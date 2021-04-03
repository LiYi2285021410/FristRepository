namespace 医院急门诊挂号
{
    partial class form_LoginUp
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_LoginUp = new System.Windows.Forms.Button();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Tbx_Name = new System.Windows.Forms.TextBox();
            this.Tbx_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_LoginUp
            // 
            this.Btn_LoginUp.Location = new System.Drawing.Point(135, 134);
            this.Btn_LoginUp.Name = "Btn_LoginUp";
            this.Btn_LoginUp.Size = new System.Drawing.Size(98, 23);
            this.Btn_LoginUp.TabIndex = 0;
            this.Btn_LoginUp.Text = "注册";
            this.Btn_LoginUp.UseVisualStyleBackColor = true;
            this.Btn_LoginUp.Click += new System.EventHandler(this.Btn_LoginUp_Click);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(55, 39);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(53, 12);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "用户名：";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(55, 75);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(41, 12);
            this.Lbl_Password.TabIndex = 2;
            this.Lbl_Password.Text = "密码：";
            // 
            // Tbx_Name
            // 
            this.Tbx_Name.Location = new System.Drawing.Point(135, 39);
            this.Tbx_Name.Name = "Tbx_Name";
            this.Tbx_Name.Size = new System.Drawing.Size(100, 21);
            this.Tbx_Name.TabIndex = 4;
            // 
            // Tbx_Password
            // 
            this.Tbx_Password.Location = new System.Drawing.Point(133, 72);
            this.Tbx_Password.Name = "Tbx_Password";
            this.Tbx_Password.Size = new System.Drawing.Size(100, 21);
            this.Tbx_Password.TabIndex = 5;
            // 
            // form_LoginUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 188);
            this.Controls.Add(this.Tbx_Password);
            this.Controls.Add(this.Tbx_Name);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Btn_LoginUp);
            this.Name = "form_LoginUp";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_LoginUp;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Tbx_Name;
        private System.Windows.Forms.TextBox Tbx_Password;
    }
}

