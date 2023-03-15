namespace ToshoSystemTest
{
    partial class FormBooks
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(14, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 34);
            this.label5.TabIndex = 20;
            this.label5.Text = "出版社";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(14, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 34);
            this.label4.TabIndex = 19;
            this.label4.Text = "著者";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "タイトル";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "ISBNコード";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtIsbn.Location = new System.Drawing.Point(187, 54);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(484, 39);
            this.txtIsbn.TabIndex = 21;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPublisher.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtPublisher.Location = new System.Drawing.Point(187, 227);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(484, 39);
            this.txtPublisher.TabIndex = 22;
            // 
            // txtWriter
            // 
            this.txtWriter.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtWriter.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtWriter.Location = new System.Drawing.Point(187, 171);
            this.txtWriter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(484, 39);
            this.txtWriter.TabIndex = 23;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTitle.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtTitle.Location = new System.Drawing.Point(187, 112);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(484, 39);
            this.txtTitle.TabIndex = 24;
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnInput.Location = new System.Drawing.Point(20, 331);
            this.btnInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(257, 44);
            this.btnInput.TabIndex = 25;
            this.btnInput.Text = "登録";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(414, 331);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(257, 44);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormBooks";
            this.Text = "図書情報登録処理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnClose;
    }
}