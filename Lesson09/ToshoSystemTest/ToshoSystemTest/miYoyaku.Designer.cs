namespace ToshoSystemTest
{
    partial class miYoyaku
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
            this.txtName02 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName02
            // 
            this.txtName02.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName02.Location = new System.Drawing.Point(14, 68);
            this.txtName02.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName02.Name = "txtName02";
            this.txtName02.ReadOnly = true;
            this.txtName02.Size = new System.Drawing.Size(131, 39);
            this.txtName02.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(165, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(799, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "さんが借りたい本は在庫ありません。";
            // 
            // btnReturn1
            // 
            this.btnReturn1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn1.Location = new System.Drawing.Point(707, 137);
            this.btnReturn1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReturn1.Name = "btnReturn1";
            this.btnReturn1.Size = new System.Drawing.Size(257, 44);
            this.btnReturn1.TabIndex = 16;
            this.btnReturn1.Text = "了解しました。";
            this.btnReturn1.UseVisualStyleBackColor = true;
            this.btnReturn1.Click += new System.EventHandler(this.btnReturn1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(165, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "予約することができます。";
            // 
            // miYoyaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(978, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName02);
            this.Name = "miYoyaku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "miYoyaku";
            this.Load += new System.EventHandler(this.miYoyaku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn1;
        private System.Windows.Forms.Label label1;
    }
}