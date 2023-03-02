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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the Search operation.
    /// Finds SageMaker resources that match a search query. Matching resources are returned
    /// as a list of <code>SearchRecord</code> objects in the response. You can sort the search
    /// results by any resource property in a ascending or descending order.
    /// 
    ///  
    /// <para>
    /// You can query against the following value types: numeric, text, Boolean, and timestamp.
    /// </para>
    ///  <note> 
    /// <para>
    /// The Search API may provide access to otherwise restricted data. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/api-permissions-reference.html">Amazon
    /// SageMaker API Permissions: Actions, Permissions, and Resources Reference</a> for more
    /// information.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SearchRequest : AmazonSageMakerRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private ResourceType _resource;
        private SearchExpression _searchExpression;
        private string _sortBy;
        private SearchSortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
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
        /// If more than <code>MaxResults</code> resources match the specified <code>SearchExpression</code>,
        /// the response includes a <code>NextToken</code>. The <code>NextToken</code> can be
        /// passed to the next <code>SearchRequest</code> to continue retrieving results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Gets and sets the property Resource. 
        /// <para>
        /// The name of the SageMaker resource to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property SearchExpression. 
        /// <para>
        /// A Boolean conditional statement. Resources must satisfy this condition to be included
        /// in search results. You must provide at least one subexpression, filter, or nested
        /// filter. The maximum number of recursive <code>SubExpressions</code>, <code>NestedFilters</code>,
        /// and <code>Filters</code> that can be included in a <code>SearchExpression</code> object
        /// is 50.
        /// </para>
        /// </summary>
        public SearchExpression SearchExpression
        {
            get { return this._searchExpression; }
            set { this._searchExpression = value; }
        }

        // Check to see if SearchExpression property is set
        internal bool IsSetSearchExpression()
        {
            return this._searchExpression != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The name of the resource property used to sort the <code>SearchResults</code>. The
        /// default is <code>LastModifiedTime</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// How <code>SearchResults</code> are ordered. Valid values are <code>Ascending</code>
        /// or <code>Descending</code>. The default is <code>Descending</code>.
        /// </para>
        /// </summary>
        public SearchSortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}