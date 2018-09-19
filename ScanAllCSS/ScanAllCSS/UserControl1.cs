using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
