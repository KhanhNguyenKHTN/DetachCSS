using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ScanAllCSS
{
    public partial class UserControl1 : UserControl
    {
        public List<string> values = new List<string>();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(txb_view.Text);
            f.Show();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txb_view.Text);
        }

        private void exportCssFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.DefaultExt = "css";
            f.Filter = "(Các file excel)|*.css";
            f.AddExtension = true;
            f.RestoreDirectory = true;
            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(f.FileName))
                    {
                        sw.Write(txb_view.Text);
                    }
                }
                catch
                {

                }
            }
        }
    }
}
