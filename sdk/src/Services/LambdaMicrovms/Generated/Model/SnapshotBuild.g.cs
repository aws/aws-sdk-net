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

namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Contains size information about a MicroVM image snapshot build.
    /// </summary>
    public partial class SnapshotBuild
    {
        /// <summary>
        /// Gets and sets the property CodeInstallSizeInBytes. 
        /// <para>
        /// The size of the installed code in bytes.
        /// </para>
        /// </summary>
        public long? CodeInstallSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the CodeInstallSizeInBytes property is set.
        /// </summary>
        internal bool IsSetCodeInstallSizeInBytes() => this.CodeInstallSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property DiskSnapshotSizeInBytes. 
        /// <para>
        /// The size of the disk snapshot in bytes.
        /// </para>
        /// </summary>
        public long? DiskSnapshotSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the DiskSnapshotSizeInBytes property is set.
        /// </summary>
        internal bool IsSetDiskSnapshotSizeInBytes() => this.DiskSnapshotSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property MemorySnapshotSizeInBytes. 
        /// <para>
        /// The size of the memory snapshot in bytes.
        /// </para>
        /// </summary>
        public long? MemorySnapshotSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the MemorySnapshotSizeInBytes property is set.
        /// </summary>
        internal bool IsSetMemorySnapshotSizeInBytes() => this.MemorySnapshotSizeInBytes.HasValue;
    }
}
