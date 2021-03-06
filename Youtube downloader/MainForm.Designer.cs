﻿namespace Youtube_downloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.groupBoxQlty = new System.Windows.Forms.GroupBox();
            this.rdb4k = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbmaxqlty = new System.Windows.Forms.RadioButton();
            this.rdbsd360 = new System.Windows.Forms.RadioButton();
            this.rdbsd480 = new System.Windows.Forms.RadioButton();
            this.rdbhd720 = new System.Windows.Forms.RadioButton();
            this.rdbhd1080 = new System.Windows.Forms.RadioButton();
            this.groupBoxFtype = new System.Windows.Forms.GroupBox();
            this.rdbmp3 = new System.Windows.Forms.RadioButton();
            this.rdbwebm = new System.Windows.Forms.RadioButton();
            this.rdbmp4 = new System.Windows.Forms.RadioButton();
            this.btndwnld = new System.Windows.Forms.Button();
            this.chkDefLoc = new System.Windows.Forms.CheckBox();
            this.chkPlaylst = new System.Windows.Forms.CheckBox();
            this.lblPLstart = new System.Windows.Forms.Label();
            this.txtPLstart = new System.Windows.Forms.TextBox();
            this.lblPLend = new System.Windows.Forms.Label();
            this.txtPLend = new System.Windows.Forms.TextBox();
            this.linkgit = new System.Windows.Forms.LinkLabel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnHideSt = new System.Windows.Forms.Button();
            this.btnRld = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.prgrsbr = new System.Windows.Forms.ProgressBar();
            this.YTtitlebackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.lblRetrv = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lstQ = new System.Windows.Forms.ListBox();
            this.btnAddQ = new System.Windows.Forms.Button();
            this.btnRmvQ = new System.Windows.Forms.Button();
            this.btnRmvAll = new System.Windows.Forms.Button();
            this.groupBoxQlty.SuspendLayout();
            this.groupBoxFtype.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(19, 33);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(122, 18);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "URL of the video:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(143, 34);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(529, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Location = new System.Drawing.Point(79, 90);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(62, 18);
            this.lblSave.TabIndex = 2;
            this.lblSave.Text = "Save to:";
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(143, 88);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(493, 20);
            this.txtdir.TabIndex = 2;
            this.txtdir.TextChanged += new System.EventHandler(this.txtdir_TextChanged);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Location = new System.Drawing.Point(639, 83);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(70, 30);
            this.btnbrowse.TabIndex = 3;
            this.btnbrowse.Text = "...";
            this.btnbrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnbrowse, "Browse for a folder");
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // groupBoxQlty
            // 
            this.groupBoxQlty.Controls.Add(this.rdb4k);
            this.groupBoxQlty.Controls.Add(this.label1);
            this.groupBoxQlty.Controls.Add(this.rdbmaxqlty);
            this.groupBoxQlty.Controls.Add(this.rdbsd360);
            this.groupBoxQlty.Controls.Add(this.rdbsd480);
            this.groupBoxQlty.Controls.Add(this.rdbhd720);
            this.groupBoxQlty.Controls.Add(this.rdbhd1080);
            this.groupBoxQlty.Location = new System.Drawing.Point(124, 168);
            this.groupBoxQlty.Name = "groupBoxQlty";
            this.groupBoxQlty.Size = new System.Drawing.Size(225, 137);
            this.groupBoxQlty.TabIndex = 8;
            this.groupBoxQlty.TabStop = false;
            this.groupBoxQlty.Text = "Quality (depends on availability)";
            this.toolTip1.SetToolTip(this.groupBoxQlty, resources.GetString("groupBoxQlty.ToolTip"));
            // 
            // rdb4k
            // 
            this.rdb4k.AutoSize = true;
            this.rdb4k.Location = new System.Drawing.Point(74, 39);
            this.rdb4k.Name = "rdb4k";
            this.rdb4k.Size = new System.Drawing.Size(76, 17);
            this.rdb4k.TabIndex = 10;
            this.rdb4k.TabStop = true;
            this.rdb4k.Text = "4k (DASH)";
            this.rdb4k.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "DASH requires ffmpeg to be installed.";
            // 
            // rdbmaxqlty
            // 
            this.rdbmaxqlty.AutoSize = true;
            this.rdbmaxqlty.Checked = true;
            this.rdbmaxqlty.Location = new System.Drawing.Point(9, 18);
            this.rdbmaxqlty.Name = "rdbmaxqlty";
            this.rdbmaxqlty.Size = new System.Drawing.Size(186, 17);
            this.rdbmaxqlty.TabIndex = 9;
            this.rdbmaxqlty.TabStop = true;
            this.rdbmaxqlty.Text = "Max. available quality (non DASH)";
            this.rdbmaxqlty.UseVisualStyleBackColor = true;
            // 
            // rdbsd360
            // 
            this.rdbsd360.AutoSize = true;
            this.rdbsd360.Location = new System.Drawing.Point(148, 89);
            this.rdbsd360.Name = "rdbsd360";
            this.rdbsd360.Size = new System.Drawing.Size(67, 17);
            this.rdbsd360.TabIndex = 14;
            this.rdbsd360.TabStop = true;
            this.rdbsd360.Text = "SD 360p";
            this.rdbsd360.UseVisualStyleBackColor = true;
            // 
            // rdbsd480
            // 
            this.rdbsd480.AutoSize = true;
            this.rdbsd480.Location = new System.Drawing.Point(9, 89);
            this.rdbsd480.Name = "rdbsd480";
            this.rdbsd480.Size = new System.Drawing.Size(106, 17);
            this.rdbsd480.TabIndex = 13;
            this.rdbsd480.TabStop = true;
            this.rdbsd480.Text = "SD 480p (DASH)";
            this.rdbsd480.UseVisualStyleBackColor = true;
            // 
            // rdbhd720
            // 
            this.rdbhd720.AutoSize = true;
            this.rdbhd720.Location = new System.Drawing.Point(148, 62);
            this.rdbhd720.Name = "rdbhd720";
            this.rdbhd720.Size = new System.Drawing.Size(68, 17);
            this.rdbhd720.TabIndex = 12;
            this.rdbhd720.TabStop = true;
            this.rdbhd720.Text = "HD 720p";
            this.rdbhd720.UseVisualStyleBackColor = true;
            // 
            // rdbhd1080
            // 
            this.rdbhd1080.AutoSize = true;
            this.rdbhd1080.Location = new System.Drawing.Point(9, 62);
            this.rdbhd1080.Name = "rdbhd1080";
            this.rdbhd1080.Size = new System.Drawing.Size(113, 17);
            this.rdbhd1080.TabIndex = 11;
            this.rdbhd1080.TabStop = true;
            this.rdbhd1080.Text = "HD 1080p (DASH)";
            this.rdbhd1080.UseVisualStyleBackColor = true;
            // 
            // groupBoxFtype
            // 
            this.groupBoxFtype.Controls.Add(this.rdbmp3);
            this.groupBoxFtype.Controls.Add(this.rdbwebm);
            this.groupBoxFtype.Controls.Add(this.rdbmp4);
            this.groupBoxFtype.Location = new System.Drawing.Point(392, 168);
            this.groupBoxFtype.Name = "groupBoxFtype";
            this.groupBoxFtype.Size = new System.Drawing.Size(213, 137);
            this.groupBoxFtype.TabIndex = 15;
            this.groupBoxFtype.TabStop = false;
            this.groupBoxFtype.Text = "File type";
            // 
            // rdbmp3
            // 
            this.rdbmp3.AutoSize = true;
            this.rdbmp3.Location = new System.Drawing.Point(69, 98);
            this.rdbmp3.Name = "rdbmp3";
            this.rdbmp3.Size = new System.Drawing.Size(105, 17);
            this.rdbmp3.TabIndex = 17;
            this.rdbmp3.TabStop = true;
            this.rdbmp3.Text = "MP3 (Audio only)";
            this.rdbmp3.UseVisualStyleBackColor = true;
            // 
            // rdbwebm
            // 
            this.rdbwebm.AutoSize = true;
            this.rdbwebm.Location = new System.Drawing.Point(142, 48);
            this.rdbwebm.Name = "rdbwebm";
            this.rdbwebm.Size = new System.Drawing.Size(53, 17);
            this.rdbwebm.TabIndex = 16;
            this.rdbwebm.Text = "webm";
            this.rdbwebm.UseVisualStyleBackColor = true;
            // 
            // rdbmp4
            // 
            this.rdbmp4.AutoSize = true;
            this.rdbmp4.Checked = true;
            this.rdbmp4.Location = new System.Drawing.Point(18, 48);
            this.rdbmp4.Name = "rdbmp4";
            this.rdbmp4.Size = new System.Drawing.Size(47, 17);
            this.rdbmp4.TabIndex = 15;
            this.rdbmp4.TabStop = true;
            this.rdbmp4.Text = "MP4";
            this.rdbmp4.UseVisualStyleBackColor = true;
            // 
            // btndwnld
            // 
            this.btndwnld.Location = new System.Drawing.Point(384, 334);
            this.btndwnld.Name = "btndwnld";
            this.btndwnld.Size = new System.Drawing.Size(123, 27);
            this.btndwnld.TabIndex = 17;
            this.btndwnld.Text = "Download";
            this.toolTip1.SetToolTip(this.btndwnld, "Click to download the video(s).");
            this.btndwnld.UseVisualStyleBackColor = true;
            this.btndwnld.Click += new System.EventHandler(this.btndwnld_Click);
            // 
            // chkDefLoc
            // 
            this.chkDefLoc.AutoSize = true;
            this.chkDefLoc.Location = new System.Drawing.Point(143, 116);
            this.chkDefLoc.Name = "chkDefLoc";
            this.chkDefLoc.Size = new System.Drawing.Size(131, 17);
            this.chkDefLoc.TabIndex = 4;
            this.chkDefLoc.Text = "Set as default location";
            this.chkDefLoc.UseVisualStyleBackColor = true;
            this.chkDefLoc.CheckedChanged += new System.EventHandler(this.chkDefLoc_CheckedChanged);
            // 
            // chkPlaylst
            // 
            this.chkPlaylst.AutoSize = true;
            this.chkPlaylst.Location = new System.Drawing.Point(143, 60);
            this.chkPlaylst.Name = "chkPlaylst";
            this.chkPlaylst.Size = new System.Drawing.Size(157, 17);
            this.chkPlaylst.TabIndex = 18;
            this.chkPlaylst.Text = "URL is for a youtube playlist";
            this.toolTip1.SetToolTip(this.chkPlaylst, "Check if the URL you have entered is for a playlist.");
            this.chkPlaylst.UseVisualStyleBackColor = true;
            this.chkPlaylst.CheckedChanged += new System.EventHandler(this.chkPlaylst_CheckedChanged);
            // 
            // lblPLstart
            // 
            this.lblPLstart.AutoSize = true;
            this.lblPLstart.Enabled = false;
            this.lblPLstart.Location = new System.Drawing.Point(302, 61);
            this.lblPLstart.Name = "lblPLstart";
            this.lblPLstart.Size = new System.Drawing.Size(153, 13);
            this.lblPLstart.TabIndex = 19;
            this.lblPLstart.Text = "Start from number (default is 1):";
            // 
            // txtPLstart
            // 
            this.txtPLstart.Enabled = false;
            this.txtPLstart.Location = new System.Drawing.Point(461, 61);
            this.txtPLstart.Name = "txtPLstart";
            this.txtPLstart.Size = new System.Drawing.Size(39, 20);
            this.txtPLstart.TabIndex = 20;
            // 
            // lblPLend
            // 
            this.lblPLend.AutoSize = true;
            this.lblPLend.Enabled = false;
            this.lblPLend.Location = new System.Drawing.Point(512, 63);
            this.lblPLend.Name = "lblPLend";
            this.lblPLend.Size = new System.Drawing.Size(149, 13);
            this.lblPLend.TabIndex = 21;
            this.lblPLend.Text = "End at number (default is last):";
            // 
            // txtPLend
            // 
            this.txtPLend.Enabled = false;
            this.txtPLend.Location = new System.Drawing.Point(667, 60);
            this.txtPLend.Name = "txtPLend";
            this.txtPLend.Size = new System.Drawing.Size(40, 20);
            this.txtPLend.TabIndex = 22;
            // 
            // linkgit
            // 
            this.linkgit.AutoSize = true;
            this.linkgit.Location = new System.Drawing.Point(636, 4);
            this.linkgit.Name = "linkgit";
            this.linkgit.Size = new System.Drawing.Size(91, 13);
            this.linkgit.TabIndex = 23;
            this.linkgit.TabStop = true;
            this.linkgit.Text = "github.com/rnand";
            this.toolTip1.SetToolTip(this.linkgit, "Go to the GitHub page of the developer.");
            this.linkgit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkgit_LinkClicked);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(12, 374);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(705, 20);
            this.txtStatus.TabIndex = 24;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatus.Visible = false;
            // 
            // btnHideSt
            // 
            this.btnHideSt.Location = new System.Drawing.Point(531, 335);
            this.btnHideSt.Name = "btnHideSt";
            this.btnHideSt.Size = new System.Drawing.Size(123, 27);
            this.btnHideSt.TabIndex = 25;
            this.btnHideSt.Text = "Hide queue";
            this.toolTip1.SetToolTip(this.btnHideSt, "Display or hide the queue.");
            this.btnHideSt.UseVisualStyleBackColor = true;
            this.btnHideSt.Visible = false;
            this.btnHideSt.Click += new System.EventHandler(this.btnHideSt_Click);
            // 
            // btnRld
            // 
            this.btnRld.BackgroundImage = global::YouTube_downloader.Properties.Resources.reload_icon_hi;
            this.btnRld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRld.Location = new System.Drawing.Point(678, 25);
            this.btnRld.Name = "btnRld";
            this.btnRld.Size = new System.Drawing.Size(31, 29);
            this.btnRld.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnRld, "Reload URL from clipboard.");
            this.btnRld.UseVisualStyleBackColor = true;
            this.btnRld.Click += new System.EventHandler(this.btnRld_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 32767;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // prgrsbr
            // 
            this.prgrsbr.Location = new System.Drawing.Point(16, 313);
            this.prgrsbr.Maximum = 1000;
            this.prgrsbr.Name = "prgrsbr";
            this.prgrsbr.Size = new System.Drawing.Size(693, 13);
            this.prgrsbr.TabIndex = 27;
            this.prgrsbr.Visible = false;
            // 
            // YTtitlebackgroundWorker
            // 
            this.YTtitlebackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.YTtitlebackgroundWorker_DoWork);
            this.YTtitlebackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.YTtitlebackgroundWorker_RunWorkerCompleted);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(141, 138);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(510, 20);
            this.txtfilename.TabIndex = 7;
            // 
            // lblRetrv
            // 
            this.lblRetrv.AutoSize = true;
            this.lblRetrv.Location = new System.Drawing.Point(144, 142);
            this.lblRetrv.Name = "lblRetrv";
            this.lblRetrv.Size = new System.Drawing.Size(83, 13);
            this.lblRetrv.TabIndex = 11;
            this.lblRetrv.Text = "Retrieving title...";
            this.lblRetrv.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(56, 138);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(79, 18);
            this.lblFileName.TabIndex = 12;
            this.lblFileName.Text = "File Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(383, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 27);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel download";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(87, 335);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(123, 27);
            this.btnPause.TabIndex = 29;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lstQ
            // 
            this.lstQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstQ.FormattingEnabled = true;
            this.lstQ.Location = new System.Drawing.Point(12, 398);
            this.lstQ.Name = "lstQ";
            this.lstQ.Size = new System.Drawing.Size(705, 106);
            this.lstQ.TabIndex = 30;
            this.lstQ.Visible = false;
            this.lstQ.SelectedIndexChanged += new System.EventHandler(this.lstQ_SelectedIndexChanged);
            // 
            // btnAddQ
            // 
            this.btnAddQ.Location = new System.Drawing.Point(235, 335);
            this.btnAddQ.Name = "btnAddQ";
            this.btnAddQ.Size = new System.Drawing.Size(123, 27);
            this.btnAddQ.TabIndex = 31;
            this.btnAddQ.Text = "Add to queue";
            this.btnAddQ.UseVisualStyleBackColor = true;
            this.btnAddQ.Click += new System.EventHandler(this.btnAddQ_Click);
            // 
            // btnRmvQ
            // 
            this.btnRmvQ.Location = new System.Drawing.Point(602, 400);
            this.btnRmvQ.Name = "btnRmvQ";
            this.btnRmvQ.Size = new System.Drawing.Size(95, 36);
            this.btnRmvQ.TabIndex = 32;
            this.btnRmvQ.Text = "Remove selected item";
            this.btnRmvQ.UseVisualStyleBackColor = true;
            this.btnRmvQ.Visible = false;
            this.btnRmvQ.Click += new System.EventHandler(this.btnRmvQ_Click);
            // 
            // btnRmvAll
            // 
            this.btnRmvAll.Location = new System.Drawing.Point(602, 442);
            this.btnRmvAll.Name = "btnRmvAll";
            this.btnRmvAll.Size = new System.Drawing.Size(95, 38);
            this.btnRmvAll.TabIndex = 33;
            this.btnRmvAll.Text = "Remove all items";
            this.btnRmvAll.UseVisualStyleBackColor = true;
            this.btnRmvAll.Visible = false;
            this.btnRmvAll.Click += new System.EventHandler(this.btnRmvAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 507);
            this.Controls.Add(this.btnRmvAll);
            this.Controls.Add(this.btnRmvQ);
            this.Controls.Add(this.btnAddQ);
            this.Controls.Add(this.lstQ);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.prgrsbr);
            this.Controls.Add(this.lblRetrv);
            this.Controls.Add(this.btnRld);
            this.Controls.Add(this.btnHideSt);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.linkgit);
            this.Controls.Add(this.txtPLend);
            this.Controls.Add(this.lblPLend);
            this.Controls.Add(this.txtPLstart);
            this.Controls.Add(this.lblPLstart);
            this.Controls.Add(this.chkPlaylst);
            this.Controls.Add(this.chkDefLoc);
            this.Controls.Add(this.btndwnld);
            this.Controls.Add(this.groupBoxFtype);
            this.Controls.Add(this.groupBoxQlty);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "YouTube Downloader 1.5.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxQlty.ResumeLayout(false);
            this.groupBoxQlty.PerformLayout();
            this.groupBoxFtype.ResumeLayout(false);
            this.groupBoxFtype.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.GroupBox groupBoxQlty;
        private System.Windows.Forms.RadioButton rdbsd360;
        private System.Windows.Forms.RadioButton rdbsd480;
        private System.Windows.Forms.RadioButton rdbhd720;
        private System.Windows.Forms.RadioButton rdbhd1080;
        private System.Windows.Forms.GroupBox groupBoxFtype;
        private System.Windows.Forms.RadioButton rdbwebm;
        private System.Windows.Forms.RadioButton rdbmp4;
        private System.Windows.Forms.Button btndwnld;
        private System.Windows.Forms.RadioButton rdbmaxqlty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDefLoc;
        private System.Windows.Forms.RadioButton rdb4k;
        private System.Windows.Forms.CheckBox chkPlaylst;
        private System.Windows.Forms.Label lblPLstart;
        private System.Windows.Forms.TextBox txtPLstart;
        private System.Windows.Forms.Label lblPLend;
        private System.Windows.Forms.TextBox txtPLend;
        private System.Windows.Forms.LinkLabel linkgit;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnHideSt;
        private System.Windows.Forms.Button btnRld;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar prgrsbr;
        private System.ComponentModel.BackgroundWorker YTtitlebackgroundWorker;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label lblRetrv;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.RadioButton rdbmp3;
        private System.Windows.Forms.ListBox lstQ;
        private System.Windows.Forms.Button btnAddQ;
        private System.Windows.Forms.Button btnRmvQ;
        private System.Windows.Forms.Button btnRmvAll;
    }
}

