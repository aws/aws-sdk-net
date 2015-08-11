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
    }
}
