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
    /// Required when you set Codec to the value H_264.
    /// </summary>
    public partial class H264Settings
    {
        private H264AdaptiveQuantization _adaptiveQuantization;
        private BandwidthReductionFilter _bandwidthReductionFilter;
        private int? _bitrate;
        private H264CodecLevel _codecLevel;
        private H264CodecProfile _codecProfile;
        private H264DynamicSubGop _dynamicSubGop;
        private H264EndOfStreamMarkers _endOfStreamMarkers;
        private H264EntropyEncoding _entropyEncoding;
        private H264FieldEncoding _fieldEncoding;
        private H264FlickerAdaptiveQuantization _flickerAdaptiveQuantization;
        private H264FramerateControl _framerateControl;
        private H264FramerateConversionAlgorithm _framerateConversionAlgorithm;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private H264GopBReference _gopBReference;
        private int? _gopClosedCadence;
        private double? _gopSize;
        private H264GopSizeUnits _gopSizeUnits;
        private int? _hrdBufferFinalFillPercentage;
        private int? _hrdBufferInitialFillPercentage;
        private int? _hrdBufferSize;
        private H264InterlaceMode _interlaceMode;
        private int? _maxBitrate;
        private int? _minIInterval;
        private int? _numberBFramesBetweenReferenceFrames;
        private int? _numberReferenceFrames;
        private H264ParControl _parControl;
        private int? _parDenominator;
        private int? _parNumerator;
        private List<string> _perFrameMetrics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private H264QualityTuningLevel _qualityTuningLevel;
        private H264QvbrSettings _qvbrSettings;
        private H264RateControlMode _rateControlMode;
        private H264RepeatPps _repeatPps;
        private H264SaliencyAwareEncoding _saliencyAwareEncoding;
        private H264ScanTypeConversionMode _scanTypeConversionMode;
        private H264SceneChangeDetect _sceneChangeDetect;
        private int? _slices;
        private H264SlowPal _slowPal;
        private int? _softness;
        private H264SpatialAdaptiveQuantization _spatialAdaptiveQuantization;
        private H264Syntax _syntax;
        private H264Telecine _telecine;
        private H264TemporalAdaptiveQuantization _temporalAdaptiveQuantization;
        private H264UnregisteredSeiTimecode _unregisteredSeiTimecode;
        private H264WriteMp4PackagingType _writeMp4PackagingType;

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Keep the default value, Auto, for
        /// this setting to have MediaConvert automatically apply the best types of quantization
        /// for your video content. When you want to apply your quantization settings manually,
        /// you must set H264AdaptiveQuantization to a value other than Auto. Use this setting
        /// to specify the strength of any adaptive quantization filters that you enable. If you
        /// don't want MediaConvert to do any adaptive quantization in this transcode, set Adaptive
        /// quantization to Off. Related settings: The value that you choose here applies to the
        /// following settings: H264FlickerAdaptiveQuantization, H264SpatialAdaptiveQuantization,
        /// and H264TemporalAdaptiveQuantization.
        /// </summary>
        public H264AdaptiveQuantization AdaptiveQuantization
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
        /// Gets and sets the property BandwidthReductionFilter. The Bandwidth reduction filter
        /// increases the video quality of your output relative to its bitrate. Use to lower the
        /// bitrate of your constant quality QVBR output, with little or no perceptual decrease
        /// in quality. Or, use to increase the video quality of outputs with other rate control
        /// modes relative to the bitrate that you specify. Bandwidth reduction increases further
        /// when your input is low quality or noisy. Outputs that use this feature incur pro-tier
        /// pricing. When you include Bandwidth reduction filter, you cannot include the Noise
        /// reducer preprocessor.
        /// </summary>
        public BandwidthReductionFilter BandwidthReductionFilter
        {
            get { return this._bandwidthReductionFilter; }
            set { this._bandwidthReductionFilter = value; }
        }

        // Check to see if BandwidthReductionFilter property is set
        internal bool IsSetBandwidthReductionFilter()
        {
            return this._bandwidthReductionFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// Required for VBR and CBR. For MS Smooth outputs, bitrates must be unique when rounded
        /// down to the nearest multiple of 1000.
        /// </summary>
        [AWSProperty(Min=1000, Max=1152000000)]
        public int? Bitrate
        {
            get { return this._bitrate; }
            set { this._bitrate = value; }
        }

        // Check to see if Bitrate property is set
        internal bool IsSetBitrate()
        {
            return this._bitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodecLevel. Specify an H.264 level that is consistent with
        /// your output video settings. If you aren't sure what level to specify, choose Auto.
        /// </summary>
        public H264CodecLevel CodecLevel
        {
            get { return this._codecLevel; }
            set { this._codecLevel = value; }
        }

        // Check to see if CodecLevel property is set
        internal bool IsSetCodecLevel()
        {
            return this._codecLevel != null;
        }

        /// <summary>
        /// Gets and sets the property CodecProfile. H.264 Profile. High 4:2:2 and 10-bit profiles
        /// are only available with the AVC-I License.
        /// </summary>
        public H264CodecProfile CodecProfile
        {
            get { return this._codecProfile; }
            set { this._codecProfile = value; }
        }

        // Check to see if CodecProfile property is set
        internal bool IsSetCodecProfile()
        {
            return this._codecProfile != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicSubGop. Specify whether to allow the number of B-frames
        /// in your output GOP structure to vary or not depending on your input video content.
        /// To improve the subjective video quality of your output that has high-motion content:
        /// Leave blank or keep the default value Adaptive. MediaConvert will use fewer B-frames
        /// for high-motion video content than low-motion content. The maximum number of B- frames
        /// is limited by the value that you choose for B-frames between reference frames. To
        /// use the same number B-frames for all types of content: Choose Static.
        /// </summary>
        public H264DynamicSubGop DynamicSubGop
        {
            get { return this._dynamicSubGop; }
            set { this._dynamicSubGop = value; }
        }

        // Check to see if DynamicSubGop property is set
        internal bool IsSetDynamicSubGop()
        {
            return this._dynamicSubGop != null;
        }

        /// <summary>
        /// Gets and sets the property EndOfStreamMarkers. Optionally include or suppress markers
        /// at the end of your output that signal the end of the video stream. To include end
        /// of stream markers: Leave blank or keep the default value, Include. To not include
        /// end of stream markers: Choose Suppress. This is useful when your output will be inserted
        /// into another stream.
        /// </summary>
        public H264EndOfStreamMarkers EndOfStreamMarkers
        {
            get { return this._endOfStreamMarkers; }
            set { this._endOfStreamMarkers = value; }
        }

        // Check to see if EndOfStreamMarkers property is set
        internal bool IsSetEndOfStreamMarkers()
        {
            return this._endOfStreamMarkers != null;
        }

        /// <summary>
        /// Gets and sets the property EntropyEncoding. Entropy encoding mode. Use CABAC (must
        /// be in Main or High profile) or CAVLC.
        /// </summary>
        public H264EntropyEncoding EntropyEncoding
        {
            get { return this._entropyEncoding; }
            set { this._entropyEncoding = value; }
        }

        // Check to see if EntropyEncoding property is set
        internal bool IsSetEntropyEncoding()
        {
            return this._entropyEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property FieldEncoding. The video encoding method for your MPEG-4
        /// AVC output. Keep the default value, PAFF, to have MediaConvert use PAFF encoding for
        /// interlaced outputs. Choose Force field to disable PAFF encoding and create separate
        /// interlaced fields. Choose MBAFF to disable PAFF and have MediaConvert use MBAFF encoding
        /// for interlaced outputs.
        /// </summary>
        public H264FieldEncoding FieldEncoding
        {
            get { return this._fieldEncoding; }
            set { this._fieldEncoding = value; }
        }

        // Check to see if FieldEncoding property is set
        internal bool IsSetFieldEncoding()
        {
            return this._fieldEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property FlickerAdaptiveQuantization. Only use this setting when
        /// you change the default value, AUTO, for the setting H264AdaptiveQuantization. When
        /// you keep all defaults, excluding H264AdaptiveQuantization and all other adaptive quantization
        /// from your JSON job specification, MediaConvert automatically applies the best types
        /// of quantization for your video content. When you set H264AdaptiveQuantization to a
        /// value other than AUTO, the default value for H264FlickerAdaptiveQuantization is Disabled.
        /// Change this value to Enabled to reduce I-frame pop. I-frame pop appears as a visual
        /// flicker that can arise when the encoder saves bits by copying some macroblocks many
        /// times from frame to frame, and then refreshes them at the I-frame. When you enable
        /// this setting, the encoder updates these macroblocks slightly more often to smooth
        /// out the flicker. To manually enable or disable H264FlickerAdaptiveQuantization, you
        /// must set Adaptive quantization to a value other than AUTO.
        /// </summary>
        public H264FlickerAdaptiveQuantization FlickerAdaptiveQuantization
        {
            get { return this._flickerAdaptiveQuantization; }
            set { this._flickerAdaptiveQuantization = value; }
        }

        // Check to see if FlickerAdaptiveQuantization property is set
        internal bool IsSetFlickerAdaptiveQuantization()
        {
            return this._flickerAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateControl. If you are using the console, use the
        /// Framerate setting to specify the frame rate for this output. If you want to keep the
        /// same frame rate as the input video, choose Follow source. If you want to do frame
        /// rate conversion, choose a frame rate from the dropdown list or choose Custom. The
        /// framerates shown in the dropdown list are decimal approximations of fractions. If
        /// you choose Custom, specify your frame rate as a fraction.
        /// </summary>
        public H264FramerateControl FramerateControl
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
        public H264FramerateConversionAlgorithm FramerateConversionAlgorithm
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
        /// Gets and sets the property GopBReference. Specify whether to allow B-frames to be
        /// referenced by other frame types. To use reference B-frames when your GOP structure
        /// has 1 or more B-frames: Leave blank or keep the default value Enabled. We recommend
        /// that you choose Enabled to help improve the video quality of your output relative
        /// to its bitrate. To not use reference B-frames: Choose Disabled.
        /// </summary>
        public H264GopBReference GopBReference
        {
            get { return this._gopBReference; }
            set { this._gopBReference = value; }
        }

        // Check to see if GopBReference property is set
        internal bool IsSetGopBReference()
        {
            return this._gopBReference != null;
        }

        /// <summary>
        /// Gets and sets the property GopClosedCadence. Specify the relative frequency of open
        /// to closed GOPs in this output. For example, if you want to allow four open GOPs and
        /// then require a closed GOP, set this value to 5. We recommend that you have the transcoder
        /// automatically choose this value for you based on characteristics of your input video.
        /// In the console, do this by keeping the default empty value. If you do explicitly specify
        /// a value, for segmented outputs, don't set this value to 0.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? GopClosedCadence
        {
            get { return this._gopClosedCadence; }
            set { this._gopClosedCadence = value; }
        }

        // Check to see if GopClosedCadence property is set
        internal bool IsSetGopClosedCadence()
        {
            return this._gopClosedCadence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopSize. Use this setting only when you set GOP mode control
        /// to Specified, frames or Specified, seconds. Specify the GOP length using a whole number
        /// of frames or a decimal value of seconds. MediaConvert will interpret this value as
        /// frames or seconds depending on the value you choose for GOP mode control. If you want
        /// to allow MediaConvert to automatically determine GOP size, leave GOP size blank and
        /// set GOP mode control to Auto. If your output group specifies HLS, DASH, or CMAF, leave
        /// GOP size blank and set GOP mode control to Auto in each output in your output group.
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
        /// Gets and sets the property GopSizeUnits. Specify how the transcoder determines GOP
        /// size for this output. We recommend that you have the transcoder automatically choose
        /// this value for you based on characteristics of your input video. To enable this automatic
        /// behavior, choose Auto and and leave GOP size blank. By default, if you don't specify
        /// GOP mode control, MediaConvert will use automatic behavior. If your output group specifies
        /// HLS, DASH, or CMAF, set GOP mode control to Auto and leave GOP size blank in each
        /// output in your output group. To explicitly specify the GOP length, choose Specified,
        /// frames or Specified, seconds and then provide the GOP length in the related setting
        /// GOP size.
        /// </summary>
        public H264GopSizeUnits GopSizeUnits
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
        /// Gets and sets the property HrdBufferFinalFillPercentage. If your downstream systems
        /// have strict buffer requirements: Specify the minimum percentage of the HRD buffer
        /// that's available at the end of each encoded video segment. For the best video quality:
        /// Set to 0 or leave blank to automatically determine the final buffer fill percentage.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? HrdBufferFinalFillPercentage
        {
            get { return this._hrdBufferFinalFillPercentage; }
            set { this._hrdBufferFinalFillPercentage = value; }
        }

        // Check to see if HrdBufferFinalFillPercentage property is set
        internal bool IsSetHrdBufferFinalFillPercentage()
        {
            return this._hrdBufferFinalFillPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HrdBufferInitialFillPercentage. Percentage of the buffer
        /// that should initially be filled (HRD buffer model).
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? HrdBufferInitialFillPercentage
        {
            get { return this._hrdBufferInitialFillPercentage; }
            set { this._hrdBufferInitialFillPercentage = value; }
        }

        // Check to see if HrdBufferInitialFillPercentage property is set
        internal bool IsSetHrdBufferInitialFillPercentage()
        {
            return this._hrdBufferInitialFillPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HrdBufferSize. Size of buffer (HRD buffer model) in bits.
        /// For example, enter five megabits as 5000000.
        /// </summary>
        [AWSProperty(Min=0, Max=1152000000)]
        public int? HrdBufferSize
        {
            get { return this._hrdBufferSize; }
            set { this._hrdBufferSize = value; }
        }

        // Check to see if HrdBufferSize property is set
        internal bool IsSetHrdBufferSize()
        {
            return this._hrdBufferSize.HasValue; 
        }

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
        public H264InterlaceMode InterlaceMode
        {
            get { return this._interlaceMode; }
            set { this._interlaceMode = value; }
        }

        // Check to see if InterlaceMode property is set
        internal bool IsSetInterlaceMode()
        {
            return this._interlaceMode != null;
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
        /// Gets and sets the property MinIInterval. Specify the minimum number of frames allowed
        /// between two IDR-frames in your output. This includes frames created at the start of
        /// a GOP or a scene change. Use Min I-Interval to improve video compression by varying
        /// GOP size when two IDR-frames would be created near each other. For example, if a regular
        /// cadence-driven IDR-frame would fall within 5 frames of a scene-change IDR-frame, and
        /// you set Min I-interval to 5, then the encoder would only write an IDR-frame for the
        /// scene-change. In this way, one GOP is shortened or extended. If a cadence-driven IDR-frame
        /// would be further than 5 frames from a scene-change IDR-frame, then the encoder leaves
        /// all IDR-frames in place. To use an automatically determined interval: We recommend
        /// that you keep this value blank. This allows for MediaConvert to use an optimal setting
        /// according to the characteristics of your input video, and results in better video
        /// compression. To manually specify an interval: Enter a value from 1 to 30. Use when
        /// your downstream systems have specific GOP size requirements. To disable GOP size variance:
        /// Enter 0. MediaConvert will only create IDR-frames at the start of your output's cadence-driven
        /// GOP. Use when your downstream systems require a regular GOP size.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public int? MinIInterval
        {
            get { return this._minIInterval; }
            set { this._minIInterval = value; }
        }

        // Check to see if MinIInterval property is set
        internal bool IsSetMinIInterval()
        {
            return this._minIInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberBFramesBetweenReferenceFrames. Specify the number
        /// of B-frames between reference frames in this output. For the best video quality: Leave
        /// blank. MediaConvert automatically determines the number of B-frames to use based on
        /// the characteristics of your input video. To manually specify the number of B-frames
        /// between reference frames: Enter an integer from 0 to 7.
        /// </summary>
        [AWSProperty(Min=0, Max=7)]
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
        /// Gets and sets the property NumberReferenceFrames. Number of reference frames to use.
        /// The encoder may use more than requested if using B-frames and/or interlaced encoding.
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public int? NumberReferenceFrames
        {
            get { return this._numberReferenceFrames; }
            set { this._numberReferenceFrames = value; }
        }

        // Check to see if NumberReferenceFrames property is set
        internal bool IsSetNumberReferenceFrames()
        {
            return this._numberReferenceFrames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParControl. Optional. Specify how the service determines
        /// the pixel aspect ratio (PAR) for this output. The default behavior, Follow source,
        /// uses the PAR from your input video for your output. To specify a different PAR in
        /// the console, choose any value other than Follow source. When you choose SPECIFIED
        /// for this setting, you must also specify values for the parNumerator and parDenominator
        /// settings.
        /// </summary>
        public H264ParControl ParControl
        {
            get { return this._parControl; }
            set { this._parControl = value; }
        }

        // Check to see if ParControl property is set
        internal bool IsSetParControl()
        {
            return this._parControl != null;
        }

        /// <summary>
        /// Gets and sets the property ParDenominator. Required when you set Pixel aspect ratio
        /// to SPECIFIED. On the console, this corresponds to any value other than Follow source.
        /// When you specify an output pixel aspect ratio (PAR) that is different from your input
        /// video PAR, provide your output PAR as a ratio. For example, for D1/DV NTSC widescreen,
        /// you would specify the ratio 40:33. In this example, the value for parDenominator is
        /// 33.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? ParDenominator
        {
            get { return this._parDenominator; }
            set { this._parDenominator = value; }
        }

        // Check to see if ParDenominator property is set
        internal bool IsSetParDenominator()
        {
            return this._parDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParNumerator. Required when you set Pixel aspect ratio
        /// to SPECIFIED. On the console, this corresponds to any value other than Follow source.
        /// When you specify an output pixel aspect ratio (PAR) that is different from your input
        /// video PAR, provide your output PAR as a ratio. For example, for D1/DV NTSC widescreen,
        /// you would specify the ratio 40:33. In this example, the value for parNumerator is
        /// 40.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? ParNumerator
        {
            get { return this._parNumerator; }
            set { this._parNumerator = value; }
        }

        // Check to see if ParNumerator property is set
        internal bool IsSetParNumerator()
        {
            return this._parNumerator.HasValue; 
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
        /// Gets and sets the property QualityTuningLevel. The Quality tuning level you choose
        /// represents a trade-off between the encoding speed of your job and the output video
        /// quality. For the fastest encoding speed at the cost of video quality: Choose Single
        /// pass. For a good balance between encoding speed and video quality: Leave blank or
        /// keep the default value Single pass HQ. For the best video quality, at the cost of
        /// encoding speed: Choose Multi pass HQ. MediaConvert performs an analysis pass on your
        /// input followed by an encoding pass. Outputs that use this feature incur pro-tier pricing.
        /// </summary>
        public H264QualityTuningLevel QualityTuningLevel
        {
            get { return this._qualityTuningLevel; }
            set { this._qualityTuningLevel = value; }
        }

        // Check to see if QualityTuningLevel property is set
        internal bool IsSetQualityTuningLevel()
        {
            return this._qualityTuningLevel != null;
        }

        /// <summary>
        /// Gets and sets the property QvbrSettings. Settings for quality-defined variable bitrate
        /// encoding with the H.265 codec. Use these settings only when you set QVBR for Rate
        /// control mode.
        /// </summary>
        public H264QvbrSettings QvbrSettings
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
        /// Gets and sets the property RateControlMode. Use this setting to specify whether this
        /// output has a variable bitrate (VBR), constant bitrate (CBR) or quality-defined variable
        /// bitrate (QVBR).
        /// </summary>
        public H264RateControlMode RateControlMode
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
        /// Gets and sets the property RepeatPps. Places a PPS header on each encoded picture,
        /// even if repeated.
        /// </summary>
        public H264RepeatPps RepeatPps
        {
            get { return this._repeatPps; }
            set { this._repeatPps = value; }
        }

        // Check to see if RepeatPps property is set
        internal bool IsSetRepeatPps()
        {
            return this._repeatPps != null;
        }

        /// <summary>
        /// Gets and sets the property SaliencyAwareEncoding. Specify whether to apply Saliency
        /// aware encoding to your output. Use to improve the perceptual video quality of your
        /// output by allocating more encoding bits to the prominent or noticeable parts of your
        /// content. To apply saliency aware encoding, when possible: We recommend that you choose
        /// Preferred. The effects of Saliency aware encoding are best seen in lower bitrate outputs.
        /// When you choose Preferred, note that Saliency aware encoding will only apply to outputs
        /// that are 720p or higher in resolution. To not apply saliency aware encoding, prioritizing
        /// encoding speed over perceptual video quality: Choose Disabled.
        /// </summary>
        public H264SaliencyAwareEncoding SaliencyAwareEncoding
        {
            get { return this._saliencyAwareEncoding; }
            set { this._saliencyAwareEncoding = value; }
        }

        // Check to see if SaliencyAwareEncoding property is set
        internal bool IsSetSaliencyAwareEncoding()
        {
            return this._saliencyAwareEncoding != null;
        }

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
        public H264ScanTypeConversionMode ScanTypeConversionMode
        {
            get { return this._scanTypeConversionMode; }
            set { this._scanTypeConversionMode = value; }
        }

        // Check to see if ScanTypeConversionMode property is set
        internal bool IsSetScanTypeConversionMode()
        {
            return this._scanTypeConversionMode != null;
        }

        /// <summary>
        /// Gets and sets the property SceneChangeDetect. Enable this setting to insert I-frames
        /// at scene changes that the service automatically detects. This improves video quality
        /// and is enabled by default. If this output uses QVBR, choose Transition detection for
        /// further video quality improvement. For more information about QVBR, see https://docs.aws.amazon.com/console/mediaconvert/cbr-vbr-qvbr.
        /// </summary>
        public H264SceneChangeDetect SceneChangeDetect
        {
            get { return this._sceneChangeDetect; }
            set { this._sceneChangeDetect = value; }
        }

        // Check to see if SceneChangeDetect property is set
        internal bool IsSetSceneChangeDetect()
        {
            return this._sceneChangeDetect != null;
        }

        /// <summary>
        /// Gets and sets the property Slices. Number of slices per picture. Must be less than
        /// or equal to the number of macroblock rows for progressive pictures, and less than
        /// or equal to half the number of macroblock rows for interlaced pictures.
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
        /// Gets and sets the property SlowPal. Ignore this setting unless your input frame rate
        /// is 23.976 or 24 frames per second (fps). Enable slow PAL to create a 25 fps output.
        /// When you enable slow PAL, MediaConvert relabels the video frames to 25 fps and resamples
        /// your audio to keep it synchronized with the video. Note that enabling this setting
        /// will slightly reduce the duration of your video. Required settings: You must also
        /// set Framerate to 25.
        /// </summary>
        public H264SlowPal SlowPal
        {
            get { return this._slowPal; }
            set { this._slowPal = value; }
        }

        // Check to see if SlowPal property is set
        internal bool IsSetSlowPal()
        {
            return this._slowPal != null;
        }

        /// <summary>
        /// Gets and sets the property Softness. Ignore this setting unless you need to comply
        /// with a specification that requires a specific value. If you don't have a specification
        /// requirement, we recommend that you adjust the softness of your output by using a lower
        /// value for the setting Sharpness or by enabling a noise reducer filter. The Softness
        /// setting specifies the quantization matrices that the encoder uses. Keep the default
        /// value, 0, for flat quantization. Choose the value 1 or 16 to use the default JVT softening
        /// quantization matricies from the H.264 specification. Choose a value from 17 to 128
        /// to use planar interpolation. Increasing values from 17 to 128 result in increasing
        /// reduction of high-frequency data. The value 128 results in the softest video.
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public int? Softness
        {
            get { return this._softness; }
            set { this._softness = value; }
        }

        // Check to see if Softness property is set
        internal bool IsSetSoftness()
        {
            return this._softness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpatialAdaptiveQuantization. Only use this setting when
        /// you change the default value, Auto, for the setting H264AdaptiveQuantization. When
        /// you keep all defaults, excluding H264AdaptiveQuantization and all other adaptive quantization
        /// from your JSON job specification, MediaConvert automatically applies the best types
        /// of quantization for your video content. When you set H264AdaptiveQuantization to a
        /// value other than AUTO, the default value for H264SpatialAdaptiveQuantization is Enabled.
        /// Keep this default value to adjust quantization within each frame based on spatial
        /// variation of content complexity. When you enable this feature, the encoder uses fewer
        /// bits on areas that can sustain more distortion with no noticeable visual degradation
        /// and uses more bits on areas where any small distortion will be noticeable. For example,
        /// complex textured blocks are encoded with fewer bits and smooth textured blocks are
        /// encoded with more bits. Enabling this feature will almost always improve your video
        /// quality. Note, though, that this feature doesn't take into account where the viewer's
        /// attention is likely to be. If viewers are likely to be focusing their attention on
        /// a part of the screen with a lot of complex texture, you might choose to set H264SpatialAdaptiveQuantization
        /// to Disabled. Related setting: When you enable spatial adaptive quantization, set the
        /// value for Adaptive quantization depending on your content. For homogeneous content,
        /// such as cartoons and video games, set it to Low. For content with a wider variety
        /// of textures, set it to High or Higher. To manually enable or disable H264SpatialAdaptiveQuantization,
        /// you must set Adaptive quantization to a value other than AUTO.
        /// </summary>
        public H264SpatialAdaptiveQuantization SpatialAdaptiveQuantization
        {
            get { return this._spatialAdaptiveQuantization; }
            set { this._spatialAdaptiveQuantization = value; }
        }

        // Check to see if SpatialAdaptiveQuantization property is set
        internal bool IsSetSpatialAdaptiveQuantization()
        {
            return this._spatialAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property Syntax. Produces a bitstream compliant with SMPTE RP-2027.
        /// </summary>
        public H264Syntax Syntax
        {
            get { return this._syntax; }
            set { this._syntax = value; }
        }

        // Check to see if Syntax property is set
        internal bool IsSetSyntax()
        {
            return this._syntax != null;
        }

        /// <summary>
        /// Gets and sets the property Telecine. When you do frame rate conversion from 23.976
        /// frames per second (fps) to 29.97 fps, and your output scan type is interlaced, you
        /// can optionally enable hard or soft telecine to create a smoother picture. Hard telecine
        /// produces a 29.97i output. Soft telecine produces an output with a 23.976 output that
        /// signals to the video player device to do the conversion during play back. When you
        /// keep the default value, None, MediaConvert does a standard frame rate conversion to
        /// 29.97 without doing anything with the field polarity to create a smoother picture.
        /// </summary>
        public H264Telecine Telecine
        {
            get { return this._telecine; }
            set { this._telecine = value; }
        }

        // Check to see if Telecine property is set
        internal bool IsSetTelecine()
        {
            return this._telecine != null;
        }

        /// <summary>
        /// Gets and sets the property TemporalAdaptiveQuantization. Only use this setting when
        /// you change the default value, AUTO, for the setting H264AdaptiveQuantization. When
        /// you keep all defaults, excluding H264AdaptiveQuantization and all other adaptive quantization
        /// from your JSON job specification, MediaConvert automatically applies the best types
        /// of quantization for your video content. When you set H264AdaptiveQuantization to a
        /// value other than AUTO, the default value for H264TemporalAdaptiveQuantization is Enabled.
        /// Keep this default value to adjust quantization within each frame based on temporal
        /// variation of content complexity. When you enable this feature, the encoder uses fewer
        /// bits on areas of the frame that aren't moving and uses more bits on complex objects
        /// with sharp edges that move a lot. For example, this feature improves the readability
        /// of text tickers on newscasts and scoreboards on sports matches. Enabling this feature
        /// will almost always improve your video quality. Note, though, that this feature doesn't
        /// take into account where the viewer's attention is likely to be. If viewers are likely
        /// to be focusing their attention on a part of the screen that doesn't have moving objects
        /// with sharp edges, such as sports athletes' faces, you might choose to set H264TemporalAdaptiveQuantization
        /// to Disabled. Related setting: When you enable temporal quantization, adjust the strength
        /// of the filter with the setting Adaptive quantization. To manually enable or disable
        /// H264TemporalAdaptiveQuantization, you must set Adaptive quantization to a value other
        /// than AUTO.
        /// </summary>
        public H264TemporalAdaptiveQuantization TemporalAdaptiveQuantization
        {
            get { return this._temporalAdaptiveQuantization; }
            set { this._temporalAdaptiveQuantization = value; }
        }

        // Check to see if TemporalAdaptiveQuantization property is set
        internal bool IsSetTemporalAdaptiveQuantization()
        {
            return this._temporalAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property UnregisteredSeiTimecode. Inserts timecode for each frame
        /// as 4 bytes of an unregistered SEI message.
        /// </summary>
        public H264UnregisteredSeiTimecode UnregisteredSeiTimecode
        {
            get { return this._unregisteredSeiTimecode; }
            set { this._unregisteredSeiTimecode = value; }
        }

        // Check to see if UnregisteredSeiTimecode property is set
        internal bool IsSetUnregisteredSeiTimecode()
        {
            return this._unregisteredSeiTimecode != null;
        }

        /// <summary>
        /// Gets and sets the property WriteMp4PackagingType. Specify how SPS and PPS NAL units
        /// are written in your output MP4 container, according to ISO/IEC 14496-15. If the location
        /// of these parameters doesn't matter in your workflow: Keep the default value, AVC1.
        /// MediaConvert writes SPS and PPS NAL units in the sample description ('stsd') box (but
        /// not into samples directly). To write SPS and PPS NAL units directly into samples (but
        /// not in the 'stsd' box): Choose AVC3. When you do, note that your output might not
        /// play properly with some downstream systems or players.
        /// </summary>
        public H264WriteMp4PackagingType WriteMp4PackagingType
        {
            get { return this._writeMp4PackagingType; }
            set { this._writeMp4PackagingType = value; }
        }

        // Check to see if WriteMp4PackagingType property is set
        internal bool IsSetWriteMp4PackagingType()
        {
            return this._writeMp4PackagingType != null;
        }

    }
}