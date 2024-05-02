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
    /// Container for the parameters to the ListFilteredTransactionEvents operation.
    /// Lists all the transaction events for an address on the blockchain.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is only supported on the Bitcoin networks.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListFilteredTransactionEventsRequest : AmazonManagedBlockchainQueryRequest
    {
        private AddressIdentifierFilter _addressIdentifierFilter;
        private ConfirmationStatusFilter _confirmationStatusFilter;
        private int? _maxResults;
        private string _network;
        private string _nextToken;
        private ListFilteredTransactionEventsSort _sort;
        private TimeFilter _timeFilter;
        private VoutFilter _voutFilter;

        /// <summary>
        /// Gets and sets the property AddressIdentifierFilter. 
        /// <para>
        /// This is the unique public address on the blockchain for which the transaction events
        /// are being requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AddressIdentifierFilter AddressIdentifierFilter
        {
            get { return this._addressIdentifierFilter; }
            set { this._addressIdentifierFilter = value; }
        }

        // Check to see if AddressIdentifierFilter property is set
        internal bool IsSetAddressIdentifierFilter()
        {
            return this._addressIdentifierFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationStatusFilter.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of transaction events to list.
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
        /// The blockchain network where the transaction occurred.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>BITCOIN_MAINNET</c> | <c>BITCOIN_TESTNET</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Network
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
        public ListFilteredTransactionEventsSort Sort
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
        /// Gets and sets the property TimeFilter. 
        /// <para>
        /// This container specifies the time frame for the transaction events returned in the
        /// response.
        /// </para>
        /// </summary>
        public TimeFilter TimeFilter
        {
            get { return this._timeFilter; }
            set { this._timeFilter = value; }
        }

        // Check to see if TimeFilter property is set
        internal bool IsSetTimeFilter()
        {
            return this._timeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property VoutFilter. 
        /// <para>
        /// This container specifies filtering attributes related to BITCOIN_VOUT event types
        /// </para>
        /// </summary>
        public VoutFilter VoutFilter
        {
            get { return this._voutFilter; }
            set { this._voutFilter = value; }
        }

        // Check to see if VoutFilter property is set
        internal bool IsSetVoutFilter()
        {
            return this._voutFilter != null;
        }

    }
}