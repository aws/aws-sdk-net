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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
        private string _cpu;
        private string _disk;
        private string _diskType;
        private string _memory;

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The CPU requirements for every worker instance of the worker type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=15)]
        public string Cpu
        {
            get { return this._cpu; }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu != null;
        }

        /// <summary>
        /// Gets and sets the property Disk. 
        /// <para>
        /// The disk requirements for every worker instance of the worker type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public string Disk
        {
            get { return this._disk; }
            set { this._disk = value; }
        }

        // Check to see if Disk property is set
        internal bool IsSetDisk()
        {
            return this._disk != null;
        }

        /// <summary>
        /// Gets and sets the property DiskType. 
        /// <para>
        /// The disk type for every worker instance of the work type. Shuffle optimized disks
        /// have higher performance characteristics and are better for shuffle heavy workloads.
        /// Default is <c>STANDARD</c>.
        /// </para>
        /// </summary>
        public string DiskType
        {
            get { return this._diskType; }
            set { this._diskType = value; }
        }

        // Check to see if DiskType property is set
        internal bool IsSetDiskType()
        {
            return this._diskType != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The memory requirements for every worker instance of the worker type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=15)]
        public string Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory != null;
        }

    }
}