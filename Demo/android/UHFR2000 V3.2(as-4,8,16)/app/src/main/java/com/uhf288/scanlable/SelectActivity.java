package com.uhf288.scanlable;

import com.uhf288.scanlable.R;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;

public class SelectActivity extends Activity implements OnClickListener{
	private Button btn_232,btn_tcp;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_select);
		btn_232=(Button) findViewById(R.id.btnrs232);
		btn_tcp=(Button) findViewById(R.id.btntcp);
		btn_232.setOnClickListener(this);
		btn_tcp.setOnClickListener(this);
	}
	
	@Override
	public void onClick(View v) {
		switch (v.getId()) {
			case R.id.btnrs232:
				Intent intent;
				intent = new Intent().setClass(SelectActivity.this, Connect232.class);
				startActivity(intent);
				break;
			case R.id.btntcp:
				Intent intent2;
				intent2 = new Intent().setClass(SelectActivity.this, ConnectTcp.class);
				startActivity(intent2);
				break;
			default:
				break;
		}
		
	}

}

