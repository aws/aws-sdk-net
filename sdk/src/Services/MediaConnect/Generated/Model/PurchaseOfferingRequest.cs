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
    /// Container for the parameters to the PurchaseOffering operation.
    /// Submits a request to purchase an offering. If you already have an active reservation,
    /// you can't purchase another offering.
    /// </summary>
    public partial class PurchaseOfferingRequest : AmazonMediaConnectRequest
    {
        private string _offeringArn;
        private string _reservationName;
        private string _start;

        /// <summary>
        /// Gets and sets the property OfferingArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OfferingArn
        {
            get { return this._offeringArn; }
            set { this._offeringArn = value; }
        }

        // Check to see if OfferingArn property is set
        internal bool IsSetOfferingArn()
        {
            return this._offeringArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationName. 
        /// <para>
        ///  The name that you want to use for the reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Start. 
        /// <para>
        ///  The date and time that you want the reservation to begin, in Coordinated Universal
        /// Time (UTC). 
        /// </para>
        ///  
        /// <para>
        /// You can specify any date and time between 12:00am on the first day of the current
        /// month to the current time on today's date, inclusive. Specify the start in a 24-hour
        /// notation. Use the following format: <c>YYYY-MM-DDTHH:mm:SSZ</c>, where <c>T</c> and
        /// <c>Z</c> are literal characters. For example, to specify 11:30pm on March 5, 2020,
        /// enter <c>2020-03-05T23:30:00Z</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start != null;
        }

    }
}