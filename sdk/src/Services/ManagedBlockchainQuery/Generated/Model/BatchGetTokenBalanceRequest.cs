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
    /// Container for the parameters to the BatchGetTokenBalance operation.
    /// Gets the token balance for a batch of tokens by using the <c>BatchGetTokenBalance</c>
    /// action for every token in the request.
    /// 
    ///  <note> 
    /// <para>
    /// Only the native tokens BTC and ETH, and the ERC-20, ERC-721, and ERC 1155 token standards
    /// are supported.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchGetTokenBalanceRequest : AmazonManagedBlockchainQueryRequest
    {
        private List<BatchGetTokenBalanceInputItem> _getTokenBalanceInputs = AWSConfigs.InitializeCollections ? new List<BatchGetTokenBalanceInputItem>() : null;

        /// <summary>
        /// Gets and sets the property GetTokenBalanceInputs. 
        /// <para>
        /// An array of <c>BatchGetTokenBalanceInputItem</c> objects whose balance is being requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<BatchGetTokenBalanceInputItem> GetTokenBalanceInputs
        {
            get { return this._getTokenBalanceInputs; }
            set { this._getTokenBalanceInputs = value; }
        }

        // Check to see if GetTokenBalanceInputs property is set
        internal bool IsSetGetTokenBalanceInputs()
        {
            return this._getTokenBalanceInputs != null && (this._getTokenBalanceInputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}