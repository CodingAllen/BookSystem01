namespace ToshoSystemTest
{
    partial class FrmYoyakusare
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
            this.btnReturn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName01 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturn1
            // 
            this.btnReturn1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn1.Location = new System.Drawing.Point(707, 137);
            this.btnReturn1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReturn1.Name = "btnReturn1";
            this.btnReturn1.Size = new System.Drawing.Size(257, 44);
            this.btnReturn1.TabIndex = 11;
            this.btnReturn1.Text = "了解しました。";
            this.btnReturn1.UseVisualStyleBackColor = true;
            this.btnReturn1.Click += new System.EventHandler(this.btnReturn1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(155, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(799, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "さんが予約した本が返されるまでしばらくお待ちください。";
            // 
            // txtName01
            // 
            this.txtName01.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName01.Location = new System.Drawing.Point(14, 51);
            this.txtName01.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName01.Name = "txtName01";
            this.txtName01.ReadOnly = true;
            this.txtName01.Size = new System.Drawing.Size(131, 39);
            this.txtName01.TabIndex = 13;
            this.txtName01.TextChanged += new System.EventHandler(this.txtReturnIsbn_TextChanged);
            // 
            // FrmYoyakusare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 194);
            this.Controls.Add(this.txtName01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn1);
            this.Name = "FrmYoyakusare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在庫なし";
            this.Load += new System.EventHandler(this.FrmYoyakusare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName01;
    }
}