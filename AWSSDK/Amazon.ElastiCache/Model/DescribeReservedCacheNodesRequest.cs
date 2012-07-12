/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Returns information about reserved Cache Nodes for this account, or about a specified reserved Cache Node. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReservedCacheNodes"/>
    public class DescribeReservedCacheNodesRequest : AmazonWebServiceRequest
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
        /// The reserved Cache Node identifier filter value. Specify this parameter to show only the reservation that matches the specified reservation
        /// ID.
        ///  
        /// </summary>
        public string ReservedCacheNodeId
        {
            get { return this.reservedCacheNodeId; }
            set { this.reservedCacheNodeId = value; }
        }

        /// <summary>
        /// Sets the ReservedCacheNodeId property
        /// </summary>
        /// <param name="reservedCacheNodeId">The value to set for the ReservedCacheNodeId property </param>
        /// <returns>this instance</returns>
        public DescribeReservedCacheNodesRequest WithReservedCacheNodeId(string reservedCacheNodeId)
        {
            this.reservedCacheNodeId = reservedCacheNodeId;
            return this;
        }
            

        // Check to see if ReservedCacheNodeId property is set
        internal bool IsSetReservedCacheNodeId()
        {
            return this.reservedCacheNodeId != null;       
        }

        /// <summary>
        /// The offering identifier filter value. Specify this parameter to show only purchased reservations matching the specified offering identifier.
        ///  
        /// </summary>
        public string ReservedCacheNodesOfferingId
        {
            get { return this.reservedCacheNodesOfferingId; }
            set { this.reservedCacheNodesOfferingId = value; }
        }

        /// <summary>
        /// Sets the ReservedCacheNodesOfferingId property
        /// </summary>
        /// <param name="reservedCacheNodesOfferingId">The value to set for the ReservedCacheNodesOfferingId property </param>
        /// <returns>this instance</returns>
        public DescribeReservedCacheNodesRequest WithReservedCacheNodesOfferingId(string reservedCacheNodesOfferingId)
        {
            this.reservedCacheNodesOfferingId = reservedCacheNodesOfferingId;
            return this;
        }
            

        // Check to see if ReservedCacheNodesOfferingId property is set
        internal bool IsSetReservedCacheNodesOfferingId()
        {
            return this.reservedCacheNodesOfferingId != null;       
        }

        /// <summary>
        /// The Cache Node type filter value. Specify this parameter to show only those reservations matching the specified Cache Nodes type.
        ///  
        /// </summary>
        public string CacheNodeType
        {
            get { return this.cacheNodeType; }
            set { this.cacheNodeType = value; }
        }

        /// <summary>
        /// Sets the CacheNodeType property
        /// </summary>
        /// <param name="cacheNodeType">The value to set for the CacheNodeType property </param>
        /// <returns>this instance</returns>
        public DescribeReservedCacheNodesRequest WithCacheNodeType(string cacheNodeType)
        {
            this.cacheNodeType = cacheNodeType;
            return this;
        }
            

        // Check to see if CacheNodeType property is set
        internal bool IsSetCacheNodeType()
        {
            return this.cacheNodeType != null;       
        }

        /// <summary>
        /// The duration filter value, specified in years or seconds. Specify this parameter to show only reservations for this duration. Valid Values:
        /// <c>1 | 3 | 31536000 | 94608000</c>
        ///  
        /// </summary>
        public string Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        /// <summary>
        /// Sets the Duration property
        /// </summary>
        /// <param name="duration">The value to set for the Duration property </param>
        /// <returns>this instance</returns>
        public DescribeReservedCacheNodesRequest WithDuration(string duration)
        {
            this.duration = duration;
            return this;
        }
            

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this.duration != null;       
        }

        /// <summary>
        /// The product description filter value. Specify this parameter to show only those reservations matching the specified product description.
        ///  
        /// </summary>
        public string ProductDescription
        {
            get { return this.productDescription; }
            set { this.productDescription = value; }
        }

        /// <summary>
        /// Sets the ProductDescription property
        /// </summary>
        /// <param name="productDescription">The value to set for the ProductDescription property </param>
        /// <returns>this instance</returns>
        public DescribeReservedCacheNodesRequest WithProductDescription(string productDescription)
        {
            this.productDescription = productDescription;
            return this;
        }
            

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this.productDescription != null;       
        }

        /// <summary>
        /// The offering type filter value. Specify this parameter to show only the available offerings matching the specified offering type. Valid
        /// Values: <c>"Light Utilization" | "Medium Utilization" | "Heavy Utilization" </c>
        ///  
        /// </summary>
        public string OfferingType
        {
            get { return this.offeringType; }
            set { this.offeringType = value; }
        }

        /// <summary>
        /// Sets the OfferingType property
        /// </summary>
        /// <param name="offeringType">The value to set for the OfferingType property </param>
        /// <returns>this instance</returns>
        public DescribeReservedCacheNodesRequest WithOfferingType(string offeringType)
        {
            this.offeringType = offeringType;
            return this;
        }
            

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this.offeringType != null;       
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more than the <c>MaxRecords</c> value is available, a marker is included in the
        /// response so that the following results can be retrieved. Default: 100 Constraints: minimum 20, maximum 100
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        public DescribeReservedCacheNodesRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;       
        }

        /// <summary>
        /// The marker provided in the previous request. If this parameter is specified, the response includes records beyond the marker only, up to
        /// <c>MaxRecords</c>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DescribeReservedCacheNodesRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;       
        }
    }
}
    
