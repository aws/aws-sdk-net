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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBCapacityReservation operation.
    /// Modifies a DB capacity reservation. You can change the reserved capacity in each Availability
    /// Zone of the reservation, and you can change the end date of the reservation. You can't
    /// change the Availability Zones of an existing reservation.
    /// 
    ///  
    /// <para>
    /// The reservation must be in the <c>active</c> state. A future-dated reservation that
    /// hasn't started isn't modifiable, and neither is a reservation that Amazon RDS is already
    /// modifying.
    /// </para>
    ///  
    /// <para>
    /// You must specify <c>CapacityPerAvailabilityZone</c>, <c>EndDateType</c>, or <c>EndDate</c>.
    /// A request that specifies none of the three changes nothing, and Amazon RDS rejects
    /// it.
    /// </para>
    /// </summary>
    public partial class ModifyDBCapacityReservationRequest : AmazonRDSRequest
    {
        private int? _capacityPerAvailabilityZone;
        private string _dbCapacityReservationIdentifier;
        private DateTime? _endDate;
        private EndDateType _endDateType;

        /// <summary>
        /// Gets and sets the property CapacityPerAvailabilityZone. 
        /// <para>
        /// The new number of DB instances to reserve in each Availability Zone of the reservation.
        /// Amazon RDS applies this number to every Availability Zone of the reservation.
        /// </para>
        ///  
        /// <para>
        /// An increase reserves more capacity at the time of the request, so it can fail when
        /// the Amazon Web Services Region has insufficient capacity.
        /// </para>
        ///  
        /// <para>
        /// This value multiplied by the number of Availability Zones counts against the DB instances
        /// quota for your Amazon Web Services account in the Amazon Web Services Region. Amazon
        /// RDS checks the quota only when you increase the value.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Minimum 1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be less than the highest number of DB instances that use the reservation in
        /// any single Availability Zone of the reservation. That number includes a DB instance
        /// that holds a unit of reserved capacity for a pending modification. To find that number
        /// for an Availability Zone, subtract <c>AvailableCapacity</c> from <c>ReservedCapacityPerAvailabilityZone</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// During a capacity commitment, can't be less than <c>CommittedCapacityPerAvailabilityZone</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? CapacityPerAvailabilityZone
        {
            get { return this._capacityPerAvailabilityZone; }
            set { this._capacityPerAvailabilityZone = value; }
        }

        // Check to see if CapacityPerAvailabilityZone property is set
        internal bool IsSetCapacityPerAvailabilityZone()
        {
            return this._capacityPerAvailabilityZone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBCapacityReservationIdentifier. 
        /// <para>
        /// The identifier or the name of the DB capacity reservation to modify. You can specify
        /// the identifier, which has the prefix <c>dbcr-</c>, or the reservation name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DBCapacityReservationIdentifier
        {
            get { return this._dbCapacityReservationIdentifier; }
            set { this._dbCapacityReservationIdentifier = value; }
        }

        // Check to see if DBCapacityReservationIdentifier property is set
        internal bool IsSetDBCapacityReservationIdentifier()
        {
            return this._dbCapacityReservationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The new end date for the reservation, in Universal Coordinated Time (UTC). Required
        /// when <c>EndDateType</c> is <c>limited</c>. Don't specify a value when <c>EndDateType</c>
        /// is <c>unlimited</c>.
        /// </para>
        ///  
        /// <para>
        /// When you specify <c>EndDate</c>, you must also specify <c>EndDateType</c>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a date and time in the future.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// During a capacity commitment, must be at or after <c>CommitmentEndDate</c>.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property EndDateType. 
        /// <para>
        /// The end date type for the reservation.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>limited</c> - The reservation has a specific end date. You must also specify <c>EndDate</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unlimited</c> - The reservation doesn't expire. Don't specify <c>EndDate</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndDateType EndDateType
        {
            get { return this._endDateType; }
            set { this._endDateType = value; }
        }

        // Check to see if EndDateType property is set
        internal bool IsSetEndDateType()
        {
            return this._endDateType != null;
        }

    }
}