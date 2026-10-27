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
    /// Eac3 Atmos Settings
    /// </summary>
    public partial class Eac3AtmosSettings
    {
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
        /// Gets and sets the property CodingMode. Dolby Digital Plus with Dolby Atmos coding
        /// mode. Determines number of channels.
        /// </summary>
        public Eac3AtmosCodingMode CodingMode { get; set; }

        /// <summary>
        /// Checks to see if the CodingMode property is set.
        /// </summary>
        internal bool IsSetCodingMode() => this.CodingMode != null;

        /// <summary>
        /// Gets and sets the property Dialnorm. Sets the dialnorm for the output. Default 23.
        /// </summary>
        public int? Dialnorm { get; set; }

        /// <summary>
        /// Checks to see if the Dialnorm property is set.
        /// </summary>
        internal bool IsSetDialnorm() => this.Dialnorm.HasValue;

        /// <summary>
        /// Gets and sets the property DrcLine. Sets the Dolby dynamic range compression profile.
        /// </summary>
        public Eac3AtmosDrcLine DrcLine { get; set; }

        /// <summary>
        /// Checks to see if the DrcLine property is set.
        /// </summary>
        internal bool IsSetDrcLine() => this.DrcLine != null;

        /// <summary>
        /// Gets and sets the property DrcRf. Sets the profile for heavy Dolby dynamic range compression,
        /// ensures that the instantaneous signal peaks do not exceed specified levels.
        /// </summary>
        public Eac3AtmosDrcRf DrcRf { get; set; }

        /// <summary>
        /// Checks to see if the DrcRf property is set.
        /// </summary>
        internal bool IsSetDrcRf() => this.DrcRf != null;

        /// <summary>
        /// Gets and sets the property HeightTrim. Height dimensional trim. Sets the maximum amount
        /// to attenuate the height channels when the downstream player isn??t configured to handle
        /// Dolby Digital Plus with Dolby Atmos and must remix the channels.
        /// </summary>
        public double? HeightTrim { get; set; }

        /// <summary>
        /// Checks to see if the HeightTrim property is set.
        /// </summary>
        internal bool IsSetHeightTrim() => this.HeightTrim.HasValue;

        /// <summary>
        /// Gets and sets the property SurroundTrim. Surround dimensional trim. Sets the maximum
        /// amount to attenuate the surround channels when the downstream player isn't configured
        /// to handle Dolby Digital Plus with Dolby Atmos and must remix the channels.
        /// </summary>
        public double? SurroundTrim { get; set; }

        /// <summary>
        /// Checks to see if the SurroundTrim property is set.
        /// </summary>
        internal bool IsSetSurroundTrim() => this.SurroundTrim.HasValue;
    }
}
