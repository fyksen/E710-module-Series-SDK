package com.uhf288.scanlable;

import java.util.ArrayList;
import java.util.HashMap;

import android.net.Uri;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.os.SystemClock;
import android.app.Activity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;
import android.widget.AdapterView.OnItemClickListener;

import com.ibamb.dnet.module.beans.*;
import com.ibamb.dnet.module.api.UdmClient;

public class UdmActivity extends Activity implements OnItemClickListener {
	private Handler mHandler;
	TextView txtInfo;
	Button btSearch;
	private static final int MSG_SHOW_RESULT = 1;
	private static final int MSG_SHOW_DEV = 2;
	private ArrayList<DeviceModel> deviceList;
	SimpleAdapter adaptermdev;
	ListView devLv;
	private HashMap<String, String> map;
	private static ArrayList<HashMap<String, String>> mList;
	
	Thread mThread=null;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_udm);
		mHandler = new Handler(){
			@Override
			public void handleMessage(Message msg) {
				// TODO Auto-generated method stub
				super.handleMessage(msg);
				switch (msg.what) {
				case MSG_SHOW_RESULT:
					 String temp = (String) msg.obj;
					 txtInfo.setText(temp);
					 break;	
				case MSG_SHOW_DEV:
					String DevInfo = (String) msg.obj;
					String[] btDev = DevInfo.split(",");
					map = new HashMap<String, String>();
					map.put("DevIP", btDev[0]);
					map.put("DevMAC", btDev[1]);
					mList.add(map);
				
					devLv.setAdapter(adaptermdev);
					adaptermdev.notifyDataSetChanged();
					break;
				default:
					break;
				}
			}
		};
		
		mList = new ArrayList<HashMap<String, String>>();
		adaptermdev = new SimpleAdapter(UdmActivity.this, mList, R.layout.listitem,
				new String[] { "DevIP", "DevMAC"},
				new int[] { R.id.tv_deviceip, R.id.tv_devicemac});
		txtInfo = (TextView) findViewById(R.id.scan_devinfo);
		devLv = (ListView) findViewById(R.id.lv);
		devLv.setOnItemClickListener(this);
		btSearch = (Button) findViewById(R.id.btsearchdev);
		btSearch.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View v) {
				if(mList!=null)
				{
					mList.clear();
					adaptermdev.notifyDataSetChanged();
				}
				new InitTask().execute();
			}
		});
		//new InitTask().execute();
	}

	
	/**
	 * 初始化
	 * 
	 * @author liuruifeng 
	 */	
	public class InitTask extends AsyncTask<String, Integer, Boolean> {
		ProgressDialog mypDialog;
		
		@Override
		protected Boolean doInBackground(String... params) {
			// TODO Auto-generated method stub
			
			searchdev();
			return true;
		}
		@Override
		protected void onPostExecute(Boolean result) {
			super.onPostExecute(result);//
			
			//mypDialog.cancel();
		}

		@Override
		protected void onPreExecute() {
			// TODO Auto-generated method stub
			super.onPreExecute();
			mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.info_search)).sendToTarget();
			
		}
	}


	@Override
	public void onItemClick(AdapterView<?> arg0, View arg1, int position, long arg3) {
		// TODO Auto-generated method stub
		map = mList.get(position);
		String ipAddr = map.get("DevIP");
		Intent intent = new Intent();
        intent.setAction("android.intent.action.VIEW");
        Uri content_url = Uri.parse("http://"+ipAddr+"/");//此处填链接
        intent.setData(content_url);
        startActivity(intent);
	}
	
	private void searchdev()
	{
		if(mThread==null)
		{
			mThread = new Thread(new Runnable() 
			{  
	            @Override  
	            public void run() 
	            {  
	            	 UdmClient udmClient = UdmClient.getInstance();
	                 deviceList = udmClient.searchDevice("");
	                 if (deviceList == null) {
	                     int tryMaxCount = 3;
	                     for (int i = tryMaxCount; i > 0; i--) {
	                         deviceList = udmClient.searchDevice("");
	                         if (deviceList != null && !deviceList.isEmpty()) {
	                             break;
	                         }
	                     }
	                 }
	                 for(int m=0;m<deviceList.size();m++)
	                 {
	                	 DeviceModel md = deviceList.get(m);
	                	 String devInfo = md.getIp()+","+md.getMac();
	                	 mHandler.obtainMessage(MSG_SHOW_DEV,devInfo).sendToTarget(); 
	                 }
	                 mHandler.obtainMessage(MSG_SHOW_RESULT,getString(R.string.info_searchfinish)).sendToTarget();
	                 mThread =null;
	            } 
	        }); 
			
			mThread.start();
		}
	}

}
