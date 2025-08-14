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
using System.Net;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal.Auth;
using Amazon.Util;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Credentials;

#if NETSTANDARD
using System.Net.Http;
#endif

namespace Amazon.Runtime
{
    /// <summary>
    /// This interface is the read only access to the ClientConfig object used when setting up service clients. Once service clients
    /// are initiated the config object should not be changed to avoid issues with using a service client in a multi threaded environment.
    /// </summary>
    public partial interface IClientConfig
    {
        /// <summary>
        /// If set to true the SDK will ignore the configured endpointUrls in the config file or in the environment variables.
        /// By default it is set to false.
        /// </summary>
        bool IgnoreConfiguredEndpointUrls { get; }

        /// <summary>
        /// The serviceId for the service, which is specified in the metadata in the ServiceModel.
        /// The transformed value of the service ID (replace any spaces in the service ID 
        /// with underscores and uppercase all letters) is used to set service-specific endpoint urls.
        /// I.e: AWS_ENDPOINT_URL_ELASTIC_BEANSTALK
        /// For configuration files, replace any spaces with underscores and lowercase all letters
        /// I.e. elastic_beanstalk = 
        ///     endpoint_url = http://localhost:8000
        /// </summary>
        string ServiceId { get; }

        /// <summary>
        /// Specifies the profile to be used. 
        /// When this is set on the config passed to the service client constructor the SDK will try to find the 
        /// credentials associated with the <see cref="Profile.Name"/> property.
        /// 
        /// <para />
        /// If set, this will override <c>AWS_PROFILE</c> and <c>AWSConfigs.ProfileName</c>.
        /// </summary>
        Profile Profile { get; }

        /// <summary> 
        /// <para> 
        /// The AWS credentials used for authenticating calls to AWS for services using AWS signature version 4 (SigV4). 
        /// SigV4 is the most common authentication mechanism used for AWS service calls. 
        /// </para> 
        /// <para> 
        /// Common instances of AWSCredentials are <see cref="Amazon.Runtime.BasicAWSCredentials" /> for static credentials and 
        /// <see cref="Amazon.Runtime.AssumeRoleAWSCredentials" /> for getting credentials by assuming an IAM role. 
        /// </para> 
        /// <para> 
        /// If null, the SDK will determine which credentials to use at request time using information from the source service model.
        /// Credentials passed as a parameter to the service client's constructor take precedence over these default credentials.
        /// </para> 
        /// </summary>
        AWSCredentials DefaultAWSCredentials { get; }

        /// <summary>
        /// Gets the configuration for identity resolvers used by the service client, which manages
        /// the resolvers used to obtain various types of identities.
        /// Use this to retrieve and manage specific identity resolvers based on the required identity type.
        /// <para />
        /// See <see cref="DefaultIdentityResolverConfiguration"/> for additional information.
        /// </summary>
        IIdentityResolverConfiguration IdentityResolverConfiguration { get; }

        /// <summary>
        /// For services using Bearer authentication, this provider can be used to override how the <see cref="BearerTokenSigner"/>
        /// resolves a <see cref="AWSToken"/>.
        /// <para />
        /// See <see cref="DefaultAWSTokenProviderChain"/> for additional information.
        /// <para />
        /// If null, the SDK will use the <see cref="DefaultAWSTokenIdentityResolver"/> to resolve the bearer token.
        /// </summary>
        IAWSTokenProvider AWSTokenProvider { get; }

        /// <summary>
        /// Returns the <see cref="Amazon.Runtime.DefaultConfigurationMode"/> that will be used. If none is specified,
        /// than the correct one is computed by <see cref="IDefaultConfigurationProvider"/>.
        /// </summary>
        DefaultConfigurationMode DefaultConfigurationMode { get; }

        /// <summary>
        /// Gets the RegionEndpoint property. The region constant to use that 
        /// determines the endpoint to use.  If this is not set
        /// then the client will fallback to the value of ServiceURL.
        /// </summary>
        RegionEndpoint RegionEndpoint { get; }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        string RegionEndpointServiceName { get; }

        /// <summary>
        /// Gets and sets of the ServiceURL property.
        /// This is an optional property if you need to set a specific service URL 
        /// instead setting the region with the RegionEndpoint property.
        /// </summary>
        string ServiceURL { get; }

        /// <summary>
        /// Gets and sets of the EndpointProvider property.
        /// This property is used for endpoints resolution.
        /// During service client creation it is set to service's default generated EndpointProvider,
        /// but can be changed to use custom user supplied EndpointProvider.
        /// </summary>
        IEndpointProvider EndpointProvider { get; }

