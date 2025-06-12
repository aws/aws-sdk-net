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
    /// Container for the parameters to the StartLiveTail operation.
    /// Starts a Live Tail streaming session for one or more log groups. A Live Tail session
    /// returns a stream of log events that have been recently ingested in the log groups.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs_LiveTail.html">Use
    /// Live Tail to view logs in near real time</a>. 
    /// 
    ///  
    /// <para>
    /// The response to this operation is a response stream, over which the server sends live
    /// log events and the client receives them.
    /// </para>
    ///  
    /// <para>
    /// The following objects are sent over the stream:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A single <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_LiveTailSessionStart.html">LiveTailSessionStart</a>
    /// object is sent at the start of the session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Every second, a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_LiveTailSessionUpdate.html">LiveTailSessionUpdate</a>
    /// object is sent. Each of these objects contains an array of the actual log events.
    /// </para>
    ///  
    /// <para>
    /// If no new log events were ingested in the past second, the <c>LiveTailSessionUpdate</c>
    /// object will contain an empty array.
    /// </para>
    ///  
    /// <para>
    /// The array of log events contained in a <c>LiveTailSessionUpdate</c> can include as
    /// many as 500 log events. If the number of log events matching the request exceeds 500
    /// per second, the log events are sampled down to 500 log events to be included in each
    /// <c>LiveTailSessionUpdate</c> object.
    /// </para>
    ///  
    /// <para>
    /// If your client consumes the log events slower than the server produces them, CloudWatch
    /// Logs buffers up to 10 <c>LiveTailSessionUpdate</c> events or 5000 log events, after
    /// which it starts dropping the oldest events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartLiveTailResponseStream.html#CWL-Type-StartLiveTailResponseStream-SessionStreamingException">SessionStreamingException</a>
    /// object is returned if an unknown error occurs on the server side.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartLiveTailResponseStream.html#CWL-Type-StartLiveTailResponseStream-SessionTimeoutException">SessionTimeoutException</a>
    /// object is returned when the session times out, after it has been kept open for three
    /// hours.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The <c>StartLiveTail</c> API routes requests to <c>streaming-logs.<i>Region</i>.amazonaws.com</c>
    /// using SDK host prefix injection. VPC endpoint support is not available for this API.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// You can end a session before it times out by closing the session stream or by closing
    /// the client that is receiving the stream. The session also ends if the established
    /// connection between the client and the server breaks.
    /// </para>
    ///  </important> 
    /// <para>
    /// For examples of using an SDK to start a Live Tail session, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/example_cloudwatch-logs_StartLiveTail_section.html">
    /// Start a Live Tail session using an Amazon Web Services SDK</a>.
    /// </para>
    /// </summary>
    public partial class StartLiveTailRequest : AmazonCloudWatchLogsRequest
    {
        private string _logEventFilterPattern;
        private List<string> _logGroupIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _logStreamNamePrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _logStreamNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property LogEventFilterPattern. 
        /// <para>
        /// An optional pattern to use to filter the results to include only log events that match
        /// the pattern. For example, a filter pattern of <c>error 404</c> causes only log events
        /// that include both <c>error</c> and <c>404</c> to be included in the Live Tail stream.
        /// </para>
        ///  
        /// <para>
        /// Regular expression filter patterns are supported.
        /// </para>
        ///  
        /// <para>
        /// For more information about filter pattern syntax, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">Filter
        /// and Pattern Syntax</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LogEventFilterPattern
        {
            get { return this._logEventFilterPattern; }
            set { this._logEventFilterPattern = value; }
        }

        // Check to see if LogEventFilterPattern property is set
        internal bool IsSetLogEventFilterPattern()
        {
            return this._logEventFilterPattern != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// An array where each item in the array is a log group to include in the Live Tail session.
        /// </para>
        ///  
        /// <para>
        /// Specify each log group by its ARN. 
        /// </para>
        ///  
        /// <para>
        /// If you specify an ARN, the ARN can't end with an asterisk (*).
        /// </para>
        ///  <note> 
        /// <para>
        ///  You can include up to 10 log groups.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> LogGroupIdentifiers
        {
            get { return this._logGroupIdentifiers; }
            set { this._logGroupIdentifiers = value; }
        }

        // Check to see if LogGroupIdentifiers property is set
        internal bool IsSetLogGroupIdentifiers()
        {
            return this._logGroupIdentifiers != null && (this._logGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogStreamNamePrefixes. 
        /// <para>
        /// If you specify this parameter, then only log events in the log streams that have names
        /// that start with the prefixes that you specify here are included in the Live Tail session.
        /// </para>
        ///  
        /// <para>
        /// If you specify this field, you can't also specify the <c>logStreamNames</c> field.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify this parameter only if you specify only one log group in <c>logGroupIdentifiers</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> LogStreamNamePrefixes
        {
            get { return this._logStreamNamePrefixes; }
            set { this._logStreamNamePrefixes = value; }
        }

        // Check to see if LogStreamNamePrefixes property is set
        internal bool IsSetLogStreamNamePrefixes()
        {
            return this._logStreamNamePrefixes != null && (this._logStreamNamePrefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogStreamNames. 
        /// <para>
        /// If you specify this parameter, then only log events in the log streams that you specify
        /// here are included in the Live Tail session.
        /// </para>
        ///  
        /// <para>
        /// If you specify this field, you can't also specify the <c>logStreamNamePrefixes</c>
        /// field.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify this parameter only if you specify only one log group in <c>logGroupIdentifiers</c>.
        /// </para>
        ///  </note>
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

    }
}