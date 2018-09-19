using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanAllCSS
{
    public class Resulfs
    {
        public static List<string> resulfs = new List<string>();
        public static List<string> key = new List<string>();
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        //quick Scan file
        private void btn_QuickScan1_Click(object sender, EventArgs e)
        {
            this.Text = "Start!";
            if (txb_QuickScan1.Text == "" || !isCSSFile(txb_QuickScan1.Text))
            {
                return;
            }
            string[] temp = txb_TargerQuick1.Text.Split('@');

            if (temp.Length == 1)
            {
                 Resulfs.resulfs.Add(QuickScanFileCSSSingleTarget(txb_QuickScan1.Text, txb_TargerQuick1.Text));
                string[] keys = txb_QuickScan1.Text.Split('\\');
                Resulfs.key.Add(keys[keys.Length - 1]);
            }
            else
            {
               Resulfs.resulfs.Add(QuickScanFileCSS(txb_QuickScan1.Text, temp));
               string[] keys = txb_QuickScan1.Text.Split('\\');
               Resulfs.key.Add(keys[keys.Length - 1]);
            }
            foreach(UserControl1 item in panel2.Controls)
            {
                item.cb_view.Items.Clear();
                item.cb_view.Items.AddRange(Resulfs.resulfs.ToArray());
            }
            this.Text = "Load done!";
        }

        private void btn_DeepScan1_Click(object sender, EventArgs e)
        {
            this.Text = "Start!";
            if (txb_DeepScan1.Text == "" || !isCSSFile(txb_DeepScan1.Text))
            {
                return;
            }
           
            string[] temp = txb_targerDeep1.Text.Split('@');

            if (temp.Length == 1)
            {
                Resulfs.resulfs.Add(DeepScanSingleTarget(txb_DeepScan1.Text, txb_targerDeep1.Text));
                string[] keys = txb_DeepScan1.Text.Split('\\');
                Resulfs.key.Add(keys[keys.Length - 1]);
            }
            else
            {
                Resulfs.resulfs.Add(DeepScan(txb_DeepScan1.Text, temp));
                string[] keys = txb_DeepScan1.Text.Split('\\');
                Resulfs.key.Add(keys[keys.Length - 1]);
            }
            foreach (UserControl1 item in panel2.Controls)
            {
                item.cb_view.Items.Clear();
                item.cb_view.Items.AddRange(Resulfs.resulfs.ToArray());
            }
            this.Text = "Load done!";
        }
        private void btn_DeepScan2_Click(object sender, EventArgs e)
        {
            this.Text = "Start!";
            string[] fileNames = txb_QuickScan2.Text.Split('@');
            List<string> fs = fileNames.ToList();
            fs.RemoveAt(0);

            string[] temp = txb_targetQuick2.Text.Split('@');

            if (temp.Length == 1)
            {
                foreach (string fname in fs)
                {
                    Resulfs.resulfs.Add(QuickScanFileCSSSingleTarget(fname, txb_targetQuick2.Text));
                    string[] keys = fname.Split('\\');
                    Resulfs.key.Add(keys[keys.Length - 1]);
                }
            }
            else
            {
                foreach (string fname in fs)
                {
                    Resulfs.resulfs.Add(QuickScanFileCSS(fname, temp));
                    string[] keys = fname.Split('\\');
                    Resulfs.key.Add(keys[keys.Length - 1]);
                }
            }
            foreach (UserControl1 item in panel2.Controls)
            {
                item.cb_view.Items.Clear();
                item.cb_view.Items.AddRange(Resulfs.resulfs.ToArray());
            }
            this.Text = "Load done!";
        }

        private void btn_DeepScan3_Click(object sender, EventArgs e)
        {
            this.Text = "Start!";
            string[] fileNames = txb_DeepScan2.Text.Split('@');
            List<string> fs = fileNames.ToList();
            fs.RemoveAt(0);

            string[] temp = txb_targerDeep2.Text.Split('@');

            if (temp.Length == 1)
            {
                foreach (string fname in fs)
                {
                    Resulfs.resulfs.Add(DeepScanSingleTarget(fname, txb_targerDeep2.Text));
                    string[] keys = fname.Split('\\');
                    Resulfs.key.Add(keys[keys.Length - 1]);
                }
            }
            else
            {
                foreach (string fname in fs)
                {
                    Resulfs.resulfs.Add(DeepScan(fname, temp));
                    string[] keys = fname.Split('\\');
                    Resulfs.key.Add(keys[keys.Length - 1]);
                }
            }
            foreach (UserControl1 item in panel2.Controls)
            {
                item.cb_view.Items.Clear();
                item.cb_view.Items.AddRange(Resulfs.resulfs.ToArray());
            }
            this.Text = "Load done!";
        }

        //MEthod
        bool isCSSFile(string tenFile)
        {
            int len = tenFile.Length;
            try
            {
                if (tenFile[len - 1] != 's' || tenFile[len - 2] != 's' || tenFile[len - 3] != 'c' || tenFile[len - 4] != '.')
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #region Quick scan
        string QuickScanFileCSS(string fileName, string[] target)
        {
            string res = "";
            try
            {
                string saveBody = "";
                string saveHeader = "";
                bool isCopyHeader = true; //1 pending copy header -- 0 pending copy body
                bool isSkip = false;
                using (StreamReader rd = new StreamReader(fileName))
                {
                    string line = "";
                    while ((line = rd.ReadLine()) != null)
                    {
                        if (!isSkip)
                        {
                            if (isCopyHeader) //copyheader
                            {
                                if (line.Contains("{"))
                                {
                                    string[] temp = line.Split('{');
                                    saveHeader += temp[0];
                                    if (CheckTarget(saveHeader, target))
                                    {
                                        isCopyHeader = false;
                                        isSkip = false;
                                    }
                                    else
                                    {
                                        saveHeader = "";
                                        isSkip = true;
                                        isCopyHeader = true;
                                    }
                                }
                                else
                                {
                                    saveHeader += line + Environment.NewLine;
                                }
                            }
                            else
                            {
                                if (line.Contains("}"))
                                {
                                    string[] temp = line.Split('}');
                                    saveBody += temp[0];
                                    res += saveHeader + "{" + Environment.NewLine + saveBody + Environment.NewLine + "}" + Environment.NewLine;
                                    saveHeader = "";
                                    saveBody = "";
                                    isCopyHeader = true;
                                    isSkip = false;
                                }
                                else
                                {
                                    saveBody += line + Environment.NewLine;
                                }
                            }
                        }
                        else
                        {
                            if (line.Contains("}"))
                            {
                                isSkip = false;
                            }
                        }
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        string QuickScanFileCSSSingleTarget(string fileName, string target)
        {
            string res = "";
            try
            {
                string saveBody = "";
                string saveHeader = "";
                bool isCopyHeader = true; //1 pending copy header -- 0 pending copy body
                bool isSkip = false;
                using (StreamReader rd = new StreamReader(fileName))
                {
                    string line = "";
                    while ((line = rd.ReadLine()) != null)
                    {
                        if (!isSkip)
                        {
                            if (isCopyHeader) //copyheader
                            {
                                if (line.Contains("{"))
                                {
                                    string[] temp = line.Split('{');
                                    saveHeader += temp[0];
                                    if (saveHeader.Contains(target))
                                    {
                                        isCopyHeader = false;
                                        isSkip = false;
                                    }
                                    else
                                    {
                                        saveHeader = "";
                                        isSkip = true;
                                        isCopyHeader = true;
                                    }
                                }
                                else
                                {
                                    saveHeader += line + Environment.NewLine;
                                }
                            }
                            else
                            {
                                if (line.Contains("}"))
                                {
                                    string[] temp = line.Split('}');
                                    saveBody += temp[0];
                                    res += saveHeader + "{" + Environment.NewLine + saveBody + Environment.NewLine + "}" + Environment.NewLine;
                                    saveHeader = "";
                                    saveBody = "";
                                    isCopyHeader = true;
                                    isSkip = false;
                                }
                                else
                                {
                                    saveBody += line + Environment.NewLine;
                                }
                            }
                        }
                        else
                        {
                            if (line.Contains("}"))
                            {
                                isSkip = false;
                            }
                        }
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #endregion

        #region Deep Scan
        string DeepScanSingleTarget(string fileName, string target)
        {
            string res = "";
            try
            {
                string saveBody = "";
                string saveHeader = "";
                bool isCopyHeader = true; //1 pending copy header -- 0 pending copy body
                bool isSkip = false;
                string s = "";
                using (StreamReader rd = new StreamReader(fileName))
                {
                    string line = "";
                    while ((line = rd.ReadLine()) != null)
                    {
                        s += line + Environment.NewLine;
                    }
                }
                for(int i=0; i < s.Length; i++)
                {
                    if (!isSkip)
                    {
                        if (isCopyHeader) //copyheader
                        {
                            if (s[i] == '{')
                            {
                                if (saveHeader.Contains(target))
                                {
                                    isCopyHeader = false;
                                    isSkip = false;
                                }
                                else
                                {
                                    saveHeader = "";
                                    isSkip = true;
                                    isCopyHeader = true;
                                }
                            }
                            else
                            {
                                saveHeader += s[i];
                            }
                        }
                        else
                        {
                            if (s[i] == '}')
                            {
                                res += saveHeader + "{" + Environment.NewLine + saveBody + Environment.NewLine + "}" + Environment.NewLine;
                                saveHeader = "";
                                saveBody = "";
                                isCopyHeader = true;
                                isSkip = false;
                            }
                            else
                            {
                                saveBody += s[i];
                            }
                        }
                    }
                    else
                    {
                        if (s[i] == '}')
                        {
                            isSkip = false;
                        }
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        string DeepScan(string fileName, string[] target)
        {
            string res = "";
            try
            {
                string saveBody = "";
                string saveHeader = "";
                bool isCopyHeader = true; //1 pending copy header -- 0 pending copy body
                bool isSkip = false;
                string s = "";
                using (StreamReader rd = new StreamReader(fileName))
                {
                    string line = "";
                    while ((line = rd.ReadLine()) != null)
                    {
                        s += line + Environment.NewLine;
                    }
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (!isSkip)
                    {
                        if (isCopyHeader) //copyheader
                        {
                            if (s[i] == '{')
                            {
                                if (CheckTarget(saveHeader, target))
                                {
                                    isCopyHeader = false;
                                    isSkip = false;
                                }
                                else
                                {
                                    saveHeader = "";
                                    isSkip = true;
                                    isCopyHeader = true;
                                }
                            }
                            else
                            {
                                saveHeader += s[i];
                            }
                        }
                        else
                        {
                            if (s[i] == '}')
                            {
                                res += saveHeader + "{" + Environment.NewLine + saveBody + Environment.NewLine + "}" + Environment.NewLine;
                                saveHeader = "";
                                saveBody = "";
                                isCopyHeader = true;
                                isSkip = false;
                            }
                            else
                            {
                                saveBody += s[i];
                            }
                        }
                    }
                    else
                    {
                        if (s[i] == '}')
                        {
                            isSkip = false;
                        }
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #endregion
        bool CheckTarget(string des, string[] target)
        {
            try
            {
                foreach (string item in target)
                {
                    if (des.Contains(item))
                        return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void btn_browser1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.DefaultExt = "css";
            f.Filter = "(Các file excel)|*.css";
            f.AddExtension = true;
            //f.Multiselect = true;
            f.RestoreDirectory = true;
            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                //foreach(string fileName in f.FileNames)
                //{
                //    txb_QuickScan1.Text += fileName +"@";
                //}
                txb_QuickScan1.Text = f.FileName;

            }
        }

        private void btn_Browser2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.DefaultExt = "css";
            f.Filter = "(Các file excel)|*.css";
            f.AddExtension = true;
            //f.Multiselect = true;
            f.RestoreDirectory = true;
            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                txb_DeepScan1.Text = f.FileName;

            }
        }

        private void btn_Browser3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();

            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {

                DirectoryInfo cssFile = new DirectoryInfo(f.SelectedPath);
                txb_QuickScan2.Text = DeepScan(cssFile);
            }
        }
        string DeepScan(DirectoryInfo dr)
        {
            string res = "";
            foreach (var item in dr.GetFiles("*.css"))
            {
                res += "@" + item.FullName;
            }
            foreach (var item in dr.GetDirectories())
            {
                res += DeepScan(item);
            }
            return res;
            //return "@" + DeepScan();
        }

        private void btn_Browser4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();

            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {

                DirectoryInfo cssFile = new DirectoryInfo(f.SelectedPath);
                txb_DeepScan2.Text = DeepScan(cssFile);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Resulfs.resulfs.Clear();
            Resulfs.resulfs.Clear();
        }
        

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            string s = (string)comboBox1.SelectedItem;
            int sl = int.Parse(s);
            if (sl <= 4)
            {
                for (int i = 0; i < sl; i++)
                {
                    UserControl1 us = generateUs(new Point((i * (panel2.Width / sl)), 0), panel2.Width / sl, panel2.Height);
                    panel2.Controls.Add(us);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    UserControl1 us = generateUs(new Point((i * (panel2.Width / 4)), 0), panel2.Width / 4, panel2.Height / 2);
                    panel2.Controls.Add(us);
                }
                for (int i = 0; i < 4; i++)
                {
                    UserControl1 us = generateUs(new Point((i * (panel2.Width / 4)), panel2.Height / 2), panel2.Width / 4, panel2.Height / 2);
                    panel2.Controls.Add(us);
                }
            }
        }
        UserControl1 generateUs(Point x, int width, int height)
        {
            UserControl1 us = new UserControl1();
            us.Location = x;
            us.Width = width;
            us.Height = height;
            us.cb_view.Items.AddRange(Resulfs.key.ToArray());
            us.cb_view.SelectedValueChanged += Cb_view_SelectedValueChanged;
            return us;
        }

        private void Cb_view_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            UserControl1 temp = (UserControl1)cb.Parent;
            string s = (string)cb.SelectedItem;
            int index = Resulfs.key.IndexOf(s);
            temp.txb_view.Text = Resulfs.resulfs[index];
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            if (panel2.Controls.Count <= 4)
            {
                for (int i = 0; i < panel2.Controls.Count; i++)
                {
                    panel2.Controls[i].Location = new Point((i * (panel2.Width / panel2.Controls.Count)), 0);
                    panel2.Controls[i].Width = panel2.Width / panel2.Controls.Count;
                    panel2.Controls[i].Height = panel2.Height;
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    panel2.Controls[i].Location = new Point((i * (panel2.Width / 4)), 0);
                    panel2.Controls[i].Width = panel2.Width / 4;
                    panel2.Controls[i].Height = panel2.Height / 2;
                }
                for (int i = 0; i < 4; i++)
                {
                    panel2.Controls[i].Location = new Point((i * (panel2.Width / 4)), panel2.Height / 2);
                    panel2.Controls[i].Width = panel2.Width / 4;
                    panel2.Controls[i].Height = panel2.Height / 2;
                }
            }
        }
    }
}
