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

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Provides information for Mobile Analytics Client Context header. 
    /// Client Context header needs information like App title, version code, version name, package name etc.
    /// </summary>
    public class ClientContextConfig
    {
        private const string APP_CLIENT_ID_KEY = "mobile_analytics_client_id";
        
        private string _appTitle = "";
        private string _appVersionName = "";
        private string _appVersionCode = "";
        private string _appPackageName = "";
        private string _appId = "";


        // TODO : add platform specific implementation: using PCLCommon
#if PCL
        public ClientContextConfig(string appId)
            : this("", "", "", "", appId)
        {

        }
#elif BCL35 || BCL45
        public ClientContextConfig(string appId)
            : this("", "", "", "", appId)
        {

        }   
#endif

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.ClientContextConfig"/> class.
        /// </summary>
        /// <param name="appTitle">App title -  The title of your app. For example, My App.</param>
        /// <param name="appVersionName">App version name - The version of your app. For example, V2.0.</param>
        /// <param name="appVersionCode">App version code - The version code for your app. For example, 3.</param>
        /// <param name="appPackageName">App package name - The name of your package. For example, com.example.my_app.</param>
        /// <param name="appId">App identifier - AWS Mobile Analytics App ID corresponding to your App</param>
        internal ClientContextConfig(string appTitle, string appVersionName,string appVersionCode, string appPackageName, string appId)
        {
            if (appTitle == null)
            {
                throw new ArgumentNullException("appTitle");
            }

            if (appVersionName == null)
            {
                throw new ArgumentNullException("appVersionName");
            }
            
            if(string.IsNullOrEmpty(appId))
            {
                throw new ArgumentNullException("appId");
            }

            if (appPackageName == null)
            {
                throw new ArgumentNullException("appPackageName");
            }

            if (appVersionCode == null)
            {
                throw new ArgumentNullException("appVersionCode");
            }

            this._appTitle = appTitle;
            this._appVersionName = appVersionName;
            this._appVersionCode = appVersionCode;
            this._appPackageName = appPackageName;
            this._appId = appId;
            
        }


        internal string AppId
        {
            get
            {
                return _appId;
            }
        }
    }
}
