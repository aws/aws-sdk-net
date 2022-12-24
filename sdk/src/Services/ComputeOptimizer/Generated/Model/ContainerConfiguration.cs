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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the container configurations within the tasks of your Amazon ECS service.
    /// </summary>
    public partial class ContainerConfiguration
    {
        private string _containerName;
        private int? _cpu;
        private MemorySizeConfiguration _memorySizeConfiguration;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        ///  The name of the container. 
        /// </para>
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        ///  The number of CPU units reserved for the container. 
        /// </para>
        /// </summary>
        public int Cpu
        {
            get { return this._cpu.GetValueOrDefault(); }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemorySizeConfiguration. 
        /// <para>
        ///  The memory size configurations for the container. 
        /// </para>
        /// </summary>
        public MemorySizeConfiguration MemorySizeConfiguration
        {
            get { return this._memorySizeConfiguration; }
            set { this._memorySizeConfiguration = value; }
        }

        // Check to see if MemorySizeConfiguration property is set
        internal bool IsSetMemorySizeConfiguration()
        {
            return this._memorySizeConfiguration != null;
        }

    }
}