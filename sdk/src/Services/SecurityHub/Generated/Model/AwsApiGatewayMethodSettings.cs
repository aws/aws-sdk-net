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

/*
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Defines settings for a method for the stage.
    /// </summary>
    public partial class AwsApiGatewayMethodSettings
    {
        private bool? _cacheDataEncrypted;
        private int? _cacheTtlInSeconds;
        private bool? _cachingEnabled;
        private bool? _dataTraceEnabled;
        private string _httpMethod;
        private string _loggingLevel;
        private bool? _metricsEnabled;
        private bool? _requireAuthorizationForCacheControl;
        private string _resourcePath;
        private int? _throttlingBurstLimit;
        private double? _throttlingRateLimit;
        private string _unauthorizedCacheControlHeaderStrategy;

        /// <summary>
        /// Gets and sets the property CacheDataEncrypted. 
        /// <para>
        /// Indicates whether the cached responses are encrypted. 
        /// </para>
        /// </summary>
        public bool? CacheDataEncrypted
        {
            get { return this._cacheDataEncrypted; }
            set { this._cacheDataEncrypted = value; }
        }

        // Check to see if CacheDataEncrypted property is set
        internal bool IsSetCacheDataEncrypted()
        {
            return this._cacheDataEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheTtlInSeconds. 
        /// <para>
        /// Specifies the time to live (TTL), in seconds, for cached responses. The higher the
        /// TTL, the longer the response is cached.
        /// </para>
        /// </summary>
        public int? CacheTtlInSeconds
        {
            get { return this._cacheTtlInSeconds; }
            set { this._cacheTtlInSeconds = value; }
        }

        // Check to see if CacheTtlInSeconds property is set
        internal bool IsSetCacheTtlInSeconds()
        {
            return this._cacheTtlInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CachingEnabled. 
        /// <para>
        /// Indicates whether responses are cached and returned for requests. For responses to
        /// be cached, a cache cluster must be enabled on the stage.
        /// </para>
        /// </summary>
        public bool? CachingEnabled
        {
            get { return this._cachingEnabled; }
            set { this._cachingEnabled = value; }
        }

        // Check to see if CachingEnabled property is set
        internal bool IsSetCachingEnabled()
        {
            return this._cachingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataTraceEnabled. 
        /// <para>
        /// Indicates whether data trace logging is enabled for the method. Data trace logging
        /// affects the log entries that are pushed to CloudWatch Logs.
        /// </para>
        /// </summary>
        public bool? DataTraceEnabled
        {
            get { return this._dataTraceEnabled; }
            set { this._dataTraceEnabled = value; }
        }

        // Check to see if DataTraceEnabled property is set
        internal bool IsSetDataTraceEnabled()
        {
            return this._dataTraceEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The HTTP method. You can use an asterisk (*) as a wildcard to apply method settings
        /// to multiple methods.
        /// </para>
        /// </summary>
        public string HttpMethod
        {
            get { return this._httpMethod; }
            set { this._httpMethod = value; }
        }

        // Check to see if HttpMethod property is set
        internal bool IsSetHttpMethod()
        {
            return this._httpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingLevel. 
        /// <para>
        /// The logging level for this method. The logging level affects the log entries that
        /// are pushed to CloudWatch Logs.
        /// </para>
        ///  
        /// <para>
        /// If the logging level is <c>ERROR</c>, then the logs only include error-level entries.
        /// </para>
        ///  
        /// <para>
        /// If the logging level is <c>INFO</c>, then the logs include both <c>ERROR</c> events
        /// and extra informational events.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>OFF</c> | <c>ERROR</c> | <c>INFO</c> 
        /// </para>
        /// </summary>
        public string LoggingLevel
        {
            get { return this._loggingLevel; }
            set { this._loggingLevel = value; }
        }

        // Check to see if LoggingLevel property is set
        internal bool IsSetLoggingLevel()
        {
            return this._loggingLevel != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsEnabled. 
        /// <para>
        /// Indicates whether CloudWatch metrics are enabled for the method. 
        /// </para>
        /// </summary>
        public bool? MetricsEnabled
        {
            get { return this._metricsEnabled; }
            set { this._metricsEnabled = value; }
        }

        // Check to see if MetricsEnabled property is set
        internal bool IsSetMetricsEnabled()
        {
            return this._metricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireAuthorizationForCacheControl. 
        /// <para>
        /// Indicates whether authorization is required for a cache invalidation request.
        /// </para>
        /// </summary>
        public bool? RequireAuthorizationForCacheControl
        {
            get { return this._requireAuthorizationForCacheControl; }
            set { this._requireAuthorizationForCacheControl = value; }
        }

        // Check to see if RequireAuthorizationForCacheControl property is set
        internal bool IsSetRequireAuthorizationForCacheControl()
        {
            return this._requireAuthorizationForCacheControl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourcePath. 
        /// <para>
        /// The resource path for this method. Forward slashes (/) are encoded as ~1 . The initial
        /// slash must include a forward slash.
        /// </para>
        ///  
        /// <para>
        /// For example, the path value <c>/resource/subresource</c> must be encoded as <c>/~1resource~1subresource</c>.
        /// </para>
        ///  
        /// <para>
        /// To specify the root path, use only a slash (/). You can use an asterisk (*) as a wildcard
        /// to apply method settings to multiple methods.
        /// </para>
        /// </summary>
        public string ResourcePath
        {
            get { return this._resourcePath; }
            set { this._resourcePath = value; }
        }

        // Check to see if ResourcePath property is set
        internal bool IsSetResourcePath()
        {
            return this._resourcePath != null;
        }

        /// <summary>
        /// Gets and sets the property ThrottlingBurstLimit. 
        /// <para>
        /// The throttling burst limit for the method.
        /// </para>
        /// </summary>
        public int? ThrottlingBurstLimit
        {
            get { return this._throttlingBurstLimit; }
            set { this._throttlingBurstLimit = value; }
        }

        // Check to see if ThrottlingBurstLimit property is set
        internal bool IsSetThrottlingBurstLimit()
        {
            return this._throttlingBurstLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThrottlingRateLimit. 
        /// <para>
        /// The throttling rate limit for the method.
        /// </para>
        /// </summary>
        public double? ThrottlingRateLimit
        {
            get { return this._throttlingRateLimit; }
            set { this._throttlingRateLimit = value; }
        }

        // Check to see if ThrottlingRateLimit property is set
        internal bool IsSetThrottlingRateLimit()
        {
            return this._throttlingRateLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnauthorizedCacheControlHeaderStrategy. 
        /// <para>
        /// Indicates how to handle unauthorized requests for cache invalidation.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>FAIL_WITH_403</c> | <c>SUCCEED_WITH_RESPONSE_HEADER</c> | <c>SUCCEED_WITHOUT_RESPONSE_HEADER</c>
        /// 
        /// </para>
        /// </summary>
        public string UnauthorizedCacheControlHeaderStrategy
        {
            get { return this._unauthorizedCacheControlHeaderStrategy; }
            set { this._unauthorizedCacheControlHeaderStrategy = value; }
        }

        // Check to see if UnauthorizedCacheControlHeaderStrategy property is set
        internal bool IsSetUnauthorizedCacheControlHeaderStrategy()
        {
            return this._unauthorizedCacheControlHeaderStrategy != null;
        }

    }
}