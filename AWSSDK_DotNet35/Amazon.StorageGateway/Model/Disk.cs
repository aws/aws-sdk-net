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
    public class Disk
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

        // Check to see if DiskAllocationResource property is set
        internal bool IsSetDiskAllocationResource()
        {
            return this.diskAllocationResource != null;
        }
    }
}
