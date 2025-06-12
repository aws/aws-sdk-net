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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for UpdateNodeStateResponse
    /// </summary>
    public partial class UpdateNodeStateResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<string> _channelPlacementGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clusterId;
        private NodeConnectionState _connectionState;
        private string _id;
        private string _instanceArn;
        private string _name;
        private List<NodeInterfaceMapping> _nodeInterfaceMappings = AWSConfigs.InitializeCollections ? new List<NodeInterfaceMapping>() : null;
        private NodeRole _role;
        private List<SdiSourceMapping> _sdiSourceMappings = AWSConfigs.InitializeCollections ? new List<SdiSourceMapping>() : null;
        private NodeState _state;

        /// <summary>
        /// Gets and sets the property Arn. The ARN of the Node. It is automatically assigned
        /// when the Node is created.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelPlacementGroups. An array of IDs. Each ID is one
        /// ChannelPlacementGroup that is associated with this Node. Empty if the Node is not
        /// yet associated with any groups.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ChannelPlacementGroups
        {
            get { return this._channelPlacementGroups; }
            set { this._channelPlacementGroups = value; }
        }

        // Check to see if ChannelPlacementGroups property is set
        internal bool IsSetChannelPlacementGroups()
        {
            return this._channelPlacementGroups != null && (this._channelPlacementGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClusterId. The ID of the Cluster that the Node belongs
        /// to.
        /// </summary>
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionState. The current connection state of the Node.
        /// </summary>
        public NodeConnectionState ConnectionState
        {
            get { return this._connectionState; }
            set { this._connectionState = value; }
        }

        // Check to see if ConnectionState property is set
        internal bool IsSetConnectionState()
        {
            return this._connectionState != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The unique ID of the Node. Unique in the Cluster. The
        /// ID is the resource-id portion of the ARN.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceArn. The ARN of the EC2 instance hosting the Node.
        /// </summary>
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name that you specified for the Node.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NodeInterfaceMappings. Documentation update needed
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeInterfaceMapping> NodeInterfaceMappings
        {
            get { return this._nodeInterfaceMappings; }
            set { this._nodeInterfaceMappings = value; }
        }

        // Check to see if NodeInterfaceMappings property is set
        internal bool IsSetNodeInterfaceMappings()
        {
            return this._nodeInterfaceMappings != null && (this._nodeInterfaceMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Role. The initial role current role of the Node in the
        /// Cluster. ACTIVE means the Node is available for encoding. BACKUP means the Node is
        /// a redundant Node and might get used if an ACTIVE Node fails.
        /// </summary>
        public NodeRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SdiSourceMappings. An array of SDI source mappings. Each
        /// mapping connects one logical SdiSource to the physical SDI card and port that the
        /// physical SDI source uses.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SdiSourceMapping> SdiSourceMappings
        {
            get { return this._sdiSourceMappings; }
            set { this._sdiSourceMappings = value; }
        }

        // Check to see if SdiSourceMappings property is set
        internal bool IsSetSdiSourceMappings()
        {
            return this._sdiSourceMappings != null && (this._sdiSourceMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. The current state of the Node.
        /// </summary>
        public NodeState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}