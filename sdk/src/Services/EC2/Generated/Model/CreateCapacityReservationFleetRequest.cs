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
    /// Container for the parameters to the CreateCapacityReservationFleet operation.
    /// Creates a Capacity Reservation Fleet. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/work-with-cr-fleets.html#create-crfleet">Create
    /// a Capacity Reservation Fleet</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class CreateCapacityReservationFleetRequest : AmazonEC2Request
    {
        private string _allocationStrategy;
        private string _clientToken;
        private bool? _dryRun;
        private DateTime? _endDate;
        private FleetInstanceMatchCriteria _instanceMatchCriteria;
        private List<ReservationFleetInstanceSpecification> _instanceTypeSpecifications = AWSConfigs.InitializeCollections ? new List<ReservationFleetInstanceSpecification>() : null;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private FleetCapacityReservationTenancy _tenancy;
        private int? _totalTargetCapacity;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The strategy used by the Capacity Reservation Fleet to determine which of the specified
        /// instance types to use. Currently, only the <c>prioritized</c> allocation strategy
        /// is supported. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/crfleet-concepts.html#allocation-strategy">
        /// Allocation strategy</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>prioritized</c> 
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation Fleet expires. When the Capacity
        /// Reservation Fleet expires, its state changes to <c>expired</c> and all of the Capacity
        /// Reservations in the Fleet expire.
        /// </para>
        ///  
        /// <para>
        /// The Capacity Reservation Fleet expires within an hour after the specified time. For
        /// example, if you specify <c>5/31/2019</c>, <c>13:30:55</c>, the Capacity Reservation
        /// Fleet is guaranteed to expire between <c>13:30:55</c> and <c>14:30:55</c> on <c>5/31/2019</c>.
        /// 
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
        /// Gets and sets the property InstanceMatchCriteria. 
        /// <para>
        /// Indicates the type of instance launches that the Capacity Reservation Fleet accepts.
        /// All Capacity Reservations in the Fleet inherit this instance matching criteria.
        /// </para>
        ///  
        /// <para>
        /// Currently, Capacity Reservation Fleets support <c>open</c> instance matching criteria
        /// only. This means that instances that have matching attributes (instance type, platform,
        /// and Availability Zone) run in the Capacity Reservations automatically. Instances do
        /// not need to explicitly target a Capacity Reservation Fleet to use its reserved capacity.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._instanceTypeSpecifications != null && (this._instanceTypeSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the Capacity Reservation Fleet. The tags are automatically assigned
        /// to the Capacity Reservations in the Fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        ///  <c>default</c> - The Capacity Reservation Fleet is created on hardware that is shared
        /// with other Amazon Web Services accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dedicated</c> - The Capacity Reservations are created on single-tenant hardware
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
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/crfleet-concepts.html#target-capacity">Total
        /// target capacity</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalTargetCapacity
        {
            get { return this._totalTargetCapacity; }
            set { this._totalTargetCapacity = value; }
        }

        // Check to see if TotalTargetCapacity property is set
        internal bool IsSetTotalTargetCapacity()
        {
            return this._totalTargetCapacity.HasValue; 
        }

    }
}