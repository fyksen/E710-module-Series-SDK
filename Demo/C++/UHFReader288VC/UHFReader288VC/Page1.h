#pragma once
#include "afxwin.h"
#include "afxcmn.h"


// Page1 �Ի���

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

	typedef int (__stdcall *PGetReaderInformation)(unsigned char* ComAdr,				//��д����ַ		
		unsigned char* VersionInfo,			//����汾
		unsigned char* ReaderType,				//��д���ͺ�
		unsigned char* TrType,		//֧�ֵ�Э��
		unsigned char* dmaxfre,           //��ǰ��д��ʹ�õ����Ƶ��
		unsigned char* dminfre,           //��ǰ��д��ʹ�õ����Ƶ��
		unsigned char* powerdBm,             //��д�����������
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

	Page1(CWnd* pParent = NULL);   // ��׼���캯��
	virtual ~Page1();
    
	void EnableButton();
	void DisableButton();
	void InventoryEPC();
	BOOL nFlag;
	byte AntArr[16];
	void Query(int ant); 
// �Ի�������
	enum { IDD = IDD_PAGE1 };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV ֧��

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
