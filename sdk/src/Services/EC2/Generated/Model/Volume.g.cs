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
    /// Describes a volume.
    /// </summary>
    public partial class Volume
    {
        /// <summary>
        /// Gets and sets the property Attachments. <note> 
        /// <para>
        /// This parameter is not returned by CreateVolume.
        /// </para>
        ///  </note> 
        /// <para>
        /// Information about the volume attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeAttachment> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<VolumeAttachment>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the volume.
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
        /// The ID of the Availability Zone for the volume.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time stamp when volume creation was initiated.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the volume is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property FastRestored. <note> 
        /// <para>
        /// This parameter is not returned by CreateVolume.
        /// </para>
        ///  </note> 
        /// <para>
        /// Indicates whether the volume was created using fast snapshot restore.
        /// </para>
        /// </summary>
        public bool? FastRestored { get; set; }

        /// <summary>
        /// Checks to see if the FastRestored property is set.
        /// </summary>
        internal bool IsSetFastRestored() => this.FastRestored.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second (IOPS). For <c>gp3</c>, <c>io1</c>, and <c>io2</c>
        /// volumes, this represents the number of IOPS that are provisioned for the volume. For
        /// <c>gp2</c> volumes, this represents the baseline performance of the volume and the
        /// rate at which the volume accumulates I/O credits for bursting.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key that was used to protect the volume
        /// encryption key for the volume.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MultiAttachEnabled. 
        /// <para>
        /// Indicates whether Amazon EBS Multi-Attach is enabled.
        /// </para>
        /// </summary>
        public bool? MultiAttachEnabled { get; set; }

        /// <summary>
        /// Checks to see if the MultiAttachEnabled property is set.
        /// </summary>
        internal bool IsSetMultiAttachEnabled() => this.MultiAttachEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The service provider that manages the volume.
        /// </para>
        /// </summary>
        public OperatorResponse Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
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
        /// The ID of the Amazon Web Services account that owns the volume.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the volume, in GiBs.
        /// </para>
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot from which the volume was created, if applicable.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property SourceVolumeId. 
        /// <para>
        /// The ID of the source volume from which the volume copy was created. Only for volume
        /// copies.
        /// </para>
        /// </summary>
        public string SourceVolumeId { get; set; }

        /// <summary>
        /// Checks to see if the SourceVolumeId property is set.
        /// </summary>
        internal bool IsSetSourceVolumeId() => this.SourceVolumeId != null;

        /// <summary>
        /// Gets and sets the property SseType. <note> 
        /// <para>
        /// This parameter is not returned by CreateVolume.
        /// </para>
        ///  </note> 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public SSEType SseType { get; set; }

        /// <summary>
        /// Checks to see if the SseType property is set.
        /// </summary>
        internal bool IsSetSseType() => this.SseType != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The volume state.
        /// </para>
        /// </summary>
        public VolumeState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the volume.
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

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput that the volume supports, in MiB/s.
        /// </para>
        /// </summary>
        public int? Throughput { get; set; }

        /// <summary>
        /// Checks to see if the Throughput property is set.
        /// </summary>
        internal bool IsSetThroughput() => this.Throughput.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the volume.
        /// </para>
        /// </summary>
        public string VolumeArn { get; set; }

        /// <summary>
        /// Checks to see if the VolumeArn property is set.
        /// </summary>
        internal bool IsSetVolumeArn() => this.VolumeArn != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
        /// </para>
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;

        /// <summary>
        /// Gets and sets the property VolumeInitializationRate. 
        /// <para>
        /// The Amazon EBS Provisioned Rate for Volume Initialization (volume initialization rate)
        /// specified for the volume during creation, in MiB/s. If no volume initialization rate
        /// was specified, the value is <c>null</c>.
        /// </para>
        /// </summary>
        public int? VolumeInitializationRate { get; set; }

        /// <summary>
        /// Checks to see if the VolumeInitializationRate property is set.
        /// </summary>
        internal bool IsSetVolumeInitializationRate() => this.VolumeInitializationRate.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type.
        /// </para>
        /// </summary>
        public VolumeType VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;
    }
}
