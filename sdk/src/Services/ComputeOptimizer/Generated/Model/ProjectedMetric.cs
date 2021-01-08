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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes a projected utilization metric of a recommendation option, such as an Amazon
    /// EC2 instance. This represents the projected utilization of a recommendation option
    /// had you used that resource during the analyzed period.
    /// 
    ///  
    /// <para>
    /// Compare the utilization metric data of your resource against its projected utilization
    /// metric data to determine the performance difference between your current resource
    /// and the recommended option.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>Cpu</code> and <code>Memory</code> metrics are the only projected utilization
    /// metrics returned when you run the <code>GetEC2RecommendationProjectedMetrics</code>
    /// action. Additionally, the <code>Memory</code> metric is returned only for resources
    /// that have the unified CloudWatch agent installed on them. For more information, see
    /// <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
    /// Memory Utilization with the CloudWatch Agent</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ProjectedMetric
    {
        private MetricName _name;
        private List<DateTime> _timestamps = new List<DateTime>();
        private List<double> _values = new List<double>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the projected utilization metric.
        /// </para>
        ///  
        /// <para>
        /// The following projected utilization metrics are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Cpu</code> - The projected percentage of allocated EC2 compute units that would
        /// be in use on the recommendation option had you used that resource during the analyzed
        /// period. This metric identifies the processing power required to run an application
        /// on the recommendation option.
        /// </para>
        ///  
        /// <para>
        /// Depending on the instance type, tools in your operating system can show a lower percentage
        /// than CloudWatch when the instance is not allocated a full processor core.
        /// </para>
        ///  
        /// <para>
        /// Units: Percent
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Memory</code> - The percentage of memory that would be in use on the recommendation
        /// option had you used that resource during the analyzed period. This metric identifies
        /// the amount of memory required to run an application on the recommendation option.
        /// </para>
        ///  
        /// <para>
        /// Units: Percent
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Memory</code> metric is returned only for resources that have the unified
        /// CloudWatch agent installed on them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
        /// Memory Utilization with the CloudWatch Agent</a>.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public MetricName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamps. 
        /// <para>
        /// The time stamps of the projected utilization metric.
        /// </para>
        /// </summary>
        public List<DateTime> Timestamps
        {
            get { return this._timestamps; }
            set { this._timestamps = value; }
        }

        // Check to see if Timestamps property is set
        internal bool IsSetTimestamps()
        {
            return this._timestamps != null && this._timestamps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the projected utilization metrics.
        /// </para>
        /// </summary>
        public List<double> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}