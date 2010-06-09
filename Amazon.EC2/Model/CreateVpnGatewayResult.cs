/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Create Vpn Gateway Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class CreateVpnGatewayResult
    {
        private VpnGateway vpnGatewayField;

        /// <summary>
        /// Gets and sets the VpnGateway property.
        /// Vpn gateway
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGateway")]
        public VpnGateway VpnGateway
        {
            get { return this.vpnGatewayField ; }
            set { this.vpnGatewayField = value; }
        }

        /// <summary>
        /// Sets the VpnGateway property
        /// </summary>
        /// <param name="vpnGateway">Vpn gateway</param>
        /// <returns>this instance</returns>
        public CreateVpnGatewayResult WithVpnGateway(VpnGateway vpnGateway)
        {
            this.vpnGatewayField = vpnGateway;
            return this;
        }

        /// <summary>
        /// Checks if VpnGateway property is set
        /// </summary>
        /// <returns>true if VpnGateway property is set</returns>
        public bool IsSetVpnGateway()
        {
            return this.vpnGatewayField != null;
        }

    }
}
