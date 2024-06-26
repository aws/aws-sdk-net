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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
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
    /// Attributes of Ethereum for a network.
    /// </summary>
    public partial class NetworkEthereumAttributes
    {
        private string _chainId;

        /// <summary>
        /// Gets and sets the property ChainId. 
        /// <para>
        /// The Ethereum <c>CHAIN_ID</c> associated with the Ethereum network. Chain IDs are as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// mainnet = <c>1</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ChainId
        {
            get { return this._chainId; }
            set { this._chainId = value; }
        }

        // Check to see if ChainId property is set
        internal bool IsSetChainId()
        {
            return this._chainId != null;
        }

    }
}