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
    /// Settings related to SCC captions. SCC is a sidecar format that holds captions in a
    /// file that is separate from the video container. Set up sidecar captions in the same
    /// output group, but different output from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/scc-srt-output-captions.html.
    /// </summary>
    public partial class SccDestinationSettings
    {
        private SccDestinationFramerate _framerate;

        /// <summary>
        /// Gets and sets the property Framerate. Set Framerate to make sure that the captions
        /// and the video are synchronized in the output. Specify a frame rate that matches the
        /// frame rate of the associated video. If the video frame rate is 29.97, choose 29.97
        /// dropframe only if the video has video_insertion=true and drop_frame_timecode=true;
        /// otherwise, choose 29.97 non-dropframe.
        /// </summary>
        public SccDestinationFramerate Framerate
        {
            get { return this._framerate; }
            set { this._framerate = value; }
        }

        // Check to see if Framerate property is set
        internal bool IsSetFramerate()
        {
            return this._framerate != null;
        }

    }
}