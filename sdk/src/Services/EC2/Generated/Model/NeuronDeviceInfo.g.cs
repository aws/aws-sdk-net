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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the neuron accelerators for the instance type.
    /// </summary>
    public partial class NeuronDeviceInfo
    {
        /// <summary>
        /// Gets and sets the property CoreInfo. 
        /// <para>
        /// Describes the cores available to each neuron accelerator.
        /// </para>
        /// </summary>
        public NeuronDeviceCoreInfo CoreInfo { get; set; }

        /// <summary>
        /// Checks to see if the CoreInfo property is set.
        /// </summary>
        internal bool IsSetCoreInfo() => this.CoreInfo != null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of neuron accelerators for the instance type.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryInfo. 
        /// <para>
        /// Describes the memory available to each neuron accelerator.
        /// </para>
        /// </summary>
        public NeuronDeviceMemoryInfo MemoryInfo { get; set; }

        /// <summary>
        /// Checks to see if the MemoryInfo property is set.
        /// </summary>
        internal bool IsSetMemoryInfo() => this.MemoryInfo != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the neuron accelerator.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
