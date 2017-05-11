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

using System.Threading;
using System.Collections;
using System;
using System.IO;
using ThirdParty.Json.LitJson;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal;
#if PCL || BCL45
using System.Threading.Tasks;
#endif
#if PCL
using PCLStorage;
#endif

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// The class controls session start, pause, resume and stop logic.
    /// </summary>
    [System.Security.SecuritySafeCritical]
    public partial class Session : IDisposable
    {
        private Logger _logger = Logger.GetLogger(typeof(Session));

        // session info
        /// <summary>
        /// Session start Time.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Session stop time.
        /// </summary>
        public DateTime? StopTime { get; set; }

        /// <summary>
        /// Session latest resume time.
        /// </summary>
        public DateTime PreStartTime { get; set; }

        /// <summary>
        /// Session ID.
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Session duration in milliseconds.
        /// </summary>
        public long Duration { get; set; }

        // lock to guard session info
        private Object _lock = new Object();

        internal class SessionStorage
        {
            public SessionStorage()
            {
                _sessionId = null; _duration = 0;
            }

            public DateTime _startTime;
            public DateTime? _stopTime;
            public DateTime _preStartTime;
            public string _sessionId;
            public long _duration;
        }

        private MobileAnalyticsManagerConfig _maConfig;
        private volatile SessionStorage _sessionStorage = null;
        private string _appID = null;
        private string _sessionStorageFileName = "_session_storage.json";
        private string _sessionStorageFileFullPath = null;

        #region public
        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session"/>
        /// </summary>
        /// <param name="appID">Amazon Mobile Analytics App Identifier.</param>
        /// <param name="maConfig">Mobile Analytics Manager Configuration.</param>
        [System.Security.SecuritySafeCritical]
        public Session(string appID, MobileAnalyticsManagerConfig maConfig)
        {
            _maConfig = maConfig;
            _appID = appID;
#if BCL
            _sessionStorageFileFullPath = InternalSDKUtils.DetermineAppLocalStoragePath(appID + _sessionStorageFileName);
#elif PCL
            _sessionStorageFileFullPath = System.IO.Path.Combine(PCLStorage.FileSystem.Current.LocalStorage.Path, appID + _sessionStorageFileName);
#elif UNITY
            _sessionStorageFileFullPath = System.IO.Path.Combine(AmazonHookedPlatformInfo.Instance.PersistentDataPath, appID + _sessionStorageFileName);
#endif
            _logger.InfoFormat("Initialize a new session. The session storage file is {0}.", _sessionStorageFileFullPath);
            _sessionStorage = new SessionStorage();
        }


        /// <summary>
        /// Start this session.
        /// </summary>
        public void Start()
        {
            lock (_lock)
            {
                // Read session info from persistent storage, in case app is killed.
                RetrieveSessionStorage();

                // If session storage is valid, restore session and resume session.
                if (_sessionStorage != null && !string.IsNullOrEmpty(_sessionStorage._sessionId))
                {
                    this.StartTime = _sessionStorage._startTime;
                    this.StopTime = _sessionStorage._stopTime;
                    this.SessionId = _sessionStorage._sessionId;
                    this.Duration = _sessionStorage._duration;

                    Resume();
                }
                // Otherwise, create a new session.
                else
                {
                    NewSessionHelper();
                }
            }
        }

        /// <summary>
        /// Pause this session.
        /// </summary>
        public void Pause()
        {
            lock (_lock)
            {
                PauseSessionHelper();
                SaveSessionStorage();
            }
        }

        /// <summary>
        /// Resume this session.
        /// </summary>       
        public void Resume()
        {
            lock (_lock)
            {
                if (this.StopTime == null)
                {
                    //this may sometimes be a valid scenario e.g when the applciation starts
                    _logger.InfoFormat("Call Resume() without calling Pause() first. But this can be valid opertion only when MobileAnalyticsManager instance is created.");
                    return;
                }

                DateTime currentTime = AWSSDKUtils.CorrectedUtcNow;
                if (this.StopTime.Value < currentTime)
                {
                    // new session 
                    if (Convert.ToInt64((currentTime - this.StopTime.Value).TotalMilliseconds) > _maConfig.SessionTimeout * 1000)
                    {
                        StopSessionHelper();
                        NewSessionHelper();
                    }
                    // resume old session
                    else
                    {
                        ResumeSessionHelper();
                    }
                }
                else
                {
                    InvalidOperationException e = new InvalidOperationException();
                    _logger.Error(e, "Session stop time is earlier than start time !");
                }
            }
        }
        #endregion

        private void NewSessionHelper()
        {

            StartTime = AWSSDKUtils.CorrectedUtcNow;
            PreStartTime = AWSSDKUtils.CorrectedUtcNow;
            StopTime = null;
            SessionId = Guid.NewGuid().ToString();
            Duration = 0;

            CustomEvent sessionStartEvent = new CustomEvent(Constants.SESSION_START_EVENT_TYPE);

            sessionStartEvent.StartTimestamp = StartTime;
            sessionStartEvent.SessionId = SessionId;

            MobileAnalyticsManager.GetInstance(_appID).RecordEvent(sessionStartEvent);
        }

        private void StopSessionHelper()
        {
            DateTime currentTime = AWSSDKUtils.CorrectedUtcNow;

            // update session info
            StopTime = currentTime;

            // record session stop event
            CustomEvent stopSessionEvent = new CustomEvent(Constants.SESSION_STOP_EVENT_TYPE);

            stopSessionEvent.StartTimestamp = StartTime;

            if (StopTime != null)
                stopSessionEvent.StopTimestamp = StopTime;
            stopSessionEvent.SessionId = SessionId;
            stopSessionEvent.Duration = Duration;

            MobileAnalyticsManager.GetInstance(_appID).RecordEvent(stopSessionEvent);
        }

        private void PauseSessionHelper()
        {
            DateTime currentTime = AWSSDKUtils.CorrectedUtcNow;

            // update session info
            StopTime = currentTime;
            Duration += Convert.ToInt64((currentTime - PreStartTime).TotalMilliseconds);

            // record session pause event
            CustomEvent pauseSessionEvent = new CustomEvent(Constants.SESSION_PAUSE_EVENT_TYPE);
            pauseSessionEvent.StartTimestamp = StartTime;

            if (StopTime != null)
                pauseSessionEvent.StopTimestamp = StopTime;
            pauseSessionEvent.SessionId = SessionId;
            pauseSessionEvent.Duration = Duration;
            MobileAnalyticsManager.GetInstance(_appID).RecordEvent(pauseSessionEvent);
        }

        private void ResumeSessionHelper()
        {
            DateTime currentTime = AWSSDKUtils.CorrectedUtcNow;

            // update session info
            PreStartTime = currentTime;

            // record session resume event
            CustomEvent resumeSessionEvent = new CustomEvent(Constants.SESSION_RESUME_EVENT_TYPE);
            resumeSessionEvent.StartTimestamp = StartTime;
            if (StopTime != null)
                resumeSessionEvent.StopTimestamp = StopTime;
            resumeSessionEvent.SessionId = SessionId;
            resumeSessionEvent.Duration = Duration;

            MobileAnalyticsManager.GetInstance(_appID).RecordEvent(resumeSessionEvent);
        }

        private void SaveSessionStorage()
        {
            _sessionStorage._startTime = StartTime;
            _sessionStorage._stopTime = StopTime;
            _sessionStorage._preStartTime = PreStartTime;
            _sessionStorage._sessionId = SessionId;
            _sessionStorage._duration = Duration;

            // store session into file
            _logger.DebugFormat("Mobile Analytics is about to store session info: {0} ", JsonMapper.ToJson(_sessionStorage));
#if PCL
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFile file = rootFolder.CreateFileAsync(_sessionStorageFileFullPath, CreationCollisionOption.ReplaceExisting).Result;
            file.WriteAllTextAsync(JsonMapper.ToJson(_sessionStorage)).Wait();
#elif BCL
            string directory = Path.GetDirectoryName(_sessionStorageFileFullPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            File.WriteAllText(_sessionStorageFileFullPath, JsonMapper.ToJson(_sessionStorage));
#elif UNITY
            Action action = () =>
            {
                // create a file to store session info
                if (!File.Exists(_sessionStorageFileFullPath))
                {
                    FileStream fs = File.Create(_sessionStorageFileFullPath);
                    fs.Close();

                    File.WriteAllText(_sessionStorageFileFullPath, JsonMapper.ToJson(_sessionStorage));
                }
                else
                {
                    File.WriteAllText(_sessionStorageFileFullPath, String.Empty);
                    File.WriteAllText(_sessionStorageFileFullPath, JsonMapper.ToJson(_sessionStorage));
                }
            };


            if (UnityInitializer.IsMainThread())
            {
                action();
            }
            else
            {
                ManualResetEvent e = new ManualResetEvent(false);
                UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    action();
                    e.Set();
                });
                e.WaitOne();
            }
#endif

        }

        private void RetrieveSessionStorage()
        {
            string sessionString = null;
#if PCL
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            if (ExistenceCheckResult.FileExists == rootFolder.CheckExistsAsync(_sessionStorageFileFullPath).Result)
            {
                IFile file = rootFolder.GetFileAsync(_sessionStorageFileFullPath).Result;
                sessionString = file.ReadAllTextAsync().Result;
            }
#elif BCL
            if (File.Exists(_sessionStorageFileFullPath))
            {
                using (var sessionFile = new System.IO.StreamReader(_sessionStorageFileFullPath))
                {
                    sessionString = sessionFile.ReadToEnd();
                    sessionFile.Close();
                }
                _logger.DebugFormat("Mobile Analytics retrieves session info: {0}", sessionString);
            }
            else
            {
                _logger.DebugFormat("Mobile Analytics session file does not exist.");
            }
#elif UNITY
            Action action = () =>
            {
                if (File.Exists(_sessionStorageFileFullPath))
                {
                    System.IO.StreamReader sessionFile = new System.IO.StreamReader(_sessionStorageFileFullPath);
                    sessionString = sessionFile.ReadToEnd();
                    sessionFile.Close();
                    _logger.DebugFormat("Mobile Analytics retrieves session info: {0}", sessionString);
                }
                else
                {
                    _logger.DebugFormat("Mobile Analytics session file does not exist.");
                }
            };


            if (UnityInitializer.IsMainThread())
            {
                action();
            }
            else
            {
                ManualResetEvent e = new ManualResetEvent(false);
                UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    action();
                    e.Set();
                });

                e.WaitOne();
            }

#endif
            if (!string.IsNullOrEmpty(sessionString))
            {
                _sessionStorage = JsonMapper.ToObject<SessionStorage>(sessionString);
            }

        }


        #region dispose pattern implementation
        /// <summary>
        /// Dispose pattern implementation
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose pattern implementation
        /// </summary>
        /// <param name="disposing">if disposing</param>
        protected virtual void Dispose(bool disposing)
        {

        }

        #endregion
    }
}
