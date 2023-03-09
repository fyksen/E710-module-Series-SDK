package com.uhf288.scanlable;

import com.rfid.trans.ReaderParameter;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemSelectedListener;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;

public class ReadWriteActivity extends Activity implements OnClickListener, OnItemSelectedListener{
	
	private int mode;
	EditText edENum0;
	int selectedEd = 3;
	int selectedWhenPause = 0;
	
	Spinner c_mem;
	Spinner lock_mem;
	Spinner lock_type;

	EditText c_wordPtr;
	EditText c_len;
	EditText c_pwd;
	EditText c_kwd;
	EditText c_ptr;
	TextView tvResult;
	
	EditText b_id;
	EditText b_addr;
	EditText b_num;
	
	EditText content;
	EditText readContent;
	Button rButton;
	Button wButton;
	Button btWriteEPC;
	Button btLock;
	Button btKill;
	private ArrayAdapter<String> spada_epc; 
	Spinner spepc;
	private static final int CHECK_W_6B = 0;
	private static final int CHECK_R_6B = 1;
	private static final int CHECK_W_6C = 2;
	private static final int CHECK_R_6C = 3;
	private Handler mHandler;
	private static final int MSG_SHOW_RESULT = 1;
	private static final int MSG_SHOW_INFO = 2;

