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
    /// Describes the configuration for a container that runs your game server executable.
    /// This definition includes container configuration, resources, and start instructions.
    /// Use this data type when creating or updating a game server container group definition.
    /// For properties of a deployed container, see <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinition.html">GameServerContainerDefinition</a>.
    /// A game server container is automatically considered essential; if an essential container
    /// fails, the entire container group restarts.
    /// 
    ///  
    /// <para>
    ///  <b>Use with: </b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerGroupDefinition.html">CreateContainerGroupDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateContainerGroupDefinition.html">UpdateContainerGroupDefinition</a>
    /// 
    /// </para>
    /// </summary>
    public partial class GameServerContainerDefinitionInput
    {
        private string _containerName;
        private List<ContainerDependency> _dependsOn = AWSConfigs.InitializeCollections ? new List<ContainerDependency>() : null;
        private List<ContainerEnvironment> _environmentOverride = AWSConfigs.InitializeCollections ? new List<ContainerEnvironment>() : null;
        private string _imageUri;
        private List<ContainerMountPoint> _mountPoints = AWSConfigs.InitializeCollections ? new List<ContainerMountPoint>() : null;
        private ContainerPortConfiguration _portConfiguration;
        private string _serverSdkVersion;

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
        /// that accepts inbound traffic connections. For example, a game server process requires
        /// a container port to allow game clients to connect to it. A container port configuration
        /// can have can have one or more container port ranges. Each range specifies starting
        /// and ending values as well as the supported network protocol.
        /// </para>
        ///  
        /// <para>
        /// Container ports aren't directly accessed by inbound traffic. Amazon GameLift Servers
        /// maps each container port to an externally accessible connection port (see the container
        /// fleet property <c>ConnectionPortRange</c>). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ServerSdkVersion. 
        /// <para>
        /// The Amazon GameLift Servers server SDK version that the game server is integrated
        /// with. Only game servers using 5.2.0 or higher are compatible with container fleets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string ServerSdkVersion
        {
            get { return this._serverSdkVersion; }
            set { this._serverSdkVersion = value; }
        }

        // Check to see if ServerSdkVersion property is set
        internal bool IsSetServerSdkVersion()
        {
            return this._serverSdkVersion != null;
        }

    }
}