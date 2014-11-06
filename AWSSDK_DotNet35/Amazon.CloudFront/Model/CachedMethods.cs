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
 * Do not modify this file. This file is generated from the cloudfront-2014-10-21.normal.json service model.
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
    /// A complex type that controls whether CloudFront caches the response to requests using
    /// the specified HTTP methods. There are two choices: - CloudFront caches responses to
    /// GET and HEAD requests. - CloudFront caches responses to GET, HEAD, and OPTIONS requests.
    /// If you pick the second choice for your S3 Origin, you may need to forward Access-Control-Request-Method,
    /// Access-Control-Request-Headers and Origin headers for the responses to be cached correctly.
    /// </summary>
    public partial class CachedMethods
    {
        private List<string> _items = new List<string>();
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. A complex type that contains the HTTP methods that
        /// you want CloudFront to cache responses to.
        /// </summary>
        public List<string> Items
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
        /// Gets and sets the property Quantity. The number of HTTP methods for which you want
        /// CloudFront to cache responses. Valid values are 2 (for caching responses to GET and
        /// HEAD requests) and 3 (for caching responses to GET, HEAD, and OPTIONS requests).
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