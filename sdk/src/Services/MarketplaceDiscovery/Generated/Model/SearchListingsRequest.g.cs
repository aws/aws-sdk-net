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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the SearchListings operation. Searches for listings
    /// that match your search criteria and filters. You can search by keyword, filter by
    /// category, pricing model, fulfillment type, and other attributes, and sort results
    /// by relevance or customer rating. The operation returns results in pages. Use <c>nextToken</c>
    /// to retrieve the next page.
    /// </summary>
    public partial class SearchListingsRequest : AmazonMarketplaceDiscoveryRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to narrow search results. A result must match every filter. Within one filter,
        /// a result matches if it has any of the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public List<SearchFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<SearchFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The preferred locale for response content, as a Best Current Practice 47 (BCP 47)
        /// language tag or a comma-separated priority list of language tags. See <c>Locale</c>
        /// for supported values, constraints, fallback behavior, and the default locale. If you
        /// omit this field, the service returns content in the default locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of listings to return in each call. If you omit this field, the
        /// default is 25. Use <c>nextToken</c> to retrieve the next page.
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
        /// If the service returns <c>nextToken</c>, more results are available. The value of
        /// <c>nextToken</c> is a unique pagination token for each page. Make the call again with
        /// the returned token to retrieve the next page. Keep all other arguments unchanged.
        /// Each pagination token expires after 24 hours. An expired pagination token returns
        /// a <c>ValidationException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SearchText. 
        /// <para>
        /// The search query text to find relevant listings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SearchText { get; set; }

        /// <summary>
        /// Checks to see if the SearchText property is set.
        /// </summary>
        internal bool IsSetSearchText() => this.SearchText != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to sort results by. If you do not specify a value, the service sorts by
        /// <c>RELEVANCE</c>. This field has one of the following values:
        /// </para>
        ///  <dl> <dt>AVERAGE_CUSTOMER_RATING</dt> <dd> 
        /// <para>
        /// Sorts by average customer rating.
        /// </para>
        ///  </dd> <dt>RELEVANCE</dt> <dd> 
        /// <para>
        /// Sorts by relevance to the search query.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public SearchListingsSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort direction. If you do not specify a value, the service sorts in <c>DESCENDING</c>
        /// order. This field has one of the following values:
        /// </para>
        ///  <dl> <dt>ASCENDING</dt> <dd> 
        /// <para>
        /// Sorts from lowest to highest.
        /// </para>
        ///  </dd> <dt>DESCENDING</dt> <dd> 
        /// <para>
        /// Sorts from highest to lowest.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public SearchListingsSortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
