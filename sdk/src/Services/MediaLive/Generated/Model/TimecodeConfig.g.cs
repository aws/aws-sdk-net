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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Timecode Config
    /// </summary>
    public partial class TimecodeConfig
    {
        /// <summary>
        /// Gets and sets the property Source. Identifies the source for the timecode that will
        /// be associated with the events outputs. -Embedded (embedded): Initialize the output
        /// timecode with timecode from the the source. If no embedded timecode is detected in
        /// the source, the system falls back to using "Start at 0" (zerobased). -System Clock
        /// (systemclock): Use the UTC time. -Start at 0 (zerobased): The time of the first frame
        /// of the event will be 00:00:00:00.
        /// </summary>
        [AWSProperty(Required = true)]
        public TimecodeConfigSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SyncThreshold. Threshold in frames beyond which output
        /// timecode is resynchronized to the input timecode. Discrepancies below this threshold
        /// are permitted to avoid unnecessary discontinuities in the output timecode. No timecode
        /// sync when this is not specified.
        /// </summary>
        public int? SyncThreshold { get; set; }

        /// <summary>
        /// Checks to see if the SyncThreshold property is set.
        /// </summary>
        internal bool IsSetSyncThreshold() => this.SyncThreshold.HasValue;
    }
}
