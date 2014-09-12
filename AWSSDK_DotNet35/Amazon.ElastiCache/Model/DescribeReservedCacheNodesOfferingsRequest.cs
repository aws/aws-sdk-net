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
    /// Container for the parameters to the DescribeReservedCacheNodesOfferings operation.
    /// The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved
    /// cache node offerings.
    /// </summary>
    public partial class DescribeReservedCacheNodesOfferingsRequest : AmazonElastiCacheRequest
    {
        private string _cacheNodeType;
        private string _duration;
        private string _marker;
        private int? _maxRecords;
        private string _offeringType;
        private string _productDescription;
        private string _reservedCacheNodesOfferingId;

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// The cache node type filter value. Use this parameter to show only the available offerings
        /// matching the specified cache node type.
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
        /// Duration filter value, specified in years or seconds. Use this parameter to show only
        /// reservations for a given duration.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>1 | 3 | 31536000 | 94608000</code>
        /// </para>
        /// </summary>
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by <i>MaxRecords</i>.
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
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <code>MaxRecords</code> value, a marker is included in the response
        /// so that the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20; maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The offering type filter value. Use this parameter to show only the available offerings
        /// matching the specified offering type.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>"Light Utilization" | "Medium Utilization" | "Heavy Utilization"
        /// </code>
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
        /// The product description filter value. Use this parameter to show only the available
        /// offerings matching the specified product description.
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
        /// Gets and sets the property ReservedCacheNodesOfferingId. 
        /// <para>
        /// The offering identifier filter value. Use this parameter to show only the available
        /// offering that matches the specified reservation identifier.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>438012d3-4052-4cc7-b2e3-8d3372e0e706</code>
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

    }
}