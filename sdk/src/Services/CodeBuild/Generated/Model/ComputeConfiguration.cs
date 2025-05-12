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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains compute attributes. These attributes only need be specified when your project's
    /// or fleet's <c>computeType</c> is set to <c>ATTRIBUTE_BASED_COMPUTE</c> or <c>CUSTOM_INSTANCE_TYPE</c>.
    /// </summary>
    public partial class ComputeConfiguration
    {
        private long? _disk;
        private string _instanceType;
        private MachineType _machineType;
        private long? _memory;
        private long? _vCpu;

        /// <summary>
        /// Gets and sets the property Disk. 
        /// <para>
        /// The amount of disk space of the instance type included in your fleet.
        /// </para>
        /// </summary>
        public long? Disk
        {
            get { return this._disk; }
            set { this._disk = value; }
        }

        // Check to see if Disk property is set
        internal bool IsSetDisk()
        {
            return this._disk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The EC2 instance type to be launched in your fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MachineType. 
        /// <para>
        /// The machine type of the instance type included in your fleet.
        /// </para>
        /// </summary>
        public MachineType MachineType
        {
            get { return this._machineType; }
            set { this._machineType = value; }
        }

        // Check to see if MachineType property is set
        internal bool IsSetMachineType()
        {
            return this._machineType != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount of memory of the instance type included in your fleet.
        /// </para>
        /// </summary>
        public long? Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VCpu. 
        /// <para>
        /// The number of vCPUs of the instance type included in your fleet.
        /// </para>
        /// </summary>
        public long? VCpu
        {
            get { return this._vCpu; }
            set { this._vCpu = value; }
        }

        // Check to see if VCpu property is set
        internal bool IsSetVCpu()
        {
            return this._vCpu.HasValue; 
        }

    }
}