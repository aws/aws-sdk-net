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
    /// Describes a support container in a container group. You can define a support container
    /// in either a game server container group or a per-instance container group. Support
    /// containers don't run game server processes.
    /// 
    ///  
    /// <para>
    /// This definition includes container configuration, resources, and start instructions.
    /// Use this data type when creating or updating a container group definition. For properties
    /// of a deployed support container, see <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinition.html">SupportContainerDefinition</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Use with: </b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerGroupDefinition.html">CreateContainerGroupDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateContainerGroupDefinition.html">UpdateContainerGroupDefinition</a>
    /// 
    /// </para>
    /// </summary>
    public partial class SupportContainerDefinitionInput
    {
        private string _containerName;
        private List<ContainerDependency> _dependsOn = AWSConfigs.InitializeCollections ? new List<ContainerDependency>() : null;
        private List<ContainerEnvironment> _environmentOverride = AWSConfigs.InitializeCollections ? new List<ContainerEnvironment>() : null;
        private bool? _essential;
        private ContainerHealthCheck _healthCheck;
        private string _imageUri;
        private int? _memoryHardLimitMebibytes;
        private List<ContainerMountPoint> _mountPoints = AWSConfigs.InitializeCollections ? new List<ContainerMountPoint>() : null;
        private ContainerPortConfiguration _portConfiguration;
        private double? _vcpu;

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
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// Establishes dependencies between this container and the status of other containers
        /// in the same container group. A container can have dependencies on multiple different
        /// containers. 
        /// </para>
        ///  
        /// <para>
        /// .
        /// </para>
        ///  
        /// <para>
        /// You can use dependencies to establish a startup/shutdown sequence across the container
        /// group. For example, you might specify that <i>ContainerB</i> has a <c>START</c> dependency
        /// on <i>ContainerA</i>. This dependency means that <i>ContainerB</i> can't start until
        /// after <i>ContainerA</i> has started. This dependency is reversed on shutdown, which
        /// means that <i>ContainerB</i> must shut down before <i>ContainerA</i> can shut down.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property EnvironmentOverride. 
        /// <para>
        /// A set of environment variables to pass to the container on startup. See the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-environment">ContainerDefinition::environment</a>
        /// parameter in the <i>Amazon Elastic Container Service API Reference</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<ContainerEnvironment> EnvironmentOverride
        {
            get { return this._environmentOverride; }
            set { this._environmentOverride = value; }
        }

        // Check to see if EnvironmentOverride property is set
        internal bool IsSetEnvironmentOverride()
        {
            return this._environmentOverride != null && (this._environmentOverride.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Essential. 
        /// <para>
        /// Flags the container as vital for the container group to function properly. If an essential
        /// container fails, the entire container group restarts. At least one support container
        /// in a per-instance container group must be essential. When flagging a container as
        /// essential, also configure a health check so that the container can signal that it's
        /// healthy. 
        /// </para>
        /// </summary>
        public bool? Essential
        {
            get { return this._essential; }
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
        /// if it stops functioning. With a health check, you can define additional reasons to
        /// flag a container as unhealthy and restart it. If an essential container fails a health
        /// check, the entire container group restarts. 
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
        /// The location of the container image to deploy to a container fleet. Provide an image
        /// in an Amazon Elastic Container Registry public or private repository. The repository
        /// must be in the same Amazon Web Services account and Amazon Web Services Region where
        /// you're creating the container group definition. For limits on image size, see <a href="https://docs.aws.amazon.com/general/latest/gr/gamelift.html">Amazon
        /// GameLift Servers endpoints and quotas</a>. You can use any of the following image
        /// URI formats: 
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
        /// Gets and sets the property MemoryHardLimitMebibytes. 
        /// <para>
        /// A specified amount of memory (in MiB) to reserve for this container. If you don't
        /// specify a container-specific memory limit, the container shares the container group's
        /// total memory allocation. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related data type: </b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html">ContainerGroupDefinition</a>TotalMemoryLimitMebibytes<code/>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024000)]
        public int? MemoryHardLimitMebibytes
        {
            get { return this._memoryHardLimitMebibytes; }
            set { this._memoryHardLimitMebibytes = value; }
        }

        // Check to see if MemoryHardLimitMebibytes property is set
        internal bool IsSetMemoryHardLimitMebibytes()
        {
            return this._memoryHardLimitMebibytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// A mount point that binds a path inside the container to a file or directory on the
        /// host system and lets it access the file or directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ContainerMountPoint> MountPoints
        {
            get { return this._mountPoints; }
            set { this._mountPoints = value; }
        }

        // Check to see if MountPoints property is set
        internal bool IsSetMountPoints()
        {
            return this._mountPoints != null && (this._mountPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PortConfiguration. 
        /// <para>
        /// A set of ports that Amazon GameLift Servers can assign to processes in a container.
        /// The container port configuration must have enough ports for each container process
        /// that accepts inbound traffic connections. A container port configuration can have
        /// can have one or more container port ranges. Each range specifies starting and ending
        /// values as well as the supported network protocol.
        /// </para>
        ///  
        /// <para>
        /// Container ports aren't directly accessed by inbound traffic. Amazon GameLift Servers
        /// maps each container port to an externally accessible connection port (see the container
        /// fleet property <c>ConnectionPortRange</c>). 
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
        /// Gets and sets the property Vcpu. 
        /// <para>
        /// The number of vCPU units to reserve for this container. The container can use more
        /// resources when needed, if available. If you don't reserve CPU units for this container,
        /// it shares the container group's total vCPU limit. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related data type: </b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html">ContainerGroupDefinition</a>
        /// TotalCpuLimit 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public double? Vcpu
        {
            get { return this._vcpu; }
            set { this._vcpu = value; }
        }

        // Check to see if Vcpu property is set
        internal bool IsSetVcpu()
        {
            return this._vcpu.HasValue; 
        }

    }
}