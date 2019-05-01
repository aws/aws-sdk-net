//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
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

        /// <summary>
        /// Gets or creates Mobile Analytics Manager instance. If the instance already exists, returns the instance; otherwise
        /// creates new instance and returns it.
        /// </summary>
        /// <param name="appID">Amazon Mobile Analytics Application ID.</param>
        /// <returns>Mobile Analytics Manager instance. </returns>
        public static MobileAnalyticsManager GetOrCreateInstance(string appID)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");

            return GetOrCreateInstanceHelper(appID, null, null, null);
        }

        /// <summary>
        /// Gets or creates Mobile Analytics Manager instance. If the instance already exists, returns the instance; otherwise
        /// creates new instance and returns it.
        /// </summary>
        /// <param name="appID">Amazon Mobile Analytics Application ID.</param>
        /// <param name="credentials">AWS Credentials.</param>
        /// <returns>Mobile Analytics Manager instance. </returns>
        public static MobileAnalyticsManager GetOrCreateInstance(string appID, AWSCredentials credentials)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");
            if (null == credentials)
                throw new ArgumentNullException("credentials");

            return GetOrCreateInstanceHelper(appID, credentials, null, null);
        }

        /// <summary>
        /// Gets or creates Mobile Analytics Manager instance. If the instance already exists, returns the instance; otherwise
        /// creates new instance and returns it.
        /// </summary>
        /// <param name="appID">Amazon Mobile Analytics Application ID.</param>
        /// <param name="regionEndpoint">Region endpoint.</param>
        /// <returns>Mobile Analytics Manager instance. </returns>
        public static MobileAnalyticsManager GetOrCreateInstance(string appID, RegionEndpoint regionEndpoint)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");
            if (null == regionEndpoint)
                throw new ArgumentNullException("regionEndpoint");

            return GetOrCreateInstanceHelper(appID, null, regionEndpoint, null);
        }

        /// <summary>
        /// Gets or creates Mobile Analytics Manager instance. If the instance already exists, returns the instance; otherwise
        /// creates new instance and returns it.
        /// </summary>
        /// <param name="appID">Amazon Mobile Analytics Application ID.</param>
        /// <param name="maConfig">Amazon Mobile Analytics Manager configuration.</param>
        /// <returns>Mobile Analytics Manager instance. </returns>
        public static MobileAnalyticsManager GetOrCreateInstance(string appID, MobileAnalyticsManagerConfig maConfig)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");
            if (null == maConfig)
                throw new ArgumentNullException("maConfig");

            return GetOrCreateInstanceHelper(appID, null, null, maConfig);
        }
		
        #region private
#if BCL
        static void ValidateParameters()
        {
            if (string.IsNullOrEmpty(AWSConfigs.ApplicationName))
            {
                throw new ArgumentException("A valid application name needs to configured to use this API." +
                    "The application name can be configured through app.config/web.config or by setting the Amazon.AWSConfigs.ApplicationName property.");
            }
        }
#endif
        #endregion
		
    }
}
