using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CaptchaGen
{
    public partial class Form1 : Form
    {
        // Text CAPTCHA
        private string currentTextCaptcha;

        // Math CAPTCHA
        private int currentMathCaptchaResult;

        // Image CAPTCHA
        private List<string> imageCategories = new List<string> { "car", "tree", "house", "dog", "cat", "bicycle" };
        private string currentImageChallenge = "";
        private List<PictureBox> imageBoxes = new List<PictureBox>();
        private List<string> correctImages = new List<string>();
        private List<string> selectedImages = new List<string>();

        public Form1()
        {
            InitializeComponent();
            GenerateTextCaptcha();
            currentMathCaptchaResult = 0;
        }

        #region Text CAPTCHA
        private void GenerateTextCaptcha()
        {
            var random = new Random();
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz23456789";
            currentTextCaptcha = new string(Enumerable.Repeat(chars, random.Next(5, 8))
                .Select(s => s[random.Next(s.Length)]).ToArray());

            var bmp = new Bitmap(picTextCaptcha.Width, picTextCaptcha.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                for (int i = 0; i < 50; i++)
                {
                    int x = random.Next(bmp.Width);
                    int y = random.Next(bmp.Height);
                    bmp.SetPixel(x, y, Color.FromArgb(random.Next()));
                }

                var font = new Font("Arial", 18, FontStyle.Bold);
                var brush = new SolidBrush(Color.Black);

                for (int i = 0; i < currentTextCaptcha.Length; i++)
                {
                    float x = 10 + (i * 20);
                    float y = 10 + (float)(random.NextDouble() * 10 - 5);
                    g.DrawString(currentTextCaptcha[i].ToString(), font, brush, x, y);
                }

                for (int i = 0; i < 3; i++)
                {
                    g.DrawLine(Pens.Gray,
                        random.Next(bmp.Width), random.Next(bmp.Height),
                        random.Next(bmp.Width), random.Next(bmp.Height));
                }
            }

            picTextCaptcha.Image = bmp;
        }

        private void btnVerifyText_Click(object sender, EventArgs e)
        {
            if (txtTextCaptcha.Text.Equals(currentTextCaptcha, StringComparison.Ordinal))
            {
                MessageBox.Show("Text CAPTCHA verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTextCaptcha.Text = string.Empty;
                GenerateTextCaptcha();
            }
            else
            {
                MessageBox.Show("Text CAPTCHA verification failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshText_Click(object sender, EventArgs e)
        {
            GenerateTextCaptcha();
            txtTextCaptcha.Text = string.Empty;
        }
        #endregion

        #region Math CAPTCHA
        private void GenerateMathCaptcha()
        {
            var random = new Random();
            int num1 = random.Next(1, 10);
            int num2 = random.Next(1, 10);
            currentMathCaptchaResult = num1 + num2;
            lblMathCaptcha.Text = $"{num1} + {num2} = ?";
        }

        private void btnVerifyMath_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMathCaptcha.Text, out int result) && result == currentMathCaptchaResult)
            {
                MessageBox.Show("Math CAPTCHA verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMathCaptcha.Text = string.Empty;
                GenerateMathCaptcha();
            }
            else
            {
                MessageBox.Show("Math CAPTCHA verification failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshMath_Click(object sender, EventArgs e)
        {
            GenerateMathCaptcha();
            txtMathCaptcha.Text = string.Empty;
        }
        #endregion

        #region Image CAPTCHA
        private static readonly Random random = new Random();

        private void GenerateImageCaptcha()
        {
            // Clear the selected images list when generating a new CAPTCHA
            selectedImages.Clear();

            foreach (var box in imageBoxes)
            {
                picImageContainer.Controls.Remove(box);
            }
            imageBoxes.Clear();

            currentImageChallenge = imageCategories[random.Next(imageCategories.Count)];
            lblImageChallenge.Text = $"Select all images with: {currentImageChallenge}";

            correctImages.Clear();
            List<string> imageTags = new List<string>();

            for (int i = 0; i < 3; i++)
                imageTags.Add(currentImageChallenge);
            correctImages.AddRange(imageTags);

            var incorrectCategories = imageCategories
                .Where(cat => cat != currentImageChallenge)
                .ToList();

            for (int i = 0; i < 6; i++)
            {
                string randomIncorrect = incorrectCategories[random.Next(incorrectCategories.Count)];
                imageTags.Add(randomIncorrect);
            }

            imageTags = imageTags.OrderBy(x => random.Next()).ToList();

            int size = 80;
            int margin = 10;
            for (int i = 0; i < 9; i++)
            {
                var box = new PictureBox
                {
                    Width = size,
                    Height = size,
                    Left = margin + (i % 3) * (size + margin),
                    Top = 40 + (i / 3) * (size + margin),
                    BorderStyle = BorderStyle.FixedSingle,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = imageTags[i],
                    Image = GetSampleImage(imageTags[i])
                };

                box.Click += ImageBox_Click;

                picImageContainer.Controls.Add(box);
                imageBoxes.Add(box);
            }
        }

        private Image GetSampleImage(string category)
        {
            try
            {
                string imagePath = Path.Combine(Application.StartupPath, "Images", $"{category}.jpg");
                if (File.Exists(imagePath))
                {
                    return Image.FromFile(imagePath);
                }
            }
            catch { }

            var bmp = new Bitmap(80, 80);
            using (var g = Graphics.FromImage(bmp))
            {
                var colors = new Dictionary<string, Color>
                {
                    {"car", Color.Red},
                    {"tree", Color.Green},
                    {"house", Color.Blue},
                    {"dog", Color.Yellow},
                    {"cat", Color.Orange},
                    {"bicycle", Color.Purple}
                };

                g.Clear(colors.ContainsKey(category) ? colors[category] : Color.Gray);
                g.DrawString(category, new Font("Arial", 8), Brushes.Black, 10, 30);
            }
            return bmp;
        }

        private void ImageBox_Click(object sender, EventArgs e)
        {
            var box = (PictureBox)sender;
            string category = box.Tag.ToString();

            bool isSelected = box.BackColor == Color.LimeGreen;

            if (isSelected)
            {
                selectedImages.Remove(category);
                box.BorderStyle = BorderStyle.FixedSingle;
                box.BackColor = Color.Transparent;
                box.Padding = new Padding(0);
            }
            else
            {
                selectedImages.Add(category);
                box.BorderStyle = BorderStyle.FixedSingle;
                box.BackColor = Color.LimeGreen;
                box.Padding = new Padding(4);
            }
        }

        private void btnVerifyImage_Click(object sender, EventArgs e)
        {
            int requiredCorrectCount = correctImages.Count;

            int selectedCorrectCount = selectedImages.Count(img => img == currentImageChallenge);

            int totalSelectedCount = selectedImages.Count;


            bool success = (selectedCorrectCount == requiredCorrectCount) &&
                           (totalSelectedCount == requiredCorrectCount);

            if (success)
            {
                MessageBox.Show("Image CAPTCHA verification successful!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedImages.Clear();
                GenerateImageCaptcha();
            }
            else
            {
                MessageBox.Show("Image CAPTCHA verification failed. Please try again.",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshImage_Click(object sender, EventArgs e)
        {
            // Clear selections before refreshing
            selectedImages.Clear();
            GenerateImageCaptcha();
        }
        #endregion

        #region reCAPTCHA
        private void btnRecaptchaVerify_Click(object sender, EventArgs e)
        {
            if (chkRecaptcha.Checked)
            {
                MessageBox.Show("reCAPTCHA verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reset checkbox after verification
                chkRecaptcha.Checked = false;
            }
            else
            {
                MessageBox.Show("Please check the reCAPTCHA checkbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Text
                    GenerateTextCaptcha();
                    break;
                case 1: // Math
                    GenerateMathCaptcha();
                    break;
                case 2: // Image
                    selectedImages.Clear();
                    GenerateImageCaptcha();
                    break;
                case 3: // reCAPTCHA
                    chkRecaptcha.Checked = false;
                    break;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}