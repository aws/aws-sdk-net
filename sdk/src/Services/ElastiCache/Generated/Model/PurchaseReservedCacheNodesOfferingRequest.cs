/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedCacheNodesOffering operation.
    /// Allows you to purchase a reserved cache node offering. Reserved nodes are not eligible
    /// for cancellation and are non-refundable. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/reserved-nodes.html">Managing
    /// Costs with Reserved Nodes</a>.
    /// </summary>
    public partial class PurchaseReservedCacheNodesOfferingRequest : AmazonElastiCacheRequest
    {
        private int? _cacheNodeCount;
        private string _reservedCacheNodeId;
        private string _reservedCacheNodesOfferingId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CacheNodeCount. 
        /// <para>
        /// The number of cache node instances to reserve.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1</c> 
        /// </para>
        /// </summary>
        public int? CacheNodeCount
        {
            get { return this._cacheNodeCount; }
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
        ///  <note> 
        /// <para>
        /// The Reserved Cache Node ID is an unique customer-specified identifier to track this
        /// reservation. If this parameter is not specified, ElastiCache automatically generates
        /// an identifier for the reservation.
        /// </para>
        ///  </note> 
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
        /// Example: <c>438012d3-4052-4cc7-b2e3-8d3372e0e706</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. A tag is a key-value pair. A tag key
        /// must be accompanied by a tag value, although null is accepted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}