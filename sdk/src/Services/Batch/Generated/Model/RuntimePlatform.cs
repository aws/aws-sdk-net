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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the compute environment architecture for Batch jobs on
    /// Fargate.
    /// </summary>
    public partial class RuntimePlatform
    {
        private string _cpuArchitecture;
        private string _operatingSystemFamily;

        /// <summary>
        /// Gets and sets the property CpuArchitecture. 
        /// <para>
        /// The vCPU architecture. The default value is <c>X86_64</c>. Valid values are <c>X86_64</c>
        /// and <c>ARM64</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter must be set to <c>X86_64</c> for Windows containers.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Fargate Spot is not supported on Windows-based containers on Fargate. A job queue
        /// will be blocked if a Windows job is submitted to a job queue with only Fargate Spot
        /// compute environments. However, you can attach both <c>FARGATE</c> and <c>FARGATE_SPOT</c>
        /// compute environments to the same job queue.
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
        /// The operating system for the compute environment. Valid values are: <c>LINUX</c> (default),
        /// <c>WINDOWS_SERVER_2019_CORE</c>, <c>WINDOWS_SERVER_2019_FULL</c>, <c>WINDOWS_SERVER_2022_CORE</c>,
        /// and <c>WINDOWS_SERVER_2022_FULL</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The following parameters can’t be set for Windows containers: <c>linuxParameters</c>,
        /// <c>privileged</c>, <c>user</c>, <c>ulimits</c>, <c>readonlyRootFilesystem</c>, and
        /// <c>efsVolumeConfiguration</c>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// The Batch Scheduler checks the compute environments that are attached to the job queue
        /// before registering a task definition with Fargate. In this scenario, the job queue
        /// is where the job is submitted. If the job requires a Windows container and the first
        /// compute environment is <c>LINUX</c>, the compute environment is skipped and the next
        /// compute environment is checked until a Windows-based compute environment is found.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Fargate Spot is not supported on Windows-based containers on Fargate. A job queue
        /// will be blocked if a Windows job is submitted to a job queue with only Fargate Spot
        /// compute environments. However, you can attach both <c>FARGATE</c> and <c>FARGATE_SPOT</c>
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