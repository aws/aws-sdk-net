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
    /// The properties that describe a container group resource. You can update all properties
    /// of a container group definition properties. Updates to a container group definition
    /// are saved as new versions. 
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
        private string _containerGroupDefinitionArn;
        private ContainerGroupType _containerGroupType;
        private DateTime? _creationTime;
        private GameServerContainerDefinition _gameServerContainerDefinition;
        private string _name;
        private ContainerOperatingSystem _operatingSystem;
        private ContainerGroupDefinitionStatus _status;
        private string _statusReason;
        private List<SupportContainerDefinition> _supportContainerDefinitions = AWSConfigs.InitializeCollections ? new List<SupportContainerDefinition>() : null;
        private int? _totalMemoryLimitMebibytes;
        private double? _totalVcpuLimit;
        private string _versionDescription;
        private int? _versionNumber;

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
        [AWSProperty(Min=1, Max=512)]
        public string ContainerGroupDefinitionArn
        {
            get { return this._containerGroupDefinitionArn; }
            set { this._containerGroupDefinitionArn = value; }
        }

        // Check to see if ContainerGroupDefinitionArn property is set
        internal bool IsSetContainerGroupDefinitionArn()
        {
            return this._containerGroupDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerGroupType. 
        /// <para>
        /// The type of container group. Container group type determines how Amazon GameLift Servers
        /// deploys the container group on each fleet instance.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GameServerContainerDefinition. 
        /// <para>
        /// The definition for the game server container in this group. This property is used
        /// only when the container group type is <c>GAME_SERVER</c>. This container definition
        /// specifies a container image with the game server build. 
        /// </para>
        /// </summary>
        public GameServerContainerDefinition GameServerContainerDefinition
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
        /// A descriptive identifier for the container group definition. The name value is unique
        /// in an Amazon Web Services Region.
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
        /// The platform that all containers in the container group definition run on.
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
        public ContainerGroupDefinitionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about a container group definition that's in <c>FAILED</c>
        /// status. Possible reasons include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An internal issue prevented Amazon GameLift Servers from creating the container group
        /// definition resource. Delete the failed resource and call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerGroupDefinition.html">CreateContainerGroupDefinition</a>again.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An access-denied message means that you don't have permissions to access the container
        /// image on ECR. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-iam-policy-examples.html.html">
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
        [AWSProperty(Min=1, Max=1024)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property SupportContainerDefinitions. 
        /// <para>
        /// The set of definitions for support containers in this group. A container group definition
        /// might have zero support container definitions. Support container can be used in any
        /// type of container group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<SupportContainerDefinition> SupportContainerDefinitions
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
        [AWSProperty(Min=4, Max=1024000)]
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
        /// The amount of vCPU units on a fleet instance to allocate for the container group (1
        /// vCPU is equal to 1024 CPU units). All containers in the group share these resources.
        /// You can set a limit for each container definition in the group. If individual containers
        /// have limits, this total value must be equal to or greater than the sum of the limits
        /// for each container in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
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
        /// An optional description that was provided for a container group definition update.
        /// Each version can have a unique description.
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

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// Indicates the version of a particular container group definition. This number is incremented
        /// automatically when you update a container group definition. You can view, update,
        /// or delete individual versions or the entire container group definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}