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
    /// Container for the parameters to the FilterLogEvents operation.
    /// Retrieves log events, optionally filtered by a filter pattern from the specified log
    /// group. You can provide an optional time range to filter the results on the event <code>timestamp</code>.
    /// You can limit the streams searched to an explicit list of <code>logStreamNames</code>.
    /// 
    ///  
    /// <para>
    /// By default, this operation returns as much matching log events as can fit in a response
    /// size of 1MB, up to 10,000 log events, or all the events found within a time-bounded
    /// scan window. If the response includes a <code>nextToken</code>, then there is more
    /// data to search, and the search can be resumed with a new request providing the nextToken.
    /// The response will contain a list of <code>searchedLogStreams</code> that contains
    /// information about which streams were searched in the request and whether they have
    /// been searched completely or require further pagination. The <code>limit</code> parameter
    /// in the request can be used to specify the maximum number of events to return in a
    /// page.
    /// </para>
    /// </summary>
    public partial class FilterLogEventsRequest : AmazonCloudWatchLogsRequest
    {
        private long? _endTime;
        private string _filterPattern;
        private bool? _interleaved;
        private int? _limit;
        private string _logGroupName;
        private List<string> _logStreamNames = new List<string>();
        private string _nextToken;
        private long? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A point in time expressed as the number of milliseconds since Jan 1, 1970 00:00:00
        /// UTC. If provided, events with a timestamp later than this time are not returned.
        /// </para>
        /// </summary>
        public long EndTime
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
        /// Gets and sets the property FilterPattern. 
        /// <para>
        /// A valid CloudWatch Logs filter pattern to use for filtering the response. If not provided,
        /// all the events are matched.
        /// </para>
        /// </summary>
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }

        /// <summary>
        /// Gets and sets the property Interleaved. 
        /// <para>
        /// If provided, the API will make a best effort to provide responses that contain events
        /// from multiple log streams within the log group interleaved in a single response. If
        /// not provided, all the matched log events in the first log stream will be searched
        /// first, then those in the next log stream, etc.
        /// </para>
        /// </summary>
        public bool Interleaved
        {
            get { return this._interleaved.GetValueOrDefault(); }
            set { this._interleaved = value; }
        }

        // Check to see if Interleaved property is set
        internal bool IsSetInterleaved()
        {
            return this._interleaved.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of events to return in a page of results. Default is 10,000 events.
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
        /// The name of the log group to query.
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
        /// Gets and sets the property LogStreamNames. 
        /// <para>
        /// Optional list of log stream names within the specified log group to search. Defaults
        /// to all the log streams in the log group.
        /// </para>
        /// </summary>
        public List<string> LogStreamNames
        {
            get { return this._logStreamNames; }
            set { this._logStreamNames = value; }
        }

        // Check to see if LogStreamNames property is set
        internal bool IsSetLogStreamNames()
        {
            return this._logStreamNames != null && this._logStreamNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token obtained from a <code>FilterLogEvents</code> response to continue
        /// paginating the FilterLogEvents results. This token is omitted from the response when
        /// there are no other events to display.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A point in time expressed as the number of milliseconds since Jan 1, 1970 00:00:00
        /// UTC. If provided, events with a timestamp prior to this time are not returned.
        /// </para>
        /// </summary>
        public long StartTime
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