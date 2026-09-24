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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about the uplink <c>Config</c> of an antenna.
    /// </summary>
    public partial class AntennaUplinkConfig
    {
        /// <summary>
        /// Gets and sets the property SpectrumConfig. 
        /// <para>
        /// Information about the uplink spectral <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UplinkSpectrumConfig SpectrumConfig { get; set; }

        /// <summary>
        /// Checks to see if the SpectrumConfig property is set.
        /// </summary>
        internal bool IsSetSpectrumConfig() => this.SpectrumConfig != null;

        /// <summary>
        /// Gets and sets the property TargetEirp. 
        /// <para>
        /// EIRP of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Eirp TargetEirp { get; set; }

        /// <summary>
        /// Checks to see if the TargetEirp property is set.
        /// </summary>
        internal bool IsSetTargetEirp() => this.TargetEirp != null;

        /// <summary>
        /// Gets and sets the property TransmitDisabled. 
        /// <para>
        /// Whether or not uplink transmit is disabled.
        /// </para>
        /// </summary>
        public bool? TransmitDisabled { get; set; }

        /// <summary>
        /// Checks to see if the TransmitDisabled property is set.
        /// </summary>
        internal bool IsSetTransmitDisabled() => this.TransmitDisabled.HasValue;
    }
}
