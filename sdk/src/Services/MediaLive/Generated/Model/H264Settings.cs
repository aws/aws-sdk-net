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
    /// H264 Settings
    /// </summary>
    public partial class H264Settings
    {
        private H264AdaptiveQuantization _adaptiveQuantization;
        private AfdSignaling _afdSignaling;
        private int? _bitrate;
        private int? _bufFillPct;
        private int? _bufSize;
        private H264ColorMetadata _colorMetadata;
        private H264ColorSpaceSettings _colorSpaceSettings;
        private H264EntropyEncoding _entropyEncoding;
        private H264FilterSettings _filterSettings;
        private FixedAfd _fixedAfd;
        private H264FlickerAq _flickerAq;
        private H264ForceFieldPictures _forceFieldPictures;
        private H264FramerateControl _framerateControl;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private H264GopBReference _gopBReference;
        private int? _gopClosedCadence;
        private int? _gopNumBFrames;
        private double? _gopSize;
        private H264GopSizeUnits _gopSizeUnits;
        private H264Level _level;
        private H264LookAheadRateControl _lookAheadRateControl;
        private int? _maxBitrate;
        private int? _minIInterval;
        private int? _numRefFrames;
        private H264ParControl _parControl;
        private int? _parDenominator;
        private int? _parNumerator;
        private H264Profile _profile;
        private H264QualityLevel _qualityLevel;
        private int? _qvbrQualityLevel;
        private H264RateControlMode _rateControlMode;
        private H264ScanType _scanType;
        private H264SceneChangeDetect _sceneChangeDetect;
        private int? _slices;
        private int? _softness;
        private H264SpatialAq _spatialAq;
        private H264SubGopLength _subgopLength;
        private H264Syntax _syntax;
        private H264TemporalAq _temporalAq;
        private TimecodeBurninSettings _timecodeBurninSettings;
        private H264TimecodeInsertionBehavior _timecodeInsertion;

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Enables or disables adaptive quantization,
        /// which is a technique MediaLive can apply to video on a frame-by-frame basis to produce
        /// more compression without losing quality. There are three types of adaptive quantization:
        /// flicker, spatial, and temporal. Set the field in one of these ways: Set to Auto. Recommended.
        /// For each type of AQ, MediaLive will determine if AQ is needed, and if so, the appropriate
        /// strength. Set a strength (a value other than Auto or Disable). This strength will
        /// apply to any of the AQ fields that you choose to enable. Set to Disabled to disable
        /// all types of adaptive quantization.
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
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Required when
        /// the rate control mode is VBR or CBR. Not used for QVBR. In an MS Smooth output group,
        /// each output must have a unique value when its bitrate is rounded down to the nearest
        /// multiple of 1000.
        /// </summary>
        [AWSProperty(Min=1000)]
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
        /// Gets and sets the property BufFillPct. Percentage of the buffer that should initially
        /// be filled (HRD buffer model).
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int BufFillPct
        {
            get { return this._bufFillPct.GetValueOrDefault(); }
            set { this._bufFillPct = value; }
        }

        // Check to see if BufFillPct property is set
        internal bool IsSetBufFillPct()
        {
            return this._bufFillPct.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BufSize. Size of buffer (HRD buffer model) in bits.
        /// </summary>
        [AWSProperty(Min=0)]
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
        public H264ColorMetadata ColorMetadata
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
        public H264ColorSpaceSettings ColorSpaceSettings
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
        /// Gets and sets the property EntropyEncoding. Entropy encoding mode.  Use cabac (must
        /// be in Main or High profile) or cavlc.
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
        /// Gets and sets the property FilterSettings. Optional filters that you can apply to
        /// an encode.
        /// </summary>
        public H264FilterSettings FilterSettings
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
        /// Gets and sets the property FlickerAq. Flicker AQ makes adjustments within each frame
        /// to reduce flicker or 'pop' on I-frames. The value to enter in this field depends on
        /// the value in the Adaptive quantization field: If you have set the Adaptive quantization
        /// field to Auto, MediaLive ignores any value in this field. MediaLive will determine
        /// if flicker AQ is appropriate and will apply the appropriate strength. If you have
        /// set the Adaptive quantization field to a strength, you can set this field to Enabled
        /// or Disabled. Enabled: MediaLive will apply flicker AQ using the specified strength.
        /// Disabled: MediaLive won't apply flicker AQ. If you have set the Adaptive quantization
        /// to Disabled, MediaLive ignores any value in this field and doesn't apply flicker AQ.
        /// </summary>
        public H264FlickerAq FlickerAq
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
        /// Gets and sets the property ForceFieldPictures. This setting applies only when scan
        /// type is "interlaced." It controls whether coding is performed on a field basis or
        /// on a frame basis. (When the video is progressive, the coding is always performed on
        /// a frame basis.)enabled: Force MediaLive to code on a field basis, so that odd and
        /// even sets of fields are coded separately.disabled: Code the two sets of fields separately
        /// (on a field basis) or together (on a frame basis using PAFF), depending on what is
        /// most appropriate for the content.
        /// </summary>
        public H264ForceFieldPictures ForceFieldPictures
        {
            get { return this._forceFieldPictures; }
            set { this._forceFieldPictures = value; }
        }

        // Check to see if ForceFieldPictures property is set
        internal bool IsSetForceFieldPictures()
        {
            return this._forceFieldPictures != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateControl. This field indicates how the output video
        /// frame rate is specified.  If "specified" is selected then the output video frame rate
        /// is determined by framerateNumerator and framerateDenominator, else if "initializeFromSource"
        /// is selected then the output video frame rate will be set equal to the input video
        /// frame rate of the first input.
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
        /// Gets and sets the property FramerateDenominator. Framerate denominator.
        /// </summary>
        [AWSProperty(Min=1)]
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
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property GopBReference. Documentation update needed
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
        /// Gets and sets the property GopNumBFrames. Number of B-frames between reference frames.
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
        /// Gets and sets the property Level. H.264 Level.
        /// </summary>
        public H264Level Level
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
        public H264LookAheadRateControl LookAheadRateControl
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
        /// Gets and sets the property MaxBitrate. For QVBR: See the tooltip for Quality levelFor
        /// VBR: Set the maximum bitrate in order to accommodate expected spikes in the complexity
        /// of the video.
        /// </summary>
        [AWSProperty(Min=1000)]
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
        /// Gets and sets the property NumRefFrames. Number of reference frames to use. The encoder
        /// may use more than requested if using B-frames and/or interlaced encoding.
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public int NumRefFrames
        {
            get { return this._numRefFrames.GetValueOrDefault(); }
            set { this._numRefFrames = value; }
        }

        // Check to see if NumRefFrames property is set
        internal bool IsSetNumRefFrames()
        {
            return this._numRefFrames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParControl. This field indicates how the output pixel aspect
        /// ratio is specified.  If "specified" is selected then the output video pixel aspect
        /// ratio is determined by parNumerator and parDenominator, else if "initializeFromSource"
        /// is selected then the output pixsel aspect ratio will be set equal to the input video
        /// pixel aspect ratio of the first input.
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
        /// Gets and sets the property Profile. H.264 Profile.
        /// </summary>
        public H264Profile Profile
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
        /// Gets and sets the property QualityLevel. Leave as STANDARD_QUALITY or choose a different
        /// value (which might result in additional costs to run the channel).- ENHANCED_QUALITY:
        /// Produces a slightly better video quality without an increase in the bitrate. Has an
        /// effect only when the Rate control mode is QVBR or CBR. If this channel is in a MediaLive
        /// multiplex, the value must be ENHANCED_QUALITY.- STANDARD_QUALITY: Valid for any Rate
        /// control mode.
        /// </summary>
        public H264QualityLevel QualityLevel
        {
            get { return this._qualityLevel; }
            set { this._qualityLevel = value; }
        }

        // Check to see if QualityLevel property is set
        internal bool IsSetQualityLevel()
        {
            return this._qualityLevel != null;
        }

        /// <summary>
        /// Gets and sets the property QvbrQualityLevel. Controls the target quality for the video
        /// encode. Applies only when the rate control mode is QVBR. You can set a target quality
        /// or you can let MediaLive determine the best quality. To set a target quality, enter
        /// values in the QVBR quality level field and the Max bitrate field. Enter values that
        /// suit your most important viewing devices. Recommended values are:- Primary screen:
        /// Quality level: 8 to 10. Max bitrate: 4M- PC or tablet: Quality level: 7. Max bitrate:
        /// 1.5M to 3M- Smartphone: Quality level: 6. Max bitrate: 1M to 1.5MTo let MediaLive
        /// decide, leave the QVBR quality level field empty, and in Max bitrate enter the maximum
        /// rate you want in the video. For more information, see the section called "Video -
        /// rate control mode" in the MediaLive user guide
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
        /// Recommended if you or your viewers pay for bandwidth.VBR: Quality and bitrate vary,
        /// depending on the video complexity. Recommended instead of QVBRif you want to maintain
        /// a specific average bitrate over the duration of the channel.CBR: Quality varies, depending
        /// on the video complexity. Recommended only if you distributeyour assets to devices
        /// that cannot handle variable bitrates.Multiplex: This rate control mode is only supported
        /// (and is required) when the video is beingdelivered to a MediaLive Multiplex in which
        /// case the rate control configuration is controlledby the properties within the Multiplex
        /// Program.
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
        /// Gets and sets the property ScanType. Sets the scan type of the output to progressive
        /// or top-field-first interlaced.
        /// </summary>
        public H264ScanType ScanType
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
        /// Gets and sets the property SceneChangeDetect. Scene change detection.- On: inserts
        /// I-frames when scene change is detected.- Off: does not force an I-frame when scene
        /// change is detected.
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
        /// or equal to half the number of macroblock rows for interlaced pictures.This field
        /// is optional; when no value is specified the encoder will choose the number of slices
        /// based on encode resolution.
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
        /// Gets and sets the property Softness. Softness. Selects quantizer matrix, larger values
        /// reduce high-frequency content in the encoded image.  If not set to zero, must be greater
        /// than 15.
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
        /// Gets and sets the property SpatialAq. Spatial AQ makes adjustments within each frame
        /// based on spatial variation of content complexity. The value to enter in this field
        /// depends on the value in the Adaptive quantization field: If you have set the Adaptive
        /// quantization field to Auto, MediaLive ignores any value in this field. MediaLive will
        /// determine if spatial AQ is appropriate and will apply the appropriate strength. If
        /// you have set the Adaptive quantization field to a strength, you can set this field
        /// to Enabled or Disabled. Enabled: MediaLive will apply spatial AQ using the specified
        /// strength. Disabled: MediaLive won't apply spatial AQ. If you have set the Adaptive
        /// quantization to Disabled, MediaLive ignores any value in this field and doesn't apply
        /// spatial AQ.
        /// </summary>
        public H264SpatialAq SpatialAq
        {
            get { return this._spatialAq; }
            set { this._spatialAq = value; }
        }

        // Check to see if SpatialAq property is set
        internal bool IsSetSpatialAq()
        {
            return this._spatialAq != null;
        }

        /// <summary>
        /// Gets and sets the property SubgopLength. If set to fixed, use gopNumBFrames B-frames
        /// per sub-GOP. If set to dynamic, optimize the number of B-frames used for each sub-GOP
        /// to improve visual quality.
        /// </summary>
        public H264SubGopLength SubgopLength
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
        /// Gets and sets the property TemporalAq. Temporal makes adjustments within each frame
        /// based on temporal variation of content complexity. The value to enter in this field
        /// depends on the value in the Adaptive quantization field: If you have set the Adaptive
        /// quantization field to Auto, MediaLive ignores any value in this field. MediaLive will
        /// determine if temporal AQ is appropriate and will apply the appropriate strength. If
        /// you have set the Adaptive quantization field to a strength, you can set this field
        /// to Enabled or Disabled. Enabled: MediaLive will apply temporal AQ using the specified
        /// strength. Disabled: MediaLive won't apply temporal AQ. If you have set the Adaptive
        /// quantization to Disabled, MediaLive ignores any value in this field and doesn't apply
        /// temporal AQ.
        /// </summary>
        public H264TemporalAq TemporalAq
        {
            get { return this._temporalAq; }
            set { this._temporalAq = value; }
        }

        // Check to see if TemporalAq property is set
        internal bool IsSetTemporalAq()
        {
            return this._temporalAq != null;
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
        public H264TimecodeInsertionBehavior TimecodeInsertion
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