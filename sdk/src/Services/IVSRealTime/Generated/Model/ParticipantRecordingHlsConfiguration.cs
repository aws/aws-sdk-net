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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// An object representing a configuration of participant HLS recordings for individual
    /// participant recording.
    /// </summary>
    public partial class ParticipantRecordingHlsConfiguration
    {
        private int? _targetSegmentDurationSeconds;

        /// <summary>
        /// Gets and sets the property TargetSegmentDurationSeconds. 
        /// <para>
        /// Defines the target duration for recorded segments generated when recording a stage
        /// participant. Segments may have durations longer than the specified value when needed
        /// to ensure each segment begins with a keyframe. Default: 6.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
        public int TargetSegmentDurationSeconds
        {
            get { return this._targetSegmentDurationSeconds.GetValueOrDefault(); }
            set { this._targetSegmentDurationSeconds = value; }
        }

        // Check to see if TargetSegmentDurationSeconds property is set
        internal bool IsSetTargetSegmentDurationSeconds()
        {
            return this._targetSegmentDurationSeconds.HasValue; 
        }

    }
}