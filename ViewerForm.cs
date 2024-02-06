using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCapture {
    public partial class ViewerForm: Form {
        public Canvas canvas;
        public ViewerForm() {
            InitializeComponent();
            canvas = new Canvas();
            canvas.Dock = DockStyle.Fill;
            this.DoubleBuffered = true;
            this.Controls.Add(canvas);
            this.Load += ViewerForm_Load1;
        }

        private void ViewerForm_Load1(object? sender, EventArgs e) {
            this.Location = new Point(1920, 0);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }


    }
}
