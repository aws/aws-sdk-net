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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedElasticsearchInstanceOffering
    /// operation. Allows you to purchase reserved Elasticsearch instances.
    /// </summary>
    public partial class PurchaseReservedElasticsearchInstanceOfferingRequest : AmazonElasticsearchRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of Elasticsearch instances to reserve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ReservationName. 
        /// <para>
        /// A customer-specified identifier to track this reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 64)]
        public string ReservationName { get; set; }

        /// <summary>
        /// Checks to see if the ReservationName property is set.
        /// </summary>
        internal bool IsSetReservationName() => this.ReservationName != null;

        /// <summary>
        /// Gets and sets the property ReservedElasticsearchInstanceOfferingId. 
        /// <para>
        /// The ID of the reserved Elasticsearch instance offering to purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReservedElasticsearchInstanceOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedElasticsearchInstanceOfferingId property is set.
        /// </summary>
        internal bool IsSetReservedElasticsearchInstanceOfferingId() => this.ReservedElasticsearchInstanceOfferingId != null;
    }
}
