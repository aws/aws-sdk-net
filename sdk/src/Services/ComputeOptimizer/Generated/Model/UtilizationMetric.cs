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
        ///  <c>Cpu</c> - The percentage of allocated EC2 compute units that are currently in
        /// use on the instance. This metric identifies the processing power required to run an
        /// application on the instance.
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
        ///  <c>Memory</c> - The percentage of memory that is currently in use on the instance.
        /// This metric identifies the amount of memory required to run an application on the
        /// instance.
        /// </para>
        ///  
        /// <para>
        /// Units: Percent
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Memory</c> metric is returned only for resources that have the unified CloudWatch
        /// agent installed on them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
        /// Memory Utilization with the CloudWatch Agent</a>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>GPU</c> - The percentage of allocated GPUs that currently run on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GPU_MEMORY</c> - The percentage of total GPU memory that currently runs on the
        /// instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>GPU</c> and <c>GPU_MEMORY</c> metrics are only returned for resources with
        /// the unified CloudWatch Agent installed on them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#nvidia-cw-agent">Enabling
        /// NVIDIA GPU utilization with the CloudWatch Agent</a>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>EBS_READ_OPS_PER_SECOND</c> - The completed read operations from all EBS volumes
        /// attached to the instance in a specified period of time.
        /// </para>
        ///  
        /// <para>
        /// Unit: Count
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EBS_WRITE_OPS_PER_SECOND</c> - The completed write operations to all EBS volumes
        /// attached to the instance in a specified period of time.
        /// </para>
        ///  
        /// <para>
        /// Unit: Count
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EBS_READ_BYTES_PER_SECOND</c> - The bytes read from all EBS volumes attached to
        /// the instance in a specified period of time.
        /// </para>
        ///  
        /// <para>
        /// Unit: Bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EBS_WRITE_BYTES_PER_SECOND</c> - The bytes written to all EBS volumes attached
        /// to the instance in a specified period of time.
        /// </para>
        ///  
        /// <para>
        /// Unit: Bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISK_READ_OPS_PER_SECOND</c> - The completed read operations from all instance
        /// store volumes available to the instance in a specified period of time.
        /// </para>
        ///  
        /// <para>
        /// If there are no instance store volumes, either the value is <c>0</c> or the metric
        /// is not reported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISK_WRITE_OPS_PER_SECOND</c> - The completed write operations from all instance
        /// store volumes available to the instance in a specified period of time.
        /// </para>
        ///  
        /// <para>
        /// If there are no instance store volumes, either the value is <c>0</c> or the metric
        /// is not reported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISK_READ_BYTES_PER_SECOND</c> - The bytes read from all instance store volumes
        /// available to the instance. This metric is used to determine the volume of the data
        /// the application reads from the disk of the instance. This can be used to determine
        /// the speed of the application.
        /// </para>
        ///  
        /// <para>
        /// If there are no instance store volumes, either the value is <c>0</c> or the metric
        /// is not reported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISK_WRITE_BYTES_PER_SECOND</c> - The bytes written to all instance store volumes
        /// available to the instance. This metric is used to determine the volume of the data
        /// the application writes onto the disk of the instance. This can be used to determine
        /// the speed of the application.
        /// </para>
        ///  
        /// <para>
        /// If there are no instance store volumes, either the value is <c>0</c> or the metric
        /// is not reported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NETWORK_IN_BYTES_PER_SECOND</c> - The number of bytes received by the instance
        /// on all network interfaces. This metric identifies the volume of incoming network traffic
        /// to a single instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NETWORK_OUT_BYTES_PER_SECOND</c> - The number of bytes sent out by the instance
        /// on all network interfaces. This metric identifies the volume of outgoing network traffic
        /// from a single instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NETWORK_PACKETS_IN_PER_SECOND</c> - The number of packets received by the instance
        /// on all network interfaces. This metric identifies the volume of incoming traffic in
        /// terms of the number of packets on a single instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NETWORK_PACKETS_OUT_PER_SECOND</c> - The number of packets sent out by the instance
        /// on all network interfaces. This metric identifies the volume of outgoing traffic in
        /// terms of the number of packets on a single instance.
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
        /// The Compute Optimizer API, Command Line Interface (CLI), and SDKs return utilization
        /// metrics using only the <c>Maximum</c> statistic, which is the highest value observed
        /// during the specified period.
        /// </para>
        ///  
        /// <para>
        /// The Compute Optimizer console displays graphs for some utilization metrics using the
        /// <c>Average</c> statistic, which is the value of <c>Sum</c> / <c>SampleCount</c> during
        /// the specified period. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/viewing-recommendations.html">Viewing
        /// resource recommendations</a> in the <i>Compute Optimizer User Guide</i>. You can also
        /// get averaged utilization metric data for your resources using Amazon CloudWatch. For
        /// more information, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/WhatIsCloudWatch.html">Amazon
        /// CloudWatch User Guide</a>.
        /// </para>
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
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}