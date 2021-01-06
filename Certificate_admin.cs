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
    public partial class Certificate_admin : Form
    {
        public string reader_name;
        public string reader_id;
        public string manager_id;
        public Certificate_admin()
        {
            InitializeComponent();
        }
        public Certificate_admin(string manaid)
        {
            InitializeComponent();
            manager_id = manaid;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                reader_name = name_box.Text;
                reader_id = id_box.Text;
                string sql = $"update  reader set reader_name = '{reader_name}' where reader_id = '{reader_id}' and  reader_name = '{reader_name}'";
                Connection con = new Connection();
                int flag = con.command(sql).ExecuteNonQuery();
                if (flag != 1)
                {
                    MessageBox.Show("查无此人");
                    return;
                }
                sql = $"select * from reader where reader_id = '{reader_id}'";
                IDataReader reader = con.read(sql);
                reader.Read();
                role_label.Text = reader.GetString(4);
               
                sql = $"update  paper set reader_id ='{reader_id}'where reader_id ='{reader_id}'";
                flag = con.command(sql).ExecuteNonQuery();


                if (flag != 1)
                {
                    state_label.Text = "未办理借书证";
                    return;
                }
                sql = $"select * from paper where reader_id = '{reader_id}'";
                reader = con.read(sql);
                reader.Read();
                state_label.Text = reader.GetString(2);
            }catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (state_label.Text == "正常")
                {
                    MessageBox.Show("已办理借书证且状态为正常");
                    return;
                }
                
                Connection con = new Connection();
                if(state_label.Text == "挂失")
                {
                    string sql1 = $"update paper set paper_state =  '正常' where reader_id = '{reader_id}'";
                    int flag1 = con.command(sql1).ExecuteNonQuery();
                    if(flag1 == 1)
                    {
                        MessageBox.Show("办理成功");
                    }
                    else
                    {
                        MessageBox.Show("办理失败");
                    }
                    return;
                }
                string sql = $"select * from borrowrule where borrowrule_role = '{role_label.Text}'";
                IDataReader reader = con.read(sql);
                reader.Read();
                int book_count = reader.GetInt32(1);
                sql = $"insert into paper values('{reader_id}','{manager_id}','正常',{book_count})";
                int flag = con.command(sql).ExecuteNonQuery();
                if (flag == 1)
                {
                    MessageBox.Show("办理成功");
                }
                
            }catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void Certificate_admin_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"update paper set paper_state  =  '挂失' where reader_id  = '{reader_id}'";
                Connection con = new Connection();
                int flag = con.command(sql).ExecuteNonQuery();
                if (flag == 1)
                {
                    MessageBox.Show("挂失成功");

                }
                else
                {
                    MessageBox.Show("挂失失败");
                }
            }
            catch(Exception e1)
            {
                e1.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"update borrow_record set reader_id = '{reader_id}' where reader_id = '{reader_id}'";
                Connection con = new Connection();
                int flag = con.command(sql).ExecuteNonQuery();
                if (flag > 0)
                {
                    MessageBox.Show("还有未归还的图书 请及时归还", "提示");
                    return;
                }
                sql = $"delete paper where reader_id = '{reader_id}'";
                flag = con.command(sql).ExecuteNonQuery();
                if(flag == 1)
                {
                    MessageBox.Show("注销成功");
                }
                else
                {
                    MessageBox.Show("注销失败");
                }
            } catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
           

        }

    
    

       
    }
}
