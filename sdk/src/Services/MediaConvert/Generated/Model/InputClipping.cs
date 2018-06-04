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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// To transcode only portions of your input (clips), include one Input clipping (one
    /// instance of InputClipping in the JSON job file) for each input clip. All input clips
    /// you specify will be included in every output of the job.
    /// </summary>
    public partial class InputClipping
    {
        private string _endTimecode;
        private string _startTimecode;

        /// <summary>
        /// Gets and sets the property EndTimecode. Set End timecode (EndTimecode) to the end
        /// of the portion of the input you are clipping. The frame corresponding to the End timecode
        /// value is included in the clip. Start timecode or End timecode may be left blank, but
        /// not both. Use the format HH:MM:SS:FF or HH:MM:SS;FF, where HH is the hour, MM is the
        /// minute, SS is the second, and FF is the frame number. When choosing this value, take
        /// into account your setting for timecode source under input settings (InputTimecodeSource).
        /// For example, if you have embedded timecodes that start at 01:00:00:00 and you want
        /// your clip to end six minutes into the video, use 01:06:00:00.
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
        /// Gets and sets the property StartTimecode. Set Start timecode (StartTimecode) to the
        /// beginning of the portion of the input you are clipping. The frame corresponding to
        /// the Start timecode value is included in the clip. Start timecode or End timecode may
        /// be left blank, but not both. Use the format HH:MM:SS:FF or HH:MM:SS;FF, where HH is
        /// the hour, MM is the minute, SS is the second, and FF is the frame number. When choosing
        /// this value, take into account your setting for Input timecode source. For example,
        /// if you have embedded timecodes that start at 01:00:00:00 and you want your clip to
        /// begin five minutes into the video, use 01:05:00:00.
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