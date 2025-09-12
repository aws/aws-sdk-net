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
using Amazon.Runtime;

namespace Amazon.Extensions.NETCore.Setup
{
    /// <summary>
    /// Settings that will be applied to service client config objects when service clients are created.
    /// </summary>
    public class DefaultClientConfig
    {
        // Maintenance Information
        // -----------------------
        // When adding new properties DefaultClientConfig follow the steps:
        // 1: For value types like bool, int and TimeSpan use the nullable version
        // 2: For TimeSpan properties users will configure in configuration source, like appsettings.json, using milliseconds
        // 3: In the following locations the list or properties are alphabetical
        // 4: Update GetAWSOptions in ConfigurationExtensions to copy the value from IConfiguration onto DefaultClientConfig
        // 5: Update CreateConfig in ClientFactory to copy the value from DefaultClientConfig to the actual service specific ClientConfig
        // 6: Update the Schema/ConfigurationSchema.json with the new property for appsettings.json intellisense


        /// <summary>
        /// This flag controls if .NET HTTP infrastructure should follow redirection
        ///  responses (e.g. HTTP 307 - temporary redirect).
        /// </summary>
        public bool? AllowAutoRedirect { get; set; }

        /// <summary>
        /// Gets and sets the AuthenticationRegion property.
        /// Used in AWS4 request signing, this is an optional property; 
        /// change it only if the region cannot be determined from the 
        /// service endpoint.
        /// </summary>
        public string AuthenticationRegion { get; set; }

        /// <summary>
        /// Gets and Sets the BufferSize property.
        /// The BufferSize controls the buffer used to read in from input streams and write 
        /// out to the request.
        /// </summary>
        public int? BufferSize { get; set; }

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
        public string ClientAppId { get; set; }

        /// <summary>
        /// Gets and sets the DisableHostPrefixInjection flag. If true, host prefix injection will be disabled for this client, the default value of this flag is false. 
        /// Host prefix injection prefixes the service endpoint with request members from APIs which use this feature. 
        /// Example: for a hostPrefix of "foo-name." and a endpoint of "service.region.amazonaws.com" the default behavior is to
        /// prefix the endpoint with the hostPrefix resulting in a final endpoint of "foo-name.service.region.amazonaws.com". Setting 
        /// DisableHostPrefixInjection to true will disable hostPrefix injection resulting in a final endpoint of
        /// "service.region.amazonaws.com" regardless of the value of hostPrefix. E.g. You may want to disable host prefix injection for testing against a local mock endpoint.
        /// </summary>
        public bool? DisableHostPrefixInjection { get; set; }

        /// <summary>
        /// Gets and sets the DisableLogging. If true logging for this client will be disabled.
        /// </summary>
        public bool? DisableLogging { get; set; }

        /// <summary>
        /// Controls whether request payloads are automatically compressed for supported operations.
        /// This setting only applies to operations that support compression.
        /// The default value is "false". Set to "true" to disable compression.
        /// </summary>
        public bool? DisableRequestCompression { get; set; }

        /// <summary>
        /// Returns the maximum number of discovered endpoints that can be stored within the cache for the client. The default limit is 1000 cache entries.
        /// </summary>
        public int? EndpointDiscoveryCacheLimit { get; set; }

        /// <summary>
        /// Returns the flag indicating if endpoint discovery should be enabled or disabled for operations that are not required to use endpoint discovery.
        /// </summary>
        public bool? EndpointDiscoveryEnabled { get; set; }

        /// <summary>
        /// Under Adaptive retry mode, this flag determines if the client should wait for
        /// a send token to become available or don't block and fail the request immediately
        /// if a send token is not available.
        /// </summary>
        public bool? FastFailRequests { get; set; }

        /// <summary>
        /// If CacheHttpClient is set to true then HttpClientCacheSize controls the number of HttpClients cached.
        /// <para>
        /// The default value is 1 which is suitable for Windows and for all other platforms that have HttpClient
        /// implementations using System.Net.Http.SocketsHttpHandler (.NET Core 2.1 and higher).
        /// </para>
        /// </summary>
        public int? HttpClientCacheSize { get; set; }

