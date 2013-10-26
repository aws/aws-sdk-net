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
    /// Container for the parameters to the DeleteVpnConnection operation.
    /// <para> Deletes a VPN connection. Use this if you want to delete a VPC and all its associated components. Another reason to use this
    /// operation is if you believe the tunnel credentials for your VPN connection have been compromised. In that situation, you can delete the VPN
    /// connection and create a new one that has new keys, without needing to delete the VPC or VPN gateway. If you create a new VPN connection, you
    /// must reconfigure the customer gateway using the new configuration information returned with the new VPN connection ID. </para> <para> If
    /// you're deleting the VPC and all its associated parts, we recommend you detach the VPN gateway from the VPC and delete the VPC before
    /// deleting the VPN connection. </para>
    /// </summary>
    public partial class DeleteVpnConnectionRequest : AmazonEC2Request
    {
        private string vpnConnectionId;


        /// <summary>
        /// The ID of the VPN connection to delete
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

    }
}
    
