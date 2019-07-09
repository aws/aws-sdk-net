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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        /// The period, in seconds, to use when retrieving the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int Period
        {
            get { return this._period.GetValueOrDefault(); }
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
        /// When you are using a <code>Put</code> operation, this defines what unit you want to
        /// use when storing the metric. In a <code>Get</code> operation, this displays the unit
        /// that is used for the metric.
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