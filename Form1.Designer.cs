namespace WinFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(352, 80);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 1;
            label1.Text = "김근우";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(430, 334);
            button1.Name = "button1";
            button1.Size = new Size(205, 55);
            button1.TabIndex = 2;
            button1.Text = "배경색 바꾸기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("한컴 울주 천전리 각석체", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(352, 149);
            label2.Name = "label2";
            label2.Size = new Size(195, 22);
            label2.TabIndex = 3;
            label2.Text = "수원대 컴퓨터SW학과";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("바탕체", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(353, 264);
            label3.Margin = new Padding(4, 2, 4, 1);
            label3.Name = "label3";
            label3.Padding = new Padding(3, 0, 0, 0);
            label3.Size = new Size(225, 32);
            label3.TabIndex = 4;
            label3.Text = "010-1234-5678";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("바탕", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            label4.Location = new Point(353, 201);
            label4.Name = "label4";
            label4.Size = new Size(191, 16);
            label4.TabIndex = 5;
            label4.Text = "kkw4987@naver.com";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
