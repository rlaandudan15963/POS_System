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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DateTime day = new DateTime();
        int nowyear;
        int nowmonth, monthdays;
        int nowday;
        int todaysale, weeksale, monthsale, yearsale = 0;//금일 및 평균 매출 변수
        int yearcount ,monthcount ,weekcount = 0;//결재 내역이 있는 날만 카운트해서 평균에 사용
        int[] eachday = new int[32];
        int[] eachmonth = new int[13];
        string MSsql = "Server=192.168.0.2; database=POS_Stuff; uid=sa; pwd=pos15963;";
        private void Form3_Shown(object sender, EventArgs e)//매출관리 보여질때 이벤트
        {
            DayChart.Show();
            MonthChart.Hide();
            for(int i = 1; i <= 31; i++)
            {
                eachday[i] = 0;
            }
            for(int i = 1; i <= 12; i++)
            {
                eachmonth[i] = 0;
            }
            day = DateTime.Now;
            nowday = day.Day;
            nowmonth = day.Month;
            nowyear = day.Year;
            monthdays = DateTime.DaysInMonth(day.Year, day.Month);
            ;//월 평균값 구하기 위한 일 갯수
            SqlDataReader dr;
            SqlConnection con;
            con = new SqlConnection(MSsql);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Sale where convert(char(8), SaleDate, 112)  between "
                + nowyear.ToString() + "0101 and "+ nowyear.ToString()+"1231;", con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    day = (DateTime)dr["SaleDate"];
                    yearsale += int.Parse(dr["Day_sale"].ToString());
                    eachmonth[day.Month] += int.Parse(dr["Day_sale"].ToString());
                    yearcount += 1;
                    if (day.Month == nowmonth)
                    {
                        monthsale += int.Parse(dr["Day_sale"].ToString());
                        eachday[day.Day] = int.Parse(dr["Day_sale"].ToString());
                        monthcount += 1;
                        if (day.Day > nowday-4 | day.Day < nowday + 4)
                        {
                            weeksale += int.Parse(dr["Day_sale"].ToString());
                            weekcount += 1;
                            if(day.Day == nowday)
                            {
                                todaysale = int.Parse(dr["Day_sale"].ToString());
                            }
                        }
                    }
                }
            }
            TodaySale.Text = todaysale.ToString();
            if (weeksale == 0) WeekMean.Text = "0";
            else WeekMean.Text = ((int)weeksale/weekcount).ToString();//매출에서 소숫값은 버리고 출력
            if (monthsale == 0) MonthMean.Text = "0";
            else MonthMean.Text = ((int)monthsale/monthcount).ToString();
            if(yearcount == 0) YearMean.Text = "0";
            else YearMean.Text = ((int)yearsale/yearcount).ToString();
            DayChart.Series["일매출"].Points.Clear();
            DayChart.Titles.Clear();
            DayChart.Titles.Add(nowmonth.ToString() + "월 일매출");
            MonthChart.Series["월매출"].Points.Clear();
            MonthChart.Titles.Clear();
            MonthChart.Titles.Add(nowyear.ToString() + "년도 월매출");
            for(int i = 1; i <= monthdays; i++)
            {
                DayChart.Series["일매출"].Points.Add(eachday[i]);
            }
            for(int i = 1; i < 13; i++)
            {
                MonthChart.Series["월매출"].Points.Add(eachmonth[i]);
            }
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
            MonthChart.Hide();
        }


        private void MonthSale_Click(object sender, EventArgs e)//월 매출 클릭
        {
            DayChart.Hide();
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
