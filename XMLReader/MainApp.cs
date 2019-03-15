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

namespace XMLReader
{
   
    public partial class MainApp : Form
    {
        XmlDocument xdoc = new XmlDocument();
        XDocument doc;
        string path = "";
        int flag = 0;

        string tempKey = "";
        string tempValue = "";
        
        public MainApp()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        public void log(string text)
        {
            var time = DateTime.Now;
            string newTime = time.ToString("dd-mm-yyyy, hh:mm:ss");
            string logPath = @"D:\log.txt";
            if (!File.Exists(logPath)){
                File.Create(logPath).Dispose();

                using(TextWriter tw = new StreamWriter(logPath))
                {
                    tw.WriteLine(newTime + " " + text);
                }
            }
            else
            {
                using (TextWriter tw = new StreamWriter(logPath, true))
                {
                    tw.WriteLine(newTime + " " +  text);
                    tw.WriteLine("");
                }
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Filter = "xml files (*.xml) | *.xml | All Files (*.*) | *.*"
            };

            if(openFile.ShowDialog() == DialogResult.OK)
            {

                
                path = openFile.FileName;
                bindGrid();
                //xdoc.Load(path);
                
                

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

        private void GvAppSetting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 2;
            txtAppKey.Text = gvAppSetting.Rows[e.RowIndex].Cells["Key"].Value.ToString();
            txtAppValue.Text = gvAppSetting.Rows[e.RowIndex].Cells["Value"].Value.ToString();
            tempKey = txtAppKey.Text;
            tempValue = txtAppValue.Text;
        }

        private void BtnAppDelete_Click(object sender, EventArgs e)
        {
            XmlNode node = xdoc.SelectSingleNode("//add[@key='" + txtAppKey.Text + "']");
            if(node != null)
            {
                node.ParentNode.RemoveChild(node);
                xdoc.Save(path);
                bindGrid();
                log("[DELETED] App Settings \n Key : " + txtAppKey.Text + "\n Value : " + txtAppValue.Text);
                MessageBox.Show("Deleted & Saved", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                txtAppKey.Text = "";
                txtAppValue.Text = "";
                log("[UPDATE] App setting \n" +
                           " [OLD] : Key : " + tempKey + "\n\tValue : " + tempValue + "\n" +
                           " [NEW] : Key : " + txtAppKey.Text + "\n\tValue : " + txtAppValue.Text);
                MessageBox.Show("Updated & Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtAppAddKey.Text = "";
                txtAppAddValue.Text = "";
                
            }
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
