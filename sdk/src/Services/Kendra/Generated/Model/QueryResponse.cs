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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the Query operation.
    /// </summary>
    public partial class QueryResponse : AmazonWebServiceResponse
    {
        private List<FacetResult> _facetResults = new List<FacetResult>();
        private string _queryId;
        private List<QueryResultItem> _resultItems = new List<QueryResultItem>();
        private int? _totalNumberOfResults;

        /// <summary>
        /// Gets and sets the property FacetResults. 
        /// <para>
        /// Contains the facet results. A <code>FacetResult</code> contains the counts for each
        /// attribute key that was specified in the <code>Facets</code> input parameter.
        /// </para>
        /// </summary>
        public List<FacetResult> FacetResults
        {
            get { return this._facetResults; }
            set { this._facetResults = value; }
        }

        // Check to see if FacetResults property is set
        internal bool IsSetFacetResults()
        {
            return this._facetResults != null && this._facetResults.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The unique identifier for the search. You use <code>QueryId</code> to identify the
        /// search when using the feedback API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property ResultItems. 
        /// <para>
        /// The results of the search.
        /// </para>
        /// </summary>
        public List<QueryResultItem> ResultItems
        {
            get { return this._resultItems; }
            set { this._resultItems = value; }
        }

        // Check to see if ResultItems property is set
        internal bool IsSetResultItems()
        {
            return this._resultItems != null && this._resultItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfResults. 
        /// <para>
        /// The total number of items found by the search; however, you can only retrieve up to
        /// 100 items. For example, if the search found 192 items, you can only retrieve the first
        /// 100 of the items.
        /// </para>
        /// </summary>
        public int TotalNumberOfResults
        {
            get { return this._totalNumberOfResults.GetValueOrDefault(); }
            set { this._totalNumberOfResults = value; }
        }

        // Check to see if TotalNumberOfResults property is set
        internal bool IsSetTotalNumberOfResults()
        {
            return this._totalNumberOfResults.HasValue; 
        }

    }
}