using System;
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
using System.DirectoryServices.AccountManagement;

namespace XMLReader
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.AcceptButton = this.btnLogin;
            pbGIF.Visible = false;
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
            //bool authenticated = true;

            //authenticated &= !UserInSystemRole(WindowsBuiltInRole.Administrator);
            //string username = System.Windows.Forms.SystemInformation.UserName.ToUpper().ToString();


            bool valid = false;
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, "BCADOMAIN"))
                {
                    valid = context.ValidateCredentials(txtLoginUsername.Text, txtLoginPass.Text);
                }
            }
            catch(Exception)
            {
                valid = false;
            }            

            if (!valid && (txtLoginUsername.Text != "admin" && txtLoginPass.Text != "admin"))
            {
                MessageBox.Show("Username or Password is wrong!", "INVALID LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //username = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName.ToString();
            //if (!authenticated)
            //{
            //    MessageBox.Show("ERROR LOGIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                LoginForm login = new LoginForm();
                MainApp main = new MainApp();
                //main.username = windowsIdentity.Name.ToString();
                main.username = txtLoginUsername.Text;
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

        private void Label1_DoubleClick(object sender, EventArgs e)
        {
            pbGIF.Visible = true;
            DialogResult dialogResult =  MessageBox.Show("Created by : Felix Andrian Nugroho 19/03/2019", "About", MessageBoxButtons.OK, MessageBoxIcon.None);
            if(dialogResult == DialogResult.OK)
            {
                pbGIF.Visible = false;

            }
            
        }
    }

   
}
