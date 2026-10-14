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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOdbPeeringConnection operation. Modifies
    /// the settings of an Oracle Database@Amazon Web Services peering connection. You can
    /// update the display name and add or remove CIDR blocks from the peering connection.
    /// </summary>
    public partial class UpdateOdbPeeringConnectionRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A new display name for the peering connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property OdbPeeringConnectionId. 
        /// <para>
        /// The identifier of the Oracle Database@Amazon Web Services peering connection to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string OdbPeeringConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the OdbPeeringConnectionId property is set.
        /// </summary>
        internal bool IsSetOdbPeeringConnectionId() => this.OdbPeeringConnectionId != null;

        /// <summary>
        /// Gets and sets the property PeerNetworkCidrsToBeAdded. 
        /// <para>
        /// A list of CIDR blocks to add to the peering connection. These CIDR blocks define the
        /// IP address ranges that can communicate through the peering connection. The CIDR blocks
        /// must not overlap with existing CIDR blocks in the Oracle Database@Amazon Web Services
        /// network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PeerNetworkCidrsToBeAdded { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeerNetworkCidrsToBeAdded property is set.
        /// </summary>
        internal bool IsSetPeerNetworkCidrsToBeAdded() => this.PeerNetworkCidrsToBeAdded != null && (this.PeerNetworkCidrsToBeAdded.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PeerNetworkCidrsToBeRemoved. 
        /// <para>
        /// A list of CIDR blocks to remove from the peering connection. The CIDR blocks must
        /// currently exist in the peering connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PeerNetworkCidrsToBeRemoved { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeerNetworkCidrsToBeRemoved property is set.
        /// </summary>
        internal bool IsSetPeerNetworkCidrsToBeRemoved() => this.PeerNetworkCidrsToBeRemoved != null && (this.PeerNetworkCidrsToBeRemoved.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
