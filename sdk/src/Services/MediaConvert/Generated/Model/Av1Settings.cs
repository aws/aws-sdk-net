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
    /// Required when you set Codec, under VideoDescription>CodecSettings to the value AV1.
    /// </summary>
    public partial class Av1Settings
    {
        private Av1AdaptiveQuantization _adaptiveQuantization;
        private Av1BitDepth _bitDepth;
        private Av1FilmGrainSynthesis _filmGrainSynthesis;
        private Av1FramerateControl _framerateControl;
        private Av1FramerateConversionAlgorithm _framerateConversionAlgorithm;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private double? _gopSize;
        private int? _maxBitrate;
        private int? _numberBFramesBetweenReferenceFrames;
        private List<string> _perFrameMetrics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Av1QvbrSettings _qvbrSettings;
        private Av1RateControlMode _rateControlMode;
        private int? _slices;
        private Av1SpatialAdaptiveQuantization _spatialAdaptiveQuantization;

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Specify the strength of any adaptive
        /// quantization filters that you enable. The value that you choose here applies to Spatial
        /// adaptive quantization.
        /// </summary>
        public Av1AdaptiveQuantization AdaptiveQuantization
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
        /// Gets and sets the property BitDepth. Specify the Bit depth. You can choose 8-bit or
        /// 10-bit.
        /// </summary>
        public Av1BitDepth BitDepth
        {
            get { return this._bitDepth; }
            set { this._bitDepth = value; }
        }

        // Check to see if BitDepth property is set
        internal bool IsSetBitDepth()
        {
            return this._bitDepth != null;
        }

        /// <summary>
        /// Gets and sets the property FilmGrainSynthesis. Film grain synthesis replaces film
        /// grain present in your content with similar quality synthesized AV1 film grain. We
        /// recommend that you choose Enabled to reduce the bandwidth of your QVBR quality level
        /// 5, 6, 7, or 8 outputs. For QVBR quality level 9 or 10 outputs we recommend that you
        /// keep the default value, Disabled. When you include Film grain synthesis, you cannot
        /// include the Noise reducer preprocessor.
        /// </summary>
        public Av1FilmGrainSynthesis FilmGrainSynthesis
        {
            get { return this._filmGrainSynthesis; }
            set { this._filmGrainSynthesis = value; }
        }

        // Check to see if FilmGrainSynthesis property is set
        internal bool IsSetFilmGrainSynthesis()
        {
            return this._filmGrainSynthesis != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateControl. Use the Framerate setting to specify
        /// the frame rate for this output. If you want to keep the same frame rate as the input
        /// video, choose Follow source. If you want to do frame rate conversion, choose a frame
        /// rate from the dropdown list or choose Custom. The framerates shown in the dropdown
        /// list are decimal approximations of fractions. If you choose Custom, specify your frame
        /// rate as a fraction.
        /// </summary>
        public Av1FramerateControl FramerateControl
        {
            get { return this._framerateControl; }
            set { this._framerateControl = value; }
        }

        // Check to see if FramerateControl property is set
        internal bool IsSetFramerateControl()
        {
            return this._framerateControl != null;
        }

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
        public Av1FramerateConversionAlgorithm FramerateConversionAlgorithm
        {
            get { return this._framerateConversionAlgorithm; }
            set { this._framerateConversionAlgorithm = value; }
        }

        // Check to see if FramerateConversionAlgorithm property is set
        internal bool IsSetFramerateConversionAlgorithm()
        {
            return this._framerateConversionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateDenominator. When you use the API for transcode
        /// jobs that use frame rate conversion, specify the frame rate as a fraction. For example,
        /// 24000 / 1001 = 23.976 fps. Use FramerateDenominator to specify the denominator of
        /// this fraction. In this example, use 1001 for the value of FramerateDenominator. When
        /// you use the console for transcode jobs that use frame rate conversion, provide the
        /// value as a decimal number for Framerate. In this example, specify 23.976.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? FramerateDenominator
        {
            get { return this._framerateDenominator; }
            set { this._framerateDenominator = value; }
        }

        // Check to see if FramerateDenominator property is set
        internal bool IsSetFramerateDenominator()
        {
            return this._framerateDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FramerateNumerator. When you use the API for transcode
        /// jobs that use frame rate conversion, specify the frame rate as a fraction. For example,
        /// 24000 / 1001 = 23.976 fps. Use FramerateNumerator to specify the numerator of this
        /// fraction. In this example, use 24000 for the value of FramerateNumerator. When you
        /// use the console for transcode jobs that use frame rate conversion, provide the value
        /// as a decimal number for Framerate. In this example, specify 23.976.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? FramerateNumerator
        {
            get { return this._framerateNumerator; }
            set { this._framerateNumerator = value; }
        }

        // Check to see if FramerateNumerator property is set
        internal bool IsSetFramerateNumerator()
        {
            return this._framerateNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopSize. Specify the GOP length (keyframe interval) in
        /// frames. With AV1, MediaConvert doesn't support GOP length in seconds. This value must
        /// be greater than zero and preferably equal to 1 + ((numberBFrames + 1) * x), where
        /// x is an integer value.
        /// </summary>
        public double? GopSize
        {
            get { return this._gopSize; }
            set { this._gopSize = value; }
        }

        // Check to see if GopSize property is set
        internal bool IsSetGopSize()
        {
            return this._gopSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. Maximum bitrate in bits/second. For example,
        /// enter five megabits per second as 5000000. Required when Rate control mode is QVBR.
        /// </summary>
        [AWSProperty(Min=1000, Max=1152000000)]
        public int? MaxBitrate
        {
            get { return this._maxBitrate; }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberBFramesBetweenReferenceFrames. Specify from the number
        /// of B-frames, in the range of 0-15. For AV1 encoding, we recommend using 7 or 15. Choose
        /// a larger number for a lower bitrate and smaller file size; choose a smaller number
        /// for better video quality.
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? NumberBFramesBetweenReferenceFrames
        {
            get { return this._numberBFramesBetweenReferenceFrames; }
            set { this._numberBFramesBetweenReferenceFrames = value; }
        }

        // Check to see if NumberBFramesBetweenReferenceFrames property is set
        internal bool IsSetNumberBFramesBetweenReferenceFrames()
        {
            return this._numberBFramesBetweenReferenceFrames.HasValue; 
        }

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
        /// control mode.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PerFrameMetrics
        {
            get { return this._perFrameMetrics; }
            set { this._perFrameMetrics = value; }
        }

        // Check to see if PerFrameMetrics property is set
        internal bool IsSetPerFrameMetrics()
        {
            return this._perFrameMetrics != null && (this._perFrameMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QvbrSettings. Settings for quality-defined variable bitrate
        /// encoding with the H.265 codec. Use these settings only when you set QVBR for Rate
        /// control mode.
        /// </summary>
        public Av1QvbrSettings QvbrSettings
        {
            get { return this._qvbrSettings; }
            set { this._qvbrSettings = value; }
        }

        // Check to see if QvbrSettings property is set
        internal bool IsSetQvbrSettings()
        {
            return this._qvbrSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RateControlMode. 'With AV1 outputs, for rate control mode,
        /// MediaConvert supports only quality-defined variable bitrate (QVBR). You can''t use
        /// CBR or VBR.'
        /// </summary>
        public Av1RateControlMode RateControlMode
        {
            get { return this._rateControlMode; }
            set { this._rateControlMode = value; }
        }

        // Check to see if RateControlMode property is set
        internal bool IsSetRateControlMode()
        {
            return this._rateControlMode != null;
        }

        /// <summary>
        /// Gets and sets the property Slices. Specify the number of slices per picture. This
        /// value must be 1, 2, 4, 8, 16, or 32. For progressive pictures, this value must be
        /// less than or equal to the number of macroblock rows. For interlaced pictures, this
        /// value must be less than or equal to half the number of macroblock rows.
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public int? Slices
        {
            get { return this._slices; }
            set { this._slices = value; }
        }

        // Check to see if Slices property is set
        internal bool IsSetSlices()
        {
            return this._slices.HasValue; 
        }

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
        public Av1SpatialAdaptiveQuantization SpatialAdaptiveQuantization
        {
            get { return this._spatialAdaptiveQuantization; }
            set { this._spatialAdaptiveQuantization = value; }
        }

        // Check to see if SpatialAdaptiveQuantization property is set
        internal bool IsSetSpatialAdaptiveQuantization()
        {
            return this._spatialAdaptiveQuantization != null;
        }

    }
}