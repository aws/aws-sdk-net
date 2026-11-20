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
    /// Container for the parameters to the SearchFacets operation. Retrieves the available
    /// facet values for filtering listings, such as categories, pricing models, fulfillment
    /// option types, publishers, and customer ratings. Each facet value includes a count
    /// of matching listings.
    /// </summary>
    public partial class SearchFacetsRequest : AmazonMarketplaceDiscoveryRequest
    {
        /// <summary>
        /// Gets and sets the property FacetTypes. 
        /// <para>
        /// The facet types to retrieve. If you omit this field or leave it empty, the service
        /// returns all available facets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 30)]
        public List<string> FacetTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FacetTypes property is set.
        /// </summary>
        internal bool IsSetFacetTypes() => this.FacetTypes != null && (this.FacetTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to apply before retrieving facets. A result must match every filter. Within
        /// one filter, a result matches if it has any of the values.
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
        /// The search query text to filter listings before retrieving facets.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SearchText { get; set; }

        /// <summary>
        /// Checks to see if the SearchText property is set.
        /// </summary>
        internal bool IsSetSearchText() => this.SearchText != null;
    }
}
