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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CoreNetworkArn. 
        /// <para>
        /// The ARN of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string CoreNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkArn property is set.
        /// </summary>
        internal bool IsSetCoreNetworkArn() => this.CoreNetworkArn != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of the core network for the peering request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string CoreNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkId property is set.
        /// </summary>
        internal bool IsSetCoreNetworkId() => this.CoreNetworkId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the attachment peer was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeLocation. 
        /// <para>
        /// The edge location for the peer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string EdgeLocation { get; set; }

        /// <summary>
        /// Checks to see if the EdgeLocation property is set.
        /// </summary>
        internal bool IsSetEdgeLocation() => this.EdgeLocation != null;

        /// <summary>
        /// Gets and sets the property LastModificationErrors. 
        /// <para>
        /// Describes the error associated with the Connect peer request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<PeeringError> LastModificationErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<PeeringError>() : null;

        /// <summary>
        /// Checks to see if the LastModificationErrors property is set.
        /// </summary>
        internal bool IsSetLastModificationErrors() => this.LastModificationErrors != null && (this.LastModificationErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The ID of the account owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property PeeringId. 
        /// <para>
        /// The ID of the peering attachment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string PeeringId { get; set; }

        /// <summary>
        /// Checks to see if the PeeringId property is set.
        /// </summary>
        internal bool IsSetPeeringId() => this.PeeringId != null;

        /// <summary>
        /// Gets and sets the property PeeringType. 
        /// <para>
        /// The type of peering. This will be <c>TRANSIT_GATEWAY</c>.
        /// </para>
        /// </summary>
        public PeeringType PeeringType { get; set; }

        /// <summary>
        /// Checks to see if the PeeringType property is set.
        /// </summary>
        internal bool IsSetPeeringType() => this.PeeringType != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The resource ARN of the peer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1500)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the peering connection. 
        /// </para>
        /// </summary>
        public PeeringState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value tags associated with the peering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
