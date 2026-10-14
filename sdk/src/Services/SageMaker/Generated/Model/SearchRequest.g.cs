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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the Search operation. Finds SageMaker resources that
    /// match a search query. Matching resources are returned as a list of <c>SearchRecord</c>
    /// objects in the response. You can sort the search results by any resource property
    /// in a ascending or descending order. <para> You can query against the following value
    /// types: numeric, text, Boolean, and timestamp. </para> <note> <para> The Search API
    /// may provide access to otherwise restricted data. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/api-permissions-reference.html">Amazon
    /// SageMaker API Permissions: Actions, Permissions, and Resources Reference</a> for more
    /// information. </para> </note>
    /// </summary>
    public partial class SearchRequest : AmazonSageMakerRequest
    {
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
        public CrossAccountFilterOption CrossAccountFilterOption { get; set; }

        /// <summary>
        /// Checks to see if the CrossAccountFilterOption property is set.
        /// </summary>
        internal bool IsSetCrossAccountFilterOption() => this.CrossAccountFilterOption != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If more than <c>MaxResults</c> resources match the specified <c>SearchExpression</c>,
        /// the response includes a <c>NextToken</c>. The <c>NextToken</c> can be passed to the
        /// next <c>SearchRequest</c> to continue retrieving results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The name of the SageMaker resource to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property SearchExpression. 
        /// <para>
        /// A Boolean conditional statement. Resources must satisfy this condition to be included
        /// in search results. You must provide at least one subexpression, filter, or nested
        /// filter. The maximum number of recursive <c>SubExpressions</c>, <c>NestedFilters</c>,
        /// and <c>Filters</c> that can be included in a <c>SearchExpression</c> object is 50.
        /// </para>
        /// </summary>
        public SearchExpression SearchExpression { get; set; }

        /// <summary>
        /// Checks to see if the SearchExpression property is set.
        /// </summary>
        internal bool IsSetSearchExpression() => this.SearchExpression != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The name of the resource property used to sort the <c>SearchResults</c>. The default
        /// is <c>LastModifiedTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// How <c>SearchResults</c> are ordered. Valid values are <c>Ascending</c> or <c>Descending</c>.
        /// The default is <c>Descending</c>.
        /// </para>
        /// </summary>
        public SearchSortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property VisibilityConditions. 
        /// <para>
        ///  Limits the results of your search request to the resources that you can access. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<VisibilityConditions> VisibilityConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<VisibilityConditions>() : null;

        /// <summary>
        /// Checks to see if the VisibilityConditions property is set.
        /// </summary>
        internal bool IsSetVisibilityConditions() => this.VisibilityConditions != null && (this.VisibilityConditions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
