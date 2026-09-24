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
    /// Information about how AWS Ground Station should conﬁgure an antenna for downlink demod
    /// decode during a contact.
    /// </summary>
    public partial class AntennaDownlinkDemodDecodeConfig
    {
        /// <summary>
        /// Gets and sets the property DecodeConfig. 
        /// <para>
        /// Information about the decode <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DecodeConfig DecodeConfig { get; set; }

        /// <summary>
        /// Checks to see if the DecodeConfig property is set.
        /// </summary>
        internal bool IsSetDecodeConfig() => this.DecodeConfig != null;

        /// <summary>
        /// Gets and sets the property DemodulationConfig. 
        /// <para>
        /// Information about the demodulation <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DemodulationConfig DemodulationConfig { get; set; }

        /// <summary>
        /// Checks to see if the DemodulationConfig property is set.
        /// </summary>
        internal bool IsSetDemodulationConfig() => this.DemodulationConfig != null;

        /// <summary>
        /// Gets and sets the property SpectrumConfig. 
        /// <para>
        /// Information about the spectral <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SpectrumConfig SpectrumConfig { get; set; }

        /// <summary>
        /// Checks to see if the SpectrumConfig property is set.
        /// </summary>
        internal bool IsSetSpectrumConfig() => this.SpectrumConfig != null;
    }
}
