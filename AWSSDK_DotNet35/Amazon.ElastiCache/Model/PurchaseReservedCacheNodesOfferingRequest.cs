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
    /// <para>The <i>PurchaseReservedCacheNodesOffering</i> operation allows you to purchase a reserved cache node offering.</para>
    /// </summary>
    public partial class PurchaseReservedCacheNodesOfferingRequest : AmazonElastiCacheRequest
    {
        private string reservedCacheNodesOfferingId;
        private string reservedCacheNodeId;
        private int? cacheNodeCount;


        /// <summary>
        /// The ID of the reserved cache node offering to purchase. Example: 438012d3-4052-4cc7-b2e3-8d3372e0e706
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
        /// A customer-specified identifier to track this reservation. Example: myreservationID
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
        /// The number of cache node instances to reserve. Default: <c>1</c>
        ///  
        /// </summary>
        public int CacheNodeCount
        {
            get { return this.cacheNodeCount ?? default(int); }
            set { this.cacheNodeCount = value; }
        }

        // Check to see if CacheNodeCount property is set
        internal bool IsSetCacheNodeCount()
        {
            return this.cacheNodeCount.HasValue;
        }

    }
}
    
