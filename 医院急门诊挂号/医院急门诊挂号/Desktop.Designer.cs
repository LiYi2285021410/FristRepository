namespace 医院急门诊挂号
{
    partial class Desktop
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
            this.btn_Consoie = new System.Windows.Forms.Button();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.btn_BackNo = new System.Windows.Forms.Button();
            this.btn_CheckOutTheBusiness = new System.Windows.Forms.Button();
            this.btn_AccountManagement = new System.Windows.Forms.Button();
            this.btn_PersonalCenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Consoie
            // 
            this.btn_Consoie.Location = new System.Drawing.Point(31, 13);
            this.btn_Consoie.Name = "btn_Consoie";
            this.btn_Consoie.Size = new System.Drawing.Size(75, 23);
            this.btn_Consoie.TabIndex = 0;
            this.btn_Consoie.Text = "控制台";
            this.btn_Consoie.UseVisualStyleBackColor = true;
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(139, 12);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(75, 23);
            this.btn_Registration.TabIndex = 1;
            this.btn_Registration.Text = "挂号";
            this.btn_Registration.UseVisualStyleBackColor = true;
            // 
            // btn_BackNo
            // 
            this.btn_BackNo.Location = new System.Drawing.Point(248, 12);
            this.btn_BackNo.Name = "btn_BackNo";
            this.btn_BackNo.Size = new System.Drawing.Size(75, 23);
            this.btn_BackNo.TabIndex = 2;
            this.btn_BackNo.Text = "退号";
            this.btn_BackNo.UseVisualStyleBackColor = true;
            // 
            // btn_CheckOutTheBusiness
            // 
            this.btn_CheckOutTheBusiness.Location = new System.Drawing.Point(350, 12);
            this.btn_CheckOutTheBusiness.Name = "btn_CheckOutTheBusiness";
            this.btn_CheckOutTheBusiness.Size = new System.Drawing.Size(75, 23);
            this.btn_CheckOutTheBusiness.TabIndex = 3;
            this.btn_CheckOutTheBusiness.Text = "结账业务";
            this.btn_CheckOutTheBusiness.UseVisualStyleBackColor = true;
            // 
            // btn_AccountManagement
            // 
            this.btn_AccountManagement.Location = new System.Drawing.Point(447, 11);
            this.btn_AccountManagement.Name = "btn_AccountManagement";
            this.btn_AccountManagement.Size = new System.Drawing.Size(75, 23);
            this.btn_AccountManagement.TabIndex = 4;
            this.btn_AccountManagement.Text = "账户管理";
            this.btn_AccountManagement.UseVisualStyleBackColor = true;
            // 
            // btn_PersonalCenter
            // 
            this.btn_PersonalCenter.Location = new System.Drawing.Point(544, 13);
            this.btn_PersonalCenter.Name = "btn_PersonalCenter";
            this.btn_PersonalCenter.Size = new System.Drawing.Size(75, 23);
            this.btn_PersonalCenter.TabIndex = 5;
            this.btn_PersonalCenter.Text = "个人中心";
            this.btn_PersonalCenter.UseVisualStyleBackColor = true;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 396);
            this.Controls.Add(this.btn_PersonalCenter);
            this.Controls.Add(this.btn_AccountManagement);
            this.Controls.Add(this.btn_CheckOutTheBusiness);
            this.Controls.Add(this.btn_BackNo);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.btn_Consoie);
            this.Name = "Desktop";
            this.Text = "桌面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Consoie;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.Button btn_BackNo;
        private System.Windows.Forms.Button btn_CheckOutTheBusiness;
        private System.Windows.Forms.Button btn_AccountManagement;
        private System.Windows.Forms.Button btn_PersonalCenter;
    }
}