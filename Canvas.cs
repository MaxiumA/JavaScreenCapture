using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Imaging;
using System.Drawing;
using System.Diagnostics;

namespace ScreenCapture {
    public class Canvas: Control {

        System.Windows.Forms.Timer timer;
        Rectangle captureRectangle;

        public bool CaptureEnabled { get; set; } = false;
        public Image CompanyLogo { get; set; } = null;


        public Canvas() {

            this.DoubleBuffered = true;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1;


            timer.Tick += Timer_Tick;
            this.Paint += Canvas_Paint;

            this.ParentChanged += Canvas_ParentChanged;

            var sz = Screen.AllScreens[0].Bounds.Size;
             captureRectangle = Screen.AllScreens[0].Bounds;


            CompanyLogo = Image.FromFile("D:\\logo.png");
        }

        private void Canvas_ParentChanged(object? sender, EventArgs e) {
            if (Parent != null)
                timer.Start();

            
        }

        private void Canvas_Paint(object? sender, PaintEventArgs e) {
            DrawFrame(e.Graphics);
        }

        private void Timer_Tick(object? sender, EventArgs e) {
            this.Invalidate();

        }


        private Bitmap CaptureScreen(int display = 0) {
            try {
                var screenSize = Screen.AllScreens[display].Bounds.Size;
                Bitmap captureBitmap = new Bitmap(screenSize.Width, screenSize.Height, PixelFormat.Format32bppArgb);
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);

                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size, CopyPixelOperation.SourcePaint);


                return captureBitmap;

            }
            catch () {
                return null;
            }
        }







        private void DrawFrame(Graphics g) {
            //// Determine the size of the "virtual screen", which includes all monitors.
            //int screenLeft = SystemInformation.VirtualScreen.Left;
            //int screenTop = SystemInformation.VirtualScreen.Top;
            //int screenWidth = SystemInformation.VirtualScreen.Width;
            //int screenHeight = SystemInformation.VirtualScreen.Height;



            g.Clear(Color.Black);

            if (CaptureEnabled) {

                g.DrawImage(CaptureScreen(), new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            }
            else {
                g.DrawImage(CompanyLogo, new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            }

        }
    }
}
