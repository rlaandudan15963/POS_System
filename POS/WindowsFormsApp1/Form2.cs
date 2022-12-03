using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string MSsql = "Server=DESKTOP-CVCKE2N; database=POS_Stuff; uid=sa; pwd=pos15963;";
        int WhatButton;
        string where;
        Form1 form1;

        public Form2(Form1 p)
        {
            InitializeComponent();
            form1 = p;
        }

        private void Form2_Shown(object sender, EventArgs e)//재고 관리 폼이 열릴때 발생할 이벤트 처리기(정확히는 보여질때)
        {
            SqlDataReader dr;
            SqlConnection con;
            con = new SqlConnection(MSsql);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Stuff", con);
            dr = cmd.ExecuteReader();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Items.Clear();
            listView1.Columns.Add("바코드", 110);
            listView1.Columns.Add("상품명", 170);
            listView1.Columns.Add("제조사", 140);
            listView1.Columns.Add("가격", 110);
            listView1.Columns.Add("개수", 90);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListViewItem lvt = new ListViewItem(dr["Barcode"].ToString());
                    lvt.SubItems.Add(dr["Name"].ToString());
                    lvt.SubItems.Add(dr["Company"].ToString());
                    lvt.SubItems.Add(dr["Price"].ToString());
                    lvt.SubItems.Add(dr["Stuff_Count"].ToString());
                    listView1.Items.Add(lvt);
                }
            }
            dr.Close();
            con.Close();
        }

        private void modie_Click(object sender, EventArgs e)//수정 버튼 이벤트
        {
            NameBox.Enabled = true;
            CompanyBox.Enabled = true;
            StocBox.Enabled = true;
            PriceBox.Enabled = true;
            BarcodeBox.Enabled = true;
            Add.Enabled = false;
            Modie.Enabled = false;
            Delete.Enabled = false;
            Yes.Enabled = true;
            No.Enabled = true;
            where = BarcodeBox.Text;
            WhatButton = 1;
        }
        private void ModiData(string key, string barcode, string name, string company, string price, string stuffcount)//데이터 수정, key는 수정할 항목을 찾을 키
        {
            SqlDataReader dr;
            SqlConnection con;
            string modiquery = "UPDATE Stuff SET Barcode = " + barcode + ", Name = '" + name + "', Company = '" + company
                + "', Price = " + price + ", Stuff_Count = " + stuffcount + " where Barcode = " + key + ";";
            con = new SqlConnection(MSsql);
            con.Open();
            SqlCommand cmd = new SqlCommand(modiquery, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select * from Stuff", con);
            dr = cmd.ExecuteReader();
            listView1.Items.Clear();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListViewItem lvt = new ListViewItem(dr["Barcode"].ToString());
                    lvt.SubItems.Add(dr["Name"].ToString());
                    lvt.SubItems.Add(dr["Company"].ToString());
                    lvt.SubItems.Add(dr["Price"].ToString());
                    lvt.SubItems.Add(dr["Stuff_Count"].ToString());
                    listView1.Items.Add(lvt);
                }
            }
            dr.Close();
            con.Close();
        }
        private void Add_Click(object sender, EventArgs e)//추가 버튼 이벤트
        {
            NameBox.Enabled = true;
            CompanyBox.Enabled = true;
            StocBox.Enabled = true;
            PriceBox.Enabled = true;
            BarcodeBox.Enabled = true;
            Modie.Enabled = false;
            Add.Enabled = false;
            Delete.Enabled = false;
            Yes.Enabled = true;
            No.Enabled = true;
            BarcodeBox.Text = NameBox.Text = CompanyBox.Text = StocBox.Text = PriceBox.Text = "";
            WhatButton = 2;
        }
        private void AddData(string barcode, string name, string company, string price, string stuffcount)//데이터베이스에 데이터 추가
        {
            SqlDataReader dr;
            SqlConnection con;
            string addquery = "insert into Stuff values('" + barcode + "', '" + name + "', '" + company + "', '" + price + "', '" + stuffcount + "');";
            con = new SqlConnection(MSsql);
            con.Open();
            SqlCommand cmd = new SqlCommand(addquery, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select * from Stuff", con);
            dr = cmd.ExecuteReader();
            listView1.Items.Clear();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListViewItem lvt = new ListViewItem(dr["Barcode"].ToString());
                    lvt.SubItems.Add(dr["Name"].ToString());
                    lvt.SubItems.Add(dr["Company"].ToString());
                    lvt.SubItems.Add(dr["Price"].ToString());
                    lvt.SubItems.Add(dr["Stuff_Count"].ToString());
                    listView1.Items.Add(lvt);
                }
            }
            dr.Close();
            con.Close();
        }
        private void Delete_Click(object sender, EventArgs e)//삭제 버튼 이벤트
        {
            Add.Enabled = false;
            Delete.Enabled=false;
            Modie.Enabled = false;
            Yes.Enabled = true;
            No.Enabled = true;
            WhatButton = 3;
            where = BarcodeBox.Text;
        }
        private void DeleteData(string key)
        {
            SqlDataReader dr;
            SqlConnection con;
            string Delquery = "DELETE FROM Stuff WHERE Barcode = " + key + ";";
            con = new SqlConnection(MSsql);
            con.Open();
            SqlCommand cmd = new SqlCommand(Delquery, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select * from Stuff", con);
            dr = cmd.ExecuteReader();
            listView1.Items.Clear();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListViewItem lvt = new ListViewItem(dr["Barcode"].ToString());
                    lvt.SubItems.Add(dr["Name"].ToString());
                    lvt.SubItems.Add(dr["Company"].ToString());
                    lvt.SubItems.Add(dr["Price"].ToString());
                    lvt.SubItems.Add(dr["Stuff_Count"].ToString());
                    listView1.Items.Add(lvt);
                }
            }
            dr.Close();
            con.Close();
        }

        private void Yes_Click(object sender, EventArgs e)//확인 버튼 이벤트
        {
            switch (WhatButton)
            {
                case 1:
                    if (Errcheck(BarcodeBox.Text, int.Parse(PriceBox.Text), int.Parse(StocBox.Text)))
                    {
                        break;
                    }
                    else
                    {
                        ModiData(where, BarcodeBox.Text, NameBox.Text, CompanyBox.Text, PriceBox.Text, StocBox.Text);
                        yesback();
                        break;
                    }    
                    
                case 2:
                    if (BarcodeBox.Text == "" || NameBox.Text == "" || PriceBox.Text == "" || StocBox.Text == "")
                        MessageBox.Show("내용을 기입해 주십시오\n");
                    else
                    {
                        AddData(BarcodeBox.Text, NameBox.Text, CompanyBox.Text, PriceBox.Text, StocBox.Text);
                        yesback();
                    }
                    break;
                case 3:
                    DeleteData(where);
                    yesback();
                    break;
            }
           
        }
        private void yesback()//초기세팅 복귀
        { 
            NameBox.Enabled = false;
            CompanyBox.Enabled = false;
            StocBox.Enabled = false;
            PriceBox.Enabled = false;
            BarcodeBox.Enabled = false;
            Modie.Enabled= false;
            Add.Enabled = true;
            Delete.Enabled = false;
            Yes.Enabled = false;
            No.Enabled = false;
            BarcodeBox.Text = NameBox.Text = CompanyBox.Text = StocBox.Text = PriceBox.Text = "";
            where = "";
        }

        private void No_Click(object sender, EventArgs e)//취소 버튼 이벤트
        {
            NameBox.Enabled = false;
            CompanyBox.Enabled = false;
            StocBox.Enabled = false;
            PriceBox.Enabled = false;
            BarcodeBox.Enabled = false;
            Modie.Enabled = false;
            Add.Enabled = true;
            Delete.Enabled = false;
            Yes.Enabled = false;
            No.Enabled = false;
            BarcodeBox.Text = NameBox.Text = CompanyBox.Text = StocBox.Text = PriceBox.Text = "";
            where = "";
        }
        private void AddInButton_Click(object sender, EventArgs e)//상품 판매 버튼에 할당하는 이벤트
        {
            if(listView1.SelectedIndices.Count != 0)
            {
                string name = listView1.Items[listView1.FocusedItem.Index].SubItems[1].ToString();
                string price = listView1.Items[listView1.FocusedItem.Index].SubItems[3].ToString();
                string count = listView1.Items[listView1.FocusedItem.Index].SubItems[4].ToString();
                int number = int.Parse(comboBox1.SelectedItem.ToString());
                form1.SetButton(name, price, count, number, true);
            }
        }
        private void NotSaleButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(comboBox1.SelectedItem.ToString()) > 0)
            {
                form1.SetButton("","","", int.Parse(comboBox1.SelectedItem.ToString()), false);
            }
        }
        private void SaleStuff_Click(object sender, EventArgs e)//뒤로가기 버튼
        {
            var f1 = (Form1)(this.Tag);
            f1.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)//닫을때 완전히 다 닫기
        {
            var f1 = (Form1)this.Tag;
            Form3 form3 = new Form3();
            f1.Close();
            form3.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)//리스트뷰 항목 선택(더블클릭)
        {
            Modie.Enabled = true;
            Delete.Enabled = true;
            if(listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem lvitem = items[0];
                BarcodeBox.Text = lvitem.SubItems[0].Text;
                NameBox.Text = lvitem.SubItems[1].Text;
                CompanyBox.Text = lvitem.SubItems[2].Text;
                PriceBox.Text = lvitem.SubItems[3].Text;
                StocBox.Text = lvitem.SubItems[4].Text;
            }
        }
        private bool Errcheck(string barcode, int price, int stuffcount)
        {       
            if (BarcodeBox.Text == "" || NameBox.Text == "" || PriceBox.Text == "" || StocBox.Text == "")
            {
                MessageBox.Show("내용을 기입해 주십시오", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if(listView1.FindItemWithText(barcode, false, 0) != null)
            {
                MessageBox.Show("바코드가 중복되었습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if (price < 0)
            { 
                MessageBox.Show("가격을 잘못 입력하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if (stuffcount < 0)
            {
                MessageBox.Show("재고 수를 잘못 입력하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else return false;
        }

        private void Search_Click(object sender, EventArgs e)//검색 기능
        {
            string barcode = SearchBar.Text;
            if(barcode == "")
            {
                SqlDataReader dr;
                SqlConnection con;
                con = new SqlConnection(MSsql);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Stuff", con);
                dr = cmd.ExecuteReader();
                listView1.Items.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem lvt = new ListViewItem(dr["Barcode"].ToString());
                        lvt.SubItems.Add(dr["Name"].ToString());
                        lvt.SubItems.Add(dr["Company"].ToString());
                        lvt.SubItems.Add(dr["Price"].ToString());
                        lvt.SubItems.Add(dr["Stuff_Count"].ToString());
                        listView1.Items.Add(lvt);
                    }
                }
                dr.Close();
                con.Close();
            }
            else
            {
                SqlDataReader dr;
                SqlConnection con;
                string searchquery = "SELECT * FROM Stuff WHERE Barcode LIKE '%" + barcode + "%';";
                con = new SqlConnection(MSsql);
                con.Open();
                SqlCommand cmd = new SqlCommand(searchquery, con);
                dr = cmd.ExecuteReader();
                listView1.Items.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem lvt = new ListViewItem(dr["Barcode"].ToString());
                        lvt.SubItems.Add(dr["Name"].ToString());
                        lvt.SubItems.Add(dr["Company"].ToString());
                        lvt.SubItems.Add(dr["Price"].ToString());
                        lvt.SubItems.Add(dr["Stuff_Count"].ToString());
                        listView1.Items.Add(lvt);
                    }
                }
                dr.Close();
                con.Close();
            }
        }
    }
}
