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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Represents dimension values for capacity metrics, including resource identifiers,
    /// geographic information, and reservation details used for grouping and filtering capacity
    /// data.
    /// </summary>
    public partial class CapacityManagerDimension
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID that owns the capacity resource. 
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        ///  The name of the Amazon Web Services account that owns the capacity resource. This
        /// dimension is only available when Organizations access is enabled for Capacity Manager.
        /// 
        /// </para>
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        ///  The unique identifier of the Availability Zone where the capacity resource is located.
        /// 
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        ///  The EC2 instance family of the capacity resource. 
        /// </para>
        /// </summary>
        public string InstanceFamily { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFamily property is set.
        /// </summary>
        internal bool IsSetInstanceFamily() => this.InstanceFamily != null;

        /// <summary>
        /// Gets and sets the property InstancePlatform. 
        /// <para>
        ///  The platform or operating system of the instance. 
        /// </para>
        /// </summary>
        public string InstancePlatform { get; set; }

        /// <summary>
        /// Checks to see if the InstancePlatform property is set.
        /// </summary>
        internal bool IsSetInstancePlatform() => this.InstancePlatform != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The specific EC2 instance type of the capacity resource. 
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property ReservationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the capacity reservation. This provides a unique
        /// identifier that can be used across Amazon Web Services services to reference the specific
        /// reservation. 
        /// </para>
        /// </summary>
        public string ReservationArn { get; set; }

        /// <summary>
        /// Checks to see if the ReservationArn property is set.
        /// </summary>
        internal bool IsSetReservationArn() => this.ReservationArn != null;

        /// <summary>
        /// Gets and sets the property ReservationCreateTimestamp. 
        /// <para>
        ///  The timestamp when the capacity reservation was originally created, in milliseconds
        /// since epoch. This differs from the start timestamp as reservations can be created
        /// before they become active. 
        /// </para>
        /// </summary>
        public DateTime? ReservationCreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ReservationCreateTimestamp property is set.
        /// </summary>
        internal bool IsSetReservationCreateTimestamp() => this.ReservationCreateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ReservationEndDateType. 
        /// <para>
        ///  The type of end date for the capacity reservation. This indicates whether the reservation
        /// has a fixed end date, is open-ended, or follows a specific termination pattern. 
        /// </para>
        /// </summary>
        public ReservationEndDateType ReservationEndDateType { get; set; }

        /// <summary>
        /// Checks to see if the ReservationEndDateType property is set.
        /// </summary>
        internal bool IsSetReservationEndDateType() => this.ReservationEndDateType != null;

        /// <summary>
        /// Gets and sets the property ReservationEndTimestamp. 
        /// <para>
        ///  The timestamp when the capacity reservation expires and is no longer available, in
        /// milliseconds since epoch. After this time, the reservation will not provide any capacity.
        /// 
        /// </para>
        /// </summary>
        public DateTime? ReservationEndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ReservationEndTimestamp property is set.
        /// </summary>
        internal bool IsSetReservationEndTimestamp() => this.ReservationEndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ReservationId. 
        /// <para>
        ///  The unique identifier of the capacity reservation. 
        /// </para>
        /// </summary>
        public string ReservationId { get; set; }

        /// <summary>
        /// Checks to see if the ReservationId property is set.
        /// </summary>
        internal bool IsSetReservationId() => this.ReservationId != null;

        /// <summary>
        /// Gets and sets the property ReservationInstanceMatchCriteria. 
        /// <para>
        ///  The instance matching criteria for the capacity reservation, determining how instances
        /// are matched to the reservation. 
        /// </para>
        /// </summary>
        public string ReservationInstanceMatchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the ReservationInstanceMatchCriteria property is set.
        /// </summary>
        internal bool IsSetReservationInstanceMatchCriteria() => this.ReservationInstanceMatchCriteria != null;

        /// <summary>
        /// Gets and sets the property ReservationStartTimestamp. 
        /// <para>
        ///  The timestamp when the capacity reservation becomes active and available for use,
        /// in milliseconds since epoch. This is when the reservation begins providing capacity.
        /// 
        /// </para>
        /// </summary>
        public DateTime? ReservationStartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ReservationStartTimestamp property is set.
        /// </summary>
        internal bool IsSetReservationStartTimestamp() => this.ReservationStartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ReservationState. 
        /// <para>
        ///  The current state of the capacity reservation. 
        /// </para>
        /// </summary>
        public ReservationState ReservationState { get; set; }

        /// <summary>
        /// Checks to see if the ReservationState property is set.
        /// </summary>
        internal bool IsSetReservationState() => this.ReservationState != null;

        /// <summary>
        /// Gets and sets the property ReservationType. 
        /// <para>
        ///  The type of capacity reservation. 
        /// </para>
        /// </summary>
        public ReservationType ReservationType { get; set; }

        /// <summary>
        /// Checks to see if the ReservationType property is set.
        /// </summary>
        internal bool IsSetReservationType() => this.ReservationType != null;

        /// <summary>
        /// Gets and sets the property ReservationUnusedFinancialOwner. 
        /// <para>
        ///  The Amazon Web Services account ID that is financially responsible for unused capacity
        /// reservation costs. 
        /// </para>
        /// </summary>
        public string ReservationUnusedFinancialOwner { get; set; }

        /// <summary>
        /// Checks to see if the ReservationUnusedFinancialOwner property is set.
        /// </summary>
        internal bool IsSetReservationUnusedFinancialOwner() => this.ReservationUnusedFinancialOwner != null;

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        ///  The Amazon Web Services Region where the capacity resource is located. 
        /// </para>
        /// </summary>
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags associated with the capacity resource, represented as key-value pairs. Only
        /// tags that have been activated for monitoring via <c>UpdateCapacityManagerMonitoredTagKeys</c>
        /// are included. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityManagerTagDimension> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityManagerTagDimension>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        ///  The tenancy of the EC2 instances associated with this capacity dimension. Valid values
        /// are 'default' for shared tenancy, 'dedicated' for dedicated instances, or 'host' for
        /// dedicated hosts. 
        /// </para>
        /// </summary>
        public CapacityTenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;
    }
}
