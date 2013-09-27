/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing a list of DescribeStorediSCSIVolumesOutput$StorediSCSIVolumes.</para>
    /// </summary>
    public class DescribeStorediSCSIVolumesResult  
    {
        
        private List<StorediSCSIVolume> storediSCSIVolumes = new List<StorediSCSIVolume>();

        /// <summary>
        /// Describes a single unit of output from <a>DescribeStorediSCSIVolumes</a>. The following fields are returned: <ul> <li> <b>ChapEnabled</b>:
        /// Indicates whether mutual CHAP is enabled for the iSCSI target. </li> <li> <b>LunNumber</b>: The logical disk number. </li> <li>
        /// <b>NetworkInterfaceId</b>: The network interface ID of the stored volume that initiator use to map the stored volume as an iSCSI target.
        /// </li> <li> <b>NetworkInterfacePort</b>: The port used to communicate with iSCSI targets. </li> <li> <b>PreservedExistingData</b>: Indicates
        /// if when the stored volume was created, existing data on the underlying local disk was preserved. </li> <li> <b>SourceSnapshotId</b>: If the
        /// stored volume was created from a snapshot, this field contains the snapshot ID used, e.g. snap-1122aabb. Otherwise, this field is not
        /// included. </li> <li> <b>StorediSCSIVolumes</b>: An array of StorediSCSIVolume objects where each object contains metadata about one stored
        /// volume. </li> <li> <b>TargetARN</b>: The Amazon Resource Name (ARN) of the volume target. </li> <li> <b>VolumeARN</b>: The Amazon Resource
        /// Name (ARN) of the stored volume. </li> <li> <b>VolumeDiskId</b>: The disk ID of the local disk that was specified in the
        /// <a>CreateStorediSCSIVolume</a> operation. </li> <li> <b>VolumeId</b>: The unique identifier of the storage volume, e.g. vol-1122AABB. </li>
        /// <li> <b>VolumeiSCSIAttributes</b>: An <a>VolumeiSCSIAttributes</a> object that represents a collection of iSCSI attributes for one stored
        /// volume. </li> <li> <b>VolumeProgress</b>: Represents the percentage complete if the volume is restoring or bootstrapping that represents the
        /// percent of data transferred. This field does not appear in the response if the stored volume is not restoring or bootstrapping. </li> <li>
        /// <b>VolumeSizeInBytes</b>: The size of the volume in bytes. </li> <li> <b>VolumeStatus</b>: One of the <a>VolumeStatus</a> values that
        /// indicates the state of the volume. </li> <li> <b>VolumeType</b>: One of the enumeration values describing the type of the volume. Currently,
        /// on STORED volumes are supported. </li> </ul>
        ///  
        /// </summary>
        public List<StorediSCSIVolume> StorediSCSIVolumes
        {
            get { return this.storediSCSIVolumes; }
            set { this.storediSCSIVolumes = value; }
        }
        /// <summary>
        /// Adds elements to the StorediSCSIVolumes collection
        /// </summary>
        /// <param name="storediSCSIVolumes">The values to add to the StorediSCSIVolumes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStorediSCSIVolumesResult WithStorediSCSIVolumes(params StorediSCSIVolume[] storediSCSIVolumes)
        {
            foreach (StorediSCSIVolume element in storediSCSIVolumes)
            {
                this.storediSCSIVolumes.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the StorediSCSIVolumes collection
        /// </summary>
        /// <param name="storediSCSIVolumes">The values to add to the StorediSCSIVolumes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStorediSCSIVolumesResult WithStorediSCSIVolumes(IEnumerable<StorediSCSIVolume> storediSCSIVolumes)
        {
            foreach (StorediSCSIVolume element in storediSCSIVolumes)
            {
                this.storediSCSIVolumes.Add(element);
            }

            return this;
        }

        // Check to see if StorediSCSIVolumes property is set
        internal bool IsSetStorediSCSIVolumes()
        {
            return this.storediSCSIVolumes.Count > 0;       
        }
    }
}
