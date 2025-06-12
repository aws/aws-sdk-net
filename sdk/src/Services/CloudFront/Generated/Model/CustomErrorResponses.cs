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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that controls:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Whether CloudFront replaces HTTP status codes in the 4xx and 5xx range with custom
    /// error messages before returning the response to the viewer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// How long CloudFront caches HTTP status codes in the 4xx and 5xx range.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about custom error pages, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/custom-error-pages.html">Customizing
    /// Error Responses</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CustomErrorResponses
    {
        private List<CustomErrorResponse> _items = AWSConfigs.InitializeCollections ? new List<CustomErrorResponse>() : null;
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains a <c>CustomErrorResponse</c> element for each HTTP status
        /// code for which you want to specify a custom error page and/or a caching duration.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomErrorResponse> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of HTTP status codes for which you want to specify a custom error page
        /// and/or a caching duration. If <c>Quantity</c> is <c>0</c>, you can omit <c>Items</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

    }
}