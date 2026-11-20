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
    /// Container for the parameters to the GetOfferTerms operation. Retrieves the terms attached
    /// to an offer, such as pricing terms (usage-based, contract, Bring Your Own License
    /// (BYOL), free trial), legal terms, payment schedules, validity terms, support terms,
    /// and renewal terms. The operation returns results in pages. Use <c>nextToken</c> to
    /// retrieve the next page.
    /// </summary>
    public partial class GetOfferTermsRequest : AmazonMarketplaceDiscoveryRequest
    {
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
        /// The maximum number of terms to return in each call. If you omit this field, the default
        /// is 10. Use <c>nextToken</c> to retrieve the next page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
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
        /// Gets and sets the property OfferId. 
        /// <para>
        /// The unique identifier of the offer whose terms to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string OfferId { get; set; }

        /// <summary>
        /// Checks to see if the OfferId property is set.
        /// </summary>
        internal bool IsSetOfferId() => this.OfferId != null;
    }
}
