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

using System.Threading;
using System.Collections;
using System;
using System.IO;
using ThirdParty.Json.LitJson;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

#if PCL
using PCLStorage;
using System.Threading.Tasks;
#endif


namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// The class controls session start, pause, resume and stop logic.
    /// </summary>
    public class Session
    {
        private Logger _logger = Logger.GetLogger(typeof(Session));

        // session info
        private DateTime _startTime;
        private DateTime? _stopTime;
        private DateTime _preStartTime;
        private string _sessionId;
        private long _duration;

        // Session Timeout
        int SESSION_TIMEOUT;

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

        private volatile SessionStorage _sessionStorage = null;

        private string APP_ID;

        private string _sessionStorageFileName = "_session_storage.json";
        private string _sessionStorageFileFullPath = null;
        internal static readonly DateTime EPOCH_START = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);


        #region public

        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session"/>
        /// </summary>
        /// <param name="appId">Amazon Mobile Analytics App Identifier.</param>
        /// <param name="sessionTimeout">Session time out value in seconds.</param>
        public Session(string appId, int sessionTimeout)
        {
            if (string.IsNullOrEmpty(appId))
                throw new ArgumentNullException("appId");

            if (sessionTimeout <= 0)
                throw new ArgumentException("sessionTimeout must be integer bigger than 0.");

            APP_ID = appId;
            SESSION_TIMEOUT = sessionTimeout;

#if BCL35 || BCL45
            _sessionStorageFileFullPath = _sessionStorageFileName;
#elif PCL
            _sessionStorageFileFullPath = System.IO.Path.Combine(PCLStorage.FileSystem.Current.LocalStorage.Path, appId + _sessionStorageFileName);
#endif
            _sessionStorage = new SessionStorage();
        }

        /// <summary>
        /// Start this session.
        /// </summary>
#if BCL35 || BCL45
        internal void Start()
#elif PCL
        internal async void Start()
