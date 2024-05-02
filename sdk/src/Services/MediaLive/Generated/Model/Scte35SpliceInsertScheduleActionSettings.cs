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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Settings for a SCTE-35 splice_insert message.
    /// </summary>
    public partial class Scte35SpliceInsertScheduleActionSettings
    {
        private long? _duration;
        private long? _spliceEventId;

        /// <summary>
        /// Gets and sets the property Duration. Optional, the duration for the splice_insert,
        /// in 90 KHz ticks. To convert seconds to ticks, multiple the seconds by 90,000. If you
        /// enter a duration, there is an expectation that the downstream system can read the
        /// duration and cue in at that time. If you do not enter a duration, the splice_insert
        /// will continue indefinitely and there is an expectation that you will enter a return_to_network
        /// to end the splice_insert at the appropriate time.
        /// </summary>
        [AWSProperty(Min=0, Max=8589934591)]
        public long? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpliceEventId. The splice_event_id for the SCTE-35 splice_insert,
        /// as defined in SCTE-35.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4294967295)]
        public long? SpliceEventId
        {
            get { return this._spliceEventId; }
            set { this._spliceEventId = value; }
        }

        // Check to see if SpliceEventId property is set
        internal bool IsSetSpliceEventId()
        {
            return this._spliceEventId.HasValue; 
        }

    }
}