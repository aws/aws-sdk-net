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
    /// Used to specify changes to the OpenZFS configuration for the volume that you are updating.
    /// </summary>
    public partial class UpdateOpenZFSVolumeConfiguration
    {
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
        /// algorithm. Compared to LZ4, Z-Standard provides a better compression ratio to minimize
        /// on-disk storage utilization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LZ4</c> - Compresses the data in the volume using the LZ4 compression algorithm.
        /// Compared to Z-Standard, LZ4 is less compute-intensive and delivers higher write throughput
        /// speeds.
        /// </para>
        ///  </li> </ul>
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
        /// Specifies the record size of an OpenZFS volume, in kibibytes (KiB). Valid values are
        /// 4, 8, 16, 32, 64, 128, 256, 512, or 1024 KiB. The default is 128 KiB. Most workloads
        /// should use the default record size. Database workflows can benefit from a smaller
        /// record size, while streaming workflows can benefit from a larger record size. For
        /// additional guidance on when to set a custom record size, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/performance.html#performance-tips-zfs">
        /// Tips for maximizing performance</a> in the <i>Amazon FSx for OpenZFS User Guide</i>.
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
        /// The maximum amount of storage in gibibytes (GiB) that the volume can use from its
        /// parent. You can specify a quota larger than the storage on the parent volume. You
        /// can specify a value of <c>-1</c> to unset a volume's storage capacity quota.
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
        /// The amount of storage in gibibytes (GiB) to reserve from the parent volume. You can't
        /// reserve more storage than the parent volume has reserved. You can specify a value
        /// of <c>-1</c> to unset a volume's storage capacity reservation.
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
        /// An object specifying how much storage users or groups can use on the volume.
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
