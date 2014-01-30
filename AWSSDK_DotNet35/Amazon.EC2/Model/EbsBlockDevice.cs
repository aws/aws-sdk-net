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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describe an Amazon EBS block device.</para>
    /// </summary>
    public class EbsBlockDevice
    {
        
        private string snapshotId;
        private int? volumeSize;
        private bool? deleteOnTermination;
        private VolumeType volumeType;
        private int? iops;


        /// <summary>
        /// The ID of the snapshot.
        ///  
        /// </summary>
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;
        }

        /// <summary>
        /// The size of the volume, in GiB. Constraints: If the volume type is <c>io1</c>, the minimum size of the volume is 10 GiB. Default: If you're
        /// creating the volume from a snapshot and don't specify a volume size, the default is the snapshot size.
        ///  
        /// </summary>
        public int VolumeSize
        {
            get { return this.volumeSize ?? default(int); }
            set { this.volumeSize = value; }
        }

        // Check to see if VolumeSize property is set
        internal bool IsSetVolumeSize()
        {
            return this.volumeSize.HasValue;
        }

        /// <summary>
        /// Indicates whether the Amazon EBS volume is deleted on instance termination.
        ///  
        /// </summary>
        public bool DeleteOnTermination
        {
            get { return this.deleteOnTermination ?? default(bool); }
            set { this.deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this.deleteOnTermination.HasValue;
        }

        /// <summary>
        /// The volume type. Default: <c>standard</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>standard, io1</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VolumeType VolumeType
        {
            get { return this.volumeType; }
            set { this.volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this.volumeType != null;
        }

        /// <summary>
        /// The number of I/O operations per second (IOPS) that the volume supports. Constraint: Range is 100 to 4000. Condition: Required when the
        /// volume type is <c>io1</c>; not used with <c>standard</c> volumes.
        ///  
        /// </summary>
        public int Iops
        {
            get { return this.iops ?? default(int); }
            set { this.iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this.iops.HasValue;
        }
    }
}
