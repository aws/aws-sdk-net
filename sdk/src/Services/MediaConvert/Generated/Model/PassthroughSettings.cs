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
    /// Optional settings when you set Codec to the value Passthrough.
    /// </summary>
    public partial class PassthroughSettings
    {
        private FrameControl _frameControl;
        private VideoSelectorMode _videoSelectorMode;

        /// <summary>
        /// Gets and sets the property FrameControl. Choose how MediaConvert handles start and
        /// end times for input clipping with video passthrough. Your input video codec must be
        /// H.264 or H.265 to use IFRAME. To clip at the nearest IDR-frame: Choose Nearest IDR.
        /// If an IDR-frame is not found at the frame that you specify, MediaConvert uses the
        /// next compatible IDR-frame. Note that your output may be shorter than your input clip
        /// duration. To clip at the nearest I-frame: Choose Nearest I-frame. If an I-frame is
        /// not found at the frame that you specify, MediaConvert uses the next compatible I-frame.
        /// Note that your output may be shorter than your input clip duration. We only recommend
        /// this setting for special workflows, and when you choose this setting your output may
        /// not be compatible with most players.
        /// </summary>
        public FrameControl FrameControl
        {
            get { return this._frameControl; }
            set { this._frameControl = value; }
        }

        // Check to see if FrameControl property is set
        internal bool IsSetFrameControl()
        {
            return this._frameControl != null;
        }

        /// <summary>
        /// Gets and sets the property VideoSelectorMode. AUTO will select the highest bitrate
        /// input in the video selector source. REMUX_ALL will passthrough all the selected streams
        /// in the video selector source. When selecting streams from multiple renditions (i.e.
        /// using Stream video selector type): REMUX_ALL will only remux all streams selected,
        /// and AUTO will use the highest bitrate video stream among the selected streams as source.
        /// </summary>
        public VideoSelectorMode VideoSelectorMode
        {
            get { return this._videoSelectorMode; }
            set { this._videoSelectorMode = value; }
        }

        // Check to see if VideoSelectorMode property is set
        internal bool IsSetVideoSelectorMode()
        {
            return this._videoSelectorMode != null;
        }

    }
}