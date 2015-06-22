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
        private List<MountPoint> _mountPoints = new List<MountPoint>();
        private string _name;
        private List<PortMapping> _portMappings = new List<PortMapping>();
        private List<VolumeFrom> _volumesFrom = new List<VolumeFrom>();

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
        /// has 1,024 <code>cpu</code> units for every CPU core. This parameter specifies the
        /// minimum amount of CPU to reserve for a container, and containers share unallocated
        /// CPU units with other containers on the instance with the same ratio as their allocated
        /// amount.
        /// </para>
        ///  
        /// <para>
        /// For example, if you run a single-container task on a single-core instance type with
        /// 512 CPU units specified for that container, and that is the only task running on the
        /// container instance, that container could use the full 1,024 CPU unit share at any
        /// given time. However, if you launched another copy of the same task on that container
        /// instance, each task would be guaranteed a minimum of 512 CPU units when needed, and
        /// each container could float to higher CPU usage if the other container was not using
        /// it, but if both tasks were 100% active all of the time, they would be limited to 512
        /// CPU units.
        /// </para>
        ///  
        /// <para>
        /// The Docker daemon on the container instance uses the CPU value to calculate the relative
        /// CPU share ratios for running containers. For more information, see <a href="https://docs.docker.com/reference/run/#cpu-share-constraint">CPU
        /// share constraint</a> in the Docker documentation. The minimum valid CPU share value
        /// that the Linux kernel will allow is 2; however, the CPU parameter is not required,
        /// and you can use CPU values below 2 in your container definitions. For CPU values below
        /// 2 (including null), the behavior varies based on your Amazon ECS container agent version:
        /// </para>
        ///  <ul> <li> <b>Agent versions less than or equal to 1.1.0:</b> Null and zero CPU values
        /// are passed to Docker as 0, which Docker then converts to 1,024 CPU shares. CPU values
        /// of 1 are passed to Docker as 1, which the Linux kernel converts to 2 CPU shares.</li>
        /// <li> <b>Agent versions greater than or equal to 1.2.0:</b> Null, zero, and CPU values
        /// of 1 are passed to Docker as 2.</li> </ul>
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
        /// Gets and sets the property EntryPoint. <important> 
        /// <para>
        /// Early versions of the Amazon ECS container agent do not properly handle <code>entryPoint</code>
        /// parameters. If you have problems using <code>entryPoint</code>, update your container
        /// agent or enter your commands and arguments as <code>command</code> array items instead.
        /// </para>
        ///  </important> 
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
        /// rest of the containers in a task. If this parameter is omitted, a container is assumed
        /// to be essential.
        /// </para>
        ///  <note> 
        /// <para>
        /// All tasks must have at least one essential container.
        /// </para>
        ///  </note>
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
        /// the need for port mappings, using the <code>name</code> parameter. The <code>name:internalName</code>
        /// construct is analogous to <code>name:alias</code> in Docker links. For more information
        /// on linking Docker containers, see <a href="https://docs.docker.com/userguide/dockerlinks/">https://docs.docker.com/userguide/dockerlinks/</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Containers that are collocated on a single container instance may be able to communicate
        /// with each other without requiring links or host port mappings. Network isolation is
        /// achieved on the container instance using security groups and VPC settings.
        /// </para>
        ///  </important>
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
        /// The number of MiB of memory reserved for the container. If your container attempts
        /// to exceed the memory allocated here, the container is killed.
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
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for data volumes in your container.
        /// </para>
        /// </summary>
        public List<MountPoint> MountPoints
        {
            get { return this._mountPoints; }
            set { this._mountPoints = value; }
        }

        // Check to see if MountPoints property is set
        internal bool IsSetMountPoints()
        {
            return this._mountPoints != null && this._mountPoints.Count > 0; 
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

        /// <summary>
        /// Gets and sets the property VolumesFrom. 
        /// <para>
        /// Data volumes to mount from another container.
        /// </para>
        /// </summary>
        public List<VolumeFrom> VolumesFrom
        {
            get { return this._volumesFrom; }
            set { this._volumesFrom = value; }
        }

        // Check to see if VolumesFrom property is set
        internal bool IsSetVolumesFrom()
        {
            return this._volumesFrom != null && this._volumesFrom.Count > 0; 
        }

    }
}