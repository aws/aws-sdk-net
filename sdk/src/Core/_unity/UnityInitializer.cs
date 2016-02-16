/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;

using Amazon;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal;
using Amazon.Util;
using System.Threading;
using Amazon.Util.Internal;

namespace Amazon
{
    /// <summary>
    /// A singleton instance of which will initialize the Main thread dispatcher & logger.
    /// This class is linked to the AWSPrefab so that user can make any configuration 
    /// changes and instance will be included in every scene via the prefab.
    /// </summary>
    public class UnityInitializer : MonoBehaviour
    {

        private static UnityInitializer _instance = null;
        private static object _lock = new object();

        #region constructor
        private UnityInitializer(){}
        #endregion

        #region public api
        /// <summary>
        /// Attaches the initializer to a game object
        /// </summary>
        /// <param name="gameObject">The game object to which you attach the initializer to</param>
        public static void AttachToGameObject(GameObject gameObject)
        {
            if (gameObject != null)
            {
                gameObject.AddComponent<UnityInitializer>();
                UnityEngine.Debug.Log(string.Format(@"Attached unity initializer to {0}", gameObject.name));
            }
            else
            {
                throw new ArgumentNullException("gameObject");
            }
         
        }

        /// <summary>
        /// Returns the Instance of UnityInitializer
        /// </summary>
        public static UnityInitializer Instance
        {
            get
            {
                return _instance;
            }
        }


        public void Awake()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    // singleton instance
                    _instance = this;

                    if (_mainThread == null || !_mainThread.Equals(Thread.CurrentThread))
                        _mainThread = Thread.CurrentThread;

                    AmazonHookedPlatformInfo.Instance.Init();

                    // preventing the instance from getting destroyed between scenes
                    DontDestroyOnLoad(this);

                    //initialize the logger
                    TraceListener tracelistener = new UnityDebugTraceListener("UnityDebug");
                    AWSConfigs.AddTraceListener("Amazon", tracelistener);

                    // Associate the main thread dispatcher
                    _instance.gameObject.AddComponent<UnityMainThreadDispatcher>();


                }
                else
                {
                    if (this != _instance)
                    {
                        //destroy the new instance
                        DestroyObject(this);
                    }
                }

            }
        }
        #endregion

        private static Thread _mainThread;
        /// <summary>
        /// Checks if the thread is a game/main/unity thread
        /// </summary>
        /// <returns>true if the thread is the game/main/unity thread, else false</returns>
        public static bool IsMainThread()
        {
            if (null == _mainThread)
            {
                throw new Exception("Main thread has not been set, is the AWSPrefab on the scene?");
            }
            return Thread.CurrentThread.Equals(_mainThread);
        }

    }
}
