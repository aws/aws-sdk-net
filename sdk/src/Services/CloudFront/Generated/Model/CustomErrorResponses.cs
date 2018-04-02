/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
    /// For more information about custom error pages, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/custom-error-pages.html">Customizing
    /// Error Responses</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CustomErrorResponses
    {
        private List<CustomErrorResponse> _items = new List<CustomErrorResponse>();
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains a <code>CustomErrorResponse</code> element for each HTTP
        /// status code for which you want to specify a custom error page and/or a caching duration.
        /// 
        /// </para>
        /// </summary>
        public List<CustomErrorResponse> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of HTTP status codes for which you want to specify a custom error page
        /// and/or a caching duration. If <code>Quantity</code> is <code>0</code>, you can omit
        /// <code>Items</code>.
        /// </para>
        /// </summary>
        public int Quantity
        {
            get { return this._quantity.GetValueOrDefault(); }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

    }
}