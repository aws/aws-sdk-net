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

using ThirdParty.Json.LitJson;
using Amazon.Util;
using Amazon.Util.Internal;
using Amazon.Util.Internal.PlatformServices;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// This class composes Client Context header for Amazon Mobile Analytics.
    /// It contains infomation like app title, version code, version name, client id, OS platform etc.
    /// </summary>
    public class ClientContext
    {
        //client related keys
        private const string CLIENT_KEY = "client";
        private const string CLIENT_ID_KEY = "client_id";
        private const string CLIENT_APP_TITLE_KEY = "app_title";
        private const string CLIENT_APP_VERSION_NAME_KEY = "app_version_name";
        private const string CLIENT_APP_VERSION_CODE_KEY = "app_version_code";
        private const string CLIENT_APP_PACKAGE_NAME_KEY = "app_package_name";
        
        //custom keys
        private const string CUSTOM_KEY = "custom";
        
        //env related keys
        private const string ENV_KEY = "env";
        private const string ENV_PLATFORM_KEY = "platform";
        private const string ENV_MODEL_KEY = "model";
        private const string ENV_MAKE_KEY = "make";
        private const string ENV_PLATFORM_VERSION_KEY = "platform_version";
        private const string ENV_LOCALE_KEY = "locale";
        
        //servies related keys
        private const string SERVICES_KEY = "services";
        private const string SERVICE_MOBILE_ANALYTICS_KEY = "mobile_analytics";
        private const string SERVICE_MOBILE_ANALYTICS_APP_ID_KEY = "app_id";
        

        private IDictionary<string,string> _client;
        private IDictionary<string,string> _custom;
        private IDictionary<string,string> _env;
        private IDictionary<string,IDictionary> _services;
        
        private IDictionary _clientContext;
        private ClientContextConfig _config;
        private static object _lock = new object();
        private string _clientID = null;
        private static IApplicationSettings _appSetting = new ApplicationSettings();
        private static IApplicationInfo _appInfo = new ApplicationInfo();
        private static IEnvironmentInfo _envInfo = new EnvironmentInfo();

        private const string APP_ID_KEY = "APP_ID_KEY";
        private const string CLIENT_ID_CACHE_FULL_PATH = "client-ID-cache";

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.ClientContext"/> class.
        /// </summary>
        /// <param name="config">Config <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.ClientContextConfig"/></param>
        public ClientContext (ClientContextConfig config)
        {
            this.Config = config;
            _custom = new Dictionary<string, string>();

#if PCL || __IOS__ || __ANDROID__
            if (string.IsNullOrEmpty(_clientID))
            {
                _clientID = _appSetting.GetValue(APP_ID_KEY, ApplicationSettingsMode.Local);
                if (string.IsNullOrEmpty(_clientID))
                {
                    _clientID = Guid.NewGuid().ToString();
                    _appSetting.SetValue(APP_ID_KEY, _clientID, ApplicationSettingsMode.Local);
                }
            }
#elif BCL35 || BCL45
            if (string.IsNullOrEmpty(_clientID))
            {
                if (!System.IO.File.Exists(CLIENT_ID_CACHE_FULL_PATH))
                {
                    System.IO.FileStream fs = System.IO.File.Create(CLIENT_ID_CACHE_FULL_PATH);
                    fs.Close();
                    _clientID = Guid.NewGuid().ToString();
                    System.IO.File.WriteAllText(CLIENT_ID_CACHE_FULL_PATH, _clientID);
                }
                else
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(CLIENT_ID_CACHE_FULL_PATH);
                    _clientID = file.ReadToEnd();
                    file.Close();
                }
            }
#endif

        }
        
        /// <summary>
        /// Gets or sets the config <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.ClientContextConfig"/>.
        /// </summary>
        /// <value>The client context config.</value>
        public ClientContextConfig Config
        {
            set
            {
                _config = value;
            }
            
            get
            {
                return _config;
            }
        }
        
        /// <summary>
        /// Adds the custom attributes to the Client Context.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Value.</param>
        public void AddCustomAttributes(string key, string value)
        {
            lock(_lock)
            {
                _custom.Add(key,value);
            }
        }
        
        /// <summary>
        /// Gets a Json Representation of the Client Context.
        /// </summary>
        /// <returns>Json Representation of Client Context</returns>
        public String ToJsonString()
        {
            lock(_lock)
            {
                _client = new Dictionary<string, string>();
                _env = new Dictionary<string, string>();
                _services = new Dictionary<string, IDictionary>();

#if PCL || __IOS__ || __ANDROID__
                 // client
                _client.Add(CLIENT_ID_KEY, _clientID);
                _client.Add(CLIENT_APP_TITLE_KEY, _appInfo.AppTitle);
                _client.Add(CLIENT_APP_VERSION_NAME_KEY, _appInfo.AppVersionName);
                _client.Add(CLIENT_APP_VERSION_CODE_KEY, _appInfo.AppVersionCode);
                _client.Add(CLIENT_APP_PACKAGE_NAME_KEY, _appInfo.PackageName);

                // env
                _env.Add(ENV_PLATFORM_KEY, _envInfo.Platform);
                _env.Add(ENV_PLATFORM_VERSION_KEY, _envInfo.PlatformVersion);
                _env.Add(ENV_LOCALE_KEY, _envInfo.Locale);
                _env.Add(ENV_MAKE_KEY, _envInfo.Make);
                _env.Add(ENV_MODEL_KEY, _envInfo.Model);

#elif BCL35 || BCL45
                // client
                _client.Add(CLIENT_ID_KEY, _clientID);

                if(!string.IsNullOrEmpty(this.Config.AppTitle))
                    _client.Add(CLIENT_APP_TITLE_KEY, this.Config.AppTitle);
                
                if(!string.IsNullOrEmpty(this.Config.AppVersionName))
                    _client.Add(CLIENT_APP_VERSION_NAME_KEY, this.Config.AppVersionName);
                
                if(!string.IsNullOrEmpty(this.Config.AppVersionCode))
                    _client.Add(CLIENT_APP_VERSION_CODE_KEY, this.Config.AppVersionCode);

                if(!string.IsNullOrEmpty(this.Config.AppPackageName))
                    _client.Add(CLIENT_APP_PACKAGE_NAME_KEY, this.Config.AppPackageName);


                // env
                if(!string.IsNullOrEmpty(this.Config.Platform))
                    _env.Add(ENV_PLATFORM_KEY, this.Config.Platform);
                else
                    _env.Add(ENV_PLATFORM_KEY, Environment.OSVersion.Platform.ToString());
                
                if(!string.IsNullOrEmpty(this.Config.PlatformVersion))
                    _env.Add(ENV_PLATFORM_KEY, this.Config.PlatformVersion);
                else
                    _env.Add(ENV_PLATFORM_VERSION_KEY, Environment.OSVersion.Version.ToString());
                
                if(!string.IsNullOrEmpty(this.Config.Locale))
                    _env.Add(ENV_LOCALE_KEY, this.Config.Locale);
                else
                    _env.Add(ENV_LOCALE_KEY, System.Globalization.CultureInfo.CurrentCulture.Name);
                
                if (!string.IsNullOrEmpty(this.Config.Make))
                    _env.Add(ENV_MAKE_KEY, this.Config.Make);
                
                if(!string.IsNullOrEmpty(this.Config.Model))
                    _env.Add(ENV_MODEL_KEY, this.Config.Model);
#endif
                // services
                IDictionary mobileAnalyticsService = new Dictionary<string, string>();
                mobileAnalyticsService.Add(SERVICE_MOBILE_ANALYTICS_APP_ID_KEY, Config.AppId);
                _services.Add(SERVICE_MOBILE_ANALYTICS_KEY, mobileAnalyticsService);


                _clientContext = new Dictionary<string, IDictionary>();
                _clientContext.Add(CLIENT_KEY, _client);
                _clientContext.Add(ENV_KEY, _env);
                _clientContext.Add(CUSTOM_KEY, _custom);
                _clientContext.Add(SERVICES_KEY, _services);

                return JsonMapper.ToJson(_clientContext); 
            
            }
        }
    }
}

