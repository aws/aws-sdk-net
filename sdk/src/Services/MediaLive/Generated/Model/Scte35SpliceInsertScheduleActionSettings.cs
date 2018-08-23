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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// SCTE-35 Splice Insert Settings.
    /// </summary>
    public partial class Scte35SpliceInsertScheduleActionSettings
    {
        private long? _duration;
        private long? _spliceEventId;

        /// <summary>
        /// Gets and sets the property Duration. The duration for the SCTE-35 splice_insert specified
        /// in 90KHz clock ticks. When duration is not specified the expectation is that a Scte35ReturnToNetwork
        /// action will be scheduled.
        /// </summary>
        public long Duration
        {
            get { return this._duration.GetValueOrDefault(); }
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
        public long SpliceEventId
        {
            get { return this._spliceEventId.GetValueOrDefault(); }
            set { this._spliceEventId = value; }
        }

        // Check to see if SpliceEventId property is set
        internal bool IsSetSpliceEventId()
        {
            return this._spliceEventId.HasValue; 
        }

    }
}