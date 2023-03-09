package com.uhf288.scanlable;

import com.rfid.trans.ReaderParameter;

import android.app.Activity;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.LinearLayout;
import android.widget.Spinner;
import android.widget.TextView;

public class ScanView extends Activity implements OnClickListener{
	
	private TextView tvVersion;
	private TextView tvResult;
	private Spinner tvpowerdBm;
	private Spinner tvBeep;
	private Spinner tvRepeat;
	
	private Button btSetFre;
	private Button btGetFre;
	
	private Button btSetPower;
	private Button btGetPower;
	
	private Button btSetAntenna;
	private Button btGetAntenna;
	
	private Button btSetBeep;
	private Button btGetBeep;
	
	private Button btSetRepeat;
	private Button btGetRepeat;
	
	CheckBox Ant1;
	CheckBox Ant2;
	CheckBox Ant3;
	CheckBox Ant4;
	CheckBox Ant5;
	CheckBox Ant6;
	CheckBox Ant7;
	CheckBox Ant8;
	CheckBox Ant9;
	CheckBox Ant10;
	CheckBox Ant11;
	CheckBox Ant12;
	CheckBox Ant13;
	CheckBox Ant14;
	CheckBox Ant15;
	CheckBox Ant16;

	LinearLayout line1;
	LinearLayout line2;
	LinearLayout line3;
	LinearLayout line4;
	
	private int soundid;
	private int tty_speed = 57600;
	private byte addr = (byte) 0xff; 
	private String[] strBand =new String[6]; 
    private String[] strmaxFrm =null; 
    private String[] strminFrm =null; 
    Spinner spBand;
    Spinner spmaxFrm;
	Spinner spminFrm;
	
	Spinner spqvalue;
	Spinner spsession;
	Spinner sptidaddr;
	Spinner sptidlen;
	Spinner sptime;
	Button Setparam;
	Button Getparam;
	private ArrayAdapter<String> spada_Band; 
    private ArrayAdapter<String> spada_maxFrm; 
    private ArrayAdapter<String> spada_minFrm; 
    
    private ArrayAdapter<String> spada_qvalue; 
    private ArrayAdapter<String> spada_session; 
    private ArrayAdapter<String> spada_tidaddr; 
    private ArrayAdapter<String> spada_tidlen; 
	private static final String TAG = "SacnView";
	private Handler mHandler;
	private static final int MSG_SHOW_RESULT = 1;
	private static final int MSG_SHOW_INFO = 2;
	private static final int MSG_SHOW_REPEAT = 3;
	
