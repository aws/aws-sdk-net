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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOdbPeeringConnection operation.
    /// Modifies the settings of an Oracle Database@Amazon Web Services peering connection.
    /// You can update the display name and add or remove CIDR blocks from the peering connection.
    /// </summary>
    public partial class UpdateOdbPeeringConnectionRequest : AmazonOdbRequest
    {
        private string _displayName;
        private string _odbPeeringConnectionId;
        private List<string> _peerNetworkCidrsToBeAdded = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _peerNetworkCidrsToBeRemoved = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A new display name for the peering connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property OdbPeeringConnectionId. 
        /// <para>
        /// The identifier of the Oracle Database@Amazon Web Services peering connection to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string OdbPeeringConnectionId
        {
            get { return this._odbPeeringConnectionId; }
            set { this._odbPeeringConnectionId = value; }
        }

        // Check to see if OdbPeeringConnectionId property is set
        internal bool IsSetOdbPeeringConnectionId()
        {
            return this._odbPeeringConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property PeerNetworkCidrsToBeAdded. 
        /// <para>
        /// A list of CIDR blocks to add to the peering connection. These CIDR blocks define the
        /// IP address ranges that can communicate through the peering connection. The CIDR blocks
        /// must not overlap with existing CIDR blocks in the Oracle Database@Amazon Web Services
        /// network.
        /// </para>
        /// </summary>
        public List<string> PeerNetworkCidrsToBeAdded
        {
            get { return this._peerNetworkCidrsToBeAdded; }
            set { this._peerNetworkCidrsToBeAdded = value; }
        }

        // Check to see if PeerNetworkCidrsToBeAdded property is set
        internal bool IsSetPeerNetworkCidrsToBeAdded()
        {
            return this._peerNetworkCidrsToBeAdded != null && (this._peerNetworkCidrsToBeAdded.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PeerNetworkCidrsToBeRemoved. 
        /// <para>
        /// A list of CIDR blocks to remove from the peering connection. The CIDR blocks must
        /// currently exist in the peering connection.
        /// </para>
        /// </summary>
        public List<string> PeerNetworkCidrsToBeRemoved
        {
            get { return this._peerNetworkCidrsToBeRemoved; }
            set { this._peerNetworkCidrsToBeRemoved = value; }
        }

        // Check to see if PeerNetworkCidrsToBeRemoved property is set
        internal bool IsSetPeerNetworkCidrsToBeRemoved()
        {
            return this._peerNetworkCidrsToBeRemoved != null && (this._peerNetworkCidrsToBeRemoved.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}