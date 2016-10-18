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
 * Do not modify this file. This file is generated from the cloudfront-2016-09-29.normal.json service model.
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
    /// A complex type that specifies the headers that you want CloudFront to forward to the
    /// origin for this cache behavior.
    /// 
    ///  
    /// <para>
    /// For the headers that you specify, CloudFront also caches separate versions of a specified
    /// object based on the header values in viewer requests. For example, suppose viewer
    /// requests for <code>logo.jpg</code> contain a custom <code>Product</code> header that
    /// has a value of either <code>Acme</code> or <code>Apex</code>, and you configure CloudFront
    /// to cache your content based on values in the <code>Product</code> header. CloudFront
    /// forwards the <code>Product</code> header to the origin and caches the response from
    /// the origin once for each header value. For more information about caching based on
    /// header values, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/header-caching.html">How
    /// CloudFront Forwards and Caches Headers</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class Headers
    {
        private List<string> _items = new List<string>();
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains one <code>Name</code> element for each header that you
        /// want CloudFront to forward to the origin and to vary on for this cache behavior. If
        /// <code>Quantity</code> is <code>0</code>, omit <code>Items</code>.
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
        /// The number of different headers that you want CloudFront to forward to the origin
        /// for this cache behavior. You can configure each cache behavior in a web distribution
        /// to do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Forward all headers to your origin</b>: Specify <code>1</code> for <code>Quantity</code>
        /// and <code>*</code> for <code>Name</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you configure CloudFront to forward all headers to your origin, CloudFront doesn't
        /// cache the objects associated with this cache behavior. Instead, it sends every request
        /// to the origin.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <i>Forward a whitelist of headers you specify</i>: Specify the number of headers
        /// that you want to forward, and specify the header names in <code>Name</code> elements.
        /// CloudFront caches your objects based on the values in all of the specified headers.
        /// CloudFront also forwards the headers that it forwards by default, but it caches your
        /// objects based only on the headers that you specify. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Forward only the default headers</b>: Specify <code>0</code> for <code>Quantity</code>
        /// and omit <code>Items</code>. In this configuration, CloudFront doesn't cache based
        /// on the values in the request headers.
        /// </para>
        ///  </li> </ul>
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