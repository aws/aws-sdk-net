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
    /// Container for the parameters to the GetLogEvents operation.
    /// Lists log events from the specified log stream. You can list all of the log events
    /// or filter using a time range.
    /// 
    ///  
    /// <para>
    /// By default, this operation returns as many log events as can fit in a response size
    /// of 1MB (up to 10,000 log events). You can get additional log events by specifying
    /// one of the tokens in a subsequent call. This operation can return empty results while
    /// there are more log events available through the token.
    /// </para>
    ///  
    /// <para>
    /// If you are using CloudWatch cross-account observability, you can use this operation
    /// in a monitoring account and view data from the linked source accounts. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>.
    /// </para>
    /// </summary>
    public partial class GetLogEventsRequest : AmazonCloudWatchLogsRequest
    {
        private DateTime? _endTime;
        private int? _limit;
        private string _logGroupIdentifier;
        private string _logGroupName;
        private string _logStreamName;
        private string _nextToken;
        private bool? _startFromHead;
        private DateTime? _startTime;
        private bool? _unmask;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetLogEventsRequest() { }

        /// <summary>
        /// Instantiates GetLogEventsRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group. <note>  If you specify values for both <code>logGroupName</code> and <code>logGroupIdentifier</code>, the action returns an <code>InvalidParameterException</code> error.  </note></param>
        /// <param name="logStreamName">The name of the log stream.</param>
        public GetLogEventsRequest(string logGroupName, string logStreamName)
        {
            _logGroupName = logGroupName;
            _logStreamName = logStreamName;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range, expressed as the number of milliseconds after <code>Jan
        /// 1, 1970 00:00:00 UTC</code>. Events with a timestamp equal to or later than this time
        /// are not included.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of log events returned. If you don't specify a limit, the default
        /// is as many log events as can fit in a response size of 1 MB (up to 10,000 log events).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
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
        /// Specify either the name or ARN of the log group to view events from. If the log group
        /// is in a source account and you are using a monitoring account, you must use the log
        /// group ARN.
        /// </para>
        ///  
        /// <para>
        ///  If you specify values for both <code>logGroupName</code> and <code>logGroupIdentifier</code>,
        /// the action returns an <code>InvalidParameterException</code> error.
        /// </para>
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
        ///  If you specify values for both <code>logGroupName</code> and <code>logGroupIdentifier</code>,
        /// the action returns an <code>InvalidParameterException</code> error. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the log stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LogStreamName
        {
            get { return this._logStreamName; }
            set { this._logStreamName = value; }
        }

        // Check to see if LogStreamName property is set
        internal bool IsSetLogStreamName()
        {
            return this._logStreamName != null;
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
        /// Gets and sets the property StartFromHead. 
        /// <para>
        /// If the value is true, the earliest log events are returned first. If the value is
        /// false, the latest log events are returned first. The default value is false.
        /// </para>
        ///  
        /// <para>
        /// If you are using a previous <code>nextForwardToken</code> value as the <code>nextToken</code>
        /// in this operation, you must specify <code>true</code> for <code>startFromHead</code>.
        /// </para>
        /// </summary>
        public bool StartFromHead
        {
            get { return this._startFromHead.GetValueOrDefault(); }
            set { this._startFromHead = value; }
        }

        // Check to see if StartFromHead property is set
        internal bool IsSetStartFromHead()
        {
            return this._startFromHead.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time range, expressed as the number of milliseconds after <code>Jan
        /// 1, 1970 00:00:00 UTC</code>. Events with a timestamp equal to this time or later than
        /// this time are included. Events with a timestamp earlier than this time are not included.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unmask. 
        /// <para>
        /// Specify <code>true</code> to display the log event fields with all sensitive data
        /// unmasked and visible. The default is <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation with this parameter, you must be signed into an account with
        /// the <code>logs:Unmask</code> permission.
        /// </para>
        /// </summary>
        public bool Unmask
        {
            get { return this._unmask.GetValueOrDefault(); }
            set { this._unmask = value; }
        }

        // Check to see if Unmask property is set
        internal bool IsSetUnmask()
        {
            return this._unmask.HasValue; 
        }

    }
}