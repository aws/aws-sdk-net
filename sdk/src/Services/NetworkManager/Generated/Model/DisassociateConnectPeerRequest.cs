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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateConnectPeer operation.
    /// Disassociates a core network Connect peer from a device and a link.
    /// </summary>
    public partial class DisassociateConnectPeerRequest : AmazonNetworkManagerRequest
    {
        private string _connectPeerId;
        private string _globalNetworkId;

        /// <summary>
        /// Gets and sets the property ConnectPeerId. 
        /// <para>
        /// The ID of the Connect peer to disassociate from a device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string ConnectPeerId
        {
            get { return this._connectPeerId; }
            set { this._connectPeerId = value; }
        }

        // Check to see if ConnectPeerId property is set
        internal bool IsSetConnectPeerId()
        {
            return this._connectPeerId != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string GlobalNetworkId
        {
            get { return this._globalNetworkId; }
            set { this._globalNetworkId = value; }
        }

        // Check to see if GlobalNetworkId property is set
        internal bool IsSetGlobalNetworkId()
        {
            return this._globalNetworkId != null;
        }

    }
}