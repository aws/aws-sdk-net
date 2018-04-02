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
    /// The <code>InvalidationList</code> complex type describes the list of invalidation
    /// objects. For more information about invalidation, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Invalidation.html">Invalidating
    /// Objects (Web Distributions Only)</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </summary>
    public partial class InvalidationList
    {
        private bool? _isTruncated;
        private List<InvalidationSummary> _items = new List<InvalidationSummary>();
        private string _marker;
        private int? _maxItems;
        private string _nextMarker;
        private int? _quantity;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public InvalidationList() { }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether more invalidation batch requests remain to be listed.
        /// If your results were truncated, you can make a follow-up pagination request using
        /// the <code>Marker</code> request parameter to retrieve more invalidation batches in
        /// the list.
        /// </para>
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
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains one <code>InvalidationSummary</code> element for each
        /// invalidation batch created by the current AWS account.
        /// </para>
        /// </summary>
        public List<InvalidationSummary> Items
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
        /// Gets and sets the property Marker. 
        /// <para>
        /// The value that you provided for the <code>Marker</code> request parameter.
        /// </para>
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
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you provided for the <code>MaxItems</code> request parameter.
        /// </para>
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
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, this element is present and contains
        /// the value that you can use for the <code>Marker</code> request parameter to continue
        /// listing your invalidation batches where they left off.
        /// </para>
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
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of invalidation batches that were created by the current AWS account. 
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