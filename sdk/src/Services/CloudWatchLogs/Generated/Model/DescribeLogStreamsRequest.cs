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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLogStreams operation.
    /// Lists the log streams for the specified log group. You can list all the log streams
    /// or filter the results by prefix. You can also control how the results are ordered.
    /// 
    ///  
    /// <para>
    /// You can specify the log group to search by using either <code>logGroupIdentifier</code>
    /// or <code>logGroupName</code>. You must include one of these two parameters, but you
    /// can't include both. 
    /// </para>
    ///  
    /// <para>
    /// This operation has a limit of five transactions per second, after which transactions
    /// are throttled.
    /// </para>
    ///  
    /// <para>
    /// If you are using CloudWatch cross-account observability, you can use this operation
    /// in a monitoring account and view data from the linked source accounts. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>.
    /// </para>
    /// </summary>
    public partial class DescribeLogStreamsRequest : AmazonCloudWatchLogsRequest
    {
        private bool? _descending;
        private int? _limit;
        private string _logGroupIdentifier;
        private string _logGroupName;
        private string _logStreamNamePrefix;
        private string _nextToken;
        private OrderBy _orderBy;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeLogStreamsRequest() { }

        /// <summary>
        /// Instantiates DescribeLogStreamsRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group. <note>  You must include either <code>logGroupIdentifier</code> or <code>logGroupName</code>, but not both.  </note></param>
        public DescribeLogStreamsRequest(string logGroupName)
        {
            _logGroupName = logGroupName;
        }

        /// <summary>
        /// Gets and sets the property Descending. 
        /// <para>
        /// If the value is true, results are returned in descending order. If the value is to
        /// false, results are returned in ascending order. The default value is false.
        /// </para>
        /// </summary>
        public bool Descending
        {
            get { return this._descending.GetValueOrDefault(); }
            set { this._descending = value; }
        }

        // Check to see if Descending property is set
        internal bool IsSetDescending()
        {
            return this._descending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items returned. If you don't specify a value, the default is
        /// up to 50 items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupIdentifier. 
        /// <para>
        /// Specify either the name or ARN of the log group to view. If the log group is in a
        /// source account and you are using a monitoring account, you must use the log group
        /// ARN.
        /// </para>
        ///  <note> 
        /// <para>
        ///  You must include either <code>logGroupIdentifier</code> or <code>logGroupName</code>,
        /// but not both. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string LogGroupIdentifier
        {
            get { return this._logGroupIdentifier; }
            set { this._logGroupIdentifier = value; }
        }

        // Check to see if LogGroupIdentifier property is set
        internal bool IsSetLogGroupIdentifier()
        {
            return this._logGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        ///  <note> 
        /// <para>
        ///  You must include either <code>logGroupIdentifier</code> or <code>logGroupName</code>,
        /// but not both. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property LogStreamNamePrefix. 
        /// <para>
        /// The prefix to match.
        /// </para>
        ///  
        /// <para>
        /// If <code>orderBy</code> is <code>LastEventTime</code>, you cannot specify this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogStreamNamePrefix
        {
            get { return this._logStreamNamePrefix; }
            set { this._logStreamNamePrefix = value; }
        }

        // Check to see if LogStreamNamePrefix property is set
        internal bool IsSetLogStreamNamePrefix()
        {
            return this._logStreamNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// If the value is <code>LogStreamName</code>, the results are ordered by log stream
        /// name. If the value is <code>LastEventTime</code>, the results are ordered by the event
        /// time. The default value is <code>LogStreamName</code>.
        /// </para>
        ///  
        /// <para>
        /// If you order the results by event time, you cannot specify the <code>logStreamNamePrefix</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <code>lastEventTimestamp</code> represents the time of the most recent log event
        /// in the log stream in CloudWatch Logs. This number is expressed as the number of milliseconds
        /// after <code>Jan 1, 1970 00:00:00 UTC</code>. <code>lastEventTimestamp</code> updates
        /// on an eventual consistency basis. It typically updates in less than an hour from ingestion,
        /// but in rare situations might take longer.
        /// </para>
        /// </summary>
        public OrderBy OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null;
        }

    }
}