        /// <summary>
        /// If set to true the SDK will ignore the configured endpointUrls in the config file or in the environment variables.
        /// By default it is set to false.
        /// </summary>
        public bool? IgnoreConfiguredEndpointUrls { get; set; }

        /// <summary>
        /// Flag on whether to log metrics for service calls.
        /// </summary>
        public bool? LogMetrics { get; set; }

        /// <summary>
        /// Gets and sets the LogResponse property.
        /// If this property is set to true, the service response is logged.
        /// The size of response being logged is controlled by the AWSConfigs.LoggingConfig.LogResponsesSizeLimit property.
        /// </summary>
        public bool? LogResponse { get; set; }

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
        public int? MaxErrorRetry { get; set; }

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
        public long? ProgressUpdateInterval { get; set; }

        /// <summary>
        /// Minimum size in bytes that a request body should be to trigger compression.
        /// </summary>
        public long? RequestMinCompressionSizeBytes { get; set; }

        /// <summary>
        /// Flag on whether to resign requests on retry or not.
        /// For Amazon S3 and Amazon Glacier this value will always be set to true.
        /// </summary>
        public bool? ResignRetries { get; set; }

        /// <summary>
        /// Returns the flag indicating the current mode in use for request 
        /// retries and influences the value returned from <see cref="MaxErrorRetry"/>.
        /// The default value is <see cref="RequestRetryMode.Standard"/>. This flag can be configured
        /// by using the AWS_RETRY_MODE environment variable, retry_mode in the
        /// shared configuration file, or by setting this value directly.
        /// </summary>
        public RequestRetryMode? RetryMode { get; set; }

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
        public string ServiceURL { get; set; }

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
        public bool? ThrottleRetries { get; set; }

        /// <summary>
        /// The timeout that is set on the HttpClient Timeout for configuring the wait time for requests time out.
        /// </summary>
        public TimeSpan? Timeout { get; set; }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Gets and sets the connection timeout that will be set on the HttpClient used by the service client to make requests.
        /// The connection timeout is used control the wait time for the connection to be established to the service. The default
        /// connection timeout for the HttpClient infinite waiting period.
        /// </summary>
        public TimeSpan? ConnectTimeout { get; set; }

        /// <summary>
        /// This property is used to set the MaxConnectionsPerServer on the matching property on the underlying HttpClient to make service calls.
        /// </summary>
        public int? MaxConnectionsPerServer { get; set; }
#endif

        /// <summary>
        /// When set to true, the service client will use the x-amz-user-agent
        /// header instead of the User-Agent header to report version and
        /// environment information to the AWS service.
        ///
        /// Note: This is especially useful when using a platform like WebAssembly
        /// which doesn't allow to specify the User-Agent header.
        /// </summary>
        public bool? UseAlternateUserAgentHeader { get; set; }

        /// <summary>
        /// Configures the endpoint calculation for a service to go to a dual stack (ipv6 enabled) endpoint
        /// for the configured region.
        /// </summary>
        public bool? UseDualstackEndpoint { get; set; }

        /// <summary>
        /// Configures the endpoint calculation to go to a FIPS (https://aws.amazon.com/compliance/fips/) endpoint
        /// for the configured region.
        /// </summary>
        public bool? UseFIPSEndpoint { get; set; }

        /// <summary>
        /// Gets and sets the UseHttp.
        /// If this property is set to true, the client attempts
        /// to use HTTP protocol, if the target endpoint supports it.
        /// By default, this property is set to false.
        /// </summary>
        /// <remarks>This does not apply if an explicit <see cref="ServiceURL"/> is specified.</remarks>
        public bool? UseHttp { get; set; }

        /// <summary>
        /// Service specific config settings. For example Amazon S3's config property UseAccelerateEndpoint property.
        /// 
        /// Setting these config on the service specific setting requires .NET reflection. If running in a trimmed environment
        /// like Native AOT additional testing is required to ensure the reflection does not attempt to access code 
        /// that has been trimmed.
        /// </summary>
        public IDictionary<string, string> ServiceSpecificSettings { get; } = new Dictionary<string, string>();
    }
}
