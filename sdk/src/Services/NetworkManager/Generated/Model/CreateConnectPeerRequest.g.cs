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
    /// Container for the parameters to the CreateConnectPeer operation. Creates a core network
    /// Connect peer for a specified core network connect attachment between a core network
    /// and an appliance. The peer address and transit gateway address must be the same IP
    /// address family (IPv4 or IPv6).
    /// </summary>
    public partial class CreateConnectPeerRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property BgpOptions. 
        /// <para>
        /// The Connect peer BGP options. This only applies only when the protocol is <c>GRE</c>.
        /// </para>
        /// </summary>
        public BgpOptions BgpOptions { get; set; }

        /// <summary>
        /// Checks to see if the BgpOptions property is set.
        /// </summary>
        internal bool IsSetBgpOptions() => this.BgpOptions != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConnectAttachmentId. 
        /// <para>
        /// The ID of the connection attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string ConnectAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectAttachmentId property is set.
        /// </summary>
        internal bool IsSetConnectAttachmentId() => this.ConnectAttachmentId != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkAddress. 
        /// <para>
        /// A Connect peer core network address. This only applies only when the protocol is <c>GRE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string CoreNetworkAddress { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkAddress property is set.
        /// </summary>
        internal bool IsSetCoreNetworkAddress() => this.CoreNetworkAddress != null;

        /// <summary>
        /// Gets and sets the property InsideCidrBlocks. 
        /// <para>
        /// The inside IP addresses used for BGP peering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InsideCidrBlocks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InsideCidrBlocks property is set.
        /// </summary>
        internal bool IsSetInsideCidrBlocks() => this.InsideCidrBlocks != null && (this.InsideCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The Connect peer address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string PeerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PeerAddress property is set.
        /// </summary>
        internal bool IsSetPeerAddress() => this.PeerAddress != null;

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
        /// The tags associated with the peer request.
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
