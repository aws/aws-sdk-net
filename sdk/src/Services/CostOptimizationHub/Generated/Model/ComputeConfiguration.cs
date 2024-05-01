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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Describes the performance configuration for compute services such as Amazon EC2, Lambda,
    /// and ECS.
    /// </summary>
    public partial class ComputeConfiguration
    {
        private string _architecture;
        private int? _memorySizeInMB;
        private string _platform;
        private double? _vCpu;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the resource.
        /// </para>
        /// </summary>
        public string Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property MemorySizeInMB. 
        /// <para>
        /// The memory size of the resource.
        /// </para>
        /// </summary>
        public int? MemorySizeInMB
        {
            get { return this._memorySizeInMB; }
            set { this._memorySizeInMB = value; }
        }

        // Check to see if MemorySizeInMB property is set
        internal bool IsSetMemorySizeInMB()
        {
            return this._memorySizeInMB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the resource. The platform is the specific combination of operating
        /// system, license model, and software on an instance.
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property VCpu. 
        /// <para>
        /// The number of vCPU cores in the resource.
        /// </para>
        /// </summary>
        public double? VCpu
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