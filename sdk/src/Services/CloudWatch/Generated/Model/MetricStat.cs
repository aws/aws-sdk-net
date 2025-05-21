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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This structure defines the metric to be returned, along with the statistics, period,
    /// and units.
    /// </summary>
    public partial class MetricStat
    {
        private Metric _metric;
        private int? _period;
        private string _stat;
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The metric to return, including the metric name, namespace, and dimensions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Metric Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the returned data points. For metrics with regular
        /// resolution, a period can be as short as one minute (60 seconds) and must be a multiple
        /// of 60. For high-resolution metrics that are collected at intervals of less than one
        /// minute, the period can be 1, 5, 10, 20, 30, 60, or any multiple of 60. High-resolution
        /// metrics are those metrics stored by a <c>PutMetricData</c> call that includes a <c>StorageResolution</c>
        /// of 1 second.
        /// </para>
        ///  
        /// <para>
        /// If the <c>StartTime</c> parameter specifies a time stamp that is greater than 3 hours
        /// ago, you must specify the period as follows or no data points in that time range is
        /// returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Start time between 3 hours and 15 days ago - Use a multiple of 60 seconds (1 minute).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start time between 15 and 63 days ago - Use a multiple of 300 seconds (5 minutes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start time greater than 63 days ago - Use a multiple of 3600 seconds (1 hour).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stat. 
        /// <para>
        /// The statistic to return. It can include any CloudWatch statistic or extended statistic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Stat
        {
            get { return this._stat; }
            set { this._stat = value; }
        }

        // Check to see if Stat property is set
        internal bool IsSetStat()
        {
            return this._stat != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// When you are using a <c>Put</c> operation, this defines what unit you want to use
        /// when storing the metric.
        /// </para>
        ///  
        /// <para>
        /// In a <c>Get</c> operation, if you omit <c>Unit</c> then all data that was collected
        /// with any unit is returned, along with the corresponding units that were specified
        /// when the data was reported to CloudWatch. If you specify a unit, the operation returns
        /// only data that was collected with that unit specified. If you specify a unit that
        /// does not match the data collected, the results of the operation are null. CloudWatch
        /// does not perform unit conversions.
        /// </para>
        /// </summary>
        public StandardUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}