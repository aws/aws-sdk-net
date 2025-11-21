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
    /// Configuration for allocating accelerator partitions.
    /// </summary>
    public partial class AcceleratorPartitionConfig
    {
        private int? _count;
        private MIGProfileType _type;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of accelerator partitions to allocate with the specified partition type.
        /// If you don't specify a value for vCPU and MemoryInGiB, SageMaker AI automatically
        /// allocates ratio-based values for those parameters based on the accelerator partition
        /// count you provide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000000)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The Multi-Instance GPU (MIG) profile type that defines the partition configuration.
        /// The profile specifies the compute and memory allocation for each partition instance.
        /// The available profile types depend on the instance type specified in the compute quota
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MIGProfileType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}