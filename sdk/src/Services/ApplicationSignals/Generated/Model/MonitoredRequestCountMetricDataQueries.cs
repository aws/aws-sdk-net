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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This structure defines the metric that is used as the "good request" or "bad request"
    /// value for a request-based SLO. This value observed for the metric defined in <c>TotalRequestCountMetric</c>
    /// is divided by the number found for <c>MonitoredRequestCountMetric</c> to determine
    /// the percentage of successful requests that this SLO tracks.
    /// </summary>
    public partial class MonitoredRequestCountMetricDataQueries
    {
        private List<MetricDataQuery> _badCountMetric = AWSConfigs.InitializeCollections ? new List<MetricDataQuery>() : null;
        private List<MetricDataQuery> _goodCountMetric = AWSConfigs.InitializeCollections ? new List<MetricDataQuery>() : null;

        /// <summary>
        /// Gets and sets the property BadCountMetric. 
        /// <para>
        /// If you want to count "bad requests" to determine the percentage of successful requests
        /// for this request-based SLO, specify the metric to use as "bad requests" in this structure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricDataQuery> BadCountMetric
        {
            get { return this._badCountMetric; }
            set { this._badCountMetric = value; }
        }

        // Check to see if BadCountMetric property is set
        internal bool IsSetBadCountMetric()
        {
            return this._badCountMetric != null && (this._badCountMetric.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GoodCountMetric. 
        /// <para>
        /// If you want to count "good requests" to determine the percentage of successful requests
        /// for this request-based SLO, specify the metric to use as "good requests" in this structure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricDataQuery> GoodCountMetric
        {
            get { return this._goodCountMetric; }
            set { this._goodCountMetric = value; }
        }

        // Check to see if GoodCountMetric property is set
        internal bool IsSetGoodCountMetric()
        {
            return this._goodCountMetric != null && (this._goodCountMetric.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}