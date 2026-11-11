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
    /// Container for the parameters to the UpdateContainerFleet operation. <b>This API works
    /// with the following fleet types:</b> Container <para> Updates the properties of a managed
    /// container fleet. Depending on the properties being updated, this operation might initiate
    /// a fleet deployment. You can track deployments for a fleet using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetDeployment.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetDeployment.html</a>.
    /// </para> <note> <para> A managed fleet's runtime environment, which depends on the
    /// fleet's Amazon Machine Image (AMI) version, can't be updated. You must create a new
    /// fleet. As a best practice, we recommend replacing your managed fleets every 30 days
    /// to maintain a secure and up-to-date runtime environment for your hosted game servers.
    /// For guidance, see <a href="https://docs.aws.amazon.com/gameliftservers/latest/developerguide/security-best-practices.html">
    /// Security best practices for Amazon GameLift Servers</a>. </para> </note> <para> <b>Request
    /// options</b> </para> <para> As with CreateContainerFleet, many fleet properties use
    /// common defaults or are calculated based on the fleet's container group definitions.
    /// </para> <ul> <li> <para> Update fleet properties that result in a fleet deployment.
    /// Include only those properties that you want to change. Specify deployment configuration
    /// settings. </para> </li> <li> <para> Update fleet properties that don't result in a
    /// fleet deployment. Include only those properties that you want to change. </para> </li>
    /// </ul> <para> Changes to the following properties initiate a fleet deployment: </para>
    /// <ul> <li> <para> <c>GameServerContainerGroupDefinition</c> </para> </li> <li> <para>
    /// <c>PerInstanceContainerGroupDefinition</c> </para> </li> <li> <para> <c>GameServerContainerGroupsPerInstance</c>
    /// </para> </li> <li> <para> <c>InstanceInboundPermissions</c> </para> </li> <li> <para>
    /// <c>InstanceConnectionPortRange</c> </para> </li> <li> <para> <c>LogConfiguration</c>
    /// </para> </li> </ul> <para> <b>Results</b> </para> <para> If successful, this operation
    /// updates the container fleet resource, and might initiate a new deployment of fleet
    /// resources using the deployment configuration provided. A deployment replaces existing
    /// fleet instances with new instances that are deployed with the updated fleet properties.
    /// The fleet is placed in <c>UPDATING</c> status until the deployment is complete, then
    /// returns to <c>ACTIVE</c>. </para> <para> You can have only one update deployment active
    /// at a time for a fleet. If a second update request initiates a deployment while another
    /// deployment is in progress, the first deployment is cancelled. </para>
    /// </summary>
    public partial class UpdateContainerFleetRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// Instructions for how to deploy updates to a container fleet, if the fleet update initiates
        /// a deployment. The deployment configuration lets you determine how to replace fleet
        /// instances and what actions to take if the deployment fails.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetDeploymentConfiguration() => this.DeploymentConfiguration != null;

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
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the container fleet to update. You can use either the fleet
        /// ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property GameServerContainerGroupDefinitionName. 
        /// <para>
        /// The name or ARN value of a new game server container group definition to deploy on
        /// the fleet. If you're updating the fleet to a specific version of a container group
        /// definition, use the ARN value and include the version number. If you're updating the
        /// fleet to the latest version of a container group definition, you can use the name
        /// value. You can't remove a fleet's game server container group definition, you can
        /// only update or replace it with another definition.
        /// </para>
        ///  
        /// <para>
        /// Update a container group definition by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateContainerGroupDefinition.html">UpdateContainerGroupDefinition</a>.
        /// This operation creates a <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html">ContainerGroupDefinition</a>
        /// resource with an incremented version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string GameServerContainerGroupDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the GameServerContainerGroupDefinitionName property is set.
        /// </summary>
        internal bool IsSetGameServerContainerGroupDefinitionName() => this.GameServerContainerGroupDefinitionName != null;

        /// <summary>
        /// Gets and sets the property GameServerContainerGroupsPerInstance. 
        /// <para>
        /// The number of times to replicate the game server container group on each fleet instance.
        /// By default, Amazon GameLift Servers calculates the maximum number of game server container
        /// groups that can fit on each instance. You can remove this property value to use the
        /// calculated value, or set it manually. If you set this number manually, Amazon GameLift
        /// Servers uses your value as long as it's less than the calculated maximum.
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
        /// <para>
        /// A revised set of port numbers to open on each fleet instance. By default, Amazon GameLift
        /// Servers calculates an optimal port range based on your fleet configuration. If you
        /// previously set this parameter manually, you can't reset this to use the calculated
        /// settings.
        /// </para>
        ///  
        /// <para>
        /// The port range must not overlap with the Amazon GameLift Servers reserved port range
        /// <c>4092-4191</c>. This range is reserved for internal Amazon GameLift Servers services.
        /// </para>
        /// </summary>
        public ConnectionPortRange InstanceConnectionPortRange { get; set; }

        /// <summary>
        /// Checks to see if the InstanceConnectionPortRange property is set.
        /// </summary>
        internal bool IsSetInstanceConnectionPortRange() => this.InstanceConnectionPortRange != null;

        /// <summary>
        /// Gets and sets the property InstanceInboundPermissionAuthorizations. 
        /// <para>
        /// A set of ports to add to the container fleet's inbound permissions.
        /// </para>
        ///  
        /// <para>
        /// The port range must not overlap with the Amazon GameLift Servers reserved port range
        /// <c>4092-4191</c>. This range is reserved for internal Amazon GameLift Servers services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<IpPermission> InstanceInboundPermissionAuthorizations { get; set; } = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;

        /// <summary>
        /// Checks to see if the InstanceInboundPermissionAuthorizations property is set.
        /// </summary>
        internal bool IsSetInstanceInboundPermissionAuthorizations() => this.InstanceInboundPermissionAuthorizations != null && (this.InstanceInboundPermissionAuthorizations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceInboundPermissionRevocations. 
        /// <para>
        /// A set of ports to remove from the container fleet's inbound permissions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<IpPermission> InstanceInboundPermissionRevocations { get; set; } = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;

        /// <summary>
        /// Checks to see if the InstanceInboundPermissionRevocations property is set.
        /// </summary>
        internal bool IsSetInstanceInboundPermissionRevocations() => this.InstanceInboundPermissionRevocations != null && (this.InstanceInboundPermissionRevocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The method for collecting container logs for the fleet. 
        /// </para>
        /// </summary>
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property MetricGroups. 
        /// <para>
        /// The name of an Amazon Web Services CloudWatch metric group to add this fleet to. 
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
        /// The game session protection policy to apply to all new game sessions that are started
        /// in this fleet. Game sessions that already exist are not affected. 
        /// </para>
        /// </summary>
        public ProtectionPolicy NewGameSessionProtectionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the NewGameSessionProtectionPolicy property is set.
        /// </summary>
        internal bool IsSetNewGameSessionProtectionPolicy() => this.NewGameSessionProtectionPolicy != null;

        /// <summary>
        /// Gets and sets the property PerInstanceContainerGroupDefinitionName. 
        /// <para>
        /// The name or ARN value of a new per-instance container group definition to deploy on
        /// the fleet. If you're updating the fleet to a specific version of a container group
        /// definition, use the ARN value and include the version number. If you're updating the
        /// fleet to the latest version of a container group definition, you can use the name
        /// value.
        /// </para>
        ///  
        /// <para>
        /// Update a container group definition by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateContainerGroupDefinition.html">UpdateContainerGroupDefinition</a>.
        /// This operation creates a <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html">ContainerGroupDefinition</a>
        /// resource with an incremented version. 
        /// </para>
        ///  
        /// <para>
        /// To remove a fleet's per-instance container group definition, leave this parameter
        /// empty and use the parameter <c>RemoveAttributes</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string PerInstanceContainerGroupDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the PerInstanceContainerGroupDefinitionName property is set.
        /// </summary>
        internal bool IsSetPerInstanceContainerGroupDefinitionName() => this.PerInstanceContainerGroupDefinitionName != null;

        /// <summary>
        /// Gets and sets the property RemoveAttributes. 
        /// <para>
        /// If set, this update removes a fleet's per-instance container group definition. You
        /// can't remove a fleet's game server container group definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> RemoveAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveAttributes property is set.
        /// </summary>
        internal bool IsSetRemoveAttributes() => this.RemoveAttributes != null && (this.RemoveAttributes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
