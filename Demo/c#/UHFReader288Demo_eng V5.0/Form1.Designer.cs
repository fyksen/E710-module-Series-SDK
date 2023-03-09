namespace UHFReader288Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lrtxtLog = new CustomControl.LogRichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Maintab = new System.Windows.Forms.TabControl();
            this.Main_Page1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Basic = new System.Windows.Forms.TabPage();
            this.gbReturnLoss = new System.Windows.Forms.GroupBox();
            this.cbbAnt = new System.Windows.Forms.ComboBox();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.cmbReturnLossFreq = new System.Windows.Forms.ComboBox();
            this.label122 = new System.Windows.Forms.Label();
            this.textReturnLoss = new System.Windows.Forms.TextBox();
            this.btReturnLoss = new System.Windows.Forms.Button();
            this.gbCmdTemperature = new System.Windows.Forms.GroupBox();
            this.btnGetReaderTemperature = new System.Windows.Forms.Button();
            this.txtReaderTemperature = new System.Windows.Forms.TextBox();
            this.gbp_DRM = new System.Windows.Forms.GroupBox();
            this.DRM_CLOSE = new System.Windows.Forms.RadioButton();
            this.DRM_OPEN = new System.Windows.Forms.RadioButton();
            this.bt_GetDRM = new System.Windows.Forms.Button();
            this.bt_setDRM = new System.Windows.Forms.Button();
            this.gbp_Retry = new System.Windows.Forms.GroupBox();
            this.com_retrytimes = new System.Windows.Forms.ComboBox();
            this.bt_Getretry = new System.Windows.Forms.Button();
            this.bt_Setretry = new System.Windows.Forms.Button();
            this.gbp_wpower = new System.Windows.Forms.GroupBox();
            this.label112 = new System.Windows.Forms.Label();
            this.com_wpower = new System.Windows.Forms.ComboBox();
            this.rb_wp2 = new System.Windows.Forms.RadioButton();
            this.rb_wp1 = new System.Windows.Forms.RadioButton();
            this.bt_GetWpower = new System.Windows.Forms.Button();
            this.bt_SetWpower = new System.Windows.Forms.Button();
            this.group_maxtime = new System.Windows.Forms.GroupBox();
            this.comboBox_maxtime = new System.Windows.Forms.ComboBox();
            this.btSetMaxtime = new System.Windows.Forms.Button();
            this.gbp_buff = new System.Windows.Forms.GroupBox();
            this.rb496 = new System.Windows.Forms.RadioButton();
            this.rb128 = new System.Windows.Forms.RadioButton();
            this.btGetEPCandTIDLen = new System.Windows.Forms.Button();
            this.btSetEPCandTIDLen = new System.Windows.Forms.Button();
            this.btGetInformation = new System.Windows.Forms.Button();
            this.btDefault = new System.Windows.Forms.Button();
            this.btFlashROM = new System.Windows.Forms.Button();
            this.gpb_antconfig = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkant16 = new System.Windows.Forms.CheckBox();
            this.checkant15 = new System.Windows.Forms.CheckBox();
            this.checkant14 = new System.Windows.Forms.CheckBox();
            this.checkant13 = new System.Windows.Forms.CheckBox();
            this.checkant12 = new System.Windows.Forms.CheckBox();
            this.checkant11 = new System.Windows.Forms.CheckBox();
            this.checkant10 = new System.Windows.Forms.CheckBox();
            this.checkant9 = new System.Windows.Forms.CheckBox();
            this.checkant8 = new System.Windows.Forms.CheckBox();
            this.checkant7 = new System.Windows.Forms.CheckBox();
            this.checkant6 = new System.Windows.Forms.CheckBox();
            this.checkant5 = new System.Windows.Forms.CheckBox();
            this.Button_Ant = new System.Windows.Forms.Button();
            this.checkant4 = new System.Windows.Forms.CheckBox();
            this.checkant3 = new System.Windows.Forms.CheckBox();
            this.checkant2 = new System.Windows.Forms.CheckBox();
            this.checkant1 = new System.Windows.Forms.CheckBox();
            this.gpb_checkant = new System.Windows.Forms.GroupBox();
            this.btSetcheckant = new System.Windows.Forms.Button();
            this.rb_Closecheckant = new System.Windows.Forms.RadioButton();
            this.rb_Opencheckant = new System.Windows.Forms.RadioButton();
            this.gpb_GPIO = new System.Windows.Forms.GroupBox();
            this.Button_GetGPIO = new System.Windows.Forms.Button();
            this.Button_SetGPIO = new System.Windows.Forms.Button();
            this.check_int4 = new System.Windows.Forms.CheckBox();
            this.check_int3 = new System.Windows.Forms.CheckBox();
            this.check_int2 = new System.Windows.Forms.CheckBox();
            this.check_int1 = new System.Windows.Forms.CheckBox();
            this.check_out4 = new System.Windows.Forms.CheckBox();
            this.check_out3 = new System.Windows.Forms.CheckBox();
            this.check_out2 = new System.Windows.Forms.CheckBox();
            this.check_out1 = new System.Windows.Forms.CheckBox();
            this.gpb_OutputRep = new System.Windows.Forms.GroupBox();
            this.btOutputRep = new System.Windows.Forms.Button();
            this.check_OutputRep4 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep3 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep2 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep1 = new System.Windows.Forms.CheckBox();
            this.gpb_Relay = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.ComboBox_RelayTime = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btRelay = new System.Windows.Forms.Button();
            this.gpb_baud = new System.Windows.Forms.GroupBox();
            this.ComboBox_baud = new System.Windows.Forms.ComboBox();
            this.btBaudRate = new System.Windows.Forms.Button();
            this.gpb_DBM = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBox_PowerDbm = new System.Windows.Forms.ComboBox();
            this.BT_DBM = new System.Windows.Forms.Button();
            this.gpb_Freq = new System.Windows.Forms.GroupBox();
            this.radioButton_band0 = new System.Windows.Forms.RadioButton();
            this.radioButton_band12 = new System.Windows.Forms.RadioButton();
            this.radioButton_band8 = new System.Windows.Forms.RadioButton();
            this.CheckBox_SameFre = new System.Windows.Forms.CheckBox();
            this.radioButton_band4 = new System.Windows.Forms.RadioButton();
            this.radioButton_band3 = new System.Windows.Forms.RadioButton();
            this.radioButton_band2 = new System.Windows.Forms.RadioButton();
            this.radioButton_band1 = new System.Windows.Forms.RadioButton();
            this.btFreq = new System.Windows.Forms.Button();
            this.ComboBox_dmaxfre = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ComboBox_dminfre = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gpb_beep = new System.Windows.Forms.GroupBox();
            this.Radio_beepDis = new System.Windows.Forms.RadioButton();
            this.Radio_beepEn = new System.Windows.Forms.RadioButton();
            this.Button_Beep = new System.Windows.Forms.Button();
            this.gpb_RDVersion = new System.Windows.Forms.GroupBox();
            this.text_RDVersion = new System.Windows.Forms.TextBox();
            this.gpb_MDVersion = new System.Windows.Forms.GroupBox();
            this.text_MDVersion = new System.Windows.Forms.TextBox();
            this.btMDVersion = new System.Windows.Forms.Button();
            this.gpb_Serial = new System.Windows.Forms.GroupBox();
            this.text_Serial = new System.Windows.Forms.TextBox();
            this.btSerial = new System.Windows.Forms.Button();
            this.gpb_address = new System.Windows.Forms.GroupBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.btaddress = new System.Windows.Forms.Button();
            this.gpb_tcp = new System.Windows.Forms.GroupBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.ipServerIP = new CustomControl.IpAddressTextBox();
            this.btDisConnectTcp = new System.Windows.Forms.Button();
            this.btConnectTcp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpb_rs232 = new System.Windows.Forms.GroupBox();
            this.btDisConnect232 = new System.Windows.Forms.Button();
            this.btConnect232 = new System.Windows.Forms.Button();
            this.ComboBox_baud2 = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.ComboBox_COM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_tcp = new System.Windows.Forms.RadioButton();
            this.rb_rs232 = new System.Windows.Forms.RadioButton();
            this.tabPage_Mx = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbp_trigger = new System.Windows.Forms.GroupBox();
            this.label84 = new System.Windows.Forms.Label();
            this.bttrigger = new System.Windows.Forms.Button();
            this.comboBox_trigger = new System.Windows.Forms.ComboBox();
            this.label85 = new System.Windows.Forms.Label();
            this.groupBox43 = new System.Windows.Forms.GroupBox();
            this.btGetQS = new System.Windows.Forms.Button();
            this.btSetQS = new System.Windows.Forms.Button();
            this.com_acS = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.com_acQ = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.groupBox44 = new System.Windows.Forms.GroupBox();
            this.text_tidlen = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.text_tidaddr = new System.Windows.Forms.TextBox();
            this.btTIDpara = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.btGetWorkmodepara = new System.Windows.Forms.Button();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.btworkmode = new System.Windows.Forms.Button();
            this.comboBox_mode = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.btInterval = new System.Windows.Forms.Button();
            this.comboBox_intervalT = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.gbp_tagType = new System.Windows.Forms.GroupBox();
            this.rb_G2TID = new System.Windows.Forms.RadioButton();
            this.bt_typeTag = new System.Windows.Forms.Button();
            this.rb_EAS = new System.Windows.Forms.RadioButton();
            this.rb_G2 = new System.Windows.Forms.RadioButton();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.rb_180006B = new System.Windows.Forms.RadioButton();
            this.rb_180006c = new System.Windows.Forms.RadioButton();
            this.gbp_Response = new System.Windows.Forms.GroupBox();
            this.btResponse = new System.Windows.Forms.Button();
            this.label57 = new System.Windows.Forms.Label();
            this.comboBox_RespTime = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.comboBox_Resp = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.gbp_mask = new System.Windows.Forms.GroupBox();
            this.btMaskSet = new System.Windows.Forms.Button();
            this.text_mdata = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.text_mlen = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.text_madds = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.rb_MaskUser = new System.Windows.Forms.RadioButton();
            this.rb_MaskTID = new System.Windows.Forms.RadioButton();
            this.rb_MaskEPC = new System.Windows.Forms.RadioButton();
            this.gbp_EASAcc = new System.Windows.Forms.GroupBox();
            this.btAccuracy = new System.Windows.Forms.Button();
            this.ComboBox_Accuracy = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbEASAcc = new System.Windows.Forms.RadioButton();
            this.tabPage_Module = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btMSetParameter = new System.Windows.Forms.Button();
            this.btMGetParameter = new System.Windows.Forms.Button();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.btSetMmode = new System.Windows.Forms.Button();
            this.com_Mmode = new System.Windows.Forms.ComboBox();
            this.label111 = new System.Windows.Forms.Label();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.checkBox_tid = new System.Windows.Forms.CheckBox();
            this.txt_Mtidlen = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.txt_mtidaddr = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.checkBox_mask = new System.Windows.Forms.CheckBox();
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
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.com_MS = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.com_MQ = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.com_MFliterTime = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.COM_MRPTime = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MRB_6B = new System.Windows.Forms.RadioButton();
            this.MRB_G2 = new System.Windows.Forms.RadioButton();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.groupBox58 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label194 = new System.Windows.Forms.Label();
            this.com_queryInter = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label192 = new System.Windows.Forms.Label();
            this.cbb_add = new System.Windows.Forms.ComboBox();
            this.label193 = new System.Windows.Forms.Label();
            this.cbb_dwell = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox57 = new System.Windows.Forms.GroupBox();
            this.rb_enable = new System.Windows.Forms.RadioButton();
            this.rb_disable = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox45 = new System.Windows.Forms.GroupBox();
            this.rb_pro4 = new System.Windows.Forms.RadioButton();
            this.rb_pro3 = new System.Windows.Forms.RadioButton();
            this.rb_pro2 = new System.Windows.Forms.RadioButton();
            this.rb_pro1 = new System.Windows.Forms.RadioButton();
            this.rb_pro0 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbp_PowerAnt = new System.Windows.Forms.GroupBox();
            this.txtPower16 = new System.Windows.Forms.TextBox();
            this.label174 = new System.Windows.Forms.Label();
            this.txtPower15 = new System.Windows.Forms.TextBox();
            this.label175 = new System.Windows.Forms.Label();
            this.txtPower14 = new System.Windows.Forms.TextBox();
            this.label176 = new System.Windows.Forms.Label();
            this.txtPower13 = new System.Windows.Forms.TextBox();
            this.label177 = new System.Windows.Forms.Label();
            this.txtPower12 = new System.Windows.Forms.TextBox();
            this.label178 = new System.Windows.Forms.Label();
            this.txtPower11 = new System.Windows.Forms.TextBox();
            this.label179 = new System.Windows.Forms.Label();
            this.txtPower10 = new System.Windows.Forms.TextBox();
            this.label180 = new System.Windows.Forms.Label();
            this.txtPower9 = new System.Windows.Forms.TextBox();
            this.label181 = new System.Windows.Forms.Label();
            this.txtPower8 = new System.Windows.Forms.TextBox();
            this.label182 = new System.Windows.Forms.Label();
            this.txtPower7 = new System.Windows.Forms.TextBox();
            this.label183 = new System.Windows.Forms.Label();
            this.txtPower6 = new System.Windows.Forms.TextBox();
            this.label184 = new System.Windows.Forms.Label();
            this.txtPower5 = new System.Windows.Forms.TextBox();
            this.label185 = new System.Windows.Forms.Label();
            this.txtPower4 = new System.Windows.Forms.TextBox();
            this.label186 = new System.Windows.Forms.Label();
            this.txtPower3 = new System.Windows.Forms.TextBox();
            this.label187 = new System.Windows.Forms.Label();
            this.txtPower2 = new System.Windows.Forms.TextBox();
            this.label188 = new System.Windows.Forms.Label();
            this.txtPower1 = new System.Windows.Forms.TextBox();
            this.label189 = new System.Windows.Forms.Label();
            this.btGetRfPower = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btSetRfPower = new System.Windows.Forms.Button();
            this.Main_Page2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage_answer = new System.Windows.Forms.TabPage();
            this.chk_phase = new System.Windows.Forms.Panel();
            this.group_ant1 = new System.Windows.Forms.GroupBox();
            this.check_ant16 = new System.Windows.Forms.CheckBox();
            this.check_ant15 = new System.Windows.Forms.CheckBox();
            this.check_ant14 = new System.Windows.Forms.CheckBox();
            this.check_ant13 = new System.Windows.Forms.CheckBox();
            this.check_ant12 = new System.Windows.Forms.CheckBox();
            this.check_ant11 = new System.Windows.Forms.CheckBox();
            this.check_ant10 = new System.Windows.Forms.CheckBox();
            this.check_ant9 = new System.Windows.Forms.CheckBox();
            this.check_ant8 = new System.Windows.Forms.CheckBox();
            this.check_ant7 = new System.Windows.Forms.CheckBox();
            this.check_ant6 = new System.Windows.Forms.CheckBox();
            this.check_ant5 = new System.Windows.Forms.CheckBox();
            this.check_ant4 = new System.Windows.Forms.CheckBox();
            this.check_ant3 = new System.Windows.Forms.CheckBox();
            this.check_ant2 = new System.Windows.Forms.CheckBox();
            this.check_ant1 = new System.Windows.Forms.CheckBox();
            this.lxLedControl6 = new LxControl.LxLedControl();
            this.label119 = new System.Windows.Forms.Label();
            this.lxLedControl5 = new LxControl.LxLedControl();
            this.label9 = new System.Windows.Forms.Label();
            this.lxLedControl4 = new LxControl.LxLedControl();
            this.label8 = new System.Windows.Forms.Label();
            this.lxLedControl3 = new LxControl.LxLedControl();
            this.label7 = new System.Windows.Forms.Label();
            this.lxLedControl2 = new LxControl.LxLedControl();
            this.label6 = new System.Windows.Forms.Label();
            this.lxLedControl1 = new LxControl.LxLedControl();
            this.label5 = new System.Windows.Forms.Label();
            this.gbp_MixRead = new System.Windows.Forms.GroupBox();
            this.text_readpsd = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.text_readLen = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.text_readadr = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.com_MixMem = new System.Windows.Forms.ComboBox();
            this.label114 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.check_phase = new System.Windows.Forms.CheckBox();
            this.checkBox_rate = new System.Windows.Forms.CheckBox();
            this.label80 = new System.Windows.Forms.Label();
            this.text_target = new System.Windows.Forms.TextBox();
            this.check_num = new System.Windows.Forms.CheckBox();
            this.com_Target = new System.Windows.Forms.ComboBox();
            this.label79 = new System.Windows.Forms.Label();
            this.com_scantime = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.com_S = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.com_Q = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_fastid = new System.Windows.Forms.RadioButton();
            this.rb_mix = new System.Windows.Forms.RadioButton();
            this.rb_tid = new System.Windows.Forms.RadioButton();
            this.rb_epc = new System.Windows.Forms.RadioButton();
            this.btIventoryG2 = new System.Windows.Forms.Button();
            this.tabPage_active = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lxLed_toltime = new LxControl.LxLedControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.lxLed_toltag = new LxControl.LxLedControl();
            this.label18 = new System.Windows.Forms.Label();
            this.lxLed_cmdsud = new LxControl.LxLedControl();
            this.label17 = new System.Windows.Forms.Label();
            this.lxLed_Num = new LxControl.LxLedControl();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btClearBuffer = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btGettagbuffer = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btGetrunmodedata = new System.Windows.Forms.Button();
            this.tabPage_Realtime = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox41 = new System.Windows.Forms.GroupBox();
            this.lxLed_Mtime = new LxControl.LxLedControl();
            this.label113 = new System.Windows.Forms.Label();
            this.lxLed_Mtag = new LxControl.LxLedControl();
            this.label116 = new System.Windows.Forms.Label();
            this.groupBox42 = new System.Windows.Forms.GroupBox();
            this.btStartMactive = new System.Windows.Forms.Button();
            this.tabPage_Buff = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.btQueryBuffNum = new System.Windows.Forms.Button();
            this.btRandCbuff = new System.Windows.Forms.Button();
            this.btClearBuff = new System.Windows.Forms.Button();
            this.btReadBuff = new System.Windows.Forms.Button();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.rb_btid = new System.Windows.Forms.RadioButton();
            this.rb_bepc = new System.Windows.Forms.RadioButton();
            this.btStartBuff = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.lxLed_cmdTime = new LxControl.LxLedControl();
            this.label86 = new System.Windows.Forms.Label();
            this.lxLed_Btoltime = new LxControl.LxLedControl();
            this.label83 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.lxLed_Btoltag = new LxControl.LxLedControl();
            this.label92 = new System.Windows.Forms.Label();
            this.lxLed_Bcmdsud = new LxControl.LxLedControl();
            this.label94 = new System.Windows.Forms.Label();
            this.lxLed_BNum = new LxControl.LxLedControl();
            this.label95 = new System.Windows.Forms.Label();
            this.tabPage_fastscan = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox59 = new System.Windows.Forms.GroupBox();
            this.lxLedControl9 = new LxControl.LxLedControl();
            this.label197 = new System.Windows.Forms.Label();
            this.lxLedControl7 = new LxControl.LxLedControl();
            this.label195 = new System.Windows.Forms.Label();
            this.lxLedControl8 = new LxControl.LxLedControl();
            this.label196 = new System.Windows.Forms.Label();
            this.groupBox60 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label198 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabPage_RW = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.btCheckReadProtected_G2 = new System.Windows.Forms.Button();
            this.btRemoveReadProtect_G2 = new System.Windows.Forms.Button();
            this.btSetMultiReadProtect_G2 = new System.Windows.Forms.Button();
            this.btSetReadProtect_G2 = new System.Windows.Forms.Button();
            this.text_AccessCode4 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.btWriteEPC_G2 = new System.Windows.Forms.Button();
            this.text_AccessCode3 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.text_WriteEPC = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.btDestroyCard = new System.Windows.Forms.Button();
            this.text_DestroyCode = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btCheckEASAlarm = new System.Windows.Forms.Button();
            this.btSetEASAlarm_G2 = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.NoAlarm_G2 = new System.Windows.Forms.RadioButton();
            this.Alarm_G2 = new System.Windows.Forms.RadioButton();
            this.text_AccessCode5 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btSetProtectState = new System.Windows.Forms.Button();
            this.Edit_AccessCode6 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.AlwaysNot2 = new System.Windows.Forms.RadioButton();
            this.Always2 = new System.Windows.Forms.RadioButton();
            this.Proect2 = new System.Windows.Forms.RadioButton();
            this.NoProect2 = new System.Windows.Forms.RadioButton();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.p_pass = new System.Windows.Forms.RadioButton();
            this.P_User = new System.Windows.Forms.RadioButton();
            this.P_TID = new System.Windows.Forms.RadioButton();
            this.P_EPC = new System.Windows.Forms.RadioButton();
            this.P_kill = new System.Windows.Forms.RadioButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btExtWrite = new System.Windows.Forms.Button();
            this.btExtRead = new System.Windows.Forms.Button();
            this.textBox_pc = new System.Windows.Forms.TextBox();
            this.checkBox_pc = new System.Windows.Forms.CheckBox();
            this.btBlockWrite = new System.Windows.Forms.Button();
            this.btBlockErase = new System.Windows.Forms.Button();
            this.btWrite = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.text_WriteData = new System.Windows.Forms.TextBox();
            this.text_AccessCode2 = new System.Windows.Forms.TextBox();
            this.text_RWlen = new System.Windows.Forms.TextBox();
            this.text_WordPtr = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.C_User = new System.Windows.Forms.RadioButton();
            this.C_TID = new System.Windows.Forms.RadioButton();
            this.C_EPC = new System.Windows.Forms.RadioButton();
            this.C_Reserve = new System.Windows.Forms.RadioButton();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.maskData_textBox = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.groupBox40 = new System.Windows.Forms.GroupBox();
            this.R_User = new System.Windows.Forms.RadioButton();
            this.R_TID = new System.Windows.Forms.RadioButton();
            this.R_EPC = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.maskLen_textBox = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.maskadr_textbox = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btSelectTag = new System.Windows.Forms.Button();
            this.comboBox_EPC = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.text_epc = new System.Windows.Forms.TextBox();
            this.check_selecttag = new System.Windows.Forms.CheckBox();
            this.Main_Page5 = new System.Windows.Forms.TabPage();
            this.panel_jb = new System.Windows.Forms.Panel();
            this.group_jbant = new System.Windows.Forms.GroupBox();
            this.chk_jbant16 = new System.Windows.Forms.CheckBox();
            this.chk_jbant15 = new System.Windows.Forms.CheckBox();
            this.chk_jbant14 = new System.Windows.Forms.CheckBox();
            this.chk_jbant13 = new System.Windows.Forms.CheckBox();
            this.chk_jbant12 = new System.Windows.Forms.CheckBox();
            this.chk_jbant11 = new System.Windows.Forms.CheckBox();
            this.chk_jbant10 = new System.Windows.Forms.CheckBox();
            this.chk_jbant9 = new System.Windows.Forms.CheckBox();
            this.chk_jbant8 = new System.Windows.Forms.CheckBox();
            this.chk_jbant7 = new System.Windows.Forms.CheckBox();
            this.chk_jbant6 = new System.Windows.Forms.CheckBox();
            this.chk_jbant5 = new System.Windows.Forms.CheckBox();
            this.chk_jbant4 = new System.Windows.Forms.CheckBox();
            this.chk_jbant3 = new System.Windows.Forms.CheckBox();
            this.chk_jbant2 = new System.Windows.Forms.CheckBox();
            this.chk_jbant1 = new System.Windows.Forms.CheckBox();
            this.com_jb_tagid = new System.Windows.Forms.ComboBox();
            this.label132 = new System.Windows.Forms.Label();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_jb_read = new System.Windows.Forms.Button();
            this.txt_jb_read_data = new System.Windows.Forms.TextBox();
            this.label137 = new System.Windows.Forms.Label();
            this.txt_jb_read_pwd = new System.Windows.Forms.TextBox();
            this.label136 = new System.Windows.Forms.Label();
            this.txt_jb_read_len = new System.Windows.Forms.TextBox();
            this.label135 = new System.Windows.Forms.Label();
            this.txt_jb_read_startaddr = new System.Windows.Forms.TextBox();
            this.label134 = new System.Windows.Forms.Label();
            this.cbb_jb_readmem = new System.Windows.Forms.ComboBox();
            this.label133 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_jb_write = new System.Windows.Forms.Button();
            this.txt_jb_write_data = new System.Windows.Forms.TextBox();
            this.label138 = new System.Windows.Forms.Label();
            this.txt_jb_write_pwd = new System.Windows.Forms.TextBox();
            this.label139 = new System.Windows.Forms.Label();
            this.txt_jb_write_startaddr = new System.Windows.Forms.TextBox();
            this.label141 = new System.Windows.Forms.Label();
            this.cbb_jb_writemem = new System.Windows.Forms.ComboBox();
            this.label142 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbb_jb_locktype = new System.Windows.Forms.ComboBox();
            this.bt_jb_lock = new System.Windows.Forms.Button();
            this.label143 = new System.Windows.Forms.Label();
            this.txt_jb_lock_pwd = new System.Windows.Forms.TextBox();
            this.label144 = new System.Windows.Forms.Label();
            this.cbb_jb_lockmem = new System.Windows.Forms.ComboBox();
            this.label145 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bt_jb_erase = new System.Windows.Forms.Button();
            this.txt_jb_erase_pwd = new System.Windows.Forms.TextBox();
            this.label146 = new System.Windows.Forms.Label();
            this.txt_jb_erase_num = new System.Windows.Forms.TextBox();
            this.label147 = new System.Windows.Forms.Label();
            this.txt_jb_erase_startaddr = new System.Windows.Forms.TextBox();
            this.label148 = new System.Windows.Forms.Label();
            this.cbb_jb_erasemem = new System.Windows.Forms.ComboBox();
            this.label149 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bt_jb_kill = new System.Windows.Forms.Button();
            this.txt_jb_kill_pwd = new System.Windows.Forms.TextBox();
            this.label150 = new System.Windows.Forms.Label();
            this.groupBox53 = new System.Windows.Forms.GroupBox();
            this.txt_jb_maskdata = new System.Windows.Forms.TextBox();
            this.label131 = new System.Windows.Forms.Label();
            this.txt_mask_jb_startaddr = new System.Windows.Forms.TextBox();
            this.label130 = new System.Windows.Forms.Label();
            this.cbb_jb_masktype = new System.Windows.Forms.ComboBox();
            this.label129 = new System.Windows.Forms.Label();
            this.chk_jb_mask = new System.Windows.Forms.CheckBox();
            this.lxLed_jb_number = new LxControl.LxLedControl();
            this.label128 = new System.Windows.Forms.Label();
            this.lxLed_jb_time = new LxControl.LxLedControl();
            this.label127 = new System.Windows.Forms.Label();
            this.groupBox52 = new System.Windows.Forms.GroupBox();
            this.dataGridView_JB = new System.Windows.Forms.DataGridView();
            this.gbp_jb_mix = new System.Windows.Forms.GroupBox();
            this.tx_jb_readpsd = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.tx_jb_masklen = new System.Windows.Forms.TextBox();
            this.label124 = new System.Windows.Forms.Label();
            this.tx_jb_maskaddr = new System.Windows.Forms.TextBox();
            this.label125 = new System.Windows.Forms.Label();
            this.cbb_jb_maskmem = new System.Windows.Forms.ComboBox();
            this.label126 = new System.Windows.Forms.Label();
            this.groupBox48 = new System.Windows.Forms.GroupBox();
            this.com_jb_target = new System.Windows.Forms.ComboBox();
            this.label151 = new System.Windows.Forms.Label();
            this.cbb_jb_scantime = new System.Windows.Forms.ComboBox();
            this.label140 = new System.Windows.Forms.Label();
            this.rb_jb_normal = new System.Windows.Forms.RadioButton();
            this.rb_jb_mix = new System.Windows.Forms.RadioButton();
            this.btInventoryJB = new System.Windows.Forms.Button();
            this.Main_Page6 = new System.Windows.Forms.TabPage();
            this.panel_gb = new System.Windows.Forms.Panel();
            this.com_gb_tagid = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.bt_gb_read = new System.Windows.Forms.Button();
            this.txt_gb_read_data = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_gb_read_pwd = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txt_gb_read_len = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txt_gb_read_startaddr = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.cbb_gb_readmem = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.bt_gb_write = new System.Windows.Forms.Button();
            this.txt_gb_write_data = new System.Windows.Forms.TextBox();
            this.label152 = new System.Windows.Forms.Label();
            this.txt_gb_write_pwd = new System.Windows.Forms.TextBox();
            this.label153 = new System.Windows.Forms.Label();
            this.txt_gb_write_startaddr = new System.Windows.Forms.TextBox();
            this.label154 = new System.Windows.Forms.Label();
            this.cbb_gb_writemem = new System.Windows.Forms.ComboBox();
            this.label155 = new System.Windows.Forms.Label();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.cbb_gb_locktype = new System.Windows.Forms.ComboBox();
            this.bt_gb_lock = new System.Windows.Forms.Button();
            this.label156 = new System.Windows.Forms.Label();
            this.txt_gb_lock_pwd = new System.Windows.Forms.TextBox();
            this.label157 = new System.Windows.Forms.Label();
            this.cbb_gb_lockmem = new System.Windows.Forms.ComboBox();
            this.label158 = new System.Windows.Forms.Label();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.bt_gb_erase = new System.Windows.Forms.Button();
            this.txt_gb_erase_pwd = new System.Windows.Forms.TextBox();
            this.label159 = new System.Windows.Forms.Label();
            this.txt_gb_erase_num = new System.Windows.Forms.TextBox();
            this.label160 = new System.Windows.Forms.Label();
            this.txt_gb_erase_startaddr = new System.Windows.Forms.TextBox();
            this.label161 = new System.Windows.Forms.Label();
            this.cbb_gb_erasemem = new System.Windows.Forms.ComboBox();
            this.label162 = new System.Windows.Forms.Label();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.bt_gb_kill = new System.Windows.Forms.Button();
            this.txt_gb_kill_pwd = new System.Windows.Forms.TextBox();
            this.label163 = new System.Windows.Forms.Label();
            this.groupBox46 = new System.Windows.Forms.GroupBox();
            this.txt_gb_maskdata = new System.Windows.Forms.TextBox();
            this.label164 = new System.Windows.Forms.Label();
            this.txt_gb_mask_startaddr = new System.Windows.Forms.TextBox();
            this.label165 = new System.Windows.Forms.Label();
            this.cbb_gb_masktype = new System.Windows.Forms.ComboBox();
            this.label166 = new System.Windows.Forms.Label();
            this.chk_gb_mask = new System.Windows.Forms.CheckBox();
            this.lxLed_gb_number = new LxControl.LxLedControl();
            this.label167 = new System.Windows.Forms.Label();
            this.lxLed_gb_time = new LxControl.LxLedControl();
            this.label168 = new System.Windows.Forms.Label();
            this.groupBox54 = new System.Windows.Forms.GroupBox();
            this.dataGridView_GB = new System.Windows.Forms.DataGridView();
            this.gbp_gb_mix = new System.Windows.Forms.GroupBox();
            this.tx_gb_readpsd = new System.Windows.Forms.TextBox();
            this.label169 = new System.Windows.Forms.Label();
            this.tx_gb_masklen = new System.Windows.Forms.TextBox();
            this.label170 = new System.Windows.Forms.Label();
            this.tx_gb_maskaddr = new System.Windows.Forms.TextBox();
            this.label171 = new System.Windows.Forms.Label();
            this.cbb_gb_maskmem = new System.Windows.Forms.ComboBox();
            this.label172 = new System.Windows.Forms.Label();
            this.gbp_gb_ant = new System.Windows.Forms.GroupBox();
            this.chk_gbant16 = new System.Windows.Forms.CheckBox();
            this.chk_gbant15 = new System.Windows.Forms.CheckBox();
            this.chk_gbant14 = new System.Windows.Forms.CheckBox();
            this.chk_gbant13 = new System.Windows.Forms.CheckBox();
            this.chk_gbant12 = new System.Windows.Forms.CheckBox();
            this.chk_gbant11 = new System.Windows.Forms.CheckBox();
            this.chk_gbant10 = new System.Windows.Forms.CheckBox();
            this.chk_gbant9 = new System.Windows.Forms.CheckBox();
            this.chk_gbant8 = new System.Windows.Forms.CheckBox();
            this.chk_gbant7 = new System.Windows.Forms.CheckBox();
            this.chk_gbant6 = new System.Windows.Forms.CheckBox();
            this.chk_gbant5 = new System.Windows.Forms.CheckBox();
            this.chk_gbant4 = new System.Windows.Forms.CheckBox();
            this.chk_gbant3 = new System.Windows.Forms.CheckBox();
            this.chk_gbant2 = new System.Windows.Forms.CheckBox();
            this.chk_gbant1 = new System.Windows.Forms.CheckBox();
            this.groupBox55 = new System.Windows.Forms.GroupBox();
            this.cbb_gb_scantime = new System.Windows.Forms.ComboBox();
            this.label173 = new System.Windows.Forms.Label();
            this.rb_gb_normal = new System.Windows.Forms.RadioButton();
            this.rb_gb_mix = new System.Windows.Forms.RadioButton();
            this.btInventoryGB = new System.Windows.Forms.Button();
            this.Main_Page3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.text_Statu6B = new System.Windows.Forms.TextBox();
            this.btCheckLock6B = new System.Windows.Forms.Button();
            this.btLock6B = new System.Windows.Forms.Button();
            this.text_checkaddr = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.text_lock6b = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.text_W6B = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.btWrite6B = new System.Windows.Forms.Button();
            this.text_W6BLen = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.text_W6BAddr = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.text_R6B = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btRead6B = new System.Windows.Forms.Button();
            this.text_R6BLen = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.text_R6BAddr = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.text_6BUID = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.ListView_ID_6B = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.rb_mutiple = new System.Windows.Forms.RadioButton();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.btInventory6B = new System.Windows.Forms.Button();
            this.Main_Page4 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DeviceListView = new System.Windows.Forms.ListView();
            this.deviceName = new System.Windows.Forms.ColumnHeader();
            this.deviceIP = new System.Windows.Forms.ColumnHeader();
            this.deviceMac = new System.Windows.Forms.ColumnHeader();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.iEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoadDefault = new System.Windows.Forms.Button();
            this.groupBox51 = new System.Windows.Forms.GroupBox();
            this.btGetNet = new System.Windows.Forms.Button();
            this.btSetNet = new System.Windows.Forms.Button();
            this.label110 = new System.Windows.Forms.Label();
            this.macTB = new System.Windows.Forms.TextBox();
            this.panel_StaticIp = new System.Windows.Forms.Panel();
            this.label109 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.altDNSTB = new System.Windows.Forms.TextBox();
            this.pDNSTB = new System.Windows.Forms.TextBox();
            this.gatewayTB = new System.Windows.Forms.TextBox();
            this.subnetTB = new System.Windows.Forms.TextBox();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.groupBox50 = new System.Windows.Forms.GroupBox();
            this.btGetCnt = new System.Windows.Forms.Button();
            this.btSetCnt = new System.Windows.Forms.Button();
            this.panel_TCP = new System.Windows.Forms.Panel();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.workasCB = new System.Windows.Forms.ComboBox();
            this.tcpRomteHostTB = new System.Windows.Forms.TextBox();
            this.tcpRemotePortNUD = new System.Windows.Forms.NumericUpDown();
            this.tcpLocalPortNUD = new System.Windows.Forms.NumericUpDown();
            this.tcpActiveCB = new System.Windows.Forms.ComboBox();
            this.groupBox49 = new System.Windows.Forms.GroupBox();
            this.btGetSeriaPort = new System.Windows.Forms.Button();
            this.btSetSerialPort = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.protocolCB = new System.Windows.Forms.ComboBox();
            this.stopbitCB = new System.Windows.Forms.ComboBox();
            this.parityCB = new System.Windows.Forms.ComboBox();
            this.databitCB = new System.Windows.Forms.ComboBox();
            this.baudrateCB = new System.Windows.Forms.ComboBox();
            this.flowCB = new System.Windows.Forms.ComboBox();
            this.fifoCB = new System.Windows.Forms.ComboBox();
            this.groupBox47 = new System.Windows.Forms.GroupBox();
            this.btExitAT = new System.Windows.Forms.Button();
            this.btGotoAT = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label63 = new System.Windows.Forms.Label();
            this.stcprecv = new CustomControl.LogRichTextBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.listtcp = new System.Windows.Forms.ListBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btListen = new System.Windows.Forms.Button();
            this.stcpport = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.bttcpdisconnect = new System.Windows.Forms.Button();
            this.bttcpconnect = new System.Windows.Forms.Button();
            this.remotePort = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.tcpremoteIp = new CustomControl.IpAddressTextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.bttcpsend = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.ctctsend = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.ctctrecv = new CustomControl.LogRichTextBox();
            this.btFlashCl = new System.Windows.Forms.Button();
            this.timer_answer = new System.Windows.Forms.Timer(this.components);
            this.timer_runmode = new System.Windows.Forms.Timer(this.components);
            this.timer_EAS = new System.Windows.Forms.Timer(this.components);
            this.Timer_Test_6B = new System.Windows.Forms.Timer(this.components);
            this.timer_Buff = new System.Windows.Forms.Timer(this.components);
            this.timer_RealTime = new System.Windows.Forms.Timer(this.components);
            this.ckClearOperationRec = new System.Windows.Forms.CheckBox();
            this.checkBox_U9 = new System.Windows.Forms.CheckBox();
            this.Maintab.SuspendLayout();
            this.Main_Page1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Basic.SuspendLayout();
            this.gbReturnLoss.SuspendLayout();
            this.gbCmdTemperature.SuspendLayout();
            this.gbp_DRM.SuspendLayout();
            this.gbp_Retry.SuspendLayout();
            this.gbp_wpower.SuspendLayout();
            this.group_maxtime.SuspendLayout();
            this.gbp_buff.SuspendLayout();
            this.gpb_antconfig.SuspendLayout();
            this.gpb_checkant.SuspendLayout();
            this.gpb_GPIO.SuspendLayout();
            this.gpb_OutputRep.SuspendLayout();
            this.gpb_Relay.SuspendLayout();
            this.gpb_baud.SuspendLayout();
            this.gpb_DBM.SuspendLayout();
            this.gpb_Freq.SuspendLayout();
            this.gpb_beep.SuspendLayout();
            this.gpb_RDVersion.SuspendLayout();
            this.gpb_MDVersion.SuspendLayout();
            this.gpb_Serial.SuspendLayout();
            this.gpb_address.SuspendLayout();
            this.gpb_tcp.SuspendLayout();
            this.gpb_rs232.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Mx.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbp_trigger.SuspendLayout();
            this.groupBox43.SuspendLayout();
            this.groupBox44.SuspendLayout();
            this.groupBox37.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.gbp_tagType.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.gbp_Response.SuspendLayout();
            this.gbp_mask.SuspendLayout();
            this.gbp_EASAcc.SuspendLayout();
            this.tabPage_Module.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.panel11.SuspendLayout();
            this.groupBox58.SuspendLayout();
            this.groupBox57.SuspendLayout();
            this.groupBox45.SuspendLayout();
            this.gbp_PowerAnt.SuspendLayout();
            this.Main_Page2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage_answer.SuspendLayout();
            this.chk_phase.SuspendLayout();
            this.group_ant1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).BeginInit();
            this.gbp_MixRead.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_active.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_toltime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_toltag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_cmdsud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Num)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage_Realtime.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox41.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtag)).BeginInit();
            this.groupBox42.SuspendLayout();
            this.tabPage_Buff.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_cmdTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Bcmdsud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_BNum)).BeginInit();
            this.tabPage_fastscan.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox59.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl8)).BeginInit();
            this.groupBox60.SuspendLayout();
            this.tabPage_RW.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox40.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.Main_Page5.SuspendLayout();
            this.panel_jb.SuspendLayout();
            this.group_jbant.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox53.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_jb_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_jb_time)).BeginInit();
            this.groupBox52.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_JB)).BeginInit();
            this.gbp_jb_mix.SuspendLayout();
            this.groupBox48.SuspendLayout();
            this.Main_Page6.SuspendLayout();
            this.panel_gb.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.groupBox46.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_gb_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_gb_time)).BeginInit();
            this.groupBox54.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GB)).BeginInit();
            this.gbp_gb_mix.SuspendLayout();
            this.gbp_gb_ant.SuspendLayout();
            this.groupBox55.SuspendLayout();
            this.Main_Page3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.Main_Page4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox51.SuspendLayout();
            this.panel_StaticIp.SuspendLayout();
            this.groupBox50.SuspendLayout();
            this.panel_TCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcpRemotePortNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcpLocalPortNUD)).BeginInit();
            this.groupBox49.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox47.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.SuspendLayout();
            // 
            // lrtxtLog
            // 
            this.lrtxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lrtxtLog.EnableAutoDragDrop = true;
            this.lrtxtLog.Location = new System.Drawing.Point(-1, 632);
            this.lrtxtLog.Name = "lrtxtLog";
            this.lrtxtLog.Size = new System.Drawing.Size(1080, 89);
            this.lrtxtLog.TabIndex = 0;
            this.lrtxtLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operation records:";
            // 
            // Maintab
            // 
            this.Maintab.Controls.Add(this.Main_Page1);
            this.Maintab.Controls.Add(this.Main_Page2);
            this.Maintab.Controls.Add(this.Main_Page5);
            this.Maintab.Controls.Add(this.Main_Page6);
            this.Maintab.Controls.Add(this.Main_Page3);
            this.Maintab.Controls.Add(this.Main_Page4);
            this.Maintab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Maintab.ItemSize = new System.Drawing.Size(72, 23);
            this.Maintab.Location = new System.Drawing.Point(0, 0);
            this.Maintab.Multiline = true;
            this.Maintab.Name = "Maintab";
            this.Maintab.SelectedIndex = 0;
            this.Maintab.Size = new System.Drawing.Size(1083, 602);
            this.Maintab.TabIndex = 3;
            this.Maintab.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Maintab_Selecting);
            this.Maintab.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // Main_Page1
            // 
            this.Main_Page1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_Page1.Controls.Add(this.tabControl1);
            this.Main_Page1.Location = new System.Drawing.Point(4, 27);
            this.Main_Page1.Name = "Main_Page1";
            this.Main_Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page1.Size = new System.Drawing.Size(1075, 571);
            this.Main_Page1.TabIndex = 0;
            this.Main_Page1.Text = "Reader Setting";
            this.Main_Page1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Basic);
            this.tabControl1.Controls.Add(this.tabPage_Mx);
            this.tabControl1.Controls.Add(this.tabPage_Module);
            this.tabControl1.Controls.Add(this.tabPage15);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(84, 23);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 568);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // tabPage_Basic
            // 
            this.tabPage_Basic.Controls.Add(this.gbReturnLoss);
            this.tabPage_Basic.Controls.Add(this.gbCmdTemperature);
            this.tabPage_Basic.Controls.Add(this.gbp_DRM);
            this.tabPage_Basic.Controls.Add(this.gbp_Retry);
            this.tabPage_Basic.Controls.Add(this.gbp_wpower);
            this.tabPage_Basic.Controls.Add(this.group_maxtime);
            this.tabPage_Basic.Controls.Add(this.gbp_buff);
            this.tabPage_Basic.Controls.Add(this.btGetInformation);
            this.tabPage_Basic.Controls.Add(this.btDefault);
            this.tabPage_Basic.Controls.Add(this.btFlashROM);
            this.tabPage_Basic.Controls.Add(this.gpb_antconfig);
            this.tabPage_Basic.Controls.Add(this.gpb_checkant);
            this.tabPage_Basic.Controls.Add(this.gpb_GPIO);
            this.tabPage_Basic.Controls.Add(this.gpb_OutputRep);
            this.tabPage_Basic.Controls.Add(this.gpb_Relay);
            this.tabPage_Basic.Controls.Add(this.gpb_baud);
            this.tabPage_Basic.Controls.Add(this.gpb_DBM);
            this.tabPage_Basic.Controls.Add(this.gpb_Freq);
            this.tabPage_Basic.Controls.Add(this.gpb_beep);
            this.tabPage_Basic.Controls.Add(this.gpb_RDVersion);
            this.tabPage_Basic.Controls.Add(this.gpb_MDVersion);
            this.tabPage_Basic.Controls.Add(this.gpb_Serial);
            this.tabPage_Basic.Controls.Add(this.gpb_address);
            this.tabPage_Basic.Controls.Add(this.gpb_tcp);
            this.tabPage_Basic.Controls.Add(this.gpb_rs232);
            this.tabPage_Basic.Controls.Add(this.groupBox1);
            this.tabPage_Basic.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Basic.Name = "tabPage_Basic";
            this.tabPage_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Basic.Size = new System.Drawing.Size(1057, 537);
            this.tabPage_Basic.TabIndex = 0;
            this.tabPage_Basic.Text = "Basic";
            this.tabPage_Basic.UseVisualStyleBackColor = true;
            // 
            // gbReturnLoss
            // 
            this.gbReturnLoss.BackColor = System.Drawing.Color.Transparent;
            this.gbReturnLoss.Controls.Add(this.cbbAnt);
            this.gbReturnLoss.Controls.Add(this.label120);
            this.gbReturnLoss.Controls.Add(this.label121);
            this.gbReturnLoss.Controls.Add(this.cmbReturnLossFreq);
            this.gbReturnLoss.Controls.Add(this.label122);
            this.gbReturnLoss.Controls.Add(this.textReturnLoss);
            this.gbReturnLoss.Controls.Add(this.btReturnLoss);
            this.gbReturnLoss.ForeColor = System.Drawing.Color.Black;
            this.gbReturnLoss.Location = new System.Drawing.Point(704, 317);
            this.gbReturnLoss.Name = "gbReturnLoss";
            this.gbReturnLoss.Size = new System.Drawing.Size(341, 46);
            this.gbReturnLoss.TabIndex = 77;
            this.gbReturnLoss.TabStop = false;
            this.gbReturnLoss.Text = "Measuring antenna ports Return Loss";
            // 
            // cbbAnt
            // 
            this.cbbAnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnt.FormattingEnabled = true;
            this.cbbAnt.Items.AddRange(new object[] {
            "ANT1",
            "ANT2",
            "ANT3",
            "ANT4"});
            this.cbbAnt.Location = new System.Drawing.Point(198, 18);
            this.cbbAnt.Name = "cbbAnt";
            this.cbbAnt.Size = new System.Drawing.Size(70, 20);
            this.cbbAnt.TabIndex = 16;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(86, 22);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(11, 12);
            this.label120.TabIndex = 15;
            this.label120.Text = "@";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(170, 22);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(23, 12);
            this.label121.TabIndex = 14;
            this.label121.Text = "MHz";
            // 
            // cmbReturnLossFreq
            // 
            this.cmbReturnLossFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnLossFreq.FormattingEnabled = true;
            this.cmbReturnLossFreq.Location = new System.Drawing.Point(97, 18);
            this.cmbReturnLossFreq.Name = "cmbReturnLossFreq";
            this.cmbReturnLossFreq.Size = new System.Drawing.Size(71, 20);
            this.cmbReturnLossFreq.TabIndex = 13;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(11, 22);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(23, 12);
            this.label122.TabIndex = 12;
            this.label122.Text = "RL:";
            // 
            // textReturnLoss
            // 
            this.textReturnLoss.Location = new System.Drawing.Point(40, 18);
            this.textReturnLoss.Name = "textReturnLoss";
            this.textReturnLoss.ReadOnly = true;
            this.textReturnLoss.Size = new System.Drawing.Size(44, 21);
            this.textReturnLoss.TabIndex = 11;
            this.textReturnLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btReturnLoss
            // 
            this.btReturnLoss.Location = new System.Drawing.Point(276, 15);
            this.btReturnLoss.Name = "btReturnLoss";
            this.btReturnLoss.Size = new System.Drawing.Size(55, 23);
            this.btReturnLoss.TabIndex = 10;
            this.btReturnLoss.Text = "Get";
            this.btReturnLoss.UseVisualStyleBackColor = true;
            this.btReturnLoss.Click += new System.EventHandler(this.btReturnLoss_Click);
            // 
            // gbCmdTemperature
            // 
            this.gbCmdTemperature.Controls.Add(this.btnGetReaderTemperature);
            this.gbCmdTemperature.Controls.Add(this.txtReaderTemperature);
            this.gbCmdTemperature.ForeColor = System.Drawing.Color.Black;
            this.gbCmdTemperature.Location = new System.Drawing.Point(702, 261);
            this.gbCmdTemperature.Name = "gbCmdTemperature";
            this.gbCmdTemperature.Size = new System.Drawing.Size(342, 49);
            this.gbCmdTemperature.TabIndex = 76;
            this.gbCmdTemperature.TabStop = false;
            this.gbCmdTemperature.Text = "Working temperature monitoring";
            // 
            // btnGetReaderTemperature
            // 
            this.btnGetReaderTemperature.Location = new System.Drawing.Point(233, 18);
            this.btnGetReaderTemperature.Name = "btnGetReaderTemperature";
            this.btnGetReaderTemperature.Size = new System.Drawing.Size(90, 23);
            this.btnGetReaderTemperature.TabIndex = 0;
            this.btnGetReaderTemperature.Text = "Get";
            this.btnGetReaderTemperature.UseVisualStyleBackColor = true;
            this.btnGetReaderTemperature.Click += new System.EventHandler(this.btnGetReaderTemperature_Click);
            // 
            // txtReaderTemperature
            // 
            this.txtReaderTemperature.Location = new System.Drawing.Point(6, 20);
            this.txtReaderTemperature.Name = "txtReaderTemperature";
            this.txtReaderTemperature.ReadOnly = true;
            this.txtReaderTemperature.Size = new System.Drawing.Size(120, 21);
            this.txtReaderTemperature.TabIndex = 1;
            this.txtReaderTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbp_DRM
            // 
            this.gbp_DRM.Controls.Add(this.DRM_CLOSE);
            this.gbp_DRM.Controls.Add(this.DRM_OPEN);
            this.gbp_DRM.Controls.Add(this.bt_GetDRM);
            this.gbp_DRM.Controls.Add(this.bt_setDRM);
            this.gbp_DRM.Location = new System.Drawing.Point(705, 420);
            this.gbp_DRM.Name = "gbp_DRM";
            this.gbp_DRM.Size = new System.Drawing.Size(343, 48);
            this.gbp_DRM.TabIndex = 75;
            this.gbp_DRM.TabStop = false;
            this.gbp_DRM.Text = "DRM";
            // 
            // DRM_CLOSE
            // 
            this.DRM_CLOSE.AutoSize = true;
            this.DRM_CLOSE.Location = new System.Drawing.Point(86, 20);
            this.DRM_CLOSE.Name = "DRM_CLOSE";
            this.DRM_CLOSE.Size = new System.Drawing.Size(65, 16);
            this.DRM_CLOSE.TabIndex = 12;
            this.DRM_CLOSE.Text = "Disable";
            this.DRM_CLOSE.UseVisualStyleBackColor = true;
            // 
            // DRM_OPEN
            // 
            this.DRM_OPEN.AutoSize = true;
            this.DRM_OPEN.Location = new System.Drawing.Point(13, 20);
            this.DRM_OPEN.Name = "DRM_OPEN";
            this.DRM_OPEN.Size = new System.Drawing.Size(59, 16);
            this.DRM_OPEN.TabIndex = 11;
            this.DRM_OPEN.Text = "Enable";
            this.DRM_OPEN.UseVisualStyleBackColor = true;
            // 
            // bt_GetDRM
            // 
            this.bt_GetDRM.Location = new System.Drawing.Point(247, 17);
            this.bt_GetDRM.Name = "bt_GetDRM";
            this.bt_GetDRM.Size = new System.Drawing.Size(77, 23);
            this.bt_GetDRM.TabIndex = 9;
            this.bt_GetDRM.Text = "Get";
            this.bt_GetDRM.UseVisualStyleBackColor = true;
            this.bt_GetDRM.Click += new System.EventHandler(this.bt_GetDRM_Click);
            // 
            // bt_setDRM
            // 
            this.bt_setDRM.Location = new System.Drawing.Point(158, 17);
            this.bt_setDRM.Name = "bt_setDRM";
            this.bt_setDRM.Size = new System.Drawing.Size(77, 23);
            this.bt_setDRM.TabIndex = 8;
            this.bt_setDRM.Text = "Set";
            this.bt_setDRM.UseVisualStyleBackColor = true;
            this.bt_setDRM.Click += new System.EventHandler(this.bt_setDRM_Click);
            // 
            // gbp_Retry
            // 
            this.gbp_Retry.Controls.Add(this.com_retrytimes);
            this.gbp_Retry.Controls.Add(this.bt_Getretry);
            this.gbp_Retry.Controls.Add(this.bt_Setretry);
            this.gbp_Retry.Location = new System.Drawing.Point(704, 367);
            this.gbp_Retry.Name = "gbp_Retry";
            this.gbp_Retry.Size = new System.Drawing.Size(343, 48);
            this.gbp_Retry.TabIndex = 74;
            this.gbp_Retry.TabStop = false;
            this.gbp_Retry.Text = "Retry write times set and get";
            // 
            // com_retrytimes
            // 
            this.com_retrytimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_retrytimes.FormattingEnabled = true;
            this.com_retrytimes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.com_retrytimes.Location = new System.Drawing.Point(14, 19);
            this.com_retrytimes.Name = "com_retrytimes";
            this.com_retrytimes.Size = new System.Drawing.Size(100, 20);
            this.com_retrytimes.TabIndex = 26;
            // 
            // bt_Getretry
            // 
            this.bt_Getretry.Location = new System.Drawing.Point(247, 17);
            this.bt_Getretry.Name = "bt_Getretry";
            this.bt_Getretry.Size = new System.Drawing.Size(77, 23);
            this.bt_Getretry.TabIndex = 9;
            this.bt_Getretry.Text = "Get";
            this.bt_Getretry.UseVisualStyleBackColor = true;
            this.bt_Getretry.Click += new System.EventHandler(this.bt_Getretry_Click);
            // 
            // bt_Setretry
            // 
            this.bt_Setretry.Location = new System.Drawing.Point(158, 17);
            this.bt_Setretry.Name = "bt_Setretry";
            this.bt_Setretry.Size = new System.Drawing.Size(77, 23);
            this.bt_Setretry.TabIndex = 8;
            this.bt_Setretry.Text = "Set";
            this.bt_Setretry.UseVisualStyleBackColor = true;
            this.bt_Setretry.Click += new System.EventHandler(this.bt_Setretry_Click);
            // 
            // gbp_wpower
            // 
            this.gbp_wpower.Controls.Add(this.label112);
            this.gbp_wpower.Controls.Add(this.com_wpower);
            this.gbp_wpower.Controls.Add(this.rb_wp2);
            this.gbp_wpower.Controls.Add(this.rb_wp1);
            this.gbp_wpower.Controls.Add(this.bt_GetWpower);
            this.gbp_wpower.Controls.Add(this.bt_SetWpower);
            this.gbp_wpower.Location = new System.Drawing.Point(6, 392);
            this.gbp_wpower.Name = "gbp_wpower";
            this.gbp_wpower.Size = new System.Drawing.Size(343, 68);
            this.gbp_wpower.TabIndex = 73;
            this.gbp_wpower.TabStop = false;
            this.gbp_wpower.Text = "Write Power Set and get";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(120, 44);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(23, 12);
            this.label112.TabIndex = 27;
            this.label112.Text = "dBm";
            // 
            // com_wpower
            // 
            this.com_wpower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_wpower.FormattingEnabled = true;
            this.com_wpower.Items.AddRange(new object[] {
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
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33"});
            this.com_wpower.Location = new System.Drawing.Point(14, 41);
            this.com_wpower.Name = "com_wpower";
            this.com_wpower.Size = new System.Drawing.Size(100, 20);
            this.com_wpower.TabIndex = 26;
            // 
            // rb_wp2
            // 
            this.rb_wp2.AutoSize = true;
            this.rb_wp2.Location = new System.Drawing.Point(157, 18);
            this.rb_wp2.Name = "rb_wp2";
            this.rb_wp2.Size = new System.Drawing.Size(59, 16);
            this.rb_wp2.TabIndex = 11;
            this.rb_wp2.Text = "Enable";
            this.rb_wp2.UseVisualStyleBackColor = true;
            // 
            // rb_wp1
            // 
            this.rb_wp1.AutoSize = true;
            this.rb_wp1.Checked = true;
            this.rb_wp1.Location = new System.Drawing.Point(15, 18);
            this.rb_wp1.Name = "rb_wp1";
            this.rb_wp1.Size = new System.Drawing.Size(65, 16);
            this.rb_wp1.TabIndex = 10;
            this.rb_wp1.TabStop = true;
            this.rb_wp1.Text = "Disable";
            this.rb_wp1.UseVisualStyleBackColor = true;
            // 
            // bt_GetWpower
            // 
            this.bt_GetWpower.Location = new System.Drawing.Point(247, 39);
            this.bt_GetWpower.Name = "bt_GetWpower";
            this.bt_GetWpower.Size = new System.Drawing.Size(77, 23);
            this.bt_GetWpower.TabIndex = 9;
            this.bt_GetWpower.Text = "Get";
            this.bt_GetWpower.UseVisualStyleBackColor = true;
            this.bt_GetWpower.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_SetWpower
            // 
            this.bt_SetWpower.Location = new System.Drawing.Point(158, 39);
            this.bt_SetWpower.Name = "bt_SetWpower";
            this.bt_SetWpower.Size = new System.Drawing.Size(77, 23);
            this.bt_SetWpower.TabIndex = 8;
            this.bt_SetWpower.Text = "Set";
            this.bt_SetWpower.UseVisualStyleBackColor = true;
            this.bt_SetWpower.Click += new System.EventHandler(this.button2_Click);
            // 
            // group_maxtime
            // 
            this.group_maxtime.Controls.Add(this.comboBox_maxtime);
            this.group_maxtime.Controls.Add(this.btSetMaxtime);
            this.group_maxtime.Location = new System.Drawing.Point(6, 290);
            this.group_maxtime.Name = "group_maxtime";
            this.group_maxtime.Size = new System.Drawing.Size(342, 41);
            this.group_maxtime.TabIndex = 72;
            this.group_maxtime.TabStop = false;
            this.group_maxtime.Text = "Max inventory time";
            // 
            // comboBox_maxtime
            // 
            this.comboBox_maxtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_maxtime.FormattingEnabled = true;
            this.comboBox_maxtime.Location = new System.Drawing.Point(94, 15);
            this.comboBox_maxtime.Name = "comboBox_maxtime";
            this.comboBox_maxtime.Size = new System.Drawing.Size(122, 20);
            this.comboBox_maxtime.TabIndex = 26;
            // 
            // btSetMaxtime
            // 
            this.btSetMaxtime.Location = new System.Drawing.Point(233, 14);
            this.btSetMaxtime.Name = "btSetMaxtime";
            this.btSetMaxtime.Size = new System.Drawing.Size(90, 23);
            this.btSetMaxtime.TabIndex = 23;
            this.btSetMaxtime.Text = "Set";
            this.btSetMaxtime.UseVisualStyleBackColor = true;
            this.btSetMaxtime.Click += new System.EventHandler(this.btSetMaxtime_Click);
            // 
            // gbp_buff
            // 
            this.gbp_buff.Controls.Add(this.rb496);
            this.gbp_buff.Controls.Add(this.rb128);
            this.gbp_buff.Controls.Add(this.btGetEPCandTIDLen);
            this.gbp_buff.Controls.Add(this.btSetEPCandTIDLen);
            this.gbp_buff.Location = new System.Drawing.Point(5, 335);
            this.gbp_buff.Name = "gbp_buff";
            this.gbp_buff.Size = new System.Drawing.Size(343, 55);
            this.gbp_buff.TabIndex = 71;
            this.gbp_buff.TabStop = false;
            this.gbp_buff.Text = "Saved EPC/TID length";
            // 
            // rb496
            // 
            this.rb496.AutoSize = true;
            this.rb496.Location = new System.Drawing.Point(93, 25);
            this.rb496.Name = "rb496";
            this.rb496.Size = new System.Drawing.Size(59, 16);
            this.rb496.TabIndex = 11;
            this.rb496.Text = "496bit";
            this.rb496.UseVisualStyleBackColor = true;
            // 
            // rb128
            // 
            this.rb128.AutoSize = true;
            this.rb128.Checked = true;
            this.rb128.Location = new System.Drawing.Point(15, 25);
            this.rb128.Name = "rb128";
            this.rb128.Size = new System.Drawing.Size(59, 16);
            this.rb128.TabIndex = 10;
            this.rb128.TabStop = true;
            this.rb128.Text = "128bit";
            this.rb128.UseVisualStyleBackColor = true;
            // 
            // btGetEPCandTIDLen
            // 
            this.btGetEPCandTIDLen.Location = new System.Drawing.Point(247, 22);
            this.btGetEPCandTIDLen.Name = "btGetEPCandTIDLen";
            this.btGetEPCandTIDLen.Size = new System.Drawing.Size(77, 23);
            this.btGetEPCandTIDLen.TabIndex = 9;
            this.btGetEPCandTIDLen.Text = "Get";
            this.btGetEPCandTIDLen.UseVisualStyleBackColor = true;
            this.btGetEPCandTIDLen.Click += new System.EventHandler(this.btGetEPCandTIDLen_Click);
            // 
            // btSetEPCandTIDLen
            // 
            this.btSetEPCandTIDLen.Location = new System.Drawing.Point(158, 22);
            this.btSetEPCandTIDLen.Name = "btSetEPCandTIDLen";
            this.btSetEPCandTIDLen.Size = new System.Drawing.Size(77, 23);
            this.btSetEPCandTIDLen.TabIndex = 8;
            this.btSetEPCandTIDLen.Text = "Set";
            this.btSetEPCandTIDLen.UseVisualStyleBackColor = true;
            this.btSetEPCandTIDLen.Click += new System.EventHandler(this.btSetEPCandTIDLen_Click);
            // 
            // btGetInformation
            // 
            this.btGetInformation.Location = new System.Drawing.Point(780, 488);
            this.btGetInformation.Name = "btGetInformation";
            this.btGetInformation.Size = new System.Drawing.Size(129, 43);
            this.btGetInformation.TabIndex = 58;
            this.btGetInformation.Text = "Get reader information";
            this.btGetInformation.UseVisualStyleBackColor = true;
            this.btGetInformation.Click += new System.EventHandler(this.btGetInformation_Click);
            // 
            // btDefault
            // 
            this.btDefault.Location = new System.Drawing.Point(915, 488);
            this.btDefault.Name = "btDefault";
            this.btDefault.Size = new System.Drawing.Size(130, 43);
            this.btDefault.TabIndex = 57;
            this.btDefault.Text = "Default setting";
            this.btDefault.UseVisualStyleBackColor = true;
            this.btDefault.Click += new System.EventHandler(this.btDefault_Click);
            // 
            // btFlashROM
            // 
            this.btFlashROM.Location = new System.Drawing.Point(355, 578);
            this.btFlashROM.Name = "btFlashROM";
            this.btFlashROM.Size = new System.Drawing.Size(169, 43);
            this.btFlashROM.TabIndex = 56;
            this.btFlashROM.Text = "切换至R2000模块升级模式";
            this.btFlashROM.UseVisualStyleBackColor = true;
            this.btFlashROM.Click += new System.EventHandler(this.btFlashROM_Click);
            // 
            // gpb_antconfig
            // 
            this.gpb_antconfig.Controls.Add(this.checkBox2);
            this.gpb_antconfig.Controls.Add(this.checkant16);
            this.gpb_antconfig.Controls.Add(this.checkant15);
            this.gpb_antconfig.Controls.Add(this.checkant14);
            this.gpb_antconfig.Controls.Add(this.checkant13);
            this.gpb_antconfig.Controls.Add(this.checkant12);
            this.gpb_antconfig.Controls.Add(this.checkant11);
            this.gpb_antconfig.Controls.Add(this.checkant10);
            this.gpb_antconfig.Controls.Add(this.checkant9);
            this.gpb_antconfig.Controls.Add(this.checkant8);
            this.gpb_antconfig.Controls.Add(this.checkant7);
            this.gpb_antconfig.Controls.Add(this.checkant6);
            this.gpb_antconfig.Controls.Add(this.checkant5);
            this.gpb_antconfig.Controls.Add(this.Button_Ant);
            this.gpb_antconfig.Controls.Add(this.checkant4);
            this.gpb_antconfig.Controls.Add(this.checkant3);
            this.gpb_antconfig.Controls.Add(this.checkant2);
            this.gpb_antconfig.Controls.Add(this.checkant1);
            this.gpb_antconfig.Location = new System.Drawing.Point(354, 312);
            this.gpb_antconfig.Name = "gpb_antconfig";
            this.gpb_antconfig.Size = new System.Drawing.Size(342, 148);
            this.gpb_antconfig.TabIndex = 54;
            this.gpb_antconfig.TabStop = false;
            this.gpb_antconfig.Text = "Antenna config";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(145, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 16);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Saved";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkant16
            // 
            this.checkant16.AutoSize = true;
            this.checkant16.Location = new System.Drawing.Point(269, 121);
            this.checkant16.Name = "checkant16";
            this.checkant16.Size = new System.Drawing.Size(54, 16);
            this.checkant16.TabIndex = 17;
            this.checkant16.Text = "ANT16";
            this.checkant16.UseVisualStyleBackColor = true;
            // 
            // checkant15
            // 
            this.checkant15.AutoSize = true;
            this.checkant15.Location = new System.Drawing.Point(192, 121);
            this.checkant15.Name = "checkant15";
            this.checkant15.Size = new System.Drawing.Size(54, 16);
            this.checkant15.TabIndex = 16;
            this.checkant15.Text = "ANT15";
            this.checkant15.UseVisualStyleBackColor = true;
            // 
            // checkant14
            // 
            this.checkant14.AutoSize = true;
            this.checkant14.Location = new System.Drawing.Point(95, 121);
            this.checkant14.Name = "checkant14";
            this.checkant14.Size = new System.Drawing.Size(54, 16);
            this.checkant14.TabIndex = 15;
            this.checkant14.Text = "ANT14";
            this.checkant14.UseVisualStyleBackColor = true;
            // 
            // checkant13
            // 
            this.checkant13.AutoSize = true;
            this.checkant13.Location = new System.Drawing.Point(8, 121);
            this.checkant13.Name = "checkant13";
            this.checkant13.Size = new System.Drawing.Size(54, 16);
            this.checkant13.TabIndex = 14;
            this.checkant13.Text = "ANT13";
            this.checkant13.UseVisualStyleBackColor = true;
            // 
            // checkant12
            // 
            this.checkant12.AutoSize = true;
            this.checkant12.Location = new System.Drawing.Point(269, 96);
            this.checkant12.Name = "checkant12";
            this.checkant12.Size = new System.Drawing.Size(54, 16);
            this.checkant12.TabIndex = 13;
            this.checkant12.Text = "ANT12";
            this.checkant12.UseVisualStyleBackColor = true;
            // 
            // checkant11
            // 
            this.checkant11.AutoSize = true;
            this.checkant11.Location = new System.Drawing.Point(192, 96);
            this.checkant11.Name = "checkant11";
            this.checkant11.Size = new System.Drawing.Size(54, 16);
            this.checkant11.TabIndex = 12;
            this.checkant11.Text = "ANT11";
            this.checkant11.UseVisualStyleBackColor = true;
            // 
            // checkant10
            // 
            this.checkant10.AutoSize = true;
            this.checkant10.Location = new System.Drawing.Point(95, 96);
            this.checkant10.Name = "checkant10";
            this.checkant10.Size = new System.Drawing.Size(54, 16);
            this.checkant10.TabIndex = 11;
            this.checkant10.Text = "ANT10";
            this.checkant10.UseVisualStyleBackColor = true;
            // 
            // checkant9
            // 
            this.checkant9.AutoSize = true;
            this.checkant9.Location = new System.Drawing.Point(8, 96);
            this.checkant9.Name = "checkant9";
            this.checkant9.Size = new System.Drawing.Size(48, 16);
            this.checkant9.TabIndex = 10;
            this.checkant9.Text = "ANT9";
            this.checkant9.UseVisualStyleBackColor = true;
            // 
            // checkant8
            // 
            this.checkant8.AutoSize = true;
            this.checkant8.Location = new System.Drawing.Point(269, 70);
            this.checkant8.Name = "checkant8";
            this.checkant8.Size = new System.Drawing.Size(48, 16);
            this.checkant8.TabIndex = 9;
            this.checkant8.Text = "ANT8";
            this.checkant8.UseVisualStyleBackColor = true;
            // 
            // checkant7
            // 
            this.checkant7.AutoSize = true;
            this.checkant7.Location = new System.Drawing.Point(192, 70);
            this.checkant7.Name = "checkant7";
            this.checkant7.Size = new System.Drawing.Size(48, 16);
            this.checkant7.TabIndex = 8;
            this.checkant7.Text = "ANT7";
            this.checkant7.UseVisualStyleBackColor = true;
            // 
            // checkant6
            // 
            this.checkant6.AutoSize = true;
            this.checkant6.Location = new System.Drawing.Point(95, 70);
            this.checkant6.Name = "checkant6";
            this.checkant6.Size = new System.Drawing.Size(48, 16);
            this.checkant6.TabIndex = 7;
            this.checkant6.Text = "ANT6";
            this.checkant6.UseVisualStyleBackColor = true;
            this.checkant6.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkant5
            // 
            this.checkant5.AutoSize = true;
            this.checkant5.Location = new System.Drawing.Point(8, 70);
            this.checkant5.Name = "checkant5";
            this.checkant5.Size = new System.Drawing.Size(48, 16);
            this.checkant5.TabIndex = 6;
            this.checkant5.Text = "ANT5";
            this.checkant5.UseVisualStyleBackColor = true;
            // 
            // Button_Ant
            // 
            this.Button_Ant.Location = new System.Drawing.Point(233, 16);
            this.Button_Ant.Name = "Button_Ant";
            this.Button_Ant.Size = new System.Drawing.Size(90, 23);
            this.Button_Ant.TabIndex = 5;
            this.Button_Ant.Text = "Set";
            this.Button_Ant.UseVisualStyleBackColor = true;
            this.Button_Ant.Click += new System.EventHandler(this.Button_Ant_Click);
            // 
            // checkant4
            // 
            this.checkant4.AutoSize = true;
            this.checkant4.Location = new System.Drawing.Point(269, 45);
            this.checkant4.Name = "checkant4";
            this.checkant4.Size = new System.Drawing.Size(48, 16);
            this.checkant4.TabIndex = 4;
            this.checkant4.Text = "ANT4";
            this.checkant4.UseVisualStyleBackColor = true;
            // 
            // checkant3
            // 
            this.checkant3.AutoSize = true;
            this.checkant3.Location = new System.Drawing.Point(192, 45);
            this.checkant3.Name = "checkant3";
            this.checkant3.Size = new System.Drawing.Size(48, 16);
            this.checkant3.TabIndex = 3;
            this.checkant3.Text = "ANT3";
            this.checkant3.UseVisualStyleBackColor = true;
            // 
            // checkant2
            // 
            this.checkant2.AutoSize = true;
            this.checkant2.Location = new System.Drawing.Point(95, 45);
            this.checkant2.Name = "checkant2";
            this.checkant2.Size = new System.Drawing.Size(48, 16);
            this.checkant2.TabIndex = 2;
            this.checkant2.Text = "ANT2";
            this.checkant2.UseVisualStyleBackColor = true;
            // 
            // checkant1
            // 
            this.checkant1.AutoSize = true;
            this.checkant1.Location = new System.Drawing.Point(8, 45);
            this.checkant1.Name = "checkant1";
            this.checkant1.Size = new System.Drawing.Size(48, 16);
            this.checkant1.TabIndex = 1;
            this.checkant1.Text = "ANT1";
            this.checkant1.UseVisualStyleBackColor = true;
            // 
            // gpb_checkant
            // 
            this.gpb_checkant.Controls.Add(this.btSetcheckant);
            this.gpb_checkant.Controls.Add(this.rb_Closecheckant);
            this.gpb_checkant.Controls.Add(this.rb_Opencheckant);
            this.gpb_checkant.Location = new System.Drawing.Point(354, 259);
            this.gpb_checkant.Name = "gpb_checkant";
            this.gpb_checkant.Size = new System.Drawing.Size(342, 51);
            this.gpb_checkant.TabIndex = 53;
            this.gpb_checkant.TabStop = false;
            this.gpb_checkant.Text = "Antenna checked";
            // 
            // btSetcheckant
            // 
            this.btSetcheckant.Location = new System.Drawing.Point(233, 19);
            this.btSetcheckant.Name = "btSetcheckant";
            this.btSetcheckant.Size = new System.Drawing.Size(90, 23);
            this.btSetcheckant.TabIndex = 2;
            this.btSetcheckant.Text = "Set";
            this.btSetcheckant.UseVisualStyleBackColor = true;
            this.btSetcheckant.Click += new System.EventHandler(this.btSetcheckant_Click);
            // 
            // rb_Closecheckant
            // 
            this.rb_Closecheckant.AutoSize = true;
            this.rb_Closecheckant.Location = new System.Drawing.Point(7, 32);
            this.rb_Closecheckant.Name = "rb_Closecheckant";
            this.rb_Closecheckant.Size = new System.Drawing.Size(173, 16);
            this.rb_Closecheckant.TabIndex = 1;
            this.rb_Closecheckant.Text = "Disable antenna detection";
            this.rb_Closecheckant.UseVisualStyleBackColor = true;
            // 
            // rb_Opencheckant
            // 
            this.rb_Opencheckant.AutoSize = true;
            this.rb_Opencheckant.Checked = true;
            this.rb_Opencheckant.Location = new System.Drawing.Point(7, 14);
            this.rb_Opencheckant.Name = "rb_Opencheckant";
            this.rb_Opencheckant.Size = new System.Drawing.Size(167, 16);
            this.rb_Opencheckant.TabIndex = 0;
            this.rb_Opencheckant.TabStop = true;
            this.rb_Opencheckant.Text = "Enable antenna detection";
            this.rb_Opencheckant.UseVisualStyleBackColor = true;
            // 
            // gpb_GPIO
            // 
            this.gpb_GPIO.Controls.Add(this.Button_GetGPIO);
            this.gpb_GPIO.Controls.Add(this.Button_SetGPIO);
            this.gpb_GPIO.Controls.Add(this.check_int4);
            this.gpb_GPIO.Controls.Add(this.check_int3);
            this.gpb_GPIO.Controls.Add(this.check_int2);
            this.gpb_GPIO.Controls.Add(this.check_int1);
            this.gpb_GPIO.Controls.Add(this.check_out4);
            this.gpb_GPIO.Controls.Add(this.check_out3);
            this.gpb_GPIO.Controls.Add(this.check_out2);
            this.gpb_GPIO.Controls.Add(this.check_out1);
            this.gpb_GPIO.Location = new System.Drawing.Point(354, 214);
            this.gpb_GPIO.Name = "gpb_GPIO";
            this.gpb_GPIO.Size = new System.Drawing.Size(693, 43);
            this.gpb_GPIO.TabIndex = 49;
            this.gpb_GPIO.TabStop = false;
            this.gpb_GPIO.Text = "GPIO Operation";
            // 
            // Button_GetGPIO
            // 
            this.Button_GetGPIO.Location = new System.Drawing.Point(585, 14);
            this.Button_GetGPIO.Name = "Button_GetGPIO";
            this.Button_GetGPIO.Size = new System.Drawing.Size(90, 23);
            this.Button_GetGPIO.TabIndex = 9;
            this.Button_GetGPIO.Text = "Get";
            this.Button_GetGPIO.UseVisualStyleBackColor = true;
            this.Button_GetGPIO.Click += new System.EventHandler(this.Button_GetGPIO_Click);
            // 
            // Button_SetGPIO
            // 
            this.Button_SetGPIO.Location = new System.Drawing.Point(483, 14);
            this.Button_SetGPIO.Name = "Button_SetGPIO";
            this.Button_SetGPIO.Size = new System.Drawing.Size(90, 23);
            this.Button_SetGPIO.TabIndex = 8;
            this.Button_SetGPIO.Text = "Set";
            this.Button_SetGPIO.UseVisualStyleBackColor = true;
            this.Button_SetGPIO.Click += new System.EventHandler(this.Button_SetGPIO_Click);
            // 
            // check_int4
            // 
            this.check_int4.AutoSize = true;
            this.check_int4.Enabled = false;
            this.check_int4.Location = new System.Drawing.Point(392, 18);
            this.check_int4.Name = "check_int4";
            this.check_int4.Size = new System.Drawing.Size(42, 16);
            this.check_int4.TabIndex = 7;
            this.check_int4.Text = "IN4";
            this.check_int4.UseVisualStyleBackColor = true;
            // 
            // check_int3
            // 
            this.check_int3.AutoSize = true;
            this.check_int3.Enabled = false;
            this.check_int3.Location = new System.Drawing.Point(338, 18);
            this.check_int3.Name = "check_int3";
            this.check_int3.Size = new System.Drawing.Size(42, 16);
            this.check_int3.TabIndex = 6;
            this.check_int3.Text = "IN3";
            this.check_int3.UseVisualStyleBackColor = true;
            // 
            // check_int2
            // 
            this.check_int2.AutoSize = true;
            this.check_int2.Enabled = false;
            this.check_int2.Location = new System.Drawing.Point(281, 18);
            this.check_int2.Name = "check_int2";
            this.check_int2.Size = new System.Drawing.Size(42, 16);
            this.check_int2.TabIndex = 5;
            this.check_int2.Text = "IN2";
            this.check_int2.UseVisualStyleBackColor = true;
            this.check_int2.CheckedChanged += new System.EventHandler(this.check_int2_CheckedChanged);
            // 
            // check_int1
            // 
            this.check_int1.AutoSize = true;
            this.check_int1.Enabled = false;
            this.check_int1.Location = new System.Drawing.Point(227, 18);
            this.check_int1.Name = "check_int1";
            this.check_int1.Size = new System.Drawing.Size(42, 16);
            this.check_int1.TabIndex = 4;
            this.check_int1.Text = "IN1";
            this.check_int1.UseVisualStyleBackColor = true;
            // 
            // check_out4
            // 
            this.check_out4.AutoSize = true;
            this.check_out4.Location = new System.Drawing.Point(170, 18);
            this.check_out4.Name = "check_out4";
            this.check_out4.Size = new System.Drawing.Size(48, 16);
            this.check_out4.TabIndex = 3;
            this.check_out4.Text = "OUT4";
            this.check_out4.UseVisualStyleBackColor = true;
            // 
            // check_out3
            // 
            this.check_out3.AutoSize = true;
            this.check_out3.Location = new System.Drawing.Point(116, 18);
            this.check_out3.Name = "check_out3";
            this.check_out3.Size = new System.Drawing.Size(48, 16);
            this.check_out3.TabIndex = 2;
            this.check_out3.Text = "OUT3";
            this.check_out3.UseVisualStyleBackColor = true;
            // 
            // check_out2
            // 
            this.check_out2.AutoSize = true;
            this.check_out2.Location = new System.Drawing.Point(62, 18);
            this.check_out2.Name = "check_out2";
            this.check_out2.Size = new System.Drawing.Size(48, 16);
            this.check_out2.TabIndex = 1;
            this.check_out2.Text = "OUT2";
            this.check_out2.UseVisualStyleBackColor = true;
            // 
            // check_out1
            // 
            this.check_out1.AutoSize = true;
            this.check_out1.Location = new System.Drawing.Point(8, 18);
            this.check_out1.Name = "check_out1";
            this.check_out1.Size = new System.Drawing.Size(48, 16);
            this.check_out1.TabIndex = 0;
            this.check_out1.Text = "OUT1";
            this.check_out1.UseVisualStyleBackColor = true;
            // 
            // gpb_OutputRep
            // 
            this.gpb_OutputRep.Controls.Add(this.btOutputRep);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep4);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep3);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep2);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep1);
            this.gpb_OutputRep.Location = new System.Drawing.Point(705, 174);
            this.gpb_OutputRep.Name = "gpb_OutputRep";
            this.gpb_OutputRep.Size = new System.Drawing.Size(342, 42);
            this.gpb_OutputRep.TabIndex = 48;
            this.gpb_OutputRep.TabStop = false;
            this.gpb_OutputRep.Text = "Set notification pluse output";
            // 
            // btOutputRep
            // 
            this.btOutputRep.Location = new System.Drawing.Point(234, 13);
            this.btOutputRep.Name = "btOutputRep";
            this.btOutputRep.Size = new System.Drawing.Size(90, 23);
            this.btOutputRep.TabIndex = 5;
            this.btOutputRep.Text = "Set";
            this.btOutputRep.UseVisualStyleBackColor = true;
            this.btOutputRep.Click += new System.EventHandler(this.btOutputRep_Click);
            // 
            // check_OutputRep4
            // 
            this.check_OutputRep4.AutoSize = true;
            this.check_OutputRep4.Location = new System.Drawing.Point(184, 16);
            this.check_OutputRep4.Name = "check_OutputRep4";
            this.check_OutputRep4.Size = new System.Drawing.Size(48, 16);
            this.check_OutputRep4.TabIndex = 4;
            this.check_OutputRep4.Text = "OUT4";
            this.check_OutputRep4.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep3
            // 
            this.check_OutputRep3.AutoSize = true;
            this.check_OutputRep3.Location = new System.Drawing.Point(125, 16);
            this.check_OutputRep3.Name = "check_OutputRep3";
            this.check_OutputRep3.Size = new System.Drawing.Size(48, 16);
            this.check_OutputRep3.TabIndex = 3;
            this.check_OutputRep3.Text = "OUT3";
            this.check_OutputRep3.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep2
            // 
            this.check_OutputRep2.AutoSize = true;
            this.check_OutputRep2.Location = new System.Drawing.Point(66, 16);
            this.check_OutputRep2.Name = "check_OutputRep2";
            this.check_OutputRep2.Size = new System.Drawing.Size(48, 16);
            this.check_OutputRep2.TabIndex = 2;
            this.check_OutputRep2.Text = "OUT2";
            this.check_OutputRep2.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep1
            // 
            this.check_OutputRep1.AutoSize = true;
            this.check_OutputRep1.Location = new System.Drawing.Point(8, 16);
            this.check_OutputRep1.Name = "check_OutputRep1";
            this.check_OutputRep1.Size = new System.Drawing.Size(48, 16);
            this.check_OutputRep1.TabIndex = 1;
            this.check_OutputRep1.Text = "OUT1";
            this.check_OutputRep1.UseVisualStyleBackColor = true;
            // 
            // gpb_Relay
            // 
            this.gpb_Relay.Controls.Add(this.label38);
            this.gpb_Relay.Controls.Add(this.ComboBox_RelayTime);
            this.gpb_Relay.Controls.Add(this.label37);
            this.gpb_Relay.Controls.Add(this.btRelay);
            this.gpb_Relay.Location = new System.Drawing.Point(354, 170);
            this.gpb_Relay.Name = "gpb_Relay";
            this.gpb_Relay.Size = new System.Drawing.Size(342, 42);
            this.gpb_Relay.TabIndex = 31;
            this.gpb_Relay.TabStop = false;
            this.gpb_Relay.Text = "Relay control";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(182, 18);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 12);
            this.label38.TabIndex = 26;
            this.label38.Text = "*50ms";
            // 
            // ComboBox_RelayTime
            // 
            this.ComboBox_RelayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_RelayTime.FormattingEnabled = true;
            this.ComboBox_RelayTime.Location = new System.Drawing.Point(82, 15);
            this.ComboBox_RelayTime.Name = "ComboBox_RelayTime";
            this.ComboBox_RelayTime.Size = new System.Drawing.Size(96, 20);
            this.ComboBox_RelayTime.TabIndex = 25;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(17, 19);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(83, 12);
            this.label37.TabIndex = 24;
            this.label37.Text = "Release time:";
            // 
            // btRelay
            // 
            this.btRelay.Location = new System.Drawing.Point(233, 13);
            this.btRelay.Name = "btRelay";
            this.btRelay.Size = new System.Drawing.Size(90, 23);
            this.btRelay.TabIndex = 23;
            this.btRelay.Text = "Set";
            this.btRelay.UseVisualStyleBackColor = true;
            this.btRelay.Click += new System.EventHandler(this.btRelay_Click);
            // 
            // gpb_baud
            // 
            this.gpb_baud.Controls.Add(this.ComboBox_baud);
            this.gpb_baud.Controls.Add(this.btBaudRate);
            this.gpb_baud.Location = new System.Drawing.Point(706, 123);
            this.gpb_baud.Name = "gpb_baud";
            this.gpb_baud.Size = new System.Drawing.Size(342, 45);
            this.gpb_baud.TabIndex = 30;
            this.gpb_baud.TabStop = false;
            this.gpb_baud.Text = "RS232/485 baud rate";
            // 
            // ComboBox_baud
            // 
            this.ComboBox_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud.FormattingEnabled = true;
            this.ComboBox_baud.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud.Location = new System.Drawing.Point(69, 17);
            this.ComboBox_baud.Name = "ComboBox_baud";
            this.ComboBox_baud.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_baud.TabIndex = 24;
            // 
            // btBaudRate
            // 
            this.btBaudRate.Location = new System.Drawing.Point(233, 14);
            this.btBaudRate.Name = "btBaudRate";
            this.btBaudRate.Size = new System.Drawing.Size(90, 23);
            this.btBaudRate.TabIndex = 23;
            this.btBaudRate.Text = "Set";
            this.btBaudRate.UseVisualStyleBackColor = true;
            this.btBaudRate.Click += new System.EventHandler(this.btBaudRate_Click);
            // 
            // gpb_DBM
            // 
            this.gpb_DBM.Controls.Add(this.label10);
            this.gpb_DBM.Controls.Add(this.ComboBox_PowerDbm);
            this.gpb_DBM.Controls.Add(this.BT_DBM);
            this.gpb_DBM.Location = new System.Drawing.Point(354, 123);
            this.gpb_DBM.Name = "gpb_DBM";
            this.gpb_DBM.Size = new System.Drawing.Size(342, 48);
            this.gpb_DBM.TabIndex = 29;
            this.gpb_DBM.TabStop = false;
            this.gpb_DBM.Text = "Power";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "dBm";
            // 
            // ComboBox_PowerDbm
            // 
            this.ComboBox_PowerDbm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PowerDbm.FormattingEnabled = true;
            this.ComboBox_PowerDbm.Items.AddRange(new object[] {
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
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33"});
            this.ComboBox_PowerDbm.Location = new System.Drawing.Point(51, 20);
            this.ComboBox_PowerDbm.Name = "ComboBox_PowerDbm";
            this.ComboBox_PowerDbm.Size = new System.Drawing.Size(100, 20);
            this.ComboBox_PowerDbm.TabIndex = 24;
            // 
            // BT_DBM
            // 
            this.BT_DBM.Location = new System.Drawing.Point(233, 20);
            this.BT_DBM.Name = "BT_DBM";
            this.BT_DBM.Size = new System.Drawing.Size(90, 23);
            this.BT_DBM.TabIndex = 23;
            this.BT_DBM.Text = "Set";
            this.BT_DBM.UseVisualStyleBackColor = true;
            this.BT_DBM.Click += new System.EventHandler(this.BT_DBM_Click);
            // 
            // gpb_Freq
            // 
            this.gpb_Freq.Controls.Add(this.radioButton_band0);
            this.gpb_Freq.Controls.Add(this.radioButton_band12);
            this.gpb_Freq.Controls.Add(this.radioButton_band8);
            this.gpb_Freq.Controls.Add(this.CheckBox_SameFre);
            this.gpb_Freq.Controls.Add(this.radioButton_band4);
            this.gpb_Freq.Controls.Add(this.radioButton_band3);
            this.gpb_Freq.Controls.Add(this.radioButton_band2);
            this.gpb_Freq.Controls.Add(this.radioButton_band1);
            this.gpb_Freq.Controls.Add(this.btFreq);
            this.gpb_Freq.Controls.Add(this.ComboBox_dmaxfre);
            this.gpb_Freq.Controls.Add(this.label15);
            this.gpb_Freq.Controls.Add(this.ComboBox_dminfre);
            this.gpb_Freq.Controls.Add(this.label14);
            this.gpb_Freq.Location = new System.Drawing.Point(354, 51);
            this.gpb_Freq.Name = "gpb_Freq";
            this.gpb_Freq.Size = new System.Drawing.Size(695, 70);
            this.gpb_Freq.TabIndex = 28;
            this.gpb_Freq.TabStop = false;
            this.gpb_Freq.Text = "Region";
            // 
            // radioButton_band0
            // 
            this.radioButton_band0.AutoSize = true;
            this.radioButton_band0.Location = new System.Drawing.Point(249, 44);
            this.radioButton_band0.Name = "radioButton_band0";
            this.radioButton_band0.Size = new System.Drawing.Size(71, 16);
            this.radioButton_band0.TabIndex = 21;
            this.radioButton_band0.TabStop = true;
            this.radioButton_band0.Text = "ALL band";
            this.radioButton_band0.UseVisualStyleBackColor = true;
            this.radioButton_band0.CheckedChanged += new System.EventHandler(this.radioButton_band0_CheckedChanged);
            // 
            // radioButton_band12
            // 
            this.radioButton_band12.AutoSize = true;
            this.radioButton_band12.Location = new System.Drawing.Point(172, 44);
            this.radioButton_band12.Name = "radioButton_band12";
            this.radioButton_band12.Size = new System.Drawing.Size(71, 16);
            this.radioButton_band12.TabIndex = 18;
            this.radioButton_band12.TabStop = true;
            this.radioButton_band12.Text = "US band3";
            this.radioButton_band12.UseVisualStyleBackColor = true;
            this.radioButton_band12.CheckedChanged += new System.EventHandler(this.radioButton_band12_CheckedChanged);
            // 
            // radioButton_band8
            // 
            this.radioButton_band8.AutoSize = true;
            this.radioButton_band8.Location = new System.Drawing.Point(10, 17);
            this.radioButton_band8.Name = "radioButton_band8";
            this.radioButton_band8.Size = new System.Drawing.Size(101, 16);
            this.radioButton_band8.TabIndex = 17;
            this.radioButton_band8.TabStop = true;
            this.radioButton_band8.Text = "Chinese band1";
            this.radioButton_band8.UseVisualStyleBackColor = true;
            this.radioButton_band8.CheckedChanged += new System.EventHandler(this.radioButton_band8_CheckedChanged);
            // 
            // CheckBox_SameFre
            // 
            this.CheckBox_SameFre.AutoSize = true;
            this.CheckBox_SameFre.Location = new System.Drawing.Point(585, 16);
            this.CheckBox_SameFre.Name = "CheckBox_SameFre";
            this.CheckBox_SameFre.Size = new System.Drawing.Size(60, 16);
            this.CheckBox_SameFre.TabIndex = 16;
            this.CheckBox_SameFre.Text = "Single";
            this.CheckBox_SameFre.UseVisualStyleBackColor = true;
            this.CheckBox_SameFre.CheckedChanged += new System.EventHandler(this.CheckBox_SameFre_CheckedChanged);
            // 
            // radioButton_band4
            // 
            this.radioButton_band4.AutoSize = true;
            this.radioButton_band4.Location = new System.Drawing.Point(103, 44);
            this.radioButton_band4.Name = "radioButton_band4";
            this.radioButton_band4.Size = new System.Drawing.Size(65, 16);
            this.radioButton_band4.TabIndex = 15;
            this.radioButton_band4.TabStop = true;
            this.radioButton_band4.Text = "EU band";
            this.radioButton_band4.UseVisualStyleBackColor = true;
            this.radioButton_band4.CheckedChanged += new System.EventHandler(this.radioButton_band4_CheckedChanged);
            // 
            // radioButton_band3
            // 
            this.radioButton_band3.AutoSize = true;
            this.radioButton_band3.Location = new System.Drawing.Point(10, 44);
            this.radioButton_band3.Name = "radioButton_band3";
            this.radioButton_band3.Size = new System.Drawing.Size(89, 16);
            this.radioButton_band3.TabIndex = 14;
            this.radioButton_band3.TabStop = true;
            this.radioButton_band3.Text = "Korean band";
            this.radioButton_band3.UseVisualStyleBackColor = true;
            this.radioButton_band3.CheckedChanged += new System.EventHandler(this.radioButton_band3_CheckedChanged);
            // 
            // radioButton_band2
            // 
            this.radioButton_band2.AutoSize = true;
            this.radioButton_band2.Location = new System.Drawing.Point(247, 16);
            this.radioButton_band2.Name = "radioButton_band2";
            this.radioButton_band2.Size = new System.Drawing.Size(65, 16);
            this.radioButton_band2.TabIndex = 13;
            this.radioButton_band2.TabStop = true;
            this.radioButton_band2.Text = "US band";
            this.radioButton_band2.UseVisualStyleBackColor = true;
            this.radioButton_band2.CheckedChanged += new System.EventHandler(this.radioButton_band2_CheckedChanged);
            // 
            // radioButton_band1
            // 
            this.radioButton_band1.AutoSize = true;
            this.radioButton_band1.Location = new System.Drawing.Point(127, 17);
            this.radioButton_band1.Name = "radioButton_band1";
            this.radioButton_band1.Size = new System.Drawing.Size(101, 16);
            this.radioButton_band1.TabIndex = 12;
            this.radioButton_band1.TabStop = true;
            this.radioButton_band1.Text = "Chinese band2";
            this.radioButton_band1.UseVisualStyleBackColor = true;
            this.radioButton_band1.CheckedChanged += new System.EventHandler(this.radioButton_band1_CheckedChanged);
            // 
            // btFreq
            // 
            this.btFreq.Location = new System.Drawing.Point(585, 37);
            this.btFreq.Name = "btFreq";
            this.btFreq.Size = new System.Drawing.Size(90, 23);
            this.btFreq.TabIndex = 11;
            this.btFreq.Text = "Set";
            this.btFreq.UseVisualStyleBackColor = true;
            this.btFreq.Click += new System.EventHandler(this.btFreq_Click);
            // 
            // ComboBox_dmaxfre
            // 
            this.ComboBox_dmaxfre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_dmaxfre.FormattingEnabled = true;
            this.ComboBox_dmaxfre.Location = new System.Drawing.Point(421, 42);
            this.ComboBox_dmaxfre.Name = "ComboBox_dmaxfre";
            this.ComboBox_dmaxfre.Size = new System.Drawing.Size(100, 20);
            this.ComboBox_dmaxfre.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(332, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "Maxfre:";
            // 
            // ComboBox_dminfre
            // 
            this.ComboBox_dminfre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_dminfre.FormattingEnabled = true;
            this.ComboBox_dminfre.Location = new System.Drawing.Point(421, 13);
            this.ComboBox_dminfre.Name = "ComboBox_dminfre";
            this.ComboBox_dminfre.Size = new System.Drawing.Size(100, 20);
            this.ComboBox_dminfre.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 7;
            this.label14.Text = "Minfre:";
            // 
            // gpb_beep
            // 
            this.gpb_beep.Controls.Add(this.Radio_beepDis);
            this.gpb_beep.Controls.Add(this.Radio_beepEn);
            this.gpb_beep.Controls.Add(this.Button_Beep);
            this.gpb_beep.Location = new System.Drawing.Point(707, 5);
            this.gpb_beep.Name = "gpb_beep";
            this.gpb_beep.Size = new System.Drawing.Size(342, 44);
            this.gpb_beep.TabIndex = 27;
            this.gpb_beep.TabStop = false;
            this.gpb_beep.Text = "Beep";
            // 
            // Radio_beepDis
            // 
            this.Radio_beepDis.AutoSize = true;
            this.Radio_beepDis.Checked = true;
            this.Radio_beepDis.Location = new System.Drawing.Point(123, 18);
            this.Radio_beepDis.Name = "Radio_beepDis";
            this.Radio_beepDis.Size = new System.Drawing.Size(53, 16);
            this.Radio_beepDis.TabIndex = 10;
            this.Radio_beepDis.TabStop = true;
            this.Radio_beepDis.Text = "Close";
            this.Radio_beepDis.UseVisualStyleBackColor = true;
            // 
            // Radio_beepEn
            // 
            this.Radio_beepEn.AutoSize = true;
            this.Radio_beepEn.Location = new System.Drawing.Point(33, 18);
            this.Radio_beepEn.Name = "Radio_beepEn";
            this.Radio_beepEn.Size = new System.Drawing.Size(47, 16);
            this.Radio_beepEn.TabIndex = 9;
            this.Radio_beepEn.Text = "Open";
            this.Radio_beepEn.UseVisualStyleBackColor = true;
            // 
            // Button_Beep
            // 
            this.Button_Beep.Location = new System.Drawing.Point(232, 14);
            this.Button_Beep.Name = "Button_Beep";
            this.Button_Beep.Size = new System.Drawing.Size(90, 23);
            this.Button_Beep.TabIndex = 8;
            this.Button_Beep.Text = "Set";
            this.Button_Beep.UseVisualStyleBackColor = true;
            this.Button_Beep.Click += new System.EventHandler(this.Button_Beep_Click);
            // 
            // gpb_RDVersion
            // 
            this.gpb_RDVersion.Controls.Add(this.text_RDVersion);
            this.gpb_RDVersion.Location = new System.Drawing.Point(354, 5);
            this.gpb_RDVersion.Name = "gpb_RDVersion";
            this.gpb_RDVersion.Size = new System.Drawing.Size(342, 44);
            this.gpb_RDVersion.TabIndex = 26;
            this.gpb_RDVersion.TabStop = false;
            this.gpb_RDVersion.Text = "Firmware version";
            // 
            // text_RDVersion
            // 
            this.text_RDVersion.Location = new System.Drawing.Point(95, 15);
            this.text_RDVersion.MaxLength = 2;
            this.text_RDVersion.Name = "text_RDVersion";
            this.text_RDVersion.ReadOnly = true;
            this.text_RDVersion.Size = new System.Drawing.Size(160, 21);
            this.text_RDVersion.TabIndex = 24;
            // 
            // gpb_MDVersion
            // 
            this.gpb_MDVersion.Controls.Add(this.text_MDVersion);
            this.gpb_MDVersion.Controls.Add(this.btMDVersion);
            this.gpb_MDVersion.Location = new System.Drawing.Point(6, 557);
            this.gpb_MDVersion.Name = "gpb_MDVersion";
            this.gpb_MDVersion.Size = new System.Drawing.Size(342, 59);
            this.gpb_MDVersion.TabIndex = 25;
            this.gpb_MDVersion.TabStop = false;
            this.gpb_MDVersion.Text = "R2000模块版本号";
            // 
            // text_MDVersion
            // 
            this.text_MDVersion.Location = new System.Drawing.Point(95, 23);
            this.text_MDVersion.MaxLength = 2;
            this.text_MDVersion.Name = "text_MDVersion";
            this.text_MDVersion.ReadOnly = true;
            this.text_MDVersion.Size = new System.Drawing.Size(121, 21);
            this.text_MDVersion.TabIndex = 24;
            // 
            // btMDVersion
            // 
            this.btMDVersion.Location = new System.Drawing.Point(233, 23);
            this.btMDVersion.Name = "btMDVersion";
            this.btMDVersion.Size = new System.Drawing.Size(90, 23);
            this.btMDVersion.TabIndex = 23;
            this.btMDVersion.Text = "读取";
            this.btMDVersion.UseVisualStyleBackColor = true;
            this.btMDVersion.Click += new System.EventHandler(this.btMDVersion_Click);
            // 
            // gpb_Serial
            // 
            this.gpb_Serial.Controls.Add(this.text_Serial);
            this.gpb_Serial.Controls.Add(this.btSerial);
            this.gpb_Serial.Location = new System.Drawing.Point(6, 243);
            this.gpb_Serial.Name = "gpb_Serial";
            this.gpb_Serial.Size = new System.Drawing.Size(342, 43);
            this.gpb_Serial.TabIndex = 6;
            this.gpb_Serial.TabStop = false;
            this.gpb_Serial.Text = "Reader serial number\n";
            // 
            // text_Serial
            // 
            this.text_Serial.Location = new System.Drawing.Point(95, 13);
            this.text_Serial.MaxLength = 8;
            this.text_Serial.Name = "text_Serial";
            this.text_Serial.ReadOnly = true;
            this.text_Serial.Size = new System.Drawing.Size(121, 21);
            this.text_Serial.TabIndex = 24;
            // 
            // btSerial
            // 
            this.btSerial.Location = new System.Drawing.Point(233, 13);
            this.btSerial.Name = "btSerial";
            this.btSerial.Size = new System.Drawing.Size(90, 23);
            this.btSerial.TabIndex = 23;
            this.btSerial.Text = "Get";
            this.btSerial.UseVisualStyleBackColor = true;
            this.btSerial.Click += new System.EventHandler(this.btSerial_Click);
            // 
            // gpb_address
            // 
            this.gpb_address.Controls.Add(this.text_address);
            this.gpb_address.Controls.Add(this.btaddress);
            this.gpb_address.Location = new System.Drawing.Point(6, 196);
            this.gpb_address.Name = "gpb_address";
            this.gpb_address.Size = new System.Drawing.Size(342, 45);
            this.gpb_address.TabIndex = 5;
            this.gpb_address.TabStop = false;
            this.gpb_address.Text = "Reader address";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(95, 14);
            this.text_address.MaxLength = 2;
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(121, 21);
            this.text_address.TabIndex = 24;
            this.text_address.Text = "00";
            this.text_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // btaddress
            // 
            this.btaddress.Location = new System.Drawing.Point(233, 14);
            this.btaddress.Name = "btaddress";
            this.btaddress.Size = new System.Drawing.Size(90, 23);
            this.btaddress.TabIndex = 23;
            this.btaddress.Text = "Set";
            this.btaddress.UseVisualStyleBackColor = true;
            this.btaddress.Click += new System.EventHandler(this.btaddress_Click);
            // 
            // gpb_tcp
            // 
            this.gpb_tcp.Controls.Add(this.tb_Port);
            this.gpb_tcp.Controls.Add(this.ipServerIP);
            this.gpb_tcp.Controls.Add(this.btDisConnectTcp);
            this.gpb_tcp.Controls.Add(this.btConnectTcp);
            this.gpb_tcp.Controls.Add(this.label2);
            this.gpb_tcp.Controls.Add(this.label4);
            this.gpb_tcp.Location = new System.Drawing.Point(5, 123);
            this.gpb_tcp.Name = "gpb_tcp";
            this.gpb_tcp.Size = new System.Drawing.Size(343, 71);
            this.gpb_tcp.TabIndex = 4;
            this.gpb_tcp.TabStop = false;
            this.gpb_tcp.Text = "TCP/IP";
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(96, 40);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(121, 21);
            this.tb_Port.TabIndex = 22;
            this.tb_Port.Text = "27011";
            this.tb_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // ipServerIP
            // 
            this.ipServerIP.IpAddressStr = "192.168.0.250";
            this.ipServerIP.Location = new System.Drawing.Point(96, 15);
            this.ipServerIP.Name = "ipServerIP";
            this.ipServerIP.Size = new System.Drawing.Size(121, 21);
            this.ipServerIP.TabIndex = 21;
            this.ipServerIP.Tag = "";
            // 
            // btDisConnectTcp
            // 
            this.btDisConnectTcp.Enabled = false;
            this.btDisConnectTcp.Location = new System.Drawing.Point(234, 40);
            this.btDisConnectTcp.Name = "btDisConnectTcp";
            this.btDisConnectTcp.Size = new System.Drawing.Size(90, 23);
            this.btDisConnectTcp.TabIndex = 20;
            this.btDisConnectTcp.Text = "Disconnect";
            this.btDisConnectTcp.UseVisualStyleBackColor = true;
            this.btDisConnectTcp.Click += new System.EventHandler(this.btDisConnectTcp_Click);
            // 
            // btConnectTcp
            // 
            this.btConnectTcp.Location = new System.Drawing.Point(234, 13);
            this.btConnectTcp.Name = "btConnectTcp";
            this.btConnectTcp.Size = new System.Drawing.Size(90, 23);
            this.btConnectTcp.TabIndex = 19;
            this.btConnectTcp.Text = "Connect";
            this.btConnectTcp.UseVisualStyleBackColor = true;
            this.btConnectTcp.Click += new System.EventHandler(this.btConnectTcp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "IP Addr:";
            // 
            // gpb_rs232
            // 
            this.gpb_rs232.Controls.Add(this.btDisConnect232);
            this.gpb_rs232.Controls.Add(this.btConnect232);
            this.gpb_rs232.Controls.Add(this.ComboBox_baud2);
            this.gpb_rs232.Controls.Add(this.label47);
            this.gpb_rs232.Controls.Add(this.ComboBox_COM);
            this.gpb_rs232.Controls.Add(this.label3);
            this.gpb_rs232.Location = new System.Drawing.Point(5, 51);
            this.gpb_rs232.Name = "gpb_rs232";
            this.gpb_rs232.Size = new System.Drawing.Size(343, 70);
            this.gpb_rs232.TabIndex = 3;
            this.gpb_rs232.TabStop = false;
            this.gpb_rs232.Text = "RS232";
            // 
            // btDisConnect232
            // 
            this.btDisConnect232.Enabled = false;
            this.btDisConnect232.Location = new System.Drawing.Point(234, 41);
            this.btDisConnect232.Name = "btDisConnect232";
            this.btDisConnect232.Size = new System.Drawing.Size(90, 23);
            this.btDisConnect232.TabIndex = 20;
            this.btDisConnect232.Text = "Disconnect";
            this.btDisConnect232.UseVisualStyleBackColor = true;
            this.btDisConnect232.Click += new System.EventHandler(this.btDisConnect232_Click);
            // 
            // btConnect232
            // 
            this.btConnect232.Location = new System.Drawing.Point(234, 13);
            this.btConnect232.Name = "btConnect232";
            this.btConnect232.Size = new System.Drawing.Size(90, 23);
            this.btConnect232.TabIndex = 19;
            this.btConnect232.Text = "Connect";
            this.btConnect232.UseVisualStyleBackColor = true;
            this.btConnect232.Click += new System.EventHandler(this.btConnect232_Click);
            // 
            // ComboBox_baud2
            // 
            this.ComboBox_baud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud2.FormattingEnabled = true;
            this.ComboBox_baud2.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud2.Location = new System.Drawing.Point(96, 43);
            this.ComboBox_baud2.Name = "ComboBox_baud2";
            this.ComboBox_baud2.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_baud2.TabIndex = 18;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(21, 48);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(65, 12);
            this.label47.TabIndex = 17;
            this.label47.Text = "Baud rate:";
            // 
            // ComboBox_COM
            // 
            this.ComboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_COM.FormattingEnabled = true;
            this.ComboBox_COM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.ComboBox_COM.Location = new System.Drawing.Point(96, 15);
            this.ComboBox_COM.Name = "ComboBox_COM";
            this.ComboBox_COM.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_COM.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Serial Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_tcp);
            this.groupBox1.Controls.Add(this.rb_rs232);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect Type";
            // 
            // rb_tcp
            // 
            this.rb_tcp.AutoSize = true;
            this.rb_tcp.Location = new System.Drawing.Point(190, 18);
            this.rb_tcp.Name = "rb_tcp";
            this.rb_tcp.Size = new System.Drawing.Size(59, 16);
            this.rb_tcp.TabIndex = 1;
            this.rb_tcp.Text = "TCP/IP";
            this.rb_tcp.UseVisualStyleBackColor = true;
            this.rb_tcp.CheckedChanged += new System.EventHandler(this.rb_tcp_CheckedChanged);
            // 
            // rb_rs232
            // 
            this.rb_rs232.AutoSize = true;
            this.rb_rs232.Location = new System.Drawing.Point(33, 18);
            this.rb_rs232.Name = "rb_rs232";
            this.rb_rs232.Size = new System.Drawing.Size(53, 16);
            this.rb_rs232.TabIndex = 0;
            this.rb_rs232.Text = "RS232";
            this.rb_rs232.UseVisualStyleBackColor = true;
            this.rb_rs232.CheckedChanged += new System.EventHandler(this.rb_rs232_CheckedChanged);
            // 
            // tabPage_Mx
            // 
            this.tabPage_Mx.Controls.Add(this.panel2);
            this.tabPage_Mx.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Mx.Name = "tabPage_Mx";
            this.tabPage_Mx.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mx.Size = new System.Drawing.Size(1057, 537);
            this.tabPage_Mx.TabIndex = 1;
            this.tabPage_Mx.Text = "Auto-running setting";
            this.tabPage_Mx.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbp_trigger);
            this.panel2.Controls.Add(this.groupBox43);
            this.panel2.Controls.Add(this.groupBox44);
            this.panel2.Controls.Add(this.btGetWorkmodepara);
            this.panel2.Controls.Add(this.groupBox37);
            this.panel2.Controls.Add(this.groupBox36);
            this.panel2.Controls.Add(this.gbp_tagType);
            this.panel2.Controls.Add(this.gbp_Response);
            this.panel2.Controls.Add(this.gbp_mask);
            this.panel2.Controls.Add(this.gbp_EASAcc);
            this.panel2.Location = new System.Drawing.Point(-3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 563);
            this.panel2.TabIndex = 0;
            // 
            // gbp_trigger
            // 
            this.gbp_trigger.Controls.Add(this.label84);
            this.gbp_trigger.Controls.Add(this.bttrigger);
            this.gbp_trigger.Controls.Add(this.comboBox_trigger);
            this.gbp_trigger.Controls.Add(this.label85);
            this.gbp_trigger.Location = new System.Drawing.Point(709, 99);
            this.gbp_trigger.Name = "gbp_trigger";
            this.gbp_trigger.Size = new System.Drawing.Size(340, 67);
            this.gbp_trigger.TabIndex = 84;
            this.gbp_trigger.TabStop = false;
            this.gbp_trigger.Text = "Set Trigger-Time";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(183, 34);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(23, 12);
            this.label84.TabIndex = 5;
            this.label84.Text = "*1s";
            // 
            // bttrigger
            // 
            this.bttrigger.Location = new System.Drawing.Point(244, 29);
            this.bttrigger.Name = "bttrigger";
            this.bttrigger.Size = new System.Drawing.Size(90, 23);
            this.bttrigger.TabIndex = 2;
            this.bttrigger.Text = "Set";
            this.bttrigger.UseVisualStyleBackColor = true;
            this.bttrigger.Click += new System.EventHandler(this.bttrigger_Click);
            // 
            // comboBox_trigger
            // 
            this.comboBox_trigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_trigger.FormattingEnabled = true;
            this.comboBox_trigger.Location = new System.Drawing.Point(90, 29);
            this.comboBox_trigger.Name = "comboBox_trigger";
            this.comboBox_trigger.Size = new System.Drawing.Size(91, 20);
            this.comboBox_trigger.TabIndex = 1;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(9, 32);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(83, 12);
            this.label85.TabIndex = 0;
            this.label85.Text = "Trigger Time:";
            // 
            // groupBox43
            // 
            this.groupBox43.Controls.Add(this.btGetQS);
            this.groupBox43.Controls.Add(this.btSetQS);
            this.groupBox43.Controls.Add(this.com_acS);
            this.groupBox43.Controls.Add(this.label65);
            this.groupBox43.Controls.Add(this.com_acQ);
            this.groupBox43.Controls.Add(this.label64);
            this.groupBox43.Location = new System.Drawing.Point(444, 172);
            this.groupBox43.Name = "groupBox43";
            this.groupBox43.Size = new System.Drawing.Size(606, 56);
            this.groupBox43.TabIndex = 83;
            this.groupBox43.TabStop = false;
            this.groupBox43.Text = "Mutiple query parameter";
            // 
            // btGetQS
            // 
            this.btGetQS.Location = new System.Drawing.Point(509, 20);
            this.btGetQS.Name = "btGetQS";
            this.btGetQS.Size = new System.Drawing.Size(90, 23);
            this.btGetQS.TabIndex = 7;
            this.btGetQS.Text = "Get";
            this.btGetQS.UseVisualStyleBackColor = true;
            this.btGetQS.Click += new System.EventHandler(this.btGetQS_Click);
            // 
            // btSetQS
            // 
            this.btSetQS.Location = new System.Drawing.Point(397, 20);
            this.btSetQS.Name = "btSetQS";
            this.btSetQS.Size = new System.Drawing.Size(90, 23);
            this.btSetQS.TabIndex = 6;
            this.btSetQS.Text = "Set";
            this.btSetQS.UseVisualStyleBackColor = true;
            this.btSetQS.Click += new System.EventHandler(this.btSetQS_Click);
            // 
            // com_acS
            // 
            this.com_acS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_acS.FormattingEnabled = true;
            this.com_acS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.com_acS.Location = new System.Drawing.Point(269, 22);
            this.com_acS.Name = "com_acS";
            this.com_acS.Size = new System.Drawing.Size(91, 20);
            this.com_acS.TabIndex = 5;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(187, 26);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(53, 12);
            this.label65.TabIndex = 4;
            this.label65.Text = "Session:";
            // 
            // com_acQ
            // 
            this.com_acQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_acQ.FormattingEnabled = true;
            this.com_acQ.Items.AddRange(new object[] {
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
            this.com_acQ.Location = new System.Drawing.Point(67, 23);
            this.com_acQ.Name = "com_acQ";
            this.com_acQ.Size = new System.Drawing.Size(91, 20);
            this.com_acQ.TabIndex = 3;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(18, 26);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(17, 12);
            this.label64.TabIndex = 2;
            this.label64.Text = "Q:";
            // 
            // groupBox44
            // 
            this.groupBox44.Controls.Add(this.text_tidlen);
            this.groupBox44.Controls.Add(this.label67);
            this.groupBox44.Controls.Add(this.text_tidaddr);
            this.groupBox44.Controls.Add(this.btTIDpara);
            this.groupBox44.Controls.Add(this.label66);
            this.groupBox44.Location = new System.Drawing.Point(8, 172);
            this.groupBox44.Name = "groupBox44";
            this.groupBox44.Size = new System.Drawing.Size(430, 56);
            this.groupBox44.TabIndex = 82;
            this.groupBox44.TabStop = false;
            this.groupBox44.Text = "TID Parameter Setting";
            // 
            // text_tidlen
            // 
            this.text_tidlen.Location = new System.Drawing.Point(238, 23);
            this.text_tidlen.MaxLength = 2;
            this.text_tidlen.Name = "text_tidlen";
            this.text_tidlen.Size = new System.Drawing.Size(69, 21);
            this.text_tidlen.TabIndex = 5;
            this.text_tidlen.Text = "04";
            this.text_tidlen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(167, 26);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(47, 12);
            this.label67.TabIndex = 4;
            this.label67.Text = "Length:";
            // 
            // text_tidaddr
            // 
            this.text_tidaddr.Location = new System.Drawing.Point(97, 23);
            this.text_tidaddr.MaxLength = 2;
            this.text_tidaddr.Name = "text_tidaddr";
            this.text_tidaddr.Size = new System.Drawing.Size(69, 21);
            this.text_tidaddr.TabIndex = 3;
            this.text_tidaddr.Text = "02";
            this.text_tidaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // btTIDpara
            // 
            this.btTIDpara.Location = new System.Drawing.Point(321, 22);
            this.btTIDpara.Name = "btTIDpara";
            this.btTIDpara.Size = new System.Drawing.Size(90, 23);
            this.btTIDpara.TabIndex = 2;
            this.btTIDpara.Text = "Set";
            this.btTIDpara.UseVisualStyleBackColor = true;
            this.btTIDpara.Click += new System.EventHandler(this.btTIDpara_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(7, 26);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(89, 12);
            this.label66.TabIndex = 0;
            this.label66.Text = "Start Address:";
            // 
            // btGetWorkmodepara
            // 
            this.btGetWorkmodepara.Location = new System.Drawing.Point(732, 242);
            this.btGetWorkmodepara.Name = "btGetWorkmodepara";
            this.btGetWorkmodepara.Size = new System.Drawing.Size(320, 40);
            this.btGetWorkmodepara.TabIndex = 80;
            this.btGetWorkmodepara.Text = "Get System Parameter";
            this.btGetWorkmodepara.UseVisualStyleBackColor = true;
            this.btGetWorkmodepara.Click += new System.EventHandler(this.btGetWorkmodepara_Click);
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.btworkmode);
            this.groupBox37.Controls.Add(this.comboBox_mode);
            this.groupBox37.Controls.Add(this.label59);
            this.groupBox37.Location = new System.Drawing.Point(345, 230);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Size = new System.Drawing.Size(380, 56);
            this.groupBox37.TabIndex = 79;
            this.groupBox37.TabStop = false;
            this.groupBox37.Text = "Work Mode";
            // 
            // btworkmode
            // 
            this.btworkmode.Location = new System.Drawing.Point(273, 20);
            this.btworkmode.Name = "btworkmode";
            this.btworkmode.Size = new System.Drawing.Size(90, 23);
            this.btworkmode.TabIndex = 2;
            this.btworkmode.Text = "Set";
            this.btworkmode.UseVisualStyleBackColor = true;
            this.btworkmode.Click += new System.EventHandler(this.btworkmode_Click);
            // 
            // comboBox_mode
            // 
            this.comboBox_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mode.FormattingEnabled = true;
            this.comboBox_mode.Items.AddRange(new object[] {
            "Answer Mode",
            "Auto_running mode",
            "Trigger mode(Low)",
            "Trigger mode(High)"});
            this.comboBox_mode.Location = new System.Drawing.Point(92, 23);
            this.comboBox_mode.Name = "comboBox_mode";
            this.comboBox_mode.Size = new System.Drawing.Size(168, 20);
            this.comboBox_mode.TabIndex = 1;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(7, 26);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(77, 12);
            this.label59.TabIndex = 0;
            this.label59.Text = "Mode Select:";
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.btInterval);
            this.groupBox36.Controls.Add(this.comboBox_intervalT);
            this.groupBox36.Controls.Add(this.label58);
            this.groupBox36.Location = new System.Drawing.Point(8, 230);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new System.Drawing.Size(331, 56);
            this.groupBox36.TabIndex = 78;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "Pulse interval";
            // 
            // btInterval
            // 
            this.btInterval.Location = new System.Drawing.Point(217, 20);
            this.btInterval.Name = "btInterval";
            this.btInterval.Size = new System.Drawing.Size(90, 23);
            this.btInterval.TabIndex = 2;
            this.btInterval.Text = "Set";
            this.btInterval.UseVisualStyleBackColor = true;
            this.btInterval.Click += new System.EventHandler(this.btInterval_Click);
            // 
            // comboBox_intervalT
            // 
            this.comboBox_intervalT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_intervalT.FormattingEnabled = true;
            this.comboBox_intervalT.Items.AddRange(new object[] {
            "10ms",
            "20ms",
            "30ms",
            "50ms",
            "100ms"});
            this.comboBox_intervalT.Location = new System.Drawing.Point(77, 22);
            this.comboBox_intervalT.Name = "comboBox_intervalT";
            this.comboBox_intervalT.Size = new System.Drawing.Size(131, 20);
            this.comboBox_intervalT.TabIndex = 1;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(7, 26);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(71, 12);
            this.label58.TabIndex = 0;
            this.label58.Text = "Pulse Time:";
            // 
            // gbp_tagType
            // 
            this.gbp_tagType.Controls.Add(this.rb_G2TID);
            this.gbp_tagType.Controls.Add(this.bt_typeTag);
            this.gbp_tagType.Controls.Add(this.rb_EAS);
            this.gbp_tagType.Controls.Add(this.rb_G2);
            this.gbp_tagType.Controls.Add(this.groupBox35);
            this.gbp_tagType.Location = new System.Drawing.Point(8, 97);
            this.gbp_tagType.Name = "gbp_tagType";
            this.gbp_tagType.Size = new System.Drawing.Size(695, 69);
            this.gbp_tagType.TabIndex = 77;
            this.gbp_tagType.TabStop = false;
            this.gbp_tagType.Text = "Query Tag Type";
            // 
            // rb_G2TID
            // 
            this.rb_G2TID.AutoSize = true;
            this.rb_G2TID.Location = new System.Drawing.Point(467, 31);
            this.rb_G2TID.Name = "rb_G2TID";
            this.rb_G2TID.Size = new System.Drawing.Size(131, 16);
            this.rb_G2TID.TabIndex = 5;
            this.rb_G2TID.Text = "Query G2 Tag\'s TID";
            this.rb_G2TID.UseVisualStyleBackColor = true;
            // 
            // bt_typeTag
            // 
            this.bt_typeTag.Location = new System.Drawing.Point(599, 28);
            this.bt_typeTag.Name = "bt_typeTag";
            this.bt_typeTag.Size = new System.Drawing.Size(90, 23);
            this.bt_typeTag.TabIndex = 4;
            this.bt_typeTag.Text = "Set";
            this.bt_typeTag.UseVisualStyleBackColor = true;
            this.bt_typeTag.Click += new System.EventHandler(this.bt_typeTag_Click);
            // 
            // rb_EAS
            // 
            this.rb_EAS.AutoSize = true;
            this.rb_EAS.Location = new System.Drawing.Point(368, 31);
            this.rb_EAS.Name = "rb_EAS";
            this.rb_EAS.Size = new System.Drawing.Size(83, 16);
            this.rb_EAS.TabIndex = 3;
            this.rb_EAS.Text = "Detect EAS";
            this.rb_EAS.UseVisualStyleBackColor = true;
            // 
            // rb_G2
            // 
            this.rb_G2.AutoSize = true;
            this.rb_G2.Checked = true;
            this.rb_G2.Location = new System.Drawing.Point(247, 31);
            this.rb_G2.Name = "rb_G2";
            this.rb_G2.Size = new System.Drawing.Size(95, 16);
            this.rb_G2.TabIndex = 1;
            this.rb_G2.TabStop = true;
            this.rb_G2.Text = "Query G2 Tag";
            this.rb_G2.UseVisualStyleBackColor = true;
            // 
            // groupBox35
            // 
            this.groupBox35.Controls.Add(this.rb_180006B);
            this.groupBox35.Controls.Add(this.rb_180006c);
            this.groupBox35.Location = new System.Drawing.Point(6, 14);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new System.Drawing.Size(200, 48);
            this.groupBox35.TabIndex = 0;
            this.groupBox35.TabStop = false;
            this.groupBox35.Text = "Protocl";
            // 
            // rb_180006B
            // 
            this.rb_180006B.AutoSize = true;
            this.rb_180006B.Location = new System.Drawing.Point(106, 20);
            this.rb_180006B.Name = "rb_180006B";
            this.rb_180006B.Size = new System.Drawing.Size(71, 16);
            this.rb_180006B.TabIndex = 1;
            this.rb_180006B.Text = "18000-6B";
            this.rb_180006B.UseVisualStyleBackColor = true;
            // 
            // rb_180006c
            // 
            this.rb_180006c.AutoSize = true;
            this.rb_180006c.Checked = true;
            this.rb_180006c.Location = new System.Drawing.Point(10, 20);
            this.rb_180006c.Name = "rb_180006c";
            this.rb_180006c.Size = new System.Drawing.Size(71, 16);
            this.rb_180006c.TabIndex = 0;
            this.rb_180006c.TabStop = true;
            this.rb_180006c.Text = "EPCC1-G2";
            this.rb_180006c.UseVisualStyleBackColor = true;
            // 
            // gbp_Response
            // 
            this.gbp_Response.Controls.Add(this.btResponse);
            this.gbp_Response.Controls.Add(this.label57);
            this.gbp_Response.Controls.Add(this.comboBox_RespTime);
            this.gbp_Response.Controls.Add(this.label56);
            this.gbp_Response.Controls.Add(this.comboBox_Resp);
            this.gbp_Response.Controls.Add(this.label55);
            this.gbp_Response.Location = new System.Drawing.Point(746, 4);
            this.gbp_Response.Name = "gbp_Response";
            this.gbp_Response.Size = new System.Drawing.Size(305, 87);
            this.gbp_Response.TabIndex = 76;
            this.gbp_Response.TabStop = false;
            this.gbp_Response.Text = "Response conditions  Setting";
            // 
            // btResponse
            // 
            this.btResponse.Location = new System.Drawing.Point(207, 50);
            this.btResponse.Name = "btResponse";
            this.btResponse.Size = new System.Drawing.Size(90, 23);
            this.btResponse.TabIndex = 5;
            this.btResponse.Text = "Set";
            this.btResponse.UseVisualStyleBackColor = true;
            this.btResponse.Click += new System.EventHandler(this.btResponse_Click);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(173, 58);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(23, 12);
            this.label57.TabIndex = 4;
            this.label57.Text = "*1s";
            // 
            // comboBox_RespTime
            // 
            this.comboBox_RespTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RespTime.FormattingEnabled = true;
            this.comboBox_RespTime.Location = new System.Drawing.Point(95, 51);
            this.comboBox_RespTime.Name = "comboBox_RespTime";
            this.comboBox_RespTime.Size = new System.Drawing.Size(77, 20);
            this.comboBox_RespTime.TabIndex = 3;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(8, 58);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(83, 12);
            this.label56.TabIndex = 2;
            this.label56.Text = "RepPauseTime:";
            // 
            // comboBox_Resp
            // 
            this.comboBox_Resp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Resp.FormattingEnabled = true;
            this.comboBox_Resp.Items.AddRange(new object[] {
            "Command notify",
            "Timer notify",
            "Add-in notify",
            "Delete notify",
            "Change notify"});
            this.comboBox_Resp.Location = new System.Drawing.Point(95, 22);
            this.comboBox_Resp.Name = "comboBox_Resp";
            this.comboBox_Resp.Size = new System.Drawing.Size(202, 20);
            this.comboBox_Resp.TabIndex = 1;
            this.comboBox_Resp.SelectedIndexChanged += new System.EventHandler(this.comboBox_Resp_SelectedIndexChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 26);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(83, 12);
            this.label55.TabIndex = 0;
            this.label55.Text = "RepCondition:";
            // 
            // gbp_mask
            // 
            this.gbp_mask.Controls.Add(this.btMaskSet);
            this.gbp_mask.Controls.Add(this.text_mdata);
            this.gbp_mask.Controls.Add(this.label54);
            this.gbp_mask.Controls.Add(this.text_mlen);
            this.gbp_mask.Controls.Add(this.label53);
            this.gbp_mask.Controls.Add(this.text_madds);
            this.gbp_mask.Controls.Add(this.label81);
            this.gbp_mask.Controls.Add(this.rb_MaskUser);
            this.gbp_mask.Controls.Add(this.rb_MaskTID);
            this.gbp_mask.Controls.Add(this.rb_MaskEPC);
            this.gbp_mask.Location = new System.Drawing.Point(346, 4);
            this.gbp_mask.Name = "gbp_mask";
            this.gbp_mask.Size = new System.Drawing.Size(384, 87);
            this.gbp_mask.TabIndex = 75;
            this.gbp_mask.TabStop = false;
            this.gbp_mask.Text = "Mask setting";
            // 
            // btMaskSet
            // 
            this.btMaskSet.Location = new System.Drawing.Point(285, 59);
            this.btMaskSet.Name = "btMaskSet";
            this.btMaskSet.Size = new System.Drawing.Size(90, 23);
            this.btMaskSet.TabIndex = 9;
            this.btMaskSet.Text = "Set";
            this.btMaskSet.UseVisualStyleBackColor = true;
            this.btMaskSet.Click += new System.EventHandler(this.btMaskSet_Click);
            // 
            // text_mdata
            // 
            this.text_mdata.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_mdata.Location = new System.Drawing.Point(94, 61);
            this.text_mdata.Name = "text_mdata";
            this.text_mdata.Size = new System.Drawing.Size(177, 21);
            this.text_mdata.TabIndex = 8;
            this.text_mdata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 67);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(95, 12);
            this.label54.TabIndex = 7;
            this.label54.Text = "Mask data(Hex):";
            // 
            // text_mlen
            // 
            this.text_mlen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_mlen.Location = new System.Drawing.Point(313, 33);
            this.text_mlen.MaxLength = 2;
            this.text_mlen.Name = "text_mlen";
            this.text_mlen.Size = new System.Drawing.Size(62, 21);
            this.text_mlen.TabIndex = 6;
            this.text_mlen.Text = "00";
            this.text_mlen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(212, 40);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(107, 12);
            this.label53.TabIndex = 5;
            this.label53.Text = "Mask length(Hex):";
            // 
            // text_madds
            // 
            this.text_madds.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_madds.Location = new System.Drawing.Point(137, 33);
            this.text_madds.MaxLength = 4;
            this.text_madds.Name = "text_madds";
            this.text_madds.Size = new System.Drawing.Size(55, 21);
            this.text_madds.TabIndex = 4;
            this.text_madds.Text = "0000";
            this.text_madds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(6, 40);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(113, 12);
            this.label81.TabIndex = 3;
            this.label81.Text = "Mask address(Hex):";
            // 
            // rb_MaskUser
            // 
            this.rb_MaskUser.AutoSize = true;
            this.rb_MaskUser.Location = new System.Drawing.Point(214, 14);
            this.rb_MaskUser.Name = "rb_MaskUser";
            this.rb_MaskUser.Size = new System.Drawing.Size(47, 16);
            this.rb_MaskUser.TabIndex = 2;
            this.rb_MaskUser.Text = "User";
            this.rb_MaskUser.UseVisualStyleBackColor = true;
            // 
            // rb_MaskTID
            // 
            this.rb_MaskTID.AutoSize = true;
            this.rb_MaskTID.Location = new System.Drawing.Point(110, 14);
            this.rb_MaskTID.Name = "rb_MaskTID";
            this.rb_MaskTID.Size = new System.Drawing.Size(41, 16);
            this.rb_MaskTID.TabIndex = 1;
            this.rb_MaskTID.Text = "TID";
            this.rb_MaskTID.UseVisualStyleBackColor = true;
            // 
            // rb_MaskEPC
            // 
            this.rb_MaskEPC.AutoSize = true;
            this.rb_MaskEPC.Checked = true;
            this.rb_MaskEPC.Location = new System.Drawing.Point(6, 14);
            this.rb_MaskEPC.Name = "rb_MaskEPC";
            this.rb_MaskEPC.Size = new System.Drawing.Size(41, 16);
            this.rb_MaskEPC.TabIndex = 0;
            this.rb_MaskEPC.TabStop = true;
            this.rb_MaskEPC.Text = "EPC";
            this.rb_MaskEPC.UseVisualStyleBackColor = true;
            // 
            // gbp_EASAcc
            // 
            this.gbp_EASAcc.Controls.Add(this.btAccuracy);
            this.gbp_EASAcc.Controls.Add(this.ComboBox_Accuracy);
            this.gbp_EASAcc.Controls.Add(this.label82);
            this.gbp_EASAcc.Controls.Add(this.rbNone);
            this.gbp_EASAcc.Controls.Add(this.rbEASAcc);
            this.gbp_EASAcc.Location = new System.Drawing.Point(8, 4);
            this.gbp_EASAcc.Name = "gbp_EASAcc";
            this.gbp_EASAcc.Size = new System.Drawing.Size(330, 87);
            this.gbp_EASAcc.TabIndex = 74;
            this.gbp_EASAcc.TabStop = false;
            this.gbp_EASAcc.Text = "EAS Sensitivity ";
            // 
            // btAccuracy
            // 
            this.btAccuracy.Location = new System.Drawing.Point(217, 49);
            this.btAccuracy.Name = "btAccuracy";
            this.btAccuracy.Size = new System.Drawing.Size(90, 23);
            this.btAccuracy.TabIndex = 4;
            this.btAccuracy.Text = "Set";
            this.btAccuracy.UseVisualStyleBackColor = true;
            this.btAccuracy.Click += new System.EventHandler(this.btAccuracy_Click);
            // 
            // ComboBox_Accuracy
            // 
            this.ComboBox_Accuracy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Accuracy.FormattingEnabled = true;
            this.ComboBox_Accuracy.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ComboBox_Accuracy.Location = new System.Drawing.Point(94, 52);
            this.ComboBox_Accuracy.Name = "ComboBox_Accuracy";
            this.ComboBox_Accuracy.Size = new System.Drawing.Size(79, 20);
            this.ComboBox_Accuracy.TabIndex = 3;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(12, 55);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(83, 12);
            this.label82.TabIndex = 2;
            this.label82.Text = "EAS Accuracy:";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(217, 22);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(47, 16);
            this.rbNone.TabIndex = 1;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbEASAcc
            // 
            this.rbEASAcc.AutoSize = true;
            this.rbEASAcc.Checked = true;
            this.rbEASAcc.Location = new System.Drawing.Point(12, 22);
            this.rbEASAcc.Name = "rbEASAcc";
            this.rbEASAcc.Size = new System.Drawing.Size(227, 16);
            this.rbEASAcc.TabIndex = 0;
            this.rbEASAcc.TabStop = true;
            this.rbEASAcc.Text = "Relay release 3s when detected EAS";
            this.rbEASAcc.UseVisualStyleBackColor = true;
            // 
            // tabPage_Module
            // 
            this.tabPage_Module.Controls.Add(this.panel9);
            this.tabPage_Module.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Module.Name = "tabPage_Module";
            this.tabPage_Module.Size = new System.Drawing.Size(1057, 537);
            this.tabPage_Module.TabIndex = 2;
            this.tabPage_Module.Text = "Real-time-inventory setting";
            this.tabPage_Module.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btMSetParameter);
            this.panel9.Controls.Add(this.btMGetParameter);
            this.panel9.Controls.Add(this.groupBox39);
            this.panel9.Controls.Add(this.groupBox38);
            this.panel9.Controls.Add(this.groupBox34);
            this.panel9.Controls.Add(this.groupBox33);
            this.panel9.Controls.Add(this.groupBox32);
            this.panel9.Controls.Add(this.groupBox28);
            this.panel9.Controls.Add(this.groupBox3);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1059, 506);
            this.panel9.TabIndex = 0;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // btMSetParameter
            // 
            this.btMSetParameter.Location = new System.Drawing.Point(928, 118);
            this.btMSetParameter.Name = "btMSetParameter";
            this.btMSetParameter.Size = new System.Drawing.Size(119, 33);
            this.btMSetParameter.TabIndex = 86;
            this.btMSetParameter.Text = "Set Parameter";
            this.btMSetParameter.UseVisualStyleBackColor = true;
            this.btMSetParameter.Click += new System.EventHandler(this.btMSetParameter_Click);
            // 
            // btMGetParameter
            // 
            this.btMGetParameter.Location = new System.Drawing.Point(928, 74);
            this.btMGetParameter.Name = "btMGetParameter";
            this.btMGetParameter.Size = new System.Drawing.Size(119, 33);
            this.btMGetParameter.TabIndex = 85;
            this.btMGetParameter.Text = "Get Parameter";
            this.btMGetParameter.UseVisualStyleBackColor = true;
            this.btMGetParameter.Click += new System.EventHandler(this.btMGetParameter_Click);
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.checkBox5);
            this.groupBox39.Controls.Add(this.btSetMmode);
            this.groupBox39.Controls.Add(this.com_Mmode);
            this.groupBox39.Controls.Add(this.label111);
            this.groupBox39.Location = new System.Drawing.Point(656, 69);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Size = new System.Drawing.Size(265, 87);
            this.groupBox39.TabIndex = 84;
            this.groupBox39.TabStop = false;
            this.groupBox39.Text = "Work Mode";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(9, 56);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(48, 16);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Save";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // btSetMmode
            // 
            this.btSetMmode.Location = new System.Drawing.Point(170, 56);
            this.btSetMmode.Name = "btSetMmode";
            this.btSetMmode.Size = new System.Drawing.Size(90, 23);
            this.btSetMmode.TabIndex = 2;
            this.btSetMmode.Text = "Set";
            this.btSetMmode.UseVisualStyleBackColor = true;
            this.btSetMmode.Click += new System.EventHandler(this.btSetMmode_Click);
            // 
            // com_Mmode
            // 
            this.com_Mmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Mmode.FormattingEnabled = true;
            this.com_Mmode.Items.AddRange(new object[] {
            "Answer mode",
            "Real-time-inventory mode",
            "trigger-mode"});
            this.com_Mmode.Location = new System.Drawing.Point(92, 23);
            this.com_Mmode.Name = "com_Mmode";
            this.com_Mmode.Size = new System.Drawing.Size(168, 20);
            this.com_Mmode.TabIndex = 1;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(7, 26);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(77, 12);
            this.label111.TabIndex = 0;
            this.label111.Text = "Mode Select:";
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.checkBox_tid);
            this.groupBox38.Controls.Add(this.txt_Mtidlen);
            this.groupBox38.Controls.Add(this.label103);
            this.groupBox38.Controls.Add(this.txt_mtidaddr);
            this.groupBox38.Controls.Add(this.label104);
            this.groupBox38.Location = new System.Drawing.Point(436, 69);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(214, 87);
            this.groupBox38.TabIndex = 83;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "TID Parameter Setting";
            // 
            // checkBox_tid
            // 
            this.checkBox_tid.AutoSize = true;
            this.checkBox_tid.Location = new System.Drawing.Point(160, 25);
            this.checkBox_tid.Name = "checkBox_tid";
            this.checkBox_tid.Size = new System.Drawing.Size(60, 16);
            this.checkBox_tid.TabIndex = 10;
            this.checkBox_tid.Text = "Enable";
            this.checkBox_tid.UseVisualStyleBackColor = true;
            // 
            // txt_Mtidlen
            // 
            this.txt_Mtidlen.Location = new System.Drawing.Point(87, 58);
            this.txt_Mtidlen.MaxLength = 2;
            this.txt_Mtidlen.Name = "txt_Mtidlen";
            this.txt_Mtidlen.Size = new System.Drawing.Size(60, 21);
            this.txt_Mtidlen.TabIndex = 5;
            this.txt_Mtidlen.Text = "04";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(16, 61);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(77, 12);
            this.label103.TabIndex = 4;
            this.label103.Text = "Length(Hex):";
            // 
            // txt_mtidaddr
            // 
            this.txt_mtidaddr.Location = new System.Drawing.Point(87, 23);
            this.txt_mtidaddr.MaxLength = 2;
            this.txt_mtidaddr.Name = "txt_mtidaddr";
            this.txt_mtidaddr.Size = new System.Drawing.Size(60, 21);
            this.txt_mtidaddr.TabIndex = 3;
            this.txt_mtidaddr.Text = "02";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(16, 26);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(119, 12);
            this.label104.TabIndex = 0;
            this.label104.Text = "Start address(Hex):";
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.checkBox_mask);
            this.groupBox34.Controls.Add(this.txt_Mdata);
            this.groupBox34.Controls.Add(this.label100);
            this.groupBox34.Controls.Add(this.txt_Mlen);
            this.groupBox34.Controls.Add(this.label101);
            this.groupBox34.Controls.Add(this.txt_Maddr);
            this.groupBox34.Controls.Add(this.label102);
            this.groupBox34.Controls.Add(this.RBM_USER);
            this.groupBox34.Controls.Add(this.RBM_TID);
            this.groupBox34.Controls.Add(this.RBM_EPC);
            this.groupBox34.Location = new System.Drawing.Point(8, 69);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(420, 87);
            this.groupBox34.TabIndex = 82;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Mask setting";
            // 
            // checkBox_mask
            // 
            this.checkBox_mask.AutoSize = true;
            this.checkBox_mask.Location = new System.Drawing.Point(323, 13);
            this.checkBox_mask.Name = "checkBox_mask";
            this.checkBox_mask.Size = new System.Drawing.Size(60, 16);
            this.checkBox_mask.TabIndex = 9;
            this.checkBox_mask.Text = "Enable";
            this.checkBox_mask.UseVisualStyleBackColor = true;
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
            this.txt_Maddr.Text = "0000";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(6, 40);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(119, 12);
            this.label102.TabIndex = 3;
            this.label102.Text = "Start address(Hex):";
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
            this.groupBox33.Controls.Add(this.checkBox4);
            this.groupBox33.Controls.Add(this.com_MS);
            this.groupBox33.Controls.Add(this.label99);
            this.groupBox33.Controls.Add(this.com_MQ);
            this.groupBox33.Controls.Add(this.label98);
            this.groupBox33.Location = new System.Drawing.Point(656, 6);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(394, 56);
            this.groupBox33.TabIndex = 81;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Mutiple query parameter";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(125, 25);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 16);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Fix-Q";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // com_MS
            // 
            this.com_MS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MS.FormattingEnabled = true;
            this.com_MS.Items.AddRange(new object[] {
            "S0",
            "S1",
            "S2",
            "S3",
            "AUTO"});
            this.com_MS.Location = new System.Drawing.Point(267, 23);
            this.com_MS.Name = "com_MS";
            this.com_MS.Size = new System.Drawing.Size(117, 20);
            this.com_MS.TabIndex = 3;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(194, 26);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(53, 12);
            this.label99.TabIndex = 2;
            this.label99.Text = "Session:";
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
            this.com_MQ.Location = new System.Drawing.Point(47, 23);
            this.com_MQ.Name = "com_MQ";
            this.com_MQ.Size = new System.Drawing.Size(70, 20);
            this.com_MQ.TabIndex = 1;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(7, 26);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(17, 12);
            this.label98.TabIndex = 0;
            this.label98.Text = "Q:";
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.com_MFliterTime);
            this.groupBox32.Controls.Add(this.label97);
            this.groupBox32.Location = new System.Drawing.Point(436, 6);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(214, 56);
            this.groupBox32.TabIndex = 80;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Tag Filter";
            // 
            // com_MFliterTime
            // 
            this.com_MFliterTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MFliterTime.FormattingEnabled = true;
            this.com_MFliterTime.Location = new System.Drawing.Point(89, 23);
            this.com_MFliterTime.Name = "com_MFliterTime";
            this.com_MFliterTime.Size = new System.Drawing.Size(115, 20);
            this.com_MFliterTime.TabIndex = 1;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(7, 26);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(77, 12);
            this.label97.TabIndex = 0;
            this.label97.Text = "Filter time:";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.COM_MRPTime);
            this.groupBox28.Controls.Add(this.label96);
            this.groupBox28.Location = new System.Drawing.Point(214, 6);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(214, 56);
            this.groupBox28.TabIndex = 79;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Pulse interval";
            // 
            // COM_MRPTime
            // 
            this.COM_MRPTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COM_MRPTime.FormattingEnabled = true;
            this.COM_MRPTime.Items.AddRange(new object[] {
            "10ms",
            "20ms",
            "30ms",
            "50ms",
            "100ms"});
            this.COM_MRPTime.Location = new System.Drawing.Point(83, 23);
            this.COM_MRPTime.Name = "COM_MRPTime";
            this.COM_MRPTime.Size = new System.Drawing.Size(121, 20);
            this.COM_MRPTime.TabIndex = 1;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(7, 26);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(71, 12);
            this.label96.TabIndex = 0;
            this.label96.Text = "Pulse Time:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MRB_6B);
            this.groupBox3.Controls.Add(this.MRB_G2);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 56);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Protocl";
            // 
            // MRB_6B
            // 
            this.MRB_6B.AutoSize = true;
            this.MRB_6B.Location = new System.Drawing.Point(106, 20);
            this.MRB_6B.Name = "MRB_6B";
            this.MRB_6B.Size = new System.Drawing.Size(71, 16);
            this.MRB_6B.TabIndex = 1;
            this.MRB_6B.Text = "18000-6B";
            this.MRB_6B.UseVisualStyleBackColor = true;
            // 
            // MRB_G2
            // 
            this.MRB_G2.AutoSize = true;
            this.MRB_G2.Checked = true;
            this.MRB_G2.Location = new System.Drawing.Point(10, 20);
            this.MRB_G2.Name = "MRB_G2";
            this.MRB_G2.Size = new System.Drawing.Size(71, 16);
            this.MRB_G2.TabIndex = 0;
            this.MRB_G2.TabStop = true;
            this.MRB_G2.Text = "EPCC1-G2";
            this.MRB_G2.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.panel11);
            this.tabPage15.Location = new System.Drawing.Point(4, 27);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(1057, 537);
            this.tabPage15.TabIndex = 3;
            this.tabPage15.Text = "Add-Function";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.groupBox58);
            this.panel11.Controls.Add(this.groupBox57);
            this.panel11.Controls.Add(this.groupBox45);
            this.panel11.Controls.Add(this.gbp_PowerAnt);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1051, 531);
            this.panel11.TabIndex = 0;
            // 
            // groupBox58
            // 
            this.groupBox58.Controls.Add(this.checkBox6);
            this.groupBox58.Controls.Add(this.label194);
            this.groupBox58.Controls.Add(this.com_queryInter);
            this.groupBox58.Controls.Add(this.button7);
            this.groupBox58.Controls.Add(this.label192);
            this.groupBox58.Controls.Add(this.cbb_add);
            this.groupBox58.Controls.Add(this.label193);
            this.groupBox58.Controls.Add(this.cbb_dwell);
            this.groupBox58.Controls.Add(this.button8);
            this.groupBox58.Location = new System.Drawing.Point(4, 174);
            this.groupBox58.Name = "groupBox58";
            this.groupBox58.Size = new System.Drawing.Size(771, 53);
            this.groupBox58.TabIndex = 83;
            this.groupBox58.TabStop = false;
            this.groupBox58.Text = "Query Param";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(511, 23);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(48, 16);
            this.checkBox6.TabIndex = 31;
            this.checkBox6.Text = "Save";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.Location = new System.Drawing.Point(12, 24);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(65, 12);
            this.label194.TabIndex = 30;
            this.label194.Text = "Interval：";
            // 
            // com_queryInter
            // 
            this.com_queryInter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_queryInter.FormattingEnabled = true;
            this.com_queryInter.Items.AddRange(new object[] {
            "00ms",
            "10ms",
            "20ms",
            "30ms",
            "40ms",
            "50ms",
            "60ms"});
            this.com_queryInter.Location = new System.Drawing.Point(76, 20);
            this.com_queryInter.Name = "com_queryInter";
            this.com_queryInter.Size = new System.Drawing.Size(72, 20);
            this.com_queryInter.TabIndex = 29;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(683, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 28;
            this.button7.Text = "Get";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label192
            // 
            this.label192.AutoSize = true;
            this.label192.Location = new System.Drawing.Point(331, 24);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(89, 12);
            this.label192.TabIndex = 27;
            this.label192.Text = "Append times：";
            // 
            // cbb_add
            // 
            this.cbb_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_add.FormattingEnabled = true;
            this.cbb_add.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbb_add.Location = new System.Drawing.Point(423, 20);
            this.cbb_add.Name = "cbb_add";
            this.cbb_add.Size = new System.Drawing.Size(72, 20);
            this.cbb_add.TabIndex = 26;
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.Location = new System.Drawing.Point(161, 24);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(71, 12);
            this.label193.TabIndex = 25;
            this.label193.Text = "DwellTime：";
            // 
            // cbb_dwell
            // 
            this.cbb_dwell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dwell.FormattingEnabled = true;
            this.cbb_dwell.Location = new System.Drawing.Point(235, 20);
            this.cbb_dwell.Name = "cbb_dwell";
            this.cbb_dwell.Size = new System.Drawing.Size(72, 20);
            this.cbb_dwell.TabIndex = 24;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(603, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 23;
            this.button8.Text = "Set";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox57
            // 
            this.groupBox57.Controls.Add(this.rb_enable);
            this.groupBox57.Controls.Add(this.rb_disable);
            this.groupBox57.Controls.Add(this.button5);
            this.groupBox57.Controls.Add(this.button6);
            this.groupBox57.Location = new System.Drawing.Point(781, 7);
            this.groupBox57.Name = "groupBox57";
            this.groupBox57.Size = new System.Drawing.Size(264, 72);
            this.groupBox57.TabIndex = 82;
            this.groupBox57.TabStop = false;
            this.groupBox57.Text = "TagFocus";
            // 
            // rb_enable
            // 
            this.rb_enable.AutoSize = true;
            this.rb_enable.Checked = true;
            this.rb_enable.Location = new System.Drawing.Point(96, 31);
            this.rb_enable.Name = "rb_enable";
            this.rb_enable.Size = new System.Drawing.Size(59, 16);
            this.rb_enable.TabIndex = 11;
            this.rb_enable.TabStop = true;
            this.rb_enable.Text = "Enable";
            this.rb_enable.UseVisualStyleBackColor = true;
            // 
            // rb_disable
            // 
            this.rb_disable.AutoSize = true;
            this.rb_disable.Location = new System.Drawing.Point(14, 31);
            this.rb_disable.Name = "rb_disable";
            this.rb_disable.Size = new System.Drawing.Size(71, 16);
            this.rb_disable.TabIndex = 10;
            this.rb_disable.Text = "Disabled";
            this.rb_disable.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(184, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Get";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(184, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Set";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox45
            // 
            this.groupBox45.Controls.Add(this.rb_pro4);
            this.groupBox45.Controls.Add(this.rb_pro3);
            this.groupBox45.Controls.Add(this.rb_pro2);
            this.groupBox45.Controls.Add(this.rb_pro1);
            this.groupBox45.Controls.Add(this.rb_pro0);
            this.groupBox45.Controls.Add(this.button1);
            this.groupBox45.Controls.Add(this.button2);
            this.groupBox45.Location = new System.Drawing.Point(4, 96);
            this.groupBox45.Name = "groupBox45";
            this.groupBox45.Size = new System.Drawing.Size(771, 72);
            this.groupBox45.TabIndex = 81;
            this.groupBox45.TabStop = false;
            this.groupBox45.Text = "RF link profile.";
            // 
            // rb_pro4
            // 
            this.rb_pro4.AutoSize = true;
            this.rb_pro4.Location = new System.Drawing.Point(243, 47);
            this.rb_pro4.Name = "rb_pro4";
            this.rb_pro4.Size = new System.Drawing.Size(71, 16);
            this.rb_pro4.TabIndex = 14;
            this.rb_pro4.TabStop = true;
            this.rb_pro4.Text = "Profile3";
            this.rb_pro4.UseVisualStyleBackColor = true;
            // 
            // rb_pro3
            // 
            this.rb_pro3.AutoSize = true;
            this.rb_pro3.Location = new System.Drawing.Point(14, 47);
            this.rb_pro3.Name = "rb_pro3";
            this.rb_pro3.Size = new System.Drawing.Size(71, 16);
            this.rb_pro3.TabIndex = 13;
            this.rb_pro3.TabStop = true;
            this.rb_pro3.Text = "Profile4";
            this.rb_pro3.UseVisualStyleBackColor = true;
            // 
            // rb_pro2
            // 
            this.rb_pro2.AutoSize = true;
            this.rb_pro2.Location = new System.Drawing.Point(468, 21);
            this.rb_pro2.Name = "rb_pro2";
            this.rb_pro2.Size = new System.Drawing.Size(71, 16);
            this.rb_pro2.TabIndex = 12;
            this.rb_pro2.TabStop = true;
            this.rb_pro2.Text = "Profile5";
            this.rb_pro2.UseVisualStyleBackColor = true;
            // 
            // rb_pro1
            // 
            this.rb_pro1.AutoSize = true;
            this.rb_pro1.Location = new System.Drawing.Point(243, 21);
            this.rb_pro1.Name = "rb_pro1";
            this.rb_pro1.Size = new System.Drawing.Size(71, 16);
            this.rb_pro1.TabIndex = 11;
            this.rb_pro1.TabStop = true;
            this.rb_pro1.Text = "Profile2";
            this.rb_pro1.UseVisualStyleBackColor = true;
            // 
            // rb_pro0
            // 
            this.rb_pro0.AutoSize = true;
            this.rb_pro0.Location = new System.Drawing.Point(14, 21);
            this.rb_pro0.Name = "rb_pro0";
            this.rb_pro0.Size = new System.Drawing.Size(71, 16);
            this.rb_pro0.TabIndex = 10;
            this.rb_pro0.TabStop = true;
            this.rb_pro0.Text = "Profile1";
            this.rb_pro0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // gbp_PowerAnt
            // 
            this.gbp_PowerAnt.Controls.Add(this.txtPower16);
            this.gbp_PowerAnt.Controls.Add(this.label174);
            this.gbp_PowerAnt.Controls.Add(this.txtPower15);
            this.gbp_PowerAnt.Controls.Add(this.label175);
            this.gbp_PowerAnt.Controls.Add(this.txtPower14);
            this.gbp_PowerAnt.Controls.Add(this.label176);
            this.gbp_PowerAnt.Controls.Add(this.txtPower13);
            this.gbp_PowerAnt.Controls.Add(this.label177);
            this.gbp_PowerAnt.Controls.Add(this.txtPower12);
            this.gbp_PowerAnt.Controls.Add(this.label178);
            this.gbp_PowerAnt.Controls.Add(this.txtPower11);
            this.gbp_PowerAnt.Controls.Add(this.label179);
            this.gbp_PowerAnt.Controls.Add(this.txtPower10);
            this.gbp_PowerAnt.Controls.Add(this.label180);
            this.gbp_PowerAnt.Controls.Add(this.txtPower9);
            this.gbp_PowerAnt.Controls.Add(this.label181);
            this.gbp_PowerAnt.Controls.Add(this.txtPower8);
            this.gbp_PowerAnt.Controls.Add(this.label182);
            this.gbp_PowerAnt.Controls.Add(this.txtPower7);
            this.gbp_PowerAnt.Controls.Add(this.label183);
            this.gbp_PowerAnt.Controls.Add(this.txtPower6);
            this.gbp_PowerAnt.Controls.Add(this.label184);
            this.gbp_PowerAnt.Controls.Add(this.txtPower5);
            this.gbp_PowerAnt.Controls.Add(this.label185);
            this.gbp_PowerAnt.Controls.Add(this.txtPower4);
            this.gbp_PowerAnt.Controls.Add(this.label186);
            this.gbp_PowerAnt.Controls.Add(this.txtPower3);
            this.gbp_PowerAnt.Controls.Add(this.label187);
            this.gbp_PowerAnt.Controls.Add(this.txtPower2);
            this.gbp_PowerAnt.Controls.Add(this.label188);
            this.gbp_PowerAnt.Controls.Add(this.txtPower1);
            this.gbp_PowerAnt.Controls.Add(this.label189);
            this.gbp_PowerAnt.Controls.Add(this.btGetRfPower);
            this.gbp_PowerAnt.Controls.Add(this.checkBox3);
            this.gbp_PowerAnt.Controls.Add(this.btSetRfPower);
            this.gbp_PowerAnt.Location = new System.Drawing.Point(4, 6);
            this.gbp_PowerAnt.Name = "gbp_PowerAnt";
            this.gbp_PowerAnt.Size = new System.Drawing.Size(771, 84);
            this.gbp_PowerAnt.TabIndex = 80;
            this.gbp_PowerAnt.TabStop = false;
            this.gbp_PowerAnt.Text = "Antenna power config(dBm)";
            // 
            // txtPower16
            // 
            this.txtPower16.Location = new System.Drawing.Point(642, 53);
            this.txtPower16.MaxLength = 2;
            this.txtPower16.Name = "txtPower16";
            this.txtPower16.Size = new System.Drawing.Size(26, 21);
            this.txtPower16.TabIndex = 46;
            this.txtPower16.Text = "30";
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(603, 57);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(41, 12);
            this.label174.TabIndex = 45;
            this.label174.Text = "ANT16:";
            // 
            // txtPower15
            // 
            this.txtPower15.Location = new System.Drawing.Point(559, 53);
            this.txtPower15.MaxLength = 2;
            this.txtPower15.Name = "txtPower15";
            this.txtPower15.Size = new System.Drawing.Size(26, 21);
            this.txtPower15.TabIndex = 44;
            this.txtPower15.Text = "30";
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Location = new System.Drawing.Point(520, 57);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(41, 12);
            this.label175.TabIndex = 43;
            this.label175.Text = "ANT15:";
            // 
            // txtPower14
            // 
            this.txtPower14.Location = new System.Drawing.Point(477, 53);
            this.txtPower14.MaxLength = 2;
            this.txtPower14.Name = "txtPower14";
            this.txtPower14.Size = new System.Drawing.Size(26, 21);
            this.txtPower14.TabIndex = 42;
            this.txtPower14.Text = "30";
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Location = new System.Drawing.Point(438, 57);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(41, 12);
            this.label176.TabIndex = 41;
            this.label176.Text = "ANT14:";
            // 
            // txtPower13
            // 
            this.txtPower13.Location = new System.Drawing.Point(388, 53);
            this.txtPower13.MaxLength = 2;
            this.txtPower13.Name = "txtPower13";
            this.txtPower13.Size = new System.Drawing.Size(26, 21);
            this.txtPower13.TabIndex = 40;
            this.txtPower13.Text = "30";
            // 
            // label177
            // 
            this.label177.AutoSize = true;
            this.label177.Location = new System.Drawing.Point(349, 57);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(41, 12);
            this.label177.TabIndex = 39;
            this.label177.Text = "ANT13:";
            // 
            // txtPower12
            // 
            this.txtPower12.Location = new System.Drawing.Point(302, 53);
            this.txtPower12.MaxLength = 2;
            this.txtPower12.Name = "txtPower12";
            this.txtPower12.Size = new System.Drawing.Size(26, 21);
            this.txtPower12.TabIndex = 38;
            this.txtPower12.Text = "30";
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Location = new System.Drawing.Point(263, 57);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(41, 12);
            this.label178.TabIndex = 37;
            this.label178.Text = "ANT12:";
            // 
            // txtPower11
            // 
            this.txtPower11.Location = new System.Drawing.Point(217, 53);
            this.txtPower11.MaxLength = 2;
            this.txtPower11.Name = "txtPower11";
            this.txtPower11.Size = new System.Drawing.Size(26, 21);
            this.txtPower11.TabIndex = 36;
            this.txtPower11.Text = "30";
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Location = new System.Drawing.Point(178, 57);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(41, 12);
            this.label179.TabIndex = 35;
            this.label179.Text = "ANT11:";
            // 
            // txtPower10
            // 
            this.txtPower10.Location = new System.Drawing.Point(132, 53);
            this.txtPower10.MaxLength = 2;
            this.txtPower10.Name = "txtPower10";
            this.txtPower10.Size = new System.Drawing.Size(26, 21);
            this.txtPower10.TabIndex = 34;
            this.txtPower10.Text = "30";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Location = new System.Drawing.Point(93, 57);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(41, 12);
            this.label180.TabIndex = 33;
            this.label180.Text = "ANT10:";
            // 
            // txtPower9
            // 
            this.txtPower9.Location = new System.Drawing.Point(49, 53);
            this.txtPower9.MaxLength = 2;
            this.txtPower9.Name = "txtPower9";
            this.txtPower9.Size = new System.Drawing.Size(26, 21);
            this.txtPower9.TabIndex = 32;
            this.txtPower9.Text = "30";
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Location = new System.Drawing.Point(10, 57);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(35, 12);
            this.label181.TabIndex = 31;
            this.label181.Text = "ANT9:";
            // 
            // txtPower8
            // 
            this.txtPower8.Location = new System.Drawing.Point(640, 19);
            this.txtPower8.MaxLength = 2;
            this.txtPower8.Name = "txtPower8";
            this.txtPower8.Size = new System.Drawing.Size(26, 21);
            this.txtPower8.TabIndex = 30;
            this.txtPower8.Text = "30";
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Location = new System.Drawing.Point(601, 23);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(35, 12);
            this.label182.TabIndex = 29;
            this.label182.Text = "ANT8:";
            // 
            // txtPower7
            // 
            this.txtPower7.Location = new System.Drawing.Point(557, 19);
            this.txtPower7.MaxLength = 2;
            this.txtPower7.Name = "txtPower7";
            this.txtPower7.Size = new System.Drawing.Size(26, 21);
            this.txtPower7.TabIndex = 28;
            this.txtPower7.Text = "30";
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Location = new System.Drawing.Point(518, 23);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(35, 12);
            this.label183.TabIndex = 27;
            this.label183.Text = "ANT7:";
            // 
            // txtPower6
            // 
            this.txtPower6.Location = new System.Drawing.Point(475, 19);
            this.txtPower6.MaxLength = 2;
            this.txtPower6.Name = "txtPower6";
            this.txtPower6.Size = new System.Drawing.Size(26, 21);
            this.txtPower6.TabIndex = 26;
            this.txtPower6.Text = "30";
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.Location = new System.Drawing.Point(436, 23);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(35, 12);
            this.label184.TabIndex = 25;
            this.label184.Text = "ANT6:";
            // 
            // txtPower5
            // 
            this.txtPower5.Location = new System.Drawing.Point(386, 19);
            this.txtPower5.MaxLength = 2;
            this.txtPower5.Name = "txtPower5";
            this.txtPower5.Size = new System.Drawing.Size(26, 21);
            this.txtPower5.TabIndex = 24;
            this.txtPower5.Text = "30";
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.Location = new System.Drawing.Point(347, 23);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(35, 12);
            this.label185.TabIndex = 23;
            this.label185.Text = "ANT5:";
            // 
            // txtPower4
            // 
            this.txtPower4.Location = new System.Drawing.Point(300, 19);
            this.txtPower4.MaxLength = 2;
            this.txtPower4.Name = "txtPower4";
            this.txtPower4.Size = new System.Drawing.Size(26, 21);
            this.txtPower4.TabIndex = 22;
            this.txtPower4.Text = "30";
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Location = new System.Drawing.Point(261, 23);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(35, 12);
            this.label186.TabIndex = 21;
            this.label186.Text = "ANT4:";
            // 
            // txtPower3
            // 
            this.txtPower3.Location = new System.Drawing.Point(215, 19);
            this.txtPower3.MaxLength = 2;
            this.txtPower3.Name = "txtPower3";
            this.txtPower3.Size = new System.Drawing.Size(26, 21);
            this.txtPower3.TabIndex = 20;
            this.txtPower3.Text = "30";
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Location = new System.Drawing.Point(176, 23);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(35, 12);
            this.label187.TabIndex = 19;
            this.label187.Text = "ANT3:";
            // 
            // txtPower2
            // 
            this.txtPower2.Location = new System.Drawing.Point(130, 19);
            this.txtPower2.MaxLength = 2;
            this.txtPower2.Name = "txtPower2";
            this.txtPower2.Size = new System.Drawing.Size(26, 21);
            this.txtPower2.TabIndex = 18;
            this.txtPower2.Text = "30";
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Location = new System.Drawing.Point(91, 23);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(35, 12);
            this.label188.TabIndex = 17;
            this.label188.Text = "ANT2:";
            // 
            // txtPower1
            // 
            this.txtPower1.Location = new System.Drawing.Point(47, 19);
            this.txtPower1.MaxLength = 2;
            this.txtPower1.Name = "txtPower1";
            this.txtPower1.Size = new System.Drawing.Size(26, 21);
            this.txtPower1.TabIndex = 16;
            this.txtPower1.Text = "30";
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Location = new System.Drawing.Point(8, 23);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(35, 12);
            this.label189.TabIndex = 15;
            this.label189.Text = "ANT1:";
            // 
            // btGetRfPower
            // 
            this.btGetRfPower.Location = new System.Drawing.Point(681, 57);
            this.btGetRfPower.Name = "btGetRfPower";
            this.btGetRfPower.Size = new System.Drawing.Size(77, 23);
            this.btGetRfPower.TabIndex = 11;
            this.btGetRfPower.Text = "Get";
            this.btGetRfPower.UseVisualStyleBackColor = true;
            this.btGetRfPower.Click += new System.EventHandler(this.btGetRfPower_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(686, 14);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 16);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Save";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // btSetRfPower
            // 
            this.btSetRfPower.Location = new System.Drawing.Point(681, 32);
            this.btSetRfPower.Name = "btSetRfPower";
            this.btSetRfPower.Size = new System.Drawing.Size(77, 23);
            this.btSetRfPower.TabIndex = 5;
            this.btSetRfPower.Text = "Set";
            this.btSetRfPower.UseVisualStyleBackColor = true;
            this.btSetRfPower.Click += new System.EventHandler(this.btSetRfPower_Click);
            // 
            // Main_Page2
            // 
            this.Main_Page2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Main_Page2.Controls.Add(this.tabControl2);
            this.Main_Page2.Location = new System.Drawing.Point(4, 27);
            this.Main_Page2.Name = "Main_Page2";
            this.Main_Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page2.Size = new System.Drawing.Size(1075, 571);
            this.Main_Page2.TabIndex = 1;
            this.Main_Page2.Text = "EPCC1-G2";
            this.Main_Page2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage_answer);
            this.tabControl2.Controls.Add(this.tabPage_active);
            this.tabControl2.Controls.Add(this.tabPage_Realtime);
            this.tabControl2.Controls.Add(this.tabPage_Buff);
            this.tabControl2.Controls.Add(this.tabPage_fastscan);
            this.tabControl2.Controls.Add(this.tabPage_RW);
            this.tabControl2.ItemSize = new System.Drawing.Size(120, 23);
            this.tabControl2.Location = new System.Drawing.Point(-1, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1071, 565);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // tabPage_answer
            // 
            this.tabPage_answer.Controls.Add(this.chk_phase);
            this.tabPage_answer.Location = new System.Drawing.Point(4, 27);
            this.tabPage_answer.Name = "tabPage_answer";
            this.tabPage_answer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_answer.Size = new System.Drawing.Size(1063, 534);
            this.tabPage_answer.TabIndex = 0;
            this.tabPage_answer.Text = "Answer Mode";
            this.tabPage_answer.UseVisualStyleBackColor = true;
            // 
            // chk_phase
            // 
            this.chk_phase.Controls.Add(this.group_ant1);
            this.chk_phase.Controls.Add(this.lxLedControl6);
            this.chk_phase.Controls.Add(this.label119);
            this.chk_phase.Controls.Add(this.lxLedControl5);
            this.chk_phase.Controls.Add(this.label9);
            this.chk_phase.Controls.Add(this.lxLedControl4);
            this.chk_phase.Controls.Add(this.label8);
            this.chk_phase.Controls.Add(this.lxLedControl3);
            this.chk_phase.Controls.Add(this.label7);
            this.chk_phase.Controls.Add(this.lxLedControl2);
            this.chk_phase.Controls.Add(this.label6);
            this.chk_phase.Controls.Add(this.lxLedControl1);
            this.chk_phase.Controls.Add(this.label5);
            this.chk_phase.Controls.Add(this.gbp_MixRead);
            this.chk_phase.Controls.Add(this.groupBox5);
            this.chk_phase.Controls.Add(this.groupBox4);
            this.chk_phase.Controls.Add(this.groupBox2);
            this.chk_phase.Enabled = false;
            this.chk_phase.Location = new System.Drawing.Point(2, 2);
            this.chk_phase.Name = "chk_phase";
            this.chk_phase.Size = new System.Drawing.Size(1066, 530);
            this.chk_phase.TabIndex = 0;
            // 
            // group_ant1
            // 
            this.group_ant1.Controls.Add(this.check_ant16);
            this.group_ant1.Controls.Add(this.check_ant15);
            this.group_ant1.Controls.Add(this.check_ant14);
            this.group_ant1.Controls.Add(this.check_ant13);
            this.group_ant1.Controls.Add(this.check_ant12);
            this.group_ant1.Controls.Add(this.check_ant11);
            this.group_ant1.Controls.Add(this.check_ant10);
            this.group_ant1.Controls.Add(this.check_ant9);
            this.group_ant1.Controls.Add(this.check_ant8);
            this.group_ant1.Controls.Add(this.check_ant7);
            this.group_ant1.Controls.Add(this.check_ant6);
            this.group_ant1.Controls.Add(this.check_ant5);
            this.group_ant1.Controls.Add(this.check_ant4);
            this.group_ant1.Controls.Add(this.check_ant3);
            this.group_ant1.Controls.Add(this.check_ant2);
            this.group_ant1.Controls.Add(this.check_ant1);
            this.group_ant1.Location = new System.Drawing.Point(8, 78);
            this.group_ant1.Name = "group_ant1";
            this.group_ant1.Size = new System.Drawing.Size(89, 441);
            this.group_ant1.TabIndex = 44;
            this.group_ant1.TabStop = false;
            this.group_ant1.Text = "Antenna";
            // 
            // check_ant16
            // 
            this.check_ant16.AutoSize = true;
            this.check_ant16.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant16.Location = new System.Drawing.Point(16, 327);
            this.check_ant16.Name = "check_ant16";
            this.check_ant16.Size = new System.Drawing.Size(54, 16);
            this.check_ant16.TabIndex = 49;
            this.check_ant16.Text = "ANT16";
            this.check_ant16.UseVisualStyleBackColor = true;
            // 
            // check_ant15
            // 
            this.check_ant15.AutoSize = true;
            this.check_ant15.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant15.Location = new System.Drawing.Point(16, 306);
            this.check_ant15.Name = "check_ant15";
            this.check_ant15.Size = new System.Drawing.Size(54, 16);
            this.check_ant15.TabIndex = 48;
            this.check_ant15.Text = "ANT15";
            this.check_ant15.UseVisualStyleBackColor = true;
            // 
            // check_ant14
            // 
            this.check_ant14.AutoSize = true;
            this.check_ant14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant14.Location = new System.Drawing.Point(16, 286);
            this.check_ant14.Name = "check_ant14";
            this.check_ant14.Size = new System.Drawing.Size(54, 16);
            this.check_ant14.TabIndex = 47;
            this.check_ant14.Text = "ANT14";
            this.check_ant14.UseVisualStyleBackColor = true;
            // 
            // check_ant13
            // 
            this.check_ant13.AutoSize = true;
            this.check_ant13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant13.Location = new System.Drawing.Point(16, 266);
            this.check_ant13.Name = "check_ant13";
            this.check_ant13.Size = new System.Drawing.Size(54, 16);
            this.check_ant13.TabIndex = 46;
            this.check_ant13.Text = "ANT13";
            this.check_ant13.UseVisualStyleBackColor = true;
            // 
            // check_ant12
            // 
            this.check_ant12.AutoSize = true;
            this.check_ant12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant12.Location = new System.Drawing.Point(16, 245);
            this.check_ant12.Name = "check_ant12";
            this.check_ant12.Size = new System.Drawing.Size(54, 16);
            this.check_ant12.TabIndex = 45;
            this.check_ant12.Text = "ANT12";
            this.check_ant12.UseVisualStyleBackColor = true;
            // 
            // check_ant11
            // 
            this.check_ant11.AutoSize = true;
            this.check_ant11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant11.Location = new System.Drawing.Point(16, 225);
            this.check_ant11.Name = "check_ant11";
            this.check_ant11.Size = new System.Drawing.Size(54, 16);
            this.check_ant11.TabIndex = 44;
            this.check_ant11.Text = "ANT11";
            this.check_ant11.UseVisualStyleBackColor = true;
            // 
            // check_ant10
            // 
            this.check_ant10.AutoSize = true;
            this.check_ant10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant10.Location = new System.Drawing.Point(16, 203);
            this.check_ant10.Name = "check_ant10";
            this.check_ant10.Size = new System.Drawing.Size(54, 16);
            this.check_ant10.TabIndex = 43;
            this.check_ant10.Text = "ANT10";
            this.check_ant10.UseVisualStyleBackColor = true;
            // 
            // check_ant9
            // 
            this.check_ant9.AutoSize = true;
            this.check_ant9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant9.Location = new System.Drawing.Point(16, 183);
            this.check_ant9.Name = "check_ant9";
            this.check_ant9.Size = new System.Drawing.Size(48, 16);
            this.check_ant9.TabIndex = 42;
            this.check_ant9.Text = "ANT9";
            this.check_ant9.UseVisualStyleBackColor = true;
            // 
            // check_ant8
            // 
            this.check_ant8.AutoSize = true;
            this.check_ant8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant8.Location = new System.Drawing.Point(16, 163);
            this.check_ant8.Name = "check_ant8";
            this.check_ant8.Size = new System.Drawing.Size(48, 16);
            this.check_ant8.TabIndex = 41;
            this.check_ant8.Text = "ANT8";
            this.check_ant8.UseVisualStyleBackColor = true;
            // 
            // check_ant7
            // 
            this.check_ant7.AutoSize = true;
            this.check_ant7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant7.Location = new System.Drawing.Point(16, 142);
            this.check_ant7.Name = "check_ant7";
            this.check_ant7.Size = new System.Drawing.Size(48, 16);
            this.check_ant7.TabIndex = 40;
            this.check_ant7.Text = "ANT7";
            this.check_ant7.UseVisualStyleBackColor = true;
            // 
            // check_ant6
            // 
            this.check_ant6.AutoSize = true;
            this.check_ant6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant6.Location = new System.Drawing.Point(16, 122);
            this.check_ant6.Name = "check_ant6";
            this.check_ant6.Size = new System.Drawing.Size(48, 16);
            this.check_ant6.TabIndex = 39;
            this.check_ant6.Text = "ANT6";
            this.check_ant6.UseVisualStyleBackColor = true;
            // 
            // check_ant5
            // 
            this.check_ant5.AutoSize = true;
            this.check_ant5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant5.Location = new System.Drawing.Point(16, 102);
            this.check_ant5.Name = "check_ant5";
            this.check_ant5.Size = new System.Drawing.Size(48, 16);
            this.check_ant5.TabIndex = 38;
            this.check_ant5.Text = "ANT5";
            this.check_ant5.UseVisualStyleBackColor = true;
            // 
            // check_ant4
            // 
            this.check_ant4.AutoSize = true;
            this.check_ant4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant4.Location = new System.Drawing.Point(16, 81);
            this.check_ant4.Name = "check_ant4";
            this.check_ant4.Size = new System.Drawing.Size(48, 16);
            this.check_ant4.TabIndex = 37;
            this.check_ant4.Text = "ANT4";
            this.check_ant4.UseVisualStyleBackColor = true;
            // 
            // check_ant3
            // 
            this.check_ant3.AutoSize = true;
            this.check_ant3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant3.Location = new System.Drawing.Point(16, 61);
            this.check_ant3.Name = "check_ant3";
            this.check_ant3.Size = new System.Drawing.Size(48, 16);
            this.check_ant3.TabIndex = 36;
            this.check_ant3.Text = "ANT3";
            this.check_ant3.UseVisualStyleBackColor = true;
            // 
            // check_ant2
            // 
            this.check_ant2.AutoSize = true;
            this.check_ant2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant2.Location = new System.Drawing.Point(16, 39);
            this.check_ant2.Name = "check_ant2";
            this.check_ant2.Size = new System.Drawing.Size(48, 16);
            this.check_ant2.TabIndex = 35;
            this.check_ant2.Text = "ANT2";
            this.check_ant2.UseVisualStyleBackColor = true;
            // 
            // check_ant1
            // 
            this.check_ant1.AutoSize = true;
            this.check_ant1.Checked = true;
            this.check_ant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_ant1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant1.Location = new System.Drawing.Point(16, 19);
            this.check_ant1.Name = "check_ant1";
            this.check_ant1.Size = new System.Drawing.Size(48, 16);
            this.check_ant1.TabIndex = 34;
            this.check_ant1.Text = "ANT1";
            this.check_ant1.UseVisualStyleBackColor = true;
            // 
            // lxLedControl6
            // 
            this.lxLedControl6.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl6.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl6.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl6.BevelRate = 0.5F;
            this.lxLedControl6.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl6.BorderWidth = 3;
            this.lxLedControl6.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl6.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl6.HighlightOpaque = ((byte)(50));
            this.lxLedControl6.Location = new System.Drawing.Point(805, 223);
            this.lxLedControl6.Name = "lxLedControl6";
            this.lxLedControl6.RoundCorner = true;
            this.lxLedControl6.ShowHighlight = true;
            this.lxLedControl6.Size = new System.Drawing.Size(249, 81);
            this.lxLedControl6.TabIndex = 43;
            this.lxLedControl6.Text = "0";
            this.lxLedControl6.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl6.TotalCharCount = 6;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(807, 204);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(71, 12);
            this.label119.TabIndex = 42;
            this.label119.Text = "TID Number:";
            // 
            // lxLedControl5
            // 
            this.lxLedControl5.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl5.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl5.BevelRate = 0.5F;
            this.lxLedControl5.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl5.BorderWidth = 3;
            this.lxLedControl5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl5.HighlightOpaque = ((byte)(50));
            this.lxLedControl5.Location = new System.Drawing.Point(944, 444);
            this.lxLedControl5.Name = "lxLedControl5";
            this.lxLedControl5.RoundCorner = true;
            this.lxLedControl5.ShowHighlight = true;
            this.lxLedControl5.Size = new System.Drawing.Size(109, 28);
            this.lxLedControl5.TabIndex = 41;
            this.lxLedControl5.Text = "0";
            this.lxLedControl5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl5.TotalCharCount = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(942, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "Total-cmd-time(ms):";
            // 
            // lxLedControl4
            // 
            this.lxLedControl4.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl4.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl4.BevelRate = 0.5F;
            this.lxLedControl4.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl4.BorderWidth = 3;
            this.lxLedControl4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl4.HighlightOpaque = ((byte)(50));
            this.lxLedControl4.Location = new System.Drawing.Point(800, 443);
            this.lxLedControl4.Name = "lxLedControl4";
            this.lxLedControl4.RoundCorner = true;
            this.lxLedControl4.ShowHighlight = true;
            this.lxLedControl4.Size = new System.Drawing.Size(109, 29);
            this.lxLedControl4.TabIndex = 39;
            this.lxLedControl4.Text = "0";
            this.lxLedControl4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl4.TotalCharCount = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(798, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "Total tag number:";
            // 
            // lxLedControl3
            // 
            this.lxLedControl3.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl3.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl3.BevelRate = 0.5F;
            this.lxLedControl3.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl3.BorderWidth = 3;
            this.lxLedControl3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl3.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl3.HighlightOpaque = ((byte)(50));
            this.lxLedControl3.Location = new System.Drawing.Point(944, 362);
            this.lxLedControl3.Name = "lxLedControl3";
            this.lxLedControl3.RoundCorner = true;
            this.lxLedControl3.ShowHighlight = true;
            this.lxLedControl3.Size = new System.Drawing.Size(112, 29);
            this.lxLedControl3.TabIndex = 37;
            this.lxLedControl3.Text = "0";
            this.lxLedControl3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl3.TotalCharCount = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(942, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "cmd time(ms):";
            // 
            // lxLedControl2
            // 
            this.lxLedControl2.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl2.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl2.BevelRate = 0.5F;
            this.lxLedControl2.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl2.BorderWidth = 3;
            this.lxLedControl2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl2.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl2.HighlightOpaque = ((byte)(50));
            this.lxLedControl2.Location = new System.Drawing.Point(800, 362);
            this.lxLedControl2.Name = "lxLedControl2";
            this.lxLedControl2.RoundCorner = true;
            this.lxLedControl2.ShowHighlight = true;
            this.lxLedControl2.Size = new System.Drawing.Size(113, 29);
            this.lxLedControl2.TabIndex = 35;
            this.lxLedControl2.Text = "0";
            this.lxLedControl2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl2.TotalCharCount = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(798, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "Speed:";
            // 
            // lxLedControl1
            // 
            this.lxLedControl1.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl1.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl1.BevelRate = 0.5F;
            this.lxLedControl1.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl1.BorderWidth = 3;
            this.lxLedControl1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl1.HighlightOpaque = ((byte)(50));
            this.lxLedControl1.Location = new System.Drawing.Point(805, 105);
            this.lxLedControl1.Name = "lxLedControl1";
            this.lxLedControl1.RoundCorner = true;
            this.lxLedControl1.ShowHighlight = true;
            this.lxLedControl1.Size = new System.Drawing.Size(249, 81);
            this.lxLedControl1.TabIndex = 33;
            this.lxLedControl1.Text = "0";
            this.lxLedControl1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl1.TotalCharCount = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(807, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "EPC Number:";
            // 
            // gbp_MixRead
            // 
            this.gbp_MixRead.Controls.Add(this.text_readpsd);
            this.gbp_MixRead.Controls.Add(this.label118);
            this.gbp_MixRead.Controls.Add(this.text_readLen);
            this.gbp_MixRead.Controls.Add(this.label117);
            this.gbp_MixRead.Controls.Add(this.text_readadr);
            this.gbp_MixRead.Controls.Add(this.label115);
            this.gbp_MixRead.Controls.Add(this.com_MixMem);
            this.gbp_MixRead.Controls.Add(this.label114);
            this.gbp_MixRead.Enabled = false;
            this.gbp_MixRead.Location = new System.Drawing.Point(433, 0);
            this.gbp_MixRead.Name = "gbp_MixRead";
            this.gbp_MixRead.Size = new System.Drawing.Size(222, 71);
            this.gbp_MixRead.TabIndex = 29;
            this.gbp_MixRead.TabStop = false;
            this.gbp_MixRead.Text = "Mix";
            // 
            // text_readpsd
            // 
            this.text_readpsd.Location = new System.Drawing.Point(64, 42);
            this.text_readpsd.MaxLength = 8;
            this.text_readpsd.Name = "text_readpsd";
            this.text_readpsd.Size = new System.Drawing.Size(65, 21);
            this.text_readpsd.TabIndex = 7;
            this.text_readpsd.Text = "00000000";
            this.text_readpsd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(6, 46);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(59, 12);
            this.label118.TabIndex = 6;
            this.label118.Text = "Password:";
            // 
            // text_readLen
            // 
            this.text_readLen.Location = new System.Drawing.Point(176, 44);
            this.text_readLen.MaxLength = 2;
            this.text_readLen.Name = "text_readLen";
            this.text_readLen.Size = new System.Drawing.Size(41, 21);
            this.text_readLen.TabIndex = 5;
            this.text_readLen.Text = "04";
            this.text_readLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(136, 48);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(29, 12);
            this.label117.TabIndex = 4;
            this.label117.Text = "Len:";
            // 
            // text_readadr
            // 
            this.text_readadr.Location = new System.Drawing.Point(176, 13);
            this.text_readadr.MaxLength = 4;
            this.text_readadr.Name = "text_readadr";
            this.text_readadr.Size = new System.Drawing.Size(41, 21);
            this.text_readadr.TabIndex = 3;
            this.text_readadr.Text = "0002";
            this.text_readadr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(136, 17);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(35, 12);
            this.label115.TabIndex = 2;
            this.label115.Text = "Addr:";
            // 
            // com_MixMem
            // 
            this.com_MixMem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MixMem.FormattingEnabled = true;
            this.com_MixMem.Items.AddRange(new object[] {
            "Reserve",
            "EPC",
            "TID",
            "User"});
            this.com_MixMem.Location = new System.Drawing.Point(64, 12);
            this.com_MixMem.Name = "com_MixMem";
            this.com_MixMem.Size = new System.Drawing.Size(66, 20);
            this.com_MixMem.TabIndex = 1;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(5, 16);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(29, 12);
            this.label114.TabIndex = 0;
            this.label114.Text = "Mem:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(100, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(704, 445);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tag list(No Repeat)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(691, 421);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.check_phase);
            this.groupBox4.Controls.Add(this.checkBox_rate);
            this.groupBox4.Controls.Add(this.label80);
            this.groupBox4.Controls.Add(this.text_target);
            this.groupBox4.Controls.Add(this.check_num);
            this.groupBox4.Controls.Add(this.com_Target);
            this.groupBox4.Controls.Add(this.label79);
            this.groupBox4.Controls.Add(this.com_scantime);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.com_S);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.com_Q);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Location = new System.Drawing.Point(654, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 71);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // check_phase
            // 
            this.check_phase.AutoSize = true;
            this.check_phase.Location = new System.Drawing.Point(342, 46);
            this.check_phase.Name = "check_phase";
            this.check_phase.Size = new System.Drawing.Size(54, 16);
            this.check_phase.TabIndex = 38;
            this.check_phase.Text = "Phase";
            this.check_phase.UseVisualStyleBackColor = true;
            // 
            // checkBox_rate
            // 
            this.checkBox_rate.AutoSize = true;
            this.checkBox_rate.Location = new System.Drawing.Point(317, 63);
            this.checkBox_rate.Name = "checkBox_rate";
            this.checkBox_rate.Size = new System.Drawing.Size(96, 16);
            this.checkBox_rate.TabIndex = 37;
            this.checkBox_rate.Text = "return Speed";
            this.checkBox_rate.UseVisualStyleBackColor = true;
            this.checkBox_rate.Visible = false;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(184, 48);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(173, 12);
            this.label80.TabIndex = 36;
            this.label80.Text = "times no tag A/B conversion ";
            // 
            // text_target
            // 
            this.text_target.ForeColor = System.Drawing.Color.Red;
            this.text_target.Location = new System.Drawing.Point(139, 42);
            this.text_target.MaxLength = 2;
            this.text_target.Name = "text_target";
            this.text_target.Size = new System.Drawing.Size(43, 21);
            this.text_target.TabIndex = 35;
            this.text_target.Text = "5";
            this.text_target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_target.TextChanged += new System.EventHandler(this.text_target_TextChanged);
            this.text_target.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // check_num
            // 
            this.check_num.AutoSize = true;
            this.check_num.Checked = true;
            this.check_num.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_num.Location = new System.Drawing.Point(122, 46);
            this.check_num.Name = "check_num";
            this.check_num.Size = new System.Drawing.Size(15, 14);
            this.check_num.TabIndex = 34;
            this.check_num.UseVisualStyleBackColor = true;
            // 
            // com_Target
            // 
            this.com_Target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Target.FormattingEnabled = true;
            this.com_Target.Items.AddRange(new object[] {
            "A",
            "B"});
            this.com_Target.Location = new System.Drawing.Point(58, 42);
            this.com_Target.Name = "com_Target";
            this.com_Target.Size = new System.Drawing.Size(51, 20);
            this.com_Target.TabIndex = 33;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(13, 48);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(47, 12);
            this.label79.TabIndex = 32;
            this.label79.Text = "Target:";
            // 
            // com_scantime
            // 
            this.com_scantime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_scantime.FormattingEnabled = true;
            this.com_scantime.Location = new System.Drawing.Point(316, 16);
            this.com_scantime.Name = "com_scantime";
            this.com_scantime.Size = new System.Drawing.Size(77, 20);
            this.com_scantime.TabIndex = 31;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(249, 19);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(59, 12);
            this.label39.TabIndex = 30;
            this.label39.Text = "ScanTime:";
            // 
            // com_S
            // 
            this.com_S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_S.FormattingEnabled = true;
            this.com_S.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "AUTO"});
            this.com_S.Location = new System.Drawing.Point(182, 16);
            this.com_S.Name = "com_S";
            this.com_S.Size = new System.Drawing.Size(59, 20);
            this.com_S.TabIndex = 29;
            this.com_S.SelectedIndexChanged += new System.EventHandler(this.com_S_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(120, 20);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 12);
            this.label32.TabIndex = 28;
            this.label32.Text = "Session：";
            // 
            // com_Q
            // 
            this.com_Q.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Q.FormattingEnabled = true;
            this.com_Q.Items.AddRange(new object[] {
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
            this.com_Q.Location = new System.Drawing.Point(58, 15);
            this.com_Q.Name = "com_Q";
            this.com_Q.Size = new System.Drawing.Size(51, 20);
            this.com_Q.TabIndex = 27;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(15, 19);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 12);
            this.label31.TabIndex = 26;
            this.label31.Text = "Q:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_fastid);
            this.groupBox2.Controls.Add(this.rb_mix);
            this.groupBox2.Controls.Add(this.rb_tid);
            this.groupBox2.Controls.Add(this.rb_epc);
            this.groupBox2.Controls.Add(this.btIventoryG2);
            this.groupBox2.Location = new System.Drawing.Point(5, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 71);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // rb_fastid
            // 
            this.rb_fastid.AutoSize = true;
            this.rb_fastid.Location = new System.Drawing.Point(259, 34);
            this.rb_fastid.Name = "rb_fastid";
            this.rb_fastid.Size = new System.Drawing.Size(59, 16);
            this.rb_fastid.TabIndex = 4;
            this.rb_fastid.Text = "FastID";
            this.rb_fastid.UseVisualStyleBackColor = true;
            this.rb_fastid.CheckedChanged += new System.EventHandler(this.rb_fastid_CheckedChanged);
            // 
            // rb_mix
            // 
            this.rb_mix.AutoSize = true;
            this.rb_mix.Location = new System.Drawing.Point(348, 34);
            this.rb_mix.Name = "rb_mix";
            this.rb_mix.Size = new System.Drawing.Size(41, 16);
            this.rb_mix.TabIndex = 3;
            this.rb_mix.Text = "Mix";
            this.rb_mix.UseVisualStyleBackColor = true;
            this.rb_mix.Click += new System.EventHandler(this.rb_mix_Click);
            this.rb_mix.CheckedChanged += new System.EventHandler(this.rb_mix_CheckedChanged);
            // 
            // rb_tid
            // 
            this.rb_tid.AutoSize = true;
            this.rb_tid.Location = new System.Drawing.Point(188, 34);
            this.rb_tid.Name = "rb_tid";
            this.rb_tid.Size = new System.Drawing.Size(41, 16);
            this.rb_tid.TabIndex = 2;
            this.rb_tid.Text = "TID";
            this.rb_tid.UseVisualStyleBackColor = true;
            this.rb_tid.CheckedChanged += new System.EventHandler(this.rb_tid_CheckedChanged);
            // 
            // rb_epc
            // 
            this.rb_epc.AutoSize = true;
            this.rb_epc.Checked = true;
            this.rb_epc.Location = new System.Drawing.Point(120, 34);
            this.rb_epc.Name = "rb_epc";
            this.rb_epc.Size = new System.Drawing.Size(41, 16);
            this.rb_epc.TabIndex = 1;
            this.rb_epc.TabStop = true;
            this.rb_epc.Text = "EPC";
            this.rb_epc.UseVisualStyleBackColor = true;
            this.rb_epc.CheckedChanged += new System.EventHandler(this.rb_epc_CheckedChanged);
            // 
            // btIventoryG2
            // 
            this.btIventoryG2.BackColor = System.Drawing.Color.Transparent;
            this.btIventoryG2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btIventoryG2.ForeColor = System.Drawing.Color.DarkBlue;
            this.btIventoryG2.Location = new System.Drawing.Point(6, 20);
            this.btIventoryG2.Name = "btIventoryG2";
            this.btIventoryG2.Size = new System.Drawing.Size(109, 40);
            this.btIventoryG2.TabIndex = 0;
            this.btIventoryG2.Text = "Start";
            this.btIventoryG2.UseVisualStyleBackColor = false;
            this.btIventoryG2.Click += new System.EventHandler(this.btIventoryG2_Click);
            // 
            // tabPage_active
            // 
            this.tabPage_active.Controls.Add(this.panel3);
            this.tabPage_active.Location = new System.Drawing.Point(4, 27);
            this.tabPage_active.Name = "tabPage_active";
            this.tabPage_active.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_active.Size = new System.Drawing.Size(1063, 534);
            this.tabPage_active.TabIndex = 1;
            this.tabPage_active.Text = "Auto-running";
            this.tabPage_active.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox9);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.groupBox8);
            this.panel3.Controls.Add(this.groupBox7);
            this.panel3.Controls.Add(this.groupBox6);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 532);
            this.panel3.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.lxLed_toltime);
            this.groupBox9.Controls.Add(this.dataGridView2);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.lxLed_toltag);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.lxLed_cmdsud);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.lxLed_Num);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Location = new System.Drawing.Point(6, 91);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1053, 438);
            this.groupBox9.TabIndex = 20;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Data";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label20.Location = new System.Drawing.Point(0, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 22;
            this.label20.Text = "Tag list:";
            // 
            // lxLed_toltime
            // 
            this.lxLed_toltime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_toltime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_toltime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_toltime.BevelRate = 0.5F;
            this.lxLed_toltime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_toltime.BorderWidth = 3;
            this.lxLed_toltime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_toltime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_toltime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_toltime.HighlightOpaque = ((byte)(50));
            this.lxLed_toltime.Location = new System.Drawing.Point(749, 132);
            this.lxLed_toltime.Name = "lxLed_toltime";
            this.lxLed_toltime.RoundCorner = true;
            this.lxLed_toltime.ShowHighlight = true;
            this.lxLed_toltime.Size = new System.Drawing.Size(162, 30);
            this.lxLed_toltime.TabIndex = 32;
            this.lxLed_toltime.Text = "0";
            this.lxLed_toltime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_toltime.TotalCharCount = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(1, 189);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1057, 251);
            this.dataGridView2.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "EPC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 380;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "First read time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Last read time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ant";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Times";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label19.Location = new System.Drawing.Point(747, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 12);
            this.label19.TabIndex = 31;
            this.label19.Text = "Total Time(ms):";
            // 
            // lxLed_toltag
            // 
            this.lxLed_toltag.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_toltag.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_toltag.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_toltag.BevelRate = 0.5F;
            this.lxLed_toltag.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_toltag.BorderWidth = 3;
            this.lxLed_toltag.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_toltag.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_toltag.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_toltag.HighlightOpaque = ((byte)(50));
            this.lxLed_toltag.Location = new System.Drawing.Point(749, 59);
            this.lxLed_toltag.Name = "lxLed_toltag";
            this.lxLed_toltag.RoundCorner = true;
            this.lxLed_toltag.ShowHighlight = true;
            this.lxLed_toltag.Size = new System.Drawing.Size(162, 30);
            this.lxLed_toltag.TabIndex = 30;
            this.lxLed_toltag.Text = "0";
            this.lxLed_toltag.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_toltag.TotalCharCount = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(747, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 12);
            this.label18.TabIndex = 29;
            this.label18.Text = "Total Number:";
            // 
            // lxLed_cmdsud
            // 
            this.lxLed_cmdsud.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_cmdsud.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_cmdsud.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_cmdsud.BevelRate = 0.5F;
            this.lxLed_cmdsud.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_cmdsud.BorderWidth = 3;
            this.lxLed_cmdsud.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_cmdsud.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_cmdsud.ForeColor = System.Drawing.Color.Purple;
            this.lxLed_cmdsud.HighlightOpaque = ((byte)(50));
            this.lxLed_cmdsud.Location = new System.Drawing.Point(488, 80);
            this.lxLed_cmdsud.Name = "lxLed_cmdsud";
            this.lxLed_cmdsud.RoundCorner = true;
            this.lxLed_cmdsud.ShowHighlight = true;
            this.lxLed_cmdsud.Size = new System.Drawing.Size(171, 82);
            this.lxLed_cmdsud.TabIndex = 26;
            this.lxLed_cmdsud.Text = "0";
            this.lxLed_cmdsud.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_cmdsud.TotalCharCount = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label17.Location = new System.Drawing.Point(490, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 25;
            this.label17.Text = "Speed:";
            // 
            // lxLed_Num
            // 
            this.lxLed_Num.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Num.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Num.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Num.BevelRate = 0.5F;
            this.lxLed_Num.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Num.BorderWidth = 3;
            this.lxLed_Num.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Num.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Num.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Num.HighlightOpaque = ((byte)(50));
            this.lxLed_Num.Location = new System.Drawing.Point(101, 35);
            this.lxLed_Num.Name = "lxLed_Num";
            this.lxLed_Num.RoundCorner = true;
            this.lxLed_Num.ShowHighlight = true;
            this.lxLed_Num.Size = new System.Drawing.Size(329, 127);
            this.lxLed_Num.TabIndex = 22;
            this.lxLed_Num.Text = "0";
            this.lxLed_Num.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 21;
            this.label13.Text = "Tag Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(21, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = ";";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btClearBuffer);
            this.groupBox8.Location = new System.Drawing.Point(703, 26);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(357, 66);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            // 
            // btClearBuffer
            // 
            this.btClearBuffer.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearBuffer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btClearBuffer.Location = new System.Drawing.Point(21, 16);
            this.btClearBuffer.Name = "btClearBuffer";
            this.btClearBuffer.Size = new System.Drawing.Size(296, 40);
            this.btClearBuffer.TabIndex = 0;
            this.btClearBuffer.Text = "Clear data";
            this.btClearBuffer.UseVisualStyleBackColor = true;
            this.btClearBuffer.Click += new System.EventHandler(this.btClearBuffer_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btGettagbuffer);
            this.groupBox7.Location = new System.Drawing.Point(352, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(352, 66);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            // 
            // btGettagbuffer
            // 
            this.btGettagbuffer.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGettagbuffer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btGettagbuffer.Location = new System.Drawing.Point(27, 16);
            this.btGettagbuffer.Name = "btGettagbuffer";
            this.btGettagbuffer.Size = new System.Drawing.Size(296, 40);
            this.btGettagbuffer.TabIndex = 0;
            this.btGettagbuffer.Text = "Read Command notify data";
            this.btGettagbuffer.UseVisualStyleBackColor = true;
            this.btGettagbuffer.Click += new System.EventHandler(this.btGettagbuffer_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btGetrunmodedata);
            this.groupBox6.Location = new System.Drawing.Point(5, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(348, 66);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            // 
            // btGetrunmodedata
            // 
            this.btGetrunmodedata.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGetrunmodedata.ForeColor = System.Drawing.Color.DarkBlue;
            this.btGetrunmodedata.Location = new System.Drawing.Point(21, 16);
            this.btGetrunmodedata.Name = "btGetrunmodedata";
            this.btGetrunmodedata.Size = new System.Drawing.Size(296, 40);
            this.btGetrunmodedata.TabIndex = 0;
            this.btGetrunmodedata.Text = "Start";
            this.btGetrunmodedata.UseVisualStyleBackColor = true;
            this.btGetrunmodedata.Click += new System.EventHandler(this.btGetrunmodedata_Click);
            // 
            // tabPage_Realtime
            // 
            this.tabPage_Realtime.Controls.Add(this.panel10);
            this.tabPage_Realtime.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Realtime.Name = "tabPage_Realtime";
            this.tabPage_Realtime.Size = new System.Drawing.Size(1063, 534);
            this.tabPage_Realtime.TabIndex = 4;
            this.tabPage_Realtime.Text = "Real-time-inventory";
            this.tabPage_Realtime.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dataGridView4);
            this.panel10.Controls.Add(this.groupBox41);
            this.panel10.Controls.Add(this.groupBox42);
            this.panel10.Location = new System.Drawing.Point(1, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1063, 533);
            this.panel10.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Column1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView4.Location = new System.Drawing.Point(358, 20);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(702, 509);
            this.dataGridView4.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "No.";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "EPC";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Width = 310;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Length";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Antenna";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "RSSI";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox41
            // 
            this.groupBox41.Controls.Add(this.lxLed_Mtime);
            this.groupBox41.Controls.Add(this.label113);
            this.groupBox41.Controls.Add(this.lxLed_Mtag);
            this.groupBox41.Controls.Add(this.label116);
            this.groupBox41.Location = new System.Drawing.Point(3, 73);
            this.groupBox41.Name = "groupBox41";
            this.groupBox41.Size = new System.Drawing.Size(349, 224);
            this.groupBox41.TabIndex = 25;
            this.groupBox41.TabStop = false;
            this.groupBox41.Text = "Data";
            // 
            // lxLed_Mtime
            // 
            this.lxLed_Mtime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Mtime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Mtime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Mtime.BevelRate = 0.5F;
            this.lxLed_Mtime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Mtime.BorderWidth = 3;
            this.lxLed_Mtime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Mtime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Mtime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Mtime.HighlightOpaque = ((byte)(50));
            this.lxLed_Mtime.Location = new System.Drawing.Point(22, 162);
            this.lxLed_Mtime.Name = "lxLed_Mtime";
            this.lxLed_Mtime.RoundCorner = true;
            this.lxLed_Mtime.ShowHighlight = true;
            this.lxLed_Mtime.Size = new System.Drawing.Size(175, 46);
            this.lxLed_Mtime.TabIndex = 32;
            this.lxLed_Mtime.Text = "0";
            this.lxLed_Mtime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Mtime.TotalCharCount = 7;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label113.Location = new System.Drawing.Point(20, 135);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(95, 12);
            this.label113.TabIndex = 31;
            this.label113.Text = "Total Time(ms):";
            // 
            // lxLed_Mtag
            // 
            this.lxLed_Mtag.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Mtag.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Mtag.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Mtag.BevelRate = 0.5F;
            this.lxLed_Mtag.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Mtag.BorderWidth = 3;
            this.lxLed_Mtag.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Mtag.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Mtag.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Mtag.HighlightOpaque = ((byte)(50));
            this.lxLed_Mtag.Location = new System.Drawing.Point(22, 69);
            this.lxLed_Mtag.Name = "lxLed_Mtag";
            this.lxLed_Mtag.RoundCorner = true;
            this.lxLed_Mtag.ShowHighlight = true;
            this.lxLed_Mtag.Size = new System.Drawing.Size(175, 46);
            this.lxLed_Mtag.TabIndex = 22;
            this.lxLed_Mtag.Text = "0";
            this.lxLed_Mtag.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Mtag.TotalCharCount = 7;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(21, 41);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(71, 12);
            this.label116.TabIndex = 21;
            this.label116.Text = "Tag Number:";
            // 
            // groupBox42
            // 
            this.groupBox42.Controls.Add(this.btStartMactive);
            this.groupBox42.Location = new System.Drawing.Point(4, 0);
            this.groupBox42.Name = "groupBox42";
            this.groupBox42.Size = new System.Drawing.Size(348, 66);
            this.groupBox42.TabIndex = 24;
            this.groupBox42.TabStop = false;
            // 
            // btStartMactive
            // 
            this.btStartMactive.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStartMactive.ForeColor = System.Drawing.Color.DarkBlue;
            this.btStartMactive.Location = new System.Drawing.Point(21, 16);
            this.btStartMactive.Name = "btStartMactive";
            this.btStartMactive.Size = new System.Drawing.Size(296, 40);
            this.btStartMactive.TabIndex = 0;
            this.btStartMactive.Text = "Start";
            this.btStartMactive.UseVisualStyleBackColor = true;
            this.btStartMactive.Click += new System.EventHandler(this.btStartMactive_Click);
            // 
            // tabPage_Buff
            // 
            this.tabPage_Buff.Controls.Add(this.panel8);
            this.tabPage_Buff.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Buff.Name = "tabPage_Buff";
            this.tabPage_Buff.Size = new System.Drawing.Size(1063, 534);
            this.tabPage_Buff.TabIndex = 3;
            this.tabPage_Buff.Text = "Buffer operation";
            this.tabPage_Buff.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox27);
            this.panel8.Controls.Add(this.groupBox29);
            this.panel8.Controls.Add(this.dataGridView3);
            this.panel8.Controls.Add(this.groupBox30);
            this.panel8.Location = new System.Drawing.Point(-2, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1067, 530);
            this.panel8.TabIndex = 1;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.btQueryBuffNum);
            this.groupBox27.Controls.Add(this.btRandCbuff);
            this.groupBox27.Controls.Add(this.btClearBuff);
            this.groupBox27.Controls.Add(this.btReadBuff);
            this.groupBox27.Location = new System.Drawing.Point(315, 5);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(370, 71);
            this.groupBox27.TabIndex = 25;
            this.groupBox27.TabStop = false;
            // 
            // btQueryBuffNum
            // 
            this.btQueryBuffNum.ForeColor = System.Drawing.Color.Blue;
            this.btQueryBuffNum.Location = new System.Drawing.Point(194, 42);
            this.btQueryBuffNum.Name = "btQueryBuffNum";
            this.btQueryBuffNum.Size = new System.Drawing.Size(151, 23);
            this.btQueryBuffNum.TabIndex = 3;
            this.btQueryBuffNum.Text = "Get buffer tag number";
            this.btQueryBuffNum.UseVisualStyleBackColor = true;
            this.btQueryBuffNum.Click += new System.EventHandler(this.btQueryBuffNum_Click);
            // 
            // btRandCbuff
            // 
            this.btRandCbuff.ForeColor = System.Drawing.Color.Blue;
            this.btRandCbuff.Location = new System.Drawing.Point(194, 13);
            this.btRandCbuff.Name = "btRandCbuff";
            this.btRandCbuff.Size = new System.Drawing.Size(151, 23);
            this.btRandCbuff.TabIndex = 2;
            this.btRandCbuff.Text = "Read and Clear Buffer";
            this.btRandCbuff.UseVisualStyleBackColor = true;
            this.btRandCbuff.Click += new System.EventHandler(this.btRandCbuff_Click);
            // 
            // btClearBuff
            // 
            this.btClearBuff.ForeColor = System.Drawing.Color.Blue;
            this.btClearBuff.Location = new System.Drawing.Point(31, 42);
            this.btClearBuff.Name = "btClearBuff";
            this.btClearBuff.Size = new System.Drawing.Size(151, 23);
            this.btClearBuff.TabIndex = 1;
            this.btClearBuff.Text = "Clear Buffer";
            this.btClearBuff.UseVisualStyleBackColor = true;
            this.btClearBuff.Click += new System.EventHandler(this.btClearBuff_Click);
            // 
            // btReadBuff
            // 
            this.btReadBuff.ForeColor = System.Drawing.Color.Blue;
            this.btReadBuff.Location = new System.Drawing.Point(31, 13);
            this.btReadBuff.Name = "btReadBuff";
            this.btReadBuff.Size = new System.Drawing.Size(151, 23);
            this.btReadBuff.TabIndex = 0;
            this.btReadBuff.Text = "Read Buffer";
            this.btReadBuff.UseVisualStyleBackColor = true;
            this.btReadBuff.Click += new System.EventHandler(this.btReadBuff_Click);
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.rb_btid);
            this.groupBox29.Controls.Add(this.rb_bepc);
            this.groupBox29.Controls.Add(this.btStartBuff);
            this.groupBox29.Location = new System.Drawing.Point(8, 5);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(307, 71);
            this.groupBox29.TabIndex = 23;
            this.groupBox29.TabStop = false;
            // 
            // rb_btid
            // 
            this.rb_btid.AutoSize = true;
            this.rb_btid.Location = new System.Drawing.Point(214, 42);
            this.rb_btid.Name = "rb_btid";
            this.rb_btid.Size = new System.Drawing.Size(41, 16);
            this.rb_btid.TabIndex = 2;
            this.rb_btid.Text = "TID";
            this.rb_btid.UseVisualStyleBackColor = true;
            // 
            // rb_bepc
            // 
            this.rb_bepc.AutoSize = true;
            this.rb_bepc.Checked = true;
            this.rb_bepc.Location = new System.Drawing.Point(214, 20);
            this.rb_bepc.Name = "rb_bepc";
            this.rb_bepc.Size = new System.Drawing.Size(41, 16);
            this.rb_bepc.TabIndex = 1;
            this.rb_bepc.TabStop = true;
            this.rb_bepc.Text = "EPC";
            this.rb_bepc.UseVisualStyleBackColor = true;
            // 
            // btStartBuff
            // 
            this.btStartBuff.BackColor = System.Drawing.Color.Transparent;
            this.btStartBuff.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStartBuff.ForeColor = System.Drawing.Color.DarkBlue;
            this.btStartBuff.Location = new System.Drawing.Point(18, 20);
            this.btStartBuff.Name = "btStartBuff";
            this.btStartBuff.Size = new System.Drawing.Size(171, 40);
            this.btStartBuff.TabIndex = 0;
            this.btStartBuff.Text = "Start";
            this.btStartBuff.UseVisualStyleBackColor = false;
            this.btStartBuff.Click += new System.EventHandler(this.btStartBuff_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column7});
            this.dataGridView3.Location = new System.Drawing.Point(5, 278);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1052, 249);
            this.dataGridView3.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "No.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "EPC";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 520;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Length";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Antenna";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "RSSI";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "times";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.lxLed_cmdTime);
            this.groupBox30.Controls.Add(this.label86);
            this.groupBox30.Controls.Add(this.lxLed_Btoltime);
            this.groupBox30.Controls.Add(this.label83);
            this.groupBox30.Controls.Add(this.label91);
            this.groupBox30.Controls.Add(this.lxLed_Btoltag);
            this.groupBox30.Controls.Add(this.label92);
            this.groupBox30.Controls.Add(this.lxLed_Bcmdsud);
            this.groupBox30.Controls.Add(this.label94);
            this.groupBox30.Controls.Add(this.lxLed_BNum);
            this.groupBox30.Controls.Add(this.label95);
            this.groupBox30.Location = new System.Drawing.Point(7, 81);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(1053, 449);
            this.groupBox30.TabIndex = 20;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Data:";
            // 
            // lxLed_cmdTime
            // 
            this.lxLed_cmdTime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_cmdTime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_cmdTime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_cmdTime.BevelRate = 0.5F;
            this.lxLed_cmdTime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_cmdTime.BorderWidth = 3;
            this.lxLed_cmdTime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_cmdTime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_cmdTime.ForeColor = System.Drawing.Color.Purple;
            this.lxLed_cmdTime.HighlightOpaque = ((byte)(50));
            this.lxLed_cmdTime.Location = new System.Drawing.Point(492, 129);
            this.lxLed_cmdTime.Name = "lxLed_cmdTime";
            this.lxLed_cmdTime.RoundCorner = true;
            this.lxLed_cmdTime.ShowHighlight = true;
            this.lxLed_cmdTime.Size = new System.Drawing.Size(146, 38);
            this.lxLed_cmdTime.TabIndex = 34;
            this.lxLed_cmdTime.Text = "0";
            this.lxLed_cmdTime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_cmdTime.TotalCharCount = 7;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.ForeColor = System.Drawing.Color.Teal;
            this.label86.Location = new System.Drawing.Point(490, 114);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(83, 12);
            this.label86.TabIndex = 33;
            this.label86.Text = "cmd time(ms):";
            // 
            // lxLed_Btoltime
            // 
            this.lxLed_Btoltime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Btoltime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Btoltime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Btoltime.BevelRate = 0.5F;
            this.lxLed_Btoltime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Btoltime.BorderWidth = 3;
            this.lxLed_Btoltime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Btoltime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Btoltime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Btoltime.HighlightOpaque = ((byte)(50));
            this.lxLed_Btoltime.Location = new System.Drawing.Point(749, 137);
            this.lxLed_Btoltime.Name = "lxLed_Btoltime";
            this.lxLed_Btoltime.RoundCorner = true;
            this.lxLed_Btoltime.ShowHighlight = true;
            this.lxLed_Btoltime.Size = new System.Drawing.Size(162, 30);
            this.lxLed_Btoltime.TabIndex = 32;
            this.lxLed_Btoltime.Text = "0";
            this.lxLed_Btoltime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Btoltime.TotalCharCount = 10;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label83.Location = new System.Drawing.Point(5, 179);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(59, 12);
            this.label83.TabIndex = 22;
            this.label83.Text = "Tag List:";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.ForeColor = System.Drawing.Color.Teal;
            this.label91.Location = new System.Drawing.Point(747, 117);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(95, 12);
            this.label91.TabIndex = 31;
            this.label91.Text = "Total time(ms):";
            // 
            // lxLed_Btoltag
            // 
            this.lxLed_Btoltag.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Btoltag.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Btoltag.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Btoltag.BevelRate = 0.5F;
            this.lxLed_Btoltag.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Btoltag.BorderWidth = 3;
            this.lxLed_Btoltag.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Btoltag.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Btoltag.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Btoltag.HighlightOpaque = ((byte)(50));
            this.lxLed_Btoltag.Location = new System.Drawing.Point(749, 68);
            this.lxLed_Btoltag.Name = "lxLed_Btoltag";
            this.lxLed_Btoltag.RoundCorner = true;
            this.lxLed_Btoltag.ShowHighlight = true;
            this.lxLed_Btoltag.Size = new System.Drawing.Size(162, 30);
            this.lxLed_Btoltag.TabIndex = 30;
            this.lxLed_Btoltag.Text = "0";
            this.lxLed_Btoltag.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Btoltag.TotalCharCount = 10;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.ForeColor = System.Drawing.Color.Teal;
            this.label92.Location = new System.Drawing.Point(747, 50);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(83, 12);
            this.label92.TabIndex = 29;
            this.label92.Text = "Total number:";
            // 
            // lxLed_Bcmdsud
            // 
            this.lxLed_Bcmdsud.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Bcmdsud.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Bcmdsud.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Bcmdsud.BevelRate = 0.5F;
            this.lxLed_Bcmdsud.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Bcmdsud.BorderWidth = 3;
            this.lxLed_Bcmdsud.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Bcmdsud.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Bcmdsud.ForeColor = System.Drawing.Color.Purple;
            this.lxLed_Bcmdsud.HighlightOpaque = ((byte)(50));
            this.lxLed_Bcmdsud.Location = new System.Drawing.Point(492, 60);
            this.lxLed_Bcmdsud.Name = "lxLed_Bcmdsud";
            this.lxLed_Bcmdsud.RoundCorner = true;
            this.lxLed_Bcmdsud.ShowHighlight = true;
            this.lxLed_Bcmdsud.Size = new System.Drawing.Size(146, 38);
            this.lxLed_Bcmdsud.TabIndex = 26;
            this.lxLed_Bcmdsud.Text = "0";
            this.lxLed_Bcmdsud.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Bcmdsud.TotalCharCount = 7;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.ForeColor = System.Drawing.Color.Teal;
            this.label94.Location = new System.Drawing.Point(490, 41);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(41, 12);
            this.label94.TabIndex = 25;
            this.label94.Text = "Speed:";
            // 
            // lxLed_BNum
            // 
            this.lxLed_BNum.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_BNum.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_BNum.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_BNum.BevelRate = 0.5F;
            this.lxLed_BNum.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_BNum.BorderWidth = 3;
            this.lxLed_BNum.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_BNum.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_BNum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_BNum.HighlightOpaque = ((byte)(50));
            this.lxLed_BNum.Location = new System.Drawing.Point(101, 40);
            this.lxLed_BNum.Name = "lxLed_BNum";
            this.lxLed_BNum.RoundCorner = true;
            this.lxLed_BNum.ShowHighlight = true;
            this.lxLed_BNum.Size = new System.Drawing.Size(329, 127);
            this.lxLed_BNum.TabIndex = 22;
            this.lxLed_BNum.Text = "0";
            this.lxLed_BNum.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(99, 22);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(71, 12);
            this.label95.TabIndex = 21;
            this.label95.Text = "tag number:";
            // 
            // tabPage_fastscan
            // 
            this.tabPage_fastscan.Controls.Add(this.panel12);
            this.tabPage_fastscan.Location = new System.Drawing.Point(4, 27);
            this.tabPage_fastscan.Name = "tabPage_fastscan";
            this.tabPage_fastscan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_fastscan.Size = new System.Drawing.Size(1063, 534);
            this.tabPage_fastscan.TabIndex = 5;
            this.tabPage_fastscan.Text = "Fast-mode";
            this.tabPage_fastscan.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dataGridView5);
            this.panel12.Controls.Add(this.groupBox59);
            this.panel12.Controls.Add(this.groupBox60);
            this.panel12.Location = new System.Drawing.Point(0, 1);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1063, 533);
            this.panel12.TabIndex = 1;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToResizeColumns = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.Column3,
            this.Column4,
            this.Column2});
            this.dataGridView5.Location = new System.Drawing.Point(249, 5);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(811, 522);
            this.dataGridView5.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "No.";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "EPC";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Width = 240;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Length";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn16.Width = 60;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Antenna";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn17.Width = 120;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "RSSI";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn18.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phase_begin";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phase_end";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Count";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 80;
            // 
            // groupBox59
            // 
            this.groupBox59.Controls.Add(this.lxLedControl9);
            this.groupBox59.Controls.Add(this.label197);
            this.groupBox59.Controls.Add(this.lxLedControl7);
            this.groupBox59.Controls.Add(this.label195);
            this.groupBox59.Controls.Add(this.lxLedControl8);
            this.groupBox59.Controls.Add(this.label196);
            this.groupBox59.Location = new System.Drawing.Point(3, 174);
            this.groupBox59.Name = "groupBox59";
            this.groupBox59.Size = new System.Drawing.Size(240, 316);
            this.groupBox59.TabIndex = 25;
            this.groupBox59.TabStop = false;
            this.groupBox59.Text = "Data";
            // 
            // lxLedControl9
            // 
            this.lxLedControl9.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl9.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl9.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl9.BevelRate = 0.5F;
            this.lxLedControl9.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl9.BorderWidth = 3;
            this.lxLedControl9.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl9.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl9.HighlightOpaque = ((byte)(50));
            this.lxLedControl9.Location = new System.Drawing.Point(21, 158);
            this.lxLedControl9.Name = "lxLedControl9";
            this.lxLedControl9.RoundCorner = true;
            this.lxLedControl9.ShowHighlight = true;
            this.lxLedControl9.Size = new System.Drawing.Size(175, 46);
            this.lxLedControl9.TabIndex = 34;
            this.lxLedControl9.Text = "0";
            this.lxLedControl9.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl9.TotalCharCount = 7;
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Location = new System.Drawing.Point(20, 130);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(77, 12);
            this.label197.TabIndex = 33;
            this.label197.Text = "Total Count:";
            // 
            // lxLedControl7
            // 
            this.lxLedControl7.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl7.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl7.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl7.BevelRate = 0.5F;
            this.lxLedControl7.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl7.BorderWidth = 3;
            this.lxLedControl7.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl7.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl7.HighlightOpaque = ((byte)(50));
            this.lxLedControl7.Location = new System.Drawing.Point(22, 245);
            this.lxLedControl7.Name = "lxLedControl7";
            this.lxLedControl7.RoundCorner = true;
            this.lxLedControl7.ShowHighlight = true;
            this.lxLedControl7.Size = new System.Drawing.Size(175, 46);
            this.lxLedControl7.TabIndex = 32;
            this.lxLedControl7.Text = "0";
            this.lxLedControl7.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl7.TotalCharCount = 7;
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label195.Location = new System.Drawing.Point(20, 218);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(83, 12);
            this.label195.TabIndex = 31;
            this.label195.Text = "Run time(ms):";
            // 
            // lxLedControl8
            // 
            this.lxLedControl8.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl8.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl8.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl8.BevelRate = 0.5F;
            this.lxLedControl8.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl8.BorderWidth = 3;
            this.lxLedControl8.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl8.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl8.HighlightOpaque = ((byte)(50));
            this.lxLedControl8.Location = new System.Drawing.Point(22, 69);
            this.lxLedControl8.Name = "lxLedControl8";
            this.lxLedControl8.RoundCorner = true;
            this.lxLedControl8.ShowHighlight = true;
            this.lxLedControl8.Size = new System.Drawing.Size(175, 46);
            this.lxLedControl8.TabIndex = 22;
            this.lxLedControl8.Text = "0";
            this.lxLedControl8.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl8.TotalCharCount = 7;
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.Location = new System.Drawing.Point(21, 41);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(65, 12);
            this.label196.TabIndex = 21;
            this.label196.Text = "Tag Number";
            // 
            // groupBox60
            // 
            this.groupBox60.Controls.Add(this.comboBox3);
            this.groupBox60.Controls.Add(this.label198);
            this.groupBox60.Controls.Add(this.button10);
            this.groupBox60.Controls.Add(this.button9);
            this.groupBox60.Location = new System.Drawing.Point(4, 0);
            this.groupBox60.Name = "groupBox60";
            this.groupBox60.Size = new System.Drawing.Size(239, 168);
            this.groupBox60.TabIndex = 24;
            this.groupBox60.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBox3.Location = new System.Drawing.Point(95, 129);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(51, 20);
            this.comboBox3.TabIndex = 35;
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Location = new System.Drawing.Point(43, 135);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(47, 12);
            this.label198.TabIndex = 34;
            this.label198.Text = "Target:";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(22, 20);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(174, 40);
            this.button10.TabIndex = 1;
            this.button10.Text = "Param Config";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.ForeColor = System.Drawing.Color.DarkBlue;
            this.button9.Location = new System.Drawing.Point(21, 74);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(174, 40);
            this.button9.TabIndex = 0;
            this.button9.Text = "Start";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabPage_RW
            // 
            this.tabPage_RW.Controls.Add(this.panel4);
            this.tabPage_RW.Location = new System.Drawing.Point(4, 27);
            this.tabPage_RW.Name = "tabPage_RW";
            this.tabPage_RW.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RW.Size = new System.Drawing.Size(1063, 534);
            this.tabPage_RW.TabIndex = 2;
            this.tabPage_RW.Text = "Read/Write Tag";
            this.tabPage_RW.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox21);
            this.panel4.Controls.Add(this.groupBox20);
            this.panel4.Controls.Add(this.groupBox18);
            this.panel4.Controls.Add(this.groupBox16);
            this.panel4.Controls.Add(this.groupBox13);
            this.panel4.Controls.Add(this.groupBox11);
            this.panel4.Controls.Add(this.groupBox31);
            this.panel4.Controls.Add(this.groupBox10);
            this.panel4.Location = new System.Drawing.Point(-2, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1067, 562);
            this.panel4.TabIndex = 0;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.btCheckReadProtected_G2);
            this.groupBox21.Controls.Add(this.btRemoveReadProtect_G2);
            this.groupBox21.Controls.Add(this.btSetMultiReadProtect_G2);
            this.groupBox21.Controls.Add(this.btSetReadProtect_G2);
            this.groupBox21.Controls.Add(this.text_AccessCode4);
            this.groupBox21.Controls.Add(this.label34);
            this.groupBox21.Location = new System.Drawing.Point(346, 361);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(310, 146);
            this.groupBox21.TabIndex = 23;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Read Protection-NXP";
            // 
            // btCheckReadProtected_G2
            // 
            this.btCheckReadProtected_G2.Location = new System.Drawing.Point(12, 119);
            this.btCheckReadProtected_G2.Name = "btCheckReadProtected_G2";
            this.btCheckReadProtected_G2.Size = new System.Drawing.Size(285, 23);
            this.btCheckReadProtected_G2.TabIndex = 6;
            this.btCheckReadProtected_G2.Text = "Detect Privacy   ";
            this.btCheckReadProtected_G2.UseVisualStyleBackColor = true;
            this.btCheckReadProtected_G2.Click += new System.EventHandler(this.btCheckReadProtected_G2_Click);
            // 
            // btRemoveReadProtect_G2
            // 
            this.btRemoveReadProtect_G2.Location = new System.Drawing.Point(12, 94);
            this.btRemoveReadProtect_G2.Name = "btRemoveReadProtect_G2";
            this.btRemoveReadProtect_G2.Size = new System.Drawing.Size(285, 23);
            this.btRemoveReadProtect_G2.TabIndex = 5;
            this.btRemoveReadProtect_G2.Text = "Reset Privacy";
            this.btRemoveReadProtect_G2.UseVisualStyleBackColor = true;
            this.btRemoveReadProtect_G2.Click += new System.EventHandler(this.btRemoveReadProtect_G2_Click);
            // 
            // btSetMultiReadProtect_G2
            // 
            this.btSetMultiReadProtect_G2.Location = new System.Drawing.Point(12, 68);
            this.btSetMultiReadProtect_G2.Name = "btSetMultiReadProtect_G2";
            this.btSetMultiReadProtect_G2.Size = new System.Drawing.Size(285, 23);
            this.btSetMultiReadProtect_G2.TabIndex = 4;
            this.btSetMultiReadProtect_G2.Text = "Set Privacy Without EPC";
            this.btSetMultiReadProtect_G2.UseVisualStyleBackColor = true;
            this.btSetMultiReadProtect_G2.Click += new System.EventHandler(this.btSetMultiReadProtect_G2_Click);
            // 
            // btSetReadProtect_G2
            // 
            this.btSetReadProtect_G2.Location = new System.Drawing.Point(12, 41);
            this.btSetReadProtect_G2.Name = "btSetReadProtect_G2";
            this.btSetReadProtect_G2.Size = new System.Drawing.Size(285, 23);
            this.btSetReadProtect_G2.TabIndex = 3;
            this.btSetReadProtect_G2.Text = "Set Privacy By EPC";
            this.btSetReadProtect_G2.UseVisualStyleBackColor = true;
            this.btSetReadProtect_G2.Click += new System.EventHandler(this.btSetReadProtect_G2_Click);
            // 
            // text_AccessCode4
            // 
            this.text_AccessCode4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode4.Location = new System.Drawing.Point(196, 14);
            this.text_AccessCode4.MaxLength = 8;
            this.text_AccessCode4.Name = "text_AccessCode4";
            this.text_AccessCode4.Size = new System.Drawing.Size(100, 21);
            this.text_AccessCode4.TabIndex = 2;
            this.text_AccessCode4.Text = "00000000";
            this.text_AccessCode4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 20);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(89, 12);
            this.label34.TabIndex = 1;
            this.label34.Text = "Password:(Hex)";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.btWriteEPC_G2);
            this.groupBox20.Controls.Add(this.text_AccessCode3);
            this.groupBox20.Controls.Add(this.label27);
            this.groupBox20.Controls.Add(this.text_WriteEPC);
            this.groupBox20.Controls.Add(this.label33);
            this.groupBox20.Location = new System.Drawing.Point(8, 427);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(332, 79);
            this.groupBox20.TabIndex = 22;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Write EPC";
            // 
            // btWriteEPC_G2
            // 
            this.btWriteEPC_G2.Location = new System.Drawing.Point(229, 44);
            this.btWriteEPC_G2.Name = "btWriteEPC_G2";
            this.btWriteEPC_G2.Size = new System.Drawing.Size(90, 23);
            this.btWriteEPC_G2.TabIndex = 4;
            this.btWriteEPC_G2.Text = "Write EPC";
            this.btWriteEPC_G2.UseVisualStyleBackColor = true;
            this.btWriteEPC_G2.Click += new System.EventHandler(this.btWriteEPC_G2_Click);
            // 
            // text_AccessCode3
            // 
            this.text_AccessCode3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode3.Location = new System.Drawing.Point(155, 44);
            this.text_AccessCode3.MaxLength = 8;
            this.text_AccessCode3.Name = "text_AccessCode3";
            this.text_AccessCode3.Size = new System.Drawing.Size(57, 21);
            this.text_AccessCode3.TabIndex = 3;
            this.text_AccessCode3.Text = "00000000";
            this.text_AccessCode3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 50);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 12);
            this.label27.TabIndex = 2;
            this.label27.Text = "Password:(Hex)";
            // 
            // text_WriteEPC
            // 
            this.text_WriteEPC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_WriteEPC.Location = new System.Drawing.Point(77, 17);
            this.text_WriteEPC.MaxLength = 60;
            this.text_WriteEPC.Name = "text_WriteEPC";
            this.text_WriteEPC.Size = new System.Drawing.Size(242, 21);
            this.text_WriteEPC.TabIndex = 1;
            this.text_WriteEPC.Text = "0000";
            this.text_WriteEPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 21);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 12);
            this.label33.TabIndex = 0;
            this.label33.Text = "EPC号:";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.btDestroyCard);
            this.groupBox18.Controls.Add(this.text_DestroyCode);
            this.groupBox18.Controls.Add(this.label26);
            this.groupBox18.Location = new System.Drawing.Point(8, 361);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(332, 56);
            this.groupBox18.TabIndex = 20;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Kill Tag";
            // 
            // btDestroyCard
            // 
            this.btDestroyCard.Location = new System.Drawing.Point(229, 21);
            this.btDestroyCard.Name = "btDestroyCard";
            this.btDestroyCard.Size = new System.Drawing.Size(90, 23);
            this.btDestroyCard.TabIndex = 3;
            this.btDestroyCard.Text = "Kill";
            this.btDestroyCard.UseVisualStyleBackColor = true;
            this.btDestroyCard.Click += new System.EventHandler(this.btDestroyCard_Click);
            // 
            // text_DestroyCode
            // 
            this.text_DestroyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_DestroyCode.Location = new System.Drawing.Point(155, 23);
            this.text_DestroyCode.MaxLength = 8;
            this.text_DestroyCode.Name = "text_DestroyCode";
            this.text_DestroyCode.Size = new System.Drawing.Size(56, 21);
            this.text_DestroyCode.TabIndex = 2;
            this.text_DestroyCode.Text = "00000000";
            this.text_DestroyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 12);
            this.label26.TabIndex = 1;
            this.label26.Text = "Kill Password:(Hex)";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.pictureBox2);
            this.groupBox16.Controls.Add(this.btCheckEASAlarm);
            this.groupBox16.Controls.Add(this.btSetEASAlarm_G2);
            this.groupBox16.Controls.Add(this.groupBox17);
            this.groupBox16.Controls.Add(this.text_AccessCode5);
            this.groupBox16.Controls.Add(this.label28);
            this.groupBox16.Location = new System.Drawing.Point(662, 239);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(397, 267);
            this.groupBox16.TabIndex = 19;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "EAS Alarm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btCheckEASAlarm
            // 
            this.btCheckEASAlarm.Location = new System.Drawing.Point(280, 78);
            this.btCheckEASAlarm.Name = "btCheckEASAlarm";
            this.btCheckEASAlarm.Size = new System.Drawing.Size(90, 23);
            this.btCheckEASAlarm.TabIndex = 13;
            this.btCheckEASAlarm.Text = "Detect";
            this.btCheckEASAlarm.UseVisualStyleBackColor = true;
            this.btCheckEASAlarm.Click += new System.EventHandler(this.btCheckEASAlarm_Click);
            // 
            // btSetEASAlarm_G2
            // 
            this.btSetEASAlarm_G2.Location = new System.Drawing.Point(280, 25);
            this.btSetEASAlarm_G2.Name = "btSetEASAlarm_G2";
            this.btSetEASAlarm_G2.Size = new System.Drawing.Size(90, 23);
            this.btSetEASAlarm_G2.TabIndex = 12;
            this.btSetEASAlarm_G2.Text = "Configure";
            this.btSetEASAlarm_G2.UseVisualStyleBackColor = true;
            this.btSetEASAlarm_G2.Click += new System.EventHandler(this.btSetEASAlarm_G2_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.NoAlarm_G2);
            this.groupBox17.Controls.Add(this.Alarm_G2);
            this.groupBox17.Location = new System.Drawing.Point(9, 47);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(249, 54);
            this.groupBox17.TabIndex = 11;
            this.groupBox17.TabStop = false;
            // 
            // NoAlarm_G2
            // 
            this.NoAlarm_G2.AutoSize = true;
            this.NoAlarm_G2.Location = new System.Drawing.Point(113, 20);
            this.NoAlarm_G2.Name = "NoAlarm_G2";
            this.NoAlarm_G2.Size = new System.Drawing.Size(71, 16);
            this.NoAlarm_G2.TabIndex = 1;
            this.NoAlarm_G2.Text = "No Alarm";
            this.NoAlarm_G2.UseVisualStyleBackColor = true;
            // 
            // Alarm_G2
            // 
            this.Alarm_G2.AutoSize = true;
            this.Alarm_G2.Checked = true;
            this.Alarm_G2.Location = new System.Drawing.Point(6, 20);
            this.Alarm_G2.Name = "Alarm_G2";
            this.Alarm_G2.Size = new System.Drawing.Size(53, 16);
            this.Alarm_G2.TabIndex = 0;
            this.Alarm_G2.TabStop = true;
            this.Alarm_G2.Text = "Alarm";
            this.Alarm_G2.UseVisualStyleBackColor = true;
            // 
            // text_AccessCode5
            // 
            this.text_AccessCode5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode5.Location = new System.Drawing.Point(158, 22);
            this.text_AccessCode5.MaxLength = 8;
            this.text_AccessCode5.Name = "text_AccessCode5";
            this.text_AccessCode5.Size = new System.Drawing.Size(100, 21);
            this.text_AccessCode5.TabIndex = 10;
            this.text_AccessCode5.Text = "00000000";
            this.text_AccessCode5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(89, 12);
            this.label28.TabIndex = 9;
            this.label28.Text = "Password:(Hex)";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.checkBox_U9);
            this.groupBox13.Controls.Add(this.btSetProtectState);
            this.groupBox13.Controls.Add(this.Edit_AccessCode6);
            this.groupBox13.Controls.Add(this.label25);
            this.groupBox13.Controls.Add(this.groupBox14);
            this.groupBox13.Controls.Add(this.groupBox15);
            this.groupBox13.Location = new System.Drawing.Point(5, 239);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(651, 121);
            this.groupBox13.TabIndex = 18;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Set Protect For Reading Or Writing";
            // 
            // btSetProtectState
            // 
            this.btSetProtectState.Location = new System.Drawing.Point(551, 84);
            this.btSetProtectState.Name = "btSetProtectState";
            this.btSetProtectState.Size = new System.Drawing.Size(90, 23);
            this.btSetProtectState.TabIndex = 6;
            this.btSetProtectState.Text = "Lock";
            this.btSetProtectState.UseVisualStyleBackColor = true;
            this.btSetProtectState.Click += new System.EventHandler(this.btSetProtectState_Click);
            // 
            // Edit_AccessCode6
            // 
            this.Edit_AccessCode6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Edit_AccessCode6.Location = new System.Drawing.Point(551, 44);
            this.Edit_AccessCode6.MaxLength = 8;
            this.Edit_AccessCode6.Name = "Edit_AccessCode6";
            this.Edit_AccessCode6.Size = new System.Drawing.Size(90, 21);
            this.Edit_AccessCode6.TabIndex = 5;
            this.Edit_AccessCode6.Text = "00000000";
            this.Edit_AccessCode6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(503, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 12);
            this.label25.TabIndex = 4;
            this.label25.Text = "Password:(Hex)";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.AlwaysNot2);
            this.groupBox14.Controls.Add(this.Always2);
            this.groupBox14.Controls.Add(this.Proect2);
            this.groupBox14.Controls.Add(this.NoProect2);
            this.groupBox14.Location = new System.Drawing.Point(4, 68);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(476, 44);
            this.groupBox14.TabIndex = 3;
            this.groupBox14.TabStop = false;
            // 
            // AlwaysNot2
            // 
            this.AlwaysNot2.AutoSize = true;
            this.AlwaysNot2.Location = new System.Drawing.Point(280, 18);
            this.AlwaysNot2.Name = "AlwaysNot2";
            this.AlwaysNot2.Size = new System.Drawing.Size(95, 16);
            this.AlwaysNot2.TabIndex = 3;
            this.AlwaysNot2.Text = "Lock forever\n";
            this.AlwaysNot2.UseVisualStyleBackColor = true;
            // 
            // Always2
            // 
            this.Always2.AutoSize = true;
            this.Always2.Location = new System.Drawing.Point(188, 18);
            this.Always2.Name = "Always2";
            this.Always2.Size = new System.Drawing.Size(107, 16);
            this.Always2.TabIndex = 2;
            this.Always2.Text = "Unlock forever\n";
            this.Always2.UseVisualStyleBackColor = true;
            // 
            // Proect2
            // 
            this.Proect2.AutoSize = true;
            this.Proect2.Location = new System.Drawing.Point(98, 18);
            this.Proect2.Name = "Proect2";
            this.Proect2.Size = new System.Drawing.Size(47, 16);
            this.Proect2.TabIndex = 1;
            this.Proect2.Text = "Lock";
            this.Proect2.UseVisualStyleBackColor = true;
            // 
            // NoProect2
            // 
            this.NoProect2.AutoSize = true;
            this.NoProect2.Checked = true;
            this.NoProect2.Location = new System.Drawing.Point(9, 18);
            this.NoProect2.Name = "NoProect2";
            this.NoProect2.Size = new System.Drawing.Size(59, 16);
            this.NoProect2.TabIndex = 0;
            this.NoProect2.TabStop = true;
            this.NoProect2.Text = "UnLock";
            this.NoProect2.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.p_pass);
            this.groupBox15.Controls.Add(this.P_User);
            this.groupBox15.Controls.Add(this.P_TID);
            this.groupBox15.Controls.Add(this.P_EPC);
            this.groupBox15.Controls.Add(this.P_kill);
            this.groupBox15.Location = new System.Drawing.Point(4, 13);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(476, 52);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            // 
            // p_pass
            // 
            this.p_pass.AutoSize = true;
            this.p_pass.Checked = true;
            this.p_pass.Location = new System.Drawing.Point(98, 18);
            this.p_pass.Name = "p_pass";
            this.p_pass.Size = new System.Drawing.Size(113, 16);
            this.p_pass.TabIndex = 4;
            this.p_pass.TabStop = true;
            this.p_pass.Text = "Access Password";
            this.p_pass.UseVisualStyleBackColor = true;
            // 
            // P_User
            // 
            this.P_User.AutoSize = true;
            this.P_User.Location = new System.Drawing.Point(360, 18);
            this.P_User.Name = "P_User";
            this.P_User.Size = new System.Drawing.Size(47, 16);
            this.P_User.TabIndex = 3;
            this.P_User.Text = "User";
            this.P_User.UseVisualStyleBackColor = true;
            // 
            // P_TID
            // 
            this.P_TID.AutoSize = true;
            this.P_TID.Location = new System.Drawing.Point(278, 18);
            this.P_TID.Name = "P_TID";
            this.P_TID.Size = new System.Drawing.Size(41, 16);
            this.P_TID.TabIndex = 2;
            this.P_TID.Text = "TID";
            this.P_TID.UseVisualStyleBackColor = true;
            // 
            // P_EPC
            // 
            this.P_EPC.AutoSize = true;
            this.P_EPC.Location = new System.Drawing.Point(188, 18);
            this.P_EPC.Name = "P_EPC";
            this.P_EPC.Size = new System.Drawing.Size(41, 16);
            this.P_EPC.TabIndex = 1;
            this.P_EPC.Text = "EPC";
            this.P_EPC.UseVisualStyleBackColor = true;
            // 
            // P_kill
            // 
            this.P_kill.AutoSize = true;
            this.P_kill.Location = new System.Drawing.Point(9, 18);
            this.P_kill.Name = "P_kill";
            this.P_kill.Size = new System.Drawing.Size(101, 16);
            this.P_kill.TabIndex = 0;
            this.P_kill.Text = "Kill Password";
            this.P_kill.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btExtWrite);
            this.groupBox11.Controls.Add(this.btExtRead);
            this.groupBox11.Controls.Add(this.textBox_pc);
            this.groupBox11.Controls.Add(this.checkBox_pc);
            this.groupBox11.Controls.Add(this.btBlockWrite);
            this.groupBox11.Controls.Add(this.btBlockErase);
            this.groupBox11.Controls.Add(this.btWrite);
            this.groupBox11.Controls.Add(this.btRead);
            this.groupBox11.Controls.Add(this.text_WriteData);
            this.groupBox11.Controls.Add(this.text_AccessCode2);
            this.groupBox11.Controls.Add(this.text_RWlen);
            this.groupBox11.Controls.Add(this.text_WordPtr);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.label24);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Location = new System.Drawing.Point(5, 119);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1055, 119);
            this.groupBox11.TabIndex = 17;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Read Data / Write Data / Block Erase";
            // 
            // btExtWrite
            // 
            this.btExtWrite.Location = new System.Drawing.Point(950, 92);
            this.btExtWrite.Name = "btExtWrite";
            this.btExtWrite.Size = new System.Drawing.Size(77, 23);
            this.btExtWrite.TabIndex = 33;
            this.btExtWrite.Text = "Ext Write";
            this.btExtWrite.UseVisualStyleBackColor = true;
            this.btExtWrite.Click += new System.EventHandler(this.btExtWrite_Click);
            // 
            // btExtRead
            // 
            this.btExtRead.Location = new System.Drawing.Point(950, 55);
            this.btExtRead.Name = "btExtRead";
            this.btExtRead.Size = new System.Drawing.Size(77, 23);
            this.btExtRead.TabIndex = 32;
            this.btExtRead.Text = "Ext Read";
            this.btExtRead.UseVisualStyleBackColor = true;
            this.btExtRead.Click += new System.EventHandler(this.btExtRead_Click);
            // 
            // textBox_pc
            // 
            this.textBox_pc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_pc.Location = new System.Drawing.Point(616, 57);
            this.textBox_pc.Name = "textBox_pc";
            this.textBox_pc.ReadOnly = true;
            this.textBox_pc.Size = new System.Drawing.Size(138, 21);
            this.textBox_pc.TabIndex = 29;
            this.textBox_pc.Text = "0800";
            // 
            // checkBox_pc
            // 
            this.checkBox_pc.AutoSize = true;
            this.checkBox_pc.Location = new System.Drawing.Point(405, 59);
            this.checkBox_pc.Name = "checkBox_pc";
            this.checkBox_pc.Size = new System.Drawing.Size(162, 16);
            this.checkBox_pc.TabIndex = 28;
            this.checkBox_pc.Text = "Auto Compute and add PC";
            this.checkBox_pc.UseVisualStyleBackColor = true;
            this.checkBox_pc.CheckedChanged += new System.EventHandler(this.checkBox_pc_CheckedChanged);
            // 
            // btBlockWrite
            // 
            this.btBlockWrite.Location = new System.Drawing.Point(770, 92);
            this.btBlockWrite.Name = "btBlockWrite";
            this.btBlockWrite.Size = new System.Drawing.Size(77, 23);
            this.btBlockWrite.TabIndex = 17;
            this.btBlockWrite.Text = "BlockWrite";
            this.btBlockWrite.UseVisualStyleBackColor = true;
            this.btBlockWrite.Click += new System.EventHandler(this.btBlockWrite_Click);
            // 
            // btBlockErase
            // 
            this.btBlockErase.Location = new System.Drawing.Point(861, 92);
            this.btBlockErase.Name = "btBlockErase";
            this.btBlockErase.Size = new System.Drawing.Size(77, 23);
            this.btBlockErase.TabIndex = 13;
            this.btBlockErase.Text = "BlockErace";
            this.btBlockErase.UseVisualStyleBackColor = true;
            this.btBlockErase.Click += new System.EventHandler(this.btBlockErase_Click);
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(861, 55);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(77, 23);
            this.btWrite.TabIndex = 12;
            this.btWrite.Text = "Write";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(770, 55);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(77, 23);
            this.btRead.TabIndex = 11;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // text_WriteData
            // 
            this.text_WriteData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_WriteData.Location = new System.Drawing.Point(529, 20);
            this.text_WriteData.Name = "text_WriteData";
            this.text_WriteData.Size = new System.Drawing.Size(504, 21);
            this.text_WriteData.TabIndex = 10;
            this.text_WriteData.Text = "0000";
            this.text_WriteData.TextChanged += new System.EventHandler(this.text_WriteData_TextChanged);
            this.text_WriteData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // text_AccessCode2
            // 
            this.text_AccessCode2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode2.Location = new System.Drawing.Point(205, 87);
            this.text_AccessCode2.MaxLength = 8;
            this.text_AccessCode2.Name = "text_AccessCode2";
            this.text_AccessCode2.Size = new System.Drawing.Size(118, 21);
            this.text_AccessCode2.TabIndex = 9;
            this.text_AccessCode2.Text = "00000000";
            this.text_AccessCode2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // text_RWlen
            // 
            this.text_RWlen.Location = new System.Drawing.Point(205, 57);
            this.text_RWlen.MaxLength = 2;
            this.text_RWlen.Name = "text_RWlen";
            this.text_RWlen.Size = new System.Drawing.Size(117, 21);
            this.text_RWlen.TabIndex = 8;
            this.text_RWlen.Text = "4";
            this.text_RWlen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // text_WordPtr
            // 
            this.text_WordPtr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_WordPtr.Location = new System.Drawing.Point(205, 19);
            this.text_WordPtr.MaxLength = 4;
            this.text_WordPtr.Name = "text_WordPtr";
            this.text_WordPtr.Size = new System.Drawing.Size(117, 21);
            this.text_WordPtr.TabIndex = 7;
            this.text_WordPtr.Text = "0000";
            this.text_WordPtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(402, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 12);
            this.label21.TabIndex = 5;
            this.label21.Text = "Read/Write data(Hex):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 12);
            this.label22.TabIndex = 4;
            this.label22.Text = "Password:(Hex)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 3;
            this.label23.Text = "Length(Dec):";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(125, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "Start address:(Hex):";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.C_User);
            this.groupBox12.Controls.Add(this.C_TID);
            this.groupBox12.Controls.Add(this.C_EPC);
            this.groupBox12.Controls.Add(this.C_Reserve);
            this.groupBox12.Location = new System.Drawing.Point(402, 81);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(353, 31);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            // 
            // C_User
            // 
            this.C_User.AutoSize = true;
            this.C_User.Location = new System.Drawing.Point(207, 11);
            this.C_User.Name = "C_User";
            this.C_User.Size = new System.Drawing.Size(47, 16);
            this.C_User.TabIndex = 3;
            this.C_User.Text = "User";
            this.C_User.UseVisualStyleBackColor = true;
            this.C_User.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // C_TID
            // 
            this.C_TID.AutoSize = true;
            this.C_TID.Location = new System.Drawing.Point(144, 11);
            this.C_TID.Name = "C_TID";
            this.C_TID.Size = new System.Drawing.Size(41, 16);
            this.C_TID.TabIndex = 2;
            this.C_TID.Text = "TID";
            this.C_TID.UseVisualStyleBackColor = true;
            this.C_TID.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // C_EPC
            // 
            this.C_EPC.AutoSize = true;
            this.C_EPC.Checked = true;
            this.C_EPC.Location = new System.Drawing.Point(81, 11);
            this.C_EPC.Name = "C_EPC";
            this.C_EPC.Size = new System.Drawing.Size(41, 16);
            this.C_EPC.TabIndex = 1;
            this.C_EPC.TabStop = true;
            this.C_EPC.Text = "EPC";
            this.C_EPC.UseVisualStyleBackColor = true;
            this.C_EPC.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // C_Reserve
            // 
            this.C_Reserve.AutoSize = true;
            this.C_Reserve.Location = new System.Drawing.Point(4, 11);
            this.C_Reserve.Name = "C_Reserve";
            this.C_Reserve.Size = new System.Drawing.Size(65, 16);
            this.C_Reserve.TabIndex = 0;
            this.C_Reserve.Text = "Reserve";
            this.C_Reserve.UseVisualStyleBackColor = true;
            this.C_Reserve.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.maskData_textBox);
            this.groupBox31.Controls.Add(this.label60);
            this.groupBox31.Controls.Add(this.groupBox40);
            this.groupBox31.Controls.Add(this.checkBox1);
            this.groupBox31.Controls.Add(this.maskLen_textBox);
            this.groupBox31.Controls.Add(this.label44);
            this.groupBox31.Controls.Add(this.maskadr_textbox);
            this.groupBox31.Controls.Add(this.label43);
            this.groupBox31.Location = new System.Drawing.Point(5, 47);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(1056, 69);
            this.groupBox31.TabIndex = 16;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Mask";
            // 
            // maskData_textBox
            // 
            this.maskData_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskData_textBox.Enabled = false;
            this.maskData_textBox.Location = new System.Drawing.Point(528, 44);
            this.maskData_textBox.Name = "maskData_textBox";
            this.maskData_textBox.Size = new System.Drawing.Size(505, 21);
            this.maskData_textBox.TabIndex = 8;
            this.maskData_textBox.Text = "00";
            this.maskData_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(403, 48);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(65, 12);
            this.label60.TabIndex = 7;
            this.label60.Text = "Data(Hex):";
            // 
            // groupBox40
            // 
            this.groupBox40.Controls.Add(this.R_User);
            this.groupBox40.Controls.Add(this.R_TID);
            this.groupBox40.Controls.Add(this.R_EPC);
            this.groupBox40.Location = new System.Drawing.Point(402, 10);
            this.groupBox40.Name = "groupBox40";
            this.groupBox40.Size = new System.Drawing.Size(513, 30);
            this.groupBox40.TabIndex = 6;
            this.groupBox40.TabStop = false;
            this.groupBox40.Text = "Mem";
            // 
            // R_User
            // 
            this.R_User.AutoSize = true;
            this.R_User.Enabled = false;
            this.R_User.Location = new System.Drawing.Point(381, 11);
            this.R_User.Name = "R_User";
            this.R_User.Size = new System.Drawing.Size(47, 16);
            this.R_User.TabIndex = 2;
            this.R_User.Text = "User";
            this.R_User.UseVisualStyleBackColor = true;
            // 
            // R_TID
            // 
            this.R_TID.AutoSize = true;
            this.R_TID.Enabled = false;
            this.R_TID.Location = new System.Drawing.Point(218, 10);
            this.R_TID.Name = "R_TID";
            this.R_TID.Size = new System.Drawing.Size(41, 16);
            this.R_TID.TabIndex = 1;
            this.R_TID.Text = "TID";
            this.R_TID.UseVisualStyleBackColor = true;
            // 
            // R_EPC
            // 
            this.R_EPC.AutoSize = true;
            this.R_EPC.Checked = true;
            this.R_EPC.Enabled = false;
            this.R_EPC.Location = new System.Drawing.Point(59, 10);
            this.R_EPC.Name = "R_EPC";
            this.R_EPC.Size = new System.Drawing.Size(41, 16);
            this.R_EPC.TabIndex = 0;
            this.R_EPC.TabStop = true;
            this.R_EPC.Text = "EPC";
            this.R_EPC.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(948, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // maskLen_textBox
            // 
            this.maskLen_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskLen_textBox.Enabled = false;
            this.maskLen_textBox.Location = new System.Drawing.Point(148, 44);
            this.maskLen_textBox.MaxLength = 2;
            this.maskLen_textBox.Name = "maskLen_textBox";
            this.maskLen_textBox.Size = new System.Drawing.Size(174, 21);
            this.maskLen_textBox.TabIndex = 4;
            this.maskLen_textBox.Text = "00";
            this.maskLen_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(12, 48);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(77, 12);
            this.label44.TabIndex = 3;
            this.label44.Text = "Length(Hex):";
            // 
            // maskadr_textbox
            // 
            this.maskadr_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskadr_textbox.Enabled = false;
            this.maskadr_textbox.Location = new System.Drawing.Point(148, 18);
            this.maskadr_textbox.MaxLength = 4;
            this.maskadr_textbox.Name = "maskadr_textbox";
            this.maskadr_textbox.Size = new System.Drawing.Size(174, 21);
            this.maskadr_textbox.TabIndex = 2;
            this.maskadr_textbox.Text = "0000";
            this.maskadr_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(12, 24);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(119, 12);
            this.label43.TabIndex = 1;
            this.label43.Text = "Start address(Hex):";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btSelectTag);
            this.groupBox10.Controls.Add(this.comboBox_EPC);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.text_epc);
            this.groupBox10.Controls.Add(this.check_selecttag);
            this.groupBox10.Location = new System.Drawing.Point(5, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1057, 41);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Select operate tag";
            // 
            // btSelectTag
            // 
            this.btSelectTag.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btSelectTag.Location = new System.Drawing.Point(943, 13);
            this.btSelectTag.Name = "btSelectTag";
            this.btSelectTag.Size = new System.Drawing.Size(90, 23);
            this.btSelectTag.TabIndex = 4;
            this.btSelectTag.Text = "Select";
            this.btSelectTag.UseVisualStyleBackColor = true;
            this.btSelectTag.Click += new System.EventHandler(this.btSelectTag_Click);
            // 
            // comboBox_EPC
            // 
            this.comboBox_EPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EPC.FormattingEnabled = true;
            this.comboBox_EPC.Location = new System.Drawing.Point(570, 14);
            this.comboBox_EPC.Name = "comboBox_EPC";
            this.comboBox_EPC.Size = new System.Drawing.Size(345, 20);
            this.comboBox_EPC.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label16.Location = new System.Drawing.Point(503, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tag list:";
            // 
            // text_epc
            // 
            this.text_epc.Location = new System.Drawing.Point(113, 14);
            this.text_epc.Name = "text_epc";
            this.text_epc.Size = new System.Drawing.Size(345, 21);
            this.text_epc.TabIndex = 1;
            // 
            // check_selecttag
            // 
            this.check_selecttag.AutoSize = true;
            this.check_selecttag.Checked = true;
            this.check_selecttag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_selecttag.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_selecttag.Location = new System.Drawing.Point(17, 16);
            this.check_selecttag.Name = "check_selecttag";
            this.check_selecttag.Size = new System.Drawing.Size(102, 16);
            this.check_selecttag.TabIndex = 0;
            this.check_selecttag.Text = "Selected tag:";
            this.check_selecttag.UseVisualStyleBackColor = true;
            // 
            // Main_Page5
            // 
            this.Main_Page5.Controls.Add(this.panel_jb);
            this.Main_Page5.Location = new System.Drawing.Point(4, 27);
            this.Main_Page5.Name = "Main_Page5";
            this.Main_Page5.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page5.Size = new System.Drawing.Size(1075, 571);
            this.Main_Page5.TabIndex = 4;
            this.Main_Page5.Text = "GJB-test";
            this.Main_Page5.UseVisualStyleBackColor = true;
            // 
            // panel_jb
            // 
            this.panel_jb.Controls.Add(this.group_jbant);
            this.panel_jb.Controls.Add(this.com_jb_tagid);
            this.panel_jb.Controls.Add(this.label132);
            this.panel_jb.Controls.Add(this.tabControl4);
            this.panel_jb.Controls.Add(this.groupBox53);
            this.panel_jb.Controls.Add(this.lxLed_jb_number);
            this.panel_jb.Controls.Add(this.label128);
            this.panel_jb.Controls.Add(this.lxLed_jb_time);
            this.panel_jb.Controls.Add(this.label127);
            this.panel_jb.Controls.Add(this.groupBox52);
            this.panel_jb.Controls.Add(this.gbp_jb_mix);
            this.panel_jb.Controls.Add(this.groupBox48);
            this.panel_jb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_jb.Location = new System.Drawing.Point(3, 3);
            this.panel_jb.Name = "panel_jb";
            this.panel_jb.Size = new System.Drawing.Size(1069, 565);
            this.panel_jb.TabIndex = 1;
            // 
            // group_jbant
            // 
            this.group_jbant.Controls.Add(this.chk_jbant16);
            this.group_jbant.Controls.Add(this.chk_jbant15);
            this.group_jbant.Controls.Add(this.chk_jbant14);
            this.group_jbant.Controls.Add(this.chk_jbant13);
            this.group_jbant.Controls.Add(this.chk_jbant12);
            this.group_jbant.Controls.Add(this.chk_jbant11);
            this.group_jbant.Controls.Add(this.chk_jbant10);
            this.group_jbant.Controls.Add(this.chk_jbant9);
            this.group_jbant.Controls.Add(this.chk_jbant8);
            this.group_jbant.Controls.Add(this.chk_jbant7);
            this.group_jbant.Controls.Add(this.chk_jbant6);
            this.group_jbant.Controls.Add(this.chk_jbant5);
            this.group_jbant.Controls.Add(this.chk_jbant4);
            this.group_jbant.Controls.Add(this.chk_jbant3);
            this.group_jbant.Controls.Add(this.chk_jbant2);
            this.group_jbant.Controls.Add(this.chk_jbant1);
            this.group_jbant.Location = new System.Drawing.Point(7, 81);
            this.group_jbant.Name = "group_jbant";
            this.group_jbant.Size = new System.Drawing.Size(89, 431);
            this.group_jbant.TabIndex = 51;
            this.group_jbant.TabStop = false;
            this.group_jbant.Text = "Antenna";
            // 
            // chk_jbant16
            // 
            this.chk_jbant16.AutoSize = true;
            this.chk_jbant16.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant16.Location = new System.Drawing.Point(16, 327);
            this.chk_jbant16.Name = "chk_jbant16";
            this.chk_jbant16.Size = new System.Drawing.Size(54, 16);
            this.chk_jbant16.TabIndex = 49;
            this.chk_jbant16.Text = "ANT16";
            this.chk_jbant16.UseVisualStyleBackColor = true;
            // 
            // chk_jbant15
            // 
            this.chk_jbant15.AutoSize = true;
            this.chk_jbant15.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant15.Location = new System.Drawing.Point(16, 306);
            this.chk_jbant15.Name = "chk_jbant15";
            this.chk_jbant15.Size = new System.Drawing.Size(54, 16);
            this.chk_jbant15.TabIndex = 48;
            this.chk_jbant15.Text = "ANT15";
            this.chk_jbant15.UseVisualStyleBackColor = true;
            // 
            // chk_jbant14
            // 
            this.chk_jbant14.AutoSize = true;
            this.chk_jbant14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant14.Location = new System.Drawing.Point(16, 286);
            this.chk_jbant14.Name = "chk_jbant14";
            this.chk_jbant14.Size = new System.Drawing.Size(54, 16);
            this.chk_jbant14.TabIndex = 47;
            this.chk_jbant14.Text = "ANT14";
            this.chk_jbant14.UseVisualStyleBackColor = true;
            // 
            // chk_jbant13
            // 
            this.chk_jbant13.AutoSize = true;
            this.chk_jbant13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant13.Location = new System.Drawing.Point(16, 266);
            this.chk_jbant13.Name = "chk_jbant13";
            this.chk_jbant13.Size = new System.Drawing.Size(54, 16);
            this.chk_jbant13.TabIndex = 46;
            this.chk_jbant13.Text = "ANT13";
            this.chk_jbant13.UseVisualStyleBackColor = true;
            // 
            // chk_jbant12
            // 
            this.chk_jbant12.AutoSize = true;
            this.chk_jbant12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant12.Location = new System.Drawing.Point(16, 245);
            this.chk_jbant12.Name = "chk_jbant12";
            this.chk_jbant12.Size = new System.Drawing.Size(54, 16);
            this.chk_jbant12.TabIndex = 45;
            this.chk_jbant12.Text = "ANT12";
            this.chk_jbant12.UseVisualStyleBackColor = true;
            // 
            // chk_jbant11
            // 
            this.chk_jbant11.AutoSize = true;
            this.chk_jbant11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant11.Location = new System.Drawing.Point(16, 225);
            this.chk_jbant11.Name = "chk_jbant11";
            this.chk_jbant11.Size = new System.Drawing.Size(54, 16);
            this.chk_jbant11.TabIndex = 44;
            this.chk_jbant11.Text = "ANT11";
            this.chk_jbant11.UseVisualStyleBackColor = true;
            // 
            // chk_jbant10
            // 
            this.chk_jbant10.AutoSize = true;
            this.chk_jbant10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant10.Location = new System.Drawing.Point(16, 203);
            this.chk_jbant10.Name = "chk_jbant10";
            this.chk_jbant10.Size = new System.Drawing.Size(54, 16);
            this.chk_jbant10.TabIndex = 43;
            this.chk_jbant10.Text = "ANT10";
            this.chk_jbant10.UseVisualStyleBackColor = true;
            // 
            // chk_jbant9
            // 
            this.chk_jbant9.AutoSize = true;
            this.chk_jbant9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant9.Location = new System.Drawing.Point(16, 183);
            this.chk_jbant9.Name = "chk_jbant9";
            this.chk_jbant9.Size = new System.Drawing.Size(48, 16);
            this.chk_jbant9.TabIndex = 42;
            this.chk_jbant9.Text = "ANT9";
            this.chk_jbant9.UseVisualStyleBackColor = true;
            // 
            // chk_jbant8
            // 
            this.chk_jbant8.AutoSize = true;
            this.chk_jbant8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant8.Location = new System.Drawing.Point(16, 163);
            this.chk_jbant8.Name = "chk_jbant8";
            this.chk_jbant8.Size = new System.Drawing.Size(48, 16);
            this.chk_jbant8.TabIndex = 41;
            this.chk_jbant8.Text = "ANT8";
            this.chk_jbant8.UseVisualStyleBackColor = true;
            // 
            // chk_jbant7
            // 
            this.chk_jbant7.AutoSize = true;
            this.chk_jbant7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant7.Location = new System.Drawing.Point(16, 142);
            this.chk_jbant7.Name = "chk_jbant7";
            this.chk_jbant7.Size = new System.Drawing.Size(48, 16);
            this.chk_jbant7.TabIndex = 40;
            this.chk_jbant7.Text = "ANT7";
            this.chk_jbant7.UseVisualStyleBackColor = true;
            // 
            // chk_jbant6
            // 
            this.chk_jbant6.AutoSize = true;
            this.chk_jbant6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant6.Location = new System.Drawing.Point(16, 122);
            this.chk_jbant6.Name = "chk_jbant6";
            this.chk_jbant6.Size = new System.Drawing.Size(48, 16);
            this.chk_jbant6.TabIndex = 39;
            this.chk_jbant6.Text = "ANT6";
            this.chk_jbant6.UseVisualStyleBackColor = true;
            // 
            // chk_jbant5
            // 
            this.chk_jbant5.AutoSize = true;
            this.chk_jbant5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant5.Location = new System.Drawing.Point(16, 102);
            this.chk_jbant5.Name = "chk_jbant5";
            this.chk_jbant5.Size = new System.Drawing.Size(48, 16);
            this.chk_jbant5.TabIndex = 38;
            this.chk_jbant5.Text = "ANT5";
            this.chk_jbant5.UseVisualStyleBackColor = true;
            // 
            // chk_jbant4
            // 
            this.chk_jbant4.AutoSize = true;
            this.chk_jbant4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant4.Location = new System.Drawing.Point(16, 81);
            this.chk_jbant4.Name = "chk_jbant4";
            this.chk_jbant4.Size = new System.Drawing.Size(48, 16);
            this.chk_jbant4.TabIndex = 37;
            this.chk_jbant4.Text = "ANT4";
            this.chk_jbant4.UseVisualStyleBackColor = true;
            this.chk_jbant4.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // chk_jbant3
            // 
            this.chk_jbant3.AutoSize = true;
            this.chk_jbant3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant3.Location = new System.Drawing.Point(16, 61);
            this.chk_jbant3.Name = "chk_jbant3";
            this.chk_jbant3.Size = new System.Drawing.Size(48, 16);
            this.chk_jbant3.TabIndex = 36;
            this.chk_jbant3.Text = "ANT3";
            this.chk_jbant3.UseVisualStyleBackColor = true;
            // 
            // chk_jbant2
            // 
            this.chk_jbant2.AutoSize = true;
            this.chk_jbant2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant2.Location = new System.Drawing.Point(16, 39);
            this.chk_jbant2.Name = "chk_jbant2";
            this.chk_jbant2.Size = new System.Drawing.Size(48, 16);
            this.chk_jbant2.TabIndex = 35;
            this.chk_jbant2.Text = "ANT2";
            this.chk_jbant2.UseVisualStyleBackColor = true;
            // 
            // chk_jbant1
            // 
            this.chk_jbant1.AutoSize = true;
            this.chk_jbant1.Checked = true;
            this.chk_jbant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_jbant1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_jbant1.Location = new System.Drawing.Point(16, 19);
            this.chk_jbant1.Name = "chk_jbant1";
            this.chk_jbant1.Size = new System.Drawing.Size(48, 16);
            this.chk_jbant1.TabIndex = 34;
            this.chk_jbant1.Text = "ANT1";
            this.chk_jbant1.UseVisualStyleBackColor = true;
            // 
            // com_jb_tagid
            // 
            this.com_jb_tagid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_jb_tagid.FormattingEnabled = true;
            this.com_jb_tagid.Location = new System.Drawing.Point(851, 92);
            this.com_jb_tagid.Name = "com_jb_tagid";
            this.com_jb_tagid.Size = new System.Drawing.Size(203, 20);
            this.com_jb_tagid.TabIndex = 50;
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label132.Location = new System.Drawing.Point(787, 96);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(53, 12);
            this.label132.TabIndex = 49;
            this.label132.Text = "TagList:";
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage1);
            this.tabControl4.Controls.Add(this.tabPage2);
            this.tabControl4.Controls.Add(this.tabPage3);
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Controls.Add(this.tabPage5);
            this.tabControl4.Location = new System.Drawing.Point(785, 127);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(275, 435);
            this.tabControl4.TabIndex = 48;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_jb_read);
            this.tabPage1.Controls.Add(this.txt_jb_read_data);
            this.tabPage1.Controls.Add(this.label137);
            this.tabPage1.Controls.Add(this.txt_jb_read_pwd);
            this.tabPage1.Controls.Add(this.label136);
            this.tabPage1.Controls.Add(this.txt_jb_read_len);
            this.tabPage1.Controls.Add(this.label135);
            this.tabPage1.Controls.Add(this.txt_jb_read_startaddr);
            this.tabPage1.Controls.Add(this.label134);
            this.tabPage1.Controls.Add(this.cbb_jb_readmem);
            this.tabPage1.Controls.Add(this.label133);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(267, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_jb_read
            // 
            this.bt_jb_read.Location = new System.Drawing.Point(120, 298);
            this.bt_jb_read.Name = "bt_jb_read";
            this.bt_jb_read.Size = new System.Drawing.Size(105, 29);
            this.bt_jb_read.TabIndex = 15;
            this.bt_jb_read.Text = "Read";
            this.bt_jb_read.UseVisualStyleBackColor = true;
            this.bt_jb_read.Click += new System.EventHandler(this.bt_jb_read_Click);
            // 
            // txt_jb_read_data
            // 
            this.txt_jb_read_data.Location = new System.Drawing.Point(120, 193);
            this.txt_jb_read_data.MaxLength = 0;
            this.txt_jb_read_data.Multiline = true;
            this.txt_jb_read_data.Name = "txt_jb_read_data";
            this.txt_jb_read_data.Size = new System.Drawing.Size(139, 90);
            this.txt_jb_read_data.TabIndex = 14;
            this.txt_jb_read_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(21, 196);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(83, 12);
            this.label137.TabIndex = 13;
            this.label137.Text = "Content(Hex):";
            // 
            // txt_jb_read_pwd
            // 
            this.txt_jb_read_pwd.Location = new System.Drawing.Point(120, 149);
            this.txt_jb_read_pwd.MaxLength = 8;
            this.txt_jb_read_pwd.Name = "txt_jb_read_pwd";
            this.txt_jb_read_pwd.Size = new System.Drawing.Size(141, 21);
            this.txt_jb_read_pwd.TabIndex = 12;
            this.txt_jb_read_pwd.Text = "00000000";
            this.txt_jb_read_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(21, 152);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(89, 12);
            this.label136.TabIndex = 11;
            this.label136.Text = "Password(Hex):";
            // 
            // txt_jb_read_len
            // 
            this.txt_jb_read_len.Location = new System.Drawing.Point(120, 104);
            this.txt_jb_read_len.MaxLength = 4;
            this.txt_jb_read_len.Name = "txt_jb_read_len";
            this.txt_jb_read_len.Size = new System.Drawing.Size(141, 21);
            this.txt_jb_read_len.TabIndex = 10;
            this.txt_jb_read_len.Text = "6";
            this.txt_jb_read_len.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(51, 107);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(47, 12);
            this.label135.TabIndex = 9;
            this.label135.Text = "Length:";
            // 
            // txt_jb_read_startaddr
            // 
            this.txt_jb_read_startaddr.Location = new System.Drawing.Point(120, 63);
            this.txt_jb_read_startaddr.MaxLength = 4;
            this.txt_jb_read_startaddr.Name = "txt_jb_read_startaddr";
            this.txt_jb_read_startaddr.Size = new System.Drawing.Size(141, 21);
            this.txt_jb_read_startaddr.TabIndex = 8;
            this.txt_jb_read_startaddr.Text = "0";
            this.txt_jb_read_startaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(12, 67);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(83, 12);
            this.label134.TabIndex = 7;
            this.label134.Text = "StartAddress:";
            // 
            // cbb_jb_readmem
            // 
            this.cbb_jb_readmem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_jb_readmem.FormattingEnabled = true;
            this.cbb_jb_readmem.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "USER",
            "USER2",
            "USER3"});
            this.cbb_jb_readmem.Location = new System.Drawing.Point(120, 26);
            this.cbb_jb_readmem.Name = "cbb_jb_readmem";
            this.cbb_jb_readmem.Size = new System.Drawing.Size(141, 20);
            this.cbb_jb_readmem.TabIndex = 3;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(53, 30);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(47, 12);
            this.label133.TabIndex = 2;
            this.label133.Text = "Memory:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_jb_write);
            this.tabPage2.Controls.Add(this.txt_jb_write_data);
            this.tabPage2.Controls.Add(this.label138);
            this.tabPage2.Controls.Add(this.txt_jb_write_pwd);
            this.tabPage2.Controls.Add(this.label139);
            this.tabPage2.Controls.Add(this.txt_jb_write_startaddr);
            this.tabPage2.Controls.Add(this.label141);
            this.tabPage2.Controls.Add(this.cbb_jb_writemem);
            this.tabPage2.Controls.Add(this.label142);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(267, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Write";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_jb_write
            // 
            this.bt_jb_write.Location = new System.Drawing.Point(121, 302);
            this.bt_jb_write.Name = "bt_jb_write";
            this.bt_jb_write.Size = new System.Drawing.Size(105, 29);
            this.bt_jb_write.TabIndex = 26;
            this.bt_jb_write.Text = "Write";
            this.bt_jb_write.UseVisualStyleBackColor = true;
            this.bt_jb_write.Click += new System.EventHandler(this.bt_jb_write_Click);
            // 
            // txt_jb_write_data
            // 
            this.txt_jb_write_data.Location = new System.Drawing.Point(121, 154);
            this.txt_jb_write_data.MaxLength = 0;
            this.txt_jb_write_data.Multiline = true;
            this.txt_jb_write_data.Name = "txt_jb_write_data";
            this.txt_jb_write_data.Size = new System.Drawing.Size(142, 137);
            this.txt_jb_write_data.TabIndex = 25;
            this.txt_jb_write_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(22, 157);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(83, 12);
            this.label138.TabIndex = 24;
            this.label138.Text = "Content(Hex):";
            // 
            // txt_jb_write_pwd
            // 
            this.txt_jb_write_pwd.Location = new System.Drawing.Point(121, 110);
            this.txt_jb_write_pwd.MaxLength = 8;
            this.txt_jb_write_pwd.Name = "txt_jb_write_pwd";
            this.txt_jb_write_pwd.Size = new System.Drawing.Size(141, 21);
            this.txt_jb_write_pwd.TabIndex = 23;
            this.txt_jb_write_pwd.Text = "00000000";
            this.txt_jb_write_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(22, 113);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(89, 12);
            this.label139.TabIndex = 22;
            this.label139.Text = "Password(Hex):";
            // 
            // txt_jb_write_startaddr
            // 
            this.txt_jb_write_startaddr.Location = new System.Drawing.Point(121, 67);
            this.txt_jb_write_startaddr.MaxLength = 4;
            this.txt_jb_write_startaddr.Name = "txt_jb_write_startaddr";
            this.txt_jb_write_startaddr.Size = new System.Drawing.Size(141, 21);
            this.txt_jb_write_startaddr.TabIndex = 19;
            this.txt_jb_write_startaddr.Text = "0";
            this.txt_jb_write_startaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(20, 71);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(83, 12);
            this.label141.TabIndex = 18;
            this.label141.Text = "StartAddress:";
            // 
            // cbb_jb_writemem
            // 
            this.cbb_jb_writemem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_jb_writemem.FormattingEnabled = true;
            this.cbb_jb_writemem.Items.AddRange(new object[] {
            "EPC",
            "SAFETY",
            "USER",
            "USER2",
            "USER3"});
            this.cbb_jb_writemem.Location = new System.Drawing.Point(121, 30);
            this.cbb_jb_writemem.Name = "cbb_jb_writemem";
            this.cbb_jb_writemem.Size = new System.Drawing.Size(141, 20);
            this.cbb_jb_writemem.TabIndex = 17;
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(54, 34);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(47, 12);
            this.label142.TabIndex = 16;
            this.label142.Text = "Memory:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbb_jb_locktype);
            this.tabPage3.Controls.Add(this.bt_jb_lock);
            this.tabPage3.Controls.Add(this.label143);
            this.tabPage3.Controls.Add(this.txt_jb_lock_pwd);
            this.tabPage3.Controls.Add(this.label144);
            this.tabPage3.Controls.Add(this.cbb_jb_lockmem);
            this.tabPage3.Controls.Add(this.label145);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(267, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lock";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbb_jb_locktype
            // 
            this.cbb_jb_locktype.FormattingEnabled = true;
            this.cbb_jb_locktype.Items.AddRange(new object[] {
            "Read And Write",
            "Read And UnWrite",
            "UnRead And Write",
            "UnRead And UnWrite"});
            this.cbb_jb_locktype.Location = new System.Drawing.Point(120, 110);
            this.cbb_jb_locktype.Name = "cbb_jb_locktype";
            this.cbb_jb_locktype.Size = new System.Drawing.Size(142, 20);
            this.cbb_jb_locktype.TabIndex = 36;
            // 
            // bt_jb_lock
            // 
            this.bt_jb_lock.Location = new System.Drawing.Point(120, 155);
            this.bt_jb_lock.Name = "bt_jb_lock";
            this.bt_jb_lock.Size = new System.Drawing.Size(105, 29);
            this.bt_jb_lock.TabIndex = 35;
            this.bt_jb_lock.Text = "Lock";
            this.bt_jb_lock.UseVisualStyleBackColor = true;
            this.bt_jb_lock.Click += new System.EventHandler(this.bt_jb_lock_Click);
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(14, 113);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(95, 12);
            this.label143.TabIndex = 31;
            this.label143.Text = "Operation Type:";
            // 
            // txt_jb_lock_pwd
            // 
            this.txt_jb_lock_pwd.Location = new System.Drawing.Point(121, 67);
            this.txt_jb_lock_pwd.MaxLength = 8;
            this.txt_jb_lock_pwd.Name = "txt_jb_lock_pwd";
            this.txt_jb_lock_pwd.Size = new System.Drawing.Size(141, 21);
            this.txt_jb_lock_pwd.TabIndex = 30;
            this.txt_jb_lock_pwd.Text = "00000000";
            this.txt_jb_lock_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(17, 71);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(89, 12);
            this.label144.TabIndex = 29;
            this.label144.Text = "Password(Hex):";
            // 
            // cbb_jb_lockmem
            // 
            this.cbb_jb_lockmem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_jb_lockmem.FormattingEnabled = true;
            this.cbb_jb_lockmem.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "SAFETY",
            "USER",
            "USER2",
            "USER3"});
            this.cbb_jb_lockmem.Location = new System.Drawing.Point(121, 30);
            this.cbb_jb_lockmem.Name = "cbb_jb_lockmem";
            this.cbb_jb_lockmem.Size = new System.Drawing.Size(141, 20);
            this.cbb_jb_lockmem.TabIndex = 28;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(54, 34);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(47, 12);
            this.label145.TabIndex = 27;
            this.label145.Text = "Memory:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bt_jb_erase);
            this.tabPage4.Controls.Add(this.txt_jb_erase_pwd);
            this.tabPage4.Controls.Add(this.label146);
            this.tabPage4.Controls.Add(this.txt_jb_erase_num);
            this.tabPage4.Controls.Add(this.label147);
            this.tabPage4.Controls.Add(this.txt_jb_erase_startaddr);
            this.tabPage4.Controls.Add(this.label148);
            this.tabPage4.Controls.Add(this.cbb_jb_erasemem);
            this.tabPage4.Controls.Add(this.label149);
            this.tabPage4.Location = new System.Drawing.Point(4, 21);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(267, 410);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Erase";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bt_jb_erase
            // 
            this.bt_jb_erase.Location = new System.Drawing.Point(121, 200);
            this.bt_jb_erase.Name = "bt_jb_erase";
            this.bt_jb_erase.Size = new System.Drawing.Size(105, 29);
            this.bt_jb_erase.TabIndex = 26;
            this.bt_jb_erase.Text = "Erase";
            this.bt_jb_erase.UseVisualStyleBackColor = true;
            this.bt_jb_erase.Click += new System.EventHandler(this.bt_jb_erase_Click);
            // 
            // txt_jb_erase_pwd
            // 
            this.txt_jb_erase_pwd.Location = new System.Drawing.Point(121, 154);
            this.txt_jb_erase_pwd.MaxLength = 8;
            this.txt_jb_erase_pwd.Name = "txt_jb_erase_pwd";
            this.txt_jb_erase_pwd.Size = new System.Drawing.Size(141, 21);
            this.txt_jb_erase_pwd.TabIndex = 23;
            this.txt_jb_erase_pwd.Text = "00000000";
            this.txt_jb_erase_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(22, 157);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(89, 12);
            this.label146.TabIndex = 22;
            this.label146.Text = "Password(Hex):";
            // 
            // txt_jb_erase_num
            // 
            this.txt_jb_erase_num.Location = new System.Drawing.Point(121, 109);
            this.txt_jb_erase_num.MaxLength = 4;
            this.txt_jb_erase_num.Name = "txt_jb_erase_num";
            this.txt_jb_erase_num.Size = new System.Drawing.Size(141, 21);
            this.txt_jb_erase_num.TabIndex = 21;
            this.txt_jb_erase_num.Text = "2";
            this.txt_jb_erase_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(52, 112);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(47, 12);
            this.label147.TabIndex = 20;
            this.label147.Text = "Length:";
            // 
            // txt_jb_erase_startaddr
            // 
            this.txt_jb_erase_startaddr.Location = new System.Drawing.Point(121, 68);
            this.txt_jb_erase_startaddr.MaxLength = 4;
            this.txt_jb_erase_startaddr.Name = "txt_jb_erase_startaddr";
            this.txt_jb_erase_startaddr.Size = new System.Drawing.Size(141, 21);
            this.txt_jb_erase_startaddr.TabIndex = 19;
            this.txt_jb_erase_startaddr.Text = "0";
            this.txt_jb_erase_startaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(17, 72);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(83, 12);
            this.label148.TabIndex = 18;
            this.label148.Text = "StartAddress:";
            // 
            // cbb_jb_erasemem
            // 
            this.cbb_jb_erasemem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_jb_erasemem.FormattingEnabled = true;
            this.cbb_jb_erasemem.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "SAFETY",
            "USER",
            "USER2",
            "USER3"});
            this.cbb_jb_erasemem.Location = new System.Drawing.Point(121, 31);
            this.cbb_jb_erasemem.Name = "cbb_jb_erasemem";
            this.cbb_jb_erasemem.Size = new System.Drawing.Size(141, 20);
            this.cbb_jb_erasemem.TabIndex = 17;
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(54, 35);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(47, 12);
            this.label149.TabIndex = 16;
            this.label149.Text = "Memory:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.bt_jb_kill);
            this.tabPage5.Controls.Add(this.txt_jb_kill_pwd);
            this.tabPage5.Controls.Add(this.label150);
            this.tabPage5.Location = new System.Drawing.Point(4, 21);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(267, 410);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kill";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bt_jb_kill
            // 
            this.bt_jb_kill.Location = new System.Drawing.Point(131, 116);
            this.bt_jb_kill.Name = "bt_jb_kill";
            this.bt_jb_kill.Size = new System.Drawing.Size(105, 29);
            this.bt_jb_kill.TabIndex = 42;
            this.bt_jb_kill.Text = "Kill";
            this.bt_jb_kill.UseVisualStyleBackColor = true;
            this.bt_jb_kill.Click += new System.EventHandler(this.bt_jb_kill_Click);
            // 
            // txt_jb_kill_pwd
            // 
            this.txt_jb_kill_pwd.Location = new System.Drawing.Point(128, 66);
            this.txt_jb_kill_pwd.MaxLength = 8;
            this.txt_jb_kill_pwd.Name = "txt_jb_kill_pwd";
            this.txt_jb_kill_pwd.Size = new System.Drawing.Size(127, 21);
            this.txt_jb_kill_pwd.TabIndex = 40;
            this.txt_jb_kill_pwd.Text = "00000000";
            this.txt_jb_kill_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(7, 70);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(119, 12);
            this.label150.TabIndex = 39;
            this.label150.Text = "Kill Password(Hex):";
            // 
            // groupBox53
            // 
            this.groupBox53.Controls.Add(this.txt_jb_maskdata);
            this.groupBox53.Controls.Add(this.label131);
            this.groupBox53.Controls.Add(this.txt_mask_jb_startaddr);
            this.groupBox53.Controls.Add(this.label130);
            this.groupBox53.Controls.Add(this.cbb_jb_masktype);
            this.groupBox53.Controls.Add(this.label129);
            this.groupBox53.Controls.Add(this.chk_jb_mask);
            this.groupBox53.Location = new System.Drawing.Point(666, 5);
            this.groupBox53.Name = "groupBox53";
            this.groupBox53.Size = new System.Drawing.Size(394, 71);
            this.groupBox53.TabIndex = 47;
            this.groupBox53.TabStop = false;
            this.groupBox53.Text = "Mask";
            // 
            // txt_jb_maskdata
            // 
            this.txt_jb_maskdata.Location = new System.Drawing.Point(156, 42);
            this.txt_jb_maskdata.MaxLength = 0;
            this.txt_jb_maskdata.Name = "txt_jb_maskdata";
            this.txt_jb_maskdata.Size = new System.Drawing.Size(232, 21);
            this.txt_jb_maskdata.TabIndex = 8;
            this.txt_jb_maskdata.Text = "0000";
            this.txt_jb_maskdata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(64, 46);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(89, 12);
            this.label131.TabIndex = 7;
            this.label131.Text = "MaskData(Hex):";
            // 
            // txt_mask_jb_startaddr
            // 
            this.txt_mask_jb_startaddr.Location = new System.Drawing.Point(338, 17);
            this.txt_mask_jb_startaddr.MaxLength = 4;
            this.txt_mask_jb_startaddr.Name = "txt_mask_jb_startaddr";
            this.txt_mask_jb_startaddr.Size = new System.Drawing.Size(50, 21);
            this.txt_mask_jb_startaddr.TabIndex = 6;
            this.txt_mask_jb_startaddr.Text = "0";
            this.txt_mask_jb_startaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(271, 21);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(65, 12);
            this.label130.TabIndex = 5;
            this.label130.Text = "StartAddr:";
            // 
            // cbb_jb_masktype
            // 
            this.cbb_jb_masktype.FormattingEnabled = true;
            this.cbb_jb_masktype.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "SAFETY",
            "USER"});
            this.cbb_jb_masktype.Location = new System.Drawing.Point(145, 17);
            this.cbb_jb_masktype.Name = "cbb_jb_masktype";
            this.cbb_jb_masktype.Size = new System.Drawing.Size(124, 20);
            this.cbb_jb_masktype.TabIndex = 4;
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(84, 21);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(47, 12);
            this.label129.TabIndex = 3;
            this.label129.Text = "Memory:";
            // 
            // chk_jb_mask
            // 
            this.chk_jb_mask.AutoSize = true;
            this.chk_jb_mask.Location = new System.Drawing.Point(10, 19);
            this.chk_jb_mask.Name = "chk_jb_mask";
            this.chk_jb_mask.Size = new System.Drawing.Size(60, 16);
            this.chk_jb_mask.TabIndex = 0;
            this.chk_jb_mask.Text = "Enable";
            this.chk_jb_mask.UseVisualStyleBackColor = true;
            // 
            // lxLed_jb_number
            // 
            this.lxLed_jb_number.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_jb_number.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_jb_number.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_jb_number.BevelRate = 0.5F;
            this.lxLed_jb_number.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_jb_number.BorderWidth = 3;
            this.lxLed_jb_number.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_jb_number.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_jb_number.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_jb_number.HighlightOpaque = ((byte)(50));
            this.lxLed_jb_number.Location = new System.Drawing.Point(609, 519);
            this.lxLed_jb_number.Name = "lxLed_jb_number";
            this.lxLed_jb_number.RoundCorner = true;
            this.lxLed_jb_number.ShowHighlight = true;
            this.lxLed_jb_number.Size = new System.Drawing.Size(154, 41);
            this.lxLed_jb_number.TabIndex = 46;
            this.lxLed_jb_number.Text = "0";
            this.lxLed_jb_number.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_jb_number.TotalCharCount = 7;
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label128.Location = new System.Drawing.Point(514, 533);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(47, 12);
            this.label128.TabIndex = 45;
            this.label128.Text = "Number:";
            // 
            // lxLed_jb_time
            // 
            this.lxLed_jb_time.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_jb_time.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_jb_time.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_jb_time.BevelRate = 0.5F;
            this.lxLed_jb_time.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_jb_time.BorderWidth = 3;
            this.lxLed_jb_time.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_jb_time.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_jb_time.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_jb_time.HighlightOpaque = ((byte)(50));
            this.lxLed_jb_time.Location = new System.Drawing.Point(253, 519);
            this.lxLed_jb_time.Name = "lxLed_jb_time";
            this.lxLed_jb_time.RoundCorner = true;
            this.lxLed_jb_time.ShowHighlight = true;
            this.lxLed_jb_time.Size = new System.Drawing.Size(154, 40);
            this.lxLed_jb_time.TabIndex = 44;
            this.lxLed_jb_time.Text = "0";
            this.lxLed_jb_time.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_jb_time.TotalCharCount = 7;
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label127.Location = new System.Drawing.Point(130, 533);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(77, 12);
            this.label127.TabIndex = 43;
            this.label127.Text = "RunTime(ms):";
            // 
            // groupBox52
            // 
            this.groupBox52.Controls.Add(this.dataGridView_JB);
            this.groupBox52.Location = new System.Drawing.Point(103, 80);
            this.groupBox52.Name = "groupBox52";
            this.groupBox52.Size = new System.Drawing.Size(678, 433);
            this.groupBox52.TabIndex = 42;
            this.groupBox52.TabStop = false;
            this.groupBox52.Text = "TagList";
            // 
            // dataGridView_JB
            // 
            this.dataGridView_JB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_JB.AllowUserToAddRows = false;
            this.dataGridView_JB.AllowUserToDeleteRows = false;
            this.dataGridView_JB.AllowUserToResizeColumns = false;
            this.dataGridView_JB.AllowUserToResizeRows = false;
            this.dataGridView_JB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_JB.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_JB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_JB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_JB.Location = new System.Drawing.Point(6, 13);
            this.dataGridView_JB.MultiSelect = false;
            this.dataGridView_JB.Name = "dataGridView_JB";
            this.dataGridView_JB.ReadOnly = true;
            this.dataGridView_JB.RowHeadersVisible = false;
            this.dataGridView_JB.RowTemplate.Height = 23;
            this.dataGridView_JB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_JB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_JB.Size = new System.Drawing.Size(664, 413);
            this.dataGridView_JB.TabIndex = 1;
            // 
            // gbp_jb_mix
            // 
            this.gbp_jb_mix.Controls.Add(this.tx_jb_readpsd);
            this.gbp_jb_mix.Controls.Add(this.label123);
            this.gbp_jb_mix.Controls.Add(this.tx_jb_masklen);
            this.gbp_jb_mix.Controls.Add(this.label124);
            this.gbp_jb_mix.Controls.Add(this.tx_jb_maskaddr);
            this.gbp_jb_mix.Controls.Add(this.label125);
            this.gbp_jb_mix.Controls.Add(this.cbb_jb_maskmem);
            this.gbp_jb_mix.Controls.Add(this.label126);
            this.gbp_jb_mix.Enabled = false;
            this.gbp_jb_mix.Location = new System.Drawing.Point(400, 5);
            this.gbp_jb_mix.Name = "gbp_jb_mix";
            this.gbp_jb_mix.Size = new System.Drawing.Size(264, 71);
            this.gbp_jb_mix.TabIndex = 41;
            this.gbp_jb_mix.TabStop = false;
            this.gbp_jb_mix.Text = "Mix";
            // 
            // tx_jb_readpsd
            // 
            this.tx_jb_readpsd.Location = new System.Drawing.Point(95, 42);
            this.tx_jb_readpsd.MaxLength = 8;
            this.tx_jb_readpsd.Name = "tx_jb_readpsd";
            this.tx_jb_readpsd.Size = new System.Drawing.Size(80, 21);
            this.tx_jb_readpsd.TabIndex = 7;
            this.tx_jb_readpsd.Text = "00000000";
            this.tx_jb_readpsd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(4, 46);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(89, 12);
            this.label123.TabIndex = 6;
            this.label123.Text = "Password(Hex):";
            // 
            // tx_jb_masklen
            // 
            this.tx_jb_masklen.Location = new System.Drawing.Point(218, 44);
            this.tx_jb_masklen.MaxLength = 3;
            this.tx_jb_masklen.Name = "tx_jb_masklen";
            this.tx_jb_masklen.Size = new System.Drawing.Size(41, 21);
            this.tx_jb_masklen.TabIndex = 5;
            this.tx_jb_masklen.Text = "4";
            this.tx_jb_masklen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(178, 48);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(29, 12);
            this.label124.TabIndex = 4;
            this.label124.Text = "Len:";
            // 
            // tx_jb_maskaddr
            // 
            this.tx_jb_maskaddr.Location = new System.Drawing.Point(218, 13);
            this.tx_jb_maskaddr.MaxLength = 5;
            this.tx_jb_maskaddr.Name = "tx_jb_maskaddr";
            this.tx_jb_maskaddr.Size = new System.Drawing.Size(41, 21);
            this.tx_jb_maskaddr.TabIndex = 3;
            this.tx_jb_maskaddr.Text = "0";
            this.tx_jb_maskaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(178, 17);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(35, 12);
            this.label125.TabIndex = 2;
            this.label125.Text = "Addr:";
            // 
            // cbb_jb_maskmem
            // 
            this.cbb_jb_maskmem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_jb_maskmem.FormattingEnabled = true;
            this.cbb_jb_maskmem.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "SAFETY",
            "USER",
            "USER2",
            "USER3"});
            this.cbb_jb_maskmem.Location = new System.Drawing.Point(64, 12);
            this.cbb_jb_maskmem.Name = "cbb_jb_maskmem";
            this.cbb_jb_maskmem.Size = new System.Drawing.Size(112, 20);
            this.cbb_jb_maskmem.TabIndex = 1;
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(5, 16);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(29, 12);
            this.label126.TabIndex = 0;
            this.label126.Text = "Mem:";
            // 
            // groupBox48
            // 
            this.groupBox48.Controls.Add(this.com_jb_target);
            this.groupBox48.Controls.Add(this.label151);
            this.groupBox48.Controls.Add(this.cbb_jb_scantime);
            this.groupBox48.Controls.Add(this.label140);
            this.groupBox48.Controls.Add(this.rb_jb_normal);
            this.groupBox48.Controls.Add(this.rb_jb_mix);
            this.groupBox48.Controls.Add(this.btInventoryJB);
            this.groupBox48.Location = new System.Drawing.Point(10, 1);
            this.groupBox48.Name = "groupBox48";
            this.groupBox48.Size = new System.Drawing.Size(388, 75);
            this.groupBox48.TabIndex = 39;
            this.groupBox48.TabStop = false;
            // 
            // com_jb_target
            // 
            this.com_jb_target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_jb_target.FormattingEnabled = true;
            this.com_jb_target.Items.AddRange(new object[] {
            "AUTO",
            "0",
            "1"});
            this.com_jb_target.Location = new System.Drawing.Point(305, 47);
            this.com_jb_target.Name = "com_jb_target";
            this.com_jb_target.Size = new System.Drawing.Size(69, 20);
            this.com_jb_target.TabIndex = 35;
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(264, 50);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(35, 12);
            this.label151.TabIndex = 34;
            this.label151.Text = "Flag:";
            // 
            // cbb_jb_scantime
            // 
            this.cbb_jb_scantime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_jb_scantime.FormattingEnabled = true;
            this.cbb_jb_scantime.Location = new System.Drawing.Point(179, 47);
            this.cbb_jb_scantime.Name = "cbb_jb_scantime";
            this.cbb_jb_scantime.Size = new System.Drawing.Size(69, 20);
            this.cbb_jb_scantime.TabIndex = 33;
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(120, 52);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(59, 12);
            this.label140.TabIndex = 32;
            this.label140.Text = "ScanTime:";
            // 
            // rb_jb_normal
            // 
            this.rb_jb_normal.AutoSize = true;
            this.rb_jb_normal.Checked = true;
            this.rb_jb_normal.Location = new System.Drawing.Point(133, 20);
            this.rb_jb_normal.Name = "rb_jb_normal";
            this.rb_jb_normal.Size = new System.Drawing.Size(59, 16);
            this.rb_jb_normal.TabIndex = 4;
            this.rb_jb_normal.TabStop = true;
            this.rb_jb_normal.Text = "Normal";
            this.rb_jb_normal.UseVisualStyleBackColor = true;
            this.rb_jb_normal.CheckedChanged += new System.EventHandler(this.rb_jb_normal_CheckedChanged);
            // 
            // rb_jb_mix
            // 
            this.rb_jb_mix.AutoSize = true;
            this.rb_jb_mix.Location = new System.Drawing.Point(276, 20);
            this.rb_jb_mix.Name = "rb_jb_mix";
            this.rb_jb_mix.Size = new System.Drawing.Size(41, 16);
            this.rb_jb_mix.TabIndex = 3;
            this.rb_jb_mix.Text = "Mix";
            this.rb_jb_mix.UseVisualStyleBackColor = true;
            this.rb_jb_mix.CheckedChanged += new System.EventHandler(this.rb_jb_mix_CheckedChanged);
            // 
            // btInventoryJB
            // 
            this.btInventoryJB.BackColor = System.Drawing.Color.Transparent;
            this.btInventoryJB.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInventoryJB.ForeColor = System.Drawing.Color.DarkBlue;
            this.btInventoryJB.Location = new System.Drawing.Point(6, 20);
            this.btInventoryJB.Name = "btInventoryJB";
            this.btInventoryJB.Size = new System.Drawing.Size(109, 40);
            this.btInventoryJB.TabIndex = 0;
            this.btInventoryJB.Text = "Start";
            this.btInventoryJB.UseVisualStyleBackColor = false;
            this.btInventoryJB.Click += new System.EventHandler(this.btInventoryJB_Click);
            // 
            // Main_Page6
            // 
            this.Main_Page6.Controls.Add(this.panel_gb);
            this.Main_Page6.Location = new System.Drawing.Point(4, 27);
            this.Main_Page6.Name = "Main_Page6";
            this.Main_Page6.Size = new System.Drawing.Size(1075, 571);
            this.Main_Page6.TabIndex = 5;
            this.Main_Page6.Text = "GB-test";
            this.Main_Page6.UseVisualStyleBackColor = true;
            // 
            // panel_gb
            // 
            this.panel_gb.Controls.Add(this.com_gb_tagid);
            this.panel_gb.Controls.Add(this.label11);
            this.panel_gb.Controls.Add(this.tabControl5);
            this.panel_gb.Controls.Add(this.groupBox46);
            this.panel_gb.Controls.Add(this.lxLed_gb_number);
            this.panel_gb.Controls.Add(this.label167);
            this.panel_gb.Controls.Add(this.lxLed_gb_time);
            this.panel_gb.Controls.Add(this.label168);
            this.panel_gb.Controls.Add(this.groupBox54);
            this.panel_gb.Controls.Add(this.gbp_gb_mix);
            this.panel_gb.Controls.Add(this.gbp_gb_ant);
            this.panel_gb.Controls.Add(this.groupBox55);
            this.panel_gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_gb.Location = new System.Drawing.Point(0, 0);
            this.panel_gb.Name = "panel_gb";
            this.panel_gb.Size = new System.Drawing.Size(1075, 571);
            this.panel_gb.TabIndex = 1;
            // 
            // com_gb_tagid
            // 
            this.com_gb_tagid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_gb_tagid.FormattingEnabled = true;
            this.com_gb_tagid.Location = new System.Drawing.Point(861, 92);
            this.com_gb_tagid.Name = "com_gb_tagid";
            this.com_gb_tagid.Size = new System.Drawing.Size(202, 20);
            this.com_gb_tagid.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(794, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 49;
            this.label11.Text = "Tag List:";
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage10);
            this.tabControl5.Controls.Add(this.tabPage11);
            this.tabControl5.Controls.Add(this.tabPage12);
            this.tabControl5.Controls.Add(this.tabPage13);
            this.tabControl5.Controls.Add(this.tabPage14);
            this.tabControl5.Location = new System.Drawing.Point(793, 127);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(275, 435);
            this.tabControl5.TabIndex = 48;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.bt_gb_read);
            this.tabPage10.Controls.Add(this.txt_gb_read_data);
            this.tabPage10.Controls.Add(this.label40);
            this.tabPage10.Controls.Add(this.txt_gb_read_pwd);
            this.tabPage10.Controls.Add(this.label41);
            this.tabPage10.Controls.Add(this.txt_gb_read_len);
            this.tabPage10.Controls.Add(this.label42);
            this.tabPage10.Controls.Add(this.txt_gb_read_startaddr);
            this.tabPage10.Controls.Add(this.label45);
            this.tabPage10.Controls.Add(this.cbb_gb_readmem);
            this.tabPage10.Controls.Add(this.label46);
            this.tabPage10.Location = new System.Drawing.Point(4, 21);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(267, 410);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Read";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // bt_gb_read
            // 
            this.bt_gb_read.Location = new System.Drawing.Point(120, 298);
            this.bt_gb_read.Name = "bt_gb_read";
            this.bt_gb_read.Size = new System.Drawing.Size(105, 29);
            this.bt_gb_read.TabIndex = 15;
            this.bt_gb_read.Text = "Read";
            this.bt_gb_read.UseVisualStyleBackColor = true;
            this.bt_gb_read.Click += new System.EventHandler(this.bt_gb_read_Click);
            // 
            // txt_gb_read_data
            // 
            this.txt_gb_read_data.Location = new System.Drawing.Point(120, 193);
            this.txt_gb_read_data.MaxLength = 0;
            this.txt_gb_read_data.Multiline = true;
            this.txt_gb_read_data.Name = "txt_gb_read_data";
            this.txt_gb_read_data.Size = new System.Drawing.Size(141, 90);
            this.txt_gb_read_data.TabIndex = 14;
            this.txt_gb_read_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(21, 196);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(83, 12);
            this.label40.TabIndex = 13;
            this.label40.Text = "Content(Hex):";
            // 
            // txt_gb_read_pwd
            // 
            this.txt_gb_read_pwd.Location = new System.Drawing.Point(120, 149);
            this.txt_gb_read_pwd.MaxLength = 8;
            this.txt_gb_read_pwd.Name = "txt_gb_read_pwd";
            this.txt_gb_read_pwd.Size = new System.Drawing.Size(141, 21);
            this.txt_gb_read_pwd.TabIndex = 12;
            this.txt_gb_read_pwd.Text = "00000000";
            this.txt_gb_read_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(21, 152);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(89, 12);
            this.label41.TabIndex = 11;
            this.label41.Text = "Password(Hex):";
            // 
            // txt_gb_read_len
            // 
            this.txt_gb_read_len.Location = new System.Drawing.Point(120, 104);
            this.txt_gb_read_len.MaxLength = 4;
            this.txt_gb_read_len.Name = "txt_gb_read_len";
            this.txt_gb_read_len.Size = new System.Drawing.Size(141, 21);
            this.txt_gb_read_len.TabIndex = 10;
            this.txt_gb_read_len.Text = "6";
            this.txt_gb_read_len.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(51, 107);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(47, 12);
            this.label42.TabIndex = 9;
            this.label42.Text = "Length:";
            // 
            // txt_gb_read_startaddr
            // 
            this.txt_gb_read_startaddr.Location = new System.Drawing.Point(120, 63);
            this.txt_gb_read_startaddr.MaxLength = 4;
            this.txt_gb_read_startaddr.Name = "txt_gb_read_startaddr";
            this.txt_gb_read_startaddr.Size = new System.Drawing.Size(141, 21);
            this.txt_gb_read_startaddr.TabIndex = 8;
            this.txt_gb_read_startaddr.Text = "0";
            this.txt_gb_read_startaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(32, 67);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 12);
            this.label45.TabIndex = 7;
            this.label45.Text = "StartAddr:";
            // 
            // cbb_gb_readmem
            // 
            this.cbb_gb_readmem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gb_readmem.FormattingEnabled = true;
            this.cbb_gb_readmem.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "SAFETY",
            "USER-0",
            "USER-1",
            "USER-2",
            "USER-3",
            "USER-4",
            "USER-5",
            "USER-6",
            "USER-7",
            "USER-8",
            "USER-9",
            "USER-10",
            "USER-11",
            "USER-12",
            "USER-13",
            "USER-14",
            "USER-15"});
            this.cbb_gb_readmem.Location = new System.Drawing.Point(120, 26);
            this.cbb_gb_readmem.Name = "cbb_gb_readmem";
            this.cbb_gb_readmem.Size = new System.Drawing.Size(141, 20);
            this.cbb_gb_readmem.TabIndex = 3;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(53, 30);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(47, 12);
            this.label46.TabIndex = 2;
            this.label46.Text = "Memory:";
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.bt_gb_write);
            this.tabPage11.Controls.Add(this.txt_gb_write_data);
            this.tabPage11.Controls.Add(this.label152);
            this.tabPage11.Controls.Add(this.txt_gb_write_pwd);
            this.tabPage11.Controls.Add(this.label153);
            this.tabPage11.Controls.Add(this.txt_gb_write_startaddr);
            this.tabPage11.Controls.Add(this.label154);
            this.tabPage11.Controls.Add(this.cbb_gb_writemem);
            this.tabPage11.Controls.Add(this.label155);
            this.tabPage11.Location = new System.Drawing.Point(4, 21);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(267, 410);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Write";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // bt_gb_write
            // 
            this.bt_gb_write.Location = new System.Drawing.Point(121, 302);
            this.bt_gb_write.Name = "bt_gb_write";
            this.bt_gb_write.Size = new System.Drawing.Size(105, 29);
            this.bt_gb_write.TabIndex = 26;
            this.bt_gb_write.Text = "Write";
            this.bt_gb_write.UseVisualStyleBackColor = true;
            this.bt_gb_write.Click += new System.EventHandler(this.bt_gb_write_Click);
            // 
            // txt_gb_write_data
            // 
            this.txt_gb_write_data.Location = new System.Drawing.Point(121, 154);
            this.txt_gb_write_data.MaxLength = 0;
            this.txt_gb_write_data.Multiline = true;
            this.txt_gb_write_data.Name = "txt_gb_write_data";
            this.txt_gb_write_data.Size = new System.Drawing.Size(141, 137);
            this.txt_gb_write_data.TabIndex = 25;
            this.txt_gb_write_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(22, 157);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(83, 12);
            this.label152.TabIndex = 24;
            this.label152.Text = "Content(Hex):";
            // 
            // txt_gb_write_pwd
            // 
            this.txt_gb_write_pwd.Location = new System.Drawing.Point(121, 110);
            this.txt_gb_write_pwd.MaxLength = 8;
            this.txt_gb_write_pwd.Name = "txt_gb_write_pwd";
            this.txt_gb_write_pwd.Size = new System.Drawing.Size(141, 21);
            this.txt_gb_write_pwd.TabIndex = 23;
            this.txt_gb_write_pwd.Text = "00000000";
            this.txt_gb_write_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Location = new System.Drawing.Point(22, 113);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(89, 12);
            this.label153.TabIndex = 22;
            this.label153.Text = "Password(Hex):";
            // 
            // txt_gb_write_startaddr
            // 
            this.txt_gb_write_startaddr.Location = new System.Drawing.Point(121, 67);
            this.txt_gb_write_startaddr.MaxLength = 4;
            this.txt_gb_write_startaddr.Name = "txt_gb_write_startaddr";
            this.txt_gb_write_startaddr.Size = new System.Drawing.Size(141, 21);
            this.txt_gb_write_startaddr.TabIndex = 19;
            this.txt_gb_write_startaddr.Text = "0";
            this.txt_gb_write_startaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(38, 71);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(65, 12);
            this.label154.TabIndex = 18;
            this.label154.Text = "StartAddr:";
            // 
            // cbb_gb_writemem
            // 
            this.cbb_gb_writemem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gb_writemem.FormattingEnabled = true;
            this.cbb_gb_writemem.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "SAFETY",
            "USER-0",
            "USER-1",
            "USER-2",
            "USER-3",
            "USER-4",
            "USER-5",
            "USER-6",
            "USER-7",
            "USER-8",
            "USER-9",
            "USER-10",
            "USER-11",
            "USER-12",
            "USER-13",
            "USER-14",
            "USER-15"});
            this.cbb_gb_writemem.Location = new System.Drawing.Point(121, 30);
            this.cbb_gb_writemem.Name = "cbb_gb_writemem";
            this.cbb_gb_writemem.Size = new System.Drawing.Size(141, 20);
            this.cbb_gb_writemem.TabIndex = 17;
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(54, 34);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(47, 12);
            this.label155.TabIndex = 16;
            this.label155.Text = "Memory:";
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.cbb_gb_locktype);
            this.tabPage12.Controls.Add(this.bt_gb_lock);
            this.tabPage12.Controls.Add(this.label156);
            this.tabPage12.Controls.Add(this.txt_gb_lock_pwd);
            this.tabPage12.Controls.Add(this.label157);
            this.tabPage12.Controls.Add(this.cbb_gb_lockmem);
            this.tabPage12.Controls.Add(this.label158);
            this.tabPage12.Location = new System.Drawing.Point(4, 21);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(267, 410);
            this.tabPage12.TabIndex = 2;
            this.tabPage12.Text = "Lock";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // cbb_gb_locktype
            // 
            this.cbb_gb_locktype.FormattingEnabled = true;
            this.cbb_gb_locktype.Items.AddRange(new object[] {
            "Read And Write",
            "Read And UnWrite",
            "UnRead And Write",
            "UnRead And UnWrite",
            "Safe mode without auth",
            "Safe mode with auth,and not secure",
            "Safe mode with auth,and secure"});
            this.cbb_gb_locktype.Location = new System.Drawing.Point(120, 110);
            this.cbb_gb_locktype.Name = "cbb_gb_locktype";
            this.cbb_gb_locktype.Size = new System.Drawing.Size(141, 20);
            this.cbb_gb_locktype.TabIndex = 36;
            // 
            // bt_gb_lock
            // 
            this.bt_gb_lock.Location = new System.Drawing.Point(120, 155);
            this.bt_gb_lock.Name = "bt_gb_lock";
            this.bt_gb_lock.Size = new System.Drawing.Size(105, 29);
            this.bt_gb_lock.TabIndex = 35;
            this.bt_gb_lock.Text = "锁标签";
            this.bt_gb_lock.UseVisualStyleBackColor = true;
            this.bt_gb_lock.Click += new System.EventHandler(this.bt_gb_lock_Click);
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(22, 113);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(95, 12);
            this.label156.TabIndex = 31;
            this.label156.Text = "Operation Type:";
            // 
            // txt_gb_lock_pwd
            // 
            this.txt_gb_lock_pwd.Location = new System.Drawing.Point(121, 67);
            this.txt_gb_lock_pwd.MaxLength = 8;
            this.txt_gb_lock_pwd.Name = "txt_gb_lock_pwd";
            this.txt_gb_lock_pwd.Size = new System.Drawing.Size(141, 21);
            this.txt_gb_lock_pwd.TabIndex = 30;
            this.txt_gb_lock_pwd.Text = "00000000";
            this.txt_gb_lock_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Location = new System.Drawing.Point(23, 71);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(89, 12);
            this.label157.TabIndex = 29;
            this.label157.Text = "Password(Hex):";
            // 
            // cbb_gb_lockmem
            // 
            this.cbb_gb_lockmem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gb_lockmem.FormattingEnabled = true;
            this.cbb_gb_lockmem.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "SAFETY",
            "USER-0",
            "USER-1",
            "USER-2",
            "USER-3",
            "USER-4",
            "USER-5",
            "USER-6",
            "USER-7",
            "USER-8",
            "USER-9",
            "USER-10",
            "USER-11",
            "USER-12",
            "USER-13",
            "USER-14",
            "USER-15"});
            this.cbb_gb_lockmem.Location = new System.Drawing.Point(121, 30);
            this.cbb_gb_lockmem.Name = "cbb_gb_lockmem";
            this.cbb_gb_lockmem.Size = new System.Drawing.Size(141, 20);
            this.cbb_gb_lockmem.TabIndex = 28;
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(54, 34);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(47, 12);
            this.label158.TabIndex = 27;
            this.label158.Text = "Memory:";
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.bt_gb_erase);
            this.tabPage13.Controls.Add(this.txt_gb_erase_pwd);
            this.tabPage13.Controls.Add(this.label159);
            this.tabPage13.Controls.Add(this.txt_gb_erase_num);
            this.tabPage13.Controls.Add(this.label160);
            this.tabPage13.Controls.Add(this.txt_gb_erase_startaddr);
            this.tabPage13.Controls.Add(this.label161);
            this.tabPage13.Controls.Add(this.cbb_gb_erasemem);
            this.tabPage13.Controls.Add(this.label162);
            this.tabPage13.Location = new System.Drawing.Point(4, 21);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(267, 410);
            this.tabPage13.TabIndex = 3;
            this.tabPage13.Text = "Erase";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // bt_gb_erase
            // 
            this.bt_gb_erase.Location = new System.Drawing.Point(121, 200);
            this.bt_gb_erase.Name = "bt_gb_erase";
            this.bt_gb_erase.Size = new System.Drawing.Size(105, 29);
            this.bt_gb_erase.TabIndex = 26;
            this.bt_gb_erase.Text = "Erase";
            this.bt_gb_erase.UseVisualStyleBackColor = true;
            this.bt_gb_erase.Click += new System.EventHandler(this.bt_gb_erase_Click);
            // 
            // txt_gb_erase_pwd
            // 
            this.txt_gb_erase_pwd.Location = new System.Drawing.Point(121, 154);
            this.txt_gb_erase_pwd.MaxLength = 8;
            this.txt_gb_erase_pwd.Name = "txt_gb_erase_pwd";
            this.txt_gb_erase_pwd.Size = new System.Drawing.Size(141, 21);
            this.txt_gb_erase_pwd.TabIndex = 23;
            this.txt_gb_erase_pwd.Text = "00000000";
            this.txt_gb_erase_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Location = new System.Drawing.Point(22, 157);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(89, 12);
            this.label159.TabIndex = 22;
            this.label159.Text = "Password(Hex):";
            // 
            // txt_gb_erase_num
            // 
            this.txt_gb_erase_num.Location = new System.Drawing.Point(121, 109);
            this.txt_gb_erase_num.MaxLength = 4;
            this.txt_gb_erase_num.Name = "txt_gb_erase_num";
            this.txt_gb_erase_num.Size = new System.Drawing.Size(141, 21);
            this.txt_gb_erase_num.TabIndex = 21;
            this.txt_gb_erase_num.Text = "2";
            this.txt_gb_erase_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Location = new System.Drawing.Point(52, 112);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(47, 12);
            this.label160.TabIndex = 20;
            this.label160.Text = "Length:";
            // 
            // txt_gb_erase_startaddr
            // 
            this.txt_gb_erase_startaddr.Location = new System.Drawing.Point(121, 68);
            this.txt_gb_erase_startaddr.MaxLength = 4;
            this.txt_gb_erase_startaddr.Name = "txt_gb_erase_startaddr";
            this.txt_gb_erase_startaddr.Size = new System.Drawing.Size(141, 21);
            this.txt_gb_erase_startaddr.TabIndex = 19;
            this.txt_gb_erase_startaddr.Text = "0";
            this.txt_gb_erase_startaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Location = new System.Drawing.Point(32, 72);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(65, 12);
            this.label161.TabIndex = 18;
            this.label161.Text = "StartAddr:";
            // 
            // cbb_gb_erasemem
            // 
            this.cbb_gb_erasemem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gb_erasemem.FormattingEnabled = true;
            this.cbb_gb_erasemem.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "SAFETY",
            "USER-0",
            "USER-1",
            "USER-2",
            "USER-3",
            "USER-4",
            "USER-5",
            "USER-6",
            "USER-7",
            "USER-8",
            "USER-9",
            "USER-10",
            "USER-11",
            "USER-12",
            "USER-13",
            "USER-14",
            "USER-15"});
            this.cbb_gb_erasemem.Location = new System.Drawing.Point(121, 31);
            this.cbb_gb_erasemem.Name = "cbb_gb_erasemem";
            this.cbb_gb_erasemem.Size = new System.Drawing.Size(141, 20);
            this.cbb_gb_erasemem.TabIndex = 17;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(54, 35);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(47, 12);
            this.label162.TabIndex = 16;
            this.label162.Text = "Memory:";
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.bt_gb_kill);
            this.tabPage14.Controls.Add(this.txt_gb_kill_pwd);
            this.tabPage14.Controls.Add(this.label163);
            this.tabPage14.Location = new System.Drawing.Point(4, 21);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(267, 410);
            this.tabPage14.TabIndex = 4;
            this.tabPage14.Text = "Kill";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // bt_gb_kill
            // 
            this.bt_gb_kill.Location = new System.Drawing.Point(131, 116);
            this.bt_gb_kill.Name = "bt_gb_kill";
            this.bt_gb_kill.Size = new System.Drawing.Size(105, 29);
            this.bt_gb_kill.TabIndex = 42;
            this.bt_gb_kill.Text = "Kill";
            this.bt_gb_kill.UseVisualStyleBackColor = true;
            this.bt_gb_kill.Click += new System.EventHandler(this.bt_gb_kill_Click);
            // 
            // txt_gb_kill_pwd
            // 
            this.txt_gb_kill_pwd.Location = new System.Drawing.Point(128, 66);
            this.txt_gb_kill_pwd.MaxLength = 8;
            this.txt_gb_kill_pwd.Name = "txt_gb_kill_pwd";
            this.txt_gb_kill_pwd.Size = new System.Drawing.Size(131, 21);
            this.txt_gb_kill_pwd.TabIndex = 40;
            this.txt_gb_kill_pwd.Text = "00000000";
            this.txt_gb_kill_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Location = new System.Drawing.Point(3, 70);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(119, 12);
            this.label163.TabIndex = 39;
            this.label163.Text = "Kill Password(Hex):";
            // 
            // groupBox46
            // 
            this.groupBox46.Controls.Add(this.txt_gb_maskdata);
            this.groupBox46.Controls.Add(this.label164);
            this.groupBox46.Controls.Add(this.txt_gb_mask_startaddr);
            this.groupBox46.Controls.Add(this.label165);
            this.groupBox46.Controls.Add(this.cbb_gb_masktype);
            this.groupBox46.Controls.Add(this.label166);
            this.groupBox46.Controls.Add(this.chk_gb_mask);
            this.groupBox46.Location = new System.Drawing.Point(666, 5);
            this.groupBox46.Name = "groupBox46";
            this.groupBox46.Size = new System.Drawing.Size(394, 71);
            this.groupBox46.TabIndex = 47;
            this.groupBox46.TabStop = false;
            this.groupBox46.Text = "Mask";
            // 
            // txt_gb_maskdata
            // 
            this.txt_gb_maskdata.Location = new System.Drawing.Point(156, 42);
            this.txt_gb_maskdata.MaxLength = 0;
            this.txt_gb_maskdata.Name = "txt_gb_maskdata";
            this.txt_gb_maskdata.Size = new System.Drawing.Size(232, 21);
            this.txt_gb_maskdata.TabIndex = 8;
            this.txt_gb_maskdata.Text = "0000";
            this.txt_gb_maskdata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(64, 46);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(65, 12);
            this.label164.TabIndex = 7;
            this.label164.Text = "Data(Hex):";
            // 
            // txt_gb_mask_startaddr
            // 
            this.txt_gb_mask_startaddr.Location = new System.Drawing.Point(338, 17);
            this.txt_gb_mask_startaddr.MaxLength = 4;
            this.txt_gb_mask_startaddr.Name = "txt_gb_mask_startaddr";
            this.txt_gb_mask_startaddr.Size = new System.Drawing.Size(50, 21);
            this.txt_gb_mask_startaddr.TabIndex = 6;
            this.txt_gb_mask_startaddr.Text = "0";
            this.txt_gb_mask_startaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(271, 21);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(65, 12);
            this.label165.TabIndex = 5;
            this.label165.Text = "StartAddr:";
            // 
            // cbb_gb_masktype
            // 
            this.cbb_gb_masktype.FormattingEnabled = true;
            this.cbb_gb_masktype.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "SAFETY",
            "USER-0",
            "USER-1",
            "USER-2",
            "USER-3",
            "USER-4",
            "USER-5",
            "USER-6",
            "USER-7",
            "USER-8",
            "USER-9",
            "USER-10",
            "USER-11",
            "USER-12",
            "USER-13",
            "USER-14",
            "USER-15"});
            this.cbb_gb_masktype.Location = new System.Drawing.Point(145, 17);
            this.cbb_gb_masktype.Name = "cbb_gb_masktype";
            this.cbb_gb_masktype.Size = new System.Drawing.Size(124, 20);
            this.cbb_gb_masktype.TabIndex = 4;
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Location = new System.Drawing.Point(84, 21);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(47, 12);
            this.label166.TabIndex = 3;
            this.label166.Text = "Memory:";
            // 
            // chk_gb_mask
            // 
            this.chk_gb_mask.AutoSize = true;
            this.chk_gb_mask.Location = new System.Drawing.Point(10, 19);
            this.chk_gb_mask.Name = "chk_gb_mask";
            this.chk_gb_mask.Size = new System.Drawing.Size(60, 16);
            this.chk_gb_mask.TabIndex = 0;
            this.chk_gb_mask.Text = "Enable";
            this.chk_gb_mask.UseVisualStyleBackColor = true;
            // 
            // lxLed_gb_number
            // 
            this.lxLed_gb_number.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_gb_number.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_gb_number.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_gb_number.BevelRate = 0.5F;
            this.lxLed_gb_number.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_gb_number.BorderWidth = 3;
            this.lxLed_gb_number.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_gb_number.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_gb_number.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_gb_number.HighlightOpaque = ((byte)(50));
            this.lxLed_gb_number.Location = new System.Drawing.Point(607, 519);
            this.lxLed_gb_number.Name = "lxLed_gb_number";
            this.lxLed_gb_number.RoundCorner = true;
            this.lxLed_gb_number.ShowHighlight = true;
            this.lxLed_gb_number.Size = new System.Drawing.Size(154, 41);
            this.lxLed_gb_number.TabIndex = 46;
            this.lxLed_gb_number.Text = "0";
            this.lxLed_gb_number.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_gb_number.TotalCharCount = 7;
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label167.Location = new System.Drawing.Point(512, 533);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(47, 12);
            this.label167.TabIndex = 45;
            this.label167.Text = "Number:";
            // 
            // lxLed_gb_time
            // 
            this.lxLed_gb_time.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_gb_time.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_gb_time.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_gb_time.BevelRate = 0.5F;
            this.lxLed_gb_time.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_gb_time.BorderWidth = 3;
            this.lxLed_gb_time.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_gb_time.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_gb_time.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_gb_time.HighlightOpaque = ((byte)(50));
            this.lxLed_gb_time.Location = new System.Drawing.Point(251, 519);
            this.lxLed_gb_time.Name = "lxLed_gb_time";
            this.lxLed_gb_time.RoundCorner = true;
            this.lxLed_gb_time.ShowHighlight = true;
            this.lxLed_gb_time.Size = new System.Drawing.Size(154, 40);
            this.lxLed_gb_time.TabIndex = 44;
            this.lxLed_gb_time.Text = "0";
            this.lxLed_gb_time.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_gb_time.TotalCharCount = 7;
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label168.Location = new System.Drawing.Point(128, 533);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(83, 12);
            this.label168.TabIndex = 43;
            this.label168.Text = "Run time(ms):";
            // 
            // groupBox54
            // 
            this.groupBox54.Controls.Add(this.dataGridView_GB);
            this.groupBox54.Location = new System.Drawing.Point(101, 80);
            this.groupBox54.Name = "groupBox54";
            this.groupBox54.Size = new System.Drawing.Size(687, 433);
            this.groupBox54.TabIndex = 42;
            this.groupBox54.TabStop = false;
            this.groupBox54.Text = "Tag List";
            // 
            // dataGridView_GB
            // 
            this.dataGridView_GB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_GB.AllowUserToAddRows = false;
            this.dataGridView_GB.AllowUserToDeleteRows = false;
            this.dataGridView_GB.AllowUserToResizeColumns = false;
            this.dataGridView_GB.AllowUserToResizeRows = false;
            this.dataGridView_GB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_GB.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_GB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_GB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GB.Location = new System.Drawing.Point(4, 15);
            this.dataGridView_GB.MultiSelect = false;
            this.dataGridView_GB.Name = "dataGridView_GB";
            this.dataGridView_GB.ReadOnly = true;
            this.dataGridView_GB.RowHeadersVisible = false;
            this.dataGridView_GB.RowTemplate.Height = 23;
            this.dataGridView_GB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_GB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_GB.Size = new System.Drawing.Size(678, 413);
            this.dataGridView_GB.TabIndex = 1;
            // 
            // gbp_gb_mix
            // 
            this.gbp_gb_mix.Controls.Add(this.tx_gb_readpsd);
            this.gbp_gb_mix.Controls.Add(this.label169);
            this.gbp_gb_mix.Controls.Add(this.tx_gb_masklen);
            this.gbp_gb_mix.Controls.Add(this.label170);
            this.gbp_gb_mix.Controls.Add(this.tx_gb_maskaddr);
            this.gbp_gb_mix.Controls.Add(this.label171);
            this.gbp_gb_mix.Controls.Add(this.cbb_gb_maskmem);
            this.gbp_gb_mix.Controls.Add(this.label172);
            this.gbp_gb_mix.Enabled = false;
            this.gbp_gb_mix.Location = new System.Drawing.Point(377, 4);
            this.gbp_gb_mix.Name = "gbp_gb_mix";
            this.gbp_gb_mix.Size = new System.Drawing.Size(287, 71);
            this.gbp_gb_mix.TabIndex = 41;
            this.gbp_gb_mix.TabStop = false;
            this.gbp_gb_mix.Text = "Mix ";
            // 
            // tx_gb_readpsd
            // 
            this.tx_gb_readpsd.Location = new System.Drawing.Point(95, 40);
            this.tx_gb_readpsd.MaxLength = 8;
            this.tx_gb_readpsd.Name = "tx_gb_readpsd";
            this.tx_gb_readpsd.Size = new System.Drawing.Size(98, 21);
            this.tx_gb_readpsd.TabIndex = 7;
            this.tx_gb_readpsd.Text = "00000000";
            this.tx_gb_readpsd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Location = new System.Drawing.Point(4, 46);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(89, 12);
            this.label169.TabIndex = 6;
            this.label169.Text = "Password(Hex):";
            // 
            // tx_gb_masklen
            // 
            this.tx_gb_masklen.Location = new System.Drawing.Point(239, 44);
            this.tx_gb_masklen.MaxLength = 3;
            this.tx_gb_masklen.Name = "tx_gb_masklen";
            this.tx_gb_masklen.Size = new System.Drawing.Size(41, 21);
            this.tx_gb_masklen.TabIndex = 5;
            this.tx_gb_masklen.Text = "4";
            this.tx_gb_masklen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Location = new System.Drawing.Point(199, 48);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(29, 12);
            this.label170.TabIndex = 4;
            this.label170.Text = "Len:";
            // 
            // tx_gb_maskaddr
            // 
            this.tx_gb_maskaddr.Location = new System.Drawing.Point(239, 13);
            this.tx_gb_maskaddr.MaxLength = 5;
            this.tx_gb_maskaddr.Name = "tx_gb_maskaddr";
            this.tx_gb_maskaddr.Size = new System.Drawing.Size(41, 21);
            this.tx_gb_maskaddr.TabIndex = 3;
            this.tx_gb_maskaddr.Text = "0";
            this.tx_gb_maskaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Location = new System.Drawing.Point(199, 17);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(35, 12);
            this.label171.TabIndex = 2;
            this.label171.Text = "Addr:";
            // 
            // cbb_gb_maskmem
            // 
            this.cbb_gb_maskmem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gb_maskmem.FormattingEnabled = true;
            this.cbb_gb_maskmem.Items.AddRange(new object[] {
            "TID",
            "EPC",
            "SAFETY",
            "USER-0",
            "USER-1",
            "USER-2",
            "USER-3",
            "USER-4",
            "USER-5",
            "USER-6",
            "USER-7",
            "USER-8",
            "USER-9",
            "USER-10",
            "USER-11",
            "USER-12",
            "USER-13",
            "USER-14",
            "USER-15"});
            this.cbb_gb_maskmem.Location = new System.Drawing.Point(64, 12);
            this.cbb_gb_maskmem.Name = "cbb_gb_maskmem";
            this.cbb_gb_maskmem.Size = new System.Drawing.Size(129, 20);
            this.cbb_gb_maskmem.TabIndex = 1;
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Location = new System.Drawing.Point(5, 16);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(47, 12);
            this.label172.TabIndex = 0;
            this.label172.Text = "Memory:";
            // 
            // gbp_gb_ant
            // 
            this.gbp_gb_ant.Controls.Add(this.chk_gbant16);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant15);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant14);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant13);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant12);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant11);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant10);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant9);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant8);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant7);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant6);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant5);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant4);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant3);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant2);
            this.gbp_gb_ant.Controls.Add(this.chk_gbant1);
            this.gbp_gb_ant.Location = new System.Drawing.Point(8, 80);
            this.gbp_gb_ant.Name = "gbp_gb_ant";
            this.gbp_gb_ant.Size = new System.Drawing.Size(89, 430);
            this.gbp_gb_ant.TabIndex = 40;
            this.gbp_gb_ant.TabStop = false;
            this.gbp_gb_ant.Text = "Antenna";
            // 
            // chk_gbant16
            // 
            this.chk_gbant16.AutoSize = true;
            this.chk_gbant16.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant16.Location = new System.Drawing.Point(14, 328);
            this.chk_gbant16.Name = "chk_gbant16";
            this.chk_gbant16.Size = new System.Drawing.Size(54, 16);
            this.chk_gbant16.TabIndex = 61;
            this.chk_gbant16.Text = "ANT16";
            this.chk_gbant16.UseVisualStyleBackColor = true;
            // 
            // chk_gbant15
            // 
            this.chk_gbant15.AutoSize = true;
            this.chk_gbant15.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant15.Location = new System.Drawing.Point(14, 307);
            this.chk_gbant15.Name = "chk_gbant15";
            this.chk_gbant15.Size = new System.Drawing.Size(54, 16);
            this.chk_gbant15.TabIndex = 60;
            this.chk_gbant15.Text = "ANT15";
            this.chk_gbant15.UseVisualStyleBackColor = true;
            // 
            // chk_gbant14
            // 
            this.chk_gbant14.AutoSize = true;
            this.chk_gbant14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant14.Location = new System.Drawing.Point(14, 287);
            this.chk_gbant14.Name = "chk_gbant14";
            this.chk_gbant14.Size = new System.Drawing.Size(54, 16);
            this.chk_gbant14.TabIndex = 59;
            this.chk_gbant14.Text = "ANT14";
            this.chk_gbant14.UseVisualStyleBackColor = true;
            // 
            // chk_gbant13
            // 
            this.chk_gbant13.AutoSize = true;
            this.chk_gbant13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant13.Location = new System.Drawing.Point(14, 267);
            this.chk_gbant13.Name = "chk_gbant13";
            this.chk_gbant13.Size = new System.Drawing.Size(54, 16);
            this.chk_gbant13.TabIndex = 58;
            this.chk_gbant13.Text = "ANT13";
            this.chk_gbant13.UseVisualStyleBackColor = true;
            // 
            // chk_gbant12
            // 
            this.chk_gbant12.AutoSize = true;
            this.chk_gbant12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant12.Location = new System.Drawing.Point(14, 246);
            this.chk_gbant12.Name = "chk_gbant12";
            this.chk_gbant12.Size = new System.Drawing.Size(54, 16);
            this.chk_gbant12.TabIndex = 57;
            this.chk_gbant12.Text = "ANT12";
            this.chk_gbant12.UseVisualStyleBackColor = true;
            // 
            // chk_gbant11
            // 
            this.chk_gbant11.AutoSize = true;
            this.chk_gbant11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant11.Location = new System.Drawing.Point(14, 226);
            this.chk_gbant11.Name = "chk_gbant11";
            this.chk_gbant11.Size = new System.Drawing.Size(54, 16);
            this.chk_gbant11.TabIndex = 56;
            this.chk_gbant11.Text = "ANT11";
            this.chk_gbant11.UseVisualStyleBackColor = true;
            // 
            // chk_gbant10
            // 
            this.chk_gbant10.AutoSize = true;
            this.chk_gbant10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant10.Location = new System.Drawing.Point(14, 204);
            this.chk_gbant10.Name = "chk_gbant10";
            this.chk_gbant10.Size = new System.Drawing.Size(54, 16);
            this.chk_gbant10.TabIndex = 55;
            this.chk_gbant10.Text = "ANT10";
            this.chk_gbant10.UseVisualStyleBackColor = true;
            // 
            // chk_gbant9
            // 
            this.chk_gbant9.AutoSize = true;
            this.chk_gbant9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant9.Location = new System.Drawing.Point(14, 184);
            this.chk_gbant9.Name = "chk_gbant9";
            this.chk_gbant9.Size = new System.Drawing.Size(48, 16);
            this.chk_gbant9.TabIndex = 54;
            this.chk_gbant9.Text = "ANT9";
            this.chk_gbant9.UseVisualStyleBackColor = true;
            // 
            // chk_gbant8
            // 
            this.chk_gbant8.AutoSize = true;
            this.chk_gbant8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant8.Location = new System.Drawing.Point(14, 164);
            this.chk_gbant8.Name = "chk_gbant8";
            this.chk_gbant8.Size = new System.Drawing.Size(48, 16);
            this.chk_gbant8.TabIndex = 53;
            this.chk_gbant8.Text = "ANT8";
            this.chk_gbant8.UseVisualStyleBackColor = true;
            // 
            // chk_gbant7
            // 
            this.chk_gbant7.AutoSize = true;
            this.chk_gbant7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant7.Location = new System.Drawing.Point(14, 143);
            this.chk_gbant7.Name = "chk_gbant7";
            this.chk_gbant7.Size = new System.Drawing.Size(48, 16);
            this.chk_gbant7.TabIndex = 52;
            this.chk_gbant7.Text = "ANT7";
            this.chk_gbant7.UseVisualStyleBackColor = true;
            // 
            // chk_gbant6
            // 
            this.chk_gbant6.AutoSize = true;
            this.chk_gbant6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant6.Location = new System.Drawing.Point(14, 123);
            this.chk_gbant6.Name = "chk_gbant6";
            this.chk_gbant6.Size = new System.Drawing.Size(48, 16);
            this.chk_gbant6.TabIndex = 51;
            this.chk_gbant6.Text = "ANT6";
            this.chk_gbant6.UseVisualStyleBackColor = true;
            // 
            // chk_gbant5
            // 
            this.chk_gbant5.AutoSize = true;
            this.chk_gbant5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant5.Location = new System.Drawing.Point(14, 103);
            this.chk_gbant5.Name = "chk_gbant5";
            this.chk_gbant5.Size = new System.Drawing.Size(48, 16);
            this.chk_gbant5.TabIndex = 50;
            this.chk_gbant5.Text = "ANT5";
            this.chk_gbant5.UseVisualStyleBackColor = true;
            // 
            // chk_gbant4
            // 
            this.chk_gbant4.AutoSize = true;
            this.chk_gbant4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant4.Location = new System.Drawing.Point(14, 82);
            this.chk_gbant4.Name = "chk_gbant4";
            this.chk_gbant4.Size = new System.Drawing.Size(48, 16);
            this.chk_gbant4.TabIndex = 37;
            this.chk_gbant4.Text = "ANT4";
            this.chk_gbant4.UseVisualStyleBackColor = true;
            // 
            // chk_gbant3
            // 
            this.chk_gbant3.AutoSize = true;
            this.chk_gbant3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant3.Location = new System.Drawing.Point(14, 61);
            this.chk_gbant3.Name = "chk_gbant3";
            this.chk_gbant3.Size = new System.Drawing.Size(48, 16);
            this.chk_gbant3.TabIndex = 36;
            this.chk_gbant3.Text = "ANT3";
            this.chk_gbant3.UseVisualStyleBackColor = true;
            // 
            // chk_gbant2
            // 
            this.chk_gbant2.AutoSize = true;
            this.chk_gbant2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant2.Location = new System.Drawing.Point(14, 40);
            this.chk_gbant2.Name = "chk_gbant2";
            this.chk_gbant2.Size = new System.Drawing.Size(48, 16);
            this.chk_gbant2.TabIndex = 35;
            this.chk_gbant2.Text = "ANT2";
            this.chk_gbant2.UseVisualStyleBackColor = true;
            // 
            // chk_gbant1
            // 
            this.chk_gbant1.AutoSize = true;
            this.chk_gbant1.Checked = true;
            this.chk_gbant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_gbant1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_gbant1.Location = new System.Drawing.Point(14, 21);
            this.chk_gbant1.Name = "chk_gbant1";
            this.chk_gbant1.Size = new System.Drawing.Size(48, 16);
            this.chk_gbant1.TabIndex = 34;
            this.chk_gbant1.Text = "ANT1";
            this.chk_gbant1.UseVisualStyleBackColor = true;
            // 
            // groupBox55
            // 
            this.groupBox55.Controls.Add(this.cbb_gb_scantime);
            this.groupBox55.Controls.Add(this.label173);
            this.groupBox55.Controls.Add(this.rb_gb_normal);
            this.groupBox55.Controls.Add(this.rb_gb_mix);
            this.groupBox55.Controls.Add(this.btInventoryGB);
            this.groupBox55.Location = new System.Drawing.Point(10, 5);
            this.groupBox55.Name = "groupBox55";
            this.groupBox55.Size = new System.Drawing.Size(365, 71);
            this.groupBox55.TabIndex = 39;
            this.groupBox55.TabStop = false;
            // 
            // cbb_gb_scantime
            // 
            this.cbb_gb_scantime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gb_scantime.FormattingEnabled = true;
            this.cbb_gb_scantime.Location = new System.Drawing.Point(261, 41);
            this.cbb_gb_scantime.Name = "cbb_gb_scantime";
            this.cbb_gb_scantime.Size = new System.Drawing.Size(101, 20);
            this.cbb_gb_scantime.TabIndex = 33;
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Location = new System.Drawing.Point(261, 24);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(59, 12);
            this.label173.TabIndex = 32;
            this.label173.Text = "ScanTime:";
            // 
            // rb_gb_normal
            // 
            this.rb_gb_normal.AutoSize = true;
            this.rb_gb_normal.Checked = true;
            this.rb_gb_normal.Location = new System.Drawing.Point(151, 22);
            this.rb_gb_normal.Name = "rb_gb_normal";
            this.rb_gb_normal.Size = new System.Drawing.Size(59, 16);
            this.rb_gb_normal.TabIndex = 4;
            this.rb_gb_normal.TabStop = true;
            this.rb_gb_normal.Text = "Normal";
            this.rb_gb_normal.UseVisualStyleBackColor = true;
            this.rb_gb_normal.CheckedChanged += new System.EventHandler(this.rb_gb_normal_CheckedChanged);
            // 
            // rb_gb_mix
            // 
            this.rb_gb_mix.AutoSize = true;
            this.rb_gb_mix.Location = new System.Drawing.Point(151, 43);
            this.rb_gb_mix.Name = "rb_gb_mix";
            this.rb_gb_mix.Size = new System.Drawing.Size(41, 16);
            this.rb_gb_mix.TabIndex = 3;
            this.rb_gb_mix.Text = "Mix";
            this.rb_gb_mix.UseVisualStyleBackColor = true;
            this.rb_gb_mix.CheckedChanged += new System.EventHandler(this.rb_gb_mix_CheckedChanged);
            // 
            // btInventoryGB
            // 
            this.btInventoryGB.BackColor = System.Drawing.Color.Transparent;
            this.btInventoryGB.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInventoryGB.ForeColor = System.Drawing.Color.DarkBlue;
            this.btInventoryGB.Location = new System.Drawing.Point(6, 20);
            this.btInventoryGB.Name = "btInventoryGB";
            this.btInventoryGB.Size = new System.Drawing.Size(109, 40);
            this.btInventoryGB.TabIndex = 0;
            this.btInventoryGB.Text = "Start";
            this.btInventoryGB.UseVisualStyleBackColor = false;
            this.btInventoryGB.Click += new System.EventHandler(this.btInventoryGB_Click);
            // 
            // Main_Page3
            // 
            this.Main_Page3.Controls.Add(this.panel5);
            this.Main_Page3.Location = new System.Drawing.Point(4, 27);
            this.Main_Page3.Name = "Main_Page3";
            this.Main_Page3.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page3.Size = new System.Drawing.Size(1075, 571);
            this.Main_Page3.TabIndex = 2;
            this.Main_Page3.Text = "18000-6B";
            this.Main_Page3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox23);
            this.panel5.Controls.Add(this.groupBox22);
            this.panel5.Controls.Add(this.text_6BUID);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.ListView_ID_6B);
            this.panel5.Controls.Add(this.groupBox19);
            this.panel5.Location = new System.Drawing.Point(-1, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1069, 569);
            this.panel5.TabIndex = 0;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.text_Statu6B);
            this.groupBox23.Controls.Add(this.btCheckLock6B);
            this.groupBox23.Controls.Add(this.btLock6B);
            this.groupBox23.Controls.Add(this.text_checkaddr);
            this.groupBox23.Controls.Add(this.label52);
            this.groupBox23.Controls.Add(this.text_lock6b);
            this.groupBox23.Controls.Add(this.label51);
            this.groupBox23.Location = new System.Drawing.Point(561, 429);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(495, 110);
            this.groupBox23.TabIndex = 21;
            this.groupBox23.TabStop = false;
            // 
            // text_Statu6B
            // 
            this.text_Statu6B.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_Statu6B.ForeColor = System.Drawing.Color.Red;
            this.text_Statu6B.Location = new System.Drawing.Point(252, 75);
            this.text_Statu6B.MaxLength = 2;
            this.text_Statu6B.Name = "text_Statu6B";
            this.text_Statu6B.ReadOnly = true;
            this.text_Statu6B.Size = new System.Drawing.Size(111, 21);
            this.text_Statu6B.TabIndex = 19;
            // 
            // btCheckLock6B
            // 
            this.btCheckLock6B.Location = new System.Drawing.Point(383, 66);
            this.btCheckLock6B.Name = "btCheckLock6B";
            this.btCheckLock6B.Size = new System.Drawing.Size(100, 30);
            this.btCheckLock6B.TabIndex = 18;
            this.btCheckLock6B.Text = "Check lock";
            this.btCheckLock6B.UseVisualStyleBackColor = true;
            this.btCheckLock6B.Click += new System.EventHandler(this.btCheckLock6B_Click);
            // 
            // btLock6B
            // 
            this.btLock6B.Location = new System.Drawing.Point(383, 20);
            this.btLock6B.Name = "btLock6B";
            this.btLock6B.Size = new System.Drawing.Size(100, 30);
            this.btLock6B.TabIndex = 17;
            this.btLock6B.Text = "Lock";
            this.btLock6B.UseVisualStyleBackColor = true;
            this.btLock6B.Click += new System.EventHandler(this.btLock6B_Click);
            // 
            // text_checkaddr
            // 
            this.text_checkaddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_checkaddr.Location = new System.Drawing.Point(202, 75);
            this.text_checkaddr.MaxLength = 2;
            this.text_checkaddr.Name = "text_checkaddr";
            this.text_checkaddr.Size = new System.Drawing.Size(44, 21);
            this.text_checkaddr.TabIndex = 16;
            this.text_checkaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(47, 78);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(149, 12);
            this.label52.TabIndex = 15;
            this.label52.Text = "Check lock address(Hex):";
            // 
            // text_lock6b
            // 
            this.text_lock6b.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_lock6b.Location = new System.Drawing.Point(202, 29);
            this.text_lock6b.MaxLength = 2;
            this.text_lock6b.Name = "text_lock6b";
            this.text_lock6b.Size = new System.Drawing.Size(44, 21);
            this.text_lock6b.TabIndex = 14;
            this.text_lock6b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(71, 32);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(113, 12);
            this.label51.TabIndex = 0;
            this.label51.Text = "Lock address(Hex):";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.text_W6B);
            this.groupBox22.Controls.Add(this.label48);
            this.groupBox22.Controls.Add(this.btWrite6B);
            this.groupBox22.Controls.Add(this.text_W6BLen);
            this.groupBox22.Controls.Add(this.label49);
            this.groupBox22.Controls.Add(this.text_W6BAddr);
            this.groupBox22.Controls.Add(this.label50);
            this.groupBox22.Controls.Add(this.text_R6B);
            this.groupBox22.Controls.Add(this.label36);
            this.groupBox22.Controls.Add(this.btRead6B);
            this.groupBox22.Controls.Add(this.text_R6BLen);
            this.groupBox22.Controls.Add(this.label35);
            this.groupBox22.Controls.Add(this.text_R6BAddr);
            this.groupBox22.Controls.Add(this.label30);
            this.groupBox22.Location = new System.Drawing.Point(563, 70);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(495, 359);
            this.groupBox22.TabIndex = 20;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Read/Write Data";
            // 
            // text_W6B
            // 
            this.text_W6B.Location = new System.Drawing.Point(122, 234);
            this.text_W6B.Multiline = true;
            this.text_W6B.Name = "text_W6B";
            this.text_W6B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_W6B.Size = new System.Drawing.Size(359, 118);
            this.text_W6B.TabIndex = 18;
            this.text_W6B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(18, 234);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(101, 12);
            this.label48.TabIndex = 17;
            this.label48.Text = "Content(Hex):   ";
            // 
            // btWrite6B
            // 
            this.btWrite6B.Location = new System.Drawing.Point(381, 194);
            this.btWrite6B.Name = "btWrite6B";
            this.btWrite6B.Size = new System.Drawing.Size(100, 30);
            this.btWrite6B.TabIndex = 16;
            this.btWrite6B.Text = "Write Data";
            this.btWrite6B.UseVisualStyleBackColor = true;
            this.btWrite6B.Click += new System.EventHandler(this.btWrite6B_Click);
            // 
            // text_W6BLen
            // 
            this.text_W6BLen.Location = new System.Drawing.Point(294, 199);
            this.text_W6BLen.MaxLength = 2;
            this.text_W6BLen.Name = "text_W6BLen";
            this.text_W6BLen.Size = new System.Drawing.Size(44, 21);
            this.text_W6BLen.TabIndex = 15;
            this.text_W6BLen.TextChanged += new System.EventHandler(this.text_W6BLen_TextChanged);
            this.text_W6BLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(193, 203);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(77, 12);
            this.label49.TabIndex = 14;
            this.label49.Text = "Length(Hex):";
            // 
            // text_W6BAddr
            // 
            this.text_W6BAddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_W6BAddr.Location = new System.Drawing.Point(124, 199);
            this.text_W6BAddr.MaxLength = 2;
            this.text_W6BAddr.Name = "text_W6BAddr";
            this.text_W6BAddr.Size = new System.Drawing.Size(44, 21);
            this.text_W6BAddr.TabIndex = 13;
            this.text_W6BAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(18, 203);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(113, 12);
            this.label50.TabIndex = 12;
            this.label50.Text = "StartAddr(Hex):   ";
            // 
            // text_R6B
            // 
            this.text_R6B.Location = new System.Drawing.Point(122, 62);
            this.text_R6B.Multiline = true;
            this.text_R6B.Name = "text_R6B";
            this.text_R6B.ReadOnly = true;
            this.text_R6B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_R6B.Size = new System.Drawing.Size(359, 118);
            this.text_R6B.TabIndex = 11;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(18, 62);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(101, 12);
            this.label36.TabIndex = 10;
            this.label36.Text = "Content(Hex):   ";
            // 
            // btRead6B
            // 
            this.btRead6B.Location = new System.Drawing.Point(381, 20);
            this.btRead6B.Name = "btRead6B";
            this.btRead6B.Size = new System.Drawing.Size(100, 30);
            this.btRead6B.TabIndex = 9;
            this.btRead6B.Text = "Read Data";
            this.btRead6B.UseVisualStyleBackColor = true;
            this.btRead6B.Click += new System.EventHandler(this.btRead6B_Click);
            // 
            // text_R6BLen
            // 
            this.text_R6BLen.Location = new System.Drawing.Point(294, 25);
            this.text_R6BLen.MaxLength = 2;
            this.text_R6BLen.Name = "text_R6BLen";
            this.text_R6BLen.Size = new System.Drawing.Size(44, 21);
            this.text_R6BLen.TabIndex = 8;
            this.text_R6BLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(193, 29);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(77, 12);
            this.label35.TabIndex = 7;
            this.label35.Text = "Length(Hex):";
            // 
            // text_R6BAddr
            // 
            this.text_R6BAddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_R6BAddr.Location = new System.Drawing.Point(124, 25);
            this.text_R6BAddr.MaxLength = 2;
            this.text_R6BAddr.Name = "text_R6BAddr";
            this.text_R6BAddr.Size = new System.Drawing.Size(44, 21);
            this.text_R6BAddr.TabIndex = 6;
            this.text_R6BAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 29);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(113, 12);
            this.label30.TabIndex = 5;
            this.label30.Text = "StartAddr(Hex):   ";
            // 
            // text_6BUID
            // 
            this.text_6BUID.Location = new System.Drawing.Point(685, 39);
            this.text_6BUID.Name = "text_6BUID";
            this.text_6BUID.ReadOnly = true;
            this.text_6BUID.Size = new System.Drawing.Size(214, 21);
            this.text_6BUID.TabIndex = 19;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(590, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 12);
            this.label29.TabIndex = 18;
            this.label29.Text = "Selected UID:";
            // 
            // ListView_ID_6B
            // 
            this.ListView_ID_6B.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_ID_6B.AllowDrop = true;
            this.ListView_ID_6B.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView_ID_6B.FullRowSelect = true;
            this.ListView_ID_6B.GridLines = true;
            this.ListView_ID_6B.HotTracking = true;
            this.ListView_ID_6B.HoverSelection = true;
            this.ListView_ID_6B.Location = new System.Drawing.Point(10, 82);
            this.ListView_ID_6B.Name = "ListView_ID_6B";
            this.ListView_ID_6B.Size = new System.Drawing.Size(524, 482);
            this.ListView_ID_6B.TabIndex = 17;
            this.ListView_ID_6B.UseCompatibleStateImageBehavior = false;
            this.ListView_ID_6B.View = System.Windows.Forms.View.Details;
            this.ListView_ID_6B.DoubleClick += new System.EventHandler(this.ListView_ID_6B_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No.";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 230;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Antenna";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Times";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RSSI";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.rb_mutiple);
            this.groupBox19.Controls.Add(this.rb_single);
            this.groupBox19.Controls.Add(this.btInventory6B);
            this.groupBox19.Location = new System.Drawing.Point(10, 5);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(524, 71);
            this.groupBox19.TabIndex = 16;
            this.groupBox19.TabStop = false;
            // 
            // rb_mutiple
            // 
            this.rb_mutiple.AutoSize = true;
            this.rb_mutiple.Location = new System.Drawing.Point(377, 35);
            this.rb_mutiple.Name = "rb_mutiple";
            this.rb_mutiple.Size = new System.Drawing.Size(65, 16);
            this.rb_mutiple.TabIndex = 2;
            this.rb_mutiple.Text = "Mutiple";
            this.rb_mutiple.UseVisualStyleBackColor = true;
            // 
            // rb_single
            // 
            this.rb_single.AutoSize = true;
            this.rb_single.Checked = true;
            this.rb_single.Location = new System.Drawing.Point(246, 35);
            this.rb_single.Name = "rb_single";
            this.rb_single.Size = new System.Drawing.Size(59, 16);
            this.rb_single.TabIndex = 1;
            this.rb_single.TabStop = true;
            this.rb_single.Text = "Single";
            this.rb_single.UseVisualStyleBackColor = true;
            // 
            // btInventory6B
            // 
            this.btInventory6B.BackColor = System.Drawing.Color.Transparent;
            this.btInventory6B.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInventory6B.ForeColor = System.Drawing.Color.DarkBlue;
            this.btInventory6B.Location = new System.Drawing.Point(18, 20);
            this.btInventory6B.Name = "btInventory6B";
            this.btInventory6B.Size = new System.Drawing.Size(171, 40);
            this.btInventory6B.TabIndex = 0;
            this.btInventory6B.Text = "Start";
            this.btInventory6B.UseVisualStyleBackColor = false;
            this.btInventory6B.Click += new System.EventHandler(this.btInventory6B_Click);
            // 
            // Main_Page4
            // 
            this.Main_Page4.Controls.Add(this.tabControl3);
            this.Main_Page4.Location = new System.Drawing.Point(4, 27);
            this.Main_Page4.Name = "Main_Page4";
            this.Main_Page4.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page4.Size = new System.Drawing.Size(1075, 571);
            this.Main_Page4.TabIndex = 3;
            this.Main_Page4.Text = "Network module config";
            this.Main_Page4.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.ItemSize = new System.Drawing.Size(60, 23);
            this.tabControl3.Location = new System.Drawing.Point(-1, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1072, 561);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DeviceListView);
            this.tabPage6.Controls.Add(this.menuStrip);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1064, 530);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "   TCP config       ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DeviceListView
            // 
            this.DeviceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deviceName,
            this.deviceIP,
            this.deviceMac});
            this.DeviceListView.FullRowSelect = true;
            this.DeviceListView.Location = new System.Drawing.Point(8, 30);
            this.DeviceListView.Name = "DeviceListView";
            this.DeviceListView.Size = new System.Drawing.Size(1050, 497);
            this.DeviceListView.TabIndex = 5;
            this.DeviceListView.UseCompatibleStateImageBehavior = false;
            this.DeviceListView.View = System.Windows.Forms.View.Details;
            this.DeviceListView.DoubleClick += new System.EventHandler(this.DeviceListView_DoubleClick);
            // 
            // deviceName
            // 
            this.deviceName.Text = "Name";
            this.deviceName.Width = 220;
            // 
            // deviceIP
            // 
            this.deviceIP.Text = "IP Addr";
            this.deviceIP.Width = 280;
            // 
            // deviceMac
            // 
            this.deviceMac.Text = "Mac Addr";
            this.deviceMac.Width = 245;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(3, 3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.configToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "&Operation";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.configToolStripMenuItem.Text = "&Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(103, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iEToolStripMenuItem,
            this.telnetToolStripMenuItem,
            this.pingToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItem2.Text = "&Tool";
            // 
            // iEToolStripMenuItem
            // 
            this.iEToolStripMenuItem.Name = "iEToolStripMenuItem";
            this.iEToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.iEToolStripMenuItem.Text = "&IE";
            this.iEToolStripMenuItem.Click += new System.EventHandler(this.iEToolStripMenuItem_Click);
            // 
            // telnetToolStripMenuItem
            // 
            this.telnetToolStripMenuItem.Name = "telnetToolStripMenuItem";
            this.telnetToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.telnetToolStripMenuItem.Text = "&Telnet";
            this.telnetToolStripMenuItem.Click += new System.EventHandler(this.telnetToolStripMenuItem_Click);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.pingToolStripMenuItem.Text = "&Ping";
            this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.englishToolStripMenuItem.Text = "&English";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.panel6);
            this.tabPage7.Location = new System.Drawing.Point(4, 27);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1064, 530);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "   Serialport Config   ";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btSave);
            this.panel6.Controls.Add(this.btLoadDefault);
            this.panel6.Controls.Add(this.groupBox51);
            this.panel6.Controls.Add(this.groupBox50);
            this.panel6.Controls.Add(this.groupBox49);
            this.panel6.Controls.Add(this.groupBox47);
            this.panel6.Location = new System.Drawing.Point(-2, -8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1069, 564);
            this.panel6.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(755, 477);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 23);
            this.btSave.TabIndex = 71;
            this.btSave.Text = "Save and reboot";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoadDefault
            // 
            this.btLoadDefault.Location = new System.Drawing.Point(754, 438);
            this.btLoadDefault.Name = "btLoadDefault";
            this.btLoadDefault.Size = new System.Drawing.Size(109, 23);
            this.btLoadDefault.TabIndex = 70;
            this.btLoadDefault.Text = "Load default value";
            this.btLoadDefault.UseVisualStyleBackColor = true;
            this.btLoadDefault.Click += new System.EventHandler(this.btLoadDefault_Click);
            // 
            // groupBox51
            // 
            this.groupBox51.Controls.Add(this.btGetNet);
            this.groupBox51.Controls.Add(this.btSetNet);
            this.groupBox51.Controls.Add(this.label110);
            this.groupBox51.Controls.Add(this.macTB);
            this.groupBox51.Controls.Add(this.panel_StaticIp);
            this.groupBox51.Location = new System.Drawing.Point(191, 298);
            this.groupBox51.Name = "groupBox51";
            this.groupBox51.Size = new System.Drawing.Size(554, 204);
            this.groupBox51.TabIndex = 69;
            this.groupBox51.TabStop = false;
            this.groupBox51.Text = "Net work setting";
            // 
            // btGetNet
            // 
            this.btGetNet.Location = new System.Drawing.Point(456, 131);
            this.btGetNet.Name = "btGetNet";
            this.btGetNet.Size = new System.Drawing.Size(90, 23);
            this.btGetNet.TabIndex = 119;
            this.btGetNet.Text = "Get";
            this.btGetNet.UseVisualStyleBackColor = true;
            this.btGetNet.Click += new System.EventHandler(this.btGetNet_Click);
            // 
            // btSetNet
            // 
            this.btSetNet.Location = new System.Drawing.Point(456, 170);
            this.btSetNet.Name = "btSetNet";
            this.btSetNet.Size = new System.Drawing.Size(90, 23);
            this.btSetNet.TabIndex = 118;
            this.btSetNet.Text = "Set";
            this.btSetNet.UseVisualStyleBackColor = true;
            this.btSetNet.Click += new System.EventHandler(this.btSetNet_Click);
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(222, 26);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(71, 12);
            this.label110.TabIndex = 61;
            this.label110.Text = "Mac Address";
            // 
            // macTB
            // 
            this.macTB.AccessibleName = "MacAddress";
            this.macTB.Location = new System.Drawing.Point(224, 42);
            this.macTB.Name = "macTB";
            this.macTB.ReadOnly = true;
            this.macTB.Size = new System.Drawing.Size(176, 21);
            this.macTB.TabIndex = 58;
            // 
            // panel_StaticIp
            // 
            this.panel_StaticIp.Controls.Add(this.label109);
            this.panel_StaticIp.Controls.Add(this.label108);
            this.panel_StaticIp.Controls.Add(this.label107);
            this.panel_StaticIp.Controls.Add(this.label106);
            this.panel_StaticIp.Controls.Add(this.label105);
            this.panel_StaticIp.Controls.Add(this.altDNSTB);
            this.panel_StaticIp.Controls.Add(this.pDNSTB);
            this.panel_StaticIp.Controls.Add(this.gatewayTB);
            this.panel_StaticIp.Controls.Add(this.subnetTB);
            this.panel_StaticIp.Controls.Add(this.ipTB);
            this.panel_StaticIp.Location = new System.Drawing.Point(12, 20);
            this.panel_StaticIp.Name = "panel_StaticIp";
            this.panel_StaticIp.Size = new System.Drawing.Size(179, 173);
            this.panel_StaticIp.TabIndex = 56;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(3, 128);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(125, 12);
            this.label109.TabIndex = 50;
            this.label109.Text = "Alternate DNS Server";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(3, 86);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(125, 12);
            this.label108.TabIndex = 49;
            this.label108.Text = "Preferred DNS Server";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(3, 60);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(47, 12);
            this.label107.TabIndex = 48;
            this.label107.Text = "Gateway";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(3, 33);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(41, 12);
            this.label106.TabIndex = 47;
            this.label106.Text = "Subnet";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(3, 6);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(65, 12);
            this.label105.TabIndex = 46;
            this.label105.Text = "IP Address";
            // 
            // altDNSTB
            // 
            this.altDNSTB.AccessibleName = "AlternateDNS";
            this.altDNSTB.Location = new System.Drawing.Point(79, 143);
            this.altDNSTB.Name = "altDNSTB";
            this.altDNSTB.Size = new System.Drawing.Size(97, 21);
            this.altDNSTB.TabIndex = 43;
            // 
            // pDNSTB
            // 
            this.pDNSTB.AccessibleName = "PreferredDNS";
            this.pDNSTB.Location = new System.Drawing.Point(79, 101);
            this.pDNSTB.Name = "pDNSTB";
            this.pDNSTB.Size = new System.Drawing.Size(97, 21);
            this.pDNSTB.TabIndex = 42;
            // 
            // gatewayTB
            // 
            this.gatewayTB.AccessibleName = "Gateway";
            this.gatewayTB.Location = new System.Drawing.Point(79, 57);
            this.gatewayTB.Name = "gatewayTB";
            this.gatewayTB.Size = new System.Drawing.Size(97, 21);
            this.gatewayTB.TabIndex = 41;
            // 
            // subnetTB
            // 
            this.subnetTB.AccessibleName = "Subnet";
            this.subnetTB.Location = new System.Drawing.Point(79, 30);
            this.subnetTB.Name = "subnetTB";
            this.subnetTB.Size = new System.Drawing.Size(97, 21);
            this.subnetTB.TabIndex = 40;
            // 
            // ipTB
            // 
            this.ipTB.AccessibleName = "IpAddress";
            this.ipTB.Location = new System.Drawing.Point(79, 3);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(97, 21);
            this.ipTB.TabIndex = 39;
            // 
            // groupBox50
            // 
            this.groupBox50.Controls.Add(this.btGetCnt);
            this.groupBox50.Controls.Add(this.btSetCnt);
            this.groupBox50.Controls.Add(this.panel_TCP);
            this.groupBox50.Location = new System.Drawing.Point(191, 143);
            this.groupBox50.Name = "groupBox50";
            this.groupBox50.Size = new System.Drawing.Size(554, 151);
            this.groupBox50.TabIndex = 68;
            this.groupBox50.TabStop = false;
            this.groupBox50.Text = "Connection setting";
            // 
            // btGetCnt
            // 
            this.btGetCnt.Location = new System.Drawing.Point(456, 78);
            this.btGetCnt.Name = "btGetCnt";
            this.btGetCnt.Size = new System.Drawing.Size(90, 23);
            this.btGetCnt.TabIndex = 119;
            this.btGetCnt.Text = "Get";
            this.btGetCnt.UseVisualStyleBackColor = true;
            this.btGetCnt.Click += new System.EventHandler(this.btGetCnt_Click);
            // 
            // btSetCnt
            // 
            this.btSetCnt.Location = new System.Drawing.Point(456, 114);
            this.btSetCnt.Name = "btSetCnt";
            this.btSetCnt.Size = new System.Drawing.Size(90, 23);
            this.btSetCnt.TabIndex = 118;
            this.btSetCnt.Text = "Set";
            this.btSetCnt.UseVisualStyleBackColor = true;
            this.btSetCnt.Click += new System.EventHandler(this.btSetCnt_Click);
            // 
            // panel_TCP
            // 
            this.panel_TCP.Controls.Add(this.label87);
            this.panel_TCP.Controls.Add(this.label88);
            this.panel_TCP.Controls.Add(this.label89);
            this.panel_TCP.Controls.Add(this.label90);
            this.panel_TCP.Controls.Add(this.label93);
            this.panel_TCP.Controls.Add(this.workasCB);
            this.panel_TCP.Controls.Add(this.tcpRomteHostTB);
            this.panel_TCP.Controls.Add(this.tcpRemotePortNUD);
            this.panel_TCP.Controls.Add(this.tcpLocalPortNUD);
            this.panel_TCP.Controls.Add(this.tcpActiveCB);
            this.panel_TCP.Location = new System.Drawing.Point(12, 20);
            this.panel_TCP.Name = "panel_TCP";
            this.panel_TCP.Size = new System.Drawing.Size(421, 117);
            this.panel_TCP.TabIndex = 113;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(3, 93);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(65, 12);
            this.label87.TabIndex = 119;
            this.label87.Text = "Local Port";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(3, 65);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(71, 12);
            this.label88.TabIndex = 118;
            this.label88.Text = "Remote Port";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(3, 36);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(71, 12);
            this.label89.TabIndex = 117;
            this.label89.Text = "Remote Host";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(3, 12);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(59, 12);
            this.label90.TabIndex = 116;
            this.label90.Text = "Worked As";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(203, 12);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(89, 12);
            this.label93.TabIndex = 107;
            this.label93.Text = "Active Connect";
            // 
            // workasCB
            // 
            this.workasCB.AccessibleName = "ConnWorkMode";
            this.workasCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workasCB.FormattingEnabled = true;
            this.workasCB.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.workasCB.Location = new System.Drawing.Point(79, 9);
            this.workasCB.Name = "workasCB";
            this.workasCB.Size = new System.Drawing.Size(92, 20);
            this.workasCB.TabIndex = 106;
            // 
            // tcpRomteHostTB
            // 
            this.tcpRomteHostTB.AccessibleName = "ConnRemoteHost";
            this.tcpRomteHostTB.Location = new System.Drawing.Point(79, 32);
            this.tcpRomteHostTB.Name = "tcpRomteHostTB";
            this.tcpRomteHostTB.Size = new System.Drawing.Size(92, 21);
            this.tcpRomteHostTB.TabIndex = 98;
            // 
            // tcpRemotePortNUD
            // 
            this.tcpRemotePortNUD.AccessibleName = "ConnRemotePort";
            this.tcpRemotePortNUD.Location = new System.Drawing.Point(111, 59);
            this.tcpRemotePortNUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.tcpRemotePortNUD.Name = "tcpRemotePortNUD";
            this.tcpRemotePortNUD.Size = new System.Drawing.Size(60, 21);
            this.tcpRemotePortNUD.TabIndex = 96;
            this.tcpRemotePortNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tcpLocalPortNUD
            // 
            this.tcpLocalPortNUD.AccessibleName = "ConnLocalPort";
            this.tcpLocalPortNUD.Location = new System.Drawing.Point(111, 86);
            this.tcpLocalPortNUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.tcpLocalPortNUD.Name = "tcpLocalPortNUD";
            this.tcpLocalPortNUD.Size = new System.Drawing.Size(60, 21);
            this.tcpLocalPortNUD.TabIndex = 95;
            this.tcpLocalPortNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tcpActiveCB
            // 
            this.tcpActiveCB.AccessibleName = "ConnActive";
            this.tcpActiveCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tcpActiveCB.FormattingEnabled = true;
            this.tcpActiveCB.Items.AddRange(new object[] {
            "None",
            "WithAnyCharacter",
            "WithStartCharacter",
            "AutoStart"});
            this.tcpActiveCB.Location = new System.Drawing.Point(292, 7);
            this.tcpActiveCB.Name = "tcpActiveCB";
            this.tcpActiveCB.Size = new System.Drawing.Size(107, 20);
            this.tcpActiveCB.TabIndex = 93;
            // 
            // groupBox49
            // 
            this.groupBox49.Controls.Add(this.btGetSeriaPort);
            this.groupBox49.Controls.Add(this.btSetSerialPort);
            this.groupBox49.Controls.Add(this.panel7);
            this.groupBox49.Location = new System.Drawing.Point(191, 18);
            this.groupBox49.Name = "groupBox49";
            this.groupBox49.Size = new System.Drawing.Size(554, 118);
            this.groupBox49.TabIndex = 67;
            this.groupBox49.TabStop = false;
            this.groupBox49.Text = "Serialport Setting ";
            // 
            // btGetSeriaPort
            // 
            this.btGetSeriaPort.Location = new System.Drawing.Point(456, 41);
            this.btGetSeriaPort.Name = "btGetSeriaPort";
            this.btGetSeriaPort.Size = new System.Drawing.Size(90, 23);
            this.btGetSeriaPort.TabIndex = 118;
            this.btGetSeriaPort.Text = "Get";
            this.btGetSeriaPort.UseVisualStyleBackColor = true;
            this.btGetSeriaPort.Click += new System.EventHandler(this.btGetSeriaPort_Click);
            // 
            // btSetSerialPort
            // 
            this.btSetSerialPort.Location = new System.Drawing.Point(456, 79);
            this.btSetSerialPort.Name = "btSetSerialPort";
            this.btSetSerialPort.Size = new System.Drawing.Size(90, 23);
            this.btSetSerialPort.TabIndex = 117;
            this.btSetSerialPort.Text = "Set";
            this.btSetSerialPort.UseVisualStyleBackColor = true;
            this.btSetSerialPort.Click += new System.EventHandler(this.btSetSerialPort_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label72);
            this.panel7.Controls.Add(this.label73);
            this.panel7.Controls.Add(this.label74);
            this.panel7.Controls.Add(this.label75);
            this.panel7.Controls.Add(this.label76);
            this.panel7.Controls.Add(this.label77);
            this.panel7.Controls.Add(this.label78);
            this.panel7.Controls.Add(this.protocolCB);
            this.panel7.Controls.Add(this.stopbitCB);
            this.panel7.Controls.Add(this.parityCB);
            this.panel7.Controls.Add(this.databitCB);
            this.panel7.Controls.Add(this.baudrateCB);
            this.panel7.Controls.Add(this.flowCB);
            this.panel7.Controls.Add(this.fifoCB);
            this.panel7.Location = new System.Drawing.Point(18, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(415, 85);
            this.panel7.TabIndex = 113;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(281, 13);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(59, 12);
            this.label72.TabIndex = 112;
            this.label72.Text = "Data Bits";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(221, 64);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(59, 12);
            this.label73.TabIndex = 111;
            this.label73.Text = "Stop Bits";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(221, 39);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(77, 12);
            this.label74.TabIndex = 110;
            this.label74.Text = "Flow Control";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(15, 64);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(41, 12);
            this.label75.TabIndex = 109;
            this.label75.Text = "Parity";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(15, 39);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(59, 12);
            this.label76.TabIndex = 107;
            this.label76.Text = "Baud Rate";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(186, 13);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(29, 12);
            this.label77.TabIndex = 108;
            this.label77.Text = "FIFO";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(15, 13);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(53, 12);
            this.label78.TabIndex = 107;
            this.label78.Text = "Protocol";
            // 
            // protocolCB
            // 
            this.protocolCB.AccessibleName = "SerialProtocol";
            this.protocolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.protocolCB.FormattingEnabled = true;
            this.protocolCB.Items.AddRange(new object[] {
            "RS232",
            "RS422",
            "RS485"});
            this.protocolCB.Location = new System.Drawing.Point(92, 10);
            this.protocolCB.Name = "protocolCB";
            this.protocolCB.Size = new System.Drawing.Size(64, 20);
            this.protocolCB.TabIndex = 83;
            // 
            // stopbitCB
            // 
            this.stopbitCB.AccessibleName = "StopBits";
            this.stopbitCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbitCB.FormattingEnabled = true;
            this.stopbitCB.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbitCB.Location = new System.Drawing.Point(311, 61);
            this.stopbitCB.Name = "stopbitCB";
            this.stopbitCB.Size = new System.Drawing.Size(45, 20);
            this.stopbitCB.TabIndex = 48;
            // 
            // parityCB
            // 
            this.parityCB.AccessibleName = "SerialParity";
            this.parityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityCB.FormattingEnabled = true;
            this.parityCB.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN",
            "MARK",
            "SPACE"});
            this.parityCB.Location = new System.Drawing.Point(92, 61);
            this.parityCB.Name = "parityCB";
            this.parityCB.Size = new System.Drawing.Size(88, 20);
            this.parityCB.TabIndex = 47;
            // 
            // databitCB
            // 
            this.databitCB.AccessibleName = "DataBits";
            this.databitCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databitCB.FormattingEnabled = true;
            this.databitCB.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databitCB.Location = new System.Drawing.Point(354, 10);
            this.databitCB.Name = "databitCB";
            this.databitCB.Size = new System.Drawing.Size(45, 20);
            this.databitCB.TabIndex = 46;
            // 
            // baudrateCB
            // 
            this.baudrateCB.AccessibleName = "BaudRate";
            this.baudrateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrateCB.FormattingEnabled = true;
            this.baudrateCB.Items.AddRange(new object[] {
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800"});
            this.baudrateCB.Location = new System.Drawing.Point(92, 35);
            this.baudrateCB.Name = "baudrateCB";
            this.baudrateCB.Size = new System.Drawing.Size(98, 20);
            this.baudrateCB.TabIndex = 45;
            // 
            // flowCB
            // 
            this.flowCB.AccessibleName = "FlowControl";
            this.flowCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowCB.FormattingEnabled = true;
            this.flowCB.Items.AddRange(new object[] {
            "None",
            "Software",
            "Hardware"});
            this.flowCB.Location = new System.Drawing.Point(311, 36);
            this.flowCB.Name = "flowCB";
            this.flowCB.Size = new System.Drawing.Size(88, 20);
            this.flowCB.TabIndex = 44;
            // 
            // fifoCB
            // 
            this.fifoCB.AccessibleName = "SerialFIFO";
            this.fifoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fifoCB.FormattingEnabled = true;
            this.fifoCB.Items.AddRange(new object[] {
            "14",
            "8",
            "4"});
            this.fifoCB.Location = new System.Drawing.Point(221, 10);
            this.fifoCB.Name = "fifoCB";
            this.fifoCB.Size = new System.Drawing.Size(45, 20);
            this.fifoCB.TabIndex = 43;
            // 
            // groupBox47
            // 
            this.groupBox47.Controls.Add(this.btExitAT);
            this.groupBox47.Controls.Add(this.btGotoAT);
            this.groupBox47.Location = new System.Drawing.Point(754, 340);
            this.groupBox47.Name = "groupBox47";
            this.groupBox47.Size = new System.Drawing.Size(110, 85);
            this.groupBox47.TabIndex = 66;
            this.groupBox47.TabStop = false;
            this.groupBox47.Text = "AT Mode Change";
            // 
            // btExitAT
            // 
            this.btExitAT.Location = new System.Drawing.Point(11, 49);
            this.btExitAT.Name = "btExitAT";
            this.btExitAT.Size = new System.Drawing.Size(90, 23);
            this.btExitAT.TabIndex = 1;
            this.btExitAT.Text = "Exit";
            this.btExitAT.UseVisualStyleBackColor = true;
            this.btExitAT.Click += new System.EventHandler(this.btExitAT_Click);
            // 
            // btGotoAT
            // 
            this.btGotoAT.Location = new System.Drawing.Point(11, 19);
            this.btGotoAT.Name = "btGotoAT";
            this.btGotoAT.Size = new System.Drawing.Size(90, 23);
            this.btGotoAT.TabIndex = 0;
            this.btGotoAT.Text = "Enter";
            this.btGotoAT.UseVisualStyleBackColor = true;
            this.btGotoAT.Click += new System.EventHandler(this.btGotoAT_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label63);
            this.tabPage8.Controls.Add(this.stcprecv);
            this.tabPage8.Controls.Add(this.groupBox25);
            this.tabPage8.Controls.Add(this.groupBox24);
            this.tabPage8.Location = new System.Drawing.Point(4, 27);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1064, 530);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "   TCP Server   ";
            this.tabPage8.UseVisualStyleBackColor = true;
            this.tabPage8.Click += new System.EventHandler(this.tabPage8_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(204, 125);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(113, 12);
            this.label63.TabIndex = 3;
            this.label63.Text = "Receive data(Hex):";
            // 
            // stcprecv
            // 
            this.stcprecv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stcprecv.EnableAutoDragDrop = true;
            this.stcprecv.Location = new System.Drawing.Point(202, 140);
            this.stcprecv.Name = "stcprecv";
            this.stcprecv.Size = new System.Drawing.Size(617, 381);
            this.stcprecv.TabIndex = 2;
            this.stcprecv.Text = "";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.listtcp);
            this.groupBox25.Location = new System.Drawing.Point(512, 6);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(307, 106);
            this.groupBox25.TabIndex = 1;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Client";
            // 
            // listtcp
            // 
            this.listtcp.FormattingEnabled = true;
            this.listtcp.ItemHeight = 12;
            this.listtcp.Location = new System.Drawing.Point(8, 20);
            this.listtcp.Name = "listtcp";
            this.listtcp.Size = new System.Drawing.Size(287, 76);
            this.listtcp.TabIndex = 0;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.btStop);
            this.groupBox24.Controls.Add(this.btListen);
            this.groupBox24.Controls.Add(this.stcpport);
            this.groupBox24.Controls.Add(this.label62);
            this.groupBox24.Location = new System.Drawing.Point(202, 6);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(301, 106);
            this.groupBox24.TabIndex = 0;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Server Setting";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(191, 63);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(92, 33);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btListen
            // 
            this.btListen.Location = new System.Drawing.Point(93, 63);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(92, 33);
            this.btListen.TabIndex = 2;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // stcpport
            // 
            this.stcpport.Location = new System.Drawing.Point(93, 25);
            this.stcpport.Name = "stcpport";
            this.stcpport.Size = new System.Drawing.Size(187, 21);
            this.stcpport.TabIndex = 1;
            this.stcpport.Text = "6000";
            this.stcpport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(17, 32);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(59, 12);
            this.label62.TabIndex = 0;
            this.label62.Text = "TCP Port:";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox26);
            this.tabPage9.Controls.Add(this.bttcpsend);
            this.tabPage9.Controls.Add(this.label69);
            this.tabPage9.Controls.Add(this.ctctsend);
            this.tabPage9.Controls.Add(this.label68);
            this.tabPage9.Controls.Add(this.ctctrecv);
            this.tabPage9.Location = new System.Drawing.Point(4, 27);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1064, 530);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "   TCP Client   ";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.bttcpdisconnect);
            this.groupBox26.Controls.Add(this.bttcpconnect);
            this.groupBox26.Controls.Add(this.remotePort);
            this.groupBox26.Controls.Add(this.label71);
            this.groupBox26.Controls.Add(this.tcpremoteIp);
            this.groupBox26.Controls.Add(this.label70);
            this.groupBox26.Location = new System.Drawing.Point(209, 6);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(617, 63);
            this.groupBox26.TabIndex = 9;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Setting";
            // 
            // bttcpdisconnect
            // 
            this.bttcpdisconnect.Location = new System.Drawing.Point(521, 25);
            this.bttcpdisconnect.Name = "bttcpdisconnect";
            this.bttcpdisconnect.Size = new System.Drawing.Size(90, 23);
            this.bttcpdisconnect.TabIndex = 26;
            this.bttcpdisconnect.Text = "Disconnect";
            this.bttcpdisconnect.UseVisualStyleBackColor = true;
            this.bttcpdisconnect.Click += new System.EventHandler(this.bttcpdisconnect_Click);
            // 
            // bttcpconnect
            // 
            this.bttcpconnect.Location = new System.Drawing.Point(415, 25);
            this.bttcpconnect.Name = "bttcpconnect";
            this.bttcpconnect.Size = new System.Drawing.Size(90, 23);
            this.bttcpconnect.TabIndex = 25;
            this.bttcpconnect.Text = "Connect";
            this.bttcpconnect.UseVisualStyleBackColor = true;
            this.bttcpconnect.Click += new System.EventHandler(this.bttcpconnect_Click);
            // 
            // remotePort
            // 
            this.remotePort.Location = new System.Drawing.Point(268, 25);
            this.remotePort.Name = "remotePort";
            this.remotePort.Size = new System.Drawing.Size(94, 21);
            this.remotePort.TabIndex = 24;
            this.remotePort.Text = "27011";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(227, 30);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(35, 12);
            this.label71.TabIndex = 23;
            this.label71.Text = "Port:";
            // 
            // tcpremoteIp
            // 
            this.tcpremoteIp.IpAddressStr = "192.168.0.250";
            this.tcpremoteIp.Location = new System.Drawing.Point(55, 25);
            this.tcpremoteIp.Name = "tcpremoteIp";
            this.tcpremoteIp.Size = new System.Drawing.Size(121, 21);
            this.tcpremoteIp.TabIndex = 22;
            this.tcpremoteIp.Tag = "";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(14, 30);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(65, 12);
            this.label70.TabIndex = 0;
            this.label70.Text = "Server IP:";
            // 
            // bttcpsend
            // 
            this.bttcpsend.Enabled = false;
            this.bttcpsend.Location = new System.Drawing.Point(730, 79);
            this.bttcpsend.Name = "bttcpsend";
            this.bttcpsend.Size = new System.Drawing.Size(90, 23);
            this.bttcpsend.TabIndex = 8;
            this.bttcpsend.Text = "Send";
            this.bttcpsend.UseVisualStyleBackColor = true;
            this.bttcpsend.Click += new System.EventHandler(this.bttcpsend_Click);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(211, 86);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(95, 12);
            this.label69.TabIndex = 7;
            this.label69.Text = "Send data(Hex):";
            // 
            // ctctsend
            // 
            this.ctctsend.Location = new System.Drawing.Point(209, 107);
            this.ctctsend.Multiline = true;
            this.ctctsend.Name = "ctctsend";
            this.ctctsend.Size = new System.Drawing.Size(617, 86);
            this.ctctsend.TabIndex = 6;
            this.ctctsend.Text = "04 FF 21 19 95";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(211, 201);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(113, 12);
            this.label68.TabIndex = 5;
            this.label68.Text = "Receive data(Hex):";
            // 
            // ctctrecv
            // 
            this.ctctrecv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctctrecv.EnableAutoDragDrop = true;
            this.ctctrecv.Location = new System.Drawing.Point(209, 216);
            this.ctctrecv.Name = "ctctrecv";
            this.ctctrecv.Size = new System.Drawing.Size(617, 304);
            this.ctctrecv.TabIndex = 4;
            this.ctctrecv.Text = "";
            // 
            // btFlashCl
            // 
            this.btFlashCl.Location = new System.Drawing.Point(939, 603);
            this.btFlashCl.Name = "btFlashCl";
            this.btFlashCl.Size = new System.Drawing.Size(100, 23);
            this.btFlashCl.TabIndex = 5;
            this.btFlashCl.Text = "Refresh";
            this.btFlashCl.UseVisualStyleBackColor = true;
            this.btFlashCl.Click += new System.EventHandler(this.btFlashCl_Click);
            // 
            // timer_answer
            // 
            this.timer_answer.Interval = 50;
            this.timer_answer.Tick += new System.EventHandler(this.timer_answer_Tick);
            // 
            // timer_runmode
            // 
            this.timer_runmode.Interval = 50;
            this.timer_runmode.Tick += new System.EventHandler(this.timer_runmode_Tick);
            // 
            // timer_EAS
            // 
            this.timer_EAS.Tick += new System.EventHandler(this.timer_EAS_Tick);
            // 
            // Timer_Test_6B
            // 
            this.Timer_Test_6B.Tick += new System.EventHandler(this.Timer_Test_6B_Tick);
            // 
            // timer_Buff
            // 
            this.timer_Buff.Interval = 50;
            this.timer_Buff.Tick += new System.EventHandler(this.timer_Buff_Tick);
            // 
            // timer_RealTime
            // 
            this.timer_RealTime.Interval = 50;
            this.timer_RealTime.Tick += new System.EventHandler(this.timer_RealTime_Tick);
            // 
            // ckClearOperationRec
            // 
            this.ckClearOperationRec.AutoSize = true;
            this.ckClearOperationRec.Checked = true;
            this.ckClearOperationRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClearOperationRec.Location = new System.Drawing.Point(134, 607);
            this.ckClearOperationRec.Name = "ckClearOperationRec";
            this.ckClearOperationRec.Size = new System.Drawing.Size(84, 16);
            this.ckClearOperationRec.TabIndex = 18;
            this.ckClearOperationRec.Text = "Auto-Clear";
            this.ckClearOperationRec.UseVisualStyleBackColor = true;
            // 
            // checkBox_U9
            // 
            this.checkBox_U9.AutoSize = true;
            this.checkBox_U9.Location = new System.Drawing.Point(505, 88);
            this.checkBox_U9.Name = "checkBox_U9";
            this.checkBox_U9.Size = new System.Drawing.Size(36, 16);
            this.checkBox_U9.TabIndex = 8;
            this.checkBox_U9.Text = "U9";
            this.checkBox_U9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 723);
            this.Controls.Add(this.ckClearOperationRec);
            this.Controls.Add(this.btFlashCl);
            this.Controls.Add(this.Maintab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lrtxtLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UHFReader288 Demo V5.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Maintab.ResumeLayout(false);
            this.Main_Page1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Basic.ResumeLayout(false);
            this.gbReturnLoss.ResumeLayout(false);
            this.gbReturnLoss.PerformLayout();
            this.gbCmdTemperature.ResumeLayout(false);
            this.gbCmdTemperature.PerformLayout();
            this.gbp_DRM.ResumeLayout(false);
            this.gbp_DRM.PerformLayout();
            this.gbp_Retry.ResumeLayout(false);
            this.gbp_wpower.ResumeLayout(false);
            this.gbp_wpower.PerformLayout();
            this.group_maxtime.ResumeLayout(false);
            this.gbp_buff.ResumeLayout(false);
            this.gbp_buff.PerformLayout();
            this.gpb_antconfig.ResumeLayout(false);
            this.gpb_antconfig.PerformLayout();
            this.gpb_checkant.ResumeLayout(false);
            this.gpb_checkant.PerformLayout();
            this.gpb_GPIO.ResumeLayout(false);
            this.gpb_GPIO.PerformLayout();
            this.gpb_OutputRep.ResumeLayout(false);
            this.gpb_OutputRep.PerformLayout();
            this.gpb_Relay.ResumeLayout(false);
            this.gpb_Relay.PerformLayout();
            this.gpb_baud.ResumeLayout(false);
            this.gpb_DBM.ResumeLayout(false);
            this.gpb_DBM.PerformLayout();
            this.gpb_Freq.ResumeLayout(false);
            this.gpb_Freq.PerformLayout();
            this.gpb_beep.ResumeLayout(false);
            this.gpb_beep.PerformLayout();
            this.gpb_RDVersion.ResumeLayout(false);
            this.gpb_RDVersion.PerformLayout();
            this.gpb_MDVersion.ResumeLayout(false);
            this.gpb_MDVersion.PerformLayout();
            this.gpb_Serial.ResumeLayout(false);
            this.gpb_Serial.PerformLayout();
            this.gpb_address.ResumeLayout(false);
            this.gpb_address.PerformLayout();
            this.gpb_tcp.ResumeLayout(false);
            this.gpb_tcp.PerformLayout();
            this.gpb_rs232.ResumeLayout(false);
            this.gpb_rs232.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Mx.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbp_trigger.ResumeLayout(false);
            this.gbp_trigger.PerformLayout();
            this.groupBox43.ResumeLayout(false);
            this.groupBox43.PerformLayout();
            this.groupBox44.ResumeLayout(false);
            this.groupBox44.PerformLayout();
            this.groupBox37.ResumeLayout(false);
            this.groupBox37.PerformLayout();
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            this.gbp_tagType.ResumeLayout(false);
            this.gbp_tagType.PerformLayout();
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.gbp_Response.ResumeLayout(false);
            this.gbp_Response.PerformLayout();
            this.gbp_mask.ResumeLayout(false);
            this.gbp_mask.PerformLayout();
            this.gbp_EASAcc.ResumeLayout(false);
            this.gbp_EASAcc.PerformLayout();
            this.tabPage_Module.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.groupBox58.ResumeLayout(false);
            this.groupBox58.PerformLayout();
            this.groupBox57.ResumeLayout(false);
            this.groupBox57.PerformLayout();
            this.groupBox45.ResumeLayout(false);
            this.groupBox45.PerformLayout();
            this.gbp_PowerAnt.ResumeLayout(false);
            this.gbp_PowerAnt.PerformLayout();
            this.Main_Page2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage_answer.ResumeLayout(false);
            this.chk_phase.ResumeLayout(false);
            this.chk_phase.PerformLayout();
            this.group_ant1.ResumeLayout(false);
            this.group_ant1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).EndInit();
            this.gbp_MixRead.ResumeLayout(false);
            this.gbp_MixRead.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage_active.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_toltime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_toltag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_cmdsud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Num)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPage_Realtime.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox41.ResumeLayout(false);
            this.groupBox41.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtag)).EndInit();
            this.groupBox42.ResumeLayout(false);
            this.tabPage_Buff.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_cmdTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Bcmdsud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_BNum)).EndInit();
            this.tabPage_fastscan.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox59.ResumeLayout(false);
            this.groupBox59.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl8)).EndInit();
            this.groupBox60.ResumeLayout(false);
            this.groupBox60.PerformLayout();
            this.tabPage_RW.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox40.ResumeLayout(false);
            this.groupBox40.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.Main_Page5.ResumeLayout(false);
            this.panel_jb.ResumeLayout(false);
            this.panel_jb.PerformLayout();
            this.group_jbant.ResumeLayout(false);
            this.group_jbant.PerformLayout();
            this.tabControl4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox53.ResumeLayout(false);
            this.groupBox53.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_jb_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_jb_time)).EndInit();
            this.groupBox52.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_JB)).EndInit();
            this.gbp_jb_mix.ResumeLayout(false);
            this.gbp_jb_mix.PerformLayout();
            this.groupBox48.ResumeLayout(false);
            this.groupBox48.PerformLayout();
            this.Main_Page6.ResumeLayout(false);
            this.panel_gb.ResumeLayout(false);
            this.panel_gb.PerformLayout();
            this.tabControl5.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            this.groupBox46.ResumeLayout(false);
            this.groupBox46.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_gb_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_gb_time)).EndInit();
            this.groupBox54.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GB)).EndInit();
            this.gbp_gb_mix.ResumeLayout(false);
            this.gbp_gb_mix.PerformLayout();
            this.gbp_gb_ant.ResumeLayout(false);
            this.gbp_gb_ant.PerformLayout();
            this.groupBox55.ResumeLayout(false);
            this.groupBox55.PerformLayout();
            this.Main_Page3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.Main_Page4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox51.ResumeLayout(false);
            this.groupBox51.PerformLayout();
            this.panel_StaticIp.ResumeLayout(false);
            this.panel_StaticIp.PerformLayout();
            this.groupBox50.ResumeLayout(false);
            this.panel_TCP.ResumeLayout(false);
            this.panel_TCP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcpRemotePortNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcpLocalPortNUD)).EndInit();
            this.groupBox49.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox47.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.LogRichTextBox lrtxtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Maintab;
        private System.Windows.Forms.TabPage Main_Page1;
        private System.Windows.Forms.TabPage Main_Page2;
        private System.Windows.Forms.TabPage Main_Page3;
        private System.Windows.Forms.TabPage Main_Page4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Basic;
        private System.Windows.Forms.GroupBox gpb_rs232;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_tcp;
        private System.Windows.Forms.RadioButton rb_rs232;
        private System.Windows.Forms.TabPage tabPage_Mx;
        private System.Windows.Forms.Button btDisConnect232;
        private System.Windows.Forms.Button btConnect232;
        private System.Windows.Forms.ComboBox ComboBox_baud2;
        private System.Windows.Forms.Label label47;
        internal System.Windows.Forms.ComboBox ComboBox_COM;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpb_tcp;
        private System.Windows.Forms.Button btDisConnectTcp;
        private System.Windows.Forms.Button btConnectTcp;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Port;
        private CustomControl.IpAddressTextBox ipServerIP;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage_answer;
        private System.Windows.Forms.TabPage tabPage_active;
        private System.Windows.Forms.Button btFlashCl;
        private System.Windows.Forms.Timer timer_answer;
        private System.Windows.Forms.Panel chk_phase;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox com_scantime;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox com_S;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox com_Q;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_tid;
        private System.Windows.Forms.RadioButton rb_epc;
        private System.Windows.Forms.Button btIventoryG2;
        private System.Windows.Forms.GroupBox gpb_address;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Button btaddress;
        private System.Windows.Forms.GroupBox gpb_MDVersion;
        private System.Windows.Forms.TextBox text_MDVersion;
        private System.Windows.Forms.Button btMDVersion;
        private System.Windows.Forms.GroupBox gpb_Serial;
        private System.Windows.Forms.TextBox text_Serial;
        private System.Windows.Forms.Button btSerial;
        private System.Windows.Forms.GroupBox gpb_beep;
        private System.Windows.Forms.GroupBox gpb_RDVersion;
        private System.Windows.Forms.TextBox text_RDVersion;
        private System.Windows.Forms.RadioButton Radio_beepDis;
        private System.Windows.Forms.RadioButton Radio_beepEn;
        private System.Windows.Forms.Button Button_Beep;
        private System.Windows.Forms.GroupBox gpb_Freq;
        private System.Windows.Forms.RadioButton radioButton_band4;
        private System.Windows.Forms.RadioButton radioButton_band3;
        private System.Windows.Forms.RadioButton radioButton_band2;
        private System.Windows.Forms.RadioButton radioButton_band1;
        private System.Windows.Forms.Button btFreq;
        private System.Windows.Forms.ComboBox ComboBox_dmaxfre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ComboBox_dminfre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CheckBox_SameFre;
        private System.Windows.Forms.GroupBox gpb_DBM;
        private System.Windows.Forms.Button BT_DBM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBox_PowerDbm;
        private System.Windows.Forms.GroupBox gpb_baud;
        private System.Windows.Forms.Button btBaudRate;
        private System.Windows.Forms.ComboBox ComboBox_baud;
        private System.Windows.Forms.GroupBox gpb_Relay;
        private System.Windows.Forms.Button btRelay;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox ComboBox_RelayTime;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox gpb_OutputRep;
        private System.Windows.Forms.Button btOutputRep;
        private System.Windows.Forms.CheckBox check_OutputRep4;
        private System.Windows.Forms.CheckBox check_OutputRep3;
        private System.Windows.Forms.CheckBox check_OutputRep2;
        private System.Windows.Forms.CheckBox check_OutputRep1;
        private System.Windows.Forms.GroupBox gpb_antconfig;
        private System.Windows.Forms.Button Button_Ant;
        private System.Windows.Forms.CheckBox checkant4;
        private System.Windows.Forms.CheckBox checkant3;
        private System.Windows.Forms.CheckBox checkant2;
        private System.Windows.Forms.CheckBox checkant1;
        private System.Windows.Forms.GroupBox gpb_checkant;
        private System.Windows.Forms.Button btSetcheckant;
        private System.Windows.Forms.RadioButton rb_Closecheckant;
        private System.Windows.Forms.RadioButton rb_Opencheckant;
        private System.Windows.Forms.GroupBox gpb_GPIO;
        private System.Windows.Forms.Button Button_GetGPIO;
        private System.Windows.Forms.Button Button_SetGPIO;
        private System.Windows.Forms.CheckBox check_int4;
        private System.Windows.Forms.CheckBox check_int3;
        private System.Windows.Forms.CheckBox check_int2;
        private System.Windows.Forms.CheckBox check_int1;
        private System.Windows.Forms.CheckBox check_out4;
        private System.Windows.Forms.CheckBox check_out3;
        private System.Windows.Forms.CheckBox check_out2;
        private System.Windows.Forms.CheckBox check_out1;
        private System.Windows.Forms.Button btGetInformation;
        private System.Windows.Forms.Button btDefault;
        private System.Windows.Forms.Button btFlashROM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbp_trigger;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Button bttrigger;
        private System.Windows.Forms.ComboBox comboBox_trigger;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.GroupBox groupBox43;
        private System.Windows.Forms.Button btGetQS;
        private System.Windows.Forms.Button btSetQS;
        private System.Windows.Forms.ComboBox com_acS;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox com_acQ;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.GroupBox groupBox44;
        private System.Windows.Forms.TextBox text_tidlen;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox text_tidaddr;
        private System.Windows.Forms.Button btTIDpara;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button btGetWorkmodepara;
        private System.Windows.Forms.GroupBox groupBox37;
        private System.Windows.Forms.Button btworkmode;
        private System.Windows.Forms.ComboBox comboBox_mode;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.Button btInterval;
        private System.Windows.Forms.ComboBox comboBox_intervalT;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.GroupBox gbp_tagType;
        private System.Windows.Forms.RadioButton rb_G2TID;
        private System.Windows.Forms.Button bt_typeTag;
        private System.Windows.Forms.RadioButton rb_EAS;
        private System.Windows.Forms.RadioButton rb_G2;
        private System.Windows.Forms.GroupBox groupBox35;
        private System.Windows.Forms.RadioButton rb_180006B;
        private System.Windows.Forms.RadioButton rb_180006c;
        private System.Windows.Forms.GroupBox gbp_Response;
        private System.Windows.Forms.Button btResponse;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ComboBox comboBox_RespTime;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox comboBox_Resp;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.GroupBox gbp_mask;
        private System.Windows.Forms.Button btMaskSet;
        private System.Windows.Forms.TextBox text_mdata;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox text_mlen;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox text_madds;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.RadioButton rb_MaskUser;
        private System.Windows.Forms.RadioButton rb_MaskTID;
        private System.Windows.Forms.RadioButton rb_MaskEPC;
        private System.Windows.Forms.GroupBox gbp_EASAcc;
        private System.Windows.Forms.Button btAccuracy;
        private System.Windows.Forms.ComboBox ComboBox_Accuracy;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbEASAcc;
        private System.Windows.Forms.Timer timer_runmode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btGetrunmodedata;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btClearBuffer;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btGettagbuffer;
        private System.Windows.Forms.GroupBox groupBox9;
        private LxControl.LxLedControl lxLed_cmdsud;
        private System.Windows.Forms.Label label17;
        private LxControl.LxLedControl lxLed_Num;
        private System.Windows.Forms.DataGridView dataGridView2;
        private LxControl.LxLedControl lxLed_toltime;
        private System.Windows.Forms.Label label19;
        private LxControl.LxLedControl lxLed_toltag;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage_RW;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox text_epc;
        private System.Windows.Forms.CheckBox check_selecttag;
        private System.Windows.Forms.Button btSelectTag;
        private System.Windows.Forms.ComboBox comboBox_EPC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.TextBox maskData_textBox;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.GroupBox groupBox40;
        private System.Windows.Forms.RadioButton R_User;
        private System.Windows.Forms.RadioButton R_TID;
        private System.Windows.Forms.RadioButton R_EPC;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox maskLen_textBox;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox maskadr_textbox;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox_pc;
        private System.Windows.Forms.CheckBox checkBox_pc;
        private System.Windows.Forms.Button btBlockWrite;
        private System.Windows.Forms.Button btBlockErase;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.TextBox text_WriteData;
        private System.Windows.Forms.TextBox text_AccessCode2;
        private System.Windows.Forms.TextBox text_RWlen;
        private System.Windows.Forms.TextBox text_WordPtr;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton C_User;
        private System.Windows.Forms.RadioButton C_TID;
        private System.Windows.Forms.RadioButton C_EPC;
        private System.Windows.Forms.RadioButton C_Reserve;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btSetProtectState;
        private System.Windows.Forms.TextBox Edit_AccessCode6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.RadioButton AlwaysNot2;
        private System.Windows.Forms.RadioButton Always2;
        private System.Windows.Forms.RadioButton Proect2;
        private System.Windows.Forms.RadioButton NoProect2;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RadioButton P_User;
        private System.Windows.Forms.RadioButton P_TID;
        private System.Windows.Forms.RadioButton P_EPC;
        private System.Windows.Forms.RadioButton P_kill;
        private System.Windows.Forms.RadioButton p_pass;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button btCheckEASAlarm;
        private System.Windows.Forms.Button btSetEASAlarm_G2;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.RadioButton NoAlarm_G2;
        private System.Windows.Forms.RadioButton Alarm_G2;
        private System.Windows.Forms.TextBox text_AccessCode5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Button btCheckReadProtected_G2;
        private System.Windows.Forms.Button btRemoveReadProtect_G2;
        private System.Windows.Forms.Button btSetMultiReadProtect_G2;
        private System.Windows.Forms.Button btSetReadProtect_G2;
        private System.Windows.Forms.TextBox text_AccessCode4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Button btWriteEPC_G2;
        private System.Windows.Forms.TextBox text_AccessCode3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox text_WriteEPC;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button btDestroyCard;
        private System.Windows.Forms.TextBox text_DestroyCode;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Timer timer_EAS;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView ListView_ID_6B;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.RadioButton rb_mutiple;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.Button btInventory6B;
        private System.Windows.Forms.Timer Timer_Test_6B;
        private System.Windows.Forms.TextBox text_6BUID;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox text_R6BLen;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox text_R6BAddr;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox text_R6B;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btRead6B;
        private System.Windows.Forms.TextBox text_W6B;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button btWrite6B;
        private System.Windows.Forms.TextBox text_W6BLen;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox text_W6BAddr;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox text_lock6b;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox text_Statu6B;
        private System.Windows.Forms.Button btCheckLock6B;
        private System.Windows.Forms.Button btLock6B;
        private System.Windows.Forms.TextBox text_checkaddr;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView DeviceListView;
        private System.Windows.Forms.ColumnHeader deviceName;
        private System.Windows.Forms.ColumnHeader deviceIP;
        private System.Windows.Forms.ColumnHeader deviceMac;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoadDefault;
        private System.Windows.Forms.GroupBox groupBox51;
        private System.Windows.Forms.Button btGetNet;
        private System.Windows.Forms.Button btSetNet;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.TextBox macTB;
        private System.Windows.Forms.Panel panel_StaticIp;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.TextBox altDNSTB;
        private System.Windows.Forms.TextBox pDNSTB;
        private System.Windows.Forms.TextBox gatewayTB;
        private System.Windows.Forms.TextBox subnetTB;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.GroupBox groupBox50;
        private System.Windows.Forms.Button btGetCnt;
        private System.Windows.Forms.Button btSetCnt;
        private System.Windows.Forms.Panel panel_TCP;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.ComboBox workasCB;
        private System.Windows.Forms.TextBox tcpRomteHostTB;
        private System.Windows.Forms.NumericUpDown tcpRemotePortNUD;
        private System.Windows.Forms.NumericUpDown tcpLocalPortNUD;
        private System.Windows.Forms.ComboBox tcpActiveCB;
        private System.Windows.Forms.GroupBox groupBox49;
        private System.Windows.Forms.Button btGetSeriaPort;
        private System.Windows.Forms.Button btSetSerialPort;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.ComboBox protocolCB;
        private System.Windows.Forms.ComboBox stopbitCB;
        private System.Windows.Forms.ComboBox parityCB;
        private System.Windows.Forms.ComboBox databitCB;
        private System.Windows.Forms.ComboBox baudrateCB;
        private System.Windows.Forms.ComboBox flowCB;
        private System.Windows.Forms.ComboBox fifoCB;
        private System.Windows.Forms.GroupBox groupBox47;
        private System.Windows.Forms.Button btExitAT;
        private System.Windows.Forms.Button btGotoAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.ListBox listtcp;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.TextBox stcpport;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private CustomControl.LogRichTextBox stcprecv;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button bttcpsend;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox ctctsend;
        private System.Windows.Forms.Label label68;
        private CustomControl.LogRichTextBox ctctrecv;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.Button bttcpdisconnect;
        private System.Windows.Forms.Button bttcpconnect;
        private System.Windows.Forms.TextBox remotePort;
        private System.Windows.Forms.Label label71;
        private CustomControl.IpAddressTextBox tcpremoteIp;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox text_target;
        private System.Windows.Forms.CheckBox check_num;
        private System.Windows.Forms.ComboBox com_Target;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.GroupBox gbp_buff;
        private System.Windows.Forms.RadioButton rb496;
        private System.Windows.Forms.RadioButton rb128;
        private System.Windows.Forms.Button btGetEPCandTIDLen;
        private System.Windows.Forms.Button btSetEPCandTIDLen;
        private System.Windows.Forms.TabPage tabPage_Buff;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button btQueryBuffNum;
        private System.Windows.Forms.Button btRandCbuff;
        private System.Windows.Forms.Button btClearBuff;
        private System.Windows.Forms.Button btReadBuff;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.RadioButton rb_btid;
        private System.Windows.Forms.RadioButton rb_bepc;
        private System.Windows.Forms.Button btStartBuff;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox30;
        private LxControl.LxLedControl lxLed_cmdTime;
        private System.Windows.Forms.Label label86;
        private LxControl.LxLedControl lxLed_Btoltime;
        private System.Windows.Forms.Label label91;
        private LxControl.LxLedControl lxLed_Btoltag;
        private System.Windows.Forms.Label label92;
        private LxControl.LxLedControl lxLed_Bcmdsud;
        private System.Windows.Forms.Label label94;
        private LxControl.LxLedControl lxLed_BNum;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Timer timer_Buff;
        private System.Windows.Forms.Button btExtWrite;
        private System.Windows.Forms.Button btExtRead;
        private System.Windows.Forms.GroupBox group_maxtime;
        private System.Windows.Forms.Button btSetMaxtime;
        private System.Windows.Forms.ComboBox comboBox_maxtime;
        private System.Windows.Forms.CheckBox checkBox_rate;
        private System.Windows.Forms.TabPage tabPage_Module;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.ComboBox com_MFliterTime;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.ComboBox COM_MRPTime;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton MRB_6B;
        private System.Windows.Forms.RadioButton MRB_G2;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.ComboBox com_MS;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox com_MQ;
        private System.Windows.Forms.Label label98;
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
        private System.Windows.Forms.Button btMGetParameter;
        private System.Windows.Forms.GroupBox groupBox39;
        private System.Windows.Forms.Button btSetMmode;
        private System.Windows.Forms.ComboBox com_Mmode;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button btMSetParameter;
        private System.Windows.Forms.TabPage tabPage_Realtime;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox41;
        private LxControl.LxLedControl lxLed_Mtime;
        private System.Windows.Forms.Label label113;
        private LxControl.LxLedControl lxLed_Mtag;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.GroupBox groupBox42;
        private System.Windows.Forms.Button btStartMactive;
        private System.Windows.Forms.Timer timer_RealTime;
        private System.Windows.Forms.CheckBox checkBox_tid;
        private System.Windows.Forms.CheckBox checkBox_mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.RadioButton radioButton_band8;
        private System.Windows.Forms.GroupBox gbp_wpower;
        private System.Windows.Forms.RadioButton rb_wp2;
        private System.Windows.Forms.RadioButton rb_wp1;
        private System.Windows.Forms.Button bt_GetWpower;
        private System.Windows.Forms.Button bt_SetWpower;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.ComboBox com_wpower;
        private System.Windows.Forms.GroupBox gbp_Retry;
        private System.Windows.Forms.ComboBox com_retrytimes;
        private System.Windows.Forms.Button bt_Getretry;
        private System.Windows.Forms.Button bt_Setretry;
        private System.Windows.Forms.GroupBox gbp_MixRead;
        private System.Windows.Forms.ComboBox com_MixMem;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.RadioButton rb_mix;
        private System.Windows.Forms.TextBox text_readpsd;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.TextBox text_readLen;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TextBox text_readadr;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.RadioButton rb_fastid;
        private System.Windows.Forms.GroupBox gbp_DRM;
        private System.Windows.Forms.RadioButton DRM_CLOSE;
        private System.Windows.Forms.RadioButton DRM_OPEN;
        private System.Windows.Forms.Button bt_GetDRM;
        private System.Windows.Forms.Button bt_setDRM;
        private System.Windows.Forms.GroupBox gbReturnLoss;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.ComboBox cmbReturnLossFreq;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.TextBox textReturnLoss;
        private System.Windows.Forms.Button btReturnLoss;
        private System.Windows.Forms.GroupBox gbCmdTemperature;
        private System.Windows.Forms.Button btnGetReaderTemperature;
        private System.Windows.Forms.TextBox txtReaderTemperature;
        private System.Windows.Forms.ComboBox cbbAnt;
        private System.Windows.Forms.CheckBox ckClearOperationRec;
        private System.Windows.Forms.RadioButton radioButton_band12;
        private System.Windows.Forms.RadioButton radioButton_band0;
        private System.Windows.Forms.CheckBox checkant16;
        private System.Windows.Forms.CheckBox checkant15;
        private System.Windows.Forms.CheckBox checkant14;
        private System.Windows.Forms.CheckBox checkant13;
        private System.Windows.Forms.CheckBox checkant12;
        private System.Windows.Forms.CheckBox checkant11;
        private System.Windows.Forms.CheckBox checkant10;
        private System.Windows.Forms.CheckBox checkant9;
        private System.Windows.Forms.CheckBox checkant8;
        private System.Windows.Forms.CheckBox checkant7;
        private System.Windows.Forms.CheckBox checkant6;
        private System.Windows.Forms.CheckBox checkant5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox group_ant1;
        public System.Windows.Forms.CheckBox check_ant16;
        public System.Windows.Forms.CheckBox check_ant15;
        public System.Windows.Forms.CheckBox check_ant14;
        public System.Windows.Forms.CheckBox check_ant13;
        public System.Windows.Forms.CheckBox check_ant12;
        public System.Windows.Forms.CheckBox check_ant11;
        public System.Windows.Forms.CheckBox check_ant10;
        public System.Windows.Forms.CheckBox check_ant9;
        public System.Windows.Forms.CheckBox check_ant8;
        public System.Windows.Forms.CheckBox check_ant7;
        public System.Windows.Forms.CheckBox check_ant6;
        public System.Windows.Forms.CheckBox check_ant5;
        public System.Windows.Forms.CheckBox check_ant4;
        public System.Windows.Forms.CheckBox check_ant3;
        public System.Windows.Forms.CheckBox check_ant2;
        public System.Windows.Forms.CheckBox check_ant1;
        private LxControl.LxLedControl lxLedControl6;
        private System.Windows.Forms.Label label119;
        private LxControl.LxLedControl lxLedControl5;
        private System.Windows.Forms.Label label9;
        private LxControl.LxLedControl lxLedControl4;
        private System.Windows.Forms.Label label8;
        private LxControl.LxLedControl lxLedControl3;
        private System.Windows.Forms.Label label7;
        private LxControl.LxLedControl lxLedControl2;
        private System.Windows.Forms.Label label6;
        private LxControl.LxLedControl lxLedControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage Main_Page5;
        private System.Windows.Forms.Panel panel_jb;
        private System.Windows.Forms.ComboBox com_jb_tagid;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bt_jb_read;
        private System.Windows.Forms.TextBox txt_jb_read_data;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.TextBox txt_jb_read_pwd;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.TextBox txt_jb_read_len;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.TextBox txt_jb_read_startaddr;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.ComboBox cbb_jb_readmem;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_jb_write;
        private System.Windows.Forms.TextBox txt_jb_write_data;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.TextBox txt_jb_write_pwd;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.TextBox txt_jb_write_startaddr;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.ComboBox cbb_jb_writemem;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbb_jb_locktype;
        private System.Windows.Forms.Button bt_jb_lock;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.TextBox txt_jb_lock_pwd;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.ComboBox cbb_jb_lockmem;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bt_jb_erase;
        private System.Windows.Forms.TextBox txt_jb_erase_pwd;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.TextBox txt_jb_erase_num;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.TextBox txt_jb_erase_startaddr;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.ComboBox cbb_jb_erasemem;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button bt_jb_kill;
        private System.Windows.Forms.TextBox txt_jb_kill_pwd;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.GroupBox groupBox53;
        private System.Windows.Forms.TextBox txt_jb_maskdata;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.TextBox txt_mask_jb_startaddr;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.ComboBox cbb_jb_masktype;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.CheckBox chk_jb_mask;
        private LxControl.LxLedControl lxLed_jb_number;
        private System.Windows.Forms.Label label128;
        private LxControl.LxLedControl lxLed_jb_time;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.GroupBox groupBox52;
        private System.Windows.Forms.DataGridView dataGridView_JB;
        private System.Windows.Forms.GroupBox gbp_jb_mix;
        private System.Windows.Forms.TextBox tx_jb_readpsd;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.TextBox tx_jb_masklen;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.TextBox tx_jb_maskaddr;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.ComboBox cbb_jb_maskmem;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.GroupBox groupBox48;
        private System.Windows.Forms.ComboBox com_jb_target;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.ComboBox cbb_jb_scantime;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.RadioButton rb_jb_normal;
        private System.Windows.Forms.RadioButton rb_jb_mix;
        private System.Windows.Forms.Button btInventoryJB;
        private System.Windows.Forms.GroupBox group_jbant;
        public System.Windows.Forms.CheckBox chk_jbant16;
        public System.Windows.Forms.CheckBox chk_jbant15;
        public System.Windows.Forms.CheckBox chk_jbant14;
        public System.Windows.Forms.CheckBox chk_jbant13;
        public System.Windows.Forms.CheckBox chk_jbant12;
        public System.Windows.Forms.CheckBox chk_jbant11;
        public System.Windows.Forms.CheckBox chk_jbant10;
        public System.Windows.Forms.CheckBox chk_jbant9;
        public System.Windows.Forms.CheckBox chk_jbant8;
        public System.Windows.Forms.CheckBox chk_jbant7;
        public System.Windows.Forms.CheckBox chk_jbant6;
        public System.Windows.Forms.CheckBox chk_jbant5;
        public System.Windows.Forms.CheckBox chk_jbant4;
        public System.Windows.Forms.CheckBox chk_jbant3;
        public System.Windows.Forms.CheckBox chk_jbant2;
        public System.Windows.Forms.CheckBox chk_jbant1;
        private System.Windows.Forms.TabPage Main_Page6;
        private System.Windows.Forms.Panel panel_gb;
        private System.Windows.Forms.ComboBox com_gb_tagid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Button bt_gb_read;
        private System.Windows.Forms.TextBox txt_gb_read_data;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txt_gb_read_pwd;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txt_gb_read_len;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txt_gb_read_startaddr;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox cbb_gb_readmem;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Button bt_gb_write;
        private System.Windows.Forms.TextBox txt_gb_write_data;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.TextBox txt_gb_write_pwd;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.TextBox txt_gb_write_startaddr;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.ComboBox cbb_gb_writemem;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.ComboBox cbb_gb_locktype;
        private System.Windows.Forms.Button bt_gb_lock;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.TextBox txt_gb_lock_pwd;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.ComboBox cbb_gb_lockmem;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.Button bt_gb_erase;
        private System.Windows.Forms.TextBox txt_gb_erase_pwd;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.TextBox txt_gb_erase_num;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.TextBox txt_gb_erase_startaddr;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.ComboBox cbb_gb_erasemem;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.Button bt_gb_kill;
        private System.Windows.Forms.TextBox txt_gb_kill_pwd;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.GroupBox groupBox46;
        private System.Windows.Forms.TextBox txt_gb_maskdata;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.TextBox txt_gb_mask_startaddr;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.ComboBox cbb_gb_masktype;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.CheckBox chk_gb_mask;
        private LxControl.LxLedControl lxLed_gb_number;
        private System.Windows.Forms.Label label167;
        private LxControl.LxLedControl lxLed_gb_time;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.GroupBox groupBox54;
        private System.Windows.Forms.DataGridView dataGridView_GB;
        private System.Windows.Forms.GroupBox gbp_gb_mix;
        private System.Windows.Forms.TextBox tx_gb_readpsd;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.TextBox tx_gb_masklen;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.TextBox tx_gb_maskaddr;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.ComboBox cbb_gb_maskmem;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.GroupBox gbp_gb_ant;
        public System.Windows.Forms.CheckBox chk_gbant4;
        public System.Windows.Forms.CheckBox chk_gbant3;
        public System.Windows.Forms.CheckBox chk_gbant2;
        public System.Windows.Forms.CheckBox chk_gbant1;
        private System.Windows.Forms.GroupBox groupBox55;
        private System.Windows.Forms.ComboBox cbb_gb_scantime;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.RadioButton rb_gb_normal;
        private System.Windows.Forms.RadioButton rb_gb_mix;
        private System.Windows.Forms.Button btInventoryGB;
        public System.Windows.Forms.CheckBox chk_gbant16;
        public System.Windows.Forms.CheckBox chk_gbant15;
        public System.Windows.Forms.CheckBox chk_gbant14;
        public System.Windows.Forms.CheckBox chk_gbant13;
        public System.Windows.Forms.CheckBox chk_gbant12;
        public System.Windows.Forms.CheckBox chk_gbant11;
        public System.Windows.Forms.CheckBox chk_gbant10;
        public System.Windows.Forms.CheckBox chk_gbant9;
        public System.Windows.Forms.CheckBox chk_gbant8;
        public System.Windows.Forms.CheckBox chk_gbant7;
        public System.Windows.Forms.CheckBox chk_gbant6;
        public System.Windows.Forms.CheckBox chk_gbant5;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.GroupBox gbp_PowerAnt;
        private System.Windows.Forms.TextBox txtPower16;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.TextBox txtPower15;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.TextBox txtPower14;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.TextBox txtPower13;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.TextBox txtPower12;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.TextBox txtPower11;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.TextBox txtPower10;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.TextBox txtPower9;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.TextBox txtPower8;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.TextBox txtPower7;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.TextBox txtPower6;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.TextBox txtPower5;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.TextBox txtPower4;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.TextBox txtPower3;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.TextBox txtPower2;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.TextBox txtPower1;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.Button btGetRfPower;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btSetRfPower;
        private System.Windows.Forms.GroupBox groupBox45;
        private System.Windows.Forms.RadioButton rb_pro4;
        private System.Windows.Forms.RadioButton rb_pro3;
        private System.Windows.Forms.RadioButton rb_pro2;
        private System.Windows.Forms.RadioButton rb_pro1;
        private System.Windows.Forms.RadioButton rb_pro0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.GroupBox groupBox57;
        private System.Windows.Forms.RadioButton rb_enable;
        private System.Windows.Forms.RadioButton rb_disable;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox58;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.ComboBox com_queryInter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.ComboBox cbb_add;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.ComboBox cbb_dwell;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabPage tabPage_fastscan;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.GroupBox groupBox59;
        private LxControl.LxLedControl lxLedControl7;
        private System.Windows.Forms.Label label195;
        private LxControl.LxLedControl lxLedControl8;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.GroupBox groupBox60;
        private System.Windows.Forms.Button button9;
        private LxControl.LxLedControl lxLedControl9;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox check_phase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox checkBox_U9;
    }
}

