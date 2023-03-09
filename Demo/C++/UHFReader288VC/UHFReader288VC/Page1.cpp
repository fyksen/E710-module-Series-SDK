// Page1.cpp : 实现文件
//

#include "stdafx.h"
#include "UHFReader288VC.h"
#include "Page1.h"
int FrmHandle;
int fcmdRet;
byte fComAddr;
BOOL InventoryFlag;
HINSTANCE g_hRRLibrary; 
// Page1 对话框

IMPLEMENT_DYNAMIC(Page1, CDialog)

Page1::Page1(CWnd* pParent /*=NULL*/)
	: CDialog(Page1::IDD, pParent)
{

}

Page1::~Page1()
{
}

void Page1::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);

	DDX_Control(pDX, IDC_LIST1, m_list1);
}


BEGIN_MESSAGE_MAP(Page1, CDialog)
	ON_BN_CLICKED(IDC_RS232, &Page1::OnBnClickedRs232)
	ON_BN_CLICKED(IDC_TCP, &Page1::OnBnClickedTcp)
	ON_BN_CLICKED(IDC_BUTTON1, &Page1::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_BUTTON2, &Page1::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BUTTON3, &Page1::OnBnClickedButton3)
	ON_BN_CLICKED(IDC_BUTTON4, &Page1::OnBnClickedButton4)//
	ON_BN_CLICKED(IDC_BUTTON6, &Page1::OnBnClickedButton6)
	ON_BN_CLICKED(IDC_BUTTON5, &Page1::OnBnClickedButton5)
	ON_WM_TIMER()
	ON_WM_SHOWWINDOW()
	ON_BN_CLICKED(IDC_CHECK14, &Page1::OnBnClickedCheck14)
END_MESSAGE_MAP()


// Page1 消息处理程序

BOOL Page1::OnInitDialog()
{
	CDialog::OnInitDialog();

	// TODO:  在此添加额外的初始化
	//Session
	int i=0;
    CString str;
	for(i=0;i<16;i++)
	{
		str.Format(_T("%d"),i);
		((CComboBox*)GetDlgItem(IDC_COMBO4))->AddString(str);	
	}
	((CComboBox*)GetDlgItem(IDC_COMBO4))->SetCurSel(4);
	//Q
	for(i=0;i<4;i++)
	{
		str.Format(_T("%d"),i);
		((CComboBox*)GetDlgItem(IDC_COMBO3))->AddString(str);	
	}
	((CComboBox*)GetDlgItem(IDC_COMBO3))->AddString(_T("AUTO"));	
	((CComboBox*)GetDlgItem(IDC_COMBO3))->SetCurSel(0);
    
	//COM
	for(i=1;i<10;i++)
	{
		str.Format(_T("%d"),i);
		((CComboBox*)GetDlgItem(IDC_COMBO1))->AddString(_T("COM")+str);	
	}
	((CComboBox*)GetDlgItem(IDC_COMBO1))->SetCurSel(0);
    //波特率
	((CComboBox*)GetDlgItem(IDC_COMBO2))->AddString(_T("9600bps"));	
	((CComboBox*)GetDlgItem(IDC_COMBO2))->AddString(_T("19200bps"));	
	((CComboBox*)GetDlgItem(IDC_COMBO2))->AddString(_T("38400bps"));	
	((CComboBox*)GetDlgItem(IDC_COMBO2))->AddString(_T("57600bps"));	
	((CComboBox*)GetDlgItem(IDC_COMBO2))->AddString(_T("115200bps"));	
    ((CComboBox*)GetDlgItem(IDC_COMBO2))->SetCurSel(3);
	
	//端口初始化
	((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(_T("27011"));
	//IP初始化
	((CEdit*)GetDlgItem(IDC_IPADDRESS1))->SetWindowText(_T("192.168.0.250"));

    //初始化列表
	m_list1.InsertColumn(0,_T("No."),LVCFMT_LEFT,80);
	m_list1.InsertColumn(1,_T("EPC"),LVCFMT_LEFT,250);
	m_list1.InsertColumn(2,_T("Length"),LVCFMT_LEFT,80);
	m_list1.InsertColumn(3,_T("RSSI"),LVCFMT_LEFT,80);
	m_list1.InsertColumn(4,_T("Times"),LVCFMT_LEFT,80);
	m_list1.SetExtendedStyle(LVS_EX_FULLROWSELECT|LVS_EX_GRIDLINES |LVS_EX_HEADERDRAGDROP);


	((CButton *)GetDlgItem(IDC_RS232))->SetCheck(1);


	g_hRRLibrary = LoadLibrary(_T("UHFReader288.dll"));

	if (g_hRRLibrary ==NULL)
		return FALSE;
	if(!(RR_OpenComPort = (POpenComPort)GetProcAddress(g_hRRLibrary,"OpenComPort")))
		return FALSE;
	if(!(RR_CloseComPort = (PCloseComPort)GetProcAddress(g_hRRLibrary,"CloseComPort")))
		return FALSE;
	if(!(RR_CloseSpecComPort = (PCloseSpecComPort)GetProcAddress(g_hRRLibrary,"CloseSpecComPort")))
		return FALSE;

	if(!(RR_GetReaderInformation = (PGetReaderInformation)GetProcAddress(g_hRRLibrary,"GetReaderInformation")))
		return FALSE;

	if(!(RR_OpenNetPort = (POpenNetPort)GetProcAddress(g_hRRLibrary,"OpenNetPort")))
		return FALSE;
	if(!(RR_CloseNetPort = (PCloseNetPort)GetProcAddress(g_hRRLibrary,"CloseNetPort")))
		return FALSE;

	if(!(RR_Inventory_G2 = (PInventory_G2)GetProcAddress(g_hRRLibrary,"Inventory_G2")))
		return FALSE;
	((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON4))->EnableWindow(FALSE);
	DisableButton();
	return TRUE;  // return TRUE unless you set the focus to a control
	// 异常: OCX 属性页应返回 FALSE
}

void Page1::EnableButton()
{
	/*((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON4))->EnableWindow(TRUE);*/
	((CButton *)GetDlgItem(IDC_BUTTON5))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON6))->EnableWindow(TRUE);
}
void Page1::DisableButton()
{
	/*((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON4))->EnableWindow(FALSE);*/
	((CButton *)GetDlgItem(IDC_BUTTON5))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON6))->EnableWindow(FALSE);
}

