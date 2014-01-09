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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para>The Ebs data type.</para>
    /// </summary>
    public class Ebs
    {
        
        private string snapshotId;
        private int? volumeSize;
        private string volumeType;
        private bool? deleteOnTermination;
        private int? iops;


        /// <summary>
        /// The snapshot ID.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
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
        /// The volume size, in gigabytes. Valid values: If the volume type is <c>io1</c>, the minimum size of the volume is 10. Default: If you're
        /// creating the volume from a snapshot, and you don't specify a volume size, the default is the snapshot size. Required: Required when the
        /// volume type is <c>io1</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
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
        /// The volume type. Valid values: <c>standard | io1</c> Default: <c>standard</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VolumeType
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
        /// Indicates whether to delete the volume on instance termination. Default: <c>true</c>
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
        /// The number of I/O operations per second (IOPS) that the volume supports. The maximum ratio of IOPS to volume size is 30.0 Valid Values:
        /// Range is 100 to 4000. Default: None.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>100 - 4000</description>
        ///     </item>
        /// </list>
        /// </para>
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
