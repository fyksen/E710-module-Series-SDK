#pragma once
#include "afxcmn.h"


// Page2 对话框

class Page2 : public CDialog
{
	DECLARE_DYNAMIC(Page2)

public:

	typedef int (__stdcall *PInventoryBuffer_G2)(unsigned char *address,
		unsigned char QValue,
		unsigned char Session,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		unsigned char MaskFlag,
		unsigned char AdrTID,
		unsigned char LenTID,
		unsigned char TIDFlag,///////////
		unsigned char Target,
		unsigned char InAnt,
		unsigned char Scantime,
		unsigned char FastFlag,///////////////
		int *BufferCount,		
		int *TagNum,
		int FrmHandle);

	typedef int (__stdcall *PReadBuffer_G2)(unsigned char *ComAdr,
		int *Totallen,
		int *CardNum,
		unsigned char *pEPCList,
		int FrmHandle);
	typedef int (__stdcall *PClearBuffer_G2)(unsigned char *ComAdr,
		int FrmHandle);
	typedef int (__stdcall *PGetBufferCnt_G2)(unsigned char *ComAdr,
		int *Count,
		int FrmHandle);




	PInventoryBuffer_G2        RR_InventoryBuffer_G2; 
	PReadBuffer_G2             RR_ReadBuffer_G2;
	PClearBuffer_G2            RR_ClearBuffer_G2;
	PGetBufferCnt_G2           RR_GetBufferCnt_G2;
	Page2(CWnd* pParent = NULL);   // 标准构造函数
	virtual ~Page2();
	byte AntArr[16];
	BOOL nFlag;
	void EnableButton();
	void DisableButton();
	void InventoryEPC();
// 对话框数据
	enum { IDD = IDD_PAGE2 };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支持

	DECLARE_MESSAGE_MAP()
public:
	virtual BOOL OnInitDialog();
	CListCtrl m_list2;
	afx_msg void OnBnClickedButton1();
	afx_msg void OnShowWindow(BOOL bShow, UINT nStatus);
	afx_msg void OnTimer(UINT_PTR nIDEvent);
	afx_msg void OnBnClickedButton2();
	afx_msg void OnBnClickedButton3();
	afx_msg void OnBnClickedButton7();
	afx_msg void OnBnClickedButton8();
	afx_msg void OnBnClickedButton5();
	afx_msg void OnBnClickedCheck17();
	afx_msg void OnBnClickedCheck18();
};
