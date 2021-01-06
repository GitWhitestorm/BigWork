using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigWork
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_box.PasswordChar = '\0';
            }
            else
            {
                password_box.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password_box.PasswordChar = '*'; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update manager set manager_id  = '{id_box.Text}' where  manager_id  = '{id_box.Text}' and manager_password = '{password_box.Text}'";
            Connection con = new Connection();
            if(con.command(sql).ExecuteNonQuery() == 1)
            {
                MessageBox.Show("登录成功");
                Librarians librarians = new Librarians(id_box.Text);
                librarians.Show();
                this.Visible = false;
            }
        }
    }
}
