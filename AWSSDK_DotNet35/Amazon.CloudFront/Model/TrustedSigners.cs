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
    /// A complex type that specifies the AWS accounts, if any, that you want to allow to
    /// create signed URLs for private content. If you want to require signed URLs in requests
    /// for objects in the target origin that match the PathPattern for this cache behavior,
    /// specify true for Enabled, and specify the applicable values for Quantity and Items.
    /// For more information, go to Using a Signed URL to Serve Private Content in the Amazon
    /// CloudFront Developer Guide. If you don't want to require signed URLs in requests for
    /// objects that match PathPattern, specify false for Enabled and 0 for Quantity. Omit
    /// Items. To add, change, or remove one or more trusted signers, change Enabled to true
    /// (if it's currently false), change Quantity as applicable, and specify all of the trusted
    /// signers that you want to include in the updated distribution.
    /// </summary>
    public partial class TrustedSigners
    {
        private bool? _enabled;
        private List<string> _items = new List<string>();
        private int? _quantity;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public TrustedSigners() { }

        /// <summary>
        /// Instantiates TrustedSigners with the parameterized properties
        /// </summary>
        /// <param name="items">Optional: A complex type that contains trusted signers for this cache behavior. If Quantity is 0, you can omit Items.</param>
        public TrustedSigners(List<string> items)
        {
            _items = items;
        }

        /// <summary>
        /// Gets and sets the property Enabled. Specifies whether you want to require end users
        /// to use signed URLs to access the files specified by PathPattern and TargetOriginId.
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Items. Optional: A complex type that contains trusted signers
        /// for this cache behavior. If Quantity is 0, you can omit Items.
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
        /// Gets and sets the property Quantity. The number of trusted signers for this cache
        /// behavior.
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