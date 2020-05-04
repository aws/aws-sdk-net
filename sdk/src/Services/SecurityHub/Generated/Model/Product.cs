/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains details about a product.
    /// </summary>
    public partial class Product
    {
        private string _activationUrl;
        private List<string> _categories = new List<string>();
        private string _companyName;
        private string _description;
        private List<string> _integrationTypes = new List<string>();
        private string _marketplaceUrl;
        private string _productArn;
        private string _productName;
        private string _productSubscriptionResourcePolicy;

        /// <summary>
        /// Gets and sets the property ActivationUrl. 
        /// <para>
        /// The URL used to activate the product.
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
        /// </summary>
        public List<string> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && this._categories.Count > 0; 
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
        ///  <code>SEND_FINDINGS_TO_SECURITY_HUB</code> - Indicates that the integration sends
        /// findings to Security Hub.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RECEIVE_FINDINGS_FROM_SECURITY_HUB</code> - Indicates that the integration
        /// receives findings from Security Hub.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> IntegrationTypes
        {
            get { return this._integrationTypes; }
            set { this._integrationTypes = value; }
        }

        // Check to see if IntegrationTypes property is set
        internal bool IsSetIntegrationTypes()
        {
            return this._integrationTypes != null && this._integrationTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MarketplaceUrl. 
        /// <para>
        /// The URL for the page that contains more information about the product.
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