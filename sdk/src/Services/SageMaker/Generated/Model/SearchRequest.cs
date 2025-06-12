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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the Search operation.
    /// Finds SageMaker resources that match a search query. Matching resources are returned
    /// as a list of <c>SearchRecord</c> objects in the response. You can sort the search
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
        private CrossAccountFilterOption _crossAccountFilterOption;
        private int? _maxResults;
        private string _nextToken;
        private ResourceType _resource;
        private SearchExpression _searchExpression;
        private string _sortBy;
        private SearchSortOrder _sortOrder;
        private List<VisibilityConditions> _visibilityConditions = AWSConfigs.InitializeCollections ? new List<VisibilityConditions>() : null;

        /// <summary>
        /// Gets and sets the property CrossAccountFilterOption. 
        /// <para>
        ///  A cross account filter option. When the value is <c>"CrossAccount"</c> the search
        /// results will only include resources made discoverable to you from other accounts.
        /// When the value is <c>"SameAccount"</c> or <c>null</c> the search results will only
        /// include resources from your account. Default is <c>null</c>. For more information
        /// on searching for resources made discoverable to your account, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/feature-store-cross-account-discoverability-use.html">
        /// Search discoverable resources</a> in the SageMaker Developer Guide. The maximum number
        /// of <c>ResourceCatalog</c>s viewable is 1000. 
        /// </para>
        /// </summary>
        public CrossAccountFilterOption CrossAccountFilterOption
        {
            get { return this._crossAccountFilterOption; }
            set { this._crossAccountFilterOption = value; }
        }

        // Check to see if CrossAccountFilterOption property is set
        internal bool IsSetCrossAccountFilterOption()
        {
            return this._crossAccountFilterOption != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
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
        /// If more than <c>MaxResults</c> resources match the specified <c>SearchExpression</c>,
        /// the response includes a <c>NextToken</c>. The <c>NextToken</c> can be passed to the
        /// next <c>SearchRequest</c> to continue retrieving results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// filter. The maximum number of recursive <c>SubExpressions</c>, <c>NestedFilters</c>,
        /// and <c>Filters</c> that can be included in a <c>SearchExpression</c> object is 50.
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
        /// The name of the resource property used to sort the <c>SearchResults</c>. The default
        /// is <c>LastModifiedTime</c>.
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
        /// How <c>SearchResults</c> are ordered. Valid values are <c>Ascending</c> or <c>Descending</c>.
        /// The default is <c>Descending</c>.
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

        /// <summary>
        /// Gets and sets the property VisibilityConditions. 
        /// <para>
        ///  Limits the results of your search request to the resources that you can access. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<VisibilityConditions> VisibilityConditions
        {
            get { return this._visibilityConditions; }
            set { this._visibilityConditions = value; }
        }

        // Check to see if VisibilityConditions property is set
        internal bool IsSetVisibilityConditions()
        {
            return this._visibilityConditions != null && (this._visibilityConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}