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
    /// To transcode only portions of your video overlay, include one input clip for each
    /// part of your video overlay that you want in your output.
    /// </summary>
    public partial class VideoOverlayInputClipping
    {
        private string _endTimecode;
        private string _startTimecode;

        /// <summary>
        /// Gets and sets the property EndTimecode. Specify the timecode of the last frame to
        /// include in your video overlay's clip. Use the format HH:MM:SS:FF or HH:MM:SS;FF, where
        /// HH is the hour, MM is the minute, SS is the second, and FF is the frame number. When
        /// entering this value, take into account your choice for Timecode source.
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
        /// Gets and sets the property StartTimecode. Specify the timecode of the first frame
        /// to include in your video overlay's clip. Use the format HH:MM:SS:FF or HH:MM:SS;FF,
        /// where HH is the hour, MM is the minute, SS is the second, and FF is the frame number.
        /// When entering this value, take into account your choice for Timecode source.
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