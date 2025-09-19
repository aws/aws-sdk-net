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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Av1 Settings
    /// </summary>
    public partial class Av1Settings
    {
        private AfdSignaling _afdSignaling;
        private int? _bitrate;
        private int? _bufSize;
        private Av1ColorSpaceSettings _colorSpaceSettings;
        private FixedAfd _fixedAfd;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private double? _gopSize;
        private Av1GopSizeUnits _gopSizeUnits;
        private Av1Level _level;
        private Av1LookAheadRateControl _lookAheadRateControl;
        private int? _maxBitrate;
        private int? _minBitrate;
        private int? _minIInterval;
        private int? _parDenominator;
        private int? _parNumerator;
        private int? _qvbrQualityLevel;
        private Av1RateControlMode _rateControlMode;
        private Av1SceneChangeDetect _sceneChangeDetect;
        private TimecodeBurninSettings _timecodeBurninSettings;

        /// <summary>
        /// Gets and sets the property AfdSignaling. Configures whether MediaLive will write AFD
        /// values into the video.AUTO: MediaLive will try to preserve the input AFD value (in
        /// cases where multiple AFD values are valid).FIXED: the AFD value will be the value
        /// configured in the fixedAfd parameter.NONE: MediaLive won't write AFD into the video
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
        /// the rate control mode is CBR. Not used for QVBR.
        /// </summary>
        [AWSProperty(Min=50000, Max=12000000)]
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
        /// Gets and sets the property BufSize. The size of the buffer (HRD buffer model) in bits.
        /// </summary>
        [AWSProperty(Min=50000, Max=24000000)]
        public int? BufSize
        {
            get { return this._bufSize; }
            set { this._bufSize = value; }
        }

        // Check to see if BufSize property is set
        internal bool IsSetBufSize()
        {
            return this._bufSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColorSpaceSettings. Color Space settings
        /// </summary>
        public Av1ColorSpaceSettings ColorSpaceSettings
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
        /// Gets and sets the property FixedAfd. Complete this property only if you set the afdSignaling
        /// property to FIXED. Choose the AFD value (4 bits) to write on all frames of the video
        /// encode.
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
        /// Gets and sets the property FramerateDenominator. The denominator for the framerate.
        /// Framerate is a fraction, for example, 24000 / 1001.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3003)]
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
        /// Gets and sets the property FramerateNumerator. The numerator for the framerate. Framerate
        /// is a fraction, for example, 24000 / 1001.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property GopSize. The GOP size (keyframe interval).If GopSizeUnits
        /// is frames, GopSize must be a whole number and must be greater than or equal to 1.If
        /// GopSizeUnits is seconds, GopSize must be greater than 0, but it can be a decimal.
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
        /// Gets and sets the property GopSizeUnits. Choose the units for the GOP size: FRAMES
        /// or SECONDS. For SECONDS, MediaLive converts the size into a frame count at run time.
        /// </summary>
        public Av1GopSizeUnits GopSizeUnits
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
        /// Gets and sets the property Level. Sets the level. This parameter is one of the properties
        /// of the encoding scheme for AV1.
        /// </summary>
        public Av1Level Level
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
        /// Gets and sets the property LookAheadRateControl. Sets the amount of lookahead. A value
        /// of LOW can decrease latency and memory usage. A value of HIGH can produce better quality
        /// for certain content.
        /// </summary>
        public Av1LookAheadRateControl LookAheadRateControl
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
        /// Gets and sets the property MaxBitrate. The maximum bitrate to assign.For recommendations,
        /// see the description for qvbrQualityLevel.
        /// </summary>
        [AWSProperty(Min=50000, Max=12000000)]
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
        /// Gets and sets the property MinBitrate. Used for QVBR rate control mode only.Optional.Enter
        /// a minimum bitrate if you want to keep the output bitrate about a threshold, in order
        /// to prevent the downstream system from de-allocating network bandwidth for this output.
        /// </summary>
        [AWSProperty(Min=0, Max=8000000)]
        public int? MinBitrate
        {
            get { return this._minBitrate; }
            set { this._minBitrate = value; }
        }

        // Check to see if MinBitrate property is set
        internal bool IsSetMinBitrate()
        {
            return this._minBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIInterval. Applies only if you enable SceneChangeDetect.
        /// Sets the interval between frames. This property ensures a minimum separation between
        /// repeated (cadence) I-frames and any I-frames inserted by scene change detection (SCD
        /// frames).Enter a number for the interval, measured in number of frames.If an SCD frame
        /// and a cadence frame are closer than the specified number of frames, MediaLive shrinks
        /// or stretches the GOP to include the SCD frame. Then normal cadence resumes in the
        /// next GOP. For GOP stretch to succeed, you must enable LookAheadRateControl.Note that
        /// the maximum GOP stretch = (GOP size) + (Minimum I-interval) - 1
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
        /// Gets and sets the property ParDenominator. The denominator for the output pixel aspect
        /// ratio (PAR).
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property ParNumerator. The numerator for the output pixel aspect
        /// ratio (PAR).
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property QvbrQualityLevel. Controls the target quality for the video
        /// encode. With QVBR rate control mode, the final quality is the target quality, constrained
        /// by the maxBitrate.Set values for the qvbrQualityLevel property and maxBitrate property
        /// that suit your most important viewing devices.To let MediaLive set the quality level
        /// (AUTO mode), leave the qvbrQualityLevel field empty. In this case, MediaLive uses
        /// the maximum bitrate, and the quality follows from that: more complex content might
        /// have a lower quality.Or set a target quality level and a maximum bitrate. With more
        /// complex content, MediaLive will try to achieve the target quality, but it won't exceed
        /// the maximum bitrate. With less complex content, This option will use only the bitrate
        /// needed to reach the target quality.Recommended values are:Primary screen: qvbrQualityLevel:
        /// Leave empty. maxBitrate: 4,000,000PC or tablet: qvbrQualityLevel: Leave empty. maxBitrate:
        /// 1,500,000 to 3,000,000Smartphone: qvbrQualityLevel: Leave empty. maxBitrate: 1,000,000
        /// to 1,500,000
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? QvbrQualityLevel
        {
            get { return this._qvbrQualityLevel; }
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
        /// that cannot handle variable bitrates.
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
        /// Gets and sets the property SceneChangeDetect. Controls whether MediaLive inserts I-frames
        /// when it detects a scene change. ENABLED or DISABLED.
        /// </summary>
        public Av1SceneChangeDetect SceneChangeDetect
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
        /// Gets and sets the property TimecodeBurninSettings. Configures the timecode burn-in
        /// feature. If you enable this feature, the timecode will become part of the video.
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

    }
}