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
    /// Describes an Amazon GameLift Servers managed container fleet.
    /// </summary>
    public partial class ContainerFleet
    {
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
        public ContainerFleetBillingType BillingType { get; set; }

        /// <summary>
        /// Checks to see if the BillingType property is set.
        /// </summary>
        internal bool IsSetBillingType() => this.BillingType != null;

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
        /// Gets and sets the property DeploymentDetails. 
        /// <para>
        /// Information about the most recent deployment for the container fleet.
        /// </para>
        /// </summary>
        public DeploymentDetails DeploymentDetails { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentDetails property is set.
        /// </summary>
        internal bool IsSetDeploymentDetails() => this.DeploymentDetails != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A meaningful description of the container fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers fleet resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</c>.
        /// In a GameLift fleet ARN, the resource ID matches the <c>FleetId</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FleetArn { get; set; }

        /// <summary>
        /// Checks to see if the FleetArn property is set.
        /// </summary>
        internal bool IsSetFleetArn() => this.FleetArn != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the container fleet to retrieve. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property FleetRoleArn. 
        /// <para>
        /// The unique identifier for an Identity and Access Management (IAM) role with permissions
        /// to run your containers on resources that are managed by Amazon GameLift Servers. See
        /// <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">Set
        /// up an IAM service role</a>. This fleet property can't be changed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FleetRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the FleetRoleArn property is set.
        /// </summary>
        internal bool IsSetFleetRoleArn() => this.FleetRoleArn != null;

        /// <summary>
        /// Gets and sets the property GameServerContainerGroupDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to the fleet's game server container group. The ARN value also identifies
        /// the specific container group definition version in use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string GameServerContainerGroupDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the GameServerContainerGroupDefinitionArn property is set.
        /// </summary>
        internal bool IsSetGameServerContainerGroupDefinitionArn() => this.GameServerContainerGroupDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property GameServerContainerGroupDefinitionName. 
        /// <para>
        /// The name of the fleet's game server container group definition, which describes how
        /// to deploy containers with your game server build and support software onto each fleet
        /// instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string GameServerContainerGroupDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the GameServerContainerGroupDefinitionName property is set.
        /// </summary>
        internal bool IsSetGameServerContainerGroupDefinitionName() => this.GameServerContainerGroupDefinitionName != null;

        /// <summary>
        /// Gets and sets the property GameServerContainerGroupsPerInstance. 
        /// <para>
        /// The number of times to replicate the game server container group on each fleet instance.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public int? GameServerContainerGroupsPerInstance { get; set; }

        /// <summary>
        /// Checks to see if the GameServerContainerGroupsPerInstance property is set.
        /// </summary>
        internal bool IsSetGameServerContainerGroupsPerInstance() => this.GameServerContainerGroupsPerInstance.HasValue;

        /// <summary>
        /// Gets and sets the property GameSessionCreationLimitPolicy. 
        /// <para>
        /// A policy that limits the number of game sessions that each individual player can create
        /// on instances in this fleet. The limit applies for a specified span of time.
        /// </para>
        /// </summary>
        public GameSessionCreationLimitPolicy GameSessionCreationLimitPolicy { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionCreationLimitPolicy property is set.
        /// </summary>
        internal bool IsSetGameSessionCreationLimitPolicy() => this.GameSessionCreationLimitPolicy != null;

        /// <summary>
        /// Gets and sets the property InstanceConnectionPortRange.
        /// </summary>
        public ConnectionPortRange InstanceConnectionPortRange { get; set; }

        /// <summary>
        /// Checks to see if the InstanceConnectionPortRange property is set.
        /// </summary>
        internal bool IsSetInstanceConnectionPortRange() => this.InstanceConnectionPortRange != null;

        /// <summary>
        /// Gets and sets the property InstanceInboundPermissions. 
        /// <para>
        /// The IP address ranges and port settings that allow inbound traffic to access game
        /// server processes and other processes on this fleet. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<IpPermission> InstanceInboundPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;

        /// <summary>
        /// Checks to see if the InstanceInboundPermissions property is set.
        /// </summary>
        internal bool IsSetInstanceInboundPermissions() => this.InstanceInboundPermissions != null && (this.InstanceInboundPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type to use for all instances in the fleet. Instance type
        /// determines the computing resources and processing power that's available to host your
        /// game servers. This includes CPU, memory, storage, and networking capacity. You can't
        /// update this fleet property.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LocationAttributes. 
        /// <para>
        /// Information about the container fleet's remote locations where fleet instances are
        /// deployed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerFleetLocationAttributes> LocationAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerFleetLocationAttributes>() : null;

        /// <summary>
        /// Checks to see if the LocationAttributes property is set.
        /// </summary>
        internal bool IsSetLocationAttributes() => this.LocationAttributes != null && (this.LocationAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaximumGameServerContainerGroupsPerInstance. 
        /// <para>
        /// The calculated maximum number of game server container groups that can be deployed
        /// on each fleet instance. The calculation depends on the resource needs of the container
        /// group and the CPU and memory resources of the fleet's instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public int? MaximumGameServerContainerGroupsPerInstance { get; set; }

        /// <summary>
        /// Checks to see if the MaximumGameServerContainerGroupsPerInstance property is set.
        /// </summary>
        internal bool IsSetMaximumGameServerContainerGroupsPerInstance() => this.MaximumGameServerContainerGroupsPerInstance.HasValue;

        /// <summary>
        /// Gets and sets the property MetricGroups. 
        /// <para>
        /// The name of an Amazon Web Services CloudWatch metric group to add this fleet to. Metric
        /// groups aggregate metrics for multiple fleets. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> MetricGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MetricGroups property is set.
        /// </summary>
        internal bool IsSetMetricGroups() => this.MetricGroups != null && (this.MetricGroups.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public ProtectionPolicy NewGameSessionProtectionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the NewGameSessionProtectionPolicy property is set.
        /// </summary>
        internal bool IsSetNewGameSessionProtectionPolicy() => this.NewGameSessionProtectionPolicy != null;

        /// <summary>
        /// Gets and sets the property PerInstanceContainerGroupDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to the fleet's per-instance container group. The ARN value also identifies
        /// the specific container group definition version in use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string PerInstanceContainerGroupDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the PerInstanceContainerGroupDefinitionArn property is set.
        /// </summary>
        internal bool IsSetPerInstanceContainerGroupDefinitionArn() => this.PerInstanceContainerGroupDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property PerInstanceContainerGroupDefinitionName. 
        /// <para>
        /// The name of the fleet's per-instance container group definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PerInstanceContainerGroupDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the PerInstanceContainerGroupDefinitionName property is set.
        /// </summary>
        internal bool IsSetPerInstanceContainerGroupDefinitionName() => this.PerInstanceContainerGroupDefinitionName != null;

        /// <summary>
        /// Gets and sets the property PlayerGatewayMode. 
        /// <para>
        /// Indicates whether player gateway is enabled for this container fleet. Player gateway
        /// provides benefits such as DDoS protection with negligible impact to latency.
        /// </para>
        ///  
        /// <para>
        /// If <c>ENABLED</c> or <c>REQUIRED</c>, game clients can use player gateway to connect
        /// with the game server. If <c>DISABLED</c>, game clients cannot use player gateway.
        /// Instead, they have to directly connect to the game server.
        /// </para>
        /// </summary>
        public PlayerGatewayMode PlayerGatewayMode { get; set; }

        /// <summary>
        /// Checks to see if the PlayerGatewayMode property is set.
        /// </summary>
        internal bool IsSetPlayerGatewayMode() => this.PlayerGatewayMode != null;

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
        ///  <c>UPDATING</c> -- The container fleet is being updated. A deployment is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c> -- The container fleet has been expired. The fleet is scaled down
        /// to zero instances and cannot host new game sessions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContainerFleetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
