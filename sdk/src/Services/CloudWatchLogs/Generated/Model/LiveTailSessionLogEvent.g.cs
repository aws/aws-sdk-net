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
    /// This object contains the information for one log event returned in a Live Tail stream.
    /// </summary>
    public partial class LiveTailSessionLogEvent
    {
        /// <summary>
        /// Gets and sets the property IngestionTime. 
        /// <para>
        /// The timestamp specifying when this log event was ingested into the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? IngestionTime { get; set; }

        /// <summary>
        /// Checks to see if the IngestionTime property is set.
        /// </summary>
        internal bool IsSetIngestionTime() => this.IngestionTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifier. 
        /// <para>
        /// The name or ARN of the log group that ingested this log event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LogGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetLogGroupIdentifier() => this.LogGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the log stream that ingested this log event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// Checks to see if the LogStreamName property is set.
        /// </summary>
        internal bool IsSetLogStreamName() => this.LogStreamName != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The log event message text.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp specifying when this log event was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
