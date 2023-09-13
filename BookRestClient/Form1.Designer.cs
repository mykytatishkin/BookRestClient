namespace BookRestClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            btAddBook = new Button();
            tbPrice = new TextBox();
            label3 = new Label();
            tbAuthor = new TextBox();
            label2 = new Label();
            tbTitle = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(456, 330);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btAddBook);
            tabPage1.Controls.Add(tbPrice);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(tbAuthor);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(tbTitle);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(448, 302);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Book";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(442, 150);
            dataGridView1.TabIndex = 7;
            // 
            // btAddBook
            // 
            btAddBook.Location = new Point(363, 73);
            btAddBook.Name = "btAddBook";
            btAddBook.Size = new Size(75, 23);
            btAddBook.TabIndex = 6;
            btAddBook.Text = "Add Book";
            btAddBook.UseVisualStyleBackColor = true;
            btAddBook.Click += btAddBook_Click;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(76, 102);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(269, 23);
            tbPrice.TabIndex = 5;
            tbPrice.TextChanged += tbTitle_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 105);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(76, 73);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(269, 23);
            tbAuthor.TabIndex = 3;
            tbAuthor.TextChanged += tbTitle_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 76);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(76, 44);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(269, 23);
            tbTitle.TabIndex = 1;
            tbTitle.TextChanged += tbTitle_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 47);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Book Title:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(448, 302);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Picture";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 330);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox tbTitle;
        private Button btAddBook;
        private TextBox tbPrice;
        private Label label3;
        private TextBox tbAuthor;
        private Label label2;
        private DataGridView dataGridView1;
    }
}