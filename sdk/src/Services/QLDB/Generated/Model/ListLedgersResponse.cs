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
    /// This is the response object from the ListLedgers operation.
    /// </summary>
    public partial class ListLedgersResponse : AmazonWebServiceResponse
    {
        private List<LedgerSummary> _ledgers = new List<LedgerSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Ledgers. 
        /// <para>
        /// The ledgers that are associated with the current Amazon Web Services account and Region.
        /// </para>
        /// </summary>
        public List<LedgerSummary> Ledgers
        {
            get { return this._ledgers; }
            set { this._ledgers = value; }
        }

        // Check to see if Ledgers property is set
        internal bool IsSetLedgers()
        {
            return this._ledgers != null && this._ledgers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token, indicating whether there are more results available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>NextToken</code> is empty, then the last page of results has been processed
        /// and there are no more results to be retrieved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>NextToken</code> is <i>not</i> empty, then there are more results available.
        /// To retrieve the next page of results, use the value of <code>NextToken</code> in a
        /// subsequent <code>ListLedgers</code> call.
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

    }
}