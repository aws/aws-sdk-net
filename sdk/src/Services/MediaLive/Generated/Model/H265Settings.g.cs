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
    /// H265 Settings
    /// </summary>
    public partial class H265Settings
    {
        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Enables or disables adaptive quantization
        /// (AQ), which is a technique MediaLive can apply to video on a frame-by-frame basis
        /// to produce more compression without losing quality. There are three types of adaptive
        /// quantization: spatial, temporal, and flicker. Flicker is the only type that you can
        /// customize. We recommend that you set the field to Auto. For more information about
        /// all the options, see the topic about video adaptive quantization in the MediaLive
        /// user guide.
        /// </summary>
        public H265AdaptiveQuantization AdaptiveQuantization { get; set; }

        /// <summary>
        /// Checks to see if the AdaptiveQuantization property is set.
        /// </summary>
        internal bool IsSetAdaptiveQuantization() => this.AdaptiveQuantization != null;

        /// <summary>
        /// Gets and sets the property AfdSignaling. Indicates that AFD values will be written
        /// into the output stream. If afdSignaling is "auto", the system will try to preserve
        /// the input AFD value (in cases where multiple AFD values are valid). If set to "fixed",
        /// the AFD value will be the value configured in the fixedAfd parameter.
        /// </summary>
        public AfdSignaling AfdSignaling { get; set; }

        /// <summary>
        /// Checks to see if the AfdSignaling property is set.
        /// </summary>
        internal bool IsSetAfdSignaling() => this.AfdSignaling != null;

        /// <summary>
        /// Gets and sets the property AlternativeTransferFunction. Whether or not EML should
        /// insert an Alternative Transfer Function SEI message to support backwards compatibility
        /// with non-HDR decoders and displays.
        /// </summary>
        public H265AlternativeTransferFunction AlternativeTransferFunction { get; set; }

        /// <summary>
        /// Checks to see if the AlternativeTransferFunction property is set.
        /// </summary>
        internal bool IsSetAlternativeTransferFunction() => this.AlternativeTransferFunction != null;

        /// <summary>
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Required when
        /// the rate control mode is VBR or CBR. Not used for QVBR. In an MS Smooth output group,
        /// each output must have a unique value when its bitrate is rounded down to the nearest
        /// multiple of 1000.
        /// </summary>
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property BufSize. Size of buffer (HRD buffer model) in bits.
        /// </summary>
        public int? BufSize { get; set; }

        /// <summary>
        /// Checks to see if the BufSize property is set.
        /// </summary>
        internal bool IsSetBufSize() => this.BufSize.HasValue;

        /// <summary>
        /// Gets and sets the property ColorMetadata. Includes colorspace metadata in the output.
        /// </summary>
        public H265ColorMetadata ColorMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ColorMetadata property is set.
        /// </summary>
        internal bool IsSetColorMetadata() => this.ColorMetadata != null;

        /// <summary>
        /// Gets and sets the property ColorSpaceSettings. Specify the type of color space to
        /// apply or choose to pass through. The default is to pass through the color space that
        /// is in the source.
        /// </summary>
        public H265ColorSpaceSettings ColorSpaceSettings { get; set; }

        /// <summary>
        /// Checks to see if the ColorSpaceSettings property is set.
        /// </summary>
        internal bool IsSetColorSpaceSettings() => this.ColorSpaceSettings != null;

        /// <summary>
        /// Gets and sets the property Deblocking. Enable or disable the deblocking filter for
        /// this codec. The filter reduces blocking artifacts at block boundaries, which improves
        /// overall video quality. If the filter is disabled, visible block edges might appear
        /// in the output, especially at lower bitrates.
        /// </summary>
        public H265Deblocking Deblocking { get; set; }

        /// <summary>
        /// Checks to see if the Deblocking property is set.
        /// </summary>
        internal bool IsSetDeblocking() => this.Deblocking != null;

        /// <summary>
        /// Gets and sets the property FilterSettings. Optional. Both filters reduce bandwidth
        /// by removing imperceptible details. You can enable one of the filters. We recommend
        /// that you try both filters and observe the results to decide which one to use. The
        /// Temporal Filter reduces bandwidth by removing imperceptible details in the content.
        /// It combines perceptual filtering and motion compensated temporal filtering (MCTF).
        /// It operates independently of the compression level. The Bandwidth Reduction filter
        /// is a perceptual filter located within the encoding loop. It adapts to the current
        /// compression level to filter imperceptible signals. This filter works only when the
        /// resolution is 1080p or lower.
        /// </summary>
        public H265FilterSettings FilterSettings { get; set; }

        /// <summary>
        /// Checks to see if the FilterSettings property is set.
        /// </summary>
        internal bool IsSetFilterSettings() => this.FilterSettings != null;

        /// <summary>
        /// Gets and sets the property FixedAfd. Four bit AFD value to write on all frames of
        /// video in the output stream. Only valid when afdSignaling is set to 'Fixed'.
        /// </summary>
        public FixedAfd FixedAfd { get; set; }

        /// <summary>
        /// Checks to see if the FixedAfd property is set.
        /// </summary>
        internal bool IsSetFixedAfd() => this.FixedAfd != null;

        /// <summary>
        /// Gets and sets the property FlickerAq. Flicker AQ makes adjustments within each frame
        /// to reduce flicker or 'pop' on I-frames. The value to enter in this field depends on
        /// the value in the Adaptive quantization field. For more information, see the topic
        /// about video adaptive quantization in the MediaLive user guide.
        /// </summary>
        public H265FlickerAq FlickerAq { get; set; }

        /// <summary>
        /// Checks to see if the FlickerAq property is set.
        /// </summary>
        internal bool IsSetFlickerAq() => this.FlickerAq != null;

        /// <summary>
        /// Gets and sets the property FramerateDenominator. Framerate denominator.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? FramerateDenominator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateDenominator property is set.
        /// </summary>
        internal bool IsSetFramerateDenominator() => this.FramerateDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property FramerateNumerator. Framerate numerator - framerate is
        /// a fraction, e.g. 24000 / 1001 = 23.976 fps.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? FramerateNumerator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateNumerator property is set.
        /// </summary>
        internal bool IsSetFramerateNumerator() => this.FramerateNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property GopBReference. Allows the encoder to use a B-Frame as a
        /// reference frame as well. ENABLED: B-frames will also serve as reference frames. DISABLED:
        /// B-frames won't be reference frames. Must be DISABLED if resolution is greater than
        /// 1080p or when using tiled hevc encoding.
        /// </summary>
        public H265GopBReference GopBReference { get; set; }

        /// <summary>
        /// Checks to see if the GopBReference property is set.
        /// </summary>
        internal bool IsSetGopBReference() => this.GopBReference != null;

        /// <summary>
        /// Gets and sets the property GopClosedCadence. Frequency of closed GOPs. In streaming
        /// applications, it is recommended that this be set to 1 so a decoder joining mid-stream
        /// will receive an IDR frame as quickly as possible. Setting this value to 0 will break
        /// output segmenting.
        /// </summary>
        public int? GopClosedCadence { get; set; }

        /// <summary>
        /// Checks to see if the GopClosedCadence property is set.
        /// </summary>
        internal bool IsSetGopClosedCadence() => this.GopClosedCadence.HasValue;

        /// <summary>
        /// Gets and sets the property GopNumBFrames. Sets the number of B-frames between reference
        /// frames. Set to 2 if resolution is greater than 1080p or when using tiled hevc encoding.
        /// </summary>
        public int? GopNumBFrames { get; set; }

        /// <summary>
        /// Checks to see if the GopNumBFrames property is set.
        /// </summary>
        internal bool IsSetGopNumBFrames() => this.GopNumBFrames.HasValue;

        /// <summary>
        /// Gets and sets the property GopSize. GOP size (keyframe interval) in units of either
        /// frames or seconds per gopSizeUnits. If gopSizeUnits is frames, gopSize must be an
        /// integer and must be greater than or equal to 1. If gopSizeUnits is seconds, gopSize
        /// must be greater than 0, but need not be an integer.
        /// </summary>
        public double? GopSize { get; set; }

        /// <summary>
        /// Checks to see if the GopSize property is set.
        /// </summary>
        internal bool IsSetGopSize() => this.GopSize.HasValue;

        /// <summary>
        /// Gets and sets the property GopSizeUnits. Indicates if the gopSize is specified in
        /// frames or seconds. If seconds the system will convert the gopSize into a frame count
        /// at run time.
        /// </summary>
        public H265GopSizeUnits GopSizeUnits { get; set; }

        /// <summary>
        /// Checks to see if the GopSizeUnits property is set.
        /// </summary>
        internal bool IsSetGopSizeUnits() => this.GopSizeUnits != null;

        /// <summary>
        /// Gets and sets the property Level. H.265 Level.
        /// </summary>
        public H265Level Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

        /// <summary>
        /// Gets and sets the property LookAheadRateControl. Amount of lookahead. A value of low
        /// can decrease latency and memory usage, while high can produce better quality for certain
        /// content.
        /// </summary>
        public H265LookAheadRateControl LookAheadRateControl { get; set; }

        /// <summary>
        /// Checks to see if the LookAheadRateControl property is set.
        /// </summary>
        internal bool IsSetLookAheadRateControl() => this.LookAheadRateControl != null;

        /// <summary>
        /// Gets and sets the property MaxBitrate. For QVBR: See the tooltip for Quality level
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
        /// Gets and sets the property MinIInterval. Only meaningful if sceneChangeDetect is set
        /// to enabled. Defaults to 5 if multiplex rate control is used. Enforces separation between
        /// repeated (cadence) I-frames and I-frames inserted by Scene Change Detection. If a
        /// scene change I-frame is within I-interval frames of a cadence I-frame, the GOP is
        /// shrunk and/or stretched to the scene change I-frame. GOP stretch requires enabling
        /// lookahead as well as setting I-interval. The normal cadence resumes for the next GOP.
        /// Note: Maximum GOP stretch = GOP size + Min-I-interval - 1
        /// </summary>
        public int? MinIInterval { get; set; }

        /// <summary>
        /// Checks to see if the MinIInterval property is set.
        /// </summary>
        internal bool IsSetMinIInterval() => this.MinIInterval.HasValue;

        /// <summary>
        /// Gets and sets the property MinQp. Sets the minimum QP. If you aren't familiar with
        /// quantization adjustment, leave the field empty. MediaLive will apply an appropriate
        /// value.
        /// </summary>
        public int? MinQp { get; set; }

        /// <summary>
        /// Checks to see if the MinQp property is set.
        /// </summary>
        internal bool IsSetMinQp() => this.MinQp.HasValue;

        /// <summary>
        /// Gets and sets the property MvOverPictureBoundaries. If you are setting up the picture
        /// as a tile, you must set this to "disabled". In all other configurations, you typically
        /// enter "enabled".
        /// </summary>
        public H265MvOverPictureBoundaries MvOverPictureBoundaries { get; set; }

        /// <summary>
        /// Checks to see if the MvOverPictureBoundaries property is set.
        /// </summary>
        internal bool IsSetMvOverPictureBoundaries() => this.MvOverPictureBoundaries != null;

        /// <summary>
        /// Gets and sets the property MvTemporalPredictor. If you are setting up the picture
        /// as a tile, you must set this to "disabled". In other configurations, you typically
        /// enter "enabled".
        /// </summary>
        public H265MvTemporalPredictor MvTemporalPredictor { get; set; }

        /// <summary>
        /// Checks to see if the MvTemporalPredictor property is set.
        /// </summary>
        internal bool IsSetMvTemporalPredictor() => this.MvTemporalPredictor != null;

        /// <summary>
        /// Gets and sets the property ParDenominator. Pixel Aspect Ratio denominator.
        /// </summary>
        public int? ParDenominator { get; set; }

        /// <summary>
        /// Checks to see if the ParDenominator property is set.
        /// </summary>
        internal bool IsSetParDenominator() => this.ParDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property ParNumerator. Pixel Aspect Ratio numerator.
        /// </summary>
        public int? ParNumerator { get; set; }

        /// <summary>
        /// Checks to see if the ParNumerator property is set.
        /// </summary>
        internal bool IsSetParNumerator() => this.ParNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property Profile. H.265 Profile.
        /// </summary>
        public H265Profile Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;

        /// <summary>
        /// Gets and sets the property QvbrQualityLevel. Controls the target quality for the video
        /// encode. Applies only when the rate control mode is QVBR. Set values for the QVBR quality
        /// level field and Max bitrate field that suit your most important viewing devices. Recommended
        /// values are: - Primary screen: Quality level: 8 to 10. Max bitrate: 4M - PC or tablet:
        /// Quality level: 7. Max bitrate: 1.5M to 3M - Smartphone: Quality level: 6. Max bitrate:
        /// 1M to 1.5M
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
        /// that cannot handle variable bitrates. Multiplex: This rate control mode is only supported
        /// (and is required) when the video is being delivered to a MediaLive Multiplex in which
        /// case the rate control configuration is controlled by the properties within the Multiplex
        /// Program.
        /// </summary>
        public H265RateControlMode RateControlMode { get; set; }

        /// <summary>
        /// Checks to see if the RateControlMode property is set.
        /// </summary>
        internal bool IsSetRateControlMode() => this.RateControlMode != null;

        /// <summary>
        /// Gets and sets the property ScanType. Sets the scan type of the output to progressive
        /// or top-field-first interlaced.
        /// </summary>
        public H265ScanType ScanType { get; set; }

        /// <summary>
        /// Checks to see if the ScanType property is set.
        /// </summary>
        internal bool IsSetScanType() => this.ScanType != null;

        /// <summary>
        /// Gets and sets the property SceneChangeDetect. Scene change detection.
        /// </summary>
        public H265SceneChangeDetect SceneChangeDetect { get; set; }

        /// <summary>
        /// Checks to see if the SceneChangeDetect property is set.
        /// </summary>
        internal bool IsSetSceneChangeDetect() => this.SceneChangeDetect != null;

        /// <summary>
        /// Gets and sets the property Slices. Number of slices per picture. Must be less than
        /// or equal to the number of macroblock rows for progressive pictures, and less than
        /// or equal to half the number of macroblock rows for interlaced pictures. This field
        /// is optional; when no value is specified the encoder will choose the number of slices
        /// based on encode resolution.
        /// </summary>
        public int? Slices { get; set; }

        /// <summary>
        /// Checks to see if the Slices property is set.
        /// </summary>
        internal bool IsSetSlices() => this.Slices.HasValue;

        /// <summary>
        /// Gets and sets the property SubgopLength. Sets the number of B-frames in each sub-GOP.
        /// FIXED: Use the value in Num B-frames. DYNAMIC: Optimizes the number of B-frames in
        /// each sub-GOP to improve visual quality. Must be FIXED if resolution is greater than
        /// 1080p or when using tiled hevc encoding.
        /// </summary>
        public H265SubGopLength SubgopLength { get; set; }

        /// <summary>
        /// Checks to see if the SubgopLength property is set.
        /// </summary>
        internal bool IsSetSubgopLength() => this.SubgopLength != null;

        /// <summary>
        /// Gets and sets the property Tier. H.265 Tier.
        /// </summary>
        public H265Tier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property TileHeight. Set this field to set up the picture as a tile.
        /// You must also set tileWidth. The tile height must result in 22 or fewer rows in the
        /// frame. The tile width must result in 20 or fewer columns in the frame. And finally,
        /// the product of the column count and row count must be 64 of less. If the tile width
        /// and height are specified, MediaLive will override the video codec slices field with
        /// a value that MediaLive calculates
        /// </summary>
        public int? TileHeight { get; set; }

        /// <summary>
        /// Checks to see if the TileHeight property is set.
        /// </summary>
        internal bool IsSetTileHeight() => this.TileHeight.HasValue;

        /// <summary>
        /// Gets and sets the property TilePadding. Set to "padded" to force MediaLive to add
        /// padding to the frame, to obtain a frame that is a whole multiple of the tile size.
        /// If you are setting up the picture as a tile, you must enter "padded". In all other
        /// configurations, you typically enter "none".
        /// </summary>
        public H265TilePadding TilePadding { get; set; }

        /// <summary>
        /// Checks to see if the TilePadding property is set.
        /// </summary>
        internal bool IsSetTilePadding() => this.TilePadding != null;

        /// <summary>
        /// Gets and sets the property TileWidth. Set this field to set up the picture as a tile.
        /// See tileHeight for more information.
        /// </summary>
        public int? TileWidth { get; set; }

        /// <summary>
        /// Checks to see if the TileWidth property is set.
        /// </summary>
        internal bool IsSetTileWidth() => this.TileWidth.HasValue;

        /// <summary>
        /// Gets and sets the property TimecodeBurninSettings. Timecode burn-in settings
        /// </summary>
        public TimecodeBurninSettings TimecodeBurninSettings { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeBurninSettings property is set.
        /// </summary>
        internal bool IsSetTimecodeBurninSettings() => this.TimecodeBurninSettings != null;

        /// <summary>
        /// Gets and sets the property TimecodeInsertion. Determines how timecodes should be inserted
        /// into the video elementary stream. - 'disabled': Do not include timecodes - 'picTimingSei':
        /// Pass through picture timing SEI messages from the source specified in Timecode Config
        /// </summary>
        public H265TimecodeInsertionBehavior TimecodeInsertion { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeInsertion property is set.
        /// </summary>
        internal bool IsSetTimecodeInsertion() => this.TimecodeInsertion != null;

        /// <summary>
        /// Gets and sets the property TreeblockSize. Select the tree block size used for encoding.
        /// If you enter "auto", the encoder will pick the best size. If you are setting up the
        /// picture as a tile, you must set this to 32x32. In all other configurations, you typically
        /// enter "auto".
        /// </summary>
        public H265TreeblockSize TreeblockSize { get; set; }

        /// <summary>
        /// Checks to see if the TreeblockSize property is set.
        /// </summary>
        internal bool IsSetTreeblockSize() => this.TreeblockSize != null;
    }
}
