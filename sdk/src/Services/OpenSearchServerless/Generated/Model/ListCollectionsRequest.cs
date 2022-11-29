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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Container for the parameters to the ListCollections operation.
    /// Lists all OpenSearch Serverless collections. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
    /// and managing Amazon OpenSearch Serverless collections</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Make sure to include an empty request body {} if you don't include any collection
    /// filters in the request.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListCollectionsRequest : AmazonOpenSearchServerlessRequest
    {
        private CollectionFilters _collectionFilters;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CollectionFilters. 
        /// <para>
        /// List of filter names and values that you can use for requests.
        /// </para>
        /// </summary>
        public CollectionFilters CollectionFilters
        {
            get { return this._collectionFilters; }
            set { this._collectionFilters = value; }
        }

        // Check to see if CollectionFilters property is set
        internal bool IsSetCollectionFilters()
        {
            return this._collectionFilters != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return. Default is 20. You can use <code>nextToken</code>
        /// to get the next page of results.
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
        /// If your initial <code>ListCollections</code> operation returns a <code>nextToken</code>,
        /// you can include the returned <code>nextToken</code> in subsequent <code>ListCollections</code>
        /// operations, which returns results in the next page.
        /// </para>
        /// </summary>
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