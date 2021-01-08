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

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Container for the parameters to the CreateNode operation.
    /// Creates a node on the specified blockchain network.
    /// 
    ///  
    /// <para>
    /// Applies to Hyperledger Fabric and Ethereum.
    /// </para>
    /// </summary>
    public partial class CreateNodeRequest : AmazonManagedBlockchainRequest
    {
        private string _clientRequestToken;
        private string _memberId;
        private string _networkId;
        private NodeConfiguration _nodeConfiguration;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the operation. An idempotent operation completes no more than one time. This identifier
        /// is required only if you make a service request directly using an HTTP client. It is
        /// generated automatically if you use an AWS SDK or the AWS CLI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// The unique identifier of the member that owns this node.
        /// </para>
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string MemberId
        {
            get { return this._memberId; }
            set { this._memberId = value; }
        }

        // Check to see if MemberId property is set
        internal bool IsSetMemberId()
        {
            return this._memberId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network for the node.
        /// </para>
        ///  
        /// <para>
        /// Ethereum public networks have the following <code>NetworkId</code>s:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>n-ethereum-mainnet</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>n-ethereum-rinkeby</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>n-ethereum-ropsten</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeConfiguration. 
        /// <para>
        /// The properties of a node configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NodeConfiguration NodeConfiguration
        {
            get { return this._nodeConfiguration; }
            set { this._nodeConfiguration = value; }
        }

        // Check to see if NodeConfiguration property is set
        internal bool IsSetNodeConfiguration()
        {
            return this._nodeConfiguration != null;
        }

    }
}