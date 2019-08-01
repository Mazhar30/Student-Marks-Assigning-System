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
    public partial class marks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mazhar\Documents\stu.mdf;Integrated Security=True;Connect Timeout=30");
        public marks()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String b = "Bangla";
            String eng = "English";
            String m = "Mathematics";
            String s = "Science";
            String r = "Religion";
            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT into Subjects VALUES('"+ textBox6.Text +"','"+b+"','"+ textBox1.Text +"')", con);
            cmd1.ExecuteNonQuery();
            
            SqlCommand cmd2 = new SqlCommand("INSERT into Subjects VALUES('"+ textBox6.Text +"','"+eng+"','"+ textBox2.Text +"')", con);
            cmd2.ExecuteNonQuery();
            
            SqlCommand cmd3 = new SqlCommand("INSERT into Subjects VALUES('"+ textBox6.Text +"','"+m+"','"+ textBox3.Text +"')", con);
            cmd3.ExecuteNonQuery();
            
            SqlCommand cmd4 = new SqlCommand("INSERT into Subjects VALUES('"+ textBox6.Text +"','"+s+"','"+ textBox4.Text +"')", con);
            cmd4.ExecuteNonQuery();
            
            SqlCommand cmd5 = new SqlCommand("INSERT into Subjects VALUES('"+ textBox6.Text +"','"+r+"','"+ textBox5.Text + "')", con);
            cmd5.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Marks Assigned successfully"+textBox5.Text);
            this.Close();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void Marks_Load(object sender, EventArgs e)
        {
            textBox6.Text = Entry.s_id;
        }
    }
}
