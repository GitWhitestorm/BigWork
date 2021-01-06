
namespace BigWork
{
    partial class UpdateBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comfirm_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.box11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.author_box = new System.Windows.Forms.TextBox();
            this.publish_box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.name_box1 = new System.Windows.Forms.TextBox();
            this.isbn_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.price_box = new System.Windows.Forms.TextBox();
            this.num_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.genre_box = new System.Windows.Forms.TextBox();
            this.class_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comfirm_button
            // 
            this.comfirm_button.Location = new System.Drawing.Point(884, 421);
            this.comfirm_button.Name = "comfirm_button";
            this.comfirm_button.Size = new System.Drawing.Size(75, 23);
            this.comfirm_button.TabIndex = 27;
            this.comfirm_button.Text = "确认修改";
            this.comfirm_button.UseVisualStyleBackColor = true;
            this.comfirm_button.Click += new System.EventHandler(this.comfirm_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(333, 325);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 21);
            this.name_box.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "书名：";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(465, 329);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 21;
            this.label44.Text = "ISBN:";
            // 
            // box11
            // 
            this.box11.AutoSize = true;
            this.box11.Location = new System.Drawing.Point(456, 409);
            this.box11.Name = "box11";
            this.box11.Size = new System.Drawing.Size(41, 12);
            this.box11.TabIndex = 20;
            this.box11.Text = "书名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "作者";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "出版商：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // author_box
            // 
            this.author_box.Location = new System.Drawing.Point(737, 320);
            this.author_box.Name = "author_box";
            this.author_box.Size = new System.Drawing.Size(100, 21);
            this.author_box.TabIndex = 17;
            this.author_box.TextChanged += new System.EventHandler(this.id_box_TextChanged);
            // 
            // publish_box
            // 
            this.publish_box.Location = new System.Drawing.Point(737, 406);
            this.publish_box.Name = "publish_box";
            this.publish_box.Size = new System.Drawing.Size(100, 21);
            this.publish_box.TabIndex = 16;
            this.publish_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(715, 281);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(227, 562);
            this.treeView1.TabIndex = 14;
            // 
            // name_box1
            // 
            this.name_box1.Location = new System.Drawing.Point(508, 411);
            this.name_box1.Name = "name_box1";
            this.name_box1.Size = new System.Drawing.Size(100, 21);
            this.name_box1.TabIndex = 28;
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(506, 329);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(65, 12);
            this.isbn_label.TabIndex = 29;
            this.isbn_label.Text = "isbn_label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "价格";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "数量";
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(508, 480);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(100, 21);
            this.price_box.TabIndex = 31;
            // 
            // num_box
            // 
            this.num_box.Location = new System.Drawing.Point(508, 553);
            this.num_box.Name = "num_box";
            this.num_box.Size = new System.Drawing.Size(100, 21);
            this.num_box.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "题材";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "分类";
            // 
            // genre_box
            // 
            this.genre_box.Location = new System.Drawing.Point(737, 480);
            this.genre_box.Name = "genre_box";
            this.genre_box.Size = new System.Drawing.Size(100, 21);
            this.genre_box.TabIndex = 35;
            // 
            // class_box
            // 
            this.class_box.Location = new System.Drawing.Point(737, 550);
            this.class_box.Name = "class_box";
            this.class_box.Size = new System.Drawing.Size(100, 21);
            this.class_box.TabIndex = 34;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 627);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.genre_box);
            this.Controls.Add(this.class_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.num_box);
            this.Controls.Add(this.isbn_label);
            this.Controls.Add(this.name_box1);
            this.Controls.Add(this.comfirm_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.box11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.author_box);
            this.Controls.Add(this.publish_box);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button comfirm_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label box11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox author_box;
        private System.Windows.Forms.TextBox publish_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox name_box1;
        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.TextBox num_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox genre_box;
        private System.Windows.Forms.TextBox class_box;
    }
}