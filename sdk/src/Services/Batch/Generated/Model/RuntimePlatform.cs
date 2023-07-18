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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the compute environment architecture for Batch jobs on Fargate.
    /// </summary>
    public partial class RuntimePlatform
    {
        private string _cpuArchitecture;
        private string _operatingSystemFamily;

        /// <summary>
        /// Gets and sets the property CpuArchitecture. 
        /// <para>
        /// The vCPU architecture. The default value is <code>X86_64</code>. Valid values are
        /// <code>X86_64</code> and <code> ARM64</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter must be set to <code>X86_64</code> for Windows containers.
        /// </para>
        ///  </note>
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

        /// <summary>
        /// Gets and sets the property OperatingSystemFamily. 
        /// <para>
        /// The operating system for the compute environment. Valid values are: <code>LINUX</code>
        /// (default), <code>WINDOWS_SERVER_2019_CORE</code>, <code>WINDOWS_SERVER_2019_FULL</code>,
        /// <code>WINDOWS_SERVER_2022_CORE</code>, and <code>WINDOWS_SERVER_2022_FULL</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The following parameters can’t be set for Windows containers: <code>linuxParameters</code>,
        /// <code>privileged</code>, <code>user</code>, <code>ulimits</code>, <code>readonlyRootFilesystem</code>,
        /// and <code>efsVolumeConfiguration</code>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// The Batch Scheduler checks before registering a task definition with Fargate. If the
        /// job requires a Windows container and the first compute environment is <code>LINUX</code>,
        /// the compute environment is skipped and the next is checked until a Windows-based compute
        /// environment is found.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Fargate Spot is not supported for Windows-based containers on Fargate. A job queue
        /// will be blocked if a Fargate Windows job is submitted to a job queue with only Fargate
        /// Spot compute environments. However, you can attach both <code>FARGATE</code> and <code>FARGATE_SPOT</code>
        /// compute environments to the same job queue.
        /// </para>
        ///  </note>
        /// </summary>
        public string OperatingSystemFamily
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