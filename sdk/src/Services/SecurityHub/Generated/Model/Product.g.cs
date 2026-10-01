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
    /// Contains details about a product.
    /// </summary>
    public partial class Product
    {
        /// <summary>
        /// Gets and sets the property ActivationUrl. 
        /// <para>
        /// The URL to the service or product documentation about the integration with Security
        /// Hub CSPM, including how to activate the integration.
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
        /// The categories assigned to the product.
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
        /// The name of the company that provides the product.
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
        /// A description of the product.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IntegrationTypes. 
        /// <para>
        /// The types of integration that the product supports. Available values are the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SEND_FINDINGS_TO_SECURITY_HUB</c> - The integration sends findings to Security
        /// Hub CSPM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RECEIVE_FINDINGS_FROM_SECURITY_HUB</c> - The integration receives findings from
        /// Security Hub CSPM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_FINDINGS_IN_SECURITY_HUB</c> - The integration does not send new findings
        /// to Security Hub CSPM, but does make updates to the findings that it receives from
        /// Security Hub CSPM.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IntegrationTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IntegrationTypes property is set.
        /// </summary>
        internal bool IsSetIntegrationTypes() => this.IntegrationTypes != null && (this.IntegrationTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MarketplaceUrl. 
        /// <para>
        /// For integrations with Amazon Web Services services, the Amazon Web Services Console
        /// URL from which to activate the service.
        /// </para>
        ///  
        /// <para>
        /// For integrations with third-party products, the Amazon Web Services Marketplace URL
        /// from which to subscribe to or purchase the product.
        /// </para>
        /// </summary>
        public string MarketplaceUrl { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceUrl property is set.
        /// </summary>
        internal bool IsSetMarketplaceUrl() => this.MarketplaceUrl != null;

        /// <summary>
        /// Gets and sets the property ProductArn. 
        /// <para>
        /// The ARN assigned to the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProductArn { get; set; }

        /// <summary>
        /// Checks to see if the ProductArn property is set.
        /// </summary>
        internal bool IsSetProductArn() => this.ProductArn != null;

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the product.
        /// </para>
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property ProductSubscriptionResourcePolicy. 
        /// <para>
        /// The resource policy associated with the product.
        /// </para>
        /// </summary>
        public string ProductSubscriptionResourcePolicy { get; set; }

        /// <summary>
        /// Checks to see if the ProductSubscriptionResourcePolicy property is set.
        /// </summary>
        internal bool IsSetProductSubscriptionResourcePolicy() => this.ProductSubscriptionResourcePolicy != null;
    }
}
