// Page2.cpp : 实现文件
//

#include "stdafx.h"
#include "UHFReader288VC.h"
#include "Page1.h"
#include "Page2.h"
extern int FrmHandle;
extern int fcmdRet;
extern byte fComAddr;
BOOL nFlag;

// Page2 对话框

IMPLEMENT_DYNAMIC(Page2, CDialog)

Page2::Page2(CWnd* pParent /*=NULL*/)
	: CDialog(Page2::IDD, pParent)
{

}

Page2::~Page2()
{
}

void Page2::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_LIST3, m_list2);
}


BEGIN_MESSAGE_MAP(Page2, CDialog)
	ON_BN_CLICKED(IDC_BUTTON1, &Page2::OnBnClickedButton1)
	ON_WM_SHOWWINDOW()
	ON_WM_TIMER()
	ON_BN_CLICKED(IDC_BUTTON2, &Page2::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BUTTON3, &Page2::OnBnClickedButton3)
	ON_BN_CLICKED(IDC_BUTTON7, &Page2::OnBnClickedButton7)
	ON_BN_CLICKED(IDC_BUTTON8, &Page2::OnBnClickedButton8)
	ON_BN_CLICKED(IDC_BUTTON5, &Page2::OnBnClickedButton5)
	ON_BN_CLICKED(IDC_CHECK17, &Page2::OnBnClickedCheck17)
	ON_BN_CLICKED(IDC_CHECK18, &Page2::OnBnClickedCheck18)
END_MESSAGE_MAP()


// Page2 消息处理程序

BOOL Page2::OnInitDialog()
{
	CDialog::OnInitDialog();

	// TODO:  在此添加额外的初始化
    ((CButton *)GetDlgItem(IDC_RADIO1))->SetCheck(1);
	((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(_T("0"));
	m_list2.InsertColumn(0,_T("No."),LVCFMT_LEFT,80);
	m_list2.InsertColumn(1,_T("EPC"),LVCFMT_LEFT,350);
	m_list2.InsertColumn(2,_T("Length"),LVCFMT_LEFT,80);
	m_list2.InsertColumn(3,_T("RSSI"),LVCFMT_LEFT,80);
	m_list2.InsertColumn(4,_T("Times"),LVCFMT_LEFT,80);
	m_list2.SetExtendedStyle(LVS_EX_FULLROWSELECT|LVS_EX_GRIDLINES |LVS_EX_HEADERDRAGDROP);

	HINSTANCE g_hRRLibrary = LoadLibrary(_T("UHFReader288.dll"));
	if(!(RR_InventoryBuffer_G2 = (PInventoryBuffer_G2)GetProcAddress(g_hRRLibrary,"InventoryBuffer_G2")))
		return FALSE;
	if(!(RR_ReadBuffer_G2 = (PReadBuffer_G2)GetProcAddress(g_hRRLibrary,"ReadBuffer_G2")))
		return FALSE;
	if(!(RR_ClearBuffer_G2 = (PClearBuffer_G2)GetProcAddress(g_hRRLibrary,"ClearBuffer_G2")))
		return FALSE;
	if(!(RR_GetBufferCnt_G2 = (PGetBufferCnt_G2)GetProcAddress(g_hRRLibrary,"GetBufferCnt_G2")))
		return FALSE;

	((CButton *)GetDlgItem(IDC_RADIO1))->SetCheck(1);

	((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(_T("0"));
	return TRUE;  // return TRUE unless you set the focus to a control
	// 异常: OCX 属性页应返回 FALSE
}
void Page2::EnableButton()
{
	((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(TRUE);
	//((CButton *)GetDlgItem(IDC_BUTTON5))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON7))->EnableWindow(TRUE);
	((CButton *)GetDlgItem(IDC_BUTTON8))->EnableWindow(TRUE);
}
void Page2::DisableButton()
{
	((CButton *)GetDlgItem(IDC_BUTTON1))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON2))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON3))->EnableWindow(FALSE);
	//((CButton *)GetDlgItem(IDC_BUTTON5))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON7))->EnableWindow(FALSE);
	((CButton *)GetDlgItem(IDC_BUTTON8))->EnableWindow(FALSE);
}
void Page2::OnBnClickedButton1()
{
	// TODO: 在此添加控件通知处理程序代码
	CString str;
	((CButton *)GetDlgItem(IDC_BUTTON1))->GetWindowText(str);
	if(str=="Start")
	{
		((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(_T("0"));
		((CButton *)GetDlgItem(IDC_BUTTON1))->SetWindowText(_T("Stop"));
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

		if(((CButton *)GetDlgItem(IDC_CHECK10))->GetCheck())
			AntArr[4]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK11))->GetCheck())
			AntArr[5]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK7))->GetCheck())
			AntArr[6]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK8))->GetCheck())
			AntArr[7]=1;

		if(((CButton *)GetDlgItem(IDC_CHECK19))->GetCheck())
			AntArr[8]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK20))->GetCheck())
			AntArr[9]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK21))->GetCheck())
			AntArr[10]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK22))->GetCheck())
			AntArr[11]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK23))->GetCheck())
			AntArr[12]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK24))->GetCheck())
			AntArr[13]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK25))->GetCheck())
			AntArr[14]=1;
		if(((CButton *)GetDlgItem(IDC_CHECK26))->GetCheck())
			AntArr[15]=1;

		//str_EPC.Empty();
		SetTimer(5,10,NULL);
	}
	else
	{
		((CButton *)GetDlgItem(IDC_BUTTON1))->SetWindowText(_T("Start"));
		KillTimer(5);
	}
}

