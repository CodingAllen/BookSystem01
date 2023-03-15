namespace ToshoSystemTest
{
    partial class frmYoyaku
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTittle = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.txtPublish = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "図書のタイトル（一部）";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtsearch.Location = new System.Drawing.Point(403, 64);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(484, 39);
            this.txtsearch.TabIndex = 7;
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.Location = new System.Drawing.Point(952, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(257, 44);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.tittle,
            this.writer,
            this.publish});
            this.dgvData.Location = new System.Drawing.Point(12, 146);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 27;
            this.dgvData.Size = new System.Drawing.Size(1360, 254);
            this.dgvData.TabIndex = 12;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "Isbn";
            this.isbn.HeaderText = "ISBNコード";
            this.isbn.MinimumWidth = 8;
            this.isbn.Name = "isbn";
            this.isbn.Width = 200;
            // 
            // tittle
            // 
            this.tittle.DataPropertyName = "Title";
            this.tittle.HeaderText = "タイトル";
            this.tittle.MinimumWidth = 8;
            this.tittle.Name = "tittle";
            this.tittle.Width = 500;
            // 
            // writer
            // 
            this.writer.DataPropertyName = "Writer";
            this.writer.HeaderText = "著者";
            this.writer.MinimumWidth = 8;
            this.writer.Name = "writer";
            this.writer.Width = 300;
            // 
            // publish
            // 
            this.publish.DataPropertyName = "Publisher";
            this.publish.HeaderText = "出版社";
            this.publish.MinimumWidth = 8;
            this.publish.Name = "publish";
            this.publish.Width = 270;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(33, 435);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "ISBNコード";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(33, 496);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 34);
            this.label3.TabIndex = 14;
            this.label3.Text = "タイトル";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(33, 552);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "著者";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(33, 608);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "出版社";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtIsbn.Location = new System.Drawing.Point(403, 430);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.ReadOnly = true;
            this.txtIsbn.Size = new System.Drawing.Size(804, 39);
            this.txtIsbn.TabIndex = 17;
            this.txtIsbn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTittle
            // 
            this.txtTittle.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTittle.Location = new System.Drawing.Point(403, 496);
            this.txtTittle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.ReadOnly = true;
            this.txtTittle.Size = new System.Drawing.Size(804, 39);
            this.txtTittle.TabIndex = 18;
            this.txtTittle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtWriter
            // 
            this.txtWriter.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtWriter.Location = new System.Drawing.Point(403, 552);
            this.txtWriter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.ReadOnly = true;
            this.txtWriter.Size = new System.Drawing.Size(804, 39);
            this.txtWriter.TabIndex = 19;
            this.txtWriter.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPublish
            // 
            this.txtPublish.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPublish.Location = new System.Drawing.Point(403, 608);
            this.txtPublish.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.ReadOnly = true;
            this.txtPublish.Size = new System.Drawing.Size(804, 39);
            this.txtPublish.TabIndex = 20;
            this.txtPublish.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDisplay.Location = new System.Drawing.Point(38, 688);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(1169, 39);
            this.txtDisplay.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(33, 768);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 34);
            this.label6.TabIndex = 22;
            this.label6.Text = "学籍番号";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(33, 826);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 34);
            this.label7.TabIndex = 23;
            this.label7.Text = "氏名";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName.Location = new System.Drawing.Point(403, 826);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(484, 39);
            this.txtName.TabIndex = 24;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNumber.Location = new System.Drawing.Point(403, 768);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(484, 39);
            this.txtNumber.TabIndex = 25;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAppointment.Location = new System.Drawing.Point(38, 932);
            this.btnAppointment.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(257, 44);
            this.btnAppointment.TabIndex = 26;
            this.btnAppointment.Text = "予約";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnConfirm.Location = new System.Drawing.Point(952, 768);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(257, 44);
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "学生の確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(403, 932);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(257, 44);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmYoyaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 1107);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtPublish);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.txtTittle);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label2);
            this.Name = "frmYoyaku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "貸出予約";
            this.Load += new System.EventHandler(this.frmYoyaku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTittle;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.TextBox txtPublish;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn publish;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
    }
}