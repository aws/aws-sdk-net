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
 * Do not modify this file. This file is generated from the elasticache-2014-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Describes all of the attributes of a reserved cache node offering.
    /// </summary>
    public partial class ReservedCacheNodesOffering
    {
        private string _cacheNodeType;
        private int? _duration;
        private double? _fixedPrice;
        private string _offeringType;
        private string _productDescription;
        private List<RecurringCharge> _recurringCharges = new List<RecurringCharge>();
        private string _reservedCacheNodesOfferingId;
        private double? _usagePrice;

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// The cache node type for the reserved cache node.
        /// </para>
        /// </summary>
        public string CacheNodeType
        {
            get { return this._cacheNodeType; }
            set { this._cacheNodeType = value; }
        }

        // Check to see if CacheNodeType property is set
        internal bool IsSetCacheNodeType()
        {
            return this._cacheNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the offering. in seconds.
        /// </para>
        /// </summary>
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        /// The fixed price charged for this offering.
        /// </para>
        /// </summary>
        public double FixedPrice
        {
            get { return this._fixedPrice.GetValueOrDefault(); }
            set { this._fixedPrice = value; }
        }

        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this._fixedPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The offering type.
        /// </para>
        /// </summary>
        public string OfferingType
        {
            get { return this._offeringType; }
            set { this._offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this._offeringType != null;
        }

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The cache engine used by the offering.
        /// </para>
        /// </summary>
        public string ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this._productDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The recurring price charged to run this reserved cache node.
        /// </para>
        /// </summary>
        public List<RecurringCharge> RecurringCharges
        {
            get { return this._recurringCharges; }
            set { this._recurringCharges = value; }
        }

        // Check to see if RecurringCharges property is set
        internal bool IsSetRecurringCharges()
        {
            return this._recurringCharges != null && this._recurringCharges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReservedCacheNodesOfferingId. 
        /// <para>
        /// A unique identifier for the reserved cache node offering.
        /// </para>
        /// </summary>
        public string ReservedCacheNodesOfferingId
        {
            get { return this._reservedCacheNodesOfferingId; }
            set { this._reservedCacheNodesOfferingId = value; }
        }

        // Check to see if ReservedCacheNodesOfferingId property is set
        internal bool IsSetReservedCacheNodesOfferingId()
        {
            return this._reservedCacheNodesOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        /// The hourly price charged for this offering.
        /// </para>
        /// </summary>
        public double UsagePrice
        {
            get { return this._usagePrice.GetValueOrDefault(); }
            set { this._usagePrice = value; }
        }

        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this._usagePrice.HasValue; 
        }

    }
}