        /// <summary>
        /// Gets the UseHttp property.
        /// If this property is set to true, the client attempts
        /// to use HTTP protocol.
        /// By default, this property is set to false.
        /// </summary>
        bool UseHttp { get; }

        /// <summary>
        /// Gets Service Version
        /// </summary>
        string ServiceVersion { get; }

        /// <summary>
        /// Gets the signatureMethod property.
        /// </summary>
        SigningAlgorithm SignatureMethod { get; }

        /// <summary>
        /// Gets the AuthenticationRegion property.
        /// Used in AWS4 request signing, this is an optional property; 
        /// change it only if the region cannot be determined from the 
        /// service endpoint.
        /// </summary>
        string AuthenticationRegion { get; }

        /// <summary>
        /// Gets the AuthenticationServiceName property.
        /// Used in AWS4 request signing, this is the short-form
        /// name of the service being called.
        /// </summary>
        string AuthenticationServiceName { get; }

        /// <summary>
        /// Gets the UserAgent property.
        /// </summary>
        string UserAgent { get; }

        /// <summary>
        /// Gets the DisableLogging. If true logging for this client will be disabled.
        /// </summary>
        bool DisableLogging { get; }

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
        bool LogMetrics { get; }

        /// <summary>
        /// Gets the LogResponse property.
        /// If this property is set to true, the service response
        /// is read in its entirety and logged.
        /// </summary>
        bool LogResponse { get; }

        /// <summary>
        /// This flag controls if .NET HTTP infrastructure should follow redirection
        ///  responses (e.g. HTTP 307 - temporary redirect).
        /// </summary>
        bool AllowAutoRedirect { get; }

        /// <summary>
        /// Gets the BufferSize property.
        /// The BufferSize controls the buffer used to read in from input streams and write 
        /// out to the request.
        /// </summary>
        int BufferSize { get; }

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
        int MaxErrorRetry { get; }

        /// <summary>
        /// Determines if MaxErrorRetry has been manually set.
        /// </summary>
        bool IsMaxErrorRetrySet { get; }

        /// <summary>
        /// Gets the interval at which progress update events are raised
        /// for upload operations. By default, the progress update events are 
        /// raised at every 100KB of data transferred. 
        /// </summary>
        long ProgressUpdateInterval { get; }

        /// <summary>
        /// Flag on whether to resign requests on retry or not.
        /// </summary>
        bool ResignRetries { get; }

        /// <summary>
        /// Credentials to use with a proxy.
        /// </summary>
        ICredentials ProxyCredentials { get; }

        /// <summary>
        /// Gets the default request timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the Timeout property of the HTTPWebRequest/HttpClient object used
        /// to send requests.
        /// </para>
        /// <para>
        /// Please specify a timeout value only if the operation will not complete within the default intervals
        /// specified for an HttpWebRequest/HttpClient.
        /// </para>
        /// </remarks>
        TimeSpan? Timeout { get; }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Gets the connection timeout that will be set on the HttpClient used by the service client to make requests.
        /// The connection timeout is used control the wait time for the connection to be established to the service.
        /// </summary>
        TimeSpan? ConnectTimeout { get; }
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
        bool UseDualstackEndpoint { get; }

        /// <summary>
        /// Configures the endpoint calculation to go to a FIPS (https://aws.amazon.com/compliance/fips/) endpoint
        /// for the configured region.
        /// </summary>
        bool UseFIPSEndpoint { get; }

        /// <summary>
        /// Controls whether request payloads are automatically compressed for supported operations.
        /// This setting only applies to operations that support compression.
        /// The default value is "false". Set to "true" to disable compression.
        /// </summary>
        bool DisableRequestCompression { get; }

        /// <summary>
        /// Minimum size in bytes that a request body should be to trigger compression.
        /// </summary>
        long RequestMinCompressionSizeBytes { get; }

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
        string ClientAppId { get; }

        /// <summary>
        /// Configures a flag enabling to either opt in or opt out of the retry throttling service.
        /// Note: set value to true to enable retry throttling feature. The Default value for this flag is false.
        /// </summary>
        bool ThrottleRetries { get; }

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="parameters">A Container class for parameters used for endpoint resolution.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters);

        /// <summary>
        /// Performs validation on this config object.
        /// Throws exception if any of the required values are missing/invalid.
        /// </summary>
        /// <exception cref="Amazon.Runtime.AmazonClientException">The timeout specified is null.</exception>
        void Validate();

