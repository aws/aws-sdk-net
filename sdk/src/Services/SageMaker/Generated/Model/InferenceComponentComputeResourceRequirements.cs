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
    /// Defines the compute resources to allocate to run a model, plus any adapter models,
    /// that you assign to an inference component. These resources include CPU cores, accelerators,
    /// and memory.
    /// </summary>
    public partial class InferenceComponentComputeResourceRequirements
    {
        private int? _maxMemoryRequiredInMb;
        private int? _minMemoryRequiredInMb;
        private float? _numberOfAcceleratorDevicesRequired;
        private float? _numberOfCpuCoresRequired;

        /// <summary>
        /// Gets and sets the property MaxMemoryRequiredInMb. 
        /// <para>
        /// The maximum MB of memory to allocate to run a model that you assign to an inference
        /// component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=128)]
        public int? MaxMemoryRequiredInMb
        {
            get { return this._maxMemoryRequiredInMb; }
            set { this._maxMemoryRequiredInMb = value; }
        }

        // Check to see if MaxMemoryRequiredInMb property is set
        internal bool IsSetMaxMemoryRequiredInMb()
        {
            return this._maxMemoryRequiredInMb.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinMemoryRequiredInMb. 
        /// <para>
        /// The minimum MB of memory to allocate to run a model that you assign to an inference
        /// component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=128)]
        public int? MinMemoryRequiredInMb
        {
            get { return this._minMemoryRequiredInMb; }
            set { this._minMemoryRequiredInMb = value; }
        }

        // Check to see if MinMemoryRequiredInMb property is set
        internal bool IsSetMinMemoryRequiredInMb()
        {
            return this._minMemoryRequiredInMb.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfAcceleratorDevicesRequired. 
        /// <para>
        /// The number of accelerators to allocate to run a model that you assign to an inference
        /// component. Accelerators include GPUs and Amazon Web Services Inferentia.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public float? NumberOfAcceleratorDevicesRequired
        {
            get { return this._numberOfAcceleratorDevicesRequired; }
            set { this._numberOfAcceleratorDevicesRequired = value; }
        }

        // Check to see if NumberOfAcceleratorDevicesRequired property is set
        internal bool IsSetNumberOfAcceleratorDevicesRequired()
        {
            return this._numberOfAcceleratorDevicesRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfCpuCoresRequired. 
        /// <para>
        /// The number of CPU cores to allocate to run a model that you assign to an inference
        /// component.
        /// </para>
        /// </summary>
        public float? NumberOfCpuCoresRequired
        {
            get { return this._numberOfCpuCoresRequired; }
            set { this._numberOfCpuCoresRequired = value; }
        }

        // Check to see if NumberOfCpuCoresRequired property is set
        internal bool IsSetNumberOfCpuCoresRequired()
        {
            return this._numberOfCpuCoresRequired.HasValue; 
        }

    }
}