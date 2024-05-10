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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedInstanceOffering operation.
    /// Allows you to purchase Amazon OpenSearch Service Reserved Instances.
    /// </summary>
    public partial class PurchaseReservedInstanceOfferingRequest : AmazonOpenSearchServiceRequest
    {
        private int? _instanceCount;
        private string _reservationName;
        private string _reservedInstanceOfferingId;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of OpenSearch instances to reserve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? InstanceCount
        {
            get { return this._instanceCount; }
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
        [AWSProperty(Required=true, Min=5, Max=64)]
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
        /// Gets and sets the property ReservedInstanceOfferingId. 
        /// <para>
        /// The ID of the Reserved Instance offering to purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ReservedInstanceOfferingId
        {
            get { return this._reservedInstanceOfferingId; }
            set { this._reservedInstanceOfferingId = value; }
        }

        // Check to see if ReservedInstanceOfferingId property is set
        internal bool IsSetReservedInstanceOfferingId()
        {
            return this._reservedInstanceOfferingId != null;
        }

    }
}