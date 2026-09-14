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
    /// Required when you set Codec to the value MPEG2.
    /// </summary>
    public partial class Mpeg2Settings
    {
        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Specify the strength of any adaptive
        /// quantization filters that you enable. The value that you choose here applies to the
        /// following settings: Spatial adaptive quantization, and Temporal adaptive quantization.
        /// </summary>
        public Mpeg2AdaptiveQuantization AdaptiveQuantization { get; set; }

        /// <summary>
        /// Checks to see if the AdaptiveQuantization property is set.
        /// </summary>
        internal bool IsSetAdaptiveQuantization() => this.AdaptiveQuantization != null;

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// Required for VBR and CBR. For MS Smooth outputs, bitrates must be unique when rounded
        /// down to the nearest multiple of 1000.
        /// </summary>
        [AWSProperty(Min = 1000, Max = 288000000)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property CodecLevel. Use Level to set the MPEG-2 level for the video
        /// output.
        /// </summary>
        public Mpeg2CodecLevel CodecLevel { get; set; }

        /// <summary>
        /// Checks to see if the CodecLevel property is set.
        /// </summary>
        internal bool IsSetCodecLevel() => this.CodecLevel != null;

        /// <summary>
        /// Gets and sets the property CodecProfile. Use Profile to set the MPEG-2 profile for
        /// the video output.
        /// </summary>
        public Mpeg2CodecProfile CodecProfile { get; set; }

        /// <summary>
        /// Checks to see if the CodecProfile property is set.
        /// </summary>
        internal bool IsSetCodecProfile() => this.CodecProfile != null;

        /// <summary>
        /// Gets and sets the property DynamicSubGop. Choose Adaptive to improve subjective video
        /// quality for high-motion content. This will cause the service to use fewer B-frames
        /// (which infer information based on other frames) for high-motion portions of the video
        /// and more B-frames for low-motion portions. The maximum number of B-frames is limited
        /// by the value you provide for the setting B frames between reference frames.
        /// </summary>
        public Mpeg2DynamicSubGop DynamicSubGop { get; set; }

        /// <summary>
        /// Checks to see if the DynamicSubGop property is set.
        /// </summary>
        internal bool IsSetDynamicSubGop() => this.DynamicSubGop != null;

        /// <summary>
        /// Gets and sets the property FramerateControl. If you are using the console, use the
        /// Framerate setting to specify the frame rate for this output. If you want to keep the
        /// same frame rate as the input video, choose Follow source. If you want to do frame
        /// rate conversion, choose a frame rate from the dropdown list or choose Custom. The
        /// framerates shown in the dropdown list are decimal approximations of fractions. If
        /// you choose Custom, specify your frame rate as a fraction.
        /// </summary>
        public Mpeg2FramerateControl FramerateControl { get; set; }

        /// <summary>
        /// Checks to see if the FramerateControl property is set.
        /// </summary>
        internal bool IsSetFramerateControl() => this.FramerateControl != null;

        /// <summary>
        /// Gets and sets the property FramerateConversionAlgorithm. Choose the method that you
        /// want MediaConvert to use when increasing or decreasing your video's frame rate. For
        /// numerically simple conversions, such as 60 fps to 30 fps: We recommend that you keep
        /// the default value, Drop duplicate. For numerically complex conversions, to avoid stutter:
        /// Choose Interpolate. This results in a smooth picture, but might introduce undesirable
        /// video artifacts. For complex frame rate conversions, especially if your source video
        /// has already been converted from its original cadence: Choose FrameFormer to do motion-compensated
        /// interpolation. FrameFormer uses the best conversion method frame by frame. Note that
        /// using FrameFormer increases the transcoding time and incurs a significant add-on cost.
        /// When you choose FrameFormer, your input video resolution must be at least 128x96.
        /// To create an output with the same number of frames as your input: Choose Maintain
        /// frame count. When you do, MediaConvert will not drop, interpolate, add, or otherwise
        /// change the frame count from your input to your output. Note that since the frame count
        /// is maintained, the duration of your output will become shorter at higher frame rates
        /// and longer at lower frame rates.
        /// </summary>
        public Mpeg2FramerateConversionAlgorithm FramerateConversionAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the FramerateConversionAlgorithm property is set.
        /// </summary>
        internal bool IsSetFramerateConversionAlgorithm() => this.FramerateConversionAlgorithm != null;

        /// <summary>
        /// Gets and sets the property FramerateDenominator. When you use the API for transcode
        /// jobs that use frame rate conversion, specify the frame rate as a fraction. For example,
        /// 24000 / 1001 = 23.976 fps. Use FramerateDenominator to specify the denominator of
        /// this fraction. In this example, use 1001 for the value of FramerateDenominator. When
        /// you use the console for transcode jobs that use frame rate conversion, provide the
        /// value as a decimal number for Framerate. In this example, specify 23.976.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1001)]
        public int? FramerateDenominator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateDenominator property is set.
        /// </summary>
        internal bool IsSetFramerateDenominator() => this.FramerateDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property FramerateNumerator. When you use the API for transcode
        /// jobs that use frame rate conversion, specify the frame rate as a fraction. For example,
        /// 24000 / 1001 = 23.976 fps. Use FramerateNumerator to specify the numerator of this
        /// fraction. In this example, use 24000 for the value of FramerateNumerator. When you
        /// use the console for transcode jobs that use frame rate conversion, provide the value
        /// as a decimal number for Framerate. In this example, specify 23.976.
        /// </summary>
        [AWSProperty(Min = 24, Max = 60000)]
        public int? FramerateNumerator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateNumerator property is set.
        /// </summary>
        internal bool IsSetFramerateNumerator() => this.FramerateNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property GopClosedCadence. Specify the relative frequency of open
        /// to closed GOPs in this output. For example, if you want to allow four open GOPs and
        /// then require a closed GOP, set this value to 5. When you create a streaming output,
        /// we recommend that you keep the default value, 1, so that players starting mid-stream
        /// receive an IDR frame as quickly as possible. Don't set this value to 0; that would
        /// break output segmenting.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? GopClosedCadence { get; set; }

        /// <summary>
        /// Checks to see if the GopClosedCadence property is set.
        /// </summary>
        internal bool IsSetGopClosedCadence() => this.GopClosedCadence.HasValue;

        /// <summary>
        /// Gets and sets the property GopSize. Specify the interval between keyframes, in seconds
        /// or frames, for this output. Default: 12 Related settings: When you specify the GOP
        /// size in seconds, set GOP mode control to Specified, seconds. The default value for
        /// GOP mode control is Frames.
        /// </summary>
        public double? GopSize { get; set; }

        /// <summary>
        /// Checks to see if the GopSize property is set.
        /// </summary>
        internal bool IsSetGopSize() => this.GopSize.HasValue;

        /// <summary>
        /// Gets and sets the property GopSizeUnits. Specify the units for GOP size. If you don't
        /// specify a value here, by default the encoder measures GOP size in frames.
        /// </summary>
        public Mpeg2GopSizeUnits GopSizeUnits { get; set; }

        /// <summary>
        /// Checks to see if the GopSizeUnits property is set.
        /// </summary>
        internal bool IsSetGopSizeUnits() => this.GopSizeUnits != null;

        /// <summary>
        /// Gets and sets the property HrdBufferFinalFillPercentage. If your downstream systems
        /// have strict buffer requirements: Specify the minimum percentage of the HRD buffer
        /// that's available at the end of each encoded video segment. For the best video quality:
        /// Set to 0 or leave blank to automatically determine the final buffer fill percentage.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? HrdBufferFinalFillPercentage { get; set; }

        /// <summary>
        /// Checks to see if the HrdBufferFinalFillPercentage property is set.
        /// </summary>
        internal bool IsSetHrdBufferFinalFillPercentage() => this.HrdBufferFinalFillPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property HrdBufferInitialFillPercentage. Percentage of the buffer
        /// that should initially be filled (HRD buffer model).
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? HrdBufferInitialFillPercentage { get; set; }

        /// <summary>
        /// Checks to see if the HrdBufferInitialFillPercentage property is set.
        /// </summary>
        internal bool IsSetHrdBufferInitialFillPercentage() => this.HrdBufferInitialFillPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property HrdBufferSize. Size of buffer (HRD buffer model) in bits.
        /// For example, enter five megabits as 5000000.
        /// </summary>
        [AWSProperty(Min = 0, Max = 47185920)]
        public int? HrdBufferSize { get; set; }

        /// <summary>
        /// Checks to see if the HrdBufferSize property is set.
        /// </summary>
        internal bool IsSetHrdBufferSize() => this.HrdBufferSize.HasValue;

        /// <summary>
        /// Gets and sets the property InterlaceMode. Choose the scan line type for the output.
        /// Keep the default value, Progressive to create a progressive output, regardless of
        /// the scan type of your input. Use Top field first or Bottom field first to create an
        /// output that's interlaced with the same field polarity throughout. Use Follow, default
        /// top or Follow, default bottom to produce outputs with the same field polarity as the
        /// source. For jobs that have multiple inputs, the output field polarity might change
        /// over the course of the output. Follow behavior depends on the input scan type. If
        /// the source is interlaced, the output will be interlaced with the same polarity as
        /// the source. If the source is progressive, the output will be interlaced with top field
        /// bottom field first, depending on which of the Follow options you choose.
        /// </summary>
        public Mpeg2InterlaceMode InterlaceMode { get; set; }

        /// <summary>
        /// Checks to see if the InterlaceMode property is set.
        /// </summary>
        internal bool IsSetInterlaceMode() => this.InterlaceMode != null;

        /// <summary>
        /// Gets and sets the property IntraDcPrecision. Use Intra DC precision to set quantization
        /// precision for intra-block DC coefficients. If you choose the value auto, the service
        /// will automatically select the precision based on the per-frame compression ratio.
        /// </summary>
        public Mpeg2IntraDcPrecision IntraDcPrecision { get; set; }

        /// <summary>
        /// Checks to see if the IntraDcPrecision property is set.
        /// </summary>
        internal bool IsSetIntraDcPrecision() => this.IntraDcPrecision != null;

        /// <summary>
        /// Gets and sets the property MaxBitrate. Maximum bitrate in bits/second. For example,
        /// enter five megabits per second as 5000000.
        /// </summary>
        [AWSProperty(Min = 1000, Max = 300000000)]
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaxBitrate property is set.
        /// </summary>
        internal bool IsSetMaxBitrate() => this.MaxBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property MinIInterval. Specify the minimum number of frames allowed
        /// between two IDR-frames in your output. This includes frames created at the start of
        /// a GOP or a scene change. Use Min I-Interval to improve video compression by varying
        /// GOP size when two IDR-frames would be created near each other. For example, if a regular
        /// cadence-driven IDR-frame would fall within 5 frames of a scene-change IDR-frame, and
        /// you set Min I-interval to 5, then the encoder would only write an IDR-frame for the
        /// scene-change. In this way, one GOP is shortened or extended. If a cadence-driven IDR-frame
        /// would be further than 5 frames from a scene-change IDR-frame, then the encoder leaves
        /// all IDR-frames in place. To manually specify an interval: Enter a value from 1 to
        /// 30. Use when your downstream systems have specific GOP size requirements. To disable
        /// GOP size variance: Enter 0. MediaConvert will only create IDR-frames at the start
        /// of your output's cadence-driven GOP. Use when your downstream systems require a regular
        /// GOP size.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public int? MinIInterval { get; set; }

        /// <summary>
        /// Checks to see if the MinIInterval property is set.
        /// </summary>
        internal bool IsSetMinIInterval() => this.MinIInterval.HasValue;

        /// <summary>
        /// Gets and sets the property NumberBFramesBetweenReferenceFrames. Specify the number
        /// of B-frames that MediaConvert puts between reference frames in this output. Valid
        /// values are whole numbers from 0 through 7. When you don't specify a value, MediaConvert
        /// defaults to 2.
        /// </summary>
        [AWSProperty(Min = 0, Max = 7)]
        public int? NumberBFramesBetweenReferenceFrames { get; set; }

        /// <summary>
        /// Checks to see if the NumberBFramesBetweenReferenceFrames property is set.
        /// </summary>
        internal bool IsSetNumberBFramesBetweenReferenceFrames() => this.NumberBFramesBetweenReferenceFrames.HasValue;

        /// <summary>
        /// Gets and sets the property ParControl. Optional. Specify how the service determines
        /// the pixel aspect ratio (PAR) for this output. The default behavior, Follow source,
        /// uses the PAR from your input video for your output. To specify a different PAR in
        /// the console, choose any value other than Follow source. When you choose SPECIFIED
        /// for this setting, you must also specify values for the parNumerator and parDenominator
        /// settings.
        /// </summary>
        public Mpeg2ParControl ParControl { get; set; }

        /// <summary>
        /// Checks to see if the ParControl property is set.
        /// </summary>
        internal bool IsSetParControl() => this.ParControl != null;

        /// <summary>
        /// Gets and sets the property ParDenominator. Required when you set Pixel aspect ratio
        /// to SPECIFIED. On the console, this corresponds to any value other than Follow source.
        /// When you specify an output pixel aspect ratio (PAR) that is different from your input
        /// video PAR, provide your output PAR as a ratio. For example, for D1/DV NTSC widescreen,
        /// you would specify the ratio 40:33. In this example, the value for parDenominator is
        /// 33.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? ParDenominator { get; set; }

        /// <summary>
        /// Checks to see if the ParDenominator property is set.
        /// </summary>
        internal bool IsSetParDenominator() => this.ParDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property ParNumerator. Required when you set Pixel aspect ratio
        /// to SPECIFIED. On the console, this corresponds to any value other than Follow source.
        /// When you specify an output pixel aspect ratio (PAR) that is different from your input
        /// video PAR, provide your output PAR as a ratio. For example, for D1/DV NTSC widescreen,
        /// you would specify the ratio 40:33. In this example, the value for parNumerator is
        /// 40.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? ParNumerator { get; set; }

        /// <summary>
        /// Checks to see if the ParNumerator property is set.
        /// </summary>
        internal bool IsSetParNumerator() => this.ParNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property PerFrameMetrics. Optionally choose one or more per frame
        /// metric reports to generate along with your output. You can use these metrics to analyze
        /// your video output according to one or more commonly used image quality metrics. You
        /// can specify per frame metrics for output groups or for individual outputs. When you
        /// do, MediaConvert writes a CSV (Comma-Separated Values) file to your S3 output destination,
        /// named after the output name and metric type. For example: videofile_PSNR.csv Jobs
        /// that generate per frame metrics will take longer to complete, depending on the resolution
        /// and complexity of your output. For example, some 4K jobs might take up to twice as
        /// long to complete. Note that when analyzing the video quality of your output, or when
        /// comparing the video quality of multiple different outputs, we generally also recommend
        /// a detailed visual review in a controlled environment. You can choose from the following
        /// per frame metrics: * PSNR: Peak Signal-to-Noise Ratio * SSIM: Structural Similarity
        /// Index Measure * MS_SSIM: Multi-Scale Similarity Index Measure * PSNR_HVS: Peak Signal-to-Noise
        /// Ratio, Human Visual System * VMAF: Video Multi-Method Assessment Fusion * QVBR: Quality-Defined
        /// Variable Bitrate. This option is only available when your output uses the QVBR rate
        /// control mode. * SHOT_CHANGE: Shot Changes
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PerFrameMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PerFrameMetrics property is set.
        /// </summary>
        internal bool IsSetPerFrameMetrics() => this.PerFrameMetrics != null && (this.PerFrameMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QualityTuningLevel. Optional. Use Quality tuning level
        /// to choose how you want to trade off encoding speed for output video quality. The default
        /// behavior is faster, lower quality, single-pass encoding.
        /// </summary>
        public Mpeg2QualityTuningLevel QualityTuningLevel { get; set; }

        /// <summary>
        /// Checks to see if the QualityTuningLevel property is set.
        /// </summary>
        internal bool IsSetQualityTuningLevel() => this.QualityTuningLevel != null;

        /// <summary>
        /// Gets and sets the property RateControlMode. Use Rate control mode to specify whether
        /// the bitrate is variable (vbr) or constant (cbr).
        /// </summary>
        public Mpeg2RateControlMode RateControlMode { get; set; }

        /// <summary>
        /// Checks to see if the RateControlMode property is set.
        /// </summary>
        internal bool IsSetRateControlMode() => this.RateControlMode != null;

        /// <summary>
        /// Gets and sets the property ScanTypeConversionMode. Use this setting for interlaced
        /// outputs, when your output frame rate is half of your input frame rate. In this situation,
        /// choose Optimized interlacing to create a better quality interlaced output. In this
        /// case, each progressive frame from the input corresponds to an interlaced field in
        /// the output. Keep the default value, Basic interlacing, for all other output frame
        /// rates. With basic interlacing, MediaConvert performs any frame rate conversion first
        /// and then interlaces the frames. When you choose Optimized interlacing and you set
        /// your output frame rate to a value that isn't suitable for optimized interlacing, MediaConvert
        /// automatically falls back to basic interlacing. Required settings: To use optimized
        /// interlacing, you must set Telecine to None or Soft. You can't use optimized interlacing
        /// for hard telecine outputs. You must also set Interlace mode to a value other than
        /// Progressive.
        /// </summary>
        public Mpeg2ScanTypeConversionMode ScanTypeConversionMode { get; set; }

        /// <summary>
        /// Checks to see if the ScanTypeConversionMode property is set.
        /// </summary>
        internal bool IsSetScanTypeConversionMode() => this.ScanTypeConversionMode != null;

        /// <summary>
        /// Gets and sets the property SceneChangeDetect. Enable this setting to insert I-frames
        /// at scene changes that the service automatically detects. This improves video quality
        /// and is enabled by default.
        /// </summary>
        public Mpeg2SceneChangeDetect SceneChangeDetect { get; set; }

        /// <summary>
        /// Checks to see if the SceneChangeDetect property is set.
        /// </summary>
        internal bool IsSetSceneChangeDetect() => this.SceneChangeDetect != null;

        /// <summary>
        /// Gets and sets the property SlowPal. Ignore this setting unless your input frame rate
        /// is 23.976 or 24 frames per second (fps). Enable slow PAL to create a 25 fps output.
        /// When you enable slow PAL, MediaConvert relabels the video frames to 25 fps and resamples
        /// your audio to keep it synchronized with the video. Note that enabling this setting
        /// will slightly reduce the duration of your video. Required settings: You must also
        /// set Framerate to 25.
        /// </summary>
        public Mpeg2SlowPal SlowPal { get; set; }

        /// <summary>
        /// Checks to see if the SlowPal property is set.
        /// </summary>
        internal bool IsSetSlowPal() => this.SlowPal != null;

        /// <summary>
        /// Gets and sets the property Softness. Ignore this setting unless you need to comply
        /// with a specification that requires a specific value. If you don't have a specification
        /// requirement, we recommend that you adjust the softness of your output by using a lower
        /// value for the setting Sharpness or by enabling a noise reducer filter. The Softness
        /// setting specifies the quantization matrices that the encoder uses. Keep the default
        /// value, 0, to use the AWS Elemental default matrices. Choose a value from 17 to 128
        /// to use planar interpolation. Increasing values from 17 to 128 result in increasing
        /// reduction of high-frequency data. The value 128 results in the softest video.
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public int? Softness { get; set; }

        /// <summary>
        /// Checks to see if the Softness property is set.
        /// </summary>
        internal bool IsSetSoftness() => this.Softness.HasValue;

        /// <summary>
        /// Gets and sets the property SpatialAdaptiveQuantization. Keep the default value, Enabled,
        /// to adjust quantization within each frame based on spatial variation of content complexity.
        /// When you enable this feature, the encoder uses fewer bits on areas that can sustain
        /// more distortion with no noticeable visual degradation and uses more bits on areas
        /// where any small distortion will be noticeable. For example, complex textured blocks
        /// are encoded with fewer bits and smooth textured blocks are encoded with more bits.
        /// Enabling this feature will almost always improve your video quality. Note, though,
        /// that this feature doesn't take into account where the viewer's attention is likely
        /// to be. If viewers are likely to be focusing their attention on a part of the screen
        /// with a lot of complex texture, you might choose to disable this feature. Related setting:
        /// When you enable spatial adaptive quantization, set the value for Adaptive quantization
        /// depending on your content. For homogeneous content, such as cartoons and video games,
        /// set it to Low. For content with a wider variety of textures, set it to High or Higher.
        /// </summary>
        public Mpeg2SpatialAdaptiveQuantization SpatialAdaptiveQuantization { get; set; }

        /// <summary>
        /// Checks to see if the SpatialAdaptiveQuantization property is set.
        /// </summary>
        internal bool IsSetSpatialAdaptiveQuantization() => this.SpatialAdaptiveQuantization != null;

        /// <summary>
        /// Gets and sets the property Syntax. Specify whether this output's video uses the D10
        /// syntax. Keep the default value to not use the syntax. Related settings: When you choose
        /// D10 for your MXF profile, you must also set this value to D10.
        /// </summary>
        public Mpeg2Syntax Syntax { get; set; }

        /// <summary>
        /// Checks to see if the Syntax property is set.
        /// </summary>
        internal bool IsSetSyntax() => this.Syntax != null;

        /// <summary>
        /// Gets and sets the property Telecine. When you do frame rate conversion from 23.976
        /// frames per second (fps) to 29.97 fps, and your output scan type is interlaced, you
        /// can optionally enable hard or soft telecine to create a smoother picture. Hard telecine
        /// produces a 29.97i output. Soft telecine produces an output with a 23.976 output that
        /// signals to the video player device to do the conversion during play back. When you
        /// keep the default value, None, MediaConvert does a standard frame rate conversion to
        /// 29.97 without doing anything with the field polarity to create a smoother picture.
        /// </summary>
        public Mpeg2Telecine Telecine { get; set; }

        /// <summary>
        /// Checks to see if the Telecine property is set.
        /// </summary>
        internal bool IsSetTelecine() => this.Telecine != null;

        /// <summary>
        /// Gets and sets the property TemporalAdaptiveQuantization. Keep the default value, Enabled,
        /// to adjust quantization within each frame based on temporal variation of content complexity.
        /// When you enable this feature, the encoder uses fewer bits on areas of the frame that
        /// aren't moving and uses more bits on complex objects with sharp edges that move a lot.
        /// For example, this feature improves the readability of text tickers on newscasts and
        /// scoreboards on sports matches. Enabling this feature will almost always improve your
        /// video quality. Note, though, that this feature doesn't take into account where the
        /// viewer's attention is likely to be. If viewers are likely to be focusing their attention
        /// on a part of the screen that doesn't have moving objects with sharp edges, such as
        /// sports athletes' faces, you might choose to disable this feature. Related setting:
        /// When you enable temporal quantization, adjust the strength of the filter with the
        /// setting Adaptive quantization.
        /// </summary>
        public Mpeg2TemporalAdaptiveQuantization TemporalAdaptiveQuantization { get; set; }

        /// <summary>
        /// Checks to see if the TemporalAdaptiveQuantization property is set.
        /// </summary>
        internal bool IsSetTemporalAdaptiveQuantization() => this.TemporalAdaptiveQuantization != null;
    }
}
