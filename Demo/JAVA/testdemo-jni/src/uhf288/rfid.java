package uhf288;
import java.lang.reflect.Array;
import com.rfid.uhf288.Device.*;
public class rfid {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		 System.loadLibrary("com_rfid_uhf288_Device");
		 com.rfid.uhf288.Device reader = new com.rfid.uhf288.Device();
		 int Port = 1;//com1
	     byte[]comAddr=new byte[1];
	     comAddr[0]=(byte)255;
	     byte baud=5;//57600bps
	     int[] PortHandle= new int[1];

	     int result = reader.OpenComPort(1, comAddr, baud, PortHandle);
	     System.out.println("打开串口:"+ result);
	     if(result==0)
	     {
	    	 byte[]versionInfo=new byte[2];
	    	 byte[]readerType=new byte[1];
	    	 byte[]trType=new byte[1];
	    	 byte[]dmaxfre=new byte[1];
	    	 byte[]dminfre=new byte[1];
	    	 byte[]powerdBm=new byte[1];
	    	 byte[]InventoryScanTime=new byte[1];
	    	 byte[]Ant=new byte[1];
	    	 byte[]BeepEn=new byte[1];
	    	 byte[]OutputRep=new byte[1];
	    	 byte[]CheckAnt=new byte[1];
	    	 result = reader.GetReaderInformation(comAddr, versionInfo, readerType, trType, dmaxfre, dminfre, powerdBm, InventoryScanTime,
	    			 Ant, BeepEn, OutputRep, CheckAnt, PortHandle[0]);
	    	 System.out.println("获取读写器信息"+result);
	    	 byte ComAdrData=0;

	    	 
	    	 
	    	 /*byte[]PlusMinus =new byte[1];
	    	 byte[]Temperature =new byte[1];
	    	 result = reader.GetReaderTemperature(comAddr, PlusMinus, Temperature, PortHandle[0]);
	    	 System.out.println("测量温度："+result);
	    	 
	    	 Ant[0]=0;
	    	 byte[]TestFreq =new byte[4];//000df638 --915M
	    	 TestFreq[0] = (byte)0x00;
	    	 TestFreq[1] = (byte)0x0d;
	    	 TestFreq[2] = (byte)0xf6;
	    	 TestFreq[3] = (byte)0x38;
	    	 byte[]ReturnLoss =new byte[1];
	    	 result = reader.MeasureReturnLoss(comAddr, TestFreq, Ant[0], ReturnLoss, PortHandle[0]);
	    	 System.out.println("测量回波损耗:"+result);*/
	    	 
	    	 
	    	 ////////////////////////////////////////////////////////////////////////////
	    	 ////////////////////////////////////////////////////////////////////////////
	    	 
	    	 //国军标操作
	    	 byte Algo=0;
	    	 byte MaskMem=2;
	    	 byte[]MaskAdr=new byte[2];
	    	 byte MaskLen=0;
			 byte[]MaskData=new byte[256];
			 byte MaskFlag=0;
			 byte InAnt=(byte)0x80;
			 byte Scantime=10;
			 byte FastFlag=1;
			 byte[]pEPCList=new byte[20000];
			 int[]Totallen=new int[1];
			 int[]CardNum=new int[1];
	    	 result = reader.Inventory_JB(comAddr, Algo, MaskMem, MaskAdr, MaskLen, MaskData, 
	    			 MaskFlag, InAnt, Scantime, FastFlag, pEPCList, CheckAnt, Totallen, CardNum, PortHandle[0]);
	    	 System.out.println("查询标签: "+result);
	    	 if(CardNum[0]>0)
	    	 {
	    		 System.out.println("标签张数: "+CardNum[0]);
	    		 int m=0;
	    		 for(int index=0;index<CardNum[0];index++)
	    		 {
	    			 int epclen = pEPCList[m++]&255;
	    			 String EPCstr="";
	    			 byte[]epc = new byte[epclen];
	    			 for(int n=0;n<epclen;n++)
	    			 {
	    				 byte bbt = pEPCList[m++];
	    				 epc[n] = bbt;
	    				 String hex= Integer.toHexString(bbt& 255);
			    		 if(hex.length()==1)
			    		 {
			    			hex="0"+hex;
			    		 }
			    		 EPCstr+=hex;
	    			 }
	    			 int rssi = pEPCList[m++];
	    			 System.out.println("EPC: "+EPCstr.toUpperCase());
	    			 System.out.println("RSSI: "+rssi);
	    			 byte ENum=(byte)(epclen/2);
	    			 byte Mem=3;
	    			 byte WordPtr=0;
	    			 byte Num=6;
	    			 byte[]Password=new byte[4];
                     MaskMem=2;
                     MaskAdr[0]=0;
                     MaskAdr[1]=0;
                     MaskLen=0;
                     int p=0;
                     byte[]Data=new byte[Num*2];
                     int[]Errorcode=new int[1];
                     byte[]Wdt=new byte[2];
                     Wdt[0]=Wdt[1]=(byte)0xAA;
                     result = reader.WriteData_JB(comAddr, epc, (byte)1, ENum, Mem, WordPtr, Wdt, 
                    		 Password, MaskMem, MaskAdr, MaskLen, MaskData, Errorcode, PortHandle[0]);
                     System.out.println("写数据: "+result);
	    			 result = reader.ReadData_JB(comAddr,epc,ENum,Mem,WordPtr,Num,Password,
		                       MaskMem,MaskAdr, MaskLen,MaskData,Data,Errorcode,PortHandle[0]); 
	    			 System.out.println("读数据: "+result);
	    			 if(result==0)
	    			 {
	    				 String Memdata="";
	    				 for( p=0;p<Num*2;p++)
		    			 {
		    				 byte bbt = Data[p];
		    				 String hex= Integer.toHexString(bbt& 255);
				    		 if(hex.length()==1)
				    		 {
				    			hex="0"+hex;
				    		 }
				    		 Memdata+=hex;
		    			 }
		    			 System.out.println(Memdata.toUpperCase());
	    			 }
	    		 }
	    	 }
	     }
	    	 
	    	 
	    	 
	    	 
	    	 
	    	 
	    	 //EPCC1-G2操作
	    	 /*byte QValue=4;
	    	 byte Session=0;
	    	 byte MaskMem=2;
	    	 byte[]MaskAdr=new byte[2];
	    	 byte MaskLen=0;
			 byte[]MaskData=new byte[256];
			 byte MaskFlag=0;
			 byte AdrTID=0;
			 byte LenTID=6;
			 byte TIDFlag=1;
			 byte Target=0;
			 byte InAnt=(byte)0x80;
			 byte Scantime=10;
			 byte FastFlag=0;
			 byte[]pEPCList=new byte[20000];
			 int[]Totallen=new int[1];
			 int[]CardNum=new int[1];
	    	 result = reader.Inventory_G2(comAddr,QValue,Session,MaskMem,MaskAdr,MaskLen,MaskData,MaskFlag,
	    			  AdrTID,LenTID,TIDFlag,Target,InAnt,Scantime,FastFlag,pEPCList, Ant,Totallen,
					   CardNum,PortHandle[0]);  
	    	 System.out.println("查询标签："+result);
	    	 if(CardNum[0]>0)
	    	 {
	    		 System.out.println("标签张数："+CardNum[0]);
	    		 int m=0;
	    		 for(int index=0;index<CardNum[0];index++)
	    		 {
	    			 int epclen = pEPCList[m++]&255;
	    			 String EPCstr="";
	    			 byte[]epc = new byte[epclen];
	    			 for(int n=0;n<epclen;n++)
	    			 {
	    				 byte bbt = pEPCList[m++];
	    				 epc[n] = bbt;
	    				 String hex= Integer.toHexString(bbt& 255);
			    		 if(hex.length()==1)
			    		 {
			    			hex="0"+hex;
			    		 }
			    		 EPCstr+=hex;
	    			 }
	    			 int rssi = pEPCList[m++];
	    			 System.out.println(EPCstr.toUpperCase());

	    			 byte ENum=(byte)255;
	    			 byte Mem=1;
	    			 byte WordPtr=2;
	    			 byte Num=6;
	    			 byte[]Password=new byte[4];
                     MaskMem=2;
                     MaskAdr[0]=0;
                     MaskAdr[1]=0;
                     MaskLen=96;
                     int p=0;
                     System.arraycopy(epc,0,MaskData,0,96/8);
                     byte[]Data=new byte[Num*2];
                     int[]Errorcode=new int[1];
                     WordPtr=2;
	    			 result = reader.ReadData_G2(comAddr,epc,ENum,Mem,WordPtr,Num,Password,
		                       MaskMem,MaskAdr, MaskLen,MaskData,Data,Errorcode,PortHandle[0]); 
	    			 System.out.println("读数据"+result);
	    			 if(result==0)
	    			 {
	    				 String Memdata="";
	    				 for( p=0;p<Num*2;p++)
		    			 {
		    				 byte bbt = Data[p];
		    				 String hex= Integer.toHexString(bbt& 255);
				    		 if(hex.length()==1)
				    		 {
				    			hex="0"+hex;
				    		 }
				    		 Memdata+=hex;
		    			 }
		    			 System.out.println(Memdata+"\n");
	    			 }
	    		 }
	    	 }
	     }*/
	     reader.CloseSpecComPort(PortHandle[0]);
	}

}
