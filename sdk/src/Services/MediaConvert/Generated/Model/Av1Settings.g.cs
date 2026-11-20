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
    /// Required when you set Codec, under VideoDescription>CodecSettings to the value AV1.
    /// </summary>
    public partial class Av1Settings
    {
        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Specify whether MediaConvert applies
        /// adaptive quantization in this output. With AV1, adaptive quantization is on or off;
        /// there is no strength to choose. Choose Auto to let MediaConvert manage adaptive quantization
        /// for you. MediaConvert enables both Spatial adaptive quantization and Temporal adaptive
        /// quantization, and you can't specify either one yourself. To choose the filters yourself,
        /// set Adaptive quantization to any of the strength values, Low, Medium, High, Higher
        /// or Max, and then use the related settings Spatial adaptive quantization and Temporal
        /// adaptive quantization. With AV1 these strength values all behave the same, because
        /// AV1 adaptive quantization has no strength. If you don't want MediaConvert to do any
        /// adaptive quantization in this transcode, set Adaptive quantization to Off. Related
        /// settings: The value that you choose here applies to the following settings: Av1SpatialAdaptiveQuantization
        /// and Av1TemporalAdaptiveQuantization.
        /// </summary>
        public Av1AdaptiveQuantization AdaptiveQuantization { get; set; }

        /// <summary>
        /// Checks to see if the AdaptiveQuantization property is set.
        /// </summary>
        internal bool IsSetAdaptiveQuantization() => this.AdaptiveQuantization != null;

        /// <summary>
        /// Gets and sets the property BitDepth. Specify the Bit depth. You can choose 8-bit or
        /// 10-bit.
        /// </summary>
        public Av1BitDepth BitDepth { get; set; }

        /// <summary>
        /// Checks to see if the BitDepth property is set.
        /// </summary>
        internal bool IsSetBitDepth() => this.BitDepth != null;

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// Required when Rate control mode is CBR.
        /// </summary>
        [AWSProperty(Min = 1000, Max = 1152000000)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property FastDecode. Choose Enabled to limit the AV1 feature set
        /// that MediaConvert uses, which reduces the complexity of decoding your output in software.
        /// Keep the default value, Disabled, unless your playback devices need the simpler bitstream.
        /// Encoding with Fast decode is slightly slower and gives comparable video quality.
        /// </summary>
        public Av1FastDecode FastDecode { get; set; }

        /// <summary>
        /// Checks to see if the FastDecode property is set.
        /// </summary>
        internal bool IsSetFastDecode() => this.FastDecode != null;

        /// <summary>
        /// Gets and sets the property FilmGrainSynthesis. Film grain synthesis replaces film
        /// grain present in your content with similar quality synthesized AV1 film grain. We
        /// recommend that you choose Enabled to reduce the bandwidth of your QVBR quality level
        /// 5, 6, 7, or 8 outputs. For QVBR quality level 9 or 10 outputs we recommend that you
        /// keep the default value, Disabled. When you include Film grain synthesis, you cannot
        /// include the Noise reducer preprocessor.
        /// </summary>
        public Av1FilmGrainSynthesis FilmGrainSynthesis { get; set; }

        /// <summary>
        /// Checks to see if the FilmGrainSynthesis property is set.
        /// </summary>
        internal bool IsSetFilmGrainSynthesis() => this.FilmGrainSynthesis != null;

        /// <summary>
        /// Gets and sets the property FramerateControl. Use the Framerate setting to specify
        /// the frame rate for this output. If you want to keep the same frame rate as the input
        /// video, choose Follow source. If you want to do frame rate conversion, choose a frame
        /// rate from the dropdown list or choose Custom. The framerates shown in the dropdown
        /// list are decimal approximations of fractions. If you choose Custom, specify your frame
        /// rate as a fraction.
        /// </summary>
        public Av1FramerateControl FramerateControl { get; set; }

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
        public Av1FramerateConversionAlgorithm FramerateConversionAlgorithm { get; set; }

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
        [AWSProperty(Min = 1, Max = 2147483647)]
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
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? FramerateNumerator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateNumerator property is set.
        /// </summary>
        internal bool IsSetFramerateNumerator() => this.FramerateNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property GopSize. Specify the GOP length (keyframe interval). Use
        /// GOP size units to say whether this value is in frames or in seconds. This value must
        /// be greater than zero. With AV1, MediaConvert can't choose the GOP length for you,
        /// so you must specify it.
        /// </summary>
        public double? GopSize { get; set; }

        /// <summary>
        /// Checks to see if the GopSize property is set.
        /// </summary>
        internal bool IsSetGopSize() => this.GopSize.HasValue;

        /// <summary>
        /// Gets and sets the property GopSizeUnits. Specify the units for GOP size. If you don't
        /// specify a value, MediaConvert treats GOP size as a number of frames. With AV1, MediaConvert
        /// can't choose the GOP length for you, so there is no automatic option here: specify
        /// the GOP length in the related setting GOP size, in frames or in seconds.
        /// </summary>
        public Av1GopSizeUnits GopSizeUnits { get; set; }

        /// <summary>
        /// Checks to see if the GopSizeUnits property is set.
        /// </summary>
        internal bool IsSetGopSizeUnits() => this.GopSizeUnits != null;

        /// <summary>
        /// Gets and sets the property MaxBitrate. Maximum bitrate in bits/second. For example,
        /// enter five megabits per second as 5000000. Required when Rate control mode is QVBR.
        /// </summary>
        [AWSProperty(Min = 1000, Max = 1152000000)]
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaxBitrate property is set.
        /// </summary>
        internal bool IsSetMaxBitrate() => this.MaxBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property NumberBFramesBetweenReferenceFrames. Specify the number
        /// of B-frames between reference frames, in the range of 0-15. For AV1 encoding, we recommend
        /// the default value, 15, which gives the lowest bitrate and smallest file size. Choose
        /// a smaller number for better video quality at a higher bitrate.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? NumberBFramesBetweenReferenceFrames { get; set; }

        /// <summary>
        /// Checks to see if the NumberBFramesBetweenReferenceFrames property is set.
        /// </summary>
        internal bool IsSetNumberBFramesBetweenReferenceFrames() => this.NumberBFramesBetweenReferenceFrames.HasValue;

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
        /// Gets and sets the property QvbrSettings. Settings for quality-defined variable bitrate
        /// encoding with the AV1 codec. Use these settings only when you set QVBR for Rate control
        /// mode.
        /// </summary>
        public Av1QvbrSettings QvbrSettings { get; set; }

        /// <summary>
        /// Checks to see if the QvbrSettings property is set.
        /// </summary>
        internal bool IsSetQvbrSettings() => this.QvbrSettings != null;

        /// <summary>
        /// Gets and sets the property RateControlMode. 'With AV1 outputs, for rate control mode,
        /// MediaConvert supports quality-defined variable bitrate (QVBR) and constant bitrate
        /// (CBR). You can''t use VBR.'
        /// </summary>
        public Av1RateControlMode RateControlMode { get; set; }

        /// <summary>
        /// Checks to see if the RateControlMode property is set.
        /// </summary>
        internal bool IsSetRateControlMode() => this.RateControlMode != null;

        /// <summary>
        /// Gets and sets the property SceneChangeDetect. Keep the default value, Enabled, to
        /// have MediaConvert insert I-frames at scene changes that it automatically detects,
        /// which improves video quality. Choose Disabled if you need a strictly fixed keyframe
        /// cadence instead. With AV1, MediaConvert doesn't support Transition detection. Transition
        /// detection is accepted for backward compatibility but behaves exactly the same as Enabled,
        /// so we recommend that you use Enabled instead. It also keeps the QVBR requirement it
        /// has for other codecs: if you choose Transition detection in an AV1 output, Rate control
        /// mode must be QVBR. Choose Enabled to get the same result with any rate control mode.
        /// </summary>
        public Av1SceneChangeDetect SceneChangeDetect { get; set; }

        /// <summary>
        /// Checks to see if the SceneChangeDetect property is set.
        /// </summary>
        internal bool IsSetSceneChangeDetect() => this.SceneChangeDetect != null;

        /// <summary>
        /// Gets and sets the property Slices. Specify the number of slices per picture. This
        /// value must be 1, 2, 4, 8, 16, or 32. For progressive pictures, this value must be
        /// less than or equal to the number of macroblock rows. For interlaced pictures, this
        /// value must be less than or equal to half the number of macroblock rows.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public int? Slices { get; set; }

        /// <summary>
        /// Checks to see if the Slices property is set.
        /// </summary>
        internal bool IsSetSlices() => this.Slices.HasValue;

        /// <summary>
        /// Gets and sets the property SlidingWindowMs. Optional. Specify the duration, in milliseconds,
        /// of the sliding window over which MediaConvert enforces your Peak bitrate. When you
        /// specify a Peak bitrate but omit this value, MediaConvert uses a default sliding window
        /// of 1000.
        /// </summary>
        [AWSProperty(Min = 1000, Max = 3000)]
        public int? SlidingWindowMs { get; set; }

        /// <summary>
        /// Checks to see if the SlidingWindowMs property is set.
        /// </summary>
        internal bool IsSetSlidingWindowMs() => this.SlidingWindowMs.HasValue;

        /// <summary>
        /// Gets and sets the property SlidingWindowPeakBitrate. Optional. Specify an instantaneous
        /// peak bitrate ceiling, in bits/second, that MediaConvert enforces over the sliding
        /// window set by Peak bitrate window. For example, enter fifty megabits per second as
        /// 50000000. Applies in the QVBR rate control mode. When you specify a value below Max
        /// bitrate, MediaConvert raises it to Max bitrate.
        /// </summary>
        [AWSProperty(Min = 1000, Max = 1152000000)]
        public int? SlidingWindowPeakBitrate { get; set; }

        /// <summary>
        /// Checks to see if the SlidingWindowPeakBitrate property is set.
        /// </summary>
        internal bool IsSetSlidingWindowPeakBitrate() => this.SlidingWindowPeakBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property SpatialAdaptiveQuantization. Only use this setting when
        /// you set Adaptive quantization to one of the strength values, Low, Medium, High, Higher
        /// or Max. When you set Adaptive quantization to Auto, MediaConvert enables this feature
        /// for you and you can't specify it manually. When you enable adaptive quantization,
        /// the default value for Av1SpatialAdaptiveQuantization is Enabled. Keep this default
        /// value to adjust quantization within each frame based on spatial variation of content
        /// complexity. When you enable this feature, the encoder uses fewer bits on areas that
        /// can sustain more distortion with no noticeable visual degradation and uses more bits
        /// on areas where any small distortion will be noticeable. For example, complex textured
        /// blocks are encoded with fewer bits and smooth textured blocks are encoded with more
        /// bits. Enabling this feature will almost always improve your video quality. Note, though,
        /// that this feature doesn't take into account where the viewer's attention is likely
        /// to be. If viewers are likely to be focusing their attention on a part of the screen
        /// with a lot of complex texture, you might choose to disable this feature. Related setting:
        /// With AV1 this filter is on or off; the Adaptive quantization value does not change
        /// its strength.
        /// </summary>
        public Av1SpatialAdaptiveQuantization SpatialAdaptiveQuantization { get; set; }

        /// <summary>
        /// Checks to see if the SpatialAdaptiveQuantization property is set.
        /// </summary>
        internal bool IsSetSpatialAdaptiveQuantization() => this.SpatialAdaptiveQuantization != null;

        /// <summary>
        /// Gets and sets the property TemporalAdaptiveQuantization. Only use this setting when
        /// you set Adaptive quantization to one of the strength values, Low, Medium, High, Higher
        /// or Max. When you set Adaptive quantization to Auto, MediaConvert enables this feature
        /// for you and you can't specify it manually. When you enable adaptive quantization,
        /// the default value for Av1TemporalAdaptiveQuantization is Enabled. Keep this default
        /// value to adjust quantization within each frame based on temporal variation of content
        /// complexity. When you enable this feature, the encoder uses fewer bits on areas of
        /// the frame that aren't moving and uses more bits on complex objects with sharp edges
        /// that move a lot. For example, this feature improves the readability of text tickers
        /// on newscasts and scoreboards on sports matches. Enabling this feature will almost
        /// always improve your video quality. Note, though, that this feature doesn't take into
        /// account where the viewer's attention is likely to be. If viewers are likely to be
        /// focusing their attention on a part of the screen that doesn't have moving objects
        /// with sharp edges, such as sports athletes' faces, you might choose to set Av1TemporalAdaptiveQuantization
        /// to Disabled. Related setting: With AV1 this filter is on or off; the Adaptive quantization
        /// value does not change its strength.
        /// </summary>
        public Av1TemporalAdaptiveQuantization TemporalAdaptiveQuantization { get; set; }

        /// <summary>
        /// Checks to see if the TemporalAdaptiveQuantization property is set.
        /// </summary>
        internal bool IsSetTemporalAdaptiveQuantization() => this.TemporalAdaptiveQuantization != null;
    }
}
