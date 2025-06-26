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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Describes a specific GPU accelerator required for an Amazon Elastic Compute Cloud
    /// worker host.
    /// </summary>
    public partial class AcceleratorSelection
    {
        private AcceleratorName _name;
        private string _runtime;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the chip used by the GPU accelerator.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>l4</c> as the name of the accelerator, you must specify <c>latest</c>
        /// or <c>grid:r570</c> as the runtime.
        /// </para>
        ///  
        /// <para>
        /// The available GPU accelerators are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>t4</c> - NVIDIA T4 Tensor Core GPU
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>a10g</c> - NVIDIA A10G Tensor Core GPU
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>l4</c> - NVIDIA L4 Tensor Core GPU
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>l40s</c> - NVIDIA L40S Tensor Core GPU
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AcceleratorName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// Specifies the runtime driver to use for the GPU accelerator. You must use the same
        /// runtime for all GPUs. 
        /// </para>
        ///  
        /// <para>
        /// You can choose from the following runtimes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>latest</c> - Use the latest runtime available for the chip. If you specify <c>latest</c>
        /// and a new version of the runtime is released, the new version of the runtime is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>grid:r570</c> - <a href="https://docs.nvidia.com/vgpu/18.0/index.html">NVIDIA
        /// vGPU software 18</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>grid:r535</c> - <a href="https://docs.nvidia.com/vgpu/16.0/index.html">NVIDIA
        /// vGPU software 16</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a runtime, Deadline Cloud uses <c>latest</c> as the default.
        /// However, if you have multiple accelerators and specify <c>latest</c> for some and
        /// leave others blank, Deadline Cloud raises an exception.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

    }
}