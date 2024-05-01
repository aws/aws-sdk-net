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
    /// The contract or wallet address by which to filter the request.
    /// </summary>
    public partial class ContractFilter
    {
        private string _deployerAddress;
        private QueryNetwork _network;
        private QueryTokenStandard _tokenStandard;

        /// <summary>
        /// Gets and sets the property DeployerAddress. 
        /// <para>
        /// The network address of the deployer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeployerAddress
        {
            get { return this._deployerAddress; }
            set { this._deployerAddress = value; }
        }

        // Check to see if DeployerAddress property is set
        internal bool IsSetDeployerAddress()
        {
            return this._deployerAddress != null;
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

        /// <summary>
        /// Gets and sets the property TokenStandard. 
        /// <para>
        /// The container for the token standard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryTokenStandard TokenStandard
        {
            get { return this._tokenStandard; }
            set { this._tokenStandard = value; }
        }

        // Check to see if TokenStandard property is set
        internal bool IsSetTokenStandard()
        {
            return this._tokenStandard != null;
        }

    }
}