void Page1::InventoryEPC()
{
	BOOL ANTFLAG=FALSE;
	for(int m_index=0;m_index<8;m_index++)//遍历4天线
	{
		if(AntArr[m_index]==1)
		{
			int ant=0;
			switch(m_index)
			{
			case 0:
				ant=0x80;
				break;
			case 1:
				ant=0x81;
				break;
			case 2:
				ant=0x82;
				break;
			case 3:
				ant=0x83;
				break;
			case 4:
				ant=0x84;
				break;
			case 5:
				ant=0x85;
				break;
			case 6:
				ant=0x86;
				break;
			case 7:
				ant=0x87;
				break;
			default:
				ant=0x80;
				break;
			}
			Query(ant);
			ANTFLAG=TRUE;
		}
	}
	if(!ANTFLAG)
	{
		Query(0);
	}
}
void Page1::Query(int Ant)
{  
	byte OutAnt = 0;
	int CardNum = 0;
	int Totallen = 0;
	int EPClen=0;
	int m=0;
	byte EPC[20000];
	int CardIndex;
	CString temps, temp,sEPC;
	byte MaskMem = 0;
	byte MaskAdr[2];
	byte MaskLen = 0;
	byte MaskData[100];
	byte MaskFlag = 0;
	byte AdrTID = 0;
	byte LenTID = 0;
	BYTE TIDFlag=0;//询查EPC
	BYTE Target=0;
	byte Scantime=20;
	byte FastFlag=0;
	MaskFlag = 0;
	CardNum = 0;
	byte InAnt=Ant;
	BYTE Qvalue= ((CComboBox*)GetDlgItem(IDC_COMBO4))->GetCurSel();
	BYTE Session= ((CComboBox*)GetDlgItem(IDC_COMBO3))->GetCurSel();
	if(Session==4)
		Session=255;
	if(Ant==0)
	{
		FastFlag=0;
	}
	else
	{
		FastFlag=1;
	}
	if(((CButton *)GetDlgItem(IDC_CHECK5))->GetCheck()==1)
	{
		AdrTID=0;
		LenTID=6;
		TIDFlag=1;
	}
	fcmdRet = RR_Inventory_G2(&fComAddr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, EPC, &OutAnt, &Totallen, &CardNum, FrmHandle);
	if(CardNum>0)
	{
		m = 1;
		if (CardNum == 0)
		{
			return;
		}
		for (CardIndex = 0 ;CardIndex<CardNum;CardIndex++)
		{
			temp=_T("");
			temps=_T("");
			BOOL EPCflag = FALSE;
			EPClen = EPC[m - 1];
			byte EPC1[250];
			memcpy(EPC1,&EPC[m], EPClen);
			byte RSSI=EPC[m+EPClen];
			m = m + EPClen + 2;
			//得到标签的EPC号
			for(int n=0;n<EPClen;n++)
			{
				temp.Format(_T("%02X"),EPC1[n]);
				temps=temps+temp;
			}
			BOOL inList=FALSE;
			for(int p=0;p<m_list1.GetItemCount();p++)
			{
				if(m_list1.GetItemText(p,1)==temps)//如果存在，次数加一
				{
					inList=TRUE;
					int m=(int)_tcstol(m_list1.GetItemText(p,4),NULL,10);
					m++;
					CString str_count;

					str_count.Format(_T("%d"),RSSI);
					m_list1.SetItemText(p,3,str_count);//RSSI

					str_count.Format(_T("%d"),m);
					m_list1.SetItemText(p,4,str_count);//次数
				}
			}
			if(!inList)//不存在插入列表
			{
				CString str_ID;
				int index=m_list1.GetItemCount();
				//序号
				str_ID.Format(_T("%d"),index+1);
				m_list1.InsertItem(index,str_ID);
				//EPC
				m_list1.SetItemText(index,1,temps);
                //长度
                str_ID.Format(_T("%d"),EPClen);
				m_list1.SetItemText(index,2,str_ID);
                //RSSI
				str_ID.Format(_T("%d"),RSSI);
				m_list1.SetItemText(index,3,str_ID);
				//次数
				m_list1.SetItemText(index,4,_T("1"));
				m_list1.EnsureVisible(index, FALSE);
			}
		}
	}

}  
void Page1::OnBnClickedRs232()
{
	// TODO: 在此添加控件通知处理程序代码
	OnBnClickedButton4();
	((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON4))->EnableWindow(FALSE);
}

