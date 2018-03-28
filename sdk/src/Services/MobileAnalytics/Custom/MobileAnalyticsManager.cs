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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

using Amazon.Runtime;
using Amazon.Util;
using Amazon.Runtime.Internal;
using Amazon.MobileAnalytics.MobileAnalyticsManager.Internal;
using Amazon.Runtime.Internal.Util;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager
{

    /// <summary>
    /// MobileAnalyticsManager is the entry point to recording analytic events for your application
    /// </summary>
    public partial class MobileAnalyticsManager : IDisposable
    {
        private static Object _lock = new Object();
        private static IDictionary<string, MobileAnalyticsManager> _instanceDictionary = new Dictionary<string, MobileAnalyticsManager>();
        private Logger _logger = Logger.GetLogger(typeof(MobileAnalyticsManager));
        private static BackgroundRunner _backgroundRunner = new BackgroundRunner();
#if UNITY
        private static CoroutineRunner _coroutineRunner = new CoroutineRunner();
#endif

        #region constructor

        /// <summary>
        /// Gets or creates Mobile Analytics Manager instance. If the instance already exists, returns the instance; otherwise
        /// creates new instance and returns it.
        /// </summary>
        /// <param name="appID">Amazon Mobile Analytics Application ID.</param>
        /// <param name="credentials">AWS Credentials.</param>
        /// <param name="regionEndpoint">Region endpoint.</param>
        /// <param name="maConfig">Amazon Mobile Analytics Manager configuration.</param>
        /// <returns>Mobile Analytics Manager instance. </returns>
        public static MobileAnalyticsManager GetOrCreateInstance(string appID, AWSCredentials credentials, RegionEndpoint regionEndpoint, MobileAnalyticsManagerConfig maConfig)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");
            if (null == credentials)
                throw new ArgumentNullException("credentials");
            if (null == regionEndpoint)
                throw new ArgumentNullException("regionEndpoint");
            if (null == maConfig)
                throw new ArgumentNullException("maConfig");

            return GetOrCreateInstanceHelper(appID, credentials, regionEndpoint, maConfig);
        }

        /// <summary>
        /// Gets or creates Mobile Analytics Manager instance. If the instance already exists, returns the instance; otherwise
        /// creates new instance and returns it.
        /// </summary>
        /// <param name="appID">Amazon Mobile Analytics Application ID.</param>
        /// <param name="credentials">AWS Credentials.</param>
        /// <param name="regionEndpoint">Region endpoint.</param>
        /// <returns>Mobile Analytics Manager instance.</returns>
        public static MobileAnalyticsManager GetOrCreateInstance(string appID, AWSCredentials credentials, RegionEndpoint regionEndpoint)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");
            if (null == credentials)
                throw new ArgumentNullException("credentials");
            if (null == regionEndpoint)
                throw new ArgumentNullException("regionEndpoint");

            MobileAnalyticsManagerConfig maConfig = new MobileAnalyticsManagerConfig();
            return GetOrCreateInstanceHelper(appID, credentials, regionEndpoint, maConfig);
        }

        /// <summary>
        /// Gets Mobile Analytics Manager instance by Application ID. Returns Mobile Analytics Manager instance if it's found.
        /// Throws InvalidOperationException if the instance has not been instantiated.
        /// </summary>
        /// <param name="appID">Amazon Mobile Analytics Application ID.</param>
        /// <returns>The Mobile Analytics Manager instance.</returns>
        public static MobileAnalyticsManager GetInstance(string appID)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");
            MobileAnalyticsManager managerInstance = null;

            lock (_lock)
            {
                if (_instanceDictionary.TryGetValue(appID, out managerInstance))
                {
                    return managerInstance;
                }
                else
                {
                    throw new InvalidOperationException("Cannot find MobileAnalyticsManager instance for appID " + appID + ". Please call GetOrCreateInstance() first.");
                }
            }
        }

        private static MobileAnalyticsManager GetOrCreateInstanceHelper(string appID, AWSCredentials credentials, RegionEndpoint regionEndpoint, MobileAnalyticsManagerConfig maConfig)
        {
#if BCL
            ValidateParameters();
#endif
            MobileAnalyticsManager managerInstance = null;
            bool isNewInstance = false;

            lock (_lock)
            {
                if (_instanceDictionary.TryGetValue(appID, out managerInstance))
                {
                    return managerInstance;
                }
                else
                {
                    managerInstance = new MobileAnalyticsManager(appID, credentials, regionEndpoint, maConfig);
                    _instanceDictionary[appID] = managerInstance;
                    isNewInstance = true;
                }
            }

            if (isNewInstance)
            {
                managerInstance.Session.Start();
            }

#if UNITY
            if(UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WebGLPlayer)
            {
                _coroutineRunner.StartWork();
            }
            else 
            {
                _backgroundRunner.StartWork();
            }
#else
            _backgroundRunner.StartWork();
#endif

            return managerInstance;
        }

        private MobileAnalyticsManager(string appID, AWSCredentials credentials, RegionEndpoint regionEndpoint, MobileAnalyticsManagerConfig maConfig)
        {
#if PCL||UNITY
            this.ClientContext = new ClientContext(appID);
#elif BCL
            if (null == maConfig)
                maConfig = new MobileAnalyticsManagerConfig();
            this.ClientContext = new ClientContext(appID, maConfig.ClientContextConfiguration);
#endif
            this.BackgroundDeliveryClient = new DeliveryClient(maConfig, ClientContext, credentials, regionEndpoint, this);
            this.Session = new Session(appID, maConfig);
        }
        #endregion

        #region public
        /// <summary>
        /// Pauses the current session.
        /// PauseSession() is the entry point into the Amazon Mobile Analytics SDK where sessions can be paused. Session is created and started immediately 
        /// after instantiating the MobileAnalyticsManager object. The session remains active until it is paused. When in a paused state, the session time will 
        /// not accumulate. When resuming a session, if enough time has elapsed from when the session is paused to when it's resumed, the session is ended and 
        /// a new session is created and started. Otherwise, the paused session is resumed and the session time continues to accumulate. Currently session 
        /// time out default value is 5 seconds.
        /// 
        /// For example, on Android platform, when MobileAnalyticsManager is first instantiated, it creates Session 1. As the user transitions from activity to activity, the old 
        /// activity will pause the current session, and the new activity will immediately resume the current session. In this case, Session 1 remains active 
        /// and accumulates session time. The user continues to use the App for a total of 3 minutes, at which point, the user receives a phone call. 
        /// When transitioning to the phone call, the current activity will pause the session and then transition to the phone app. In this case Session 1 
        /// remains paused while the phone call is in progress and session time does not accumulate. After completing the phone call a few minutes later, 
        /// the user returns to the App and the activity will resume Session 1. Since enough time has elapsed since resuming Session 1, Session 1 will be ended 
        /// with a play time of 3 minutes. Session 2 will then be immediately created and started.
        /// 
        /// In order for MobileAnalyticsManager to track sessions, you must call the PauseSession() and ResumeSession() in each activity of your app.
        /// <example>
        /// The example below shows how to pause and resume session in Xamarin Android
        /// <code>
        ///public class MainActivity : Activity
        ///{
        ///    private static MobileAnalyticsManager _manager = null;
        ///
        ///    protected override void OnCreate(Bundle bundle)
        ///    {
        ///        _manager = MobileAnalyticsManager.GetOrCreateInstance(YourAppId, YourCredential, RegionEndpoint.USEast1, YourConfig);
        ///        base.OnCreate(bundle);
        ///    }
        ///    protected override void OnResume()
        ///    {
        ///        await _manager.ResumeSession();
        ///        base.OnResume();
        ///    }
        ///    protected override void OnPause()
        ///    {
        ///        await _manager.PauseSession();
        ///        base.OnPause();
        ///    }
        ///}
        /// </code>  
        /// </example> 
        /// </summary>       
        public void PauseSession()
        {
            try
            {
                Session.Pause();
            }
            catch (Exception e)
            {
                _logger.Error(e, "An exception occurred when pause session.");
                MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "An exception occurred when pausing session.", e, new List<Amazon.MobileAnalytics.Model.Event>());
                OnRaiseErrorEvent(eventArgs);
            }
        }

        /// <summary>
        /// Resume the current session.
        /// ResumeSession() is the entry point into the Amazon Mobile Analytics SDK where sessions can be resumed. Session is created and started immediately 
        /// after instantiating the MobileAnalyticsManager object. The session remains active until it is paused. When in a paused state, the session time will 
        /// not accumulate. When resuming a session, if enough time has elapsed from when the session is paused to when it's resumed, the session is ended and 
        /// a new session is created and started. Otherwise, the paused session is resumed and the session time continues to accumulate. Currently session 
        /// time out default value is 5 seconds.
        /// 
        /// For example, on Android platform, when MobileAnalyticsManager is first instantiated, it creates Session 1. As the user transitions from activity to activity, the old 
        /// activity will pause the current session, and the new activity will immediately resume the current session. In this case, Session 1 remains active 
        /// and accumulates session time. The user continues to use the App for a total of 3 minutes, at which point, the user receives a phone call. 
        /// When transitioning to the phone call, the current activity will pause the session and then transition to the phone app. In this case Session 1 
        /// remains paused while the phone call is in progress and session time does not accumulate. After completing the phone call a few minutes later, 
        /// the user returns to the App and the activity will resume Session 1. Since enough time has elapsed since resuming Session 1, Session 1 will be ended 
        /// with a play time of 3 minutes. Session 2 will then be immediately created and started.
        /// 
        /// In order for MobileAnalyticsManager to track sessions, you must call the PauseSession() and ResumeSession() in each activity of your app.
        /// <example>
        /// The example below shows how to pause and resume session in Xamarin Android
        /// <code>
        ///public class MainActivity : Activity
        ///{
        ///    private static MobileAnalyticsManager _manager = null;
        ///
        ///    protected override void OnCreate(Bundle bundle)
        ///    {
        ///        _manager = MobileAnalyticsManager.GetOrCreateInstance(YourAppId, YourCredential, RegionEndpoint.USEast1, YourConfig);
        ///        base.OnCreate(bundle);
        ///    }
        ///    protected override void OnResume()
        ///    {
        ///        await _manager.ResumeSession();
        ///        base.OnResume();
        ///    }
        ///    protected override void OnPause()
        ///    {
        ///        await _manager.PauseSession();
        ///        base.OnPause();
        ///    }
        ///}
        /// </code>  
        /// </example> 
        /// </summary>
        public void ResumeSession()
        {
            try
            {
                Session.Resume();
            }
            catch (Exception e)
            {
                _logger.Error(e, "An exception occurred when resume session.");
                MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "An exception occurred when resuming session.", e, new List<Amazon.MobileAnalytics.Model.Event>());
                OnRaiseErrorEvent(eventArgs);
            }
        }


        /// <summary>
        /// Records the custom event to the local persistent storage. Background thread will deliver the event later.
        /// </summary>
        /// <param name="customEvent">The Mobile Analytics event.</param>
        public void RecordEvent(CustomEvent customEvent)
        {
            if (null == customEvent)
                throw new ArgumentNullException("customEvent");

            customEvent.Timestamp = AWSSDKUtils.CorrectedUtcNow;
            Amazon.MobileAnalytics.Model.Event modelEvent = customEvent.ConvertToMobileAnalyticsModelEvent(this.Session);

            BackgroundDeliveryClient.EnqueueEventsForDelivery(modelEvent);
        }


        /// <summary>
        /// Adds client context custom attribute
        /// Refer <a href="http://docs.aws.amazon.com/mobileanalytics/latest/ug/PutEvents.html" >Rest API</a> for more information
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Value.</param>
        public void AddCustomAttributeToClientContext(string key, string value)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }

            if (null == value)
            {
                throw new ArgumentNullException("value");
            }

            ClientContext.AddCustomAttributes(key, value);
        }

        /// <summary>
        /// The event for MobileAnalyticsErrorEvent notifications. All subscribers will be notified 
        /// when a new Mobile Analytics error event is raised.
        /// <para>
        /// The MobileAnalyticsErrorEvent is fired as error happens in Mobile Analytics Manager. 
        /// The delegates attached to the event will be passed information detailing what is the error.
        /// For example, the error can be Amazon Mobile Analytics server return error, local event storage error, 
        /// File I/O error etc.
        /// </para>
        /// The example below shows how to subscribe to this event.
        /// <example>
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void errorHandler(object sender, MobileAnalyticsErrorEventArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the MobileAnalyticsErrorEvent delegate's invocation list
        /// <code>
        /// _manager = MobileAnalyticsManager.GetOrCreateInstance(YourAppId, YourCredential, RegionEndpoint.USEast1, YourConfig);
        /// _manager.MobileAnalyticsErrorEvent += errorHandler;
        /// </code>
        /// </example>
        /// </summary>
        public event EventHandler<MobileAnalyticsErrorEventArgs> MobileAnalyticsErrorEvent;
        #endregion


        #region internal
        internal Session Session { get; set; }

        internal ClientContext ClientContext { get; set; }

        internal IDeliveryClient BackgroundDeliveryClient { get; private set; }

        internal static IDictionary<string, MobileAnalyticsManager> CopyOfInstanceDictionary
        {
            get
            {
                lock (_lock)
                {
                    return new Dictionary<string, MobileAnalyticsManager>(_instanceDictionary);
                }
            }
        }

        internal void OnRaiseErrorEvent(MobileAnalyticsErrorEventArgs eventArgs)
        {
            AWSSDKUtils.InvokeInBackground(MobileAnalyticsErrorEvent, eventArgs, this);
        }
        #endregion


        #region Dispose Pattern Implementation

        /// <summary>
        /// Implement the dispose pattern
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///  Implement the dispose pattern
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Session.Dispose();
                this.BackgroundDeliveryClient.Dispose();
            }
        }

        #endregion
    }

    /// <summary>
    /// Encapsulates the information needed to notify
    /// errors of Mobile Analytics Manager.
    /// </summary>
    public class MobileAnalyticsErrorEventArgs : EventArgs
    {
        /// <summary>
        /// The constructor of MobileAnalyticsErrorEventArgs
        /// </summary>
        /// <param name="className">The class name where the error is caught.</param>
        /// <param name="errorMessage">The message that describes reason of the error.</param>
        /// <param name="exception">The exception thrown in Mobile Analytics Manager.</param>
        /// <param name="undeliveredEvents">The list of events that caused the error. This is a list of low level event objects. This list might be empty if the error is not caused by mal-formatted events.</param>
        internal MobileAnalyticsErrorEventArgs(string className, string errorMessage, Exception exception, List<Amazon.MobileAnalytics.Model.Event> undeliveredEvents)
        {
            if (null == className)
                throw new ArgumentNullException("className");
            if (null == errorMessage)
                throw new ArgumentNullException("errorMessage");
            if (null == exception)
                throw new ArgumentNullException("exception");
            if (null == undeliveredEvents)
                throw new ArgumentNullException("undeliveredEvents");

            this.ClassName = className;
            this.ErrorMessage = errorMessage;
            this.Exception = exception;
            this.UndeliveredEvents = undeliveredEvents;
        }

        /// <summary>
        /// The class name where the error is caught.
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// The message that describes reason of the error.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The exception thrown in Mobile Analytics Manager.
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// The list of events that caused the error. This is a list of low level event objects.
        /// This list might be empty if the error is not caused by mal-formatted events.
        /// </summary>
        public List<Amazon.MobileAnalytics.Model.Event> UndeliveredEvents { get; set; }

    }
}
