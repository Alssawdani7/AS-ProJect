using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSystem.PL
{
    public enum error{ TXTUser=0,TXTpassword=1,both=2}
    public partial class FormLogin : Form
    {
        AS_DBEntities db = new AS_DBEntities();
        TB_User user = new TB_User();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Name = txtUser.Text;


            if (txtUser.TextLength !=0 || txtPassword.TextLength!=0 )
            {
                if (db.TB_User.Where(x => x.user_name == Name).FirstOrDefault() != null)
                {
                    user = db.TB_User.Where(x => x.user_name == Name).FirstOrDefault();

                }

                if (user.user_name == txtUser.Text)
                {
                    if (user.user_pass == txtPassword.Text)
                    {
                        MessageBox.Show("ahmad");
                    }
                    else
                    {
                        errorFunaction(error.TXTpassword);
                        

                    }

                }
                else
                {
                    errorFunaction(error.TXTUser);
                    
                } 
            }
            else
            {
                errorFunaction(error.both);
            }

           


        }
        //دالة الخطاء 
        private void errorFunaction(error e1 )
        {
            switch (e1)
            {
                case error.TXTUser:
                    txtUser.BorderThickness = 2;
                    txtUser.BorderColor = Color.Red;
                    errorProvider.SetError(txtUser, "enter name");
                    errorProvider.SetIconAlignment(txtUser, ErrorIconAlignment.MiddleLeft);
                    break;
                case error.TXTpassword:
                    txtPassword.BorderThickness = 2;
                    txtPassword.BorderColor = Color.Red;
            
                    break;
                case error.both:
                    txtUser.BorderThickness = 2;
                    txtUser.BorderColor = Color.Red;
                    txtPassword.BorderThickness = 2;
                    txtPassword.BorderColor = Color.Red;
                    break;
               
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            eraseErrorFuncation(error.TXTUser);

        }

        //دالة ازالة الخطاء 
        private void eraseErrorFuncation(error e1)
        {
            switch (e1)
            {
                case error.TXTUser:
                    txtUser.BorderThickness = 2;
                    txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))); 
                    break;
                case error.TXTpassword:
                    txtPassword.BorderThickness = 2;
                    txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))); 
                    break;
                

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            eraseErrorFuncation(error.TXTpassword);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            var type = "admin";
            user = db.TB_User.Where(x => x.user_type == type).FirstOrDefault();
            txtUser.DefaultText = user.user_name;
            txtPassword.Focus();
        }

      
    }
}
