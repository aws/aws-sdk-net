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
    /// Container for the parameters to the DeleteVpnConnection operation.
    /// Deletes the specified VPN connection.
    /// 
    ///  
    /// <para>
    /// If you're deleting the VPC and its associated components, we recommend that you detach
    /// the virtual private gateway from the VPC and delete the VPC before deleting the VPN
    /// connection. If you believe that the tunnel credentials for your VPN connection have
    /// been compromised, you can delete the VPN connection and create a new one that has
    /// new keys, without needing to delete the VPC or virtual private gateway. If you create
    /// a new VPN connection, you must reconfigure the customer gateway using the new configuration
    /// information returned with the new VPN connection ID.
    /// </para>
    /// </summary>
    public partial class DeleteVpnConnectionRequest : AmazonEC2Request
    {
        private string _vpnConnectionId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteVpnConnectionRequest() { }

        /// <summary>
        /// Instantiates DeleteVpnConnectionRequest with the parameterized properties
        /// </summary>
        /// <param name="vpnConnectionId">The ID of the VPN connection.</param>
        public DeleteVpnConnectionRequest(string vpnConnectionId)
        {
            _vpnConnectionId = vpnConnectionId;
        }

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the VPN connection.
        /// </para>
        /// </summary>
        public string VpnConnectionId
        {
            get { return this._vpnConnectionId; }
            set { this._vpnConnectionId = value; }
        }

        // Check to see if VpnConnectionId property is set
        internal bool IsSetVpnConnectionId()
        {
            return this._vpnConnectionId != null;
        }

    }
}