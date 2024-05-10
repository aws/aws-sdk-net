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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
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
    /// Container for the parameters to the GetAssetContract operation.
    /// Gets the information about a specific contract deployed on the blockchain.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// The Bitcoin blockchain networks do not support this operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Metadata is currently only available for some <c>ERC-20</c> contracts. Metadata will
    /// be available for additional contracts in the future.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class GetAssetContractRequest : AmazonManagedBlockchainQueryRequest
    {
        private ContractIdentifier _contractIdentifier;

        /// <summary>
        /// Gets and sets the property ContractIdentifier. 
        /// <para>
        /// Contains the blockchain address and network information about the contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContractIdentifier ContractIdentifier
        {
            get { return this._contractIdentifier; }
            set { this._contractIdentifier = value; }
        }

        // Check to see if ContractIdentifier property is set
        internal bool IsSetContractIdentifier()
        {
            return this._contractIdentifier != null;
        }

    }
}