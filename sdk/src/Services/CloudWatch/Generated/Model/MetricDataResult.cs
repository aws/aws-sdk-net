/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// A <code>GetMetricData</code> call returns an array of <code>MetricDataResult</code>
    /// structures. Each of these structures includes the data points for that metric, along
    /// with the time stamps of those data points and other identifying information.
    /// </summary>
    public partial class MetricDataResult
    {
        private string _id;
        private string _label;
        private List<MessageData> _messages = new List<MessageData>();
        private StatusCode _statusCode;
        private List<DateTime> _timestamps = new List<DateTime>();
        private List<double> _values = new List<double>();

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The short name you specified to represent this metric.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The human-readable label associated with the data.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// A list of messages with additional information about the data returned.
        /// </para>
        /// </summary>
        public List<MessageData> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && this._messages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status of the returned data. <code>Complete</code> indicates that all data points
        /// in the requested time range were returned. <code>PartialData</code> means that an
        /// incomplete set of data points were returned. You can use the <code>NextToken</code>
        /// value that was returned and repeat your request to get more data points. <code>NextToken</code>
        /// is not returned if you are performing a math expression. <code>InternalError</code>
        /// indicates that an error occurred. Retry your request using <code>NextToken</code>,
        /// if present.
        /// </para>
        /// </summary>
        public StatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamps. 
        /// <para>
        /// The time stamps for the data points, formatted in Unix timestamp format. The number
        /// of time stamps always matches the number of values and the value for Timestamps[x]
        /// is Values[x].
        /// </para>
        /// </summary>
        public List<DateTime> Timestamps
        {
            get { return this._timestamps; }
            set { this._timestamps = value; }
        }

        // Check to see if Timestamps property is set
        internal bool IsSetTimestamps()
        {
            return this._timestamps != null && this._timestamps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The data points for the metric corresponding to <code>Timestamps</code>. The number
        /// of values always matches the number of time stamps and the time stamp for Values[x]
        /// is Timestamps[x].
        /// </para>
        /// </summary>
        public List<double> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}