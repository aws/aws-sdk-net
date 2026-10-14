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
    /// The configuration of an Amazon FSx for NetApp ONTAP volume.
    /// </summary>
    public partial class OntapVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property AggregateConfiguration. 
        /// <para>
        /// This structure specifies configuration options for a volume’s storage aggregate or
        /// aggregates.
        /// </para>
        /// </summary>
        public AggregateConfiguration AggregateConfiguration { get; set; }

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
        /// Gets and sets the property FlexCacheEndpointType. 
        /// <para>
        /// Specifies the FlexCache endpoint type of the volume. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> specifies that the volume doesn't have a FlexCache configuration. <c>NONE</c>
        /// is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ORIGIN</c> specifies that the volume is the origin volume for a FlexCache volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CACHE</c> specifies that the volume is a FlexCache volume.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FlexCacheEndpointType FlexCacheEndpointType { get; set; }

        /// <summary>
        /// Checks to see if the FlexCacheEndpointType property is set.
        /// </summary>
        internal bool IsSetFlexCacheEndpointType() => this.FlexCacheEndpointType != null;

        /// <summary>
        /// Gets and sets the property JunctionPath. 
        /// <para>
        /// Specifies the directory that network-attached storage (NAS) clients use to mount the
        /// volume, along with the storage virtual machine (SVM) Domain Name System (DNS) name
        /// or IP address. You can create a <c>JunctionPath</c> directly below a parent volume
        /// junction or on a directory within a volume. A <c>JunctionPath</c> for a volume named
        /// <c>vol3</c> might be <c>/vol1/vol2/vol3</c>, or <c>/vol1/dir2/vol3</c>, or even <c>/dir1/dir2/vol3</c>.
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
        /// Specifies the type of volume. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RW</c> specifies a read/write volume. <c>RW</c> is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DP</c> specifies a data-protection volume. You can protect data by replicating
        /// it to data-protection mirror copies. If a disaster occurs, you can use these data-protection
        /// mirror copies to recover data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LS</c> specifies a load-sharing mirror volume. A load-sharing mirror reduces the
        /// network traffic to a FlexVol volume by providing additional read-only access to clients.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OntapVolumeType OntapVolumeType { get; set; }

        /// <summary>
        /// Checks to see if the OntapVolumeType property is set.
        /// </summary>
        internal bool IsSetOntapVolumeType() => this.OntapVolumeType != null;

        /// <summary>
        /// Gets and sets the property SecurityStyle. 
        /// <para>
        /// The security style for the volume, which can be <c>UNIX</c>, <c>NTFS</c>, or <c>MIXED</c>.
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
        /// The configured size of the volume, in bytes.
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
        /// The configured size of the volume, in megabytes (MBs).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? SizeInMegabytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeInMegabytes property is set.
        /// </summary>
        internal bool IsSetSizeInMegabytes() => this.SizeInMegabytes.HasValue;

        /// <summary>
        /// Gets and sets the property SnaplockConfiguration. 
        /// <para>
        /// The SnapLock configuration object for an FSx for ONTAP SnapLock volume. 
        /// </para>
        /// </summary>
        public SnaplockConfiguration SnaplockConfiguration { get; set; }

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
        /// The volume's storage efficiency setting.
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
        /// The ID of the volume's storage virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string StorageVirtualMachineId { get; set; }

        /// <summary>
        /// Checks to see if the StorageVirtualMachineId property is set.
        /// </summary>
        internal bool IsSetStorageVirtualMachineId() => this.StorageVirtualMachineId != null;

        /// <summary>
        /// Gets and sets the property StorageVirtualMachineRoot. 
        /// <para>
        /// A Boolean flag indicating whether this volume is the root volume for its storage virtual
        /// machine (SVM). Only one volume on an SVM can be the root volume. This value defaults
        /// to <c>false</c>. If this value is <c>true</c>, then this is the SVM root volume.
        /// </para>
        ///  
        /// <para>
        /// This flag is useful when you're deleting an SVM, because you must first delete all
        /// non-root volumes. This flag, when set to <c>false</c>, helps you identify which volumes
        /// to delete before you can delete the SVM.
        /// </para>
        /// </summary>
        public bool? StorageVirtualMachineRoot { get; set; }

        /// <summary>
        /// Checks to see if the StorageVirtualMachineRoot property is set.
        /// </summary>
        internal bool IsSetStorageVirtualMachineRoot() => this.StorageVirtualMachineRoot.HasValue;

        /// <summary>
        /// Gets and sets the property TieringPolicy. 
        /// <para>
        /// The volume's <c>TieringPolicy</c> setting.
        /// </para>
        /// </summary>
        public TieringPolicy TieringPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TieringPolicy property is set.
        /// </summary>
        internal bool IsSetTieringPolicy() => this.TieringPolicy != null;

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The volume's universally unique identifier (UUID).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 36)]
        public string UUID { get; set; }

        /// <summary>
        /// Checks to see if the UUID property is set.
        /// </summary>
        internal bool IsSetUUID() => this.UUID != null;

        /// <summary>
        /// Gets and sets the property VolumeStyle. 
        /// <para>
        /// Use to specify the style of an ONTAP volume. For more information about FlexVols and
        /// FlexGroups, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/volume-types.html">Volume
        /// types</a> in Amazon FSx for NetApp ONTAP User Guide.
        /// </para>
        /// </summary>
        public VolumeStyle VolumeStyle { get; set; }

        /// <summary>
        /// Checks to see if the VolumeStyle property is set.
        /// </summary>
        internal bool IsSetVolumeStyle() => this.VolumeStyle != null;
    }
}
