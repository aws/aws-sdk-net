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
    /// The container of the token filter like the contract address on a given blockchain
    /// network or a unique token identifier on a given blockchain network.
    /// 
    ///  <note> 
    /// <para>
    /// You must always specify the network property of this container when using this operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TokenFilter
    {
        private string _contractAddress;
        private QueryNetwork _network;
        private string _tokenId;

        /// <summary>
        /// Gets and sets the property ContractAddress. 
        /// <para>
        /// This is the address of the contract.
        /// </para>
        /// </summary>
        public string ContractAddress
        {
            get { return this._contractAddress; }
            set { this._contractAddress = value; }
        }

        // Check to see if ContractAddress property is set
        internal bool IsSetContractAddress()
        {
            return this._contractAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network of the token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryNetwork Network
        {
            get { return this._network; }
            set { this._network = value; }
        }

        // Check to see if Network property is set
        internal bool IsSetNetwork()
        {
            return this._network != null;
        }

        /// <summary>
        /// Gets and sets the property TokenId. 
        /// <para>
        /// The unique identifier of the token.
        /// </para>
        /// </summary>
        public string TokenId
        {
            get { return this._tokenId; }
            set { this._tokenId = value; }
        }

        // Check to see if TokenId property is set
        internal bool IsSetTokenId()
        {
            return this._tokenId != null;
        }

    }
}