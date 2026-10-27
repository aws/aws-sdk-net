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
    /// The state of a GPU on a container instance, including its sharing mode and the memory
    /// that's available for new containers.
    /// </summary>
    public partial class GpuDevice
    {
        /// <summary>
        /// Gets and sets the property ContainerCount. 
        /// <para>
        /// The number of containers that Amazon ECS assigned to the GPU. This value is <c>0</c>
        /// when the sharing mode is <c>IDLE</c> and <c>1</c> when the sharing mode is <c>DEDICATED</c>.
        /// Amazon ECS counts the containers that it assigned to the GPU, not the processes that
        /// are running on it.
        /// </para>
        /// </summary>
        public int? ContainerCount { get; set; }

        /// <summary>
        /// Checks to see if the ContainerCount property is set.
        /// </summary>
        internal bool IsSetContainerCount() => this.ContainerCount.HasValue;

        /// <summary>
        /// Gets and sets the property GpuId. 
        /// <para>
        /// The ID of the GPU. This ID matches the GPU IDs in the <c>gpuIds</c> of the containers
        /// that Amazon ECS assigned to the GPU.
        /// </para>
        /// </summary>
        public string GpuId { get; set; }

        /// <summary>
        /// Checks to see if the GpuId property is set.
        /// </summary>
        internal bool IsSetGpuId() => this.GpuId != null;

        /// <summary>
        /// Gets and sets the property RemainingMemoryInMiB. 
        /// <para>
        /// The amount of GPU memory, in MiB, that's available to allocate to new containers that
        /// use the <c>nvidiaMps</c> sharing strategy. Amazon ECS calculates this value from the
        /// memory that it allocated to containers on the GPU, not from the memory that the containers
        /// use.
        /// </para>
        /// </summary>
        public int? RemainingMemoryInMiB { get; set; }

        /// <summary>
        /// Checks to see if the RemainingMemoryInMiB property is set.
        /// </summary>
        internal bool IsSetRemainingMemoryInMiB() => this.RemainingMemoryInMiB.HasValue;

        /// <summary>
        /// Gets and sets the property SharingMode. 
        /// <para>
        /// How the GPU is shared between containers.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IDLE</c> - No containers are assigned to the GPU, and all of its memory is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NVIDIA_MPS</c> - One or more containers share the GPU by using NVIDIA Multi-Process
        /// Service (MPS).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEDICATED</c> - One container has exclusive use of the GPU.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GpuSharingMode SharingMode { get; set; }

        /// <summary>
        /// Checks to see if the SharingMode property is set.
        /// </summary>
        internal bool IsSetSharingMode() => this.SharingMode != null;

        /// <summary>
        /// Gets and sets the property TotalMemoryInMiB. 
        /// <para>
        /// The total amount of GPU memory, in MiB, that the Amazon ECS container agent reported
        /// for the GPU. This is the memory that's available to containers, and it can be less
        /// than the nominal memory of the GPU.
        /// </para>
        /// </summary>
        public int? TotalMemoryInMiB { get; set; }

        /// <summary>
        /// Checks to see if the TotalMemoryInMiB property is set.
        /// </summary>
        internal bool IsSetTotalMemoryInMiB() => this.TotalMemoryInMiB.HasValue;
    }
}
