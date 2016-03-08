package com.amazonaws.unity;

import com.unity3d.player.UnityPlayer;

import android.annotation.TargetApi;
import android.app.Activity;
import android.content.Context;
import android.content.res.Configuration;
import android.graphics.PixelFormat;
import android.os.Build;
import android.os.Bundle;
import android.util.Log;
import android.view.KeyEvent;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.FrameLayout;
import android.widget.FrameLayout.LayoutParams;
import android.widget.TextView;

public class AWSTestActivity extends Activity {

	public static Context mContext;
	protected UnityPlayer mUnityPlayer;

	private static String LOG_TAG = "AWSTestActivity";

	private static String AWS_TEST_DRIVER = "TestDriver";

	private Button btnStartTests;
	private TextView txtResultText;

	@TargetApi(Build.VERSION_CODES.GINGERBREAD)
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		super.onCreate(savedInstanceState);

		try {
			mContext = this;
			getWindow().takeSurface(null);

			setTheme(android.R.style.Theme_NoTitleBar_Fullscreen);
			getWindow().setFormat(PixelFormat.RGB_565);

			mUnityPlayer = new UnityPlayer(this);
			if (mUnityPlayer.getSettings().getBoolean("hide_status_bar", true))
				getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
						WindowManager.LayoutParams.FLAG_FULLSCREEN);

			int glesMode = mUnityPlayer.getSettings().getInt("gles_mode", 1);
			boolean trueColor8888 = false;
			mUnityPlayer.init(glesMode, trueColor8888);

			View playerView = mUnityPlayer.getView();

			setContentView(R.layout.activity_awstest);
			
			FrameLayout layout = (FrameLayout) findViewById(R.id.layout_main);
			LayoutParams lp = new LayoutParams(LayoutParams.MATCH_PARENT, LayoutParams.MATCH_PARENT);

			layout.addView(playerView, 0, lp);
			btnStartTests = (Button) findViewById(R.id.btnStartTests);
			btnStartTests.setOnClickListener(new View.OnClickListener() {

				@Override
				public void onClick(View v) {
					UnityPlayer.UnitySendMessage(AWS_TEST_DRIVER, "OnTestStart", "testStarted");
				}
			});

			txtResultText = (TextView) findViewById(R.id.status);

		} catch (Exception e) {
			Log.e(LOG_TAG, "exception");
			Log.e(LOG_TAG, e.getMessage());
		}
	}

	protected void onDestroy() {
		mUnityPlayer.quit();
		super.onDestroy();
	}

	protected void onPause() {
		super.onPause();
		mUnityPlayer.pause();
	}

	protected void onResume() {
		super.onResume();
		mUnityPlayer.resume();
	}

	public void onConfigurationChanged(Configuration newConfig) {
		super.onConfigurationChanged(newConfig);
		mUnityPlayer.configurationChanged(newConfig);
	}

	public void onWindowFocusChanged(boolean hasFocus) {
		super.onWindowFocusChanged(hasFocus);
		mUnityPlayer.windowFocusChanged(hasFocus);
	}

	public boolean dispatchKeyEvent(KeyEvent event) {
		if (event.getAction() == KeyEvent.ACTION_MULTIPLE)
			return mUnityPlayer.onKeyMultiple(event.getKeyCode(), event.getRepeatCount(), event);
		return super.dispatchKeyEvent(event);
	}

	public static AWSTestActivity getCurrentActivity() {
		return (AWSTestActivity) mContext;
	}

	public void printResult(final String message) {
		runOnUiThread(new Runnable() {
			
			@Override
			public void run() {
				Log.d(LOG_TAG, "setting text box to value " + message);
				txtResultText.setText(message);
			}
		});
		
	}

}