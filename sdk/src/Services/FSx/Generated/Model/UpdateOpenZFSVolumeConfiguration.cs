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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Used to specify changes to the OpenZFS configuration for the volume that you are updating.
    /// </summary>
    public partial class UpdateOpenZFSVolumeConfiguration
    {
        private OpenZFSDataCompressionType _dataCompressionType;
        private List<OpenZFSNfsExport> _nfsExports = new List<OpenZFSNfsExport>();
        private bool? _readOnly;
        private int? _recordSizeKiB;
        private int? _storageCapacityQuotaGiB;
        private int? _storageCapacityReservationGiB;
        private List<OpenZFSUserOrGroupQuota> _userAndGroupQuotas = new List<OpenZFSUserOrGroupQuota>();

        /// <summary>
        /// Gets and sets the property DataCompressionType. 
        /// <para>
        /// Specifies the method used to compress the data on the volume. The compression type
        /// is <code>NONE</code> by default.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code> - Doesn't compress the data on the volume. <code>NONE</code> is
        /// the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ZSTD</code> - Compresses the data in the volume using the Zstandard (ZSTD)
        /// compression algorithm. Compared to LZ4, Z-Standard provides a better compression ratio
        /// to minimize on-disk storage utilization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LZ4</code> - Compresses the data in the volume using the LZ4 compression algorithm.
        /// Compared to Z-Standard, LZ4 is less compute-intensive and delivers higher write throughput
        /// speeds.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OpenZFSDataCompressionType DataCompressionType
        {
            get { return this._dataCompressionType; }
            set { this._dataCompressionType = value; }
        }

        // Check to see if DataCompressionType property is set
        internal bool IsSetDataCompressionType()
        {
            return this._dataCompressionType != null;
        }

        /// <summary>
        /// Gets and sets the property NfsExports. 
        /// <para>
        /// The configuration object for mounting a Network File System (NFS) file system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<OpenZFSNfsExport> NfsExports
        {
            get { return this._nfsExports; }
            set { this._nfsExports = value; }
        }

        // Check to see if NfsExports property is set
        internal bool IsSetNfsExports()
        {
            return this._nfsExports != null && this._nfsExports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// A Boolean value indicating whether the volume is read-only.
        /// </para>
        /// </summary>
        public bool ReadOnly
        {
            get { return this._readOnly.GetValueOrDefault(); }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

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
        [AWSProperty(Min=4, Max=1024)]
        public int RecordSizeKiB
        {
            get { return this._recordSizeKiB.GetValueOrDefault(); }
            set { this._recordSizeKiB = value; }
        }

        // Check to see if RecordSizeKiB property is set
        internal bool IsSetRecordSizeKiB()
        {
            return this._recordSizeKiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageCapacityQuotaGiB. 
        /// <para>
        /// The maximum amount of storage in gibibytes (GiB) that the volume can use from its
        /// parent. You can specify a quota larger than the storage on the parent volume. You
        /// can specify a value of <code>-1</code> to unset a volume's storage capacity quota.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=2147483647)]
        public int StorageCapacityQuotaGiB
        {
            get { return this._storageCapacityQuotaGiB.GetValueOrDefault(); }
            set { this._storageCapacityQuotaGiB = value; }
        }

        // Check to see if StorageCapacityQuotaGiB property is set
        internal bool IsSetStorageCapacityQuotaGiB()
        {
            return this._storageCapacityQuotaGiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageCapacityReservationGiB. 
        /// <para>
        /// The amount of storage in gibibytes (GiB) to reserve from the parent volume. You can't
        /// reserve more storage than the parent volume has reserved. You can specify a value
        /// of <code>-1</code> to unset a volume's storage capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=2147483647)]
        public int StorageCapacityReservationGiB
        {
            get { return this._storageCapacityReservationGiB.GetValueOrDefault(); }
            set { this._storageCapacityReservationGiB = value; }
        }

        // Check to see if StorageCapacityReservationGiB property is set
        internal bool IsSetStorageCapacityReservationGiB()
        {
            return this._storageCapacityReservationGiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserAndGroupQuotas. 
        /// <para>
        /// An object specifying how much storage users or groups can use on the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public List<OpenZFSUserOrGroupQuota> UserAndGroupQuotas
        {
            get { return this._userAndGroupQuotas; }
            set { this._userAndGroupQuotas = value; }
        }

        // Check to see if UserAndGroupQuotas property is set
        internal bool IsSetUserAndGroupQuotas()
        {
            return this._userAndGroupQuotas != null && this._userAndGroupQuotas.Count > 0; 
        }

    }
}