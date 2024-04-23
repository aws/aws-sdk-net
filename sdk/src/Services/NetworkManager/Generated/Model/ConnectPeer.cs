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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a core network Connect peer.
    /// </summary>
    public partial class ConnectPeer
    {
        private ConnectPeerConfiguration _configuration;
        private string _connectAttachmentId;
        private string _connectPeerId;
        private string _coreNetworkId;
        private DateTime? _createdAt;
        private string _edgeLocation;
        private ConnectPeerState _state;
        private string _subnetArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the Connect peer.
        /// </para>
        /// </summary>
        public ConnectPeerConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectAttachmentId. 
        /// <para>
        /// The ID of the attachment to connect.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string ConnectAttachmentId
        {
            get { return this._connectAttachmentId; }
            set { this._connectAttachmentId = value; }
        }

        // Check to see if ConnectAttachmentId property is set
        internal bool IsSetConnectAttachmentId()
        {
            return this._connectAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectPeerId. 
        /// <para>
        /// The ID of the Connect peer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string CoreNetworkId
        {
            get { return this._coreNetworkId; }
            set { this._coreNetworkId = value; }
        }

        // Check to see if CoreNetworkId property is set
        internal bool IsSetCoreNetworkId()
        {
            return this._coreNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the Connect peer was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeLocation. 
        /// <para>
        /// The Connect peer Regions where edges are located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string EdgeLocation
        {
            get { return this._edgeLocation; }
            set { this._edgeLocation = value; }
        }

        // Check to see if EdgeLocation property is set
        internal bool IsSetEdgeLocation()
        {
            return this._edgeLocation != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the Connect peer.
        /// </para>
        /// </summary>
        public ConnectPeerState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetArn. 
        /// <para>
        /// The subnet ARN for the Connect peer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string SubnetArn
        {
            get { return this._subnetArn; }
            set { this._subnetArn = value; }
        }

        // Check to see if SubnetArn property is set
        internal bool IsSetSubnetArn()
        {
            return this._subnetArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value tags associated with the Connect peer.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}