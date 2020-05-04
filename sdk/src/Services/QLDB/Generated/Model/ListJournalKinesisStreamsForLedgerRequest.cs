/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Container for the parameters to the ListJournalKinesisStreamsForLedger operation.
    /// Returns an array of all Amazon QLDB journal stream descriptors for a given ledger.
    /// The output of each stream descriptor includes the same details that are returned by
    /// <code>DescribeJournalKinesisStream</code>.
    /// 
    ///  
    /// <para>
    /// This action returns a maximum of <code>MaxResults</code> items. It is paginated so
    /// that you can retrieve all the items by calling <code>ListJournalKinesisStreamsForLedger</code>
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
        /// The maximum number of results to return in a single <code>ListJournalKinesisStreamsForLedger</code>
        /// request. (The actual number of results returned might be fewer.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// If you received a value for <code>NextToken</code> in the response from a previous
        /// <code>ListJournalKinesisStreamsForLedger</code> call, you should use that value as
        /// input here.
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