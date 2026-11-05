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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CacheDataEncrypted. 
        /// <para>
        /// Specifies whether the cached responses are encrypted.
        /// </para>
        /// </summary>
        public bool? CacheDataEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the CacheDataEncrypted property is set.
        /// </summary>
        internal bool IsSetCacheDataEncrypted() => this.CacheDataEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property CacheTtlInSeconds. 
        /// <para>
        /// Specifies the time to live (TTL), in seconds, for cached responses. The higher the
        /// TTL, the longer the response will be cached.
        /// </para>
        /// </summary>
        public int? CacheTtlInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the CacheTtlInSeconds property is set.
        /// </summary>
        internal bool IsSetCacheTtlInSeconds() => this.CacheTtlInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property CachingEnabled. 
        /// <para>
        /// Specifies whether responses should be cached and returned for requests. A cache cluster
        /// must be enabled on the stage for responses to be cached.
        /// </para>
        /// </summary>
        public bool? CachingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CachingEnabled property is set.
        /// </summary>
        internal bool IsSetCachingEnabled() => this.CachingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property DataTraceEnabled. 
        /// <para>
        /// Specifies whether data trace logging is enabled for this method, which affects the
        /// log entries pushed to Amazon CloudWatch Logs. This can be useful to troubleshoot APIs,
        /// but can result in logging sensitive data. We recommend that you don't enable this
        /// option for production APIs.
        /// </para>
        /// </summary>
        public bool? DataTraceEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DataTraceEnabled property is set.
        /// </summary>
        internal bool IsSetDataTraceEnabled() => this.DataTraceEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LoggingLevel. 
        /// <para>
        /// Specifies the logging level for this method, which affects the log entries pushed
        /// to Amazon CloudWatch Logs. Valid values are <c>OFF</c>, <c>ERROR</c>, and <c>INFO</c>.
        /// Choose <c>ERROR</c> to write only error-level entries to CloudWatch Logs, or choose
        /// <c>INFO</c> to include all <c>ERROR</c> events as well as extra informational events.
        /// </para>
        /// </summary>
        public string LoggingLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoggingLevel property is set.
        /// </summary>
        internal bool IsSetLoggingLevel() => this.LoggingLevel != null;

        /// <summary>
        /// Gets and sets the property MetricsEnabled. 
        /// <para>
        /// Specifies whether Amazon CloudWatch metrics are enabled for this method.
        /// </para>
        /// </summary>
        public bool? MetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the MetricsEnabled property is set.
        /// </summary>
        internal bool IsSetMetricsEnabled() => this.MetricsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RequireAuthorizationForCacheControl. 
        /// <para>
        /// Specifies whether authorization is required for a cache invalidation request.
        /// </para>
        /// </summary>
        public bool? RequireAuthorizationForCacheControl { get; set; }

        /// <summary>
        /// Checks to see if the RequireAuthorizationForCacheControl property is set.
        /// </summary>
        internal bool IsSetRequireAuthorizationForCacheControl() => this.RequireAuthorizationForCacheControl.HasValue;

        /// <summary>
        /// Gets and sets the property ThrottlingBurstLimit. 
        /// <para>
        /// Specifies the throttling burst limit.
        /// </para>
        /// </summary>
        public int? ThrottlingBurstLimit { get; set; }

        /// <summary>
        /// Checks to see if the ThrottlingBurstLimit property is set.
        /// </summary>
        internal bool IsSetThrottlingBurstLimit() => this.ThrottlingBurstLimit.HasValue;

        /// <summary>
        /// Gets and sets the property ThrottlingRateLimit. 
        /// <para>
        /// Specifies the throttling rate limit.
        /// </para>
        /// </summary>
        public double? ThrottlingRateLimit { get; set; }

        /// <summary>
        /// Checks to see if the ThrottlingRateLimit property is set.
        /// </summary>
        internal bool IsSetThrottlingRateLimit() => this.ThrottlingRateLimit.HasValue;

        /// <summary>
        /// Gets and sets the property UnauthorizedCacheControlHeaderStrategy. 
        /// <para>
        /// Specifies how to handle unauthorized requests for cache invalidation.
        /// </para>
        /// </summary>
        public UnauthorizedCacheControlHeaderStrategy UnauthorizedCacheControlHeaderStrategy { get; set; }

        /// <summary>
        /// Checks to see if the UnauthorizedCacheControlHeaderStrategy property is set.
        /// </summary>
        internal bool IsSetUnauthorizedCacheControlHeaderStrategy() => this.UnauthorizedCacheControlHeaderStrategy != null;
    }
}
