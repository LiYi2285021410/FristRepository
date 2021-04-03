namespace 医院急门诊挂号
{
    partial class Form_LoginIn
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
            this.Tbx_Password = new System.Windows.Forms.TextBox();
            this.Tbx_Name = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Btn_LoginIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tbx_Password
            // 
            this.Tbx_Password.Location = new System.Drawing.Point(127, 68);
            this.Tbx_Password.Name = "Tbx_Password";
            this.Tbx_Password.Size = new System.Drawing.Size(100, 21);
            this.Tbx_Password.TabIndex = 9;
            // 
            // Tbx_Name
            // 
            this.Tbx_Name.Location = new System.Drawing.Point(129, 35);
            this.Tbx_Name.Name = "Tbx_Name";
            this.Tbx_Name.Size = new System.Drawing.Size(100, 21);
            this.Tbx_Name.TabIndex = 8;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(49, 71);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(41, 12);
            this.Lbl_Password.TabIndex = 7;
            this.Lbl_Password.Text = "密码：";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(49, 35);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(53, 12);
            this.Lbl_Name.TabIndex = 6;
            this.Lbl_Name.Text = "用户名：";
            // 
            // Btn_LoginIn
            // 
            this.Btn_LoginIn.Location = new System.Drawing.Point(127, 125);
            this.Btn_LoginIn.Name = "Btn_LoginIn";
            this.Btn_LoginIn.Size = new System.Drawing.Size(75, 23);
            this.Btn_LoginIn.TabIndex = 10;
            this.Btn_LoginIn.Text = "登录";
            this.Btn_LoginIn.UseVisualStyleBackColor = true;
            this.Btn_LoginIn.Click += new System.EventHandler(this.Btn_LoginIn_Click);
            // 
            // Form_LoginIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 201);
            this.Controls.Add(this.Btn_LoginIn);
            this.Controls.Add(this.Tbx_Password);
            this.Controls.Add(this.Tbx_Name);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_Name);
            this.Name = "Form_LoginIn";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_Password;
        private System.Windows.Forms.TextBox Tbx_Name;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Button Btn_LoginIn;
    }
}