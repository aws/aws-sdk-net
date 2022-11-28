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
    /// Container for the parameters to the PutLogEvents operation.
    /// Uploads a batch of log events to the specified log stream.
    /// 
    ///  
    /// <para>
    /// You must include the sequence token obtained from the response of the previous call.
    /// An upload in a newly created log stream does not require a sequence token. You can
    /// also get the sequence token in the <code>expectedSequenceToken</code> field from <code>InvalidSequenceTokenException</code>.
    /// If you call <code>PutLogEvents</code> twice within a narrow time period using the
    /// same value for <code>sequenceToken</code>, both calls might be successful or one might
    /// be rejected.
    /// </para>
    ///  
    /// <para>
    /// The batch of events must satisfy the following constraints:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The maximum batch size is 1,048,576 bytes. This size is calculated as the sum of all
    /// event messages in UTF-8, plus 26 bytes for each log event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// None of the log events in the batch can be more than 2 hours in the future.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// None of the log events in the batch can be more than 14 days in the past. Also, none
    /// of the log events can be from earlier than the retention period of the log group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The log events in the batch must be in chronological order by their timestamp. The
    /// timestamp is the time that the event occurred, expressed as the number of milliseconds
    /// after <code>Jan 1, 1970 00:00:00 UTC</code>. (In Amazon Web Services Tools for PowerShell
    /// and the Amazon Web Services SDK for .NET, the timestamp is specified in .NET format:
    /// <code>yyyy-mm-ddThh:mm:ss</code>. For example, <code>2017-09-15T13:45:30</code>.)
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A batch of log events in a single request cannot span more than 24 hours. Otherwise,
    /// the operation fails.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The maximum number of log events in a batch is 10,000.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// There is a quota of five requests per second per log stream. Additional requests are
    /// throttled. This quota can't be changed.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If a call to <code>PutLogEvents</code> returns "UnrecognizedClientException" the most
    /// likely cause is a non-valid Amazon Web Services access key ID or secret key. 
    /// </para>
    /// </summary>
    public partial class PutLogEventsRequest : AmazonCloudWatchLogsRequest
    {
        private List<InputLogEvent> _logEvents = new List<InputLogEvent>();
        private string _logGroupName;
        private string _logStreamName;
        private string _sequenceToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PutLogEventsRequest() { }

        /// <summary>
        /// Instantiates PutLogEventsRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group.</param>
        /// <param name="logStreamName">The name of the log stream.</param>
        /// <param name="logEvents">The log events.</param>
        public PutLogEventsRequest(string logGroupName, string logStreamName, List<InputLogEvent> logEvents)
        {
            _logGroupName = logGroupName;
            _logStreamName = logStreamName;
            _logEvents = logEvents;
        }

        /// <summary>
        /// Gets and sets the property LogEvents. 
        /// <para>
        /// The log events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public List<InputLogEvent> LogEvents
        {
            get { return this._logEvents; }
            set { this._logEvents = value; }
        }

        // Check to see if LogEvents property is set
        internal bool IsSetLogEvents()
        {
            return this._logEvents != null && this._logEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
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
        /// Gets and sets the property SequenceToken. 
        /// <para>
        /// The sequence token obtained from the response of the previous <code>PutLogEvents</code>
        /// call. An upload in a newly created log stream does not require a sequence token. You
        /// can also get the sequence token using <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeLogStreams.html">DescribeLogStreams</a>.
        /// If you call <code>PutLogEvents</code> twice within a narrow time period using the
        /// same value for <code>sequenceToken</code>, both calls might be successful or one might
        /// be rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string SequenceToken
        {
            get { return this._sequenceToken; }
            set { this._sequenceToken = value; }
        }

        // Check to see if SequenceToken property is set
        internal bool IsSetSequenceToken()
        {
            return this._sequenceToken != null;
        }

    }
}