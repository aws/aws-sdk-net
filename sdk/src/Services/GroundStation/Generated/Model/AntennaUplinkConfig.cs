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
    /// Information about the uplink <c>Config</c> of an antenna.
    /// </summary>
    public partial class AntennaUplinkConfig
    {
        private UplinkSpectrumConfig _spectrumConfig;
        private Eirp _targetEirp;
        private bool? _transmitDisabled;

        /// <summary>
        /// Gets and sets the property SpectrumConfig. 
        /// <para>
        /// Information about the uplink spectral <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UplinkSpectrumConfig SpectrumConfig
        {
            get { return this._spectrumConfig; }
            set { this._spectrumConfig = value; }
        }

        // Check to see if SpectrumConfig property is set
        internal bool IsSetSpectrumConfig()
        {
            return this._spectrumConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TargetEirp. 
        /// <para>
        /// EIRP of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Eirp TargetEirp
        {
            get { return this._targetEirp; }
            set { this._targetEirp = value; }
        }

        // Check to see if TargetEirp property is set
        internal bool IsSetTargetEirp()
        {
            return this._targetEirp != null;
        }

        /// <summary>
        /// Gets and sets the property TransmitDisabled. 
        /// <para>
        /// Whether or not uplink transmit is disabled.
        /// </para>
        /// </summary>
        public bool? TransmitDisabled
        {
            get { return this._transmitDisabled; }
            set { this._transmitDisabled = value; }
        }

        // Check to see if TransmitDisabled property is set
        internal bool IsSetTransmitDisabled()
        {
            return this._transmitDisabled.HasValue; 
        }

    }
}