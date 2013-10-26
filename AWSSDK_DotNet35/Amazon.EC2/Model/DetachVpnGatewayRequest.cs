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
    /// Container for the parameters to the DetachVpnGateway operation.
    /// <para> Detaches a VPN gateway from a VPC. You do this if you're planning to turn off the VPC and not use it anymore. You can confirm a VPN
    /// gateway has been completely detached from a VPC by describing the VPN gateway (any attachments to the VPN gateway are also described).
    /// </para> <para> You must wait for the attachment's state to switch to detached before you can delete the VPC or attach a different VPC to the
    /// VPN gateway. </para>
    /// </summary>
    public partial class DetachVpnGatewayRequest : AmazonEC2Request
    {
        private string vpnGatewayId;
        private string vpcId;


        /// <summary>
        /// The ID of the VPN gateway to detach from the VPC.
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

        /// <summary>
        /// The ID of the VPC to detach the VPN gateway from.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

    }
}
    
