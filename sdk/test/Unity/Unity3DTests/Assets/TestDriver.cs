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
            finalFailedWWWTests = null;
            finalFailedUWRTests = null;
            //set sleep timeout to infinity
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }

        private HashSet<string> finalFailedWWWTests;
        private HashSet<string> finalFailedUWRTests;

        public void OnTestFinished(AWSConfigs.HttpClientOption hco, HashSet<string> failedTestCases)
        {
            bool retry = retryCount < 3 && failedTestCases.Count > 0;

            Debug.LogFormat(@"the following test cases {0} for {1} = {2}",
                retry ? "will be retried" : "failed",
                hco,
                string.Join(",", failedTestCases.ToArray<string>()));

            if (retryCount < 3 && failedTestCases.Count > 0)
            {
                retryCount++;
                EnsureBackgroundExecution(() =>
                {
                    if (hco == AWSConfigs.HttpClientOption.UnityWWW)
                    {
                        runner.HttpClient = hco;
                        runner.RunTestsWithCategory("WWW", failedTestCases);

                    }
                    else
                    {
                        runner.HttpClient = hco;
                        runner.RunTestsWithName(failedTestCases);
                    }
                });
                return;
            }

            if (hco == AWSConfigs.HttpClientOption.UnityWWW)
            {
                finalFailedWWWTests = new HashSet<string>(failedTestCases);
            }
            else if (hco == AWSConfigs.HttpClientOption.UnityWebRequest)
            {
                finalFailedUWRTests = new HashSet<string>(failedTestCases);
            }

            if (finalFailedUWRTests != null && finalFailedWWWTests != null)
            {
                mainThread.Enqueue(() =>
                {
                    Debug.Log("OnTestFinished");

                    if (finalFailedUWRTests.Count > 0 || finalFailedWWWTests.Count > 0)
                        PrintResult("SOME TESTS FAILED");
                    else
                        PrintResult("ALL TESTS PASSED");
                });
            }
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
                    retryCount = 0;

                    count++;
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