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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This field is deprecated. We recommend that you use a cache policy or an origin request
    /// policy instead of this field.
    /// 
    ///  
    /// <para>
    /// If you want to include query strings in the cache key, use <code>QueryStringsConfig</code>
    /// in a cache policy. See <code>CachePolicy</code>.
    /// </para>
    ///  
    /// <para>
    /// If you want to send query strings to the origin but not include them in the cache
    /// key, use <code>QueryStringsConfig</code> in an origin request policy. See <code>OriginRequestPolicy</code>.
    /// </para>
    ///  
    /// <para>
    /// A complex type that contains information about the query string parameters that you
    /// want CloudFront to use for caching for a cache behavior.
    /// </para>
    /// </summary>
    public partial class QueryStringCacheKeys
    {
        private List<string> _items = new List<string>();
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A list that contains the query string parameters that you want CloudFront to use as
        /// a basis for caching for a cache behavior. If <code>Quantity</code> is 0, you can omit
        /// <code>Items</code>.
        /// </para>
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
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of <code>whitelisted</code> query string parameters for a cache behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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