void Page2::OnShowWindow(BOOL bShow, UINT nStatus)
{
	CDialog::OnShowWindow(bShow, nStatus);
	if((FrmHandle>0)&&(FrmHandle<65535))
	{
		EnableButton();
	}
	else
	{
		DisableButton();
	}
	((CButton *)GetDlgItem(IDC_BUTTON1))->SetWindowText(_T("Start"));
	KillTimer(5);
	// TODO: 在此处添加消息处理程序代码
}

void Page2::OnTimer(UINT_PTR nIDEvent)
{
	// TODO: 在此添加消息处理程序代码和/或调用默认值
    if(nIDEvent==5)
	{
		if(nFlag)
			return;
		nFlag=TRUE;
		InventoryEPC();
		nFlag=FALSE;
	}
	CDialog::OnTimer(nIDEvent);
}
void Page2::InventoryEPC()
{
	byte OutAnt = 0;
	int CardNum = 0;
	int Totallen = 0;
	int EPClen=0;
	int m=0;
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
	byte FastFlag=1;//快速查询
	MaskFlag = 0;
	byte InAnt=0;
	int BufferCount=0, TagNum=0;
	byte Qvalue=4;
	byte Session=0;
	AdrTID=0;
	LenTID=6;
	if(((CButton *)GetDlgItem(IDC_RADIO1))->GetCheck()==1)//EPC查询
	{
		Session=255;
		TIDFlag=0 ;
	}
	else
	{
		Session=1;
		TIDFlag=1;
	}
	BOOL selectant=FALSE;
	for(int p=0;p<8;p++)
	{
		if(AntArr[p]==1)
		{
			selectant=TRUE;
			break;
		}
	}
	if(!selectant)
	{
		FastFlag=0;
		fcmdRet = RR_InventoryBuffer_G2(&fComAddr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, &BufferCount, &TagNum, FrmHandle);
		if(fcmdRet==0)
		{
			CString temp;
			temp.Format(_T("%d"),BufferCount);
			((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(temp);
		}
		return;
	}
	if(AntArr[0]==1)
	{
		InAnt=0x80;
		fcmdRet = RR_InventoryBuffer_G2(&fComAddr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, &BufferCount, &TagNum, FrmHandle);
		if(fcmdRet==0)
		{
			CString temp;
			temp.Format(_T("%d"),BufferCount);
			((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(temp);
		}
	}
	
	if(AntArr[1]==1)
	{
		InAnt=0x81;
		fcmdRet = RR_InventoryBuffer_G2(&fComAddr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, &BufferCount, &TagNum, FrmHandle);
		if(fcmdRet==0)
		{
			CString temp;
			temp.Format(_T("%d"),BufferCount);
			((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(temp);
		}
	}
	if(AntArr[2]==1)
	{
		InAnt=0x82;
		fcmdRet = RR_InventoryBuffer_G2(&fComAddr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, &BufferCount, &TagNum, FrmHandle);
		if(fcmdRet==0)
		{
			CString temp;
			temp.Format(_T("%d"),BufferCount);
			((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(temp);
		}
	}
	if(AntArr[3]==1)
	{
		InAnt=0x83;
		fcmdRet = RR_InventoryBuffer_G2(&fComAddr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, &BufferCount, &TagNum, FrmHandle);
		if(fcmdRet==0)
		{
			CString temp;
			temp.Format(_T("%d"),BufferCount);
			((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(temp);
		}
	}

	if(AntArr[4]==1)
	{
		InAnt=0x84;
		fcmdRet = RR_InventoryBuffer_G2(&fComAddr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, &BufferCount, &TagNum, FrmHandle);
		if(fcmdRet==0)
		{
			CString temp;
			temp.Format(_T("%d"),BufferCount);
			((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(temp);
		}
	}

	if(AntArr[5]==1)
	{
		InAnt=0x85;
		fcmdRet = RR_InventoryBuffer_G2(&fComAddr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, &BufferCount, &TagNum, FrmHandle);
		if(fcmdRet==0)
		{
			CString temp;
			temp.Format(_T("%d"),BufferCount);
			((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(temp);
		}
	}

	if(AntArr[6]==1)
	{
		InAnt=0x86;
		fcmdRet = RR_InventoryBuffer_G2(&fComAddr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, &BufferCount, &TagNum, FrmHandle);
		if(fcmdRet==0)
		{
			CString temp;
			temp.Format(_T("%d"),BufferCount);
			((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(temp);
		}
	}

	if(AntArr[7]==1)
	{
		InAnt=0x87;
		fcmdRet = RR_InventoryBuffer_G2(&fComAddr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, &BufferCount, &TagNum, FrmHandle);
		if(fcmdRet==0)
		{
			CString temp;
			temp.Format(_T("%d"),BufferCount);
			((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(temp);
		}
	}
}

void Page2::OnBnClickedButton2()
{
	// TODO: 在此添加控件通知处理程序代码
	m_list2.DeleteAllItems();
	int Totallen=0;
	int CardNum=0;
	byte pEPCList[20000];
	fcmdRet = RR_ReadBuffer_G2(&fComAddr, &Totallen,&CardNum,pEPCList, FrmHandle);
	if(fcmdRet==1)
	{
		int m = 2;
		if (CardNum == 0)
		{
			return;
		}
		for (int CardIndex = 0 ;CardIndex<CardNum;CardIndex++)
		{
			CString temp=_T("");
			CString temps=_T("");
			BOOL EPCflag = FALSE;
			int EPClen = pEPCList[m];
			byte EPC1[250];
			memcpy(EPC1,&pEPCList[m+1], EPClen);
			byte RSSI=pEPCList[m+EPClen+1];
			byte ncount=pEPCList[m+EPClen+2];
			m = m + EPClen + 5;
			//得到标签的EPC号
			for(int n=0;n<EPClen;n++)
			{
				temp.Format(_T("%02X"),EPC1[n]);
				temps=temps+temp;
			}
			CString str_ID;
			int index=m_list2.GetItemCount();
			//序号
			str_ID.Format(_T("%d"),index+1);
			m_list2.InsertItem(index,str_ID);
			//EPC
			m_list2.SetItemText(index,1,temps);
			//长度
			str_ID.Format(_T("%d"),EPClen);
			m_list2.SetItemText(index,2,str_ID);
			//RSSI
			str_ID.Format(_T("%d"),RSSI);
			m_list2.SetItemText(index,3,str_ID);
			//次数
			str_ID.Format(_T("%d"),ncount);
			m_list2.SetItemText(index,4,str_ID);
			m_list2.EnsureVisible(index, FALSE);
		}
	}
}

void Page2::OnBnClickedButton3()
{
	// TODO: 在此添加控件通知处理程序代码
	fcmdRet = RR_ClearBuffer_G2(&fComAddr, FrmHandle);
}

void Page2::OnBnClickedButton7()
{
	// TODO: 在此添加控件通知处理程序代码
	OnBnClickedButton2();//读取缓存
	OnBnClickedButton3();//清空缓存
}

void Page2::OnBnClickedButton8()
{
	// TODO: 在此添加控件通知处理程序代码
	int Count=0;
	fcmdRet=RR_GetBufferCnt_G2(&fComAddr,&Count,FrmHandle);
	if(fcmdRet==0)
	{
		CString temp;
		temp.Format(_T("%d"),Count);
		((CEdit*)GetDlgItem(IDC_EDIT2))->SetWindowText(temp);
	}
}

void Page2::OnBnClickedButton5()
{
	// TODO: 在此添加控件通知处理程序代码
	m_list2.DeleteAllItems();
}

void Page2::OnBnClickedCheck17()
{
	// TODO: 在此添加控件通知处理程序代码
}

void Page2::OnBnClickedCheck18()
{
	// TODO: 在此添加控件通知处理程序代码
}
