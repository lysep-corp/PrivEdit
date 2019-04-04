using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivEdit
{
    public partial class GeneralSettings : MetroFramework.Forms.MetroForm
    {
        static string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string LanguageFile = path + @"\Languages\" + ucfg.Default.language + ".json";
        public GeneralSettings()
        {
            InitializeComponent();
        }
        private void GeneralSettings_Load(object sender, EventArgs e)
        {
            ThemeHandler();
            LanguageHandler();
            LoadLangList();
        }
        private void LoadLangList()
        {
            DirectoryInfo d = new DirectoryInfo(path + @"\Languages\");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
            foreach (FileInfo file in Files)
            {
                string a = file.Name.Replace(".json", "");
                langCombo.Items.Add(a);
            }
        }
        private void ThemeHandler()
        {
            if(ucfg.Default.theme == "Dark")
            {

            }
            else
            {
                this.Theme = MetroFramework.MetroThemeStyle.Light;
                langCombo.Theme = MetroFramework.MetroThemeStyle.Light;
                langLabel.Theme = MetroFramework.MetroThemeStyle.Light;
                infoLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            this.Style = ucfg.Default.scheme;
            langCombo.Style = ucfg.Default.scheme;
            langLabel.Style = ucfg.Default.scheme;
            infoLabel.Style = ucfg.Default.scheme;
        }
        private void LanguageHandler()
        {
            if(ucfg.Default.language != "EN")
            {
                this.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "settingsGUI", "sFormTXT");
                langLabel.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "settingsGUI", "langLabelTXT");
                infoLabel.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "themeGUI", "infoLabelTXT");
                langCombo.Text = ucfg.Default.language;
            }
            else
            {
                langCombo.Text = ucfg.Default.language;
            }
        }
        private void langCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucfg.Default.language = langCombo.Text;
            ucfg.Default.Save();
        }
    }
}
