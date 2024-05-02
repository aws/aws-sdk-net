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
    /// Container for the parameters to the ListTransactions operation.
    /// Lists all the transaction events for a transaction.
    /// </summary>
    public partial class ListTransactionsRequest : AmazonManagedBlockchainQueryRequest
    {
        private string _address;
        private ConfirmationStatusFilter _confirmationStatusFilter;
        private BlockchainInstant _fromBlockchainInstant;
        private int? _maxResults;
        private QueryNetwork _network;
        private string _nextToken;
        private ListTransactionsSort _sort;
        private BlockchainInstant _toBlockchainInstant;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The address (either a contract or wallet), whose transactions are being requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationStatusFilter. 
        /// <para>
        /// This filter is used to include transactions in the response that haven't reached <a
        /// href="https://docs.aws.amazon.com/managed-blockchain/latest/ambq-dg/key-concepts.html#finality">
        /// <i>finality</i> </a>. Transactions that have reached finality are always part of the
        /// response.
        /// </para>
        /// </summary>
        public ConfirmationStatusFilter ConfirmationStatusFilter
        {
            get { return this._confirmationStatusFilter; }
            set { this._confirmationStatusFilter = value; }
        }

        // Check to see if ConfirmationStatusFilter property is set
        internal bool IsSetConfirmationStatusFilter()
        {
            return this._confirmationStatusFilter != null;
        }

        /// <summary>
        /// Gets and sets the property FromBlockchainInstant.
        /// </summary>
        public BlockchainInstant FromBlockchainInstant
        {
            get { return this._fromBlockchainInstant; }
            set { this._fromBlockchainInstant = value; }
        }

        // Check to see if FromBlockchainInstant property is set
        internal bool IsSetFromBlockchainInstant()
        {
            return this._fromBlockchainInstant != null;
        }

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
        [AWSProperty(Min=1, Max=250)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network where the transactions occurred.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131070)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The order by which the results will be sorted. 
        /// </para>
        /// </summary>
        public ListTransactionsSort Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

        /// <summary>
        /// Gets and sets the property ToBlockchainInstant.
        /// </summary>
        public BlockchainInstant ToBlockchainInstant
        {
            get { return this._toBlockchainInstant; }
            set { this._toBlockchainInstant = value; }
        }

        // Check to see if ToBlockchainInstant property is set
        internal bool IsSetToBlockchainInstant()
        {
            return this._toBlockchainInstant != null;
        }

    }
}