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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the Query operation.
    /// </summary>
    public partial class QueryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FacetResults. 
        /// <para>
        /// Contains the facet results. A <c>FacetResult</c> contains the counts for each field/attribute
        /// key that was specified in the <c>Facets</c> input parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FacetResult> FacetResults { get; set; } = AWSConfigs.InitializeCollections ? new List<FacetResult>() : null;

        /// <summary>
        /// Checks to see if the FacetResults property is set.
        /// </summary>
        internal bool IsSetFacetResults() => this.FacetResults != null && (this.FacetResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeaturedResultsItems. 
        /// <para>
        /// The list of featured result items. Featured results are displayed at the top of the
        /// search results page, placed above all other results for certain queries. If there's
        /// an exact match of a query, then certain documents are featured in the search results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FeaturedResultsItem> FeaturedResultsItems { get; set; } = AWSConfigs.InitializeCollections ? new List<FeaturedResultsItem>() : null;

        /// <summary>
        /// Checks to see if the FeaturedResultsItems property is set.
        /// </summary>
        internal bool IsSetFeaturedResultsItems() => this.FeaturedResultsItems != null && (this.FeaturedResultsItems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The identifier for the search. You also use <c>QueryId</c> to identify the search
        /// when using the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_SubmitFeedback.html">SubmitFeedback</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;

        /// <summary>
        /// Gets and sets the property ResultItems. 
        /// <para>
        /// The results of the search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QueryResultItem> ResultItems { get; set; } = AWSConfigs.InitializeCollections ? new List<QueryResultItem>() : null;

        /// <summary>
        /// Checks to see if the ResultItems property is set.
        /// </summary>
        internal bool IsSetResultItems() => this.ResultItems != null && (this.ResultItems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpellCorrectedQueries. 
        /// <para>
        /// A list of information related to suggested spell corrections for a query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SpellCorrectedQuery> SpellCorrectedQueries { get; set; } = AWSConfigs.InitializeCollections ? new List<SpellCorrectedQuery>() : null;

        /// <summary>
        /// Checks to see if the SpellCorrectedQueries property is set.
        /// </summary>
        internal bool IsSetSpellCorrectedQueries() => this.SpellCorrectedQueries != null && (this.SpellCorrectedQueries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalNumberOfResults. 
        /// <para>
        /// The total number of items found by the search. However, you can only retrieve up to
        /// 100 items. For example, if the search found 192 items, you can only retrieve the first
        /// 100 of the items.
        /// </para>
        /// </summary>
        public int? TotalNumberOfResults { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfResults property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfResults() => this.TotalNumberOfResults.HasValue;

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// A list of warning codes and their messages on problems with your query.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kendra currently only supports one type of warning, which is a warning on invalid
        /// syntax used in the query. For examples of invalid query syntax, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/searching-example.html#searching-index-query-syntax">Searching
        /// with advanced query syntax</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<Warning> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<Warning>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
