using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Diagnostics;
using System.Drawing;
//커밋테스트
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private Image originalImage;
        private Image altImage;
        private bool isAlt = false;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // 초기 이미지 저장 및 대체 이미지 생성
            originalImage = pictureBox1.Image;
            altImage = CreateAltImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { Random rand = new Random(); 
            this.BackColor = Color.FromArgb(rand.Next(200), rand.Next(200), rand.Next(256)); 
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("https://github.com/ghtfy") { UseShellExecute = true };
            Process.Start(psi);
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("https://instagram.com/") { UseShellExecute = true };
            Process.Start(psi);
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            if (isAlt)
            {
                pictureBox1.Image = originalImage;
                isAlt = false;
            }
            else
            {
                pictureBox1.Image = altImage;
                isAlt = true;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private Image CreateAltImage()
        {
            int w = pictureBox1.Width > 0 ? pictureBox1.Width : 200;
            int h = pictureBox1.Height > 0 ? pictureBox1.Height : 200;
            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightSteelBlue);
                using (Font f = new Font("맑은 고딕", 20))
                using (Brush br = new SolidBrush(Color.DarkBlue))
                {
                    var sz = g.MeasureString("Profile 2", f);
                    g.DrawString("Profile 2", f, br, (w - sz.Width) / 2, (h - sz.Height) / 2);
                }
            }
            return bmp;
        }
}
    
}
