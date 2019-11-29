namespace OrionAntivirus
{
    partial class App
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
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.browseBtn = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteProgress = new System.Windows.Forms.ProgressBar();
            this.statusLbl = new System.Windows.Forms.Label();
            this.deleteLbl = new System.Windows.Forms.Label();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hashTxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.websiteLink = new System.Windows.Forms.LinkLabel();
            this.deleteTimer = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.scanLog = new System.Windows.Forms.RichTextBox();
            this.deleteTip = new System.Windows.Forms.ToolTip(this.components);
            this.browseTip = new System.Windows.Forms.ToolTip(this.components);
            this.isInfectedLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(483, 109);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(129, 27);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.Text = "Browse...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.Browse_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialog_FileOk);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-136, -27);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(599, 486);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Audiowide", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(457, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "ORION ANTIVIRUS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "v1.0.0 | Product by Velotics Technologies";
            // 
            // deleteProgress
            // 
            this.deleteProgress.Location = new System.Drawing.Point(141, 136);
            this.deleteProgress.Name = "deleteProgress";
            this.deleteProgress.Size = new System.Drawing.Size(471, 27);
            this.deleteProgress.TabIndex = 1;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.statusLbl.Location = new System.Drawing.Point(6, 3);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(145, 30);
            this.statusLbl.TabIndex = 2;
            this.statusLbl.Text = "1. Choose File";
            // 
            // deleteLbl
            // 
            this.deleteLbl.AutoSize = true;
            this.deleteLbl.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteLbl.Location = new System.Drawing.Point(6, 3);
            this.deleteLbl.Name = "deleteLbl";
            this.deleteLbl.Size = new System.Drawing.Size(223, 30);
            this.deleteLbl.TabIndex = 4;
            this.deleteLbl.Text = "2. Delete Infected File";
            // 
            // filePathTxt
            // 
            this.filePathTxt.Location = new System.Drawing.Point(98, 139);
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(514, 21);
            this.filePathTxt.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(243, 259);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 200);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.hashTxt);
            this.tabPage1.Controls.Add(this.browseBtn);
            this.tabPage1.Controls.Add(this.filePathTxt);
            this.tabPage1.Controls.Add(this.statusLbl);
            this.tabPage1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scan a File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(8, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "File Path:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(2, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "MD5 Hash:";
            // 
            // hashTxt
            // 
            this.hashTxt.Location = new System.Drawing.Point(98, 112);
            this.hashTxt.Name = "hashTxt";
            this.hashTxt.Size = new System.Drawing.Size(379, 21);
            this.hashTxt.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.isInfectedLbl);
            this.tabPage2.Controls.Add(this.deleteBtn);
            this.tabPage2.Controls.Add(this.deleteLbl);
            this.tabPage2.Controls.Add(this.deleteProgress);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 169);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Infected File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(6, 136);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(129, 27);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // websiteLink
            // 
            this.websiteLink.AutoSize = true;
            this.websiteLink.LinkArea = new System.Windows.Forms.LinkArea(0, 16);
            this.websiteLink.Location = new System.Drawing.Point(773, 78);
            this.websiteLink.Name = "websiteLink";
            this.websiteLink.Size = new System.Drawing.Size(86, 13);
            this.websiteLink.TabIndex = 6;
            this.websiteLink.TabStop = true;
            this.websiteLink.Text = "Velotics Website";
            this.websiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebsiteLink_LinkClicked);
            // 
            // deleteTimer
            // 
            this.deleteTimer.Tick += new System.EventHandler(this.DeleteTimer_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.scanLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(618, 169);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Scan Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // scanLog
            // 
            this.scanLog.Location = new System.Drawing.Point(6, 6);
            this.scanLog.Name = "scanLog";
            this.scanLog.Size = new System.Drawing.Size(606, 157);
            this.scanLog.TabIndex = 0;
            this.scanLog.Text = "";
            // 
            // isInfectedLbl
            // 
            this.isInfectedLbl.AutoSize = true;
            this.isInfectedLbl.Location = new System.Drawing.Point(6, 115);
            this.isInfectedLbl.Name = "isInfectedLbl";
            this.isInfectedLbl.Size = new System.Drawing.Size(50, 18);
            this.isInfectedLbl.TabIndex = 6;
            this.isInfectedLbl.Text = "Delete?";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 461);
            this.Controls.Add(this.websiteLink);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.Text = "Orion Antivirus - Scan Files for Malware";
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar deleteProgress;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label deleteLbl;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox hashTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel websiteLink;
        private System.Windows.Forms.Timer deleteTimer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox scanLog;
        private System.Windows.Forms.ToolTip deleteTip;
        private System.Windows.Forms.ToolTip browseTip;
        private System.Windows.Forms.Label isInfectedLbl;
    }
}

