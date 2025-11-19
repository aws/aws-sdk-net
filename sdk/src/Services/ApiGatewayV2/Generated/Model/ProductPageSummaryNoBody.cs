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
    /// Represents a product page summary without listing any page content.
    /// </summary>
    public partial class ProductPageSummaryNoBody
    {
        private DateTime? _lastModified;
        private string _pageTitle;
        private string _productPageArn;
        private string _productPageId;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The timestamp when the product page was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModified
        {
            get { return this._lastModified.GetValueOrDefault(); }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageTitle. 
        /// <para>
        /// The page title.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string PageTitle
        {
            get { return this._pageTitle; }
            set { this._pageTitle = value; }
        }

        // Check to see if PageTitle property is set
        internal bool IsSetPageTitle()
        {
            return this._pageTitle != null;
        }

        /// <summary>
        /// Gets and sets the property ProductPageArn. 
        /// <para>
        /// The ARN of the product page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProductPageArn
        {
            get { return this._productPageArn; }
            set { this._productPageArn = value; }
        }

        // Check to see if ProductPageArn property is set
        internal bool IsSetProductPageArn()
        {
            return this._productPageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProductPageId. 
        /// <para>
        /// The product page identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=30)]
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

    }
}