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
    /// Defines a prepaid payment model that allows buyers to configure the entitlements they
    /// want to purchase and the duration.
    /// </summary>
    public partial class ConfigurableUpfrontPricingTermConfiguration
    {
        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Defines the dimensions that the acceptor has purchased from the overall set of dimensions
        /// presented in the rate card.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<Dimension> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SelectorValue. 
        /// <para>
        /// Defines the length of time for which the particular pricing/dimension is being purchased
        /// by the acceptor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string SelectorValue { get; set; }

        /// <summary>
        /// Checks to see if the SelectorValue property is set.
        /// </summary>
        internal bool IsSetSelectorValue() => this.SelectorValue != null;
    }
}
