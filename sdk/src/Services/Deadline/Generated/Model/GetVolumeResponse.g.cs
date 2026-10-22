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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the GetVolume operation.
    /// </summary>
    public partial class GetVolumeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AttachedWorkerId. 
        /// <para>
        /// The worker ID of the worker the volume is attached to.
        /// </para>
        /// </summary>
        public string AttachedWorkerId { get; set; }

        /// <summary>
        /// Checks to see if the AttachedWorkerId property is set.
        /// </summary>
        internal bool IsSetAttachedWorkerId() => this.AttachedWorkerId != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time the volume expires and will be deleted.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the farm that contains the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The fleet ID of the fleet that contains the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The IOPS of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 80000)]
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property LastAssignedAt. 
        /// <para>
        /// The date and time the volume was last assigned to a worker.
        /// </para>
        /// </summary>
        public DateTime? LastAssignedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastAssignedAt property is set.
        /// </summary>
        internal bool IsSetLastAssignedAt() => this.LastAssignedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastReleasedAt. 
        /// <para>
        /// The date and time the volume was last released from a worker.
        /// </para>
        /// </summary>
        public DateTime? LastReleasedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastReleasedAt property is set.
        /// </summary>
        internal bool IsSetLastReleasedAt() => this.LastReleasedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SizeGiB. 
        /// <para>
        /// The volume size in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65536)]
        public int? SizeGiB { get; set; }

        /// <summary>
        /// Checks to see if the SizeGiB property is set.
        /// </summary>
        internal bool IsSetSizeGiB() => this.SizeGiB.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VolumeState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property ThroughputMiB. 
        /// <para>
        /// The throughput of the volume in MiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 125, Max = 2000)]
        public int? ThroughputMiB { get; set; }

        /// <summary>
        /// Checks to see if the ThroughputMiB property is set.
        /// </summary>
        internal bool IsSetThroughputMiB() => this.ThroughputMiB.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The volume ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The EBS volume type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EbsVolumeType VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;
    }
}
