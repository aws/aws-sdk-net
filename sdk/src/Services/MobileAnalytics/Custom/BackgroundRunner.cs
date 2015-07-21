//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using Amazon.Runtime.Internal.Util;

#if PCL || BCL45
using System.Threading.Tasks;
#endif

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Amazon Mobile Analytics background runner.
    /// Background runner periodically calls delivery client to send events to server.
    /// </summary>
    public class BackgroundRunner
    {
        private Logger _logger = Logger.GetLogger(typeof(BackgroundRunner));
        private object _lock = new object();

        // Background thread wait time. Thread will sleep for the interval mention. Value is in Seconds.
        // Default 60 seconds.
        private const int BackgroundSubmissionWaitTime = 15;
#if BCL35
        private System.Threading.Thread _thread = null;

        /// <summary>
        /// Starts the Mobile Analytics Manager background thread.
        /// </summary>
        public void StartWork()
        {
            lock (_lock)
            {
                if (!IsAlive()) { 
                    _thread = new System.Threading.Thread(DoWork);
                    _thread.Start();
                }    
            }
            
        }

        private bool IsAlive()
        {
            return _thread != null && _thread.ThreadState != ThreadState.Stopped
                                   && _thread.ThreadState != ThreadState.Aborted
                                   && _thread.ThreadState != ThreadState.AbortRequested;
        }


        private void DoWork()
        {
            while (true)
            {
                try
                {
                    _logger.InfoFormat("Mobile Analytics Manager is trying to deliver events in background thread.");

                    IDictionary<string, MobileAnalyticsManager> instanceDictionary = MobileAnalyticsManager.InstanceDictionary;
                    foreach (string appId in instanceDictionary.Keys)
                    {
                        try
                        {
                            MobileAnalyticsManager manager = MobileAnalyticsManager.GetInstance(appId);
                            manager.BackgroundDeliveryClient.AttemptDelivery();
                        }
                        catch (System.Exception e)
                        {
                            _logger.Error(e, "An exception occurred in Mobile Analytics Delivery Client.");
                        }
                    }
                    Thread.Sleep(BackgroundSubmissionWaitTime * 1000);
                }
                catch (System.Exception e)
                {
                    _logger.Error(e, "An exception occurred in Mobile Analytics Manager.");
                }
            }
        }

#elif BCL45 || PCL
        private int _startFlag = 0;
        private Task _deliveryTask = null;

        /// <summary>
        /// Starts the Mobile Analytics Manager background thread.
        /// </summary>
        public void StartWork()
        {
            // Start background task if it is not started yet.
            if (0 == Interlocked.CompareExchange(ref _startFlag, 1, 0))
            {
                DoWorkAsync(BackgroundSubmissionWaitTime * 1000);
            }
        }

        private async Task DoWorkAsync(int millisecondsDelay)
        {
            while (true)
            {
                await Task.Delay(millisecondsDelay);

                try
                {
                    _logger.InfoFormat("Mobile Analytics Manager is trying to deliver events in background thread.");

                    IDictionary<string, MobileAnalyticsManager> instanceDictionary = MobileAnalyticsManager.InstanceDictionary;
                    foreach (string appId in instanceDictionary.Keys)
                    {
                        try
                        {
                            MobileAnalyticsManager manager = MobileAnalyticsManager.GetInstance(appId);
                            await manager.BackgroundDeliveryClient.AttemptDeliveryAsync();
                        }
                        catch (System.Exception e)
                        {
                            _logger.Error(e, "An exception occurred in Mobile Analytics Delivery Client : {0}", e.ToString());
                        }
                    }
                }
                catch (System.Exception e)
                {
                    _logger.Error(e, "An exception occurred in Mobile Analytics Manager : {0}", e.ToString());
                }
            }
        }
#endif
    }
}

