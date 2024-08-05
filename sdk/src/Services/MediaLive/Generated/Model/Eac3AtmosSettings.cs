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
    /// Eac3 Atmos Settings
    /// </summary>
    public partial class Eac3AtmosSettings
    {
        private double? _bitrate;
        private Eac3AtmosCodingMode _codingMode;
        private int? _dialnorm;
        private Eac3AtmosDrcLine _drcLine;
        private Eac3AtmosDrcRf _drcRf;
        private double? _heightTrim;
        private double? _surroundTrim;

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
        /// Gets and sets the property CodingMode. Dolby Digital Plus with Dolby Atmos coding
        /// mode. Determines number of channels.
        /// </summary>
        public Eac3AtmosCodingMode CodingMode
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
        /// Gets and sets the property Dialnorm. Sets the dialnorm for the output. Default 23.
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
        public Eac3AtmosDrcLine DrcLine
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
        public Eac3AtmosDrcRf DrcRf
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
        /// Gets and sets the property HeightTrim. Height dimensional trim. Sets the maximum amount
        /// to attenuate the height channels when the downstream player isn??t configured to handle
        /// Dolby Digital Plus with Dolby Atmos and must remix the channels.
        /// </summary>
        public double? HeightTrim
        {
            get { return this._heightTrim; }
            set { this._heightTrim = value; }
        }

        // Check to see if HeightTrim property is set
        internal bool IsSetHeightTrim()
        {
            return this._heightTrim.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SurroundTrim. Surround dimensional trim. Sets the maximum
        /// amount to attenuate the surround channels when the downstream player isn't configured
        /// to handle Dolby Digital Plus with Dolby Atmos and must remix the channels.
        /// </summary>
        public double? SurroundTrim
        {
            get { return this._surroundTrim; }
            set { this._surroundTrim = value; }
        }

        // Check to see if SurroundTrim property is set
        internal bool IsSetSurroundTrim()
        {
            return this._surroundTrim.HasValue; 
        }

    }
}