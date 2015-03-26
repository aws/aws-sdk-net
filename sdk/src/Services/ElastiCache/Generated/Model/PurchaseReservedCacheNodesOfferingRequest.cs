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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
    /// The <i>PurchaseReservedCacheNodesOffering</i> action allows you to purchase a reserved
    /// cache node offering.
    /// </summary>
    public partial class PurchaseReservedCacheNodesOfferingRequest : AmazonElastiCacheRequest
    {
        private int? _cacheNodeCount;
        private string _reservedCacheNodeId;
        private string _reservedCacheNodesOfferingId;

        /// <summary>
        /// Gets and sets the property CacheNodeCount. 
        /// <para>
        /// The number of cache node instances to reserve.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>1</code>
        /// </para>
        /// </summary>
        public int CacheNodeCount
        {
            get { return this._cacheNodeCount.GetValueOrDefault(); }
            set { this._cacheNodeCount = value; }
        }

        // Check to see if CacheNodeCount property is set
        internal bool IsSetCacheNodeCount()
        {
            return this._cacheNodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservedCacheNodeId. 
        /// <para>
        /// A customer-specified identifier to track this reservation.
        /// </para>
        ///  
        /// <para>
        /// Example: myreservationID
        /// </para>
        /// </summary>
        public string ReservedCacheNodeId
        {
            get { return this._reservedCacheNodeId; }
            set { this._reservedCacheNodeId = value; }
        }

        // Check to see if ReservedCacheNodeId property is set
        internal bool IsSetReservedCacheNodeId()
        {
            return this._reservedCacheNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedCacheNodesOfferingId. 
        /// <para>
        /// The ID of the reserved cache node offering to purchase.
        /// </para>
        ///  
        /// <para>
        /// Example: 438012d3-4052-4cc7-b2e3-8d3372e0e706
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