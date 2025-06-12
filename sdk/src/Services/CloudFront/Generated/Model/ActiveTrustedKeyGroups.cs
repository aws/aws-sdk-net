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
    /// A list of key groups, and the public keys in each key group, that CloudFront can use
    /// to verify the signatures of signed URLs and signed cookies.
    /// </summary>
    public partial class ActiveTrustedKeyGroups
    {
        private bool? _enabled;
        private List<KGKeyPairIds> _items = AWSConfigs.InitializeCollections ? new List<KGKeyPairIds>() : null;
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// This field is <c>true</c> if any of the key groups have public keys that CloudFront
        /// can use to verify the signatures of signed URLs and signed cookies. If not, this field
        /// is <c>false</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
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
        /// A list of key groups, including the identifiers of the public keys in each key group
        /// that CloudFront can use to verify the signatures of signed URLs and signed cookies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KGKeyPairIds> Items
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
        /// The number of key groups in the list.
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