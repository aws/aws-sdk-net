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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Contains cost efficiency metrics for a specific group over time. The group is defined
    /// by the grouping dimension specified in the request, such as account ID, Amazon Web
    /// Services Region.
    /// </summary>
    public partial class EfficiencyMetricsByGroup
    {
        private string _group;
        private string _message;
        private List<MetricsByTime> _metricsByTime = AWSConfigs.InitializeCollections ? new List<MetricsByTime>() : null;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The value of the grouping dimension for this set of metrics. For example, if grouped
        /// by account ID, this field contains the account ID. If no grouping is specified, this
        /// field is empty.
        /// </para>
        /// </summary>
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An explanation of why efficiency metrics could not be calculated for this group when
        /// the metricsByTime field is null. Common reasons include insufficient or inconclusive
        /// cost and usage data during the specified time period. This field is null or empty
        /// when metrics are successfully calculated.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsByTime. 
        /// <para>
        /// A list of time-series data points containing efficiency metrics for this group. Each
        /// data point includes an efficiency score, estimated savings, spending, and a timestamp
        /// corresponding to the specified granularity. This field is null when efficiency metrics
        /// cannot be calculated for the group, in which case the message field provides an explanation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricsByTime> MetricsByTime
        {
            get { return this._metricsByTime; }
            set { this._metricsByTime = value; }
        }

        // Check to see if MetricsByTime property is set
        internal bool IsSetMetricsByTime()
        {
            return this._metricsByTime != null && (this._metricsByTime.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}