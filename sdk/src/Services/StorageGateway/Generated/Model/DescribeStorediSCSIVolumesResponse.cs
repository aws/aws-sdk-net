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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the DescribeStorediSCSIVolumes operation.
    /// </summary>
    public partial class DescribeStorediSCSIVolumesResponse : AmazonWebServiceResponse
    {
        private List<StorediSCSIVolume> _storediSCSIVolumes = AWSConfigs.InitializeCollections ? new List<StorediSCSIVolume>() : null;

        /// <summary>
        /// Gets and sets the property StorediSCSIVolumes. 
        /// <para>
        /// Describes a single unit of output from <a>DescribeStorediSCSIVolumes</a>. The following
        /// fields are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ChapEnabled</c>: Indicates whether mutual CHAP is enabled for the iSCSI target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LunNumber</c>: The logical disk number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NetworkInterfaceId</c>: The network interface ID of the stored volume that initiator
        /// use to map the stored volume as an iSCSI target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NetworkInterfacePort</c>: The port used to communicate with iSCSI targets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PreservedExistingData</c>: Indicates when the stored volume was created, existing
        /// data on the underlying local disk was preserved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SourceSnapshotId</c>: If the stored volume was created from a snapshot, this field
        /// contains the snapshot ID used, e.g. <c>snap-1122aabb</c>. Otherwise, this field is
        /// not included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StorediSCSIVolumes</c>: An array of StorediSCSIVolume objects where each object
        /// contains metadata about one stored volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TargetARN</c>: The Amazon Resource Name (ARN) of the volume target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VolumeARN</c>: The Amazon Resource Name (ARN) of the stored volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VolumeDiskId</c>: The disk ID of the local disk that was specified in the <a>CreateStorediSCSIVolume</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VolumeId</c>: The unique identifier of the storage volume, e.g. <c>vol-1122AABB</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VolumeiSCSIAttributes</c>: An <a>VolumeiSCSIAttributes</a> object that represents
        /// a collection of iSCSI attributes for one stored volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VolumeProgress</c>: Represents the percentage complete if the volume is restoring
        /// or bootstrapping that represents the percent of data transferred. This field does
        /// not appear in the response if the stored volume is not restoring or bootstrapping.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VolumeSizeInBytes</c>: The size of the volume in bytes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VolumeStatus</c>: One of the <c>VolumeStatus</c> values that indicates the state
        /// of the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VolumeType</c>: One of the enumeration values describing the type of the volume.
        /// Currently, only <c>STORED</c> volumes are supported.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StorediSCSIVolume> StorediSCSIVolumes
        {
            get { return this._storediSCSIVolumes; }
            set { this._storediSCSIVolumes = value; }
        }

        // Check to see if StorediSCSIVolumes property is set
        internal bool IsSetStorediSCSIVolumes()
        {
            return this._storediSCSIVolumes != null && (this._storediSCSIVolumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}