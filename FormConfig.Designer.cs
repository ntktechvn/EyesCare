﻿namespace EyesCare
{
    partial class FormConfig
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            notifyIconTaskbar = new NotifyIcon(components);
            contextMenuTaskbar = new ContextMenuStrip(components);
            configToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            comboBoxLongBreakTime = new ComboBox();
            label2 = new Label();
            comboBoxLongBreakRestTime = new ComboBox();
            comboBoxShortBreakRestTime = new ComboBox();
            label3 = new Label();
            comboBoxShortBreakTime = new ComboBox();
            checkBoxShortBreak = new CheckBox();
            buttonTestShortBreak = new Button();
            checkBoxPreventClose = new CheckBox();
            checkBoxLongBreak = new CheckBox();
            buttonTestLongBreak = new Button();
            buttonSaveConfig = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelShortBreakTimer = new ToolStripStatusLabel();
            toolStripStatusLabelLongtBreakTimer = new ToolStripStatusLabel();
            toolStripStatusLabelPause = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            checkBoxCheckIDLE = new CheckBox();
            checkBoxStartWithWindow = new CheckBox();
            tabPage2 = new TabPage();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonPause1H = new Button();
            tạmDừng1GiờToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem1H = new ToolStripMenuItem();
            pauseToolStripMenuItem2H = new ToolStripMenuItem();
            contextMenuTaskbar.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // notifyIconTaskbar
            // 
            notifyIconTaskbar.ContextMenuStrip = contextMenuTaskbar;
            notifyIconTaskbar.Icon = (Icon)resources.GetObject("notifyIconTaskbar.Icon");
            notifyIconTaskbar.Text = "Bảo vệ mắt và cột sống";
            notifyIconTaskbar.Visible = true;
            notifyIconTaskbar.DoubleClick += notifyIconTaskbar_DoubleClick;
            // 
            // contextMenuTaskbar
            // 
            contextMenuTaskbar.ImageScalingSize = new Size(24, 24);
            contextMenuTaskbar.Items.AddRange(new ToolStripItem[] { configToolStripMenuItem, tạmDừng1GiờToolStripMenuItem, exitToolStripMenuItem });
            contextMenuTaskbar.Name = "contextMenuTaskbar";
            contextMenuTaskbar.Size = new Size(181, 92);
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(180, 22);
            configToolStripMenuItem.Text = "Cấu hình";
            configToolStripMenuItem.Click += configToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Thoát";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // comboBoxLongBreakTime
            // 
            comboBoxLongBreakTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLongBreakTime.FormattingEnabled = true;
            comboBoxLongBreakTime.Location = new Point(187, 47);
            comboBoxLongBreakTime.Margin = new Padding(2);
            comboBoxLongBreakTime.Name = "comboBoxLongBreakTime";
            comboBoxLongBreakTime.Size = new Size(68, 23);
            comboBoxLongBreakTime.TabIndex = 2;
            comboBoxLongBreakTime.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 47);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "trong";
            // 
            // comboBoxLongBreakRestTime
            // 
            comboBoxLongBreakRestTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLongBreakRestTime.FormattingEnabled = true;
            comboBoxLongBreakRestTime.Location = new Point(313, 47);
            comboBoxLongBreakRestTime.Margin = new Padding(2);
            comboBoxLongBreakRestTime.Name = "comboBoxLongBreakRestTime";
            comboBoxLongBreakRestTime.Size = new Size(68, 23);
            comboBoxLongBreakRestTime.TabIndex = 4;
            // 
            // comboBoxShortBreakRestTime
            // 
            comboBoxShortBreakRestTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShortBreakRestTime.FormattingEnabled = true;
            comboBoxShortBreakRestTime.Location = new Point(313, 13);
            comboBoxShortBreakRestTime.Margin = new Padding(2);
            comboBoxShortBreakRestTime.Name = "comboBoxShortBreakRestTime";
            comboBoxShortBreakRestTime.Size = new Size(68, 23);
            comboBoxShortBreakRestTime.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 13);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "trong";
            // 
            // comboBoxShortBreakTime
            // 
            comboBoxShortBreakTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShortBreakTime.FormattingEnabled = true;
            comboBoxShortBreakTime.Location = new Point(187, 13);
            comboBoxShortBreakTime.Margin = new Padding(2);
            comboBoxShortBreakTime.Name = "comboBoxShortBreakTime";
            comboBoxShortBreakTime.Size = new Size(68, 23);
            comboBoxShortBreakTime.TabIndex = 6;
            // 
            // checkBoxShortBreak
            // 
            checkBoxShortBreak.AutoSize = true;
            checkBoxShortBreak.Checked = true;
            checkBoxShortBreak.CheckState = CheckState.Checked;
            checkBoxShortBreak.Location = new Point(7, 13);
            checkBoxShortBreak.Margin = new Padding(2);
            checkBoxShortBreak.Name = "checkBoxShortBreak";
            checkBoxShortBreak.Size = new Size(171, 19);
            checkBoxShortBreak.TabIndex = 14;
            checkBoxShortBreak.Text = "Cho mắt nghỉ ngơi sau mỗi";
            checkBoxShortBreak.UseVisualStyleBackColor = true;
            // 
            // buttonTestShortBreak
            // 
            buttonTestShortBreak.Location = new Point(387, 13);
            buttonTestShortBreak.Margin = new Padding(2);
            buttonTestShortBreak.Name = "buttonTestShortBreak";
            buttonTestShortBreak.Size = new Size(73, 23);
            buttonTestShortBreak.TabIndex = 10;
            buttonTestShortBreak.Text = "Nghỉ ngay";
            buttonTestShortBreak.UseVisualStyleBackColor = true;
            buttonTestShortBreak.Click += buttonTestShortBreak_Click;
            // 
            // checkBoxPreventClose
            // 
            checkBoxPreventClose.AutoSize = true;
            checkBoxPreventClose.Checked = true;
            checkBoxPreventClose.CheckState = CheckState.Checked;
            checkBoxPreventClose.Location = new Point(7, 80);
            checkBoxPreventClose.Margin = new Padding(2);
            checkBoxPreventClose.Name = "checkBoxPreventClose";
            checkBoxPreventClose.Size = new Size(327, 19);
            checkBoxPreventClose.TabIndex = 16;
            checkBoxPreventClose.Text = "Bắt buộc phải nghỉ ngơi (Không cho phép tắt thông báo)";
            checkBoxPreventClose.UseVisualStyleBackColor = true;
            // 
            // checkBoxLongBreak
            // 
            checkBoxLongBreak.AutoSize = true;
            checkBoxLongBreak.Checked = true;
            checkBoxLongBreak.CheckState = CheckState.Checked;
            checkBoxLongBreak.Location = new Point(7, 47);
            checkBoxLongBreak.Margin = new Padding(2);
            checkBoxLongBreak.Name = "checkBoxLongBreak";
            checkBoxLongBreak.Size = new Size(158, 19);
            checkBoxLongBreak.TabIndex = 15;
            checkBoxLongBreak.Text = "Vận động cơ thể sau mỗi";
            checkBoxLongBreak.UseVisualStyleBackColor = true;
            // 
            // buttonTestLongBreak
            // 
            buttonTestLongBreak.Location = new Point(387, 47);
            buttonTestLongBreak.Margin = new Padding(2);
            buttonTestLongBreak.Name = "buttonTestLongBreak";
            buttonTestLongBreak.Size = new Size(73, 23);
            buttonTestLongBreak.TabIndex = 9;
            buttonTestLongBreak.Text = "Nghỉ ngay";
            buttonTestLongBreak.UseVisualStyleBackColor = true;
            buttonTestLongBreak.Click += buttonTestLongbreak_Click;
            // 
            // buttonSaveConfig
            // 
            buttonSaveConfig.Location = new Point(7, 173);
            buttonSaveConfig.Margin = new Padding(2);
            buttonSaveConfig.Name = "buttonSaveConfig";
            buttonSaveConfig.Size = new Size(93, 27);
            buttonSaveConfig.TabIndex = 11;
            buttonSaveConfig.Text = "Lưu cấu hình";
            buttonSaveConfig.UseVisualStyleBackColor = true;
            buttonSaveConfig.Click += buttonSaveConfig_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelShortBreakTimer, toolStripStatusLabelLongtBreakTimer, toolStripStatusLabelPause });
            statusStrip1.Location = new Point(0, 246);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 9, 0);
            statusStrip1.Size = new Size(495, 22);
            statusStrip1.TabIndex = 19;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelShortBreakTimer
            // 
            toolStripStatusLabelShortBreakTimer.ForeColor = Color.SaddleBrown;
            toolStripStatusLabelShortBreakTimer.Name = "toolStripStatusLabelShortBreakTimer";
            toolStripStatusLabelShortBreakTimer.Size = new Size(63, 17);
            toolStripStatusLabelShortBreakTimer.Text = "Nghỉ ngắn";
            // 
            // toolStripStatusLabelLongtBreakTimer
            // 
            toolStripStatusLabelLongtBreakTimer.ForeColor = SystemColors.HotTrack;
            toolStripStatusLabelLongtBreakTimer.Name = "toolStripStatusLabelLongtBreakTimer";
            toolStripStatusLabelLongtBreakTimer.Size = new Size(52, 17);
            toolStripStatusLabelLongtBreakTimer.Text = "Nghỉ dài";
            // 
            // toolStripStatusLabelPause
            // 
            toolStripStatusLabelPause.ForeColor = Color.IndianRed;
            toolStripStatusLabelPause.Name = "toolStripStatusLabelPause";
            toolStripStatusLabelPause.Size = new Size(61, 17);
            toolStripStatusLabelPause.Text = "Tạm dừng";
            toolStripStatusLabelPause.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(7, 7);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(480, 233);
            tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonPause1H);
            tabPage1.Controls.Add(checkBoxCheckIDLE);
            tabPage1.Controls.Add(checkBoxStartWithWindow);
            tabPage1.Controls.Add(checkBoxLongBreak);
            tabPage1.Controls.Add(checkBoxShortBreak);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBoxLongBreakRestTime);
            tabPage1.Controls.Add(comboBoxShortBreakTime);
            tabPage1.Controls.Add(buttonSaveConfig);
            tabPage1.Controls.Add(checkBoxPreventClose);
            tabPage1.Controls.Add(buttonTestLongBreak);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(comboBoxShortBreakRestTime);
            tabPage1.Controls.Add(buttonTestShortBreak);
            tabPage1.Controls.Add(comboBoxLongBreakTime);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(472, 205);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cấu hình";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxCheckIDLE
            // 
            checkBoxCheckIDLE.AutoSize = true;
            checkBoxCheckIDLE.Checked = true;
            checkBoxCheckIDLE.CheckState = CheckState.Checked;
            checkBoxCheckIDLE.Location = new Point(7, 113);
            checkBoxCheckIDLE.Margin = new Padding(2);
            checkBoxCheckIDLE.Name = "checkBoxCheckIDLE";
            checkBoxCheckIDLE.Size = new Size(199, 19);
            checkBoxCheckIDLE.TabIndex = 18;
            checkBoxCheckIDLE.Text = "Tạm dừng nếu bạn không làm gì";
            checkBoxCheckIDLE.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartWithWindow
            // 
            checkBoxStartWithWindow.AutoSize = true;
            checkBoxStartWithWindow.Location = new Point(7, 147);
            checkBoxStartWithWindow.Margin = new Padding(2);
            checkBoxStartWithWindow.Name = "checkBoxStartWithWindow";
            checkBoxStartWithWindow.Size = new Size(163, 19);
            checkBoxStartWithWindow.TabIndex = 17;
            checkBoxStartWithWindow.Text = "Khởi động cùng Windows";
            checkBoxStartWithWindow.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(linkLabel2);
            tabPage2.Controls.Add(linkLabel1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(472, 205);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thông tin";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(240, 50);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(219, 15);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://github.com/ntktechvn/EyesCare";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(240, 20);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(103, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://ntktech.vn";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 50);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(213, 15);
            label5.TabIndex = 5;
            label5.Text = "Mã nguồn mở, phát hành/cập nhật tại:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(387, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 15);
            label1.TabIndex = 2;
            label1.Text = "Một sản phẩm miễn phí của NTKTech";
            // 
            // buttonPause1H
            // 
            buttonPause1H.Location = new Point(360, 170);
            buttonPause1H.Margin = new Padding(2);
            buttonPause1H.Name = "buttonPause1H";
            buttonPause1H.Size = new Size(103, 27);
            buttonPause1H.TabIndex = 21;
            buttonPause1H.Text = "Tạm dừng 1 giờ";
            buttonPause1H.UseVisualStyleBackColor = true;
            buttonPause1H.Click += buttonPause1H_Click;
            // 
            // tạmDừng1GiờToolStripMenuItem
            // 
            tạmDừng1GiờToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pauseToolStripMenuItem1H, pauseToolStripMenuItem2H });
            tạmDừng1GiờToolStripMenuItem.Name = "tạmDừng1GiờToolStripMenuItem";
            tạmDừng1GiờToolStripMenuItem.Size = new Size(180, 22);
            tạmDừng1GiờToolStripMenuItem.Text = "Tạm dừng";
            // 
            // pauseToolStripMenuItem1H
            // 
            pauseToolStripMenuItem1H.Name = "pauseToolStripMenuItem1H";
            pauseToolStripMenuItem1H.Size = new Size(180, 22);
            pauseToolStripMenuItem1H.Text = "1 giờ";
            pauseToolStripMenuItem1H.Click += pauseToolStripMenuItem1H_Click;
            // 
            // pauseToolStripMenuItem2H
            // 
            pauseToolStripMenuItem2H.Name = "pauseToolStripMenuItem2H";
            pauseToolStripMenuItem2H.Size = new Size(180, 22);
            pauseToolStripMenuItem2H.Text = "2 giờ";
            pauseToolStripMenuItem2H.Click += pauseToolStripMenuItem2H_Click;
            // 
            // FormConfig
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(495, 268);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhắc bạn";
            FormClosing += FormConfig_FormClosing;
            contextMenuTaskbar.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIconTaskbar;
        private ContextMenuStrip contextMenuTaskbar;
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ComboBox comboBoxLongBreakTime;
        private Label label2;
        private ComboBox comboBoxLongBreakRestTime;
        private ComboBox comboBoxShortBreakRestTime;
        private Label label3;
        private ComboBox comboBoxShortBreakTime;
        private Button buttonTestShortBreak;
        private Button buttonTestLongBreak;
        private Button buttonSaveConfig;
        private CheckBox checkBoxPreventClose;
        private CheckBox checkBoxLongBreak;
        private CheckBox checkBoxShortBreak;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelShortBreakTimer;
        private ToolStripStatusLabel toolStripStatusLabelLongtBreakTimer;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private LinkLabel linkLabel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private CheckBox checkBoxStartWithWindow;
        private LinkLabel linkLabel2;
        private CheckBox checkBoxCheckIDLE;
        private ToolStripStatusLabel toolStripStatusLabelPause;
        private Button buttonPause1H;
        private ToolStripMenuItem tạmDừng1GiờToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem1H;
        private ToolStripMenuItem pauseToolStripMenuItem2H;
    }
}
