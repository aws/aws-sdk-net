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
    /// Network configuration properties.
    /// </summary>
    public partial class Network
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network. For more information about ARNs and
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
        /// The date and time that the network was created.
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
        /// Attributes of the blockchain framework for the network.
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
        public Framework Framework { get; set; }

        /// <summary>
        /// Checks to see if the Framework property is set.
        /// </summary>
        internal bool IsSetFramework() => this.Framework != null;

        /// <summary>
        /// Gets and sets the property FrameworkAttributes. 
        /// <para>
        /// Attributes of the blockchain framework that the network uses.
        /// </para>
        /// </summary>
        public NetworkFrameworkAttributes FrameworkAttributes { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkAttributes property is set.
        /// </summary>
        internal bool IsSetFrameworkAttributes() => this.FrameworkAttributes != null;

        /// <summary>
        /// Gets and sets the property FrameworkVersion. 
        /// <para>
        /// The version of the blockchain framework that the network uses.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public string FrameworkVersion { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkVersion property is set.
        /// </summary>
        internal bool IsSetFrameworkVersion() => this.FrameworkVersion != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the network.
        /// </para>
        /// </summary>
        public NetworkStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the network. Each tag consists of a key and optional value.
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

        /// <summary>
        /// Gets and sets the property VotingPolicy. 
        /// <para>
        /// The voting rules that the network uses to decide if a proposal is accepted.
        /// </para>
        /// </summary>
        public VotingPolicy VotingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the VotingPolicy property is set.
        /// </summary>
        internal bool IsSetVotingPolicy() => this.VotingPolicy != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointServiceName. 
        /// <para>
        /// The VPC endpoint service name of the VPC endpoint service of the network. Members
        /// use the VPC endpoint service name to create a VPC endpoint to access network resources.
        /// </para>
        /// </summary>
        public string VpcEndpointServiceName { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointServiceName property is set.
        /// </summary>
        internal bool IsSetVpcEndpointServiceName() => this.VpcEndpointServiceName != null;
    }
}
