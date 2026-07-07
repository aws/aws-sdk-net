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
    /// This is the response object from the CreateRevenueAttribution operation.
    /// </summary>
    public partial class CreateRevenueAttributionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _description;
        private string _id;
        private MarketplaceProductSummary _marketplaceProduct;
        private string _name;
        private string _revision;
        private TenancyModel _tenancyModel;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the newly created revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the revenue attribution.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the newly created revenue attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=1011)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MarketplaceProduct. 
        /// <para>
        /// The associated AWS Marketplace product listing, if set at creation.
        /// </para>
        /// </summary>
        public MarketplaceProductSummary MarketplaceProduct
        {
            get { return this._marketplaceProduct; }
            set { this._marketplaceProduct = value; }
        }

        // Check to see if MarketplaceProduct property is set
        internal bool IsSetMarketplaceProduct()
        {
            return this._marketplaceProduct != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the revenue attribution.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the newly created attribution resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
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