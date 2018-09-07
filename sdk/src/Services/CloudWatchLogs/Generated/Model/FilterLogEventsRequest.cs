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
    /// Lists log events from the specified log group. You can list all the log events or
    /// filter the results using a filter pattern, a time range, and the name of the log stream.
    /// 
    ///  
    /// <para>
    /// By default, this operation returns as many log events as can fit in 1 MB (up to 10,000
    /// log events), or all the events found within the time range that you specify. If the
    /// results include a token, then there are more log events available, and you can get
    /// additional results by specifying the token in a subsequent call.
    /// </para>
    /// </summary>
    public partial class FilterLogEventsRequest : AmazonCloudWatchLogsRequest
    {
        private long? _endTime;
        private string _filterPattern;
        private bool? _interleaved;
        private int? _limit;
        private string _logGroupName;
        private string _logStreamNamePrefix;
        private List<string> _logStreamNames = new List<string>();
        private string _nextToken;
        private long? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range, expressed as the number of milliseconds after Jan 1, 1970
        /// 00:00:00 UTC. Events with a time stamp later than this time are not returned.
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
        /// The filter pattern to use. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">Filter
        /// and Pattern Syntax</a>.
        /// </para>
        ///  
        /// <para>
        /// If not provided, all the events are matched.
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
        /// If the value is true, the operation makes a best effort to provide responses that
        /// contain events from multiple log streams within the log group, interleaved in a single
        /// response. If the value is false, all the matched log events in the first log stream
        /// are searched first, then those in the next log stream, and so on. The default is false.
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
        /// The maximum number of events to return. The default is 10,000 events.
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
        /// The name of the log group to search.
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
        /// Gets and sets the property LogStreamNamePrefix. 
        /// <para>
        /// Filters the results to include only events from log streams that have names starting
        /// with this prefix.
        /// </para>
        ///  
        /// <para>
        /// If you specify a value for both <code>logStreamNamePrefix</code> and <code>logStreamNames</code>,
        /// but the value for <code>logStreamNamePrefix</code> does not match any log stream names
        /// specified in <code>logStreamNames</code>, the action returns an <code>InvalidParameterException</code>
        /// error.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LogStreamNames. 
        /// <para>
        /// Filters the results to only logs from the log streams in this list.
        /// </para>
        ///  
        /// <para>
        /// If you specify a value for both <code>logStreamNamePrefix</code> and <code>logStreamNames</code>,
        /// but the value for <code>logStreamNamePrefix</code> does not match any log stream names
        /// specified in <code>logStreamNames</code>, the action returns an <code>InvalidParameterException</code>
        /// error.
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
        /// The token for the next set of events to return. (You received this token from a previous
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time range, expressed as the number of milliseconds after Jan 1,
        /// 1970 00:00:00 UTC. Events with a time stamp before this time are not returned.
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