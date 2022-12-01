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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The overrides that are sent to a container. An empty container override can be passed
    /// in. An example of an empty container override is <code>{"containerOverrides": [ ]
    /// }</code>. If a non-empty container override is specified, the <code>name</code> parameter
    /// must be included.
    /// </summary>
    public partial class EcsContainerOverride
    {
        private List<string> _command = new List<string>();
        private int? _cpu;
        private List<EcsEnvironmentVariable> _environment = new List<EcsEnvironmentVariable>();
        private List<EcsEnvironmentFile> _environmentFiles = new List<EcsEnvironmentFile>();
        private int? _memory;
        private int? _memoryReservation;
        private string _name;
        private List<EcsResourceRequirement> _resourceRequirements = new List<EcsResourceRequirement>();

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to send to the container that overrides the default command from the Docker
        /// image or the task definition. You must also specify a container name.
        /// </para>
        /// </summary>
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && this._command.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of <code>cpu</code> units reserved for the container, instead of the default
        /// value from the task definition. You must also specify a container name.
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
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to send to the container. You can add new environment variables,
        /// which are added to the container at launch, or you can override the existing environment
        /// variables from the Docker image or the task definition. You must also specify a container
        /// name.
        /// </para>
        /// </summary>
        public List<EcsEnvironmentVariable> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && this._environment.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentFiles. 
        /// <para>
        /// A list of files containing the environment variables to pass to a container, instead
        /// of the value from the container definition.
        /// </para>
        /// </summary>
        public List<EcsEnvironmentFile> EnvironmentFiles
        {
            get { return this._environmentFiles; }
            set { this._environmentFiles = value; }
        }

        // Check to see if EnvironmentFiles property is set
        internal bool IsSetEnvironmentFiles()
        {
            return this._environmentFiles != null && this._environmentFiles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The hard limit (in MiB) of memory to present to the container, instead of the default
        /// value from the task definition. If your container attempts to exceed the memory specified
        /// here, the container is killed. You must also specify a container name.
        /// </para>
        /// </summary>
        public int Memory
        {
            get { return this._memory.GetValueOrDefault(); }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryReservation. 
        /// <para>
        /// The soft limit (in MiB) of memory to reserve for the container, instead of the default
        /// value from the task definition. You must also specify a container name.
        /// </para>
        /// </summary>
        public int MemoryReservation
        {
            get { return this._memoryReservation.GetValueOrDefault(); }
            set { this._memoryReservation = value; }
        }

        // Check to see if MemoryReservation property is set
        internal bool IsSetMemoryReservation()
        {
            return this._memoryReservation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container that receives the override. This parameter is required if
        /// any override is specified.
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
        /// Gets and sets the property ResourceRequirements. 
        /// <para>
        /// The type and amount of a resource to assign to a container, instead of the default
        /// value from the task definition. The only supported resource is a GPU.
        /// </para>
        /// </summary>
        public List<EcsResourceRequirement> ResourceRequirements
        {
            get { return this._resourceRequirements; }
            set { this._resourceRequirements = value; }
        }

        // Check to see if ResourceRequirements property is set
        internal bool IsSetResourceRequirements()
        {
            return this._resourceRequirements != null && this._resourceRequirements.Count > 0; 
        }

    }
}