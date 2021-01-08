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
    /// Describes a connection.
    /// </summary>
    public partial class Connection
    {
        private string _connectedDeviceId;
        private string _connectedLinkId;
        private string _connectionArn;
        private string _connectionId;
        private DateTime? _createdAt;
        private string _description;
        private string _deviceId;
        private string _globalNetworkId;
        private string _linkId;
        private ConnectionState _state;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ConnectedDeviceId. 
        /// <para>
        /// The ID of the second device in the connection.
        /// </para>
        /// </summary>
        public string ConnectedDeviceId
        {
            get { return this._connectedDeviceId; }
            set { this._connectedDeviceId = value; }
        }

        // Check to see if ConnectedDeviceId property is set
        internal bool IsSetConnectedDeviceId()
        {
            return this._connectedDeviceId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectedLinkId. 
        /// <para>
        /// The ID of the link for the second device in the connection.
        /// </para>
        /// </summary>
        public string ConnectedLinkId
        {
            get { return this._connectedLinkId; }
            set { this._connectedLinkId = value; }
        }

        // Check to see if ConnectedLinkId property is set
        internal bool IsSetConnectedLinkId()
        {
            return this._connectedLinkId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connection.
        /// </para>
        /// </summary>
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the connection was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the connection.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The ID of the first device in the connection.
        /// </para>
        /// </summary>
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property LinkId. 
        /// <para>
        /// The ID of the link for the first device in the connection.
        /// </para>
        /// </summary>
        public string LinkId
        {
            get { return this._linkId; }
            set { this._linkId = value; }
        }

        // Check to see if LinkId property is set
        internal bool IsSetLinkId()
        {
            return this._linkId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the connection.
        /// </para>
        /// </summary>
        public ConnectionState State
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the connection.
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}