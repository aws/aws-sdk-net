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
    /// A distribution list.
    /// </summary>
    public partial class DistributionList
    {
        private bool? _isTruncated;
        private List<DistributionSummary> _items = new List<DistributionSummary>();
        private string _marker;
        private int? _maxItems;
        private string _nextMarker;
        private int? _quantity;


        /// <summary>
        /// Gets and sets the property IsTruncated. A flag that indicates whether more distributions
        /// remain to be listed.    If your results were truncated, you can make a follow-up pagination
        /// request using the Marker request parameter to retrieve more distributions in the list.
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
            set { this._isTruncated = value; }
        }


        /// <summary>
        /// Sets the IsTruncated property
        /// </summary>
        /// <param name="isTruncated">The value to set for the IsTruncated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionList WithIsTruncated(bool isTruncated)
        {
            this._isTruncated = isTruncated;
            return this;
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Items. A complex type that contains one DistributionSummary
        /// element for    each distribution that was created by the current AWS account.
        /// </summary>
        public List<DistributionSummary> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        /// <summary>
        /// Sets the Items property
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionList WithItems(params DistributionSummary[] items)
        {
            foreach (var element in items)
            {
                this._items.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Items property
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionList WithItems(IEnumerable<DistributionSummary> items)
        {
            foreach (var element in items)
            {
                this._items.Add(element);
            }
            return this;
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


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionList WithMarker(string marker)
        {
            this._marker = marker;
            return this;
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


        /// <summary>
        /// Sets the MaxItems property
        /// </summary>
        /// <param name="maxItems">The value to set for the MaxItems property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionList WithMaxItems(int maxItems)
        {
            this._maxItems = maxItems;
            return this;
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property NextMarker. If IsTruncated is true, this element is present
        /// and contains the value you can use for the Marker request parameter to continue listing
        /// your distributions where they left off.
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }


        /// <summary>
        /// Sets the NextMarker property
        /// </summary>
        /// <param name="nextMarker">The value to set for the NextMarker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionList WithNextMarker(string nextMarker)
        {
            this._nextMarker = nextMarker;
            return this;
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }


        /// <summary>
        /// Gets and sets the property Quantity. The number of distributions that were created
        /// by the current AWS account.
        /// </summary>
        public int Quantity
        {
            get { return this._quantity.GetValueOrDefault(); }
            set { this._quantity = value; }
        }


        /// <summary>
        /// Sets the Quantity property
        /// </summary>
        /// <param name="quantity">The value to set for the Quantity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionList WithQuantity(int quantity)
        {
            this._quantity = quantity;
            return this;
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

    }
}