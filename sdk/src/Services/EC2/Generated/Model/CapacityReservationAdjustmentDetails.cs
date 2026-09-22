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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the configuration that a Capacity Reservation will have after a pending
    /// adjustment is applied.
    /// </summary>
    public partial class CapacityReservationAdjustmentDetails
    {
        private long? _commitmentDuration;
        private DateTime? _commitmentEndDate;
        private DateTime? _endDate;
        private string _endDateType;
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property CommitmentDuration. 
        /// <para>
        /// The commitment duration, in seconds, that the Capacity Reservation will have after
        /// the adjustment.
        /// </para>
        /// </summary>
        public long? CommitmentDuration
        {
            get { return this._commitmentDuration; }
            set { this._commitmentDuration = value; }
        }

        // Check to see if CommitmentDuration property is set
        internal bool IsSetCommitmentDuration()
        {
            return this._commitmentDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CommitmentEndDate. 
        /// <para>
        /// The date and time at which the commitment duration will expire after the adjustment.
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
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date that the Capacity Reservation will have after the adjustment.
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
        /// Gets and sets the property EndDateType. 
        /// <para>
        /// Indicates the way in which the Capacity Reservation will end after the adjustment.
        /// Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>unlimited</c> - The Capacity Reservation remains active until you explicitly cancel
        /// it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>limited</c> - The Capacity Reservation expires automatically at the date and time
        /// given by <c>endDate</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string EndDateType
        {
            get { return this._endDateType; }
            set { this._endDateType = value; }
        }

        // Check to see if EndDateType property is set
        internal bool IsSetEndDateType()
        {
            return this._endDateType != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date that the Capacity Reservation will have after the adjustment.
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

    }
}