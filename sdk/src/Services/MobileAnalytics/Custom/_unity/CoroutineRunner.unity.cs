using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Logger = Amazon.Runtime.Internal.Util.Logger;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Amazon Mobile Analytics coroutine runner.
    /// Coroutine runner periodically calls delivery client to send events to server.
    /// </summary>
    public partial class CoroutineRunner
    {
        private Logger _logger = Logger.GetLogger(typeof(CoroutineRunner));

        /// <summary>
        /// Coroutine wait time. Coroutine will yield for the interval mention. Value is in Seconds.
        /// Default 60 seconds.
        /// </summary>
        public const int BackgroundSubmissionWaitTime = 60;
    
        private static Coroutine _coroutine = null;
        private static bool _shouldStop;

        /// <summary>
        /// Starts the Mobile Analytics Manager coroutine.
        /// </summary>
        public void StartWork()
        {
            if(_coroutine == null) 
            {
                _shouldStop = false;
                _coroutine = UnityInitializer.Instance.StartCoroutine(DoWork());
            }
        }

        /// <summary>
        /// Aborts the coroutine.
        /// </summary>
        public static void StopCoroutine()
        {
            if (_coroutine != null) 
            {
                _shouldStop = true;
                UnityInitializer.Instance.StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }

        /// <summary>
        /// Sends Mobile Analytics events to server on coroutine.
        /// </summary>
        private IEnumerator DoWork()
        {
            while (!_shouldStop) 
            {
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
                            manager.BackgroundDeliveryClient.AttemptDelivery();
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
                    _logger.Error(e, "An exception occurred in Mobile Analytics Manager.");
                }

                yield return new WaitForSeconds(BackgroundSubmissionWaitTime);
            }            
        }
    }
}
