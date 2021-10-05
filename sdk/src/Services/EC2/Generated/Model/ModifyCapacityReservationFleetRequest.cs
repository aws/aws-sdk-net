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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyCapacityReservationFleet operation.
    /// Modifies a Capacity Reservation Fleet.
    /// 
    ///  
    /// <para>
    /// When you modify the total target capacity of a Capacity Reservation Fleet, the Fleet
    /// automatically creates new Capacity Reservations, or modifies or cancels existing Capacity
    /// Reservations in the Fleet to meet the new total target capacity. When you modify the
    /// end date for the Fleet, the end dates for all of the individual Capacity Reservations
    /// in the Fleet are updated accordingly.
    /// </para>
    /// </summary>
    public partial class ModifyCapacityReservationFleetRequest : AmazonEC2Request
    {
        private string _capacityReservationFleetId;
        private DateTime? _endDate;
        private bool? _removeEndDate;
        private int? _totalTargetCapacity;

        /// <summary>
        /// Gets and sets the property CapacityReservationFleetId. 
        /// <para>
        /// The ID of the Capacity Reservation Fleet to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapacityReservationFleetId
        {
            get { return this._capacityReservationFleetId; }
            set { this._capacityReservationFleetId = value; }
        }

        // Check to see if CapacityReservationFleetId property is set
        internal bool IsSetCapacityReservationFleetId()
        {
            return this._capacityReservationFleetId != null;
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation Fleet expires. When the Capacity
        /// Reservation Fleet expires, its state changes to <code>expired</code> and all of the
        /// Capacity Reservations in the Fleet expire.
        /// </para>
        ///  
        /// <para>
        /// The Capacity Reservation Fleet expires within an hour after the specified time. For
        /// example, if you specify <code>5/31/2019</code>, <code>13:30:55</code>, the Capacity
        /// Reservation Fleet is guaranteed to expire between <code>13:30:55</code> and <code>14:30:55</code>
        /// on <code>5/31/2019</code>.
        /// </para>
        ///  
        /// <para>
        /// You can't specify <b>EndDate</b> and <b> RemoveEndDate</b> in the same request.
        /// </para>
        /// </summary>
        public DateTime EndDate
        {
            get { return this._endDate.GetValueOrDefault(); }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveEndDate. 
        /// <para>
        /// Indicates whether to remove the end date from the Capacity Reservation Fleet. If you
        /// remove the end date, the Capacity Reservation Fleet does not expire and it remains
        /// active until you explicitly cancel it using the <b>CancelCapacityReservationFleet</b>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// You can't specify <b>RemoveEndDate</b> and <b> EndDate</b> in the same request.
        /// </para>
        /// </summary>
        public bool RemoveEndDate
        {
            get { return this._removeEndDate.GetValueOrDefault(); }
            set { this._removeEndDate = value; }
        }

        // Check to see if RemoveEndDate property is set
        internal bool IsSetRemoveEndDate()
        {
            return this._removeEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalTargetCapacity. 
        /// <para>
        /// The total number of capacity units to be reserved by the Capacity Reservation Fleet.
        /// This value, together with the instance type weights that you assign to each instance
        /// type used by the Fleet determine the number of instances for which the Fleet reserves
        /// capacity. Both values are based on units that make sense for your workload. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/crfleet-concepts.html#target-capacity">Total
        /// target capacity</a> in the Amazon EC2 User Guide.
        /// </para>
        /// </summary>
        public int TotalTargetCapacity
        {
            get { return this._totalTargetCapacity.GetValueOrDefault(); }
            set { this._totalTargetCapacity = value; }
        }

        // Check to see if TotalTargetCapacity property is set
        internal bool IsSetTotalTargetCapacity()
        {
            return this._totalTargetCapacity.HasValue; 
        }

    }
}