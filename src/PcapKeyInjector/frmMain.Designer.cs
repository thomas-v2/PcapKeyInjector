
namespace PcapKeyInjector
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPathToEditcap = new System.Windows.Forms.TextBox();
            this.tbOutputFilenamePattern = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutputDirectory = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxPcapFile = new System.Windows.Forms.GroupBox();
            this.btnBrowseInputPcap = new System.Windows.Forms.Button();
            this.tbInputPcap = new System.Windows.Forms.TextBox();
            this.groupBoxKeyFile = new System.Windows.Forms.GroupBox();
            this.btnBrowseInputKeylog = new System.Windows.Forms.Button();
            this.tbInputKeylog = new System.Windows.Forms.TextBox();
            this.btnDoInject = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOutputFilename = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBoxPcapFile.SuspendLayout();
            this.groupBoxKeyFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to editcap.exe (from Wireshark installation):";
            // 
            // tbPathToEditcap
            // 
            this.tbPathToEditcap.Location = new System.Drawing.Point(12, 25);
            this.tbPathToEditcap.Name = "tbPathToEditcap";
            this.tbPathToEditcap.Size = new System.Drawing.Size(410, 20);
            this.tbPathToEditcap.TabIndex = 1;
            this.tbPathToEditcap.Text = "C:\\Program Files\\Wireshark\\editcap.exe";
            // 
            // tbOutputFilenamePattern
            // 
            this.tbOutputFilenamePattern.Location = new System.Drawing.Point(12, 64);
            this.tbOutputFilenamePattern.Name = "tbOutputFilenamePattern";
            this.tbOutputFilenamePattern.Size = new System.Drawing.Size(410, 20);
            this.tbOutputFilenamePattern.TabIndex = 2;
            this.tbOutputFilenamePattern.Text = "{1}_withKey";
            this.tbOutputFilenamePattern.TextChanged += new System.EventHandler(this.tbOutputFilenameScheme_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output filename pattern (use {1}=pcap filename, {2}=key filename):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output directory:";
            // 
            // tbOutputDirectory
            // 
            this.tbOutputDirectory.Location = new System.Drawing.Point(12, 103);
            this.tbOutputDirectory.Name = "tbOutputDirectory";
            this.tbOutputDirectory.Size = new System.Drawing.Size(410, 20);
            this.tbOutputDirectory.TabIndex = 5;
            this.tbOutputDirectory.Text = "C:\\temp";
            this.tbOutputDirectory.TextChanged += new System.EventHandler(this.tbOutputDirectory_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(852, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(837, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Ready.";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxPcapFile
            // 
            this.groupBoxPcapFile.AutoSize = true;
            this.groupBoxPcapFile.Controls.Add(this.btnBrowseInputPcap);
            this.groupBoxPcapFile.Controls.Add(this.tbInputPcap);
            this.groupBoxPcapFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPcapFile.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPcapFile.Name = "groupBoxPcapFile";
            this.groupBoxPcapFile.Size = new System.Drawing.Size(411, 282);
            this.groupBoxPcapFile.TabIndex = 8;
            this.groupBoxPcapFile.TabStop = false;
            this.groupBoxPcapFile.Text = "Drop pcapng file here, enter filename, or use browse button";
            // 
            // btnBrowseInputPcap
            // 
            this.btnBrowseInputPcap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInputPcap.Location = new System.Drawing.Point(3, 259);
            this.btnBrowseInputPcap.Name = "btnBrowseInputPcap";
            this.btnBrowseInputPcap.Size = new System.Drawing.Size(405, 23);
            this.btnBrowseInputPcap.TabIndex = 1;
            this.btnBrowseInputPcap.Text = "Browse pcapng files";
            this.btnBrowseInputPcap.UseVisualStyleBackColor = true;
            this.btnBrowseInputPcap.Click += new System.EventHandler(this.btnBrowseInputPcap_Click);
            // 
            // tbInputPcap
            // 
            this.tbInputPcap.AllowDrop = true;
            this.tbInputPcap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInputPcap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbInputPcap.Location = new System.Drawing.Point(3, 16);
            this.tbInputPcap.Multiline = true;
            this.tbInputPcap.Name = "tbInputPcap";
            this.tbInputPcap.Size = new System.Drawing.Size(405, 237);
            this.tbInputPcap.TabIndex = 0;
            this.tbInputPcap.TextChanged += new System.EventHandler(this.tbInputPcap_TextChanged);
            this.tbInputPcap.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbInputPcap_DragDrop);
            this.tbInputPcap.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbInputPcap_DragEnter);
            // 
            // groupBoxKeyFile
            // 
            this.groupBoxKeyFile.AutoSize = true;
            this.groupBoxKeyFile.Controls.Add(this.btnBrowseInputKeylog);
            this.groupBoxKeyFile.Controls.Add(this.tbInputKeylog);
            this.groupBoxKeyFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKeyFile.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKeyFile.Name = "groupBoxKeyFile";
            this.groupBoxKeyFile.Size = new System.Drawing.Size(408, 282);
            this.groupBoxKeyFile.TabIndex = 9;
            this.groupBoxKeyFile.TabStop = false;
            this.groupBoxKeyFile.Text = "Drop key.log file here, enter filename, or use browse button";
            // 
            // btnBrowseInputKeylog
            // 
            this.btnBrowseInputKeylog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInputKeylog.Location = new System.Drawing.Point(3, 259);
            this.btnBrowseInputKeylog.Name = "btnBrowseInputKeylog";
            this.btnBrowseInputKeylog.Size = new System.Drawing.Size(402, 23);
            this.btnBrowseInputKeylog.TabIndex = 1;
            this.btnBrowseInputKeylog.Text = "Browse keylog files";
            this.btnBrowseInputKeylog.UseVisualStyleBackColor = true;
            this.btnBrowseInputKeylog.Click += new System.EventHandler(this.btnBrowseInputKeylog_Click);
            // 
            // tbInputKeylog
            // 
            this.tbInputKeylog.AllowDrop = true;
            this.tbInputKeylog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInputKeylog.BackColor = System.Drawing.SystemColors.Info;
            this.tbInputKeylog.Location = new System.Drawing.Point(3, 16);
            this.tbInputKeylog.Multiline = true;
            this.tbInputKeylog.Name = "tbInputKeylog";
            this.tbInputKeylog.Size = new System.Drawing.Size(402, 237);
            this.tbInputKeylog.TabIndex = 0;
            this.tbInputKeylog.TextChanged += new System.EventHandler(this.tbInputKeylog_TextChanged);
            this.tbInputKeylog.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbInputKeylog_DragDrop);
            this.tbInputKeylog.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbInputKeylog_DragEnter);
            // 
            // btnDoInject
            // 
            this.btnDoInject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoInject.Enabled = false;
            this.btnDoInject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoInject.Location = new System.Drawing.Point(488, 25);
            this.btnDoInject.Name = "btnDoInject";
            this.btnDoInject.Size = new System.Drawing.Size(347, 59);
            this.btnDoInject.TabIndex = 10;
            this.btnDoInject.Text = "Inject";
            this.btnDoInject.UseVisualStyleBackColor = true;
            this.btnDoInject.Click += new System.EventHandler(this.btnDoInject_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 129);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPcapFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxKeyFile);
            this.splitContainer1.Size = new System.Drawing.Size(823, 282);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Output will be saved as:";
            // 
            // tbOutputFilename
            // 
            this.tbOutputFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutputFilename.Location = new System.Drawing.Point(427, 103);
            this.tbOutputFilename.Name = "tbOutputFilename";
            this.tbOutputFilename.ReadOnly = true;
            this.tbOutputFilename.Size = new System.Drawing.Size(405, 20);
            this.tbOutputFilename.TabIndex = 14;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(428, 25);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(54, 59);
            this.btnSaveSettings.TabIndex = 15;
            this.btnSaveSettings.Text = "Save\r\nSettings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 436);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.tbOutputFilename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnDoInject);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbOutputDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOutputFilenamePattern);
            this.Controls.Add(this.tbPathToEditcap);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(868, 474);
            this.Name = "frmMain";
            this.Text = "Pcap Key Injector";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxPcapFile.ResumeLayout(false);
            this.groupBoxPcapFile.PerformLayout();
            this.groupBoxKeyFile.ResumeLayout(false);
            this.groupBoxKeyFile.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPathToEditcap;
        private System.Windows.Forms.TextBox tbOutputFilenamePattern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOutputDirectory;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBoxPcapFile;
        private System.Windows.Forms.GroupBox groupBoxKeyFile;
        private System.Windows.Forms.Button btnDoInject;
        private System.Windows.Forms.TextBox tbInputPcap;
        private System.Windows.Forms.TextBox tbInputKeylog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOutputFilename;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnBrowseInputPcap;
        private System.Windows.Forms.Button btnBrowseInputKeylog;
    }
}

