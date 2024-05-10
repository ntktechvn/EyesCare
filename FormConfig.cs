using EyesCare.Properties;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace EyesCare
{
    public partial class FormConfig : Form
    {
        public static string SECOND10 = "10 giây";
        public static string SECOND20 = "20 giây";
        public static string SECOND30 = "30 giây";
        public static string MINUTE1 = "1 phút";
        public static string MINUTE2 = "2 phút";
        public static string MINUTE3 = "3 phút";
        public static string MINUTE4 = "4 phút";
        public static string MINUTE5 = "5 phút";
        public static string MINUTE10 = "10 phút";
        public static string MINUTE15 = "15 phút";
        public static string MINUTE20 = "20 phút";
        public static string MINUTE30 = "30 phút";
        public static string MINUTE40 = "40 phút";
        public static string MINUTE50 = "50 phút";
        public static string MINUTE60 = "60 phút";

        Timer timer;
        FormBreak FormBreak;
        public FormConfig()
        {
            InitializeComponent();
            InitConfig();

            comboBoxLongBreakTime.Items.Add(MINUTE30);
            comboBoxLongBreakTime.Items.Add(MINUTE40);
            comboBoxLongBreakTime.Items.Add(MINUTE50);
            comboBoxLongBreakTime.Items.Add(MINUTE60);
            comboBoxLongBreakTime.SelectedItem = Settings.Default.LongBreakTime;

            comboBoxLongBreakRestTime.Items.Add(MINUTE1);
            comboBoxLongBreakRestTime.Items.Add(MINUTE2);
            comboBoxLongBreakRestTime.Items.Add(MINUTE3);
            comboBoxLongBreakRestTime.Items.Add(MINUTE4);
            comboBoxLongBreakRestTime.Items.Add(MINUTE5);
            comboBoxLongBreakRestTime.SelectedItem = Settings.Default.LongBreakRestTime;

            comboBoxShortBreakTime.Items.Add(MINUTE1);
            comboBoxShortBreakTime.Items.Add(MINUTE2);
            comboBoxShortBreakTime.Items.Add(MINUTE3);
            comboBoxShortBreakTime.Items.Add(MINUTE4);
            comboBoxShortBreakTime.Items.Add(MINUTE5);
            comboBoxShortBreakTime.Items.Add(MINUTE10);
            comboBoxShortBreakTime.SelectedItem = Settings.Default.ShortBreakTime;

            comboBoxShortBreakRestTime.Items.Add(SECOND10);
            comboBoxShortBreakRestTime.Items.Add(SECOND20);
            comboBoxShortBreakRestTime.Items.Add(SECOND30);
            comboBoxShortBreakRestTime.SelectedItem = Settings.Default.ShortBreakRestTime;

            checkBoxLongBreak.Checked = Settings.Default.LongBreak;
            checkBoxShortBreak.Checked = Settings.Default.ShortBreak;
            checkBoxPreventClose.Checked = Settings.Default.PreventClose;

            checkBoxStartWithWindow.Checked = Settings.Default.StartWithWin;

            FormBreak = new FormBreak();

            timer = new Timer();
            timer.Tick += new EventHandler(Timer_tick);
            timer.Interval = 1000;
            timer.Start();
        }

        int countLong = 0;
        int countShort = 0;
        private void Timer_tick(object? sender, EventArgs? e)
        {
            if (Settings.Default.LongBreak)
            {
                countLong++;
                var secs = ConvertToSecond(Settings.Default.LongBreakTime) - countLong;
                TimeSpan t = TimeSpan.FromSeconds(secs);
                toolStripStatusLabelLongtBreakTimer.Text = string.Format("Nghỉ dài sau {0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
                if (countLong >= ConvertToSecond(Settings.Default.LongBreakTime))
                {
                    countLong = 0;
                    countShort = -ConvertToSecond(Settings.Default.LongBreakRestTime);
                    FormBreak.ShowNow("long", ConvertToSecond(Settings.Default.LongBreakRestTime));
                }
            }
            if (Settings.Default.ShortBreak)
            {
                countShort++;
                var secs = ConvertToSecond(Settings.Default.ShortBreakTime) - countShort;
                TimeSpan t = TimeSpan.FromSeconds(secs);
                toolStripStatusLabelShortBreakTimer.Text = string.Format("Nghỉ ngắn sau {0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
                if (countShort >= ConvertToSecond(Settings.Default.ShortBreakTime))
                {
                    countShort = 0;
                    FormBreak.ShowNow("short", ConvertToSecond(Settings.Default.ShortBreakRestTime));
                }
            }
        }
        void InitConfig()
        {
            if (Settings.Default.LongBreakTime.Length == 0)
            {
                Settings.Default.LongBreakTime = MINUTE30;
                Settings.Default.LongBreakRestTime = MINUTE1;
                Settings.Default.ShortBreakTime = MINUTE1;
                Settings.Default.ShortBreakRestTime = SECOND10;
                Settings.Default.Save();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void notifyIconTaskbar_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        [DllImport("user32.dll")]
        static extern int GetDpiForWindow(IntPtr hWnd);
        private void buttonTestLongbreak_Click(object sender, EventArgs e)
        {
            FormBreak.ShowNow("long", ConvertToSecond(Settings.Default.LongBreakRestTime));
        }

        private void buttonTestShortBreak_Click(object sender, EventArgs e)
        {
            FormBreak.ShowNow("short", ConvertToSecond(Settings.Default.ShortBreakRestTime));
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            Settings.Default.LongBreak = checkBoxLongBreak.Checked;
            Settings.Default.LongBreakTime = comboBoxLongBreakTime.Text;
            Settings.Default.LongBreakRestTime = comboBoxLongBreakRestTime.Text;
            Settings.Default.ShortBreak = checkBoxShortBreak.Checked;
            Settings.Default.ShortBreakTime = comboBoxShortBreakTime.Text;
            Settings.Default.ShortBreakRestTime = comboBoxShortBreakRestTime.Text;
            Settings.Default.PreventClose = checkBoxPreventClose.Checked;
            Settings.Default.StartWithWin = checkBoxStartWithWindow.Checked;
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (Settings.Default.StartWithWin)
                    registryKey.SetValue("ApplicationName", Application.ExecutablePath);
                else
                    registryKey.DeleteValue("ApplicationName");
            }
            catch { }

            Settings.Default.Save();
            countLong = countShort = 0;
            MessageBox.Show("Đã lưu cấu hình", "Thông báo");
        }

        static int ConvertToSecond(string input)
        {
            if (input == SECOND10)
            {
                return 10;
            }
            else if (input == SECOND20)
            {
                return 20;
            }
            else if (input == SECOND30)
            {
                return 30;
            }
            else if (input == MINUTE1)
            {
                return 60;
            }
            else if (input == MINUTE2)
            {
                return 2 * 60;
            }
            else if (input == MINUTE3)
            {
                return 3 * 60;
            }
            else if (input == MINUTE4)
            {
                return 4 * 60;
            }
            else if (input == MINUTE5)
            {
                return 5 * 60;
            }
            else if (input == MINUTE10)
            {
                return 10 * 60;
            }
            else if (input == MINUTE15)
            {
                return 15 * 60;
            }
            else if (input == MINUTE20)
            {
                return 20 * 60;
            }
            else if (input == MINUTE30)
            {
                return 30 * 60;
            }
            else if (input == MINUTE40)
            {
                return 40 * 60;
            }
            else if (input == MINUTE50)
            {
                return 50 * 60;
            }
            else if (input == MINUTE60)
            {
                return 60 * 60;
            }
            else
                return 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link != null && e.Link.LinkData != null)
            {
                _ = System.Diagnostics.Process.Start((string)e.Link.LinkData);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link != null && e.Link.LinkData != null)
            {
                _ = System.Diagnostics.Process.Start((string)e.Link.LinkData);
            }
        }
    }
}
