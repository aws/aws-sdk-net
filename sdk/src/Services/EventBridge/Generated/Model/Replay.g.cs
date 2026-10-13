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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// A <c>Replay</c> object that contains details about a replay.
    /// </summary>
    public partial class Replay
    {
        /// <summary>
        /// Gets and sets the property EventEndTime. 
        /// <para>
        /// A time stamp for the time to start replaying events. Any event with a creation time
        /// prior to the <c>EventEndTime</c> specified is replayed.
        /// </para>
        /// </summary>
        public DateTime? EventEndTime { get; set; }

        /// <summary>
        /// Checks to see if the EventEndTime property is set.
        /// </summary>
        internal bool IsSetEventEndTime() => this.EventEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventLastReplayedTime. 
        /// <para>
        /// A time stamp for the time that the last event was replayed.
        /// </para>
        /// </summary>
        public DateTime? EventLastReplayedTime { get; set; }

        /// <summary>
        /// Checks to see if the EventLastReplayedTime property is set.
        /// </summary>
        internal bool IsSetEventLastReplayedTime() => this.EventLastReplayedTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The ARN of the archive to replay event from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string EventSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceArn property is set.
        /// </summary>
        internal bool IsSetEventSourceArn() => this.EventSourceArn != null;

        /// <summary>
        /// Gets and sets the property EventStartTime. 
        /// <para>
        /// A time stamp for the time to start replaying events. This is determined by the time
        /// in the event as described in <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutEventsRequestEntry.html#eventbridge-Type-PutEventsRequestEntry-Time">Time</a>.
        /// </para>
        /// </summary>
        public DateTime? EventStartTime { get; set; }

        /// <summary>
        /// Checks to see if the EventStartTime property is set.
        /// </summary>
        internal bool IsSetEventStartTime() => this.EventStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReplayEndTime. 
        /// <para>
        /// A time stamp for the time that the replay completed.
        /// </para>
        /// </summary>
        public DateTime? ReplayEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ReplayEndTime property is set.
        /// </summary>
        internal bool IsSetReplayEndTime() => this.ReplayEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReplayName. 
        /// <para>
        /// The name of the replay.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ReplayName { get; set; }

        /// <summary>
        /// Checks to see if the ReplayName property is set.
        /// </summary>
        internal bool IsSetReplayName() => this.ReplayName != null;

        /// <summary>
        /// Gets and sets the property ReplayStartTime. 
        /// <para>
        /// A time stamp for the time that the replay started.
        /// </para>
        /// </summary>
        public DateTime? ReplayStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ReplayStartTime property is set.
        /// </summary>
        internal bool IsSetReplayStartTime() => this.ReplayStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the replay.
        /// </para>
        /// </summary>
        public ReplayState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// A description of why the replay is in the current state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;
    }
}
