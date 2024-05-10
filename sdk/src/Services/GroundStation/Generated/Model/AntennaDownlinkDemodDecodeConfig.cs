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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about how AWS Ground Station should conﬁgure an antenna for downlink demod
    /// decode during a contact.
    /// </summary>
    public partial class AntennaDownlinkDemodDecodeConfig
    {
        private DecodeConfig _decodeConfig;
        private DemodulationConfig _demodulationConfig;
        private SpectrumConfig _spectrumConfig;

        /// <summary>
        /// Gets and sets the property DecodeConfig. 
        /// <para>
        /// Information about the decode <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DecodeConfig DecodeConfig
        {
            get { return this._decodeConfig; }
            set { this._decodeConfig = value; }
        }

        // Check to see if DecodeConfig property is set
        internal bool IsSetDecodeConfig()
        {
            return this._decodeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DemodulationConfig. 
        /// <para>
        /// Information about the demodulation <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DemodulationConfig DemodulationConfig
        {
            get { return this._demodulationConfig; }
            set { this._demodulationConfig = value; }
        }

        // Check to see if DemodulationConfig property is set
        internal bool IsSetDemodulationConfig()
        {
            return this._demodulationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SpectrumConfig. 
        /// <para>
        /// Information about the spectral <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SpectrumConfig SpectrumConfig
        {
            get { return this._spectrumConfig; }
            set { this._spectrumConfig = value; }
        }

        // Check to see if SpectrumConfig property is set
        internal bool IsSetSpectrumConfig()
        {
            return this._spectrumConfig != null;
        }

    }
}