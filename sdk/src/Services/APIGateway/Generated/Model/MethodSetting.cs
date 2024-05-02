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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Specifies the method setting properties.
    /// </summary>
    public partial class MethodSetting
    {
        private bool? _cacheDataEncrypted;
        private int? _cacheTtlInSeconds;
        private bool? _cachingEnabled;
        private bool? _dataTraceEnabled;
        private string _loggingLevel;
        private bool? _metricsEnabled;
        private bool? _requireAuthorizationForCacheControl;
        private int? _throttlingBurstLimit;
        private double? _throttlingRateLimit;
        private UnauthorizedCacheControlHeaderStrategy _unauthorizedCacheControlHeaderStrategy;

        /// <summary>
        /// Gets and sets the property CacheDataEncrypted. 
        /// <para>
        /// Specifies whether the cached responses are encrypted.
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
        /// TTL, the longer the response will be cached.
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
        /// Specifies whether responses should be cached and returned for requests. A cache cluster
        /// must be enabled on the stage for responses to be cached.
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
        /// Specifies whether data trace logging is enabled for this method, which affects the
        /// log entries pushed to Amazon CloudWatch Logs. This can be useful to troubleshoot APIs,
        /// but can result in logging sensitive data. We recommend that you don't enable this
        /// option for production APIs.
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
        /// Gets and sets the property LoggingLevel. 
        /// <para>
        /// Specifies the logging level for this method, which affects the log entries pushed
        /// to Amazon CloudWatch Logs. Valid values are <c>OFF</c>, <c>ERROR</c>, and <c>INFO</c>.
        /// Choose <c>ERROR</c> to write only error-level entries to CloudWatch Logs, or choose
        /// <c>INFO</c> to include all <c>ERROR</c> events as well as extra informational events.
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
        /// Specifies whether Amazon CloudWatch metrics are enabled for this method.
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
        /// Specifies whether authorization is required for a cache invalidation request.
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
        /// Gets and sets the property ThrottlingBurstLimit. 
        /// <para>
        /// Specifies the throttling burst limit.
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
        /// Specifies the throttling rate limit.
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
        /// Specifies how to handle unauthorized requests for cache invalidation.
        /// </para>
        /// </summary>
        public UnauthorizedCacheControlHeaderStrategy UnauthorizedCacheControlHeaderStrategy
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