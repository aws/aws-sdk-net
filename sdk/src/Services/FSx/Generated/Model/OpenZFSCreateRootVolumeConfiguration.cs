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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration of an Amazon FSx for OpenZFS root volume.
    /// </summary>
    public partial class OpenZFSCreateRootVolumeConfiguration
    {
        private bool? _copyTagsToSnapshots;
        private OpenZFSDataCompressionType _dataCompressionType;
        private List<OpenZFSNfsExport> _nfsExports = AWSConfigs.InitializeCollections ? new List<OpenZFSNfsExport>() : null;
        private bool? _readOnly;
        private int? _recordSizeKiB;
        private List<OpenZFSUserOrGroupQuota> _userAndGroupQuotas = AWSConfigs.InitializeCollections ? new List<OpenZFSUserOrGroupQuota>() : null;

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshots. 
        /// <para>
        /// A Boolean value indicating whether tags for the volume should be copied to snapshots
        /// of the volume. This value defaults to <c>false</c>. If it's set to <c>true</c>, all
        /// tags for the volume are copied to snapshots where the user doesn't specify tags. If
        /// this value is <c>true</c> and you specify one or more tags, only the specified tags
        /// are copied to snapshots. If you specify one or more tags when creating the snapshot,
        /// no tags are copied from the volume, regardless of this value. 
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshots
        {
            get { return this._copyTagsToSnapshots; }
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
        /// The configuration object for mounting a file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._nfsExports != null && (this._nfsExports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// A Boolean value indicating whether the volume is read-only. Setting this value to
        /// <c>true</c> can be useful after you have completed changes to a volume and no longer
        /// want changes to occur. 
        /// </para>
        /// </summary>
        public bool? ReadOnly
        {
            get { return this._readOnly; }
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
        /// Specifies the record size of an OpenZFS root volume, in kibibytes (KiB). Valid values
        /// are 4, 8, 16, 32, 64, 128, 256, 512, or 1024 KiB. The default is 128 KiB. Most workloads
        /// should use the default record size. Database workflows can benefit from a smaller
        /// record size, while streaming workflows can benefit from a larger record size. For
        /// additional guidance on setting a custom record size, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/performance.html#performance-tips-zfs">
        /// Tips for maximizing performance</a> in the <i>Amazon FSx for OpenZFS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=4096)]
        public int? RecordSizeKiB
        {
            get { return this._recordSizeKiB; }
            set { this._recordSizeKiB = value; }
        }

        // Check to see if RecordSizeKiB property is set
        internal bool IsSetRecordSizeKiB()
        {
            return this._recordSizeKiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserAndGroupQuotas. 
        /// <para>
        /// An object specifying how much storage users or groups can use on the volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._userAndGroupQuotas != null && (this._userAndGroupQuotas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}