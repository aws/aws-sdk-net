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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration of the resources used for the compute allocation definition.
    /// </summary>
    public partial class ComputeQuotaResourceConfig
    {
        /// <summary>
        /// Gets and sets the property AcceleratorPartition. 
        /// <para>
        /// The accelerator partition configuration for fractional GPU allocation.
        /// </para>
        /// </summary>
        public AcceleratorPartitionConfig AcceleratorPartition { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorPartition property is set.
        /// </summary>
        internal bool IsSetAcceleratorPartition() => this.AcceleratorPartition != null;

        /// <summary>
        /// Gets and sets the property Accelerators. 
        /// <para>
        /// The number of accelerators to allocate. If you don't specify a value for vCPU and
        /// MemoryInGiB, SageMaker AI automatically allocates ratio-based values for those parameters
        /// based on the number of accelerators you provide. For example, if you allocate 16 out
        /// of 32 total accelerators, SageMaker AI uses the ratio of 0.5 and allocates values
        /// to vCPU and MemoryInGiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000)]
        public int? Accelerators { get; set; }

        /// <summary>
        /// Checks to see if the Accelerators property is set.
        /// </summary>
        internal bool IsSetAccelerators() => this.Accelerators.HasValue;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of instances to add to the instance group of a SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the instance group for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property MemoryInGiB. 
        /// <para>
        /// The amount of memory in GiB to allocate. If you specify a value only for this parameter,
        /// SageMaker AI automatically allocates a ratio-based value for vCPU based on this memory
        /// that you provide. For example, if you allocate 200 out of 400 total memory in GiB,
        /// SageMaker AI uses the ratio of 0.5 and allocates values to vCPU. Accelerators are
        /// set to 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000)]
        public float? MemoryInGiB { get; set; }

        /// <summary>
        /// Checks to see if the MemoryInGiB property is set.
        /// </summary>
        internal bool IsSetMemoryInGiB() => this.MemoryInGiB.HasValue;

        /// <summary>
        /// Gets and sets the property VCpu. 
        /// <para>
        /// The number of vCPU to allocate. If you specify a value only for vCPU, SageMaker AI
        /// automatically allocates ratio-based values for MemoryInGiB based on this vCPU parameter.
        /// For example, if you allocate 20 out of 40 total vCPU, SageMaker AI uses the ratio
        /// of 0.5 and allocates values to MemoryInGiB. Accelerators are set to 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000)]
        public float? VCpu { get; set; }

        /// <summary>
        /// Checks to see if the VCpu property is set.
        /// </summary>
        internal bool IsSetVCpu() => this.VCpu.HasValue;
    }
}
