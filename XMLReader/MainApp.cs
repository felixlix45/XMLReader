using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;

// Magic. Do not touch.

// TODO: disable txtusername when open button clicked
// TODO: Add logout button

namespace XMLReader
{
   
    public partial class MainApp : Form
    {
        public string username { get; set; }
        XmlDocument xdoc = new XmlDocument();
        XDocument doc;
        string path = "";
        int flag = 0;
        int indexRowConString = 0;
        string tempKey = "";
        string tempValue = "";

        int flagConString = 0;
        string finalString = "";
        string dataSource = "", integratedSecurity = "", attachDBFilename = "", userInstance = "";

        string initialCatalog = "", persistySecInfo = "", userID = "", password = "";

        string tempName = "", tempProv = "";
        string tempData = "", tempSecurity = "", tempDBFilename = "", tempUser = "";
        string oldPassword = "";

        
        public MainApp()
        {

            InitializeComponent();
            this.CenterToScreen();
            tabControl1.Enabled = false;
            btnRefresh.Enabled = false;
            btnLogout.Visible = false;
            btnOpen.Enabled = false;
            btnSaveAs.Enabled = false;
            this.lblName.Text = "Name :  " + this.username;
        }

        public void log(string text)
        {
            var time = DateTime.Now;
            string newTime = time.ToString("dd-MM-yyyy, hh:mm:ss");
            string logPath = "";
            if (Directory.Exists("D://"))
            {
                DirectoryInfo di = System.IO.Directory.CreateDirectory("D:\\XML_Reader\\Log");
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                logPath = @"D:\XML_Reader\Log\log.txt";
            }
            else
            {
                DirectoryInfo di = System.IO.Directory.CreateDirectory("C:\\XML_Reader\\Log");
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                logPath = @"C:\XML_Reader\Log\log.txt";
            }
           
            if (!File.Exists(logPath)){
                File.Create(logPath).Dispose();
                using(TextWriter tw = new StreamWriter(logPath))
                {
                    tw.WriteLine("LOG");
                    tw.WriteLine("====================================================");
                    tw.WriteLine("[USER] => " + txtUsername.Text.ToUpper() + "\n" + newTime + " " + text);
                    tw.WriteLine("\n");
                }
            }
            else
            {
                using (TextWriter tw = new StreamWriter(logPath, true))
                {
                    tw.WriteLine("====================================================");
                    tw.WriteLine("[USER] => " + txtUsername.Text.ToUpper() + "\n" + newTime + " " +  text);
                    tw.WriteLine("\n");
                }
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void CbAddConShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAddConShowPass.Checked == true)
            {
                txtConAddPass.PasswordChar = '\0';
            }
            else
            {
                txtConAddPass.PasswordChar = '*';
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //this.Close();
            //LoginForm login = new LoginForm();
            //login.Show();

            gvAppSetting.DataSource = null;
            gvConString.DataSource = null;
            btnOpen.Enabled = false;
            tabControl1.Enabled = false;
            btnRefresh.Enabled = false;
            txtUsername.Enabled = true;
            btnLogout.Visible = false;
            btnLogout.Enabled = false;
            btnSaveAs.Enabled = false;
            txtUsername.Text = "";
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            bindGrid();
            
        }

        private void LblUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.TextLength > 2)
            {
                btnOpen.Enabled = true;
                
            }
            else
            {
                btnOpen.Enabled = false;
               
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To use this application you must : \n" +
                "1. Insert your name\n" +
                "2. Open XML/Config file\n\n" +
                "Your file is AUTOMATICALLY saved when you click Add, Delete (there is confirmation to delete), or Update button.\n\n" +
                "If you want to save your file into another directory, you can click the Save As button.\n\n" +
                "Once you click Open button, you must logout first to change your name.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Filter = "xml files (*.xml, *.config) | *.xml; *.config",
                FilterIndex = 1,
                Multiselect = false
            };

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                tabControl1.Enabled = true;
                path = openFile.FileName;
                bindGrid();
                btnRefresh.Enabled = true;
                txtUsername.Enabled = false;
                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                btnSaveAs.Enabled = false;
            }
        }

        public void bindGrid()
        {
            flag = 1;
            doc = XDocument.Load(path);
            xdoc.Load(path);
            var query = from b in doc.Descendants("appSettings").Descendants("add")
                        select new
                        {
                            Key = b.Attribute("key").Value,
                            Value = b.Attribute("value").Value
                        };

            var query2 = from b in doc.Descendants("connectionStrings").Descendants("add")
                         select new
                         {
                             Name = b.Attribute("name").Value,
                             connectionString = b.Attribute("connectionString").Value,
                             ProviderName = b.Attribute("providerName").Value
                        };
            gvAppSetting.DataSource = query.ToList();
            gvConString.DataSource = query2.ToList();
            gvConString.Columns["connectionString"].Visible = false;
           
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML File (*.xml)|*.xml | Config FIle (*.config) | *.config";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.InitialDirectory = @"C:/";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.CheckPathExists = true;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xdoc.Save(saveFileDialog1.FileName);
            }
        }

        private void GvAppSetting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                tabControl1.SelectedIndex = 0;
                flag = 2;
                txtAppKey.Text = gvAppSetting.Rows[e.RowIndex].Cells["Key"].Value.ToString();
                txtAppValue.Text = gvAppSetting.Rows[e.RowIndex].Cells["Value"].Value.ToString();
                tempKey = txtAppKey.Text;
                tempValue = txtAppValue.Text;
            }
            
        }

        private void BtnAppDelete_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Please click Open XML first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flag != 2)
            {
                MessageBox.Show("Please select the item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                {
                    XmlNode node = xdoc.SelectSingleNode("//add[@key='" + txtAppKey.Text + "']");
                    if (node != null)
                    {
                        node.ParentNode.RemoveChild(node);
                        xdoc.Save(path);
                        bindGrid();
                        log("[DELETED] => App Settings \n" +
                            "====================================================" +
                            "\n Key : " + txtAppKey.Text + "\n Value : " + txtAppValue.Text);
                        MessageBox.Show("Deleted & Saved", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAppKey.Text = "";
                        txtAppValue.Text = "";
                    }
                }
                
            }
            
        }

        private void BtnAppUpdate_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Please click Open XML first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flag != 2)
            {
                MessageBox.Show("Please select the item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAppKey.Text == tempKey && txtAppValue.Text == tempValue)
            {
                MessageBox.Show("Nothing to update", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                XmlNode node = xdoc.SelectSingleNode("//add[@key='" + txtAppKey.Text + "']");
                node.Attributes["key"].Value = txtAppKey.Text;
                node.Attributes["value"].Value = txtAppValue.Text;
                xdoc.Save(path);
                bindGrid();
                log("[UPDATE] => App setting \n" +
                           "====================================================\n" +
                           " [OLD] => Key : " + tempKey + "\n\t  Value : " + tempValue + "\n" +
                           " [NEW] => Key : " + txtAppKey.Text + "\n\t  Value : " + txtAppValue.Text);
                MessageBox.Show("Updated & Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAppKey.Text = "";
                txtAppValue.Text = "";
            }
            
        }

        private void BtnAppAdd_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Please click Open XML first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAppAddKey.Text == "" || txtAppAddValue.Text == "")
            {
                MessageBox.Show("Please fill all the column!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XElement emp = new XElement("add",
                    new XAttribute("key", txtAppAddKey.Text),
                    new XAttribute("value", txtAppAddValue.Text));
                doc.Descendants("appSettings").FirstOrDefault().Add(emp);
                doc.Save(path);
                bindGrid();
                log("[ADDED] => App Settings \n" +
                    "====================================================\n" +
                    " Key : " + txtAppAddKey.Text + "\n Value : " + txtAppAddValue.Text);
                MessageBox.Show("Added & Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAppAddKey.Text = "";
                txtAppAddValue.Text = "";
                
            }
        }

        private void GvConString_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                tabControl1.SelectedIndex = 1;

                indexRowConString = e.RowIndex;
                int counter = 0;
                string text = gvConString.Rows[e.RowIndex].Cells["connectionString"].Value.ToString();
                string name = gvConString.Rows[e.RowIndex].Cells["name"].Value.ToString();
                dataSource = "";
                integratedSecurity = "";
                attachDBFilename = "";
                userInstance = "";

                initialCatalog = "";
                persistySecInfo = "";
                userID = "";
                password = "";


                if (string.Equals(name, "ApplicationServices"))
                {


                    lblConSecurity.Text = "Integrated Security :";
                    lblConDBFile.Text = "Attach DB Filename :";
                    lblConUser.Text = "User Instance :";

                    txtConName.Text = "";
                    txtConProv.Text = "";
                    txtConData.Text = "";
                    txtConDBFilename.Text = "";
                    txtConSecurity.Text = "";
                    txtConDBFilename.Text = "";
                    txtConUser.Text = "";
                    txtConOldPass.Text = "";

                    txtConName.Text = gvConString.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    txtConProv.Text = gvConString.Rows[e.RowIndex].Cells["providerName"].Value.ToString();

                    tempName = txtConName.Text;
                    tempProv = txtConProv.Text;
                    flag = 2;
                    flagConString = 0;
                    txtConOldPass.ReadOnly = true;
                    txtConNewPass.ReadOnly = true;
                    txtConConPass.ReadOnly = true;
                    cbConShowOldPass.Enabled = false;

                    //Get every connectionstring attribute detail
                    //Data Source, DB Filename, User Instance, etc              
                    for (int i = 0; i < text.Length - 1; i++)
                    {

                        if (text[i].Equals('=') && !text[i + 1].Equals(';'))
                        {
                            if (counter == 0)
                            {
                                while (!text[i + 1].Equals(';'))
                                {
                                    dataSource = dataSource + text[i + 1];
                                    i++;
                                }
                                counter = 1;
                            }
                            else if (counter == 1)
                            {
                                while (!text[i + 1].Equals(';'))
                                {
                                    integratedSecurity = integratedSecurity + text[i + 1];
                                    i++;
                                }

                                counter = 2;
                            }
                            else if (counter == 2)
                            {
                                while (!text[i + 1].Equals(';'))
                                {
                                    attachDBFilename = attachDBFilename + text[i + 1];
                                    i++;
                                }

                                counter = 3;
                            }
                            else if (counter == 3)
                            {
                                while (i != text.Length - 1)
                                {
                                    userInstance = userInstance + text[i + 1];
                                    i++;
                                }
                                counter = 4;
                            }

                        }

                        txtConData.Text = dataSource;
                        txtConSecurity.Text = integratedSecurity;
                        txtConDBFilename.Text = attachDBFilename;
                        txtConUser.Text = userInstance;
                        finalString = "data Source=" + txtConData.Text + ";Integrated Security=" + txtConSecurity.Text + ";AttachDBFilename=" + txtConDBFilename.Text + ";User Instance=" + txtConUser.Text;

                        txtConOldPass.Text = "";
                        txtConNewPass.Text = "";
                        txtConConPass.Text = "";
                        tempData = dataSource;
                        tempSecurity = integratedSecurity;
                        tempDBFilename = attachDBFilename;
                        tempUser = userInstance;
                        txtConName.ReadOnly = true;

                    }
                }
                else
                {
                    txtConName.Text = "";
                    txtConProv.Text = "";
                    txtConData.Text = "";
                    txtConDBFilename.Text = "";
                    txtConSecurity.Text = "";
                    txtConDBFilename.Text = "";
                    txtConUser.Text = "";
                    txtConOldPass.Text = "";
                    txtConNewPass.Text = "";
                    txtConConPass.Text = "";

                    txtConName.Text = gvConString.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    txtConProv.Text = gvConString.Rows[e.RowIndex].Cells["providerName"].Value.ToString();

                    tempName = txtConName.Text;
                    tempProv = txtConProv.Text;

                    flag = 2;
                    flagConString = 1;
                    txtConOldPass.ReadOnly = false;
                    txtConNewPass.ReadOnly = false;
                    txtConConPass.ReadOnly = false;
                    cbConShowOldPass.Enabled = true;
                    lblConSecurity.Text = "Initial Catalog :";
                    lblConDBFile.Text = "Persist Security Info";
                    lblConUser.Text = "User ID";

                    for (int i = 0; i < text.Length - 1; i++)
                    {

                        if (text[i].Equals('=') && !text[i + 1].Equals(';'))
                        {
                            if (counter == 0)
                            {
                                while (!text[i + 1].Equals(';'))
                                {
                                    dataSource = dataSource + text[i + 1];
                                    i++;
                                }
                                counter = 1;
                            }
                            else if (counter == 1)
                            {
                                while (!text[i + 1].Equals(';'))
                                {
                                    initialCatalog = initialCatalog + text[i + 1];
                                    i++;
                                }

                                counter = 2;
                            }
                            else if (counter == 2)
                            {
                                while (!text[i + 1].Equals(';'))
                                {
                                    persistySecInfo = persistySecInfo + text[i + 1];
                                    i++;
                                }

                                counter = 3;
                            }
                            else if (counter == 3)
                            {
                                while (!text[i + 1].Equals(';'))
                                {
                                    userID = userID + text[i + 1];
                                    i++;
                                }

                                counter = 4;
                            }
                            else if (counter == 4)
                            {
                                while (i != text.Length - 2)
                                {
                                    password = password + text[i + 1];
                                    i++;
                                }
                                counter = 5;
                            }
                        }
                        finalString = "Data Source=" + txtConData.Text + ";Initial Catalog=" + txtConSecurity.Text + ";Persist Security Info=" + txtConDBFilename.Text + ";User ID=" + txtConUser.Text + ";Password=" + password + ";";
                        txtConData.Text = dataSource;
                        txtConSecurity.Text = initialCatalog;
                        txtConDBFilename.Text = persistySecInfo;
                        txtConUser.Text = userID;
                        txtConOldPass.Text = "";
                        tempData = dataSource;
                        tempSecurity = initialCatalog;
                        tempDBFilename = persistySecInfo;
                        tempUser = userID;
                        oldPassword = password;
                        txtConName.ReadOnly = false;
                    }
                }
            }
            
        }

        private void BtnConDelete_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Please click Open XML first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flag != 2)
            {
                MessageBox.Show("Please select the item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.Equals(tempName, "ApplicationServices"))
            {
                MessageBox.Show("You can't delete this item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (oldPassword != txtConOldPass.Text)
            {
                MessageBox.Show("You need the correct old password to delete this item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                {
                    XmlNode node = xdoc.SelectSingleNode("//add[@name='" + txtConName.Text + "']");

                    if (node != null)
                    {
                        node.ParentNode.RemoveChild(node);
                        xdoc.Save(path);
                        bindGrid();
                        MessageBox.Show("Deleted & Saved", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        log("[DELETED] => Connection String\n" +
                            "====================================================\n" +
                            " Name : " + txtConName.Text + "\n Connection String : " + finalString + "\n Provider Name : " + txtConProv.Text);
                        txtConName.Text = "";
                        txtConProv.Text = "";
                        txtConData.Text = "";
                        txtConDBFilename.Text = "";
                        txtConUser.Text = "";
                        txtConSecurity.Text = "";
                        txtConOldPass.Text = "";
                        txtConNewPass.Text = "";
                        txtConConPass.Text = "";
                        cbConShowOldPass.Checked = false;

                    }
                }
                
               
            }
        }

        private void BtnConUpdate_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Please click Open XML first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flag != 2)
            {
                MessageBox.Show("Please select the item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string tempFinalString = finalString;
                
                if (string.Equals(tempName, "ApplicationServices"))
                {
                    if (string.Equals(txtConName.Text, tempName) && string.Equals(txtConProv.Text, tempProv) && txtConData.Text == tempData && txtConSecurity.Text == tempSecurity && txtConDBFilename.Text == tempDBFilename && txtConUser.Text == tempUser)
                    {
                        MessageBox.Show("Nothing to update", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        finalString = "data Source=" + txtConData.Text + ";Integrated Security=" + txtConSecurity.Text + ";AttachDBFilename=" + txtConDBFilename.Text + ";User Instance=" + txtConUser.Text;
                        XmlNode node = xdoc.SelectSingleNode("//add[@name='" + tempName + "']");
                        node.Attributes["connectionString"].Value = finalString;
                        node.Attributes["providerName"].Value = txtConProv.Text;
                        xdoc.Save(path);
                        bindGrid();
                        log("[UPDATE] => Connection Strings \n" +
                            "====================================================\n" +
                               " [OLD] => Name : " + tempName + "\n \t  Connection String : " + tempFinalString + "\n \t  Provider Name : " + tempProv + "\n" +
                               " [NEW] => Name : " + txtConName.Text + "\n \t  Connection String : " + finalString + "\n \t  Provider Name : " + txtConProv.Text);
                        MessageBox.Show("Updated & Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (string.Equals(txtConName.Text, tempName) && string.Equals(txtConProv.Text, tempProv) && txtConData.Text == tempData && txtConSecurity.Text == tempSecurity && txtConDBFilename.Text == tempDBFilename && txtConUser.Text == tempUser && txtConOldPass.Text == txtConNewPass.Text)
                    {
                        MessageBox.Show("Nothing to update", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (string.Equals(txtConName.Text, "") || string.Equals(txtConProv.Text, "") || txtConData.Text == "" || txtConSecurity.Text == "" || txtConDBFilename.Text == "" || txtConUser.Text == "")
                    {
                        MessageBox.Show("Please fill all the column", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (oldPassword != txtConOldPass.Text)
                    {
                        MessageBox.Show("Old password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtConNewPass.Text == "" && txtConConPass.Text == "")
                    {
                        MessageBox.Show("If you want to update this item without updating the old password, please just insert the new password as the old password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(txtConNewPass.Text != txtConConPass.Text)
                    {
                        MessageBox.Show("New Password and Confirm Password is different", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        finalString = "Data Source=" + txtConData.Text + ";Initial Catalog=" + txtConSecurity.Text + ";Persist Security Info=" + txtConDBFilename.Text + ";User ID=" + txtConUser.Text + ";Password=" + txtConNewPass.Text + ";";
                        XmlNode node = xdoc.SelectSingleNode("//add[@name='" + tempName + "']");
                        node.Attributes["connectionString"].Value = finalString;
                        node.Attributes["providerName"].Value = txtConProv.Text;

                        xdoc.Save(path);
                        bindGrid();
                        log("[UPDATE] => Connection Strings \n" +
                            "====================================================\n" +
                               " [OLD] => Name : " + tempName + "\n \t  Connection String : " + tempFinalString + "\n \t  Provider Name : " + tempProv + "\n" +
                               " [NEW] => Name : " + txtConName.Text + "\n \t  Connection String : " + finalString + "\n \t  Provider Name : " + txtConProv.Text);
                        MessageBox.Show("Updated & Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                txtConName.Text = "";
                txtConProv.Text = "";
                txtConData.Text = "";
                txtConSecurity.Text = "";
                txtConDBFilename.Text = "";
                txtConUser.Text = "";
                txtConOldPass.Text = "";
                txtConNewPass.Text = "";
                txtConConPass.Text = "";
                cbConShowOldPass.Checked = false;
                flag = 1;
                
            }
        }

        private void BtnConAdd_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Please click Open XML first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.Equals(txtConAddName.Text, "") || string.Equals(txtConAddProv.Text , "" ) || txtConAddData.Text == "" || txtConAddSecurity.Text == "" || txtConAddDBFilename.Text == "" || txtConAddUser.Text == "")
            {
                MessageBox.Show("Something is missing, check your input again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(string.Equals(txtConAddName.Text, "ApplicationServices"))
                {
                    MessageBox.Show("You cannot add this item", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finalString = "Data Source=" + txtConAddData.Text + ";Initial Catalog=" + txtConAddSecurity.Text + ";Persist Security Info=" + txtConAddDBFilename.Text + ";User ID=" + txtConAddUser.Text + ";Password=" + txtConAddPass.Text + ";";
                
                XElement emp = new XElement("add",
                    new XAttribute("name", txtConAddName.Text),
                    new XAttribute("connectionString", finalString),
                    new XAttribute("providerName", txtConAddProv.Text));
                doc.Descendants("connectionStrings").FirstOrDefault().Add(emp);
                MessageBox.Show("Added & Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doc.Save(path);
                bindGrid();
                log("[ADDED] Connection Strings \n" +
                    "====================================================\n" +
                    " Name : " + txtConAddName.Text + "\n Connection String : " + finalString + "\n Provider Name : " + txtConAddProv.Text);
                txtConAddData.Text = "";
                txtConAddDBFilename.Text = "";
                txtConAddName.Text = "";
                txtConAddProv.Text = "";
                txtConAddPass.Text = "";
                txtConAddSecurity.Text = "";
                txtConAddUser.Text = "";
                cbAddConShowPass.Checked = false;
            }
        }

        private void CbConShowOldPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConShowOldPass.Checked == true)
            {
                txtConOldPass.PasswordChar = '\0';
                txtConNewPass.PasswordChar = '\0';
                txtConConPass.PasswordChar = '\0';
            }
            else
            {
                txtConOldPass.PasswordChar = '*';
                txtConNewPass.PasswordChar = '*';
                txtConConPass.PasswordChar = '*';
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

    }

    public static class XElementExtensions
    {
        public static DataTable ToDataTable(this XElement element)
        {
            DataSet ds = new DataSet();
            string rawXml = element.ToString();
            ds.ReadXml(new StringReader(rawXml));
            return ds.Tables[0];
        }


        public static DataTable ToDataTable(this IEnumerable<XElement> elements)
        {
            return ToDataTable(new XElement("Root", elements));
        }
    }


}
