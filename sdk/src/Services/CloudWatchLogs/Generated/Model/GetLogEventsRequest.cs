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
    /// Retrieves log events from the specified log stream. You can provide an optional time
    /// range to filter the results on the event <code class="code">timestamp</code>. 
    /// 
    ///  
    /// <para>
    ///  By default, this operation returns as much log events as can fit in a response size
    /// of 1MB, up to 10,000 log events. The response will always include a <code class="code">nextForwardToken</code>
    /// and a <code class="code">nextBackwardToken</code> in the response body. You can use
    /// any of these tokens in subsequent <code class="code">GetLogEvents</code> requests
    /// to paginate through events in either forward or backward direction. You can also limit
    /// the number of log events returned in the response by specifying the <code class="code">limit</code>
    /// parameter in the request. 
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
        /// <param name="logGroupName">Sets the GetLogEventsRequest LogGroupName property</param>
        /// <param name="logStreamName">Sets the GetLogEventsRequest LogStreamName property</param>
        public GetLogEventsRequest(string logGroupName, string logStreamName)
        {
            _logGroupName = logGroupName;
            _logStreamName = logStreamName;
        }

        /// <summary>
        /// Gets and sets the property EndTime.
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
        ///  The maximum number of log events returned in the response. If you don't specify a
        /// value, the request would return as many log events as can fit in a response size of
        /// 1MB, up to 10,000 log events. 
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
        ///  A string token used for pagination that points to the next page of results. It must
        /// be a value obtained from the <code class="code">nextForwardToken</code> or <code class="code">nextBackwardToken</code>
        /// fields in the response of the previous <code class="code">GetLogEvents</code> request.
        /// 
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
        /// Gets and sets the property StartFromHead. If set to true, the earliest log events
        /// would be returned first. The default is false (the latest log events are returned
        /// first).
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