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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the GetLogEvents operation.
    /// Lists log events from the specified log stream. You can list all the log events or
    /// filter using a time range.
    /// 
    ///  
    /// <para>
    /// By default, this operation returns as many log events as can fit in a response size
    /// of 1 MB (up to 10,000 log events). You can get additional log events by specifying
    /// one of the tokens in a subsequent call.
    /// </para>
    /// </summary>
    public partial class GetLogEventsRequest : AmazonCloudWatchLogsRequest
    {
        private DateTime? _endTime;
        private int? _limit;
        private string _logGroupName;
        private string _logStreamName;
        private string _nextToken;
        private bool? _startFromHead;
        private DateTime? _startTime;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetLogEventsRequest() { }

        /// <summary>
        /// Instantiates GetLogEventsRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group.</param>
        /// <param name="logStreamName">The name of the log stream.</param>
        public GetLogEventsRequest(string logGroupName, string logStreamName)
        {
            _logGroupName = logGroupName;
            _logStreamName = logStreamName;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range, expressed as the number of milliseconds after Jan 1, 1970
        /// 00:00:00 UTC. Events with a time stamp later than this time are not included.
        /// </para>
        /// </summary>
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
        /// The maximum number of log events returned. If you don't specify a value, the maximum
        /// is as many log events as can fit in a response size of 1 MB, up to 10,000 log events.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
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
        /// The start of the time range, expressed as the number of milliseconds after Jan 1,
        /// 1970 00:00:00 UTC. Events with a time stamp earlier than this time are not included.
        /// </para>
        /// </summary>
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

    }
}