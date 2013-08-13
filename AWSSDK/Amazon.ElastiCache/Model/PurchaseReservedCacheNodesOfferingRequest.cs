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
    /// Container for the parameters to the PurchaseReservedCacheNodesOffering operation.
    /// <para> Purchases a reserved Cache Node offering. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.PurchaseReservedCacheNodesOffering"/>
    public class PurchaseReservedCacheNodesOfferingRequest : AmazonWebServiceRequest
    {
        private string reservedCacheNodesOfferingId;
        private string reservedCacheNodeId;
        private int? cacheNodeCount;

        /// <summary>
        /// The ID of the Reserved Cache Node offering to purchase. Example: 438012d3-4052-4cc7-b2e3-8d3372e0e706
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PurchaseReservedCacheNodesOfferingRequest WithReservedCacheNodesOfferingId(string reservedCacheNodesOfferingId)
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
        /// Customer-specified identifier to track this reservation. Example: myreservationID
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PurchaseReservedCacheNodesOfferingRequest WithReservedCacheNodeId(string reservedCacheNodeId)
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
        /// The number of instances to reserve. Default: <c>1</c>
        ///  
        /// </summary>
        public int CacheNodeCount
        {
            get { return this.cacheNodeCount ?? default(int); }
            set { this.cacheNodeCount = value; }
        }

        /// <summary>
        /// Sets the CacheNodeCount property
        /// </summary>
        /// <param name="cacheNodeCount">The value to set for the CacheNodeCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PurchaseReservedCacheNodesOfferingRequest WithCacheNodeCount(int cacheNodeCount)
        {
            this.cacheNodeCount = cacheNodeCount;
            return this;
        }
            

        // Check to see if CacheNodeCount property is set
        internal bool IsSetCacheNodeCount()
        {
            return this.cacheNodeCount.HasValue;
        }
    }
}
    
