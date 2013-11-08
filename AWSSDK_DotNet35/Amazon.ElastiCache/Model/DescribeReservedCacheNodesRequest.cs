/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedCacheNodes operation.
    /// <para>The <i>DescribeReservedCacheNodes</i> operation returns information about reserved cache nodes for this account, or about a specified
    /// reserved cache node.</para>
    /// </summary>
    public partial class DescribeReservedCacheNodesRequest : AmazonElastiCacheRequest
    {
        private string reservedCacheNodeId;
        private string reservedCacheNodesOfferingId;
        private string cacheNodeType;
        private string duration;
        private string productDescription;
        private string offeringType;
        private int? maxRecords;
        private string marker;


        /// <summary>
        /// The reserved cache node identifier filter value. Use this parameter to show only the reservation that matches the specified reservation ID.
        ///  
        /// </summary>
        public string ReservedCacheNodeId
        {
            get { return this.reservedCacheNodeId; }
            set { this.reservedCacheNodeId = value; }
        }

        // Check to see if ReservedCacheNodeId property is set
        internal bool IsSetReservedCacheNodeId()
        {
            return this.reservedCacheNodeId != null;
        }

        /// <summary>
        /// The offering identifier filter value. Use this parameter to show only purchased reservations matching the specified offering identifier.
        ///  
        /// </summary>
        public string ReservedCacheNodesOfferingId
        {
            get { return this.reservedCacheNodesOfferingId; }
            set { this.reservedCacheNodesOfferingId = value; }
        }

        // Check to see if ReservedCacheNodesOfferingId property is set
        internal bool IsSetReservedCacheNodesOfferingId()
        {
            return this.reservedCacheNodesOfferingId != null;
        }

        /// <summary>
        /// The cache node type filter value. Use this parameter to show only those reservations matching the specified cache node type.
        ///  
        /// </summary>
        public string CacheNodeType
        {
            get { return this.cacheNodeType; }
            set { this.cacheNodeType = value; }
        }

        // Check to see if CacheNodeType property is set
        internal bool IsSetCacheNodeType()
        {
            return this.cacheNodeType != null;
        }

        /// <summary>
        /// The duration filter value, specified in years or seconds. Use this parameter to show only reservations for this duration. Valid Values: <c>1
        /// | 3 | 31536000 | 94608000</c>
        ///  
        /// </summary>
        public string Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this.duration != null;
        }

        /// <summary>
        /// The product description filter value. Use this parameter to show only those reservations matching the specified product description.
        ///  
        /// </summary>
        public string ProductDescription
        {
            get { return this.productDescription; }
            set { this.productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this.productDescription != null;
        }

        /// <summary>
        /// The offering type filter value. Use this parameter to show only the available offerings matching the specified offering type. Valid values:
        /// <c>"Light Utilization" | "Medium Utilization" | "Heavy Utilization" </c>
        ///  
        /// </summary>
        public string OfferingType
        {
            get { return this.offeringType; }
            set { this.offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this.offeringType != null;
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more records exist than the specified <c>MaxRecords</c> value, a marker is
        /// included in the response so that the remaining results can be retrieved. Default: 100Constraints: minimum 20; maximum 100.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// An optional marker returned from a prior request. Use this marker for pagination of results from this operation. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified by <i>MaxRecords</i>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

    }
}
    
