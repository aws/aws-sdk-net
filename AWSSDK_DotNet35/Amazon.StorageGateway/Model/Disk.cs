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
    /// <para>Describes a gateway local disk.</para>
    /// </summary>
    public class Disk
    {
        
        private string diskId;
        private string diskPath;
        private string diskNode;
        private long? diskSizeInBytes;
        private DiskAllocationType diskAllocationType;
        private string diskAllocationResource;

        /// <summary>
        /// The unique device ID or other distinguishing data that identify the local disk.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 300</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DiskId
        {
            get { return this.diskId; }
            set { this.diskId = value; }
        }

        // Check to see if DiskId property is set
        internal bool IsSetDiskId()
        {
            return this.diskId != null;
        }

        /// <summary>
        /// The path of the local disk in the gateway virtual machine (VM).
        ///  
        /// </summary>
        public string DiskPath
        {
            get { return this.diskPath; }
            set { this.diskPath = value; }
        }

        // Check to see if DiskPath property is set
        internal bool IsSetDiskPath()
        {
            return this.diskPath != null;
        }

        /// <summary>
        /// The device node of the local disk as assigned by the virtualization environment.
        ///  
        /// </summary>
        public string DiskNode
        {
            get { return this.diskNode; }
            set { this.diskNode = value; }
        }

        // Check to see if DiskNode property is set
        internal bool IsSetDiskNode()
        {
            return this.diskNode != null;
        }

        /// <summary>
        /// The local disk size in bytes.
        ///  
        /// </summary>
        public long DiskSizeInBytes
        {
            get { return this.diskSizeInBytes ?? default(long); }
            set { this.diskSizeInBytes = value; }
        }

        // Check to see if DiskSizeInBytes property is set
        internal bool IsSetDiskSizeInBytes()
        {
            return this.diskSizeInBytes.HasValue;
        }

        /// <summary>
        /// One of the <a>DiskAllocationType</a> enumeration values that identifies how the local disk is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>AVAILABLE, CACHE STORAGE, STORED iSCSI VOLUME, UPLOAD BUFFER, WORKING STORAGE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public DiskAllocationType DiskAllocationType
        {
            get { return this.diskAllocationType; }
            set { this.diskAllocationType = value; }
        }

        // Check to see if DiskAllocationType property is set
        internal bool IsSetDiskAllocationType()
        {
            return this.diskAllocationType != null;
        }

        /// <summary>
        /// The iSCSI Qualified Name (IQN) that is defined for the disk. This field is not included in the response if the local disk is not defined as
        /// an iSCSI target. The format of this field is <i>targetIqn::LUNNumber::region-volumeId</i>.
        ///  
        /// </summary>
        public string DiskAllocationResource
        {
            get { return this.diskAllocationResource; }
            set { this.diskAllocationResource = value; }
        }

        // Check to see if DiskAllocationResource property is set
        internal bool IsSetDiskAllocationResource()
        {
            return this.diskAllocationResource != null;
        }
    }
}
