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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
        private long? _codeInstallSizeInBytes;
        private long? _diskSnapshotSizeInBytes;
        private long? _memorySnapshotSizeInBytes;

        /// <summary>
        /// Gets and sets the property CodeInstallSizeInBytes. 
        /// <para>
        /// The size of the installed code in bytes.
        /// </para>
        /// </summary>
        public long? CodeInstallSizeInBytes
        {
            get { return this._codeInstallSizeInBytes; }
            set { this._codeInstallSizeInBytes = value; }
        }

        // Check to see if CodeInstallSizeInBytes property is set
        internal bool IsSetCodeInstallSizeInBytes()
        {
            return this._codeInstallSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiskSnapshotSizeInBytes. 
        /// <para>
        /// The size of the disk snapshot in bytes.
        /// </para>
        /// </summary>
        public long? DiskSnapshotSizeInBytes
        {
            get { return this._diskSnapshotSizeInBytes; }
            set { this._diskSnapshotSizeInBytes = value; }
        }

        // Check to see if DiskSnapshotSizeInBytes property is set
        internal bool IsSetDiskSnapshotSizeInBytes()
        {
            return this._diskSnapshotSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemorySnapshotSizeInBytes. 
        /// <para>
        /// The size of the memory snapshot in bytes.
        /// </para>
        /// </summary>
        public long? MemorySnapshotSizeInBytes
        {
            get { return this._memorySnapshotSizeInBytes; }
            set { this._memorySnapshotSizeInBytes = value; }
        }

        // Check to see if MemorySnapshotSizeInBytes property is set
        internal bool IsSetMemorySnapshotSizeInBytes()
        {
            return this._memorySnapshotSizeInBytes.HasValue; 
        }

    }
}