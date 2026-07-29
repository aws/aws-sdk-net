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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRevenueAttribution operation.
    /// Creates a new revenue attribution record in the specified catalog.
    /// </summary>
    public partial class CreateRevenueAttributionRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        private CatalogName _catalog;
        private string _clientToken;
        private string _description;
        private string _name;
        private string _productIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TenancyModel _tenancyModel;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog in which to create the revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CatalogName Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token to ensure idempotency of the create request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the revenue attribution. Must be unique within the catalog and the partner's
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProductIdentifier. 
        /// <para>
        /// The unique product identifier in AWS Marketplace. Accepts a product entity ID (e.g.,
        /// prod-abc123def4567) or a product ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProductIdentifier
        {
            get { return this._productIdentifier; }
            set { this._productIdentifier = value; }
        }

        // Check to see if ProductIdentifier property is set
        internal bool IsSetProductIdentifier()
        {
            return this._productIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the revenue attribution upon creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TenancyModel. 
        /// <para>
        /// The tenancy model for this revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TenancyModel TenancyModel
        {
            get { return this._tenancyModel; }
            set { this._tenancyModel = value; }
        }

        // Check to see if TenancyModel property is set
        internal bool IsSetTenancyModel()
        {
            return this._tenancyModel != null;
        }

    }
}