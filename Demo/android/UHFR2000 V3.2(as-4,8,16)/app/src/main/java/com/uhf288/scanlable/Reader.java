package com.uhf288.scanlable;
import java.sql.Date;
import java.text.SimpleDateFormat;

import android.widget.TextView;

import com.rfid.trans.UHFLib;
public class Reader {
	public static UHFLib rrlib = null;
	public  static void writelog(String log,TextView tvResult)
	{
		SimpleDateFormat simpleDateFormat = new SimpleDateFormat("HH:mm:ss");// HH:mm:ss
		Date date = new Date(System.currentTimeMillis());
		String textlog = simpleDateFormat.format(date)+" "+log;
		tvResult.setText(textlog);
	}
}
