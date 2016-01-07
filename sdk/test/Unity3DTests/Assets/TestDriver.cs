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

        internal static Queue<string> Results { get; set; }
        // Use this for initialization
        void Start()
        {
            Results = new Queue<string>();

            UnityInitializer.AttachToGameObject(this.gameObject);

            //set sleep timeout to infinity
            Screen.sleepTimeout = SleepTimeout.NeverSleep;

            AWSConfigs.WebRequestApiOption = AWSConfigs.HttpWebRequestApiOption.UnityWebRequest;

            //set up logging
            var loggingConfig = AWSConfigs.LoggingConfig;
            loggingConfig.LogTo = LoggingOptions.UnityLogger;
            loggingConfig.LogMetrics = true;
            loggingConfig.LogResponses = ResponseLoggingOption.Always;
            loggingConfig.LogResponsesSizeLimit = 4096;
            loggingConfig.LogMetricsFormat = LogMetricsFormatOption.JSON;
			
            var context = AWSConfigsDynamoDB.Context;

            var runner = new TestRunner();

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                runner.RunTests();
            }));
        }

        void Update()
        {
            if (Results.Count > 0)
            {
                ResultsText.text += Results.Dequeue();
                ResultsText.text += Environment.NewLine;
            }
        }

    }
}