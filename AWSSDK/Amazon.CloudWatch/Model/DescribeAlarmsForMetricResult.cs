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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// <para> The output for the DescribeAlarmsForMetric action. </para>
    /// </summary>
    public class DescribeAlarmsForMetricResult  
    {
        
        private List<MetricAlarm> metricAlarms = new List<MetricAlarm>();

        /// <summary>
        /// A list of information for each alarm with the specified metric.
        ///  
        /// </summary>
        public List<MetricAlarm> MetricAlarms
        {
            get { return this.metricAlarms; }
            set { this.metricAlarms = value; }
        }
        /// <summary>
        /// Adds elements to the MetricAlarms collection
        /// </summary>
        /// <param name="metricAlarms">The values to add to the MetricAlarms collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAlarmsForMetricResult WithMetricAlarms(params MetricAlarm[] metricAlarms)
        {
            foreach (MetricAlarm element in metricAlarms)
            {
                this.metricAlarms.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the MetricAlarms collection
        /// </summary>
        /// <param name="metricAlarms">The values to add to the MetricAlarms collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAlarmsForMetricResult WithMetricAlarms(IEnumerable<MetricAlarm> metricAlarms)
        {
            foreach (MetricAlarm element in metricAlarms)
            {
                this.metricAlarms.Add(element);
            }

            return this;
        }

        // Check to see if MetricAlarms property is set
        internal bool IsSetMetricAlarms()
        {
            return this.metricAlarms.Count > 0;       
        }
    }
}
