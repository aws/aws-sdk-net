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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
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
namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The type and amount of a resource to assign to a container. The supported resources
    /// include <c>GPU</c>, <c>MEMORY</c>, and <c>VCPU</c>.
    /// </summary>
    public partial class BatchResourceRequirement
    {
        private BatchResourceRequirementType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of resource to assign to a container. The supported resources include <c>GPU</c>,
        /// <c>MEMORY</c>, and <c>VCPU</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchResourceRequirementType Type
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
        /// based on the <c>type</c> specified.
        /// </para>
        ///  <dl> <dt>type="GPU"</dt> <dd> 
        /// <para>
        /// The number of physical GPUs to reserve for the container. Make sure that the number
        /// of GPUs reserved for all containers in a job doesn't exceed the number of available
        /// GPUs on the compute resource that the job is launched on.
        /// </para>
        ///  <note> 
        /// <para>
        /// GPUs aren't available for jobs that are running on Fargate resources.
        /// </para>
        ///  </note> </dd> <dt>type="MEMORY"</dt> <dd> 
        /// <para>
        /// The memory hard limit (in MiB) present to the container. This parameter is supported
        /// for jobs that are running on EC2 resources. If your container attempts to exceed the
        /// memory specified, the container is terminated. This parameter maps to <c>Memory</c>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container"> Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <c>--memory</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. You must specify at least 4 MiB of memory for a job. This is required but
        /// can be specified in several places for multi-node parallel (MNP) jobs. It must be
        /// specified for each node at least once. This parameter maps to <c>Memory</c> in the
        /// <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container"> Create a container</a>
        /// section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker Remote API</a>
        /// and the <c>--memory</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're trying to maximize your resource utilization by providing your jobs as much
        /// memory as possible for a particular instance type, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/memory-management.html">Memory
        /// management</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For jobs that are running on Fargate resources, then <c>value</c> is the hard limit
        /// (in MiB), and must match one of the supported values and the <c>VCPU</c> values must
        /// be one of the values supported for that memory value.
        /// </para>
        ///  <dl> <dt>value = 512</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 0.25
        /// </para>
        ///  </dd> <dt>value = 1024</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 0.25 or 0.5
        /// </para>
        ///  </dd> <dt>value = 2048</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 0.25, 0.5, or 1
        /// </para>
        ///  </dd> <dt>value = 3072</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 0.5, or 1
        /// </para>
        ///  </dd> <dt>value = 4096</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 0.5, 1, or 2
        /// </para>
        ///  </dd> <dt>value = 5120, 6144, or 7168</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 1 or 2
        /// </para>
        ///  </dd> <dt>value = 8192</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 1, 2, 4, or 8
        /// </para>
        ///  </dd> <dt>value = 9216, 10240, 11264, 12288, 13312, 14336, or 15360</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 2 or 4
        /// </para>
        ///  </dd> <dt>value = 16384</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 2, 4, or 8
        /// </para>
        ///  </dd> <dt>value = 17408, 18432, 19456, 21504, 22528, 23552, 25600, 26624, 27648,
        /// 29696, or 30720</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 4
        /// </para>
        ///  </dd> <dt>value = 20480, 24576, or 28672</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 4 or 8
        /// </para>
        ///  </dd> <dt>value = 36864, 45056, 53248, or 61440</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 8
        /// </para>
        ///  </dd> <dt>value = 32768, 40960, 49152, or 57344</dt> <dd> 
        /// <para>
        ///  <c>VCPU</c> = 8 or 16
        /// </para>
        ///  </dd> <dt>value = 65536, 73728, 81920, 90112, 98304, 106496, 114688, or 122880</dt>
        /// <dd> 
        /// <para>
        ///  <c>VCPU</c> = 16
        /// </para>
        ///  </dd> </dl> </dd> <dt>type="VCPU"</dt> <dd> 
        /// <para>
        /// The number of vCPUs reserved for the container. This parameter maps to <c>CpuShares</c>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container"> Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <c>--cpu-shares</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. Each vCPU is equivalent to 1,024 CPU shares. For EC2 resources, you must
        /// specify at least one vCPU. This is required but can be specified in several places;
        /// it must be specified for each node at least once.
        /// </para>
        ///  
        /// <para>
        /// The default for the Fargate On-Demand vCPU resource count quota is 6 vCPUs. For more
        /// information about Fargate quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/ecs-service.html#service-quotas-fargate">Fargate
        /// quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// For jobs that are running on Fargate resources, then <c>value</c> must match one of
        /// the supported values and the <c>MEMORY</c> values must be one of the values supported
        /// for that <c>VCPU</c> value. The supported values are 0.25, 0.5, 1, 2, 4, 8, and 16
        /// </para>
        ///  <dl> <dt>value = 0.25</dt> <dd> 
        /// <para>
        ///  <c>MEMORY</c> = 512, 1024, or 2048
        /// </para>
        ///  </dd> <dt>value = 0.5</dt> <dd> 
        /// <para>
        ///  <c>MEMORY</c> = 1024, 2048, 3072, or 4096
        /// </para>
        ///  </dd> <dt>value = 1</dt> <dd> 
        /// <para>
        ///  <c>MEMORY</c> = 2048, 3072, 4096, 5120, 6144, 7168, or 8192
        /// </para>
        ///  </dd> <dt>value = 2</dt> <dd> 
        /// <para>
        ///  <c>MEMORY</c> = 4096, 5120, 6144, 7168, 8192, 9216, 10240, 11264, 12288, 13312, 14336,
        /// 15360, or 16384
        /// </para>
        ///  </dd> <dt>value = 4</dt> <dd> 
        /// <para>
        ///  <c>MEMORY</c> = 8192, 9216, 10240, 11264, 12288, 13312, 14336, 15360, 16384, 17408,
        /// 18432, 19456, 20480, 21504, 22528, 23552, 24576, 25600, 26624, 27648, 28672, 29696,
        /// or 30720
        /// </para>
        ///  </dd> <dt>value = 8</dt> <dd> 
        /// <para>
        ///  <c>MEMORY</c> = 16384, 20480, 24576, 28672, 32768, 36864, 40960, 45056, 49152, 53248,
        /// 57344, or 61440 
        /// </para>
        ///  </dd> <dt>value = 16</dt> <dd> 
        /// <para>
        ///  <c>MEMORY</c> = 32768, 40960, 49152, 57344, 65536, 73728, 81920, 90112, 98304, 106496,
        /// 114688, or 122880 
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