using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string Conn = "Server=localhost;Database=pos;Uid=root;Pwd=****;";
        string stuffstr;//상품명 임시 저장할 변수

        public Form1()
        {
            InitializeComponent();
        }
        public void SetButton(string salename, string price, string count, int number, bool DelOrAdd)//상품 버튼에 상품 할당 메소드, 필요시 인자 추가(부울형은 할당인지, 비할당인지를 표시)
        {
            switch (number)
            {
                case 1:
                    {
                        if (DelOrAdd)
                        {
                            button1.Text = salename;
                        }
                        else
                        {
                            button1.Text = "";
                        }
                        break;
                    }
                case 2:
                    {
                        if (DelOrAdd)
                        {
                            button2.Text = salename;
                        }
                        else
                        {
                            button2.Text = "";
                        }
                        break;
                    }
                case 3:
                    {
                        if (DelOrAdd)
                        {
                            button3.Text = salename;
                        }
                        else
                        {
                            button3.Text = "";
                        }
                        break;
                    }
                case 4:
                    {
                        if (DelOrAdd)
                        {
                            button4.Text = salename;
                        }
                        else
                        {
                            button4.Text = "";
                        }
                        break;
                    }
                case 5:
                    {
                        if (DelOrAdd)
                        {
                            button5.Text = salename;
                        }
                        else
                        {
                            button5.Text = "";
                        }
                        break;
                    }
                case 6:
                    {
                        if (DelOrAdd)
                        {
                            button6.Text = salename;
                        }
                        else
                        {
                            button6.Text = "";
                        }
                        break;
                    }
                case 7:
                    {
                        if (DelOrAdd)
                        {
                            button7.Text = salename;
                        }
                        else
                        {
                            button7.Text = "";
                        }
                        break;
                    }
                case 8:
                    {
                        if (DelOrAdd)
                        {
                            button8.Text = salename;
                        }
                        else
                        {
                            button8.Text = "";
                        }
                        break;
                    }
                case 9:
                    {
                        if (DelOrAdd)
                        {
                            button9.Text = salename;
                        }
                        else
                        {
                            button9.Text = "";
                        }
                        break;
                    }
                case 10:
                    {
                        if (DelOrAdd)
                        {
                            button10.Text = salename;
                        }
                        else
                        {
                            button10.Text = "";
                        }
                        break;
                    }
                case 11:
                    {
                        if (DelOrAdd)
                        {
                            button11.Text = salename;
                        }
                        else
                        {
                            button11.Text = "";
                        }
                        break;
                    }
                case 12:
                    {
                        if (DelOrAdd)
                        {
                            button12.Text = salename;
                        }
                        else
                        {
                            button12.Text = "";
                        }
                        break;
                    }
                case 13:
                    {
                        if (DelOrAdd)
                        {
                            button13.Text = salename;
                        }
                        else
                        {
                            button13.Text = "";
                        }
                        break;
                    }
                case 14:
                    {
                        if (DelOrAdd)
                        {
                            button14.Text = salename;
                        }
                        else
                        {
                            button14.Text = "";
                        }
                        break;
                    }
                case 15:
                    {
                        if (DelOrAdd)
                        {
                            button15.Text = salename;
                        }
                        else
                        {
                            button15.Text = "";
                        }
                        break;
                    }
                case 16:
                    {
                        if (DelOrAdd)
                        {
                            input.Text = salename;
                        }
                        else
                        {
                            input.Text = "";
                        }
                        break;
                    }
                
            }
        }
        private void AddSalePrice(string addnum)//총 결재 금액 창에 금액 추가하는 메소드
        {
            saletextBox.Text = (int.Parse(saletextBox.Text)+int.Parse(addnum)).ToString();
        }
        private void SaleStuff(object sender, EventArgs e)//상품 버튼 클릭시 이벤트 처리
        {
            Button Stuff = sender as Button;//클릭한 버튼
            add.Enabled = true;//확인 활성화
            cancle.Enabled = true;//취소 활성화
            stuffcount.Enabled = true;//갯수 텍스트 박스 활성화
            stuffstr = Stuff.Text;
        }
        private void add_Click(object sender, EventArgs e)//(확인)상품을 가격표에 등록
        {
            if (int.TryParse(stuffcount.Text, out _))
            {
                pricelistBox.Items[0].SubItems[3].Text = stuffcount.Text;//판매대기 리스트박스에 저장             
                //AddSalePrice(가격데이터); //인자로 넘겨주길 바람
                stuffcount.Text = "0";
                add.Enabled = false;
                cancle.Enabled = false;
                stuffcount.Enabled = false;
            }
            else
            {
                MessageBox.Show("숫자를 입력하시오", "err");
            }
        }
        private void cancle_Click(object sender, EventArgs e)//(취소)
        {
            stuffstr = "";
            add.Enabled = false;
            cancle.Enabled = false;
            stuffcount.Enabled = false;
        }

        private void Num(object sender, EventArgs e)//판매창의 추가 결재 금액 숫자 버튼 이벤트처리기
        {
            Button num = sender as Button;
            if (int.Parse(addpricetextBox.Text) == 0) addpricetextBox.Text = num.Text;//추가 결재 금액 텍스트 박스 = addpricetextBox
            else addpricetextBox.Text += num.Text;
        }
        private void ACbutton_Click(object sender, EventArgs e)//판매창의 AC버튼 이벤트 처리기
        {
            if (int.Parse(addpricetextBox.Text) != 0) addpricetextBox.Text = "0";
        }
        private void Addbutton_Click(object sender, EventArgs e)//판매창의 추가 결재 금액 등록 버튼 이벤트처리기
        {
            ListViewItem item = new ListViewItem();
            if (addpricetextBox.Text == "0") return;
            AddSalePrice(addpricetextBox.Text);
            item.SubItems.Add("추가금액");
            item.SubItems.Add(addpricetextBox.Text);
            item.SubItems.Add("");
            pricelistBox.Items.Add(item);
            addpricetextBox.Text = "0";
        }
        private void DeletePrice_Click(object sender, EventArgs e)
        {
            if (pricelistBox.SelectedItems.Count > 0)
            {
                int index = pricelistBox.FocusedItem.Index;
                pricelistBox.Items.RemoveAt(index);
            }
        }

        private void CancelSale_Click(object sender, EventArgs e)
        {
            pricelistBox.Items.Clear();
            saletextBox.Text = "0";
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Tag = this;
            form2.Show();
            this.Hide();
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Tag = this;
            form3.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 form2 = new Form2(this);
            Form3 form3 = new Form3();
            form2.Close();
            form3.Close();
        }

        private void input_Click(object sender, EventArgs e)
        {
            if(Barcode.Text != "")
            {
                string barcode = Barcode.Text;               
             
                using (MySqlConnection conn = new MySqlConnection(Conn))
                {
                    DataSet ds = new DataSet();
                    string sql = " select * from stuff where barcode='" + barcode + "'";
                    MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(ds, "stuff");

                    string name = ds.Tables[0].Rows[0]["name"].ToString();
                    string price = ds.Tables[0].Rows[0]["price"].ToString();

                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(name);
                    lvi.SubItems.Add(price);
                    lvi.SubItems.Add("1");
                    //pricelistBox.Items[i],SubItems[3].Text
                    pricelistBox.Items.Add(lvi);
                    SetButton(name, price, "1", 1, true);
                    AddSalePrice(price);
                              
                    for (int i = 0; i < pricelistBox.Items.Count; i++)                                       
                          SetButton(pricelistBox.Items[i].SubItems[1].Text,
                              price, "1", i + 1, true);                                                                                      
                }
                Barcode.Text = "";
            }            
        }
    }
}
