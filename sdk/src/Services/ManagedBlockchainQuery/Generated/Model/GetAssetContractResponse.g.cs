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

namespace Amazon.ManagedBlockchainQuery.Model
{
    /// <summary>
    /// This is the response object from the GetAssetContract operation.
    /// </summary>
    public partial class GetAssetContractResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ContractIdentifier. 
        /// <para>
        /// Contains the blockchain address and network information about the contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContractIdentifier ContractIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ContractIdentifier property is set.
        /// </summary>
        internal bool IsSetContractIdentifier() => this.ContractIdentifier != null;

        /// <summary>
        /// Gets and sets the property DeployerAddress. 
        /// <para>
        /// The address of the deployer of contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeployerAddress { get; set; }

        /// <summary>
        /// Checks to see if the DeployerAddress property is set.
        /// </summary>
        internal bool IsSetDeployerAddress() => this.DeployerAddress != null;

        /// <summary>
        /// Gets and sets the property Metadata.
        /// </summary>
        public ContractMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property TokenStandard. 
        /// <para>
        /// The token standard of the contract requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryTokenStandard TokenStandard { get; set; }

        /// <summary>
        /// Checks to see if the TokenStandard property is set.
        /// </summary>
        internal bool IsSetTokenStandard() => this.TokenStandard != null;
    }
}