	byte[]Version=new byte[2];
	byte[]Power=new byte[1];
	byte[]aband=new byte[1];
	byte[]aMaxFre=new byte[1];
	byte[]aMinFre=new byte[1];
	byte[]scanTime=new byte[1];
	byte[]BeepEn=new byte[1];
	int[]Ant=new int[1];
	private int band,MaxFre,MinFre,Antenna=0;
	Thread mThread =null;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub  properties
		super.onCreate(savedInstanceState);	
		setContentView(R.layout.scan_view);
		initView();
		mHandler = new Handler(){
			@Override
			public void handleMessage(Message msg) {
				// TODO Auto-generated method stub
				super.handleMessage(msg);
				switch (msg.what) {
				case MSG_SHOW_RESULT:
					 String temp = (String) msg.obj;
					 Reader.writelog(temp,tvResult);
					 break;
				case MSG_SHOW_REPEAT:
					 String retryStr = (String) msg.obj;
					 int retry = Integer.valueOf(retryStr);
					 tvRepeat.setSelection(retry,true);
					break;
				case MSG_SHOW_INFO:
					String hvn = String.valueOf(Version[0]);
					if(hvn.length()==1)hvn="0"+hvn;
					String lvn = String.valueOf(Version[1]);
					if(lvn.length()==1)lvn="0"+lvn;
					tvVersion.setText(hvn+"."+lvn);
					tvpowerdBm.setSelection(Power[0],true);
					SetFre(aband[0]);
					int bandindex = aband[0];
					if(bandindex ==8)
					{
						bandindex=bandindex-4;
					}
					else if(bandindex ==0)
					{
						bandindex=5;
					}
					else
					{
						bandindex=bandindex-1;
					}
					spBand.setSelection(bandindex,true);
					spminFrm.setSelection(aMinFre[0],true);
					spmaxFrm.setSelection(aMaxFre[0],true);
					tvBeep.setSelection(BeepEn[0], true);
					
					int AntInfo=Ant[0];
					if((AntInfo & 0x0001)==0x0001)
					{Ant1.setChecked(true);}
					else
					{Ant1.setChecked(false);}
					
					if((AntInfo & 0x0002)==0x0002)
					{Ant2.setChecked(true);}
					else
					{Ant2.setChecked(false);}
					
					if((AntInfo & 0x0004)==0x0004)
					{Ant3.setChecked(true);}
					else
					{Ant3.setChecked(false);}
					
					if((AntInfo & 0x0008)==0x0008)
					{Ant4.setChecked(true);}
					else
					{Ant4.setChecked(false);}

					if((AntInfo & 0x0010)==0x0010)
					{Ant5.setChecked(true);}
					else
					{Ant5.setChecked(false);}

					if((AntInfo & 0x0020)==0x0020)
					{Ant6.setChecked(true);}
					else
					{Ant6.setChecked(false);}

					if((AntInfo & 0x0040)==0x0040)
					{Ant7.setChecked(true);}
					else
					{Ant7.setChecked(false);}

					if((AntInfo & 0x0080)==0x0080)
					{Ant8.setChecked(true);}
					else
					{Ant8.setChecked(false);}

					if((AntInfo & 0x0100)==0x0100)
					{Ant9.setChecked(true);}
					else
					{Ant9.setChecked(false);}

					if((AntInfo & 0x0200)==0x0200)
					{Ant10.setChecked(true);}
					else
					{Ant10.setChecked(false);}

					if((AntInfo & 0x0400)==0x0400)
					{Ant11.setChecked(true);}
					else
					{Ant11.setChecked(false);}

					if((AntInfo & 0x0800)==0x0800)
					{Ant12.setChecked(true);}
					else
					{Ant12.setChecked(false);}

					if((AntInfo & 0x1000)==0x1000)
					{Ant13.setChecked(true);}
					else
					{Ant13.setChecked(false);}

					if((AntInfo & 0x2000)==0x2000)
					{Ant14.setChecked(true);}
					else
					{Ant14.setChecked(false);}

					if((AntInfo & 0x4000)==0x4000)
					{Ant15.setChecked(true);}
					else
					{Ant15.setChecked(false);}

					if((AntInfo & 0x8000)==0x8000)
					{Ant16.setChecked(true);}
					else
					{Ant16.setChecked(false);}
					
				default:
					break;
				}
			}
		};
	}
	
	private void initView(){
		
		
		tvVersion = (TextView)findViewById(R.id.version);
		tvResult = (TextView)findViewById(R.id.param_result);
		//功率
		tvpowerdBm = (Spinner)findViewById(R.id.power_spinner);
		ArrayAdapter<CharSequence> adapter3 =  ArrayAdapter.createFromResource(this, R.array.Power_select, android.R.layout.simple_spinner_item);
		adapter3.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		tvpowerdBm.setAdapter(adapter3); 
		tvpowerdBm.setSelection(30, true);
		//蜂鸣器
		tvBeep = (Spinner)findViewById(R.id.beep_spinner);
		ArrayAdapter<CharSequence> adapter4 =  ArrayAdapter.createFromResource(this, R.array.beep_select, android.R.layout.simple_spinner_item);
		adapter4.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		tvBeep.setAdapter(adapter4); 
		tvBeep.setSelection(0, true);
		//重写次数
		tvRepeat = (Spinner)findViewById(R.id.repeat_spinner);
		ArrayAdapter<CharSequence> adapter30 =  ArrayAdapter.createFromResource(this, R.array.repeat_select, android.R.layout.simple_spinner_item);
		adapter30.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		tvRepeat.setAdapter(adapter30); 
		tvRepeat.setSelection(3, true);
		//天线
		Ant1 = (CheckBox)this.findViewById(R.id.checkAnt1);
	    Ant2 = (CheckBox)this.findViewById(R.id.checkAnt2);
	    Ant3 = (CheckBox)this.findViewById(R.id.checkAnt3);
	    Ant4 = (CheckBox)this.findViewById(R.id.checkAnt4);
		Ant5 = (CheckBox)this.findViewById(R.id.checkAnt5);
		Ant6 = (CheckBox)this.findViewById(R.id.checkAnt6);
		Ant7 = (CheckBox)this.findViewById(R.id.checkAnt7);
		Ant8 = (CheckBox)this.findViewById(R.id.checkAnt8);
		Ant9 = (CheckBox)this.findViewById(R.id.checkAnt9);
		Ant10 = (CheckBox)this.findViewById(R.id.checkAnt10);
		Ant11 = (CheckBox)this.findViewById(R.id.checkAnt11);
		Ant12 = (CheckBox)this.findViewById(R.id.checkAnt12);
		Ant13 = (CheckBox)this.findViewById(R.id.checkAnt13);
		Ant14 = (CheckBox)this.findViewById(R.id.checkAnt14);
		Ant15 = (CheckBox)this.findViewById(R.id.checkAnt15);
		Ant16 = (CheckBox)this.findViewById(R.id.checkAnt16);

		line1 =(LinearLayout)this.findViewById(R.id.antGroup1);
		line2 =(LinearLayout)this.findViewById(R.id.antGroup2);
		line3 =(LinearLayout)this.findViewById(R.id.antGroup3);
		line4 =(LinearLayout)this.findViewById(R.id.antGroup4);
	    
		////////////频段
	    strBand[0]="Chinese band2";
		strBand[1]="US band";
		strBand[2]="Korean band";
		strBand[3]="EU band";
		strBand[4]="Chinese band1";
		strBand[5]="ALL band";
		
		spBand=(Spinner)findViewById(R.id.band_spinner);  
		spada_Band = new ArrayAdapter<String>(ScanView.this,  
	             android.R.layout.simple_spinner_item, strBand);  
		spada_Band.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		spBand.setAdapter(spada_Band);  
		spBand.setSelection(1,false); 
		SetFre(2);
		spBand.setOnItemSelectedListener(new Spinner.OnItemSelectedListener() {  
	    public void onItemSelected(AdapterView<?> arg0, View arg1,  
	            int arg2, long arg3) {  
	        // TODO Auto-generated method stub  
	        arg0.setVisibility(View.VISIBLE);  
	        if(arg2==0)SetFre(1);
            if(arg2==1)SetFre(2);
            if(arg2==2)SetFre(3);
            if(arg2==3)SetFre(4);
            if(arg2==4)SetFre(8);
            if(arg2==5)SetFre(0);
	    }  
	    public void onNothingSelected(AdapterView<?> arg0) {  
	        // TODO Auto-generated method stub  
	    	}  
		});  
		
		btSetFre = (Button)findViewById(R.id.pro_setting);
		btGetFre = (Button)findViewById(R.id.pro_read);
		
		btSetPower = (Button)findViewById(R.id.btsetpwr);
		btGetPower = (Button)findViewById(R.id.btgetpwr);

		btSetAntenna = (Button)findViewById(R.id.btsetant);
		btGetAntenna = (Button)findViewById(R.id.btgetant);

		btSetBeep = (Button)findViewById(R.id.btsetbeep);
		btGetBeep = (Button)findViewById(R.id.btgetbeep);
		
		btSetRepeat = (Button)findViewById(R.id.btsetwtime);
		btGetRepeat = (Button)findViewById(R.id.btgetwtime);
		
		btSetFre.setOnClickListener(this);
		btGetFre.setOnClickListener(this);
		btSetPower.setOnClickListener(this);
		btGetPower.setOnClickListener(this);
		btSetAntenna.setOnClickListener(this);
		btGetAntenna.setOnClickListener(this);
		btSetBeep.setOnClickListener(this);
		btGetBeep.setOnClickListener(this);
		btSetRepeat.setOnClickListener(this);
		btGetRepeat.setOnClickListener(this);

		ReaderParameter param = Reader.rrlib.GetInventoryPatameter();
		if(param.MaxAntennaNum==4)
		{
			line1.setVisibility(View.VISIBLE);
			line2.setVisibility(View.GONE);
			line3.setVisibility(View.GONE);
			line4.setVisibility(View.GONE);
		}
		else if(param.MaxAntennaNum==8)
		{
			line1.setVisibility(View.VISIBLE);
			line2.setVisibility(View.VISIBLE);
			line3.setVisibility(View.GONE);
			line4.setVisibility(View.GONE);
		}else if(param.MaxAntennaNum==16)
		{
			line1.setVisibility(View.VISIBLE);
			line2.setVisibility(View.VISIBLE);
			line3.setVisibility(View.VISIBLE);
			line4.setVisibility(View.VISIBLE);
		}

	}
	
	
	
	@Override
	public void onClick(View view) {
		try{
			if(view == btSetFre)
			{
				int fband = spBand.getSelectedItemPosition();
				band=0;
				if(fband==0)band=1;
				if(fband==1)band=2;
				if(fband==2)band=3;
				if(fband==3)band=4;
				if(fband==4)band=8;
				if(fband==5)band=0;
				int Frequent= spminFrm.getSelectedItemPosition();
				MinFre = Frequent;
				Frequent= spmaxFrm.getSelectedItemPosition();
				MaxFre = Frequent;
				Thread mThread = new Thread(new Runnable() 
				{  
		            @Override  
		            public void run() 
		            {  
		            	String temp="";
						int result = Reader.rrlib.SetRegion(band,MaxFre,MinFre);
						if(result!=0)
							temp=getString(R.string.frequent_error);
						else
							temp=getString(R.string.set_success);
						mHandler.obtainMessage(MSG_SHOW_RESULT,temp).sendToTarget();
		            }  
		        }); 
				mThread.start();
				
			}
			else if((view == btGetFre)||(view == btGetPower)||(view == btGetAntenna)||(view == btGetBeep))
			{


				if(mThread==null)
				{
					mThread = new Thread(new Runnable()
					{
						@Override
						public void run()
						{
							int result = Reader.rrlib.GetUHFInformation(Version, Power, aband, aMaxFre, aMinFre, BeepEn, Ant);
							if(result==0)
							{
								mHandler.obtainMessage(MSG_SHOW_INFO,getString(R.string.get_success)).sendToTarget();
								mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.get_success)).sendToTarget();
							}
							else
							{
								mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.get_failed)).sendToTarget();
							}
							mThread=null;
						}
					});
					mThread.start();
				}

			}
			else if(view == btSetPower)
			{
				final int Power= tvpowerdBm.getSelectedItemPosition();
				Thread mThread = new Thread(new Runnable() 
				{  
		            @Override  
		            public void run() 
		            {  
		            	String temp="";
		            	int result = Reader.rrlib.SetRfPower(Power);		            	
		            	if(result!=0)
							temp=getString(R.string.power_error);
						else
							temp=getString(R.string.set_success);
						mHandler.obtainMessage(MSG_SHOW_RESULT,temp).sendToTarget();
		            }  
		        }); 
				mThread.start();
			}
			else if(view == btSetAntenna)
			{
				Antenna=0;
				if(Ant1.isChecked())
				{Antenna |= 0x0001;}
				if(Ant2.isChecked())
				{Antenna |= 0x0002;}
				if(Ant3.isChecked())
				{Antenna |= 0x0004;}
				if(Ant4.isChecked())
				{Antenna |= 0x0008;}
				if(Ant5.isChecked())
				{Antenna |= 0x0010;}
				if(Ant6.isChecked())
				{Antenna |= 0x0020;}
				if(Ant7.isChecked())
				{Antenna |= 0x0040;}
				if(Ant8.isChecked())
				{Antenna |= 0x0080;}

				if(Ant9.isChecked())
				{Antenna |= 0x0100;}
				if(Ant10.isChecked())
				{Antenna |= 0x0200;}
				if(Ant11.isChecked())
				{Antenna |= 0x0400;}
				if(Ant12.isChecked())
				{Antenna |= 0x0800;}
				if(Ant13.isChecked())
				{Antenna |= 0x1000;}
				if(Ant14.isChecked())
				{Antenna |= 0x2000;}
				if(Ant15.isChecked())
				{Antenna |= 0x4000;}
				if(Ant16.isChecked())
				{Antenna |= 0x8000;}
				Thread mThread = new Thread(new Runnable() 
				{  
		            @Override  
		            public void run() 
		            {  
		            	String temp="";
		            	int result = Reader.rrlib.SetAntenna((byte)1,Antenna);
		            	if(result!=0)
							temp=getString(R.string.antenna_error);
						else
							temp=getString(R.string.set_success);
						mHandler.obtainMessage(MSG_SHOW_RESULT,temp).sendToTarget();
		            }  
		        }); 
				mThread.start();
				
			}
			else if(view == btSetBeep)
			{
				final int BeepEn = tvBeep.getSelectedItemPosition();
				Thread mThread = new Thread(new Runnable() 
				{  
		            @Override  
		            public void run() 
		            {  
		            	String temp="";
		            	int result = Reader.rrlib.SetBeepNotification(BeepEn);      	
		            	if(result!=0)
							temp=getString(R.string.beep_error);
						else
							temp=getString(R.string.set_success);
						mHandler.obtainMessage(MSG_SHOW_RESULT,temp).sendToTarget();
		            }  
		        }); 
				mThread.start();
			}
			else if(view == btSetRepeat)
			{
				final int RepeatTime = tvRepeat.getSelectedItemPosition();
				Thread mThread = new Thread(new Runnable() 
				{  
		            @Override  
		            public void run() 
		            {  
		            	String temp="";
		            	int result = Reader.rrlib.SetRetryTimes((byte)RepeatTime);      	
		            	if(result!=0)
							temp=getString(R.string.setrepeat_error);
						else
							temp=getString(R.string.set_success);
						mHandler.obtainMessage(MSG_SHOW_RESULT,temp).sendToTarget();
		            }  
		        }); 
				mThread.start();
			}
			else if(view == btGetRepeat)
			{
				Thread mThread = new Thread(new Runnable() 
				{  
		            @Override  
		            public void run() 
		            {  
		            	String temp="";
		            	byte[]RepeatTime = new byte[1];
		            	int result = Reader.rrlib.GetRetryTimes(RepeatTime);      	
		            	if(result!=0)
							temp=getString(R.string.getrepeat_error);
						else
						{
							mHandler.obtainMessage(MSG_SHOW_RESULT,String.valueOf(RepeatTime[0])).sendToTarget();
							temp=getString(R.string.get_success);
						}
						mHandler.obtainMessage(MSG_SHOW_RESULT,temp).sendToTarget();
		            }  
		        }); 
				mThread.start();
			}
		}catch(Exception ex)
		{}
	}
	
	int lastBand=0;
	private void SetFre(int m)
	{
		if(lastBand==m)return;
		try{
			if(m==1){ 
			    strmaxFrm=new String[20];
	         	strminFrm=new String[20];
	         	for(int i=0;i<20;i++){
	         		String temp="";
	         		float values=(float) (920.125 + i * 0.25);
	         		temp=String.valueOf(values)+"MHz";
	         		strminFrm[i]=temp;
	         		strmaxFrm[i]=temp;
	         	}
	         	spmaxFrm=(Spinner)findViewById(R.id.max_spinner);  
	         	spada_maxFrm = new ArrayAdapter<String>(ScanView.this,  
	                      android.R.layout.simple_spinner_item, strmaxFrm);  
	         	spada_maxFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
	         	spmaxFrm.setAdapter(spada_maxFrm);  
	         	spmaxFrm.setSelection(19,false);
	         	
	         	spminFrm=(Spinner)findViewById(R.id.min_spinner);  
	         	spada_minFrm = new ArrayAdapter<String>(ScanView.this,  
	                      android.R.layout.simple_spinner_item, strminFrm);  
	         	spada_minFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
	         	spminFrm.setAdapter(spada_minFrm);  
	         	spminFrm.setSelection(0,false);
		     }else if(m==2){
		     	strmaxFrm=new String[50];
		     	strminFrm=new String[50];
		     	for(int i=0;i<50;i++){
		     		String temp="";
		     		float values=(float) (902.75 + i * 0.5);
		     		temp=String.valueOf(values)+"MHz";
		     		strminFrm[i]=temp;
		     		strmaxFrm[i]=temp;
		     	}
		     	spmaxFrm=(Spinner)findViewById(R.id.max_spinner);  
		     	spada_maxFrm = new ArrayAdapter<String>(ScanView.this,  
		                  android.R.layout.simple_spinner_item, strmaxFrm);  
		     	spada_maxFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		     	spmaxFrm.setAdapter(spada_maxFrm);  
		     	spmaxFrm.setSelection(49,false);
		     	
		     	spminFrm=(Spinner)findViewById(R.id.min_spinner);  
		     	spada_minFrm = new ArrayAdapter<String>(ScanView.this,  
		                  android.R.layout.simple_spinner_item, strminFrm);  
		     	spada_minFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		     	spminFrm.setAdapter(spada_minFrm);  
		     	spminFrm.setSelection(0,false);
		     }else if(m==3){
		      	strmaxFrm=new String[32];
		      	strminFrm=new String[32];
		      	for(int i=0;i<32;i++){
		      		String temp="";
		      		float values=(float) (917.1 + i * 0.2);
		      		temp=String.valueOf(values)+"MHz";
		      		strminFrm[i]=temp;
		      		strmaxFrm[i]=temp;
		      	}
		      	spmaxFrm=(Spinner)findViewById(R.id.max_spinner);  
		      	spada_maxFrm = new ArrayAdapter<String>(ScanView.this,  
		                   android.R.layout.simple_spinner_item, strmaxFrm);  
		      	spada_maxFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		      	spmaxFrm.setAdapter(spada_maxFrm);  
		      	spmaxFrm.setSelection(31,false);
		      	
		      	spminFrm=(Spinner)findViewById(R.id.min_spinner);  
		      	spada_minFrm = new ArrayAdapter<String>(ScanView.this,  
		                   android.R.layout.simple_spinner_item, strminFrm);  
		      	spada_minFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		      	spminFrm.setAdapter(spada_minFrm);  
		      	spminFrm.setSelection(0,false);
		      }else if(m==4){
		       	strmaxFrm=new String[15];
		       	strminFrm=new String[15];
		       	for(int i=0;i<15;i++){
		       		String temp="";
		       		float values=(float) (865.1 + i * 0.2);
		       		temp=String.valueOf(values)+"MHz";
		       		strminFrm[i]=temp;
		       		strmaxFrm[i]=temp;
		       	}
		       	spmaxFrm=(Spinner)findViewById(R.id.max_spinner);  
		       	spada_maxFrm = new ArrayAdapter<String>(ScanView.this,  
		                    android.R.layout.simple_spinner_item, strmaxFrm);  
		       	spada_maxFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		       	spmaxFrm.setAdapter(spada_maxFrm);  
		       	spmaxFrm.setSelection(14,false);
		       	
		       	spminFrm=(Spinner)findViewById(R.id.min_spinner);  
		       	spada_minFrm = new ArrayAdapter<String>(ScanView.this,  
		                    android.R.layout.simple_spinner_item, strminFrm);  
		       	spada_minFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		       	spminFrm.setAdapter(spada_minFrm);  
		       	spminFrm.setSelection(0,false);
		       }else if(m==8){
				    strmaxFrm=new String[20];
		         	strminFrm=new String[20];
		         	for(int i=0;i<20;i++){
		         		String temp="";
		         		float values=(float) (840.125 + i * 0.25);
		         		temp=String.valueOf(values)+"MHz";
		         		strminFrm[i]=temp;
		         		strmaxFrm[i]=temp;
		         	}
		         	spmaxFrm=(Spinner)findViewById(R.id.max_spinner);  
		         	spada_maxFrm = new ArrayAdapter<String>(ScanView.this,  
		                      android.R.layout.simple_spinner_item, strmaxFrm);  
		         	spada_maxFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		         	spmaxFrm.setAdapter(spada_maxFrm);  
		         	spmaxFrm.setSelection(19,false);
		         	
		         	spminFrm=(Spinner)findViewById(R.id.min_spinner);  
		         	spada_minFrm = new ArrayAdapter<String>(ScanView.this,  
		                      android.R.layout.simple_spinner_item, strminFrm);  
		         	spada_minFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		         	spminFrm.setAdapter(spada_minFrm);  
		         	spminFrm.setSelection(0,false);
		       }
		       else if(m==0){ 
				    strmaxFrm=new String[61];
		        	strminFrm=new String[61];
		        	for(int i=0;i<61;i++){
		        		String temp="";
		        		float values=(float) (840 + i * 2);
		        		temp=String.valueOf(values)+"MHz";
		        		strminFrm[i]=temp;
		        		strmaxFrm[i]=temp;
		        	}
		        	spmaxFrm=(Spinner)findViewById(R.id.max_spinner);  
		        	spada_maxFrm = new ArrayAdapter<String>(ScanView.this,  
		                     android.R.layout.simple_spinner_item, strmaxFrm);  
		        	spada_maxFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		        	spmaxFrm.setAdapter(spada_maxFrm);  
		        	spmaxFrm.setSelection(60,false);
		        	
		        	spminFrm=(Spinner)findViewById(R.id.min_spinner);  
		        	spada_minFrm = new ArrayAdapter<String>(ScanView.this,  
		                     android.R.layout.simple_spinner_item, strminFrm);  
		        	spada_minFrm.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		        	spminFrm.setAdapter(spada_minFrm);  
		        	spminFrm.setSelection(0,false);
		    }
		}catch(Exception ex)
		{}
		lastBand =m;
	}
}
