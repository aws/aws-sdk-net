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
    /// Configuration properties of the member.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class MemberConfiguration
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the member.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FrameworkConfiguration. 
        /// <para>
        /// Configuration properties of the blockchain framework relevant to the member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemberFrameworkConfiguration FrameworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkConfiguration property is set.
        /// </summary>
        internal bool IsSetFrameworkConfiguration() => this.FrameworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed key in Key Management Service
        /// (KMS) to use for encryption at rest in the member. This parameter is inherited by
        /// any nodes that this member creates. For more information, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/managed-blockchain-encryption-at-rest.html">Encryption
        /// at Rest</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Use one of the following options to specify this parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Undefined or empty string</b> - By default, use an KMS key that is owned and managed
        /// by Amazon Web Services on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>A valid symmetric customer managed KMS key</b> - Use the specified KMS key in
        /// your account that you create, own, and manage.
        /// </para>
        ///  
        /// <para>
        /// Amazon Managed Blockchain doesn't support asymmetric keys. For more information, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// symmetric and asymmetric keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following is an example of a KMS key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LogPublishingConfiguration. 
        /// <para>
        /// Configuration properties for logging events associated with a member of a Managed
        /// Blockchain network.
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
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the member. Tags consist of a key and optional value. 
        /// </para>
        ///  
        /// <para>
        /// When specifying tags during creation, you can specify multiple key-value pairs in
        /// a single request, with an overall maximum of 50 tags added to each resource.
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
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
