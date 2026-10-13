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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// The CPU and memory recommendations for a container within the tasks of your Amazon
    /// ECS service.
    /// </summary>
    public partial class ContainerRecommendation
    {
        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        ///  The name of the container. 
        /// </para>
        /// </summary>
        public string ContainerName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerName property is set.
        /// </summary>
        internal bool IsSetContainerName() => this.ContainerName != null;

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        ///  The recommended number of CPU units reserved for the container. 
        /// </para>
        /// </summary>
        public int? Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu.HasValue;

        /// <summary>
        /// Gets and sets the property MemorySizeConfiguration. 
        /// <para>
        ///  The recommended memory size configurations for the container. 
        /// </para>
        /// </summary>
        public MemorySizeConfiguration MemorySizeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MemorySizeConfiguration property is set.
        /// </summary>
        internal bool IsSetMemorySizeConfiguration() => this.MemorySizeConfiguration != null;
    }
}
