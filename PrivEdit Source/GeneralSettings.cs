using System;
using System.IO;
using static PrivEdit.Parsers.JSON.parser;
using static PrivEdit.Lib.global;
namespace PrivEdit
{
    public partial class GeneralSettings : MetroFramework.Forms.MetroForm
    {
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
                Theme = MetroFramework.MetroThemeStyle.Light;
                langCombo.Theme = MetroFramework.MetroThemeStyle.Light;
                langLabel.Theme = MetroFramework.MetroThemeStyle.Light;
                infoLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            Style = ucfg.Default.scheme;
            langCombo.Style = ucfg.Default.scheme;
            langLabel.Style = ucfg.Default.scheme;
            infoLabel.Style = ucfg.Default.scheme;
        }
        private void LanguageHandler()
        {
            if(lang_pref != "EN")
            {
                Text = ParseIt(LanguageFile, "settingsGUI", "sFormTXT");
                langLabel.Text = ParseIt(LanguageFile, "settingsGUI", "langLabelTXT");
                infoLabel.Text = ParseIt(LanguageFile, "themeGUI", "infoLabelTXT");
            }
            langCombo.PromptText = lang_pref;
        }
        private void langCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucfg.Default.language = langCombo.Text;
            ucfg.Default.Save();
        }
    }
}
