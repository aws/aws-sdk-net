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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The properties that describe a container group resource. You can update all properties
    /// of a container group definition. Updates to a container group definition are saved
    /// as new versions. 
    /// 
    ///  
    /// <para>
    ///  <b>Used with:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerGroupDefinition.html">CreateContainerGroupDefinition</a>
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
    public partial class ContainerGroupDefinition
    {
        /// <summary>
        /// Gets and sets the property ContainerGroupDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to an Amazon GameLift Servers <c>ContainerGroupDefinition</c> resource.
        /// It uniquely identifies the resource across all Amazon Web Services Regions. Format
        /// is <c>arn:aws:gamelift:[region]::containergroupdefinition/[container group definition
        /// name]:[version]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ContainerGroupDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the ContainerGroupDefinitionArn property is set.
        /// </summary>
        internal bool IsSetContainerGroupDefinitionArn() => this.ContainerGroupDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property ContainerGroupType. 
        /// <para>
        /// The type of container group. Container group type determines how Amazon GameLift Servers
        /// deploys the container group on each fleet instance.
        /// </para>
        /// </summary>
        public ContainerGroupType ContainerGroupType { get; set; }

        /// <summary>
        /// Checks to see if the ContainerGroupType property is set.
        /// </summary>
        internal bool IsSetContainerGroupType() => this.ContainerGroupType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property GameServerContainerDefinition. 
        /// <para>
        /// The definition for the game server container in this group. This property is used
        /// only when the container group type is <c>GAME_SERVER</c>. This container definition
        /// specifies a container image with the game server build. 
        /// </para>
        /// </summary>
        public GameServerContainerDefinition GameServerContainerDefinition { get; set; }

        /// <summary>
        /// Checks to see if the GameServerContainerDefinition property is set.
        /// </summary>
        internal bool IsSetGameServerContainerDefinition() => this.GameServerContainerDefinition != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive identifier for the container group definition. The name value is unique
        /// in an Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The platform that all containers in the container group definition run on.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Linux 2 (AL2) will reach end of support on 6/30/2026. See more details in the
        /// <a href="http://aws.amazon.com/amazon-linux-2/faqs/">Amazon Linux 2 FAQs</a>. For
        /// game servers that are hosted on AL2 and use server SDK version 4.x for Amazon GameLift
        /// Servers, first update the game server build to server SDK 5.x, and then deploy to
        /// AL2023 instances. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk5-migration.html">
        /// Migrate to server SDK version 5.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        public ContainerOperatingSystem OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the container group definition resource. Values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COPYING</c> -- Amazon GameLift Servers is in the process of making copies of all
        /// container images that are defined in the group. While in this state, the resource
        /// can't be used to create a container fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c> -- Amazon GameLift Servers has copied the registry images for all containers
        /// that are defined in the group. You can use a container group definition in this status
        /// to create a container fleet. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> -- Amazon GameLift Servers failed to create a valid container group
        /// definition resource. For more details on the cause of the failure, see <c>StatusReason</c>.
        /// A container group definition resource in failed status will be deleted within a few
        /// minutes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContainerGroupDefinitionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about a container group definition that's in <c>FAILED</c>
        /// status. Possible reasons include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An internal issue prevented Amazon GameLift Servers from creating the container group
        /// definition resource. Delete the failed resource and call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerGroupDefinition.html">CreateContainerGroupDefinition</a>
        /// again. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An access-denied message means that you don't have permissions to access the container
        /// image on ECR. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-iam-policy-examples.html">
        /// IAM permission examples</a> for help setting up required IAM permissions for Amazon
        /// GameLift Servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>ImageUri</c> value for at least one of the containers in the container group
        /// definition was invalid or not found in the current Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// At least one of the container images referenced in the container group definition
        /// exceeds the allowed size. For size limits, see <a href="https://docs.aws.amazon.com/general/latest/gr/gamelift.html">
        /// Amazon GameLift Servers endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// At least one of the container images referenced in the container group definition
        /// uses a different operating system than the one defined for the container group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property SupportContainerDefinitions. 
        /// <para>
        /// The set of definitions for support containers in this group. A container group definition
        /// might have zero support container definitions. Support containers can be used in any
        /// type of container group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<SupportContainerDefinition> SupportContainerDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<SupportContainerDefinition>() : null;

        /// <summary>
        /// Checks to see if the SupportContainerDefinitions property is set.
        /// </summary>
        internal bool IsSetSupportContainerDefinitions() => this.SupportContainerDefinitions != null && (this.SupportContainerDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalMemoryLimitMebibytes. 
        /// <para>
        /// The amount of memory (in MiB) on a fleet instance to allocate for the container group.
        /// All containers in the group share these resources. 
        /// </para>
        ///  
        /// <para>
        /// You can set a limit for each container definition in the group. If individual containers
        /// have limits, this total value must be greater than any individual container's memory
        /// limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1024000)]
        public int? TotalMemoryLimitMebibytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalMemoryLimitMebibytes property is set.
        /// </summary>
        internal bool IsSetTotalMemoryLimitMebibytes() => this.TotalMemoryLimitMebibytes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalVcpuLimit. 
        /// <para>
        /// The amount of vCPU units on a fleet instance to allocate for the container group (1
        /// vCPU is equal to 1024 CPU units). All containers in the group share these resources.
        /// You can set a vCPU reservation for each container definition in the group. If individual
        /// containers have reservations, this total value must be equal to or greater than the
        /// sum of the reservations for each container in the group.
        /// </para>
        ///  
        /// <para>
        /// For a game server container group, if this property is set, Amazon GameLift Servers
        /// uses this value to calculate how many game server container groups fit on an instance.
        /// If this property isn't set, the group's containers can use up to the instance's available
        /// vCPU, and Amazon GameLift Servers uses the sum of the containers' <c>Vcpu</c> values
        /// to calculate how many game server container groups fit on an instance.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10)]
        public double? TotalVcpuLimit { get; set; }

        /// <summary>
        /// Checks to see if the TotalVcpuLimit property is set.
        /// </summary>
        internal bool IsSetTotalVcpuLimit() => this.TotalVcpuLimit.HasValue;

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// An optional description that was provided for a container group definition update.
        /// Each version can have a unique description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the VersionDescription property is set.
        /// </summary>
        internal bool IsSetVersionDescription() => this.VersionDescription != null;

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// Indicates the version of a particular container group definition. This number is incremented
        /// automatically when you update a container group definition. You can view, update,
        /// or delete individual versions or the entire container group definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? VersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the VersionNumber property is set.
        /// </summary>
        internal bool IsSetVersionNumber() => this.VersionNumber.HasValue;
    }
}
