namespace CaptchaGen
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnVerifyText = new Button();
            btnRefreshText = new Button();
            txtTextCaptcha = new TextBox();
            label1 = new Label();
            picTextCaptcha = new PictureBox();
            tabPage2 = new TabPage();
            btnVerifyMath = new Button();
            btnRefreshMath = new Button();
            txtMathCaptcha = new TextBox();
            lblMathCaptcha = new Label();
            tabPage3 = new TabPage();
            btnVerifyImage = new Button();
            btnRefreshImage = new Button();
            picImageContainer = new Panel();
            lblImageChallenge = new Label();
            tabPage4 = new TabPage();
            btnRecaptchaVerify = new Button();
            label2 = new Label();
            chkRecaptcha = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTextCaptcha).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            picImageContainer.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(645, 555);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnVerifyText);
            tabPage1.Controls.Add(btnRefreshText);
            tabPage1.Controls.Add(txtTextCaptcha);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(picTextCaptcha);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(637, 522);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Text CAPTCHA";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnVerifyText
            // 
            btnVerifyText.Location = new Point(290, 300);
            btnVerifyText.Margin = new Padding(4, 5, 4, 5);
            btnVerifyText.Name = "btnVerifyText";
            btnVerifyText.Size = new Size(100, 35);
            btnVerifyText.TabIndex = 4;
            btnVerifyText.Text = "Verify";
            btnVerifyText.UseVisualStyleBackColor = true;
            btnVerifyText.Click += btnVerifyText_Click;
            // 
            // btnRefreshText
            // 
            btnRefreshText.Location = new Point(182, 300);
            btnRefreshText.Margin = new Padding(4, 5, 4, 5);
            btnRefreshText.Name = "btnRefreshText";
            btnRefreshText.Size = new Size(100, 35);
            btnRefreshText.TabIndex = 3;
            btnRefreshText.Text = "Refresh";
            btnRefreshText.UseVisualStyleBackColor = true;
            btnRefreshText.Click += btnRefreshText_Click;
            // 
            // txtTextCaptcha
            // 
            txtTextCaptcha.Location = new Point(185, 260);
            txtTextCaptcha.Margin = new Padding(4, 5, 4, 5);
            txtTextCaptcha.Name = "txtTextCaptcha";
            txtTextCaptcha.Size = new Size(207, 27);
            txtTextCaptcha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 227);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter the text from the image left:";
            // 
            // picTextCaptcha
            // 
            picTextCaptcha.Anchor = AnchorStyles.None;
            picTextCaptcha.BorderStyle = BorderStyle.FixedSingle;
            picTextCaptcha.Location = new Point(196, 136);
            picTextCaptcha.Margin = new Padding(4, 5, 4, 5);
            picTextCaptcha.Name = "picTextCaptcha";
            picTextCaptcha.Size = new Size(191, 76);
            picTextCaptcha.TabIndex = 0;
            picTextCaptcha.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnVerifyMath);
            tabPage2.Controls.Add(btnRefreshMath);
            tabPage2.Controls.Add(txtMathCaptcha);
            tabPage2.Controls.Add(lblMathCaptcha);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(637, 522);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Math CAPTCHA";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVerifyMath
            // 
            btnVerifyMath.Location = new Point(260, 185);
            btnVerifyMath.Margin = new Padding(4, 5, 4, 5);
            btnVerifyMath.Name = "btnVerifyMath";
            btnVerifyMath.Size = new Size(100, 35);
            btnVerifyMath.TabIndex = 3;
            btnVerifyMath.Text = "Verify";
            btnVerifyMath.UseVisualStyleBackColor = true;
            btnVerifyMath.Click += btnVerifyMath_Click;
            // 
            // btnRefreshMath
            // 
            btnRefreshMath.Location = new Point(152, 185);
            btnRefreshMath.Margin = new Padding(4, 5, 4, 5);
            btnRefreshMath.Name = "btnRefreshMath";
            btnRefreshMath.Size = new Size(100, 35);
            btnRefreshMath.TabIndex = 2;
            btnRefreshMath.Text = "Refresh";
            btnRefreshMath.UseVisualStyleBackColor = true;
            btnRefreshMath.Click += btnRefreshMath_Click;
            // 
            // txtMathCaptcha
            // 
            txtMathCaptcha.Location = new Point(152, 145);
            txtMathCaptcha.Margin = new Padding(4, 5, 4, 5);
            txtMathCaptcha.Name = "txtMathCaptcha";
            txtMathCaptcha.Size = new Size(207, 27);
            txtMathCaptcha.TabIndex = 1;
            // 
            // lblMathCaptcha
            // 
            lblMathCaptcha.AutoSize = true;
            lblMathCaptcha.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMathCaptcha.Location = new Point(147, 92);
            lblMathCaptcha.Margin = new Padding(4, 0, 4, 0);
            lblMathCaptcha.Name = "lblMathCaptcha";
            lblMathCaptcha.Size = new Size(85, 29);
            lblMathCaptcha.TabIndex = 0;
            lblMathCaptcha.Text = "1 + 2 =";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnVerifyImage);
            tabPage3.Controls.Add(btnRefreshImage);
            tabPage3.Controls.Add(picImageContainer);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 5, 4, 5);
            tabPage3.Size = new Size(637, 522);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Image CAPTCHA";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnVerifyImage
            // 
            btnVerifyImage.Location = new Point(260, 446);
            btnVerifyImage.Margin = new Padding(4, 5, 4, 5);
            btnVerifyImage.Name = "btnVerifyImage";
            btnVerifyImage.Size = new Size(100, 35);
            btnVerifyImage.TabIndex = 2;
            btnVerifyImage.Text = "Verify";
            btnVerifyImage.UseVisualStyleBackColor = true;
            btnVerifyImage.Click += btnVerifyImage_Click;
            // 
            // btnRefreshImage
            // 
            btnRefreshImage.Location = new Point(152, 446);
            btnRefreshImage.Margin = new Padding(4, 5, 4, 5);
            btnRefreshImage.Name = "btnRefreshImage";
            btnRefreshImage.Size = new Size(100, 35);
            btnRefreshImage.TabIndex = 1;
            btnRefreshImage.Text = "Refresh";
            btnRefreshImage.UseVisualStyleBackColor = true;
            btnRefreshImage.Click += btnRefreshImage_Click;
            // 
            // picImageContainer
            // 
            picImageContainer.BorderStyle = BorderStyle.FixedSingle;
            picImageContainer.Controls.Add(lblImageChallenge);
            picImageContainer.Location = new Point(8, 9);
            picImageContainer.Margin = new Padding(4, 5, 4, 5);
            picImageContainer.Name = "picImageContainer";
            picImageContainer.Size = new Size(618, 427);
            picImageContainer.TabIndex = 3;
            // 
            // lblImageChallenge
            // 
            lblImageChallenge.AutoSize = true;
            lblImageChallenge.Location = new Point(13, 15);
            lblImageChallenge.Margin = new Padding(4, 0, 4, 0);
            lblImageChallenge.Name = "lblImageChallenge";
            lblImageChallenge.Size = new Size(202, 20);
            lblImageChallenge.TabIndex = 0;
            lblImageChallenge.Text = "Select all images with: object";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnRecaptchaVerify);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(chkRecaptcha);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(4, 5, 4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(4, 5, 4, 5);
            tabPage4.Size = new Size(637, 522);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "reCAPTCHA";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnRecaptchaVerify
            // 
            btnRecaptchaVerify.Location = new Point(260, 185);
            btnRecaptchaVerify.Margin = new Padding(4, 5, 4, 5);
            btnRecaptchaVerify.Name = "btnRecaptchaVerify";
            btnRecaptchaVerify.Size = new Size(100, 35);
            btnRecaptchaVerify.TabIndex = 2;
            btnRecaptchaVerify.Text = "Verify";
            btnRecaptchaVerify.UseVisualStyleBackColor = true;
            btnRecaptchaVerify.Click += btnRecaptchaVerify_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(332, 20);
            label2.TabIndex = 1;
            label2.Text = "Please check the box to prove you're not a robot:";
            // 
            // chkRecaptcha
            // 
            chkRecaptcha.Appearance = Appearance.Button;
            chkRecaptcha.AutoSize = true;
            chkRecaptcha.Location = new Point(151, 117);
            chkRecaptcha.Margin = new Padding(4, 5, 4, 5);
            chkRecaptcha.Name = "chkRecaptcha";
            chkRecaptcha.Size = new Size(303, 30);
            chkRecaptcha.TabIndex = 0;
            chkRecaptcha.Text = "☐  I'm not a robot (reCAPTCHA simulation)";
            chkRecaptcha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 555);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "CAPTCHA Generator";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTextCaptcha).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            picImageContainer.ResumeLayout(false);
            picImageContainer.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox picTextCaptcha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTextCaptcha;
        private System.Windows.Forms.Button btnRefreshText;
        private System.Windows.Forms.Button btnVerifyText;
        private System.Windows.Forms.Label lblMathCaptcha;
        private System.Windows.Forms.TextBox txtMathCaptcha;
        private System.Windows.Forms.Button btnRefreshMath;
        private System.Windows.Forms.Button btnVerifyMath;
        private System.Windows.Forms.Panel picImageContainer;
        private System.Windows.Forms.Button btnRefreshImage;
        private System.Windows.Forms.Button btnVerifyImage;
        private System.Windows.Forms.CheckBox chkRecaptcha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecaptchaVerify;
        private System.Windows.Forms.Label lblImageChallenge;
    }
}