using EyesCare.Properties;
using Timer = System.Windows.Forms.Timer;

namespace EyesCare
{
    public partial class FormBreak : Form
    {
        public string[] LongBreakMessages = [
            "Rời khỏi chỗ ngồi và đi lại một lát",
            "Vươn vai và làm vài động tác thể dục thôi",
            "Ngồi lâu tăng nguy cơ thoát vị đĩa đệm",
            "Ngồi 1 chỗ quá lâu sẽ bị đau cổ vai gáy",
            "Tăng nguy cơ bệnh trĩ khi bạn ngồi quá lâu",
        ];
        public string[] ShortBreakMessages = [
            "Hãy để mắt bạn nghỉ ngơi một lát",
            "Nhắm mắt và thư giãn một chút nào",
            "Nhìn sang trái, nhìn sang phải",
            "Nhìn lên, rồi lại nhìn xuống",
            "Ngưng tập trung vào màn hình máy tính một lúc",
            "Một chút cà phê hoặc chút nước lọc",
        ];
        readonly int screenWidth;
        readonly int screenHeight;
        public FormBreak()
        {
            InitializeComponent();
            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            screenWidth = SystemInformation.VirtualScreen.Width;
            screenHeight = SystemInformation.VirtualScreen.Height;
            this.Size = new Size(screenWidth, screenHeight);
            this.Location = new Point(screenLeft, screenTop);

            countToClose = new Timer();
            countToClose.Tick += EndOfTime;
            countToClose.Interval = 1000;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Timer countToClose;
        public int SecondMax;
        public void ShowNow(string type = "short", int seconds = 1)
        {
            if (!this.Modal)
            {
                var messages = type == "short" ? ShortBreakMessages : LongBreakMessages;
                Random random = new();
                string message = messages[random.Next(0, messages.Length)];
                SetMessage(message);
                SetReturnSecond(seconds);

                buttonClose.Left = screenWidth / 2 - buttonClose.Width / 2;
                buttonClose.Visible = !Settings.Default.PreventClose;

                labelMessage.Top = screenHeight / 2;
                labelCount.Top = labelMessage.Top + 100;
                buttonClose.Top = labelCount.Top + 100;

                SecondMax = seconds;
                countToClose.Start();
                this.ShowDialog();
            }
        }

        void SetMessage(string message = "")
        {
            labelMessage.Text = message;
            labelMessage.Left = screenWidth / 2 - labelMessage.Width / 2;
        }
        void SetReturnSecond(int second = 0)
        {
            labelCount.Text = string.Format("{0}s", second);
            labelCount.Left = screenWidth / 2 - labelCount.Width / 2;
        }

        private void EndOfTime(object? sender, EventArgs? e)
        {
            SecondMax--;
            SetReturnSecond(SecondMax);
            if (SecondMax <= 0)
            {
                countToClose.Stop();
                this.Hide();
            }
        }
    }
}
