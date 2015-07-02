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


using System.Collections;
using System;

using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager
{
    /// <summary>
    /// Provides information for Mobile Analytics Client Context header. 
    /// Client Context header needs information like App title, version code, version name, package name etc.
    /// </summary>
    public class ClientContextConfig
    { 
        /// <summary>
        /// Constuctor of ClientContextConfig.
        /// </summary>
        /// <param name="appId"></param>
        public ClientContextConfig(string appId)
        {
            this.AppId = appId;
        }

        /// <summary>
        /// Mobile Analytics app identifier. 
        /// The value is obtained from Mobile Analytics console for record your app data.
        /// </summary>
        public string AppId { get; set; }
        
        /// <summary>
        /// The title of your app. For example, "My App".
        /// </summary>
        public string AppTitle { get; set; }

        /// <summary>
        /// The version for your app. For example, V3.0.
        /// </summary>
        public string AppVersionName { get; set; }

        /// <summary>
        /// The version code of your app. For example, 3.0.
        /// </summary>
        public string AppVersionCode { get; set; }

        /// <summary>
        /// The name of your app package. For example, com.your_company.your_app.
        /// </summary>
        public string AppPackageName { get; set; }

        /// <summary>
        /// The operating system of the device. For example, iPhoneOS.
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// The version of the operating system of the device. For example, 8.1.
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// The locale of the device. For example, en_US.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// The manufacturer of the device. For example, Samsung.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// The model of the device. For example, Nexus.
        /// </summary>
        public string Model { get; set; }
    }
}
