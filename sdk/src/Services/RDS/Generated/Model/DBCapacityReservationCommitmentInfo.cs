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
    /// Contains the capacity commitment details of a DB capacity reservation, including the
    /// number of committed DB instances in each Availability Zone and the end date of the
    /// commitment period. Amazon RDS holds the committed capacity until the commitment ends.
    /// Amazon RDS rejects a request to cancel a reservation in the <c>active</c> state, and
    /// a request to reduce the reserved capacity below the commitment.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the following operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CancelDBCapacityReservation</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateDBCapacityReservation</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeDBCapacityReservations</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ModifyDBCapacityReservation</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DBCapacityReservationCommitmentInfo
    {
        private DateTime? _commitmentEndDate;
        private int? _committedCapacityPerAvailabilityZone;

        /// <summary>
        /// Gets and sets the property CommitmentEndDate. 
        /// <para>
        /// The date and time when the commitment ends, in Universal Coordinated Time (UTC). This
        /// date reports the capacity commitment that Amazon RDS granted.
        /// </para>
        ///  
        /// <para>
        /// Amazon RDS can grant a shorter capacity commitment than you request in <c>CommitmentDuration</c>.
        /// Therefore, this date can fall earlier than <c>StartDate</c> plus <c>CommitmentDuration</c>.
        /// </para>
        /// </summary>
        public DateTime? CommitmentEndDate
        {
            get { return this._commitmentEndDate; }
            set { this._commitmentEndDate = value; }
        }

        // Check to see if CommitmentEndDate property is set
        internal bool IsSetCommitmentEndDate()
        {
            return this._commitmentEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CommittedCapacityPerAvailabilityZone. 
        /// <para>
        /// The number of DB instances that Amazon RDS holds in each Availability Zone of the
        /// reservation for the length of the commitment.
        /// </para>
        /// </summary>
        public int? CommittedCapacityPerAvailabilityZone
        {
            get { return this._committedCapacityPerAvailabilityZone; }
            set { this._committedCapacityPerAvailabilityZone = value; }
        }

        // Check to see if CommittedCapacityPerAvailabilityZone property is set
        internal bool IsSetCommittedCapacityPerAvailabilityZone()
        {
            return this._committedCapacityPerAvailabilityZone.HasValue; 
        }

    }
}