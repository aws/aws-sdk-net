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
    /// The configuration of an Amazon FSx for OpenZFS volume.
    /// </summary>
    public partial class OpenZFSVolumeConfiguration
    {
        private bool? _copyTagsToSnapshots;
        private OpenZFSDataCompressionType _dataCompressionType;
        private bool? _deleteClonedVolumes;
        private bool? _deleteIntermediateSnaphots;
        private List<OpenZFSNfsExport> _nfsExports = new List<OpenZFSNfsExport>();
        private OpenZFSOriginSnapshotConfiguration _originSnapshot;
        private string _parentVolumeId;
        private bool? _readOnly;
        private int? _recordSizeKiB;
        private string _restoreToSnapshot;
        private int? _storageCapacityQuotaGiB;
        private int? _storageCapacityReservationGiB;
        private List<OpenZFSUserOrGroupQuota> _userAndGroupQuotas = new List<OpenZFSUserOrGroupQuota>();
        private string _volumePath;

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshots. 
        /// <para>
        /// A Boolean value indicating whether tags for the volume should be copied to snapshots.
        /// This value defaults to <code>false</code>. If it's set to <code>true</code>, all tags
        /// for the volume are copied to snapshots where the user doesn't specify tags. If this
        /// value is <code>true</code> and you specify one or more tags, only the specified tags
        /// are copied to snapshots. If you specify one or more tags when creating the snapshot,
        /// no tags are copied from the volume, regardless of this value.
        /// </para>
        /// </summary>
        public bool CopyTagsToSnapshots
        {
            get { return this._copyTagsToSnapshots.GetValueOrDefault(); }
            set { this._copyTagsToSnapshots = value; }
        }

        // Check to see if CopyTagsToSnapshots property is set
        internal bool IsSetCopyTagsToSnapshots()
        {
            return this._copyTagsToSnapshots.HasValue; 
        }

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
        /// Gets and sets the property DeleteClonedVolumes. 
        /// <para>
        /// A Boolean value indicating whether dependent clone volumes created from intermediate
        /// snapshots should be deleted when a volume is restored from snapshot.
        /// </para>
        /// </summary>
        public bool DeleteClonedVolumes
        {
            get { return this._deleteClonedVolumes.GetValueOrDefault(); }
            set { this._deleteClonedVolumes = value; }
        }

        // Check to see if DeleteClonedVolumes property is set
        internal bool IsSetDeleteClonedVolumes()
        {
            return this._deleteClonedVolumes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteIntermediateSnaphots. 
        /// <para>
        /// A Boolean value indicating whether snapshots between the current state and the specified
        /// snapshot should be deleted when a volume is restored from snapshot.
        /// </para>
        /// </summary>
        public bool DeleteIntermediateSnaphots
        {
            get { return this._deleteIntermediateSnaphots.GetValueOrDefault(); }
            set { this._deleteIntermediateSnaphots = value; }
        }

        // Check to see if DeleteIntermediateSnaphots property is set
        internal bool IsSetDeleteIntermediateSnaphots()
        {
            return this._deleteIntermediateSnaphots.HasValue; 
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
        /// Gets and sets the property OriginSnapshot. 
        /// <para>
        /// The configuration object that specifies the snapshot to use as the origin of the data
        /// for the volume.
        /// </para>
        /// </summary>
        public OpenZFSOriginSnapshotConfiguration OriginSnapshot
        {
            get { return this._originSnapshot; }
            set { this._originSnapshot = value; }
        }

        // Check to see if OriginSnapshot property is set
        internal bool IsSetOriginSnapshot()
        {
            return this._originSnapshot != null;
        }

        /// <summary>
        /// Gets and sets the property ParentVolumeId. 
        /// <para>
        /// The ID of the parent volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=23, Max=23)]
        public string ParentVolumeId
        {
            get { return this._parentVolumeId; }
            set { this._parentVolumeId = value; }
        }

        // Check to see if ParentVolumeId property is set
        internal bool IsSetParentVolumeId()
        {
            return this._parentVolumeId != null;
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
        /// The record size of an OpenZFS volume, in kibibytes (KiB). Valid values are 4, 8, 16,
        /// 32, 64, 128, 256, 512, or 1024 KiB. The default is 128 KiB. Most workloads should
        /// use the default record size. For guidance on when to set a custom record size, see
        /// the <i>Amazon FSx for OpenZFS User Guide</i>.
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
        /// Gets and sets the property RestoreToSnapshot. 
        /// <para>
        /// Specifies the ID of the snapshot to which the volume was restored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=28)]
        public string RestoreToSnapshot
        {
            get { return this._restoreToSnapshot; }
            set { this._restoreToSnapshot = value; }
        }

        // Check to see if RestoreToSnapshot property is set
        internal bool IsSetRestoreToSnapshot()
        {
            return this._restoreToSnapshot != null;
        }

        /// <summary>
        /// Gets and sets the property StorageCapacityQuotaGiB. 
        /// <para>
        /// The maximum amount of storage in gibibtyes (GiB) that the volume can use from its
        /// parent. You can specify a quota larger than the storage on the parent volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
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
        /// reserve more storage than the parent volume has reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
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

        /// <summary>
        /// Gets and sets the property VolumePath. 
        /// <para>
        /// The path to the volume from the root volume. For example, <code>fsx/parentVolume/volume1</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string VolumePath
        {
            get { return this._volumePath; }
            set { this._volumePath = value; }
        }

        // Check to see if VolumePath property is set
        internal bool IsSetVolumePath()
        {
            return this._volumePath != null;
        }

    }
}