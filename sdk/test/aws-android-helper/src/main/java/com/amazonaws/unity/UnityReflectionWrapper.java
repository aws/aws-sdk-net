package com.amazonaws.unity;

import android.app.Activity;
import android.util.Log;

import java.lang.reflect.Method;

/**
 * Created by saligram on 1/28/2016.
 */
public class UnityReflectionWrapper {
    private static String LOG_TAG = "UnityReflectionWrapper";

    private static Class unityPlayerActivity;

    private static String AWS_TEST_DRIVER = "TestDriver";

    /**
     * Send message to Unity Code
     *
     * @param unityMethod
     * @param message
     */
    public static void SendMessage(String unityMethod, String message) {
        try {
            if (unityPlayerActivity == null) {
                unityPlayerActivity = Class.forName("com.unity3d.player.UnityPlayer");
            }

            Method method = unityPlayerActivity.getMethod(
                    "UnitySendMessage", String.class, String.class, String.class);
            method.invoke(unityPlayerActivity, AWS_TEST_DRIVER, unityMethod, message);
        } catch (Exception ex) {
            Log.d(LOG_TAG, ex.toString());
        }
    }

    /**
     * @return instance of com.unity3d.player.UnityPlayer
     */
    public static Activity getUnityActivity() {
        try {
            if (unityPlayerActivity == null)
                unityPlayerActivity = Class.forName("com.unity3d.player.UnityPlayer");

            Activity activity = (Activity) unityPlayerActivity.getField("currentActivity").get(null);
            if (activity == null) {
                Log.d(LOG_TAG, "Current unity activity is null");
            }

            return activity;
        } catch (Exception e) {
            Log.e(LOG_TAG, e.toString());
        }
        return null;
    }
}
