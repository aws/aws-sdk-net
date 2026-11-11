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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the instance store features that are supported by the instance type.
    /// </summary>
    public partial class InstanceStorageInfo
    {
        /// <summary>
        /// Gets and sets the property Disks. 
        /// <para>
        /// Describes the disks that are available for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DiskInfo> Disks { get; set; } = AWSConfigs.InitializeCollections ? new List<DiskInfo>() : null;

        /// <summary>
        /// Checks to see if the Disks property is set.
        /// </summary>
        internal bool IsSetDisks() => this.Disks != null && (this.Disks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncryptionSupport. 
        /// <para>
        /// Indicates whether data is encrypted at rest.
        /// </para>
        /// </summary>
        public InstanceStorageEncryptionSupport EncryptionSupport { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionSupport property is set.
        /// </summary>
        internal bool IsSetEncryptionSupport() => this.EncryptionSupport != null;

        /// <summary>
        /// Gets and sets the property NvmeSupport. 
        /// <para>
        /// Indicates whether non-volatile memory express (NVMe) is supported.
        /// </para>
        /// </summary>
        public EphemeralNvmeSupport NvmeSupport { get; set; }

        /// <summary>
        /// Checks to see if the NvmeSupport property is set.
        /// </summary>
        internal bool IsSetNvmeSupport() => this.NvmeSupport != null;

        /// <summary>
        /// Gets and sets the property TotalSizeInGB. 
        /// <para>
        /// The total size of the disks, in GB.
        /// </para>
        /// </summary>
        public long? TotalSizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the TotalSizeInGB property is set.
        /// </summary>
        internal bool IsSetTotalSizeInGB() => this.TotalSizeInGB.HasValue;
    }
}