#endif
        {
            // Read session info from persistent storage, in case app is killed.

#if BCL35 || BCL45
            RetrieveSessionStorage();
#elif PCL
            await RetrieveSessionStorage();
#endif

            // If session storage is valid, restore session and resume session.
            if (_sessionStorage != null && !string.IsNullOrEmpty(_sessionStorage._sessionId))
            {
                _startTime = _sessionStorage._startTime;
                _stopTime = _sessionStorage._stopTime;
                _sessionId = _sessionStorage._sessionId;
                _duration = _sessionStorage._duration;

                Resume();
            }
            else
            {
                NewSession();
            }

        }

        /// <summary>
        /// Pause this session.
        /// </summary>
        public void Pause()
        {
            PauseSession();
            _logger.InfoFormat("before Save session storage");

            SaveSessionStorage();
            _logger.InfoFormat("after Save session storage");
        }

        /// <summary>
        /// Resume this session.
        /// </summary>
        public void Resume()
        {
            if (_stopTime == null)
            {
                //this may sometimes be a valid scenario e.g when the applciation starts
                _logger.InfoFormat("Call Resume() without calling Pause() first. But this can be valid opertion only when MobileAnalyticsManager instance is created.");
                return;
            }

            DateTime currentTime = DateTime.UtcNow;

            if (_stopTime.Value < currentTime)
            {

                long resumeTimeStamp = Convert.ToInt64((currentTime - EPOCH_START).TotalSeconds);
                long stopTimeStamp = Convert.ToInt64((_stopTime.Value - EPOCH_START).TotalSeconds);

                // new session 
                if (resumeTimeStamp - stopTimeStamp > SESSION_TIMEOUT)
                {
                    StopSession();
                    NewSession();

                }
                // resume old session
                else
                {
                    ResumeSession();
                }

            }
            else
            {
                InvalidOperationException e = new InvalidOperationException();
                _logger.Error(e, "session stop time is earlier than start time !");
            }

        }

        /// <summary>
        /// Gets the session info.
        /// </summary>
        /// <returns>SessionInfo object.</returns>
        public SessionInfo RetrieveSessionInfo()
        {
            SessionInfo sessionInfo = new SessionInfo();

            lock (_lock)
            {
                sessionInfo.StartTimestamp = _startTime;
                if (_stopTime != null)
                {
                    sessionInfo.StopTimestamp = _stopTime;
                }
                else
                    sessionInfo.StopTimestamp = null;
                sessionInfo.SessionId = _sessionId;
                sessionInfo.Duration = _duration;
            }
            return sessionInfo;
        }

        #endregion


        #region private
        private void NewSession()
        {
            lock (_lock)
            {
                _startTime = DateTime.UtcNow;
                _preStartTime = DateTime.UtcNow;
                _stopTime = null;
                _sessionId = Guid.NewGuid().ToString();
                _duration = 0;
            }

            CustomEvent sessionStartEvent = new CustomEvent(Constants.SESSION_START_EVENT_TYPE);
            lock (_lock)
            {
                sessionStartEvent.StartTimestamp = _startTime;
                sessionStartEvent.SessionId = _sessionId;
            }

            MobileAnalyticsManager.GetInstance(APP_ID).RecordEventAsync(sessionStartEvent);
        }

        private void StopSession()
        {
            DateTime currentTime = DateTime.UtcNow;

            // update session info
            lock (_lock)
            {
                _stopTime = currentTime;
            }


            // record session stop event
            CustomEvent stopSessionEvent = new CustomEvent(Constants.SESSION_STOP_EVENT_TYPE);
            lock (_lock)
            {
                stopSessionEvent.StartTimestamp = _startTime;

                if (_stopTime != null)
                    stopSessionEvent.StopTimestamp = _stopTime;
                stopSessionEvent.SessionId = _sessionId;
                stopSessionEvent.Duration = _duration;
            }
            MobileAnalyticsManager.GetInstance(APP_ID).RecordEventAsync(stopSessionEvent);
        }

        private void PauseSession()
        {
            DateTime currentTime = DateTime.UtcNow;

            // update session info
            lock (_lock)
            {
                _stopTime = currentTime;
                _duration += Convert.ToInt64((currentTime - _preStartTime).TotalMilliseconds);
            }

            // record session pause event
            CustomEvent pauseSessionEvent = new CustomEvent(Constants.SESSION_PAUSE_EVENT_TYPE);
            lock (_lock)
            {
                pauseSessionEvent.StartTimestamp = _startTime;

                if (_stopTime != null)
                    pauseSessionEvent.StopTimestamp = _stopTime;
                pauseSessionEvent.SessionId = _sessionId;
                pauseSessionEvent.Duration = _duration;
            }
            MobileAnalyticsManager.GetInstance(APP_ID).RecordEventAsync(pauseSessionEvent);
        }

        private void ResumeSession()
        {
            DateTime currentTime = DateTime.UtcNow;

            // update session info
            lock (_lock)
            {
                _preStartTime = currentTime;
            }

            // record session resume event
            CustomEvent resumeSessionEvent = new CustomEvent(Constants.SESSION_RESUME_EVENT_TYPE);
            lock (_lock)
            {
                resumeSessionEvent.StartTimestamp = _startTime;
                if (_stopTime != null)
                    resumeSessionEvent.StopTimestamp = _stopTime;
                resumeSessionEvent.SessionId = _sessionId;
                resumeSessionEvent.Duration = _duration;
            }
            MobileAnalyticsManager.GetInstance(APP_ID).RecordEventAsync(resumeSessionEvent);
        }

#if BCL35 || BCL45
        private void SaveSessionStorage()
#elif PCL 
        private async void SaveSessionStorage()
#endif
        {
            lock (_lock)
            {
                _sessionStorage._startTime = _startTime;
                _sessionStorage._stopTime = _stopTime;
                _sessionStorage._preStartTime = _preStartTime;
                _sessionStorage._sessionId = _sessionId;
                _sessionStorage._duration = _duration;
            }

            // store session into file
            _logger.DebugFormat("Mobile Analytics is about to store session info: {0} ", JsonMapper.ToJson(_sessionStorage));
#if BCL35 || BCL45
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
#elif PCL 
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFile file = await rootFolder.CreateFileAsync(_sessionStorageFileFullPath, CreationCollisionOption.ReplaceExisting);
            await file.WriteAllTextAsync(JsonMapper.ToJson(_sessionStorage));
#endif
        }

#if BCL35 || BCL45
        private bool RetrieveSessionStorage()
#elif PCL
        private async Task<bool> RetrieveSessionStorage()        
#endif
        {
            string sessionString = null;

#if BCL35 || BCL45
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
#elif PCL 
            try
            {
                IFolder rootFolder = FileSystem.Current.LocalStorage;

                if(ExistenceCheckResult.FileExists  == await rootFolder.CheckExistsAsync(_sessionStorageFileFullPath))
                {
                    IFile file = await rootFolder.GetFileAsync(_sessionStorageFileFullPath);
                    sessionString = await file.ReadAllTextAsync();
                }

            }
            catch (Exception e)
            {
                _logger.Error(e, "Catch Exception when reading session storage file.");
                return false;
            }

#endif

            if (!string.IsNullOrEmpty(sessionString))
            {
                try
                {
                    _sessionStorage = JsonMapper.ToObject<SessionStorage>(sessionString);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Get exception when convert string to SessionStorage object.");
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion
    }
}
