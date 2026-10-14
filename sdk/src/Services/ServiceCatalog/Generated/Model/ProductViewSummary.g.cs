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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Summary information about a product view.
    /// </summary>
    public partial class ProductViewSummary
    {
        /// <summary>
        /// Gets and sets the property Distributor. 
        /// <para>
        /// The distributor of the product. Contact the product administrator for the significance
        /// of this value.
        /// </para>
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// Checks to see if the Distributor property is set.
        /// </summary>
        internal bool IsSetDistributor() => this.Distributor != null;

        /// <summary>
        /// Gets and sets the property HasDefaultPath. 
        /// <para>
        /// Indicates whether the product has a default path. If the product does not have a default
        /// path, call <a>ListLaunchPaths</a> to disambiguate between paths. Otherwise, <a>ListLaunchPaths</a>
        /// is not required, and the output of <a>ProductViewSummary</a> can be used directly
        /// with <a>DescribeProvisioningParameters</a>.
        /// </para>
        /// </summary>
        public bool? HasDefaultPath { get; set; }

        /// <summary>
        /// Checks to see if the HasDefaultPath property is set.
        /// </summary>
        internal bool IsSetHasDefaultPath() => this.HasDefaultPath.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The product view identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the product. Contact the product administrator for the significance of
        /// this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// Short description of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Checks to see if the ShortDescription property is set.
        /// </summary>
        internal bool IsSetShortDescription() => this.ShortDescription != null;

        /// <summary>
        /// Gets and sets the property SupportDescription. 
        /// <para>
        /// The description of the support for this Product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string SupportDescription { get; set; }

        /// <summary>
        /// Checks to see if the SupportDescription property is set.
        /// </summary>
        internal bool IsSetSupportDescription() => this.SupportDescription != null;

        /// <summary>
        /// Gets and sets the property SupportEmail. 
        /// <para>
        /// The email contact information to obtain support for this Product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 254)]
        public string SupportEmail { get; set; }

        /// <summary>
        /// Checks to see if the SupportEmail property is set.
        /// </summary>
        internal bool IsSetSupportEmail() => this.SupportEmail != null;

        /// <summary>
        /// Gets and sets the property SupportUrl. 
        /// <para>
        /// The URL information to obtain support for this Product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2083)]
        public string SupportUrl { get; set; }

        /// <summary>
        /// Checks to see if the SupportUrl property is set.
        /// </summary>
        internal bool IsSetSupportUrl() => this.SupportUrl != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The product type. Contact the product administrator for the significance of this value.
        /// If this value is <c>MARKETPLACE</c>, the product was created by Amazon Web Services
        /// Marketplace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public ProductType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
