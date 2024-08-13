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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
        private DateTime? _eventEndTime;
        private DateTime? _eventLastReplayedTime;
        private string _eventSourceArn;
        private DateTime? _eventStartTime;
        private DateTime? _replayEndTime;
        private string _replayName;
        private DateTime? _replayStartTime;
        private ReplayState _state;
        private string _stateReason;

        /// <summary>
        /// Gets and sets the property EventEndTime. 
        /// <para>
        /// A time stamp for the time to start replaying events. Any event with a creation time
        /// prior to the <c>EventEndTime</c> specified is replayed.
        /// </para>
        /// </summary>
        public DateTime? EventEndTime
        {
            get { return this._eventEndTime; }
            set { this._eventEndTime = value; }
        }

        // Check to see if EventEndTime property is set
        internal bool IsSetEventEndTime()
        {
            return this._eventEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventLastReplayedTime. 
        /// <para>
        /// A time stamp for the time that the last event was replayed.
        /// </para>
        /// </summary>
        public DateTime? EventLastReplayedTime
        {
            get { return this._eventLastReplayedTime; }
            set { this._eventLastReplayedTime = value; }
        }

        // Check to see if EventLastReplayedTime property is set
        internal bool IsSetEventLastReplayedTime()
        {
            return this._eventLastReplayedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The ARN of the archive to replay event from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string EventSourceArn
        {
            get { return this._eventSourceArn; }
            set { this._eventSourceArn = value; }
        }

        // Check to see if EventSourceArn property is set
        internal bool IsSetEventSourceArn()
        {
            return this._eventSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventStartTime. 
        /// <para>
        /// A time stamp for the time to start replaying events. This is determined by the time
        /// in the event as described in <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutEventsRequestEntry.html#eventbridge-Type-PutEventsRequestEntry-Time">Time</a>.
        /// </para>
        /// </summary>
        public DateTime? EventStartTime
        {
            get { return this._eventStartTime; }
            set { this._eventStartTime = value; }
        }

        // Check to see if EventStartTime property is set
        internal bool IsSetEventStartTime()
        {
            return this._eventStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplayEndTime. 
        /// <para>
        /// A time stamp for the time that the replay completed.
        /// </para>
        /// </summary>
        public DateTime? ReplayEndTime
        {
            get { return this._replayEndTime; }
            set { this._replayEndTime = value; }
        }

        // Check to see if ReplayEndTime property is set
        internal bool IsSetReplayEndTime()
        {
            return this._replayEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplayName. 
        /// <para>
        /// The name of the replay.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ReplayName
        {
            get { return this._replayName; }
            set { this._replayName = value; }
        }

        // Check to see if ReplayName property is set
        internal bool IsSetReplayName()
        {
            return this._replayName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplayStartTime. 
        /// <para>
        /// A time stamp for the time that the replay started.
        /// </para>
        /// </summary>
        public DateTime? ReplayStartTime
        {
            get { return this._replayStartTime; }
            set { this._replayStartTime = value; }
        }

        // Check to see if ReplayStartTime property is set
        internal bool IsSetReplayStartTime()
        {
            return this._replayStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the replay.
        /// </para>
        /// </summary>
        public ReplayState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// A description of why the replay is in the current state.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

    }
}