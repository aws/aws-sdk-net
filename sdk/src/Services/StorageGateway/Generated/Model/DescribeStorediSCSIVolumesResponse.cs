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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the DescribeStorediSCSIVolumes operation.
    /// </summary>
    public partial class DescribeStorediSCSIVolumesResponse : AmazonWebServiceResponse
    {
        private List<StorediSCSIVolume> _storediSCSIVolumes = new List<StorediSCSIVolume>();

        /// <summary>
        /// Gets and sets the property StorediSCSIVolumes. 
        /// <para>
        /// Describes a single unit of output from <a>DescribeStorediSCSIVolumes</a>. The following
        /// fields are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChapEnabled</code>: Indicates whether mutual CHAP is enabled for the iSCSI
        /// target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LunNumber</code>: The logical disk number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NetworkInterfaceId</code>: The network interface ID of the stored volume that
        /// initiator use to map the stored volume as an iSCSI target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NetworkInterfacePort</code>: The port used to communicate with iSCSI targets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PreservedExistingData</code>: Indicates when the stored volume was created,
        /// existing data on the underlying local disk was preserved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceSnapshotId</code>: If the stored volume was created from a snapshot,
        /// this field contains the snapshot ID used, e.g. <code>snap-1122aabb</code>. Otherwise,
        /// this field is not included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StorediSCSIVolumes</code>: An array of StorediSCSIVolume objects where each
        /// object contains metadata about one stored volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TargetARN</code>: The Amazon Resource Name (ARN) of the volume target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VolumeARN</code>: The Amazon Resource Name (ARN) of the stored volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VolumeDiskId</code>: The disk ID of the local disk that was specified in the
        /// <a>CreateStorediSCSIVolume</a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VolumeId</code>: The unique identifier of the storage volume, e.g. <code>vol-1122AABB</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VolumeiSCSIAttributes</code>: An <a>VolumeiSCSIAttributes</a> object that represents
        /// a collection of iSCSI attributes for one stored volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VolumeProgress</code>: Represents the percentage complete if the volume is
        /// restoring or bootstrapping that represents the percent of data transferred. This field
        /// does not appear in the response if the stored volume is not restoring or bootstrapping.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VolumeSizeInBytes</code>: The size of the volume in bytes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VolumeStatus</code>: One of the <code>VolumeStatus</code> values that indicates
        /// the state of the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VolumeType</code>: One of the enumeration values describing the type of the
        /// volume. Currently, only <code>STORED</code> volumes are supported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<StorediSCSIVolume> StorediSCSIVolumes
        {
            get { return this._storediSCSIVolumes; }
            set { this._storediSCSIVolumes = value; }
        }

        // Check to see if StorediSCSIVolumes property is set
        internal bool IsSetStorediSCSIVolumes()
        {
            return this._storediSCSIVolumes != null && this._storediSCSIVolumes.Count > 0; 
        }

    }
}