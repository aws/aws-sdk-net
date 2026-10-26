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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Eac3 Settings
    /// </summary>
    public partial class Eac3Settings
    {
        /// <summary>
        /// Gets and sets the property AttenuationControl. When set to attenuate3Db, applies a
        /// 3 dB attenuation to the surround channels. Only used for 3/2 coding mode.
        /// </summary>
        public Eac3AttenuationControl AttenuationControl { get; set; }

        /// <summary>
        /// Checks to see if the AttenuationControl property is set.
        /// </summary>
        internal bool IsSetAttenuationControl() => this.AttenuationControl != null;

        /// <summary>
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Valid bitrates
        /// depend on the coding mode.
        /// </summary>
        public double? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property BitstreamMode. Specifies the bitstream mode (bsmod) for
        /// the emitted E-AC-3 stream. See ATSC A/52-2012 (Annex E) for background on these values.
        /// </summary>
        public Eac3BitstreamMode BitstreamMode { get; set; }

        /// <summary>
        /// Checks to see if the BitstreamMode property is set.
        /// </summary>
        internal bool IsSetBitstreamMode() => this.BitstreamMode != null;

        /// <summary>
        /// Gets and sets the property CodingMode. Dolby Digital Plus coding mode. Determines
        /// number of channels.
        /// </summary>
        public Eac3CodingMode CodingMode { get; set; }

        /// <summary>
        /// Checks to see if the CodingMode property is set.
        /// </summary>
        internal bool IsSetCodingMode() => this.CodingMode != null;

        /// <summary>
        /// Gets and sets the property DcFilter. When set to enabled, activates a DC highpass
        /// filter for all input channels.
        /// </summary>
        public Eac3DcFilter DcFilter { get; set; }

        /// <summary>
        /// Checks to see if the DcFilter property is set.
        /// </summary>
        internal bool IsSetDcFilter() => this.DcFilter != null;

        /// <summary>
        /// Gets and sets the property Dialnorm. Sets the dialnorm for the output. If blank and
        /// input audio is Dolby Digital Plus, dialnorm will be passed through.
        /// </summary>
        public int? Dialnorm { get; set; }

        /// <summary>
        /// Checks to see if the Dialnorm property is set.
        /// </summary>
        internal bool IsSetDialnorm() => this.Dialnorm.HasValue;

        /// <summary>
        /// Gets and sets the property DrcLine. Sets the Dolby dynamic range compression profile.
        /// </summary>
        public Eac3DrcLine DrcLine { get; set; }

        /// <summary>
        /// Checks to see if the DrcLine property is set.
        /// </summary>
        internal bool IsSetDrcLine() => this.DrcLine != null;

        /// <summary>
        /// Gets and sets the property DrcRf. Sets the profile for heavy Dolby dynamic range compression,
        /// ensures that the instantaneous signal peaks do not exceed specified levels.
        /// </summary>
        public Eac3DrcRf DrcRf { get; set; }

        /// <summary>
        /// Checks to see if the DrcRf property is set.
        /// </summary>
        internal bool IsSetDrcRf() => this.DrcRf != null;

        /// <summary>
        /// Gets and sets the property LfeControl. When encoding 3/2 audio, setting to lfe enables
        /// the LFE channel
        /// </summary>
        public Eac3LfeControl LfeControl { get; set; }

        /// <summary>
        /// Checks to see if the LfeControl property is set.
        /// </summary>
        internal bool IsSetLfeControl() => this.LfeControl != null;

        /// <summary>
        /// Gets and sets the property LfeFilter. When set to enabled, applies a 120Hz lowpass
        /// filter to the LFE channel prior to encoding. Only valid with codingMode32 coding mode.
        /// </summary>
        public Eac3LfeFilter LfeFilter { get; set; }

        /// <summary>
        /// Checks to see if the LfeFilter property is set.
        /// </summary>
        internal bool IsSetLfeFilter() => this.LfeFilter != null;

        /// <summary>
        /// Gets and sets the property LoRoCenterMixLevel. Left only/Right only center mix level.
        /// Only used for 3/2 coding mode.
        /// </summary>
        public double? LoRoCenterMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoRoCenterMixLevel property is set.
        /// </summary>
        internal bool IsSetLoRoCenterMixLevel() => this.LoRoCenterMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LoRoSurroundMixLevel. Left only/Right only surround mix
        /// level. Only used for 3/2 coding mode.
        /// </summary>
        public double? LoRoSurroundMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoRoSurroundMixLevel property is set.
        /// </summary>
        internal bool IsSetLoRoSurroundMixLevel() => this.LoRoSurroundMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LtRtCenterMixLevel. Left total/Right total center mix level.
        /// Only used for 3/2 coding mode.
        /// </summary>
        public double? LtRtCenterMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LtRtCenterMixLevel property is set.
        /// </summary>
        internal bool IsSetLtRtCenterMixLevel() => this.LtRtCenterMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LtRtSurroundMixLevel. Left total/Right total surround mix
        /// level. Only used for 3/2 coding mode.
        /// </summary>
        public double? LtRtSurroundMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LtRtSurroundMixLevel property is set.
        /// </summary>
        internal bool IsSetLtRtSurroundMixLevel() => this.LtRtSurroundMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataControl. When set to followInput, encoder metadata
        /// will be sourced from the DD, DD+, or DolbyE decoder that supplied this audio data.
        /// If audio was not supplied from one of these streams, then the static metadata settings
        /// will be used.
        /// </summary>
        public Eac3MetadataControl MetadataControl { get; set; }

        /// <summary>
        /// Checks to see if the MetadataControl property is set.
        /// </summary>
        internal bool IsSetMetadataControl() => this.MetadataControl != null;

        /// <summary>
        /// Gets and sets the property PassthroughControl. When set to whenPossible, input DD+
        /// audio will be passed through if it is present on the input. This detection is dynamic
        /// over the life of the transcode. Inputs that alternate between DD+ and non-DD+ content
        /// will have a consistent DD+ output as the system alternates between passthrough and
        /// encoding.
        /// </summary>
        public Eac3PassthroughControl PassthroughControl { get; set; }

        /// <summary>
        /// Checks to see if the PassthroughControl property is set.
        /// </summary>
        internal bool IsSetPassthroughControl() => this.PassthroughControl != null;

        /// <summary>
        /// Gets and sets the property PhaseControl. When set to shift90Degrees, applies a 90-degree
        /// phase shift to the surround channels. Only used for 3/2 coding mode.
        /// </summary>
        public Eac3PhaseControl PhaseControl { get; set; }

        /// <summary>
        /// Checks to see if the PhaseControl property is set.
        /// </summary>
        internal bool IsSetPhaseControl() => this.PhaseControl != null;

        /// <summary>
        /// Gets and sets the property StereoDownmix. Stereo downmix preference. Only used for
        /// 3/2 coding mode.
        /// </summary>
        public Eac3StereoDownmix StereoDownmix { get; set; }

        /// <summary>
        /// Checks to see if the StereoDownmix property is set.
        /// </summary>
        internal bool IsSetStereoDownmix() => this.StereoDownmix != null;

        /// <summary>
        /// Gets and sets the property SurroundExMode. When encoding 3/2 audio, sets whether an
        /// extra center back surround channel is matrix encoded into the left and right surround
        /// channels.
        /// </summary>
        public Eac3SurroundExMode SurroundExMode { get; set; }

        /// <summary>
        /// Checks to see if the SurroundExMode property is set.
        /// </summary>
        internal bool IsSetSurroundExMode() => this.SurroundExMode != null;

        /// <summary>
        /// Gets and sets the property SurroundMode. When encoding 2/0 audio, sets whether Dolby
        /// Surround is matrix encoded into the two channels.
        /// </summary>
        public Eac3SurroundMode SurroundMode { get; set; }

        /// <summary>
        /// Checks to see if the SurroundMode property is set.
        /// </summary>
        internal bool IsSetSurroundMode() => this.SurroundMode != null;
    }
}
