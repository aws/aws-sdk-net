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
    /// Represents the output of a <code>PurchaseReservedElasticsearchInstanceOffering</code>
    /// operation.
    /// </summary>
    public partial class PurchaseReservedElasticsearchInstanceOfferingResponse : AmazonWebServiceResponse
    {
        private string _reservationName;
        private string _reservedElasticsearchInstanceId;

        /// <summary>
        /// Gets and sets the property ReservationName. 
        /// <para>
        /// The customer-specified identifier used to track this reservation.
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
        /// Gets and sets the property ReservedElasticsearchInstanceId. 
        /// <para>
        /// Details of the reserved Elasticsearch instance which was purchased.
        /// </para>
        /// </summary>
        public string ReservedElasticsearchInstanceId
        {
            get { return this._reservedElasticsearchInstanceId; }
            set { this._reservedElasticsearchInstanceId = value; }
        }

        // Check to see if ReservedElasticsearchInstanceId property is set
        internal bool IsSetReservedElasticsearchInstanceId()
        {
            return this._reservedElasticsearchInstanceId != null;
        }

    }
}