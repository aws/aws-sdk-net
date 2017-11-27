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
    /// Required when you set (Codec) under (AudioDescriptions)>(CodecSettings) to the value
    /// EAC3.
    /// </summary>
    public partial class Eac3Settings
    {
        private Eac3AttenuationControl _attenuationControl;
        private int? _bitrate;
        private Eac3BitstreamMode _bitstreamMode;
        private Eac3CodingMode _codingMode;
        private Eac3DcFilter _dcFilter;
        private int? _dialnorm;
        private Eac3DynamicRangeCompressionLine _dynamicRangeCompressionLine;
        private Eac3DynamicRangeCompressionRf _dynamicRangeCompressionRf;
        private Eac3LfeControl _lfeControl;
        private Eac3LfeFilter _lfeFilter;
        private double? _loRoCenterMixLevel;
        private double? _loRoSurroundMixLevel;
        private double? _ltRtCenterMixLevel;
        private double? _ltRtSurroundMixLevel;
        private Eac3MetadataControl _metadataControl;
        private Eac3PassthroughControl _passthroughControl;
        private Eac3PhaseControl _phaseControl;
        private int? _sampleRate;
        private Eac3StereoDownmix _stereoDownmix;
        private Eac3SurroundExMode _surroundExMode;
        private Eac3SurroundMode _surroundMode;

        /// <summary>
        /// Gets and sets the property AttenuationControl.
        /// </summary>
        public Eac3AttenuationControl AttenuationControl
        {
            get { return this._attenuationControl; }
            set { this._attenuationControl = value; }
        }

        // Check to see if AttenuationControl property is set
        internal bool IsSetAttenuationControl()
        {
            return this._attenuationControl != null;
        }

        /// <summary>
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Valid bitrates
        /// depend on the coding mode.
        /// </summary>
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
        /// Gets and sets the property BitstreamMode.
        /// </summary>
        public Eac3BitstreamMode BitstreamMode
        {
            get { return this._bitstreamMode; }
            set { this._bitstreamMode = value; }
        }

        // Check to see if BitstreamMode property is set
        internal bool IsSetBitstreamMode()
        {
            return this._bitstreamMode != null;
        }

        /// <summary>
        /// Gets and sets the property CodingMode.
        /// </summary>
        public Eac3CodingMode CodingMode
        {
            get { return this._codingMode; }
            set { this._codingMode = value; }
        }

        // Check to see if CodingMode property is set
        internal bool IsSetCodingMode()
        {
            return this._codingMode != null;
        }

        /// <summary>
        /// Gets and sets the property DcFilter.
        /// </summary>
        public Eac3DcFilter DcFilter
        {
            get { return this._dcFilter; }
            set { this._dcFilter = value; }
        }

        // Check to see if DcFilter property is set
        internal bool IsSetDcFilter()
        {
            return this._dcFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Dialnorm. Sets the dialnorm for the output. If blank and
        /// input audio is Dolby Digital Plus, dialnorm will be passed through.
        /// </summary>
        public int Dialnorm
        {
            get { return this._dialnorm.GetValueOrDefault(); }
            set { this._dialnorm = value; }
        }

        // Check to see if Dialnorm property is set
        internal bool IsSetDialnorm()
        {
            return this._dialnorm.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionLine.
        /// </summary>
        public Eac3DynamicRangeCompressionLine DynamicRangeCompressionLine
        {
            get { return this._dynamicRangeCompressionLine; }
            set { this._dynamicRangeCompressionLine = value; }
        }

        // Check to see if DynamicRangeCompressionLine property is set
        internal bool IsSetDynamicRangeCompressionLine()
        {
            return this._dynamicRangeCompressionLine != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionRf.
        /// </summary>
        public Eac3DynamicRangeCompressionRf DynamicRangeCompressionRf
        {
            get { return this._dynamicRangeCompressionRf; }
            set { this._dynamicRangeCompressionRf = value; }
        }

        // Check to see if DynamicRangeCompressionRf property is set
        internal bool IsSetDynamicRangeCompressionRf()
        {
            return this._dynamicRangeCompressionRf != null;
        }

        /// <summary>
        /// Gets and sets the property LfeControl.
        /// </summary>
        public Eac3LfeControl LfeControl
        {
            get { return this._lfeControl; }
            set { this._lfeControl = value; }
        }

        // Check to see if LfeControl property is set
        internal bool IsSetLfeControl()
        {
            return this._lfeControl != null;
        }

        /// <summary>
        /// Gets and sets the property LfeFilter.
        /// </summary>
        public Eac3LfeFilter LfeFilter
        {
            get { return this._lfeFilter; }
            set { this._lfeFilter = value; }
        }

        // Check to see if LfeFilter property is set
        internal bool IsSetLfeFilter()
        {
            return this._lfeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property LoRoCenterMixLevel. Left only/Right only center mix level.
        /// Only used for 3/2 coding mode.Valid values: 3.0, 1.5, 0.0, -1.5 -3.0 -4.5 -6.0 -60
        /// </summary>
        public double LoRoCenterMixLevel
        {
            get { return this._loRoCenterMixLevel.GetValueOrDefault(); }
            set { this._loRoCenterMixLevel = value; }
        }

        // Check to see if LoRoCenterMixLevel property is set
        internal bool IsSetLoRoCenterMixLevel()
        {
            return this._loRoCenterMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoRoSurroundMixLevel. Left only/Right only surround mix
        /// level. Only used for 3/2 coding mode.Valid values: -1.5 -3.0 -4.5 -6.0 -60
        /// </summary>
        public double LoRoSurroundMixLevel
        {
            get { return this._loRoSurroundMixLevel.GetValueOrDefault(); }
            set { this._loRoSurroundMixLevel = value; }
        }

        // Check to see if LoRoSurroundMixLevel property is set
        internal bool IsSetLoRoSurroundMixLevel()
        {
            return this._loRoSurroundMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LtRtCenterMixLevel. Left total/Right total center mix level.
        /// Only used for 3/2 coding mode.Valid values: 3.0, 1.5, 0.0, -1.5 -3.0 -4.5 -6.0 -60
        /// </summary>
        public double LtRtCenterMixLevel
        {
            get { return this._ltRtCenterMixLevel.GetValueOrDefault(); }
            set { this._ltRtCenterMixLevel = value; }
        }

        // Check to see if LtRtCenterMixLevel property is set
        internal bool IsSetLtRtCenterMixLevel()
        {
            return this._ltRtCenterMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LtRtSurroundMixLevel. Left total/Right total surround mix
        /// level. Only used for 3/2 coding mode.Valid values: -1.5 -3.0 -4.5 -6.0 -60
        /// </summary>
        public double LtRtSurroundMixLevel
        {
            get { return this._ltRtSurroundMixLevel.GetValueOrDefault(); }
            set { this._ltRtSurroundMixLevel = value; }
        }

        // Check to see if LtRtSurroundMixLevel property is set
        internal bool IsSetLtRtSurroundMixLevel()
        {
            return this._ltRtSurroundMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataControl.
        /// </summary>
        public Eac3MetadataControl MetadataControl
        {
            get { return this._metadataControl; }
            set { this._metadataControl = value; }
        }

        // Check to see if MetadataControl property is set
        internal bool IsSetMetadataControl()
        {
            return this._metadataControl != null;
        }

        /// <summary>
        /// Gets and sets the property PassthroughControl.
        /// </summary>
        public Eac3PassthroughControl PassthroughControl
        {
            get { return this._passthroughControl; }
            set { this._passthroughControl = value; }
        }

        // Check to see if PassthroughControl property is set
        internal bool IsSetPassthroughControl()
        {
            return this._passthroughControl != null;
        }

        /// <summary>
        /// Gets and sets the property PhaseControl.
        /// </summary>
        public Eac3PhaseControl PhaseControl
        {
            get { return this._phaseControl; }
            set { this._phaseControl = value; }
        }

        // Check to see if PhaseControl property is set
        internal bool IsSetPhaseControl()
        {
            return this._phaseControl != null;
        }

        /// <summary>
        /// Gets and sets the property SampleRate. Sample rate in hz. Sample rate is always 48000.
        /// </summary>
        public int SampleRate
        {
            get { return this._sampleRate.GetValueOrDefault(); }
            set { this._sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StereoDownmix.
        /// </summary>
        public Eac3StereoDownmix StereoDownmix
        {
            get { return this._stereoDownmix; }
            set { this._stereoDownmix = value; }
        }

        // Check to see if StereoDownmix property is set
        internal bool IsSetStereoDownmix()
        {
            return this._stereoDownmix != null;
        }

        /// <summary>
        /// Gets and sets the property SurroundExMode.
        /// </summary>
        public Eac3SurroundExMode SurroundExMode
        {
            get { return this._surroundExMode; }
            set { this._surroundExMode = value; }
        }

        // Check to see if SurroundExMode property is set
        internal bool IsSetSurroundExMode()
        {
            return this._surroundExMode != null;
        }

        /// <summary>
        /// Gets and sets the property SurroundMode.
        /// </summary>
        public Eac3SurroundMode SurroundMode
        {
            get { return this._surroundMode; }
            set { this._surroundMode = value; }
        }

        // Check to see if SurroundMode property is set
        internal bool IsSetSurroundMode()
        {
            return this._surroundMode != null;
        }

    }
}