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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The runtime platform that Amazon ECS applies to a service revision. This value overrides
    /// the runtime platform specified in the task definition. You can't set this value.
    /// </summary>
    public partial class RuntimePlatformOverride
    {
        private string _cpuArchitecture;

        /// <summary>
        /// Gets and sets the property CpuArchitecture. 
        /// <para>
        /// The CPU architecture that tasks in this service revision run on. This value might
        /// differ from the architecture declared in the task definition—for example, when Amazon
        /// ECS detects an architecture mismatch during an Amazon ECS Express deployment and runs
        /// tasks on a different architecture. You can't set this value.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>X86_64</c> - The x86 64-bit architecture.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARM64</c> - The 64-bit ARM architecture.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string CpuArchitecture
        {
            get { return this._cpuArchitecture; }
            set { this._cpuArchitecture = value; }
        }

        // Check to see if CpuArchitecture property is set
        internal bool IsSetCpuArchitecture()
        {
            return this._cpuArchitecture != null;
        }

    }
}