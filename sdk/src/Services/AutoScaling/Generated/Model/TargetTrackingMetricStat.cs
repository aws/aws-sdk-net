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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// This structure defines the CloudWatch metric to return, along with the statistic and
    /// unit.
    /// 
    ///  
    /// <para>
    /// For more information about the CloudWatch terminology below, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html">Amazon
    /// CloudWatch concepts</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TargetTrackingMetricStat
    {
        private Metric _metric;
        private int? _period;
        private string _stat;
        private string _unit;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The metric to use.
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
        ///  The period of the metric in seconds. The default value is 60. Accepted values are
        /// 10, 30, and 60. For high resolution metric, set the value to less than 60. For more
        /// information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/policy-creating-high-resolution-metrics.html">Create
        /// a target tracking policy using high-resolution metrics for faster response</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// For a list of valid values, see the table in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html#Statistic">Statistics</a>
        /// in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The most commonly used metric for scaling is <c>Average</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// The unit to use for the returned data points. For a complete list of the units that
        /// CloudWatch supports, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_MetricDatum.html">MetricDatum</a>
        /// data type in the <i>Amazon CloudWatch API Reference</i>.
        /// </para>
        /// </summary>
        public string Unit
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