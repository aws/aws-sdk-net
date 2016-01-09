/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using Logger = Amazon.Runtime.Internal.Util.Logger;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This class is used to dispatch web requests using the WWW API and
    /// to call user callbacks on the main thread.
    /// </summary>
    public class UnityMainThreadDispatcher : MonoBehaviour
    {
        private Logger _logger;
        private float _nextUpdateTime;
        private float _updateInterval = 0.1f;

        /// <summary>
        /// This method is called called when the script instance is
        /// being loaded.
        /// </summary>
        public void Awake()
        {
            _logger = Logger.GetLogger(this.GetType());
            // Call the method to process requests at a regular interval.
            _nextUpdateTime = Time.unscaledTime;
            _nextUpdateTime += _updateInterval;
        }

        /// <summary>
        /// This method is called as often as possible.
        /// </summary>
        void Update()
        {
            if (Time.unscaledTime >= _nextUpdateTime)
            {
                ProcessRequests();
                _nextUpdateTime += _updateInterval;
            }
        }

        /// <summary>
        /// This method processes queued web requests and user callbacks.
        /// </summary>
        void ProcessRequests()
        {
            // Make a network call for queued requests on the main thread
            var request = UnityRequestQueue.Instance.DequeueRequest();
            if (request != null)
            {
                StartCoroutine(InvokeRequest(request));
            }

            // Invoke queued callbacks on the main thread
            var asyncResult = UnityRequestQueue.Instance.DequeueCallback();
            if (asyncResult != null && asyncResult.Action != null)
            {
                try
                {
                    asyncResult.Action(asyncResult.Request, asyncResult.Response,
                        asyncResult.Exception, asyncResult.AsyncOptions);
                }
                catch (Exception exception)
                {
                    // Catch any unhandled exceptions from the user callback 
                    // and log it. 
                    _logger.Error(exception,
                        "An unhandled exception was thrown from the callback method {0}.",
                        asyncResult.Request.ToString());
                }
            }

            //Invoke queued main thread executions
            var mainThreadCallback = UnityRequestQueue.Instance.DequeueMainThreadOperation();
            if (mainThreadCallback != null)
            {
                try
                {
                    mainThreadCallback();
                }
                catch (Exception exception)
                {
                    // Catch any unhandled exceptions from the user callback 
                    // and log it. 
                    _logger.Error(exception,
                        "An unhandled exception was thrown from the callback method");
                }
            }

            //network updates
            //TODO: need to check for performance
            NetworkReachability _networkReachability = Application.internetReachability;
            if (OnRefresh != null)
            {
                OnRefresh(this, new NetworkStatusRefreshed(_networkReachability));
            }

        }

        /// <summary>
        /// Makes a single web request using the WWW API.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>IEnumerator which indicated if the operation is pending.</returns>
        IEnumerator InvokeRequest(UnityWebRequest request)
        {
            // Fire the request            
            request.WwwRequest = new WWW(request.RequestUri.AbsoluteUri,
                request.RequestContent, request.Headers);

            yield return request.WwwRequest;
            request.Response = new UnityWebResponseData(request.WwwRequest);

            if (request.IsSync)
            {
                // For synchronous calls, signal the wait handle 
                // so that the calling thread which waits on the wait handle
                // is unblocked.
                if (!request.Response.IsSuccessStatusCode)
                {
                    request.Exception=  new HttpErrorResponseException(request.Response);
                }
                request.WaitHandle.Set();
            }
            else
            {
                if (!request.Response.IsSuccessStatusCode)
                {
                    request.Exception = new HttpErrorResponseException(request.Response);
                }
                // For asychronous calls invoke the callback method with the
                // state object that was originally passed in.

                // Invoke the callback method for the request on the thread pool
                // after the web request is executed. This callback triggers the 
                // post processing of the response from the server.
                ThreadPool.QueueUserWorkItem((state) =>
                {
                    try
                    {
                        request.Callback(request.AsyncResult);
                    }
                    catch (Exception exception)
                    {
                        // The callback method (HttpHandler.GetResponseCallback) and 
                        // subsequent calls to handler callbacks capture any exceptions
                        // thrown from the runtime pipeline during post processing.

                        // Log the exception, in case we get an unhandled exception 
                        // from the callback.
                        _logger.Error(exception,
                            "An exception was thrown from the callback method executed from" +
                            "UnityMainThreadDispatcher.InvokeRequest method.");

                    }
                });
            }
        }

        /// Public callback API to send the status of network.
        /// </summary>
        public class NetworkStatusRefreshed : EventArgs
        {
            public NetworkReachability NetworkReachability;

            public NetworkStatusRefreshed(NetworkReachability reachability)
            {
                NetworkReachability = reachability;
            }
        }

        public static event EventHandler<NetworkStatusRefreshed> OnRefresh;
    }
}