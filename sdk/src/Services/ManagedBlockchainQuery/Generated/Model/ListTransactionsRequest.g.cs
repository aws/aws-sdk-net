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
    /// Container for the parameters to the ListTransactions operation. Lists all the transaction
    /// events for a transaction.
    /// </summary>
    public partial class ListTransactionsRequest : AmazonManagedBlockchainQueryRequest
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The address (either a contract or wallet), whose transactions are being requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property ConfirmationStatusFilter. 
        /// <para>
        /// This filter is used to include transactions in the response that haven't reached <a
        /// href="https://docs.aws.amazon.com/managed-blockchain/latest/ambq-dg/key-concepts.html#finality">
        /// <i>finality</i> </a>. Transactions that have reached finality are always part of the
        /// response.
        /// </para>
        /// </summary>
        public ConfirmationStatusFilter ConfirmationStatusFilter { get; set; }

        /// <summary>
        /// Checks to see if the ConfirmationStatusFilter property is set.
        /// </summary>
        internal bool IsSetConfirmationStatusFilter() => this.ConfirmationStatusFilter != null;

        /// <summary>
        /// Gets and sets the property FromBlockchainInstant.
        /// </summary>
        public BlockchainInstant FromBlockchainInstant { get; set; }

        /// <summary>
        /// Checks to see if the FromBlockchainInstant property is set.
        /// </summary>
        internal bool IsSetFromBlockchainInstant() => this.FromBlockchainInstant != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of transactions to list.
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
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network where the transactions occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryNetwork Network { get; set; }

        /// <summary>
        /// Checks to see if the Network property is set.
        /// </summary>
        internal bool IsSetNetwork() => this.Network != null;

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
        /// Gets and sets the property Sort. 
        /// <para>
        /// The order by which the results will be sorted. 
        /// </para>
        /// </summary>
        public ListTransactionsSort Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;

        /// <summary>
        /// Gets and sets the property ToBlockchainInstant.
        /// </summary>
        public BlockchainInstant ToBlockchainInstant { get; set; }

        /// <summary>
        /// Checks to see if the ToBlockchainInstant property is set.
        /// </summary>
        internal bool IsSetToBlockchainInstant() => this.ToBlockchainInstant != null;
    }
}
