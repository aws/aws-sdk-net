package com.amazonaws.unity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import com.amazonaws.unity.awsandroidhelper.R;

public class AWSTestActivity extends AppCompatActivity {

    private static String LOG_TAG = "AWSTestActivity";

    private Button btnStartTests;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_awstest);

        btnStartTests = (Button) findViewById(R.id.btnStartTests);

        btnStartTests.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.d(LOG_TAG, "sending messgae to unity code to start execution");
                UnityReflectionWrapper.SendMessage("OnTestStart", "Test Started");
            }
        });
    }

    /**
     * Starts the current activity
     */
    public static void startActivity() {
        Context context = UnityReflectionWrapper.getUnityActivity();
        Intent thisActivity = new Intent();
        thisActivity.setClass(context, AWSTestActivity.class);
        context.startActivity(thisActivity);
    }

}
