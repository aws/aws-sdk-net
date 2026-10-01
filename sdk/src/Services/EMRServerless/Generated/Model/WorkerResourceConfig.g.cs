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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The cumulative configuration requirements for every worker instance of the worker
    /// type.
    /// </summary>
    public partial class WorkerResourceConfig
    {
        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The CPU requirements for every worker instance of the worker type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 15)]
        public string Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu != null;

        /// <summary>
        /// Gets and sets the property Disk. 
        /// <para>
        /// The disk requirements for every worker instance of the worker type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public string Disk { get; set; }

        /// <summary>
        /// Checks to see if the Disk property is set.
        /// </summary>
        internal bool IsSetDisk() => this.Disk != null;

        /// <summary>
        /// Gets and sets the property DiskType. 
        /// <para>
        /// The disk type for every worker instance of the work type. Shuffle optimized disks
        /// have higher performance characteristics and are better for shuffle heavy workloads.
        /// Default is <c>STANDARD</c>.
        /// </para>
        /// </summary>
        public string DiskType { get; set; }

        /// <summary>
        /// Checks to see if the DiskType property is set.
        /// </summary>
        internal bool IsSetDiskType() => this.DiskType != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The memory requirements for every worker instance of the worker type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 15)]
        public string Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory != null;
    }
}
