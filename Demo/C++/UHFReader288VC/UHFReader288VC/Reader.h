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



#pragma comment(lib, "ws2_32.lib")   
#define ASSERT assert   


typedef struct _RFIDTag  
{  
	unsigned char PacketParam;//数据包类型标志
	unsigned char LEN;//长度
	LPCTSTR UID; //EPC或UID
	unsigned char RSSI;
	unsigned char ANT;
	int FrmHandle;  
}MyStruct, *RFIDTagStruct;    

typedef void(CALLBACK *pRFIDCallBack)(RFIDTagStruct lpRfid, INT32 nEvt);

class CReader
{
private:
	//MessageTran uart;
	union 
	{
		unsigned char data[255];
		struct 
		{
			unsigned char Len;				//数据长度,不包含本字节
			unsigned char ComAddr;			//读写器地址0~254,255为广播地址
			unsigned char CMD;				//操作命令字
			unsigned char Data[252];			//命令操作数,Len=4没有此项
		}comData;
	}sendBuff;
	SOCKET sServer;
	int netport;
	DCB portDCB;
	HANDLE hCommPort;			//串口句柄
	DWORD  time1;
	DWORD  time2;
	DWORD  time3;
	unsigned char inventoryScanTime;
	unsigned char recvBuff[UARTRXBUFLEN];
	unsigned char btRecvArr[UARTRXBUFLEN];
	unsigned char btArBuff[UARTRXBUFLEN];//存储为处理的数据
	unsigned char szBuff[UARTRXBUFLEN];
	unsigned char szBuff1[UARTRXBUFLEN];
	int recvLength;
	fstream _file;
	BOOL LogFileFlag;
	int ATstate;
    bool usbFlag;
	OVERLAPPED ol;
	BOOL fWriteStat;
	BOOL fReadStat;
	unsigned char ReaderAddr;
	CThreadClass Devthread;
	
public:
	CReader(void);
	CRITICAL_SECTION g_cs; 
	BOOL isInventoryCmd;
	BOOL isStopCmd;
	BOOL DeviceIsOpen;
	CString ipAddress;
	int ipPort;;
	int m_type;
	int FrmHandle;//标记外部创建的句柄号，主要用于回调的时候告诉上位机是哪个设备读到了标签
    //BOOL ThreadWork;
	void LOCK();
	void UNLOCK();
	BOOL InventoryBackUID;//询查命令是否返回UID
	pRFIDCallBack MypCallBack;//
	void log(TCHAR* IOFlag,unsigned char* str,int len);
	void GetCRC(unsigned char *pData, int len);
	int CheckCRC(unsigned char *pData, int len);
	int Open_Net(int Port,LPCTSTR IPaddr);
	int Open_Com(int portNumber,unsigned char fbaud);
	int Open_USB();
	int SendDataToPort(unsigned char *dataToSend, unsigned int BytesOfSend);
	int ReadUSB(unsigned char *data, DWORD *lenth);
	int GetDataFromPort(unsigned char *Recv, int *pLengthOfRecved);
	int AutoGetDataFromPort(unsigned char *Recv, int *pLengthOfRecved,int command);
	int GetInventoryDataFromPort1(unsigned char *Recv, int *pLengthOfRecved,int cmd);
	int GetInventoryDataFromPort2(unsigned char *Recv, int *pLengthOfRecved,int cmd);
	int GetBufferDataFromPort(unsigned char *Recv, int *pLengthOfRecved);
	int GetDataFromPort_buff(unsigned char *Recv, int *pLengthOfRecved);
	int GetDataFromPort1(unsigned char *Recv, int *pLengthOfRecved);
    int GetDataFromPort2(unsigned char *Recv, int *pLengthOfRecved);
	void parserRidTag(unsigned char *btFrm,int cmd);
	bool GraceClose(SOCKET *ps); 
	int CloseTCP();
	int OpenTCP(int Port,
		LPCTSTR IPaddr,
		unsigned char*ComAdr);
	int OpenUSB(unsigned char *address);
	int CloseUSB();
	int CloseCom();
	int OpenCom(int port,
		unsigned char *address,
		unsigned char baud);
	int GetReaderInformation(unsigned char* ComAdr,				//读写器地址		
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
		unsigned char*CheckAnt);//最大询查时间
	int Inventory_G2(unsigned char *address,
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
		int *CardNum);

