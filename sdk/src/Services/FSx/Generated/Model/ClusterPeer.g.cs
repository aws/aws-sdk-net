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
    /// Describes an Amazon FSx for NetApp ONTAP cluster peer relationship.
    /// </summary>
    public partial class ClusterPeer
    {
        /// <summary>
        /// Gets and sets the property AllowedSvmIds. 
        /// <para>
        /// The IDs of the SVMs on the file system that are preauthorized for SVM peering with
        /// the peer cluster, if <c>AllowedSvmMode</c> is <c>SPECIFIED</c>.
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
        /// Indicates which SVMs on the file system are preauthorized for SVM peering with the
        /// peer cluster.
        /// </para>
        /// </summary>
        public AllowedSvmMode AllowedSvmMode { get; set; }

        /// <summary>
        /// Checks to see if the AllowedSvmMode property is set.
        /// </summary>
        internal bool IsSetAllowedSvmMode() => this.AllowedSvmMode != null;

        /// <summary>
        /// Gets and sets the property AuthenticationStatus. 
        /// <para>
        /// The authentication status of the cluster peer relationship.
        /// </para>
        /// </summary>
        public ClusterPeerAuthenticationStatus AuthenticationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationStatus property is set.
        /// </summary>
        internal bool IsSetAuthenticationStatus() => this.AuthenticationStatus != null;

        /// <summary>
        /// Gets and sets the property ClusterPeerId. 
        /// <para>
        /// The system-generated, unique ID of the cluster peer.
        /// </para>
        /// </summary>
        public string ClusterPeerId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterPeerId property is set.
        /// </summary>
        internal bool IsSetClusterPeerId() => this.ClusterPeerId != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The globally unique ID of the file system, assigned by Amazon FSx.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the cluster peer can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATED</c> – The cluster peer is fully available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> – Amazon FSx is creating the cluster peer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> – Amazon FSx is deleting the cluster peer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – Amazon FSx was unable to create the cluster peer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ClusterPeerLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property LifecycleTransitionReason. 
        /// <para>
        /// The reason why the cluster peer lifecycle status changed.
        /// </para>
        /// </summary>
        public LifecycleTransitionReason LifecycleTransitionReason { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleTransitionReason property is set.
        /// </summary>
        internal bool IsSetLifecycleTransitionReason() => this.LifecycleTransitionReason != null;

        /// <summary>
        /// Gets and sets the property PassphraseSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret containing
        /// the cluster peering passphrase.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 1024)]
        public string PassphraseSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the PassphraseSecretArn property is set.
        /// </summary>
        internal bool IsSetPassphraseSecretArn() => this.PassphraseSecretArn != null;

        /// <summary>
        /// Gets and sets the property PeerAddresses. 
        /// <para>
        /// The IP addresses of the intercluster logical interfaces (LIFs) on the peer cluster.
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
        /// The name that the file system uses to identify the peer cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 44)]
        public string PeerClusterName { get; set; }

        /// <summary>
        /// Checks to see if the PeerClusterName property is set.
        /// </summary>
        internal bool IsSetPeerClusterName() => this.PeerClusterName != null;

        /// <summary>
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Min = 8, Max = 512)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the connection to the peer cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The cluster peer's universally unique identifier (UUID).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 36)]
        public string UUID { get; set; }

        /// <summary>
        /// Checks to see if the UUID property is set.
        /// </summary>
        internal bool IsSetUUID() => this.UUID != null;
    }
}
