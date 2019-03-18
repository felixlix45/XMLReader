﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

using System.IO;
using System.Threading;

namespace XMLReader
{
    public partial class LoginForm : Form
    {

        

        
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.AcceptButton = this.btnLogin;
        }

        public bool UserInSystemRole(WindowsBuiltInRole role)
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(role);
        }

        private static IntPtr LogonUser()
        {
            IntPtr accountToken = WindowsIdentity.GetCurrent().Token;
            //Console.WriteLine("Token number is: " + accountToken.ToString());
            return accountToken;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            IntPtr logonToken = LogonUser();
            WindowsIdentity windowsIdentity = new WindowsIdentity(logonToken);
            bool authenticated = true;
            string username;
            string password = string.Empty;
            authenticated &= !UserInSystemRole(WindowsBuiltInRole.Administrator);
            username = System.Windows.Forms.SystemInformation.UserName.ToUpper().ToString();
            

            //Error ketika dicoba
            //username = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName.ToString();
            if (!authenticated)
            {
                MessageBox.Show("ERROR LOGIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoginForm login = new LoginForm();
                MainApp main = new MainApp();
                //main.username = windowsIdentity.Name.ToString();
                main.username = username;
                main.Show();
                this.Hide();
            }


            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }


    }

   
}
