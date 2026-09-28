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
    /// Describes a core network Connect peer.
    /// </summary>
    public partial class ConnectPeer
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the Connect peer.
        /// </para>
        /// </summary>
        public ConnectPeerConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ConnectAttachmentId. 
        /// <para>
        /// The ID of the attachment to connect.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string ConnectAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectAttachmentId property is set.
        /// </summary>
        internal bool IsSetConnectAttachmentId() => this.ConnectAttachmentId != null;

        /// <summary>
        /// Gets and sets the property ConnectPeerId. 
        /// <para>
        /// The ID of the Connect peer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string ConnectPeerId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectPeerId property is set.
        /// </summary>
        internal bool IsSetConnectPeerId() => this.ConnectPeerId != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network.
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
        /// The timestamp when the Connect peer was created.
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
        /// The Connect peer Regions where edges are located.
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
        /// Describes the error associated with the attachment request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<ConnectPeerError> LastModificationErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectPeerError>() : null;

        /// <summary>
        /// Checks to see if the LastModificationErrors property is set.
        /// </summary>
        internal bool IsSetLastModificationErrors() => this.LastModificationErrors != null && (this.LastModificationErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the Connect peer.
        /// </para>
        /// </summary>
        public ConnectPeerState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubnetArn. 
        /// <para>
        /// The subnet ARN for the Connect peer. This only applies only when the protocol is NO_ENCAP.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string SubnetArn { get; set; }

        /// <summary>
        /// Checks to see if the SubnetArn property is set.
        /// </summary>
        internal bool IsSetSubnetArn() => this.SubnetArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value tags associated with the Connect peer.
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
