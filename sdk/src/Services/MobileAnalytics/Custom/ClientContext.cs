using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ThirdParty.Json.LitJson;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.MobileAnalytics.Custom
{
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

        private IDictionary<string, string> _client;
        private IDictionary<string, string> _custom;
        private IDictionary<string, string> _env;
        private IDictionary<string, IDictionary> _services;

        private IDictionary _clientContext;

        /*
         * TODO: Verify what this is used for
         */
        private ClientContextConfig _config;

        /*
         * TODO: Verify what this is used for
         */
        private static object _lock = new object();

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="config">Config</param>
        public ClientContext(ClientContextConfig config)
        {
            this.Config = config;
            _custom = new Dictionary<string, string>();
        }

        /// <summary>
        /// Gets or sets the config.
        /// </summary>
        /// <value>The config.</value>
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
        /// Adds the custom attributes to the Client Context
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Value.</param>
        public void AddCustomAttributes(string key, string value)
        {
            lock (_lock)
            {
                _custom.Add(key, value);
            }
        }

        /// <summary>
        /// Gets a Json Representation of the Client Context
        /// </summary>
        /// <returns>Json Representation of Client Context</returns>
        public String ToJsonString()
        {
            lock (_lock)
            {
                _client = new Dictionary<string, string>();
                _env = new Dictionary<string, string>();
                _services = new Dictionary<string, IDictionary>();

                // client
                _client.Add(CLIENT_ID_KEY, Config.ClientId);
                _client.Add(CLIENT_APP_TITLE_KEY, Config.AppTitle);
                
                if (!string.IsNullOrEmpty(Config.AppVersionName))
                {
                    _client.Add(CLIENT_APP_VERSION_NAME_KEY, Config.AppVersionName);
                }
                
                if (!string.IsNullOrEmpty(Config.AppVersionCode))
                {
                    _client.Add(CLIENT_APP_VERSION_CODE_KEY, Config.AppVersionCode);
                }
                
                if (!string.IsNullOrEmpty(Config.AppPackageName))
                {
                    _client.Add(CLIENT_APP_PACKAGE_NAME_KEY, Config.AppPackageName);
                }


                // env
                _env.Add(ENV_PLATFORM_KEY, "iPhoneOS");
                /*
                 * All of the fields below are optional and will appear as null in the S3 bucket.
                 * I'm keeping them null rather than filling in arbitary and pointless values.
                 */
                //_env.Add(ENV_PLATFORM_VERSION_KEY, "4.0.4");
                //_env.Add(ENV_LOCALE_KEY, "en_US");
                //_env.Add(ENV_MAKE_KEY, "Apple");
                //_env.Add(ENV_MODEL_KEY, "iPhone9++");

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
