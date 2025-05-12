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
    /// Represents an Amazon Redshift Serverless reservation, which gives you the option to
    /// commit to a specified number of Redshift Processing Units (RPUs) for a year at a discount
    /// from Serverless on-demand (OD) rates.
    /// </summary>
    public partial class Reservation
    {
        private int? _capacity;
        private DateTime? _endDate;
        private ReservationOffering _offering;
        private string _reservationArn;
        private string _reservationId;
        private DateTime? _startDate;
        private string _status;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The number of Redshift Processing Units (RPUs) to reserve.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date for the serverless reservation. This date is one year after the start
        /// date that you specify.
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Offering. 
        /// <para>
        /// The type of offering for the reservation. The offering class determines the payment
        /// schedule for the reservation.
        /// </para>
        /// </summary>
        public ReservationOffering Offering
        {
            get { return this._offering; }
            set { this._offering = value; }
        }

        // Check to see if Offering property is set
        internal bool IsSetOffering()
        {
            return this._offering != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the serverless reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property ReservationId. 
        /// <para>
        /// The identifier that uniquely identifies the serverless reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date for the serverless reservation. This is the date you specified for
        /// the reservation to start when you created the reservation.
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the reservation. Possible values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>payment-pending</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>active</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>payment-failed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>retired</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}