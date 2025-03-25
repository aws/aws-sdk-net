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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the GetLogEvents operation.
    /// Lists log events from the specified log stream. You can list all of the log events
    /// or filter using a time range.
    /// 
    ///  
    /// <para>
    ///  <c>GetLogEvents</c> is a paginated operation. Each page returned can contain up to
    /// 1 MB of log events or up to 10,000 log events. A returned page might only be partially
    /// full, or even empty. For example, if the result of a query would return 15,000 log
    /// events, the first page isn't guaranteed to have 10,000 log events even if they all
    /// fit into 1 MB.
    /// </para>
    ///  
    /// <para>
    /// Partially full or empty pages don't necessarily mean that pagination is finished.
    /// As long as the <c>nextBackwardToken</c> or <c>nextForwardToken</c> returned is NOT
    /// equal to the <c>nextToken</c> that you passed into the API call, there might be more
    /// log events available. The token that you use depends on the direction you want to
    /// move in along the log stream. The returned tokens are never null.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you set <c>startFromHead</c> to <c>true</c> and you don’t include <c>endTime</c>
    /// in your request, you can end up in a situation where the pagination doesn't terminate.
    /// This can happen when the new log events are being added to the target log streams
    /// faster than they are being read. This situation is a good use case for the CloudWatch
    /// Logs <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs_LiveTail.html">Live
    /// Tail</a> feature.
    /// </para>
    ///  </note> 
    /// <para>
    /// If you are using CloudWatch cross-account observability, you can use this operation
    /// in a monitoring account and view data from the linked source accounts. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>.
    /// </para>
    ///  
    /// <para>
    /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
    /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
    /// include both. 
    /// </para>
    ///  <note> 
    /// <para>
    /// If you are using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html">log
    /// transformation</a>, the <c>GetLogEvents</c> operation returns only the original versions
    /// of log events, before they were transformed. To view the transformed versions, you
    /// must use a <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AnalyzingLogData.html">CloudWatch
    /// Logs query.</a> 
    /// </para>
    ///  </note>
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
        /// <param name="logGroupName">The name of the log group. <note>  You must include either <c>logGroupIdentifier</c> or <c>logGroupName</c>, but not both.  </note></param>
        /// <param name="logStreamName">The name of the log stream.</param>
        public GetLogEventsRequest(string logGroupName, string logStreamName)
        {
            _logGroupName = logGroupName;
            _logStreamName = logStreamName;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range, expressed as the number of milliseconds after <c>Jan 1,
        /// 1970 00:00:00 UTC</c>. Events with a timestamp equal to or later than this time are
        /// not included.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of log events returned. If you don't specify a limit, the default
        /// is as many log events as can fit in a response size of 1 MB (up to 10,000 log events).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? Limit
        {
            get { return this._limit; }
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
        ///  <note> 
        /// <para>
        ///  You must include either <c>logGroupIdentifier</c> or <c>logGroupName</c>, but not
        /// both. 
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
        ///  You must include either <c>logGroupIdentifier</c> or <c>logGroupName</c>, but not
        /// both. 
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
        /// If you are using a previous <c>nextForwardToken</c> value as the <c>nextToken</c>
        /// in this operation, you must specify <c>true</c> for <c>startFromHead</c>.
        /// </para>
        /// </summary>
        public bool? StartFromHead
        {
            get { return this._startFromHead; }
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
        /// The start of the time range, expressed as the number of milliseconds after <c>Jan
        /// 1, 1970 00:00:00 UTC</c>. Events with a timestamp equal to this time or later than
        /// this time are included. Events with a timestamp earlier than this time are not included.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Unmask. 
        /// <para>
        /// Specify <c>true</c> to display the log event fields with all sensitive data unmasked
        /// and visible. The default is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation with this parameter, you must be signed into an account with
        /// the <c>logs:Unmask</c> permission.
        /// </para>
        /// </summary>
        public bool? Unmask
        {
            get { return this._unmask; }
            set { this._unmask = value; }
        }

        // Check to see if Unmask property is set
        internal bool IsSetUnmask()
        {
            return this._unmask.HasValue; 
        }

    }
}