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
    /// A list of AWS accounts and the active CloudFront key pairs in each account that CloudFront
    /// can use to verify the signatures of signed URLs and signed cookies.
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
        /// <param name="items">A list of AWS accounts and the identifiers of active CloudFront key pairs in each account that CloudFront can use to verify the signatures of signed URLs and signed cookies.</param>
        public ActiveTrustedSigners(List<Signer> items)
        {
            _items = items;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// This field is <code>true</code> if any of the AWS accounts in the list have active
        /// CloudFront key pairs that CloudFront can use to verify the signatures of signed URLs
        /// and signed cookies. If not, this field is <code>false</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Items. 
        /// <para>
        /// A list of AWS accounts and the identifiers of active CloudFront key pairs in each
        /// account that CloudFront can use to verify the signatures of signed URLs and signed
        /// cookies.
        /// </para>
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
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of AWS accounts in the list.
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