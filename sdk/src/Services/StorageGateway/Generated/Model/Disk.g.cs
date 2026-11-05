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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DiskAllocationResource. 
        /// <para>
        /// The iSCSI qualified name (IQN) that is defined for a disk. This field is not included
        /// in the response if the local disk is not defined as an iSCSI target. The format of
        /// this field is <i>targetIqn::LUNNumber::region-volumeId</i>.
        /// </para>
        /// </summary>
        public string DiskAllocationResource { get; set; }

        /// <summary>
        /// Checks to see if the DiskAllocationResource property is set.
        /// </summary>
        internal bool IsSetDiskAllocationResource() => this.DiskAllocationResource != null;

        /// <summary>
        /// Gets and sets the property DiskAllocationType.
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string DiskAllocationType { get; set; }

        /// <summary>
        /// Checks to see if the DiskAllocationType property is set.
        /// </summary>
        internal bool IsSetDiskAllocationType() => this.DiskAllocationType != null;

        /// <summary>
        /// Gets and sets the property DiskAttributeList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> DiskAttributeList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DiskAttributeList property is set.
        /// </summary>
        internal bool IsSetDiskAttributeList() => this.DiskAttributeList != null && (this.DiskAttributeList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DiskId. 
        /// <para>
        /// The unique device ID or other distinguishing data that identifies a local disk.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string DiskId { get; set; }

        /// <summary>
        /// Checks to see if the DiskId property is set.
        /// </summary>
        internal bool IsSetDiskId() => this.DiskId != null;

        /// <summary>
        /// Gets and sets the property DiskNode. 
        /// <para>
        /// The device node of a local disk as assigned by the virtualization environment.
        /// </para>
        /// </summary>
        public string DiskNode { get; set; }

        /// <summary>
        /// Checks to see if the DiskNode property is set.
        /// </summary>
        internal bool IsSetDiskNode() => this.DiskNode != null;

        /// <summary>
        /// Gets and sets the property DiskPath. 
        /// <para>
        /// The path of a local disk in the gateway virtual machine (VM).
        /// </para>
        /// </summary>
        public string DiskPath { get; set; }

        /// <summary>
        /// Checks to see if the DiskPath property is set.
        /// </summary>
        internal bool IsSetDiskPath() => this.DiskPath != null;

        /// <summary>
        /// Gets and sets the property DiskSizeInBytes. 
        /// <para>
        /// The local disk size in bytes.
        /// </para>
        /// </summary>
        public long? DiskSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the DiskSizeInBytes property is set.
        /// </summary>
        internal bool IsSetDiskSizeInBytes() => this.DiskSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property DiskStatus. 
        /// <para>
        /// A value that represents the status of a local disk.
        /// </para>
        /// </summary>
        public string DiskStatus { get; set; }

        /// <summary>
        /// Checks to see if the DiskStatus property is set.
        /// </summary>
        internal bool IsSetDiskStatus() => this.DiskStatus != null;
    }
}
