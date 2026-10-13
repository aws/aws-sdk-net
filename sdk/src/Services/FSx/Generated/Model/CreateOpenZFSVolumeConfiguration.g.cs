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
    /// Specifies the configuration of the Amazon FSx for OpenZFS volume that you are creating.
    /// </summary>
    public partial class CreateOpenZFSVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshots. 
        /// <para>
        /// A Boolean value indicating whether tags for the volume should be copied to snapshots.
        /// This value defaults to <c>false</c>. If this value is set to <c>true</c>, and you
        /// do not specify any tags, all tags for the original volume are copied over to snapshots.
        /// If this value is set to <c>true</c>, and you do specify one or more tags, only the
        /// specified tags for the original volume are copied over to snapshots. If you specify
        /// one or more tags when creating a new snapshot, no tags are copied over from the original
        /// volume, regardless of this value. 
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshots { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToSnapshots property is set.
        /// </summary>
        internal bool IsSetCopyTagsToSnapshots() => this.CopyTagsToSnapshots.HasValue;

        /// <summary>
        /// Gets and sets the property DataCompressionType. 
        /// <para>
        /// Specifies the method used to compress the data on the volume. The compression type
        /// is <c>NONE</c> by default.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> - Doesn't compress the data on the volume. <c>NONE</c> is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ZSTD</c> - Compresses the data in the volume using the Zstandard (ZSTD) compression
        /// algorithm. ZSTD compression provides a higher level of data compression and higher
        /// read throughput performance than LZ4 compression.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LZ4</c> - Compresses the data in the volume using the LZ4 compression algorithm.
        /// LZ4 compression provides a lower level of compression and higher write throughput
        /// performance than ZSTD compression.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about volume compression types and the performance of your Amazon
        /// FSx for OpenZFS file system, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/performance.html#performance-tips-zfs">
        /// Tips for maximizing performance</a> File system and volume settings in the <i>Amazon
        /// FSx for OpenZFS User Guide</i>.
        /// </para>
        /// </summary>
        public OpenZFSDataCompressionType DataCompressionType { get; set; }

        /// <summary>
        /// Checks to see if the DataCompressionType property is set.
        /// </summary>
        internal bool IsSetDataCompressionType() => this.DataCompressionType != null;

        /// <summary>
        /// Gets and sets the property NfsExports. 
        /// <para>
        /// The configuration object for mounting a Network File System (NFS) file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<OpenZFSNfsExport> NfsExports { get; set; } = AWSConfigs.InitializeCollections ? new List<OpenZFSNfsExport>() : null;

        /// <summary>
        /// Checks to see if the NfsExports property is set.
        /// </summary>
        internal bool IsSetNfsExports() => this.NfsExports != null && (this.NfsExports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OriginSnapshot. 
        /// <para>
        /// The configuration object that specifies the snapshot to use as the origin of the data
        /// for the volume.
        /// </para>
        /// </summary>
        public CreateOpenZFSOriginSnapshotConfiguration OriginSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the OriginSnapshot property is set.
        /// </summary>
        internal bool IsSetOriginSnapshot() => this.OriginSnapshot != null;

        /// <summary>
        /// Gets and sets the property ParentVolumeId. 
        /// <para>
        /// The ID of the volume to use as the parent volume of the volume that you are creating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 23, Max = 23)]
        public string ParentVolumeId { get; set; }

        /// <summary>
        /// Checks to see if the ParentVolumeId property is set.
        /// </summary>
        internal bool IsSetParentVolumeId() => this.ParentVolumeId != null;

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// A Boolean value indicating whether the volume is read-only.
        /// </para>
        /// </summary>
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the ReadOnly property is set.
        /// </summary>
        internal bool IsSetReadOnly() => this.ReadOnly.HasValue;

        /// <summary>
        /// Gets and sets the property RecordSizeKiB. 
        /// <para>
        /// Specifies the suggested block size for a volume in a ZFS dataset, in kibibytes (KiB).
        /// For file systems using the Intelligent-Tiering storage class, valid values are 128,
        /// 256, 512, 1024, 2048, or 4096 KiB, with a default of 1024 KiB. For all other file
        /// systems, valid values are 4, 8, 16, 32, 64, 128, 256, 512, or 1024 KiB, with a default
        /// of 128 KiB. We recommend using the default setting for the majority of use cases.
        /// Generally, workloads that write in fixed small or large record sizes may benefit from
        /// setting a custom record size, like database workloads (small record size) or media
        /// streaming workloads (large record size). For additional guidance on when to set a
        /// custom record size, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/performance.html#record-size-performance">
        /// ZFS Record size</a> in the <i>Amazon FSx for OpenZFS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 4096)]
        public int? RecordSizeKiB { get; set; }

        /// <summary>
        /// Checks to see if the RecordSizeKiB property is set.
        /// </summary>
        internal bool IsSetRecordSizeKiB() => this.RecordSizeKiB.HasValue;

        /// <summary>
        /// Gets and sets the property StorageCapacityQuotaGiB. 
        /// <para>
        /// Sets the maximum storage size in gibibytes (GiB) for the volume. You can specify a
        /// quota that is larger than the storage on the parent volume. A volume quota limits
        /// the amount of storage that the volume can consume to the configured amount, but does
        /// not guarantee the space will be available on the parent volume. To guarantee quota
        /// space, you must also set <c>StorageCapacityReservationGiB</c>. To <i>not</i> specify
        /// a storage capacity quota, set this to <c>-1</c>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/managing-volumes.html#volume-properties">Volume
        /// properties</a> in the <i>Amazon FSx for OpenZFS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -1, Max = 2147483647)]
        public int? StorageCapacityQuotaGiB { get; set; }

        /// <summary>
        /// Checks to see if the StorageCapacityQuotaGiB property is set.
        /// </summary>
        internal bool IsSetStorageCapacityQuotaGiB() => this.StorageCapacityQuotaGiB.HasValue;

        /// <summary>
        /// Gets and sets the property StorageCapacityReservationGiB. 
        /// <para>
        /// Specifies the amount of storage in gibibytes (GiB) to reserve from the parent volume.
        /// Setting <c>StorageCapacityReservationGiB</c> guarantees that the specified amount
        /// of storage space on the parent volume will always be available for the volume. You
        /// can't reserve more storage than the parent volume has. To <i>not</i> specify a storage
        /// capacity reservation, set this to <c>0</c> or <c>-1</c>. For more information, see
        /// <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/managing-volumes.html#volume-properties">Volume
        /// properties</a> in the <i>Amazon FSx for OpenZFS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -1, Max = 2147483647)]
        public int? StorageCapacityReservationGiB { get; set; }

        /// <summary>
        /// Checks to see if the StorageCapacityReservationGiB property is set.
        /// </summary>
        internal bool IsSetStorageCapacityReservationGiB() => this.StorageCapacityReservationGiB.HasValue;

        /// <summary>
        /// Gets and sets the property UserAndGroupQuotas. 
        /// <para>
        /// Configures how much storage users and groups can use on the volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public List<OpenZFSUserOrGroupQuota> UserAndGroupQuotas { get; set; } = AWSConfigs.InitializeCollections ? new List<OpenZFSUserOrGroupQuota>() : null;

        /// <summary>
        /// Checks to see if the UserAndGroupQuotas property is set.
        /// </summary>
        internal bool IsSetUserAndGroupQuotas() => this.UserAndGroupQuotas != null && (this.UserAndGroupQuotas.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
