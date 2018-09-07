/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        /// Specifies whether the cached responses are encrypted. The PATCH path for this setting
        /// is <code>/{method_setting_key}/caching/dataEncrypted</code>, and the value is a Boolean.
        /// </para>
        /// </summary>
        public bool CacheDataEncrypted
        {
            get { return this._cacheDataEncrypted.GetValueOrDefault(); }
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
        /// TTL, the longer the response will be cached. The PATCH path for this setting is <code>/{method_setting_key}/caching/ttlInSeconds</code>,
        /// and the value is an integer.
        /// </para>
        /// </summary>
        public int CacheTtlInSeconds
        {
            get { return this._cacheTtlInSeconds.GetValueOrDefault(); }
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
        /// must be enabled on the stage for responses to be cached. The PATCH path for this setting
        /// is <code>/{method_setting_key}/caching/enabled</code>, and the value is a Boolean.
        /// </para>
        /// </summary>
        public bool CachingEnabled
        {
            get { return this._cachingEnabled.GetValueOrDefault(); }
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
        /// log entries pushed to Amazon CloudWatch Logs. The PATCH path for this setting is <code>/{method_setting_key}/logging/dataTrace</code>,
        /// and the value is a Boolean.
        /// </para>
        /// </summary>
        public bool DataTraceEnabled
        {
            get { return this._dataTraceEnabled.GetValueOrDefault(); }
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
        /// to Amazon CloudWatch Logs. The PATCH path for this setting is <code>/{method_setting_key}/logging/loglevel</code>,
        /// and the available levels are <code>OFF</code>, <code>ERROR</code>, and <code>INFO</code>.
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
        /// Specifies whether Amazon CloudWatch metrics are enabled for this method. The PATCH
        /// path for this setting is <code>/{method_setting_key}/metrics/enabled</code>, and the
        /// value is a Boolean.
        /// </para>
        /// </summary>
        public bool MetricsEnabled
        {
            get { return this._metricsEnabled.GetValueOrDefault(); }
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
        /// Specifies whether authorization is required for a cache invalidation request. The
        /// PATCH path for this setting is <code>/{method_setting_key}/caching/requireAuthorizationForCacheControl</code>,
        /// and the value is a Boolean.
        /// </para>
        /// </summary>
        public bool RequireAuthorizationForCacheControl
        {
            get { return this._requireAuthorizationForCacheControl.GetValueOrDefault(); }
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
        /// Specifies the throttling burst limit. The PATCH path for this setting is <code>/{method_setting_key}/throttling/burstLimit</code>,
        /// and the value is an integer.
        /// </para>
        /// </summary>
        public int ThrottlingBurstLimit
        {
            get { return this._throttlingBurstLimit.GetValueOrDefault(); }
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
        /// Specifies the throttling rate limit. The PATCH path for this setting is <code>/{method_setting_key}/throttling/rateLimit</code>,
        /// and the value is a double.
        /// </para>
        /// </summary>
        public double ThrottlingRateLimit
        {
            get { return this._throttlingRateLimit.GetValueOrDefault(); }
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
        /// Specifies how to handle unauthorized requests for cache invalidation. The PATCH path
        /// for this setting is <code>/{method_setting_key}/caching/unauthorizedCacheControlHeaderStrategy</code>,
        /// and the available values are <code>FAIL_WITH_403</code>, <code>SUCCEED_WITH_RESPONSE_HEADER</code>,
        /// <code>SUCCEED_WITHOUT_RESPONSE_HEADER</code>.
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