/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container definitions are used in task definitions to describe the different containers
    /// that are launched as part of a task.
    /// </summary>
    public partial class ContainerDefinition
    {
        private List<string> _command = new List<string>();
        private int? _cpu;
        private List<string> _entryPoint = new List<string>();
        private List<KeyValuePair> _environment = new List<KeyValuePair>();
        private bool? _essential;
        private string _image;
        private List<string> _links = new List<string>();
        private int? _memory;
        private string _name;
        private List<PortMapping> _portMappings = new List<PortMapping>();

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The <code>CMD</code> that is passed to the container. For more information on the
        /// Docker <code>CMD</code> parameter, see <a href="https://docs.docker.com/reference/builder/#cmd">https://docs.docker.com/reference/builder/#cmd</a>.
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
        /// The number of <code>cpu</code> units reserved for the container. A container instance
        /// has 1,024 <code>cpu</code> units for every CPU core.
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
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// The <code>ENTRYPOINT</code> that is passed to the container. For more information
        /// on the Docker <code>ENTRYPOINT</code> parameter, see <a href="https://docs.docker.com/reference/builder/#entrypoint">https://docs.docker.com/reference/builder/#entrypoint</a>.
        /// </para>
        /// </summary>
        public List<string> EntryPoint
        {
            get { return this._entryPoint; }
            set { this._entryPoint = value; }
        }

        // Check to see if EntryPoint property is set
        internal bool IsSetEntryPoint()
        {
            return this._entryPoint != null && this._entryPoint.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container.
        /// </para>
        /// </summary>
        public List<KeyValuePair> Environment
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
        /// Gets and sets the property Essential. 
        /// <para>
        /// If the <code>essential</code> parameter of a container is marked as <code>true</code>,
        /// the failure of that container will stop the task. If the <code>essential</code> parameter
        /// of a container is marked as <code>false</code>, then its failure will not affect the
        /// rest of the containers in a task.
        /// </para>
        /// </summary>
        public bool Essential
        {
            get { return this._essential.GetValueOrDefault(); }
            set { this._essential = value; }
        }

        // Check to see if Essential property is set
        internal bool IsSetEssential()
        {
            return this._essential.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start a container. This string is passed directly to the Docker
        /// daemon. Images in the Docker Hub registry are available by default. Other repositories
        /// are specified with <code><i>repository-url</i>/<i>image</i>:<i>tag</i></code>.
        /// </para>
        /// </summary>
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property Links. 
        /// <para>
        /// The <code>link</code> parameter allows containers to communicate with each other without
        /// the need for port mappings, using the <code>name</code> parameter. For more information
        /// on linking Docker containers, see <a href="https://docs.docker.com/userguide/dockerlinks/">https://docs.docker.com/userguide/dockerlinks/</a>.
        /// </para>
        /// </summary>
        public List<string> Links
        {
            get { return this._links; }
            set { this._links = value; }
        }

        // Check to see if Links property is set
        internal bool IsSetLinks()
        {
            return this._links != null && this._links.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The number of MiB of memory reserved for the container. Docker will allocate a minimum
        /// of 4 MiB of memory to a container.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a container. If you are linking multiple containers together in a task
        /// definition, the <code>name</code> of one container can be entered in the <code>links</code>
        /// of another container to connect the containers.
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
        /// Gets and sets the property PortMappings. 
        /// <para>
        /// The list of port mappings for the container.
        /// </para>
        /// </summary>
        public List<PortMapping> PortMappings
        {
            get { return this._portMappings; }
            set { this._portMappings = value; }
        }

        // Check to see if PortMappings property is set
        internal bool IsSetPortMappings()
        {
            return this._portMappings != null && this._portMappings.Count > 0; 
        }

    }
}