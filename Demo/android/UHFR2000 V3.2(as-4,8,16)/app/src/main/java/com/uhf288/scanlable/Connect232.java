package com.uhf288.scanlable;

import java.util.ArrayList;
import java.util.List;

import com.rfid.serialport.SerialPortFinder;
import com.rfid.trans.UHFLib;

import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.app.Activity;
import android.content.Intent;
import android.view.KeyEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;
public class Connect232 extends Activity {


		private static final String TAG = "COONECTRS232";
		private static String devport = "/dev/ttyHSL2";
		private static final boolean DEBUG = true;
		private TextView mConectButton;
			
		private List<String> mPortList = new ArrayList<String>();
		
		private TextView   mBaud9600View, mBaud19200View,  mBaud38400View,mBaud57600View,mBaud115200View;
		private Spinner mDropPort;

		private int mPosPort = -1;
		
		private SerialPortFinder mSerialPortFinder;
		
		String[] entries = null;
		String[] entryValues = null;
		private ArrayAdapter<String> spacom; 
		private int baud = 57600;
		private Handler mHandler;
		private static final int MSG_SHOW_RESULT = 0;
		@Override
		protected void onCreate(Bundle savedInstanceState) {
			super.onCreate(savedInstanceState);
			setContentView(R.layout.activity_connect232);
			mHandler = new Handler(){
				@Override
				public void handleMessage(Message msg) {
					// TODO Auto-generated method stub
					super.handleMessage(msg);
					switch (msg.what) {
					case MSG_SHOW_RESULT:
						mConectButton.setEnabled(true);
						 byte[]buffer = (byte[]) msg.obj;
	                     if(buffer[0]==0)
	                     {
	                    	 Intent intent;
							 intent = new Intent().setClass(Connect232.this, MainActivity.class);
							 startActivity(intent);
	                     }
	                     else
	                     {
	                    	 Toast.makeText(getApplication(),getString(R.string.openport_failed), Toast.LENGTH_SHORT).show();
	                     }
						break;
					default:
						break;
					}
				}
			};
			
			mSerialPortFinder = new SerialPortFinder();
			
			entries = mSerialPortFinder.getAllDevices();
	        entryValues = mSerialPortFinder.getAllDevicesPath();
			
			mConectButton = (TextView) findViewById(R.id.textview_connect);

			mBaud9600View = (TextView) findViewById(R.id.baud_9600);
			mBaud19200View =  (TextView) findViewById(R.id.baud_19200);
			mBaud38400View =  (TextView) findViewById(R.id.baud_38400);
			mBaud57600View =  (TextView) findViewById(R.id.baud_57600);
			mBaud115200View =  (TextView) findViewById(R.id.baud_115200);
			mDropPort = (Spinner) findViewById(R.id.spinner1);
			
			spacom = new ArrayAdapter<String>(Connect232.this,  
                    android.R.layout.simple_spinner_dropdown_item, entryValues);  
			mDropPort.setAdapter(spacom);  
			mDropPort.setSelection(0,false);
			devport = spacom.getItem(0);
			mDropPort.setOnItemSelectedListener(new Spinner.OnItemSelectedListener() {  
		        public void onItemSelected(AdapterView<?> arg0, View arg1,  
		                int position, long arg3) {  
		            // TODO Auto-generated method stub  
		        	 devport = spacom.getItem(position);
		             arg0.setVisibility(View.VISIBLE);  
		        }  
		        public void onNothingSelected(AdapterView<?> arg0) {  
		            // TODO Auto-generated method stub  
		        	}  
				});  
			
			baud = 57600;
			mBaud9600View.setOnClickListener(new OnClickListener() {
				@Override
				public void onClick(View v) {
					baud = 9600;
				}
			});
			
			mBaud19200View.setOnClickListener(new OnClickListener() {
				@Override
				public void onClick(View v) {
					baud = 19200;
				}
			});
			mBaud38400View.setOnClickListener(new OnClickListener() {
				@Override
				public void onClick(View v) {
					baud = 38400;
				}
			});
			
			mBaud57600View.setOnClickListener(new OnClickListener() {
				@Override
				public void onClick(View v) {
					baud = 57600;
				}
			});
			mBaud115200View.setOnClickListener(new OnClickListener() {
				@Override
				public void onClick(View v) {
					baud = 115200;
				}
			});
			

			mConectButton.setOnClickListener(new OnClickListener() {
				
				@Override
				public void onClick(View v) {
					try {
						mConectButton.setEnabled(false);
						Thread mThread = new Thread(new Runnable() 
						{  
				            @Override  
				            public void run() 
				            {  
				            	Reader.rrlib = new UHFLib(0,"");
				            	byte[]data = new byte[1];
				            	int result = Reader.rrlib.Connect(devport, baud);
				            	data[0] = (byte)(result);
				            	mHandler.obtainMessage(MSG_SHOW_RESULT, 1, -1, data).sendToTarget();
				            }  
				        }); 
						mThread.start();
					}catch (Exception e) 
					{
						Toast.makeText(
								getApplicationContext(),
								getString(R.string.openport_failed),
								Toast.LENGTH_SHORT).show();
					}
				}
			});
		}
		

		
		@Override
		protected void onResume() {
			// TODO Auto-generated method stub	
			super.onResume();
		}
		
		
	
		public boolean onKeyDown(int keyCode, KeyEvent event) {
			if (keyCode == KeyEvent.KEYCODE_BACK) {
				
				finish();

				return true;
			}
			return super.onKeyDown(keyCode, event);
		}
		
		@Override
		protected void onDestroy() {
			// TODO Auto-generated method stub
			super.onDestroy();
		}

}
