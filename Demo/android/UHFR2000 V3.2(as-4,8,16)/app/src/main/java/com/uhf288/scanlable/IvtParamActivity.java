package com.uhf288.scanlable;

import android.os.Bundle;
import android.app.Activity;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.Spinner;
import android.widget.Toast;

import com.rfid.trans.*;
public class IvtParamActivity extends Activity implements OnClickListener{

	private Spinner spType;
	private Spinner spMem;
	private Spinner spStart;
	private Spinner spLength;
	
	private Spinner spQ;
	private Spinner spS;
	private Spinner spTime;
	private Spinner spTarget;
	private Spinner spCount;
	
	EditText txtPsd;
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
	
	Button btSet;
	Button btGet;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_ivt_param);
	    ////////////查询类型
		String[] strType = new String[3];
		strType[0]="EPC";
		strType[1]="TID";
		strType[2]= getString(R.string.info_mix);
		spType=(Spinner)findViewById(R.id.type_spinner);  
		ArrayAdapter<String> spada_Type = new ArrayAdapter<String>(IvtParamActivity.this,  
	             android.R.layout.simple_spinner_item, strType);  
		spada_Type.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		spType.setAdapter(spada_Type);  
		spType.setSelection(0,false); 
		
		
		 ////////////查询区域
		String[] strMem = new String[3];
		strMem[0]="EPC";
		strMem[1]="TID";
		strMem[2]="User";
		spMem=(Spinner)findViewById(R.id.mixmem_spinner);  
		ArrayAdapter<String> spada_Mem = new ArrayAdapter<String>(IvtParamActivity.this,  
	             android.R.layout.simple_spinner_item, strMem);  
		spada_Mem.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		spMem.setAdapter(spada_Mem);  
		spMem.setSelection(0,false); 
	
		////////////起始地址
		spStart = (Spinner)findViewById(R.id.start_spinner);
		ArrayAdapter<CharSequence> adapter1 =  ArrayAdapter.createFromResource(this, R.array.act_addr, android.R.layout.simple_spinner_item);
		adapter1.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spStart.setAdapter(adapter1); 
		spStart.setSelection(0, true);
		
		////////////读取长度
		spLength = (Spinner)findViewById(R.id.count_spinner);
		ArrayAdapter<CharSequence> adapter2 =  ArrayAdapter.createFromResource(this, R.array.act_len, android.R.layout.simple_spinner_item);
		adapter2.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spLength.setAdapter(adapter2); 
		spLength.setSelection(5, true);

		//////////Q值
		spQ = (Spinner)findViewById(R.id.qvalue_spinner);
		ArrayAdapter<CharSequence> adapter3 =  ArrayAdapter.createFromResource(this, R.array.men_q, android.R.layout.simple_spinner_item);
		adapter3.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spQ.setAdapter(adapter3); 
		spQ.setSelection(4, true);
		/////////Session值
		spS = (Spinner)findViewById(R.id.session_spinner);
		ArrayAdapter<CharSequence> adapter4 =  ArrayAdapter.createFromResource(this, R.array.men_s, android.R.layout.simple_spinner_item);
		adapter4.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spS.setAdapter(adapter4); 
		spS.setSelection(1, true);
		////////查询时间
		spTime = (Spinner)findViewById(R.id.scantime_spinner);
		ArrayAdapter<CharSequence> adapter5 =  ArrayAdapter.createFromResource(this, R.array.men_time, android.R.layout.simple_spinner_item);
		adapter5.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spTime.setAdapter(adapter5); 
		spTime.setSelection(10, true);
		
		 ////////////Target
		String[] strTar= new String[2];
		strTar[0]="A";
		strTar[1]="B";
		spTarget=(Spinner)findViewById(R.id.target_spinner);  
		ArrayAdapter<String> spada_tar = new ArrayAdapter<String>(IvtParamActivity.this,  
	             android.R.layout.simple_spinner_item, strTar);  
		spada_Mem.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
		spTarget.setAdapter(spada_tar);  
		spTarget.setSelection(0,false); 
		
		////////////无标签次数切换A/B
		spCount = (Spinner)findViewById(R.id.change_spinner);
		ArrayAdapter<CharSequence> adapter6 =  ArrayAdapter.createFromResource(this, R.array.act_addr, android.R.layout.simple_spinner_item);
		adapter6.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spCount.setAdapter(adapter6); 
		spCount.setSelection(8, true);
		
		txtPsd = (EditText)findViewById(R.id.et_pwd);  
		
		Ant1 = (CheckBox)findViewById(R.id.scanAnt1);  
		Ant2 = (CheckBox)findViewById(R.id.scanAnt2); 
		Ant3 = (CheckBox)findViewById(R.id.scanAnt3); 
		Ant4 = (CheckBox)findViewById(R.id.scanAnt4);

		Ant5 = (CheckBox)findViewById(R.id.scanAnt5);
		Ant6 = (CheckBox)findViewById(R.id.scanAnt6);
		Ant7 = (CheckBox)findViewById(R.id.scanAnt7);
		Ant8 = (CheckBox)findViewById(R.id.scanAnt8);

		Ant9 = (CheckBox)findViewById(R.id.scanAnt9);
		Ant10 = (CheckBox)findViewById(R.id.scanAnt10);
		Ant11 = (CheckBox)findViewById(R.id.scanAnt11);
		Ant12 = (CheckBox)findViewById(R.id.scanAnt12);

		Ant13 = (CheckBox)findViewById(R.id.scanAnt13);
		Ant14 = (CheckBox)findViewById(R.id.scanAnt14);
		Ant15 = (CheckBox)findViewById(R.id.scanAnt15);
		Ant16 = (CheckBox)findViewById(R.id.scanAnt16);

		btSet = (Button)findViewById(R.id.btSetParam);
		btGet = (Button)findViewById(R.id.btGetParam);
		btSet.setOnClickListener(this);
		btGet.setOnClickListener(this);

		line1 = (LinearLayout) findViewById(R.id.scanGroup1);
		line2 = (LinearLayout) findViewById(R.id.scanGroup2);
		line3 = (LinearLayout) findViewById(R.id.scanGroup3);
		line4 = (LinearLayout) findViewById(R.id.scanGroup4);
		GetParam();
	}

	@Override
	public void onClick(View arg0) {
		// TODO Auto-generated method stub
		if(arg0 == btSet)
		{
			if((txtPsd.getText()==null)||(txtPsd.getText().toString().length()!=8))
			{
				Toast.makeText(getApplication(),getString(R.string.info_psw_length_error), Toast.LENGTH_SHORT).show();
                return;
			}
			ReaderParameter param = Reader.rrlib.GetInventoryPatameter();
			param.IvtType     = spType.getSelectedItemPosition();
			param.Memory      = spMem.getSelectedItemPosition()+1;
			param.Password    = txtPsd.getText().toString();
			param.TidPtr      = spStart.getSelectedItemPosition();
			param.TidLen      = spLength.getSelectedItemPosition()+1;
			param.Session     = spS.getSelectedItemPosition();
			if(param.Session==4)param.Session=255;
			param.QValue      = spQ.getSelectedItemPosition();
			param.ScanTime    = spTime.getSelectedItemPosition()+1;
			param.Target      = spTarget.getSelectedItemPosition();
			param.reTryCount  = spCount.getSelectedItemPosition();
			
			param.Antenna     = 0;
			if(Ant1.isChecked())param.Antenna|=0x0001;
			if(Ant2.isChecked())param.Antenna|=0x0002;
			if(Ant3.isChecked())param.Antenna|=0x0004;
			if(Ant4.isChecked())param.Antenna|=0x0008;

			if(Ant5.isChecked())param.Antenna|=0x0010;
			if(Ant6.isChecked())param.Antenna|=0x0020;
			if(Ant7.isChecked())param.Antenna|=0x0040;
			if(Ant8.isChecked())param.Antenna|=0x0080;

			if(Ant9.isChecked())param.Antenna|=0x0100;
			if(Ant10.isChecked())param.Antenna|=0x0200;
			if(Ant11.isChecked())param.Antenna|=0x0400;
			if(Ant12.isChecked())param.Antenna|=0x0800;

			if(Ant13.isChecked())param.Antenna|=0x1000;
			if(Ant14.isChecked())param.Antenna|=0x2000;
			if(Ant15.isChecked())param.Antenna|=0x4000;
			if(Ant16.isChecked())param.Antenna|=0x8000;
			
			Reader.rrlib.SetInventoryPatameter(param);	
			Toast.makeText(getApplication(),getString(R.string.set_success), Toast.LENGTH_SHORT).show();

		}
		else if(arg0 == btGet)
		{
			GetParam();
		}
	}

	
	private void GetParam()
	{
		ReaderParameter param = Reader.rrlib.GetInventoryPatameter();
		spType.setSelection(param.IvtType, false);
		spMem.setSelection(param.Memory-1, false);
		txtPsd.setText(param.Password);
		spStart.setSelection(param.TidPtr, false);
		spLength.setSelection(param.TidLen-1, false);
		if(param.Session==255)
		{
			spS.setSelection(4, false);
		}
		else
			spS.setSelection(param.Session, false);
		spQ.setSelection(param.QValue, false);
		
		spTime.setSelection(param.ScanTime-1, false);
		spTarget.setSelection(param.Target, false);
		spCount.setSelection(param.reTryCount,false);
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
		if((param.Antenna&0x0001)==0x0001)
			Ant1.setChecked(true);
		else
			Ant1.setChecked(false);
		
		if((param.Antenna&0x0002)==0x0002)
			Ant2.setChecked(true);
		else
			Ant2.setChecked(false);
		
		if((param.Antenna&0x0004)==0x0004)
			Ant3.setChecked(true);
		else
			Ant3.setChecked(false);
		
		if((param.Antenna&0x0008)==0x0008)
			Ant4.setChecked(true);
		else
			Ant4.setChecked(false);


		if((param.Antenna&0x0010)==0x0010)
		Ant5.setChecked(true);
	else
		Ant5.setChecked(false);

		if((param.Antenna&0x0020)==0x0020)
			Ant6.setChecked(true);
		else
			Ant6.setChecked(false);

		if((param.Antenna&0x0040)==0x0040)
			Ant7.setChecked(true);
		else
			Ant7.setChecked(false);

		if((param.Antenna&0x0080)==0x0080)
			Ant8.setChecked(true);
		else
			Ant8.setChecked(false);

		if((param.Antenna&0x0100)==0x0100)
			Ant9.setChecked(true);
		else
			Ant9.setChecked(false);

		if((param.Antenna&0x0200)==0x0200)
			Ant10.setChecked(true);
		else
			Ant10.setChecked(false);

		if((param.Antenna&0x0400)==0x0400)
			Ant11.setChecked(true);
		else
			Ant11.setChecked(false);

		if((param.Antenna&0x0800)==0x0800)
			Ant12.setChecked(true);
		else
			Ant12.setChecked(false);

		if((param.Antenna&0x1000)==0x1000)
			Ant13.setChecked(true);
		else
			Ant13.setChecked(false);

		if((param.Antenna&0x2000)==0x2000)
			Ant14.setChecked(true);
		else
			Ant14.setChecked(false);

		if((param.Antenna&0x4000)==0x4000)
			Ant15.setChecked(true);
		else
			Ant15.setChecked(false);

		if((param.Antenna&0x8000)==0x8000)
			Ant16.setChecked(true);
		else
			Ant16.setChecked(false);

		Toast.makeText(getApplication(),getString(R.string.get_success), Toast.LENGTH_SHORT).show();
	}

}
