using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string stuffstr;//상품명 임시 저장할 변수
        public Form1()
        {
            InitializeComponent();
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
                pricelistBox.Items.Add($"{stuffstr}\t\t[가격데이터]\t\t{stuffcount.Text}");//판매대기 리스트박스에 저장
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
            if (addpricetextBox.Text == "0") return;
            AddSalePrice(addpricetextBox.Text);
            pricelistBox.Items.Add("추가금액\t\t\t" + addpricetextBox.Text);//결재할 상품 목록 리스트박스 = pricelistBox
            addpricetextBox.Text = "0";
        }
        private void DeletePrice_Click(object sender, EventArgs e)
        {
            if (pricelistBox.SelectedIndex > -1) pricelistBox.Items.RemoveAt(pricelistBox.SelectedIndex);
        }

        private void CancelSale_Click(object sender, EventArgs e)
        {
            pricelistBox.Items.Clear();
            saletextBox.Text = "0";
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
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

        
    }
}
