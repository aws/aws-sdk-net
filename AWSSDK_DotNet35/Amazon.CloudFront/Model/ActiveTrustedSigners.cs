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
    /// A complex type that lists the AWS accounts, if any, that you included in the TrustedSigners
    /// complex type for the default cache behavior or for any of the other cache behaviors
    /// for this distribution. These are accounts that you want to allow to create signed
    /// URLs for private content.
    /// </summary>
    public partial class ActiveTrustedSigners
    {
        private bool? _enabled;
        private List<Signer> _items = new List<Signer>();
        private int? _quantity;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ActiveTrustedSigners() { }

        /// <summary>
        /// Instantiates ActiveTrustedSigners with the parameterized properties
        /// </summary>
        /// <param name="items">A complex type that contains one Signer complex type for each unique trusted signer that is specified in the TrustedSigners complex type, including trusted signers in the default cache behavior and in all of the other cache behaviors.</param>
        public ActiveTrustedSigners(List<Signer> items)
        {
            _items = items;
        }

        /// <summary>
        /// Gets and sets the property Enabled. Each active trusted signer.
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
        /// Gets and sets the property Items. A complex type that contains one Signer complex
        /// type for each unique trusted signer that is specified in the TrustedSigners complex
        /// type, including trusted signers in the default cache behavior and in all of the other
        /// cache behaviors.
        /// </summary>
        public List<Signer> Items
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
        /// Gets and sets the property Quantity. The number of unique trusted signers included
        /// in all cache behaviors. For example, if three cache behaviors all list the same three
        /// AWS accounts, the value of Quantity for ActiveTrustedSigners will be 3.
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