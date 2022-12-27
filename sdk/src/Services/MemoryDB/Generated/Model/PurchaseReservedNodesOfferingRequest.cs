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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedNodesOffering operation.
    /// Allows you to purchase a reserved node offering. Reserved nodes are not eligible for
    /// cancellation and are non-refundable.
    /// </summary>
    public partial class PurchaseReservedNodesOfferingRequest : AmazonMemoryDBRequest
    {
        private int? _nodeCount;
        private string _reservationId;
        private string _reservedNodesOfferingId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property NodeCount. 
        /// <para>
        /// The number of node instances to reserve.
        /// </para>
        /// </summary>
        public int NodeCount
        {
            get { return this._nodeCount.GetValueOrDefault(); }
            set { this._nodeCount = value; }
        }

        // Check to see if NodeCount property is set
        internal bool IsSetNodeCount()
        {
            return this._nodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservationId. 
        /// <para>
        /// A customer-specified identifier to track this reservation.
        /// </para>
        /// </summary>
        public string ReservationId
        {
            get { return this._reservationId; }
            set { this._reservationId = value; }
        }

        // Check to see if ReservationId property is set
        internal bool IsSetReservationId()
        {
            return this._reservationId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedNodesOfferingId. 
        /// <para>
        /// The ID of the reserved node offering to purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReservedNodesOfferingId
        {
            get { return this._reservedNodesOfferingId; }
            set { this._reservedNodesOfferingId = value; }
        }

        // Check to see if ReservedNodesOfferingId property is set
        internal bool IsSetReservedNodesOfferingId()
        {
            return this._reservedNodesOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. A tag is a key-value pair. A tag key
        /// must be accompanied by a tag value, although null is accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}