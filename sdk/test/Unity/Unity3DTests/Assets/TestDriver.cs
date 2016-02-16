using UnityEngine;
using System.Collections;
using Amazon;
using System.Threading;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using AWSSDK.Tests.Framework;
using NUnit.Framework.Interfaces;
using System.Linq;

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

#if UNITY_EDITOR || UNITY_IOS
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

        private void PrintResult(string message)
        {

        }
          
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
            failedWWWTests = new HashSet<string>();
            failedUWRTests = new HashSet<string>();
            //set sleep timeout to infinity
            Screen.sleepTimeout = SleepTimeout.NeverSleep;

            //set up logging
            var loggingConfig = AWSConfigs.LoggingConfig;
            loggingConfig.LogTo = LoggingOptions.UnityLogger;
            loggingConfig.LogMetrics = true;
            loggingConfig.LogResponses = ResponseLoggingOption.Always;
            loggingConfig.LogResponsesSizeLimit = 4096;
            loggingConfig.LogMetricsFormat = LogMetricsFormatOption.JSON;
        }

        private HashSet<string> failedWWWTests;
        private HashSet<string> failedUWRTests;

        public void OnTestFinished(int pass, int fail, AWSConfigs.HttpClientOption hco, HashSet<string> failedTestCases)
        {
            if (hco == AWSConfigs.HttpClientOption.UnityWebRequest)
            {
                failedUWRTests.UnionWith(failedTestCases);
            }
            else
            {
                failedWWWTests.UnionWith(failedTestCases);
            }

            if (!allTestsStarted)
            {
                Debug.Log(@"Tests on both http client have not completed, returning");
                return;
            }

            Debug.Log(string.Format(@"the following test cases will be retried for WWW = {0} & UWR= {1}",
                string.Join(",", failedWWWTests.ToArray<string>()), string.Join(",", failedUWRTests.ToArray<string>())));

            if (retryCount < 3 && (failedUWRTests.Count > 0 || failedWWWTests.Count > 0))
            {
                allTestsStarted = false;
                HashSet<string> testNamesToRetryForWWW = failedWWWTests;
                HashSet<string> testNamesToRetryForUWR = failedUWRTests;

                failedWWWTests = new HashSet<string>();
                failedUWRTests = new HashSet<string>();

                retryCount++;
                EnsureBackgroundExecution(() =>
                {
                    int count = 0;
                    foreach (var httpClient in new AWSConfigs.HttpClientOption[]
                        { AWSConfigs.HttpClientOption.UnityWWW,
                        AWSConfigs.HttpClientOption.UnityWebRequest })
                    {
                        if (count == 1)
                            allTestsStarted = true;

                        AWSConfigs.HttpClient = httpClient;

                        if (httpClient == AWSConfigs.HttpClientOption.UnityWWW)
                        {
                            if (testNamesToRetryForWWW.Count > 0)
                            {
                                runner.HttpClient = httpClient;
                                runner.RunTestsWithCategory("WWW", testNamesToRetryForWWW);
                            }
                        }
                        else
                        {
                            if (testNamesToRetryForUWR.Count > 0)
                            {
                                runner.HttpClient = httpClient;
                                runner.RunTestsWithName(testNamesToRetryForUWR);
                            }
                        }

                        Thread.Sleep(TimeSpan.FromSeconds(5));

                        count++;
                    }
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

        /// <summary>
        /// used for callback from android/ios buttons
        /// </summary>
        /// <param name="message"></param>
        public void OnTestStart(string message)
        {
            Debug.Log(string.Format(@"Got Message {0}", message));
            StartTests();
        }

        private bool allTestsStarted = false;

        private void StartTests()
        {
            runner = new TestRunner();

            var httpClients = new List<AWSConfigs.HttpClientOption>(){ AWSConfigs.HttpClientOption.UnityWWW };

            if (Type.GetType("UnityEngine.Experimental.Networking.UnityWebRequest, UnityEngine") != null)
            {
                httpClients.Add(AWSConfigs.HttpClientOption.UnityWebRequest);
            }

            Debug.Log(@"Added the following http clients");
            
            foreach (var hc in httpClients)
            {
                Debug.Log(hc.ToString());
            }

            EnsureBackgroundExecution(() =>
            {
                int count = 0;
                foreach (var httpClient in httpClients)
                {
                    count++;

                    if (count == httpClients.Count)
                        allTestsStarted = true;

                    AWSConfigs.HttpClient = httpClient;

                    if (httpClient == AWSConfigs.HttpClientOption.UnityWWW)
                    {
                        runner.HttpClient = httpClient;
                        runner.RunTestsWithCategory("WWW");
                    }
                    else
                    {
                        runner.HttpClient = httpClient;
                        runner.RunTests();
                    }

                    Thread.Sleep(TimeSpan.FromSeconds(5));
                }
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