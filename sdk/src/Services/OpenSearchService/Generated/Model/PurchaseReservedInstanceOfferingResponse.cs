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
    /// Represents the output of a <c>PurchaseReservedInstanceOffering</c> operation.
    /// </summary>
    public partial class PurchaseReservedInstanceOfferingResponse : AmazonWebServiceResponse
    {
        private string _reservationName;
        private string _reservedInstanceId;

        /// <summary>
        /// Gets and sets the property ReservationName. 
        /// <para>
        /// The customer-specified identifier used to track this reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=64)]
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
        /// Gets and sets the property ReservedInstanceId. 
        /// <para>
        /// The ID of the Reserved Instance offering that was purchased.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ReservedInstanceId
        {
            get { return this._reservedInstanceId; }
            set { this._reservedInstanceId = value; }
        }

        // Check to see if ReservedInstanceId property is set
        internal bool IsSetReservedInstanceId()
        {
            return this._reservedInstanceId != null;
        }

    }
}