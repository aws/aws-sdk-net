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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
    /// Container for the parameters to the GetContainerServiceMetricData operation.
    /// Returns the data points of a specific metric of your Amazon Lightsail container service.
    /// 
    ///  
    /// <para>
    /// Metrics report the utilization of your resources. Monitor and collect metric data
    /// regularly to maintain the reliability, availability, and performance of your resources.
    /// </para>
    /// </summary>
    public partial class GetContainerServiceMetricDataRequest : AmazonLightsailRequest
    {
        private DateTime? _endTime;
        private ContainerServiceMetricName _metricName;
        private int? _period;
        private string _serviceName;
        private DateTime? _startTime;
        private List<string> _statistics = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric for which you want to return information.
        /// </para>
        ///  
        /// <para>
        /// Valid container service metric names are listed below, along with the most useful
        /// statistics to include in your request, and the published unit value.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CPUUtilization</c> - The average percentage of compute units that are currently
        /// in use across all nodes of the container service. This metric identifies the processing
        /// power required to run containers on each node of the container service.
        /// </para>
        ///  
        /// <para>
        /// Statistics: The most useful statistics are <c>Maximum</c> and <c>Average</c>.
        /// </para>
        ///  
        /// <para>
        /// Unit: The published unit is <c>Percent</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MemoryUtilization</c> - The average percentage of available memory that is currently
        /// in use across all nodes of the container service. This metric identifies the memory
        /// required to run containers on each node of the container service.
        /// </para>
        ///  
        /// <para>
        /// Statistics: The most useful statistics are <c>Maximum</c> and <c>Average</c>.
        /// </para>
        ///  
        /// <para>
        /// Unit: The published unit is <c>Percent</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerServiceMetricName MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the returned data points.
        /// </para>
        ///  
        /// <para>
        /// All container service metric data is available in 5-minute (300 seconds) granularity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=86400)]
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the container service for which to get metric data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

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
        ///  <c>Average</c> - The value of <c>Sum</c> / <c>SampleCount</c> during the specified
        /// period. By comparing this statistic with the <c>Minimum</c> and <c>Maximum</c> values,
        /// you can determine the full scope of a metric and how close the average use is to the
        /// <c>Minimum</c> and <c>Maximum</c> values. This comparison helps you to know when to
        /// increase or decrease your resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SampleCount</c> - The count, or number, of data points used for the statistical
        /// calculation.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && (this._statistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}