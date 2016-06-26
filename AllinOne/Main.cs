using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllinOne
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void desktopCleanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesktopCleaner oDesktopCleaner = new DesktopCleaner
            {
                WindowState = FormWindowState.Minimized,
                MdiParent = this
            };
            oDesktopCleaner.Show();
            oDesktopCleaner.WindowState = FormWindowState.Maximized;
        }
    }
}
