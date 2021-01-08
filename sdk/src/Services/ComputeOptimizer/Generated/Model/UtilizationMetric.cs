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
    /// Describes a utilization metric of a resource, such as an Amazon EC2 instance.
    /// 
    ///  
    /// <para>
    /// Compare the utilization metric data of your resource against its projected utilization
    /// metric data to determine the performance difference between your current resource
    /// and the recommended option.
    /// </para>
    /// </summary>
    public partial class UtilizationMetric
    {
        private MetricName _name;
        private MetricStatistic _statistic;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the utilization metric.
        /// </para>
        ///  
        /// <para>
        /// The following utilization metrics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Cpu</code> - The percentage of allocated EC2 compute units that are currently
        /// in use on the instance. This metric identifies the processing power required to run
        /// an application on the instance.
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
        ///  <code>Memory</code> - The percentage of memory that is currently in use on the instance.
        /// This metric identifies the amount of memory required to run an application on the
        /// instance.
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
        ///  </note> </li> <li> 
        /// <para>
        ///  <code>EBS_READ_OPS_PER_SECOND</code> - The completed read operations from all EBS
        /// volumes attached to the instance in a specified period of time.
        /// </para>
        ///  
        /// <para>
        /// Unit: Count
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EBS_WRITE_OPS_PER_SECOND</code> - The completed write operations to all EBS
        /// volumes attached to the instance in a specified period of time.
        /// </para>
        ///  
        /// <para>
        /// Unit: Count
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EBS_READ_BYTES_PER_SECOND</code> - The bytes read from all EBS volumes attached
        /// to the instance in a specified period of time.
        /// </para>
        ///  
        /// <para>
        /// Unit: Bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EBS_WRITE_BYTES_PER_SECOND</code> - The bytes written to all EBS volumes attached
        /// to the instance in a specified period of time.
        /// </para>
        ///  
        /// <para>
        /// Unit: Bytes
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic of the utilization metric.
        /// </para>
        ///  
        /// <para>
        /// The following statistics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Average</code> - This is the value of Sum / SampleCount during the specified
        /// period, or the average value observed during the specified period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Maximum</code> - The highest value observed during the specified period. Use
        /// this value to determine high volumes of activity for your application.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MetricStatistic Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the utilization metric.
        /// </para>
        /// </summary>
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}