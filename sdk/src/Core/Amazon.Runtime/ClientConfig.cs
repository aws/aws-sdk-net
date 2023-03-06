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
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;

using Amazon.Runtime.Internal.Auth;
using Amazon.Util;
using System.Globalization;
using Amazon.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;

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

        // Represents max timeout.
        public static readonly TimeSpan MaxTimeout = TimeSpan.FromMilliseconds(int.MaxValue);

        private IDefaultConfigurationProvider _defaultConfigurationProvider;

        private DefaultConfigurationMode? defaultConfigurationMode;
        private RegionEndpoint regionEndpoint = null;
        private bool probeForRegionEndpoint = true;
        private bool throttleRetries = true;
        private bool useHttp = false;
        private bool useAlternateUserAgentHeader = AWSConfigs.UseAlternateUserAgentHeader;
        private string serviceURL = null;
        private string authRegion = null;
        private string authServiceName = null;
        private string signatureVersion = "4";
        private SigningAlgorithm signatureMethod = SigningAlgorithm.HmacSHA256;
        private bool readEntireResponse = false;
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
        private TimeSpan? readWriteTimeout = null;
        private bool disableHostPrefixInjection = false;
        private bool? endpointDiscoveryEnabled = null;
        private int endpointDiscoveryCacheLimit = 1000;
        private RequestRetryMode? retryMode = null;
        private int? maxRetries = null;
        private const int MaxRetriesDefault = 2;
        private const int MaxRetriesLegacyDefault = 4;
        private IAWSTokenProvider _awsTokenProvider = new DefaultAWSTokenProviderChain();
#if BCL
        private readonly TcpKeepAlive tcpKeepAlive = new TcpKeepAlive();
