// UHFReader288VCDlg.h : ͷ�ļ�
//

#pragma once
#include "afxcmn.h"
#include "Page1.h"
#include "Page2.h"

// CUHFReader288VCDlg �Ի���
class CUHFReader288VCDlg : public CDialog
{
// ����
public:
	CUHFReader288VCDlg(CWnd* pParent = NULL);	// ��׼���캯��

// �Ի�������
	enum { IDD = IDD_UHFReader288VC_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV ֧��


// ʵ��
protected:
	HICON m_hIcon;

	// ���ɵ���Ϣӳ�亯��
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	CTabCtrl m_tab;
	Page1 m_page1;
	Page2 m_page2;
	CStatusBar m_statusbar;
	int m_handle;
	afx_msg void OnTcnSelchangeTab1(NMHDR *pNMHDR, LRESULT *pResult);
};
