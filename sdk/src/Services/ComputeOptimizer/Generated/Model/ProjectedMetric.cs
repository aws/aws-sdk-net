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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// The <c>Cpu</c>, <c>Memory</c>, <c>GPU</c>, and <c>GPU_MEMORY</c> metrics are the only
    /// projected utilization metrics returned when you run the <a>GetEC2RecommendationProjectedMetrics</a>
    /// action. Additionally, these metrics are only returned for resources with the unified
    /// CloudWatch agent installed on them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
    /// Memory Utilization with the CloudWatch Agent</a> and <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#nvidia-cw-agent">Enabling
    /// NVIDIA GPU utilization with the CloudWatch Agent</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ProjectedMetric
    {
        private MetricName _name;
        private List<DateTime> _timestamps = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;
        private List<double> _values = AWSConfigs.InitializeCollections ? new List<double>() : null;

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
        ///  <c>Cpu</c> - The projected percentage of allocated EC2 compute units that would be
        /// in use on the recommendation option had you used that resource during the analyzed
        /// period. This metric identifies the processing power required to run an application
        /// on the recommendation option.
        /// </para>
        ///  
        /// <para>
        /// Depending on the instance type, tools in your operating system can show a lower percentage
        /// than CloudWatch when the instance is not allocated a full processor core.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Memory</c> - The percentage of memory that would be in use on the recommendation
        /// option had you used that resource during the analyzed period. This metric identifies
        /// the amount of memory required to run an application on the recommendation option.
        /// </para>
        ///  
        /// <para>
        /// Units: Percent
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Memory</c> metric is only returned for resources with the unified CloudWatch
        /// agent installed on them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
        /// Memory Utilization with the CloudWatch Agent</a>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>GPU</c> - The projected percentage of allocated GPUs if you adjust your configurations
        /// to Compute Optimizer's recommendation option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GPU_MEMORY</c> - The projected percentage of total GPU memory if you adjust your
        /// configurations to Compute Optimizer's recommendation option.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>GPU</c> and <c>GPU_MEMORY</c> metrics are only returned for resources with
        /// the unified CloudWatch Agent installed on them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#nvidia-cw-agent">Enabling
        /// NVIDIA GPU utilization with the CloudWatch Agent</a>.
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
        /// The timestamps of the projected utilization metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> Timestamps
        {
            get { return this._timestamps; }
            set { this._timestamps = value; }
        }

        // Check to see if Timestamps property is set
        internal bool IsSetTimestamps()
        {
            return this._timestamps != null && (this._timestamps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the projected utilization metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}