#endif

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
        /// Gets and sets of the SignatureVersion property.
        ///
        /// Note: This property exists for backward compatibility but is no longer
        /// used by any service other than S3.
        /// </summary>
        public string SignatureVersion
        {
            get { return this.signatureVersion; }
            set { this.signatureVersion = value; }
        }

        /// <summary>
        /// Gets and sets of the UserAgent property.
        /// </summary>
        public abstract string UserAgent { get; }

        /// <summary>
        /// When set to true, the service client will use the  x-amz-user-agent
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
                    this.RegionEndpoint.OriginalSystemName = value.SystemName;
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
            get { return this.serviceURL; }
            set 
            {
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
        /// Given this client configuration, return a string form ofthe service endpoint url.
        /// </summary>
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
        public virtual string DetermineServiceURL()
        {
            string url;
            if (this.ServiceURL != null)
            {
                url = this.ServiceURL;
            }
            else
            {
                url = GetUrl(this, RegionEndpoint);
            }

            return url;
        }

        /// <summary>
        /// Given this client configuration, return a DNS suffix for service endpoint url.
        /// </summary>
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
        public virtual string DetermineDnsSuffix()
        {
            var endpoint = regionEndpoint.GetEndpointForService(this);
            return endpoint.DnsSuffix;
        }

        internal static string GetUrl(IClientConfig config, RegionEndpoint regionEndpoint)
        {
            var endpoint = 
                regionEndpoint.GetEndpointForService(
                    config.RegionEndpointServiceName, 
                    config.ToGetEndpointForServiceOptions());

            string url = new Uri(string.Format(CultureInfo.InvariantCulture, "{0}{1}", config.UseHttp ? "http://" : "https://", endpoint.Hostname)).AbsoluteUri;
            return url;
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
        /// Returns the flag indicating how many retry HTTP requests an SDK should
        /// make for a single SDK operation invocation before giving up. This flag will 
        /// return 4 when the RetryMode is set to "Legacy" which is the default. For
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
                    //For legacy mode there was no MaxAttempts shared config or 
                    //environment variables so use the legacy default value.
                    if (RetryMode == RequestRetryMode.Legacy)
                    {
                        return MaxRetriesLegacyDefault;
                    }

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
        /// Gets and sets the ReadEntireResponse property.
        /// NOTE: This property does not effect response processing and is deprecated.
        /// To enable response logging, the ClientConfig.LogResponse and AWSConfigs.LoggingConfig
        /// properties can be used.
        /// </summary>
        [Obsolete("This property does not effect response processing and is deprecated." +
            "To enable response logging, the ClientConfig.LogResponse and AWSConfigs.LoggingConfig.LogResponses properties can be used.")]
        public bool ReadEntireResponse
        {
            get { return this.readEntireResponse; }
            set { this.readEntireResponse = value; }
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

        public ClientConfig() : this(new LegacyOnlyDefaultConfigurationProvider())
        {
            this.defaultConfigurationBackingField = _defaultConfigurationProvider.GetDefaultConfiguration(null, null);
            this.defaultConfigurationMode = this.defaultConfigurationBackingField.Name;
        }

        /// <summary>
        /// Specialized <see cref="IDefaultConfigurationProvider"/> that is only meant to provide backwards
        /// compatibility for the obsolete <see cref="ClientConfig"/> constructor.
        /// </summary>
        private class LegacyOnlyDefaultConfigurationProvider : IDefaultConfigurationProvider
        {
            public IDefaultConfiguration GetDefaultConfiguration(RegionEndpoint clientRegion, DefaultConfigurationMode? requestedConfigurationMode = null)
            {
                if (requestedConfigurationMode.HasValue &&
                    requestedConfigurationMode.Value != Runtime.DefaultConfigurationMode.Legacy)
                    throw new AmazonClientException($"This ClientConfig only supports {Runtime.DefaultConfigurationMode.Legacy}");

                return new DefaultConfiguration
                {
                    Name = Runtime.DefaultConfigurationMode.Legacy,
                    RetryMode = RequestRetryMode.Legacy,
                    S3UsEast1RegionalEndpoint = S3UsEast1RegionalEndpointValue.Legacy,
                    StsRegionalEndpoints = StsRegionalEndpointsValue.Legacy
                };
            }
        }
        #endregion

        protected virtual void Initialize()
        {
        }
        
#if BCL35
        /// <summary>
        /// Overrides the default request timeout value.
        /// This field does not impact Begin*/End* calls. A manual timeout must be implemented.
        /// </summary>
#elif BCL45
        /// <summary>
        /// Overrides the default request timeout value.
        /// This field does not impact *Async calls. A manual timeout (for instance, using CancellationToken) must be implemented.
        /// </summary>
#endif
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

#if AWS_ASYNC_API
        /// <summary>
        /// Generates a <see cref="CancellationToken"/> based on the value
        /// for <see cref="DefaultConfiguration.TimeToFirstByteTimeout"/>.
        /// <para />
        /// NOTE: <see cref="Amazon.Runtime.HttpWebRequestMessage.GetResponseAsync"/> uses 
        /// </summary>
        internal CancellationToken BuildDefaultCancellationToken()
        {
            // legacy mode never had a working cancellation token, so keep it to default()
            if (DefaultConfiguration.Name == Runtime.DefaultConfigurationMode.Legacy)
                return default(CancellationToken);

            // TimeToFirstByteTimeout is not a perfect match with HttpWebRequest/HttpClient.Timeout.  However, given
            // that both are configured to only use Timeout until the Response Headers are downloaded, this value
            // provides a reasonable default value.
            var cancelTimeout = DefaultConfiguration.TimeToFirstByteTimeout;

            return cancelTimeout.HasValue
                ? new CancellationTokenSource(cancelTimeout.Value).Token
                : default(CancellationToken);
        }
#endif


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
        /// Returns the current UTC now after clock correction for this endpoint.
        /// </summary>
        [Obsolete("Please use CorrectClockSkew.GetCorrectedUtcNowForEndpoint(string endpoint) instead.", false)]
        public DateTime CorrectedUtcNow
        {
            get
            {
                return CorrectClockSkew.GetCorrectedUtcNowForEndpoint(DetermineServiceURL());
            }
        }

        /// <summary>
        /// The calculated clock skew correction for a specific endpoint, if there is one.
        /// This field will be set if a service call resulted in an exception
        /// and the SDK has determined that there is a difference between local
        /// and server times.
        /// 
        /// If <seealso cref="CorrectForClockSkew"/> is set to true, this
        /// value will still be set to the correction, but it will not be used by the
        /// SDK and clock skew errors will not be retried.
        /// </summary>
        public TimeSpan ClockOffset
        {
            get
            {
                if (AWSConfigs.ManualClockCorrection.HasValue)
                {
                    return AWSConfigs.ManualClockCorrection.Value;
                }
                else
                {
                    string endpoint = DetermineServiceURL();
                    return CorrectClockSkew.GetClockCorrectionForEndpoint(endpoint);
                }
            }
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
        /// The default value is RequestRetryMode.Legacy. This flag can be configured
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
        /// implementations using <see cref="System.Net.Http.SocketsHttpHandler"/> (.NET Core 2.1 and higher).
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

#if NETCOREAPP3_1_OR_GREATER
                return 1;
#else
                return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? 1 : Environment.ProcessorCount;
#endif
            }
            set => _httpClientCacheSize = value;
        }
#endif
        
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
#if NETSTANDARD
        [Obsolete("ReadWriteTimeout is not consumed in asynchronous HTTP requests. Please use a cancellation token to handle stream read/write timeouts.")]
#endif
        public TimeSpan? ReadWriteTimeout
        {
            get { return this.readWriteTimeout; }
            set
            {
                ValidateTimeout(value);
                this.readWriteTimeout = value;
            }
        }

        /// <summary>
        /// Gets and sets of the EndpointProvider property.
        /// This property is used for endpoints resolution.
        /// During service client creation it is set to service's default generated EndpointProvider,
        /// but can be changed to use custom user supplied EndpointProvider.
        /// </summary>
        public IEndpointProvider EndpointProvider { get; set; }
    }
}