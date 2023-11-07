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

namespace Amazon.ManagedBlockchainQuery.Model
{
    /// <summary>
    /// The container for the identifier for the token including the unique token ID and its
    /// blockchain network.
    /// 
    ///  <note> 
    /// <para>
    /// Only the native tokens BTC,ETH, and the ERC-20, ERC-721, and ERC 1155 token standards
    /// are supported.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TokenIdentifier
    {
        private string _contractAddress;
        private QueryNetwork _network;
        private string _tokenId;

        /// <summary>
        /// Gets and sets the property ContractAddress. 
        /// <para>
        /// This is the token's contract address.
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
        ///  <note> 
        /// <para>
        /// You must specify this container with <code>btc</code> for the native BTC token, and
        /// <code>eth</code> for the native ETH token. For all other token types you must specify
        /// the <code>tokenId</code> in the 64 character hexadecimal <code>tokenid</code> format.
        /// </para>
        ///  </note>
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