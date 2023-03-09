using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UHF;
namespace UHFReader288Demo
{
    public partial class ParamSetting : Form
    {
        public ParamSetting()
        {
            InitializeComponent();
        }
        byte ComAddr;
        int FrmHandle;

        private void button1_Click(object sender, EventArgs e)
        {
            byte opt = 0x01;
            if (checkBox1.Checked) opt = 0x00;
            else opt = 0x01;
            byte cfgNum = 0x09;
            byte[] data = new byte[256];
            int len = 2;
            data[0] = (byte)com_MQ.SelectedIndex;
            if (checkBox2.Checked) data[0] |= 0x10;
            data[1] = (byte)com_MS.SelectedIndex;
            int fCmdRet = RWDev.SetCfgParameter(ref ComAddr, opt, cfgNum, data, len, FrmHandle);
            if (fCmdRet==0)
            {
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Set success";
            }
            else
            {
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Set failed";
            }
        }

        private void ParamSetting_Load(object sender, EventArgs e)
        {
            FrmHandle = Form1.frmcomportindex;
            ComAddr = Form1.fComAdr;
            com_MQ.SelectedIndex = 6;
            com_MS.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte cfgNum = 0x09;
            byte[] data = new byte[256];
            int len = 0;
            int fCmdRet = RWDev.GetCfgParameter(ref ComAddr, cfgNum, data,ref len, FrmHandle);
            if (fCmdRet == 0)
            {
                com_MQ.SelectedIndex = data[0] & 0x0F;
                if ((data[0] & 0x10) > 0)
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
                if (data[1] < 4) com_MS.SelectedIndex = data[1];
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Read success";
            }
            else
            {
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Read failed";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte opt = 0x01;
            if (checkBox1.Checked) opt = 0x00;
            else opt = 0x01;
            byte cfgNum = 0x0A;
            byte[] data = new byte[256];
            int len = 2;
            data[0] = Convert.ToByte(txt_mtidaddr.Text,16);
            data[1] = Convert.ToByte(txt_Mtidlen.Text, 16);
            int fCmdRet = RWDev.SetCfgParameter(ref ComAddr, opt, cfgNum, data, len, FrmHandle);
            if (fCmdRet == 0)
            {
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Set success";
            }
            else
            {
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Set failed";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte cfgNum = 0x0A;
            byte[] data = new byte[256];
            int len = 0;
            int fCmdRet = RWDev.GetCfgParameter(ref ComAddr, cfgNum, data, ref len, FrmHandle);
            if (fCmdRet == 0)
            {
                txt_mtidaddr.Text = Convert.ToString(data[0],16).PadLeft(2,'0');
                txt_Mtidlen.Text = Convert.ToString(data[1], 16).PadLeft(2, '0');
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Read success";
            }
            else
            {
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Read failed";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte opt = 0x01;
            if (checkBox1.Checked) opt = 0x00;
            else opt = 0x01;
            byte cfgNum = 0x0B;
            byte[] data = new byte[256];
            int len = 0;
            if (RBM_EPC.Checked)
                data[len] = 1;
            else if (RBM_TID.Checked)
                data[len] = 2;
            else if (RBM_USER.Checked)
                data[len] = 3;
            len++;
            int MaskAddr = Convert.ToInt32(txt_Maddr.Text, 16);
            data[len] = (byte)(MaskAddr >> 8);
            len++;
            data[len] = (byte)(MaskAddr & 255);
            len++;
            int MaskLen = Convert.ToInt32(txt_Mlen.Text, 16);
            data[len] = (byte)MaskLen;
            len++;
            int datalen = (byte)((MaskLen + 7) / 8);
            byte[] MaskData = RWDev.HexStringToByteArray(txt_Mdata.Text);
            if (MaskData!=null && MaskData.Length < datalen) return;
            if (MaskData!=null)
                Array.Copy(MaskData, 0, data, len, datalen);
            len += datalen;
            int fCmdRet = RWDev.SetCfgParameter(ref ComAddr, opt, cfgNum, data, len, FrmHandle);
            if (fCmdRet == 0)
            {
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Set success";
            }
            else
            {
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Set failed";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte cfgNum = 0x0B;
            byte[] data = new byte[256];
            int len = 0;
            int fCmdRet = RWDev.GetCfgParameter(ref ComAddr, cfgNum, data, ref len, FrmHandle);
            if (fCmdRet == 0)
            {
                if (data[0] == 1)
                    RBM_EPC.Checked = true;
                else if(data[0] == 2)
                    RBM_TID.Checked = true;
                else if(data[0] == 3)
                    RBM_USER.Checked = true;
                txt_Maddr.Text = Convert.ToString(data[1] * 256 + data[2], 16).PadLeft(4, '0');

                txt_Mlen.Text = Convert.ToString(data[3], 16).PadLeft(2, '0');
                if (data[3]>0)
                {
                    byte[] daw = new byte[len-4];
                    Array.Copy(data, 4, daw, 0, daw.Length);
                    txt_Mdata.Text = RWDev.ByteArrayToHexString(daw);
                }
                else
                {
                    txt_Mdata.Text = "";
                }
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Read success";
            }
            else
            {
                StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " Read failed";
            }
        }
    }
}
