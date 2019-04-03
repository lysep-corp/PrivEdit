using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivEdit
{
    public partial class ThemeSettings : MetroFramework.Forms.MetroForm
    {
        public ThemeSettings()
        {
            InitializeComponent();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            this.Style = ucfg.Default.scheme;
            this.opacLabel.Style = ucfg.Default.scheme;
            this.themeLabel.Style = ucfg.Default.scheme;
            this.infoLabel.Style = ucfg.Default.scheme;
            this.colorLabel.Style = ucfg.Default.scheme;
            this.themeCombo.Style = ucfg.Default.scheme;
            this.opacTrack.Style = ucfg.Default.scheme;
            this.colorCombo.Style = ucfg.Default.scheme;
            opacTrack.Value = Convert.ToInt32(ucfg.Default.opac / 0.01);
            themeCombo.Text = ucfg.Default.theme;
            colorCombo.Text = Convert.ToString(this.Style);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Black);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Blue);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Brown);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Default);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Green);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Lime);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Magenta);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Orange);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Pink);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Purple);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Red);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Silver);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Teal);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.White);
            colorCombo.Items.Add(MetroFramework.MetroColorStyle.Yellow);
            this.Opacity = ucfg.Default.opac;
            if (ucfg.Default.theme == "Light")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Default;
                themeCombo.Theme = MetroFramework.MetroThemeStyle.Default;
                opacLabel.Theme = MetroFramework.MetroThemeStyle.Default;
                themeLabel.Theme = MetroFramework.MetroThemeStyle.Default;
                infoLabel.Theme = MetroFramework.MetroThemeStyle.Default;
                opacTrack.Theme = MetroFramework.MetroThemeStyle.Default;
                colorCombo.Theme = MetroFramework.MetroThemeStyle.Default;
                colorLabel.Theme = MetroFramework.MetroThemeStyle.Default;
            }
            else
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                themeCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
                opacLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                themeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                infoLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                opacTrack.Theme = MetroFramework.MetroThemeStyle.Dark;
                colorCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
                colorLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }
        private void metroTrackBar1_Scroll(object sender, EventArgs e)
        {
            PrivEditForm Temp = new PrivEditForm();
            Temp.Opacity = opacTrack.Value * 0.01;
            ucfg.Default.opac = opacTrack.Value * 0.01;
            ucfg.Default.Save();
            Temp.Update();
        }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucfg.Default.theme = themeCombo.Text;
            ucfg.Default.Save();
            this.Update();
            this.Refresh();
        }
        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                         if (colorCombo.SelectedIndex == 0)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Black;
            }            if (colorCombo.SelectedIndex == 1)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Blue;
            }            if (colorCombo.SelectedIndex == 2)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Brown;
            }            if (colorCombo.SelectedIndex == 3)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Default;
            }            if (colorCombo.SelectedIndex == 4)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Green;
            }            if (colorCombo.SelectedIndex == 5)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Lime;
            }            if (colorCombo.SelectedIndex == 6)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Magenta;
            }            if (colorCombo.SelectedIndex == 7)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Orange;
            }            if (colorCombo.SelectedIndex == 8)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Pink;
            }            if (colorCombo.SelectedIndex == 9)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Purple;
            }            if (colorCombo.SelectedIndex == 10)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Red;
            }            if (colorCombo.SelectedIndex == 11)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Silver;
            }            if (colorCombo.SelectedIndex == 12)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Teal;
            }            if (colorCombo.SelectedIndex == 13)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.White;
            }            if (colorCombo.SelectedIndex == 14)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Yellow;
            }
            ucfg.Default.Save();
        }
    }
}
