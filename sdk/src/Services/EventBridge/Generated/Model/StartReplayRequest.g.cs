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
    /// Container for the parameters to the StartReplay operation. Starts the specified replay.
    /// Events are not necessarily replayed in the exact same order that they were added to
    /// the archive. A replay processes events to replay based on the time in the event, and
    /// replays them using 1 minute intervals. If you specify an <c>EventStartTime</c> and
    /// an <c>EventEndTime</c> that covers a 20 minute time range, the events are replayed
    /// from the first minute of that 20 minute range first. Then the events from the second
    /// minute are replayed. You can use <c>DescribeReplay</c> to determine the progress of
    /// a replay. The value returned for <c>EventLastReplayedTime</c> indicates the time within
    /// the specified time range associated with the last event replayed.
    /// </summary>
    public partial class StartReplayRequest : AmazonEventBridgeRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the replay to start.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// A <c>ReplayDestination</c> object that includes details about the destination for
        /// the replay.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplayDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property EventEndTime. 
        /// <para>
        /// A time stamp for the time to stop replaying events. Only events that occurred between
        /// the <c>EventStartTime</c> and <c>EventEndTime</c> are replayed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EventEndTime { get; set; }

        /// <summary>
        /// Checks to see if the EventEndTime property is set.
        /// </summary>
        internal bool IsSetEventEndTime() => this.EventEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The ARN of the archive to replay events from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string EventSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceArn property is set.
        /// </summary>
        internal bool IsSetEventSourceArn() => this.EventSourceArn != null;

        /// <summary>
        /// Gets and sets the property EventStartTime. 
        /// <para>
        /// A time stamp for the time to start replaying events. Only events that occurred between
        /// the <c>EventStartTime</c> and <c>EventEndTime</c> are replayed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EventStartTime { get; set; }

        /// <summary>
        /// Checks to see if the EventStartTime property is set.
        /// </summary>
        internal bool IsSetEventStartTime() => this.EventStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReplayName. 
        /// <para>
        /// The name of the replay to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ReplayName { get; set; }

        /// <summary>
        /// Checks to see if the ReplayName property is set.
        /// </summary>
        internal bool IsSetReplayName() => this.ReplayName != null;
    }
}