void Page1::OnBnClickedTcp()
{
	OnBnClickedButton2();
	((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON4))->EnableWindow(FALSE);
	// TODO: 在此添加控件通知处理程序代码
}

void Page1::OnBnClickedButton1()//打开串口
{
	// TODO: 在此添加控件通知处理程序代码
	CString strip;
	CString str;
	fComAddr=255;
	FrmHandle=0;
	strip="";
	int port=((CComboBox*)GetDlgItem(IDC_COMBO1))->GetCurSel()+1;
	byte baud=((CComboBox*)GetDlgItem(IDC_COMBO2))->GetCurSel();
	if(baud>2)baud=baud+2;
	fcmdRet=RR_OpenComPort(port,&fComAddr,baud,&FrmHandle);
	if(fcmdRet==0)
	{
		EnableButton();
		((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(FALSE);
		((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(TRUE);
		((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(FALSE);
		((CButton *)GetDlgItem(IDC_BUTTON4))->EnableWindow(FALSE);
		MessageBox(_T("Success"),_T("Info"),0);
	}
	else
	{
		MessageBox(_T("Failed"),_T("Info"),0);
	}
}

void Page1::OnBnClickedButton2()//关闭串口
{
	//if((FrmHandle>0)&&(FrmHandle<256))
	{
		fcmdRet=RR_CloseSpecComPort(FrmHandle);
		((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(TRUE);
		((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(FALSE);
		((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(FALSE);
		((CButton *)GetDlgItem(IDC_BUTTON4))->EnableWindow(FALSE);
		FrmHandle=-1;
		DisableButton();
	}
	// TODO: 在此添加控件通知处理程序代码
}

void Page1::OnBnClickedButton3()//打开网口
{
	// TODO: 在此添加控件通知处理程序代码

	CString strip;
	CString str;
	fComAddr=255;
	FrmHandle=0;
	strip="";
	GetDlgItemText(IDC_EDIT2,str);
	int port=_tcstol(str,NULL,10);
	GetDlgItemText(IDC_IPADDRESS1,strip);
	DWORD dwFileNameCharNum = WideCharToMultiByte(CP_OEMCP,NULL,strip.GetBuffer(strip.GetLength()),-1,NULL,0,NULL,FALSE);
	char *ip = new char[dwFileNameCharNum+1];
	WideCharToMultiByte (CP_OEMCP,NULL,strip.GetBuffer(strip.GetLength()),-1,ip,dwFileNameCharNum,NULL,FALSE);
	ip[dwFileNameCharNum]='\0';

	fcmdRet=RR_OpenNetPort(port,ip, &fComAddr,&FrmHandle);
	if(fcmdRet==0)
	{
		EnableButton();
		((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(FALSE);
		((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(FALSE);
		((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(FALSE);
		((CButton *)GetDlgItem(IDC_BUTTON4))->EnableWindow(TRUE);
		MessageBox(_T("Success"),_T("Info"),0);
	}
	else
	{
		MessageBox(_T("Failed"),_T("Info"),0);
	}
}

void Page1::OnBnClickedButton4()//关闭网口
{
	// TODO: 在此添加控件通知处理程序代码
	if((FrmHandle>0)&&(FrmHandle<256))
	{
		fcmdRet=RR_CloseNetPort(FrmHandle);
		((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(FALSE);
		((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(FALSE);
		((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(TRUE);
		((CButton *)GetDlgItem(IDC_BUTTON4))->EnableWindow(FALSE);
		FrmHandle=-1;
		DisableButton();
	}
}

void Page1::OnBnClickedButton6()
{
	// TODO: 在此添加控件通知处理程序代码

	CString str;
	((CButton *)GetDlgItem(IDC_BUTTON6))->GetWindowText(str);
	if(str=="Start")
	{
		((CButton *)GetDlgItem(IDC_BUTTON6))->SetWindowText(_T("Stop"));
		m_list1.DeleteAllItems();
		nFlag=FALSE;
		memset(AntArr,0,16);
		if(((CButton *)GetDlgItem(IDC_CHECK1))->GetCheck())
			AntArr[0]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK2))->GetCheck())
			AntArr[1]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK3))->GetCheck())
			AntArr[2]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK4))->GetCheck())
			AntArr[3]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK6))->GetCheck())
			AntArr[4]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK7))->GetCheck())
			AntArr[5]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK8))->GetCheck())
			AntArr[6]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK9))->GetCheck())
			AntArr[7]=1;

		if(((CButton *)GetDlgItem(IDC_CHECK12))->GetCheck())
			AntArr[8]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK13))->GetCheck())
			AntArr[9]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK14))->GetCheck())
			AntArr[10]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK15))->GetCheck())
			AntArr[11]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK16))->GetCheck())
			AntArr[12]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK17))->GetCheck())
			AntArr[13]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK18))->GetCheck())
			AntArr[14]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK19))->GetCheck())
			AntArr[15]=1;
		str.Empty();
		SetTimer(2,5,NULL);
	}
	else
	{
		((CButton *)GetDlgItem(IDC_BUTTON6))->SetWindowText(_T("Start"));
		KillTimer(2);
	}
}

void Page1::OnBnClickedButton5()
{
	// TODO: 在此添加控件通知处理程序代码
	m_list1.DeleteAllItems();
	nFlag=FALSE;
}

void Page1::OnTimer(UINT_PTR nIDEvent)
{
	// TODO: 在此添加消息处理程序代码和/或调用默认值
    if(nIDEvent==2)
	{
		if(nFlag)
			return;
		nFlag=TRUE;
		InventoryEPC();
		nFlag=FALSE;
	}
	CDialog::OnTimer(nIDEvent);
}

void Page1::OnShowWindow(BOOL bShow, UINT nStatus)
{
	CDialog::OnShowWindow(bShow, nStatus);

	KillTimer(2);
	((CButton *)GetDlgItem(IDC_BUTTON6))->SetWindowText(_T("Start"));
	// TODO: 在此处添加消息处理程序代码
}

void Page1::OnBnClickedCheck14()
{
	// TODO: 在此添加控件通知处理程序代码
}
