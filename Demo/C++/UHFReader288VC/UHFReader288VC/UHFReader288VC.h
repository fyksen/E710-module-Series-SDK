// UHFReader288VC.h : PROJECT_NAME Ӧ�ó������ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�ڰ������ļ�֮ǰ������stdafx.h�������� PCH �ļ�"
#endif

#include "resource.h"		// ������


// CUHFReader288VCApp:
// �йش����ʵ�֣������ UHFReader288VC.cpp
//

class CUHFReader288VCApp : public CWinApp
{
public:
	CUHFReader288VCApp();

// ��д
	public:
	virtual BOOL InitInstance();

// ʵ��

	DECLARE_MESSAGE_MAP()
};

extern CUHFReader288VCApp theApp;