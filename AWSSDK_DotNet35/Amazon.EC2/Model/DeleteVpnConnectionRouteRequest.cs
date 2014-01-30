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
    /// Container for the parameters to the DeleteVpnConnectionRoute operation.
    /// <para>Deletes the specified static route associated with a VPN connection between an existing virtual private gateway and a VPN customer
    /// gateway. The static route allows traffic to be routed from the virtual private gateway to the VPN customer gateway.</para>
    /// </summary>
    public partial class DeleteVpnConnectionRouteRequest : AmazonEC2Request
    {
        private string vpnConnectionId;
        private string destinationCidrBlock;


        /// <summary>
        /// The ID of the VPN connection.
        ///  
        /// </summary>
        public string VpnConnectionId
        {
            get { return this.vpnConnectionId; }
            set { this.vpnConnectionId = value; }
        }

        // Check to see if VpnConnectionId property is set
        internal bool IsSetVpnConnectionId()
        {
            return this.vpnConnectionId != null;
        }

        /// <summary>
        /// The CIDR block associated with the local subnet of the customer network.
        ///  
        /// </summary>
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlock; }
            set { this.destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this.destinationCidrBlock != null;
        }

    }
}
    
