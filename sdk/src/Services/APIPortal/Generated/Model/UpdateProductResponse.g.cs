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
    /// This is the response object from the UpdateProduct operation.
    /// </summary>
    public partial class UpdateProductResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApiSelectionConfiguration. How Managed APIs are selected
        /// for the product.
        /// </summary>
        public ApiSelectionConfiguration ApiSelectionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ApiSelectionConfiguration property is set.
        /// </summary>
        internal bool IsSetApiSelectionConfiguration() => this.ApiSelectionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. A description of the product, up to 1024 characters.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. The name of the product, from 1 to 255 characters.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DisplayOrder. The order of the product's pages and API
        /// page sections in the portal navigation.
        /// </summary>
        public DisplayOrder DisplayOrder { get; set; }

        /// <summary>
        /// Checks to see if the DisplayOrder property is set.
        /// </summary>
        internal bool IsSetDisplayOrder() => this.DisplayOrder != null;

        /// <summary>
        /// Gets and sets the property FailureReason.
        /// </summary>
        public ProductFailureReason FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property ProductArn. The ARN of the product.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string ProductArn { get; set; }

        /// <summary>
        /// Checks to see if the ProductArn property is set.
        /// </summary>
        internal bool IsSetProductArn() => this.ProductArn != null;

        /// <summary>
        /// Gets and sets the property ProductId. The identifier of the product.
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public ProductStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. When the resource was last updated.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
