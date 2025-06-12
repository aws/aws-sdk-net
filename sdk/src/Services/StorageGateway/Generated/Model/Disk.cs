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
    /// Represents a gateway's local disk.
    /// </summary>
    public partial class Disk
    {
        private string _diskAllocationResource;
        private string _diskAllocationType;
        private List<string> _diskAttributeList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _diskId;
        private string _diskNode;
        private string _diskPath;
        private long? _diskSizeInBytes;
        private string _diskStatus;

        /// <summary>
        /// Gets and sets the property DiskAllocationResource. 
        /// <para>
        /// The iSCSI qualified name (IQN) that is defined for a disk. This field is not included
        /// in the response if the local disk is not defined as an iSCSI target. The format of
        /// this field is <i>targetIqn::LUNNumber::region-volumeId</i>.
        /// </para>
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
        [AWSProperty(Min=3, Max=100)]
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
        /// Gets and sets the property DiskAttributeList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> DiskAttributeList
        {
            get { return this._diskAttributeList; }
            set { this._diskAttributeList = value; }
        }

        // Check to see if DiskAttributeList property is set
        internal bool IsSetDiskAttributeList()
        {
            return this._diskAttributeList != null && (this._diskAttributeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DiskId. 
        /// <para>
        /// The unique device ID or other distinguishing data that identifies a local disk.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
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
        /// <para>
        /// The device node of a local disk as assigned by the virtualization environment.
        /// </para>
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
        /// <para>
        /// The path of a local disk in the gateway virtual machine (VM).
        /// </para>
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
        /// <para>
        /// The local disk size in bytes.
        /// </para>
        /// </summary>
        public long? DiskSizeInBytes
        {
            get { return this._diskSizeInBytes; }
            set { this._diskSizeInBytes = value; }
        }

        // Check to see if DiskSizeInBytes property is set
        internal bool IsSetDiskSizeInBytes()
        {
            return this._diskSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiskStatus. 
        /// <para>
        /// A value that represents the status of a local disk.
        /// </para>
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