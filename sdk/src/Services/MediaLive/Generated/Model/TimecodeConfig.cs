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
    /// Timecode Config
    /// </summary>
    public partial class TimecodeConfig
    {
        private TimecodeConfigSource _source;
        private int? _syncThreshold;

        /// <summary>
        /// Gets and sets the property Source. Identifies the source for the timecode that will
        /// be associated with the events outputs.-Embedded (embedded): Initialize the output
        /// timecode with timecode from the the source.  If no embedded timecode is detected in
        /// the source, the system falls back to using "Start at 0" (zerobased).-System Clock
        /// (systemclock): Use the UTC time.-Start at 0 (zerobased): The time of the first frame
        /// of the event will be 00:00:00:00.
        /// </summary>
        [AWSProperty(Required=true)]
        public TimecodeConfigSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SyncThreshold. Threshold in frames beyond which output
        /// timecode is resynchronized to the input timecode. Discrepancies below this threshold
        /// are permitted to avoid unnecessary discontinuities in the output timecode. No timecode
        /// sync when this is not specified.
        /// </summary>
        [AWSProperty(Min=1, Max=1000000)]
        public int? SyncThreshold
        {
            get { return this._syncThreshold; }
            set { this._syncThreshold = value; }
        }

        // Check to see if SyncThreshold property is set
        internal bool IsSetSyncThreshold()
        {
            return this._syncThreshold.HasValue; 
        }

    }
}