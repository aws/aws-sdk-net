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
    /// Describes an Amazon GameLift Servers managed container fleet.
    /// </summary>
    public partial class ContainerFleet
    {
        private ContainerFleetBillingType _billingType;
        private DateTime? _creationTime;
        private DeploymentDetails _deploymentDetails;
        private string _description;
        private string _fleetArn;
        private string _fleetId;
        private string _fleetRoleArn;
        private string _gameServerContainerGroupDefinitionArn;
        private string _gameServerContainerGroupDefinitionName;
        private int? _gameServerContainerGroupsPerInstance;
        private GameSessionCreationLimitPolicy _gameSessionCreationLimitPolicy;
        private ConnectionPortRange _instanceConnectionPortRange;
        private List<IpPermission> _instanceInboundPermissions = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;
        private string _instanceType;
        private List<ContainerFleetLocationAttributes> _locationAttributes = AWSConfigs.InitializeCollections ? new List<ContainerFleetLocationAttributes>() : null;
        private LogConfiguration _logConfiguration;
        private int? _maximumGameServerContainerGroupsPerInstance;
        private List<string> _metricGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ProtectionPolicy _newGameSessionProtectionPolicy;
        private string _perInstanceContainerGroupDefinitionArn;
        private string _perInstanceContainerGroupDefinitionName;
        private ContainerFleetStatus _status;

        /// <summary>
        /// Gets and sets the property BillingType. 
        /// <para>
        /// Indicates whether the fleet uses On-Demand or Spot instances for this fleet. Learn
        /// more about when to use <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-ec2-instances.html#gamelift-ec2-instances-spot">
        /// On-Demand versus Spot Instances</a>. You can't update this fleet property.
        /// </para>
        ///  
        /// <para>
        /// By default, this property is set to <c>ON_DEMAND</c>.
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
        /// Gets and sets the property DeploymentDetails. 
        /// <para>
        /// Information about the most recent deployment for the container fleet.
        /// </para>
        /// </summary>
        public DeploymentDetails DeploymentDetails
        {
            get { return this._deploymentDetails; }
            set { this._deploymentDetails = value; }
        }

        // Check to see if DeploymentDetails property is set
        internal bool IsSetDeploymentDetails()
        {
            return this._deploymentDetails != null;
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
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers fleet resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</c>.
        /// In a GameLift fleet ARN, the resource ID matches the <c>FleetId</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the container fleet to retrieve. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property FleetRoleArn. 
        /// <para>
        /// The unique identifier for an Identity and Access Management (IAM) role with permissions
        /// to run your containers on resources that are managed by Amazon GameLift Servers. See
        /// <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">Set
        /// up an IAM service role</a>. This fleet property can't be changed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property GameServerContainerGroupDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to the fleet's game server container group. The ARN value also identifies
        /// the specific container group definition version in use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string GameServerContainerGroupDefinitionArn
        {
            get { return this._gameServerContainerGroupDefinitionArn; }
            set { this._gameServerContainerGroupDefinitionArn = value; }
        }

        // Check to see if GameServerContainerGroupDefinitionArn property is set
        internal bool IsSetGameServerContainerGroupDefinitionArn()
        {
            return this._gameServerContainerGroupDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerContainerGroupDefinitionName. 
        /// <para>
        /// The name of the fleet's game server container group definition, which describes how
        /// to deploy containers with your game server build and support software onto each fleet
        /// instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// server processes and other processes on this fleet. 
        /// </para>
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
        /// The Amazon EC2 instance type to use for all instances in the fleet. Instance type
        /// determines the computing resources and processing power that's available to host your
        /// game servers. This includes including CPU, memory, storage, and networking capacity.
        /// You can't update this fleet property.
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
        /// Gets and sets the property LocationAttributes. 
        /// <para>
        /// Information about the container fleet's remote locations where fleet instances are
        /// deployed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerFleetLocationAttributes> LocationAttributes
        {
            get { return this._locationAttributes; }
            set { this._locationAttributes = value; }
        }

        // Check to see if LocationAttributes property is set
        internal bool IsSetLocationAttributes()
        {
            return this._locationAttributes != null && (this._locationAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The method that is used to collect container logs for the fleet. Amazon GameLift Servers
        /// saves all standard output for each container in logs, including game session logs.
        /// 
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
        /// Gets and sets the property MaximumGameServerContainerGroupsPerInstance. 
        /// <para>
        /// The calculated maximum number of game server container group that can be deployed
        /// on each fleet instance. The calculation depends on the resource needs of the container
        /// group and the CPU and memory resources of the fleet's instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int? MaximumGameServerContainerGroupsPerInstance
        {
            get { return this._maximumGameServerContainerGroupsPerInstance; }
            set { this._maximumGameServerContainerGroupsPerInstance = value; }
        }

        // Check to see if MaximumGameServerContainerGroupsPerInstance property is set
        internal bool IsSetMaximumGameServerContainerGroupsPerInstance()
        {
            return this._maximumGameServerContainerGroupsPerInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricGroups. 
        /// <para>
        /// The name of an Amazon Web Services CloudWatch metric group to add this fleet to. Metric
        /// groups aggregate metrics for multiple fleets. 
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
        /// Gets and sets the property PerInstanceContainerGroupDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to the fleet's per-instance container group. The ARN value also identifies
        /// the specific container group definition version in use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string PerInstanceContainerGroupDefinitionArn
        {
            get { return this._perInstanceContainerGroupDefinitionArn; }
            set { this._perInstanceContainerGroupDefinitionArn = value; }
        }

        // Check to see if PerInstanceContainerGroupDefinitionArn property is set
        internal bool IsSetPerInstanceContainerGroupDefinitionArn()
        {
            return this._perInstanceContainerGroupDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property PerInstanceContainerGroupDefinitionName. 
        /// <para>
        /// The name of the fleet's per-instance container group definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the container fleet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> -- A new container fleet has been requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> -- A new container fleet resource is being created. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATED</c> -- A new container fleet resource has been created. No fleet instances
        /// have been deployed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATING</c> -- New container fleet instances are being deployed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> -- The container fleet has been deployed and is ready to host game
        /// sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> -- Updates to the container fleet is being updated. A deployment
        /// is in progress.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContainerFleetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}