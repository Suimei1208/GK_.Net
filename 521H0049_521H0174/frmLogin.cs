using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure.Design;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _521H0049_521H0174
{
    public partial class frmLogin : Form
    {
        private bool isHide = true;
        
        
        public frmLogin()
        {
            InitializeComponent();
            errlabel.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeePass_Click(object sender, EventArgs e)
        {
            if (!isHide)
            {
                btnSeePass.BackgroundImage = Properties.Resources.icon_closeEye;
                tbPassword.PasswordChar= '*';
                isHide= true;
            }
            else
            {
                btnSeePass.BackgroundImage = Properties.Resources.icon_openEye;
                tbPassword.PasswordChar = '\0';
                isHide= false;
            }
            
            
        }

        private bool InputValidator()
        {
            string usn = tbUsername.Text.Trim();
            string psw = tbPassword.Text.Trim();
            myDAL DAL = new myDAL();

            if (usn.Equals("")||psw.Equals(""))
            {
                errlabel.Text = "Username/Password is empty";
                return false;
            }
            else if (!DAL.UserExists(usn, psw))
            {
                errlabel.Text = "Incorrect Username/Password";
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (InputValidator())
            {
                frmMainController f = new frmMainController();
                f.Show();
                this.Hide();
            }
            else
            {
                errlabel.Show();
            }

        }
    }
}
