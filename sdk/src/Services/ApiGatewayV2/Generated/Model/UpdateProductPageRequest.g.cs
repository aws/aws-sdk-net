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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProductPage operation. Updates a product
    /// page of a portal product.
    /// </summary>
    public partial class UpdateProductPageRequest : AmazonApiGatewayV2Request
    {
        /// <summary>
        /// Gets and sets the property DisplayContent. 
        /// <para>
        /// The content of the product page.
        /// </para>
        /// </summary>
        public DisplayContent DisplayContent { get; set; }

        /// <summary>
        /// Checks to see if the DisplayContent property is set.
        /// </summary>
        internal bool IsSetDisplayContent() => this.DisplayContent != null;

        /// <summary>
        /// Gets and sets the property PortalProductId. 
        /// <para>
        /// The portal product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PortalProductId { get; set; }

        /// <summary>
        /// Checks to see if the PortalProductId property is set.
        /// </summary>
        internal bool IsSetPortalProductId() => this.PortalProductId != null;

        /// <summary>
        /// Gets and sets the property ProductPageId. 
        /// <para>
        /// The portal product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProductPageId { get; set; }

        /// <summary>
        /// Checks to see if the ProductPageId property is set.
        /// </summary>
        internal bool IsSetProductPageId() => this.ProductPageId != null;
    }
}
