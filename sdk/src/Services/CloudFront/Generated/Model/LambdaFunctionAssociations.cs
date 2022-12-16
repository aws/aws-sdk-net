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
    /// A complex type that specifies a list of Lambda@Edge functions associations for a cache
    /// behavior.
    /// 
    ///  
    /// <para>
    /// If you want to invoke one or more Lambda@Edge functions triggered by requests that
    /// match the <code>PathPattern</code> of the cache behavior, specify the applicable values
    /// for <code>Quantity</code> and <code>Items</code>. Note that there can be up to 4 <code>LambdaFunctionAssociation</code>
    /// items in this list (one for each possible value of <code>EventType</code>) and each
    /// <code>EventType</code> can be associated with only one function.
    /// </para>
    ///  
    /// <para>
    /// If you don't want to invoke any Lambda@Edge functions for the requests that match
    /// <code>PathPattern</code>, specify <code>0</code> for <code>Quantity</code> and omit
    /// <code>Items</code>.
    /// </para>
    /// </summary>
    public partial class LambdaFunctionAssociations
    {
        private List<LambdaFunctionAssociation> _items = new List<LambdaFunctionAssociation>();
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        ///  <b>Optional</b>: A complex type that contains <code>LambdaFunctionAssociation</code>
        /// items for this cache behavior. If <code>Quantity</code> is <code>0</code>, you can
        /// omit <code>Items</code>.
        /// </para>
        /// </summary>
        public List<LambdaFunctionAssociation> Items
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
        /// The number of Lambda@Edge function associations for this cache behavior.
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