	int InventoryMix_G2(unsigned char *address,
		unsigned char QValue,
		unsigned char Session,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		unsigned char MaskFlag,
		unsigned char ReadMem,
		unsigned char *ReadAdr,
		unsigned char ReadLen,
		unsigned char *Psd,
		unsigned char Target,
		unsigned char InAnt,
		unsigned char Scantime,
		unsigned char FastFlag,///////////////
		unsigned char *pEPCList,
		unsigned char *Ant,
		int *Totallen,		
		int *CardNum);

	int Inventory_EPC_G2(unsigned char *address,
		unsigned char MatchType,
		unsigned char *MatchLen,
		unsigned char *MatchOffset,
		unsigned char *EPCData,///////////////
		unsigned char *pEPCList,
		unsigned char *Ant,
		int *Totallen,		
		int *CardNum);

	int Inventory_QT_G2(unsigned char *address,
		unsigned char QValue,
		unsigned char Session,
		unsigned char Target,
		unsigned char InAnt,///////////////
		unsigned char Scantime,
		unsigned char FastFlag,
		unsigned char *pEPCList,
		unsigned char *Ant,
		int *Totallen,		
		int *CardNum);

	int ReadData_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char Mem,
		unsigned char WordPtr,
		unsigned char Num,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		unsigned char *Data,
		int *Errorcode);

	int WriteData_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char WNum,
		unsigned char ENum,
		unsigned char Mem,
		unsigned char WordPtr,
		unsigned char *Wdt,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);

	int WriteEPC_G2(unsigned char *address,						       
		unsigned char *Password,
		unsigned char *WriteEPC,
		unsigned char ENum,
		int *Errorcode);

	int KillTag_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char *Killpwd,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);

	int Lock_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char select,
		unsigned char setprotect,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);

	int BlockErase_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char Mem,
		unsigned char WordPtr,
		unsigned char Num,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);

	int SetPrivacyByEPC_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);

	int SetPrivacyWithoutEPC_G2(unsigned char *address,
		unsigned char *Password,
		int *Errorcode);

	int ResetPrivacy_G2(unsigned char *address,
		unsigned char *Password,
		int *Errorcode);

	int CheckPrivacy_G2(unsigned char *address,
		unsigned char *readpro,
		int *Errorcode);

	int EASConfigure_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char *Password,
		unsigned char EAS,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);

	int EASAlarm_G2(unsigned char *address,
		int *Errorcode);

	int BlockLock_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char *Password,
		unsigned char WrdPointer,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);

	int SingleTagInventory_G2(unsigned char *address,
		unsigned char* EPC,
		int *EPCLength,		
		int *CardNum);

	int BlockWrite_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char WNum,
		unsigned char ENum,
		unsigned char Mem,
		unsigned char WordPtr,
		unsigned char *Wdt,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);

	int InventorySingle_6B(unsigned char *address,
		unsigned char *Ant,
		unsigned char* ID_6B);

	int InventoryMultiple_6B(unsigned char *address,
		unsigned char Condition,
		unsigned char StartAddress,
		unsigned char mask,
		unsigned char *ConditionContent,
		unsigned char *Ant,
		unsigned char* ID_6B,
		int *Cardnum);

	int ReadData_6B(unsigned char *address,
		unsigned char* ID_6B,
		unsigned char StartAddress,
		unsigned char Num,
		unsigned char *Data,
		int *Errorcode);

	int WriteData_6B(unsigned char *address,
		unsigned char *ID_6B,
		unsigned char StartAddress,
		unsigned char *Writedata,
		unsigned char Writedatalen,
		unsigned char *writtenbyte,
		int *Errorcode);

	int Lock_6B(unsigned char *address,
		unsigned char *ID_6B,
		unsigned char StartAddress,
		int *Errorcode);

	int CheckLock_6B(unsigned char *address,
		unsigned char *ID_6B,
		unsigned char StartAddress,
		unsigned char *ReLockState,
		int *Errorcode)	;

	int SetRegion(unsigned char *address,
		unsigned char dmaxfre,
		unsigned char dminfre);

	int SetAddress(unsigned char *address,
		unsigned char ComAdrData);

	int SetInventoryScanTime(unsigned char *address,
		unsigned char ScanTime);
	int InSelfTestMode(unsigned char *address,
		BOOL IsSelfTestMode);

	int SetBaudRate(unsigned char *address,
		unsigned char baud);

	int SetRfPower(unsigned char *address,
		unsigned char PowerDbm);

	int BuzzerAndLEDControl(unsigned char *address,
		unsigned char AvtiveTime,
		unsigned char SilentTime,
		unsigned char Times);

	int SetWorkMode(unsigned char *address,
		unsigned char Read_mode);

	int GetSystemParameter(unsigned char *address,
		unsigned char *Read_mode,
		unsigned char *Accuracy,
		unsigned char *RepCondition,
		unsigned char *RepPauseTime,
		unsigned char *ReadPauseTim,
		unsigned char *TagProtocol,
		unsigned char *MaskMem,
		unsigned char *MaskAdr,
		unsigned char *MaskLen,
		unsigned char *MaskData,
		unsigned char *TriggerTime,
		unsigned char *AdrTID,
		unsigned char *LenTID);
	int SetDAC(unsigned char *address,
		unsigned char DACdata);
	int GetDAC(unsigned char *address,
		unsigned char *DACdata);

	int CheckPowerParameter(unsigned char *address,
		unsigned char *code);
	int SolidifyDACandPowerlist(unsigned char *address,
		unsigned char *dBm_list,
		unsigned char *code);
	int GetStartInformation(unsigned char *address,
		unsigned char *FreE,
		unsigned char *addrE,
		unsigned char *scnE,
		unsigned char *xpwrE,
		unsigned char *wgE,
		unsigned char *xRreadModeE,
		unsigned char *xModeParaE,
		unsigned char *xbpsE,
		unsigned char *xEasAccuE);
	int SetEASSensitivity(unsigned char *ComAdr,
		unsigned char Accuracy);

	int SetTriggerTime(unsigned char *ComAdr,
		unsigned char TriggerTime);

	int SetMask(unsigned char *ComAdr,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData);

	int SetResponsePamametersofAuto_runningMode(unsigned char *ComAdr,
		unsigned char RepCondition,
		unsigned char RepPauseTime);

	int SetInventoryInterval(unsigned char *ComAdr,
		unsigned char ReadPauseTim);

	int SelectTagType(unsigned char *ComAdr,
		unsigned char TagProtocol);


	int SetBeepNotification(unsigned char *ComAdr,
		unsigned char BeepEn);

	int SetReal_timeClock(unsigned char *ComAdr,
		unsigned char *paramer);

	int GetTime(unsigned char *ComAdr,
		unsigned char *paramer);

	int GetTagBufferInfo(unsigned char *ComAdr,
		unsigned char *Data,
		int *dataLength);

	int ClearTagBuffer(unsigned char *ComAdr);

	int SetRelay(unsigned char *ComAdr,
		unsigned char RelayTime);

	int SetRevDelay(unsigned char *ComAdr,
		unsigned char RevDelay);

	int GetRevDelay(unsigned char *ComAdr,
		unsigned char *RevDelay);

	int GetGPIOStatus(unsigned char *ComAdr,
		unsigned char *OutputPin);

	int SetGPIO(unsigned char *ComAdr,
		unsigned char OutputPin);

	int SetNotificationPulseOutput(unsigned char *ComAdr,
		unsigned char OutputRep);

	int ReadActiveModeData(unsigned char * ScanModeData,
		int *ValidDatalength);

	int SetTIDParameter(unsigned char *address,
		unsigned char AdrTID,
		unsigned char LenTID);

	int ChangeATMode(unsigned char *address,
		unsigned char ATMode);

	int TransparentCMD(unsigned char *ComAdr,
		unsigned char timeout,
		unsigned char nlen,
		unsigned char *cmddata,
		unsigned char *recvLen,
		unsigned char *recvdata);

	int ATGetDataFromPort(unsigned char *Recv, int *pLengthOfRecved);

	int SetSeriaNo(unsigned char *address,
		unsigned char* SeriaNo);

	int GetSeriaNo(unsigned char *address,
		unsigned char* SeriaNo);

	
	int SetCheckAnt(unsigned char *address,
		unsigned char CheckAnt);



	int SetTagCustomFunction(unsigned char *address,
		unsigned char *InlayType);

	int GetMonza4QTWorkParamter_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		unsigned char *QTcontrol,
		int *Errorcode)	;

	int SetMonza4QTWorkParamter_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char QTcontrol,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);


	int SetCommType(unsigned char *address,
		unsigned char CommType);


	int SetQS(unsigned char *address,
		unsigned char Qvalue,
		unsigned char Session);

	int GetQS(unsigned char *address,
		unsigned char *Qvalue,
		unsigned char *Session);

	int GetModuleVersion(unsigned char *address,
		unsigned char *Version);

	int SetFlashRom(unsigned char *address);

	int ExtReadData_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char Mem,
		unsigned char *WordPtr,
		unsigned char Num,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		unsigned char *Data,
		int *Errorcode)	;

	int ExtWriteData_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char WNum,
		unsigned char ENum,
		unsigned char Mem,
		unsigned char *WordPtr,
		unsigned char *Wdt,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);

	int InventoryBuffer_G2(unsigned char *address,
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
		int *TagNum);

	int SetSaveLen(unsigned char *ComAdr,
		unsigned char SaveLen);

	int GetSaveLen(unsigned char *ComAdr,
		unsigned char *SaveLen);

	int ReadBuffer_G2(unsigned char *ComAdr,
		int *Totallen,
		int *CardNum,
		unsigned char *pEPCList);

	int ClearBuffer_G2(unsigned char *ComAdr);

	int GetBufferCnt_G2(unsigned char *ComAdr,
		int *Count);

	int SetReadMode(unsigned char *ComAdr,
		unsigned char ReadMode);

	int SetReadParameter(unsigned char *ComAdr,
		unsigned char *Parameter,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		unsigned char MaskFlag,
		unsigned char AdrTID,
		unsigned char LenTID,
		unsigned char TIDFlag);

	int GetReadParameter(unsigned char *ComAdr,
		unsigned char *Parameter);

	int WriteRfPower(unsigned char *address,
		unsigned char PowerDbm);

	int ReadRfPower(unsigned char *address,
		unsigned char *PowerDbm);

	int RetryTimes(unsigned char *address,
		unsigned char *Times);

	int SetHeartBeatTime(unsigned char *address,
		unsigned char *HeartBeatTime);

    int GetTMP_G2(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char WordPtr,
		unsigned char WaitTime,
		unsigned char *Data,
		int *Errorcode);
	int GetTmpData(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char SendUID,
		unsigned char NewSample,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		unsigned char *UID,
		unsigned char *SenserData,
		unsigned char *UTC,
		int *Errorcode);
    int ConfigAntNum(unsigned char *address,
		unsigned char *AntNum);

    int SetUserPwd(unsigned char *address,
		unsigned char *UserPwd);

    int GetUserPwd(unsigned char *address,
		unsigned char *UserPwd);//
    int SetUTCTime(unsigned char *address,
		unsigned char *UTCTime);
    int GetEMTmpData(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char SendUID,
		unsigned char NewSample,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		unsigned char *UID,
		unsigned char *SenserData,
		unsigned char *UTC,
		int *Errorcode);
    int GetSPI(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char SPICmdSize,
		unsigned char SPIResSize,
		unsigned char SPISclk,
		unsigned char SPIInitDelay,
		unsigned char SPIInterval,
		unsigned char* SPICmd,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		unsigned char *SPIResData,
		int *Errorcode);
    int ResetAlarm(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char *Password,
		unsigned char MaskMem,
		unsigned char *MaskAdr,
		unsigned char MaskLen,
		unsigned char *MaskData,
		int *Errorcode);

    int SetCarrierTime(unsigned char *address,
		unsigned char *CarrierTime);

    int SecondIdentify(unsigned char *address,
		unsigned char *Token1,
		unsigned char *Token2,
		unsigned char *Handle);

    int FirstIdentify(unsigned char *address,
		unsigned char *RT);

    int QueryAndIdentify(unsigned char *address,
		unsigned char *EPC,
		unsigned char ENum,
		unsigned char *EPCLen,
		unsigned char *NewEPC,
		unsigned char *RSSI,
		unsigned char *KI,
		unsigned char *TID);

    int SetFTime(unsigned char *address,
		unsigned char FTime);

    int GetFTime(unsigned char *address,
		unsigned char* FTime);

	int SetDRM(BYTE *address,
		BYTE DRM);

	int GetDRM(BYTE *address,
		BYTE* DRM);

	int SetAntennaMultiplexing(unsigned char *ComAdr,
		unsigned char SetOnce,
		unsigned char AntCfg1,
		unsigned char AntCfg2);

	int GetReaderTemperature(BYTE *address,
		BYTE* PlusMinus,
		BYTE* Temperature);

	int MeasureReturnLoss(BYTE *address,
		BYTE* TestFreq,
		BYTE Ant,
		BYTE* ReturnLoss);

	~CReader(void);
};
