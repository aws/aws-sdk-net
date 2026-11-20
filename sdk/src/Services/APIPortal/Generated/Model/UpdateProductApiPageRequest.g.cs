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
    /// Container for the parameters to the UpdateProductApiPage operation. Updates an API
    /// page. Only the fields supplied in the request are changed.
    /// </summary>
    public partial class UpdateProductApiPageRequest : AmazonAPIPortalRequest
    {
        /// <summary>
        /// Gets and sets the property DisplayContent.
        /// </summary>
        public ApiPageDisplayContent DisplayContent { get; set; }

        /// <summary>
        /// Checks to see if the DisplayContent property is set.
        /// </summary>
        internal bool IsSetDisplayContent() => this.DisplayContent != null;

        /// <summary>
        /// Gets and sets the property ProductApiPageId. The identifier of the API page.
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string ProductApiPageId { get; set; }

        /// <summary>
        /// Checks to see if the ProductApiPageId property is set.
        /// </summary>
        internal bool IsSetProductApiPageId() => this.ProductApiPageId != null;

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
        /// Gets and sets the property TryItState. The new Try-It setting. Omit it to keep the
        /// current setting. To enable it, the page's API URL must use HTTPS on a domain that
        /// supports Try-It.
        /// </summary>
        public TryItState TryItState { get; set; }

        /// <summary>
        /// Checks to see if the TryItState property is set.
        /// </summary>
        internal bool IsSetTryItState() => this.TryItState != null;
    }
}
