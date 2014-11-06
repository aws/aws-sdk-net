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
    /// A complex type that specifies the headers that you want CloudFront to forward to the
    /// origin for this cache behavior. For the headers that you specify, CloudFront also
    /// caches separate versions of a given object based on the header values in viewer requests;
    /// this is known as varying on headers. For example, suppose viewer requests for logo.jpg
    /// contain a custom Product header that has a value of either Acme or Apex, and you configure
    /// CloudFront to vary on the Product header. CloudFront forwards the Product header to
    /// the origin and caches the response from the origin once for each header value.
    /// </summary>
    public partial class Headers
    {
        private List<string> _items = new List<string>();
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. Optional: A complex type that contains a Name element
        /// for each header that you want CloudFront to forward to the origin and to vary on for
        /// this cache behavior. If Quantity is 0, omit Items.
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
        /// Gets and sets the property Quantity. The number of different headers that you want
        /// CloudFront to forward to the origin and to vary on for this cache behavior. The maximum
        /// number of headers that you can specify by name is 10. If you want CloudFront to forward
        /// all headers to the origin and vary on all of them, specify 1 for Quantity and * for
        /// Name. If you don't want CloudFront to forward any additional headers to the origin
        /// or to vary on any headers, specify 0 for Quantity and omit Items.
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