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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Defines the structure for the productV2.
    /// </summary>
    public partial class ProductV2
    {
        /// <summary>
        /// Gets and sets the property ActivationUrl. 
        /// <para>
        /// The URL to the serviceV@ or productV2 documentation about the integration, which includes
        /// how to activate the integration.
        /// </para>
        /// </summary>
        public string ActivationUrl { get; set; }

        /// <summary>
        /// Checks to see if the ActivationUrl property is set.
        /// </summary>
        internal bool IsSetActivationUrl() => this.ActivationUrl != null;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The domains or functional areas the productV2 addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the organization or vendor that provides the productV2.
        /// </para>
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Checks to see if the CompanyName property is set.
        /// </summary>
        internal bool IsSetCompanyName() => this.CompanyName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Detailed information about the productV2.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IntegrationV2Types. 
        /// <para>
        /// The type of integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IntegrationV2Types { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IntegrationV2Types property is set.
        /// </summary>
        internal bool IsSetIntegrationV2Types() => this.IntegrationV2Types != null && (this.IntegrationV2Types.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MarketplaceProductId. 
        /// <para>
        /// The identifier for the Amazon Web Services Marketplace product associated with this
        /// integration.
        /// </para>
        /// </summary>
        public string MarketplaceProductId { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceProductId property is set.
        /// </summary>
        internal bool IsSetMarketplaceProductId() => this.MarketplaceProductId != null;

        /// <summary>
        /// Gets and sets the property MarketplaceUrl. 
        /// <para>
        /// The console URL where you can purchase or subscribe to products.
        /// </para>
        /// </summary>
        public string MarketplaceUrl { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceUrl property is set.
        /// </summary>
        internal bool IsSetMarketplaceUrl() => this.MarketplaceUrl != null;

        /// <summary>
        /// Gets and sets the property ProductV2Name. 
        /// <para>
        /// The name of the productV2.
        /// </para>
        /// </summary>
        public string ProductV2Name { get; set; }

        /// <summary>
        /// Checks to see if the ProductV2Name property is set.
        /// </summary>
        internal bool IsSetProductV2Name() => this.ProductV2Name != null;
    }
}
