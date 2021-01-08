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

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// This is the response object from the ListJournalKinesisStreamsForLedger operation.
    /// </summary>
    public partial class ListJournalKinesisStreamsForLedgerResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<JournalKinesisStreamDescription> _streams = new List<JournalKinesisStreamDescription>();

        /// <summary>
        /// Gets and sets the property NextToken. <ul> <li> 
        /// <para>
        /// If <code>NextToken</code> is empty, the last page of results has been processed and
        /// there are no more results to be retrieved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>NextToken</code> is <i>not</i> empty, more results are available. To retrieve
        /// the next page of results, use the value of <code>NextToken</code> in a subsequent
        /// <code>ListJournalKinesisStreamsForLedger</code> call.
        /// </para>
        ///  </li> </ul>
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

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        /// The array of QLDB journal stream descriptors that are associated with the given ledger.
        /// </para>
        /// </summary>
        public List<JournalKinesisStreamDescription> Streams
        {
            get { return this._streams; }
            set { this._streams = value; }
        }

        // Check to see if Streams property is set
        internal bool IsSetStreams()
        {
            return this._streams != null && this._streams.Count > 0; 
        }

    }
}