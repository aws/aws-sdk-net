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
    /// Container for the parameters to the PutLogEvents operation.
    /// Uploads a batch of log events to the specified log stream.
    /// 
    ///  
    /// <para>
    /// Every PutLogEvents request must include the <code>sequenceToken</code> obtained from
    /// the response of the previous request. An upload in a newly created log stream does
    /// not require a <code>sequenceToken</code>. You can also get the <code>sequenceToken</code>
    /// using <a>DescribeLogStreams</a>.
    /// </para>
    ///  
    /// <para>
    /// The batch of events must satisfy the following constraints:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The maximum batch size is 1,048,576 bytes, and this size is calculated as the sum
    /// of all event messages in UTF-8, plus 26 bytes for each log event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// None of the log events in the batch can be more than 2 hours in the future.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// None of the log events in the batch can be older than 14 days or the retention period
    /// of the log group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The log events in the batch must be in chronological ordered by their <code>timestamp</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The maximum number of log events in a batch is 10,000.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A batch of log events in a single PutLogEvents request cannot span more than 24 hours.
    /// Otherwise, the PutLogEvents operation will fail.
    /// </para>
    ///  </li> </ul>
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
        /// <param name="logGroupName">The name of the log group to put log events to.</param>
        /// <param name="logStreamName">The name of the log stream to put log events to.</param>
        /// <param name="logEvents">Sets the PutLogEventsRequest LogEvents property</param>
        public PutLogEventsRequest(string logGroupName, string logStreamName, List<InputLogEvent> logEvents)
        {
            _logGroupName = logGroupName;
            _logStreamName = logStreamName;
            _logEvents = logEvents;
        }

        /// <summary>
        /// Gets and sets the property LogEvents.
        /// </summary>
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
        /// The name of the log group to put log events to.
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
        /// The name of the log stream to put log events to.
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
        /// Gets and sets the property SequenceToken. 
        /// <para>
        /// A string token that must be obtained from the response of the previous <code>PutLogEvents</code>
        /// request.
        /// </para>
        /// </summary>
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