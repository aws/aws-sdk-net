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
    /// Information about your commitment for a future-dated Capacity Reservation.
    /// </summary>
    public partial class CapacityReservationCommitmentInfo
    {
        private DateTime? _commitmentEndDate;
        private int? _committedInstanceCount;

        /// <summary>
        /// Gets and sets the property CommitmentEndDate. 
        /// <para>
        /// The date and time at which the commitment duration expires, in the ISO8601 format
        /// in the UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>). You can't decrease the instance
        /// count or cancel the Capacity Reservation before this date and time.
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
        /// Gets and sets the property CommittedInstanceCount. 
        /// <para>
        /// The instance capacity that you committed to when you requested the future-dated Capacity
        /// Reservation.
        /// </para>
        /// </summary>
        public int? CommittedInstanceCount
        {
            get { return this._committedInstanceCount; }
            set { this._committedInstanceCount = value; }
        }

        // Check to see if CommittedInstanceCount property is set
        internal bool IsSetCommittedInstanceCount()
        {
            return this._committedInstanceCount.HasValue; 
        }

    }
}