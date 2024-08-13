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
    /// This is the response object from the DescribeReplay operation.
    /// </summary>
    public partial class DescribeReplayResponse : AmazonWebServiceResponse
    {
        private string _description;
        private ReplayDestination _destination;
        private DateTime? _eventEndTime;
        private DateTime? _eventLastReplayedTime;
        private string _eventSourceArn;
        private DateTime? _eventStartTime;
        private string _replayArn;
        private DateTime? _replayEndTime;
        private string _replayName;
        private DateTime? _replayStartTime;
        private ReplayState _state;
        private string _stateReason;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the replay.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// A <c>ReplayDestination</c> object that contains details about the replay.
        /// </para>
        /// </summary>
        public ReplayDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property EventEndTime. 
        /// <para>
        /// The time stamp for the last event that was replayed from the archive.
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
        /// The time that the event was last replayed.
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
        /// The ARN of the archive events were replayed from.
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
        /// The time stamp of the first event that was last replayed from the archive.
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
        /// Gets and sets the property ReplayArn. 
        /// <para>
        /// The ARN of the replay.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ReplayArn
        {
            get { return this._replayArn; }
            set { this._replayArn = value; }
        }

        // Check to see if ReplayArn property is set
        internal bool IsSetReplayArn()
        {
            return this._replayArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplayEndTime. 
        /// <para>
        /// A time stamp for the time that the replay stopped.
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
        /// The reason that the replay is in the current state.
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