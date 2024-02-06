namespace ScreenCapture {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            cbSourceScreen = new ComboBox();
            label1 = new Label();
            cbTargetScreen = new ComboBox();
            label2 = new Label();
            bShowViewer = new Button();
            bCaptureSwitch = new Button();
            lbProcesses = new ListBox();
            bUpdateProcesses = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbSourceScreen
            // 
            cbSourceScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbSourceScreen.FormattingEnabled = true;
            cbSourceScreen.Location = new Point(175, 17);
            cbSourceScreen.Margin = new Padding(4);
            cbSourceScreen.Name = "cbSourceScreen";
            cbSourceScreen.Size = new Size(427, 36);
            cbSourceScreen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 2;
            label1.Text = "Source Screen";
            // 
            // cbTargetScreen
            // 
            cbTargetScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTargetScreen.FormattingEnabled = true;
            cbTargetScreen.Location = new Point(175, 65);
            cbTargetScreen.Margin = new Padding(4);
            cbTargetScreen.Name = "cbTargetScreen";
            cbTargetScreen.Size = new Size(427, 36);
            cbTargetScreen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 2;
            label2.Text = "Target Screen";
            // 
            // bShowViewer
            // 
            bShowViewer.Location = new Point(35, 124);
            bShowViewer.Name = "bShowViewer";
            bShowViewer.Size = new Size(186, 128);
            bShowViewer.TabIndex = 3;
            bShowViewer.Text = "Share Screen";
            bShowViewer.UseVisualStyleBackColor = true;
            bShowViewer.Click += bShowViewer_Click;
            // 
            // bCaptureSwitch
            // 
            bCaptureSwitch.Location = new Point(35, 283);
            bCaptureSwitch.Name = "bCaptureSwitch";
            bCaptureSwitch.Size = new Size(186, 128);
            bCaptureSwitch.TabIndex = 4;
            bCaptureSwitch.Text = "Capture Switch On/Off";
            bCaptureSwitch.UseVisualStyleBackColor = true;
            bCaptureSwitch.Click += bCaptureSwitch_Click;
            // 
            // lbProcesses
            // 
            lbProcesses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbProcesses.FormattingEnabled = true;
            lbProcesses.ItemHeight = 28;
            lbProcesses.Location = new Point(250, 124);
            lbProcesses.Name = "lbProcesses";
            lbProcesses.Size = new Size(352, 284);
            lbProcesses.TabIndex = 5;
            lbProcesses.SelectedIndexChanged += lbProcesses_SelectedIndexChanged;
            // 
            // bUpdateProcesses
            // 
            bUpdateProcesses.Location = new Point(512, 414);
            bUpdateProcesses.Name = "bUpdateProcesses";
            bUpdateProcesses.Size = new Size(94, 50);
            bUpdateProcesses.TabIndex = 6;
            bUpdateProcesses.Text = "UPD";
            bUpdateProcesses.UseVisualStyleBackColor = true;
            bUpdateProcesses.Click += bUpdateProcesses_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(250, 430);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(639, 637);
            Controls.Add(pictureBox1);
            Controls.Add(bUpdateProcesses);
            Controls.Add(lbProcesses);
            Controls.Add(bCaptureSwitch);
            Controls.Add(bShowViewer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbTargetScreen);
            Controls.Add(cbSourceScreen);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(520, 324);
            Name = "MainForm";
            Text = "Screen Capture";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbSourceScreen;
        private Label label1;
        private ComboBox cbTargetScreen;
        private Label label2;
        private Button bShowViewer;
        private Button bCaptureSwitch;
        private ListBox lbProcesses;
        private Button bUpdateProcesses;
        private PictureBox pictureBox1;
    }
}