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
    /// Container for the parameters to the CreateCapacityReservation operation.
    /// Creates a new Capacity Reservation with the specified attributes. Capacity Reservations
    /// enable you to reserve capacity for your Amazon EC2 instances in a specific Availability
    /// Zone for any duration.
    /// 
    ///  
    /// <para>
    /// You can create a Capacity Reservation at any time, and you can choose when it starts.
    /// You can create a Capacity Reservation for immediate use or you can request a Capacity
    /// Reservation for a future date.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-capacity-reservations.html">
    /// Reserve compute capacity with On-Demand Capacity Reservations</a> in the <i>Amazon
    /// EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Your request to create a Capacity Reservation could fail if:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon EC2 does not have sufficient capacity. In this case, try again at a later time,
    /// try in a different Availability Zone, or request a smaller Capacity Reservation. If
    /// your workload is flexible across instance types and sizes, try with different instance
    /// attributes.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The requested quantity exceeds your On-Demand Instance quota. In this case, increase
    /// your On-Demand Instance quota for the requested instance type and try again. For more
    /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-resource-limits.html">
    /// Amazon EC2 Service Quotas</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateCapacityReservationRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _clientToken;
        private long? _commitmentDuration;
        private CapacityReservationDeliveryPreference _deliveryPreference;
        private bool? _dryRun;
        private bool? _ebsOptimized;
        private DateTime? _endDate;
        private EndDateType _endDateType;
        private bool? _ephemeralStorage;
        private int? _instanceCount;
        private InstanceMatchCriteria _instanceMatchCriteria;
        private CapacityReservationInstancePlatform _instancePlatform;
        private string _instanceType;
        private string _outpostArn;
        private string _placementGroupArn;
        private DateTime? _startDate;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private CapacityReservationTenancy _tenancy;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to create the Capacity Reservation.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone in which to create the Capacity Reservation.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
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
        /// Gets and sets the property CommitmentDuration. <note> 
        /// <para>
        /// Required for future-dated Capacity Reservations only. To create a Capacity Reservation
        /// for immediate use, omit this parameter. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Specify a commitment duration, in seconds, for the future-dated Capacity Reservation.
        /// </para>
        ///  
        /// <para>
        /// The commitment duration is a minimum duration for which you commit to having the future-dated
        /// Capacity Reservation in the <c>active</c> state in your account after it has been
        /// delivered.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cr-concepts.html#cr-commitment-duration">
        /// Commitment duration</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200000000)]
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
        /// Gets and sets the property DeliveryPreference. <note> 
        /// <para>
        /// Required for future-dated Capacity Reservations only. To create a Capacity Reservation
        /// for immediate use, omit this parameter. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Indicates that the requested capacity will be delivered in addition to any running
        /// instances or reserved capacity that you have in your account at the requested date
        /// and time.
        /// </para>
        ///  
        /// <para>
        /// The only supported value is <c>incremental</c>.
        /// </para>
        /// </summary>
        public CapacityReservationDeliveryPreference DeliveryPreference
        {
            get { return this._deliveryPreference; }
            set { this._deliveryPreference = value; }
        }

        // Check to see if DeliveryPreference property is set
        internal bool IsSetDeliveryPreference()
        {
            return this._deliveryPreference != null;
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
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether the Capacity Reservation supports EBS-optimized instances. This
        /// optimization provides dedicated throughput to Amazon EBS and an optimized configuration
        /// stack to provide optimal I/O performance. This optimization isn't available with all
        /// instance types. Additional usage charges apply when using an EBS- optimized instance.
        /// </para>
        /// </summary>
        public bool? EbsOptimized
        {
            get { return this._ebsOptimized; }
            set { this._ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation expires. When a Capacity Reservation
        /// expires, the reserved capacity is released and you can no longer launch instances
        /// into it. The Capacity Reservation's state changes to <c>expired</c> when it reaches
        /// its end date and time.
        /// </para>
        ///  
        /// <para>
        /// You must provide an <c>EndDate</c> value if <c>EndDateType</c> is <c>limited</c>.
        /// Omit <c>EndDate</c> if <c>EndDateType</c> is <c>unlimited</c>.
        /// </para>
        ///  
        /// <para>
        /// If the <c>EndDateType</c> is <c>limited</c>, the Capacity Reservation is cancelled
        /// within an hour from the specified time. For example, if you specify 5/31/2019, 13:30:55,
        /// the Capacity Reservation is guaranteed to end between 13:30:55 and 14:30:55 on 5/31/2019.
        /// </para>
        ///  
        /// <para>
        /// If you are requesting a future-dated Capacity Reservation, you can't specify an end
        /// date and time that is within the commitment duration.
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
        /// Indicates the way in which the Capacity Reservation ends. A Capacity Reservation can
        /// have one of the following end types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>unlimited</c> - The Capacity Reservation remains active until you explicitly cancel
        /// it. Do not provide an <c>EndDate</c> if the <c>EndDateType</c> is <c>unlimited</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>limited</c> - The Capacity Reservation expires automatically at a specified date
        /// and time. You must provide an <c>EndDate</c> value if the <c>EndDateType</c> value
        /// is <c>limited</c>.
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

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        ///  <i>Deprecated.</i> 
        /// </para>
        /// </summary>
        public bool? EphemeralStorage
        {
            get { return this._ephemeralStorage; }
            set { this._ephemeralStorage = value; }
        }

        // Check to see if EphemeralStorage property is set
        internal bool IsSetEphemeralStorage()
        {
            return this._ephemeralStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances for which to reserve capacity.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can request future-dated Capacity Reservations for an instance count with a minimum
        /// of 64 vCPUs. For example, if you request a future-dated Capacity Reservation for <c>m5.xlarge</c>
        /// instances, you must request at least 25 instances (<i>16 * m5.xlarge = 64 vCPUs</i>).
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid range: 1 - 1000
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceMatchCriteria. 
        /// <para>
        /// Indicates the type of instance launches that the Capacity Reservation accepts. The
        /// options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>open</c> - The Capacity Reservation automatically matches all instances that have
        /// matching attributes (instance type, platform, and Availability Zone). Instances that
        /// have matching attributes run in the Capacity Reservation automatically without specifying
        /// any additional parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>targeted</c> - The Capacity Reservation only accepts instances that have matching
        /// attributes (instance type, platform, and Availability Zone), and explicitly target
        /// the Capacity Reservation. This ensures that only permitted instances can use the reserved
        /// capacity. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you are requesting a future-dated Capacity Reservation, you must specify <c>targeted</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>open</c> 
        /// </para>
        /// </summary>
        public InstanceMatchCriteria InstanceMatchCriteria
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
        /// Gets and sets the property InstancePlatform. 
        /// <para>
        /// The type of operating system for which to reserve capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityReservationInstancePlatform InstancePlatform
        {
            get { return this._instancePlatform; }
            set { this._instancePlatform = value; }
        }

        // Check to see if InstancePlatform property is set
        internal bool IsSetInstancePlatform()
        {
            return this._instancePlatform != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for which to reserve capacity.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can request future-dated Capacity Reservations for instance types in the C, M,
        /// R, I, T, and G instance families only.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. <note> 
        /// <para>
        /// Not supported for future-dated Capacity Reservations.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost on which to create the Capacity Reservation.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property PlacementGroupArn. <note> 
        /// <para>
        /// Not supported for future-dated Capacity Reservations.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster placement group in which to create the
        /// Capacity Reservation. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cr-cpg.html">
        /// Capacity Reservations for cluster placement groups</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PlacementGroupArn
        {
            get { return this._placementGroupArn; }
            set { this._placementGroupArn = value; }
        }

        // Check to see if PlacementGroupArn property is set
        internal bool IsSetPlacementGroupArn()
        {
            return this._placementGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. <note> 
        /// <para>
        /// Required for future-dated Capacity Reservations only. To create a Capacity Reservation
        /// for immediate use, omit this parameter. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The date and time at which the future-dated Capacity Reservation should become available
        /// for use, in the ISO8601 format in the UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        ///  
        /// <para>
        /// You can request a future-dated Capacity Reservation between 5 and 120 days in advance.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the Capacity Reservation during launch.
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
        /// Indicates the tenancy of the Capacity Reservation. A Capacity Reservation can have
        /// one of the following tenancy settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>default</c> - The Capacity Reservation is created on hardware that is shared with
        /// other Amazon Web Services accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dedicated</c> - The Capacity Reservation is created on single-tenant hardware
        /// that is dedicated to a single Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityReservationTenancy Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

    }
}