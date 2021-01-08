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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The type and amount of a resource to assign to a container. The supported resources
    /// include <code>GPU</code>, <code>MEMORY</code>, and <code>VCPU</code>.
    /// </summary>
    public partial class ResourceRequirement
    {
        private ResourceType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of resource to assign to a container. The supported resources include <code>GPU</code>,
        /// <code>MEMORY</code>, and <code>VCPU</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The quantity of the specified resource to reserve for the container. The values vary
        /// based on the <code>type</code> specified.
        /// </para>
        ///  <dl> <dt>type="GPU"</dt> <dd> 
        /// <para>
        /// The number of physical GPUs to reserve for the container. The number of GPUs reserved
        /// for all containers in a job shouldn't exceed the number of available GPUs on the compute
        /// resource that the job is launched on.
        /// </para>
        ///  <note> 
        /// <para>
        /// GPUs are not available for jobs running on Fargate resources.
        /// </para>
        ///  </note> </dd> <dt>type="MEMORY"</dt> <dd> 
        /// <para>
        /// For jobs running on EC2 resources, the hard limit (in MiB) of memory to present to
        /// the container. If your container attempts to exceed the memory specified here, the
        /// container is killed. This parameter maps to <code>Memory</code> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--memory</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. You must specify at least 4 MiB of memory for a job. This is required but
        /// can be specified in several places for multi-node parallel (MNP) jobs. It must be
        /// specified for each node at least once. This parameter maps to <code>Memory</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--memory</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're trying to maximize your resource utilization by providing your jobs as much
        /// memory as possible for a particular instance type, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/memory-management.html">Memory
        /// Management</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For jobs running on Fargate resources, then <code>value</code> is the hard limit (in
        /// MiB), and must match one of the supported values and the <code>VCPU</code> values
        /// must be one of the values supported for that memory value.
        /// </para>
        ///  <dl> <dt>value = 512</dt> <dd> 
        /// <para>
        ///  <code>VCPU</code> = 0.25
        /// </para>
        ///  </dd> <dt>value = 1024</dt> <dd> 
        /// <para>
        ///  <code>VCPU</code> = 0.25 or 0.5
        /// </para>
        ///  </dd> <dt>value = 2048</dt> <dd> 
        /// <para>
        ///  <code>VCPU</code> = 0.25, 0.5, or 1
        /// </para>
        ///  </dd> <dt>value = 3072</dt> <dd> 
        /// <para>
        ///  <code>VCPU</code> = 0.5, or 1
        /// </para>
        ///  </dd> <dt>value = 4096</dt> <dd> 
        /// <para>
        ///  <code>VCPU</code> = 0.5, 1, or 2
        /// </para>
        ///  </dd> <dt>value = 5120, 6144, or 7168</dt> <dd> 
        /// <para>
        ///  <code>VCPU</code> = 1 or 2
        /// </para>
        ///  </dd> <dt>value = 8192</dt> <dd> 
        /// <para>
        ///  <code>VCPU</code> = 1, 2, or 4
        /// </para>
        ///  </dd> <dt>value = 9216, 10240, 11264, 12288, 13312, 14336, 15360, or 16384</dt> <dd>
        /// 
        /// <para>
        ///  <code>VCPU</code> = 2 or 4
        /// </para>
        ///  </dd> <dt>value = 17408, 18432, 19456, 20480, 21504, 22528, 23552, 24576, 25600,
        /// 26624, 27648, 28672, 29696, or 30720</dt> <dd> 
        /// <para>
        ///  <code>VCPU</code> = 4
        /// </para>
        ///  </dd> </dl> </dd> <dt>type="VCPU"</dt> <dd> 
        /// <para>
        /// The number of vCPUs reserved for the container. This parameter maps to <code>CpuShares</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--cpu-shares</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. Each vCPU is equivalent to 1,024 CPU shares. For EC2 resources, you must
        /// specify at least one vCPU. This is required but can be specified in several places;
        /// it must be specified for each node at least once.
        /// </para>
        ///  
        /// <para>
        /// For jobs running on Fargate resources, then <code>value</code> must match one of the
        /// supported values and the <code>MEMORY</code> values must be one of the values supported
        /// for that VCPU value. The supported values are 0.25, 0.5, 1, 2, and 4
        /// </para>
        ///  <dl> <dt>value = 0.25</dt> <dd> 
        /// <para>
        ///  <code>MEMORY</code> = 512, 1024, or 2048
        /// </para>
        ///  </dd> <dt>value = 0.5</dt> <dd> 
        /// <para>
        ///  <code>MEMORY</code> = 1024, 2048, 3072, or 4096
        /// </para>
        ///  </dd> <dt>value = 1</dt> <dd> 
        /// <para>
        ///  <code>MEMORY</code> = 2048, 3072, 4096, 5120, 6144, 7168, or 8192
        /// </para>
        ///  </dd> <dt>value = 2</dt> <dd> 
        /// <para>
        ///  <code>MEMORY</code> = 4096, 5120, 6144, 7168, 8192, 9216, 10240, 11264, 12288, 13312,
        /// 14336, 15360, or 16384
        /// </para>
        ///  </dd> <dt>value = 4</dt> <dd> 
        /// <para>
        ///  <code>MEMORY</code> = 8192, 9216, 10240, 11264, 12288, 13312, 14336, 15360, 16384,
        /// 17408, 18432, 19456, 20480, 21504, 22528, 23552, 24576, 25600, 26624, 27648, 28672,
        /// 29696, or 30720
        /// </para>
        ///  </dd> </dl> </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}