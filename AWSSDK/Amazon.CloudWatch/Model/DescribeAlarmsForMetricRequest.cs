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
    /// Container for the parameters to the DescribeAlarmsForMetric operation.
    /// <para> Retrieves all alarms for a single metric. Specify a statistic, period, or unit to filter the set of alarms further. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DescribeAlarmsForMetric"/>
    public class DescribeAlarmsForMetricRequest : AmazonWebServiceRequest
    {
        private string metricName;
        private string namespaceValue;
        private string statistic;
        private List<Dimension> dimensions = new List<Dimension>();
        private int? period;
        private string unit;

        /// <summary>
        /// The name of the metric.
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
        public DescribeAlarmsForMetricRequest WithMetricName(string metricName)
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
        /// The namespace of the metric.
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
        public DescribeAlarmsForMetricRequest WithNamespace(string namespaceValue)
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
        /// The statistic for the metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>SampleCount, Average, Sum, Minimum, Maximum</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Statistic
        {
            get { return this.statistic; }
            set { this.statistic = value; }
        }

        /// <summary>
        /// Sets the Statistic property
        /// </summary>
        /// <param name="statistic">The value to set for the Statistic property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAlarmsForMetricRequest WithStatistic(string statistic)
        {
            this.statistic = statistic;
            return this;
        }
            

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this.statistic != null;       
        }

        /// <summary>
        /// The list of dimensions associated with the metric.
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
        public DescribeAlarmsForMetricRequest WithDimensions(params Dimension[] dimensions)
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
        public DescribeAlarmsForMetricRequest WithDimensions(IEnumerable<Dimension> dimensions)
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
        /// The period in seconds over which the statistic is applied.
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
        public DescribeAlarmsForMetricRequest WithPeriod(int period)
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
        public DescribeAlarmsForMetricRequest WithUnit(string unit)
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
    
