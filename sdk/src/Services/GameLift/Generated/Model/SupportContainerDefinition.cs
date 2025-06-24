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
    /// Describes a support container in a container group. A support container might be in
    /// a game server container group or a per-instance container group. Support containers
    /// don't run game server processes.
    /// 
    ///  
    /// <para>
    /// You can update a support container definition and deploy the updates to an existing
    /// fleet. When creating or updating a game server container group definition, use the
    /// property <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinitionInput.html">GameServerContainerDefinitionInput</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Part of:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html">ContainerGroupDefinition</a>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Returned by:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeContainerGroupDefinition.html">DescribeContainerGroupDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListContainerGroupDefinitions.html">ListContainerGroupDefinitions</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateContainerGroupDefinition.html">UpdateContainerGroupDefinition</a>
    /// 
    /// </para>
    /// </summary>
    public partial class SupportContainerDefinition
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
        private string _resolvedImageDigest;
        private double? _vcpu;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The container definition identifier. Container names are unique within a container
        /// group definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Indicates that the container relies on the status of other containers in the same
        /// container group during its startup and shutdown sequences. A container might have
        /// dependencies on multiple containers.
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
        /// A set of environment variables that's passed to the container on startup. See the
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ContainerDefinition.html#ECS-Type-ContainerDefinition-environment">ContainerDefinition::environment</a>
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
        /// Indicates whether the container is vital to the container group. If an essential container
        /// fails, the entire container group restarts.
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
        /// A configuration for a non-terminal health check. A support container automatically
        /// restarts if it stops functioning or if it fails this health check. 
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
        /// The URI to the image that Amazon GameLift Servers deploys to a container fleet. For
        /// a more specific identifier, see <c>ResolvedImageDigest</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The amount of memory that Amazon GameLift Servers makes available to the container.
        /// If memory limits aren't set for an individual container, the container shares the
        /// container group's total memory allocation.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related data type: </b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html">ContainerGroupDefinition
        /// TotalMemoryLimitMebibytes</a> 
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
        /// A set of ports that allow access to the container from external users. Processes running
        /// in the container can bind to a one of these ports. Container ports aren't directly
        /// accessed by inbound traffic. Amazon GameLift Servers maps these container ports to
        /// externally accessible connection ports, which are assigned as needed from the container
        /// fleet's <c>ConnectionPortRange</c>.
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
        /// A unique and immutable identifier for the container image. The digest is a SHA 256
        /// hash of the container image manifest. 
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
        /// Gets and sets the property Vcpu. 
        /// <para>
        /// The number of vCPU units that are reserved for the container. If no resources are
        /// reserved, the container shares the total vCPU limit for the container group.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related data type: </b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html">ContainerGroupDefinition
        /// TotalVcpuLimit</a> 
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