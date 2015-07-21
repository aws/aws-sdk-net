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
        public static MobileAnalyticsManager GetOrCreateInstance(string appID)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");

            return GetOrCreateInstanceHelper(appID, null, null, null);
        }

        public static MobileAnalyticsManager GetOrCreateInstance(string appID, AWSCredentials credentials)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");
            if (credentials == null)
                throw new ArgumentNullException("credential");

            return GetOrCreateInstanceHelper(appID, credentials, null, null);
        }

        public static MobileAnalyticsManager GetOrCreateInstance(string appID, RegionEndpoint regionEndpoint)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");
            if (regionEndpoint == null)
                throw new ArgumentNullException("regionEndpoint");

            return GetOrCreateInstanceHelper(appID, null, regionEndpoint, null);
        }

        public static MobileAnalyticsManager GetOrCreateInstance(string appID, MobileAnalyticsManagerConfig maConfig)
        {
            if (string.IsNullOrEmpty(appID))
                throw new ArgumentNullException("appID");
            if (maConfig == null)
                throw new ArgumentNullException("maConfig");

            return GetOrCreateInstanceHelper(appID, null, null, maConfig);
        }
    }
}
