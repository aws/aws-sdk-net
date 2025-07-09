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
    /// Container for the parameters to the CreateContainerFleet operation.
    /// Creates a managed fleet of Amazon Elastic Compute Cloud (Amazon EC2) instances to
    /// host your containerized game servers. Use this operation to define how to deploy a
    /// container architecture onto each fleet instance and configure fleet settings. You
    /// can create a container fleet in any Amazon Web Services Regions that Amazon GameLift
    /// Servers supports for multi-location fleets. A container fleet can be deployed to a
    /// single location or multiple locations. Container fleets are deployed with Amazon Linux
    /// 2023 as the instance operating system.
    /// 
    ///  
    /// <para>
    /// Define the fleet's container architecture using container group definitions. Each
    /// fleet can have one of the following container group types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The game server container group runs your game server build and dependent software.
    /// Amazon GameLift Servers deploys one or more replicas of this container group to each
    /// fleet instance. The number of replicas depends on the computing capabilities of the
    /// fleet instance in use. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An optional per-instance container group might be used to run other software that
    /// only needs to run once per instance, such as background services, logging, or test
    /// processes. One per-instance container group is deployed to each fleet instance. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each container group can include the definition for one or more containers. A container
    /// definition specifies a container image that is stored in an Amazon Elastic Container
    /// Registry (Amazon ECR) public or private repository.
    /// </para>
    ///  
    /// <para>
    ///  <b>Request options</b> 
    /// </para>
    ///  
    /// <para>
    /// Use this operation to make the following types of requests. Most fleet settings have
    /// default values, so you can create a working fleet with a minimal configuration and
    /// default values, which you can customize later.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Create a fleet with no container groups. You can configure a container fleet and then
    /// add container group definitions later. In this scenario, no fleet instances are deployed,
    /// and the fleet can't host game sessions until you add a game server container group
    /// definition. Provide the following required parameter values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>FleetRoleArn</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Create a fleet with a game server container group. Provide the following required
    /// parameter values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>FleetRoleArn</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GameServerContainerGroupDefinitionName</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Create a fleet with a game server container group and a per-instance container group.
    /// Provide the following required parameter values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>FleetRoleArn</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GameServerContainerGroupDefinitionName</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PerInstanceContainerGroupDefinitionName</c> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    ///  <b>Results</b> 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation creates a new container fleet resource, places it in
    /// <c>PENDING</c> status, and initiates the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-all.html#fleets-creation-workflow">fleet
    /// creation workflow</a>. For fleets with container groups, this workflow starts a fleet
    /// deployment and transitions the status to <c>ACTIVE</c>. Fleets without a container
    /// group are placed in <c>CREATED</c> status.
    /// </para>
    ///  
    /// <para>
    /// You can update most of the properties of a fleet, including container group definitions,
    /// and deploy the update across all fleet instances. Use a fleet update to deploy a new
    /// game server version update across the container fleet. 
    /// </para>
    /// </summary>
    public partial class CreateContainerFleetRequest : AmazonGameLiftRequest
    {
        private ContainerFleetBillingType _billingType;
        private string _description;
        private string _fleetRoleArn;
        private string _gameServerContainerGroupDefinitionName;
        private int? _gameServerContainerGroupsPerInstance;
        private GameSessionCreationLimitPolicy _gameSessionCreationLimitPolicy;
        private ConnectionPortRange _instanceConnectionPortRange;
        private List<IpPermission> _instanceInboundPermissions = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;
        private string _instanceType;
        private List<LocationConfiguration> _locations = AWSConfigs.InitializeCollections ? new List<LocationConfiguration>() : null;
        private LogConfiguration _logConfiguration;
        private List<string> _metricGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ProtectionPolicy _newGameSessionProtectionPolicy;
        private string _perInstanceContainerGroupDefinitionName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property BillingType. 
        /// <para>
        /// Indicates whether to use On-Demand or Spot instances for this fleet. Learn more about
        /// when to use <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-ec2-instances.html#gamelift-ec2-instances-spot">
        /// On-Demand versus Spot Instances</a>. This fleet property can't be changed after the
        /// fleet is created.
        /// </para>
        ///  
        /// <para>
        /// By default, this property is set to <c>ON_DEMAND</c>.
        /// </para>
        ///  
        /// <para>
        /// You can't update this fleet property later.
        /// </para>
        /// </summary>
        public ContainerFleetBillingType BillingType
        {
            get { return this._billingType; }
            set { this._billingType = value; }
        }

        // Check to see if BillingType property is set
        internal bool IsSetBillingType()
        {
            return this._billingType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A meaningful description of the container fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FleetRoleArn. 
        /// <para>
        /// The unique identifier for an Identity and Access Management (IAM) role with permissions
        /// to run your containers on resources that are managed by Amazon GameLift Servers. Use
        /// an IAM service role with the <c>GameLiftContainerFleetPolicy</c> managed policy attached.
        /// For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">Set
        /// up an IAM service role</a>. You can't change this fleet property after the fleet is
        /// created.
        /// </para>
        ///  
        /// <para>
        /// IAM role ARN values use the following pattern: <c>arn:aws:iam::[Amazon Web Services
        /// account]:role/[role name]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FleetRoleArn
        {
            get { return this._fleetRoleArn; }
            set { this._fleetRoleArn = value; }
        }

        // Check to see if FleetRoleArn property is set
        internal bool IsSetFleetRoleArn()
        {
            return this._fleetRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerContainerGroupDefinitionName. 
        /// <para>
        /// A container group definition resource that describes how to deploy containers with
        /// your game server build and support software onto each fleet instance. You can specify
        /// the container group definition's name to use the latest version. Alternatively, provide
        /// an ARN value with a specific version number.
        /// </para>
        ///  
        /// <para>
        /// Create a container group definition by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerGroupDefinition.html">CreateContainerGroupDefinition</a>.
        /// This operation creates a <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html">ContainerGroupDefinition</a>
        /// resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string GameServerContainerGroupDefinitionName
        {
            get { return this._gameServerContainerGroupDefinitionName; }
            set { this._gameServerContainerGroupDefinitionName = value; }
        }

        // Check to see if GameServerContainerGroupDefinitionName property is set
        internal bool IsSetGameServerContainerGroupDefinitionName()
        {
            return this._gameServerContainerGroupDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerContainerGroupsPerInstance. 
        /// <para>
        /// The number of times to replicate the game server container group on each fleet instance.
        /// 
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon GameLift Servers calculates the maximum number of game server container
        /// groups that can fit on each instance. This calculation is based on the CPU and memory
        /// resources of the fleet's instance type). To use the calculated maximum, don't set
        /// this parameter. If you set this number manually, Amazon GameLift Servers uses your
        /// value as long as it's less than the calculated maximum.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int? GameServerContainerGroupsPerInstance
        {
            get { return this._gameServerContainerGroupsPerInstance; }
            set { this._gameServerContainerGroupsPerInstance = value; }
        }

        // Check to see if GameServerContainerGroupsPerInstance property is set
        internal bool IsSetGameServerContainerGroupsPerInstance()
        {
            return this._gameServerContainerGroupsPerInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GameSessionCreationLimitPolicy. 
        /// <para>
        /// A policy that limits the number of game sessions that each individual player can create
        /// on instances in this fleet. The limit applies for a specified span of time.
        /// </para>
        /// </summary>
        public GameSessionCreationLimitPolicy GameSessionCreationLimitPolicy
        {
            get { return this._gameSessionCreationLimitPolicy; }
            set { this._gameSessionCreationLimitPolicy = value; }
        }

        // Check to see if GameSessionCreationLimitPolicy property is set
        internal bool IsSetGameSessionCreationLimitPolicy()
        {
            return this._gameSessionCreationLimitPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceConnectionPortRange. 
        /// <para>
        /// The set of port numbers to open on each fleet instance. A fleet's connection ports
        /// map to container ports that are configured in the fleet's container group definitions.
        /// 
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon GameLift Servers calculates an optimal port range based on your
        /// fleet configuration. To use the calculated range, don't set this parameter. The values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Port range: 4192 to a number calculated based on your fleet configuration. Amazon
        /// GameLift Servers uses the following formula: <c>4192 + [# of game server container
        /// groups per fleet instance] * [# of container ports in the game server container group
        /// definition] + [# of container ports in the game server container group definition]</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also choose to manually set this parameter. When manually setting this parameter,
        /// you must use port numbers that match the fleet's inbound permissions port range.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set values manually, Amazon GameLift Servers no longer calculates a port range
        /// for you, even if you later remove the manual settings. 
        /// </para>
        ///  </note>
        /// </summary>
        public ConnectionPortRange InstanceConnectionPortRange
        {
            get { return this._instanceConnectionPortRange; }
            set { this._instanceConnectionPortRange = value; }
        }

        // Check to see if InstanceConnectionPortRange property is set
        internal bool IsSetInstanceConnectionPortRange()
        {
            return this._instanceConnectionPortRange != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceInboundPermissions. 
        /// <para>
        /// The IP address ranges and port settings that allow inbound traffic to access game
        /// server processes and other processes on this fleet. As a best practice, when remotely
        /// accessing a fleet instance, we recommend opening ports only when you need them and
        /// closing them when you're finished.
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon GameLift Servers calculates an optimal port range based on your
        /// fleet configuration. To use the calculated range, don't set this parameter. The values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Protocol: UDP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Port range: 4192 to a number calculated based on your fleet configuration. Amazon
        /// GameLift Servers uses the following formula: <c>4192 + [# of game server container
        /// groups per fleet instance] * [# of container ports in the game server container group
        /// definition] + [# of container ports in the game server container group definition]</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also choose to manually set this parameter. When manually setting this parameter,
        /// you must use port numbers that match the fleet's connection port range.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set values manually, Amazon GameLift Servers no longer calculates a port range
        /// for you, even if you later remove the manual settings. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<IpPermission> InstanceInboundPermissions
        {
            get { return this._instanceInboundPermissions; }
            set { this._instanceInboundPermissions = value; }
        }

        // Check to see if InstanceInboundPermissions property is set
        internal bool IsSetInstanceInboundPermissions()
        {
            return this._instanceInboundPermissions != null && (this._instanceInboundPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type to use for all instances in the fleet. For multi-location
        /// fleets, the instance type must be available in the home region and all remote locations.
        /// Instance type determines the computing resources and processing power that's available
        /// to host your game servers. This includes including CPU, memory, storage, and networking
        /// capacity. 
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon GameLift Servers selects an instance type that fits the needs of
        /// your container groups and is available in all selected fleet locations. You can also
        /// choose to manually set this parameter. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// Elastic Compute Cloud Instance Types</a> for detailed descriptions of Amazon EC2 instance
        /// types.
        /// </para>
        ///  
        /// <para>
        /// You can't update this fleet property later.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Locations. 
        /// <para>
        /// A set of locations to deploy container fleet instances to. You can add any Amazon
        /// Web Services Region or Local Zone that's supported by Amazon GameLift Servers. Provide
        /// a list of one or more Amazon Web Services Region codes, such as <c>us-west-2</c>,
        /// or Local Zone names. Also include the fleet's home Region, which is the Amazon Web
        /// Services Region where the fleet is created. For a list of supported Regions and Local
        /// Zones, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">
        /// Amazon GameLift Servers service locations</a> for managed hosting.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<LocationConfiguration> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && (this._locations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// A method for collecting container logs for the fleet. Amazon GameLift Servers saves
        /// all standard output for each container in logs, including game session logs. You can
        /// select from the following methods: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLOUDWATCH</c> -- Send logs to an Amazon CloudWatch log group that you define.
        /// Each container emits a log stream, which is organized in the log group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> -- Store logs in an Amazon S3 bucket that you define.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> -- Don't collect container logs.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By default, this property is set to <c>CLOUDWATCH</c>. 
        /// </para>
        ///  
        /// <para>
        /// Amazon GameLift Servers requires permissions to send logs other Amazon Web Services
        /// services in your account. These permissions are included in the IAM fleet role for
        /// this container fleet (see <c>FleetRoleArn)</c>.
        /// </para>
        /// </summary>
        public LogConfiguration LogConfiguration
        {
            get { return this._logConfiguration; }
            set { this._logConfiguration = value; }
        }

        // Check to see if LogConfiguration property is set
        internal bool IsSetLogConfiguration()
        {
            return this._logConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MetricGroups. 
        /// <para>
        /// The name of an Amazon Web Services CloudWatch metric group to add this fleet to. You
        /// can use a metric group to aggregate metrics for multiple fleets. You can specify an
        /// existing metric group name or use a new name to create a new metric group. Each fleet
        /// can have only one metric group, but you can change this value at any time. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> MetricGroups
        {
            get { return this._metricGroups; }
            set { this._metricGroups = value; }
        }

        // Check to see if MetricGroups property is set
        internal bool IsSetMetricGroups()
        {
            return this._metricGroups != null && (this._metricGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NewGameSessionProtectionPolicy. 
        /// <para>
        /// Determines whether Amazon GameLift Servers can shut down game sessions on the fleet
        /// that are actively running and hosting players. Amazon GameLift Servers might prompt
        /// an instance shutdown when scaling down fleet capacity or when retiring unhealthy instances.
        /// You can also set game session protection for individual game sessions using <a href="gamelift/latest/apireference/API_UpdateGameSession.html">UpdateGameSession</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NoProtection</b> -- Game sessions can be shut down during active gameplay. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FullProtection</b> -- Game sessions in <c>ACTIVE</c> status can't be shut down.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By default, this property is set to <c>NoProtection</c>. 
        /// </para>
        /// </summary>
        public ProtectionPolicy NewGameSessionProtectionPolicy
        {
            get { return this._newGameSessionProtectionPolicy; }
            set { this._newGameSessionProtectionPolicy = value; }
        }

        // Check to see if NewGameSessionProtectionPolicy property is set
        internal bool IsSetNewGameSessionProtectionPolicy()
        {
            return this._newGameSessionProtectionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property PerInstanceContainerGroupDefinitionName. 
        /// <para>
        /// The name of a container group definition resource that describes a set of axillary
        /// software. A fleet instance has one process for executables in this container group.
        /// A per-instance container group is optional. You can update the fleet to add or remove
        /// a per-instance container group at any time. You can specify the container group definition's
        /// name to use the latest version. Alternatively, provide an ARN value with a specific
        /// version number. 
        /// </para>
        ///  
        /// <para>
        /// Create a container group definition by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerGroupDefinition.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerGroupDefinition.html</a>.
        /// This operation creates a <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html</a>
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string PerInstanceContainerGroupDefinitionName
        {
            get { return this._perInstanceContainerGroupDefinitionName; }
            set { this._perInstanceContainerGroupDefinitionName = value; }
        }

        // Check to see if PerInstanceContainerGroupDefinitionName property is set
        internal bool IsSetPerInstanceContainerGroupDefinitionName()
        {
            return this._perInstanceContainerGroupDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new fleet resource. Tags are developer-defined key-value
        /// pairs. Tagging Amazon Web Services resources are useful for resource management, access
        /// management and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
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

    }
}