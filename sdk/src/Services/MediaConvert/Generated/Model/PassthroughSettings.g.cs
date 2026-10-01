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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Optional settings when you set Codec to the value Passthrough.
    /// </summary>
    public partial class PassthroughSettings
    {
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
        public FrameControl FrameControl { get; set; }

        /// <summary>
        /// Checks to see if the FrameControl property is set.
        /// </summary>
        internal bool IsSetFrameControl() => this.FrameControl != null;

        /// <summary>
        /// Gets and sets the property GopsPerSegment. Specify how many input GOPs MediaConvert
        /// places in each output segment when you set Passthrough segmentation mode to GOP count.
        /// For example, if your input has a closed GOP every 1.92 seconds and you specify 2,
        /// each output segment is 3.84 seconds. In this mode, output segment duration is determined
        /// by your input GOP structure rather than by your configured Segment length or Fragment
        /// length, so segment durations are consistent only when your input GOP cadence is constant.
        /// Segments at input discontinuities or ad avails may contain fewer GOPs.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? GopsPerSegment { get; set; }

        /// <summary>
        /// Checks to see if the GopsPerSegment property is set.
        /// </summary>
        internal bool IsSetGopsPerSegment() => this.GopsPerSegment.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentationMode. Choose how MediaConvert determines segment
        /// boundaries when you passthrough video to a segmented ABR output (HLS, DASH, or CMAF).
        /// This setting applies only to ABR outputs. Keep the default value, Auto, to let MediaConvert
        /// choose based on your input: when your input is a segmented HLS or DASH source, MediaConvert
        /// reproduces your input's own segment boundaries, with one output segment per input
        /// segment; for all other inputs, MediaConvert places boundaries by duration, cutting
        /// at the first eligible IDR-frame at or after each configured Segment length or Fragment
        /// length target. Choose Duration based to always place boundaries by duration, at the
        /// first eligible IDR-frame at or after each configured Segment length or Fragment length
        /// target, regardless of your input. When your input GOP duration does not evenly divide
        /// your target segment length, output segment durations will vary. Choose GOP count to
        /// place a fixed number of input GOPs in every segment, and specify GOPs per segment.
        /// Every segment contains the same number of input GOPs, which produces consistent segment
        /// durations when your input GOP cadence is constant. In this mode MediaConvert ignores
        /// your configured Segment length and Fragment length for video boundary placement. Ad
        /// avails and input discontinuities are still honored as segment boundaries.
        /// </summary>
        public PassthroughSegmentationMode SegmentationMode { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationMode property is set.
        /// </summary>
        internal bool IsSetSegmentationMode() => this.SegmentationMode != null;

        /// <summary>
        /// Gets and sets the property VideoSelectorMode. AUTO will select the highest bitrate
        /// input in the video selector source. REMUX_ALL will passthrough all the selected streams
        /// in the video selector source. When selecting streams from multiple renditions (i.e.
        /// using Stream video selector type): REMUX_ALL will only remux all streams selected,
        /// and AUTO will use the highest bitrate video stream among the selected streams as source.
        /// </summary>
        public VideoSelectorMode VideoSelectorMode { get; set; }

        /// <summary>
        /// Checks to see if the VideoSelectorMode property is set.
        /// </summary>
        internal bool IsSetVideoSelectorMode() => this.VideoSelectorMode != null;
    }
}
