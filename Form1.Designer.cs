namespace SteamBPR
{
    partial class SteamBPR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteamBPR));
            Menu = new Panel();
            panel1 = new Panel();
            SteamBPD = new Label();
            Line = new Panel();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(30, 30, 30);
            Menu.Controls.Add(panel1);
            Menu.Controls.Add(SteamBPD);
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(150, 400);
            Menu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(20, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 95);
            panel1.TabIndex = 1;
            // 
            // SteamBPD
            // 
            SteamBPD.AutoSize = true;
            SteamBPD.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SteamBPD.ForeColor = Color.FromArgb(197, 195, 192);
            SteamBPD.Location = new Point(20, 121);
            SteamBPD.Name = "SteamBPD";
            SteamBPD.Size = new Size(110, 22);
            SteamBPD.TabIndex = 0;
            SteamBPD.Text = "SteamBPR";
            SteamBPD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Line
            // 
            Line.BackColor = Color.Gray;
            Line.Location = new Point(150, 50);
            Line.Name = "Line";
            Line.Size = new Size(2, 300);
            Line.TabIndex = 1;
            // 
            // SteamBPR
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(800, 400);
            Controls.Add(Line);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "SteamBPR";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SteamBPR";
            Load += SteamBPR_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Menu;
        private Panel Line;
        private Label SteamBPD;
        private Panel panel1;
    }
}
