package com.rfid.uhf288;

public class Device {

	/**
	 * @param args
	 */
	public native int OpenComPort(int port,byte[]comAddr,byte baud,int[]PortHandle);
    public native int CloseSpecComPort(int PortHandle);
    public native int OpenNetPort(int Port,String IPaddr,byte[]comAddr,int[] PortHandle);
    public native int CloseNetPort(int PortHandle);
    public native int GetReaderInformation(byte[]comAddr,byte[]versionInfo,byte[]readerType,byte[]trType,byte[]dmaxfre,
    									   byte[]dminfre,byte[]powerdBm,byte[]InventoryScanTime,byte[]Ant,byte[]BeepEn,
    									   byte[]OutputRep,byte[]CheckAnt,int PortHandle);
    
    public native int Inventory_G2(byte[]comAddr,byte QValue,byte Session,byte MaskMem,byte[]MaskAdr,byte MaskLen,
    							   byte[]MaskData,byte MaskFlag,byte AdrTID,byte LenTID,byte TIDFlag,byte Target,
    							   byte InAnt,byte Scantime,byte FastFlag,byte[]pEPCList,byte[] Ant,int[]Totallen,
    							   int[]CardNum,int PortHandle);  
    
    public native int InventoryMix_G2(byte[]comAddr,byte QValue,byte Session,byte MaskMem,byte[]MaskAdr,byte MaskLen,
			   					   byte[]MaskData,byte MaskFlag,byte ReadMem,byte[]ReadAdr,byte ReadLen,byte[]Psd,
			   					   byte Target,byte InAnt,byte Scantime,byte FastFlag,byte[]pEPCList,byte[] Ant,
			   					   int[]Totallen,int[]CardNum,int PortHandle);
    
    public native int ReadData_G2(byte[]comAddr,byte[] EPC,byte ENum,byte Mem,byte WordPtr,byte Num,byte[]Password,
    		                      byte MaskMem,byte[]MaskAdr,byte MaskLen,byte[]MaskData,byte[]Data,int[]Errorcode,
    		                      int PortHandle);
    
    public native int WriteData_G2(byte[]comAddr,byte[] EPC,byte WNum,byte ENum,byte Mem,byte WordPtr,byte[] Wdt,
    		                       byte[]Password,byte MaskMem,byte[]MaskAdr,byte MaskLen,byte[]MaskData,int[]Errorcode,
                                   int PortHandle);
    
    public native int WriteEPC_G2(byte[]comAddr,byte[] Password,byte[] EPC,byte ENum,int[]Errorcode,int PortHandle);
    
