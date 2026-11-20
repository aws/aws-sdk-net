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
    /// A filter used to narrow search results by attribute, such as category, pricing model,
    /// or fulfillment type.
    /// </summary>
    public partial class SearchFilter
    {
        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The type of filter to apply. See <c>filterValues</c> for the supported types and their
        /// values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchFilterType FilterType { get; set; }

        /// <summary>
        /// Checks to see if the FilterType property is set.
        /// </summary>
        internal bool IsSetFilterType() => this.FilterType != null;

        /// <summary>
        /// Gets and sets the property FilterValues. 
        /// <para>
        /// The values to filter by. Term filters accept multiple values, and a result matches
        /// if it has any of them. Range filters accept a single value. The supported values for
        /// each <c>filterType</c> are as follows:
        /// </para>
        ///  <dl> <dt>CATEGORY</dt> <dd> 
        /// <para>
        /// One or more category identifiers. Matches listings in those categories.
        /// </para>
        ///  </dd> <dt>CERTIFICATES</dt> <dd> 
        /// <para>
        /// One or more certification identifiers, such as <c>ISO_27001</c> or <c>SOC2_TYPE_2</c>.
        /// Matches listings that hold those certifications.
        /// </para>
        ///  </dd> <dt>DEPLOYED_ON_AWS</dt> <dd> 
        /// <para>
        /// The single value <c>DEPLOYED_ON_AWS</c>. Matches listings whose products are deployed
        /// on AWS infrastructure.
        /// </para>
        ///  </dd> <dt>FULFILLMENT_OPTION_TYPE</dt> <dd> 
        /// <para>
        /// One or more fulfillment option types, such as <c>SAAS</c>, <c>AMAZON_MACHINE_IMAGE</c>,
        /// or <c>CONTAINER</c>. Matches listings that you can deploy or access in those ways.
        /// </para>
        ///  </dd> <dt>MAX_AVERAGE_CUSTOMER_RATING</dt> <dd> 
        /// <para>
        /// A single rating between <c>0.0</c> and <c>5.0</c>. Matches listings whose average
        /// customer rating is at or below that value.
        /// </para>
        ///  </dd> <dt>MIN_AVERAGE_CUSTOMER_RATING</dt> <dd> 
        /// <para>
        /// A single rating between <c>0.0</c> and <c>5.0</c>. Matches listings whose average
        /// customer rating is at or above that value.
        /// </para>
        ///  </dd> <dt>NUMBER_OF_PRODUCTS</dt> <dd> 
        /// <para>
        ///  <c>SINGLE_PRODUCT</c> or <c>MULTI_PRODUCT</c>. Matches single-product listings or
        /// multi-product solutions.
        /// </para>
        ///  </dd> <dt>PRICING_MODEL</dt> <dd> 
        /// <para>
        /// One or more of <c>BYOL</c>, <c>CONTRACT</c>, <c>FREE</c>, and <c>USAGE</c>. Matches
        /// listings with offers that use those pricing models.
        /// </para>
        ///  </dd> <dt>PRICING_UNIT</dt> <dd> 
        /// <para>
        /// One or more pricing units, such as <c>USERS</c>, <c>HOSTS</c>, or <c>REQUESTS</c>.
        /// Matches listings that bill by those units.
        /// </para>
        ///  </dd> <dt>PRODUCT_ID</dt> <dd> 
        /// <para>
        /// One or more product identifiers. Matches listings that contain those products.
        /// </para>
        ///  </dd> <dt>PUBLISHER</dt> <dd> 
        /// <para>
        /// One or more publisher identifiers. Matches listings from those sellers.
        /// </para>
        ///  </dd> <dt>SELLER_ENGAGEMENT</dt> <dd> 
        /// <para>
        /// One or more <c>SellerEngagementType</c> values, such as <c>BUY_NOW</c> or <c>REQUEST_FOR_DEMO</c>.
        /// Matches listings that offer those ways to engage with the seller.
        /// </para>
        ///  </dd> <dt>SPECIALIZATION</dt> <dd> 
        /// <para>
        /// One or more specialization identifiers. Matches listings that earned those specializations.
        /// </para>
        ///  </dd> <dt>SPECIALIZATION_CATEGORY</dt> <dd> 
        /// <para>
        /// One or more specialization category identifiers. Matches listings that earned a category
        /// under a specialization.
        /// </para>
        ///  </dd> <dt>TRUST_CENTER</dt> <dd> 
        /// <para>
        /// The single value <c>HAS_TRUST_CENTER</c>. Matches listings that have a trust center.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Use <c>SearchFacets</c> to retrieve the values available for <c>CATEGORY</c>, <c>PUBLISHER</c>,
        /// <c>CERTIFICATES</c>, <c>SPECIALIZATION</c>, and <c>SPECIALIZATION_CATEGORY</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public List<string> FilterValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FilterValues property is set.
        /// </summary>
        internal bool IsSetFilterValues() => this.FilterValues != null && (this.FilterValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
