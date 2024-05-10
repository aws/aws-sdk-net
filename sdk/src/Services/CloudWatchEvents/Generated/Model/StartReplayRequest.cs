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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
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
namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the StartReplay operation.
    /// Starts the specified replay. Events are not necessarily replayed in the exact same
    /// order that they were added to the archive. A replay processes events to replay based
    /// on the time in the event, and replays them using 1 minute intervals. If you specify
    /// an <c>EventStartTime</c> and an <c>EventEndTime</c> that covers a 20 minute time range,
    /// the events are replayed from the first minute of that 20 minute range first. Then
    /// the events from the second minute are replayed. You can use <c>DescribeReplay</c>
    /// to determine the progress of a replay. The value returned for <c>EventLastReplayedTime</c>
    /// indicates the time within the specified time range associated with the last event
    /// replayed.
    /// </summary>
    public partial class StartReplayRequest : AmazonCloudWatchEventsRequest
    {
        private string _description;
        private ReplayDestination _destination;
        private DateTime? _eventEndTime;
        private string _eventSourceArn;
        private DateTime? _eventStartTime;
        private string _replayName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the replay to start.
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
        /// A <c>ReplayDestination</c> object that includes details about the destination for
        /// the replay.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A time stamp for the time to stop replaying events. Only events that occurred between
        /// the <c>EventStartTime</c> and <c>EventEndTime</c> are replayed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The ARN of the archive to replay events from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// A time stamp for the time to start replaying events. Only events that occurred between
        /// the <c>EventStartTime</c> and <c>EventEndTime</c> are replayed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ReplayName. 
        /// <para>
        /// The name of the replay to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}