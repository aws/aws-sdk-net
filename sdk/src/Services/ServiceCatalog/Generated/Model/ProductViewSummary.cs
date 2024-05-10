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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Summary information about a product view.
    /// </summary>
    public partial class ProductViewSummary
    {
        private string _distributor;
        private bool? _hasDefaultPath;
        private string _id;
        private string _name;
        private string _owner;
        private string _productId;
        private string _shortDescription;
        private string _supportDescription;
        private string _supportEmail;
        private string _supportUrl;
        private ProductType _type;

        /// <summary>
        /// Gets and sets the property Distributor. 
        /// <para>
        /// The distributor of the product. Contact the product administrator for the significance
        /// of this value.
        /// </para>
        /// </summary>
        public string Distributor
        {
            get { return this._distributor; }
            set { this._distributor = value; }
        }

        // Check to see if Distributor property is set
        internal bool IsSetDistributor()
        {
            return this._distributor != null;
        }

        /// <summary>
        /// Gets and sets the property HasDefaultPath. 
        /// <para>
        /// Indicates whether the product has a default path. If the product does not have a default
        /// path, call <a>ListLaunchPaths</a> to disambiguate between paths. Otherwise, <a>ListLaunchPaths</a>
        /// is not required, and the output of <a>ProductViewSummary</a> can be used directly
        /// with <a>DescribeProvisioningParameters</a>.
        /// </para>
        /// </summary>
        public bool? HasDefaultPath
        {
            get { return this._hasDefaultPath; }
            set { this._hasDefaultPath = value; }
        }

        // Check to see if HasDefaultPath property is set
        internal bool IsSetHasDefaultPath()
        {
            return this._hasDefaultPath.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The product view identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the product. Contact the product administrator for the significance of
        /// this value.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// Short description of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string ShortDescription
        {
            get { return this._shortDescription; }
            set { this._shortDescription = value; }
        }

        // Check to see if ShortDescription property is set
        internal bool IsSetShortDescription()
        {
            return this._shortDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SupportDescription. 
        /// <para>
        /// The description of the support for this Product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string SupportDescription
        {
            get { return this._supportDescription; }
            set { this._supportDescription = value; }
        }

        // Check to see if SupportDescription property is set
        internal bool IsSetSupportDescription()
        {
            return this._supportDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SupportEmail. 
        /// <para>
        /// The email contact information to obtain support for this Product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=254)]
        public string SupportEmail
        {
            get { return this._supportEmail; }
            set { this._supportEmail = value; }
        }

        // Check to see if SupportEmail property is set
        internal bool IsSetSupportEmail()
        {
            return this._supportEmail != null;
        }

        /// <summary>
        /// Gets and sets the property SupportUrl. 
        /// <para>
        /// The URL information to obtain support for this Product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2083)]
        public string SupportUrl
        {
            get { return this._supportUrl; }
            set { this._supportUrl = value; }
        }

        // Check to see if SupportUrl property is set
        internal bool IsSetSupportUrl()
        {
            return this._supportUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The product type. Contact the product administrator for the significance of this value.
        /// If this value is <c>MARKETPLACE</c>, the product was created by Amazon Web Services
        /// Marketplace.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public ProductType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}