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
    /// A complex type that controls which HTTP methods CloudFront processes and forwards
    /// to your Amazon S3 bucket or your custom origin. There are three choices: - CloudFront
    /// forwards only GET and HEAD requests. - CloudFront forwards only GET, HEAD and OPTIONS
    /// requests. - CloudFront forwards GET, HEAD, OPTIONS, PUT, PATCH, POST, and DELETE requests.
    /// If you pick the third choice, you may need to restrict access to your Amazon S3 bucket
    /// or to your custom origin so users can't perform operations that you don't want them
    /// to. For example, you may not want users to have permission to delete objects from
    /// your origin.
    /// </summary>
    public partial class AllowedMethods
    {
        private CachedMethods _cachedMethods;
        private List<string> _items = new List<string>();
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property CachedMethods.
        /// </summary>
        public CachedMethods CachedMethods
        {
            get { return this._cachedMethods; }
            set { this._cachedMethods = value; }
        }

        // Check to see if CachedMethods property is set
        internal bool IsSetCachedMethods()
        {
            return this._cachedMethods != null;
        }

        /// <summary>
        /// Gets and sets the property Items. A complex type that contains the HTTP methods that
        /// you want CloudFront to process and forward to your origin.
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
        /// Gets and sets the property Quantity. The number of HTTP methods that you want CloudFront
        /// to forward to your origin. Valid values are 2 (for GET and HEAD requests), 3 (for
        /// GET, HEAD and OPTIONS requests) and 7 (for GET, HEAD, OPTIONS, PUT, PATCH, POST, and
        /// DELETE requests).
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