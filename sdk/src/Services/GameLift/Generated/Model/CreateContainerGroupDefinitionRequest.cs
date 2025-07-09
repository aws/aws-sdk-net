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
    /// Container for the parameters to the CreateContainerGroupDefinition operation.
    /// Creates a <c>ContainerGroupDefinition</c> that describes a set of containers for hosting
    /// your game server with Amazon GameLift Servers managed containers hosting. An Amazon
    /// GameLift Servers container group is similar to a container task or pod. Use container
    /// group definitions when you create a container fleet with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerFleet.html">CreateContainerFleet</a>.
    /// 
    /// 
    ///  
    /// <para>
    /// A container group definition determines how Amazon GameLift Servers deploys your containers
    /// to each instance in a container fleet. You can maintain multiple versions of a container
    /// group definition.
    /// </para>
    ///  
    /// <para>
    /// There are two types of container groups:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <b>game server container group</b> has the containers that run your game server
    /// application and supporting software. A game server container group can have these
    /// container types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Game server container. This container runs your game server. You can define one game
    /// server container in a game server container group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Support container. This container runs software in parallel with your game server.
    /// You can define up to 8 support containers in a game server group.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When building a game server container group definition, you can choose to bundle your
    /// game server executable and all dependent software into a single game server container.
    /// Alternatively, you can separate the software into one game server container and one
    /// or more support containers.
    /// </para>
    ///  
    /// <para>
    /// On a container fleet instance, a game server container group can be deployed multiple
    /// times (depending on the compute resources of the instance). This means that all containers
    /// in the container group are replicated together.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <b>per-instance container group</b> has containers for processes that aren't replicated
    /// on a container fleet instance. This might include background services, logging, test
    /// processes, or processes that need to persist independently of the game server container
    /// group. When building a per-instance container group, you can define up to 10 support
    /// containers.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// This operation requires Identity and Access Management (IAM) permissions to access
    /// container images in Amazon ECR repositories. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-iam-policy-examples.html">
    /// IAM permissions for Amazon GameLift Servers</a> for help setting the appropriate permissions.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Request options</b> 
    /// </para>
    ///  
    /// <para>
    /// Use this operation to make the following types of requests. You can specify values
    /// for the minimum required parameters and customize optional values later.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Create a game server container group definition. Provide the following required parameter
    /// values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Name</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ContainerGroupType</c> (<c>GAME_SERVER</c>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>OperatingSystem</c> (omit to use default value)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TotalMemoryLimitMebibytes</c> (omit to use default value)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TotalVcpuLimit </c>(omit to use default value)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// At least one <c>GameServerContainerDefinition</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ContainerName</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ImageUrl</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PortConfiguration</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ServerSdkVersion</c> (omit to use default value)
    /// </para>
    ///  </li> </ul> </li> </ul> </li> <li> 
    /// <para>
    /// Create a per-instance container group definition. Provide the following required parameter
    /// values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Name</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ContainerGroupType</c> (<c>PER_INSTANCE</c>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>OperatingSystem</c> (omit to use default value)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TotalMemoryLimitMebibytes</c> (omit to use default value)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TotalVcpuLimit </c>(omit to use default value)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// At least one <c>SupportContainerDefinition</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ContainerName</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ImageUrl</c> 
    /// </para>
    ///  </li> </ul> </li> </ul> </li> </ul> 
    /// <para>
    ///  <b>Results</b> 
    /// </para>
    ///  
    /// <para>
    /// If successful, this request creates a <c>ContainerGroupDefinition</c> resource and
    /// assigns a unique ARN value. You can update most properties of a container group definition
    /// by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateContainerGroupDefinition.html">UpdateContainerGroupDefinition</a>,
    /// and optionally save the update as a new version.
    /// </para>
    /// </summary>
    public partial class CreateContainerGroupDefinitionRequest : AmazonGameLiftRequest
    {
        private ContainerGroupType _containerGroupType;
        private GameServerContainerDefinitionInput _gameServerContainerDefinition;
        private string _name;
        private ContainerOperatingSystem _operatingSystem;
        private List<SupportContainerDefinitionInput> _supportContainerDefinitions = AWSConfigs.InitializeCollections ? new List<SupportContainerDefinitionInput>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _totalMemoryLimitMebibytes;
        private double? _totalVcpuLimit;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property ContainerGroupType. 
        /// <para>
        /// The type of container group being defined. Container group type determines how Amazon
        /// GameLift Servers deploys the container group on each fleet instance.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>GAME_SERVER</c> 
        /// </para>
        /// </summary>
        public ContainerGroupType ContainerGroupType
        {
            get { return this._containerGroupType; }
            set { this._containerGroupType = value; }
        }

        // Check to see if ContainerGroupType property is set
        internal bool IsSetContainerGroupType()
        {
            return this._containerGroupType != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerContainerDefinition. 
        /// <para>
        /// The definition for the game server container in this group. Define a game server container
        /// only when the container group type is <c>GAME_SERVER</c>. Game server containers specify
        /// a container image with your game server build. You can pass in your container definitions
        /// as a JSON file.
        /// </para>
        /// </summary>
        public GameServerContainerDefinitionInput GameServerContainerDefinition
        {
            get { return this._gameServerContainerDefinition; }
            set { this._gameServerContainerDefinition = value; }
        }

        // Check to see if GameServerContainerDefinition property is set
        internal bool IsSetGameServerContainerDefinition()
        {
            return this._gameServerContainerDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive identifier for the container group definition. The name value must be
        /// unique in an Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The platform that all containers in the group use. Containers in a group must run
        /// on the same operating system.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>AMAZON_LINUX_2023</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Linux 2 (AL2) will reach end of support on 6/30/2025. See more details in the
        /// <a href="http://aws.amazon.com/amazon-linux-2/faqs/">Amazon Linux 2 FAQs</a>. For
        /// game servers that are hosted on AL2 and use server SDK version 4.x for Amazon GameLift
        /// Servers, first update the game server build to server SDK 5.x, and then deploy to
        /// AL2023 instances. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk5-migration.html">
        /// Migrate to server SDK version 5.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerOperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property SupportContainerDefinitions. 
        /// <para>
        /// One or more definition for support containers in this group. You can define a support
        /// container in any type of container group. You can pass in your container definitions
        /// as a JSON file.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<SupportContainerDefinitionInput> SupportContainerDefinitions
        {
            get { return this._supportContainerDefinitions; }
            set { this._supportContainerDefinitions = value; }
        }

        // Check to see if SupportContainerDefinitions property is set
        internal bool IsSetSupportContainerDefinitions()
        {
            return this._supportContainerDefinitions != null && (this._supportContainerDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the container group definition resource. Tags are developer-defined
        /// key-value pairs. Tagging Amazon Web Services resources are useful for resource management,
        /// access management and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalMemoryLimitMebibytes. 
        /// <para>
        /// The maximum amount of memory (in MiB) to allocate to the container group. All containers
        /// in the group share this memory. If you specify memory limits for an individual container,
        /// the total value must be greater than any individual container's memory limit.
        /// </para>
        ///  
        /// <para>
        /// Default value: 1024
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=1024000)]
        public int? TotalMemoryLimitMebibytes
        {
            get { return this._totalMemoryLimitMebibytes; }
            set { this._totalMemoryLimitMebibytes = value; }
        }

        // Check to see if TotalMemoryLimitMebibytes property is set
        internal bool IsSetTotalMemoryLimitMebibytes()
        {
            return this._totalMemoryLimitMebibytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalVcpuLimit. 
        /// <para>
        /// The maximum amount of vCPU units to allocate to the container group (1 vCPU is equal
        /// to 1024 CPU units). All containers in the group share this memory. If you specify
        /// vCPU limits for individual containers, the total value must be equal to or greater
        /// than the sum of the CPU limits for all containers in the group.
        /// </para>
        ///  
        /// <para>
        /// Default value: 1
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10)]
        public double? TotalVcpuLimit
        {
            get { return this._totalVcpuLimit; }
            set { this._totalVcpuLimit = value; }
        }

        // Check to see if TotalVcpuLimit property is set
        internal bool IsSetTotalVcpuLimit()
        {
            return this._totalVcpuLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description for the initial version of this container group definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

    }
}