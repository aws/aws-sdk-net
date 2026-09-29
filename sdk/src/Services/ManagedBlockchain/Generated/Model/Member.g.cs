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
    /// Member configuration properties.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class Member
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the member. For more information about ARNs and
        /// their format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that the member was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the member.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FrameworkAttributes. 
        /// <para>
        /// Attributes relevant to a member for the blockchain framework that the Managed Blockchain
        /// network uses.
        /// </para>
        /// </summary>
        public MemberFrameworkAttributes FrameworkAttributes { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkAttributes property is set.
        /// </summary>
        internal bool IsSetFrameworkAttributes() => this.FrameworkAttributes != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the member.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed key in Key Management Service
        /// (KMS) that the member uses for encryption at rest. If the value of this parameter
        /// is <c>"AWS Owned KMS Key"</c>, the member uses an Amazon Web Services owned KMS key
        /// for encryption. This parameter is inherited by the nodes that this member owns.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/managed-blockchain-encryption-at-rest.html">Encryption
        /// at Rest</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
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
        /// Configuration properties for logging events associated with a member.
        /// </para>
        /// </summary>
        public MemberLogPublishingConfiguration LogPublishingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogPublishingConfiguration property is set.
        /// </summary>
        internal bool IsSetLogPublishingConfiguration() => this.LogPublishingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the member.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network to which the member belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a member.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The Amazon Web Services account is in the process of creating a
        /// member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The member has been created and can participate in the network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> - The Amazon Web Services account attempted to create a member
        /// and creation failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The member is in the process of being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The member and all associated resources are in the process of being
        /// deleted. Either the Amazon Web Services account that owns the member deleted it, or
        /// the member is being deleted as the result of an <c>APPROVED</c> <c>PROPOSAL</c> to
        /// remove the member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - The member can no longer participate on the network and all associated
        /// resources are deleted. Either the Amazon Web Services account that owns the member
        /// deleted it, or the member is being deleted as the result of an <c>APPROVED</c> <c>PROPOSAL</c>
        /// to remove the member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACCESSIBLE_ENCRYPTION_KEY</c> - The member is impaired and might not function
        /// as expected because it cannot access the specified customer managed key in KMS for
        /// encryption at rest. Either the KMS key was disabled or deleted, or the grants on the
        /// key were revoked.
        /// </para>
        ///  
        /// <para>
        /// The effect of disabling or deleting a key or of revoking a grant isn't immediate.
        /// It might take some time for the member resource to discover that the key is inaccessible.
        /// When a resource is in this state, we recommend deleting and recreating the resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MemberStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the member. Tags consist of a key and optional value.
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
