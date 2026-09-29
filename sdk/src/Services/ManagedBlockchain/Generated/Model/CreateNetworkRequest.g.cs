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
    /// Container for the parameters to the CreateNetwork operation. Creates a new blockchain
    /// network using Amazon Managed Blockchain. <para> Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class CreateNetworkRequest : AmazonManagedBlockchainRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// This is a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the operation. An idempotent operation completes no more than once. This identifier
        /// is required only if you make a service request directly using an HTTP client. It is
        /// generated automatically if you use an Amazon Web Services SDK or the Amazon Web Services
        /// CLI. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Framework. 
        /// <para>
        /// The blockchain framework that the network uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Framework Framework { get; set; }

        /// <summary>
        /// Checks to see if the Framework property is set.
        /// </summary>
        internal bool IsSetFramework() => this.Framework != null;

        /// <summary>
        /// Gets and sets the property FrameworkConfiguration. 
        /// <para>
        ///  Configuration properties of the blockchain framework relevant to the network configuration.
        /// 
        /// </para>
        /// </summary>
        public NetworkFrameworkConfiguration FrameworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkConfiguration property is set.
        /// </summary>
        internal bool IsSetFrameworkConfiguration() => this.FrameworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property FrameworkVersion. 
        /// <para>
        /// The version of the blockchain framework that the network uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public string FrameworkVersion { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkVersion property is set.
        /// </summary>
        internal bool IsSetFrameworkVersion() => this.FrameworkVersion != null;

        /// <summary>
        /// Gets and sets the property MemberConfiguration. 
        /// <para>
        /// Configuration properties for the first member within the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemberConfiguration MemberConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MemberConfiguration property is set.
        /// </summary>
        internal bool IsSetMemberConfiguration() => this.MemberConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network.
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
        /// Tags to assign to the network.
        /// </para>
        ///  
        /// <para>
        ///  Each tag consists of a key and an optional value. You can specify multiple key-value
        /// pairs in a single request with an overall maximum of 50 tags allowed per resource.
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

        /// <summary>
        /// Gets and sets the property VotingPolicy. 
        /// <para>
        ///  The voting rules used by the network to determine if a proposal is approved. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VotingPolicy VotingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the VotingPolicy property is set.
        /// </summary>
        internal bool IsSetVotingPolicy() => this.VotingPolicy != null;
    }
}
