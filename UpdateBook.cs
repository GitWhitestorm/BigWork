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
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                int index = dataGridView1.CurrentRow.Index;
                isbn_label.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                name_box1.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                author_box.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                publish_box.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                price_box.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                num_box.Text = dataGridView1.Rows[index].Cells[5].Value.ToString(); 
                genre_box.Text = dataGridView1.Rows[index].Cells[6].Value.ToString(); 
                class_box.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
                Connection connection = new Connection();
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = name_box.Text;
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
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void comfirm_button_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"update book set book_name = '{name_box1.Text}',book_author = '{author_box.Text}',book_publish = '{publish_box.Text}',book_price = '{price_box.Text}',book_number = '{num_box.Text}',book_genre = '{genre_box.Text}',book_class = '{class_box.Text}' where book_isbn = '{isbn_label.Text}'";
                Connection con = new Connection();
                if (con.command(sql).ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
            
        }
    }
}