        /// <summary>
        /// Gets the DisableHostPrefixInjection flag. If true, host prefix injection will be disabled for this client, the default value of this flag is false. 
        /// Host prefix injection prefixes the service endpoint with request members from APIs which use this feature. 
        /// Example: for a hostPrefix of "foo-name." and a endpoint of "service.region.amazonaws.com" the default behavior is to
        /// prefix the endpoint with the hostPrefix resulting in a final endpoint of "foo-name.service.region.amazonaws.com". Setting 
        /// DisableHostPrefixInjection to true will disable hostPrefix injection resulting in a final endpoint of
        /// "service.region.amazonaws.com" regardless of the value of hostPrefix. E.g. You may want to disable host prefix injection for testing against a local mock endpoint.
        /// </summary>
        bool DisableHostPrefixInjection { get; }

        /// <summary>
        /// Returns the flag indicating if endpoint discovery should be enabled or disabled for operations that are not required to use endpoint discovery.
        /// </summary>
        bool EndpointDiscoveryEnabled { get; }

        /// <summary>
        /// Returns the maximum number of discovered endpoints that can be stored within the cache for the client. The default limit is 1000 cache entries.
        /// </summary>
        int EndpointDiscoveryCacheLimit { get; }

        /// <summary>
        /// Returns the flag indicating the current mode in use for request 
        /// retries and influences the value returned from <see cref="MaxErrorRetry"/>.
        /// The default value is RequestRetryMode.Legacy. This flag can be configured
        /// by using the AWS_RETRY_MODE environment variable, retry_mode in the
        /// shared configuration file, or by setting this value directly.
        /// </summary>
        RequestRetryMode RetryMode { get; }
                
        /// <summary>
        /// Under Adaptive retry mode, this flag determines if the client should wait for
        /// a send token to become available or don't block and fail the request immediately
        /// if a send token is not available.
        /// </summary>
        bool FastFailRequests { get;  }

        /// <summary>
        /// When set to true, the service client will use the  x-amz-user-agent
        /// header instead of the User-Agent header to report version and
        /// environment information to the AWS service.
        ///
        /// Note: This is especially useful when using a platform like WebAssembly
        /// which doesn't allow to specify the User-Agent header.
        /// </summary>
        bool UseAlternateUserAgentHeader { get; }
        
        /// <summary>
        /// <para>
        /// This telemetry provider is used to collect and report telemetry data 
        /// (such as traces and metrics) for operations performed by this specific client.
        /// If this property is not explicitly set, it will default to the global 
        /// <see cref="AWSConfigs.TelemetryProvider"/>.
        /// </para>
        /// </summary>
        TelemetryProvider TelemetryProvider { get; }

        /// <summary>
        /// Determines the behavior for calculating checksums for request payloads.
        /// By default it is set to <see cref="RequestChecksumCalculation.WHEN_SUPPORTED"/>.
        /// </summary>
        RequestChecksumCalculation RequestChecksumCalculation { get; }
        
        /// <summary>
        /// Determines the behavior for validating checksums on response payloads.
        /// By default it is set to <see cref="ResponseChecksumValidation.WHEN_SUPPORTED"/>.
        /// </summary>
        ResponseChecksumValidation ResponseChecksumValidation { get; }

        /// <summary>
        /// Controls whether the resolved endpoint will include the account id. This allows for direct routing of traffic
        /// to the cell responsible for a given account, which avoids the additional latency of extra backend hops and reduces
        /// complexity in the routing layer.
        /// </summary>
        public AccountIdEndpointMode AccountIdEndpointMode { get; }

#if BCL
        /// <summary>
        /// Gets the TCP keep-alive values to use for service requests. Enabling TCP keep-alive sends periodic TCP keep-alive probe packets, to prevent disconnection due to 
        /// network inactivity. This is useful when you make API calls that take a long time to respond. In this case, the connection could be dropped by an intermediate 
        /// node (e.g. proxy) as the connection is inactive for a long time. Timeout controls the duration of inactivity before a keep-alive probe packet is sent. 
        /// Interval controls the amount of time to wait before retrying a keep-alive probe packet in the event the server doesn't respond to a keep-alive probe.
        /// </summary>
        TcpKeepAlive TcpKeepAlive { get; }                
#endif

#if NETSTANDARD
        /// <summary>
        /// Get the value to use for <see cref="HttpClientHandler.MaxConnectionsPerServer"/> on requests.
        /// If this property is null, <see cref="HttpClientHandler.MaxConnectionsPerServer"/>
        /// will be left at its default value of <see cref="int.MaxValue"/>.
        /// </summary>
        int? MaxConnectionsPerServer { get; }
        
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
        bool CacheHttpClient { get; }

        /// <summary>
        /// If CacheHttpClient is set to true then HttpClientCacheSize controls the number of HttpClients cached.
        /// </summary>
        int HttpClientCacheSize { get; }
#endif
    }
}