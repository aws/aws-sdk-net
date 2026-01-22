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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Describes the GPU accelerators for the instance type.
    /// </summary>
    public partial class GpuDeviceInfo
    {
        private int? _count;
        private double? _gpuPartitionSize;
        private int? _logicalGpuCount;
        private string _manufacturer;
        private GpuDeviceMemoryInfo _memoryInfo;
        private string _name;
        private List<string> _workloads = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of GPUs for the instance type.
        /// </para>
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GpuPartitionSize. 
        /// <para>
        /// The size of each GPU as a fraction of a full GPU, between 0 (excluded) and 1 (included).
        /// </para>
        /// </summary>
        public double GpuPartitionSize
        {
            get { return this._gpuPartitionSize.GetValueOrDefault(); }
            set { this._gpuPartitionSize = value; }
        }

        // Check to see if GpuPartitionSize property is set
        internal bool IsSetGpuPartitionSize()
        {
            return this._gpuPartitionSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogicalGpuCount. 
        /// <para>
        /// Total number of GPU devices of this type.
        /// </para>
        /// </summary>
        public int LogicalGpuCount
        {
            get { return this._logicalGpuCount.GetValueOrDefault(); }
            set { this._logicalGpuCount = value; }
        }

        // Check to see if LogicalGpuCount property is set
        internal bool IsSetLogicalGpuCount()
        {
            return this._logicalGpuCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Manufacturer. 
        /// <para>
        /// The manufacturer of the GPU accelerator.
        /// </para>
        /// </summary>
        public string Manufacturer
        {
            get { return this._manufacturer; }
            set { this._manufacturer = value; }
        }

        // Check to see if Manufacturer property is set
        internal bool IsSetManufacturer()
        {
            return this._manufacturer != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryInfo. 
        /// <para>
        /// Describes the memory available to the GPU accelerator.
        /// </para>
        /// </summary>
        public GpuDeviceMemoryInfo MemoryInfo
        {
            get { return this._memoryInfo; }
            set { this._memoryInfo = value; }
        }

        // Check to see if MemoryInfo property is set
        internal bool IsSetMemoryInfo()
        {
            return this._memoryInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the GPU accelerator.
        /// </para>
        /// </summary>
        public string Name
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
        /// Gets and sets the property Workloads. 
        /// <para>
        /// A list of workload types this GPU supports.
        /// </para>
        /// </summary>
        public List<string> Workloads
        {
            get { return this._workloads; }
            set { this._workloads = value; }
        }

        // Check to see if Workloads property is set
        internal bool IsSetWorkloads()
        {
            return this._workloads != null && (this._workloads.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}