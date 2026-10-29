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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFleetMetric operation. Updates the data
    /// for a fleet metric. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateFleetMetric</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateFleetMetricRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AggregationField. 
        /// <para>
        /// The field to aggregate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string AggregationField { get; set; }

        /// <summary>
        /// Checks to see if the AggregationField property is set.
        /// </summary>
        internal bool IsSetAggregationField() => this.AggregationField != null;

        /// <summary>
        /// Gets and sets the property AggregationType. 
        /// <para>
        /// The type of the aggregation query.
        /// </para>
        /// </summary>
        public AggregationType AggregationType { get; set; }

        /// <summary>
        /// Checks to see if the AggregationType property is set.
        /// </summary>
        internal bool IsSetAggregationType() => this.AggregationType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the fleet metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpectedVersion. 
        /// <para>
        /// The expected version of the fleet metric record in the registry.
        /// </para>
        /// </summary>
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedVersion property is set.
        /// </summary>
        internal bool IsSetExpectedVersion() => this.ExpectedVersion.HasValue;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index to search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the fleet metric to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The time in seconds between fleet metric emissions. Range [60(1 min), 86400(1 day)]
        /// and must be multiple of 60.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 86400)]
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The search query string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property QueryVersion. 
        /// <para>
        /// The version of the query.
        /// </para>
        /// </summary>
        public string QueryVersion { get; set; }

        /// <summary>
        /// Checks to see if the QueryVersion property is set.
        /// </summary>
        internal bool IsSetQueryVersion() => this.QueryVersion != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Used to support unit transformation such as milliseconds to seconds. The unit must
        /// be supported by <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_MetricDatum.html">CW
        /// metric</a>.
        /// </para>
        /// </summary>
        public FleetMetricUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
