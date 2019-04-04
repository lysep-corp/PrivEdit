﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using MetroFramework;
using MetroFramework.Forms;
using PrivEdit.Lib;
using Parsers = PrivEdit.Parsers;
using System.Xml;
namespace PrivEdit
{
    public partial class PrivEditForm : MetroFramework.Forms.MetroForm
    {
        static string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string LanguageFile = path + @"\Languages\" + ucfg.Default.language + ".json";
        #region Main Functions
        public PrivEditForm()
        {
            InitializeComponent();
        }
        private void PrivEditForm_Load(object sender, EventArgs e)
        {
            updateTheme();
            UpdateLanguage();
            editorControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            editorControl.MouseClick += new MouseEventHandler(this.CloseButtonClick);
        }
        public void MainUpdate()
        {
            this.Update();
            this.UpdateBounds();
            this.UpdateDefaultButton();
            this.UpdateStyles();
            this.UpdateZOrder();
        }
        public void UpdateLanguage()
        {
            if (!Directory.Exists(path + @"\Languages"))
            {
                try
                {
                    Directory.CreateDirectory(path + @"\Languages");
                    File.WriteAllBytes(path + @"\Languages\TR.json", Properties.Resources.TR);
                }
                catch (Exception ex)
                {
                    if (ucfg.Default.language != "EN")
                    {
                        MetroFramework.MetroMessageBox.Show(this, Parsers.JSON.parser.ParseIt(LanguageFile, "messages", "permError") + "\n" + ex, "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Error while checking Language file. Check program's permissions...\n" + ex, "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }
            if(ucfg.Default.language == "EN")
            {}
            else if (ucfg.Default.language == "TR")
            {
                fileMenu.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu" ,"fileMenuTXT");
                newButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "newButtonTXT");
                openButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "openButtonTXT");
                saveButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "saveButtonTXT");
                saveAsButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "saveAsButtonTXT");
                arrayMenu.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "arrayMenuTXT");
                clearButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "clearButtonTXT");
                forwardButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "forwardButtonTXT");
                backButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "backButtonTXT");
                findButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "findButtonTXT");
                changeButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "changeButtonTXT");
                settingsMenu.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "settingsMenuTXT");
                gSettingsButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "gSettingsButtonTXT");
                tSettingsButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "tSettingsButtonTXT");
                scsSettingsButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "scsSettingsButtonTXT");
                foSettingsButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "foSettingsButtonTXT");
                fsSettingsButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "fsSettingsButtonTXT");
                aboutMenu.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "aboutMenuTXT");
                authorsButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "authorsButtonTXT");
                youtubeButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "youtubeButtonTXT");
                githubButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "githubButtonTXT");
                sThanksButton.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "upperMenu", "sThanksButtonTXT");
            }

        }
        public void updateTheme()
        {
            MetroColorStyle scheme = ucfg.Default.scheme;
            this.Style = scheme;
            metroPanel1.Style = scheme;
            editorControl.Style = scheme;
            statusLabel.Style = scheme;
            this.Opacity = ucfg.Default.opac;
            if (ucfg.Default.theme == "Light")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Default;
                metroPanel1.Theme = MetroFramework.MetroThemeStyle.Default;
                editorControl.Theme = MetroFramework.MetroThemeStyle.Default;
                statusLabel.Theme = MetroFramework.MetroThemeStyle.Default;
                upperMenu.BackColor = Color.White;
                upperMenu.ForeColor = Color.FromArgb(10, 10, 10);
            }
        }
        private void UpdateHeader()
        {
            try
            {
                foreach (PrivLib.edSci item in editorControl.SelectedTab.Controls)
                {
                    this.Text = "Priv Edit - " + editorControl.SelectedTab.Text;
                }
            }
            catch
            {
                this.Text = "Priv Edit";
            }
            this.UpdateStyles();
        }
        public void New()
        {
            PrivLib.edSci Tab = new PrivLib.edSci();
            Tab.TabID = global.IDCounter;
            Tab.Path = "null";
            Tab.Name = "editor-" + global.IDCounter;
            Tab.Dock = DockStyle.Fill;
            Tab.Text = "";
            Tab.KeyPress += new KeyPressEventHandler(this.scintillaAsciiBlocker);
            Tab.UpdateUI += new EventHandler<ScintillaNET.UpdateUIEventArgs>(this.CursorDetector);
            Tab.TextChanged += new EventHandler(this.LineCounter);
            foreach (var style in Tab.Styles)
            {
                if (ucfg.Default.theme == "Light")
                {}
                else
                {
                    style.BackColor = Color.FromArgb(20, 20, 20);
                    style.ForeColor = Color.FromArgb(254, 254, 254);
                    Tab.CaretForeColor = Color.FromArgb(254, 254, 254);
                }
            }
            if (ucfg.Default.language != "EN")
            {
                editorControl.TabPages.Add(Parsers.JSON.parser.ParseIt(LanguageFile, "texts", "newFile") + " [x]");
            }
            else
            {
                editorControl.TabPages.Add("New File" + " [x]");
            }
            editorControl.SelectTab(editorControl.TabPages.Count-1);
            editorControl.SelectedTab.Controls.Add(Tab);
            global.IDCounter++;
        }
        public void OpenFile(string filename)
        {
            PrivLib.edSci Tab = new PrivLib.edSci();
            Tab.TabID = global.IDCounter;
            Tab.Path = filename;
            Tab.setVisibleLanguage((ScintillaNET.Lexer)PrivLib.getLanguage(PrivLib.splitPath(filename)));
            Tab.UpdateUI += new EventHandler<ScintillaNET.UpdateUIEventArgs>(this.CursorDetector);
            Tab.KeyPress += new KeyPressEventHandler(this.scintillaAsciiBlocker);
            Tab.TextChanged += new EventHandler(this.LineCounter);
            Tab.Name = "editor-" + global.IDCounter;
            Tab.Dock = DockStyle.Fill;
            Tab.Text = File.ReadAllText(filename);
            Tab.EmptyUndoBuffer();
            foreach (var style in Tab.Styles)
            {
                if (ucfg.Default.theme == "Light")
                {}
                else
                {
                    style.BackColor = Color.FromArgb(20, 20, 20);
                    style.ForeColor = Color.FromArgb(254, 254, 254);
                    Tab.CaretForeColor = Color.FromArgb(254, 254, 254);
                }
            }
            editorControl.TabPages.Add(PrivLib.splitPath(filename) + " [x]");
            editorControl.SelectTab(editorControl.TabPages.Count-1);
            editorControl.SelectedTab.Controls.Add(Tab);
            global.IDCounter++;
        }
        private void SaveAs()
        {
            if(editorControl.TabCount > 0)
            {
                var result = FileSaver.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (PrivLib.edSci item in editorControl.SelectedTab.Controls)
                    {
                        File.WriteAllText(FileSaver.FileName, item.Text);
                        item.Path = FileSaver.FileName;
                        editorControl.SelectedTab.Text = PrivLib.splitPath(FileSaver.FileName);
                        UpdateHeader();
                    }
                }
            }
        }
        private void Save()
        {
            if (editorControl.TabCount > 0) { 
                foreach (PrivLib.edSci item in editorControl.SelectedTab.Controls)
                {
                    if (item.Path != "" && item.Path != "null")
                    {
                        File.WriteAllText(item.Path, item.Text);
                        editorControl.SelectedTab.Text = PrivLib.splitPath(item.Path);
                        UpdateHeader();
                    }
                    else
                    {
                        SaveAs();
                    }
                }
            }
        }
        private void Open()
        {
            int size = -1;
            DialogResult dialogResult = FileOpener.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (FileOpener.CheckFileExists)
                {
                    string file = FileOpener.FileName;
                    try
                    {
                        OpenFile(file);
                    }
                    catch (IOException)
                    {
                        if (ucfg.Default.language != "EN")
                        {
                            MessageBox.Show(Parsers.JSON.parser.ParseIt(LanguageFile, "messages", "openFileError"), "ERROR!");
                        }
                        else
                        {
                            MessageBox.Show("An error returned while openin file.", "ERROR!");
                        }

                    }
                }
                else
                {
                    if (ucfg.Default.language != "EN")
                    {
                        MessageBox.Show(Parsers.JSON.parser.ParseIt(LanguageFile, "messages", "fileFindError"), "ERROR!");
                    }
                    else
                    {
                        MessageBox.Show("File not found!", "ERROR!");
                    }
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        //Will be fixed but i don't have time for this may be later...
        //////////////////////////////////////////////////////////////////////////////////////////
        private void PrivEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //////////////////////////////////////////////////////////////////////////////////////////
            //Will be fixed but i don't have time for this may be later...
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            //Will be fixed but i don't have time for this may be later...
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            //Will be fixed but i don't have time for this may be later...
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            //Will be fixed but i don't have time for this may be later...
            //////////////////////////////////////////////////////////////////////////////////////////
            //int n = 0;
            //foreach (MetroFramework.Controls.MetroTabPageCollection item in editorControl.TabPages)
            //{

            //    foreach (MetroFramework.Controls.MetroTabPage.ControlCollection titem in item)
            //    {
            //        foreach (PrivLib.edSci kitem in titem)
            //        {
            //            kitem.checkChanged();
            //            if (kitem.ChangedPoint)
            //            {
            //                editorControl.SelectTab(n);
            //                DialogResult dr = MetroMessageBox.Show(this, "\n\n" + kitem.Filename + " adlı dosyayı kaydetmek istermisiniz ?", "Hayır | Evet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //                if (dr == DialogResult.Yes)
            //                {
            //                    SaveAs();
            //                    tabRec_Add(kitem.Path);
            //                }

            //            }
            //            else
            //            {
            //                if (kitem.Path == "null")
            //                {

            //                }
            //                else
            //                {
            //                    tabRec_Add(kitem.Path);

            //                }

            //            }
            //        }
            //    }
            //    n++;
            //}
            //////////////////////////////////////////////////////////////////////////////////////////
            //Will be fixed but i don't have time for this may be later...
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            //Will be fixed but i don't have time for this may be later...
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            //Will be fixed but i don't have time for this may be later...
            //////////////////////////////////////////////////////////////////////////////////////////
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        //Will be fixed but i don't have time for this may be later...
        //////////////////////////////////////////////////////////////////////////////////////////

        #endregion

        #region Events
        #region Tab Name Handling
        private void editorControl_UpdateForm(object sender, EventArgs e)
        {
            UpdateHeader();
        }
        #endregion

        #region menuStrip
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void FarklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();

        }
        private void kaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void yeniDosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }
        private void temaAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeSettings themeset = new ThemeSettings();
            themeset.Show();
        }
        private void geriALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PrivLib.edSci item in editorControl.SelectedTab.Controls)
            {
                item.Undo();
            }
        }
        private void birAdımİleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PrivLib.edSci item in editorControl.SelectedTab.Controls)
            {
                item.Redo();
            }
        }
        private void düzenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PrivLib.edSci item in editorControl.SelectedTab.Controls)
            {
                item.Text = "";
            }
        }
        private void gSettingsButton_Click(object sender, EventArgs e)
        {
            GeneralSettings gSettings = new GeneralSettings();
            gSettings.Show();
        }
        #endregion

        #region Word Handling
        private void scintillaAsciiBlocker(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 32)
            {
                e.Handled = true;
                return;
            }
        }
        private void CursorDetector(object sender, ScintillaNET.UpdateUIEventArgs e)
        {
            foreach (PrivLib.edSci item in editorControl.SelectedTab.Controls)
            {
                if(ucfg.Default.language != "EN")
                {
                    statusLabel.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "texts", "line")  + " : " + item.CurrentLine.ToString() + Parsers.JSON.parser.ParseIt(LanguageFile, "texts", "character") + ", : " + (item.CurrentPosition - item.Lines[item.LineFromPosition(item.CurrentPosition)].Position) + Parsers.JSON.parser.ParseIt(LanguageFile, "texts", "position") + " : " + item.CurrentPosition.ToString();
                }
                else
                {
                    statusLabel.Text = "Line : " + item.CurrentLine.ToString() + ", Character : " + (item.CurrentPosition - item.Lines[item.LineFromPosition(item.CurrentPosition)].Position) + ", Position : " + item.CurrentPosition.ToString();
                }
            }
        }
        private void LineCounter(object sender, EventArgs e)
        {
            PrivLib.edSci handler = (PrivLib.edSci)sender;
            if(handler.Filename != "null")
            {
                try { 
                    handler.checkChanged();
                    if (handler.ChangedPoint)
                    {
                        editorControl.SelectedTab.Text  = handler.Filename.ToString() + "*" + " [x]";
                    }
                    else
                    {
                        editorControl.SelectedTab.Text = handler.Filename.ToString() + " [x]";
                    }
                }
                catch
                {
                }
            }
            else
            {
                if(ucfg.Default.language != "EN")
                {
                    editorControl.SelectedTab.Text = Parsers.JSON.parser.ParseIt(LanguageFile, "texts", "newFile") + "*" + " [x]";
                }
                else
                {
                    editorControl.SelectedTab.Text = "New File*" + " [x]";
                }
            }
            var maxLineNumberCharLength = handler.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == handler.MaxLineNumberCharLength)
            { 
              return;
            }
            const int padding = 2;
            handler.Margins[0].Width = handler.TextWidth(handler.CurrentLine, new string('9', maxLineNumberCharLength + 1)) + padding;
            handler.MaxLineNumberCharLength = maxLineNumberCharLength;
        }
        #endregion

        #region Draws
        private string[] splitTabs()
        {
            return ucfg.Default.tabList.Split('\n');
        }
        private Point _imageLocation = new Point(13, 5);
        private Point _imgHitArea = new Point(20, 5);
        private void CloseButtonClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.editorControl.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.editorControl.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (editorControl.SelectedIndex >= 0)
            {
                if (r.Contains(p))
                {
                    TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                    tc.TabPages.Remove(TabP);
                }
            }
        }
        public void tabRec_Add(string path)
        {
            ucfg.Default.tabList = ucfg.Default.tabList + path + "\n";
        }
        #endregion

        #endregion


    }
}
