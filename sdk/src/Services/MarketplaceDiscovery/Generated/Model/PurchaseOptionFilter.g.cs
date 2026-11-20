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
    /// A filter used to narrow purchase option results by product, seller, type, visibility,
    /// or availability.
    /// </summary>
    public partial class PurchaseOptionFilter
    {
        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The type of filter to apply. This field has one of the following values:
        /// </para>
        ///  <dl> <dt>AVAILABILITY_STATUS</dt> <dd> 
        /// <para>
        /// Filters by whether the purchase option is available or expired.
        /// </para>
        ///  </dd> <dt>PRODUCT_ID</dt> <dd> 
        /// <para>
        /// Filters by product.
        /// </para>
        ///  </dd> <dt>PURCHASE_OPTION_TYPE</dt> <dd> 
        /// <para>
        /// Filters by offer or offer set.
        /// </para>
        ///  </dd> <dt>SELLER_OF_RECORD_PROFILE_ID</dt> <dd> 
        /// <para>
        /// Filters by seller.
        /// </para>
        ///  </dd> <dt>VISIBILITY_SCOPE</dt> <dd> 
        /// <para>
        /// Filters by visibility.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// See <c>filterValues</c> for the values that each type accepts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PurchaseOptionFilterType FilterType { get; set; }

        /// <summary>
        /// Checks to see if the FilterType property is set.
        /// </summary>
        internal bool IsSetFilterType() => this.FilterType != null;

        /// <summary>
        /// Gets and sets the property FilterValues. 
        /// <para>
        /// The values to filter by. Supported values depend on <c>filterType</c>:
        /// </para>
        ///  <dl> <dt>AVAILABILITY_STATUS</dt> <dd> 
        /// <para>
        /// One or more availability statuses to filter by: <c>AVAILABLE</c> or <c>EXPIRED</c>.
        /// </para>
        ///  </dd> <dt>PRODUCT_ID</dt> <dd> 
        /// <para>
        /// One or more product identifiers to filter by.
        /// </para>
        ///  </dd> <dt>PURCHASE_OPTION_TYPE</dt> <dd> 
        /// <para>
        /// One or more purchase option types to filter by: <c>OFFER</c> or <c>OFFERSET</c>.
        /// </para>
        ///  </dd> <dt>SELLER_OF_RECORD_PROFILE_ID</dt> <dd> 
        /// <para>
        /// One or more seller profile identifiers to filter by.
        /// </para>
        ///  </dd> <dt>VISIBILITY_SCOPE</dt> <dd> 
        /// <para>
        /// The visibility scope to filter by: <c>PRIVATE</c>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// To retrieve private offers and offer sets visible to you, use <c>VISIBILITY_SCOPE</c>
        /// with <c>PRIVATE</c>. Within one filter, a result matches if it has any of the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> FilterValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FilterValues property is set.
        /// </summary>
        internal bool IsSetFilterValues() => this.FilterValues != null && (this.FilterValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
