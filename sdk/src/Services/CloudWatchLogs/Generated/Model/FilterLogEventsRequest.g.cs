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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the FilterLogEvents operation. Lists log events from
    /// the specified log group. You can list all the log events or filter the results using
    /// one or more of the following: <ul> <li> <para> A filter pattern </para> </li> <li>
    /// <para> A time range </para> </li> <li> <para> The log stream name, or a log stream
    /// name prefix that matches multiple log streams </para> </li> </ul> <para> You must
    /// have the <c>logs:FilterLogEvents</c> permission to perform this operation. </para>
    /// <para> You can specify the log group to search by using either <c>logGroupIdentifier</c>
    /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
    /// include both. </para> <para> <c>FilterLogEvents</c> is a paginated operation. Each
    /// page returned can contain up to 1 MB of log events or up to 10,000 log events. A returned
    /// page might only be partially full, or even empty. For example, if the result of a
    /// query would return 15,000 log events, the first page isn't guaranteed to have 10,000
    /// log events even if they all fit into 1 MB. </para> <para> Partially full or empty
    /// pages don't necessarily mean that pagination is finished. If the results include a
    /// <c>nextToken</c>, there might be more log events available. You can return these additional
    /// log events by providing the nextToken in a subsequent <c>FilterLogEvents</c> operation.
    /// If the results don't include a <c>nextToken</c>, then pagination is finished. </para>
    /// <para> Specifying the <c>limit</c> parameter only guarantees that a single page doesn't
    /// return more log events than the specified limit, but it might return fewer events
    /// than the limit. This is the expected API behavior. </para> <para> The returned log
    /// events are sorted by event timestamp, the timestamp when the event was ingested by
    /// CloudWatch Logs, and the ID of the <c>PutLogEvents</c> request. By default, the events
    /// are returned in ascending timestamp order (oldest first). To return events in descending
    /// timestamp order (newest first), set the <c>startFromHead</c> parameter to <c>false</c>.
    /// </para> <para> If you are using CloudWatch cross-account observability, you can use
    /// this operation in a monitoring account and view data from the linked source accounts.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>. </para> <note> <para> If you are using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html">log
    /// transformation</a>, the <c>FilterLogEvents</c> operation returns only the original
    /// versions of log events, before they were transformed. To view the transformed versions,
    /// you must use a <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AnalyzingLogData.html">CloudWatch
    /// Logs query.</a> </para> </note>
    /// </summary>
    public partial class FilterLogEventsRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range, expressed as the number of milliseconds after <c>Jan 1,
        /// 1970 00:00:00 UTC</c>. Events with a timestamp later than this time are not returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

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
        [AWSProperty(Min = 0, Max = 1024)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// Checks to see if the FilterPattern property is set.
        /// </summary>
        internal bool IsSetFilterPattern() => this.FilterPattern != null;

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
        public bool? Interleaved { get; set; }

        /// <summary>
        /// Checks to see if the Interleaved property is set.
        /// </summary>
        internal bool IsSetInterleaved() => this.Interleaved.HasValue;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of events to return. The default is 10,000 events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

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
        [AWSProperty(Min = 1, Max = 2048)]
        public string LogGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetLogGroupIdentifier() => this.LogGroupIdentifier != null;

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
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

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
        [AWSProperty(Min = 1, Max = 512)]
        public string LogStreamNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the LogStreamNamePrefix property is set.
        /// </summary>
        internal bool IsSetLogStreamNamePrefix() => this.LogStreamNamePrefix != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> LogStreamNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogStreamNames property is set.
        /// </summary>
        internal bool IsSetLogStreamNames() => this.LogStreamNames != null && (this.LogStreamNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of events to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartFromHead. 
        /// <para>
        /// If the value is true, the earliest log events are returned first. If the value is
        /// false, the latest log events are returned first. The default value is true.
        /// </para>
        ///  
        /// <para>
        /// The <c>startFromHead</c> parameter sets the sort direction on the first request. On
        /// subsequent requests, the <c>nextToken</c> determines the sort direction. To continue
        /// paginating in the same direction, provide the returned <c>nextToken</c>. If you provide
        /// both <c>nextToken</c> and <c>startFromHead</c>, the direction of the <c>nextToken</c>
        /// is used.
        /// </para>
        ///  <note> 
        /// <para>
        /// Setting <c>startFromHead</c> to <c>false</c> is supported only when <c>startTime</c>
        /// is on or after <c>Jan 1, 2024 00:00:00 UTC</c>. A request with <c>startFromHead</c>
        /// set to <c>false</c> and a <c>startTime</c> before this date returns an <c>InvalidParameterException</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? StartFromHead { get; set; }

        /// <summary>
        /// Checks to see if the StartFromHead property is set.
        /// </summary>
        internal bool IsSetStartFromHead() => this.StartFromHead.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time range, expressed as the number of milliseconds after <c>Jan
        /// 1, 1970 00:00:00 UTC</c>. Events with a timestamp before this time are not returned.
        /// </para>
        ///  <note> 
        /// <para>
        /// Set <c>startTime</c> explicitly to reduce the chances of empty pages in the response.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

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
        public bool? Unmask { get; set; }

        /// <summary>
        /// Checks to see if the Unmask property is set.
        /// </summary>
        internal bool IsSetUnmask() => this.Unmask.HasValue;
    }
}
