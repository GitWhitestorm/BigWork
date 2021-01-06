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
    public partial class Librarians : Form
    {
        string manager_id;
        public Librarians()
        {
            InitializeComponent();
        }
        public Librarians(string id)
        {
            InitializeComponent();
            manager_id = id;
        }

        private void 图书信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBook update = new UpdateBook();
            update.Show();
        }

        private void Librarians_Load(object sender, EventArgs e)
        {

            Connection con = new Connection();


            string sql = "select distinct book_genre,book_class from book order by book_genre,book_class asc";
            IDataReader reader = con.read(sql);
            string str1 = "";
            int index = -1;
            while (reader.Read())
            {
                if (str1 != reader.GetString(0))
                {
                    treeView1.Nodes.Add(reader.GetString(0));
                    index++;
                    treeView1.Nodes[index].Nodes.Add(reader.GetString(1));
                    str1 = reader.GetString(0);
                }
                else
                {
                    treeView1.Nodes[index].Nodes.Add(reader.GetString(1));
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = bookname_box.Text;
                string _class = treeView1.SelectedNode.Text;
                string sql = "";
                if (treeView1.SelectedNode.Nodes == null)
                {
                    sql = $"select * from book where book_name like '%{name}%' and book_class = '{_class}'";
                }
                if (treeView1.SelectedNode.Parent == null)
                {
                    sql = $"select * from book where book_name like '%{name}%' and book_genre = '{_class}'";
                }
                Connection con = new Connection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con.connection());
                DataSet set = new DataSet();
                adapter.Fill(set);
                dataGridView1.DataSource = set.Tables[0];
            }catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                name_label.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                isbn_label.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                Connection connection = new Connection();
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void borrow_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            try
            {
                string reader_name = name_box.Text;
                string reader_id = id_box.Text;
                string sql = $"update reader set reader_id = '{reader_id}' where reader_id = '{reader_id}' and reader_name = '{reader_name}'";
                Connection con = new Connection();
                
                if(con.command(sql).ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("查无此人");
                    return;
                }
                sql = $"select reader_role from reader where reader_id = '{reader_id}'";
                IDataReader reader = con.read(sql);
                reader.Read();
                string reader_role = reader.GetString(0);                       
                SqlCommand command = new SqlCommand();
                SqlTransaction transaction;
                SqlConnection connection = con.connection();
                transaction = connection.BeginTransaction();
                sql = $"update book set book_number = book_number-1 where book_number>0 and book_isbn = '{isbn_label.Text}'";
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = sql;
               if(command.ExecuteNonQuery() != 1)
                {
                    transaction.Rollback();
                    MessageBox.Show("图书数量等于0不可借出");
                    return;
                }
                sql = $"update paper set book_num = book_num-1  where book_num>0 and reader_id = '{reader_id}' and paper_state = '正常'";
                command.CommandText = sql;
                if (command.ExecuteNonQuery() != 1)
                {
                    transaction.Rollback();
                    MessageBox.Show("借书证状态不是正常或者可借数量为0");
                    return;
                }
                sql = $"insert into borrow_record values('{reader_id}','{isbn_label.Text}','{dt}','{reader_role}')";
                command.CommandText = sql;
                if (command.ExecuteNonQuery() != 1)
                {
                    transaction.Rollback();
                    MessageBox.Show("图书数量等于0不可借出");
                    return;
                }

                transaction.Commit();
                MessageBox.Show("借书成功");
            }catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void 证件管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Certificate_admin admin = new Certificate_admin(manager_id);
            admin.Show();
        }

        private void 借书规则修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrowrule borrowrule = new Borrowrule();
            borrowrule.Show();
        }
    }
}
