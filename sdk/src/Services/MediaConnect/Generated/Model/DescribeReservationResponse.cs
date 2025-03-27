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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeReservation operation.
    /// </summary>
    public partial class DescribeReservationResponse : AmazonWebServiceResponse
    {
        private Reservation _reservation;

        /// <summary>
        /// Gets and sets the property Reservation. 
        /// <para>
        ///  A pricing agreement for a discounted rate for a specific outbound bandwidth that
        /// your MediaConnect account will use each month over a specific time period. The discounted
        /// rate in the reservation applies to outbound bandwidth for all flows from your account
        /// until your account reaches the amount of bandwidth in your reservation. If you use
        /// more outbound bandwidth than the agreed upon amount in a single month, the overage
        /// is charged at the on-demand rate. 
        /// </para>
        /// </summary>
        public Reservation Reservation
        {
            get { return this._reservation; }
            set { this._reservation = value; }
        }

        // Check to see if Reservation property is set
        internal bool IsSetReservation()
        {
            return this._reservation != null;
        }

    }
}