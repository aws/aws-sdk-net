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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Overlay one or more videos on top of your input video.
    /// </summary>
    public partial class VideoOverlay
    {
        private string _endTimecode;
        private VideoOverlayInput _input;
        private string _startTimecode;

        /// <summary>
        /// Gets and sets the property EndTimecode. Enter the end timecode in the underlying input
        /// video for this overlay. Your overlay will be active through this frame. To display
        /// your video overlay for the duration of the underlying video: Leave blank. Use the
        /// format HH:MM:SS:FF or HH:MM:SS;FF, where HH is the hour, MM is the minute, SS is the
        /// second, and FF is the frame number. When entering this value, take into account your
        /// choice for the underlying Input timecode source. For example, if you have embedded
        /// timecodes that start at 01:00:00:00 and you want your overlay to end ten minutes into
        /// the video, enter 01:10:00:00.
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
        /// Gets and sets the property Input. Input settings for Video overlay. You can include
        /// one or more video overlays in sequence at different times that you specify.
        /// </summary>
        public VideoOverlayInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimecode. Enter the start timecode in the underlying
        /// input video for this overlay. Your overlay will be active starting with this frame.
        /// To display your video overlay starting at the beginning of the underlying video: Leave
        /// blank. Use the format HH:MM:SS:FF or HH:MM:SS;FF, where HH is the hour, MM is the
        /// minute, SS is the second, and FF is the frame number. When entering this value, take
        /// into account your choice for the underlying Input timecode source. For example, if
        /// you have embedded timecodes that start at 01:00:00:00 and you want your overlay to
        /// begin five minutes into the video, enter 01:05:00:00.
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