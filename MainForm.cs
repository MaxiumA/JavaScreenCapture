
using System.Diagnostics;


namespace ScreenCapture {
    public partial class MainForm: Form {

        ViewerForm viewer;

        List<Process> visibleProcesses = new List<Process>();

        public MainForm() {
            InitializeComponent();
            this.Load += MainForm_Load;
        }
        void ResetButtons() {
            bCaptureSwitch.Text = "Capture\nDisabled";
            bCaptureSwitch.BackColor = Color.LightSlateGray;
            bCaptureSwitch.Enabled = false;
        }


        void UpdateProcessList() {
            
            lbProcesses.Items.Clear();
            visibleProcesses.Clear();
            Process[] localByName = Process.GetProcessesByName("chrome");
            foreach (Process p in localByName) {
                
                if (p.MainWindowTitle.Contains("Google Chrome")) {
                    visibleProcesses.Add(p);
                    lbProcesses.Items.Add(p.MainWindowTitle);
                }
            }
        }

        private void MainForm_Load(object? sender, EventArgs e) {
            ResetButtons();

            foreach (Screen screen in Screen.AllScreens) {
                cbSourceScreen.Items.Add(screen.DeviceName);
                cbTargetScreen.Items.Add(screen.DeviceName);

                if (screen.Primary) {
                    cbSourceScreen.SelectedIndex = cbSourceScreen.Items.IndexOf(screen.DeviceName);

                }
            }

            if (Screen.AllScreens.Length > 1) {
                foreach (Screen screen in Screen.AllScreens) {
                    if (!screen.Primary) {
                        cbTargetScreen.SelectedIndex = cbTargetScreen.Items.IndexOf(screen.DeviceName);
                        break;
                    }
                }
            }

        }

        void HideViewer() {
            viewer.Close();
            viewer = null;
            ResetButtons();
        }

        void ShowViewer() {
            viewer = new ViewerForm();
            viewer.FormClosed += delegate (object? sender, FormClosedEventArgs e) {
                viewer = null;
                ResetButtons();
            };
            viewer.Show();
            bCaptureSwitch.BackColor = Color.Red;
            bCaptureSwitch.Enabled = true;
        }


        //--------------------------------



        private void bShowViewer_Click(object sender, EventArgs e) {
            if (viewer == null) {
                ShowViewer();
            }
            else {
                HideViewer();
            }
        }


        private void bCaptureSwitch_Click(object sender, EventArgs e) {

            if (viewer != null) {

                viewer.canvas.CaptureEnabled = !viewer.canvas.CaptureEnabled;
                bCaptureSwitch.BackColor = (viewer.canvas.CaptureEnabled) ? Color.Green : Color.Red;
                bCaptureSwitch.Text = (viewer.canvas.CaptureEnabled) ? "Capture\n Enabled" : "Capture\n Disabled";
            }
        }

        private void bUpdateProcesses_Click(object sender, EventArgs e) {
            UpdateProcessList();
        }

        private void lbProcesses_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbProcesses.SelectedIndex >= 0) {

                var bmp = ScreenCapture.CaptureWindow(visibleProcesses[lbProcesses.SelectedIndex].MainWindowHandle);

                pictureBox1.Image = bmp;
            }
        }



    }
}