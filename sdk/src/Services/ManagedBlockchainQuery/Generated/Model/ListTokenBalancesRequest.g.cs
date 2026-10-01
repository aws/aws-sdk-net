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
    /// Container for the parameters to the ListTokenBalances operation. This action returns
    /// the following for a given blockchain network: <ul> <li> <para> Lists all token balances
    /// owned by an address (either a contract address or a wallet address). </para> </li>
    /// <li> <para> Lists all token balances for all tokens created by a contract. </para>
    /// </li> <li> <para> Lists all token balances for a given token. </para> </li> </ul>
    /// <note> <para> You must always specify the network property of the <c>tokenFilter</c>
    /// when using this operation. </para> </note>
    /// </summary>
    public partial class ListTokenBalancesRequest : AmazonManagedBlockchainQueryRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of token balances to return.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>100</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Even if additional results can be retrieved, the request can return less results than
        /// <c>maxResults</c> or an empty array of results.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the next set of results, make another request with the returned <c>nextToken</c>
        /// value. The value of <c>nextToken</c> is <c>null</c> when there are no more results
        /// to return
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131070)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OwnerFilter. 
        /// <para>
        /// The contract or wallet address on the blockchain network by which to filter the request.
        /// You must specify the <c>address</c> property of the <c>ownerFilter</c> when listing
        /// balances of tokens owned by the address.
        /// </para>
        /// </summary>
        public OwnerFilter OwnerFilter { get; set; }

        /// <summary>
        /// Checks to see if the OwnerFilter property is set.
        /// </summary>
        internal bool IsSetOwnerFilter() => this.OwnerFilter != null;

        /// <summary>
        /// Gets and sets the property TokenFilter. 
        /// <para>
        /// The contract address or a token identifier on the blockchain network by which to filter
        /// the request. You must specify the <c>contractAddress</c> property of this container
        /// when listing tokens minted by a contract.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must always specify the network property of this container when using this operation.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public TokenFilter TokenFilter { get; set; }

        /// <summary>
        /// Checks to see if the TokenFilter property is set.
        /// </summary>
        internal bool IsSetTokenFilter() => this.TokenFilter != null;
    }
}
