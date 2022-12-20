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
    /// H265 Settings
    /// </summary>
    public partial class H265Settings
    {
        private H265AdaptiveQuantization _adaptiveQuantization;
        private AfdSignaling _afdSignaling;
        private H265AlternativeTransferFunction _alternativeTransferFunction;
        private int? _bitrate;
        private int? _bufSize;
        private H265ColorMetadata _colorMetadata;
        private H265ColorSpaceSettings _colorSpaceSettings;
        private H265FilterSettings _filterSettings;
        private FixedAfd _fixedAfd;
        private H265FlickerAq _flickerAq;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private int? _gopClosedCadence;
        private double? _gopSize;
        private H265GopSizeUnits _gopSizeUnits;
        private H265Level _level;
        private H265LookAheadRateControl _lookAheadRateControl;
        private int? _maxBitrate;
        private int? _minIInterval;
        private int? _parDenominator;
        private int? _parNumerator;
        private H265Profile _profile;
        private int? _qvbrQualityLevel;
        private H265RateControlMode _rateControlMode;
        private H265ScanType _scanType;
        private H265SceneChangeDetect _sceneChangeDetect;
        private int? _slices;
        private H265Tier _tier;
        private TimecodeBurninSettings _timecodeBurninSettings;
        private H265TimecodeInsertionBehavior _timecodeInsertion;

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Adaptive quantization. Allows intra-frame
        /// quantizers to vary to improve visual quality.
        /// </summary>
        public H265AdaptiveQuantization AdaptiveQuantization
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
        /// Gets and sets the property AfdSignaling. Indicates that AFD values will be written
        /// into the output stream.  If afdSignaling is "auto", the system will try to preserve
        /// the input AFD value (in cases where multiple AFD values are valid). If set to "fixed",
        /// the AFD value will be the value configured in the fixedAfd parameter.
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
        /// Gets and sets the property AlternativeTransferFunction. Whether or not EML should
        /// insert an Alternative Transfer Function SEI message to support backwards compatibility
        /// with non-HDR decoders and displays.
        /// </summary>
        public H265AlternativeTransferFunction AlternativeTransferFunction
        {
            get { return this._alternativeTransferFunction; }
            set { this._alternativeTransferFunction = value; }
        }

        // Check to see if AlternativeTransferFunction property is set
        internal bool IsSetAlternativeTransferFunction()
        {
            return this._alternativeTransferFunction != null;
        }

        /// <summary>
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Required when
        /// the rate control mode is VBR or CBR. Not used for QVBR. In an MS Smooth output group,
        /// each output must have a unique value when its bitrate is rounded down to the nearest
        /// multiple of 1000.
        /// </summary>
        [AWSProperty(Min=100000, Max=40000000)]
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
        /// Gets and sets the property BufSize. Size of buffer (HRD buffer model) in bits.
        /// </summary>
        [AWSProperty(Min=100000, Max=80000000)]
        public int BufSize
        {
            get { return this._bufSize.GetValueOrDefault(); }
            set { this._bufSize = value; }
        }

        // Check to see if BufSize property is set
        internal bool IsSetBufSize()
        {
            return this._bufSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColorMetadata. Includes colorspace metadata in the output.
        /// </summary>
        public H265ColorMetadata ColorMetadata
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
        /// Gets and sets the property ColorSpaceSettings. Color Space settings
        /// </summary>
        public H265ColorSpaceSettings ColorSpaceSettings
        {
            get { return this._colorSpaceSettings; }
            set { this._colorSpaceSettings = value; }
        }

        // Check to see if ColorSpaceSettings property is set
        internal bool IsSetColorSpaceSettings()
        {
            return this._colorSpaceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property FilterSettings. Optional filters that you can apply to
        /// an encode.
        /// </summary>
        public H265FilterSettings FilterSettings
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
        /// Gets and sets the property FixedAfd. Four bit AFD value to write on all frames of
        /// video in the output stream. Only valid when afdSignaling is set to 'Fixed'.
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
        /// Gets and sets the property FlickerAq. If set to enabled, adjust quantization within
        /// each frame to reduce flicker or 'pop' on I-frames.
        /// </summary>
        public H265FlickerAq FlickerAq
        {
            get { return this._flickerAq; }
            set { this._flickerAq = value; }
        }

        // Check to see if FlickerAq property is set
        internal bool IsSetFlickerAq()
        {
            return this._flickerAq != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateDenominator. Framerate denominator.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3003)]
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
        /// Gets and sets the property FramerateNumerator. Framerate numerator - framerate is
        /// a fraction, e.g. 24000 / 1001 = 23.976 fps.
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
        /// Gets and sets the property GopClosedCadence. Frequency of closed GOPs. In streaming
        /// applications, it is recommended that this be set to 1 so a decoder joining mid-stream
        /// will receive an IDR frame as quickly as possible. Setting this value to 0 will break
        /// output segmenting.
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
        /// Gets and sets the property GopSize. GOP size (keyframe interval) in units of either
        /// frames or seconds per gopSizeUnits.If gopSizeUnits is frames, gopSize must be an integer
        /// and must be greater than or equal to 1.If gopSizeUnits is seconds, gopSize must be
        /// greater than 0, but need not be an integer.
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
        /// Gets and sets the property GopSizeUnits. Indicates if the gopSize is specified in
        /// frames or seconds. If seconds the system will convert the gopSize into a frame count
        /// at run time.
        /// </summary>
        public H265GopSizeUnits GopSizeUnits
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
        /// Gets and sets the property Level. H.265 Level.
        /// </summary>
        public H265Level Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

        /// <summary>
        /// Gets and sets the property LookAheadRateControl. Amount of lookahead. A value of low
        /// can decrease latency and memory usage, while high can produce better quality for certain
        /// content.
        /// </summary>
        public H265LookAheadRateControl LookAheadRateControl
        {
            get { return this._lookAheadRateControl; }
            set { this._lookAheadRateControl = value; }
        }

        // Check to see if LookAheadRateControl property is set
        internal bool IsSetLookAheadRateControl()
        {
            return this._lookAheadRateControl != null;
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. For QVBR: See the tooltip for Quality level
        /// </summary>
        [AWSProperty(Min=100000, Max=40000000)]
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
        /// Gets and sets the property MinIInterval. Only meaningful if sceneChangeDetect is set
        /// to enabled.  Defaults to 5 if multiplex rate control is used.  Enforces separation
        /// between repeated (cadence) I-frames and I-frames inserted by Scene Change Detection.
        /// If a scene change I-frame is within I-interval frames of a cadence I-frame, the GOP
        /// is shrunk and/or stretched to the scene change I-frame. GOP stretch requires enabling
        /// lookahead as well as setting I-interval. The normal cadence resumes for the next GOP.
        /// Note: Maximum GOP stretch = GOP size + Min-I-interval - 1
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
        /// Gets and sets the property ParDenominator. Pixel Aspect Ratio denominator.
        /// </summary>
        [AWSProperty(Min=1)]
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
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property Profile. H.265 Profile.
        /// </summary>
        public H265Profile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

        /// <summary>
        /// Gets and sets the property QvbrQualityLevel. Controls the target quality for the video
        /// encode. Applies only when the rate control mode is QVBR. Set values for the QVBR quality
        /// level field and Max bitrate field that suit your most important viewing devices. Recommended
        /// values are:- Primary screen: Quality level: 8 to 10. Max bitrate: 4M- PC or tablet:
        /// Quality level: 7. Max bitrate: 1.5M to 3M- Smartphone: Quality level: 6. Max bitrate:
        /// 1M to 1.5M
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int QvbrQualityLevel
        {
            get { return this._qvbrQualityLevel.GetValueOrDefault(); }
            set { this._qvbrQualityLevel = value; }
        }

        // Check to see if QvbrQualityLevel property is set
        internal bool IsSetQvbrQualityLevel()
        {
            return this._qvbrQualityLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RateControlMode. Rate control mode.QVBR: Quality will match
        /// the specified quality level except when it is constrained by themaximum bitrate. 
        /// Recommended if you or your viewers pay for bandwidth.CBR: Quality varies, depending
        /// on the video complexity. Recommended only if you distributeyour assets to devices
        /// that cannot handle variable bitrates.Multiplex: This rate control mode is only supported
        /// (and is required) when the video is beingdelivered to a MediaLive Multiplex in which
        /// case the rate control configuration is controlledby the properties within the Multiplex
        /// Program.
        /// </summary>
        public H265RateControlMode RateControlMode
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
        /// Gets and sets the property ScanType. Sets the scan type of the output to progressive
        /// or top-field-first interlaced.
        /// </summary>
        public H265ScanType ScanType
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
        /// Gets and sets the property SceneChangeDetect. Scene change detection.
        /// </summary>
        public H265SceneChangeDetect SceneChangeDetect
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
        /// or equal to half the number of macroblock rows for interlaced pictures.This field
        /// is optional; when no value is specified the encoder will choose the number of slices
        /// based on encode resolution.
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
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
        /// Gets and sets the property Tier. H.265 Tier.
        /// </summary>
        public H265Tier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
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
        /// Gets and sets the property TimecodeInsertion. Determines how timecodes should be inserted
        /// into the video elementary stream.- 'disabled': Do not include timecodes- 'picTimingSei':
        /// Pass through picture timing SEI messages from the source specified in Timecode Config
        /// </summary>
        public H265TimecodeInsertionBehavior TimecodeInsertion
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