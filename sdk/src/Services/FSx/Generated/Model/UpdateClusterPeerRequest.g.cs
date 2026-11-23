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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateClusterPeer operation. Updates an Amazon
    /// FSx for NetApp ONTAP cluster peer relationship.
    /// </summary>
    public partial class UpdateClusterPeerRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ClusterPeerId. 
        /// <para>
        /// The ID of the cluster peer that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterPeerId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterPeerId property is set.
        /// </summary>
        internal bool IsSetClusterPeerId() => this.ClusterPeerId != null;

        /// <summary>
        /// Gets and sets the property PeerAddresses. 
        /// <para>
        /// Specifies the IP addresses of the intercluster logical interfaces (LIFs) on the peer
        /// cluster. The addresses that you specify replace the existing peer addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 288)]
        public List<string> PeerAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeerAddresses property is set.
        /// </summary>
        internal bool IsSetPeerAddresses() => this.PeerAddresses != null && (this.PeerAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PeerClusterName. 
        /// <para>
        /// Specifies the name that the file system uses to identify the peer cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 44)]
        public string PeerClusterName { get; set; }

        /// <summary>
        /// Checks to see if the PeerClusterName property is set.
        /// </summary>
        internal bool IsSetPeerClusterName() => this.PeerClusterName != null;
    }
}
