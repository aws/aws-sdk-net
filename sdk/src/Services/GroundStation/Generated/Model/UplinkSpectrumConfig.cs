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
    /// Information about the uplink spectral <c>Config</c>.
    /// </summary>
    public partial class UplinkSpectrumConfig
    {
        private Frequency _centerFrequency;
        private Polarization _polarization;

        /// <summary>
        /// Gets and sets the property CenterFrequency. 
        /// <para>
        /// Center frequency of an uplink spectral <c>Config</c>. Valid values are between 2025
        /// to 2120 MHz.
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
        /// Polarization of an uplink spectral <c>Config</c>. Capturing both <c>"RIGHT_HAND"</c>
        /// and <c>"LEFT_HAND"</c> polarization requires two separate configs.
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