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

namespace AllinOne
{
    public partial class DesktopCleaner : Form
    {
        public DesktopCleaner()
        {
            InitializeComponent();
            txtDesktopLocation.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void btnFetchFiles_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(txtDesktopLocation.Text.Trim()))
            {
                ckblFiles.Items.Clear();
                foreach (var filename in Directory.GetFiles(txtDesktopLocation.Text.Trim()))
                {
                    ckblFiles.Items.Add(filename, false);
                }
                
            }
        
        }

        private void btnTargetLocation_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fbdTargetLocation.ShowDialog())
            {
                txtTargetLocation.Text = fbdTargetLocation.SelectedPath;
            }
        }

        private void btnMoveFiles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to move selected files") == DialogResult.OK)
            {
                foreach (string checkboxitem in ckblFiles.CheckedItems)
                {
                    FileInfo oFileInfo = new FileInfo(checkboxitem);
                    File.Move(checkboxitem,txtTargetLocation.Text + "\\"+ oFileInfo.Name  );
                }
                btnFetchFiles_Click(sender, e);

            }
        }
    }
}
