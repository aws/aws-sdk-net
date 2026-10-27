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
    /// Av1 Settings
    /// </summary>
    public partial class Av1Settings
    {
        /// <summary>
        /// Gets and sets the property AfdSignaling. Configures whether MediaLive will write AFD
        /// values into the video. AUTO: MediaLive will try to preserve the input AFD value (in
        /// cases where multiple AFD values are valid). FIXED: the AFD value will be the value
        /// configured in the fixedAfd parameter. NONE: MediaLive won't write AFD into the video
        /// </summary>
        public AfdSignaling AfdSignaling { get; set; }

        /// <summary>
        /// Checks to see if the AfdSignaling property is set.
        /// </summary>
        internal bool IsSetAfdSignaling() => this.AfdSignaling != null;

        /// <summary>
        /// Gets and sets the property BitDepth. Specifies the bit depth for the output encode.
        /// Choose a value. Or leave the field empty to use the default, which is 8 bit.
        /// </summary>
        public Av1BitDepth BitDepth { get; set; }

        /// <summary>
        /// Checks to see if the BitDepth property is set.
        /// </summary>
        internal bool IsSetBitDepth() => this.BitDepth != null;

        /// <summary>
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Required when
        /// the rate control mode is CBR. Not used for QVBR.
        /// </summary>
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property BufSize. The size of the buffer (HRD buffer model) in bits.
        /// </summary>
        public int? BufSize { get; set; }

        /// <summary>
        /// Checks to see if the BufSize property is set.
        /// </summary>
        internal bool IsSetBufSize() => this.BufSize.HasValue;

        /// <summary>
        /// Gets and sets the property ColorSpaceSettings. Specify the type of color space to
        /// apply or choose to pass through. The default is to pass through the color space that
        /// is in the source.
        /// </summary>
        public Av1ColorSpaceSettings ColorSpaceSettings { get; set; }

        /// <summary>
        /// Checks to see if the ColorSpaceSettings property is set.
        /// </summary>
        internal bool IsSetColorSpaceSettings() => this.ColorSpaceSettings != null;

        /// <summary>
        /// Gets and sets the property FilterSettings. Optional filters that you can apply to
        /// an encode.
        /// </summary>
        public Av1FilterSettings FilterSettings { get; set; }

        /// <summary>
        /// Checks to see if the FilterSettings property is set.
        /// </summary>
        internal bool IsSetFilterSettings() => this.FilterSettings != null;

        /// <summary>
        /// Gets and sets the property FixedAfd. Complete this property only if you set the afdSignaling
        /// property to FIXED. Choose the AFD value (4 bits) to write on all frames of the video
        /// encode.
        /// </summary>
        public FixedAfd FixedAfd { get; set; }

        /// <summary>
        /// Checks to see if the FixedAfd property is set.
        /// </summary>
        internal bool IsSetFixedAfd() => this.FixedAfd != null;

        /// <summary>
        /// Gets and sets the property FramerateDenominator. The denominator for the framerate.
        /// Framerate is a fraction, for example, 24000 / 1001.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? FramerateDenominator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateDenominator property is set.
        /// </summary>
        internal bool IsSetFramerateDenominator() => this.FramerateDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property FramerateNumerator. The numerator for the framerate. Framerate
        /// is a fraction, for example, 24000 / 1001.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? FramerateNumerator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateNumerator property is set.
        /// </summary>
        internal bool IsSetFramerateNumerator() => this.FramerateNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property GopSize. The GOP size (keyframe interval). If GopSizeUnits
        /// is frames, GopSize must be a whole number and must be greater than or equal to 1.
        /// If GopSizeUnits is seconds, GopSize must be greater than 0, but it can be a decimal.
        /// </summary>
        public double? GopSize { get; set; }

        /// <summary>
        /// Checks to see if the GopSize property is set.
        /// </summary>
        internal bool IsSetGopSize() => this.GopSize.HasValue;

        /// <summary>
        /// Gets and sets the property GopSizeUnits. Choose the units for the GOP size: FRAMES
        /// or SECONDS. For SECONDS, MediaLive converts the size into a frame count at run time.
        /// </summary>
        public Av1GopSizeUnits GopSizeUnits { get; set; }

        /// <summary>
        /// Checks to see if the GopSizeUnits property is set.
        /// </summary>
        internal bool IsSetGopSizeUnits() => this.GopSizeUnits != null;

        /// <summary>
        /// Gets and sets the property Level. Sets the level. This parameter is one of the properties
        /// of the encoding scheme for AV1.
        /// </summary>
        public Av1Level Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

        /// <summary>
        /// Gets and sets the property LookAheadRateControl. Sets the amount of lookahead. A value
        /// of LOW can decrease latency and memory usage. A value of HIGH can produce better quality
        /// for certain content.
        /// </summary>
        public Av1LookAheadRateControl LookAheadRateControl { get; set; }

        /// <summary>
        /// Checks to see if the LookAheadRateControl property is set.
        /// </summary>
        internal bool IsSetLookAheadRateControl() => this.LookAheadRateControl != null;

        /// <summary>
        /// Gets and sets the property MaxBitrate. The maximum bitrate to assign. For recommendations,
        /// see the description for qvbrQualityLevel.
        /// </summary>
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaxBitrate property is set.
        /// </summary>
        internal bool IsSetMaxBitrate() => this.MaxBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property MinBitrate. Used for QVBR rate control mode only. Optional.
        /// Enter a minimum bitrate if you want to keep the output bitrate about a threshold,
        /// in order to prevent the downstream system from de-allocating network bandwidth for
        /// this output.
        /// </summary>
        public int? MinBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MinBitrate property is set.
        /// </summary>
        internal bool IsSetMinBitrate() => this.MinBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property MinIInterval. Applies only if you enable SceneChangeDetect.
        /// Sets the interval between frames. This property ensures a minimum separation between
        /// repeated (cadence) I-frames and any I-frames inserted by scene change detection (SCD
        /// frames). Enter a number for the interval, measured in number of frames. If an SCD
        /// frame and a cadence frame are closer than the specified number of frames, MediaLive
        /// shrinks or stretches the GOP to include the SCD frame. Then normal cadence resumes
        /// in the next GOP. For GOP stretch to succeed, you must enable LookAheadRateControl.
        /// Note that the maximum GOP stretch = (GOP size) + (Minimum I-interval) - 1
        /// </summary>
        public int? MinIInterval { get; set; }

        /// <summary>
        /// Checks to see if the MinIInterval property is set.
        /// </summary>
        internal bool IsSetMinIInterval() => this.MinIInterval.HasValue;

        /// <summary>
        /// Gets and sets the property ParDenominator. The denominator for the output pixel aspect
        /// ratio (PAR).
        /// </summary>
        public int? ParDenominator { get; set; }

        /// <summary>
        /// Checks to see if the ParDenominator property is set.
        /// </summary>
        internal bool IsSetParDenominator() => this.ParDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property ParNumerator. The numerator for the output pixel aspect
        /// ratio (PAR).
        /// </summary>
        public int? ParNumerator { get; set; }

        /// <summary>
        /// Checks to see if the ParNumerator property is set.
        /// </summary>
        internal bool IsSetParNumerator() => this.ParNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property QvbrQualityLevel. Controls the target quality for the video
        /// encode. With QVBR rate control mode, the final quality is the target quality, constrained
        /// by the maxBitrate. Set values for the qvbrQualityLevel property and maxBitrate property
        /// that suit your most important viewing devices. To let MediaLive set the quality level
        /// (AUTO mode), leave the qvbrQualityLevel field empty. In this case, MediaLive uses
        /// the maximum bitrate, and the quality follows from that: more complex content might
        /// have a lower quality. Or set a target quality level and a maximum bitrate. With more
        /// complex content, MediaLive will try to achieve the target quality, but it won't exceed
        /// the maximum bitrate. With less complex content, This option will use only the bitrate
        /// needed to reach the target quality. Recommended values are: Primary screen: qvbrQualityLevel:
        /// Leave empty. maxBitrate: 4,000,000 PC or tablet: qvbrQualityLevel: Leave empty. maxBitrate:
        /// 1,500,000 to 3,000,000 Smartphone: qvbrQualityLevel: Leave empty. maxBitrate: 1,000,000
        /// to 1,500,000
        /// </summary>
        public int? QvbrQualityLevel { get; set; }

        /// <summary>
        /// Checks to see if the QvbrQualityLevel property is set.
        /// </summary>
        internal bool IsSetQvbrQualityLevel() => this.QvbrQualityLevel.HasValue;

        /// <summary>
        /// Gets and sets the property RateControlMode. Rate control mode. QVBR: Quality will
        /// match the specified quality level except when it is constrained by the maximum bitrate.
        /// Recommended if you or your viewers pay for bandwidth. CBR: Quality varies, depending
        /// on the video complexity. Recommended only if you distribute your assets to devices
        /// that cannot handle variable bitrates.
        /// </summary>
        public Av1RateControlMode RateControlMode { get; set; }

        /// <summary>
        /// Checks to see if the RateControlMode property is set.
        /// </summary>
        internal bool IsSetRateControlMode() => this.RateControlMode != null;

        /// <summary>
        /// Gets and sets the property SceneChangeDetect. Controls whether MediaLive inserts I-frames
        /// when it detects a scene change. ENABLED or DISABLED.
        /// </summary>
        public Av1SceneChangeDetect SceneChangeDetect { get; set; }

        /// <summary>
        /// Checks to see if the SceneChangeDetect property is set.
        /// </summary>
        internal bool IsSetSceneChangeDetect() => this.SceneChangeDetect != null;

        /// <summary>
        /// Gets and sets the property SpatialAq. Spatial AQ makes adjustments within each frame
        /// based on spatial variation of content complexity. Enabled: MediaLive will determine
        /// the appropriate level of spatial AQ to apply. Disabled: No spatial AQ. For more information,
        /// see the topic about video adaptive quantization in the MediaLive user guide.
        /// </summary>
        public Av1SpatialAq SpatialAq { get; set; }

        /// <summary>
        /// Checks to see if the SpatialAq property is set.
        /// </summary>
        internal bool IsSetSpatialAq() => this.SpatialAq != null;

        /// <summary>
        /// Gets and sets the property TemporalAq. Temporal AQ makes adjustments within each frame
        /// based on variations in content complexity over time. Enabled: MediaLive will determine
        /// the appropriate level of temporal AQ to apply. Disabled: No temporal AQ. For more
        /// information, see the topic about video adaptive quantization in the MediaLive user
        /// guide.
        /// </summary>
        public Av1TemporalAq TemporalAq { get; set; }

        /// <summary>
        /// Checks to see if the TemporalAq property is set.
        /// </summary>
        internal bool IsSetTemporalAq() => this.TemporalAq != null;

        /// <summary>
        /// Gets and sets the property TimecodeBurninSettings. Configures the timecode burn-in
        /// feature. If you enable this feature, the timecode will become part of the video.
        /// </summary>
        public TimecodeBurninSettings TimecodeBurninSettings { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeBurninSettings property is set.
        /// </summary>
        internal bool IsSetTimecodeBurninSettings() => this.TimecodeBurninSettings != null;

        /// <summary>
        /// Gets and sets the property TimecodeInsertion. Controls how MediaLive inserts timecodes
        /// into the video output encode. DISABLED: Do not insert timecodes. METADATA_OBU: Include
        /// timecodes. MediaLive inserts timecode metadata based on the timecode from the source
        /// specified in the Timecode Config property. The timecode metadata is a metadata OBU
        /// (Open Bitstream Unit) of type METADATA_TYPE_TIMECODE, in accordance with https://aomediacodec.github.io/av1-spec/#metadata-timecode-syntax.
        /// </summary>
        public Av1TimecodeInsertionBehavior TimecodeInsertion { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeInsertion property is set.
        /// </summary>
        internal bool IsSetTimecodeInsertion() => this.TimecodeInsertion != null;
    }
}
