namespace ScanAllCSS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_Quick1 = new System.Windows.Forms.TabPage();
            this.btn_browser1 = new System.Windows.Forms.Button();
            this.txb_TargerQuick1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_QuickScan1 = new System.Windows.Forms.Button();
            this.txb_QuickScan1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_deepScan1 = new System.Windows.Forms.TabPage();
            this.btn_Browser2 = new System.Windows.Forms.Button();
            this.txb_targerDeep1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_DeepScan1 = new System.Windows.Forms.Button();
            this.txb_DeepScan1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Quick2 = new System.Windows.Forms.TabPage();
            this.btn_Browser3 = new System.Windows.Forms.Button();
            this.txb_targetQuick2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_DeepScan2 = new System.Windows.Forms.Button();
            this.txb_QuickScan2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_deep2 = new System.Windows.Forms.TabPage();
            this.btn_Browser4 = new System.Windows.Forms.Button();
            this.txb_targerDeep2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_DeepScan3 = new System.Windows.Forms.Button();
            this.txb_DeepScan2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tb_Quick1.SuspendLayout();
            this.tb_deepScan1.SuspendLayout();
            this.tb_Quick2.SuspendLayout();
            this.tb_deep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 174);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(7, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Location = new System.Drawing.Point(292, 135);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(85, 36);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tb_Quick1);
            this.tabControl1.Controls.Add(this.tb_deepScan1);
            this.tabControl1.Controls.Add(this.tb_Quick2);
            this.tabControl1.Controls.Add(this.tb_deep2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 130);
            this.tabControl1.TabIndex = 0;
            // 
            // tb_Quick1
            // 
            this.tb_Quick1.Controls.Add(this.btn_browser1);
            this.tb_Quick1.Controls.Add(this.txb_TargerQuick1);
            this.tb_Quick1.Controls.Add(this.label5);
            this.tb_Quick1.Controls.Add(this.btn_QuickScan1);
            this.tb_Quick1.Controls.Add(this.txb_QuickScan1);
            this.tb_Quick1.Controls.Add(this.label1);
            this.tb_Quick1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_Quick1.Location = new System.Drawing.Point(4, 29);
            this.tb_Quick1.Name = "tb_Quick1";
            this.tb_Quick1.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Quick1.Size = new System.Drawing.Size(1005, 97);
            this.tb_Quick1.TabIndex = 0;
            this.tb_Quick1.Text = "Quick Scan";
            this.tb_Quick1.UseVisualStyleBackColor = true;
            // 
            // btn_browser1
            // 
            this.btn_browser1.Location = new System.Drawing.Point(695, 12);
            this.btn_browser1.Name = "btn_browser1";
            this.btn_browser1.Size = new System.Drawing.Size(75, 26);
            this.btn_browser1.TabIndex = 5;
            this.btn_browser1.Text = "Browser";
            this.btn_browser1.UseVisualStyleBackColor = true;
            this.btn_browser1.Click += new System.EventHandler(this.btn_browser1_Click);
            // 
            // txb_TargerQuick1
            // 
            this.txb_TargerQuick1.Location = new System.Drawing.Point(109, 52);
            this.txb_TargerQuick1.Name = "txb_TargerQuick1";
            this.txb_TargerQuick1.Size = new System.Drawing.Size(571, 26);
            this.txb_TargerQuick1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Target:";
            // 
            // btn_QuickScan1
            // 
            this.btn_QuickScan1.Location = new System.Drawing.Point(809, 15);
            this.btn_QuickScan1.Name = "btn_QuickScan1";
            this.btn_QuickScan1.Size = new System.Drawing.Size(190, 63);
            this.btn_QuickScan1.TabIndex = 2;
            this.btn_QuickScan1.Text = "Scan";
            this.btn_QuickScan1.UseVisualStyleBackColor = true;
            this.btn_QuickScan1.Click += new System.EventHandler(this.btn_QuickScan1_Click);
            // 
            // txb_QuickScan1
            // 
            this.txb_QuickScan1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txb_QuickScan1.Location = new System.Drawing.Point(109, 12);
            this.txb_QuickScan1.Name = "txb_QuickScan1";
            this.txb_QuickScan1.Size = new System.Drawing.Size(571, 26);
            this.txb_QuickScan1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of file:";
            // 
            // tb_deepScan1
            // 
            this.tb_deepScan1.Controls.Add(this.btn_Browser2);
            this.tb_deepScan1.Controls.Add(this.txb_targerDeep1);
            this.tb_deepScan1.Controls.Add(this.label6);
            this.tb_deepScan1.Controls.Add(this.btn_DeepScan1);
            this.tb_deepScan1.Controls.Add(this.txb_DeepScan1);
            this.tb_deepScan1.Controls.Add(this.label2);
            this.tb_deepScan1.Location = new System.Drawing.Point(4, 29);
            this.tb_deepScan1.Name = "tb_deepScan1";
            this.tb_deepScan1.Padding = new System.Windows.Forms.Padding(3);
            this.tb_deepScan1.Size = new System.Drawing.Size(1005, 97);
            this.tb_deepScan1.TabIndex = 1;
            this.tb_deepScan1.Text = "Deep Scan";
            this.tb_deepScan1.UseVisualStyleBackColor = true;
            // 
            // btn_Browser2
            // 
            this.btn_Browser2.Location = new System.Drawing.Point(707, 12);
            this.btn_Browser2.Name = "btn_Browser2";
            this.btn_Browser2.Size = new System.Drawing.Size(75, 26);
            this.btn_Browser2.TabIndex = 8;
            this.btn_Browser2.Text = "Browser";
            this.btn_Browser2.UseVisualStyleBackColor = true;
            this.btn_Browser2.Click += new System.EventHandler(this.btn_Browser2_Click);
            // 
            // txb_targerDeep1
            // 
            this.txb_targerDeep1.Location = new System.Drawing.Point(119, 54);
            this.txb_targerDeep1.Name = "txb_targerDeep1";
            this.txb_targerDeep1.Size = new System.Drawing.Size(571, 26);
            this.txb_targerDeep1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Target:";
            // 
            // btn_DeepScan1
            // 
            this.btn_DeepScan1.Location = new System.Drawing.Point(819, 12);
            this.btn_DeepScan1.Name = "btn_DeepScan1";
            this.btn_DeepScan1.Size = new System.Drawing.Size(168, 67);
            this.btn_DeepScan1.TabIndex = 5;
            this.btn_DeepScan1.Text = "Scan";
            this.btn_DeepScan1.UseVisualStyleBackColor = true;
            this.btn_DeepScan1.Click += new System.EventHandler(this.btn_DeepScan1_Click);
            // 
            // txb_DeepScan1
            // 
            this.txb_DeepScan1.Location = new System.Drawing.Point(119, 12);
            this.txb_DeepScan1.Name = "txb_DeepScan1";
            this.txb_DeepScan1.Size = new System.Drawing.Size(571, 26);
            this.txb_DeepScan1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of file:";
            // 
            // tb_Quick2
            // 
            this.tb_Quick2.Controls.Add(this.btn_Browser3);
            this.tb_Quick2.Controls.Add(this.txb_targetQuick2);
            this.tb_Quick2.Controls.Add(this.label7);
            this.tb_Quick2.Controls.Add(this.btn_DeepScan2);
            this.tb_Quick2.Controls.Add(this.txb_QuickScan2);
            this.tb_Quick2.Controls.Add(this.label3);
            this.tb_Quick2.Location = new System.Drawing.Point(4, 29);
            this.tb_Quick2.Name = "tb_Quick2";
            this.tb_Quick2.Size = new System.Drawing.Size(1005, 97);
            this.tb_Quick2.TabIndex = 2;
            this.tb_Quick2.Text = "Quick Folder";
            this.tb_Quick2.UseVisualStyleBackColor = true;
            // 
            // btn_Browser3
            // 
            this.btn_Browser3.Location = new System.Drawing.Point(722, 11);
            this.btn_Browser3.Name = "btn_Browser3";
            this.btn_Browser3.Size = new System.Drawing.Size(75, 26);
            this.btn_Browser3.TabIndex = 8;
            this.btn_Browser3.Text = "Browser";
            this.btn_Browser3.UseVisualStyleBackColor = true;
            this.btn_Browser3.Click += new System.EventHandler(this.btn_Browser3_Click);
            // 
            // txb_targetQuick2
            // 
            this.txb_targetQuick2.Location = new System.Drawing.Point(136, 53);
            this.txb_targetQuick2.Name = "txb_targetQuick2";
            this.txb_targetQuick2.Size = new System.Drawing.Size(571, 26);
            this.txb_targetQuick2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Target:";
            // 
            // btn_DeepScan2
            // 
            this.btn_DeepScan2.Location = new System.Drawing.Point(818, 14);
            this.btn_DeepScan2.Name = "btn_DeepScan2";
            this.btn_DeepScan2.Size = new System.Drawing.Size(184, 65);
            this.btn_DeepScan2.TabIndex = 5;
            this.btn_DeepScan2.Text = "Scan";
            this.btn_DeepScan2.UseVisualStyleBackColor = true;
            this.btn_DeepScan2.Click += new System.EventHandler(this.btn_DeepScan2_Click);
            // 
            // txb_QuickScan2
            // 
            this.txb_QuickScan2.Location = new System.Drawing.Point(136, 11);
            this.txb_QuickScan2.Name = "txb_QuickScan2";
            this.txb_QuickScan2.Size = new System.Drawing.Size(571, 26);
            this.txb_QuickScan2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name of folder:";
            // 
            // tb_deep2
            // 
            this.tb_deep2.Controls.Add(this.btn_Browser4);
            this.tb_deep2.Controls.Add(this.txb_targerDeep2);
            this.tb_deep2.Controls.Add(this.label8);
            this.tb_deep2.Controls.Add(this.btn_DeepScan3);
            this.tb_deep2.Controls.Add(this.txb_DeepScan2);
            this.tb_deep2.Controls.Add(this.label4);
            this.tb_deep2.Location = new System.Drawing.Point(4, 29);
            this.tb_deep2.Name = "tb_deep2";
            this.tb_deep2.Size = new System.Drawing.Size(1005, 97);
            this.tb_deep2.TabIndex = 3;
            this.tb_deep2.Text = "Deep Folder";
            this.tb_deep2.UseVisualStyleBackColor = true;
            // 
            // btn_Browser4
            // 
            this.btn_Browser4.Location = new System.Drawing.Point(711, 13);
            this.btn_Browser4.Name = "btn_Browser4";
            this.btn_Browser4.Size = new System.Drawing.Size(75, 26);
            this.btn_Browser4.TabIndex = 8;
            this.btn_Browser4.Text = "Browser";
            this.btn_Browser4.UseVisualStyleBackColor = true;
            this.btn_Browser4.Click += new System.EventHandler(this.btn_Browser4_Click);
            // 
            // txb_targerDeep2
            // 
            this.txb_targerDeep2.Location = new System.Drawing.Point(118, 58);
            this.txb_targerDeep2.Name = "txb_targerDeep2";
            this.txb_targerDeep2.Size = new System.Drawing.Size(571, 26);
            this.txb_targerDeep2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Target:";
            // 
            // btn_DeepScan3
            // 
            this.btn_DeepScan3.Location = new System.Drawing.Point(814, 11);
            this.btn_DeepScan3.Name = "btn_DeepScan3";
            this.btn_DeepScan3.Size = new System.Drawing.Size(188, 73);
            this.btn_DeepScan3.TabIndex = 5;
            this.btn_DeepScan3.Text = "Scan";
            this.btn_DeepScan3.UseVisualStyleBackColor = true;
            this.btn_DeepScan3.Click += new System.EventHandler(this.btn_DeepScan3_Click);
            // 
            // txb_DeepScan2
            // 
            this.txb_DeepScan2.Location = new System.Drawing.Point(118, 13);
            this.txb_DeepScan2.Name = "txb_DeepScan2";
            this.txb_DeepScan2.Size = new System.Drawing.Size(571, 26);
            this.txb_DeepScan2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name of file:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(12, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 324);
            this.panel2.TabIndex = 1;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tb_Quick1.ResumeLayout(false);
            this.tb_Quick1.PerformLayout();
            this.tb_deepScan1.ResumeLayout(false);
            this.tb_deepScan1.PerformLayout();
            this.tb_Quick2.ResumeLayout(false);
            this.tb_Quick2.PerformLayout();
            this.tb_deep2.ResumeLayout(false);
            this.tb_deep2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_Quick1;
        private System.Windows.Forms.Button btn_QuickScan1;
        private System.Windows.Forms.TextBox txb_QuickScan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tb_deepScan1;
        private System.Windows.Forms.Button btn_DeepScan1;
        private System.Windows.Forms.TextBox txb_DeepScan1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tb_Quick2;
        private System.Windows.Forms.Button btn_DeepScan2;
        private System.Windows.Forms.TextBox txb_QuickScan2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tb_deep2;
        private System.Windows.Forms.Button btn_DeepScan3;
        private System.Windows.Forms.TextBox txb_DeepScan2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_TargerQuick1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_targerDeep1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_targetQuick2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_targerDeep2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_browser1;
        private System.Windows.Forms.Button btn_Browser2;
        private System.Windows.Forms.Button btn_Browser3;
        private System.Windows.Forms.Button btn_Browser4;
        private System.Windows.Forms.Button btn_clear;
        internal System.Windows.Forms.ComboBox comboBox1;
    }
}

