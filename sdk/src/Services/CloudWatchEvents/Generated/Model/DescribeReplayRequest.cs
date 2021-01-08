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

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReplay operation.
    /// Retrieves details about a replay. Use <code>DescribeReplay</code> to determine the
    /// progress of a running replay. A replay processes events to replay based on the time
    /// in the event, and replays them using 1 minute intervals. If you use <code>StartReplay</code>
    /// and specify an <code>EventStartTime</code> and an <code>EventEndTime</code> that covers
    /// a 20 minute time range, the events are replayed from the first minute of that 20 minute
    /// range first. Then the events from the second minute are replayed. You can use <code>DescribeReplay</code>
    /// to determine the progress of a replay. The value returned for <code>EventLastReplayedTime</code>
    /// indicates the time within the specified time range associated with the last event
    /// replayed.
    /// </summary>
    public partial class DescribeReplayRequest : AmazonCloudWatchEventsRequest
    {
        private string _replayName;

        /// <summary>
        /// Gets and sets the property ReplayName. 
        /// <para>
        /// The name of the replay to retrieve.
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