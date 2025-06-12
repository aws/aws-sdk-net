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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _activationUrl;
        private List<string> _categories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _companyName;
        private string _description;
        private List<string> _integrationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _marketplaceUrl;
        private string _productArn;
        private string _productName;
        private string _productSubscriptionResourcePolicy;

        /// <summary>
        /// Gets and sets the property ActivationUrl. 
        /// <para>
        /// The URL to the service or product documentation about the integration with Security
        /// Hub, including how to activate the integration.
        /// </para>
        /// </summary>
        public string ActivationUrl
        {
            get { return this._activationUrl; }
            set { this._activationUrl = value; }
        }

        // Check to see if ActivationUrl property is set
        internal bool IsSetActivationUrl()
        {
            return this._activationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The categories assigned to the product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the company that provides the product.
        /// </para>
        /// </summary>
        public string CompanyName
        {
            get { return this._companyName; }
            set { this._companyName = value; }
        }

        // Check to see if CompanyName property is set
        internal bool IsSetCompanyName()
        {
            return this._companyName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the product.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationTypes. 
        /// <para>
        /// The types of integration that the product supports. Available values are the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SEND_FINDINGS_TO_SECURITY_HUB</c> - The integration sends findings to Security
        /// Hub.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RECEIVE_FINDINGS_FROM_SECURITY_HUB</c> - The integration receives findings from
        /// Security Hub.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_FINDINGS_IN_SECURITY_HUB</c> - The integration does not send new findings
        /// to Security Hub, but does make updates to the findings that it receives from Security
        /// Hub.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IntegrationTypes
        {
            get { return this._integrationTypes; }
            set { this._integrationTypes = value; }
        }

        // Check to see if IntegrationTypes property is set
        internal bool IsSetIntegrationTypes()
        {
            return this._integrationTypes != null && (this._integrationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public string MarketplaceUrl
        {
            get { return this._marketplaceUrl; }
            set { this._marketplaceUrl = value; }
        }

        // Check to see if MarketplaceUrl property is set
        internal bool IsSetMarketplaceUrl()
        {
            return this._marketplaceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ProductArn. 
        /// <para>
        /// The ARN assigned to the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProductArn
        {
            get { return this._productArn; }
            set { this._productArn = value; }
        }

        // Check to see if ProductArn property is set
        internal bool IsSetProductArn()
        {
            return this._productArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the product.
        /// </para>
        /// </summary>
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
        }

        /// <summary>
        /// Gets and sets the property ProductSubscriptionResourcePolicy. 
        /// <para>
        /// The resource policy associated with the product.
        /// </para>
        /// </summary>
        public string ProductSubscriptionResourcePolicy
        {
            get { return this._productSubscriptionResourcePolicy; }
            set { this._productSubscriptionResourcePolicy = value; }
        }

        // Check to see if ProductSubscriptionResourcePolicy property is set
        internal bool IsSetProductSubscriptionResourcePolicy()
        {
            return this._productSubscriptionResourcePolicy != null;
        }

    }
}