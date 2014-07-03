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
    /// The CloudFrontOriginAccessIdentityList type.
    /// </summary>
    public partial class CloudFrontOriginAccessIdentityList
    {
        private bool? _isTruncated;
        private List<CloudFrontOriginAccessIdentitySummary> _items = new List<CloudFrontOriginAccessIdentitySummary>();
        private string _marker;
        private int? _maxItems;
        private string _nextMarker;
        private int? _quantity;


        /// <summary>
        /// Gets and sets the property IsTruncated. A flag that indicates whether more origin
        /// access identities remain to be listed.    If your results were truncated, you can
        /// make a follow-up pagination request using the Marker request parameter to retrieve
        /// more items in the list.
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Items. A complex type that contains one    CloudFrontOriginAccessIdentitySummary
        /// element for each origin    access identity that was created by the current AWS account.
        /// </summary>
        public List<CloudFrontOriginAccessIdentitySummary> Items
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
        /// Gets and sets the property Marker. The value you provided for the Marker request parameter.
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property MaxItems. The value you provided for the MaxItems request
        /// parameter.
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property NextMarker. If IsTruncated is true, this element is present
        /// and contains the value you can use for the Marker request parameter to continue listing
        /// your origin access identities where they left off.
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }


        /// <summary>
        /// Gets and sets the property Quantity. The number of CloudFront origin access identities
        /// that were created by    the current AWS account.
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