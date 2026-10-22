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
    /// This is the response object from the GetProductPage operation.
    /// </summary>
    public partial class GetProductPageResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The timestamp when the product page was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property ProductPageArn. 
        /// <para>
        /// The ARN of the product page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProductPageArn { get; set; }

        /// <summary>
        /// Checks to see if the ProductPageArn property is set.
        /// </summary>
        internal bool IsSetProductPageArn() => this.ProductPageArn != null;

        /// <summary>
        /// Gets and sets the property ProductPageId. 
        /// <para>
        /// The product page identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 30)]
        public string ProductPageId { get; set; }

        /// <summary>
        /// Checks to see if the ProductPageId property is set.
        /// </summary>
        internal bool IsSetProductPageId() => this.ProductPageId != null;
    }
}
