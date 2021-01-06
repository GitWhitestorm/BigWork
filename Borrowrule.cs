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

namespace BigWork
{
    public partial class Borrowrule : Form
    {
        public Borrowrule()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update  borrowrule set  max_time  = {days_box.Text},number = {nums_box.Text} where borrowrule_role = '{comboBox1.SelectedItem}'";
            Connection con = new Connection();
            if(con.command(sql).ExecuteNonQuery() == 1)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void selectedchange(object sender, EventArgs e)
        {
            try
            {
                string sql = $"select * from borrowrule where  borrowrule_role = '{comboBox1.SelectedItem}'";
                Connection con = new Connection();
                IDataReader reader = con.read(sql);
                reader.Read();
                days_box.Text = reader.GetInt32(1).ToString();
                nums_box.Text = reader.GetInt32(2).ToString();
            }catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }
    }
}
