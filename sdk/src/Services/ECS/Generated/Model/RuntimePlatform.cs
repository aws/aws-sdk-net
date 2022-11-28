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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Information about the platform for the Amazon ECS service or task.
    /// 
    ///  
    /// <para>
    /// For more information about <code>RuntimePlatform</code>, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#runtime-platform">RuntimePlatform</a>
    /// in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RuntimePlatform
    {
        private CPUArchitecture _cpuArchitecture;
        private OSFamily _operatingSystemFamily;

        /// <summary>
        /// Gets and sets the property CpuArchitecture. 
        /// <para>
        /// The CPU architecture.
        /// </para>
        ///  
        /// <para>
        /// You can run your Linux tasks on an ARM-based platform by setting the value to <code>ARM64</code>.
        /// This option is available for tasks that run on Linux Amazon EC2 instance or Linux
        /// containers on Fargate.
        /// </para>
        /// </summary>
        public CPUArchitecture CpuArchitecture
        {
            get { return this._cpuArchitecture; }
            set { this._cpuArchitecture = value; }
        }

        // Check to see if CpuArchitecture property is set
        internal bool IsSetCpuArchitecture()
        {
            return this._cpuArchitecture != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystemFamily. 
        /// <para>
        /// The operating system.
        /// </para>
        /// </summary>
        public OSFamily OperatingSystemFamily
        {
            get { return this._operatingSystemFamily; }
            set { this._operatingSystemFamily = value; }
        }

        // Check to see if OperatingSystemFamily property is set
        internal bool IsSetOperatingSystemFamily()
        {
            return this._operatingSystemFamily != null;
        }

    }
}