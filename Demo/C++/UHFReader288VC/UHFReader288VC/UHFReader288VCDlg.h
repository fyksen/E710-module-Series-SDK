// UHFReader288VCDlg.h : 头文件
//

#pragma once
#include "afxcmn.h"
#include "Page1.h"
#include "Page2.h"

// CUHFReader288VCDlg 对话框
class CUHFReader288VCDlg : public CDialog
{
// 构造
public:
	CUHFReader288VCDlg(CWnd* pParent = NULL);	// 标准构造函数

// 对话框数据
	enum { IDD = IDD_UHFReader288VC_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 支持


// 实现
protected:
	HICON m_hIcon;

	// 生成的消息映射函数
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
