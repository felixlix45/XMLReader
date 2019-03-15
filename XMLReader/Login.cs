using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            MainApp main = new MainApp();
            main.username = txtLoginUsername.Text;
            main.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }


    }

   
}
