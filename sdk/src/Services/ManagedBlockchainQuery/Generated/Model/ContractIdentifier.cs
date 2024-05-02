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
    /// Container for the blockchain address and network information about a contract.
    /// </summary>
    public partial class ContractIdentifier
    {
        private string _contractAddress;
        private QueryNetwork _network;

        /// <summary>
        /// Gets and sets the property ContractAddress. 
        /// <para>
        /// Container for the blockchain address about a contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The blockchain network of the contract.
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

    }
}