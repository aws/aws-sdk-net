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
    /// Defines the structure for the productV2.
    /// </summary>
    public partial class ProductV2
    {
        private string _activationUrl;
        private List<string> _categories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _companyName;
        private string _description;
        private List<string> _integrationV2Types = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _marketplaceUrl;
        private string _productV2Name;

        /// <summary>
        /// Gets and sets the property ActivationUrl. 
        /// <para>
        /// The URL to the serviceV@ or productV2 documentation about the integration, which includes
        /// how to activate the integration.
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
        /// The domains or functional areas the productV2 addresses.
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
        /// The name of the organization or vendor that provides the productV2.
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
        /// Detailed information about the productV2.
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
        /// Gets and sets the property IntegrationV2Types. 
        /// <para>
        /// The type of integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IntegrationV2Types
        {
            get { return this._integrationV2Types; }
            set { this._integrationV2Types = value; }
        }

        // Check to see if IntegrationV2Types property is set
        internal bool IsSetIntegrationV2Types()
        {
            return this._integrationV2Types != null && (this._integrationV2Types.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MarketplaceUrl. 
        /// <para>
        /// The console URL where you can purchase or subscribe to products.
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
        /// Gets and sets the property ProductV2Name. 
        /// <para>
        /// The name of the productV2.
        /// </para>
        /// </summary>
        public string ProductV2Name
        {
            get { return this._productV2Name; }
            set { this._productV2Name = value; }
        }

        // Check to see if ProductV2Name property is set
        internal bool IsSetProductV2Name()
        {
            return this._productV2Name != null;
        }

    }
}