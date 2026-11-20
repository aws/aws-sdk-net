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
    /// Container for the parameters to the ListPurchaseOptions operation. Retrieves the purchase
    /// options (offers and offer sets) available to you. You can filter results by product,
    /// seller, purchase option type, visibility scope, and availability status. The operation
    /// returns results in pages. Use <c>nextToken</c> to retrieve the next page. <note> <para>
    /// You must include at least one of the following filters in the request: a <c>PRODUCT_ID</c>
    /// filter to specify the product for which to retrieve purchase options, or a <c>VISIBILITY_SCOPE</c>
    /// filter to retrieve purchase options by visibility. </para> </note>
    /// </summary>
    public partial class ListPurchaseOptionsRequest : AmazonMarketplaceDiscoveryRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to narrow the results. A result must match every filter. Within one filter,
        /// a result matches if it has any of the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<PurchaseOptionFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<PurchaseOptionFilter>() : null;

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
        /// The maximum number of purchase options to return in each call. If you omit this field,
        /// the default is 25. Use <c>nextToken</c> to retrieve the next page.
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
    }
}
