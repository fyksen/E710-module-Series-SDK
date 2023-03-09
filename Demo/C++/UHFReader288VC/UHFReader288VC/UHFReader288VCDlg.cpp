// UHFReader288VCDlg.cpp : 实现文件
//

#include "stdafx.h"
#include "UHFReader288VC.h"
#include "UHFReader288VCDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// 用于应用程序“关于”菜单项的 CAboutDlg 对话框

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// 对话框数据
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支持

// 实现
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
END_MESSAGE_MAP()


// CUHFReader288VCDlg 对话框




CUHFReader288VCDlg::CUHFReader288VCDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CUHFReader288VCDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CUHFReader288VCDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_TAB1, m_tab);
}

BEGIN_MESSAGE_MAP(CUHFReader288VCDlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_NOTIFY(TCN_SELCHANGE, IDC_TAB1, &CUHFReader288VCDlg::OnTcnSelchangeTab1)
END_MESSAGE_MAP()


// CUHFReader288VCDlg 消息处理程序

BOOL CUHFReader288VCDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// 将“关于...”菜单项添加到系统菜单中。

	// IDM_ABOUTBOX 必须在系统命令范围内。
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// 设置此对话框的图标。当应用程序主窗口不是对话框时，框架将自动
	//  执行此操作
	SetIcon(m_hIcon, TRUE);			// 设置大图标
	SetIcon(m_hIcon, FALSE);		// 设置小图标
	m_tab.InsertItem(0,_T("Inventory"));
	

	m_page1.Create(IDD_PAGE1,GetDlgItem(IDC_TAB1));
	
	m_page1.ShowWindow(TRUE);


	CRect rs;
	m_tab.GetClientRect(&rs);
	//调整子对话框在父窗口中的位置
	rs.top+=23; 
	rs.bottom-=2; 
	rs.left+=4;
	rs.right-=3; 
	//设置子对话框尺寸并移动到指定位置
	m_page1.MoveWindow(&rs);
	m_page2.MoveWindow(&rs);
	m_tab.SetCurSel(0); 
	// TODO: 在此添加额外的初始化代码
	UINT arr[3];
	int i=0;
	for(i=0;i<3;i++)
	{
		arr[i]=200+i;
	}
	m_statusbar.Create(this);
	m_statusbar.SetIndicators(arr,sizeof(arr)/sizeof(UINT));
	for(i=0;i<3;i++)
	{
		m_statusbar.SetPaneInfo(i,arr[i],0,200);
	}
	m_statusbar.SetPaneInfo(2,arr[2],0,300);
	RepositionBars(AFX_IDW_CONTROLBAR_FIRST,AFX_IDW_CONTROLBAR_LAST,0);
	// TODO: 在此添加额外的初始化代码

	return TRUE;  // 除非将焦点设置到控件，否则返回 TRUE
}

void CUHFReader288VCDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// 如果向对话框添加最小化按钮，则需要下面的代码
//  来绘制该图标。对于使用文档/视图模型的 MFC 应用程序，
//  这将由框架自动完成。

void CUHFReader288VCDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // 用于绘制的设备上下文

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// 使图标在工作区矩形中居中
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// 绘制图标
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

//当用户拖动最小化窗口时系统调用此函数取得光标
//显示。
HCURSOR CUHFReader288VCDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


void CUHFReader288VCDlg::OnTcnSelchangeTab1(NMHDR *pNMHDR, LRESULT *pResult)
{
	// TODO: 在此添加控件通知处理程序代码
	int CurSel = m_tab.GetCurSel();
	switch(CurSel)
	{
	case 0:
		m_page1.ShowWindow(true);
		m_page2.ShowWindow(false);
		break;
	case 1:
		m_page1.ShowWindow(false);
		m_page2.ShowWindow(true);
		break;
	default:
		;
	}    
	*pResult = 0;
}
