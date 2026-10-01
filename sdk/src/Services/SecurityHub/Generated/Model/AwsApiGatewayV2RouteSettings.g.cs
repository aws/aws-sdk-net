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
    /// Contains route settings for a stage.
    /// </summary>
    public partial class AwsApiGatewayV2RouteSettings
    {
        /// <summary>
        /// Gets and sets the property DataTraceEnabled. 
        /// <para>
        /// Indicates whether data trace logging is enabled. Data trace logging affects the log
        /// entries that are pushed to CloudWatch Logs. Supported only for WebSocket APIs.
        /// </para>
        /// </summary>
        public bool? DataTraceEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DataTraceEnabled property is set.
        /// </summary>
        internal bool IsSetDataTraceEnabled() => this.DataTraceEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property DetailedMetricsEnabled. 
        /// <para>
        /// Indicates whether detailed metrics are enabled.
        /// </para>
        /// </summary>
        public bool? DetailedMetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DetailedMetricsEnabled property is set.
        /// </summary>
        internal bool IsSetDetailedMetricsEnabled() => this.DetailedMetricsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LoggingLevel. 
        /// <para>
        /// The logging level. The logging level affects the log entries that are pushed to CloudWatch
        /// Logs. Supported only for WebSocket APIs.
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
        /// Gets and sets the property ThrottlingBurstLimit. 
        /// <para>
        /// The throttling burst limit.
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
        /// The throttling rate limit.
        /// </para>
        /// </summary>
        public double? ThrottlingRateLimit { get; set; }

        /// <summary>
        /// Checks to see if the ThrottlingRateLimit property is set.
        /// </summary>
        internal bool IsSetThrottlingRateLimit() => this.ThrottlingRateLimit.HasValue;
    }
}
