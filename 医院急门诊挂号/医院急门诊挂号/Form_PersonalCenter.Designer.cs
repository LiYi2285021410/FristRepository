namespace 医院急门诊挂号
{
    partial class Form_PersonalCenter
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
            this.lbl_Number = new System.Windows.Forms.Label();
            this.txb_Number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(41, 25);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(47, 12);
            this.lbl_Number.TabIndex = 0;
            this.lbl_Number.Text = "就诊号:";
            // 
            // txb_Number
            // 
            this.txb_Number.Location = new System.Drawing.Point(99, 25);
            this.txb_Number.Name = "txb_Number";
            this.txb_Number.Size = new System.Drawing.Size(100, 21);
            this.txb_Number.TabIndex = 1;
            // 
            // Form_PersonalCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.txb_Number);
            this.Controls.Add(this.lbl_Number);
            this.Name = "Form_PersonalCenter";
            this.Text = "Form_PersonalCenter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.TextBox txb_Number;
    }
}