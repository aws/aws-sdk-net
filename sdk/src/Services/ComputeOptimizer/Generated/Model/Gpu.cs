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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the GPU accelerators for the instance type.
    /// </summary>
    public partial class Gpu
    {
        private int? _gpuCount;
        private int? _gpuMemorySizeInMiB;

        /// <summary>
        /// Gets and sets the property GpuCount. 
        /// <para>
        ///  The number of GPUs for the instance type. 
        /// </para>
        /// </summary>
        public int? GpuCount
        {
            get { return this._gpuCount; }
            set { this._gpuCount = value; }
        }

        // Check to see if GpuCount property is set
        internal bool IsSetGpuCount()
        {
            return this._gpuCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GpuMemorySizeInMiB. 
        /// <para>
        ///  The total size of the memory for the GPU accelerators for the instance type, in MiB.
        /// 
        /// </para>
        /// </summary>
        public int? GpuMemorySizeInMiB
        {
            get { return this._gpuMemorySizeInMiB; }
            set { this._gpuMemorySizeInMiB = value; }
        }

        // Check to see if GpuMemorySizeInMiB property is set
        internal bool IsSetGpuMemorySizeInMiB()
        {
            return this._gpuMemorySizeInMiB.HasValue; 
        }

    }
}