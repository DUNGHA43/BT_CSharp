namespace Lab6_BT
{
    partial class B2_F2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtinTH = new System.Windows.Forms.TextBox();
            this.txtinGT = new System.Windows.Forms.TextBox();
            this.txtinMH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN HÀNG HÓA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá tiền:";
            // 
            // txtinTH
            // 
            this.txtinTH.Location = new System.Drawing.Point(234, 123);
            this.txtinTH.Name = "txtinTH";
            this.txtinTH.ReadOnly = true;
            this.txtinTH.Size = new System.Drawing.Size(320, 20);
            this.txtinTH.TabIndex = 9;
            // 
            // txtinGT
            // 
            this.txtinGT.Location = new System.Drawing.Point(234, 156);
            this.txtinGT.Name = "txtinGT";
            this.txtinGT.ReadOnly = true;
            this.txtinGT.Size = new System.Drawing.Size(320, 20);
            this.txtinGT.TabIndex = 8;
            // 
            // txtinMH
            // 
            this.txtinMH.Location = new System.Drawing.Point(234, 90);
            this.txtinMH.Name = "txtinMH";
            this.txtinMH.ReadOnly = true;
            this.txtinMH.Size = new System.Drawing.Size(320, 20);
            this.txtinMH.TabIndex = 7;
            // 
            // B2_F2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 259);
            this.Controls.Add(this.txtinTH);
            this.Controls.Add(this.txtinGT);
            this.Controls.Add(this.txtinMH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "B2_F2";
            this.Text = "B2_F2";
            this.Load += new System.EventHandler(this.B2_F2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtinTH;
        private System.Windows.Forms.TextBox txtinGT;
        private System.Windows.Forms.TextBox txtinMH;
    }
}