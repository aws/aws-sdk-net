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
    /// Container for the parameters to the CreateCapacityReservationFleet operation.
    /// Creates a Capacity Reservation Fleet. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/work-with-cr-fleets.html#create-crfleet">Create
    /// a Capacity Reservation Fleet</a> in the Amazon EC2 User Guide.
    /// </summary>
    public partial class CreateCapacityReservationFleetRequest : AmazonEC2Request
    {
        private string _allocationStrategy;
        private string _clientToken;
        private DateTime? _endDate;
        private FleetInstanceMatchCriteria _instanceMatchCriteria;
        private List<ReservationFleetInstanceSpecification> _instanceTypeSpecifications = new List<ReservationFleetInstanceSpecification>();
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private FleetCapacityReservationTenancy _tenancy;
        private int? _totalTargetCapacity;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The strategy used by the Capacity Reservation Fleet to determine which of the specified
        /// instance types to use. Currently, only the <code>prioritized</code> allocation strategy
        /// is supported. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/crfleet-concepts.html#allocation-strategy">
        /// Allocation strategy</a> in the Amazon EC2 User Guide.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>prioritized</code> 
        /// </para>
        /// </summary>
        public string AllocationStrategy
        {
            get { return this._allocationStrategy; }
            set { this._allocationStrategy = value; }
        }

        // Check to see if AllocationStrategy property is set
        internal bool IsSetAllocationStrategy()
        {
            return this._allocationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensure
        /// Idempotency</a>.
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
        /// Gets and sets the property InstanceMatchCriteria. 
        /// <para>
        /// Indicates the type of instance launches that the Capacity Reservation Fleet accepts.
        /// All Capacity Reservations in the Fleet inherit this instance matching criteria.
        /// </para>
        ///  
        /// <para>
        /// Currently, Capacity Reservation Fleets support <code>open</code> instance matching
        /// criteria only. This means that instances that have matching attributes (instance type,
        /// platform, and Availability Zone) run in the Capacity Reservations automatically. Instances
        /// do not need to explicitly target a Capacity Reservation Fleet to use its reserved
        /// capacity.
        /// </para>
        /// </summary>
        public FleetInstanceMatchCriteria InstanceMatchCriteria
        {
            get { return this._instanceMatchCriteria; }
            set { this._instanceMatchCriteria = value; }
        }

        // Check to see if InstanceMatchCriteria property is set
        internal bool IsSetInstanceMatchCriteria()
        {
            return this._instanceMatchCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypeSpecifications. 
        /// <para>
        /// Information about the instance types for which to reserve the capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ReservationFleetInstanceSpecification> InstanceTypeSpecifications
        {
            get { return this._instanceTypeSpecifications; }
            set { this._instanceTypeSpecifications = value; }
        }

        // Check to see if InstanceTypeSpecifications property is set
        internal bool IsSetInstanceTypeSpecifications()
        {
            return this._instanceTypeSpecifications != null && this._instanceTypeSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the Capacity Reservation Fleet. The tags are automatically assigned
        /// to the Capacity Reservations in the Fleet.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Indicates the tenancy of the Capacity Reservation Fleet. All Capacity Reservations
        /// in the Fleet inherit this tenancy. The Capacity Reservation Fleet can have one of
        /// the following tenancy settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>default</code> - The Capacity Reservation Fleet is created on hardware that
        /// is shared with other Amazon Web Services accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dedicated</code> - The Capacity Reservations are created on single-tenant hardware
        /// that is dedicated to a single Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FleetCapacityReservationTenancy Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

        /// <summary>
        /// Gets and sets the property TotalTargetCapacity. 
        /// <para>
        /// The total number of capacity units to be reserved by the Capacity Reservation Fleet.
        /// This value, together with the instance type weights that you assign to each instance
        /// type used by the Fleet determine the number of instances for which the Fleet reserves
        /// capacity. Both values are based on units that make sense for your workload. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/crfleet-concepts.html#target-capacity">
        /// Total target capacity</a> in the Amazon EC2 User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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