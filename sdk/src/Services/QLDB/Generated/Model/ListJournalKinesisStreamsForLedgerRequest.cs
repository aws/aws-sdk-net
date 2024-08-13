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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
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
namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Container for the parameters to the ListJournalKinesisStreamsForLedger operation.
    /// Returns all Amazon QLDB journal streams for a given ledger.
    /// 
    ///  
    /// <para>
    /// This action does not return any expired journal streams. For more information, see
    /// <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/streams.create.html#streams.create.states.expiration">Expiration
    /// for terminal streams</a> in the <i>Amazon QLDB Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This action returns a maximum of <c>MaxResults</c> items. It is paginated so that
    /// you can retrieve all the items by calling <c>ListJournalKinesisStreamsForLedger</c>
    /// multiple times.
    /// </para>
    /// </summary>
    public partial class ListJournalKinesisStreamsForLedgerRequest : AmazonQLDBRequest
    {
        private string _ledgerName;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LedgerName. 
        /// <para>
        /// The name of the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string LedgerName
        {
            get { return this._ledgerName; }
            set { this._ledgerName = value; }
        }

        // Check to see if LedgerName property is set
        internal bool IsSetLedgerName()
        {
            return this._ledgerName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single <c>ListJournalKinesisStreamsForLedger</c>
        /// request. (The actual number of results returned might be fewer.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token, indicating that you want to retrieve the next page of results.
        /// If you received a value for <c>NextToken</c> in the response from a previous <c>ListJournalKinesisStreamsForLedger</c>
        /// call, you should use that value as input here.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
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

    }
}