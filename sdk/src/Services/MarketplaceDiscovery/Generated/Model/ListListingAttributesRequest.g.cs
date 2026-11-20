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
    /// Container for the parameters to the ListListingAttributes operation. Retrieves the
    /// requested attributes for a listing, including case studies and trust center information.
    /// The operation returns results in pages. Use <c>nextToken</c> to retrieve the next
    /// page.
    /// </summary>
    public partial class ListListingAttributesRequest : AmazonMarketplaceDiscoveryRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeTypes. 
        /// <para>
        /// The attribute types to retrieve. Specify one or more of the following values:
        /// </para>
        ///  <dl> <dt>CASE_STUDY</dt> <dd> 
        /// <para>
        /// Case studies associated with the listing.
        /// </para>
        ///  </dd> <dt>SPECIALIZATION_DETAIL</dt> <dd> 
        /// <para>
        /// Specializations earned for the listing.
        /// </para>
        ///  </dd> <dt>TRUST_CENTER_CERTIFICATION</dt> <dd> 
        /// <para>
        /// Trust center certifications associated with the listing.
        /// </para>
        ///  </dd> <dt>TRUST_CENTER_CONTROL</dt> <dd> 
        /// <para>
        /// Trust center controls associated with the listing.
        /// </para>
        ///  </dd> <dt>TRUST_CENTER_DOCUMENT</dt> <dd> 
        /// <para>
        /// Trust center documents associated with the listing.
        /// </para>
        ///  </dd> <dt>TRUST_CENTER_FAQ</dt> <dd> 
        /// <para>
        /// The trust center FAQ associated with the listing.
        /// </para>
        ///  </dd> <dt>TRUST_CENTER_SOURCE</dt> <dd> 
        /// <para>
        /// Trust center sources associated with the listing.
        /// </para>
        ///  </dd> <dt>TRUST_CENTER_UPDATE</dt> <dd> 
        /// <para>
        /// Trust center updates associated with the listing.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> AttributeTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributeTypes property is set.
        /// </summary>
        internal bool IsSetAttributeTypes() => this.AttributeTypes != null && (this.AttributeTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListingId. 
        /// <para>
        /// The unique identifier of the listing whose attributes are requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ListingId { get; set; }

        /// <summary>
        /// Checks to see if the ListingId property is set.
        /// </summary>
        internal bool IsSetListingId() => this.ListingId != null;

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
        /// The maximum number of attributes to return in each call. If you omit this field, the
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
    }
}
