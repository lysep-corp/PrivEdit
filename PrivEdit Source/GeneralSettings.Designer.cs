namespace PrivEdit
{
    partial class GeneralSettings
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
            this.infoLabel = new MetroFramework.Controls.MetroLabel();
            this.langLabel = new MetroFramework.Controls.MetroLabel();
            this.langCombo = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(23, 239);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(264, 15);
            this.infoLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.infoLabel.TabIndex = 11;
            this.infoLabel.Text = "**Settings Will Apply After Restarting The Program.";
            this.infoLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.infoLabel.UseCustomForeColor = true;
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Location = new System.Drawing.Point(109, 78);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(69, 19);
            this.langLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.langLabel.TabIndex = 10;
            this.langLabel.Text = "Language:";
            this.langLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // langCombo
            // 
            this.langCombo.FormattingEnabled = true;
            this.langCombo.ItemHeight = 23;
            this.langCombo.Items.AddRange(new object[] {
            "EN"});
            this.langCombo.Location = new System.Drawing.Point(77, 100);
            this.langCombo.MaximumSize = new System.Drawing.Size(144, 0);
            this.langCombo.Name = "langCombo";
            this.langCombo.Size = new System.Drawing.Size(144, 29);
            this.langCombo.Style = MetroFramework.MetroColorStyle.Purple;
            this.langCombo.TabIndex = 9;
            this.langCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.langCombo.UseSelectable = true;
            this.langCombo.SelectedIndexChanged += new System.EventHandler(this.langCombo_SelectedIndexChanged);
            // 
            // GeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 269);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.langCombo);
            this.MaximizeBox = false;
            this.Name = "GeneralSettings";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "General Settings";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.GeneralSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel infoLabel;
        private MetroFramework.Controls.MetroLabel langLabel;
        private MetroFramework.Controls.MetroComboBox langCombo;
    }
}