namespace ToshoSystemTest
{
    partial class FrmHenkyaku
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReturnIsbn = new System.Windows.Forms.TextBox();
            this.txtReturnTitle = new System.Windows.Forms.TextBox();
            this.btnBookConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(76, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "タイトル";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(76, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBNコード";
            // 
            // txtReturnIsbn
            // 
            this.txtReturnIsbn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtReturnIsbn.Location = new System.Drawing.Point(326, 56);
            this.txtReturnIsbn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtReturnIsbn.Name = "txtReturnIsbn";
            this.txtReturnIsbn.Size = new System.Drawing.Size(310, 39);
            this.txtReturnIsbn.TabIndex = 6;
            this.txtReturnIsbn.TextChanged += new System.EventHandler(this.txtReturnIsbn_TextChanged);
            this.txtReturnIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReturnIsbn_KeyPress);
            // 
            // txtReturnTitle
            // 
            this.txtReturnTitle.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtReturnTitle.Location = new System.Drawing.Point(326, 125);
            this.txtReturnTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtReturnTitle.Name = "txtReturnTitle";
            this.txtReturnTitle.ReadOnly = true;
            this.txtReturnTitle.Size = new System.Drawing.Size(999, 39);
            this.txtReturnTitle.TabIndex = 7;
            // 
            // btnBookConfirm
            // 
            this.btnBookConfirm.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBookConfirm.Location = new System.Drawing.Point(694, 51);
            this.btnBookConfirm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBookConfirm.Name = "btnBookConfirm";
            this.btnBookConfirm.Size = new System.Drawing.Size(257, 44);
            this.btnBookConfirm.TabIndex = 10;
            this.btnBookConfirm.Text = "図書の確認";
            this.btnBookConfirm.UseVisualStyleBackColor = true;
            this.btnBookConfirm.Click += new System.EventHandler(this.btnBookConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(694, 214);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(257, 44);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(326, 214);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(257, 44);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "返却";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmHenkyaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 299);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBookConfirm);
            this.Controls.Add(this.txtReturnTitle);
            this.Controls.Add(this.txtReturnIsbn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHenkyaku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "図書の返却";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReturnIsbn;
        private System.Windows.Forms.TextBox txtReturnTitle;
        private System.Windows.Forms.Button btnBookConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturn;
    }
}