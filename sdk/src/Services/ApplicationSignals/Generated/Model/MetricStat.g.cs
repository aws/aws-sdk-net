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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This structure defines the metric to be used as the service level indicator, along
    /// with the statistics, period, and unit.
    /// </summary>
    public partial class MetricStat
    {
        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The metric to use as the service level indicator, including the metric name, namespace,
        /// and dimensions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Metric Metric { get; set; }

        /// <summary>
        /// Checks to see if the Metric property is set.
        /// </summary>
        internal bool IsSetMetric() => this.Metric != null;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, to be used for the metric. For metrics with regular resolution,
        /// a period can be as short as one minute (60 seconds) and must be a multiple of 60.
        /// For high-resolution metrics that are collected at intervals of less than one minute,
        /// the period can be 1, 5, 10, 30, 60, or any multiple of 60. High-resolution metrics
        /// are those metrics stored by a <c>PutMetricData</c> call that includes a <c>StorageResolution</c>
        /// of 1 second.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

        /// <summary>
        /// Gets and sets the property Stat. 
        /// <para>
        /// The statistic to use for comparison to the threshold. It can be any CloudWatch statistic
        /// or extended statistic. For more information about statistics, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Statistics-definitions.html">CloudWatch
        /// statistics definitions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Stat { get; set; }

        /// <summary>
        /// Checks to see if the Stat property is set.
        /// </summary>
        internal bool IsSetStat() => this.Stat != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// If you omit <c>Unit</c> then all data that was collected with any unit is returned,
        /// along with the corresponding units that were specified when the data was reported
        /// to CloudWatch. If you specify a unit, the operation returns only data that was collected
        /// with that unit specified. If you specify a unit that does not match the data collected,
        /// the results of the operation are null. CloudWatch does not perform unit conversions.
        /// </para>
        /// </summary>
        public StandardUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
