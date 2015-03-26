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
    /// 
    /// </summary>
    public partial class Disk
    {
        private string _diskAllocationResource;
        private string _diskAllocationType;
        private string _diskId;
        private string _diskNode;
        private string _diskPath;
        private long? _diskSizeInBytes;
        private string _diskStatus;

        /// <summary>
        /// Gets and sets the property DiskAllocationResource.
        /// </summary>
        public string DiskAllocationResource
        {
            get { return this._diskAllocationResource; }
            set { this._diskAllocationResource = value; }
        }

        // Check to see if DiskAllocationResource property is set
        internal bool IsSetDiskAllocationResource()
        {
            return this._diskAllocationResource != null;
        }

        /// <summary>
        /// Gets and sets the property DiskAllocationType.
        /// </summary>
        public string DiskAllocationType
        {
            get { return this._diskAllocationType; }
            set { this._diskAllocationType = value; }
        }

        // Check to see if DiskAllocationType property is set
        internal bool IsSetDiskAllocationType()
        {
            return this._diskAllocationType != null;
        }

        /// <summary>
        /// Gets and sets the property DiskId.
        /// </summary>
        public string DiskId
        {
            get { return this._diskId; }
            set { this._diskId = value; }
        }

        // Check to see if DiskId property is set
        internal bool IsSetDiskId()
        {
            return this._diskId != null;
        }

        /// <summary>
        /// Gets and sets the property DiskNode.
        /// </summary>
        public string DiskNode
        {
            get { return this._diskNode; }
            set { this._diskNode = value; }
        }

        // Check to see if DiskNode property is set
        internal bool IsSetDiskNode()
        {
            return this._diskNode != null;
        }

        /// <summary>
        /// Gets and sets the property DiskPath.
        /// </summary>
        public string DiskPath
        {
            get { return this._diskPath; }
            set { this._diskPath = value; }
        }

        // Check to see if DiskPath property is set
        internal bool IsSetDiskPath()
        {
            return this._diskPath != null;
        }

        /// <summary>
        /// Gets and sets the property DiskSizeInBytes.
        /// </summary>
        public long DiskSizeInBytes
        {
            get { return this._diskSizeInBytes.GetValueOrDefault(); }
            set { this._diskSizeInBytes = value; }
        }

        // Check to see if DiskSizeInBytes property is set
        internal bool IsSetDiskSizeInBytes()
        {
            return this._diskSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiskStatus.
        /// </summary>
        public string DiskStatus
        {
            get { return this._diskStatus; }
            set { this._diskStatus = value; }
        }

        // Check to see if DiskStatus property is set
        internal bool IsSetDiskStatus()
        {
            return this._diskStatus != null;
        }

    }
}