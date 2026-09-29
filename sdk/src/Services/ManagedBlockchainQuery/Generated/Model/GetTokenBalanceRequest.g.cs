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
    /// Container for the parameters to the GetTokenBalance operation. Gets the balance of
    /// a specific token, including native tokens, for a given address (wallet or contract)
    /// on the blockchain. <note> <para> Only the native tokens BTC and ETH, and the ERC-20,
    /// ERC-721, and ERC 1155 token standards are supported. </para> </note>
    /// </summary>
    public partial class GetTokenBalanceRequest : AmazonManagedBlockchainQueryRequest
    {
        /// <summary>
        /// Gets and sets the property AtBlockchainInstant. 
        /// <para>
        /// The time for when the TokenBalance is requested or the current time if a time is not
        /// provided in the request.
        /// </para>
        ///  <note> 
        /// <para>
        /// This time will only be recorded up to the second.
        /// </para>
        ///  </note>
        /// </summary>
        public BlockchainInstant AtBlockchainInstant { get; set; }

        /// <summary>
        /// Checks to see if the AtBlockchainInstant property is set.
        /// </summary>
        internal bool IsSetAtBlockchainInstant() => this.AtBlockchainInstant != null;

        /// <summary>
        /// Gets and sets the property OwnerIdentifier. 
        /// <para>
        /// The container for the identifier for the owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OwnerIdentifier OwnerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OwnerIdentifier property is set.
        /// </summary>
        internal bool IsSetOwnerIdentifier() => this.OwnerIdentifier != null;

        /// <summary>
        /// Gets and sets the property TokenIdentifier. 
        /// <para>
        /// The container for the identifier for the token, including the unique token ID and
        /// its blockchain network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TokenIdentifier TokenIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TokenIdentifier property is set.
        /// </summary>
        internal bool IsSetTokenIdentifier() => this.TokenIdentifier != null;
    }
}
