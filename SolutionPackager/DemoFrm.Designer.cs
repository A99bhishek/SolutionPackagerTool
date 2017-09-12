namespace SolutionPackagerTool
{
    partial class DemoFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoFrm));
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.txtSolutionPackagerExe = new System.Windows.Forms.TextBox();
            this.lblSolutionPackagerExe = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSolutionPackagerExeFinder = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.llissue = new System.Windows.Forms.LinkLabel();
            this.eProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialogForExe = new System.Windows.Forms.OpenFileDialog();
            this.btnAbort = new System.Windows.Forms.Button();
            this.lblPackage = new System.Windows.Forms.Label();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.radExtract = new System.Windows.Forms.RadioButton();
            this.radPack = new System.Windows.Forms.RadioButton();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblLocalize = new System.Windows.Forms.Label();
            this.btnMapFileFinder = new System.Windows.Forms.Button();
            this.btnLogFile = new System.Windows.Forms.Button();
            this.btnSolutionZip = new System.Windows.Forms.Button();
            this.lblLogFile = new System.Windows.Forms.Label();
            this.btnFolderFinder = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblAllowWrite = new System.Windows.Forms.Label();
            this.lblAllowDelete = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblClobber = new System.Windows.Forms.Label();
            this.chkAllowWrite = new System.Windows.Forms.CheckBox();
            this.txtLocalize = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.chkLogo = new System.Windows.Forms.CheckBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtMapFile = new System.Windows.Forms.TextBox();
            this.chkClobber = new System.Windows.Forms.CheckBox();
            this.cmbErrorLevel = new System.Windows.Forms.ComboBox();
            this.cmbAllowDelete = new System.Windows.Forms.ComboBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblMapFile = new System.Windows.Forms.Label();
            this.txtSolutionZip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetPackageType = new System.Windows.Forms.Button();
            this.btnAllowDeleteReset = new System.Windows.Forms.Button();
            this.btnErrorLevelReset = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.consoleControl = new ConsoleControl.ConsoleControl();
            ((System.ComponentModel.ISupportInitialize)(this.eProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // txtSolutionPackagerExe
            // 
            this.txtSolutionPackagerExe.BackColor = System.Drawing.SystemColors.Window;
            this.txtSolutionPackagerExe.Location = new System.Drawing.Point(212, 27);
            this.txtSolutionPackagerExe.Name = "txtSolutionPackagerExe";
            this.txtSolutionPackagerExe.Size = new System.Drawing.Size(495, 20);
            this.txtSolutionPackagerExe.TabIndex = 1;
            // 
            // lblSolutionPackagerExe
            // 
            this.lblSolutionPackagerExe.AutoSize = true;
            this.lblSolutionPackagerExe.Location = new System.Drawing.Point(44, 29);
            this.lblSolutionPackagerExe.Name = "lblSolutionPackagerExe";
            this.lblSolutionPackagerExe.Size = new System.Drawing.Size(153, 13);
            this.lblSolutionPackagerExe.TabIndex = 0;
            this.lblSolutionPackagerExe.Text = "Solution Packager Executable:";
            // 
            // btnSolutionPackagerExeFinder
            // 
            this.btnSolutionPackagerExeFinder.Image = ((System.Drawing.Image)(resources.GetObject("btnSolutionPackagerExeFinder.Image")));
            this.btnSolutionPackagerExeFinder.Location = new System.Drawing.Point(713, 24);
            this.btnSolutionPackagerExeFinder.Name = "btnSolutionPackagerExeFinder";
            this.btnSolutionPackagerExeFinder.Size = new System.Drawing.Size(23, 23);
            this.btnSolutionPackagerExeFinder.TabIndex = 2;
            this.btnSolutionPackagerExeFinder.UseVisualStyleBackColor = true;
            this.btnSolutionPackagerExeFinder.Click += new System.EventHandler(this.btnSolutionPackagerExeFinder_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(205, 665);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(69, 32);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(496, 665);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 32);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llissue
            // 
            this.llissue.AutoSize = true;
            this.llissue.Location = new System.Drawing.Point(1290, 30);
            this.llissue.Name = "llissue";
            this.llissue.Size = new System.Drawing.Size(82, 13);
            this.llissue.TabIndex = 44;
            this.llissue.TabStop = true;
            this.llissue.Text = "Report an Issue";
            this.llissue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llissue_LinkClicked);
            // 
            // eProvider
            // 
            this.eProvider.ContainerControl = this;
            // 
            // openFileDialogForExe
            // 
            this.openFileDialogForExe.FileName = "openFileDialog1";
            // 
            // btnAbort
            // 
            this.btnAbort.Enabled = false;
            this.btnAbort.Image = ((System.Drawing.Image)(resources.GetObject("btnAbort.Image")));
            this.btnAbort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbort.Location = new System.Drawing.Point(354, 665);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(65, 32);
            this.btnAbort.TabIndex = 45;
            this.btnAbort.Text = "Abort";
            this.btnAbort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(80, 144);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(80, 13);
            this.lblPackage.TabIndex = 50;
            this.lblPackage.Text = "Package Type:";
            // 
            // cmbPackage
            // 
            this.cmbPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Items.AddRange(new object[] {
            "Managed",
            "UnManaged",
            "Both"});
            this.cmbPackage.Location = new System.Drawing.Point(212, 136);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(121, 21);
            this.cmbPackage.TabIndex = 51;
            // 
            // radExtract
            // 
            this.radExtract.AutoSize = true;
            this.radExtract.Location = new System.Drawing.Point(212, 89);
            this.radExtract.Name = "radExtract";
            this.radExtract.Size = new System.Drawing.Size(58, 17);
            this.radExtract.TabIndex = 49;
            this.radExtract.TabStop = true;
            this.radExtract.Text = "Extract";
            this.radExtract.UseVisualStyleBackColor = true;
            this.radExtract.CheckedChanged += new System.EventHandler(this.radExtract_CheckedChanged_1);
            // 
            // radPack
            // 
            this.radPack.AutoSize = true;
            this.radPack.Location = new System.Drawing.Point(297, 89);
            this.radPack.Name = "radPack";
            this.radPack.Size = new System.Drawing.Size(50, 17);
            this.radPack.TabIndex = 48;
            this.radPack.TabStop = true;
            this.radPack.Text = "Pack";
            this.radPack.UseVisualStyleBackColor = true;
            this.radPack.CheckedChanged += new System.EventHandler(this.radPack_CheckedChanged_1);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(94, 202);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(66, 13);
            this.lblZip.TabIndex = 52;
            this.lblZip.Text = "Solution Zip:";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(52, 480);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(65, 13);
            this.lblSource.TabIndex = 74;
            this.lblSource.Text = "Source Loc:";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(120, 93);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(40, 13);
            this.lblAction.TabIndex = 47;
            this.lblAction.Text = "Action:";
            // 
            // lblLocalize
            // 
            this.lblLocalize.AutoSize = true;
            this.lblLocalize.Location = new System.Drawing.Point(66, 537);
            this.lblLocalize.Name = "lblLocalize";
            this.lblLocalize.Size = new System.Drawing.Size(49, 13);
            this.lblLocalize.TabIndex = 76;
            this.lblLocalize.Text = "Localize:";
            // 
            // btnMapFileFinder
            // 
            this.btnMapFileFinder.Image = ((System.Drawing.Image)(resources.GetObject("btnMapFileFinder.Image")));
            this.btnMapFileFinder.Location = new System.Drawing.Point(713, 421);
            this.btnMapFileFinder.Name = "btnMapFileFinder";
            this.btnMapFileFinder.Size = new System.Drawing.Size(23, 23);
            this.btnMapFileFinder.TabIndex = 68;
            this.btnMapFileFinder.UseVisualStyleBackColor = true;
            this.btnMapFileFinder.Click += new System.EventHandler(this.btnMapFileFinder_Click);
            // 
            // btnLogFile
            // 
            this.btnLogFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLogFile.Image")));
            this.btnLogFile.Location = new System.Drawing.Point(713, 498);
            this.btnLogFile.Name = "btnLogFile";
            this.btnLogFile.Size = new System.Drawing.Size(23, 23);
            this.btnLogFile.TabIndex = 73;
            this.btnLogFile.UseVisualStyleBackColor = true;
            this.btnLogFile.Click += new System.EventHandler(this.btnLogFile_Click);
            // 
            // btnSolutionZip
            // 
            this.btnSolutionZip.Image = ((System.Drawing.Image)(resources.GetObject("btnSolutionZip.Image")));
            this.btnSolutionZip.Location = new System.Drawing.Point(713, 193);
            this.btnSolutionZip.Name = "btnSolutionZip";
            this.btnSolutionZip.Size = new System.Drawing.Size(23, 23);
            this.btnSolutionZip.TabIndex = 54;
            this.btnSolutionZip.UseVisualStyleBackColor = true;
            this.btnSolutionZip.Click += new System.EventHandler(this.btnSolutionZip_Click);
            // 
            // lblLogFile
            // 
            this.lblLogFile.AutoSize = true;
            this.lblLogFile.Location = new System.Drawing.Point(66, 436);
            this.lblLogFile.Name = "lblLogFile";
            this.lblLogFile.Size = new System.Drawing.Size(47, 13);
            this.lblLogFile.TabIndex = 71;
            this.lblLogFile.Text = "Log File:";
            // 
            // btnFolderFinder
            // 
            this.btnFolderFinder.Image = ((System.Drawing.Image)(resources.GetObject("btnFolderFinder.Image")));
            this.btnFolderFinder.Location = new System.Drawing.Point(713, 239);
            this.btnFolderFinder.Name = "btnFolderFinder";
            this.btnFolderFinder.Size = new System.Drawing.Size(23, 23);
            this.btnFolderFinder.TabIndex = 57;
            this.btnFolderFinder.UseVisualStyleBackColor = true;
            this.btnFolderFinder.Click += new System.EventHandler(this.btnFolderFinder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(96, 249);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(64, 13);
            this.lblFolder.TabIndex = 55;
            this.lblFolder.Text = "Folder Path:";
            // 
            // lblAllowWrite
            // 
            this.lblAllowWrite.AutoSize = true;
            this.lblAllowWrite.Location = new System.Drawing.Point(97, 288);
            this.lblAllowWrite.Name = "lblAllowWrite";
            this.lblAllowWrite.Size = new System.Drawing.Size(63, 13);
            this.lblAllowWrite.TabIndex = 58;
            this.lblAllowWrite.Text = "Allow Write:";
            // 
            // lblAllowDelete
            // 
            this.lblAllowDelete.AutoSize = true;
            this.lblAllowDelete.Location = new System.Drawing.Point(91, 326);
            this.lblAllowDelete.Name = "lblAllowDelete";
            this.lblAllowDelete.Size = new System.Drawing.Size(69, 13);
            this.lblAllowDelete.TabIndex = 60;
            this.lblAllowDelete.Text = "Allow Delete:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(99, 391);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(61, 13);
            this.lblError.TabIndex = 64;
            this.lblError.Text = "Error Level:";
            // 
            // lblClobber
            // 
            this.lblClobber.AutoSize = true;
            this.lblClobber.Location = new System.Drawing.Point(114, 356);
            this.lblClobber.Name = "lblClobber";
            this.lblClobber.Size = new System.Drawing.Size(46, 13);
            this.lblClobber.TabIndex = 62;
            this.lblClobber.Text = "Clobber:";
            // 
            // chkAllowWrite
            // 
            this.chkAllowWrite.AutoSize = true;
            this.chkAllowWrite.Checked = true;
            this.chkAllowWrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowWrite.Location = new System.Drawing.Point(212, 287);
            this.chkAllowWrite.Name = "chkAllowWrite";
            this.chkAllowWrite.Size = new System.Drawing.Size(15, 14);
            this.chkAllowWrite.TabIndex = 59;
            this.chkAllowWrite.UseVisualStyleBackColor = true;
            // 
            // txtLocalize
            // 
            this.txtLocalize.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocalize.Location = new System.Drawing.Point(212, 600);
            this.txtLocalize.Name = "txtLocalize";
            this.txtLocalize.Size = new System.Drawing.Size(495, 20);
            this.txtLocalize.TabIndex = 77;
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.SystemColors.Window;
            this.txtSource.Location = new System.Drawing.Point(212, 543);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(495, 20);
            this.txtSource.TabIndex = 75;
            // 
            // txtLogFile
            // 
            this.txtLogFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogFile.Location = new System.Drawing.Point(212, 499);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.Size = new System.Drawing.Size(495, 20);
            this.txtLogFile.TabIndex = 72;
            // 
            // chkLogo
            // 
            this.chkLogo.AutoSize = true;
            this.chkLogo.Location = new System.Drawing.Point(212, 470);
            this.chkLogo.Name = "chkLogo";
            this.chkLogo.Size = new System.Drawing.Size(15, 14);
            this.chkLogo.TabIndex = 70;
            this.chkLogo.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(62, 400);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(51, 13);
            this.lblLogo.TabIndex = 69;
            this.lblLogo.Text = "No Logo:";
            // 
            // txtMapFile
            // 
            this.txtMapFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtMapFile.Location = new System.Drawing.Point(212, 422);
            this.txtMapFile.Name = "txtMapFile";
            this.txtMapFile.Size = new System.Drawing.Size(495, 20);
            this.txtMapFile.TabIndex = 67;
            // 
            // chkClobber
            // 
            this.chkClobber.AutoSize = true;
            this.chkClobber.Location = new System.Drawing.Point(212, 356);
            this.chkClobber.Name = "chkClobber";
            this.chkClobber.Size = new System.Drawing.Size(15, 14);
            this.chkClobber.TabIndex = 65;
            this.chkClobber.UseVisualStyleBackColor = true;
            // 
            // cmbErrorLevel
            // 
            this.cmbErrorLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbErrorLevel.FormattingEnabled = true;
            this.cmbErrorLevel.Items.AddRange(new object[] {
            "Off",
            "Error",
            "Warning",
            "Info",
            "Verbose"});
            this.cmbErrorLevel.Location = new System.Drawing.Point(212, 383);
            this.cmbErrorLevel.Name = "cmbErrorLevel";
            this.cmbErrorLevel.Size = new System.Drawing.Size(121, 21);
            this.cmbErrorLevel.TabIndex = 63;
            // 
            // cmbAllowDelete
            // 
            this.cmbAllowDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllowDelete.FormattingEnabled = true;
            this.cmbAllowDelete.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Prompt"});
            this.cmbAllowDelete.Location = new System.Drawing.Point(212, 322);
            this.cmbAllowDelete.Name = "cmbAllowDelete";
            this.cmbAllowDelete.Size = new System.Drawing.Size(121, 21);
            this.cmbAllowDelete.TabIndex = 61;
            // 
            // txtFolder
            // 
            this.txtFolder.BackColor = System.Drawing.SystemColors.Window;
            this.txtFolder.Location = new System.Drawing.Point(212, 242);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(495, 20);
            this.txtFolder.TabIndex = 56;
            // 
            // lblMapFile
            // 
            this.lblMapFile.AutoSize = true;
            this.lblMapFile.Location = new System.Drawing.Point(64, 359);
            this.lblMapFile.Name = "lblMapFile";
            this.lblMapFile.Size = new System.Drawing.Size(50, 13);
            this.lblMapFile.TabIndex = 66;
            this.lblMapFile.Text = "Map File:";
            // 
            // txtSolutionZip
            // 
            this.txtSolutionZip.BackColor = System.Drawing.SystemColors.Window;
            this.txtSolutionZip.Location = new System.Drawing.Point(212, 195);
            this.txtSolutionZip.Name = "txtSolutionZip";
            this.txtSolutionZip.Size = new System.Drawing.Size(495, 20);
            this.txtSolutionZip.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(212, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "*Please locate the Solution Explorer executable ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(212, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "*Use Pack to create solution file and to decompress the solution contents use Ext" +
    "ract.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(212, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 26);
            this.label3.TabIndex = 81;
            this.label3.Text = "*(Optional) Package type can be managed, unmanaged or both. For Both the Managed " +
    "and \r\nUnamanaged solution file shall exists for extract operation. Default is Un" +
    "managed.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(212, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(513, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "*Locate a solution file for Extract action and enter name of solution file that w" +
    "ill be created from Pack action.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(212, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "*Folder where you want to extract to and pack from.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(244, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "*(Optional) Files that have the read-only attribute set are overwritten or delete" +
    "d. ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(212, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "*(Optional) The path and name of an .xml file containing file mapping directives";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(233, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "*(Optional)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(337, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "*(Optional)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(339, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "*(Optional)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(230, 471);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "*(Optional)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(212, 521);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "*(Optional)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(212, 565);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 91;
            this.label13.Text = "*(Optional)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(212, 623);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "*(Optional)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnErrorLevelReset);
            this.groupBox1.Controls.Add(this.btnAllowDeleteReset);
            this.groupBox1.Controls.Add(this.btnResetPackageType);
            this.groupBox1.Controls.Add(this.lblMapFile);
            this.groupBox1.Controls.Add(this.lblLogo);
            this.groupBox1.Controls.Add(this.lblLogFile);
            this.groupBox1.Controls.Add(this.lblSource);
            this.groupBox1.Controls.Add(this.lblLocalize);
            this.groupBox1.Location = new System.Drawing.Point(47, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 574);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.consoleControl);
            this.groupBox2.Location = new System.Drawing.Point(780, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 574);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command Window";
            // 
            // btnResetPackageType
            // 
            this.btnResetPackageType.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPackageType.Image")));
            this.btnResetPackageType.Location = new System.Drawing.Point(296, 65);
            this.btnResetPackageType.Name = "btnResetPackageType";
            this.btnResetPackageType.Size = new System.Drawing.Size(28, 23);
            this.btnResetPackageType.TabIndex = 77;
            this.btnResetPackageType.UseVisualStyleBackColor = true;
            this.btnResetPackageType.Click += new System.EventHandler(this.btnResetPackageType_Click);
            // 
            // btnAllowDeleteReset
            // 
            this.btnAllowDeleteReset.Image = ((System.Drawing.Image)(resources.GetObject("btnAllowDeleteReset.Image")));
            this.btnAllowDeleteReset.Location = new System.Drawing.Point(370, 252);
            this.btnAllowDeleteReset.Name = "btnAllowDeleteReset";
            this.btnAllowDeleteReset.Size = new System.Drawing.Size(28, 23);
            this.btnAllowDeleteReset.TabIndex = 78;
            this.btnAllowDeleteReset.UseVisualStyleBackColor = true;
            this.btnAllowDeleteReset.Click += new System.EventHandler(this.btnAllowDeleteReset_Click);
            // 
            // btnErrorLevelReset
            // 
            this.btnErrorLevelReset.Image = ((System.Drawing.Image)(resources.GetObject("btnErrorLevelReset.Image")));
            this.btnErrorLevelReset.Location = new System.Drawing.Point(371, 313);
            this.btnErrorLevelReset.Name = "btnErrorLevelReset";
            this.btnErrorLevelReset.Size = new System.Drawing.Size(28, 23);
            this.btnErrorLevelReset.TabIndex = 79;
            this.btnErrorLevelReset.UseVisualStyleBackColor = true;
            this.btnErrorLevelReset.Click += new System.EventHandler(this.btnErrorLevelReset_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(6, 553);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(233, 13);
            this.label15.TabIndex = 92;
            this.label15.Text = "*Input text in command window when prompt to.";
            // 
            // consoleControl
            // 
            this.consoleControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.consoleControl.IsInputEnabled = true;
            this.consoleControl.Location = new System.Drawing.Point(3, 16);
            this.consoleControl.Name = "consoleControl";
            this.consoleControl.SendKeyboardCommandsToProcess = false;
            this.consoleControl.ShowDiagnostics = false;
            this.consoleControl.Size = new System.Drawing.Size(619, 518);
            this.consoleControl.TabIndex = 47;
            // 
            // DemoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.cmbPackage);
            this.Controls.Add(this.radExtract);
            this.Controls.Add(this.radPack);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.btnMapFileFinder);
            this.Controls.Add(this.btnLogFile);
            this.Controls.Add(this.btnSolutionZip);
            this.Controls.Add(this.btnFolderFinder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.lblAllowWrite);
            this.Controls.Add(this.lblAllowDelete);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblClobber);
            this.Controls.Add(this.chkAllowWrite);
            this.Controls.Add(this.txtLocalize);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.txtLogFile);
            this.Controls.Add(this.chkLogo);
            this.Controls.Add(this.txtMapFile);
            this.Controls.Add(this.chkClobber);
            this.Controls.Add(this.cmbErrorLevel);
            this.Controls.Add(this.cmbAllowDelete);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.txtSolutionZip);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.llissue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSolutionPackagerExeFinder);
            this.Controls.Add(this.lblSolutionPackagerExe);
            this.Controls.Add(this.txtSolutionPackagerExe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "DemoFrm";
            this.Size = new System.Drawing.Size(1408, 723);
            this.Load += new System.EventHandler(this.DemoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.TextBox txtSolutionPackagerExe;
        private System.Windows.Forms.Label lblSolutionPackagerExe;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
        private System.Windows.Forms.Button btnSolutionPackagerExeFinder;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.LinkLabel llissue;
        private System.Windows.Forms.ErrorProvider eProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialogForExe;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.RadioButton radExtract;
        private System.Windows.Forms.RadioButton radPack;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblLocalize;
        private System.Windows.Forms.Button btnMapFileFinder;
        private System.Windows.Forms.Button btnLogFile;
        private System.Windows.Forms.Button btnSolutionZip;
        private System.Windows.Forms.Label lblLogFile;
        private System.Windows.Forms.Button btnFolderFinder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblAllowWrite;
        private System.Windows.Forms.Label lblAllowDelete;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblClobber;
        private System.Windows.Forms.CheckBox chkAllowWrite;
        private System.Windows.Forms.TextBox txtLocalize;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.CheckBox chkLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtMapFile;
        private System.Windows.Forms.CheckBox chkClobber;
        private System.Windows.Forms.ComboBox cmbErrorLevel;
        private System.Windows.Forms.ComboBox cmbAllowDelete;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblMapFile;
        private System.Windows.Forms.TextBox txtSolutionZip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ConsoleControl.ConsoleControl consoleControl;
        private System.Windows.Forms.Button btnResetPackageType;
        private System.Windows.Forms.Button btnErrorLevelReset;
        private System.Windows.Forms.Button btnAllowDeleteReset;
        private System.Windows.Forms.Label label15;
    }
}