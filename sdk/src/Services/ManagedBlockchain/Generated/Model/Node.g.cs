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

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Configuration properties of a node.
    /// </summary>
    public partial class Node
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the node. For more information about ARNs and their
        /// format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the node exists. Required for Ethereum nodes. 
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that the node was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property FrameworkAttributes. 
        /// <para>
        /// Attributes of the blockchain framework being used.
        /// </para>
        /// </summary>
        public NodeFrameworkAttributes FrameworkAttributes { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkAttributes property is set.
        /// </summary>
        internal bool IsSetFrameworkAttributes() => this.FrameworkAttributes != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the node.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed key in Key Management Service
        /// (KMS) that the node uses for encryption at rest. If the value of this parameter is
        /// <c>"AWS Owned KMS Key"</c>, the node uses an Amazon Web Services owned KMS key for
        /// encryption. The node inherits this parameter from the member that it belongs to.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/managed-blockchain-encryption-at-rest.html">Encryption
        /// at Rest</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LogPublishingConfiguration. 
        /// <para>
        /// Configuration properties for logging events associated with a peer node on a Hyperledger
        /// Fabric network on Managed Blockchain.
        /// </para>
        /// </summary>
        public NodeLogPublishingConfiguration LogPublishingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogPublishingConfiguration property is set.
        /// </summary>
        internal bool IsSetLogPublishingConfiguration() => this.LogPublishingConfiguration != null;

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// The unique identifier of the member to which the node belongs.
        /// </para>
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string MemberId { get; set; }

        /// <summary>
        /// Checks to see if the MemberId property is set.
        /// </summary>
        internal bool IsSetMemberId() => this.MemberId != null;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network that the node is on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property StateDB. 
        /// <para>
        /// The state database that the node uses. Values are <c>LevelDB</c> or <c>CouchDB</c>.
        /// </para>
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        public StateDBType StateDB { get; set; }

        /// <summary>
        /// Checks to see if the StateDB property is set.
        /// </summary>
        internal bool IsSetStateDB() => this.StateDB != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the node.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The Amazon Web Services account is in the process of creating a
        /// node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The node has been created and can participate in the network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNHEALTHY</c> - The node is impaired and might not function as expected. Amazon
        /// Managed Blockchain automatically finds nodes in this state and tries to recover them.
        /// If a node is recoverable, it returns to <c>AVAILABLE</c>. Otherwise, it moves to <c>FAILED</c>
        /// status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> - The Amazon Web Services account attempted to create a node
        /// and creation failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The node is in the process of being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The node is in the process of being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - The node can no longer participate on the network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The node is no longer functional, cannot be recovered, and must be
        /// deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACCESSIBLE_ENCRYPTION_KEY</c> - The node is impaired and might not function
        /// as expected because it cannot access the specified customer managed key in KMS for
        /// encryption at rest. Either the KMS key was disabled or deleted, or the grants on the
        /// key were revoked.
        /// </para>
        ///  
        /// <para>
        /// The effect of disabling or deleting a key or of revoking a grant isn't immediate.
        /// It might take some time for the node resource to discover that the key is inaccessible.
        /// When a resource is in this state, we recommend deleting and recreating the resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NodeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the node. Each tag consists of a key and optional value.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ethereum-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Ethereum Developer Guide</i>, or
        /// <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
