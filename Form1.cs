using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace bd
{
	public partial class Form1 : Form
	{
		private string connectionString;

		#region ������� NpgsqlDataAdapter
		private NpgsqlDataAdapter menuItemAdapter;
		private NpgsqlDataAdapter restaurantAdapter;
		#endregion

		#region ������� NpgsqlCommandBuilder
		private NpgsqlCommandBuilder menuItemBuilder;
		private NpgsqlCommandBuilder restaurantBuilder;
		#endregion

		private DataSet dataSet = new DataSet();

		public Form1()
		{
			InitializeComponent();
			connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PostgreSqlConnection"].ConnectionString;

			menuItemAdapter = new NpgsqlDataAdapter("SELECT * FROM menu_item", connectionString);
			restaurantAdapter = new NpgsqlDataAdapter("SELECT * FROM restaurant", connectionString);
			restaurantBuilder = new NpgsqlCommandBuilder(restaurantAdapter);

			// �������������� ��������� ������ SQL ��� ���������� ������
			menuItemBuilder = new NpgsqlCommandBuilder(menuItemAdapter);

			// ��������� ������� �������
			menuItemAdapter.Fill(dataSet, "menu_item");
			restaurantAdapter.Fill(dataSet, "restaurant");

			// ����������� ������ � DataGridView
			dataGridViewmenuItem.DataSource = dataSet.Tables["menu_item"];

			// ��������� ComboBox ��� ����������
			FillRestaurantComboBox();
			FillReport1Combobox();
			FillReport2Combobox();
		}


		// ����� ��� ���������� ComboBox �����������
		private void FillRestaurantComboBox()
		{
			((DataGridViewComboBoxColumn)dataGridViewmenuItem.Columns["restaurant_id"]).DataSource =
				dataSet.Tables["restaurant"];
			((DataGridViewComboBoxColumn)dataGridViewmenuItem.Columns["restaurant_id"]).DisplayMember =
				"restaurant_name";
			((DataGridViewComboBoxColumn)dataGridViewmenuItem.Columns["restaurant_id"]).ValueMember =
				"restaurant_id";
		}
		private void FillReport1Combobox()
		{
			using (var sqlConnection = new NpgsqlConnection(connectionString))
			{
				NpgsqlDataAdapter sqlAdapter = new NpgsqlDataAdapter("select * from restaurant", sqlConnection);

				// ���������� dataSet ������� �� sqlAdapter.
				DataSet dataSet = new DataSet();
				sqlAdapter.Fill(dataSet, "restaurant");

				// ���������� ���������� cbSupplier � �������� suppliers �� dataSet.
				comboBoxReport1.DataSource = dataSet.Tables["restaurant"];
				comboBoxReport1.DisplayMember = "restaurant_name";
				comboBoxReport1.ValueMember = "restaurant_id";
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			// ���������� ��������� � ������� menu_item
			menuItemAdapter.Update(dataSet, "menu_item");
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void buttonGetReport1_Click(object sender, EventArgs e)
		{
			using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
			{
				sqlConnection.Open();
				NpgsqlCommand sqlCommand = new NpgsqlCommand(
					"SELECT r.restaurant_name, rv.content, rv.rating, res.date, res.time, res.persons " +
					"FROM review rv " +
					"JOIN reservation res ON rv.user_id = res.user_id " +
					"JOIN restaurant r ON res.restaurant_id = r.restaurant_id " +
					"WHERE rv.rating > 4.0 " +
					"AND res.restaurant_id = @SelectedRestaurantId",
					sqlConnection);

				// ��������� �������� ��� ���������� ���������
				sqlCommand.Parameters.AddWithValue("@SelectedRestaurantId", comboBoxReport1.SelectedValue);

				NpgsqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				DataTable dataTable = new DataTable("report1");
				dataTable.Columns.Add("Restaurant");
				dataTable.Columns.Add("Review Content");
				dataTable.Columns.Add("Rating");
				dataTable.Columns.Add("Reservation Date");
				dataTable.Columns.Add("Reservation Time");
				dataTable.Columns.Add("Number of Persons");

				while (sqlDataReader.Read())
				{
					DataRow row = dataTable.NewRow();
					row["Restaurant"] = sqlDataReader["restaurant_name"];
					row["Review Content"] = sqlDataReader["content"];
					row["Rating"] = sqlDataReader["rating"];
					row["Reservation Date"] = sqlDataReader["date"];
					row["Reservation Time"] = sqlDataReader["time"];
					row["Number of Persons"] = sqlDataReader["persons"];
					dataTable.Rows.Add(row);
				}

				sqlDataReader.Close();
				dataGridViewReport1.DataSource = dataTable;
			}
		}
		private void FillReport2Combobox()
		{
			using (var sqlConnection = new NpgsqlConnection(connectionString))
			{
				NpgsqlDataAdapter sqlAdapter = new NpgsqlDataAdapter("select * from restaurant", sqlConnection);

				// ���������� dataSet ������� �� sqlAdapter.
				DataSet dataSet = new DataSet();
				sqlAdapter.Fill(dataSet, "restaurant");

				// ���������� ���������� cbSupplier � �������� suppliers �� dataSet.
				comboBox2.DataSource = dataSet.Tables["restaurant"];
				comboBox2.DisplayMember = "restaurant_name";
				comboBox2.ValueMember = "restaurant_id";	
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
			{
				// ������ � �������� ������� get_menu_by_restaurant($1)
				NpgsqlCommand sqlCommand = new NpgsqlCommand("SELECT * FROM get_menu_by_restaurant(@restaurant_id)", sqlConnection);

				// �������� �������� restaurant_id �� ComboBox
				sqlCommand.Parameters.AddWithValue("@restaurant_id", (int)comboBox2.SelectedValue);

				sqlConnection.Open();

				// ������� ������� ��� ������
				DataTable dataTable = new DataTable("report2");
				var sqlAdapter = new NpgsqlDataAdapter(sqlCommand);

				// ��������� ������� �������
				sqlAdapter.Fill(dataTable);

				// ����������� ������ � DataGridView ��� �����������
				dataGridViewReport2.DataSource = dataTable;
			}
		}

		
	}


}
