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
    /// Input video selectors contain the video settings for the input. Each of your inputs
    /// can have up to one video selector.
    /// </summary>
    public partial class VideoSelector
    {
        private AlphaBehavior _alphaBehavior;
        private ColorSpace _colorSpace;
        private ColorSpaceUsage _colorSpaceUsage;
        private EmbeddedTimecodeOverride _embeddedTimecodeOverride;
        private Hdr10Metadata _hdr10Metadata;
        private PadVideo _padVideo;
        private int? _pid;
        private int? _programNumber;
        private InputRotate _rotate;
        private InputSampleRange _sampleRange;

        /// <summary>
        /// Gets and sets the property AlphaBehavior. Ignore this setting unless this input is
        /// a QuickTime animation with an alpha channel. Use this setting to create separate Key
        /// and Fill outputs. In each output, specify which part of the input MediaConvert uses.
        /// Leave this setting at the default value DISCARD to delete the alpha channel and preserve
        /// the video. Set it to REMAP_TO_LUMA to delete the video and map the alpha channel to
        /// the luma channel of your outputs.
        /// </summary>
        public AlphaBehavior AlphaBehavior
        {
            get { return this._alphaBehavior; }
            set { this._alphaBehavior = value; }
        }

        // Check to see if AlphaBehavior property is set
        internal bool IsSetAlphaBehavior()
        {
            return this._alphaBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property ColorSpace. If your input video has accurate color space
        /// metadata, or if you don't know about color space: Keep the default value, Follow.
        /// MediaConvert will automatically detect your input color space. If your input video
        /// has metadata indicating the wrong color space, or has missing metadata: Specify the
        /// accurate color space here. If your input video is HDR 10 and the SMPTE ST 2086 Mastering
        /// Display Color Volume static metadata isn't present in your video stream, or if that
        /// metadata is present but not accurate: Choose Force HDR 10. Specify correct values
        /// in the input HDR 10 metadata settings. For more information about HDR jobs, see https://docs.aws.amazon.com/console/mediaconvert/hdr.
        /// When you specify an input color space, MediaConvert uses the following color space
        /// metadata, which includes color primaries, transfer characteristics, and matrix coefficients:
        /// * HDR 10: BT.2020, PQ, BT.2020 non-constant * HLG 2020: BT.2020, HLG, BT.2020 non-constant
        /// * P3DCI (Theater): DCIP3, SMPTE 428M, BT.709 * P3D65 (SDR): Display P3, sRGB, BT.709
        /// * P3D65 (HDR): Display P3, PQ, BT.709
        /// </summary>
        public ColorSpace ColorSpace
        {
            get { return this._colorSpace; }
            set { this._colorSpace = value; }
        }

        // Check to see if ColorSpace property is set
        internal bool IsSetColorSpace()
        {
            return this._colorSpace != null;
        }

        /// <summary>
        /// Gets and sets the property ColorSpaceUsage. There are two sources for color metadata,
        /// the input file and the job input settings Color space (ColorSpace) and HDR master
        /// display information settings(Hdr10Metadata). The Color space usage setting determines
        /// which takes precedence. Choose Force (FORCE) to use color metadata from the input
        /// job settings. If you don't specify values for those settings, the service defaults
        /// to using metadata from your input. FALLBACK - Choose Fallback (FALLBACK) to use color
        /// metadata from the source when it is present. If there's no color metadata in your
        /// input file, the service defaults to using values you specify in the input settings.
        /// </summary>
        public ColorSpaceUsage ColorSpaceUsage
        {
            get { return this._colorSpaceUsage; }
            set { this._colorSpaceUsage = value; }
        }

        // Check to see if ColorSpaceUsage property is set
        internal bool IsSetColorSpaceUsage()
        {
            return this._colorSpaceUsage != null;
        }

        /// <summary>
        /// Gets and sets the property EmbeddedTimecodeOverride. Set Embedded timecode override
        /// (embeddedTimecodeOverride) to Use MDPM (USE_MDPM) when your AVCHD input contains timecode
        /// tag data in the Modified Digital Video Pack Metadata (MDPM). When you do, we recommend
        /// you also set Timecode source (inputTimecodeSource) to Embedded (EMBEDDED). Leave Embedded
        /// timecode override blank, or set to None (NONE), when your input does not contain MDPM
        /// timecode.
        /// </summary>
        public EmbeddedTimecodeOverride EmbeddedTimecodeOverride
        {
            get { return this._embeddedTimecodeOverride; }
            set { this._embeddedTimecodeOverride = value; }
        }

        // Check to see if EmbeddedTimecodeOverride property is set
        internal bool IsSetEmbeddedTimecodeOverride()
        {
            return this._embeddedTimecodeOverride != null;
        }

        /// <summary>
        /// Gets and sets the property Hdr10Metadata. Use these settings to provide HDR 10 metadata
        /// that is missing or inaccurate in your input video. Appropriate values vary depending
        /// on the input video and must be provided by a color grader. The color grader generates
        /// these values during the HDR 10 mastering process. The valid range for each of these
        /// settings is 0 to 50,000. Each increment represents 0.00002 in CIE1931 color coordinate.
        /// Related settings - When you specify these values, you must also set Color space (ColorSpace)
        /// to HDR 10 (HDR10). To specify whether the the values you specify here take precedence
        /// over the values in the metadata of your input file, set Color space usage (ColorSpaceUsage).
        /// To specify whether color metadata is included in an output, set Color metadata (ColorMetadata).
        /// For more information about MediaConvert HDR jobs, see https://docs.aws.amazon.com/console/mediaconvert/hdr.
        /// </summary>
        public Hdr10Metadata Hdr10Metadata
        {
            get { return this._hdr10Metadata; }
            set { this._hdr10Metadata = value; }
        }

        // Check to see if Hdr10Metadata property is set
        internal bool IsSetHdr10Metadata()
        {
            return this._hdr10Metadata != null;
        }

        /// <summary>
        /// Gets and sets the property PadVideo. Use this setting if your input has video and
        /// audio durations that don't align, and your output or player has strict alignment requirements.
        /// Examples: Input audio track has a delayed start. Input video track ends before audio
        /// ends. When you set Pad video (padVideo) to Black (BLACK), MediaConvert generates black
        /// video frames so that output video and audio durations match. Black video frames are
        /// added at the beginning or end, depending on your input. To keep the default behavior
        /// and not generate black video, set Pad video to Disabled (DISABLED) or leave blank.
        /// </summary>
        public PadVideo PadVideo
        {
            get { return this._padVideo; }
            set { this._padVideo = value; }
        }

        // Check to see if PadVideo property is set
        internal bool IsSetPadVideo()
        {
            return this._padVideo != null;
        }

        /// <summary>
        /// Gets and sets the property Pid. Use PID (Pid) to select specific video data from an
        /// input file. Specify this value as an integer; the system automatically converts it
        /// to the hexidecimal value. For example, 257 selects PID 0x101. A PID, or packet identifier,
        /// is an identifier for a set of data in an MPEG-2 transport stream container.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int Pid
        {
            get { return this._pid.GetValueOrDefault(); }
            set { this._pid = value; }
        }

        // Check to see if Pid property is set
        internal bool IsSetPid()
        {
            return this._pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgramNumber. Selects a specific program from within a
        /// multi-program transport stream. Note that Quad 4K is not currently supported.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int ProgramNumber
        {
            get { return this._programNumber.GetValueOrDefault(); }
            set { this._programNumber = value; }
        }

        // Check to see if ProgramNumber property is set
        internal bool IsSetProgramNumber()
        {
            return this._programNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rotate. Use Rotate (InputRotate) to specify how the service
        /// rotates your video. You can choose automatic rotation or specify a rotation. You can
        /// specify a clockwise rotation of 0, 90, 180, or 270 degrees. If your input video container
        /// is .mov or .mp4 and your input has rotation metadata, you can choose Automatic to
        /// have the service rotate your video according to the rotation specified in the metadata.
        /// The rotation must be within one degree of 90, 180, or 270 degrees. If the rotation
        /// metadata specifies any other rotation, the service will default to no rotation. By
        /// default, the service does no rotation, even if your input video has rotation metadata.
        /// The service doesn't pass through rotation metadata.
        /// </summary>
        public InputRotate Rotate
        {
            get { return this._rotate; }
            set { this._rotate = value; }
        }

        // Check to see if Rotate property is set
        internal bool IsSetRotate()
        {
            return this._rotate != null;
        }

        /// <summary>
        /// Gets and sets the property SampleRange. If the sample range metadata in your input
        /// video is accurate, or if you don't know about sample range, keep the default value,
        /// Follow (FOLLOW), for this setting. When you do, the service automatically detects
        /// your input sample range. If your input video has metadata indicating the wrong sample
        /// range, specify the accurate sample range here. When you do, MediaConvert ignores any
        /// sample range information in the input metadata. Regardless of whether MediaConvert
        /// uses the input sample range or the sample range that you specify, MediaConvert uses
        /// the sample range for transcoding and also writes it to the output metadata.
        /// </summary>
        public InputSampleRange SampleRange
        {
            get { return this._sampleRange; }
            set { this._sampleRange = value; }
        }

        // Check to see if SampleRange property is set
        internal bool IsSetSampleRange()
        {
            return this._sampleRange != null;
        }

    }
}