	byte select =0;
	byte setprotect = 0;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.rw_6c);
		initView();
		mHandler = new Handler(){
			@Override
			public void handleMessage(Message msg) {
				// TODO Auto-generated method stub
				super.handleMessage(msg);
				String temp;
				switch (msg.what) {
				case MSG_SHOW_RESULT:
					  temp = (String) msg.obj;
					 Reader.writelog(temp,tvResult);
					 break;
				case MSG_SHOW_INFO:
					 temp = (String) msg.obj;
					readContent.setText(temp);
					break;
				default:
					break;
				}
			}
		};
	}
	
	@Override
	protected void onResume() {
		// TODO Auto-generated method stub
		int epcCount = ScanMode.lsTagList.size();
		String[]epcdata = new String[epcCount];
		for(int m=0;m<epcCount;m++)
		{
			ScanMode.InventoryTagMap map = ScanMode.lsTagList.get(m);
			epcdata[m] = map.strEPC;
		}
		if(epcCount>0)
		{
			spada_epc = new ArrayAdapter<String>(ReadWriteActivity.this,  
	                android.R.layout.simple_spinner_item, epcdata);  
			spada_epc.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		   	spepc.setAdapter(spada_epc);  
		   	spepc.setSelection(0,false);
		}
		
		super.onResume();
	}
	
	@Override
	protected void onPause() {
		// TODO Auto-generated method stub
		super.onPause();
	}
	
	@Override
	protected void onDestroy() {
		// TODO Auto-generated method stub
		super.onDestroy();
	}
	
	private void initView(){
		//edENum0 = (EditText)findViewById(R.id.epc0);
		spepc = (Spinner)findViewById(R.id.epc_spinner);  
		tvResult = (TextView)findViewById(R.id.rw_result);	
		c_mem = (Spinner)findViewById(R.id.mem_spinner);
		ArrayAdapter<CharSequence> adapter =  ArrayAdapter.createFromResource(this, R.array.men_select, android.R.layout.simple_spinner_item);
		adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		c_mem.setAdapter(adapter); 
		c_mem.setSelection(3, true);
		c_mem.setOnItemSelectedListener(this);

		lock_mem = (Spinner)findViewById(R.id.lockmem_spinner);
		ArrayAdapter<CharSequence> adapter1 =  ArrayAdapter.createFromResource(this, R.array.arrayLockMem, android.R.layout.simple_spinner_item);
		adapter1.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		lock_mem.setAdapter(adapter1);
		lock_mem.setSelection(4, true);

		lock_type = (Spinner)findViewById(R.id.locktype_spinner);
		ArrayAdapter<CharSequence> adapter2 =  ArrayAdapter.createFromResource(this, R.array.arrayLock, android.R.layout.simple_spinner_item);
		adapter2.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		lock_type.setAdapter(adapter2);
		lock_type.setSelection(2, true);

		
		c_wordPtr = (EditText)findViewById(R.id.et_wordptr);
		c_wordPtr.setText("0");
		c_len = (EditText)findViewById(R.id.et_length);
		c_len.setText("6");
		c_pwd = (EditText)findViewById(R.id.et_pwd);
		c_pwd.setText("00000000");
		c_kwd = (EditText)findViewById(R.id.et_kwd);
		content = (EditText)findViewById(R.id.et_content_6c);
		readContent =  (EditText)findViewById(R.id.et_read_6c);
		rButton = (Button)findViewById(R.id.button_read_6c);
		wButton = (Button)findViewById(R.id.button_write_6c);
		btWriteEPC = (Button)findViewById(R.id.button_write_epc);
		btKill = (Button)findViewById(R.id.button_kill);
		btLock = (Button)findViewById(R.id.button_lock);
		rButton.setOnClickListener(this);
		wButton.setOnClickListener(this);	
		btWriteEPC.setOnClickListener(this);
		btKill.setOnClickListener(this);
		btLock.setOnClickListener(this);
	}
	
	@Override
	public void onBackPressed() {
	}

	@SuppressLint("ResourceAsColor")
	@Override
	public void onClick(View view) {
		if(view == wButton){
			if(!checkContent(CHECK_W_6C))return;
			try{
				final String str = spepc.getSelectedItem().toString();
				final byte Mem = (byte)c_mem.getSelectedItemPosition();
				final byte WordPtr =(byte)(int)Integer.valueOf(c_wordPtr.getText().toString());
				final byte[]Password = hexStringToBytes(c_pwd.getText().toString());
				final String strData =content.getText().toString();
				
				Thread mThread = new Thread(new Runnable() 
				{  
		            @Override  
		            public void run() 
		            {  
		            	
		            	int result = Reader.rrlib.WriteDataByEPC(str, Mem, WordPtr, Password, strData);
						if(result!=0){	
							mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.write_failed)).sendToTarget();
						}
						else{
							mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.write_success)).sendToTarget();
						}
		            }
		        }); 
				mThread.start();
			}catch(Exception ex)
			{Reader.writelog(getString(R.string.write_failed), tvResult);}
			
			
		}else if(view == rButton){
			if(!checkContent(CHECK_R_6C))return;
			try{
				ReaderParameter param = Reader.rrlib.GetInventoryPatameter();
				final String str = spepc.getSelectedItem().toString();
				final byte Mem = (byte)c_mem.getSelectedItemPosition();
				final byte Num = (byte)(int)Integer.valueOf(c_len.getText().toString());
				final byte WordPtr =(byte)(int)Integer.valueOf(c_wordPtr.getText().toString());
				final byte[]Password = hexStringToBytes(c_pwd.getText().toString());
				
				Thread mThread = new Thread(new Runnable() 
				{  
		            @Override  
		            public void run() 
		            {  
		            	
		            	String strData = Reader.rrlib.ReadDataByEPC(str, Mem, WordPtr,Num, Password);
						if(strData.length()==0){
							mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.get_failed)).sendToTarget();
						}
						else{
							mHandler.obtainMessage(MSG_SHOW_INFO,strData).sendToTarget();
							mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.get_success)).sendToTarget();
							
						}
		            }
		        }); 
				mThread.start();
			}catch(Exception ex)
			{
				Reader.writelog(getString(R.string.get_failed), tvResult);
			}
		}
		else if(view == btWriteEPC)
		{
			if(!checkContent(CHECK_W_6C))return;
			try{
				ReaderParameter param = Reader.rrlib.GetInventoryPatameter();
				final String str = spepc.getSelectedItem().toString();
				final byte[]Password = hexStringToBytes(c_pwd.getText().toString());
				final String strData =content.getText().toString();
				final int tidlen = param.TidLen;
				Thread mThread = new Thread(new Runnable() 
				{  
		            @Override  
		            public void run() 
		            {  
		            	int result =0x30;
		            	if(tidlen==0)
						{
		            		result = Reader.rrlib.WriteEPC(strData, Password);
		            		if(result!=0){
								mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.write_failed)).sendToTarget();
							}
							else{
								mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.write_success)).sendToTarget();
							}
							return;
						}
						else
						{
							result = Reader.rrlib.WriteEPCByTID(str, strData, Password);
						}
						if(result!=0){
							mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.write_failed)).sendToTarget();
						}
						else{
							mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.write_success)).sendToTarget();
						}
		            }
		        }); 
				mThread.start();
			}catch(Exception ex)
			{Reader.writelog(getString(R.string.write_failed), tvResult);}
		}
		else if(view == btKill)
		{
			try{
				final String str = spepc.getSelectedItem().toString();
				final String Password = c_kwd.getText().toString();
				if(Password==null || Password.length()!=8)return;
				Thread mThread = new Thread(new Runnable()
				{
					@Override
					public void run()
					{
						int result = Reader.rrlib.Kill(str,  Password);
						if(result!=0){
							mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.kill_failed)).sendToTarget();
						}
						else{
							mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.kill_success)).sendToTarget();
						}
					}
				});
				mThread.start();
			}catch(Exception ex)
			{Reader.writelog(getString(R.string.kill_failed), tvResult);}

		}
		else if(view == btLock)
		{
			try{
				int result = 0x30;
				final String PasswordStr = c_pwd.getText().toString();
				final String strEPC = spepc.getSelectedItem().toString();
				select = (byte) (lock_mem.getSelectedItemPosition());
				setprotect = (byte) (lock_type.getSelectedItemPosition());
				if(select==5)
				{
					select = (byte)255;
					setprotect = (byte)255;
				}
				Thread mThread = new Thread(new Runnable()
				{
					@Override
					public void run()
					{
						int result = Reader.rrlib.Lock(strEPC,select,setprotect,PasswordStr);
						if(result!=0){
							mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.lock_failed)).sendToTarget();
						}
						else{
							mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.lock_success)).sendToTarget();
						}
					}
				});
				mThread.start();
			}catch(Exception ex)
			{Reader.writelog(getString(R.string.lock_failed), tvResult);}
		}
	}

	@Override
	public void onItemSelected(AdapterView<?> arg0, View arg1, int position,
			long arg3) {
		selectedEd = position;
	}

	@Override
	public void onNothingSelected(AdapterView<?> arg0) {
		// TODO Auto-generated method stub
		
	}

	private boolean checkContent(int check){
		switch (check) {
		case CHECK_W_6C:
			if(Util.isEtEmpty(content)) return Util.showWarning(this,R.string.content_empty_warning);
			if(Integer.valueOf(c_len.getText().toString()) != content.getText().toString().length()/4) 
				return Util.showWarning(this,R.string.length_content_warning);
			if(!(Util.isLenLegal(content)))
				return Util.showWarning(this,R.string.str_lenght_odd_warning);
			if(!(Util.isLenLegal(c_pwd)))
				return Util.showWarning(this,R.string.str_lenght_odd_warning);
		case CHECK_R_6C:
			if(Util.isEtEmpty(c_wordPtr)) return Util.showWarning(this,R.string.wordptr_empty_warning);
			if(Util.isEtEmpty(c_len)) return Util.showWarning(this,R.string.length_empty_warning);
			if(Util.isEtEmpty(c_pwd)) return Util.showWarning(this,R.string.pwd_empty_warning);
			
			if(!(Util.isLenLegal(c_pwd)))
				return Util.showWarning(this,R.string.str_lenght_odd_warning);
			
			break;
		default:
			break;
		}
		return true;
	}
	
	public String bytesToHexString(byte[] src, int offset, int length) {
        StringBuilder stringBuilder = new StringBuilder("");
        if (src == null || src.length <= 0) {
            return null;
        }
        for (int i = offset; i < length; i++) {
            int v = src[i] & 0xFF;
            String hv = Integer.toHexString(v);
            if (hv.length() == 1) {
                stringBuilder.append(0);
            }
            stringBuilder.append(hv);
        }
        return stringBuilder.toString();
    }

	public byte[] hexStringToBytes(String hexString) {  
        if (hexString == null || hexString.equals("")) {  
            return null;  
        }  
        hexString = hexString.toUpperCase();  
        int length = hexString.length() / 2;  
        char[] hexChars = hexString.toCharArray();  
        byte[] d = new byte[length];  
        for (int i = 0; i < length; i++) {  
            int pos = i * 2;  
            d[i] = (byte) (charToByte(hexChars[pos]) << 4 | charToByte(hexChars[pos + 1]));  
        }  
        return d;  
    }   
    private byte charToByte(char c) {  
        return (byte) "0123456789ABCDEF".indexOf(c);  
    } 
}
