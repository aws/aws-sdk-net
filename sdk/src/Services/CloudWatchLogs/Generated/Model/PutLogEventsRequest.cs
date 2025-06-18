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
    /// Container for the parameters to the PutLogEvents operation.
    /// Uploads a batch of log events to the specified log stream.
    /// 
    ///  <important> 
    /// <para>
    /// The sequence token is now ignored in <c>PutLogEvents</c> actions. <c>PutLogEvents</c>
    /// actions are always accepted and never return <c>InvalidSequenceTokenException</c>
    /// or <c>DataAlreadyAcceptedException</c> even if the sequence token is not valid. You
    /// can use parallel <c>PutLogEvents</c> actions on the same log stream. 
    /// </para>
    ///  </important> 
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
    /// Events more than 2 hours in the future are rejected while processing remaining valid
    /// events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Events older than 14 days or preceding the log group's retention period are rejected
    /// while processing remaining valid events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The log events in the batch must be in chronological order by their timestamp. The
    /// timestamp is the time that the event occurred, expressed as the number of milliseconds
    /// after <c>Jan 1, 1970 00:00:00 UTC</c>. (In Amazon Web Services Tools for PowerShell
    /// and the Amazon Web Services SDK for .NET, the timestamp is specified in .NET format:
    /// <c>yyyy-mm-ddThh:mm:ss</c>. For example, <c>2017-09-15T13:45:30</c>.) 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  A batch of log events in a single request must be in a chronological order. Otherwise,
    /// the operation fails.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each log event can be no larger than 1 MB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The maximum number of log events in a batch is 10,000.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For valid events (within 14 days in the past to 2 hours in future), the time span
    /// in a single batch cannot exceed 24 hours. Otherwise, the operation fails.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// The quota of five requests per second per log stream has been removed. Instead, <c>PutLogEvents</c>
    /// actions are throttled based on a per-second per-account quota. You can request an
    /// increase to the per-second throttling quota by using the Service Quotas service.
    /// </para>
    ///  </important> 
    /// <para>
    /// If a call to <c>PutLogEvents</c> returns "UnrecognizedClientException" the most likely
    /// cause is a non-valid Amazon Web Services access key ID or secret key. 
    /// </para>
    /// </summary>
    public partial class PutLogEventsRequest : AmazonCloudWatchLogsRequest
    {
        private Entity _entity;
        private List<InputLogEvent> _logEvents = AWSConfigs.InitializeCollections ? new List<InputLogEvent>() : null;
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
        /// Gets and sets the property Entity. 
        /// <para>
        /// The entity associated with the log events.
        /// </para>
        /// </summary>
        public Entity Entity
        {
            get { return this._entity; }
            set { this._entity = value; }
        }

        // Check to see if Entity property is set
        internal bool IsSetEntity()
        {
            return this._entity != null;
        }

        /// <summary>
        /// Gets and sets the property LogEvents. 
        /// <para>
        /// The log events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._logEvents != null && (this._logEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The sequence token obtained from the response of the previous <c>PutLogEvents</c>
        /// call.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <c>sequenceToken</c> parameter is now ignored in <c>PutLogEvents</c> actions.
        /// <c>PutLogEvents</c> actions are now accepted and never return <c>InvalidSequenceTokenException</c>
        /// or <c>DataAlreadyAcceptedException</c> even if the sequence token is not valid.
        /// </para>
        ///  </important>
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