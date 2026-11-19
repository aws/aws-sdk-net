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
    /// Describes the properties of the Dedicated Host.
    /// </summary>
    public partial class Host
    {
        /// <summary>
        /// Gets and sets the property AllocationTime. 
        /// <para>
        /// The time that the Dedicated Host was allocated.
        /// </para>
        /// </summary>
        public DateTime? AllocationTime { get; set; }

        /// <summary>
        /// Checks to see if the AllocationTime property is set.
        /// </summary>
        internal bool IsSetAllocationTime() => this.AllocationTime.HasValue;

        /// <summary>
        /// Gets and sets the property AllowsMultipleInstanceTypes. 
        /// <para>
        /// Indicates whether the Dedicated Host supports multiple instance types of the same
        /// instance family. If the value is <c>on</c>, the Dedicated Host supports multiple instance
        /// types in the instance family. If the value is <c>off</c>, the Dedicated Host supports
        /// a single instance type only.
        /// </para>
        /// </summary>
        public AllowsMultipleInstanceTypes AllowsMultipleInstanceTypes { get; set; }

        /// <summary>
        /// Checks to see if the AllowsMultipleInstanceTypes property is set.
        /// </summary>
        internal bool IsSetAllowsMultipleInstanceTypes() => this.AllowsMultipleInstanceTypes != null;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the Outpost hardware asset on which the Dedicated Host is allocated.
        /// </para>
        /// </summary>
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property AutoPlacement. 
        /// <para>
        /// Whether auto-placement is on or off.
        /// </para>
        /// </summary>
        public AutoPlacement AutoPlacement { get; set; }

        /// <summary>
        /// Checks to see if the AutoPlacement property is set.
        /// </summary>
        internal bool IsSetAutoPlacement() => this.AutoPlacement != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the Dedicated Host.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone in which the Dedicated Host is allocated.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property AvailableCapacity. 
        /// <para>
        /// Information about the instances running on the Dedicated Host.
        /// </para>
        /// </summary>
        public AvailableCapacity AvailableCapacity { get; set; }

        /// <summary>
        /// Checks to see if the AvailableCapacity property is set.
        /// </summary>
        internal bool IsSetAvailableCapacity() => this.AvailableCapacity != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CpuOptions. 
        /// <para>
        /// The CPU options for the Dedicated Host, including AMD Secure Encrypted Virtualization-Secure
        /// Nested Paging (AMD SEV-SNP) settings.
        /// </para>
        /// </summary>
        public HostCpuOptions CpuOptions { get; set; }

        /// <summary>
        /// Checks to see if the CpuOptions property is set.
        /// </summary>
        internal bool IsSetCpuOptions() => this.CpuOptions != null;

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        /// The ID of the Dedicated Host.
        /// </para>
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// Checks to see if the HostId property is set.
        /// </summary>
        internal bool IsSetHostId() => this.HostId != null;

        /// <summary>
        /// Gets and sets the property HostMaintenance. 
        /// <para>
        /// Indicates whether host maintenance is enabled or disabled for the Dedicated Host.
        /// </para>
        /// </summary>
        public HostMaintenance HostMaintenance { get; set; }

        /// <summary>
        /// Checks to see if the HostMaintenance property is set.
        /// </summary>
        internal bool IsSetHostMaintenance() => this.HostMaintenance != null;

        /// <summary>
        /// Gets and sets the property HostProperties. 
        /// <para>
        /// The hardware specifications of the Dedicated Host.
        /// </para>
        /// </summary>
        public HostProperties HostProperties { get; set; }

        /// <summary>
        /// Checks to see if the HostProperties property is set.
        /// </summary>
        internal bool IsSetHostProperties() => this.HostProperties != null;

        /// <summary>
        /// Gets and sets the property HostRecovery. 
        /// <para>
        /// Indicates whether host recovery is enabled or disabled for the Dedicated Host.
        /// </para>
        /// </summary>
        public HostRecovery HostRecovery { get; set; }

        /// <summary>
        /// Checks to see if the HostRecovery property is set.
        /// </summary>
        internal bool IsSetHostRecovery() => this.HostRecovery != null;

        /// <summary>
        /// Gets and sets the property HostReservationId. 
        /// <para>
        /// The reservation ID of the Dedicated Host. This returns a <c>null</c> response if the
        /// Dedicated Host doesn't have an associated reservation.
        /// </para>
        /// </summary>
        public string HostReservationId { get; set; }

        /// <summary>
        /// Checks to see if the HostReservationId property is set.
        /// </summary>
        internal bool IsSetHostReservationId() => this.HostReservationId != null;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The IDs and instance type that are currently running on the Dedicated Host.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HostInstance> Instances { get; set; } = AWSConfigs.InitializeCollections ? new List<HostInstance>() : null;

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances != null && (this.Instances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MemberOfServiceLinkedResourceGroup. 
        /// <para>
        /// Indicates whether the Dedicated Host is in a host resource group. If <b>memberOfServiceLinkedResourceGroup</b>
        /// is <c>true</c>, the host is in a host resource group; otherwise, it is not.
        /// </para>
        /// </summary>
        public bool? MemberOfServiceLinkedResourceGroup { get; set; }

        /// <summary>
        /// Checks to see if the MemberOfServiceLinkedResourceGroup property is set.
        /// </summary>
        internal bool IsSetMemberOfServiceLinkedResourceGroup() => this.MemberOfServiceLinkedResourceGroup.HasValue;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Outpost on which the Dedicated
        /// Host is allocated.
        /// </para>
        /// </summary>
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the Dedicated Host.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ReleaseTime. 
        /// <para>
        /// The time that the Dedicated Host was released.
        /// </para>
        /// </summary>
        public DateTime? ReleaseTime { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseTime property is set.
        /// </summary>
        internal bool IsSetReleaseTime() => this.ReleaseTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The Dedicated Host's state.
        /// </para>
        /// </summary>
        public AllocationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the Dedicated Host.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
