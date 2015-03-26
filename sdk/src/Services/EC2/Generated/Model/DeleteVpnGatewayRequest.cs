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
    /// Container for the parameters to the DeleteVpnGateway operation.
    /// Deletes the specified virtual private gateway. We recommend that before you delete
    /// a virtual private gateway, you detach it from the VPC and delete the VPN connection.
    /// Note that you don't need to delete the virtual private gateway if you plan to delete
    /// and recreate the VPN connection between your VPC and your network.
    /// </summary>
    public partial class DeleteVpnGatewayRequest : AmazonEC2Request
    {
        private string _vpnGatewayId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteVpnGatewayRequest() { }

        /// <summary>
        /// Instantiates DeleteVpnGatewayRequest with the parameterized properties
        /// </summary>
        /// <param name="vpnGatewayId">The ID of the virtual private gateway.</param>
        public DeleteVpnGatewayRequest(string vpnGatewayId)
        {
            _vpnGatewayId = vpnGatewayId;
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