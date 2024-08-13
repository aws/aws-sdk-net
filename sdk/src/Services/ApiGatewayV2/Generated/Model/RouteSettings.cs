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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents a collection of route settings.
    /// </summary>
    public partial class RouteSettings
    {
        private bool? _dataTraceEnabled;
        private bool? _detailedMetricsEnabled;
        private LoggingLevel _loggingLevel;
        private int? _throttlingBurstLimit;
        private double? _throttlingRateLimit;

        /// <summary>
        /// Gets and sets the property DataTraceEnabled. 
        /// <para>
        /// Specifies whether (true) or not (false) data trace logging is enabled for this route.
        /// This property affects the log entries pushed to Amazon CloudWatch Logs. Supported
        /// only for WebSocket APIs.
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
        /// Gets and sets the property DetailedMetricsEnabled. 
        /// <para>
        /// Specifies whether detailed metrics are enabled.
        /// </para>
        /// </summary>
        public bool? DetailedMetricsEnabled
        {
            get { return this._detailedMetricsEnabled; }
            set { this._detailedMetricsEnabled = value; }
        }

        // Check to see if DetailedMetricsEnabled property is set
        internal bool IsSetDetailedMetricsEnabled()
        {
            return this._detailedMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoggingLevel. 
        /// <para>
        /// Specifies the logging level for this route: INFO, ERROR, or OFF. This property affects
        /// the log entries pushed to Amazon CloudWatch Logs. Supported only for WebSocket APIs.
        /// </para>
        /// </summary>
        public LoggingLevel LoggingLevel
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

    }
}