using System;
using System.Windows.Forms;

namespace PrivEdit
{
    public partial class LoadScreen : Form
    {
        public LoadScreen()
        {
            InitializeComponent();
        }

        private void LoadScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoadScreen_Load(object sender, EventArgs e)
        {

        }
        private void Launch()
        {
            Wait(4000);
            PrivEditForm mainFrm = new PrivEditForm();
            mainFrm.Show();
            Hide();
        }
        public static void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();
        }

        private void LoadScreen_Shown(object sender, EventArgs e)
        {
            Launch();
        }
    }
}
