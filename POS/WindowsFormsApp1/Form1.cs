using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //MSSQL 서버 연결용 문장
        string MSsql = "Server=192.168.0.2; database=POS_Stuff; uid=sa; pwd=pos15963; ";
        //아래 5개의 변수는 계산대에 추가할 상품의 정보를 임시로 저장해 리스트뷰에 넣는데 활용
        string stuffstr;//상품명 임시 저장할 변수
        int where;//상품 버튼 번호 임시 저장
        string salebarcode;//상품 바코드 임시 저장
        int saleprice;//상품 가격 임시 저장
        int salecount;//상품 재고수 임시 저장(백업)

        public Form1()
        {
            InitializeComponent();
        }
        //각 버튼별로 할당된 상품의 정보(인덱스 0은 사용안함)
        public string[] stuffbarcode = new string[16];
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
        private void Form1_Load(object sender, EventArgs e)//상품 버튼의 바코드 정보 초기화
        {
            for (int i = 1; i < 16; i++) stuffbarcode[i] = "";
        }
        private void Form1_Shown(object sender, EventArgs e)//재고관리에서 재고를 채워올 경우 버튼에 할당된 상품에 적용하는 과정
        {
            SqlConnection con = new SqlConnection(MSsql);//MSsql 서버 연결
            con.Open();//DB열기
            string getcount;//데이터를 가져올 명령어 문자열
            SqlCommand cmd;//MSsql에 명령어를 실행시키는 기능
            SqlDataReader dr;//데이터테이블에서 읽어오는 기능
            for (int i = 1; i < 16; i++)
            {
                if (stuffbarcode[i] != "")//상품버튼에 상품이 할당된 경우
                {
                    getcount = "select * From Stuff where Barcode = " + stuffbarcode[i] + ";";//바코드로 해당 상품의 정보를 가져오는 명령어
                    cmd = new SqlCommand(getcount, con);//값 가져오는 명령어 접수
                    dr = cmd.ExecuteReader();
                    if (dr.Read()) stuffmany[i] = dr["Stuff_Count"].ToString();//재고수 갱신
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
                Sale.Enabled = Stock.Enabled = Payment.Enabled = DeletePrice.Enabled = CancelSale.Enabled = false;//화면 전환및 결재 버튼 비활성화
                //결재할 상품 정보 저장
                stuffstr = Stuff.Text;
                string number = Stuff.Name.Substring(1);
                where = int.Parse(number);//인덱스 추출(버튼 이름의 번호에서 추출)
                saleprice = int.Parse(stuffprice[where]);
                salecount = int.Parse(stuffmany[where]);
                salebarcode = stuffbarcode[where];
            }
            else MessageBox.Show("상품이 할당되어 있지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void add_Click(object sender, EventArgs e)//(확인)상품을 가격표에 등록
        {
            if (int.TryParse(stuffcount.Text, out _))//문자열이 정수로 변환 가능한지 체크
            {
                int count = int.Parse(stuffcount.Text);
                if (count > 0)
                {
                    if (salecount >= count & where > 0)//상품 버튼으로 결재창에 들록함
                    {
                        ListViewItem lvt = new ListViewItem(salebarcode);//리스트뷰 아이템 객체 ([0]에 바코드 삽입, 눈에는 안보임)
                        lvt.SubItems.Add(stuffstr);//서브 아이템에 넣을 데이터([1])
                        lvt.SubItems.Add((saleprice * count).ToString());//[2]
                        lvt.SubItems.Add(stuffcount.Text);//[3]
                        pricelistBox.Items.Add(lvt);//리스트뷰에 아이템(행)추가 
                        AddSalePrice((saleprice * count).ToString());
                        stuffcount.Text = "0";//작업 완료후 초기화
                        stuffmany[where] = (int.Parse(stuffmany[where])-count).ToString();//계산하기전의 재고수 빼기(where = 0이면 바코드로 등록한 상품임)
                        add.Enabled = false;
                        cancle.Enabled = false;
                        stuffcount.Enabled = false;
                        Payment.Enabled = DeletePrice.Enabled = CancelSale.Enabled = true;//재고확인, 매출 확인은 계산하기 전까진 비활성화
                    }
                    else if(where == 0)//바코드로 상품 등록한 경우
                    {
                        //아래 과정은 재고수를 넘기는지 검사하는 코드
                        int countcheck = 0;//대기창에 있는 결재할 총 개수
                        for(int i = 0; i < pricelistBox.Items.Count; i++)
                        {
                            //결재대기창에 올린 상품과 같은 바코드가 있다면 해당 개수를 가져와서 countcheck에 더한다
                            if (pricelistBox.Items[i].SubItems[0].Text == salebarcode) countcheck += int.Parse(pricelistBox.Items[i].SubItems[3].Text);
                        }
                        if(salecount >= (countcheck + count))//재고수를 넘기는지 검사
                        {
                            ListViewItem lvt = new ListViewItem(salebarcode);//리스트뷰 아이템 객체 ([0]에 바코드 삽입, 눈에는 안보임)
                            lvt.SubItems.Add(stuffstr);//서브 아이템에 넣을 데이터([1])
                            lvt.SubItems.Add((saleprice * count).ToString());//[2]
                            lvt.SubItems.Add(stuffcount.Text);//[3]
                            pricelistBox.Items.Add(lvt);//리스트뷰에 아이템(행)추가 
                            AddSalePrice((saleprice * count).ToString());
                            stuffcount.Text = "0";//작업 완료후 초기화
                            add.Enabled = false;
                            cancle.Enabled = false;
                            stuffcount.Enabled = false;
                            Payment.Enabled = DeletePrice.Enabled = CancelSale.Enabled = true;//재고확인, 매출 확인은 계산하기 전까진 비활성화
                        }
                        //예외처리
                        else MessageBox.Show("재고수가 부족합니다.\n남은 재고수 : " + (salecount - countcheck).ToString(), "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    //예외처리
                    else MessageBox.Show("재고수가 부족합니다.\n남은 재고수 : " + stuffmany[where], "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else MessageBox.Show("0보다 큰수를 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("숫자를 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void cancle_Click(object sender, EventArgs e)//(상품 계산대에서 취소)
        {
            //임시저장한 정보 및 버튼 활성화 상태 초기화
            stuffstr = "";
            saleprice = 0;
            salecount = 0;
            salebarcode = "";
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
            ListViewItem item = new ListViewItem();//바코드는 없음
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
        private void Payment_Click_1(object sender, EventArgs e)//계산대 상품들 결재
        {
            SqlConnection con = new SqlConnection(MSsql);//MSsql 서버를 위의 연결용 문자열로 프로그램과 연결함
            con.Open();//DB열기
            string getcount;//데이터를 가져올 명령어 문자열
            SqlCommand cmd;//MSsql에 명령어를 실행시키는 기능
            SqlDataReader dr;//데이터테이블에서 읽어오는 기능
            string salequery;//MSsql 데이터베이스에 쓰일 업데이트 명령어 문자열
            string getin = "";//가져온 재고수 임시 저장 -> (3)에 쓰임 [가독성을 위해 맨 위의 임시저장 변수와 별개로 생성함]
            DateTime today = DateTime.Now;//오늘 날짜
            string todaysale = "";//금일 매출
            if(pricelistBox.Items.Count == 0) MessageBox.Show("계산할 상품이 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//예외처리(계산할 상품이 없을때)
            else
            {
                for (int i = 0; i < pricelistBox.Items.Count; i++)//리스트뷰의 아이템 수만큼 반복
                {
                    int Findidx = Array.IndexOf(stuffbarcode, pricelistBox.Items[i].SubItems[0].Text);//배열에 해당되는 바코드가 있으면 해당 인덱스를 가져옴, 없으면 -1
                    if (Findidx > -1)//버튼에 할당된 상품들중 하나일 경우(1)
                    {
                        //Update = 수정할 테이블, Set = 수정할 컬럼의 값, where = 정보를 가져올 조건(특정 컬럼값, 특정 범위 등등..)
                        salequery = "UPDATE Stuff SET Stuff_Count = " + stuffmany[Findidx] + " where Barcode = " + stuffbarcode[Findidx] + ";";//해당 상품의 재고를 업데이트함(바코드를 키로 사용)
                        cmd = new SqlCommand(salequery, con);//위의 업데이트 명령어 접수
                       cmd.ExecuteNonQuery();//명령어 실행
                    }
                    else if (pricelistBox.Items[i].SubItems[1].Text == "추가결제") continue;//따로 추가한 추가결재 금액이면 해당 반복은 스킵함(2)
                    else if(Findidx == -1)//버튼기입이 아닌 바코드로 상품 등록한 경우(위의 버튼별 정보 리스트에 해당되지 않는 경우) (3)
                    {
                        //select = 호출할 컬럼(* = 컬럼 전부), From = 호출
                        getcount = "select Stuff_Count From Stuff where Barcode = " + pricelistBox.Items[i].SubItems[0].Text + ";";//바코드로 해당 상품의 재고수를 가져오는 명령어
                        cmd = new SqlCommand(getcount, con);//값 가져오는 명령어 접수
                        dr = cmd.ExecuteReader();//위의 명령어를 읽기 기능으로 실행
                        if(dr.Read()) getin = dr["Stuff_Count"].ToString();//아까의 조건으로 읽어온 정보 저장
                        dr.Close();
                        getin = (int.Parse(getin) - int.Parse(pricelistBox.Items[i].SubItems[3].Text)).ToString();//계산한 만큼 재고수에서 빼기
                        salequery = "UPDATE Stuff SET Stuff_Count = " + getin + " where Barcode = " + pricelistBox.Items[i].SubItems[0].Text + ";";//재고수 업데이트
                        cmd = new SqlCommand(salequery, con);//위의 업데이트 명령어 접수
                        cmd.ExecuteNonQuery();//명령어 실행
                    }
                    else MessageBox.Show("해당 상품을 처리하는데 오류가 발생하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//예외처리
                }
                getcount = "select * From sale where SaleDate = '" + today.Year + "-" + today.Month + "-" + today.Day + "';";//매출 데이터베이스에서 금일 매출 가져오는 명령어
                cmd = new SqlCommand(getcount, con);
                dr = cmd.ExecuteReader();//읽기로 실행
                if (dr.Read())//금일매출데이터가 있으면 업데이트
                {
                    todaysale = (int.Parse(dr["Day_sale"].ToString()) + int.Parse(saletextBox.Text)).ToString();//가져온 금일 매출에 계산한 가격총합을 더함
                    dr.Close();
                    salequery = "UPDATE sale SET Day_sale = " +todaysale+ " where SaleDate = '" + today.Year + "-" + today.Month + "-" + today.Day + "';";//업데이트 명령어
                    cmd = new SqlCommand(salequery, con);//위의 업데이트 명령어 접수
                    cmd.ExecuteNonQuery();//명령어 실행
                }
                else//금일 첫 게산이면
                {
                    dr.Close();
                    salequery = "Insert Into dbo.sale (SaleDate, Day_sale) Values('" + today.Year + "-" + today.Month + "-" + today.Day + "', "+saletextBox.Text+");";//계산한 내용 추가
                    cmd = new SqlCommand(salequery, con);
                    cmd.ExecuteNonQuery();//명령어 실행
                }
            }
            con.Close();//데이터베이스 닫기
            pricelistBox.Items.Clear();
            saletextBox.Text = "0";
            Sale.Enabled = Stock.Enabled = true;
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
                saletextBox.Text = (int.Parse(saletextBox.Text) - int.Parse(pricelistBox.Items[index].SubItems[2].Text)).ToString();
                pricelistBox.Items.RemoveAt(index);//선택된 결재 대기 상품 제거
                if (pricelistBox.Items.Count == 0) Sale.Enabled = Stock.Enabled = true;//만일 제거해서 결재창이 비었다면 화면전환 활성화
            }
        }

        private void CancelSale_Click(object sender, EventArgs e)//결재 취소
        {
            //결재 취소하기 전에 계산대에 올려진 상품개수를 재고수에 되돌림(버튼에 할당된 상품의 경우만 실행, 나머지는 스킵)
            for(int i = 0; i < pricelistBox.Items.Count; i++)//리스트뷰의 아이템 수만큼 반복
            {
                int idx = Array.IndexOf(stuffbarcode, pricelistBox.Items[i].SubItems[0].Text);//바코드로 버튼에 할당된 상품이 있는지 확인, 확인후 있다면 인덱스를 가져옴
                if (idx > -1)//버튼에 할당된 상품인 경우
                {
                    stuffmany[idx] = (int.Parse(stuffmany[idx]) + int.Parse(pricelistBox.Items[i].SubItems[3].Text)).ToString();//재고수 되돌림
                }
                else continue;//아닌 경우 스킵
            }
            pricelistBox.Items.Clear();//결재 대기창 비움
            saletextBox.Text = "0";//총 결재액 초기화
            Sale.Enabled = Stock.Enabled = true;//화면전환 활성화
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
        //바코드 입력창에 바코드 입력시 해당 바코드의 상품을 결재하는 기능으로 변경함(버튼에 상품 할당 기능은 재고 관리 기능에 있음)
        private void input_Click(object sender, EventArgs e)
        {
            if(Barcode.Text != "")
            {
                SqlConnection con = new SqlConnection(MSsql);//MSsql 서버 연결
                con.Open();//DB열기
                string getcount;//데이터를 가져올 명령어 문자열
                SqlCommand cmd;//MSsql에 명령어를 실행시키는 기능
                SqlDataReader dr;//데이터테이블에서 읽어오는 기능
                string salequery;//MSsql 데이터베이스에 쓰일 업데이트 명령어 문자열
                getcount = "select * From Stuff where Barcode = " + Barcode.Text + ";";//바코드로 해당 상품의 정보를 가져오는 명령어
                cmd = new SqlCommand(getcount, con);//값 가져오는 명령어 접수
                dr = cmd.ExecuteReader();//위의 명령어를 읽기 기능으로 실행
                if (dr.Read())//읽어오는데 성공
                {
                    salebarcode = dr["Barcode"].ToString();
                    stuffstr = dr["Name"].ToString();
                    saleprice = int.Parse(dr["Price"].ToString());
                    salecount = int.Parse(dr["Stuff_Count"].ToString());
                    add.Enabled = true;//확인 활성화
                    cancle.Enabled = true;//취소 활성화
                    stuffcount.Enabled = true;//갯수 텍스트 박스 활성화
                    where = 0;//바코드로 상품을 결재창에 올림을 알림
                    Sale.Enabled = Stock.Enabled = Payment.Enabled = DeletePrice.Enabled = CancelSale.Enabled = false;
                }
                else MessageBox.Show("등록된 상품이 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
            }            
        }
    }
}
