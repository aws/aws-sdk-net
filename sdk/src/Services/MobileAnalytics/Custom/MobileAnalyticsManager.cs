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
    /// MobileAnalyticsManager in the entry point to recording analytic events for your application
    /// </summary>
    public partial class MobileAnalyticsManager
    {
        private static object _lock = new object();
        private static IDictionary<string, MobileAnalyticsManager> _instanceDictionary = new Dictionary<string, MobileAnalyticsManager>();
        private Logger _logger = Logger.GetLogger(typeof(MobileAnalyticsManager));
        private static BackgroundRunner _backgroundRunner = new BackgroundRunner();
        
        #region constructor

        /// <summary>
        /// Gets the or creates Mobile Analytics Manager instance. If the instance already exists, returns the instance; otherwise
        /// creates new instance and returns it.
        /// </summary>
        /// <param name="credential">AWS Credentials.</param>
        /// <param name="regionEndpoint">Region endpoint.</param>
        /// <param name="appId">Amazon Mobile Analytics Application ID.</param>
        /// <param name="maConfig">Amazon Mobile Analytics Manager configuration.</param>
        /// <returns>Mobile Analytics Manager instance. If it's null, default configuration would be created.</returns>
        public static MobileAnalyticsManager GetOrCreateInstance(AWSCredentials credential,
                                                                         RegionEndpoint regionEndpoint,
                                                                         string appId,
                                                                         MobileAnalyticsManagerConfig maConfig
                                                                         )
        {
            if (credential == null)
                throw new ArgumentNullException("credential");
            if (regionEndpoint == null)
                throw new ArgumentNullException("regionEndpoint");
            if (string.IsNullOrEmpty(appId))
                throw new ArgumentNullException("appId");


            MobileAnalyticsManager managerInstance = null;
            bool isNewInstance = false;
            lock (_lock)
            {
                if (_instanceDictionary.ContainsKey(appId))
                {
                    managerInstance = _instanceDictionary[appId];
                }
                else
                {
                    if (maConfig == null)
                        maConfig = new MobileAnalyticsManagerConfig();
                    if (maConfig.ClientContextConfiguration == null)
                        maConfig.ClientContextConfiguration = new ClientContextConfig(appId);

                    managerInstance = new MobileAnalyticsManager(credential, regionEndpoint, maConfig);
                    _instanceDictionary[appId] = managerInstance;
                    isNewInstance = true;
                }
            }

            if (isNewInstance)
                managerInstance.Session.Start();

            _backgroundRunner.StartWork();

            return managerInstance;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManager"/> class.
        /// </summary>
        /// <param name="credentials">AWS Credentials.</param>
        /// <param name="regionEndpoint">Region endpoint.</param>
        /// <param name="maConfig">Mobile Ananlytics Manager Config.</param>
        private MobileAnalyticsManager(AWSCredentials credentials, RegionEndpoint regionEndpoint, MobileAnalyticsManagerConfig maConfig)
        {
            this.ClientContext = new ClientContext(maConfig.ClientContextConfiguration);
            this.BackgroundDeliveryClient = new DeliveryClient(maConfig, ClientContext, credentials, regionEndpoint);
            this.Session = new Session(maConfig.ClientContextConfiguration.AppId, maConfig.SessionTimeout);
        }

        /// <summary>
        /// Gets Mobile Analytics Manager instance by Application ID. Returns Mobile Analytics Manager instance if it's found.
        /// Throws InvalidOperationException if the instance has not been instantiated.
        /// </summary>
        /// <param name="appId">Amazon Mobile Analytics Application ID.</param>
        /// <returns>The Mobile Analytics Manager instance.</returns>
        public static MobileAnalyticsManager GetInstance(string appId)
        {
            if (string.IsNullOrEmpty(appId))
                throw new ArgumentNullException("appId");
            
            lock (_lock)
            {
                if (_instanceDictionary.ContainsKey(appId))
                {
                    return _instanceDictionary[appId];
                }
                else
                {
                    throw new InvalidOperationException("We cannot find MobileAnalyticsManager instance for appId " + appId + ". Please call GetOrCreateInstance() first.");
                }
            }
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
        ///        _manager = MobileAnalyticsManager.GetOrCreateInstance(YourCredential, RegionEndpoint.USEast1, YourAppId, YourConfig);
        ///        base.OnCreate(bundle);
        ///    }
        ///    protected override void OnResume()
        ///    {
        ///        _manager.ResumeSession();
        ///        base.OnResume();
        ///    }
        ///    protected override void OnPause()
        ///    {
        ///        _manager.PauseSession();
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
            catch(Exception e)
            {
                _logger.Error(e, "An exception occurred when pause session.");
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
        ///        _manager = MobileAnalyticsManager.GetOrCreateInstance(YourCredential, RegionEndpoint.USEast1, YourAppId, YourConfig);
        ///        base.OnCreate(bundle);
        ///    }
        ///    protected override void OnResume()
        ///    {
        ///        _manager.ResumeSession();
        ///        base.OnResume();
        ///    }
        ///    protected override void OnPause()
        ///    {
        ///        _manager.PauseSession();
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
            }
        }    
		
		
		/// <summary>
        /// Records the custom event to the local persistent storage. Background thread will deliver the event later.
        /// </summary>
        /// <param name="customEvent">The Mobile Analytics event.</param>
        public void RecordEventAsync(CustomEvent customEvent)
        {
            customEvent.Timestamp = DateTime.UtcNow;
		
            Amazon.MobileAnalytics.Model.Event modelEvent = customEvent.ConvertToMobileAnalyticsModelEvent(this.Session);
            BackgroundDeliveryClient.EnqueueEventsForDeliveryAsync(modelEvent);
        }
		
		
        /// <summary>
        /// Adds client context custom attribute
        /// Refer <a href="http://docs.aws.amazon.com/mobileanalytics/latest/ug/PutEvents.html" >Rest API</a> for more information
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Value.</param>
        public void AddClientContextCustomAttribute(string key,string value)
        {
            if(string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }
            
            if(value == null)
            {
                throw new ArgumentNullException("value");
            }

            ClientContext.AddCustomAttributes(key,value);
        }

        /// <summary>
        /// Get the object which represents Mobile Analytics Session.
        /// </summary>
        public Session Session { get; private set; }

        /// <summary>
        /// Get the object which represents Mobile Analytics Client Context header.
        /// </summary>
        public ClientContext ClientContext { get; private set; }   
        #endregion


        #region internal
        internal IDeliveryClient BackgroundDeliveryClient{get;private set;}
        
        internal static IDictionary<string,MobileAnalyticsManager> InstanceDictionary
        {
            get
            {
                lock(_lock)
                {
                    return new Dictionary<string, MobileAnalyticsManager>(_instanceDictionary);
                }
            }
        }

        #endregion
        
    }
}
