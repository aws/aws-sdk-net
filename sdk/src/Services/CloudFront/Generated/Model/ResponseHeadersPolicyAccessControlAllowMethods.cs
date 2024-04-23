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
    /// A list of HTTP methods that CloudFront includes as values for the <c>Access-Control-Allow-Methods</c>
    /// HTTP response header.
    /// 
    ///  
    /// <para>
    /// For more information about the <c>Access-Control-Allow-Methods</c> HTTP response header,
    /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Methods">Access-Control-Allow-Methods</a>
    /// in the MDN Web Docs.
    /// </para>
    /// </summary>
    public partial class ResponseHeadersPolicyAccessControlAllowMethods
    {
        private List<string> _items = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The list of HTTP methods. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GET</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HEAD</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIONS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PATCH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>POST</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>ALL</c> is a special value that includes all of the listed HTTP methods.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Items
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
        /// The number of HTTP methods in the list.
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