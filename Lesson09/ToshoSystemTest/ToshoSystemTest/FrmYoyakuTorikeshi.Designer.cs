namespace ToshoSystemTest
{
    partial class FrmYoyakuTorikeshi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGakuNo = new System.Windows.Forms.TextBox();
            this.bntStudentConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YoyakuDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "学籍番号";
            // 
            // txtGakuNo
            // 
            this.txtGakuNo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtGakuNo.Location = new System.Drawing.Point(333, 54);
            this.txtGakuNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGakuNo.Name = "txtGakuNo";
            this.txtGakuNo.Size = new System.Drawing.Size(357, 39);
            this.txtGakuNo.TabIndex = 6;
            // 
            // bntStudentConfirm
            // 
            this.bntStudentConfirm.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntStudentConfirm.Location = new System.Drawing.Point(825, 54);
            this.bntStudentConfirm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bntStudentConfirm.Name = "bntStudentConfirm";
            this.bntStudentConfirm.Size = new System.Drawing.Size(257, 44);
            this.bntStudentConfirm.TabIndex = 10;
            this.bntStudentConfirm.Text = "学生の確認";
            this.bntStudentConfirm.UseVisualStyleBackColor = true;
            this.bntStudentConfirm.Click += new System.EventHandler(this.bntStudentConfirm_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(80, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "ISBNコード";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(80, 482);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "タイトル";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTitle.Location = new System.Drawing.Point(333, 472);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(644, 39);
            this.txtTitle.TabIndex = 13;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtIsbn.Location = new System.Drawing.Point(333, 406);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.ReadOnly = true;
            this.txtIsbn.Size = new System.Drawing.Size(357, 39);
            this.txtIsbn.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Isbn,
            this.Title,
            this.YoyakuDate});
            this.dataGridView1.Location = new System.Drawing.Point(20, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 258);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Isbn
            // 
            this.Isbn.DataPropertyName = "isbn";
            this.Isbn.HeaderText = "ISBNコード";
            this.Isbn.MinimumWidth = 8;
            this.Isbn.Name = "Isbn";
            this.Isbn.Width = 150;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "タイトル";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.Width = 200;
            // 
            // YoyakuDate
            // 
            this.YoyakuDate.DataPropertyName = "yoyakudate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.YoyakuDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.YoyakuDate.HeaderText = "予約日時";
            this.YoyakuDate.MinimumWidth = 8;
            this.YoyakuDate.Name = "YoyakuDate";
            this.YoyakuDate.Width = 200;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(87, 555);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(257, 44);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "予約の取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(437, 555);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(257, 44);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmYoyakuTorikeshi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 616);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntStudentConfirm);
            this.Controls.Add(this.txtGakuNo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmYoyakuTorikeshi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYoyakuTorikeshi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGakuNo;
        private System.Windows.Forms.Button bntStudentConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn YoyakuDate;
    }
}