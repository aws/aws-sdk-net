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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// <b>This data type is used with the Amazon GameLift containers feature, which is currently
    /// in public preview.</b> 
    /// 
    ///  
    /// <para>
    /// Describes a container's configuration, resources, and start instructions. Use this
    /// data type to create a container group definition. For the properties of a container
    /// that's been deployed to a fleet, see <a>ContainerDefinition</a>. You can't change
    /// these properties after you've created the container group definition. If you need
    /// a container group with different properties, then you must create a new one. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Used with: </b> <a>CreateContainerGroupDefinition</a> 
    /// </para>
    /// </summary>
    public partial class ContainerDefinitionInput
    {
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _containerName;
        private int? _cpu;
        private List<ContainerDependency> _dependsOn = AWSConfigs.InitializeCollections ? new List<ContainerDependency>() : null;
        private List<string> _entryPoint = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ContainerEnvironment> _environment = AWSConfigs.InitializeCollections ? new List<ContainerEnvironment>() : null;
        private bool? _essential;
        private ContainerHealthCheck _healthCheck;
        private string _imageUri;
        private ContainerMemoryLimits _memoryLimits;
        private ContainerPortConfiguration _portConfiguration;
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// A command to pass to the container on startup. Add multiple arguments as additional
        /// strings in the array. See the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-command">ContainerDefinition
        /// command</a> parameter in the <i>Amazon Elastic Container Service API reference.</i>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && (this._command.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// A string that uniquely identifies the container definition within a container group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units to reserve for this container. The container can use more
        /// resources when needed, if available. Note: 1 vCPU unit equals 1024 CPU units. If you
        /// don't reserve CPU units for this container, then it shares the total CPU limit for
        /// the container group. This property is similar to the Amazon ECS container definition
        /// parameter <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#container_definition_environment">environment</a>
        /// (<i>Amazon Elastic Container Service Developer Guide).</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related data type: </b> <a>ContainerGroupDefinition$TotalCpuLimit</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
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
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// Sets up dependencies between this container and the status of other containers in
        /// the same container group. A container can have dependencies on multiple different
        /// containers. 
        /// </para>
        ///  
        /// <para>
        /// You can use dependencies to establish a startup/shutdown sequence across the container
        /// group. A container startup dependency is reversed on shutdown.
        /// </para>
        ///  
        /// <para>
        /// For example, you might specify that SideCarContainerB has a <c>START</c> dependency
        /// on SideCarContainerA. This dependency means that SideCarContainerB can't start until
        /// after SideCarContainerA has started. This dependency is reversed on shutdown, which
        /// means that SideCarContainerB must shut down before SideCarContainerA can shut down.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ContainerDependency> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && (this._dependsOn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// An entry point to pass to the container on startup. Add multiple arguments as additional
        /// strings in the array. See the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-entryPoint">ContainerDefinition::entryPoint</a>
        /// parameter in the <i>Amazon Elastic Container Service API Reference</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> EntryPoint
        {
            get { return this._entryPoint; }
            set { this._entryPoint = value; }
        }

        // Check to see if EntryPoint property is set
        internal bool IsSetEntryPoint()
        {
            return this._entryPoint != null && (this._entryPoint.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// A set of environment variables to pass to the container on startup. See the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-environment">ContainerDefinition::environment</a>
        /// parameter in the <i>Amazon Elastic Container Service API Reference</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<ContainerEnvironment> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Essential. 
        /// <para>
        /// Specifies whether the container is vital for the container group to function properly.
        /// If an essential container fails, it causes the entire container group to restart.
        /// Each container group must have an essential container.
        /// </para>
        ///  
        /// <para>
        ///  <b>Replica container groups</b> - A replica group must have exactly one essential
        /// container. Use the following to configure an essential replica container:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Choose a container is running your game server and the Amazon GameLift Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Include a port configuration. This container runs your game server processes, and
        /// each process requires a container port to allow access to game clients.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don't configure a health check. The Agent handles this task for the essential replica
        /// container. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Daemon container groups</b> - A daemon group must have at least one essential
        /// container. 
        /// </para>
        ///  
        /// <para>
        ///  
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
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// Configuration for a non-terminal health check. A container automatically restarts
        /// if it stops functioning. This parameter lets you define additional reasons to consider
        /// a container unhealthy and restart it. You can set a health check for any container
        /// except for the essential container in the replica container group. If an essential
        /// container in the daemon group fails a health check, the entire container group is
        /// restarted. 
        /// </para>
        /// </summary>
        public ContainerHealthCheck HealthCheck
        {
            get { return this._healthCheck; }
            set { this._healthCheck = value; }
        }

        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this._healthCheck != null;
        }

        /// <summary>
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// The location of a container image that $short; will copy and deploy to a container
        /// fleet. Images in Amazon Elastic Container Registry private repositories are supported.
        /// The repository must be in the same Amazon Web Services account and Amazon Web Services
        /// Region where you're creating the container group definition. For limits on image size,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/gamelift.html">Amazon GameLift
        /// endpoints and quotas</a>. You can use any of the following image URI formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Image ID only: <c>[AWS account].dkr.ecr.[AWS region].amazonaws.com/[repository ID]</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Image ID and digest: <c>[AWS account].dkr.ecr.[AWS region].amazonaws.com/[repository
        /// ID]@[digest]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Image ID and tag: <c>[AWS account].dkr.ecr.[AWS region].amazonaws.com/[repository
        /// ID]:[tag]</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ImageUri
        {
            get { return this._imageUri; }
            set { this._imageUri = value; }
        }

        // Check to see if ImageUri property is set
        internal bool IsSetImageUri()
        {
            return this._imageUri != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryLimits. 
        /// <para>
        /// The amount of memory to make available to the container. If you don't specify memory
        /// limits for this container, then it shares the container group's total memory allocation.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related data type: </b> <a>ContainerGroupDefinition$TotalMemoryLimit</a> 
        /// </para>
        /// </summary>
        public ContainerMemoryLimits MemoryLimits
        {
            get { return this._memoryLimits; }
            set { this._memoryLimits = value; }
        }

        // Check to see if MemoryLimits property is set
        internal bool IsSetMemoryLimits()
        {
            return this._memoryLimits != null;
        }

        /// <summary>
        /// Gets and sets the property PortConfiguration. 
        /// <para>
        /// A set of ports that Amazon GameLift can assign to processes in the container. All
        /// processes that accept inbound traffic connections, including game server processes,
        /// must be assigned a port from this set. The set of ports must be large enough to assign
        /// one to each process in the container that needs one. If the container includes your
        /// game server, include enough ports to assign one port to each concurrent server process
        /// (as defined in a container fleet's <a>RuntimeConfiguration</a>). For more details,
        /// see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-network">Networking
        /// for container fleets</a>. 
        /// </para>
        ///  
        /// <para>
        /// Container ports aren't directly accessed by inbound traffic. Amazon GameLift maps
        /// these container ports to externally accessible connection ports, which are assigned
        /// as needed from the container fleet's <c>ConnectionPortRange</c>.
        /// </para>
        /// </summary>
        public ContainerPortConfiguration PortConfiguration
        {
            get { return this._portConfiguration; }
            set { this._portConfiguration = value; }
        }

        // Check to see if PortConfiguration property is set
        internal bool IsSetPortConfiguration()
        {
            return this._portConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The directory in the container where commands are run. See the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-workingDirectory">ContainerDefinition::workingDirectory
        /// parameter</a> in the <i>Amazon Elastic Container Service API Reference</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string WorkingDirectory
        {
            get { return this._workingDirectory; }
            set { this._workingDirectory = value; }
        }

        // Check to see if WorkingDirectory property is set
        internal bool IsSetWorkingDirectory()
        {
            return this._workingDirectory != null;
        }

    }
}