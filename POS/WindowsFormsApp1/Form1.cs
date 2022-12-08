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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //MSSQL 서버 연결용 문장
        string MSsql = "Server=DESKTOP-CVCKE2N; database=POS_Stuff; uid=sa; pwd=pos15963;";
        string stuffstr;//상품명 임시 저장할 변수
        int where;//상품 버튼 번호 임시 저장
        int saleprice;//상품 가격 임시 저장
        int salecount;//상품 재고수 임시 저장(백업)
        public Form1()
        {
            InitializeComponent();
        }
        string[] stuffbarcode = new string[16];
        string[] stuffname = new string[16];
        string[] stuffprice = new string[16];
        string[] stuffmany = new string[16];
        public void SetButton(string barcode, string salename, string price, string count, int number, bool DelOrAdd)//상품 버튼에 상품 할당 메소드(부울형은 할당인지, 비할당인지를 표시)
        {
            //각 번호별로 정보를 인덱스에 할당함(버튼의 번호로 인덱스를 지정하기에 0 사용안함
            switch (number)
            {
                case 1:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[1] = barcode;
                            stuffname[1] = salename;
                            stuffprice[1] = price;
                            stuffmany[1] = count;
                            b1.Text = salename;
                        }
                        else
                        {
                            b1.Text = "";
                        }
                        break;
                    }
                case 2:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[2] = barcode;
                            stuffname[2] = salename;
                            stuffprice[2] = price;
                            stuffmany[2] = count;
                            b2.Text = salename;
                        }
                        else
                        {
                            b2.Text = "";
                        }
                        break;
                    }
                case 3:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[3] = barcode;
                            stuffname[3] = salename;
                            stuffprice[3] = price;
                            stuffmany[3] = count;
                            b3.Text = salename;
                        }
                        else
                        {
                            b3.Text = "";
                        }
                        break;
                    }
                case 4:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[4] = barcode;
                            stuffname[4] = salename;
                            stuffprice[4] = price;
                            stuffmany[4] = count;
                            b4.Text = salename;
                        }
                        else
                        {
                            b4.Text = "";
                        }
                        break;
                    }
                case 5:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[5] = barcode;
                            stuffname[5] = salename;
                            stuffprice[5] = price;
                            stuffmany[5] = count;
                            b5.Text = salename;
                        }
                        else
                        {
                            b5.Text = "";
                        }
                        break;
                    }
                case 6:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[6] = barcode;
                            stuffname[6] = salename;
                            stuffprice[6] = price;
                            stuffmany[6] = count;
                            b6.Text = salename;
                        }
                        else
                        {
                            b6.Text = "";
                        }
                        break;
                    }
                case 7:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[7] = barcode;
                            stuffname[7] = salename;
                            stuffprice[7] = price;
                            stuffmany[7] = count;
                            b7.Text = salename;
                        }
                        else
                        {
                            b7.Text = "";
                        }
                        break;
                    }
                case 8:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[8] = barcode;
                            stuffname[8] = salename;
                            stuffprice[8] = price;
                            stuffmany[8] = count;
                            b8.Text = salename;
                        }
                        else
                        {
                            b8.Text = "";
                        }
                        break;
                    }
                case 9:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[9] = barcode;
                            stuffname[9] = salename;
                            stuffprice[9] = price;
                            stuffmany[9] = count;
                            b9.Text = salename;
                        }
                        else
                        {
                            b9.Text = "";
                        }
                        break;
                    }
                case 10:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[10] = barcode;
                            stuffname[10] = salename;
                            stuffprice[10] = price;
                            stuffmany[10] = count;
                            b10.Text = salename;
                        }
                        else
                        {
                            b10.Text = "";
                        }
                        break;
                    }
                case 11:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[11] = barcode;
                            stuffname[11] = salename;
                            stuffprice[11] = price;
                            stuffmany[11] = count;
                            b11.Text = salename;
                        }
                        else
                        {
                            b11.Text = "";
                        }
                        break;
                    }
                case 12:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[12] = barcode;
                            stuffname[12] = salename;
                            stuffprice[12] = price;
                            stuffmany[12] = count;
                            b12.Text = salename;
                        }
                        else
                        {
                            b12.Text = "";
                        }
                        break;
                    }
                case 13:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[13] = barcode;
                            stuffname[13] = salename;
                            stuffprice[13] = price;
                            stuffmany[13] = count;
                            b13.Text = salename;
                        }
                        else
                        {
                            b13.Text = "";
                        }
                        break;
                    }
                case 14:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[14] = barcode;
                            stuffname[14] = salename;
                            stuffprice[14] = price;
                            stuffmany[14] = count;
                            b14.Text = salename;
                        }
                        else
                        {
                            b14.Text = "";
                        }
                        break;
                    }
                case 15:
                    {
                        if (DelOrAdd)
                        {
                            stuffbarcode[15] = barcode;
                            stuffname[15] = salename;
                            stuffprice[15] = price;
                            stuffmany[15] = count;
                            b15.Text = salename;
                        }
                        else
                        {
                            b15.Text = "";
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
            Button Stuff = sender as Button;
            if(Stuff.Text != "")
            {
                add.Enabled = true;//확인 활성화
                cancle.Enabled = true;//취소 활성화
                stuffcount.Enabled = true;//갯수 텍스트 박스 활성화
                Sale.Enabled = Stock.Enabled = Payment.Enabled = DeletePrice.Enabled = CancelSale.Enabled = false;
                stuffstr = Stuff.Text;
                where = int.Parse(Stuff.Name.Substring(1));//인덱스 추출(버튼 이름의 번호에서 추출)
                saleprice = int.Parse(stuffprice[where]);
                salecount = int.Parse(stuffmany[where]);
            }
            else MessageBox.Show("상품이 할당되어 있지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void add_Click(object sender, EventArgs e)//(확인)상품을 가격표에 등록
        {
            if (int.TryParse(stuffcount.Text, out _))
            {
                int count = int.Parse(stuffcount.Text);
                if (count > 0)
                {
                    if (int.Parse(stuffmany[where]) > count)
                    {
                        ListViewItem lvt = new ListViewItem();//리스트뷰 아이템 객체 
                        lvt.SubItems.Add(stuffstr);//서브 아이템에 넣을 데이터([1])
                        lvt.SubItems.Add((saleprice * count).ToString());//[2]
                        lvt.SubItems.Add(stuffcount.Text);//[3]
                        pricelistBox.Items.Add(lvt);//리스트뷰에 아이템(행)추가 
                        AddSalePrice((saleprice * count).ToString());
                        stuffcount.Text = "0";//작업 완료후 초기화
                        stuffmany[where] = (int.Parse(stuffmany[where])-count).ToString();//계산하기전의 재고수 빼기
                        add.Enabled = false;
                        cancle.Enabled = false;
                        stuffcount.Enabled = false;
                        Payment.Enabled = DeletePrice.Enabled = CancelSale.Enabled = true;//재고확인, 매출 확인은 계산하기 전까진 비활성화
                    }
                    else MessageBox.Show("재고수가 부족합니다.\n남은 재고수 : " + stuffmany[where], "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                MessageBox.Show("양수를 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("숫자를 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cancle_Click(object sender, EventArgs e)//(상품 계산대에서 취소)
        {
            stuffstr = "";
            saleprice = 0;
            salecount = 0;
            add.Enabled = false;
            cancle.Enabled = false;
            stuffcount.Enabled = false;
            Payment.Enabled = DeletePrice.Enabled = CancelSale.Enabled = true;
            if (pricelistBox.Items.Count == 0) Sale.Enabled = Stock.Enabled = true;//계산대가 완전히 비어버리면 재고관리, 매출 활성화
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
            if (addpricetextBox.Text != "0")
            { 
                AddSalePrice(addpricetextBox.Text);
                item.SubItems.Add("추가금액");
                item.SubItems.Add(addpricetextBox.Text);
                item.SubItems.Add("");
                pricelistBox.Items.Add(item);
                addpricetextBox.Text = "0";
                Sale.Enabled = Stock.Enabled = Payment.Enabled = DeletePrice.Enabled = CancelSale.Enabled = false;
            }
        }
        private void DeletePrice_Click(object sender, EventArgs e)
        {
            if (pricelistBox.SelectedItems.Count > 0)
            {
                int index = pricelistBox.FocusedItem.Index;
                for (int j = 1; j < 16; j++)//결재 대기의 상품명을 통해 정보 추출
                {
                    if (pricelistBox.Items[index].SubItems[1].Text == stuffname[j])//아이템의 이름이 상품명과 일치하면 재고수를 다시 되돌림
                    {
                        stuffmany[j] = (int.Parse(stuffmany[j]) + int.Parse(pricelistBox.Items[index].SubItems[3].Text)).ToString();
                    }
                }
                pricelistBox.Items.RemoveAt(index);
                if (pricelistBox.Items.Count == 0) Sale.Enabled = Stock.Enabled = true;
            }
        }

        private void CancelSale_Click(object sender, EventArgs e)//결재 취소
        {
            //결재 취소하기 전에 계산대에 올려진 상품 되돌림
            for(int i = 0; i < pricelistBox.SelectedItems.Count; i++)//리스트뷰의 아이템 수만큼 반복
            {
                for(int j = 1; j < 16; j++)//결재 대기의 상품명을 통해 정보 추출
                {
                    if (pricelistBox.Items[i].SubItems[1].Text == stuffname[j])//아이템의 상품이름이 상품명과 일치하면 재고수를 다시 되돌림
                    {
                        stuffmany[j] = (int.Parse(stuffmany[j]) + int.Parse(pricelistBox.Items[i].SubItems[3].Text)).ToString();
                    }
                }
                if (pricelistBox.Items[i].SubItems[1].Text == "추가금액") continue;//계산기로 올린 추가금액은 스킵
            }
            pricelistBox.Items.Clear();
            saletextBox.Text = "0";
            Sale.Enabled = Stock.Enabled = true;
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
             
                using (SqlConnection con = new SqlConnection(MSsql))
                {
                    SqlDataReader dr;
                    string searchquery = "SELECT * FROM Stuff WHERE Barcode LIKE '%" + barcode + "%';";                 
                    con.Open();
                    SqlCommand cmd = new SqlCommand(searchquery, con);
                    dr = cmd.ExecuteReader();
                    string name = "";
                    string price = "";
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            name = dr["Name"].ToString();
                            price = dr["Price"].ToString();
                        }
                    }
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(name);
                    lvi.SubItems.Add(price);
                    lvi.SubItems.Add("1");
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

        private void Payment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("계산되었습니다.");
            pricelistBox.Clear();
            saletextBox.Clear();
            for (int i = 1; i < 16; i++)
                SetButton("", "", "", i, true);

            //재고 정보 갱신
            //...
        }
    }
}
