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
            this.metroLabel1.Style = ucfg.Default.scheme;
            this.metroLabel2.Style = ucfg.Default.scheme;
            this.metroLabel3.Style = ucfg.Default.scheme;
            this.metroLabel4.Style = ucfg.Default.scheme;
            this.themeCombo.Style = ucfg.Default.scheme;
            this.metroTrackBar1.Style = ucfg.Default.scheme;
            this.metroComboBox2.Style = ucfg.Default.scheme;
            metroTrackBar1.Value = Convert.ToInt32(ucfg.Default.opac / 0.01);
            themeCombo.Text = ucfg.Default.theme;
            metroComboBox2.Text = Convert.ToString(this.Style);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Black);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Blue);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Brown);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Default);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Green);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Lime);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Magenta);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Orange);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Pink);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Purple);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Red);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Silver);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Teal);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.White);
            metroComboBox2.Items.Add(MetroFramework.MetroColorStyle.Yellow);
            this.Opacity = ucfg.Default.opac;
            if (ucfg.Default.theme == "Beyaz")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Default;
                themeCombo.Theme = MetroFramework.MetroThemeStyle.Default;
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Default;
                metroLabel2.Theme = MetroFramework.MetroThemeStyle.Default;
                metroLabel3.Theme = MetroFramework.MetroThemeStyle.Default;
                metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Default;


            }
            else
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                themeCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }

        private void metroTrackBar1_Scroll(object sender, EventArgs e)
        {
            PrivEditForm Temp = new PrivEditForm();
            Temp.Opacity = metroTrackBar1.Value * 0.01;
            ucfg.Default.opac = metroTrackBar1.Value * 0.01;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (themeCombo.Text == "Beyaz")
            {
                PrivEditForm Temp = new PrivEditForm();
                Temp.Theme = MetroFramework.MetroThemeStyle.Default;
                Temp.Guncelle();
            }
            else
            {
                PrivEditForm Temp = new PrivEditForm();
                Temp.Theme = MetroFramework.MetroThemeStyle.Dark;
                Temp.Guncelle();
            }

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                         if (metroComboBox2.SelectedIndex == 0)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Black;
            }            if (metroComboBox2.SelectedIndex == 1)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Blue;
            }            if (metroComboBox2.SelectedIndex == 2)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Brown;
            }            if (metroComboBox2.SelectedIndex == 3)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Default;
            }            if (metroComboBox2.SelectedIndex == 4)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Green;
            }            if (metroComboBox2.SelectedIndex == 5)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Lime;
            }            if (metroComboBox2.SelectedIndex == 6)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Magenta;
            }            if (metroComboBox2.SelectedIndex == 7)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Orange;
            }            if (metroComboBox2.SelectedIndex == 8)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Pink;
            }            if (metroComboBox2.SelectedIndex == 9)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Purple;
            }            if (metroComboBox2.SelectedIndex == 10)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Red;
            }            if (metroComboBox2.SelectedIndex == 11)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Silver;
            }            if (metroComboBox2.SelectedIndex == 12)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Teal;
            }            if (metroComboBox2.SelectedIndex == 13)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.White;
            }            if (metroComboBox2.SelectedIndex == 14)
            {
                ucfg.Default.scheme = MetroFramework.MetroColorStyle.Yellow;
            }
            ucfg.Default.Save();
        }
    }
}
