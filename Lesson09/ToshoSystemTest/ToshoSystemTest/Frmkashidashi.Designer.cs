namespace ToshoSystemTest
{
    partial class Frmkashidashi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGakuNo = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtISBn = new System.Windows.Forms.TextBox();
            this.bntStudentConfirm = new System.Windows.Forms.Button();
            this.btnBookConfirm = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnKashi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kashiDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YoteiDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(68, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "学籍番号";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(68, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "氏名";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(68, 459);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBNコード";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(68, 520);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "タイトル";
            // 
            // txtGakuNo
            // 
            this.txtGakuNo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtGakuNo.Location = new System.Drawing.Point(297, 74);
            this.txtGakuNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGakuNo.Name = "txtGakuNo";
            this.txtGakuNo.Size = new System.Drawing.Size(281, 39);
            this.txtGakuNo.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTitle.Location = new System.Drawing.Point(297, 516);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(784, 39);
            this.txtTitle.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName.Location = new System.Drawing.Point(297, 140);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(281, 39);
            this.txtName.TabIndex = 7;
            // 
            // txtISBn
            // 
            this.txtISBn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtISBn.Location = new System.Drawing.Point(297, 459);
            this.txtISBn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtISBn.Name = "txtISBn";
            this.txtISBn.Size = new System.Drawing.Size(281, 39);
            this.txtISBn.TabIndex = 8;
            this.txtISBn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtISBn_KeyDown);
            this.txtISBn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBn_KeyPress);
            // 
            // bntStudentConfirm
            // 
            this.bntStudentConfirm.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntStudentConfirm.Location = new System.Drawing.Point(827, 74);
            this.bntStudentConfirm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bntStudentConfirm.Name = "bntStudentConfirm";
            this.bntStudentConfirm.Size = new System.Drawing.Size(257, 44);
            this.bntStudentConfirm.TabIndex = 9;
            this.bntStudentConfirm.Text = "学生の確認";
            this.bntStudentConfirm.UseVisualStyleBackColor = true;
            this.bntStudentConfirm.Click += new System.EventHandler(this.bntStudentConfirm_Click);
            // 
            // btnBookConfirm
            // 
            this.btnBookConfirm.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBookConfirm.Location = new System.Drawing.Point(827, 450);
            this.btnBookConfirm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBookConfirm.Name = "btnBookConfirm";
            this.btnBookConfirm.Size = new System.Drawing.Size(257, 44);
            this.btnBookConfirm.TabIndex = 10;
            this.btnBookConfirm.Text = "図書の確認";
            this.btnBookConfirm.UseVisualStyleBackColor = true;
            this.btnBookConfirm.Click += new System.EventHandler(this.btnBookConfirm_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEnd.Location = new System.Drawing.Point(430, 614);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(257, 44);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.Text = "閉じる";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnKashi
            // 
            this.btnKashi.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKashi.Location = new System.Drawing.Point(75, 614);
            this.btnKashi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKashi.Name = "btnKashi";
            this.btnKashi.Size = new System.Drawing.Size(257, 44);
            this.btnKashi.TabIndex = 12;
            this.btnKashi.Text = "貸出";
            this.btnKashi.UseVisualStyleBackColor = true;
            this.btnKashi.Click += new System.EventHandler(this.btnKashi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Isbn,
            this.title,
            this.kashiDate,
            this.YoteiDate});
            this.dataGridView1.Location = new System.Drawing.Point(75, 192);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 249);
            this.dataGridView1.TabIndex = 13;
            // 
            // Isbn
            // 
            this.Isbn.DataPropertyName = "isbn";
            this.Isbn.HeaderText = "ISBNコード";
            this.Isbn.MinimumWidth = 8;
            this.Isbn.Name = "Isbn";
            this.Isbn.Width = 130;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "タイトル";
            this.title.MinimumWidth = 8;
            this.title.Name = "title";
            this.title.Width = 300;
            // 
            // kashiDate
            // 
            this.kashiDate.DataPropertyName = "kashidate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.kashiDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.kashiDate.HeaderText = "貸出年月日";
            this.kashiDate.MinimumWidth = 8;
            this.kashiDate.Name = "kashiDate";
            this.kashiDate.Width = 130;
            // 
            // YoteiDate
            // 
            this.YoteiDate.DataPropertyName = "yoteidate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.YoteiDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.YoteiDate.HeaderText = "返却予定日";
            this.YoteiDate.MinimumWidth = 8;
            this.YoteiDate.Name = "YoteiDate";
            this.YoteiDate.Width = 130;
            // 
            // Frmkashidashi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 675);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKashi);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnBookConfirm);
            this.Controls.Add(this.bntStudentConfirm);
            this.Controls.Add(this.txtISBn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtGakuNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Frmkashidashi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "図書の貸し出し";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGakuNo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtISBn;
        private System.Windows.Forms.Button bntStudentConfirm;
        private System.Windows.Forms.Button btnBookConfirm;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnKashi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn kashiDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn YoteiDate;
    }
}