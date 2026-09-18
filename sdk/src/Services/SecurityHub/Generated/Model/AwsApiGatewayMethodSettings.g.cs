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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Defines settings for a method for the stage.
    /// </summary>
    public partial class AwsApiGatewayMethodSettings
    {
        /// <summary>
        /// Gets and sets the property CacheDataEncrypted. 
        /// <para>
        /// Indicates whether the cached responses are encrypted. 
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
        /// TTL, the longer the response is cached.
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
        /// Indicates whether responses are cached and returned for requests. For responses to
        /// be cached, a cache cluster must be enabled on the stage.
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
        /// Indicates whether data trace logging is enabled for the method. Data trace logging
        /// affects the log entries that are pushed to CloudWatch Logs.
        /// </para>
        /// </summary>
        public bool? DataTraceEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DataTraceEnabled property is set.
        /// </summary>
        internal bool IsSetDataTraceEnabled() => this.DataTraceEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The HTTP method. You can use an asterisk (*) as a wildcard to apply method settings
        /// to multiple methods.
        /// </para>
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// Checks to see if the HttpMethod property is set.
        /// </summary>
        internal bool IsSetHttpMethod() => this.HttpMethod != null;

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
        public string LoggingLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoggingLevel property is set.
        /// </summary>
        internal bool IsSetLoggingLevel() => this.LoggingLevel != null;

        /// <summary>
        /// Gets and sets the property MetricsEnabled. 
        /// <para>
        /// Indicates whether CloudWatch metrics are enabled for the method. 
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
        /// Indicates whether authorization is required for a cache invalidation request.
        /// </para>
        /// </summary>
        public bool? RequireAuthorizationForCacheControl { get; set; }

        /// <summary>
        /// Checks to see if the RequireAuthorizationForCacheControl property is set.
        /// </summary>
        internal bool IsSetRequireAuthorizationForCacheControl() => this.RequireAuthorizationForCacheControl.HasValue;

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
        public string ResourcePath { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePath property is set.
        /// </summary>
        internal bool IsSetResourcePath() => this.ResourcePath != null;

        /// <summary>
        /// Gets and sets the property ThrottlingBurstLimit. 
        /// <para>
        /// The throttling burst limit for the method.
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
        /// The throttling rate limit for the method.
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
        /// Indicates how to handle unauthorized requests for cache invalidation.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>FAIL_WITH_403</c> | <c>SUCCEED_WITH_RESPONSE_HEADER</c> | <c>SUCCEED_WITHOUT_RESPONSE_HEADER</c>
        /// 
        /// </para>
        /// </summary>
        public string UnauthorizedCacheControlHeaderStrategy { get; set; }

        /// <summary>
        /// Checks to see if the UnauthorizedCacheControlHeaderStrategy property is set.
        /// </summary>
        internal bool IsSetUnauthorizedCacheControlHeaderStrategy() => this.UnauthorizedCacheControlHeaderStrategy != null;
    }
}
