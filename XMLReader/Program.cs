using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyApplicationContext context = new MyApplicationContext();
            
            Application.Run(context);
        }

        public class MyApplicationContext : ApplicationContext
        {
            private LoginForm login = new LoginForm();
            private MainApp main = new MainApp();
            public MyApplicationContext()
            {
                main.Show();
            }
        }
    }
}
