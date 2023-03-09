#pragma once
#include "time.h"
#include <atlstr.h> 
#include <iostream>
#include <fstream>
#include <assert.h>
#include "stdlib.h"
#include <tchar.h>
#include <windows.h>
#include <setupapi.h>
#include <winsock2.h>
#include <cassert>  
#include "ThreadClass.h"
#define __inner_checkReturn
#define PASSIVE_LEVEL 0
#define __drv_maxIRQL(irql)
#define __drv_when(cond, annotes)
#define __drv_freesMem(kind)
#define TIME_OUT_SEC 60000
#define UARTRXBUFLEN 65536
using namespace std; 
typedef struct __msgTran
{
	unsigned char aucRevBuf[UARTRXBUFLEN];		//接收缓冲区
	int pucRevIn;			        //接收缓冲区写入指针
	int pucRevOut;		            //接收缓冲区读出指针
	int ucRecvIndx;                             //接收长度
	int ucState;					
	unsigned char m_Type;
	SOCKET sServer;             //通讯Socket
	HANDLE hCommPort;			//串口句柄
}MessageTran;

class CThreadClass
{
public:
	CThreadClass();
	virtual ~CThreadClass(void);
	void CreatThread(int m_type,HANDLE hCommPort,SOCKET sServer);
	void ThreadExit();
	void ClearMsgTran();
	int GetTranMessage(unsigned char*msgData,unsigned char* exit);
	
	
	HANDLE hThread;
	bool GetRecvState();
	bool ReadState();
private:  
    MessageTran msgTran;
	bool ThreadLoop;
	static DWORD WINAPI ThreadProc(LPVOID lpThreadParameter);  
	void ReceiveData();  
};
