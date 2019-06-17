namespace PrivEdit
{
    partial class PrivEditForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.editorControl = new MetroFramework.Controls.MetroTabControl();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniDosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birAdımİleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelAyarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.temaAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxRenkUyumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.dosyaAçmaAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKAydetmeAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapımcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emeğiGeçenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpener = new System.Windows.Forms.OpenFileDialog();
            this.FileSaver = new System.Windows.Forms.SaveFileDialog();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.upperMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newButton = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.openButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardButton = new System.Windows.Forms.ToolStripMenuItem();
            this.backButton = new System.Windows.Forms.ToolStripMenuItem();
            this.arraySep1 = new System.Windows.Forms.ToolStripSeparator();
            this.findButton = new System.Windows.Forms.ToolStripMenuItem();
            this.changeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gSettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.setSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.scsSettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.setSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.foSettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.fsSettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.githubButton = new System.Windows.Forms.ToolStripMenuItem();
            this.sThanksButton = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.upperMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.editorControl);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 84);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1003, 472);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // editorControl
            // 
            this.editorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.editorControl.Location = new System.Drawing.Point(0, 0);
            this.editorControl.Margin = new System.Windows.Forms.Padding(3, 500, 3, 3);
            this.editorControl.Name = "editorControl";
            this.editorControl.Size = new System.Drawing.Size(1003, 472);
            this.editorControl.Style = MetroFramework.MetroColorStyle.Lime;
            this.editorControl.TabIndex = 4;
            this.editorControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.editorControl.UseSelectable = true;
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem1,
            this.kaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.yeniDosyaToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem1
            // 
            this.kaydetToolStripMenuItem1.Name = "kaydetToolStripMenuItem1";
            this.kaydetToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.kaydetToolStripMenuItem1.Text = "Kaydet";
            this.kaydetToolStripMenuItem1.Click += new System.EventHandler(this.kaydetToolStripMenuItem1_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.kaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.FarklıKaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // yeniDosyaToolStripMenuItem
            // 
            this.yeniDosyaToolStripMenuItem.Name = "yeniDosyaToolStripMenuItem";
            this.yeniDosyaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniDosyaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.yeniDosyaToolStripMenuItem.Text = "Yeni Dosya";
            this.yeniDosyaToolStripMenuItem.Click += new System.EventHandler(this.yeniDosyaToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temizleToolStripMenuItem,
            this.birAdımİleriToolStripMenuItem,
            this.geriALToolStripMenuItem,
            this.toolStripSeparator2,
            this.bulToolStripMenuItem,
            this.değiştirToolStripMenuItem,
            this.toolStripSeparator3});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            this.düzenToolStripMenuItem.Click += new System.EventHandler(this.düzenToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // birAdımİleriToolStripMenuItem
            // 
            this.birAdımİleriToolStripMenuItem.Name = "birAdımİleriToolStripMenuItem";
            this.birAdımİleriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.birAdımİleriToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.birAdımİleriToolStripMenuItem.Text = "İleri Al";
            this.birAdımİleriToolStripMenuItem.Click += new System.EventHandler(this.birAdımİleriToolStripMenuItem_Click);
            // 
            // geriALToolStripMenuItem
            // 
            this.geriALToolStripMenuItem.Name = "geriALToolStripMenuItem";
            this.geriALToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriALToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.geriALToolStripMenuItem.Text = "Geri Al";
            this.geriALToolStripMenuItem.Click += new System.EventHandler(this.geriALToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // bulToolStripMenuItem
            // 
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.bulToolStripMenuItem.Text = "Bul";
            // 
            // değiştirToolStripMenuItem
            // 
            this.değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            this.değiştirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.değiştirToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.değiştirToolStripMenuItem.Text = "Değiştir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelAyarlarToolStripMenuItem,
            this.toolStripSeparator5,
            this.temaAyarlarıToolStripMenuItem,
            this.syntaxRenkUyumuToolStripMenuItem,
            this.toolStripSeparator6,
            this.dosyaAçmaAyarlarıToolStripMenuItem,
            this.dosyaKAydetmeAyarlarıToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // genelAyarlarToolStripMenuItem
            // 
            this.genelAyarlarToolStripMenuItem.Name = "genelAyarlarToolStripMenuItem";
            this.genelAyarlarToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.genelAyarlarToolStripMenuItem.Text = "Genel Ayarlar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(222, 6);
            // 
            // temaAyarlarıToolStripMenuItem
            // 
            this.temaAyarlarıToolStripMenuItem.Name = "temaAyarlarıToolStripMenuItem";
            this.temaAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.temaAyarlarıToolStripMenuItem.Text = "Tema Ayarları";
            this.temaAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.temaAyarlarıToolStripMenuItem_Click);
            // 
            // syntaxRenkUyumuToolStripMenuItem
            // 
            this.syntaxRenkUyumuToolStripMenuItem.Enabled = false;
            this.syntaxRenkUyumuToolStripMenuItem.Name = "syntaxRenkUyumuToolStripMenuItem";
            this.syntaxRenkUyumuToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.syntaxRenkUyumuToolStripMenuItem.Text = "Syntax & Renk Uyumu Ayarları";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(222, 6);
            // 
            // dosyaAçmaAyarlarıToolStripMenuItem
            // 
            this.dosyaAçmaAyarlarıToolStripMenuItem.Name = "dosyaAçmaAyarlarıToolStripMenuItem";
            this.dosyaAçmaAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.dosyaAçmaAyarlarıToolStripMenuItem.Text = "Dosya Açma Ayarları";
            // 
            // dosyaKAydetmeAyarlarıToolStripMenuItem
            // 
            this.dosyaKAydetmeAyarlarıToolStripMenuItem.Name = "dosyaKAydetmeAyarlarıToolStripMenuItem";
            this.dosyaKAydetmeAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.dosyaKAydetmeAyarlarıToolStripMenuItem.Text = "Dosya Kaydetme Ayarları";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yapımcılarToolStripMenuItem,
            this.faceBookToolStripMenuItem,
            this.youTubeToolStripMenuItem,
            this.gitHubToolStripMenuItem,
            this.emeğiGeçenlerToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // yapımcılarToolStripMenuItem
            // 
            this.yapımcılarToolStripMenuItem.Name = "yapımcılarToolStripMenuItem";
            this.yapımcılarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.yapımcılarToolStripMenuItem.Text = "Yapımcılar";
            // 
            // faceBookToolStripMenuItem
            // 
            this.faceBookToolStripMenuItem.Name = "faceBookToolStripMenuItem";
            this.faceBookToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.faceBookToolStripMenuItem.Text = "Facebook";
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // emeğiGeçenlerToolStripMenuItem
            // 
            this.emeğiGeçenlerToolStripMenuItem.Name = "emeğiGeçenlerToolStripMenuItem";
            this.emeğiGeçenlerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.emeğiGeçenlerToolStripMenuItem.Text = "Emeği Geçenler";
            // 
            // FileOpener
            // 
            this.FileOpener.Title = "Dosya Aç";
            // 
            // FileSaver
            // 
            this.FileSaver.Filter = "Metin dosyaları (*.txt)|*.txt";
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.statusLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(20, 556);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1003, 28);
            this.infoPanel.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.statusLabel.Location = new System.Drawing.Point(6, 5);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 0);
            this.statusLabel.Style = MetroFramework.MetroColorStyle.Lime;
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.statusLabel.UseCustomForeColor = true;
            // 
            // upperMenu
            // 
            this.upperMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.upperMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.upperMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.upperMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.arrayMenu,
            this.settingsMenu,
            this.aboutMenu});
            this.upperMenu.Location = new System.Drawing.Point(20, 60);
            this.upperMenu.Name = "upperMenu";
            this.upperMenu.Size = new System.Drawing.Size(1003, 24);
            this.upperMenu.TabIndex = 6;
            this.upperMenu.Text = "Menu";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.fileSep1,
            this.openButton,
            this.saveButton,
            this.saveAsButton});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // newButton
            // 
            this.newButton.Name = "newButton";
            this.newButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newButton.Size = new System.Drawing.Size(186, 22);
            this.newButton.Text = "New";
            this.newButton.Click += new System.EventHandler(this.yeniDosyaToolStripMenuItem_Click);
            // 
            // fileSep1
            // 
            this.fileSep1.Name = "fileSep1";
            this.fileSep1.Size = new System.Drawing.Size(183, 6);
            // 
            // openButton
            // 
            this.openButton.Name = "openButton";
            this.openButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openButton.Size = new System.Drawing.Size(186, 22);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveButton.Size = new System.Drawing.Size(186, 22);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.kaydetToolStripMenuItem1_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsButton.Size = new System.Drawing.Size(186, 22);
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.Click += new System.EventHandler(this.FarklıKaydetToolStripMenuItem_Click);
            // 
            // arrayMenu
            // 
            this.arrayMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearButton,
            this.forwardButton,
            this.backButton,
            this.arraySep1,
            this.findButton,
            this.changeButton});
            this.arrayMenu.Name = "arrayMenu";
            this.arrayMenu.Size = new System.Drawing.Size(47, 20);
            this.arrayMenu.Text = "Array";
            // 
            // clearButton
            // 
            this.clearButton.Name = "clearButton";
            this.clearButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.clearButton.Size = new System.Drawing.Size(176, 22);
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.forwardButton.Size = new System.Drawing.Size(176, 22);
            this.forwardButton.Text = "Go Forward";
            this.forwardButton.Click += new System.EventHandler(this.birAdımİleriToolStripMenuItem_Click);
            // 
            // backButton
            // 
            this.backButton.Name = "backButton";
            this.backButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.backButton.Size = new System.Drawing.Size(176, 22);
            this.backButton.Text = "Go Back";
            this.backButton.Click += new System.EventHandler(this.geriALToolStripMenuItem_Click);
            // 
            // arraySep1
            // 
            this.arraySep1.Name = "arraySep1";
            this.arraySep1.Size = new System.Drawing.Size(173, 6);
            // 
            // findButton
            // 
            this.findButton.Enabled = false;
            this.findButton.Name = "findButton";
            this.findButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findButton.Size = new System.Drawing.Size(176, 22);
            this.findButton.Text = "Find";
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Name = "changeButton";
            this.changeButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.changeButton.Size = new System.Drawing.Size(176, 22);
            this.changeButton.Text = "Change";
            // 
            // settingsMenu
            // 
            this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gSettingsButton,
            this.setSep1,
            this.tSettingsButton,
            this.scsSettingsButton,
            this.setSep2,
            this.foSettingsButton,
            this.fsSettingsButton});
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(61, 20);
            this.settingsMenu.Text = "Settings";
            // 
            // gSettingsButton
            // 
            this.gSettingsButton.Name = "gSettingsButton";
            this.gSettingsButton.Size = new System.Drawing.Size(238, 22);
            this.gSettingsButton.Text = "General Settings";
            this.gSettingsButton.Click += new System.EventHandler(this.gSettingsButton_Click);
            // 
            // setSep1
            // 
            this.setSep1.Name = "setSep1";
            this.setSep1.Size = new System.Drawing.Size(235, 6);
            // 
            // tSettingsButton
            // 
            this.tSettingsButton.Name = "tSettingsButton";
            this.tSettingsButton.Size = new System.Drawing.Size(238, 22);
            this.tSettingsButton.Text = "Theme Settings";
            this.tSettingsButton.Click += new System.EventHandler(this.temaAyarlarıToolStripMenuItem_Click);
            // 
            // scsSettingsButton
            // 
            this.scsSettingsButton.Enabled = false;
            this.scsSettingsButton.Name = "scsSettingsButton";
            this.scsSettingsButton.Size = new System.Drawing.Size(238, 22);
            this.scsSettingsButton.Text = "Syntax - Color Scheme Settings";
            // 
            // setSep2
            // 
            this.setSep2.Name = "setSep2";
            this.setSep2.Size = new System.Drawing.Size(235, 6);
            // 
            // foSettingsButton
            // 
            this.foSettingsButton.Enabled = false;
            this.foSettingsButton.Name = "foSettingsButton";
            this.foSettingsButton.Size = new System.Drawing.Size(238, 22);
            this.foSettingsButton.Text = "File Opening Settings";
            // 
            // fsSettingsButton
            // 
            this.fsSettingsButton.Enabled = false;
            this.fsSettingsButton.Name = "fsSettingsButton";
            this.fsSettingsButton.Size = new System.Drawing.Size(238, 22);
            this.fsSettingsButton.Text = "File Saving Settings";
            // 
            // aboutMenu
            // 
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorsButton,
            this.youtubeButton,
            this.githubButton,
            this.sThanksButton});
            this.aboutMenu.Enabled = false;
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(52, 20);
            this.aboutMenu.Text = "About";
            // 
            // authorsButton
            // 
            this.authorsButton.Enabled = false;
            this.authorsButton.Name = "authorsButton";
            this.authorsButton.Size = new System.Drawing.Size(152, 22);
            this.authorsButton.Text = "Authors";
            // 
            // youtubeButton
            // 
            this.youtubeButton.Enabled = false;
            this.youtubeButton.Name = "youtubeButton";
            this.youtubeButton.Size = new System.Drawing.Size(152, 22);
            this.youtubeButton.Text = "YouTube";
            // 
            // githubButton
            // 
            this.githubButton.Enabled = false;
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(152, 22);
            this.githubButton.Text = "GitHub";
            // 
            // sThanksButton
            // 
            this.sThanksButton.Enabled = false;
            this.sThanksButton.Name = "sThanksButton";
            this.sThanksButton.Size = new System.Drawing.Size(152, 22);
            this.sThanksButton.Text = "Special Thanks";
            // 
            // PrivEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 604);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.upperMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "PrivEditForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "PrivEdit";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrivEditForm_FormClosing);
            this.Load += new System.EventHandler(this.PrivEditForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.upperMenu.ResumeLayout(false);
            this.upperMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yeniDosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelAyarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem temaAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syntaxRenkUyumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçmaAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaKAydetmeAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapımcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emeğiGeçenlerToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog FileOpener;
        public System.Windows.Forms.SaveFileDialog FileSaver;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem1;
        private System.Windows.Forms.Panel infoPanel;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem geriALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birAdımİleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.MenuStrip upperMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newButton;
        private System.Windows.Forms.ToolStripSeparator fileSep1;
        private System.Windows.Forms.ToolStripMenuItem openButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsButton;
        private System.Windows.Forms.ToolStripMenuItem arrayMenu;
        private System.Windows.Forms.ToolStripMenuItem clearButton;
        private System.Windows.Forms.ToolStripMenuItem forwardButton;
        private System.Windows.Forms.ToolStripMenuItem backButton;
        private System.Windows.Forms.ToolStripSeparator arraySep1;
        private System.Windows.Forms.ToolStripMenuItem findButton;
        private System.Windows.Forms.ToolStripMenuItem changeButton;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem gSettingsButton;
        private System.Windows.Forms.ToolStripSeparator setSep1;
        private System.Windows.Forms.ToolStripMenuItem tSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem scsSettingsButton;
        private System.Windows.Forms.ToolStripSeparator setSep2;
        private System.Windows.Forms.ToolStripMenuItem foSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem fsSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem authorsButton;
        private System.Windows.Forms.ToolStripMenuItem youtubeButton;
        private System.Windows.Forms.ToolStripMenuItem githubButton;
        private System.Windows.Forms.ToolStripMenuItem sThanksButton;
        public MetroFramework.Controls.MetroTabControl editorControl;
    }
}

