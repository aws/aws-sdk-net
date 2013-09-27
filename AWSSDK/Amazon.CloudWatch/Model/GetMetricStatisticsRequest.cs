/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the GetMetricStatistics operation.
    /// <para> Gets statistics for the specified metric. </para> <para><b>NOTE:</b> The maximum number of data points returned from a single
    /// GetMetricStatistics request is 1,440. If a request is made that generates more than 1,440 data points, Amazon CloudWatch returns an error.
    /// In such a case, alter the request by narrowing the specified time range or increasing the specified period. Alternatively, make multiple
    /// requests across adjacent time ranges. </para> <para> Amazon CloudWatch aggregates data points based on the length of the <c>period</c> that
    /// you specify. For example, if you request statistics with a one-minute granularity, Amazon CloudWatch aggregates data points with time stamps
    /// that fall within the same one-minute period. In such a case, the data points queried can greatly outnumber the data points returned. </para>
    /// <para><b>NOTE:</b> The maximum number of data points that can be queried is 50,850; whereas the maximum number of data points returned is
    /// 1,440. </para> <para> The following examples show various statistics allowed by the data point query maximum of 50,850 when you call
    /// <c>GetMetricStatistics</c> on Amazon EC2 instances with detailed (one-minute) monitoring enabled: </para>
    /// <ul>
    /// <li>Statistics for up to 400 instances for a span of one hour</li>
    /// <li>Statistics for up to 35 instances over a span of 24 hours</li>
    /// <li>Statistics for up to 2 instances over a span of 2 weeks</li>
    /// 
    /// </ul>
    /// <para> For information about the namespace, metric names, and dimensions that other Amazon Web Services products use to send metrics to
    /// Cloudwatch, go to Amazon CloudWatch Metrics, Namespaces, and Dimensions Reference in the <i>Amazon CloudWatch Developer Guide</i> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.GetMetricStatistics"/>
    public class GetMetricStatisticsRequest : AmazonWebServiceRequest
    {
        private string namespaceValue;
        private string metricName;
        private List<Dimension> dimensions = new List<Dimension>();
        private DateTime? startTime;
        private DateTime? endTime;
        private int? period;
        private List<string> statistics = new List<string>();
        private string unit;

        /// <summary>
        /// The namespace of the metric, with or without spaces.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[^:].*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this.namespaceValue; }
            set { this.namespaceValue = value; }
        }

        /// <summary>
        /// Sets the Namespace property
        /// </summary>
        /// <param name="namespaceValue">The value to set for the Namespace property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetMetricStatisticsRequest WithNamespace(string namespaceValue)
        {
            this.namespaceValue = namespaceValue;
            return this;
        }
            

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this.namespaceValue != null;       
        }

        /// <summary>
        /// The name of the metric, with or without spaces.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this.metricName; }
            set { this.metricName = value; }
        }

        /// <summary>
        /// Sets the MetricName property
        /// </summary>
        /// <param name="metricName">The value to set for the MetricName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetMetricStatisticsRequest WithMetricName(string metricName)
        {
            this.metricName = metricName;
            return this;
        }
            

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this.metricName != null;       
        }

        /// <summary>
        /// A list of dimensions describing qualities of the metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<Dimension> Dimensions
        {
            get { return this.dimensions; }
            set { this.dimensions = value; }
        }
        /// <summary>
        /// Adds elements to the Dimensions collection
        /// </summary>
        /// <param name="dimensions">The values to add to the Dimensions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetMetricStatisticsRequest WithDimensions(params Dimension[] dimensions)
        {
            foreach (Dimension element in dimensions)
            {
                this.dimensions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Dimensions collection
        /// </summary>
        /// <param name="dimensions">The values to add to the Dimensions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetMetricStatisticsRequest WithDimensions(IEnumerable<Dimension> dimensions)
        {
            foreach (Dimension element in dimensions)
            {
                this.dimensions.Add(element);
            }

            return this;
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this.dimensions.Count > 0;       
        }

        /// <summary>
        /// The time stamp to use for determining the first datapoint to return. The value specified is inclusive; results include datapoints with the
        /// time stamp specified. <note> The specified start time is rounded down to the nearest value. Datapoints are returned for start times up to
        /// two weeks in the past. Specified start times that are more than two weeks in the past will not return datapoints for metrics that are older
        /// than two weeks. </note>
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">The value to set for the StartTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetMetricStatisticsRequest WithStartTime(DateTime startTime)
        {
            this.startTime = startTime;
            return this;
        }
            

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;       
        }

        /// <summary>
        /// The time stamp to use for determining the last datapoint to return. The value specified is exclusive; results will include datapoints up to
        /// the time stamp specified.
        ///  
        /// </summary>
        public DateTime EndTime
        {
            get { return this.endTime ?? default(DateTime); }
            set { this.endTime = value; }
        }

        /// <summary>
        /// Sets the EndTime property
        /// </summary>
        /// <param name="endTime">The value to set for the EndTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetMetricStatisticsRequest WithEndTime(DateTime endTime)
        {
            this.endTime = endTime;
            return this;
        }
            

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this.endTime.HasValue;       
        }

        /// <summary>
        /// The granularity, in seconds, of the returned datapoints. <c>Period</c> must be at least 60 seconds and must be a multiple of 60. The default
        /// value is 60.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>60 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Period
        {
            get { return this.period ?? default(int); }
            set { this.period = value; }
        }

        /// <summary>
        /// Sets the Period property
        /// </summary>
        /// <param name="period">The value to set for the Period property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetMetricStatisticsRequest WithPeriod(int period)
        {
            this.period = period;
            return this;
        }
            

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this.period.HasValue;       
        }

        /// <summary>
        /// The metric statistics to return. For information about specific statistics returned by GetMetricStatistics, go to
        /// <a href="http://docs.amazonwebservices.com/AmazonCloudWatch/latest/DeveloperGuide/index.html?CHAP_TerminologyandKeyConcepts.html#Statistic">Statistics</a>
        /// in the <i>Amazon CloudWatch Developer Guide</i>. Valid Values: <c>Average | Sum | SampleCount | Maximum | Minimum</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 5</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> Statistics
        {
            get { return this.statistics; }
            set { this.statistics = value; }
        }
        /// <summary>
        /// Adds elements to the Statistics collection
        /// </summary>
        /// <param name="statistics">The values to add to the Statistics collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetMetricStatisticsRequest WithStatistics(params string[] statistics)
        {
            foreach (string element in statistics)
            {
                this.statistics.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Statistics collection
        /// </summary>
        /// <param name="statistics">The values to add to the Statistics collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetMetricStatisticsRequest WithStatistics(IEnumerable<string> statistics)
        {
            foreach (string element in statistics)
            {
                this.statistics.Add(element);
            }

            return this;
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this.statistics.Count > 0;       
        }

        /// <summary>
        /// The unit for the metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Seconds, Microseconds, Milliseconds, Bytes, Kilobytes, Megabytes, Gigabytes, Terabytes, Bits, Kilobits, Megabits, Gigabits, Terabits, Percent, Count, Bytes/Second, Kilobytes/Second, Megabytes/Second, Gigabytes/Second, Terabytes/Second, Bits/Second, Kilobits/Second, Megabits/Second, Gigabits/Second, Terabits/Second, Count/Second, None</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }

        /// <summary>
        /// Sets the Unit property
        /// </summary>
        /// <param name="unit">The value to set for the Unit property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetMetricStatisticsRequest WithUnit(string unit)
        {
            this.unit = unit;
            return this;
        }
            

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this.unit != null;       
        }
    }
}
    
