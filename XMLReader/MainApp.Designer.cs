namespace XMLReader
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAppDelete = new System.Windows.Forms.Button();
            this.txtAppValue = new System.Windows.Forms.TextBox();
            this.txtAppKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAppUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAppAddValue = new System.Windows.Forms.TextBox();
            this.txtAppAddKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAppAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnConDelete = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtConConPass = new System.Windows.Forms.TextBox();
            this.txtConNewPass = new System.Windows.Forms.TextBox();
            this.cbConShowOldPass = new System.Windows.Forms.CheckBox();
            this.txtConUser = new System.Windows.Forms.TextBox();
            this.txtConDBFilename = new System.Windows.Forms.TextBox();
            this.txtConOldPass = new System.Windows.Forms.TextBox();
            this.txtConSecurity = new System.Windows.Forms.TextBox();
            this.lblConUser = new System.Windows.Forms.Label();
            this.lblConDBFile = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblConSecurity = new System.Windows.Forms.Label();
            this.txtConData = new System.Windows.Forms.TextBox();
            this.lblConData = new System.Windows.Forms.Label();
            this.txtConProv = new System.Windows.Forms.TextBox();
            this.txtConName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnConUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbAddConShowPass = new System.Windows.Forms.CheckBox();
            this.txtConAddUser = new System.Windows.Forms.TextBox();
            this.txtConAddDBFilename = new System.Windows.Forms.TextBox();
            this.txtConAddPass = new System.Windows.Forms.TextBox();
            this.txtConAddSecurity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConAddData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConAddProv = new System.Windows.Forms.TextBox();
            this.txtConAddName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConAdd = new System.Windows.Forms.Button();
            this.gvAppSetting = new System.Windows.Forms.DataGridView();
            this.gvConString = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.pbGIF = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAppSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(38, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1228, 384);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbGIF);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1220, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "App Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAppDelete);
            this.groupBox2.Controls.Add(this.txtAppValue);
            this.groupBox2.Controls.Add(this.txtAppKey);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAppUpdate);
            this.groupBox2.Location = new System.Drawing.Point(674, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 288);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update and Delete";
            // 
            // btnAppDelete
            // 
            this.btnAppDelete.Location = new System.Drawing.Point(58, 222);
            this.btnAppDelete.Name = "btnAppDelete";
            this.btnAppDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAppDelete.TabIndex = 5;
            this.btnAppDelete.Text = "Delete";
            this.btnAppDelete.UseVisualStyleBackColor = true;
            this.btnAppDelete.Click += new System.EventHandler(this.BtnAppDelete_Click);
            // 
            // txtAppValue
            // 
            this.txtAppValue.Location = new System.Drawing.Point(138, 94);
            this.txtAppValue.Name = "txtAppValue";
            this.txtAppValue.Size = new System.Drawing.Size(164, 20);
            this.txtAppValue.TabIndex = 4;
            // 
            // txtAppKey
            // 
            this.txtAppKey.Location = new System.Drawing.Point(138, 46);
            this.txtAppKey.Name = "txtAppKey";
            this.txtAppKey.ReadOnly = true;
            this.txtAppKey.Size = new System.Drawing.Size(164, 20);
            this.txtAppKey.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Key :";
            // 
            // btnAppUpdate
            // 
            this.btnAppUpdate.Location = new System.Drawing.Point(396, 222);
            this.btnAppUpdate.Name = "btnAppUpdate";
            this.btnAppUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAppUpdate.TabIndex = 0;
            this.btnAppUpdate.Text = "Update";
            this.btnAppUpdate.UseVisualStyleBackColor = true;
            this.btnAppUpdate.Click += new System.EventHandler(this.BtnAppUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAppAddValue);
            this.groupBox1.Controls.Add(this.txtAppAddKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAppAdd);
            this.groupBox1.Location = new System.Drawing.Point(27, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // txtAppAddValue
            // 
            this.txtAppAddValue.Location = new System.Drawing.Point(138, 94);
            this.txtAppAddValue.Name = "txtAppAddValue";
            this.txtAppAddValue.Size = new System.Drawing.Size(164, 20);
            this.txtAppAddValue.TabIndex = 4;
            // 
            // txtAppAddKey
            // 
            this.txtAppAddKey.Location = new System.Drawing.Point(138, 46);
            this.txtAppAddKey.Name = "txtAppAddKey";
            this.txtAppAddKey.Size = new System.Drawing.Size(164, 20);
            this.txtAppAddKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key :";
            // 
            // btnAppAdd
            // 
            this.btnAppAdd.Location = new System.Drawing.Point(368, 222);
            this.btnAppAdd.Name = "btnAppAdd";
            this.btnAppAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAppAdd.TabIndex = 0;
            this.btnAppAdd.Text = "Add";
            this.btnAppAdd.UseVisualStyleBackColor = true;
            this.btnAppAdd.Click += new System.EventHandler(this.BtnAppAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1220, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection String";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnConDelete);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.txtConProv);
            this.groupBox5.Controls.Add(this.txtConName);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.btnConUpdate);
            this.groupBox5.Location = new System.Drawing.Point(643, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(560, 325);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Update and Delete";
            // 
            // btnConDelete
            // 
            this.btnConDelete.Location = new System.Drawing.Point(30, 296);
            this.btnConDelete.Name = "btnConDelete";
            this.btnConDelete.Size = new System.Drawing.Size(75, 23);
            this.btnConDelete.TabIndex = 6;
            this.btnConDelete.Text = "Delete";
            this.btnConDelete.UseVisualStyleBackColor = true;
            this.btnConDelete.Click += new System.EventHandler(this.BtnConDelete_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.txtConConPass);
            this.groupBox6.Controls.Add(this.txtConNewPass);
            this.groupBox6.Controls.Add(this.cbConShowOldPass);
            this.groupBox6.Controls.Add(this.txtConUser);
            this.groupBox6.Controls.Add(this.txtConDBFilename);
            this.groupBox6.Controls.Add(this.txtConOldPass);
            this.groupBox6.Controls.Add(this.txtConSecurity);
            this.groupBox6.Controls.Add(this.lblConUser);
            this.groupBox6.Controls.Add(this.lblConDBFile);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.lblConSecurity);
            this.groupBox6.Controls.Add(this.txtConData);
            this.groupBox6.Controls.Add(this.lblConData);
            this.groupBox6.Location = new System.Drawing.Point(10, 57);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(530, 233);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Connection String";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(17, 194);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 15);
            this.label20.TabIndex = 19;
            this.label20.Text = "Confirm Password :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "New Password :";
            // 
            // txtConConPass
            // 
            this.txtConConPass.Location = new System.Drawing.Point(140, 194);
            this.txtConConPass.Name = "txtConConPass";
            this.txtConConPass.PasswordChar = '*';
            this.txtConConPass.Size = new System.Drawing.Size(126, 20);
            this.txtConConPass.TabIndex = 17;
            // 
            // txtConNewPass
            // 
            this.txtConNewPass.Location = new System.Drawing.Point(140, 159);
            this.txtConNewPass.Name = "txtConNewPass";
            this.txtConNewPass.PasswordChar = '*';
            this.txtConNewPass.Size = new System.Drawing.Size(126, 20);
            this.txtConNewPass.TabIndex = 16;
            // 
            // cbConShowOldPass
            // 
            this.cbConShowOldPass.AutoSize = true;
            this.cbConShowOldPass.Location = new System.Drawing.Point(291, 125);
            this.cbConShowOldPass.Name = "cbConShowOldPass";
            this.cbConShowOldPass.Size = new System.Drawing.Size(102, 17);
            this.cbConShowOldPass.TabIndex = 15;
            this.cbConShowOldPass.Text = "Show Password";
            this.cbConShowOldPass.UseVisualStyleBackColor = true;
            this.cbConShowOldPass.CheckedChanged += new System.EventHandler(this.CbConShowOldPass_CheckedChanged);
            // 
            // txtConUser
            // 
            this.txtConUser.Location = new System.Drawing.Point(366, 81);
            this.txtConUser.Name = "txtConUser";
            this.txtConUser.Size = new System.Drawing.Size(126, 20);
            this.txtConUser.TabIndex = 14;
            // 
            // txtConDBFilename
            // 
            this.txtConDBFilename.Location = new System.Drawing.Point(398, 37);
            this.txtConDBFilename.Name = "txtConDBFilename";
            this.txtConDBFilename.Size = new System.Drawing.Size(126, 20);
            this.txtConDBFilename.TabIndex = 13;
            // 
            // txtConOldPass
            // 
            this.txtConOldPass.Location = new System.Drawing.Point(140, 123);
            this.txtConOldPass.Name = "txtConOldPass";
            this.txtConOldPass.PasswordChar = '*';
            this.txtConOldPass.Size = new System.Drawing.Size(126, 20);
            this.txtConOldPass.TabIndex = 12;
            // 
            // txtConSecurity
            // 
            this.txtConSecurity.Location = new System.Drawing.Point(140, 78);
            this.txtConSecurity.Name = "txtConSecurity";
            this.txtConSecurity.Size = new System.Drawing.Size(126, 20);
            this.txtConSecurity.TabIndex = 11;
            // 
            // lblConUser
            // 
            this.lblConUser.AutoSize = true;
            this.lblConUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConUser.Location = new System.Drawing.Point(272, 81);
            this.lblConUser.Name = "lblConUser";
            this.lblConUser.Size = new System.Drawing.Size(88, 15);
            this.lblConUser.TabIndex = 10;
            this.lblConUser.Text = "User Instance :";
            // 
            // lblConDBFile
            // 
            this.lblConDBFile.AutoSize = true;
            this.lblConDBFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConDBFile.Location = new System.Drawing.Point(272, 37);
            this.lblConDBFile.Name = "lblConDBFile";
            this.lblConDBFile.Size = new System.Drawing.Size(121, 15);
            this.lblConDBFile.TabIndex = 9;
            this.lblConDBFile.Text = "Attach DB FIlename :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Old Password :";
            // 
            // lblConSecurity
            // 
            this.lblConSecurity.AutoSize = true;
            this.lblConSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConSecurity.Location = new System.Drawing.Point(17, 81);
            this.lblConSecurity.Name = "lblConSecurity";
            this.lblConSecurity.Size = new System.Drawing.Size(114, 15);
            this.lblConSecurity.TabIndex = 7;
            this.lblConSecurity.Text = "Integrated Security :";
            // 
            // txtConData
            // 
            this.txtConData.Location = new System.Drawing.Point(104, 37);
            this.txtConData.Name = "txtConData";
            this.txtConData.Size = new System.Drawing.Size(126, 20);
            this.txtConData.TabIndex = 6;
            // 
            // lblConData
            // 
            this.lblConData.AutoSize = true;
            this.lblConData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConData.Location = new System.Drawing.Point(17, 37);
            this.lblConData.Name = "lblConData";
            this.lblConData.Size = new System.Drawing.Size(81, 15);
            this.lblConData.TabIndex = 6;
            this.lblConData.Text = "Data Source :";
            // 
            // txtConProv
            // 
            this.txtConProv.Location = new System.Drawing.Point(392, 19);
            this.txtConProv.Name = "txtConProv";
            this.txtConProv.Size = new System.Drawing.Size(148, 20);
            this.txtConProv.TabIndex = 4;
            // 
            // txtConName
            // 
            this.txtConName.Location = new System.Drawing.Point(71, 19);
            this.txtConName.Name = "txtConName";
            this.txtConName.ReadOnly = true;
            this.txtConName.Size = new System.Drawing.Size(148, 20);
            this.txtConName.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(250, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Provider Name :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Name :";
            // 
            // btnConUpdate
            // 
            this.btnConUpdate.Location = new System.Drawing.Point(465, 296);
            this.btnConUpdate.Name = "btnConUpdate";
            this.btnConUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnConUpdate.TabIndex = 0;
            this.btnConUpdate.Text = "Update";
            this.btnConUpdate.UseVisualStyleBackColor = true;
            this.btnConUpdate.Click += new System.EventHandler(this.BtnConUpdate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtConAddProv);
            this.groupBox3.Controls.Add(this.txtConAddName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnConAdd);
            this.groupBox3.Location = new System.Drawing.Point(27, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 325);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbAddConShowPass);
            this.groupBox4.Controls.Add(this.txtConAddUser);
            this.groupBox4.Controls.Add(this.txtConAddDBFilename);
            this.groupBox4.Controls.Add(this.txtConAddPass);
            this.groupBox4.Controls.Add(this.txtConAddSecurity);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtConAddData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(10, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(530, 233);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection String";
            // 
            // cbAddConShowPass
            // 
            this.cbAddConShowPass.AutoSize = true;
            this.cbAddConShowPass.Location = new System.Drawing.Point(259, 125);
            this.cbAddConShowPass.Name = "cbAddConShowPass";
            this.cbAddConShowPass.Size = new System.Drawing.Size(102, 17);
            this.cbAddConShowPass.TabIndex = 15;
            this.cbAddConShowPass.Text = "Show Password";
            this.cbAddConShowPass.UseVisualStyleBackColor = true;
            this.cbAddConShowPass.CheckedChanged += new System.EventHandler(this.CbAddConShowPass_CheckedChanged);
            // 
            // txtConAddUser
            // 
            this.txtConAddUser.Location = new System.Drawing.Point(366, 81);
            this.txtConAddUser.Name = "txtConAddUser";
            this.txtConAddUser.Size = new System.Drawing.Size(126, 20);
            this.txtConAddUser.TabIndex = 14;
            // 
            // txtConAddDBFilename
            // 
            this.txtConAddDBFilename.Location = new System.Drawing.Point(398, 37);
            this.txtConAddDBFilename.Name = "txtConAddDBFilename";
            this.txtConAddDBFilename.Size = new System.Drawing.Size(126, 20);
            this.txtConAddDBFilename.TabIndex = 13;
            // 
            // txtConAddPass
            // 
            this.txtConAddPass.Location = new System.Drawing.Point(104, 123);
            this.txtConAddPass.Name = "txtConAddPass";
            this.txtConAddPass.PasswordChar = '*';
            this.txtConAddPass.Size = new System.Drawing.Size(126, 20);
            this.txtConAddPass.TabIndex = 12;
            // 
            // txtConAddSecurity
            // 
            this.txtConAddSecurity.Location = new System.Drawing.Point(140, 78);
            this.txtConAddSecurity.Name = "txtConAddSecurity";
            this.txtConAddSecurity.Size = new System.Drawing.Size(126, 20);
            this.txtConAddSecurity.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(272, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "User Instance :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(272, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Attach DB FIlename :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Integrated Security :";
            // 
            // txtConAddData
            // 
            this.txtConAddData.Location = new System.Drawing.Point(104, 37);
            this.txtConAddData.Name = "txtConAddData";
            this.txtConAddData.Size = new System.Drawing.Size(126, 20);
            this.txtConAddData.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data Source :";
            // 
            // txtConAddProv
            // 
            this.txtConAddProv.Location = new System.Drawing.Point(392, 19);
            this.txtConAddProv.Name = "txtConAddProv";
            this.txtConAddProv.Size = new System.Drawing.Size(148, 20);
            this.txtConAddProv.TabIndex = 4;
            // 
            // txtConAddName
            // 
            this.txtConAddName.Location = new System.Drawing.Point(71, 19);
            this.txtConAddName.Name = "txtConAddName";
            this.txtConAddName.Size = new System.Drawing.Size(148, 20);
            this.txtConAddName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Provider Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name :";
            // 
            // btnConAdd
            // 
            this.btnConAdd.Location = new System.Drawing.Point(450, 296);
            this.btnConAdd.Name = "btnConAdd";
            this.btnConAdd.Size = new System.Drawing.Size(75, 23);
            this.btnConAdd.TabIndex = 0;
            this.btnConAdd.Text = "Add";
            this.btnConAdd.UseVisualStyleBackColor = true;
            this.btnConAdd.Click += new System.EventHandler(this.BtnConAdd_Click);
            // 
            // gvAppSetting
            // 
            this.gvAppSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvAppSetting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvAppSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAppSetting.Location = new System.Drawing.Point(38, 437);
            this.gvAppSetting.MultiSelect = false;
            this.gvAppSetting.Name = "gvAppSetting";
            this.gvAppSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAppSetting.Size = new System.Drawing.Size(587, 178);
            this.gvAppSetting.TabIndex = 1;
            this.gvAppSetting.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvAppSetting_CellClick);
            // 
            // gvConString
            // 
            this.gvConString.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvConString.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvConString.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvConString.Location = new System.Drawing.Point(681, 437);
            this.gvConString.MultiSelect = false;
            this.gvConString.Name = "gvConString";
            this.gvConString.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvConString.Size = new System.Drawing.Size(576, 178);
            this.gvConString.TabIndex = 2;
            this.gvConString.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvConString_CellClick);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(550, 640);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open XML";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(235, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LblName_MouseDoubleClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(580, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(979, 640);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(303, 11);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(164, 20);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextChanged += new System.EventHandler(this.LblUsername_TextChanged);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(681, 8);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(681, 640);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 8;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // pbGIF
            // 
            this.pbGIF.Image = ((System.Drawing.Image)(resources.GetObject("pbGIF.Image")));
            this.pbGIF.Location = new System.Drawing.Point(485, 141);
            this.pbGIF.Name = "pbGIF";
            this.pbGIF.Size = new System.Drawing.Size(274, 214);
            this.pbGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGIF.TabIndex = 5;
            this.pbGIF.TabStop = false;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 675);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.gvConString);
            this.Controls.Add(this.gvAppSetting);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainApp";
            this.Text = "MainApp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAppSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gvAppSetting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAppDelete;
        private System.Windows.Forms.TextBox txtAppValue;
        private System.Windows.Forms.TextBox txtAppKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAppUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAppAddValue;
        private System.Windows.Forms.TextBox txtAppAddKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtConAddProv;
        private System.Windows.Forms.TextBox txtConAddName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConAdd;
        private System.Windows.Forms.DataGridView gvConString;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnConDelete;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtConConPass;
        private System.Windows.Forms.TextBox txtConNewPass;
        private System.Windows.Forms.CheckBox cbConShowOldPass;
        private System.Windows.Forms.TextBox txtConUser;
        private System.Windows.Forms.TextBox txtConDBFilename;
        private System.Windows.Forms.TextBox txtConOldPass;
        private System.Windows.Forms.TextBox txtConSecurity;
        private System.Windows.Forms.Label lblConUser;
        private System.Windows.Forms.Label lblConDBFile;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblConSecurity;
        private System.Windows.Forms.TextBox txtConData;
        private System.Windows.Forms.Label lblConData;
        private System.Windows.Forms.TextBox txtConProv;
        private System.Windows.Forms.TextBox txtConName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnConUpdate;
        private System.Windows.Forms.CheckBox cbAddConShowPass;
        private System.Windows.Forms.TextBox txtConAddUser;
        private System.Windows.Forms.TextBox txtConAddDBFilename;
        private System.Windows.Forms.TextBox txtConAddPass;
        private System.Windows.Forms.TextBox txtConAddSecurity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConAddData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.PictureBox pbGIF;
    }
}