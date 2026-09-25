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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The LoRaWAN information that is to be used with the multicast group.
    /// </summary>
    public partial class LoRaWANMulticast
    {
        /// <summary>
        /// Gets and sets the property DefaultSessionParameters. 
        /// <para>
        /// The default session parameters for the multicast group.
        /// </para>
        /// </summary>
        public DefaultSessionParametersMulticast DefaultSessionParameters { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSessionParameters property is set.
        /// </summary>
        internal bool IsSetDefaultSessionParameters() => this.DefaultSessionParameters != null;

        /// <summary>
        /// Gets and sets the property DlClass.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public DlClass DlClass { get; set; }

        /// <summary>
        /// Checks to see if the DlClass property is set.
        /// </summary>
        internal bool IsSetDlClass() => this.DlClass != null;

        /// <summary>
        /// Gets and sets the property ParticipatingGateways.
        /// </summary>
        public ParticipatingGatewaysMulticast ParticipatingGateways { get; set; }

        /// <summary>
        /// Checks to see if the ParticipatingGateways property is set.
        /// </summary>
        internal bool IsSetParticipatingGateways() => this.ParticipatingGateways != null;

        /// <summary>
        /// Gets and sets the property RfRegion.
        /// </summary>
        public SupportedRfRegion RfRegion { get; set; }

        /// <summary>
        /// Checks to see if the RfRegion property is set.
        /// </summary>
        internal bool IsSetRfRegion() => this.RfRegion != null;
    }
}
