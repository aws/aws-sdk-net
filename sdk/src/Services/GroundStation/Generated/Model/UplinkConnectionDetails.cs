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
    /// Connection details for customer to Agent and Agent to Ground Station
    /// </summary>
    public partial class UplinkConnectionDetails
    {
        private RangedConnectionDetails _agentIpAndPortAddress;
        private ConnectionDetails _ingressAddressAndPort;

        /// <summary>
        /// Gets and sets the property AgentIpAndPortAddress.
        /// </summary>
        [AWSProperty(Required=true)]
        public RangedConnectionDetails AgentIpAndPortAddress
        {
            get { return this._agentIpAndPortAddress; }
            set { this._agentIpAndPortAddress = value; }
        }

        // Check to see if AgentIpAndPortAddress property is set
        internal bool IsSetAgentIpAndPortAddress()
        {
            return this._agentIpAndPortAddress != null;
        }

        /// <summary>
        /// Gets and sets the property IngressAddressAndPort.
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionDetails IngressAddressAndPort
        {
            get { return this._ingressAddressAndPort; }
            set { this._ingressAddressAndPort = value; }
        }

        // Check to see if IngressAddressAndPort property is set
        internal bool IsSetIngressAddressAndPort()
        {
            return this._ingressAddressAndPort != null;
        }

    }
}