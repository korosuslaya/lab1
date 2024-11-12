namespace bd
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			button1 = new Button();
			dataGridViewmenuItem = new DataGridView();
			item_id = new DataGridViewTextBoxColumn();
			restaurant_id = new DataGridViewComboBoxColumn();
			name = new DataGridViewTextBoxColumn();
			description = new DataGridViewTextBoxColumn();
			Price = new DataGridViewTextBoxColumn();
			tabPage2 = new TabPage();
			dataGridViewReport1 = new DataGridView();
			groupBox1 = new GroupBox();
			buttonGetReport1 = new Button();
			comboBoxReport1 = new ComboBox();
			label1 = new Label();
			tabPage3 = new TabPage();
			button2 = new Button();
			dataGridViewReport2 = new DataGridView();
			comboBox2 = new ComboBox();
			label2 = new Label();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewmenuItem).BeginInit();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewReport1).BeginInit();
			groupBox1.SuspendLayout();
			tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewReport2).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.AccessibleDescription = "";
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Location = new Point(12, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1127, 575);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(button1);
			tabPage1.Controls.Add(dataGridViewmenuItem);
			tabPage1.Location = new Point(4, 29);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1119, 542);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Меню";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(6, 10);
			button1.Name = "button1";
			button1.Size = new Size(185, 29);
			button1.TabIndex = 2;
			button1.Text = "Сохранить изменения";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridViewmenuItem
			// 
			dataGridViewmenuItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewmenuItem.Columns.AddRange(new DataGridViewColumn[] { item_id, restaurant_id, name, description, Price });
			dataGridViewmenuItem.Location = new Point(6, 45);
			dataGridViewmenuItem.Name = "dataGridViewmenuItem";
			dataGridViewmenuItem.RowHeadersWidth = 51;
			dataGridViewmenuItem.Size = new Size(938, 491);
			dataGridViewmenuItem.TabIndex = 1;
			// 
			// item_id
			// 
			item_id.DataPropertyName = "item_id";
			item_id.HeaderText = "id";
			item_id.MinimumWidth = 6;
			item_id.Name = "item_id";
			item_id.ReadOnly = true;
			item_id.Width = 125;
			// 
			// restaurant_id
			// 
			restaurant_id.DataPropertyName = "restaurant_id1";
			restaurant_id.HeaderText = "Ресторан";
			restaurant_id.MinimumWidth = 6;
			restaurant_id.Name = "restaurant_id";
			restaurant_id.Width = 125;
			// 
			// name
			// 
			name.DataPropertyName = "name";
			name.HeaderText = "Имя";
			name.MinimumWidth = 6;
			name.Name = "name";
			name.Width = 125;
			// 
			// description
			// 
			description.DataPropertyName = "description";
			description.HeaderText = "Описание";
			description.MinimumWidth = 6;
			description.Name = "description";
			description.Width = 125;
			// 
			// Price
			// 
			Price.DataPropertyName = "price";
			Price.HeaderText = "Цена";
			Price.MinimumWidth = 6;
			Price.Name = "Price";
			Price.Width = 125;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(dataGridViewReport1);
			tabPage2.Controls.Add(groupBox1);
			tabPage2.Location = new Point(4, 29);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1119, 542);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridViewReport1
			// 
			dataGridViewReport1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewReport1.Location = new Point(20, 107);
			dataGridViewReport1.Name = "dataGridViewReport1";
			dataGridViewReport1.RowHeadersWidth = 51;
			dataGridViewReport1.Size = new Size(1045, 380);
			dataGridViewReport1.TabIndex = 1;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(buttonGetReport1);
			groupBox1.Controls.Add(comboBoxReport1);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(20, 20);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1071, 69);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "groupBox1";
			// 
			// buttonGetReport1
			// 
			buttonGetReport1.Location = new Point(555, 33);
			buttonGetReport1.Name = "buttonGetReport1";
			buttonGetReport1.Size = new Size(122, 30);
			buttonGetReport1.TabIndex = 2;
			buttonGetReport1.Text = "Найти";
			buttonGetReport1.UseVisualStyleBackColor = true;
			buttonGetReport1.Click += buttonGetReport1_Click;
			// 
			// comboBoxReport1
			// 
			comboBoxReport1.FormattingEnabled = true;
			comboBoxReport1.Location = new Point(180, 34);
			comboBoxReport1.Name = "comboBoxReport1";
			comboBoxReport1.Size = new Size(313, 28);
			comboBoxReport1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(68, 34);
			label1.Name = "label1";
			label1.Size = new Size(73, 20);
			label1.TabIndex = 0;
			label1.Text = "Ресторан";
			label1.Click += label1_Click;
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(button2);
			tabPage3.Controls.Add(dataGridViewReport2);
			tabPage3.Controls.Add(comboBox2);
			tabPage3.Controls.Add(label2);
			tabPage3.Location = new Point(4, 29);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new Size(1119, 542);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "tabPage3";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(383, 25);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 4;
			button2.Text = "Найти";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// dataGridViewReport2
			// 
			dataGridViewReport2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewReport2.Location = new Point(19, 69);
			dataGridViewReport2.Name = "dataGridViewReport2";
			dataGridViewReport2.RowHeadersWidth = 51;
			dataGridViewReport2.Size = new Size(792, 436);
			dataGridViewReport2.TabIndex = 3;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(203, 25);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(125, 28);
			comboBox2.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(19, 28);
			label2.Name = "label2";
			label2.Size = new Size(147, 20);
			label2.TabIndex = 1;
			label2.Text = "Выберите ресторан";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1156, 608);
			Controls.Add(tabControl1);
			Name = "Form1";
			Text = "Form1";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewmenuItem).EndInit();
			tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewReport1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewReport2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private DataGridView dataGridViewmenuItem;
		private TabPage tabPage2;
		private Button button1;
		private GroupBox groupBox1;
		private Label label1;
		private Button buttonGetReport1;
		private ComboBox comboBoxReport1;
		private DataGridView dataGridViewReport1;
		private TabPage tabPage3;
		private Label label2;
		private DataGridView dataGridViewReport2;
		private ComboBox comboBox2;
		private Button button2;
		private DataGridViewTextBoxColumn item_id;
		private DataGridViewComboBoxColumn restaurant_id;
		private DataGridViewTextBoxColumn name;
		private DataGridViewTextBoxColumn description;
		private DataGridViewTextBoxColumn Price;
	}
}