    public native int KillTag_G2(byte[]comAddr,byte[] EPC,byte ENum,byte[] Killpwd,byte MaskMem,byte[]MaskAdr,byte MaskLen,
    		                     byte[]MaskData,int[]Errorcode,int PortHandle);
    public native int Lock_G2(byte[]comAddr,byte[] EPC,byte ENum,byte selectid,byte setprotect,byte[] Password,byte MaskMem,
    		                  byte[]MaskAdr,byte MaskLen, byte[]MaskData,int[]Errorcode,int PortHandle);
    public native int BlockErase_G2(byte[]comAddr,byte[] EPC,byte ENum,byte Mem,byte WordPtr,byte Num,byte[] Password,
    					      byte MaskMem,byte[]MaskAdr,byte MaskLen, byte[]MaskData,int[]Errorcode,int PortHandle);
    public native int SetRegion(byte[]comAddr, byte dmaxfre,byte dminfre,int PortHandle);
    public native int SetAddress(byte[]comAddr, byte ComAdrData,int PortHandle);
    public native int SetInventoryScanTime(byte[]comAddr, byte ScanTime,int PortHandle);
    public native int SetBaudRate(byte[]comAddr, byte baud,int PortHandle);
    public native int SetRfPower(byte[]comAddr, byte PowerDbm,int PortHandle);
    public native int SetWorkMode(byte[]comAddr, byte Read_mode,int PortHandle);
    public native int GetSystemParameter(byte[]comAddr,byte[]Read_mode,byte[]Accuracy,byte[]RepCondition,byte[]RepPauseTime,
    									byte[]ReadPauseTim,byte[]TagProtocol,byte[]MaskMem,byte[]MaskAdr,byte[]MaskLen,
    									byte[]MaskData, byte[]TriggerTime,byte[]AdrTID,byte[]LenTID,int PortHandle);
    public native int SetAntennaMultiplexing(byte[]comAddr, byte Ant,int PortHandle);
    public native int SetAntenna(byte[]comAddr, byte SetOnce,byte AntCfg1,byte AntCfg2,int PortHandle);
    public native int WriteRfPower(byte[]comAddr, byte PowerDbm,int PortHandle);
    public native int ReadRfPower(byte[]comAddr, byte[] PowerDbm,int PortHandle);
    public native int RetryTimes(byte[]comAddr, byte[] Times,int PortHandle);
    public native int SetReadMode(byte[]comAddr, byte ReadMode,int PortHandle);
    public native int SetCheckAnt(byte[]comAddr, byte CheckAnt,int PortHandle);
    public native int GetSeriaNo(byte[]comAddr, byte[] SeriaNo,int PortHandle);
    public native int SetBeepNotification(byte[]comAddr, byte BeepEn,int PortHandle);
    public native int SetReal_timeClock(byte[]comAddr, byte[] paramer,int PortHandle);
    public native int GetTime(byte[]comAddr, byte[] paramer,int PortHandle);
    public native int SetDRM(byte[]comAddr, byte DRM,int PortHandle);
    public native int GetDRM(byte[]comAddr, byte[] DRM,int PortHandle);
    public native int GetReaderTemperature(byte[]comAddr, byte[] PlusMinus,byte[]Temperature,int PortHandle);
    public native int MeasureReturnLoss(byte[]comAddr, byte[] TestFreq,byte Ant,byte[]ReturnLoss,int PortHandle);
    public native int SetGPIO(byte[] comAddr, byte OutputPin, int PortHandle);
    public native int GetGPIOStatus(byte[] ComAdr, byte[] OutputPin, int PortHandle);
    public native int ReadActiveModeData(byte[] ScanModeData, int[] ValidDatalength, int PortHandle);
    public native int SetRelay(byte[] comAddr, byte RelayTime, int PortHandle);
	public native int SwitchProtocol(byte[] comAddr, byte[] protocol, int PortHandle);
	
	public native int Inventory_JB(byte[]comAddr,byte Algo,byte MaskMem,byte[]MaskAdr,byte MaskLen,
    							   byte[]MaskData,byte MaskFlag, byte InAnt,byte Scantime,byte FastFlag,byte[]pEPCList,byte[] Ant,int[]Totallen,
    							   int[]CardNum,int PortHandle); 

	public native int InventoryMix_JB(byte[]comAddr,byte Algo,byte MaskMem,byte[]MaskAdr,byte MaskLen,
			   					   byte[]MaskData,byte MaskFlag,byte ReadMem,byte[]ReadAdr,byte ReadLen,byte[]Psd,
			   					   byte InAnt,byte Scantime,byte FastFlag,byte[]pEPCList,byte[] Ant,
			   					   int[]Totallen,int[]CardNum,int PortHandle);
								   
	public native int ReadData_JB(byte[]comAddr,byte[] TagID,byte TNum,byte Mem,int WordPtr,byte WordNum,byte[]Password,
    		                      byte MaskMem,byte[]MaskAdr,byte MaskLen,byte[]MaskData,byte[]Data,int[]Errorcode,
    		                      int PortHandle);
    
    public native int WriteData_JB(byte[]comAddr,byte[] TagID,byte WNum,byte TNum,byte Mem,int WordPtr,byte[] Wdt,
    		                       byte[]Password,byte MaskMem,byte[]MaskAdr,byte MaskLen,byte[]MaskData,int[]Errorcode,
                                   int PortHandle);
	public native int KillTag_JB(byte[]comAddr,byte[] TagID,byte TNum,byte[] Killpwd,byte MaskMem,byte[]MaskAdr,byte MaskLen,
    		                     byte[]MaskData,int[]Errorcode,int PortHandle);
    public native int Lock_JB(byte[]comAddr,byte[] EPC,byte TNum,byte LockMem,byte Cfg,byte Action,byte[] Password,byte MaskMem,
    		                  byte[]MaskAdr,byte MaskLen, byte[]MaskData,int[]Errorcode,int PortHandle);
    public native int BlockErase_JB(byte[]comAddr,byte[] EPC,byte TNum,byte Mem,int WordPtr,int Num,byte[] Password,
    					      byte MaskMem,byte[]MaskAdr,byte MaskLen, byte[]MaskData,int[]Errorcode,int PortHandle);
								   
    
									
								   
								   
    public static void main(String[] args) {
		// TODO Auto-generated method stub

	}

}
