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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private int? _accelerators;
        private int? _count;
        private ClusterInstanceType _instanceType;
        private float? _memoryInGiB;
        private float? _vCpu;

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
        [AWSProperty(Min=0, Max=10000000)]
        public int? Accelerators
        {
            get { return this._accelerators; }
            set { this._accelerators = value; }
        }

        // Check to see if Accelerators property is set
        internal bool IsSetAccelerators()
        {
            return this._accelerators.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of instances to add to the instance group of a SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000)]
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the instance group for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

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
        [AWSProperty(Min=0, Max=10000000)]
        public float? MemoryInGiB
        {
            get { return this._memoryInGiB; }
            set { this._memoryInGiB = value; }
        }

        // Check to see if MemoryInGiB property is set
        internal bool IsSetMemoryInGiB()
        {
            return this._memoryInGiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VCpu. 
        /// <para>
        /// The number of vCPU to allocate. If you specify a value only for vCPU, SageMaker AI
        /// automatically allocates ratio-based values for MemoryInGiB based on this vCPU parameter.
        /// For example, if you allocate 20 out of 40 total vCPU, SageMaker AI uses the ratio
        /// of 0.5 and allocates values to MemoryInGiB. Accelerators are set to 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000)]
        public float? VCpu
        {
            get { return this._vCpu; }
            set { this._vCpu = value; }
        }

        // Check to see if VCpu property is set
        internal bool IsSetVCpu()
        {
            return this._vCpu.HasValue; 
        }

    }
}