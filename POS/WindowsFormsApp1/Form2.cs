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
    public partial class Form2 : Form
    {
        //Sql 서버의 사용자아이디, 비밀번호, 데이터베이스 이름, 서버명
        public static string uid = "sa";
        public static string password = "pos15963";
        public static string database = "POS_Stuff";
        public static string server = "DESKTOP-CVCKE2N";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            string constr = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";";
            SqlConnection POS_DATABASE = new SqlConnection(constr);
            try { 
            POS_DATABASE.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = POS_DATABASE;
            cmd.CommandText = "SELECT * FROM stuff";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            listView1.Items.Clear();
                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        i = i + 1;
                        ListViewItem lvt = new ListViewItem();
                        lvt.SubItems.Add(i.ToString());
                        lvt.SubItems.Add(reader["stuff"].ToString());
                        lvt.SubItems.Add(reader.GetString(1));
                        lvt.SubItems.Add(reader.GetString(2));
                        lvt.SubItems.Add(reader.GetString(3));
                        lvt.SubItems.Add(reader.GetString(4));
                        lvt.SubItems.Add(reader.GetString(4));
                        listView1.Items.Add(lvt);
                    }
                    reader.Close();
                    listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
                    POS_DATABASE.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var f1 = (Form1)(this.Tag);
            f1.Show();
            this.Hide();
        }
    }
}
