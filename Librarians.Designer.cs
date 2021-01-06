
namespace BigWork
{
    partial class Librarians
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookname_box = new System.Windows.Forms.TextBox();
            this.isbn_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.borrow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书信息修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.证件管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书规则修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(5, 38);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(220, 432);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(715, 281);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(707, 343);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 21);
            this.name_box.TabIndex = 2;
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(708, 430);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 21);
            this.id_box.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(428, 439);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 7;
            this.label44.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "书名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "书名：";
            // 
            // bookname_box
            // 
            this.bookname_box.Location = new System.Drawing.Point(304, 351);
            this.bookname_box.Name = "bookname_box";
            this.bookname_box.Size = new System.Drawing.Size(100, 21);
            this.bookname_box.TabIndex = 9;
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(485, 439);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(65, 12);
            this.isbn_label.TabIndex = 11;
            this.isbn_label.Text = "isbn_label";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(485, 351);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(65, 12);
            this.name_label.TabIndex = 10;
            this.name_label.Text = "name_label";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // borrow
            // 
            this.borrow.Location = new System.Drawing.Point(878, 430);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(75, 23);
            this.borrow.TabIndex = 13;
            this.borrow.Text = "借书";
            this.borrow.UseVisualStyleBackColor = true;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书信息修改ToolStripMenuItem,
            this.证件管理ToolStripMenuItem,
            this.借书规则修改ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 25);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书信息修改ToolStripMenuItem
            // 
            this.图书信息修改ToolStripMenuItem.Name = "图书信息修改ToolStripMenuItem";
            this.图书信息修改ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.图书信息修改ToolStripMenuItem.Text = "图书信息修改";
            this.图书信息修改ToolStripMenuItem.Click += new System.EventHandler(this.图书信息修改ToolStripMenuItem_Click);
            // 
            // 证件管理ToolStripMenuItem
            // 
            this.证件管理ToolStripMenuItem.Name = "证件管理ToolStripMenuItem";
            this.证件管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.证件管理ToolStripMenuItem.Text = "证件管理";
            this.证件管理ToolStripMenuItem.Click += new System.EventHandler(this.证件管理ToolStripMenuItem_Click);
            // 
            // 借书规则修改ToolStripMenuItem
            // 
            this.借书规则修改ToolStripMenuItem.Name = "借书规则修改ToolStripMenuItem";
            this.借书规则修改ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.借书规则修改ToolStripMenuItem.Text = "借书规则修改";
            this.借书规则修改ToolStripMenuItem.Click += new System.EventHandler(this.借书规则修改ToolStripMenuItem_Click);
            // 
            // Librarians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 551);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isbn_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.bookname_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Librarians";
            this.Text = "Librarians";
            this.Load += new System.EventHandler(this.Librarians_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookname_box;
        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书信息修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 证件管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书规则修改ToolStripMenuItem;
    }
}