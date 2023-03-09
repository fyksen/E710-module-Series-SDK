namespace UHFReader288Demo
{
    partial class ParamSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParamSetting));
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_Mtidlen = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.txt_mtidaddr = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_Mdata = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.txt_Mlen = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.txt_Maddr = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.RBM_USER = new System.Windows.Forms.RadioButton();
            this.RBM_TID = new System.Windows.Forms.RadioButton();
            this.RBM_EPC = new System.Windows.Forms.RadioButton();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.com_MS = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.com_MQ = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.StatusBar1 = new System.Windows.Forms.StatusBar();
            this.TStatusPanel = new System.Windows.Forms.StatusBarPanel();
            this.Port = new System.Windows.Forms.StatusBarPanel();
            this.Manufacturername = new System.Windows.Forms.StatusBarPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox38.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.groupBox33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TStatusPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manufacturername)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.button3);
            this.groupBox38.Controls.Add(this.button4);
            this.groupBox38.Controls.Add(this.txt_Mtidlen);
            this.groupBox38.Controls.Add(this.label103);
            this.groupBox38.Controls.Add(this.txt_mtidaddr);
            this.groupBox38.Controls.Add(this.label104);
            this.groupBox38.Location = new System.Drawing.Point(12, 95);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(530, 56);
            this.groupBox38.TabIndex = 86;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "TID param";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(434, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Get";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(343, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Set";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_Mtidlen
            // 
            this.txt_Mtidlen.Location = new System.Drawing.Point(254, 20);
            this.txt_Mtidlen.MaxLength = 2;
            this.txt_Mtidlen.Name = "txt_Mtidlen";
            this.txt_Mtidlen.Size = new System.Drawing.Size(60, 21);
            this.txt_Mtidlen.TabIndex = 5;
            this.txt_Mtidlen.Text = "00";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(166, 24);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(83, 12);
            this.label103.TabIndex = 4;
            this.label103.Text = "Length(Hex)：";
            // 
            // txt_mtidaddr
            // 
            this.txt_mtidaddr.Location = new System.Drawing.Point(97, 20);
            this.txt_mtidaddr.MaxLength = 2;
            this.txt_mtidaddr.Name = "txt_mtidaddr";
            this.txt_mtidaddr.Size = new System.Drawing.Size(60, 21);
            this.txt_mtidaddr.TabIndex = 3;
            this.txt_mtidaddr.Text = "00";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(5, 24);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(77, 12);
            this.label104.TabIndex = 0;
            this.label104.Text = "Start(Hex)：";
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.button5);
            this.groupBox34.Controls.Add(this.button6);
            this.groupBox34.Controls.Add(this.txt_Mdata);
            this.groupBox34.Controls.Add(this.label100);
            this.groupBox34.Controls.Add(this.txt_Mlen);
            this.groupBox34.Controls.Add(this.label101);
            this.groupBox34.Controls.Add(this.txt_Maddr);
            this.groupBox34.Controls.Add(this.label102);
            this.groupBox34.Controls.Add(this.RBM_USER);
            this.groupBox34.Controls.Add(this.RBM_TID);
            this.groupBox34.Controls.Add(this.RBM_EPC);
            this.groupBox34.Location = new System.Drawing.Point(12, 159);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(530, 92);
            this.groupBox34.TabIndex = 85;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Mask";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(434, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Get";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(434, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Set";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_Mdata
            // 
            this.txt_Mdata.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Mdata.Location = new System.Drawing.Point(94, 61);
            this.txt_Mdata.Name = "txt_Mdata";
            this.txt_Mdata.Size = new System.Drawing.Size(316, 21);
            this.txt_Mdata.TabIndex = 8;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(6, 67);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(65, 12);
            this.label100.TabIndex = 7;
            this.label100.Text = "Data(Hex):";
            // 
            // txt_Mlen
            // 
            this.txt_Mlen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Mlen.Location = new System.Drawing.Point(348, 33);
            this.txt_Mlen.MaxLength = 2;
            this.txt_Mlen.Name = "txt_Mlen";
            this.txt_Mlen.Size = new System.Drawing.Size(62, 21);
            this.txt_Mlen.TabIndex = 6;
            this.txt_Mlen.Text = "00";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(247, 40);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(77, 12);
            this.label101.TabIndex = 5;
            this.label101.Text = "Length(Hex):";
            // 
            // txt_Maddr
            // 
            this.txt_Maddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Maddr.Location = new System.Drawing.Point(137, 33);
            this.txt_Maddr.MaxLength = 4;
            this.txt_Maddr.Name = "txt_Maddr";
            this.txt_Maddr.Size = new System.Drawing.Size(55, 21);
            this.txt_Maddr.TabIndex = 4;
            this.txt_Maddr.Text = "0020";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(6, 40);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(95, 12);
            this.label102.TabIndex = 3;
            this.label102.Text = "Start-bit(Hex):";
            // 
            // RBM_USER
            // 
            this.RBM_USER.AutoSize = true;
            this.RBM_USER.Location = new System.Drawing.Point(247, 14);
            this.RBM_USER.Name = "RBM_USER";
            this.RBM_USER.Size = new System.Drawing.Size(47, 16);
            this.RBM_USER.TabIndex = 2;
            this.RBM_USER.Text = "User";
            this.RBM_USER.UseVisualStyleBackColor = true;
            // 
            // RBM_TID
            // 
            this.RBM_TID.AutoSize = true;
            this.RBM_TID.Location = new System.Drawing.Point(136, 14);
            this.RBM_TID.Name = "RBM_TID";
            this.RBM_TID.Size = new System.Drawing.Size(41, 16);
            this.RBM_TID.TabIndex = 1;
            this.RBM_TID.Text = "TID";
            this.RBM_TID.UseVisualStyleBackColor = true;
            // 
            // RBM_EPC
            // 
            this.RBM_EPC.AutoSize = true;
            this.RBM_EPC.Checked = true;
            this.RBM_EPC.Location = new System.Drawing.Point(20, 14);
            this.RBM_EPC.Name = "RBM_EPC";
            this.RBM_EPC.Size = new System.Drawing.Size(41, 16);
            this.RBM_EPC.TabIndex = 0;
            this.RBM_EPC.TabStop = true;
            this.RBM_EPC.Text = "EPC";
            this.RBM_EPC.UseVisualStyleBackColor = true;
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.checkBox2);
            this.groupBox33.Controls.Add(this.button2);
            this.groupBox33.Controls.Add(this.button1);
            this.groupBox33.Controls.Add(this.com_MS);
            this.groupBox33.Controls.Add(this.label99);
            this.groupBox33.Controls.Add(this.com_MQ);
            this.groupBox33.Controls.Add(this.label98);
            this.groupBox33.Location = new System.Drawing.Point(12, 33);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(530, 56);
            this.groupBox33.TabIndex = 84;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Param1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // com_MS
            // 
            this.com_MS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MS.FormattingEnabled = true;
            this.com_MS.Items.AddRange(new object[] {
            "S0",
            "S1",
            "S2",
            "S3"});
            this.com_MS.Location = new System.Drawing.Point(237, 22);
            this.com_MS.Name = "com_MS";
            this.com_MS.Size = new System.Drawing.Size(79, 20);
            this.com_MS.TabIndex = 3;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(171, 26);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(59, 12);
            this.label99.TabIndex = 2;
            this.label99.Text = "Session：";
            // 
            // com_MQ
            // 
            this.com_MQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MQ.FormattingEnabled = true;
            this.com_MQ.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.com_MQ.Location = new System.Drawing.Point(44, 22);
            this.com_MQ.Name = "com_MQ";
            this.com_MQ.Size = new System.Drawing.Size(59, 20);
            this.com_MQ.TabIndex = 1;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(7, 26);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(23, 12);
            this.label98.TabIndex = 0;
            this.label98.Text = "Q：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(231, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 87;
            this.checkBox1.Text = "Save";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // StatusBar1
            // 
            this.StatusBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StatusBar1.Location = new System.Drawing.Point(0, 252);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.TStatusPanel,
            this.Port,
            this.Manufacturername});
            this.StatusBar1.ShowPanels = true;
            this.StatusBar1.Size = new System.Drawing.Size(563, 20);
            this.StatusBar1.SizingGrip = false;
            this.StatusBar1.TabIndex = 88;
            this.StatusBar1.Text = "StatusBar1";
            // 
            // TStatusPanel
            // 
            this.TStatusPanel.Name = "TStatusPanel";
            this.TStatusPanel.Width = 740;
            // 
            // Port
            // 
            this.Port.MinWidth = 66;
            this.Port.Name = "Port";
            this.Port.Text = "Port:";
            // 
            // Manufacturername
            // 
            this.Manufacturername.Name = "Manufacturername";
            this.Manufacturername.Text = "statusManufacturer nameBarPanel1";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(109, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 16);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Phase";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ParamSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 272);
            this.Controls.Add(this.StatusBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox38);
            this.Controls.Add(this.groupBox34);
            this.Controls.Add(this.groupBox33);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParamSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast inventory Parameter";
            this.Load += new System.EventHandler(this.ParamSetting_Load);
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TStatusPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manufacturername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox38;
        private System.Windows.Forms.TextBox txt_Mtidlen;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox txt_mtidaddr;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.TextBox txt_Mdata;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox txt_Mlen;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox txt_Maddr;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.RadioButton RBM_USER;
        private System.Windows.Forms.RadioButton RBM_TID;
        private System.Windows.Forms.RadioButton RBM_EPC;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.ComboBox com_MS;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox com_MQ;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.StatusBar StatusBar1;
        private System.Windows.Forms.StatusBarPanel TStatusPanel;
        private System.Windows.Forms.StatusBarPanel Port;
        private System.Windows.Forms.StatusBarPanel Manufacturername;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}