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
    /// Describes a peering connection.
    /// </summary>
    public partial class Peering
    {
        private string _coreNetworkArn;
        private string _coreNetworkId;
        private DateTime? _createdAt;
        private string _edgeLocation;
        private List<PeeringError> _lastModificationErrors = AWSConfigs.InitializeCollections ? new List<PeeringError>() : null;
        private string _ownerAccountId;
        private string _peeringId;
        private PeeringType _peeringType;
        private string _resourceArn;
        private PeeringState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CoreNetworkArn. 
        /// <para>
        /// The ARN of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string CoreNetworkArn
        {
            get { return this._coreNetworkArn; }
            set { this._coreNetworkArn = value; }
        }

        // Check to see if CoreNetworkArn property is set
        internal bool IsSetCoreNetworkArn()
        {
            return this._coreNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of the core network for the peering request.
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
        /// The timestamp when the attachment peer was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
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
        /// The edge location for the peer.
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
        /// Gets and sets the property LastModificationErrors. 
        /// <para>
        /// Describes the error associated with the Connect peer request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<PeeringError> LastModificationErrors
        {
            get { return this._lastModificationErrors; }
            set { this._lastModificationErrors = value; }
        }

        // Check to see if LastModificationErrors property is set
        internal bool IsSetLastModificationErrors()
        {
            return this._lastModificationErrors != null && (this._lastModificationErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The ID of the account owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property PeeringId. 
        /// <para>
        /// The ID of the peering attachment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string PeeringId
        {
            get { return this._peeringId; }
            set { this._peeringId = value; }
        }

        // Check to see if PeeringId property is set
        internal bool IsSetPeeringId()
        {
            return this._peeringId != null;
        }

        /// <summary>
        /// Gets and sets the property PeeringType. 
        /// <para>
        /// The type of peering. This will be <c>TRANSIT_GATEWAY</c>.
        /// </para>
        /// </summary>
        public PeeringType PeeringType
        {
            get { return this._peeringType; }
            set { this._peeringType = value; }
        }

        // Check to see if PeeringType property is set
        internal bool IsSetPeeringType()
        {
            return this._peeringType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The resource ARN of the peer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1500)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the peering connection. 
        /// </para>
        /// </summary>
        public PeeringState State
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
        /// The list of key-value tags associated with the peering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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