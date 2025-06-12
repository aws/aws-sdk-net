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
    /// A complex type that specifies a list of Lambda@Edge functions associations for a cache
    /// behavior.
    /// 
    ///  
    /// <para>
    /// If you want to invoke one or more Lambda@Edge functions triggered by requests that
    /// match the <c>PathPattern</c> of the cache behavior, specify the applicable values
    /// for <c>Quantity</c> and <c>Items</c>. Note that there can be up to 4 <c>LambdaFunctionAssociation</c>
    /// items in this list (one for each possible value of <c>EventType</c>) and each <c>EventType</c>
    /// can be associated with only one function.
    /// </para>
    ///  
    /// <para>
    /// If you don't want to invoke any Lambda@Edge functions for the requests that match
    /// <c>PathPattern</c>, specify <c>0</c> for <c>Quantity</c> and omit <c>Items</c>.
    /// </para>
    /// </summary>
    public partial class LambdaFunctionAssociations
    {
        private List<LambdaFunctionAssociation> _items = AWSConfigs.InitializeCollections ? new List<LambdaFunctionAssociation>() : null;
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        ///  <b>Optional</b>: A complex type that contains <c>LambdaFunctionAssociation</c> items
        /// for this cache behavior. If <c>Quantity</c> is <c>0</c>, you can omit <c>Items</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaFunctionAssociation> Items
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
        /// The number of Lambda@Edge function associations for this cache behavior.
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