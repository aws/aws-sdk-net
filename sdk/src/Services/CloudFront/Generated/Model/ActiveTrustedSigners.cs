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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
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
    /// A complex type that lists the AWS accounts, if any, that you included in the <code>TrustedSigners</code>
    /// complex type for this distribution. These are the accounts that you want to allow
    /// to create signed URLs for private content.
    /// 
    ///  
    /// <para>
    /// The <code>Signer</code> complex type lists the AWS account number of the trusted signer
    /// or <code>self</code> if the signer is the AWS account that created the distribution.
    /// The <code>Signer</code> element also includes the IDs of any active CloudFront key
    /// pairs that are associated with the trusted signer's AWS account. If no <code>KeyPairId</code>
    /// element appears for a <code>Signer</code>, that signer can't create signed URLs. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
    /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
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
        /// <param name="items">A complex type that contains one <code>Signer</code> complex type for each trusted signer that is specified in the <code>TrustedSigners</code> complex type. For more information, see <a>ActiveTrustedSigners</a>. </param>
        public ActiveTrustedSigners(List<Signer> items)
        {
            _items = items;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Enabled is <code>true</code> if any of the AWS accounts listed in the <code>TrustedSigners</code>
        /// complex type for this RTMP distribution have active CloudFront key pairs. If not,
        /// <code>Enabled</code> is <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>ActiveTrustedSigners</a>.
        /// </para>
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
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains one <code>Signer</code> complex type for each trusted
        /// signer that is specified in the <code>TrustedSigners</code> complex type.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>ActiveTrustedSigners</a>. 
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
        /// A complex type that contains one <code>Signer</code> complex type for each trusted
        /// signer specified in the <code>TrustedSigners</code> complex type.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>ActiveTrustedSigners</a>.
        /// </para>
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