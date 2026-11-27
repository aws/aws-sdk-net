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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Defines the per unit rates for each individual product dimension.
    /// </summary>
    public partial class RateCardItem
    {
        /// <summary>
        /// Gets and sets the property DimensionKey. 
        /// <para>
        /// Dimension for which the given entitlement applies. Dimensions represent categories
        /// of capacity in a product and are specified when the product is listed in AWS Marketplace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string DimensionKey { get; set; }

        /// <summary>
        /// Checks to see if the DimensionKey property is set.
        /// </summary>
        internal bool IsSetDimensionKey() => this.DimensionKey != null;

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// Per unit price for the product dimension that's used for calculating the amount to
        /// be charged.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Price { get; set; }

        /// <summary>
        /// Checks to see if the Price property is set.
        /// </summary>
        internal bool IsSetPrice() => this.Price != null;

        /// <summary>
        /// Gets and sets the property RegionalPrices. 
        /// <para>
        /// The per-Region price overrides for the product dimension. When a Regional price is
        /// present for an AWS Region, it replaces the default <c>price</c>. This field is absent
        /// when the offer doesn't define regional price overrides.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<RegionalPrice> RegionalPrices { get; set; } = AWSConfigs.InitializeCollections ? new List<RegionalPrice>() : null;

        /// <summary>
        /// Checks to see if the RegionalPrices property is set.
        /// </summary>
        internal bool IsSetRegionalPrices() => this.RegionalPrices != null && (this.RegionalPrices.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
