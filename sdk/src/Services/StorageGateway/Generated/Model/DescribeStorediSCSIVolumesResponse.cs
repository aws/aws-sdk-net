/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        ///  <b>ChapEnabled</b>: Indicates whether mutual CHAP is enabled for the iSCSI target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>LunNumber</b>: The logical disk number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NetworkInterfaceId</b>: The network interface ID of the stored volume that initiator
        /// use to map the stored volume as an iSCSI target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NetworkInterfacePort</b>: The port used to communicate with iSCSI targets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PreservedExistingData</b>: Indicates if when the stored volume was created, existing
        /// data on the underlying local disk was preserved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SourceSnapshotId</b>: If the stored volume was created from a snapshot, this field
        /// contains the snapshot ID used, e.g. snap-1122aabb. Otherwise, this field is not included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>StorediSCSIVolumes</b>: An array of StorediSCSIVolume objects where each object
        /// contains metadata about one stored volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TargetARN</b>: The Amazon Resource Name (ARN) of the volume target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VolumeARN</b>: The Amazon Resource Name (ARN) of the stored volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VolumeDiskId</b>: The disk ID of the local disk that was specified in the <a>CreateStorediSCSIVolume</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VolumeId</b>: The unique identifier of the storage volume, e.g. vol-1122AABB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VolumeiSCSIAttributes</b>: An <a>VolumeiSCSIAttributes</a> object that represents
        /// a collection of iSCSI attributes for one stored volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VolumeProgress</b>: Represents the percentage complete if the volume is restoring
        /// or bootstrapping that represents the percent of data transferred. This field does
        /// not appear in the response if the stored volume is not restoring or bootstrapping.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VolumeSizeInBytes</b>: The size of the volume in bytes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VolumeStatus</b>: One of the <code>VolumeStatus</code> values that indicates the
        /// state of the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VolumeType</b>: One of the enumeration values describing the type of the volume.
        /// Currently, on STORED volumes are supported.
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