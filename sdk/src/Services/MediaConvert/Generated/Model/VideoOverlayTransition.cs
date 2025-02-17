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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Specify one or more Transitions for your video overlay. Use Transitions to reposition
    /// or resize your overlay over time. To use the same position and size for the duration
    /// of your video overlay: Leave blank. To specify a Transition: Enter a value for Start
    /// timecode, End Timecode, X Position, Y Position, Width, or Height.
    /// </summary>
    public partial class VideoOverlayTransition
    {
        private VideoOverlayPosition _endPosition;
        private string _endTimecode;
        private string _startTimecode;

        /// <summary>
        /// Gets and sets the property EndPosition. Specify the ending position for this transition,
        /// relative to the base input video's frame. Your video overlay will move smoothly to
        /// this position, beginning at this transition's Start timecode and ending at this transition's
        /// End timecode.
        /// </summary>
        public VideoOverlayPosition EndPosition
        {
            get { return this._endPosition; }
            set { this._endPosition = value; }
        }

        // Check to see if EndPosition property is set
        internal bool IsSetEndPosition()
        {
            return this._endPosition != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimecode. Specify the timecode for when this transition
        /// ends. Use the format HH:MM:SS:FF or HH:MM:SS;FF, where HH is the hour, MM is the minute,
        /// SS is the second, and FF is the frame number. When entering this value, take into
        /// account your choice for Timecode source.
        /// </summary>
        public string EndTimecode
        {
            get { return this._endTimecode; }
            set { this._endTimecode = value; }
        }

        // Check to see if EndTimecode property is set
        internal bool IsSetEndTimecode()
        {
            return this._endTimecode != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimecode. Specify the timecode for when this transition
        /// begins. Use the format HH:MM:SS:FF or HH:MM:SS;FF, where HH is the hour, MM is the
        /// minute, SS is the second, and FF is the frame number. When entering this value, take
        /// into account your choice for Timecode source.
        /// </summary>
        public string StartTimecode
        {
            get { return this._startTimecode; }
            set { this._startTimecode = value; }
        }

        // Check to see if StartTimecode property is set
        internal bool IsSetStartTimecode()
        {
            return this._startTimecode != null;
        }

    }
}