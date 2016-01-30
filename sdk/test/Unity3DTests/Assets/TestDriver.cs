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

        internal static Queue<string> Results { get; set; }

        private static TestDriver _instance;

        private int retryCount;


        /*
        #if UNITY_EDITOR
                // Use this for initialization
                void Start()
                {
                    InitializeDriver();
                    StartTests();
                }

                void Update()
                {
                    if (Results.Count > 0)
                    {
                        ResultsText.text += Results.Dequeue();
                        ResultsText.text += Environment.NewLine;
                    }
                }

        # el
                */
#if UNITY_ANDROID

        void Start()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = this;

                    DontDestroyOnLoad(this);

                    InitializeDriver();
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
        Queue<Action> mainThread = new Queue<Action>();
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
            if (Results.Count > 0)
            {
                ResultsText.text += Results.Dequeue();
                ResultsText.text += Environment.NewLine;
            }

            if (mainThread.Count > 0)
            {
                var action = mainThread.Dequeue();
                if (action != null)
                    action();
            }
        }

        private void InitializeDriver()
        {
            Results = new Queue<string>();

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

        public void OnTestFinished(int pass, int fail, HashSet<string> failedTestFixture)
        {
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
            var runner = new TestRunner();

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                runner.RunTests();
            }));
        }

    }
}