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
    /// Eac3 Settings
    /// </summary>
    public partial class Eac3Settings
    {
        private Eac3AttenuationControl _attenuationControl;
        private double? _bitrate;
        private Eac3BitstreamMode _bitstreamMode;
        private Eac3CodingMode _codingMode;
        private Eac3DcFilter _dcFilter;
        private int? _dialnorm;
        private Eac3DrcLine _drcLine;
        private Eac3DrcRf _drcRf;
        private Eac3LfeControl _lfeControl;
        private Eac3LfeFilter _lfeFilter;
        private double? _loRoCenterMixLevel;
        private double? _loRoSurroundMixLevel;
        private double? _ltRtCenterMixLevel;
        private double? _ltRtSurroundMixLevel;
        private Eac3MetadataControl _metadataControl;
        private Eac3PassthroughControl _passthroughControl;
        private Eac3PhaseControl _phaseControl;
        private Eac3StereoDownmix _stereoDownmix;
        private Eac3SurroundExMode _surroundExMode;
        private Eac3SurroundMode _surroundMode;

        /// <summary>
        /// Gets and sets the property AttenuationControl. When set to attenuate3Db, applies a
        /// 3 dB attenuation to the surround channels. Only used for 3/2 coding mode.
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
        public double? Bitrate
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
        /// Gets and sets the property BitstreamMode. Specifies the bitstream mode (bsmod) for
        /// the emitted E-AC-3 stream. See ATSC A/52-2012 (Annex E) for background on these values.
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
        /// Gets and sets the property CodingMode. Dolby Digital Plus coding mode. Determines
        /// number of channels.
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
        /// Gets and sets the property DcFilter. When set to enabled, activates a DC highpass
        /// filter for all input channels.
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
        [AWSProperty(Min=1, Max=31)]
        public int? Dialnorm
        {
            get { return this._dialnorm; }
            set { this._dialnorm = value; }
        }

        // Check to see if Dialnorm property is set
        internal bool IsSetDialnorm()
        {
            return this._dialnorm.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DrcLine. Sets the Dolby dynamic range compression profile.
        /// </summary>
        public Eac3DrcLine DrcLine
        {
            get { return this._drcLine; }
            set { this._drcLine = value; }
        }

        // Check to see if DrcLine property is set
        internal bool IsSetDrcLine()
        {
            return this._drcLine != null;
        }

        /// <summary>
        /// Gets and sets the property DrcRf. Sets the profile for heavy Dolby dynamic range compression,
        /// ensures that the instantaneous signal peaks do not exceed specified levels.
        /// </summary>
        public Eac3DrcRf DrcRf
        {
            get { return this._drcRf; }
            set { this._drcRf = value; }
        }

        // Check to see if DrcRf property is set
        internal bool IsSetDrcRf()
        {
            return this._drcRf != null;
        }

        /// <summary>
        /// Gets and sets the property LfeControl. When encoding 3/2 audio, setting to lfe enables
        /// the LFE channel
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
        /// Gets and sets the property LfeFilter. When set to enabled, applies a 120Hz lowpass
        /// filter to the LFE channel prior to encoding. Only valid with codingMode32 coding mode.
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
        /// Only used for 3/2 coding mode.
        /// </summary>
        public double? LoRoCenterMixLevel
        {
            get { return this._loRoCenterMixLevel; }
            set { this._loRoCenterMixLevel = value; }
        }

        // Check to see if LoRoCenterMixLevel property is set
        internal bool IsSetLoRoCenterMixLevel()
        {
            return this._loRoCenterMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoRoSurroundMixLevel. Left only/Right only surround mix
        /// level. Only used for 3/2 coding mode.
        /// </summary>
        public double? LoRoSurroundMixLevel
        {
            get { return this._loRoSurroundMixLevel; }
            set { this._loRoSurroundMixLevel = value; }
        }

        // Check to see if LoRoSurroundMixLevel property is set
        internal bool IsSetLoRoSurroundMixLevel()
        {
            return this._loRoSurroundMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LtRtCenterMixLevel. Left total/Right total center mix level.
        /// Only used for 3/2 coding mode.
        /// </summary>
        public double? LtRtCenterMixLevel
        {
            get { return this._ltRtCenterMixLevel; }
            set { this._ltRtCenterMixLevel = value; }
        }

        // Check to see if LtRtCenterMixLevel property is set
        internal bool IsSetLtRtCenterMixLevel()
        {
            return this._ltRtCenterMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LtRtSurroundMixLevel. Left total/Right total surround mix
        /// level. Only used for 3/2 coding mode.
        /// </summary>
        public double? LtRtSurroundMixLevel
        {
            get { return this._ltRtSurroundMixLevel; }
            set { this._ltRtSurroundMixLevel = value; }
        }

        // Check to see if LtRtSurroundMixLevel property is set
        internal bool IsSetLtRtSurroundMixLevel()
        {
            return this._ltRtSurroundMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataControl. When set to followInput, encoder metadata
        /// will be sourced from the DD, DD+, or DolbyE decoder that supplied this audio data.
        /// If audio was not supplied from one of these streams, then the static metadata settings
        /// will be used.
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
        /// Gets and sets the property PassthroughControl. When set to whenPossible, input DD+
        /// audio will be passed through if it is present on the input. This detection is dynamic
        /// over the life of the transcode. Inputs that alternate between DD+ and non-DD+ content
        /// will have a consistent DD+ output as the system alternates between passthrough and
        /// encoding.
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
        /// Gets and sets the property PhaseControl. When set to shift90Degrees, applies a 90-degree
        /// phase shift to the surround channels. Only used for 3/2 coding mode.
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
        /// Gets and sets the property StereoDownmix. Stereo downmix preference. Only used for
        /// 3/2 coding mode.
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
        /// Gets and sets the property SurroundExMode. When encoding 3/2 audio, sets whether an
        /// extra center back surround channel is matrix encoded into the left and right surround
        /// channels.
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
        /// Gets and sets the property SurroundMode. When encoding 2/0 audio, sets whether Dolby
        /// Surround is matrix encoded into the two channels.
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