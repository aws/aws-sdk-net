/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Creates a new VPN connection between an existing VPN gateway and customer gateway. The only supported connection type is ipsec.1.
    /// </para> <para> The response includes information that you need to configure your customer gateway, in XML format. We recommend you use the
    /// command line version of this operation ( <c>ec2-create-vpn-connection</c> ), which takes an <c>-f</c> option (for format) and returns
    /// configuration information formatted as expected by the vendor you specified, or in a generic, human readable format. For information about
    /// the command, go to <c>ec2-create-vpn-connection</c> in the Amazon Virtual Private Cloud Command Line Reference. </para>
    /// <para><b>IMPORTANT:</b> We strongly recommend you use HTTPS when calling this operation because the response contains sensitive
    /// cryptographic information for configuring your customer gateway. If you decide to shut down your VPN connection for any reason and then
    /// create a new one, you must re-configure your customer gateway with the new information returned from this call. </para>
    /// </summary>
    public partial class CreateVpnConnectionRequest : AmazonEC2Request
    {
        private string type;
        private string customerGatewayId;
        private string vpnGatewayId;
        private VpnConnectionOptionsSpecification options;


        /// <summary>
        /// The type of VPN connection.
        ///  
        /// </summary>
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }

        /// <summary>
        /// The ID of the customer gateway.
        ///  
        /// </summary>
        public string CustomerGatewayId
        {
            get { return this.customerGatewayId; }
            set { this.customerGatewayId = value; }
        }

        // Check to see if CustomerGatewayId property is set
        internal bool IsSetCustomerGatewayId()
        {
            return this.customerGatewayId != null;
        }

        /// <summary>
        /// The ID of the VPN gateway.
        ///  
        /// </summary>
        public string VpnGatewayId
        {
            get { return this.vpnGatewayId; }
            set { this.vpnGatewayId = value; }
        }

        // Check to see if VpnGatewayId property is set
        internal bool IsSetVpnGatewayId()
        {
            return this.vpnGatewayId != null;
        }
        public VpnConnectionOptionsSpecification Options
        {
            get { return this.options; }
            set { this.options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this.options != null;
        }

    }
}
    
