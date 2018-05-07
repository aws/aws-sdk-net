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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedElasticsearchInstanceOffering operation.
    /// Allows you to purchase reserved Elasticsearch instances.
    /// </summary>
    public partial class PurchaseReservedElasticsearchInstanceOfferingRequest : AmazonElasticsearchRequest
    {
        private int? _instanceCount;
        private string _reservationName;
        private string _reservedElasticsearchInstanceOfferingId;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of Elasticsearch instances to reserve.
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservationName. 
        /// <para>
        /// A customer-specified identifier to track this reservation.
        /// </para>
        /// </summary>
        public string ReservationName
        {
            get { return this._reservationName; }
            set { this._reservationName = value; }
        }

        // Check to see if ReservationName property is set
        internal bool IsSetReservationName()
        {
            return this._reservationName != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedElasticsearchInstanceOfferingId. 
        /// <para>
        /// The ID of the reserved Elasticsearch instance offering to purchase.
        /// </para>
        /// </summary>
        public string ReservedElasticsearchInstanceOfferingId
        {
            get { return this._reservedElasticsearchInstanceOfferingId; }
            set { this._reservedElasticsearchInstanceOfferingId = value; }
        }

        // Check to see if ReservedElasticsearchInstanceOfferingId property is set
        internal bool IsSetReservedElasticsearchInstanceOfferingId()
        {
            return this._reservedElasticsearchInstanceOfferingId != null;
        }

    }
}