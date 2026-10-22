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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetInstanceMetricData operation. Returns the data
    /// points for the specified Amazon Lightsail instance metric, given an instance name.
    /// <para> Metrics report the utilization of your resources, and the error counts generated
    /// by them. Monitor and collect metric data regularly to maintain the reliability, availability,
    /// and performance of your resources. </para>
    /// </summary>
    public partial class GetInstanceMetricDataRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the instance for which you want to get metrics data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric for which you want to return information.
        /// </para>
        ///  
        /// <para>
        /// Valid instance metric names are listed below, along with the most useful <c>statistics</c>
        /// to include in your request, and the published <c>unit</c> value.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>BurstCapacityPercentage</c> </b> - The percentage of CPU performance available
        /// for your instance to burst above its baseline. Your instance continuously accrues
        /// and consumes burst capacity. Burst capacity stops accruing when your instance's <c>BurstCapacityPercentage</c>
        /// reaches 100%. For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-viewing-instance-burst-capacity">Viewing
        /// instance burst capacity in Amazon Lightsail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistics are <c>Maximum</c> and <c>Average</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Percent</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>BurstCapacityTime</c> </b> - The available amount of time for your instance
        /// to burst at 100% CPU utilization. Your instance continuously accrues and consumes
        /// burst capacity. Burst capacity time stops accruing when your instance's <c>BurstCapacityPercentage</c>
        /// metric reaches 100%.
        /// </para>
        ///  
        /// <para>
        /// Burst capacity time is consumed at the full rate only when your instance operates
        /// at 100% CPU utilization. For example, if your instance operates at 50% CPU utilization
        /// in the burstable zone for a 5-minute period, then it consumes CPU burst capacity minutes
        /// at a 50% rate in that period. Your instance consumed 2 minutes and 30 seconds of CPU
        /// burst capacity minutes in the 5-minute period. For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-viewing-instance-burst-capacity">Viewing
        /// instance burst capacity in Amazon Lightsail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistics are <c>Maximum</c> and <c>Average</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Seconds</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>CPUUtilization</c> </b> - The percentage of allocated compute units that are
        /// currently in use on the instance. This metric identifies the processing power to run
        /// the applications on the instance. Tools in your operating system can show a lower
        /// percentage than Lightsail when the instance is not allocated a full processor core.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistics are <c>Maximum</c> and <c>Average</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Percent</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkIn</c> </b> - The number of bytes received on all network interfaces
        /// by the instance. This metric identifies the volume of incoming network traffic to
        /// the instance. The number reported is the number of bytes received during the period.
        /// Because this metric is reported in 5-minute intervals, divide the reported number
        /// by 300 to find Bytes/second.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Sum</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Bytes</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkOut</c> </b> - The number of bytes sent out on all network interfaces
        /// by the instance. This metric identifies the volume of outgoing network traffic from
        /// the instance. The number reported is the number of bytes sent during the period. Because
        /// this metric is reported in 5-minute intervals, divide the reported number by 300 to
        /// find Bytes/second.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Sum</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Bytes</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>StatusCheckFailed</c> </b> - Reports whether the instance passed or failed
        /// both the instance status check and the system status check. This metric can be either
        /// 0 (passed) or 1 (failed). This metric data is available in 1-minute (60 seconds) granularity.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Sum</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Count</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>StatusCheckFailed_Instance</c> </b> - Reports whether the instance passed
        /// or failed the instance status check. This metric can be either 0 (passed) or 1 (failed).
        /// This metric data is available in 1-minute (60 seconds) granularity.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Sum</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Count</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>StatusCheckFailed_System</c> </b> - Reports whether the instance passed or
        /// failed the system status check. This metric can be either 0 (passed) or 1 (failed).
        /// This metric data is available in 1-minute (60 seconds) granularity.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Sum</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Count</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>MetadataNoToken</c> </b> - Reports the number of times that the instance metadata
        /// service was successfully accessed without a token. This metric determines if there
        /// are any processes accessing instance metadata by using Instance Metadata Service Version
        /// 1, which doesn't use a token. If all requests use token-backed sessions, such as Instance
        /// Metadata Service Version 2, then the value is 0.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Sum</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Count</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskReadOps</c> </b> - The number of read operations completed on the system
        /// disk of the instance during the period. This metric doesn't include activity on additional
        /// disks that you attach to the instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Sum</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Count</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskWriteOps</c> </b> - The number of write operations completed on the system
        /// disk of the instance during the period. This metric doesn't include activity on additional
        /// disks that you attach to the instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Sum</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Count</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskReadBytes</c> </b> - The number of bytes read from the system disk of
        /// the instance during the period. This metric doesn't include activity on additional
        /// disks that you attach to the instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Sum</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Bytes</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskWriteBytes</c> </b> - The number of bytes written to the system disk of
        /// the instance during the period. This metric doesn't include activity on additional
        /// disks that you attach to the instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Sum</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Bytes</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskTotalReadTime</c> </b> - The total number of seconds spent by all read
        /// operations that completed on the system disk of the instance during the period. This
        /// metric doesn't include activity on additional disks that you attach to the instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Average</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Seconds</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskTotalWriteTime</c> </b> - The total number of seconds spent by all write
        /// operations that completed on the system disk of the instance during the period. This
        /// metric doesn't include activity on additional disks that you attach to the instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Average</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Seconds</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskQueueLength</c> </b> - The number of read and write requests that are
        /// waiting to access the system disk of the instance. This metric doesn't include activity
        /// on additional disks that you attach to the instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>Statistics</c>: The most useful statistic is <c>Average</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Unit</c>: The published unit is <c>Count</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about system disk performance metrics, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-viewing-instance-disk-performance-metrics">View
        /// system disk performance metrics for your Lightsail instance</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceMetricName MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the returned data points.
        /// </para>
        ///  
        /// <para>
        /// The <c>StatusCheckFailed</c>, <c>StatusCheckFailed_Instance</c>, and <c>StatusCheckFailed_System</c>
        /// instance metric data is available in 1-minute (60 seconds) granularity. All other
        /// instance metric data is available in 5-minute (300 seconds) granularity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 60, Max = 86400)]
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistic for the metric.
        /// </para>
        ///  
        /// <para>
        /// The following statistics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Minimum</c> - The lowest value observed during the specified period. Use this
        /// value to determine low volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Maximum</c> - The highest value observed during the specified period. Use this
        /// value to determine high volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sum</c> - All values submitted for the matching metric added together. You can
        /// use this statistic to determine the total volume of a metric.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Average</c> - The value of Sum / SampleCount during the specified period. By comparing
        /// this statistic with the Minimum and Maximum values, you can determine the full scope
        /// of a metric and how close the average use is to the Minimum and Maximum values. This
        /// comparison helps you to know when to increase or decrease your resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SampleCount</c> - The count, or number, of data points used for the statistical
        /// calculation.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Statistics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null && (this.Statistics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for the metric data request. Valid units depend on the metric data being
        /// requested. For the valid units to specify with each available metric, see the <c>metricName</c>
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetricUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
