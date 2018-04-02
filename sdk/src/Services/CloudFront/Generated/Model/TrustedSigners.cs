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
    /// A complex type that specifies the AWS accounts, if any, that you want to allow to
    /// create signed URLs for private content.
    /// 
    ///  
    /// <para>
    /// If you want to require signed URLs in requests for objects in the target origin that
    /// match the <code>PathPattern</code> for this cache behavior, specify <code>true</code>
    /// for <code>Enabled</code>, and specify the applicable values for <code>Quantity</code>
    /// and <code>Items</code>. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
    /// Private Content through CloudFront</a> in the <i>Amazon Amazon CloudFront Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you don't want to require signed URLs in requests for objects that match <code>PathPattern</code>,
    /// specify <code>false</code> for <code>Enabled</code> and <code>0</code> for <code>Quantity</code>.
    /// Omit <code>Items</code>.
    /// </para>
    ///  
    /// <para>
    /// To add, change, or remove one or more trusted signers, change <code>Enabled</code>
    /// to <code>true</code> (if it's currently <code>false</code>), change <code>Quantity</code>
    /// as applicable, and specify all of the trusted signers that you want to include in
    /// the updated distribution.
    /// </para>
    ///  
    /// <para>
    /// For more information about updating the distribution configuration, see <a>DistributionConfig</a>
    /// .
    /// </para>
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
        /// <param name="items"> <b>Optional</b>: A complex type that contains trusted signers for this cache behavior. If <code>Quantity</code> is <code>0</code>, you can omit <code>Items</code>.</param>
        public TrustedSigners(List<string> items)
        {
            _items = items;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether you want to require viewers to use signed URLs to access the files
        /// specified by <code>PathPattern</code> and <code>TargetOriginId</code>.
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
        ///  <b>Optional</b>: A complex type that contains trusted signers for this cache behavior.
        /// If <code>Quantity</code> is <code>0</code>, you can omit <code>Items</code>.
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
        /// The number of trusted signers for this cache behavior.
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