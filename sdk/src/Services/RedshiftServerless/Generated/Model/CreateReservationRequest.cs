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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReservation operation.
    /// Creates an Amazon Redshift Serverless reservation, which gives you the option to commit
    /// to a specified number of Redshift Processing Units (RPUs) for a year at a discount
    /// from Serverless on-demand (OD) rates.
    /// </summary>
    public partial class CreateReservationRequest : AmazonRedshiftServerlessRequest
    {
        private int? _capacity;
        private string _clientToken;
        private string _offeringId;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The number of Redshift Processing Units (RPUs) to reserve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. This
        /// token must be a valid UUIDv4 value. For more information about idempotency, see <a
        /// href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">
        /// Making retries safe with idempotent APIs </a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The ID of the offering associated with the reservation. The offering determines the
        /// payment schedule for the reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string OfferingId
        {
            get { return this._offeringId; }
            set { this._offeringId = value; }
        }

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this._offeringId != null;
        }

    }
}