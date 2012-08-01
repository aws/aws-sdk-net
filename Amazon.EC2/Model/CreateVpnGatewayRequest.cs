/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Creates a new VPN gateway. A VPN gateway is the VPC-side endpoint
    /// for your VPN connection. You can create a VPN gateway before
    /// creating the VPC itself. AWS might delete any VPN
    /// gateway that you create with this operation if you leave
    /// it inactive for an extended period of time (inactive means that
    /// there's no VPN connection in use with the VPN gateway)
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateVpnGatewayRequest
    {    
        private string typeField;
        private string availabilityZoneField;

        /// <summary>
        /// Gets and sets the Type property.
        /// The type of VPN connection this VPN gateway
        /// supports. Valid
        /// Values: ipsec.1
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The type of VPN connection this VPN gateway
        /// supports. Valid
        /// Values: ipsec.1</param>
        /// <returns>this instance</returns>
        public CreateVpnGatewayRequest WithType(string type)
        {
            this.typeField = type;
            return this;
        }

        /// <summary>
        /// Checks if Type property is set
        /// </summary>
        /// <returns>true if Type property is set</returns>
        public bool IsSetType()
        {
            return this.typeField != null;
        }

        /// <summary>
        /// Gets and sets the AvailabilityZone property.
        /// The Availability Zone where you want the VPN
        /// gateway.
        /// Default: AWS selects a zone for you (recommended)
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone where you want the VPN
        /// gateway.
        /// Default: AWS selects a zone for you (recommended)</param>
        /// <returns>this instance</returns>
        public CreateVpnGatewayRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

    }
}
