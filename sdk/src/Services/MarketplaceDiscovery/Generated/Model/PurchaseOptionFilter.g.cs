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
        /// The type of filter to apply, such as <c>PRODUCT_ID</c>, <c>VISIBILITY_SCOPE</c>, or
        /// <c>PURCHASE_OPTION_TYPE</c>.
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
        ///  <ul> <li> 
        /// <para>
        ///  <c>PRODUCT_ID</c> – One or more product identifiers to filter by.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SELLER_OF_RECORD_PROFILE_ID</c> – One or more seller profile identifiers to filter
        /// by.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PURCHASE_OPTION_TYPE</c> – One or more purchase option types to filter by: <c>OFFER</c>
        /// or <c>OFFERSET</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VISIBILITY_SCOPE</c> – The visibility scope to filter by: <c>PRIVATE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABILITY_STATUS</c> – One or more availability statuses to filter by: <c>AVAILABLE</c>
        /// or <c>EXPIRED</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To retrieve private offers and offer sets visible to you, use <c>VISIBILITY_SCOPE</c>
        /// with <c>PRIVATE</c>. OR logic combines multiple values within the same filter.
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
