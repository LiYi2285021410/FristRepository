using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace 医院急门诊挂号
{
    public partial class form_LoginUp : Form
    {
        public form_LoginUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void Btn_LoginUp_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            SqlCommand sqlCommandInsert = new SqlCommand();
            sqlCommandInsert.CommandText =
                $"INSERT tb_User " +
                $"(Nomber, Password  " +
                $"VALUES" +
                $"('{this.Tbx_Name.Text.Trim()}', HASHBYTES('MD5', '{this.Tbx_Password.Text.Trim()}')); ";


            SqlCommand sqlCommandSelect = new SqlCommand();
            sqlCommandSelect.CommandText=
                $"SELECT COUNT(1) FROM tb_User"
                + $" WHERE No='{this.Tbx_Name.Text.Trim()}'"								
                + $" AND Password=HASHBYTES('MD5','{this.Tbx_Password.Text.Trim()}');"; 


            sqlConnection.Open();
            int rowCountSelect = (int)sqlCommandSelect.ExecuteScalar();
            int rowCountInsert = (int)sqlCommandInsert.ExecuteScalar();
            int rowCountSelectTow = (int)sqlCommandSelect.ExecuteScalar();
            sqlConnection.Close();                                                         
            if (rowCountSelect < rowCountSelectTow)                                                             
            {
                MessageBox.Show("注册成功。请前往登录");											
            }
            else                                                                           
            {
                MessageBox.Show("注册失败，用户号/密码有误，请重新输入！");								
                this.Tbx_Password.Focus();                                                  
                this.Tbx_Password.SelectAll();                                              
            }
        }
    }
}
