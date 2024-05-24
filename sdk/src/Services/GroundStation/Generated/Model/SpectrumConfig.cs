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
    /// Object that describes a spectral <c>Config</c>.
    /// </summary>
    public partial class SpectrumConfig
    {
        private FrequencyBandwidth _bandwidth;
        private Frequency _centerFrequency;
        private Polarization _polarization;

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// Bandwidth of a spectral <c>Config</c>. AWS Ground Station currently has the following
        /// bandwidth limitations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>AntennaDownlinkDemodDecodeconfig</c>, valid values are between 125 kHz to 650
        /// MHz.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>AntennaDownlinkconfig</c> valid values are between 10 kHz to 54 MHz.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>AntennaUplinkConfig</c>, valid values are between 10 kHz to 54 MHz.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public FrequencyBandwidth Bandwidth
        {
            get { return this._bandwidth; }
            set { this._bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this._bandwidth != null;
        }

        /// <summary>
        /// Gets and sets the property CenterFrequency. 
        /// <para>
        /// Center frequency of a spectral <c>Config</c>. Valid values are between 2200 to 2300
        /// MHz and 7750 to 8400 MHz for downlink and 2025 to 2120 MHz for uplink.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Frequency CenterFrequency
        {
            get { return this._centerFrequency; }
            set { this._centerFrequency = value; }
        }

        // Check to see if CenterFrequency property is set
        internal bool IsSetCenterFrequency()
        {
            return this._centerFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property Polarization. 
        /// <para>
        /// Polarization of a spectral <c>Config</c>. Capturing both <c>"RIGHT_HAND"</c> and <c>"LEFT_HAND"</c>
        /// polarization requires two separate configs.
        /// </para>
        /// </summary>
        public Polarization Polarization
        {
            get { return this._polarization; }
            set { this._polarization = value; }
        }

        // Check to see if Polarization property is set
        internal bool IsSetPolarization()
        {
            return this._polarization != null;
        }

    }
}