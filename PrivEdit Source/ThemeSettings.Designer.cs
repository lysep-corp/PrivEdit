namespace PrivEdit
{
    partial class ThemeSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.opacTrack = new MetroFramework.Controls.MetroTrackBar();
            this.opacLabel = new MetroFramework.Controls.MetroLabel();
            this.themeCombo = new MetroFramework.Controls.MetroComboBox();
            this.themeLabel = new MetroFramework.Controls.MetroLabel();
            this.infoLabel = new MetroFramework.Controls.MetroLabel();
            this.colorCombo = new MetroFramework.Controls.MetroComboBox();
            this.colorLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // opacTrack
            // 
            this.opacTrack.BackColor = System.Drawing.Color.Transparent;
            this.opacTrack.Location = new System.Drawing.Point(23, 117);
            this.opacTrack.Minimum = 12;
            this.opacTrack.Name = "opacTrack";
            this.opacTrack.Size = new System.Drawing.Size(253, 31);
            this.opacTrack.Style = MetroFramework.MetroColorStyle.Purple;
            this.opacTrack.TabIndex = 0;
            this.opacTrack.Text = "Form Opaklığı";
            this.opacTrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.opacTrack.Value = 100;
            this.opacTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // opacLabel
            // 
            this.opacLabel.AutoSize = true;
            this.opacLabel.Location = new System.Drawing.Point(20, 95);
            this.opacLabel.Name = "opacLabel";
            this.opacLabel.Size = new System.Drawing.Size(114, 19);
            this.opacLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.opacLabel.TabIndex = 1;
            this.opacLabel.Text = "Program Opacity:";
            this.opacLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // themeCombo
            // 
            this.themeCombo.FormattingEnabled = true;
            this.themeCombo.ItemHeight = 23;
            this.themeCombo.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.themeCombo.Location = new System.Drawing.Point(21, 208);
            this.themeCombo.MaximumSize = new System.Drawing.Size(144, 0);
            this.themeCombo.Name = "themeCombo";
            this.themeCombo.Size = new System.Drawing.Size(144, 29);
            this.themeCombo.Style = MetroFramework.MetroColorStyle.Purple;
            this.themeCombo.TabIndex = 2;
            this.themeCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.themeCombo.UseSelectable = true;
            this.themeCombo.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Location = new System.Drawing.Point(19, 186);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(74, 19);
            this.themeLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.themeLabel.TabIndex = 3;
            this.themeLabel.Text = "First Color:";
            this.themeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(4, 429);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(264, 15);
            this.infoLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "**Settings Will Apply After Restarting The Program.";
            this.infoLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.infoLabel.UseCustomForeColor = true;
            // 
            // colorCombo
            // 
            this.colorCombo.FormattingEnabled = true;
            this.colorCombo.ItemHeight = 23;
            this.colorCombo.Location = new System.Drawing.Point(21, 275);
            this.colorCombo.MaximumSize = new System.Drawing.Size(144, 0);
            this.colorCombo.Name = "colorCombo";
            this.colorCombo.Size = new System.Drawing.Size(144, 29);
            this.colorCombo.Style = MetroFramework.MetroColorStyle.Purple;
            this.colorCombo.TabIndex = 5;
            this.colorCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.colorCombo.UseSelectable = true;
            this.colorCombo.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(23, 253);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(112, 19);
            this.colorLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "Secondary Color:";
            this.colorLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ThemeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorCombo);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.themeCombo);
            this.Controls.Add(this.opacLabel);
            this.Controls.Add(this.opacTrack);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 450);
            this.MinimumSize = new System.Drawing.Size(299, 450);
            this.Name = "ThemeSettings";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Theme Settings";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTrackBar opacTrack;
        private MetroFramework.Controls.MetroLabel opacLabel;
        private MetroFramework.Controls.MetroComboBox themeCombo;
        private MetroFramework.Controls.MetroLabel themeLabel;
        private MetroFramework.Controls.MetroLabel infoLabel;
        private MetroFramework.Controls.MetroComboBox colorCombo;
        private MetroFramework.Controls.MetroLabel colorLabel;
    }
}