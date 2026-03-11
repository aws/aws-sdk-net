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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
    /// Container for the parameters to the GetProductPage operation.
    /// Gets a product page of a portal product.
    /// </summary>
    public partial class GetProductPageRequest : AmazonApiGatewayV2Request
    {
        private string _portalProductId;
        private string _productPageId;
        private string _resourceOwnerAccountId;

        /// <summary>
        /// Gets and sets the property PortalProductId. 
        /// <para>
        /// The portal product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PortalProductId
        {
            get { return this._portalProductId; }
            set { this._portalProductId = value; }
        }

        // Check to see if PortalProductId property is set
        internal bool IsSetPortalProductId()
        {
            return this._portalProductId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductPageId. 
        /// <para>
        /// The portal product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProductPageId
        {
            get { return this._productPageId; }
            set { this._productPageId = value; }
        }

        // Check to see if ProductPageId property is set
        internal bool IsSetProductPageId()
        {
            return this._productPageId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwnerAccountId. 
        /// <para>
        /// The account ID of the resource owner of the portal product.
        /// </para>
        /// </summary>
        public string ResourceOwnerAccountId
        {
            get { return this._resourceOwnerAccountId; }
            set { this._resourceOwnerAccountId = value; }
        }

        // Check to see if ResourceOwnerAccountId property is set
        internal bool IsSetResourceOwnerAccountId()
        {
            return this._resourceOwnerAccountId != null;
        }

    }
}