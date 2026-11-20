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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProduct operation. Updates a product. Only
    /// the fields supplied in the request are changed.
    /// </summary>
    public partial class UpdateProductRequest : AmazonAPIPortalRequest
    {
        /// <summary>
        /// Gets and sets the property ApiSelectionConfiguration. The new API selection settings.
        /// The selection mode must match the mode the product was created with. Omit it to keep
        /// the current settings.
        /// </summary>
        public ApiSelectionConfiguration ApiSelectionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ApiSelectionConfiguration property is set.
        /// </summary>
        internal bool IsSetApiSelectionConfiguration() => this.ApiSelectionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. The new description of the product. Omit it
        /// to keep the current description.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. The new name of the product. Omit it to keep
        /// the current name.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DisplayOrder. The new page order. Omit it to keep the current
        /// order.
        /// </summary>
        public DisplayOrder DisplayOrder { get; set; }

        /// <summary>
        /// Checks to see if the DisplayOrder property is set.
        /// </summary>
        internal bool IsSetDisplayOrder() => this.DisplayOrder != null;

        /// <summary>
        /// Gets and sets the property ProductId. The identifier of the product.
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;
    }
}
