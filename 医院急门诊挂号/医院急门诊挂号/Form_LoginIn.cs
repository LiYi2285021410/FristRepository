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
    public partial class Form_LoginIn : Form
    {
        public Form_LoginIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void Btn_LoginIn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                     
            sqlCommand.CommandText =
                "SELECT COUNT(1) FROM tb_User WHERE Number=@No AND Password=HASHBYTES('MD5',@Password);";  
            SqlParameter sqlParameter = new SqlParameter();
            #region 
            sqlParameter.ParameterName = "@No";                                                         
            sqlParameter.Value = this.Tbx_Name.Text.Trim();                                           
            sqlParameter.SqlDbType = SqlDbType.Char;                                                    
            sqlParameter.Size = 10;                                                                     
            sqlCommand.Parameters.Add(sqlParameter);                                                    
            #endregion
            #region 
            sqlCommand.Parameters.AddWithValue("@Password", this.Tbx_Password.Text.Trim());         
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;                         
            #endregion
            sqlConnection.Open();                                                                      
            int rowCount = (int)sqlCommand.ExecuteScalar();                                          
            sqlConnection.Close();                                                                     
            if (rowCount == 1)                                                                          
            {
                MessageBox.Show("登录成功。");															
            }
            else                                                                                       
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");
                this.Tbx_Password.Focus();
                this.Tbx_Password.SelectAll();
            }
        }
    }
}
