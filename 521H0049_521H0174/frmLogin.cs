﻿using System;
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

        private void InputValidator()
        {
            string usn = tbUsername.Text.Trim();
            string psw = tbPassword.Text.Trim();
            myDAL DAL = new myDAL();

            if (usn.Equals("")||psw.Equals(""))
            {
                errlabel.Text = "Username/Password is empty";
                errlabel.Show();
            }
            else if (!DAL.UserExists(usn, psw))
            {
                errlabel.Text = "Incorrect Username/Password";
                errlabel.Show();
            }
            else
            {
                frmMainController f = new frmMainController();
                f.Show();
                this.Hide();
            }
            
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            InputValidator();
        }

        private void User_EnterKeyPressed(object sender, KeyPressEventArgs e)
        {
            InputValidator();
        }

        private void password_EnterKeyPressed(object sender, KeyPressEventArgs e)
        {
            InputValidator();
        }
    }
}
