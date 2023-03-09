package com.uhf288.scanlable;

import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;
import java.util.Timer;
import java.util.TimerTask;

import com.rfid.trans.ReadTag;
import com.rfid.trans.TagCallback;
//import com.UHF.scanlable.UHfData.InventoryTagMap;

import android.app.Activity;
import android.content.Context;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.AdapterView.OnItemSelectedListener;
import android.widget.BaseAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.TextView;

public class ScanMode extends Activity implements OnClickListener, OnItemClickListener,OnItemSelectedListener{
	
	private String mode;
	Button scan;
	ListView listView;
	TextView txNum;
	TextView txTime;
	long beginTime =0;
	private Timer timer;
	private MyAdapter myAdapter;
	private Handler mHandler;
	private boolean isCanceled = true;
	Spinner s_mem;
	private static final int SCAN_INTERVAL = 20;
	private static final int MSG_UPDATE_LISTVIEW = 0;
	private static final int MSG_UPDATE_TIME = 1;
	private static final int MSG_UPDATE_BUTTON = 2;
    private int MaxAntennaNum=4;
	public static class InventoryTagMap  {
		public String strEPC;
		public int antenna;
		public String strRSSI;
		public int nReadCount;
	}
	public static List<InventoryTagMap> lsTagList = new ArrayList<InventoryTagMap>();
	public Map<String, Integer> dtIndexMap =new LinkedHashMap<String, Integer>();
	private List<InventoryTagMap> data;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		try
		{
			setContentView(R.layout.query);	
			scan = (Button)findViewById(R.id.button_scan);
			scan.setOnClickListener(this);
			
			listView = (ListView)findViewById(R.id.tag_real_list_view);
			listView.setOnItemClickListener(this);
			data = new ArrayList<InventoryTagMap>();
			txNum = (TextView)findViewById(R.id.tx_num);
			txTime = (TextView)findViewById(R.id.tx_time);
			
			mHandler = new Handler(){

				@Override
				public void handleMessage(Message msg) {
					// TODO Auto-generated method stub

					switch (msg.what) {
					case MSG_UPDATE_LISTVIEW:
						if(isCanceled)return;
						data = lsTagList;
						if(myAdapter == null){
							myAdapter = new MyAdapter(ScanMode.this, new ArrayList(data));
							listView.setAdapter(myAdapter);
						}else{
							myAdapter.mList = new ArrayList(data);
						}
						txNum.setText(String.valueOf(myAdapter.getCount()));
						myAdapter.notifyDataSetChanged();
						break;
					case MSG_UPDATE_TIME:
						long endTime = System.currentTimeMillis();
						txTime.setText(String.valueOf(endTime-beginTime));
						break;
					case MSG_UPDATE_BUTTON:
						scan.setText(getString(R.string.btscan));
						break;
					default:
						break;
					}
					super.handleMessage(msg);
				}
				
			};
		}
		catch(Exception e)
		{
			
		}
	}
	
	@Override
	protected void onResume() {
		// TODO Auto-generated method stub
		super.onResume();
		scan.setText(getString(R.string.btscan));
	}
	
	@Override
	public void onClick(View arg0) {
		try
		{
			if(scan.getText().toString().equals(getString(R.string.btscan))){
				isCanceled=false;
				MsgCallback callback = new MsgCallback();
				Reader.rrlib.SetCallBack(callback);
				if(Reader.rrlib.StartRead()==0)
				{
					MaxAntennaNum = Reader.rrlib.GetInventoryPatameter().MaxAntennaNum;
					if (myAdapter != null) {
						txNum.setText("0");
						txTime.setText("0");
						myAdapter.notifyDataSetChanged();
						mHandler.removeMessages(MSG_UPDATE_LISTVIEW);
						mHandler.sendEmptyMessage(MSG_UPDATE_LISTVIEW);
					}
					beginTime = System.currentTimeMillis();
					timer = new Timer();
					timer.schedule(new TimerTask() {
						@Override
						public void run() {
							mHandler.removeMessages(MSG_UPDATE_TIME);
							mHandler.sendEmptyMessage(MSG_UPDATE_TIME);
						}
					}, 0, SCAN_INTERVAL);
					scan.setText(getString(R.string.btstop));
					lsTagList = new ArrayList<InventoryTagMap>();
					dtIndexMap =new LinkedHashMap<String, Integer>();
				}


			}else{
				cancelScan();
			}
		}
		catch(Exception e)
		{
			cancelScan();
		}
	}
	
	private void cancelScan(){
		Reader.rrlib.StopRead();
		scan.setText(getString(R.string.btstoping));
		isCanceled = true;
		if(timer != null){
			timer.cancel();
			timer = null;
		}
	}
	
	public class MsgCallback implements TagCallback {

		@Override
		public void tagCallback(ReadTag arg0) {
			// TODO Auto-generated method stub
			String epc = arg0.epcId.toUpperCase();
			String DevName = arg0.DevName;
			InventoryTagMap m;
			Integer findIndex = dtIndexMap.get(epc);
			if (findIndex == null) {
				dtIndexMap.put(epc,dtIndexMap.size());
				 m = new InventoryTagMap();
				 m.strEPC = epc;
				 m.antenna = 1<<(arg0.antId-1);
				 m.strRSSI = String.valueOf(arg0.rssi);
				 m.nReadCount =1;
				 lsTagList.add(m);
			}
			else
			{
				 m= lsTagList.get(findIndex);
				 m.antenna |= 1<<(arg0.antId-1);
				 m.nReadCount++;
				 m.strRSSI = String.valueOf(arg0.rssi);
			}
			mHandler.removeMessages(MSG_UPDATE_LISTVIEW);
			mHandler.sendEmptyMessage(MSG_UPDATE_LISTVIEW);
		}

		@Override
		public int tagCallbackFailed(int reason) {
			// TODO Auto-generated method stub
			return 0;
		}

		@Override
		public void ReadOver() {
			mHandler.removeMessages(MSG_UPDATE_BUTTON);
			mHandler.sendEmptyMessage(MSG_UPDATE_BUTTON);
		}
	};
	
	@Override
	public void onItemClick(AdapterView<?> arg0, View arg1, int position, long arg3) {

	}
	
	@Override
	protected void onPause() {
		// TODO Auto-generated method stub
		super.onPause();
		cancelScan();
	}
	
	@Override
	protected void onDestroy() {
		// TODO Auto-generated method stub
		super.onDestroy();
	}
	
	class MyAdapter extends BaseAdapter{
		
		private Context mContext;
		private List<InventoryTagMap> mList;
		private LayoutInflater layoutInflater;
		
		public MyAdapter(Context context, List<InventoryTagMap> list) {
			mContext = context;
			mList = list;
			layoutInflater = LayoutInflater.from(context);
		}

		@Override
		public int getCount() {
			// TODO Auto-generated method stub
			return mList.size();
		}

		@Override
		public Object getItem(int position) {
			// TODO Auto-generated method stub
			return mList.get(position);
		}

		@Override
		public long getItemId(int arg0) {
			// TODO Auto-generated method stub
			return 0;
		}

		@Override
		public View getView(int position, View view, ViewGroup viewParent) {
			// TODO Auto-generated method stub
			ItemView iv = null;
			if(view == null){
				iv = new ItemView();
				view = layoutInflater.inflate(R.layout.list, null);
				iv.tvId = (TextView)view.findViewById(R.id.id_text);
				iv.tvEpc = (TextView)view.findViewById(R.id.epc_text);
				iv.tvTime = (TextView)view.findViewById(R.id.times_text);
				iv.tvRssi = (TextView)view.findViewById(R.id.rssi_text);
				iv.tvAnt = (TextView)view.findViewById(R.id.ant_text);
				view.setTag(iv);
			}else{
				iv = (ItemView)view.getTag();
			}
			String epc = mList.get(position).strEPC;
			Integer findIndex = dtIndexMap.get(epc);
			if(findIndex!=null)
			{
				iv.tvId.setText(String.valueOf(findIndex+1));
				iv.tvEpc.setText(epc);
				iv.tvTime.setText(String.valueOf(mList.get(position).nReadCount));
				iv.tvRssi.setText(mList.get(position).strRSSI);
				int ant = mList.get(position).antenna;
				String str = Integer.toBinaryString(ant);
				String temp = str;
				for(int m=0;m<MaxAntennaNum-str.length();m++)
				{
					temp="0"+temp;
				}
				iv.tvAnt.setText(temp);
				//String antStr = mList.get(position).antenna;
				//iv.tvAnt.setText(String.valueOf(antStr));
			}
		
			return view;
		}
		
		public class ItemView{
			TextView tvId;
			TextView tvEpc;
			TextView tvTime;
			TextView tvRssi;
			TextView tvAnt;
		}
	}
	
	@Override
	public void onItemSelected(AdapterView<?> arg0, View arg1, int position,
			long arg3) {
	}



	@Override
	public void onNothingSelected(AdapterView<?> arg0) {
		// TODO Auto-generated method stub
		
	}
}
