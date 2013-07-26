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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// <para> The output for the DescribeAlarms action. </para>
    /// </summary>
    public partial class DescribeAlarmsResult : AmazonWebServiceResponse
    {
        
        private List<MetricAlarm> metricAlarms = new List<MetricAlarm>();
        private string nextToken;

        /// <summary>
        /// A list of information for the specified alarms.
        ///  
        /// </summary>
        public List<MetricAlarm> MetricAlarms
        {
            get { return this.metricAlarms; }
            set { this.metricAlarms = value; }
        }

        // Check to see if MetricAlarms property is set
        internal bool IsSetMetricAlarms()
        {
            return this.metricAlarms.Count > 0;
        }

        /// <summary>
        /// A string that marks the start of the next batch of returned results.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
