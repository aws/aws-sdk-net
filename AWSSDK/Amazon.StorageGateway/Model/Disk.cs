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
    /// <summary>Disk
    /// </summary>
    public partial class Disk
    {
        
        private string diskId;
        private string diskPath;
        private string diskNode;
        private long? diskSizeInBytes;
        private string diskAllocationType;
        private string diskAllocationResource;
        public string DiskId
        {
            get { return this.diskId; }
            set { this.diskId = value; }
        }

        /// <summary>
        /// Sets the DiskId property
        /// </summary>
        /// <param name="diskId">The value to set for the DiskId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Disk WithDiskId(string diskId)
        {
            this.diskId = diskId;
            return this;
        }
            

        // Check to see if DiskId property is set
        internal bool IsSetDiskId()
        {
            return this.diskId != null;
        }
        public string DiskPath
        {
            get { return this.diskPath; }
            set { this.diskPath = value; }
        }

        /// <summary>
        /// Sets the DiskPath property
        /// </summary>
        /// <param name="diskPath">The value to set for the DiskPath property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Disk WithDiskPath(string diskPath)
        {
            this.diskPath = diskPath;
            return this;
        }
            

        // Check to see if DiskPath property is set
        internal bool IsSetDiskPath()
        {
            return this.diskPath != null;
        }
        public string DiskNode
        {
            get { return this.diskNode; }
            set { this.diskNode = value; }
        }

        /// <summary>
        /// Sets the DiskNode property
        /// </summary>
        /// <param name="diskNode">The value to set for the DiskNode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Disk WithDiskNode(string diskNode)
        {
            this.diskNode = diskNode;
            return this;
        }
            

        // Check to see if DiskNode property is set
        internal bool IsSetDiskNode()
        {
            return this.diskNode != null;
        }
        public long DiskSizeInBytes
        {
            get { return this.diskSizeInBytes ?? default(long); }
            set { this.diskSizeInBytes = value; }
        }

        /// <summary>
        /// Sets the DiskSizeInBytes property
        /// </summary>
        /// <param name="diskSizeInBytes">The value to set for the DiskSizeInBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Disk WithDiskSizeInBytes(long diskSizeInBytes)
        {
            this.diskSizeInBytes = diskSizeInBytes;
            return this;
        }
            

        // Check to see if DiskSizeInBytes property is set
        internal bool IsSetDiskSizeInBytes()
        {
            return this.diskSizeInBytes.HasValue;
        }
        public string DiskAllocationType
        {
            get { return this.diskAllocationType; }
            set { this.diskAllocationType = value; }
        }

        /// <summary>
        /// Sets the DiskAllocationType property
        /// </summary>
        /// <param name="diskAllocationType">The value to set for the DiskAllocationType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Disk WithDiskAllocationType(string diskAllocationType)
        {
            this.diskAllocationType = diskAllocationType;
            return this;
        }
            

        // Check to see if DiskAllocationType property is set
        internal bool IsSetDiskAllocationType()
        {
            return this.diskAllocationType != null;
        }
        public string DiskAllocationResource
        {
            get { return this.diskAllocationResource; }
            set { this.diskAllocationResource = value; }
        }

        /// <summary>
        /// Sets the DiskAllocationResource property
        /// </summary>
        /// <param name="diskAllocationResource">The value to set for the DiskAllocationResource property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Disk WithDiskAllocationResource(string diskAllocationResource)
        {
            this.diskAllocationResource = diskAllocationResource;
            return this;
        }
            

        // Check to see if DiskAllocationResource property is set
        internal bool IsSetDiskAllocationResource()
        {
            return this.diskAllocationResource != null;
        }
    }
}
