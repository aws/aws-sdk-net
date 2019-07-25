/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set (Codec) under (VideoDescription)>(CodecSettings) to the value
    /// MPEG2.
    /// </summary>
    public partial class Mpeg2Settings
    {
        private Mpeg2AdaptiveQuantization _adaptiveQuantization;
        private int? _bitrate;
        private Mpeg2CodecLevel _codecLevel;
        private Mpeg2CodecProfile _codecProfile;
        private Mpeg2DynamicSubGop _dynamicSubGop;
        private Mpeg2FramerateControl _framerateControl;
        private Mpeg2FramerateConversionAlgorithm _framerateConversionAlgorithm;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private int? _gopClosedCadence;
        private double? _gopSize;
        private Mpeg2GopSizeUnits _gopSizeUnits;
        private int? _hrdBufferInitialFillPercentage;
        private int? _hrdBufferSize;
        private Mpeg2InterlaceMode _interlaceMode;
        private Mpeg2IntraDcPrecision _intraDcPrecision;
        private int? _maxBitrate;
        private int? _minIInterval;
        private int? _numberBFramesBetweenReferenceFrames;
        private Mpeg2ParControl _parControl;
        private int? _parDenominator;
        private int? _parNumerator;
        private Mpeg2QualityTuningLevel _qualityTuningLevel;
        private Mpeg2RateControlMode _rateControlMode;
        private Mpeg2SceneChangeDetect _sceneChangeDetect;
        private Mpeg2SlowPal _slowPal;
        private int? _softness;
        private Mpeg2SpatialAdaptiveQuantization _spatialAdaptiveQuantization;
        private Mpeg2Syntax _syntax;
        private Mpeg2Telecine _telecine;
        private Mpeg2TemporalAdaptiveQuantization _temporalAdaptiveQuantization;

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Adaptive quantization. Allows intra-frame
        /// quantizers to vary to improve visual quality.
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
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// Required for VBR and CBR. For MS Smooth outputs, bitrates must be unique when rounded
        /// down to the nearest multiple of 1000.
        /// </summary>
        [AWSProperty(Min=1000, Max=288000000)]
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
        /// Gets and sets the property CodecLevel. Use Level (Mpeg2CodecLevel) to set the MPEG-2
        /// level for the video output.
        /// </summary>
        public Mpeg2CodecLevel CodecLevel
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
        /// Gets and sets the property CodecProfile. Use Profile (Mpeg2CodecProfile) to set the
        /// MPEG-2 profile for the video output.
        /// </summary>
        public Mpeg2CodecProfile CodecProfile
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
        public Mpeg2DynamicSubGop DynamicSubGop
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
        /// Gets and sets the property FramerateControl. If you are using the console, use the
        /// Framerate setting to specify the frame rate for this output. If you want to keep the
        /// same frame rate as the input video, choose Follow source. If you want to do frame
        /// rate conversion, choose a frame rate from the dropdown list or choose Custom. The
        /// framerates shown in the dropdown list are decimal approximations of fractions. If
        /// you choose Custom, specify your frame rate as a fraction. If you are creating your
        /// transcoding job sepecification as a JSON file without the console, use FramerateControl
        /// to specify which value the service uses for the frame rate for this output. Choose
        /// INITIALIZE_FROM_SOURCE if you want the service to use the frame rate from the input.
        /// Choose SPECIFIED if you want the service to use the frame rate you specify in the
        /// settings FramerateNumerator and FramerateDenominator.
        /// </summary>
        public Mpeg2FramerateControl FramerateControl
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
        /// Gets and sets the property FramerateConversionAlgorithm. When set to INTERPOLATE,
        /// produces smoother motion during frame rate conversion.
        /// </summary>
        public Mpeg2FramerateConversionAlgorithm FramerateConversionAlgorithm
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
        /// Gets and sets the property FramerateDenominator. Frame rate denominator.
        /// </summary>
        [AWSProperty(Min=1, Max=1001)]
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
        /// Gets and sets the property FramerateNumerator. Frame rate numerator - frame rate is
        /// a fraction, e.g. 24000 / 1001 = 23.976 fps.
        /// </summary>
        [AWSProperty(Min=24, Max=60000)]
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
        /// Gets and sets the property GopClosedCadence. Frequency of closed GOPs. In streaming
        /// applications, it is recommended that this be set to 1 so a decoder joining mid-stream
        /// will receive an IDR frame as quickly as possible. Setting this value to 0 will break
        /// output segmenting.
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
        /// Gets and sets the property GopSize. GOP Length (keyframe interval) in frames or seconds.
        /// Must be greater than zero.
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
        /// Gets and sets the property GopSizeUnits. Indicates if the GOP Size in MPEG2 is specified
        /// in frames or seconds. If seconds the system will convert the GOP Size into a frame
        /// count at run time.
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
        [AWSProperty(Min=0, Max=47185920)]
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
        /// Gets and sets the property InterlaceMode. Use Interlace mode (InterlaceMode) to choose
        /// the scan line type for the output. * Top Field First (TOP_FIELD) and Bottom Field
        /// First (BOTTOM_FIELD) produce interlaced output with the entire output having the same
        /// field polarity (top or bottom first). * Follow, Default Top (FOLLOW_TOP_FIELD) and
        /// Follow, Default Bottom (FOLLOW_BOTTOM_FIELD) use the same field polarity as the source.
        /// Therefore, behavior depends on the input scan type.  - If the source is interlaced,
        /// the output will be interlaced with the same polarity as the source (it will follow
        /// the source). The output could therefore be a mix of "top field first" and "bottom
        /// field first".  - If the source is progressive, the output will be interlaced with
        /// "top field first" or "bottom field first" polarity, depending on which of the Follow
        /// options you chose.
        /// </summary>
        public Mpeg2InterlaceMode InterlaceMode
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
        /// Gets and sets the property IntraDcPrecision. Use Intra DC precision (Mpeg2IntraDcPrecision)
        /// to set quantization precision for intra-block DC coefficients. If you choose the value
        /// auto, the service will automatically select the precision based on the per-frame compression
        /// ratio.
        /// </summary>
        public Mpeg2IntraDcPrecision IntraDcPrecision
        {
            get { return this._intraDcPrecision; }
            set { this._intraDcPrecision = value; }
        }

        // Check to see if IntraDcPrecision property is set
        internal bool IsSetIntraDcPrecision()
        {
            return this._intraDcPrecision != null;
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. Maximum bitrate in bits/second. For example,
        /// enter five megabits per second as 5000000.
        /// </summary>
        [AWSProperty(Min=1000, Max=300000000)]
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
        /// Gets and sets the property MinIInterval. Enforces separation between repeated (cadence)
        /// I-frames and I-frames inserted by Scene Change Detection. If a scene change I-frame
        /// is within I-interval frames of a cadence I-frame, the GOP is shrunk and/or stretched
        /// to the scene change I-frame. GOP stretch requires enabling lookahead as well as setting
        /// I-interval. The normal cadence resumes for the next GOP. This setting is only used
        /// when Scene Change Detect is enabled. Note: Maximum GOP stretch = GOP size + Min-I-interval
        /// - 1
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
        /// Gets and sets the property NumberBFramesBetweenReferenceFrames. Number of B-frames
        /// between reference frames.
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
        /// Gets and sets the property ParControl. Using the API, enable ParFollowSource if you
        /// want the service to use the pixel aspect ratio from the input. Using the console,
        /// do this by choosing Follow source for Pixel aspect ratio.
        /// </summary>
        public Mpeg2ParControl ParControl
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
        /// Gets and sets the property ParDenominator. Pixel Aspect Ratio denominator.
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
        /// Gets and sets the property ParNumerator. Pixel Aspect Ratio numerator.
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
        /// Gets and sets the property QualityTuningLevel. Use Quality tuning level (Mpeg2QualityTuningLevel)
        /// to specifiy whether to use single-pass or multipass video encoding.
        /// </summary>
        public Mpeg2QualityTuningLevel QualityTuningLevel
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
        /// Gets and sets the property RateControlMode. Use Rate control mode (Mpeg2RateControlMode)
        /// to specifiy whether the bitrate is variable (vbr) or constant (cbr).
        /// </summary>
        public Mpeg2RateControlMode RateControlMode
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
        /// Gets and sets the property SceneChangeDetect. Scene change detection (inserts I-frames
        /// on scene changes).
        /// </summary>
        public Mpeg2SceneChangeDetect SceneChangeDetect
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
        /// Gets and sets the property SlowPal. Enables Slow PAL rate conversion. 23.976fps and
        /// 24fps input is relabeled as 25fps, and audio is sped up correspondingly.
        /// </summary>
        public Mpeg2SlowPal SlowPal
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
        /// Gets and sets the property Softness. Softness. Selects quantizer matrix, larger values
        /// reduce high-frequency content in the encoded image.
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
        /// Gets and sets the property SpatialAdaptiveQuantization. Adjust quantization within
        /// each frame based on spatial variation of content complexity.
        /// </summary>
        public Mpeg2SpatialAdaptiveQuantization SpatialAdaptiveQuantization
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
        /// Gets and sets the property Syntax. Produces a Type D-10 compatible bitstream (SMPTE
        /// 356M-2001).
        /// </summary>
        public Mpeg2Syntax Syntax
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
        /// Gets and sets the property Telecine. Only use Telecine (Mpeg2Telecine) when you set
        /// Framerate (Framerate) to 29.970. Set Telecine (Mpeg2Telecine) to Hard (hard) to produce
        /// a 29.97i output from a 23.976 input. Set it to Soft (soft) to produce 23.976 output
        /// and leave converstion to the player.
        /// </summary>
        public Mpeg2Telecine Telecine
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
        /// Gets and sets the property TemporalAdaptiveQuantization. Adjust quantization within
        /// each frame based on temporal variation of content complexity.
        /// </summary>
        public Mpeg2TemporalAdaptiveQuantization TemporalAdaptiveQuantization
        {
            get { return this._temporalAdaptiveQuantization; }
            set { this._temporalAdaptiveQuantization = value; }
        }

        // Check to see if TemporalAdaptiveQuantization property is set
        internal bool IsSetTemporalAdaptiveQuantization()
        {
            return this._temporalAdaptiveQuantization != null;
        }

    }
}