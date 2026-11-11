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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The GPU memory and compute limits for a container that shares a GPU by using NVIDIA
    /// Multi-Process Service (MPS). Amazon ECS assigns the container a single GPU that has
    /// enough memory available. Other containers that use MPS can share the same GPU.
    /// </summary>
    public partial class NvidiaMpsAllocation
    {
        /// <summary>
        /// Gets and sets the property MaxComputePercent. 
        /// <para>
        /// The maximum percentage of the GPU's compute capacity that the container can use. Amazon
        /// ECS sets the <c>CUDA_MPS_ACTIVE_THREAD_PERCENTAGE</c> environment variable in the
        /// container to this value. This value is a limit, not a reservation.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this parameter, Amazon ECS doesn't set <c>CUDA_MPS_ACTIVE_THREAD_PERCENTAGE</c>,
        /// and the active thread percentage of the MPS server on the container instance applies.
        /// By default, this is 100 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxComputePercent { get; set; }

        /// <summary>
        /// Checks to see if the MaxComputePercent property is set.
        /// </summary>
        internal bool IsSetMaxComputePercent() => this.MaxComputePercent.HasValue;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount of GPU memory, in MiB, to allocate to the container. Amazon ECS assigns
        /// the container a GPU that has at least the specified amount of memory available, and
        /// sets the <c>CUDA_MPS_PINNED_DEVICE_MEM_LIMIT</c> environment variable in the container
        /// to limit its memory to this amount. The memory must be available on a single GPU.
        /// If more than one container in a task uses <c>nvidiaMps</c>, Amazon ECS assigns them
        /// the same GPU, which must have enough memory available for all of them.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory.HasValue;
    }
}
