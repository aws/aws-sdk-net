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
    /// Describes a container in a container fleet, the resources available to the container,
    /// and the commands that are run when the container starts. Container properties can't
    /// be updated. To change a property, create a new container group definition. See also
    /// <a>ContainerDefinitionInput</a>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Part of:</b> <a>ContainerGroupDefinition</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Returned by:</b> <a>DescribeContainerGroupDefinition</a>, <a>ListContainerGroupDefinitions</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ContainerDefinition
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
        private string _resolvedImageDigest;
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// A command that's passed to the container on startup. Each argument for the command
        /// is an additional string in the array. See the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-command">ContainerDefinition::command</a>
        /// parameter in the <i>Amazon Elastic Container Service API reference.</i> 
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
        /// The container definition identifier. Container names are unique within a container
        /// group definition. 
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
        /// The number of CPU units that are reserved for the container. Note: 1 vCPU unit equals
        /// 1024 CPU units. If no resources are reserved, the container shares the total CPU limit
        /// for the container group.
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
        /// Indicates that the container relies on the status of other containers in the same
        /// container group during its startup and shutdown sequences. A container might have
        /// dependencies on multiple containers.
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
        /// The entry point that's passed to the container on startup. If there are multiple arguments,
        /// each argument is an additional string in the array. See the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-entryPoint">ContainerDefinition::entryPoint</a>
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
        /// A set of environment variables that's passed to the container on startup. See the
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-environment">ContainerDefinition::environment</a>
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
        /// Indicates whether the container is vital to the container group. If an essential container
        /// fails, the entire container group is restarted.
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
        /// A configuration for a non-terminal health check. A container, which automatically
        /// restarts if it stops functioning, also restarts if it fails this health check. If
        /// an essential container in the daemon group fails a health check, the entire container
        /// group is restarted. The essential container in the replica group doesn't use this
        /// health check mechanism, because the Amazon GameLift Agent automatically handles the
        /// task.
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
        /// The URI to the image that $short; copied and deployed to a container fleet. For a
        /// more specific identifier, see <c>ResolvedImageDigest</c>. 
        /// </para>
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
        /// The amount of memory that Amazon GameLift makes available to the container. If memory
        /// limits aren't set for an individual container, the container shares the container
        /// group's total memory allocation.
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
        /// Defines the ports that are available to assign to processes in the container. For
        /// example, a game server process requires a container port to allow game clients to
        /// connect to it. Container ports aren't directly accessed by inbound traffic. Amazon
        /// GameLift maps these container ports to externally accessible connection ports, which
        /// are assigned as needed from the container fleet's <c>ConnectionPortRange</c>. 
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
        /// Gets and sets the property ResolvedImageDigest. 
        /// <para>
        /// A unique and immutable identifier for the container image that is deployed to a container
        /// fleet. The digest is a SHA 256 hash of the container image manifest. 
        /// </para>
        /// </summary>
        public string ResolvedImageDigest
        {
            get { return this._resolvedImageDigest; }
            set { this._resolvedImageDigest = value; }
        }

        // Check to see if ResolvedImageDigest property is set
        internal bool IsSetResolvedImageDigest()
        {
            return this._resolvedImageDigest != null;
        }

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The directory in the container where commands are run. See the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-workingDirectory">ContainerDefinition::workingDirectory</a>
        /// parameter in the <i>Amazon Elastic Container Service API Reference</i>. 
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