using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Marking_System
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mazhar\Documents\stu.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void EntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Student", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            show_all_data sad = new show_all_data();
            sad.dataGridView1.DataSource = dt;
            sad.Show();
        }

        private void EntryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Entry ab = new Entry();
            ab.Show();
            //this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            search_result sr = new search_result();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Student where Id=" + int.Parse(textBox1.Text),con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                sr.textBox1.Text = (dr["Id"].ToString());
                sr.textBox2.Text = (dr["Name"].ToString());
                sr.textBox3.Text = (dr["Class"].ToString());
            }
            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select marks from Subjects where F_Id=" + int.Parse(textBox1.Text)+"and subject = 'Bangla'", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                sr.textBox4.Text = (dr3["marks"].ToString());
            }
            con.Close();

            con.Open();
            SqlCommand cmd4 = new SqlCommand("Select marks from Subjects where F_Id=" + int.Parse(textBox1.Text)+"and subject = 'English'", con);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                sr.textBox5.Text = (dr4["marks"].ToString());
            }
            con.Close();

            con.Open();
            SqlCommand cmd5 = new SqlCommand("Select marks from Subjects where F_Id=" + int.Parse(textBox1.Text)+"and subject = 'Mathematics'", con);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                sr.textBox6.Text = (dr5["marks"].ToString());
            }
            con.Close();

            con.Open();
            SqlCommand cmd6 = new SqlCommand("Select marks from Subjects where F_Id=" + int.Parse(textBox1.Text)+"and subject = 'Science'", con);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                sr.textBox7.Text = (dr6["marks"].ToString());
            }
            con.Close();

            con.Open();
            SqlCommand cmd7 = new SqlCommand("Select marks from Subjects where F_Id=" + int.Parse(textBox1.Text)+"and subject = 'Religion'", con);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                sr.textBox8.Text = (dr7["marks"].ToString());
            }
            con.Close();
            sr.Show();
        }
    }
}
