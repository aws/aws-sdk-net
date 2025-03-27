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
    /// Container for the parameters to the DescribeReservation operation.
    /// Displays the details of a reservation. The response includes the reservation name,
    /// state, start date and time, and the details of the offering that make up the rest
    /// of the reservation (such as price, duration, and outbound bandwidth).
    /// </summary>
    public partial class DescribeReservationRequest : AmazonMediaConnectRequest
    {
        private string _reservationArn;

        /// <summary>
        /// Gets and sets the property ReservationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the offering. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReservationArn
        {
            get { return this._reservationArn; }
            set { this._reservationArn = value; }
        }

        // Check to see if ReservationArn property is set
        internal bool IsSetReservationArn()
        {
            return this._reservationArn != null;
        }

    }
}