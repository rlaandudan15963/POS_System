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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Shown(object sender, EventArgs e)//매출관리 보여질때 이벤트
        {
            DayChart.Show();
            WeekChart.Hide();
            MonthChart.Hide();
        }
        private void SaleStuff_Click(object sender, EventArgs e)//뒤로가기 버튼 클릭
        {
            var f1 = (Form1)(this.Tag);
            f1.Show();
            this.Hide();
        }

        private void DaySales_Click(object sender, EventArgs e)//일 매출 확인 클릭(차트를 보여줄것만 보여주고 나머진 숨기는 식으로 진행)
        {
            DayChart.Show();
            WeekChart.Hide();
            MonthChart.Hide();
        }

        private void WeekSale_Click(object sender, EventArgs e)//주 매출 확인 클릭
        {
            DayChart.Hide();
            WeekChart.Show();
            MonthChart.Hide();
        }

        private void MonthSale_Click(object sender, EventArgs e)//월 매출 클릭
        {
            DayChart.Hide();
            WeekChart.Hide();
            MonthChart.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            var f1 = (Form1)this.Tag;
            Form2 form2 = new Form2(f1);
            f1.Close();
            form2.Close();
        }
    }
}
