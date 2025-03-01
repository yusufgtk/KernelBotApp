namespace KernelBotApp
{
    partial class Form1
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
            richTextBox = new RichTextBox();
            flowLayoutChatPanel = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            richTextBox.Location = new Point(0, 673);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(862, 142);
            richTextBox.TabIndex = 4;
            richTextBox.Text = "";
            // 
            // flowLayoutChatPanel
            // 
            flowLayoutChatPanel.AutoSize = true;
            flowLayoutChatPanel.Dock = DockStyle.Top;
            flowLayoutChatPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutChatPanel.Location = new Point(0, 0);
            flowLayoutChatPanel.Name = "flowLayoutChatPanel";
            flowLayoutChatPanel.Size = new Size(984, 0);
            flowLayoutChatPanel.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Model1;
            pictureBox1.Location = new Point(858, 673);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(899, 734);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 9;
            label1.Text = "Send";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Model4;
            pictureBox2.Location = new Point(858, 673);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 811);
            Controls.Add(label1);
            Controls.Add(flowLayoutChatPanel);
            Controls.Add(richTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kernel AI";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox;
        private FlowLayoutPanel flowLayoutChatPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
