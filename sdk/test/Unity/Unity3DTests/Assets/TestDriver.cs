using UnityEngine;
using System.Collections;
using Amazon;
using System.Threading;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using AWSSDK.Tests.Framework;

namespace AWSSDK.Tests
{
    public class TestDriver : MonoBehaviour
    {
        public Text ResultsText;

        private static object _lock = new object();

        internal static Queue<string> Results = new Queue<string>();

        private static TestDriver _instance;

        private int retryCount = 0;

        private static Queue<Action> mainThread = new Queue<Action>();

        private TestRunner runner;

        void Awake()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = this;

                    DontDestroyOnLoad(this);

                    InitializeDriver();

                    if (mainThread == null)
                        mainThread = new Queue<Action>();

                    if (Results == null)
                        Results = new Queue<string>();

#if UNITY_EDITOR
                    StartTests();
#endif

                }
                else
                {
                    if (this != _instance)
                    {
                        //destroy the new instance
                        DestroyObject(this);
                    }
                }
            }
        }


#if UNITY_EDITOR
        private void PrintResult(string message)
        {

        }

#elif UNITY_ANDROID

        private void PrintResult(string message)
        {
            using (var ajc = new AndroidJavaClass("com.amazonaws.unity.AWSTestActivity"))
            {
                using (var ajo = ajc.CallStatic<AndroidJavaObject>("getCurrentActivity"))
                {
                    ajo.Call("printResult", message);
                }
            }
        }

#elif UNITY_IOS    
        
          
#endif
        /// <summary>
        /// Returns the Instance of UnityInitializer
        /// </summary>
        public static TestDriver Instance
        {
            get
            {
                return _instance;
            }
        }

        void Update()
        {
            try
            {
                if (Results != null && Results.Count > 0)
                {
                    try
                    {
                        ResultsText.text += Results.Dequeue();
                        ResultsText.text += Environment.NewLine;
                    }
                    catch
                    {
                        //supress
                    }
                }

                if (mainThread != null && mainThread.Count > 0)
                {
                    var action = mainThread.Dequeue();
                    if (action != null)
                        action.Invoke();
                }
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private void InitializeDriver()
        {
            UnityInitializer.AttachToGameObject(this.gameObject);

            //set sleep timeout to infinity
            Screen.sleepTimeout = SleepTimeout.NeverSleep;

            //set up logging
            var loggingConfig = AWSConfigs.LoggingConfig;
            loggingConfig.LogTo = LoggingOptions.UnityLogger;
            loggingConfig.LogMetrics = true;
            loggingConfig.LogResponses = ResponseLoggingOption.Always;
            loggingConfig.LogResponsesSizeLimit = 4096;
            loggingConfig.LogMetricsFormat = LogMetricsFormatOption.JSON;
            var context = AWSConfigsDynamoDB.Context;
        }

        public void OnTestFinished(int pass, int fail, HashSet<string> failedTestCases)
        {
            if (failedTestCases.Count > 0 && retryCount <= 3)
            {
                retryCount++;
                EnsureBackgroundExecution(() =>
                {
                    Debug.Log("retrying tests");
                    runner.RunTestsWithName(failedTestCases);
                });
                return;
            }

            mainThread.Enqueue(() =>
            {
                Debug.Log("OnTestFinished");

                if (fail > 0)
                    PrintResult("SOME TESTS FAILED");
                else
                    PrintResult("ALL TESTS PASSED");
            });
        }

        public void OnTestStart(string message)
        {
            Debug.Log(string.Format(@"Got Message {0}", message));
            StartTests();
        }

        private void StartTests()
        {
            runner = new TestRunner();

            EnsureBackgroundExecution(() =>
            {
                runner.RunTests();
            });
        }

        private void EnsureBackgroundExecution(Action action)
        {
            if (UnityInitializer.IsMainThread())
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    action.Invoke();
                }));
            }
            else
            {
                action.Invoke();
            }
        }

    }
}