using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ExecutePY
{
    public partial class SplashScreenView : Form
    {
        private MainView mainBox;

        public SplashScreenView(MainView mainBox)
        {
            InitializeComponent();
            this.mainBox = mainBox;
        }

        private new void Refresh()
        {
            base.Hide();
            Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(base.Location.X, base.Location.Y, 0, 0, base.Size, CopyPixelOperation.SourceCopy);
            bitmap.Save("spls.bin", ImageFormat.Png);
            this.BackgroundImage = bitmap;
            base.Show();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        //what is this?
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //what is this?
        private void timer2_Tick(object sender, EventArgs e)
        {
            mainBox.Show();
        }
    }
}
