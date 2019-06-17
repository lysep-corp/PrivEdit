namespace PrivEdit
{
    partial class LoadScreen
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
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.creditsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPic
            // 
            this.logoPic.Image = global::PrivEdit.Properties.Resources.LS_ORANGE;
            this.logoPic.Location = new System.Drawing.Point(41, 36);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(120, 120);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPic.TabIndex = 0;
            this.logoPic.TabStop = false;
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.creditsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(95)))), ((int)(((byte)(7)))));
            this.creditsLabel.Location = new System.Drawing.Point(6, 180);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(114, 12);
            this.creditsLabel.TabIndex = 1;
            this.creditsLabel.Text = "PrivEdit  -|-   by Lysep CORP.";
            // 
            // LoadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.logoPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadScreen";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadScreen_FormClosed);
            this.Load += new System.EventHandler(this.LoadScreen_Load);
            this.Shown += new System.EventHandler(this.LoadScreen_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Label creditsLabel;
    }
}