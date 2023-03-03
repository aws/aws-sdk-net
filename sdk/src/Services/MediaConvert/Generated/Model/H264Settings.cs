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
    /// Required when you set (Codec) under (VideoDescription)>(CodecSettings) to the value
    /// H_264.
    /// </summary>
    public partial class H264Settings
    {
        private H264AdaptiveQuantization _adaptiveQuantization;
        private BandwidthReductionFilter _bandwidthReductionFilter;
        private int? _bitrate;
        private H264CodecLevel _codecLevel;
        private H264CodecProfile _codecProfile;
        private H264DynamicSubGop _dynamicSubGop;
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
        private H264QualityTuningLevel _qualityTuningLevel;
        private H264QvbrSettings _qvbrSettings;
        private H264RateControlMode _rateControlMode;
        private H264RepeatPps _repeatPps;
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

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Keep the default value, Auto (AUTO),
        /// for this setting to have MediaConvert automatically apply the best types of quantization
        /// for your video content. When you want to apply your quantization settings manually,
        /// you must set H264AdaptiveQuantization to a value other than Auto (AUTO). Use this
        /// setting to specify the strength of any adaptive quantization filters that you enable.
        /// If you don't want MediaConvert to do any adaptive quantization in this transcode,
        /// set Adaptive quantization (H264AdaptiveQuantization) to Off (OFF). Related settings:
        /// The value that you choose here applies to the following settings: H264FlickerAdaptiveQuantization,
        /// H264SpatialAdaptiveQuantization, and H264TemporalAdaptiveQuantization.
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
        public int Bitrate
        {
            get { return this._bitrate.GetValueOrDefault(); }
            set { this._bitrate = value; }
        }

        // Check to see if Bitrate property is set
        internal bool IsSetBitrate()
        {
            return this._bitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodecLevel. Specify an H.264 level that is consistent with
        /// your output video settings. If you aren't sure what level to specify, choose Auto
        /// (AUTO).
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
        /// Gets and sets the property DynamicSubGop. Choose Adaptive to improve subjective video
        /// quality for high-motion content. This will cause the service to use fewer B-frames
        /// (which infer information based on other frames) for high-motion portions of the video
        /// and more B-frames for low-motion portions. The maximum number of B-frames is limited
        /// by the value you provide for the setting B frames between reference frames (numberBFramesBetweenReferenceFrames).
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
        /// interlaced outputs. Choose Force field (FORCE_FIELD) to disable PAFF encoding and
        /// create separate interlaced fields. Choose MBAFF to disable PAFF and have MediaConvert
        /// use MBAFF encoding for interlaced outputs.
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
        /// value other than AUTO, the default value for H264FlickerAdaptiveQuantization is Disabled
        /// (DISABLED). Change this value to Enabled (ENABLED) to reduce I-frame pop. I-frame
        /// pop appears as a visual flicker that can arise when the encoder saves bits by copying
        /// some macroblocks many times from frame to frame, and then refreshes them at the I-frame.
        /// When you enable this setting, the encoder updates these macroblocks slightly more
        /// often to smooth out the flicker. To manually enable or disable H264FlickerAdaptiveQuantization,
        /// you must set Adaptive quantization (H264AdaptiveQuantization) to a value other than
        /// AUTO.
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
        /// you choose Custom, specify your frame rate as a fraction. If you are creating your
        /// transcoding job specification as a JSON file without the console, use FramerateControl
        /// to specify which value the service uses for the frame rate for this output. Choose
        /// INITIALIZE_FROM_SOURCE if you want the service to use the frame rate from the input.
        /// Choose SPECIFIED if you want the service to use the frame rate you specify in the
        /// settings FramerateNumerator and FramerateDenominator.
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
        /// want MediaConvert to use when increasing or decreasing the frame rate. We recommend
        /// using drop duplicate (DUPLICATE_DROP) for numerically simple conversions, such as
        /// 60 fps to 30 fps. For numerically complex conversions, you can use interpolate (INTERPOLATE)
        /// to avoid stutter. This results in a smooth picture, but might introduce undesirable
        /// video artifacts. For complex frame rate conversions, especially if your source video
        /// has already been converted from its original cadence, use FrameFormer (FRAMEFORMER)
        /// to do motion-compensated interpolation. FrameFormer chooses the best conversion method
        /// frame by frame. Note that using FrameFormer increases the transcoding time and incurs
        /// a significant add-on cost.
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
        /// Gets and sets the property FramerateNumerator. When you use the API for transcode
        /// jobs that use frame rate conversion, specify the frame rate as a fraction. For example,
        /// 24000 / 1001 = 23.976 fps. Use FramerateNumerator to specify the numerator of this
        /// fraction. In this example, use 24000 for the value of FramerateNumerator. When you
        /// use the console for transcode jobs that use frame rate conversion, provide the value
        /// as a decimal number for Framerate. In this example, specify 23.976.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
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
        /// Gets and sets the property GopBReference. If enable, use reference B frames for GOP
        /// structures that have B frames > 1.
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
        /// To enable this automatic behavior, keep the default value by leaving this setting
        /// out of your JSON job specification. In the console, do this by keeping the default
        /// empty value. If you do explicitly specify a value, for segmented outputs, don't set
        /// this value to 0.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
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
        /// Gets and sets the property GopSize. Use this setting only when you set GOP mode control
        /// (GopSizeUnits) to Specified, frames (FRAMES) or Specified, seconds (SECONDS). Specify
        /// the GOP length using a whole number of frames or a decimal value of seconds. MediaConvert
        /// will interpret this value as frames or seconds depending on the value you choose for
        /// GOP mode control (GopSizeUnits). If you want to allow MediaConvert to automatically
        /// determine GOP size, leave GOP size blank and set GOP mode control to Auto (AUTO).
        /// If your output group specifies HLS, DASH, or CMAF, leave GOP size blank and set GOP
        /// mode control to Auto in each output in your output group.
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
        /// Gets and sets the property GopSizeUnits. Specify how the transcoder determines GOP
        /// size for this output. We recommend that you have the transcoder automatically choose
        /// this value for you based on characteristics of your input video. To enable this automatic
        /// behavior, choose Auto (AUTO) and and leave GOP size (GopSize) blank. By default, if
        /// you don't specify GOP mode control (GopSizeUnits), MediaConvert will use automatic
        /// behavior. If your output group specifies HLS, DASH, or CMAF, set GOP mode control
        /// to Auto and leave GOP size blank in each output in your output group. To explicitly
        /// specify the GOP length, choose Specified, frames (FRAMES) or Specified, seconds (SECONDS)
        /// and then provide the GOP length in the related setting GOP size (GopSize).
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
        public int HrdBufferFinalFillPercentage
        {
            get { return this._hrdBufferFinalFillPercentage.GetValueOrDefault(); }
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
        public int HrdBufferInitialFillPercentage
        {
            get { return this._hrdBufferInitialFillPercentage.GetValueOrDefault(); }
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
        public int HrdBufferSize
        {
            get { return this._hrdBufferSize.GetValueOrDefault(); }
            set { this._hrdBufferSize = value; }
        }

        // Check to see if HrdBufferSize property is set
        internal bool IsSetHrdBufferSize()
        {
            return this._hrdBufferSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InterlaceMode. Choose the scan line type for the output.
        /// Keep the default value, Progressive (PROGRESSIVE) to create a progressive output,
        /// regardless of the scan type of your input. Use Top field first (TOP_FIELD) or Bottom
        /// field first (BOTTOM_FIELD) to create an output that's interlaced with the same field
        /// polarity throughout. Use Follow, default top (FOLLOW_TOP_FIELD) or Follow, default
        /// bottom (FOLLOW_BOTTOM_FIELD) to produce outputs with the same field polarity as the
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
        public int MaxBitrate
        {
            get { return this._maxBitrate.GetValueOrDefault(); }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIInterval. Use this setting only when you also enable
        /// Scene change detection (SceneChangeDetect). This setting determines how the encoder
        /// manages the spacing between I-frames that it inserts as part of the I-frame cadence
        /// and the I-frames that it inserts for Scene change detection. We recommend that you
        /// have the transcoder automatically choose this value for you based on characteristics
        /// of your input video. To enable this automatic behavior, keep the default value by
        /// leaving this setting out of your JSON job specification. In the console, do this by
        /// keeping the default empty value. When you explicitly specify a value for this setting,
        /// the encoder determines whether to skip a cadence-driven I-frame by the value you set.
        /// For example, if you set Min I interval (minIInterval) to 5 and a cadence-driven I-frame
        /// would fall within 5 frames of a scene-change I-frame, then the encoder skips the cadence-driven
        /// I-frame. In this way, one GOP is shrunk slightly and one GOP is stretched slightly.
        /// When the cadence-driven I-frames are farther from the scene-change I-frame than the
        /// value you set, then the encoder leaves all I-frames in place and the GOPs surrounding
        /// the scene change are smaller than the usual cadence GOPs.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public int MinIInterval
        {
            get { return this._minIInterval.GetValueOrDefault(); }
            set { this._minIInterval = value; }
        }

        // Check to see if MinIInterval property is set
        internal bool IsSetMinIInterval()
        {
            return this._minIInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberBFramesBetweenReferenceFrames. This setting to determines
        /// the number of B-frames that MediaConvert puts between reference frames in this output.
        /// We recommend that you use automatic behavior to allow the transcoder to choose the
        /// best value based on characteristics of your input video. In the console, choose AUTO
        /// to select this automatic behavior. When you manually edit your JSON job specification,
        /// leave this setting out to choose automatic behavior. When you want to specify this
        /// number explicitly, choose a whole number from 0 through 7.
        /// </summary>
        [AWSProperty(Min=0, Max=7)]
        public int NumberBFramesBetweenReferenceFrames
        {
            get { return this._numberBFramesBetweenReferenceFrames.GetValueOrDefault(); }
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
        public int NumberReferenceFrames
        {
            get { return this._numberReferenceFrames.GetValueOrDefault(); }
            set { this._numberReferenceFrames = value; }
        }

        // Check to see if NumberReferenceFrames property is set
        internal bool IsSetNumberReferenceFrames()
        {
            return this._numberReferenceFrames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParControl. Optional. Specify how the service determines
        /// the pixel aspect ratio (PAR) for this output. The default behavior, Follow source
        /// (INITIALIZE_FROM_SOURCE), uses the PAR from your input video for your output. To specify
        /// a different PAR in the console, choose any value other than Follow source. To specify
        /// a different PAR by editing the JSON job specification, choose SPECIFIED. When you
        /// choose SPECIFIED for this setting, you must also specify values for the parNumerator
        /// and parDenominator settings.
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
        /// (parControl) to SPECIFIED. On the console, this corresponds to any value other than
        /// Follow source. When you specify an output pixel aspect ratio (PAR) that is different
        /// from your input video PAR, provide your output PAR as a ratio. For example, for D1/DV
        /// NTSC widescreen, you would specify the ratio 40:33. In this example, the value for
        /// parDenominator is 33.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int ParDenominator
        {
            get { return this._parDenominator.GetValueOrDefault(); }
            set { this._parDenominator = value; }
        }

        // Check to see if ParDenominator property is set
        internal bool IsSetParDenominator()
        {
            return this._parDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParNumerator. Required when you set Pixel aspect ratio
        /// (parControl) to SPECIFIED. On the console, this corresponds to any value other than
        /// Follow source. When you specify an output pixel aspect ratio (PAR) that is different
        /// from your input video PAR, provide your output PAR as a ratio. For example, for D1/DV
        /// NTSC widescreen, you would specify the ratio 40:33. In this example, the value for
        /// parNumerator is 40.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int ParNumerator
        {
            get { return this._parNumerator.GetValueOrDefault(); }
            set { this._parNumerator = value; }
        }

        // Check to see if ParNumerator property is set
        internal bool IsSetParNumerator()
        {
            return this._parNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QualityTuningLevel. Optional. Use Quality tuning level
        /// (qualityTuningLevel) to choose how you want to trade off encoding speed for output
        /// video quality. The default behavior is faster, lower quality, single-pass encoding.
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
        /// control mode (RateControlMode).
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
        /// Gets and sets the property ScanTypeConversionMode. Use this setting for interlaced
        /// outputs, when your output frame rate is half of your input frame rate. In this situation,
        /// choose Optimized interlacing (INTERLACED_OPTIMIZE) to create a better quality interlaced
        /// output. In this case, each progressive frame from the input corresponds to an interlaced
        /// field in the output. Keep the default value, Basic interlacing (INTERLACED), for all
        /// other output frame rates. With basic interlacing, MediaConvert performs any frame
        /// rate conversion first and then interlaces the frames. When you choose Optimized interlacing
        /// and you set your output frame rate to a value that isn't suitable for optimized interlacing,
        /// MediaConvert automatically falls back to basic interlacing. Required settings: To
        /// use optimized interlacing, you must set Telecine (telecine) to None (NONE) or Soft
        /// (SOFT). You can't use optimized interlacing for hard telecine outputs. You must also
        /// set Interlace mode (interlaceMode) to a value other than Progressive (PROGRESSIVE).
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
        /// and is enabled by default. If this output uses QVBR, choose Transition detection (TRANSITION_DETECTION)
        /// for further video quality improvement. For more information about QVBR, see https://docs.aws.amazon.com/console/mediaconvert/cbr-vbr-qvbr.
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
        public int Slices
        {
            get { return this._slices.GetValueOrDefault(); }
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
        /// set Framerate to 25. In your JSON job specification, set (framerateControl) to (SPECIFIED),
        /// (framerateNumerator) to 25 and (framerateDenominator) to 1.
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
        /// value for the setting Sharpness (sharpness) or by enabling a noise reducer filter
        /// (noiseReducerFilter). The Softness (softness) setting specifies the quantization matrices
        /// that the encoder uses. Keep the default value, 0, for flat quantization. Choose the
        /// value 1 or 16 to use the default JVT softening quantization matricies from the H.264
        /// specification. Choose a value from 17 to 128 to use planar interpolation. Increasing
        /// values from 17 to 128 result in increasing reduction of high-frequency data. The value
        /// 128 results in the softest video.
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public int Softness
        {
            get { return this._softness.GetValueOrDefault(); }
            set { this._softness = value; }
        }

        // Check to see if Softness property is set
        internal bool IsSetSoftness()
        {
            return this._softness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpatialAdaptiveQuantization. Only use this setting when
        /// you change the default value, Auto (AUTO), for the setting H264AdaptiveQuantization.
        /// When you keep all defaults, excluding H264AdaptiveQuantization and all other adaptive
        /// quantization from your JSON job specification, MediaConvert automatically applies
        /// the best types of quantization for your video content. When you set H264AdaptiveQuantization
        /// to a value other than AUTO, the default value for H264SpatialAdaptiveQuantization
        /// is Enabled (ENABLED). Keep this default value to adjust quantization within each frame
        /// based on spatial variation of content complexity. When you enable this feature, the
        /// encoder uses fewer bits on areas that can sustain more distortion with no noticeable
        /// visual degradation and uses more bits on areas where any small distortion will be
        /// noticeable. For example, complex textured blocks are encoded with fewer bits and smooth
        /// textured blocks are encoded with more bits. Enabling this feature will almost always
        /// improve your video quality. Note, though, that this feature doesn't take into account
        /// where the viewer's attention is likely to be. If viewers are likely to be focusing
        /// their attention on a part of the screen with a lot of complex texture, you might choose
        /// to set H264SpatialAdaptiveQuantization to Disabled (DISABLED). Related setting: When
        /// you enable spatial adaptive quantization, set the value for Adaptive quantization
        /// (H264AdaptiveQuantization) depending on your content. For homogeneous content, such
        /// as cartoons and video games, set it to Low. For content with a wider variety of textures,
        /// set it to High or Higher. To manually enable or disable H264SpatialAdaptiveQuantization,
        /// you must set Adaptive quantization (H264AdaptiveQuantization) to a value other than
        /// AUTO.
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
        /// (HARD) produces a 29.97i output. Soft telecine (SOFT) produces an output with a 23.976
        /// output that signals to the video player device to do the conversion during play back.
        /// When you keep the default value, None (NONE), MediaConvert does a standard frame rate
        /// conversion to 29.97 without doing anything with the field polarity to create a smoother
        /// picture.
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
        /// value other than AUTO, the default value for H264TemporalAdaptiveQuantization is Enabled
        /// (ENABLED). Keep this default value to adjust quantization within each frame based
        /// on temporal variation of content complexity. When you enable this feature, the encoder
        /// uses fewer bits on areas of the frame that aren't moving and uses more bits on complex
        /// objects with sharp edges that move a lot. For example, this feature improves the readability
        /// of text tickers on newscasts and scoreboards on sports matches. Enabling this feature
        /// will almost always improve your video quality. Note, though, that this feature doesn't
        /// take into account where the viewer's attention is likely to be. If viewers are likely
        /// to be focusing their attention on a part of the screen that doesn't have moving objects
        /// with sharp edges, such as sports athletes' faces, you might choose to set H264TemporalAdaptiveQuantization
        /// to Disabled (DISABLED). Related setting: When you enable temporal quantization, adjust
        /// the strength of the filter with the setting Adaptive quantization (adaptiveQuantization).
        /// To manually enable or disable H264TemporalAdaptiveQuantization, you must set Adaptive
        /// quantization (H264AdaptiveQuantization) to a value other than AUTO.
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

    }
}