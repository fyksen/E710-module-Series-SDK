#pragma once
#include "afxwin.h"
#include "afxcmn.h"


// Page1 对话框

class Page1 : public CDialog
{
	DECLARE_DYNAMIC(Page1)

public:
	typedef int (__stdcall *PAutoOpenComPort)(int *port, 
		unsigned char *address,
		unsigned char Baud,
		int *Frmhandle);
	typedef int (__stdcall *POpenComPort)(int port,
		unsigned char *address,
		unsigned char Baud,
		int *Frmhandle);
	typedef int (__stdcall *PCloseComPort)();

	typedef int (__stdcall *POpenNetPort)(int Port,
		LPSTR IPaddr,
		unsigned char*ComAdr,
		int *Frmhandle);
	typedef int (__stdcall *PCloseNetPort)(int FrmHandle);

	typedef int (__stdcall *PCloseSpecComPort)(int Frmhandle);

	typedef int (__stdcall *PGetReaderInformation)(unsigned char* ComAdr,				//读写器地址		
		unsigned char* VersionInfo,			//软件版本
		unsigned char* ReaderType,				//读写器型号
		unsigned char* TrType,		//支持的协议
		unsigned char* dmaxfre,           //当前读写器使用的最高频率
		unsigned char* dminfre,           //当前读写器使用的最低频率
		unsigned char* powerdBm,             //读写器的输出功率
		unsigned char* ScanTime,
		unsigned char*Ant,
		unsigned char*BeepEn,
		unsigned char*OutputRep,
		unsigned char*CheckAnt,
		int FrmHandle);
	typedef int (__stdcall *PInventory_G2)(unsigned char *address,
		unsigned char QValue,
		unsigned char Session,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		unsigned char MaskFlag,
		unsigned char AdrTID,
		unsigned char LenTID,
		unsigned char TIDFlag,
		unsigned char Target,
		unsigned char InAnt,
		unsigned char Scantime,
		unsigned char FastFlag,
		unsigned char *pEPCList,
		unsigned char *Ant,
		int *Totallen,		
		int *CardNum,
		int FrmHandle);




	PAutoOpenComPort        RR_AutoOpenComPort; 
	POpenComPort            RR_OpenComPort;
	PCloseComPort           RR_CloseComPort;
	PCloseSpecComPort       RR_CloseSpecComPort;
	POpenNetPort            RR_OpenNetPort;
	PCloseNetPort           RR_CloseNetPort;
	PGetReaderInformation   RR_GetReaderInformation;
	PInventory_G2           RR_Inventory_G2;

	Page1(CWnd* pParent = NULL);   // 标准构造函数
	virtual ~Page1();
    
	void EnableButton();
	void DisableButton();
	void InventoryEPC();
	BOOL nFlag;
	byte AntArr[16];
	void Query(int ant); 
// 对话框数据
	enum { IDD = IDD_PAGE1 };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支持

	DECLARE_MESSAGE_MAP()
public:

	CListCtrl m_list1;
	virtual BOOL OnInitDialog();
	afx_msg void OnBnClickedRs232();
	afx_msg void OnBnClickedTcp();
	afx_msg void OnBnClickedButton1();
	afx_msg void OnBnClickedButton2();
	afx_msg void OnBnClickedButton3();
	afx_msg void OnBnClickedButton4();
	afx_msg void OnBnClickedButton6();
	afx_msg void OnBnClickedButton5();
	afx_msg void OnTimer(UINT_PTR nIDEvent);
	afx_msg void OnShowWindow(BOOL bShow, UINT nStatus);
	afx_msg void OnBnClickedCheck14();
};
