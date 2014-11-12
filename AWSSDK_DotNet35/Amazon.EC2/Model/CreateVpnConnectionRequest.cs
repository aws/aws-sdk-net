/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpnConnection operation.
    /// Creates a VPN connection between an existing virtual private gateway and a VPN customer
    /// gateway. The only supported connection type is <code>ipsec.1</code>.
    /// 
    ///  
    /// <para>
    /// The response includes information that you need to give to your network administrator
    /// to configure your customer gateway.
    /// </para>
    ///  <important> 
    /// <para>
    /// We strongly recommend that you use HTTPS when calling this operation because the response
    /// contains sensitive cryptographic information for configuring your customer gateway.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you decide to shut down your VPN connection for any reason and later create a new
    /// VPN connection, you must reconfigure your customer gateway with the new information
    /// returned from this call.
    /// </para>
    ///  
    /// <para>
    /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
    /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
    /// Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVpnConnectionRequest : AmazonEC2Request
    {
        private string _customerGatewayId;
        private VpnConnectionOptionsSpecification _options;
        private string _type;
        private string _vpnGatewayId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateVpnConnectionRequest() { }

        /// <summary>
        /// Instantiates CreateVpnConnectionRequest with the parameterized properties
        /// </summary>
        /// <param name="type">The type of VPN connection (<code>ipsec.1</code>).</param>
        /// <param name="customerGatewayId">The ID of the customer gateway.</param>
        /// <param name="vpnGatewayId">The ID of the virtual private gateway.</param>
        public CreateVpnConnectionRequest(string type, string customerGatewayId, string vpnGatewayId)
        {
            _type = type;
            _customerGatewayId = customerGatewayId;
            _vpnGatewayId = vpnGatewayId;
        }

        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The ID of the customer gateway.
        /// </para>
        /// </summary>
        public string CustomerGatewayId
        {
            get { return this._customerGatewayId; }
            set { this._customerGatewayId = value; }
        }

        // Check to see if CustomerGatewayId property is set
        internal bool IsSetCustomerGatewayId()
        {
            return this._customerGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Indicates whether the VPN connection requires static routes. If you are creating a
        /// VPN connection for a device that does not support BGP, you must specify <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code>
        /// </para>
        /// </summary>
        public VpnConnectionOptionsSpecification Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of VPN connection (<code>ipsec.1</code>).
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VpnGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway.
        /// </para>
        /// </summary>
        public string VpnGatewayId
        {
            get { return this._vpnGatewayId; }
            set { this._vpnGatewayId = value; }
        }

        // Check to see if VpnGatewayId property is set
        internal bool IsSetVpnGatewayId()
        {
            return this._vpnGatewayId != null;
        }

    }
}