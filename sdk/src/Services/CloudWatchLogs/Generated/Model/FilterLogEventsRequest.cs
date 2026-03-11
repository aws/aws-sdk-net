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
    /// Container for the parameters to the FilterLogEvents operation.
    /// Lists log events from the specified log group. You can list all the log events or
    /// filter the results using one or more of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// A filter pattern
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A time range
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The log stream name, or a log stream name prefix that matches multiple log streams
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You must have the <c>logs:FilterLogEvents</c> permission to perform this operation.
    /// </para>
    ///  
    /// <para>
    /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
    /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
    /// include both. 
    /// </para>
    ///  
    /// <para>
    ///  <c>FilterLogEvents</c> is a paginated operation. Each page returned can contain up
    /// to 1 MB of log events or up to 10,000 log events. A returned page might only be partially
    /// full, or even empty. For example, if the result of a query would return 15,000 log
    /// events, the first page isn't guaranteed to have 10,000 log events even if they all
    /// fit into 1 MB.
    /// </para>
    ///  
    /// <para>
    /// Partially full or empty pages don't necessarily mean that pagination is finished.
    /// If the results include a <c>nextToken</c>, there might be more log events available.
    /// You can return these additional log events by providing the nextToken in a subsequent
    /// <c>FilterLogEvents</c> operation. If the results don't include a <c>nextToken</c>,
    /// then pagination is finished. 
    /// </para>
    ///  
    /// <para>
    /// Specifying the <c>limit</c> parameter only guarantees that a single page doesn't return
    /// more log events than the specified limit, but it might return fewer events than the
    /// limit. This is the expected API behavior.
    /// </para>
    ///  
    /// <para>
    /// The returned log events are sorted by event timestamp, the timestamp when the event
    /// was ingested by CloudWatch Logs, and the ID of the <c>PutLogEvents</c> request.
    /// </para>
    ///  
    /// <para>
    /// If you are using CloudWatch cross-account observability, you can use this operation
    /// in a monitoring account and view data from the linked source accounts. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you are using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html">log
    /// transformation</a>, the <c>FilterLogEvents</c> operation returns only the original
    /// versions of log events, before they were transformed. To view the transformed versions,
    /// you must use a <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AnalyzingLogData.html">CloudWatch
    /// Logs query.</a> 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class FilterLogEventsRequest : AmazonCloudWatchLogsRequest
    {
        private long? _endTime;
        private string _filterPattern;
        private bool? _interleaved;
        private int? _limit;
        private string _logGroupIdentifier;
        private string _logGroupName;
        private string _logStreamNamePrefix;
        private List<string> _logStreamNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nextToken;
        private long? _startTime;
        private bool? _unmask;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range, expressed as the number of milliseconds after <c>Jan 1,
        /// 1970 00:00:00 UTC</c>. Events with a timestamp later than this time are not returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? EndTime
        {
            get { return this._endTime; }
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
        /// The filter pattern to use. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">Filter
        /// and Pattern Syntax</a>.
        /// </para>
        ///  
        /// <para>
        /// If not provided, all the events are matched.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// If the value is true, the operation attempts to provide responses that contain events
        /// from multiple log streams within the log group, interleaved in a single response.
        /// If the value is false, all the matched log events in the first log stream are searched
        /// first, then those in the next log stream, and so on.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important</b> As of June 17, 2019, this parameter is ignored and the value is
        /// assumed to be true. The response from this operation always interleaves events from
        /// multiple log streams within a log group.
        /// </para>
        /// </summary>
        [Obsolete("Starting on June 17, 2019, this parameter will be ignored and the value will be assumed to be true. The response from this operation will always interleave events from multiple log streams within a log group.")]
        public bool? Interleaved
        {
            get { return this._interleaved; }
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
        /// Specify either the name or ARN of the log group to view log events from. If the log
        /// group is in a source account and you are using a monitoring account, you must use
        /// the log group ARN.
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
        /// The name of the log group to search.
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
        /// Gets and sets the property LogStreamNamePrefix. 
        /// <para>
        /// Filters the results to include only events from log streams that have names starting
        /// with this prefix.
        /// </para>
        ///  
        /// <para>
        /// If you specify a value for both <c>logStreamNamePrefix</c> and <c>logStreamNames</c>,
        /// the action returns an <c>InvalidParameterException</c> error.
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
        /// Gets and sets the property LogStreamNames. 
        /// <para>
        /// Filters the results to only logs from the log streams in this list.
        /// </para>
        ///  
        /// <para>
        /// If you specify a value for both <c>logStreamNames</c> and <c>logStreamNamePrefix</c>,
        /// the action returns an <c>InvalidParameterException</c> error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> LogStreamNames
        {
            get { return this._logStreamNames; }
            set { this._logStreamNames = value; }
        }

        // Check to see if LogStreamNames property is set
        internal bool IsSetLogStreamNames()
        {
            return this._logStreamNames != null && (this._logStreamNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of events to return. (You received this token from a previous
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time range, expressed as the number of milliseconds after <c>Jan
        /// 1, 1970 00:00:00 UTC</c>. Events with a timestamp before this time are not returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? StartTime
        {
            get { return this._startTime; }
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