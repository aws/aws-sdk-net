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
    public partial class Session
    {
        private Logger _logger = Logger.GetLogger(typeof(Session));

        // session info
        public DateTime StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public DateTime PreStartTime { get; set; }
        public string SessionId { get; set; }
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
        private string _appId = null;
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
            _appId = appID;
#if BCL
            _sessionStorageFileName = InternalSDKUtils.DetermineAppLocalStoragePath(appID + _sessionStorageFileName);
#elif PCL
            _sessionStorageFileFullPath = System.IO.Path.Combine(PCLStorage.FileSystem.Current.LocalStorage.Path, appID + _sessionStorageFileName);
#endif
            _sessionStorage = new SessionStorage();
        }


        /// <summary>
        /// Start this session.
        /// </summary>
        internal void Start()
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

        /// <summary>
        /// Pause this session.
        /// </summary>
        public void Pause()
        {
            PauseSessionHelper();
            SaveSessionStorage();
        }

        /// <summary>
        /// Resume this session.
        /// </summary>       
        public void Resume()
        {
            if (this.StopTime == null)
            {
                //this may sometimes be a valid scenario e.g when the applciation starts
                _logger.InfoFormat("Call Resume() without calling Pause() first. But this can be valid opertion only when MobileAnalyticsManager instance is created.");
                return;
            }

            DateTime currentTime = DateTime.UtcNow;
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
                _logger.Error(e, "session stop time is earlier than start time !");
            }
        }
        #endregion

        private void NewSessionHelper()
        {
            lock (_lock)
            {
                StartTime = DateTime.UtcNow;
                PreStartTime = DateTime.UtcNow;
                StopTime = null;
                SessionId = Guid.NewGuid().ToString();
                Duration = 0;
            }

            CustomEvent sessionStartEvent = new CustomEvent(Constants.SESSION_START_EVENT_TYPE);
            lock (_lock)
            {
                sessionStartEvent.StartTimestamp = StartTime;
                sessionStartEvent.SessionId = SessionId;
            }
            MobileAnalyticsManager.GetInstance(_appId).RecordEvent(sessionStartEvent);
        }

        private void StopSessionHelper()
        {
            DateTime currentTime = DateTime.UtcNow;

            // update session info
            lock (_lock)
            {
                StopTime = currentTime;
            }

            // record session stop event
            CustomEvent stopSessionEvent = new CustomEvent(Constants.SESSION_STOP_EVENT_TYPE);
            lock (_lock)
            {
                stopSessionEvent.StartTimestamp = StartTime;

                if (StopTime != null)
                    stopSessionEvent.StopTimestamp = StopTime;
                stopSessionEvent.SessionId = SessionId;
                stopSessionEvent.Duration = Duration;
            }
            MobileAnalyticsManager.GetInstance(_appId).RecordEvent(stopSessionEvent);
        }

        private void PauseSessionHelper()
        {
            DateTime currentTime = DateTime.UtcNow;

            // update session info
            lock (_lock)
            {
                StopTime = currentTime;
                Duration += Convert.ToInt64((currentTime - PreStartTime).TotalMilliseconds);
            }

            // record session pause event
            CustomEvent pauseSessionEvent = new CustomEvent(Constants.SESSION_PAUSE_EVENT_TYPE);
            lock (_lock)
            {
                pauseSessionEvent.StartTimestamp = StartTime;

                if (StopTime != null)
                    pauseSessionEvent.StopTimestamp = StopTime;
                pauseSessionEvent.SessionId = SessionId;
                pauseSessionEvent.Duration = Duration;
            }
            MobileAnalyticsManager.GetInstance(_appId).RecordEvent(pauseSessionEvent);
        }

        private void ResumeSessionHelper()
        {
            DateTime currentTime = DateTime.UtcNow;

            // update session info
            lock (_lock)
            {
                PreStartTime = currentTime;
            }

            // record session resume event
            CustomEvent resumeSessionEvent = new CustomEvent(Constants.SESSION_RESUME_EVENT_TYPE);
            lock (_lock)
            {
                resumeSessionEvent.StartTimestamp = StartTime;
                if (StopTime != null)
                    resumeSessionEvent.StopTimestamp = StopTime;
                resumeSessionEvent.SessionId = SessionId;
                resumeSessionEvent.Duration = Duration;
            }
            MobileAnalyticsManager.GetInstance(_appId).RecordEvent(resumeSessionEvent);
        }


        private void SaveSessionStorage()
        {
            lock (_lock)
            {
                _sessionStorage._startTime = StartTime;
                _sessionStorage._stopTime = StopTime;
                _sessionStorage._preStartTime = PreStartTime;
                _sessionStorage._sessionId = SessionId;
                _sessionStorage._duration = Duration;
            }
            // store session into file
            _logger.DebugFormat("Mobile Analytics is about to store session info: {0} ", JsonMapper.ToJson(_sessionStorage));
#if PCL
            lock (_lock)
            {
                IFolder rootFolder = FileSystem.Current.LocalStorage;
                IFile file = rootFolder.CreateFileAsync(_sessionStorageFileFullPath, CreationCollisionOption.ReplaceExisting).Result;
                file.WriteAllTextAsync(JsonMapper.ToJson(_sessionStorage)).Wait();
            }
#elif BCL
            lock (_lock)
            {
                File.WriteAllText(_sessionStorageFileFullPath, JsonMapper.ToJson(_sessionStorage));
            }
#endif
        }

        private void RetrieveSessionStorage()
        {
            string sessionString = null;
#if PCL
            lock (_lock)
            {
                IFolder rootFolder = FileSystem.Current.LocalStorage;
                if (ExistenceCheckResult.FileExists == rootFolder.CheckExistsAsync(_sessionStorageFileFullPath).Result)
                {
                    IFile file = rootFolder.GetFileAsync(_sessionStorageFileFullPath).Result;
                    sessionString = file.ReadAllTextAsync().Result;
                }
            }
#elif BCL
            lock (_lock)
            {
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
            }
#endif
            if (!string.IsNullOrEmpty(sessionString))
            {
                _sessionStorage = JsonMapper.ToObject<SessionStorage>(sessionString);
            }

        }
    }
}
