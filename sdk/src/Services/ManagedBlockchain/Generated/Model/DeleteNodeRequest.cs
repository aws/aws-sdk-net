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
    /// Container for the parameters to the DeleteNode operation.
    /// Deletes a node that your Amazon Web Services account owns. All data on the node is
    /// lost and cannot be recovered.
    /// 
    ///  
    /// <para>
    /// Applies to Hyperledger Fabric and Ethereum.
    /// </para>
    /// </summary>
    public partial class DeleteNodeRequest : AmazonManagedBlockchainRequest
    {
        private string _memberId;
        private string _networkId;
        private string _nodeId;

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// The unique identifier of the member that owns this node.
        /// </para>
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric and is required for Hyperledger Fabric.
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
        /// The unique identifier of the network that the node is on.
        /// </para>
        ///  
        /// <para>
        /// Ethereum public networks have the following <c>NetworkId</c>s:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>n-ethereum-mainnet</c> 
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
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The unique identifier of the node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

    }
}