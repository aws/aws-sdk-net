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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Specifies the configuration of the ONTAP volume that you are creating.
    /// </summary>
    public partial class CreateOntapVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property AggregateConfiguration. 
        /// <para>
        /// Use to specify configuration options for a volume’s storage aggregate or aggregates.
        /// </para>
        /// </summary>
        public CreateAggregateConfiguration AggregateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AggregateConfiguration property is set.
        /// </summary>
        internal bool IsSetAggregateConfiguration() => this.AggregateConfiguration != null;

        /// <summary>
        /// Gets and sets the property CopyTagsToBackups. 
        /// <para>
        /// A boolean flag indicating whether tags for the volume should be copied to backups.
        /// This value defaults to false. If it's set to true, all tags for the volume are copied
        /// to all automatic and user-initiated backups where the user doesn't specify tags. If
        /// this value is true, and you specify one or more tags, only the specified tags are
        /// copied to backups. If you specify one or more tags when creating a user-initiated
        /// backup, no tags are copied from the volume, regardless of this value.
        /// </para>
        /// </summary>
        public bool? CopyTagsToBackups { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToBackups property is set.
        /// </summary>
        internal bool IsSetCopyTagsToBackups() => this.CopyTagsToBackups.HasValue;

        /// <summary>
        /// Gets and sets the property JunctionPath. 
        /// <para>
        /// Specifies the location in the SVM's namespace where the volume is mounted. This parameter
        /// is required. The <c>JunctionPath</c> must have a leading forward slash, such as <c>/vol3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string JunctionPath { get; set; }

        /// <summary>
        /// Checks to see if the JunctionPath property is set.
        /// </summary>
        internal bool IsSetJunctionPath() => this.JunctionPath != null;

        /// <summary>
        /// Gets and sets the property OntapVolumeType. 
        /// <para>
        /// Specifies the type of volume you are creating. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RW</c> specifies a read/write volume. <c>RW</c> is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DP</c> specifies a data-protection volume. A <c>DP</c> volume is read-only and
        /// can be used as the destination of a NetApp SnapMirror relationship.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/managing-volumes.html#volume-types">Volume
        /// types</a> in the Amazon FSx for NetApp ONTAP User Guide.
        /// </para>
        /// </summary>
        public InputOntapVolumeType OntapVolumeType { get; set; }

        /// <summary>
        /// Checks to see if the OntapVolumeType property is set.
        /// </summary>
        internal bool IsSetOntapVolumeType() => this.OntapVolumeType != null;

        /// <summary>
        /// Gets and sets the property SecurityStyle. 
        /// <para>
        /// Specifies the security style for the volume. If a volume's security style is not specified,
        /// it is automatically set to the root volume's security style. The security style determines
        /// the type of permissions that FSx for ONTAP uses to control data access. Specify one
        /// of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UNIX</c> if the file system is managed by a UNIX administrator, the majority of
        /// users are NFS clients, and an application accessing the data uses a UNIX user as the
        /// service account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NTFS</c> if the file system is managed by a Windows administrator, the majority
        /// of users are SMB clients, and an application accessing the data uses a Windows user
        /// as the service account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MIXED</c> This is an advanced setting. For more information, see the topic <a
        /// href="https://docs.netapp.com/us-en/ontap/nfs-admin/security-styles-their-effects-concept.html">What
        /// the security styles and their effects are</a> in the NetApp Documentation Center.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/managing-volumes.html#volume-security-style">Volume
        /// security style</a> in the FSx for ONTAP User Guide.
        /// </para>
        /// </summary>
        public SecurityStyle SecurityStyle { get; set; }

        /// <summary>
        /// Checks to see if the SecurityStyle property is set.
        /// </summary>
        internal bool IsSetSecurityStyle() => this.SecurityStyle != null;

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        /// Specifies the configured size of the volume, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 22517998000000000)]
        public long? SizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeInBytes property is set.
        /// </summary>
        internal bool IsSetSizeInBytes() => this.SizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInMegabytes. 
        /// <para>
        /// Use <c>SizeInBytes</c> instead. Specifies the size of the volume, in megabytes (MB),
        /// that you are creating.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated, use SizeInBytes instead")]
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? SizeInMegabytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeInMegabytes property is set.
        /// </summary>
        internal bool IsSetSizeInMegabytes() => this.SizeInMegabytes.HasValue;

        /// <summary>
        /// Gets and sets the property SnaplockConfiguration. 
        /// <para>
        /// Specifies the SnapLock configuration for an FSx for ONTAP volume. 
        /// </para>
        /// </summary>
        public CreateSnaplockConfiguration SnaplockConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SnaplockConfiguration property is set.
        /// </summary>
        internal bool IsSetSnaplockConfiguration() => this.SnaplockConfiguration != null;

        /// <summary>
        /// Gets and sets the property SnapshotPolicy. 
        /// <para>
        /// Specifies the snapshot policy for the volume. There are three built-in snapshot policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>default</c>: This is the default policy. A maximum of six hourly snapshots taken
        /// five minutes past the hour. A maximum of two daily snapshots taken Monday through
        /// Saturday at 10 minutes after midnight. A maximum of two weekly snapshots taken every
        /// Sunday at 15 minutes after midnight.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>default-1weekly</c>: This policy is the same as the <c>default</c> policy except
        /// that it only retains one snapshot from the weekly schedule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>none</c>: This policy does not take any snapshots. This policy can be assigned
        /// to volumes to prevent automatic snapshots from being taken.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also provide the name of a custom policy that you created with the ONTAP CLI
        /// or REST API.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/snapshots-ontap.html#snapshot-policies">Snapshot
        /// policies</a> in the Amazon FSx for NetApp ONTAP User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SnapshotPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotPolicy property is set.
        /// </summary>
        internal bool IsSetSnapshotPolicy() => this.SnapshotPolicy != null;

        /// <summary>
        /// Gets and sets the property StorageEfficiencyEnabled. 
        /// <para>
        /// Set to true to enable deduplication, compression, and compaction storage efficiency
        /// features on the volume, or set to false to disable them.
        /// </para>
        ///  
        /// <para>
        ///  <c>StorageEfficiencyEnabled</c> is required when creating a <c>RW</c> volume (<c>OntapVolumeType</c>
        /// set to <c>RW</c>).
        /// </para>
        /// </summary>
        public bool? StorageEfficiencyEnabled { get; set; }

        /// <summary>
        /// Checks to see if the StorageEfficiencyEnabled property is set.
        /// </summary>
        internal bool IsSetStorageEfficiencyEnabled() => this.StorageEfficiencyEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property StorageVirtualMachineId. 
        /// <para>
        /// Specifies the ONTAP SVM in which to create the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 21, Max = 21)]
        public string StorageVirtualMachineId { get; set; }

        /// <summary>
        /// Checks to see if the StorageVirtualMachineId property is set.
        /// </summary>
        internal bool IsSetStorageVirtualMachineId() => this.StorageVirtualMachineId != null;

        /// <summary>
        /// Gets and sets the property TieringPolicy.
        /// </summary>
        public TieringPolicy TieringPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TieringPolicy property is set.
        /// </summary>
        internal bool IsSetTieringPolicy() => this.TieringPolicy != null;

        /// <summary>
        /// Gets and sets the property VolumeStyle. 
        /// <para>
        /// Use to specify the style of an ONTAP volume. FSx for ONTAP offers two styles of volumes
        /// that you can use for different purposes, FlexVol and FlexGroup volumes. For more information,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/managing-volumes.html#volume-styles">Volume
        /// styles</a> in the Amazon FSx for NetApp ONTAP User Guide.
        /// </para>
        /// </summary>
        public VolumeStyle VolumeStyle { get; set; }

        /// <summary>
        /// Checks to see if the VolumeStyle property is set.
        /// </summary>
        internal bool IsSetVolumeStyle() => this.VolumeStyle != null;
    }
}
