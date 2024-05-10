namespace EyesCare
{
    partial class FormBreak
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
            labelMessage = new Label();
            buttonClose = new Button();
            labelCount = new Label();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = SystemColors.ButtonHighlight;
            labelMessage.Location = new Point(300, 200);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(261, 74);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "Message";
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(330, 340);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(110, 40);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Đóng";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCount.ForeColor = SystemColors.ButtonHighlight;
            labelCount.Location = new Point(350, 270);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(92, 48);
            labelCount.TabIndex = 2;
            labelCount.Text = "120s";
            labelCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormBreak
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(labelCount);
            Controls.Add(buttonClose);
            Controls.Add(labelMessage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBreak";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.Manual;
            Text = "FormBreak";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMessage;
        private Button buttonClose;
        private Label labelCount;
    }
}