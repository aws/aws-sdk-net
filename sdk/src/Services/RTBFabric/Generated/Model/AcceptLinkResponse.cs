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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// This is the response object from the AcceptLink operation.
    /// </summary>
    public partial class AcceptLinkResponse : AmazonWebServiceResponse
    {
        private LinkAttributes _attributes;
        private DateTime? _createdAt;
        private LinkDirection _direction;
        private List<ModuleConfiguration> _flowModules = AWSConfigs.InitializeCollections ? new List<ModuleConfiguration>() : null;
        private string _gatewayId;
        private string _linkId;
        private string _peerGatewayId;
        private List<ModuleConfiguration> _pendingFlowModules = AWSConfigs.InitializeCollections ? new List<ModuleConfiguration>() : null;
        private LinkStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Attributes of the link.
        /// </para>
        /// </summary>
        public LinkAttributes Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the link was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction of the link.
        /// </para>
        /// </summary>
        public LinkDirection Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property FlowModules. 
        /// <para>
        /// The configuration of flow modules.
        /// </para>
        /// </summary>
        public List<ModuleConfiguration> FlowModules
        {
            get { return this._flowModules; }
            set { this._flowModules = value; }
        }

        // Check to see if FlowModules property is set
        internal bool IsSetFlowModules()
        {
            return this._flowModules != null && (this._flowModules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property LinkId. 
        /// <para>
        /// The unique identifier of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PeerGatewayId. 
        /// <para>
        /// The unique identifier of the peer gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PeerGatewayId
        {
            get { return this._peerGatewayId; }
            set { this._peerGatewayId = value; }
        }

        // Check to see if PeerGatewayId property is set
        internal bool IsSetPeerGatewayId()
        {
            return this._peerGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property PendingFlowModules. 
        /// <para>
        /// The configuration of pending flow modules.
        /// </para>
        /// </summary>
        public List<ModuleConfiguration> PendingFlowModules
        {
            get { return this._pendingFlowModules; }
            set { this._pendingFlowModules = value; }
        }

        // Check to see if PendingFlowModules property is set
        internal bool IsSetPendingFlowModules()
        {
            return this._pendingFlowModules != null && (this._pendingFlowModules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LinkStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the link was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}