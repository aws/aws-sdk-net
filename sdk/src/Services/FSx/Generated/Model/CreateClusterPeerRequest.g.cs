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
    /// Container for the parameters to the CreateClusterPeer operation. Creates a cluster
    /// peer relationship between an Amazon FSx for NetApp ONTAP file system and another ONTAP
    /// cluster. <para> The <c>CreateClusterPeer</c> operation returns while the cluster peer's
    /// lifecycle state is still <c>CREATING</c>. You can check the cluster peer creation
    /// status by calling the DescribeClusterPeers operation. </para>
    /// </summary>
    public partial class CreateClusterPeerRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedSvmIds. 
        /// <para>
        /// Specifies the IDs of the SVMs on the file system that are preauthorized for SVM peering
        /// with the peer cluster. You can specify <c>AllowedSvmIds</c> only when <c>AllowedSvmMode</c>
        /// is <c>SPECIFIED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 24)]
        public List<string> AllowedSvmIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedSvmIds property is set.
        /// </summary>
        internal bool IsSetAllowedSvmIds() => this.AllowedSvmIds != null && (this.AllowedSvmIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedSvmMode. 
        /// <para>
        /// Specifies which SVMs on the file system are preauthorized for SVM peering with the
        /// peer cluster.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL</c> – All SVMs on the file system are preauthorized. You can't specify <c>AllowedSvmIds</c>
        /// along with this property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> – No SVMs on the file system are preauthorized. You can't specify <c>AllowedSvmIds</c>
        /// along with this property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPECIFIED</c> – Only the SVMs in <c>AllowedSvmIds</c> are preauthorized. You must
        /// specify <c>AllowedSvmIds</c> along with this property.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AllowedSvmMode AllowedSvmMode { get; set; }

        /// <summary>
        /// Checks to see if the AllowedSvmMode property is set.
        /// </summary>
        internal bool IsSetAllowedSvmMode() => this.AllowedSvmMode != null;

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
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// Specifies the ID of the Amazon FSx for NetApp ONTAP file system on which to create
        /// the cluster peer relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property PassphraseSecretArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager
        /// secret containing the cluster peering passphrase. Store the passphrase as a plaintext
        /// secret value, not as a key-value pair. The secret must be in the same Amazon Web Services
        /// Region as the file system. You must use the same passphrase when you create the cluster
        /// peer relationship on the peer cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 64, Max = 1024)]
        public string PassphraseSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the PassphraseSecretArn property is set.
        /// </summary>
        internal bool IsSetPassphraseSecretArn() => this.PassphraseSecretArn != null;

        /// <summary>
        /// Gets and sets the property PeerAddresses. 
        /// <para>
        /// Specifies the IP addresses of the intercluster logical interfaces (LIFs) on the peer
        /// cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 288)]
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

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
