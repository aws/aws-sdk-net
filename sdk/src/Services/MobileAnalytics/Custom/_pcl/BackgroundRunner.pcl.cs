/*
 * Copyright 2015-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

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
    public partial class BackgroundRunner
    {
        private int _startFlag = 0;
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
            while (!ShouldStop)
            {
                await Task.Delay(millisecondsDelay).ConfigureAwait(false);

                if (ShouldStop) break;
                
                try
                {
                    _logger.InfoFormat("Mobile Analytics Manager is trying to deliver events in background thread.");

                    IDictionary<string, MobileAnalyticsManager> instanceDictionary = MobileAnalyticsManager.CopyOfInstanceDictionary;
                    foreach (string appId in instanceDictionary.Keys)
                    {
                        MobileAnalyticsManager manager = null;
                        try
                        {
                            manager = MobileAnalyticsManager.GetInstance(appId);
                            await manager.BackgroundDeliveryClient.AttemptDeliveryAsync().ConfigureAwait(false);
                        }
                        catch (System.Exception e)
                        {
                            _logger.Error(e, "An exception occurred in Mobile Analytics Delivery Client : {0}", e.ToString());

                            if (null != manager)
                            {
                                MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "An exception occurred when deliverying events to Amazon Mobile Analytics.", e, new List<Amazon.MobileAnalytics.Model.Event>());
                                manager.OnRaiseErrorEvent(eventArgs);
                            }
                        }
                    }
                }
                catch (System.Exception e)
                {
                    _logger.Error(e, "An exception occurred in Mobile Analytics Manager : {0}", e.ToString());
                }
            }
        }
    }
}

