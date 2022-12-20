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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Mpeg2 Settings
    /// </summary>
    public partial class Mpeg2Settings
    {
        private Mpeg2AdaptiveQuantization _adaptiveQuantization;
        private AfdSignaling _afdSignaling;
        private Mpeg2ColorMetadata _colorMetadata;
        private Mpeg2ColorSpace _colorSpace;
        private Mpeg2DisplayRatio _displayAspectRatio;
        private Mpeg2FilterSettings _filterSettings;
        private FixedAfd _fixedAfd;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private int? _gopClosedCadence;
        private int? _gopNumBFrames;
        private double? _gopSize;
        private Mpeg2GopSizeUnits _gopSizeUnits;
        private Mpeg2ScanType _scanType;
        private Mpeg2SubGopLength _subgopLength;
        private TimecodeBurninSettings _timecodeBurninSettings;
        private Mpeg2TimecodeInsertionBehavior _timecodeInsertion;

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Choose Off to disable adaptive quantization.
        /// Or choose another value to enable the quantizer and set its strength. The strengths
        /// are: Auto, Off, Low, Medium, High. When you enable this field, MediaLive allows intra-frame
        /// quantizers to vary, which might improve visual quality.
        /// </summary>
        public Mpeg2AdaptiveQuantization AdaptiveQuantization
        {
            get { return this._adaptiveQuantization; }
            set { this._adaptiveQuantization = value; }
        }

        // Check to see if AdaptiveQuantization property is set
        internal bool IsSetAdaptiveQuantization()
        {
            return this._adaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property AfdSignaling. Indicates the AFD values that MediaLive will
        /// write into the video encode. If you do not know what AFD signaling is, or if your
        /// downstream system has not given you guidance, choose AUTO.AUTO: MediaLive will try
        /// to preserve the input AFD value (in cases where multiple AFD values are valid).FIXED:
        /// MediaLive will use the value you specify in fixedAFD.
        /// </summary>
        public AfdSignaling AfdSignaling
        {
            get { return this._afdSignaling; }
            set { this._afdSignaling = value; }
        }

        // Check to see if AfdSignaling property is set
        internal bool IsSetAfdSignaling()
        {
            return this._afdSignaling != null;
        }

        /// <summary>
        /// Gets and sets the property ColorMetadata. Specifies whether to include the color space
        /// metadata. The metadata describes the color space that applies to the video (the colorSpace
        /// field). We recommend that you insert the metadata.
        /// </summary>
        public Mpeg2ColorMetadata ColorMetadata
        {
            get { return this._colorMetadata; }
            set { this._colorMetadata = value; }
        }

        // Check to see if ColorMetadata property is set
        internal bool IsSetColorMetadata()
        {
            return this._colorMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ColorSpace. Choose the type of color space conversion to
        /// apply to the output. For detailed information on setting up both the input and the
        /// output to obtain the desired color space in the output, see the section on \"MediaLive
        /// Features - Video - color space\" in the MediaLive User Guide.PASSTHROUGH: Keep the
        /// color space of the input content - do not convert it.AUTO:Convert all content that
        /// is SD to rec 601, and convert all content that is HD to rec 709.
        /// </summary>
        public Mpeg2ColorSpace ColorSpace
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
        /// Gets and sets the property DisplayAspectRatio. Sets the pixel aspect ratio for the
        /// encode.
        /// </summary>
        public Mpeg2DisplayRatio DisplayAspectRatio
        {
            get { return this._displayAspectRatio; }
            set { this._displayAspectRatio = value; }
        }

        // Check to see if DisplayAspectRatio property is set
        internal bool IsSetDisplayAspectRatio()
        {
            return this._displayAspectRatio != null;
        }

        /// <summary>
        /// Gets and sets the property FilterSettings. Optionally specify a noise reduction filter,
        /// which can improve quality of compressed content. If you do not choose a filter, no
        /// filter will be applied.TEMPORAL: This filter is useful for both source content that
        /// is noisy (when it has excessive digital artifacts) and source content that is clean.When
        /// the content is noisy, the filter cleans up the source content before the encoding
        /// phase, with these two effects: First, it improves the output video quality because
        /// the content has been cleaned up. Secondly, it decreases the bandwidth because MediaLive
        /// does not waste bits on encoding noise.When the content is reasonably clean, the filter
        /// tends to decrease the bitrate.
        /// </summary>
        public Mpeg2FilterSettings FilterSettings
        {
            get { return this._filterSettings; }
            set { this._filterSettings = value; }
        }

        // Check to see if FilterSettings property is set
        internal bool IsSetFilterSettings()
        {
            return this._filterSettings != null;
        }

        /// <summary>
        /// Gets and sets the property FixedAfd. Complete this field only when afdSignaling is
        /// set to FIXED. Enter the AFD value (4 bits) to write on all frames of the video encode.
        /// </summary>
        public FixedAfd FixedAfd
        {
            get { return this._fixedAfd; }
            set { this._fixedAfd = value; }
        }

        // Check to see if FixedAfd property is set
        internal bool IsSetFixedAfd()
        {
            return this._fixedAfd != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateDenominator. description": "The framerate denominator.
        /// For example, 1001. The framerate is the numerator divided by the denominator. For
        /// example, 24000 / 1001 = 23.976 FPS.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int FramerateDenominator
        {
            get { return this._framerateDenominator.GetValueOrDefault(); }
            set { this._framerateDenominator = value; }
        }

        // Check to see if FramerateDenominator property is set
        internal bool IsSetFramerateDenominator()
        {
            return this._framerateDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FramerateNumerator. The framerate numerator. For example,
        /// 24000. The framerate is the numerator divided by the denominator. For example, 24000
        /// / 1001 = 23.976 FPS.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int FramerateNumerator
        {
            get { return this._framerateNumerator.GetValueOrDefault(); }
            set { this._framerateNumerator = value; }
        }

        // Check to see if FramerateNumerator property is set
        internal bool IsSetFramerateNumerator()
        {
            return this._framerateNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopClosedCadence. MPEG2: default is open GOP.
        /// </summary>
        [AWSProperty(Min=0)]
        public int GopClosedCadence
        {
            get { return this._gopClosedCadence.GetValueOrDefault(); }
            set { this._gopClosedCadence = value; }
        }

        // Check to see if GopClosedCadence property is set
        internal bool IsSetGopClosedCadence()
        {
            return this._gopClosedCadence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopNumBFrames. Relates to the GOP structure. The number
        /// of B-frames between reference frames. If you do not know what a B-frame is, use the
        /// default.
        /// </summary>
        [AWSProperty(Min=0, Max=7)]
        public int GopNumBFrames
        {
            get { return this._gopNumBFrames.GetValueOrDefault(); }
            set { this._gopNumBFrames = value; }
        }

        // Check to see if GopNumBFrames property is set
        internal bool IsSetGopNumBFrames()
        {
            return this._gopNumBFrames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopSize. Relates to the GOP structure. The GOP size (keyframe
        /// interval) in the units specified in gopSizeUnits. If you do not know what GOP is,
        /// use the default.If gopSizeUnits is frames, then the gopSize must be an integer and
        /// must be greater than or equal to 1.If gopSizeUnits is seconds, the gopSize must be
        /// greater than 0, but does not need to be an integer.
        /// </summary>
        public double GopSize
        {
            get { return this._gopSize.GetValueOrDefault(); }
            set { this._gopSize = value; }
        }

        // Check to see if GopSize property is set
        internal bool IsSetGopSize()
        {
            return this._gopSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopSizeUnits. Relates to the GOP structure. Specifies whether
        /// the gopSize is specified in frames or seconds. If you do not plan to change the default
        /// gopSize, leave the default. If you specify SECONDS, MediaLive will internally convert
        /// the gop size to a frame count.
        /// </summary>
        public Mpeg2GopSizeUnits GopSizeUnits
        {
            get { return this._gopSizeUnits; }
            set { this._gopSizeUnits = value; }
        }

        // Check to see if GopSizeUnits property is set
        internal bool IsSetGopSizeUnits()
        {
            return this._gopSizeUnits != null;
        }

        /// <summary>
        /// Gets and sets the property ScanType. Set the scan type of the output to PROGRESSIVE
        /// or INTERLACED (top field first).
        /// </summary>
        public Mpeg2ScanType ScanType
        {
            get { return this._scanType; }
            set { this._scanType = value; }
        }

        // Check to see if ScanType property is set
        internal bool IsSetScanType()
        {
            return this._scanType != null;
        }

        /// <summary>
        /// Gets and sets the property SubgopLength. Relates to the GOP structure. If you do not
        /// know what GOP is, use the default.FIXED: Set the number of B-frames in each sub-GOP
        /// to the value in gopNumBFrames.DYNAMIC: Let MediaLive optimize the number of B-frames
        /// in each sub-GOP, to improve visual quality.
        /// </summary>
        public Mpeg2SubGopLength SubgopLength
        {
            get { return this._subgopLength; }
            set { this._subgopLength = value; }
        }

        // Check to see if SubgopLength property is set
        internal bool IsSetSubgopLength()
        {
            return this._subgopLength != null;
        }

        /// <summary>
        /// Gets and sets the property TimecodeBurninSettings. Timecode burn-in settings
        /// </summary>
        public TimecodeBurninSettings TimecodeBurninSettings
        {
            get { return this._timecodeBurninSettings; }
            set { this._timecodeBurninSettings = value; }
        }

        // Check to see if TimecodeBurninSettings property is set
        internal bool IsSetTimecodeBurninSettings()
        {
            return this._timecodeBurninSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TimecodeInsertion. Determines how MediaLive inserts timecodes
        /// in the output video. For detailed information about setting up the input and the output
        /// for a timecode, see the section on \"MediaLive Features - Timecode configuration\"
        /// in the MediaLive User Guide.DISABLED: do not include timecodes.GOP_TIMECODE: Include
        /// timecode metadata in the GOP header.
        /// </summary>
        public Mpeg2TimecodeInsertionBehavior TimecodeInsertion
        {
            get { return this._timecodeInsertion; }
            set { this._timecodeInsertion = value; }
        }

        // Check to see if TimecodeInsertion property is set
        internal bool IsSetTimecodeInsertion()
        {
            return this._timecodeInsertion != null;
        }

    }
}