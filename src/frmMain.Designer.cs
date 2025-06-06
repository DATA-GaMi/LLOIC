namespace LOIC
{
	partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdTargetIP = new System.Windows.Forms.Button();
            this.txtTargetIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdTargetURL = new System.Windows.Forms.Button();
            this.txtTargetURL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAllowGzip = new System.Windows.Forms.CheckBox();
            this.chkUseGet = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSLSpT = new System.Windows.Forms.TextBox();
            this.chkMsgRandom = new System.Windows.Forms.CheckBox();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.lbSepOptions = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.chkWaitReply = new System.Windows.Forms.CheckBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtSubsite = new System.Windows.Forms.TextBox();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdAttack = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbSepStatus = new System.Windows.Forms.Label();
            this.lbFailed = new System.Windows.Forms.Label();
            this.lbRequested = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbDownloaded = new System.Windows.Forms.Label();
            this.lbDownloading = new System.Windows.Forms.Label();
            this.lbRequesting = new System.Windows.Forms.Label();
            this.lbConnecting = new System.Windows.Forms.Label();
            this.lbIdle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TTip = new System.Windows.Forms.ToolTip(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.textOLServer = new System.Windows.Forms.TextBox();
            this.textOLTime = new System.Windows.Forms.TextBox();
            this.chkbOLUp = new System.Windows.Forms.CheckBox();
            this.enableHive = new System.Windows.Forms.RadioButton();
            this.tShowStats = new System.Windows.Forms.Timer(this.components);
            this.disableHive = new System.Windows.Forms.RadioButton();
            this.label25 = new System.Windows.Forms.Label();
            this.txtIRCserver = new System.Windows.Forms.TextBox();
            this.txtIRCport = new System.Windows.Forms.TextBox();
            this.txtIRCchannel = new System.Windows.Forms.TextBox();
            this.pBanner = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.enableOverlord = new System.Windows.Forms.RadioButton();
            this.labelOLStatus = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tCheckOL = new System.Windows.Forms.Timer(this.components);
            this.tZergRush = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdTargetIP);
            this.groupBox1.Controls.Add(this.txtTargetIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdTargetURL);
            this.groupBox1.Controls.Add(this.txtTargetURL);
            this.groupBox1.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Location = new System.Drawing.Point(212, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Select your target";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdTargetIP
            // 
            this.cmdTargetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.cmdTargetIP.ForeColor = System.Drawing.Color.Azure;
            this.cmdTargetIP.Location = new System.Drawing.Point(410, 46);
            this.cmdTargetIP.Name = "cmdTargetIP";
            this.cmdTargetIP.Size = new System.Drawing.Size(71, 22);
            this.cmdTargetIP.TabIndex = 4;
            this.cmdTargetIP.Text = "Lock on";
            this.cmdTargetIP.UseVisualStyleBackColor = false;
            this.cmdTargetIP.Click += new System.EventHandler(this.cmdTargetIP_Click);
            // 
            // txtTargetIP
            // 
            this.txtTargetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtTargetIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetIP.ForeColor = System.Drawing.Color.Azure;
            this.txtTargetIP.Location = new System.Drawing.Point(39, 48);
            this.txtTargetIP.Name = "txtTargetIP";
            this.txtTargetIP.Size = new System.Drawing.Size(365, 26);
            this.txtTargetIP.TabIndex = 3;
            this.TTip.SetToolTip(this.txtTargetIP, "If you know your target\'s IP, enter the IP here and click \"Lock on\"");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdTargetURL
            // 
            this.cmdTargetURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.cmdTargetURL.ForeColor = System.Drawing.Color.Azure;
            this.cmdTargetURL.Location = new System.Drawing.Point(410, 19);
            this.cmdTargetURL.Name = "cmdTargetURL";
            this.cmdTargetURL.Size = new System.Drawing.Size(71, 22);
            this.cmdTargetURL.TabIndex = 2;
            this.cmdTargetURL.Text = "Lock on";
            this.cmdTargetURL.UseVisualStyleBackColor = false;
            this.cmdTargetURL.Click += new System.EventHandler(this.cmdTargetURL_Click);
            // 
            // txtTargetURL
            // 
            this.txtTargetURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtTargetURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetURL.ForeColor = System.Drawing.Color.Azure;
            this.txtTargetURL.Location = new System.Drawing.Point(39, 20);
            this.txtTargetURL.Name = "txtTargetURL";
            this.txtTargetURL.Size = new System.Drawing.Size(365, 26);
            this.txtTargetURL.TabIndex = 1;
            this.TTip.SetToolTip(this.txtTargetURL, "If you don\'t know your target\'s IP, enter a URL here and click \"Lock on\"");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTarget);
            this.groupBox2.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Location = new System.Drawing.Point(212, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected target";
            // 
            // txtTarget
            // 
            this.txtTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarget.Font = new System.Drawing.Font("Arial", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget.ForeColor = System.Drawing.Color.Azure;
            this.txtTarget.Location = new System.Drawing.Point(6, 19);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(746, 111);
            this.txtTarget.TabIndex = 1;
            this.txtTarget.TabStop = false;
            this.txtTarget.Text = "N O N E !";
            this.txtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtTarget, "The currently selected target");
            this.txtTarget.Enter += new System.EventHandler(this.txtTarget_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAllowGzip);
            this.groupBox3.Controls.Add(this.chkUseGet);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtSLSpT);
            this.groupBox3.Controls.Add(this.chkMsgRandom);
            this.groupBox3.Controls.Add(this.chkRandom);
            this.groupBox3.Controls.Add(this.lbSepOptions);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.chkWaitReply);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.txtSubsite);
            this.groupBox3.Controls.Add(this.txtTimeout);
            this.groupBox3.Controls.Add(this.txtThreads);
            this.groupBox3.Controls.Add(this.cbMethod);
            this.groupBox3.Controls.Add(this.txtPort);
            this.groupBox3.Controls.Add(this.tbSpeed);
            this.groupBox3.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Location = new System.Drawing.Point(212, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 130);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Attack options";
            // 
            // chkAllowGzip
            // 
            this.chkAllowGzip.AutoSize = true;
            this.chkAllowGzip.Enabled = false;
            this.chkAllowGzip.Location = new System.Drawing.Point(657, 44);
            this.chkAllowGzip.Name = "chkAllowGzip";
            this.chkAllowGzip.Size = new System.Drawing.Size(97, 23);
            this.chkAllowGzip.TabIndex = 33;
            this.chkAllowGzip.Text = "use gZip";
            this.TTip.SetToolTip(this.chkAllowGzip, "If checked, enables Gzip support for HTTP methods");
            this.chkAllowGzip.UseVisualStyleBackColor = true;
            // 
            // chkUseGet
            // 
            this.chkUseGet.AutoSize = true;
            this.chkUseGet.Enabled = false;
            this.chkUseGet.Location = new System.Drawing.Point(657, 23);
            this.chkUseGet.Name = "chkUseGet";
            this.chkUseGet.Size = new System.Drawing.Size(98, 23);
            this.chkUseGet.TabIndex = 32;
            this.chkUseGet.Text = "use GET";
            this.TTip.SetToolTip(this.chkUseGet, "If checked it uses the GET method instead of POST.");
            this.chkUseGet.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(327, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Sockets / Thread";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSLSpT
            // 
            this.txtSLSpT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtSLSpT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSLSpT.Enabled = false;
            this.txtSLSpT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLSpT.ForeColor = System.Drawing.Color.Azure;
            this.txtSLSpT.Location = new System.Drawing.Point(343, 77);
            this.txtSLSpT.Name = "txtSLSpT";
            this.txtSLSpT.Size = new System.Drawing.Size(57, 26);
            this.txtSLSpT.TabIndex = 30;
            this.txtSLSpT.Text = "25";
            this.txtSLSpT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtSLSpT, "Amount of sockets per thread");
            // 
            // chkMsgRandom
            // 
            this.chkMsgRandom.Location = new System.Drawing.Point(437, 21);
            this.chkMsgRandom.Name = "chkMsgRandom";
            this.chkMsgRandom.Size = new System.Drawing.Size(212, 18);
            this.chkMsgRandom.TabIndex = 29;
            this.chkMsgRandom.Text = "Append random chars to the message";
            this.TTip.SetToolTip(this.chkMsgRandom, "Enable appending random chars to the message every request");
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Enabled = false;
            this.chkRandom.Location = new System.Drawing.Point(138, 21);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(278, 23);
            this.chkRandom.TabIndex = 28;
            this.chkRandom.Text = "Append random chars to the URL";
            this.TTip.SetToolTip(this.chkRandom, "Enable appending random chars to the subsite every request");
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // lbSepOptions
            // 
            this.lbSepOptions.BackColor = System.Drawing.Color.Azure;
            this.lbSepOptions.Location = new System.Drawing.Point(6, 68);
            this.lbSepOptions.Name = "lbSepOptions";
            this.lbSepOptions.Size = new System.Drawing.Size(746, 1);
            this.lbSepOptions.TabIndex = 27;
            this.lbSepOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(329, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "TCP / UDP message";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(62, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "HTTP Subsite";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Timeout";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(161, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Threads";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(75, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Method";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Port";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(362, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(390, 15);
            this.label20.TabIndex = 18;
            this.label20.Text = "<= faster     Speed     slower =>";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkWaitReply
            // 
            this.chkWaitReply.AutoSize = true;
            this.chkWaitReply.Location = new System.Drawing.Point(231, 79);
            this.chkWaitReply.Name = "chkWaitReply";
            this.chkWaitReply.Size = new System.Drawing.Size(134, 23);
            this.chkWaitReply.TabIndex = 7;
            this.chkWaitReply.Text = "Wait for reply";
            this.TTip.SetToolTip(this.chkWaitReply, "Don\'t disconnect before the server\'s started to answer");
            this.chkWaitReply.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.Azure;
            this.txtData.Location = new System.Drawing.Point(330, 41);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(312, 26);
            this.txtData.TabIndex = 3;
            this.txtData.Text = "U dun goofed";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtData, "The data to send in TCP/UDP mode");
            // 
            // txtSubsite
            // 
            this.txtSubsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtSubsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubsite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubsite.ForeColor = System.Drawing.Color.Azure;
            this.txtSubsite.Location = new System.Drawing.Point(63, 41);
            this.txtSubsite.Name = "txtSubsite";
            this.txtSubsite.Size = new System.Drawing.Size(259, 26);
            this.txtSubsite.TabIndex = 2;
            this.txtSubsite.Text = "/";
            this.txtSubsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtSubsite, "What subsite to target (when using HTTP as type)");
            // 
            // txtTimeout
            // 
            this.txtTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtTimeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeout.ForeColor = System.Drawing.Color.Azure;
            this.txtTimeout.Location = new System.Drawing.Point(6, 41);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(50, 26);
            this.txtTimeout.TabIndex = 1;
            this.txtTimeout.Text = "30";
            this.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtTimeout, "Max time in seconds to wait for a response.");
            // 
            // txtThreads
            // 
            this.txtThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtThreads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThreads.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThreads.ForeColor = System.Drawing.Color.Azure;
            this.txtThreads.Location = new System.Drawing.Point(161, 77);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(57, 26);
            this.txtThreads.TabIndex = 6;
            this.txtThreads.Text = "10";
            this.txtThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtThreads, "How many users LOIC should emulate");
            this.txtThreads.Leave += new System.EventHandler(this.txtThreads_Leave);
            // 
            // cbMethod
            // 
            this.cbMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cbMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMethod.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMethod.ForeColor = System.Drawing.Color.Azure;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "HTTP",
            "ICMP",
            "NTP",
            "DNS",
            "ReCoil",
            "slowLOIC"});
            this.cbMethod.Location = new System.Drawing.Point(75, 76);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(75, 27);
            this.cbMethod.TabIndex = 5;
            this.cbMethod.Text = "TCP";
            this.TTip.SetToolTip(this.cbMethod, "What type of attack to launch");
            this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.cbMethod_SelectedIndexChanged);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.Azure;
            this.txtPort.Location = new System.Drawing.Point(6, 77);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(60, 26);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "80";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtPort, "What port to attack (regular websites use 80)");
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(414, 72);
            this.tbSpeed.Maximum = 50;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(338, 69);
            this.tbSpeed.TabIndex = 8;
            this.TTip.SetToolTip(this.tbSpeed, "Use this to increase or reduce attack speed");
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdAttack);
            this.groupBox4.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox4.Location = new System.Drawing.Point(712, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 75);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3. Ready?";
            // 
            // cmdAttack
            // 
            this.cmdAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.cmdAttack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAttack.ForeColor = System.Drawing.Color.Azure;
            this.cmdAttack.Location = new System.Drawing.Point(6, 19);
            this.cmdAttack.Name = "cmdAttack";
            this.cmdAttack.Size = new System.Drawing.Size(246, 50);
            this.cmdAttack.TabIndex = 1;
            this.cmdAttack.Text = "��ʼAttack!!!";
            this.TTip.SetToolTip(this.cmdAttack, "I sincerely hope you can guess what this button does.");
            this.cmdAttack.UseVisualStyleBackColor = false;
            this.cmdAttack.Click += new System.EventHandler(this.cmdAttack_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbSepStatus);
            this.groupBox5.Controls.Add(this.lbFailed);
            this.groupBox5.Controls.Add(this.lbRequested);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.lbDownloaded);
            this.groupBox5.Controls.Add(this.lbDownloading);
            this.groupBox5.Controls.Add(this.lbRequesting);
            this.groupBox5.Controls.Add(this.lbConnecting);
            this.groupBox5.Controls.Add(this.lbIdle);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox5.Location = new System.Drawing.Point(212, 406);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(758, 68);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Attack status";
            // 
            // lbSepStatus
            // 
            this.lbSepStatus.BackColor = System.Drawing.Color.Azure;
            this.lbSepStatus.Location = new System.Drawing.Point(6, 40);
            this.lbSepStatus.Name = "lbSepStatus";
            this.lbSepStatus.Size = new System.Drawing.Size(746, 1);
            this.lbSepStatus.TabIndex = 25;
            this.lbSepStatus.Text = "Idle";
            this.lbSepStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFailed
            // 
            this.lbFailed.Location = new System.Drawing.Point(648, 41);
            this.lbFailed.Name = "lbFailed";
            this.lbFailed.Size = new System.Drawing.Size(101, 24);
            this.lbFailed.TabIndex = 24;
            this.lbFailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbFailed, "How many times (in total) the webserver didn\'t respond. High number = server down" +
        ".");
            // 
            // lbRequested
            // 
            this.lbRequested.Location = new System.Drawing.Point(541, 41);
            this.lbRequested.Name = "lbRequested";
            this.lbRequested.Size = new System.Drawing.Size(101, 24);
            this.lbRequested.TabIndex = 23;
            this.lbRequested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbRequested, "How many times (in total) a download has been requested");
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(648, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 24);
            this.label22.TabIndex = 22;
            this.label22.Text = "Failed";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(541, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 24);
            this.label23.TabIndex = 21;
            this.label23.Text = "Requested";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDownloaded
            // 
            this.lbDownloaded.Location = new System.Drawing.Point(434, 41);
            this.lbDownloaded.Name = "lbDownloaded";
            this.lbDownloaded.Size = new System.Drawing.Size(101, 24);
            this.lbDownloaded.TabIndex = 20;
            this.lbDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbDownloaded, "How many times (in total) that a download has been initiated");
            // 
            // lbDownloading
            // 
            this.lbDownloading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.lbDownloading.Location = new System.Drawing.Point(327, 41);
            this.lbDownloading.Name = "lbDownloading";
            this.lbDownloading.Size = new System.Drawing.Size(101, 24);
            this.lbDownloading.TabIndex = 19;
            this.lbDownloading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbDownloading, "How many threads that are downloading information from the server");
            // 
            // lbRequesting
            // 
            this.lbRequesting.Location = new System.Drawing.Point(220, 41);
            this.lbRequesting.Name = "lbRequesting";
            this.lbRequesting.Size = new System.Drawing.Size(101, 24);
            this.lbRequesting.TabIndex = 18;
            this.lbRequesting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbRequesting, "How many threads that are requesting information from the server");
            // 
            // lbConnecting
            // 
            this.lbConnecting.Location = new System.Drawing.Point(113, 41);
            this.lbConnecting.Name = "lbConnecting";
            this.lbConnecting.Size = new System.Drawing.Size(101, 24);
            this.lbConnecting.TabIndex = 17;
            this.lbConnecting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbConnecting, "How many threads that are trying to connect");
            // 
            // lbIdle
            // 
            this.lbIdle.Location = new System.Drawing.Point(6, 41);
            this.lbIdle.Name = "lbIdle";
            this.lbIdle.Size = new System.Drawing.Size(101, 24);
            this.lbIdle.TabIndex = 16;
            this.lbIdle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbIdle, "How many threads that are without work. Should be 0");
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(434, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Downloaded";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(327, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "Downloading";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(220, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 13;
            this.label14.Text = "Requesting";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(113, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Connecting";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 24);
            this.label16.TabIndex = 11;
            this.label16.Text = "Idle";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(22, 452);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(221, 19);
            this.label24.TabIndex = 14;
            this.label24.Text = "https://github.com/Data-Gami";
            this.TTip.SetToolTip(this.label24, "Go to official page");
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // textOLServer
            // 
            this.textOLServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.textOLServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOLServer.ForeColor = System.Drawing.Color.Azure;
            this.textOLServer.Location = new System.Drawing.Point(505, 39);
            this.textOLServer.Name = "textOLServer";
            this.textOLServer.Size = new System.Drawing.Size(107, 26);
            this.textOLServer.TabIndex = 25;
            this.TTip.SetToolTip(this.textOLServer, "URL of the Overlord-Server (http://overlord.com:8100/hidden/go.lcs");
            // 
            // textOLTime
            // 
            this.textOLTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.textOLTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOLTime.ForeColor = System.Drawing.Color.Azure;
            this.textOLTime.Location = new System.Drawing.Point(727, 39);
            this.textOLTime.MaxLength = 3;
            this.textOLTime.Name = "textOLTime";
            this.textOLTime.Size = new System.Drawing.Size(27, 26);
            this.textOLTime.TabIndex = 28;
            this.textOLTime.Text = "30";
            this.TTip.SetToolTip(this.textOLTime, "the time between rechecks of the OverLord CC (in minutes)");
            // 
            // chkbOLUp
            // 
            this.chkbOLUp.AutoSize = true;
            this.chkbOLUp.Checked = true;
            this.chkbOLUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbOLUp.Location = new System.Drawing.Point(626, 40);
            this.chkbOLUp.Name = "chkbOLUp";
            this.chkbOLUp.Size = new System.Drawing.Size(64, 23);
            this.chkbOLUp.TabIndex = 30;
            this.chkbOLUp.Text = "Up?";
            this.TTip.SetToolTip(this.chkbOLUp, "Search Up or Down in the Page. Use Up for Pages like Twitter or \"dedicated\" Web-P" +
        "ages and Down for Boards / Blogs.");
            this.chkbOLUp.UseVisualStyleBackColor = true;
            // 
            // enableHive
            // 
            this.enableHive.AutoSize = true;
            this.enableHive.Location = new System.Drawing.Point(377, 15);
            this.enableHive.Name = "enableHive";
            this.enableHive.Size = new System.Drawing.Size(190, 23);
            this.enableHive.TabIndex = 16;
            this.enableHive.Text = "IRC Mode (HiveMind)";
            this.TTip.SetToolTip(this.enableHive, "Fill the IRC options if you wish to use this mode");
            this.enableHive.UseVisualStyleBackColor = true;
            this.enableHive.CheckedChanged += new System.EventHandler(this.enableHive_CheckedChanged);
            // 
            // tShowStats
            // 
            this.tShowStats.Interval = 20;
            this.tShowStats.Tick += new System.EventHandler(this.tShowStats_Tick);
            // 
            // disableHive
            // 
            this.disableHive.AutoSize = true;
            this.disableHive.Checked = true;
            this.disableHive.Location = new System.Drawing.Point(212, 15);
            this.disableHive.Name = "disableHive";
            this.disableHive.Size = new System.Drawing.Size(245, 23);
            this.disableHive.TabIndex = 15;
            this.disableHive.TabStop = true;
            this.disableHive.Text = "Manual Mode (Do it yourself)";
            this.disableHive.UseVisualStyleBackColor = true;
            this.disableHive.CheckedChanged += new System.EventHandler(this.disableHive_CheckedChanged);
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(760, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(210, 16);
            this.label25.TabIndex = 17;
            this.label25.Text = "Disconnected.";
            // 
            // txtIRCserver
            // 
            this.txtIRCserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtIRCserver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIRCserver.ForeColor = System.Drawing.Color.Azure;
            this.txtIRCserver.Location = new System.Drawing.Point(505, 15);
            this.txtIRCserver.Name = "txtIRCserver";
            this.txtIRCserver.Size = new System.Drawing.Size(107, 26);
            this.txtIRCserver.TabIndex = 18;
            // 
            // txtIRCport
            // 
            this.txtIRCport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtIRCport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIRCport.ForeColor = System.Drawing.Color.Azure;
            this.txtIRCport.Location = new System.Drawing.Point(618, 15);
            this.txtIRCport.Name = "txtIRCport";
            this.txtIRCport.Size = new System.Drawing.Size(53, 26);
            this.txtIRCport.TabIndex = 19;
            this.txtIRCport.Text = "6667";
            // 
            // txtIRCchannel
            // 
            this.txtIRCchannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtIRCchannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIRCchannel.ForeColor = System.Drawing.Color.Azure;
            this.txtIRCchannel.Location = new System.Drawing.Point(677, 15);
            this.txtIRCchannel.Name = "txtIRCchannel";
            this.txtIRCchannel.Size = new System.Drawing.Size(77, 26);
            this.txtIRCchannel.TabIndex = 20;
            this.txtIRCchannel.Text = "#loic";
            // 
            // pBanner
            // 
            this.pBanner.Image = global::LLOIC.Properties.Resources.LOIC;
            this.pBanner.Location = new System.Drawing.Point(12, 12);
            this.pBanner.Name = "pBanner";
            this.pBanner.Size = new System.Drawing.Size(184, 462);
            this.pBanner.TabIndex = 12;
            this.pBanner.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "IRC server";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(615, 1);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 19);
            this.label26.TabIndex = 22;
            this.label26.Text = "Port";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(674, 1);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 19);
            this.label27.TabIndex = 23;
            this.label27.Text = "Channel";
            // 
            // enableOverlord
            // 
            this.enableOverlord.AutoSize = true;
            this.enableOverlord.Location = new System.Drawing.Point(377, 39);
            this.enableOverlord.Name = "enableOverlord";
            this.enableOverlord.Size = new System.Drawing.Size(153, 23);
            this.enableOverlord.TabIndex = 24;
            this.enableOverlord.Text = "DAMN OverLord";
            this.enableOverlord.UseVisualStyleBackColor = true;
            this.enableOverlord.CheckedChanged += new System.EventHandler(this.enableOverlord_CheckedChanged);
            // 
            // labelOLStatus
            // 
            this.labelOLStatus.Location = new System.Drawing.Point(760, 43);
            this.labelOLStatus.Name = "labelOLStatus";
            this.labelOLStatus.Size = new System.Drawing.Size(210, 16);
            this.labelOLStatus.TabIndex = 26;
            this.labelOLStatus.Text = "Disconnected.";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(680, 43);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 19);
            this.label28.TabIndex = 27;
            this.label28.Text = "Interval:";
            // 
            // tCheckOL
            // 
            this.tCheckOL.Interval = 300000;
            this.tCheckOL.Tick += new System.EventHandler(this.tCheckOL_Tick);
            // 
            // tZergRush
            // 
            this.tZergRush.Interval = 300000;
            this.tZergRush.Tick += new System.EventHandler(this.tStartZergRush);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(983, 486);
            this.Controls.Add(this.chkbOLUp);
            this.Controls.Add(this.textOLTime);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.labelOLStatus);
            this.Controls.Add(this.textOLServer);
            this.Controls.Add(this.enableOverlord);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIRCchannel);
            this.Controls.Add(this.txtIRCport);
            this.Controls.Add(this.txtIRCserver);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.enableHive);
            this.Controls.Add(this.disableHive);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.pBanner);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.Icon = global::LLOIC.Properties.Resources.LOIC_ICO;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_Closed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdTargetURL;
		private System.Windows.Forms.TextBox txtTargetURL;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdTargetIP;
		private System.Windows.Forms.TextBox txtTargetIP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtThreads;
		private System.Windows.Forms.ComboBox cbMethod;
		private System.Windows.Forms.TextBox txtTimeout;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button cmdAttack;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label lbDownloaded;
		private System.Windows.Forms.Label lbDownloading;
		private System.Windows.Forms.Label lbRequesting;
		private System.Windows.Forms.Label lbConnecting;
		private System.Windows.Forms.Label lbIdle;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lbFailed;
		private System.Windows.Forms.Label lbRequested;
		private System.Windows.Forms.TextBox txtSubsite;
		private System.Windows.Forms.ToolTip TTip;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.Timer tShowStats;
		private System.Windows.Forms.Label lbSepStatus;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.CheckBox chkWaitReply;
		private System.Windows.Forms.TrackBar tbSpeed;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbSepOptions;
		private System.Windows.Forms.PictureBox pBanner;
		private System.Windows.Forms.CheckBox chkMsgRandom;
		private System.Windows.Forms.CheckBox chkRandom;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.RadioButton disableHive;
		private System.Windows.Forms.RadioButton enableHive;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox txtIRCserver;
		private System.Windows.Forms.TextBox txtIRCport;
		private System.Windows.Forms.TextBox txtIRCchannel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.RadioButton enableOverlord;
		private System.Windows.Forms.TextBox textOLServer;
		private System.Windows.Forms.Label labelOLStatus;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox textOLTime;
		private System.Windows.Forms.Timer tCheckOL;
		private System.Windows.Forms.CheckBox chkbOLUp;
		private System.Windows.Forms.Timer tZergRush;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSLSpT;
		private System.Windows.Forms.CheckBox chkAllowGzip;
		private System.Windows.Forms.CheckBox chkUseGet;
	}
}