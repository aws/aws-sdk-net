 /*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Globalization;


using Amazon.Util;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal.Settings;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Credentials;



#if NETSTANDARD
using System.Runtime.InteropServices;
#endif


namespace Amazon.Runtime
{
    /// <summary>
    /// This class is the base class of all the configurations settings to connect
    /// to a service.
    /// </summary>
    public abstract partial class ClientConfig : IClientConfig
    {
        // Represents infinite timeout. http://msdn.microsoft.com/en-us/library/system.threading.timeout.infinite.aspx
        internal static readonly TimeSpan InfiniteTimeout = TimeSpan.FromMilliseconds(-1);
        /// <summary>
        /// Represents upper limit value for <see cref="RequestMinCompressionSizeBytes"/>
        /// </summary>
        internal const long UpperLimitCompressionSizeBytes = 10485760;

        // Represents max timeout.
        public static readonly TimeSpan MaxTimeout = TimeSpan.FromMilliseconds(int.MaxValue);

        private IDefaultConfigurationProvider _defaultConfigurationProvider;
        private string serviceId = null;
        private DefaultConfigurationMode? defaultConfigurationMode;
        private RegionEndpoint regionEndpoint = null;
        private bool probeForRegionEndpoint = true;
        private bool throttleRetries = true;
        private bool useHttp = false;
        private bool useAlternateUserAgentHeader = AWSConfigs.UseAlternateUserAgentHeader;
        private string serviceURL = null;
        private string authRegion = null;
        private string authServiceName = null;
        private string clientAppId = null;
        private SigningAlgorithm signatureMethod = SigningAlgorithm.HmacSHA256;
        private bool logResponse = false;
        private int bufferSize = AWSSDKUtils.DefaultBufferSize;
        private long progressUpdateInterval = AWSSDKUtils.DefaultProgressUpdateInterval;
        private bool resignRetries = false;
        private ICredentials proxyCredentials;
        private bool logMetrics = AWSConfigs.LoggingConfig.LogMetrics;
        private bool disableLogging = false;
        private TimeSpan? timeout = null;
        private bool allowAutoRedirect = true;
        private bool? useDualstackEndpoint;
        private bool? useFIPSEndpoint;
        private bool? disableRequestCompression;
        private long? requestMinCompressionSizeBytes;
        private bool disableHostPrefixInjection = false;
        private bool? endpointDiscoveryEnabled = null;
        private bool? ignoreConfiguredEndpointUrls;
        private int endpointDiscoveryCacheLimit = 1000;
        private RequestRetryMode? retryMode = null;
        private int? maxRetries = null;
        private const int MaxRetriesDefault = 2;
        private const long DefaultMinCompressionSizeBytes = 10240;
        private bool didProcessServiceURL = false;
        private AWSCredentials _defaultAWSCredentials = null;
        private IIdentityResolverConfiguration _identityResolverConfiguration = DefaultIdentityResolverConfiguration.Instance;
        private IAWSTokenProvider _awsTokenProvider;
        private TelemetryProvider telemetryProvider = AWSConfigs.TelemetryProvider;
        private AccountIdEndpointMode? accountIdEndpointMode = null;
        private RequestChecksumCalculation? requestChecksumCalculation = null;
        private ResponseChecksumValidation? responseChecksumValidation = null;

        private CredentialProfileStoreChain credentialProfileStoreChain;
#if BCL
        private readonly TcpKeepAlive tcpKeepAlive = new TcpKeepAlive();
#endif

        /// <summary>
        /// Controls whether the resolved endpoint will include the account id. This allows for direct routing of traffic
        /// to the cell responsible for a given account, which avoids the additional latency of extra backend hops and reduces
        /// complexity in the routing layer.
        /// </summary>
        public AccountIdEndpointMode AccountIdEndpointMode
        {
            get
            {
                if (!accountIdEndpointMode.HasValue)
                {
                    return FallbackInternalConfigurationFactory.AccountIdEndpointMode ?? AccountIdEndpointMode.PREFERRED;
                }
                return accountIdEndpointMode.Value;
            }
            set
            {
                this.accountIdEndpointMode = value;
            }
        }
        /// <summary>
        /// Specifies the profile to be used. When this is set on the ClientConfig and that config is passed to 
        /// the service client constructor the sdk will try to find the credentials associated with the Profile.Name property
        /// If set, this will override AWS_PROFILE and AWSConfigs.ProfileName.
        /// </summary>
        public Profile Profile { get; set; }
        private CredentialProfileStoreChain CredentialProfileStoreChain
        {
            get
            {
                if (credentialProfileStoreChain == null)
                {
                    if(Profile != null)
                    {
                        credentialProfileStoreChain = new CredentialProfileStoreChain(Profile.Location);
                    }
                    else
                    {
                        credentialProfileStoreChain = new CredentialProfileStoreChain();
                    }

                }
                return credentialProfileStoreChain;
            }
            set
            {
                credentialProfileStoreChain = value;
            }
        }

#if BCL
        private static WebProxy GetWebProxyWithCredentials(string value)
#else
        private static Amazon.Runtime.Internal.Util.WebProxy GetWebProxyWithCredentials(string value)
#endif
        {
            if (!string.IsNullOrEmpty(value))
            {
#if BCL
                if (!value.Contains("://"))
                {
                    value = "http://" + value;
                }
                var asUri = new Uri(value);

                var parsedProxy = new WebProxy(asUri);
#else
                var asUri = new Uri(value);
                var parsedProxy = new Amazon.Runtime.Internal.Util.WebProxy(asUri);
#endif
                if (!string.IsNullOrEmpty(asUri.UserInfo)) {
                    var userAndPass = asUri.UserInfo.Split(':');
                    parsedProxy.Credentials = new NetworkCredential(
                        userAndPass[0],
                        userAndPass.Length > 1 ? userAndPass[1] : string.Empty
                    );
                }
                return parsedProxy;
            }

            return null;
        }

        /// <inheritdoc />
        public AWSCredentials DefaultAWSCredentials
        {
            get { return this._defaultAWSCredentials; }
            set { this._defaultAWSCredentials = value; }
        }

        /// <inheritdoc />
        public IIdentityResolverConfiguration IdentityResolverConfiguration
        {
            get { return this._identityResolverConfiguration; }
            set { this._identityResolverConfiguration = value; }
        }

        /// <inheritdoc />
        public IAWSTokenProvider AWSTokenProvider
        {
            get { return this._awsTokenProvider; }
            set { this._awsTokenProvider = value; }
        }

        /// <summary>
        /// Gets Service Version
        /// </summary>
        public abstract string ServiceVersion
        {
            get;
        }

        /// <summary>
        /// Gets and sets of the signatureMethod property.
        /// </summary>
        public SigningAlgorithm SignatureMethod
        {
            get { return this.signatureMethod; }
            set { this.signatureMethod = value; }
        }

        /// <summary>
        /// Gets and sets of the UserAgent property.
        /// </summary>
        public abstract string UserAgent { get; }

        /// <summary>
        /// When set to true, the service client will use the x-amz-user-agent
        /// header instead of the User-Agent header to report version and
        /// environment information to the AWS service.
        ///
        /// Note: This is especially useful when using a platform like WebAssembly
        /// which doesn't allow to specify the User-Agent header.
        /// </summary>
        public bool UseAlternateUserAgentHeader
        {
            get { return this.useAlternateUserAgentHeader; }
            set { this.useAlternateUserAgentHeader = value; }
        }

        /// <summary>
        /// <para>
        /// Gets and sets the RegionEndpoint property.  The region constant that 
        /// determines the endpoint to use.
        /// 
        /// Setting this property to null will force the SDK to recalculate the
        /// RegionEndpoint value based on App/WebConfig, environment variables,
        /// profile, etc.
        /// </para>
        /// <para>
        /// RegionEndpoint and ServiceURL are mutually exclusive properties. 
        /// Whichever property is set last will cause the other to automatically 
        /// be reset to null.
        /// </para>
        /// </summary>
        public RegionEndpoint RegionEndpoint
        {
            get
            {
                if (probeForRegionEndpoint)
                {
                    RegionEndpoint = GetDefaultRegionEndpoint();
                    this.probeForRegionEndpoint = false;
                }
                return this.regionEndpoint;
            }
            set
            {
                if (!string.IsNullOrEmpty(this.serviceURL))
                    Logger.GetLogger(GetType()).InfoFormat($"RegionEndpoint and ServiceURL are mutually exclusive. Since " +
                        $"RegionEndpoint was set last, RegionEndpoint: {value} will be used to make the request and ServiceUrl: {this.serviceURL} has been set to null.");
                this.defaultConfigurationBackingField = null;
                this.serviceURL = null;
                this.regionEndpoint = value;
                this.probeForRegionEndpoint = this.regionEndpoint == null;

                // legacy support for initial pseudo regions - convert to base Region 
                // and set FIPSEndpoint to true
                if (!string.IsNullOrEmpty(value?.SystemName) &&
                    (value.SystemName.Contains("fips-") || value.SystemName.Contains("-fips")))
                {
                    Logger.GetLogger(GetType()).InfoFormat($"FIPS Pseudo Region support is deprecated. Will attempt to convert {value.SystemName}.");

                    this.UseFIPSEndpoint = true;
                    this.regionEndpoint =
                        RegionEndpoint.GetBySystemName(
                            value.SystemName.Replace("fips-", "").Replace("-fips", ""));
                }
            }
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public abstract string RegionEndpointServiceName
        {
            get;
        }

        /// <summary>
        /// <para>
        /// Gets and sets of the ServiceURL property.
        /// This is an optional property; change it
        /// only if you want to try a different service
        /// endpoint.
        /// </para>
        /// <para>
        /// RegionEndpoint and ServiceURL are mutually exclusive properties. 
        /// Whichever property is set last will cause the other to automatically 
        /// be reset to null.
        /// </para>
        /// </summary>
        public string ServiceURL
        {
            get 
            {
                if (!didProcessServiceURL && this.serviceURL == null && IgnoreConfiguredEndpointUrls == false && ServiceId != null)
                {
                    
                    string serviceSpecificTransformedEnvironmentVariable = TransformServiceId.TransformServiceIdToEnvVariable(ServiceId);
                    string transformedConfigServiceId = TransformServiceId.TransformServiceIdToConfigVariable(ServiceId);

                    if (Environment.GetEnvironmentVariable(serviceSpecificTransformedEnvironmentVariable) != null)
                    {
                        Logger.GetLogger(GetType()).InfoFormat($"ServiceURL configured from service specific environment variable: {serviceSpecificTransformedEnvironmentVariable}.");
                        this.ServiceURL = Environment.GetEnvironmentVariable(serviceSpecificTransformedEnvironmentVariable);                    
                    }
                    else if (Environment.GetEnvironmentVariable(EnvironmentVariables.GLOBAL_ENDPOINT_ENVIRONMENT_VARIABLE) != null)
                    {
                        this.ServiceURL = Environment.GetEnvironmentVariable(EnvironmentVariables.GLOBAL_ENDPOINT_ENVIRONMENT_VARIABLE);
                        Logger.GetLogger(GetType()).InfoFormat($"ServiceURL configured from global environment variable: {EnvironmentVariables.GLOBAL_ENDPOINT_ENVIRONMENT_VARIABLE}.");
                    }
                    else
                    {
                        Dictionary<string, string> innerDictionary;
                        string endpointUrlValue;
                        CredentialProfile profile;
                        if (Profile != null)
                        {
                            CredentialProfileStoreChain.TryGetProfile(Profile.Name, out profile);
                        }
                        else
                        {
                            CredentialProfileStoreChain.TryGetProfile(DefaultAWSCredentialsIdentityResolver.GetProfileName(), out profile);
                        }
                        if(profile != null)
                        {
                            if (profile.NestedProperties.TryGetValue(transformedConfigServiceId, out innerDictionary))
                            {
                                if (innerDictionary.TryGetValue(SettingsConstants.EndpointUrl, out endpointUrlValue))
                                {
                                    Logger.GetLogger(GetType()).InfoFormat($"ServiceURL configured from service specific endpoint url in " +
                                    $"profile {profile.Name} from key {transformedConfigServiceId}.");
                                    this.ServiceURL = endpointUrlValue;
                                }

                            }
                            else if (!String.IsNullOrEmpty(profile.EndpointUrl))
                            {
                                Logger.GetLogger(GetType()).InfoFormat($"ServiceURL configured from global endpoint url" +
                                    $"in profile {profile.Name} from key {SettingsConstants.EndpointUrl}.");
                                this.ServiceURL = profile.EndpointUrl;
                            }
                        }

                    }
                    didProcessServiceURL = true;
                }
                return this.serviceURL;

            }
            set
            {
                if (regionEndpoint != null)
                    Logger.GetLogger(GetType()).InfoFormat($"RegionEndpoint and ServiceURL are mutually exclusive. Since " +
                        $"ServiceUrl was set last, ServiceUrl: {value} will be used to make the request and RegionEndpoint: {this.regionEndpoint} has been set to null.");
                this.regionEndpoint = null;
                this.probeForRegionEndpoint = false;
                
                if(!string.IsNullOrEmpty(value))
                {
                    // If the URL passed in only has a host name make sure there is an ending "/" to avoid signature mismatch issues.
                    // If there is a resource path do not add a "/" because the marshallers are relying on the URL to be in format without the "/".
                    // API Gateway Management API is an example of a service that vends its own URL that users have to set which has a resource path.
                    // The marshallers add new segments to the resource path with the "/".
                    try
                    {
                        var path = new Uri(value).PathAndQuery;
                        if (string.IsNullOrEmpty(path) || path == "/")
                        {
                            if (!string.IsNullOrEmpty(value) && !value.EndsWith("/"))
                            {
                                value += "/";
                            }
                        }
                    }
                    catch(UriFormatException)
                    {
                        throw new AmazonClientException("Value for ServiceURL is not a valid URL: " + value);
                    }
                }

                this.serviceURL = value;
            }
        }

        /// <summary>
        /// Gets and sets the UseHttp.
        /// If this property is set to true, the client attempts
        /// to use HTTP protocol, if the target endpoint supports it.
        /// By default, this property is set to false.
        /// </summary>
        /// <remarks>This does not apply if an explicit <see cref="ServiceURL"/> is specified.</remarks>
        public bool UseHttp
        {
            get { return this.useHttp; }
            set { this.useHttp = value; }
        }

        /// <summary>
        /// Gets and sets the AuthenticationRegion property.
        /// Used in AWS4 request signing, this is an optional property; 
        /// change it only if the region cannot be determined from the 
        /// service endpoint.
        /// </summary>
        public string AuthenticationRegion
        {
            get { return this.authRegion; }
            set { this.authRegion = value; }
        }

        /// <summary>
        /// Gets and sets the AuthenticationServiceName property.
        /// Used in AWS4 request signing, this is the short-form
        /// name of the service being called.
        /// </summary>
        public string AuthenticationServiceName
        {
            get { return this.authServiceName; }
            set { this.authServiceName = value; }
        }
        
        /// <summary>
        /// The serviceId for the service, which is specified in the metadata in the ServiceModel.
        /// The transformed value of the service ID (replace any spaces in the service ID 
        /// with underscores and uppercase all letters) is used to set service-specific endpoint urls.
        /// I.e: AWS_ENDPOINT_URL_ELASTIC_BEANSTALK
        /// For configuration files, replace any spaces with underscores and lowercase all letters
        /// I.e. elastic_beanstalk = 
        ///     endpoint_url = http://localhost:8000
        /// </summary>
        public string ServiceId
        {
            get { return this.serviceId; }
            set { this.serviceId = value; }
        }
        /// <summary>
        /// Returns the flag indicating how many retry HTTP requests an SDK should
        /// make for a single SDK operation invocation before giving up. For
        /// RetryMode values of "Standard" or "Adaptive" this flag will return 2. In 
        /// addition to the values returned that are dependent on the RetryMode, the
        /// value can be set to a specific value by using the AWS_MAX_ATTEMPTS environment
        /// variable, max_attempts in the shared configuration file, or by setting a
        /// value directly on this property. When using AWS_MAX_ATTEMPTS or max_attempts
        /// the value returned from this property will be one less than the value entered
        /// because this flag is the number of retry requests, not total requests. To 
        /// learn more about the RetryMode property that affects the values returned by 
        /// this flag, see <see cref="RetryMode"/>.
        /// </summary>
        public int MaxErrorRetry
        {
            get
            {
                if (!this.maxRetries.HasValue)
                {
                    //For standard and adaptive modes first check the environment variables
                    //and shared config for a value. Otherwise default to the new default value.
                    //In the shared config or environment variable MaxAttempts is the total number 
                    //of attempts. This will include the initial call and must be deducted from
                    //from the number of actual retries.
                    return FallbackInternalConfigurationFactory.MaxAttempts - 1 ?? MaxRetriesDefault;
                }

                return this.maxRetries.Value;
            }
            set { this.maxRetries = value; }
        }

        /// <summary>
        /// Determines if MaxErrorRetry has been manually set.
        /// </summary>
        public bool IsMaxErrorRetrySet
        {
            get
            {
                return this.maxRetries.HasValue;
            }
        }

        /// <summary>
        /// Gets and sets the LogResponse property.
        /// If this property is set to true, the service response is logged.
        /// The size of response being logged is controlled by the AWSConfigs.LoggingConfig.LogResponsesSizeLimit property.
        /// </summary>
        public bool LogResponse
        {
            get { return this.logResponse; }
            set { this.logResponse = value; }
        }

        /// <summary>
        /// Gets and Sets the BufferSize property.
        /// The BufferSize controls the buffer used to read in from input streams and write 
        /// out to the request.
        /// </summary>
        public int BufferSize
        {
            get { return this.bufferSize; }
            set { this.bufferSize = value; }
        }

        /// <summary>
        /// <para>
        /// Gets or sets the interval at which progress update events are raised
        /// for upload operations. By default, the progress update events are 
        /// raised at every 100KB of data transferred. 
        /// </para>
        /// <para>
        /// If the value of this property is set less than ClientConfig.BufferSize, 
        /// progress updates events will be raised at the interval specified by ClientConfig.BufferSize.
        /// </para>
        /// </summary>
        public long ProgressUpdateInterval
        {
            get { return progressUpdateInterval; }
            set { progressUpdateInterval = value; }
        }
        

        /// <summary>
        /// Flag on whether to resign requests on retry or not.
        /// For Amazon S3 and Amazon Glacier this value will always be set to true.
        /// </summary>
        public bool ResignRetries
        {
            get { return this.resignRetries; }
            set { this.resignRetries = value; }
        }

        /// <summary>
        /// This flag controls if .NET HTTP infrastructure should follow redirection
        ///  responses (e.g. HTTP 307 - temporary redirect).
        /// </summary>
        public bool AllowAutoRedirect
        {
            get
            {
                return this.allowAutoRedirect;
            }
            set
            {
                this.allowAutoRedirect = value;
            }
        }

        /// <summary>
        /// Flag on whether to log metrics for service calls.
        /// 
        /// This can be set in the application's configs, as below:
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSLogMetrics" value"true"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        public bool LogMetrics
        {
            get { return this.logMetrics; }
            set { this.logMetrics = value; }
        }

        /// <summary>
        /// Gets and sets the DisableLogging. If true logging for this client will be disabled.
        /// </summary>
        public bool DisableLogging
        {
            get { return this.disableLogging; }
            set { this.disableLogging = value; }
        }

        /// <summary>
        /// Specify a <see cref="Amazon.Runtime.DefaultConfigurationMode"/> to use.
        /// <para />
        /// Returns the <see cref="Amazon.Runtime.DefaultConfigurationMode"/> that will be used. If none is specified,
        /// than the correct one is computed by <see cref="IDefaultConfigurationProvider"/>.
        /// </summary>
        public DefaultConfigurationMode DefaultConfigurationMode
        {
            get
            {
                if (this.defaultConfigurationMode.HasValue)
                    return this.defaultConfigurationMode.Value;

                return DefaultConfiguration.Name;
            }
            set
            {
                this.defaultConfigurationMode = value;
                defaultConfigurationBackingField = null;
            }
        }

        private IDefaultConfiguration defaultConfigurationBackingField;
        protected IDefaultConfiguration DefaultConfiguration
        {
            get
            {
                if (defaultConfigurationBackingField != null)
                    return defaultConfigurationBackingField;

                defaultConfigurationBackingField =
                    _defaultConfigurationProvider.GetDefaultConfiguration(RegionEndpoint, defaultConfigurationMode);

                return defaultConfigurationBackingField;
            }
        }

        /// <summary>
        /// Credentials to use with a proxy.
        /// </summary>
        public ICredentials ProxyCredentials
        {
            get 
            {
                if(this.proxyCredentials == null &&
                    (!string.IsNullOrEmpty(AWSConfigs.ProxyConfig.Username) ||
                    !string.IsNullOrEmpty(AWSConfigs.ProxyConfig.Password)))
                {
                    return new NetworkCredential(AWSConfigs.ProxyConfig.Username, AWSConfigs.ProxyConfig.Password ?? string.Empty);
                }
                return this.proxyCredentials;
            }
            set { this.proxyCredentials = value; }
        }

#if BCL
        public WebProxy GetHttpProxy()
#else
        public IWebProxy GetHttpProxy()
#endif
        {
            var explicitProxy = GetWebProxy();
            if (explicitProxy != null)
            {
                return explicitProxy;
            }
            return GetWebProxyWithCredentials(Environment.GetEnvironmentVariable("http_proxy"));
        }

#if BCL
        public WebProxy GetHttpsProxy()
#else
        public IWebProxy GetHttpsProxy()
#endif
        {
            var explicitProxy = GetWebProxy();
            if (explicitProxy != null)
            {
                return explicitProxy;
            }
            return GetWebProxyWithCredentials(Environment.GetEnvironmentVariable("https_proxy"));
        }

#if BCL
        /// <summary>
        /// Specifies the TCP keep-alive values to use for service requests.
        /// </summary>
        public TcpKeepAlive TcpKeepAlive
        {
            get { return this.tcpKeepAlive; }
        }
#endif

        #region Constructor 
        protected ClientConfig(IDefaultConfigurationProvider defaultConfigurationProvider)
        {
            _defaultConfigurationProvider = defaultConfigurationProvider;

            Initialize();
        }

        #endregion

        protected virtual void Initialize()
        {
        }

        /// <summary>
        /// .NET Framework 3.5
        /// ------------------
        /// Overrides the default request timeout value.
        /// This field does not impact *Async calls. A manual timeout (for instance, using CancellationToken) must be implemented.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the Timeout property of the HttpWebRequest/HttpClient object used
        /// to send requests.
        /// </para>
        /// <para>
        /// Please specify a timeout value only if the operation will not complete within the default intervals
        /// specified for an HttpWebRequest/HttpClient.
        /// </para>
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">The timeout specified is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not Infinite.</exception>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        /// <seealso cref="P:System.Net.Http.HttpClient.Timeout"/>
        public TimeSpan? Timeout
        {
            get
            {
                if (this.timeout.HasValue)
                    return this.timeout;

                // TimeToFirstByteTimeout is not a perfect match with HttpWebRequest/HttpClient.Timeout.  However, given
                // that both are configured to only use Timeout until the Response Headers are downloaded, this value
                // provides a reasonable default value.
                return DefaultConfiguration.TimeToFirstByteTimeout;
            }
            set
            {
                ValidateTimeout(value);
                this.timeout = value;
            }
        }

#if NET8_0_OR_GREATER
        TimeSpan? _connectTimeout;

        /// <summary>
        /// Gets and sets the connection timeout that will be set on the HttpClient used by the service client to make requests.
        /// The connection timeout is used control the wait time for the connection to be established to the service. The default
        /// connection timeout for the HttpClient is infinite waiting period.
        /// </summary>
        public TimeSpan? ConnectTimeout
        {
            get
            {
                if (!this._connectTimeout.HasValue)
                    return null;

                return this._connectTimeout.Value;
            }
            set
            {
                ValidateTimeout(value);
                this._connectTimeout = value;
            }
        }
#endif

        /// <summary>
        /// Generates a <see cref="CancellationToken"/> based on the value
        /// for <see cref="DefaultConfiguration.TimeToFirstByteTimeout"/>.
        /// </summary>
        internal CancellationToken BuildDefaultCancellationToken()
        {
            // TimeToFirstByteTimeout is not a perfect match with HttpWebRequest/HttpClient.Timeout.  However, given
            // that both are configured to only use Timeout until the Response Headers are downloaded, this value
            // provides a reasonable default value.
            var cancelTimeout = DefaultConfiguration.TimeToFirstByteTimeout;

            return cancelTimeout.HasValue
                ? new CancellationTokenSource(cancelTimeout.Value).Token
                : default(CancellationToken);
        }

        /// <summary>
        /// Configures the endpoint calculation for a service to go to a dual stack (ipv6 enabled) endpoint
        /// for the configured region.
        /// </summary>
        /// <remarks>
        /// Note: AWS services are enabling dualstack endpoints over time. It is your responsibility to check 
        /// that the service actually supports a dualstack endpoint in the configured region before enabling 
        /// this option for a service.
        /// </remarks>
        public bool UseDualstackEndpoint
        {
            get 
            {
                if (!this.useDualstackEndpoint.HasValue)
                {
                    return FallbackInternalConfigurationFactory.UseDualStackEndpoint ?? false;
                }

                return this.useDualstackEndpoint.Value;
            }
            set { useDualstackEndpoint = value; }
        }

        /// <summary>
        /// Configures the endpoint calculation to go to a FIPS (https://aws.amazon.com/compliance/fips/) endpoint
        /// for the configured region.
        /// </summary>
        public bool UseFIPSEndpoint
        {
            get
            {
                if (!this.useFIPSEndpoint.HasValue)
                {
                    return FallbackInternalConfigurationFactory.UseFIPSEndpoint ?? false;
                }

                return this.useFIPSEndpoint.Value;
            }
            set { useFIPSEndpoint = value; }
        }

        /// <summary>
        /// If set to true the SDK will ignore the configured endpointUrls in the config file or in the environment variables.
        /// By default it is set to false.
        /// </summary>
        public bool IgnoreConfiguredEndpointUrls
        {
            get
            {
                if (!this.ignoreConfiguredEndpointUrls.HasValue)
                    return FallbackInternalConfigurationFactory.IgnoreConfiguredEndpointUrls ?? false;

                return this.ignoreConfiguredEndpointUrls.Value;
            }
            set { ignoreConfiguredEndpointUrls = value; }
        }

        /// <summary>
        /// Controls whether request payloads are automatically compressed for supported operations.
        /// This setting only applies to operations that support compression.
        /// The default value is "false". Set to "true" to disable compression.
        /// </summary>
        public bool DisableRequestCompression
        {
            get
            {
                if (!this.disableRequestCompression.HasValue)
                {
                    return FallbackInternalConfigurationFactory.DisableRequestCompression ?? false;
                }

                return this.disableRequestCompression.Value;
            }
            set { disableRequestCompression = value; }
        }

        /// <summary>
        /// Minimum size in bytes that a request body should be to trigger compression.
        /// </summary>
        public long RequestMinCompressionSizeBytes
        {
            get
            {
                if (!this.requestMinCompressionSizeBytes.HasValue)
                {
                    return FallbackInternalConfigurationFactory.RequestMinCompressionSizeBytes ?? DefaultMinCompressionSizeBytes;
                }

                return this.requestMinCompressionSizeBytes.Value;
            }
            set 
            {
                ValidateMinCompression(value);
                requestMinCompressionSizeBytes = value; 
            }
        }

        /// <summary>
        /// <para>
        /// ClientAppId is an optional application specific identifier that can be set. When set it will be appended to the User-Agent header of every request in the form of <c>app/{ClientAppId}</c>. 
        /// </para>
        /// <para>
        /// If the ClientAppId is not set on the object the SDK will search the environment variable <c>AWS_SDK_UA_APP_ID</c> and the shared config profile attribute <c>sdk_ua_app_id</c> for a potential value for the ClientAppId.
        /// </para>
        /// </summary>
        /// <remarks>
        /// See <see href="https://docs.aws.amazon.com/sdkref/latest/guide/settings-reference.html"/> for more information on environment variables and shared config settings.
        /// </remarks>
        public string ClientAppId
        {
            get
            {
                if (this.clientAppId == null)
                {
                    return FallbackInternalConfigurationFactory.ClientAppId;
                }

                return this.clientAppId;
            }
            set 
            {
                ValidateClientAppId(value);
                this.clientAppId = value;
            }
        }

        private static void ValidateClientAppId(string clientAppId)
        {
            if (clientAppId != null && clientAppId.Length > EnvironmentVariableInternalConfiguration.AWS_SDK_UA_APP_ID_MAX_LENGTH)
            {
                Logger.GetLogger(typeof(InternalConfiguration)).InfoFormat("Warning: Client app id exceeds recommended maximum length of {0} characters: \"{1}\"", EnvironmentVariableInternalConfiguration.AWS_SDK_UA_APP_ID_MAX_LENGTH, clientAppId);
            }
        }

        private static void ValidateMinCompression(long minCompressionSize)
        {
            if (minCompressionSize < 0 || minCompressionSize > UpperLimitCompressionSizeBytes)
            {
                throw new ArgumentException(string.Format("Invalid value {0} for {1}." +
                    " A long value between 0 and {2} bytes inclusive is expected.", minCompressionSize,
                    nameof(requestMinCompressionSizeBytes), UpperLimitCompressionSizeBytes));
            }
        }

        /// <summary>
        /// Enable or disable the Retry Throttling feature by setting the ThrottleRetries flag to True/False respectively.
        /// Retry Throttling is a feature that intelligently throttles retry attempts when a large percentage of requests 
        /// are failing and retries are unsuccessful as well. In such situations the allotted retry capacity for the service URL
        /// will be drained until requests start to succeed again. Once the requisite capacity is available, retries would 
        /// be permitted again. When retries are throttled, the service enters a fail-fast behaviour as the traditional retry attempt
        /// for the request would be circumvented. Hence, errors will resurface quickly. This will result in a greater number of exceptions
        /// but prevents requests being tied up in unsuccessful retry attempts.
        /// Note: Retry Throttling is enabled by default. Set the ThrottleRetries flag to false to switch off this feature.
        /// </summary>
        public bool ThrottleRetries
        {
            get { return throttleRetries; }
            set { throttleRetries = value; }
        }

        /// <summary>
        /// Enable or disable the Nagle algorithm on the underlying http
        /// client.
        /// 
        /// This method is not intended to be called by consumers of the AWS SDK for .NET
        /// </summary>
        /// <param name="useNagle"></param>
        public void SetUseNagleIfAvailable(bool useNagle)
        {
#if BCL
            this.UseNagleAlgorithm = useNagle;
#endif
        }

        /// <summary>
        /// Performs validation on this config object.
        /// Throws exception if any of the required values are missing/invalid.
        /// </summary>
        public virtual void Validate()
        {
            if (RegionEndpoint == null && string.IsNullOrEmpty(this.ServiceURL))
                throw new AmazonClientException("No RegionEndpoint or ServiceURL configured");
#if BCL
            if (TcpKeepAlive.Enabled)
            {
                ValidateTcpKeepAliveTimeSpan(TcpKeepAlive.Timeout, "TcpKeepAlive.Timeout");
                ValidateTcpKeepAliveTimeSpan(TcpKeepAlive.Interval, "TcpKeepAlive.Interval");
            }
#endif
        }

        /// <summary>
        /// Gets and sets the DisableHostPrefixInjection flag. If true, host prefix injection will be disabled for this client, the default value of this flag is false. 
        /// Host prefix injection prefixes the service endpoint with request members from APIs which use this feature. 
        /// Example: for a hostPrefix of "foo-name." and a endpoint of "service.region.amazonaws.com" the default behavior is to
        /// prefix the endpoint with the hostPrefix resulting in a final endpoint of "foo-name.service.region.amazonaws.com". Setting 
        /// DisableHostPrefixInjection to true will disable hostPrefix injection resulting in a final endpoint of
        /// "service.region.amazonaws.com" regardless of the value of hostPrefix. E.g. You may want to disable host prefix injection for testing against a local mock endpoint.
        /// </summary>
        public bool DisableHostPrefixInjection
        {
            get { return this.disableHostPrefixInjection; }
            set { this.disableHostPrefixInjection = value; }
        }

        /// <summary>
        /// Returns the flag indicating if endpoint discovery should be enabled or disabled for operations that are not required to use endpoint discovery.
        /// </summary>
        public bool EndpointDiscoveryEnabled
        {
            get
            {
                if (!this.endpointDiscoveryEnabled.HasValue)
                {
                    return FallbackInternalConfigurationFactory.EndpointDiscoveryEnabled ?? false;
                }

                return this.endpointDiscoveryEnabled.Value;
            }
            set { this.endpointDiscoveryEnabled = value; }
        }

        /// <summary>
        /// Returns the maximum number of discovered endpoints that can be stored within the cache for the client. The default limit is 1000 cache entries.
        /// </summary>
        public int EndpointDiscoveryCacheLimit
        {
            get { return this.endpointDiscoveryCacheLimit; }
            set { this.endpointDiscoveryCacheLimit = value; }
        }

        /// <summary>
        /// Returns the flag indicating the current mode in use for request 
        /// retries and influences the value returned from <see cref="MaxErrorRetry"/>.
        /// The default value is <see cref="RequestRetryMode.Standard"/>. This flag can be configured
        /// by using the AWS_RETRY_MODE environment variable, retry_mode in the
        /// shared configuration file, or by setting this value directly.
        /// </summary>
        public RequestRetryMode RetryMode
        {
            get
            {
                if (!this.retryMode.HasValue)
                {
                    return FallbackInternalConfigurationFactory.RetryMode ?? DefaultConfiguration.RetryMode;
                }

                return this.retryMode.Value;
            }
            set { this.retryMode = value; }
        }
        
        /// <summary>
        /// Under Adaptive retry mode, this flag determines if the client should wait for
        /// a send token to become available or don't block and fail the request immediately
        /// if a send token is not available.
        /// </summary>
        public bool FastFailRequests { get; set; } = false;

        /// <summary>
        /// Throw an exception if the boxed TimeSpan parameter doesn't have a value or is out of range.
        /// </summary>
        public static void ValidateTimeout(TimeSpan? timeout)
        {
            if (!timeout.HasValue)
            {
                throw new ArgumentNullException("timeout");
            }

            if (timeout != InfiniteTimeout && (timeout <= TimeSpan.Zero || timeout > MaxTimeout))
            {
                throw new ArgumentOutOfRangeException("timeout");
            }
        }

#if BCL
        private static void ValidateTcpKeepAliveTimeSpan(TimeSpan? value, string paramName)
        {
            if (!value.HasValue)
            {
                throw new ArgumentNullException(paramName);
            }

            if (value > MaxTimeout || (int)value.Value.TotalMilliseconds <= 0)
            {
                throw new ArgumentOutOfRangeException(paramName);
            }
        }

#endif
        /// <summary>
        /// Returns the request timeout value if its value is set, 
        /// else returns client timeout value.
        /// </summary>
        public static TimeSpan? GetTimeoutValue(TimeSpan? clientTimeout, TimeSpan? requestTimeout)
        {
            return requestTimeout.HasValue ? requestTimeout
                : (clientTimeout.HasValue ? clientTimeout : null);
        }

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="parameters">A Container class for parameters used for endpoint resolution.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public abstract Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters);

#if NETSTANDARD
        /// <summary>
        /// <para>
        /// This is a switch used for performance testing and is not intended for production applications 
        /// to change. This switch may be removed in a future version of the SDK as the .NET Core platform matures.
        /// </para>
        /// <para>
        /// If true, the HttpClient is cached and reused for every request made by the service client 
        /// and shared with other service clients.
        /// </para>
        /// <para>
        /// For the .NET Core platform this is default to true because the HttpClient manages the connection
        /// pool.
        /// </para>
        /// </summary>
        public bool CacheHttpClient {get; set;} = true;

        private int? _httpClientCacheSize;
        /// <summary>
        /// If CacheHttpClient is set to true then HttpClientCacheSize controls the number of HttpClients cached.
        /// <para>
        /// The default value is 1 which is suitable for Windows and for all other platforms that have HttpClient
        /// implementations using System.Net.Http.SocketsHttpHandler (.NET Core 2.1 and higher).
        /// </para>
        /// </summary>
        public int HttpClientCacheSize
        {
            get
            {
                if(_httpClientCacheSize.HasValue)
                {
                    return _httpClientCacheSize.Value;
                }

// Use both NETCOREAPP3_1 and NETCOREAPP3_1_OR_GREATER because currently the build server only has .NET Core 3.1 SDK installed
// which predates the OR_GREATER preprocessor statements. The NETCOREAPP3_1_OR_GREATER is used for future proofing.
#if NETCOREAPP3_1 || NETCOREAPP3_1_OR_GREATER
                return 1;
#else
                return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? 1 : Environment.ProcessorCount;
#endif
            }
            set => _httpClientCacheSize = value;
        }
#endif

#if NETFRAMEWORK
        private TimeSpan? readWriteTimeout = null;

        /// <summary>
        /// Overrides the default read-write timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the ReadWriteTimeout property of the HttpWebRequest object used
        /// to send requests.
        /// </para>
        /// <exception cref="System.ArgumentNullException">The timeout specified is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not Infinite.</exception>
        /// </remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        public TimeSpan? ReadWriteTimeout
        {
            get { return this.readWriteTimeout; }
            set
            {
                ValidateTimeout(value);
                this.readWriteTimeout = value;
            }
        }
#endif

        /// <summary>
        /// Gets and sets of the EndpointProvider property.
        /// This property is used for endpoints resolution.
        /// During service client creation it is set to service's default generated EndpointProvider,
        /// but can be changed to use custom user supplied EndpointProvider.
        /// </summary>
        public IEndpointProvider EndpointProvider { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="TelemetryProvider"/> instance for this client configuration.
        /// <para>
        /// This telemetry provider is used to collect and report telemetry data 
        /// (such as traces and metrics) for operations performed by this specific client.
        /// If this property is not explicitly set, it will default to the global 
        /// <see cref="AWSConfigs.TelemetryProvider"/>.
        /// </para>
        /// </summary>
        public TelemetryProvider TelemetryProvider
        {
            get { return this.telemetryProvider; }
            set { this.telemetryProvider = value; }
        }

        /// <summary>
        /// Determines the behavior for calculating checksums for request payloads.
        /// By default it is set to <see cref="RequestChecksumCalculation.WHEN_SUPPORTED"/>.
        /// </summary>
        public RequestChecksumCalculation RequestChecksumCalculation
        {
            get
            {
                if (!this.requestChecksumCalculation.HasValue)
                    return FallbackInternalConfigurationFactory.RequestChecksumCalculation ?? RequestChecksumCalculation.WHEN_SUPPORTED;

                return this.requestChecksumCalculation.Value;
            }
            set { requestChecksumCalculation = value; }
        }

        /// <summary>
        /// Determines the behavior for validating checksums on response payloads.
        /// By default it is set to <see cref="ResponseChecksumValidation.WHEN_SUPPORTED"/>.
        /// </summary>
        public ResponseChecksumValidation ResponseChecksumValidation
        {
            get
            {
                if (!this.responseChecksumValidation.HasValue)
                    return FallbackInternalConfigurationFactory.ResponseChecksumValidation ?? ResponseChecksumValidation.WHEN_SUPPORTED;

                return this.responseChecksumValidation.Value;
            }
            set { responseChecksumValidation = value; }
        }
    }
}
