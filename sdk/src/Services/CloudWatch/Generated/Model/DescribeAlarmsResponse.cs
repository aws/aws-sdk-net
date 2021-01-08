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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This is the response object from the DescribeAlarms operation.
    /// </summary>
    public partial class DescribeAlarmsResponse : AmazonWebServiceResponse
    {
        private List<CompositeAlarm> _compositeAlarms = new List<CompositeAlarm>();
        private List<MetricAlarm> _metricAlarms = new List<MetricAlarm>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CompositeAlarms. 
        /// <para>
        /// The information about any composite alarms returned by the operation.
        /// </para>
        /// </summary>
        public List<CompositeAlarm> CompositeAlarms
        {
            get { return this._compositeAlarms; }
            set { this._compositeAlarms = value; }
        }

        // Check to see if CompositeAlarms property is set
        internal bool IsSetCompositeAlarms()
        {
            return this._compositeAlarms != null && this._compositeAlarms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricAlarms. 
        /// <para>
        /// The information about any metric alarms returned by the operation.
        /// </para>
        /// </summary>
        public List<MetricAlarm> MetricAlarms
        {
            get { return this._metricAlarms; }
            set { this._metricAlarms = value; }
        }

        // Check to see if MetricAlarms property is set
        internal bool IsSetMetricAlarms()
        {
            return this._metricAlarms != null && this._metricAlarms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that marks the start of the next batch of returned results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}