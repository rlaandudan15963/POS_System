namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StocBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.Modie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BarcodeBox = new System.Windows.Forms.TextBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.SaleStuff = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddInButton = new System.Windows.Forms.Button();
            this.NotSaleButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Font = new System.Drawing.Font("굴림", 12F);
            this.NameBox.Location = new System.Drawing.Point(80, 26);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(262, 26);
            this.NameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "상품명 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "제조사 :";
            // 
            // CompanyBox
            // 
            this.CompanyBox.Enabled = false;
            this.CompanyBox.Font = new System.Drawing.Font("굴림", 12F);
            this.CompanyBox.Location = new System.Drawing.Point(80, 70);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(262, 26);
            this.CompanyBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(376, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "재고 :";
            // 
            // StocBox
            // 
            this.StocBox.Enabled = false;
            this.StocBox.Font = new System.Drawing.Font("굴림", 12F);
            this.StocBox.Location = new System.Drawing.Point(431, 29);
            this.StocBox.Name = "StocBox";
            this.StocBox.Size = new System.Drawing.Size(147, 26);
            this.StocBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(376, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "금액 :";
            // 
            // PriceBox
            // 
            this.PriceBox.Enabled = false;
            this.PriceBox.Font = new System.Drawing.Font("굴림", 12F);
            this.PriceBox.Location = new System.Drawing.Point(431, 73);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(147, 26);
            this.PriceBox.TabIndex = 7;
            // 
            // Modie
            // 
            this.Modie.Enabled = false;
            this.Modie.Location = new System.Drawing.Point(634, 12);
            this.Modie.Name = "Modie";
            this.Modie.Size = new System.Drawing.Size(75, 23);
            this.Modie.TabIndex = 9;
            this.Modie.Text = "수정";
            this.Modie.UseVisualStyleBackColor = true;
            this.Modie.Click += new System.EventHandler(this.modie_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "바코드 :";
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.Enabled = false;
            this.BarcodeBox.Font = new System.Drawing.Font("굴림", 12F);
            this.BarcodeBox.Location = new System.Drawing.Point(80, 113);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(262, 26);
            this.BarcodeBox.TabIndex = 10;
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("굴림", 12F);
            this.SearchBar.Location = new System.Drawing.Point(107, 158);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(435, 26);
            this.SearchBar.TabIndex = 12;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("굴림", 12F);
            this.Search.Location = new System.Drawing.Point(556, 161);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(68, 23);
            this.Search.TabIndex = 13;
            this.Search.Text = "검색";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(634, 55);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 14;
            this.Add.Text = "추가";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(634, 95);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "삭제";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Yes
            // 
            this.Yes.Enabled = false;
            this.Yes.Location = new System.Drawing.Point(729, 54);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(75, 23);
            this.Yes.TabIndex = 16;
            this.Yes.Text = "확인";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.Enabled = false;
            this.No.Location = new System.Drawing.Point(729, 98);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(75, 23);
            this.No.TabIndex = 17;
            this.No.Text = "취소";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // SaleStuff
            // 
            this.SaleStuff.Location = new System.Drawing.Point(647, 357);
            this.SaleStuff.Name = "SaleStuff";
            this.SaleStuff.Size = new System.Drawing.Size(157, 28);
            this.SaleStuff.TabIndex = 90;
            this.SaleStuff.Text = "뒤로가기";
            this.SaleStuff.UseVisualStyleBackColor = true;
            this.SaleStuff.Click += new System.EventHandler(this.SaleStuff_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 248);
            this.listView1.TabIndex = 91;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(712, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 24);
            this.comboBox1.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F);
            this.label6.Location = new System.Drawing.Point(630, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 94;
            this.label6.Text = "상품 번호";
            // 
            // AddInButton
            // 
            this.AddInButton.Location = new System.Drawing.Point(663, 246);
            this.AddInButton.Name = "AddInButton";
            this.AddInButton.Size = new System.Drawing.Size(123, 23);
            this.AddInButton.TabIndex = 95;
            this.AddInButton.Text = "상품 버튼에 할당";
            this.AddInButton.UseVisualStyleBackColor = true;
            this.AddInButton.Click += new System.EventHandler(this.AddInButton_Click);
            // 
            // NotSaleButton
            // 
            this.NotSaleButton.Location = new System.Drawing.Point(663, 275);
            this.NotSaleButton.Name = "NotSaleButton";
            this.NotSaleButton.Size = new System.Drawing.Size(123, 23);
            this.NotSaleButton.TabIndex = 93;
            this.NotSaleButton.Text = "비할당";
            this.NotSaleButton.UseVisualStyleBackColor = true;
            this.NotSaleButton.Click += new System.EventHandler(this.NotSaleButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F);
            this.label7.Location = new System.Drawing.Point(9, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "바코드 검색";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddInButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NotSaleButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SaleStuff);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BarcodeBox);
            this.Controls.Add(this.Modie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StocBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompanyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Name = "Form2";
            this.Text = "POS_Stock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CompanyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StocBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Button Modie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BarcodeBox;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button SaleStuff;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddInButton;
        private System.Windows.Forms.Button NotSaleButton;
        private System.Windows.Forms.Label label7;
    }
}