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
    /// Mpeg2 Settings
    /// </summary>
    public partial class Mpeg2Settings
    {
        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Choose Off to disable adaptive quantization.
        /// Or choose another value to enable the quantizer and set its strength. The strengths
        /// are: Auto, Off, Low, Medium, High. When you enable this field, MediaLive allows intra-frame
        /// quantizers to vary, which might improve visual quality.
        /// </summary>
        public Mpeg2AdaptiveQuantization AdaptiveQuantization { get; set; }

        /// <summary>
        /// Checks to see if the AdaptiveQuantization property is set.
        /// </summary>
        internal bool IsSetAdaptiveQuantization() => this.AdaptiveQuantization != null;

        /// <summary>
        /// Gets and sets the property AfdSignaling. Indicates the AFD values that MediaLive will
        /// write into the video encode. If you do not know what AFD signaling is, or if your
        /// downstream system has not given you guidance, choose AUTO. AUTO: MediaLive will try
        /// to preserve the input AFD value (in cases where multiple AFD values are valid). FIXED:
        /// MediaLive will use the value you specify in fixedAFD.
        /// </summary>
        public AfdSignaling AfdSignaling { get; set; }

        /// <summary>
        /// Checks to see if the AfdSignaling property is set.
        /// </summary>
        internal bool IsSetAfdSignaling() => this.AfdSignaling != null;

        /// <summary>
        /// Gets and sets the property ColorMetadata. Specifies whether to include the color space
        /// metadata. The metadata describes the color space that applies to the video (the colorSpace
        /// field). We recommend that you insert the metadata.
        /// </summary>
        public Mpeg2ColorMetadata ColorMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ColorMetadata property is set.
        /// </summary>
        internal bool IsSetColorMetadata() => this.ColorMetadata != null;

        /// <summary>
        /// Gets and sets the property ColorSpace. Choose the type of color space conversion to
        /// apply to the output. For detailed information on setting up both the input and the
        /// output to obtain the desired color space in the output, see the section on \"MediaLive
        /// Features - Video - color space\" in the MediaLive User Guide. PASSTHROUGH: Keep the
        /// color space of the input content - do not convert it. AUTO:Convert all content that
        /// is SD to rec 601, and convert all content that is HD to rec 709.
        /// </summary>
        public Mpeg2ColorSpace ColorSpace { get; set; }

        /// <summary>
        /// Checks to see if the ColorSpace property is set.
        /// </summary>
        internal bool IsSetColorSpace() => this.ColorSpace != null;

        /// <summary>
        /// Gets and sets the property DisplayAspectRatio. Sets the pixel aspect ratio for the
        /// encode.
        /// </summary>
        public Mpeg2DisplayRatio DisplayAspectRatio { get; set; }

        /// <summary>
        /// Checks to see if the DisplayAspectRatio property is set.
        /// </summary>
        internal bool IsSetDisplayAspectRatio() => this.DisplayAspectRatio != null;

        /// <summary>
        /// Gets and sets the property FilterSettings. Optionally specify a noise reduction filter,
        /// which can improve quality of compressed content. If you do not choose a filter, no
        /// filter will be applied. TEMPORAL: This filter is useful for both source content that
        /// is noisy (when it has excessive digital artifacts) and source content that is clean.
        /// When the content is noisy, the filter cleans up the source content before the encoding
        /// phase, with these two effects: First, it improves the output video quality because
        /// the content has been cleaned up. Secondly, it decreases the bandwidth because MediaLive
        /// does not waste bits on encoding noise. When the content is reasonably clean, the filter
        /// tends to decrease the bitrate.
        /// </summary>
        public Mpeg2FilterSettings FilterSettings { get; set; }

        /// <summary>
        /// Checks to see if the FilterSettings property is set.
        /// </summary>
        internal bool IsSetFilterSettings() => this.FilterSettings != null;

        /// <summary>
        /// Gets and sets the property FixedAfd. Complete this field only when afdSignaling is
        /// set to FIXED. Enter the AFD value (4 bits) to write on all frames of the video encode.
        /// </summary>
        public FixedAfd FixedAfd { get; set; }

        /// <summary>
        /// Checks to see if the FixedAfd property is set.
        /// </summary>
        internal bool IsSetFixedAfd() => this.FixedAfd != null;

        /// <summary>
        /// Gets and sets the property FramerateDenominator. description": "The framerate denominator.
        /// For example, 1001. The framerate is the numerator divided by the denominator. For
        /// example, 24000 / 1001 = 23.976 FPS.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? FramerateDenominator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateDenominator property is set.
        /// </summary>
        internal bool IsSetFramerateDenominator() => this.FramerateDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property FramerateNumerator. The framerate numerator. For example,
        /// 24000. The framerate is the numerator divided by the denominator. For example, 24000
        /// / 1001 = 23.976 FPS.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? FramerateNumerator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateNumerator property is set.
        /// </summary>
        internal bool IsSetFramerateNumerator() => this.FramerateNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property GopClosedCadence. MPEG2: default is open GOP.
        /// </summary>
        public int? GopClosedCadence { get; set; }

        /// <summary>
        /// Checks to see if the GopClosedCadence property is set.
        /// </summary>
        internal bool IsSetGopClosedCadence() => this.GopClosedCadence.HasValue;

        /// <summary>
        /// Gets and sets the property GopNumBFrames. Relates to the GOP structure. The number
        /// of B-frames between reference frames. If you do not know what a B-frame is, use the
        /// default.
        /// </summary>
        public int? GopNumBFrames { get; set; }

        /// <summary>
        /// Checks to see if the GopNumBFrames property is set.
        /// </summary>
        internal bool IsSetGopNumBFrames() => this.GopNumBFrames.HasValue;

        /// <summary>
        /// Gets and sets the property GopSize. Relates to the GOP structure. The GOP size (keyframe
        /// interval) in the units specified in gopSizeUnits. If you do not know what GOP is,
        /// use the default. If gopSizeUnits is frames, then the gopSize must be an integer and
        /// must be greater than or equal to 1. If gopSizeUnits is seconds, the gopSize must be
        /// greater than 0, but does not need to be an integer.
        /// </summary>
        public double? GopSize { get; set; }

        /// <summary>
        /// Checks to see if the GopSize property is set.
        /// </summary>
        internal bool IsSetGopSize() => this.GopSize.HasValue;

        /// <summary>
        /// Gets and sets the property GopSizeUnits. Relates to the GOP structure. Specifies whether
        /// the gopSize is specified in frames or seconds. If you do not plan to change the default
        /// gopSize, leave the default. If you specify SECONDS, MediaLive will internally convert
        /// the gop size to a frame count.
        /// </summary>
        public Mpeg2GopSizeUnits GopSizeUnits { get; set; }

        /// <summary>
        /// Checks to see if the GopSizeUnits property is set.
        /// </summary>
        internal bool IsSetGopSizeUnits() => this.GopSizeUnits != null;

        /// <summary>
        /// Gets and sets the property ScanType. Set the scan type of the output to PROGRESSIVE
        /// or INTERLACED (top field first).
        /// </summary>
        public Mpeg2ScanType ScanType { get; set; }

        /// <summary>
        /// Checks to see if the ScanType property is set.
        /// </summary>
        internal bool IsSetScanType() => this.ScanType != null;

        /// <summary>
        /// Gets and sets the property SubgopLength. Relates to the GOP structure. If you do not
        /// know what GOP is, use the default. FIXED: Set the number of B-frames in each sub-GOP
        /// to the value in gopNumBFrames. DYNAMIC: Let MediaLive optimize the number of B-frames
        /// in each sub-GOP, to improve visual quality.
        /// </summary>
        public Mpeg2SubGopLength SubgopLength { get; set; }

        /// <summary>
        /// Checks to see if the SubgopLength property is set.
        /// </summary>
        internal bool IsSetSubgopLength() => this.SubgopLength != null;

        /// <summary>
        /// Gets and sets the property TimecodeBurninSettings. Timecode burn-in settings
        /// </summary>
        public TimecodeBurninSettings TimecodeBurninSettings { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeBurninSettings property is set.
        /// </summary>
        internal bool IsSetTimecodeBurninSettings() => this.TimecodeBurninSettings != null;

        /// <summary>
        /// Gets and sets the property TimecodeInsertion. Determines how MediaLive inserts timecodes
        /// in the output video. For detailed information about setting up the input and the output
        /// for a timecode, see the section on \"MediaLive Features - Timecode configuration\"
        /// in the MediaLive User Guide. DISABLED: do not include timecodes. GOP_TIMECODE: Include
        /// timecode metadata in the GOP header.
        /// </summary>
        public Mpeg2TimecodeInsertionBehavior TimecodeInsertion { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeInsertion property is set.
        /// </summary>
        internal bool IsSetTimecodeInsertion() => this.TimecodeInsertion != null;
    }
}
