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
    /// Container for the parameters to the CreateFleet operation. <b>This API works with
    /// the following fleet types:</b> EC2, Anywhere, Container <para> Creates a fleet of
    /// compute resources to host your game servers. Use this operation to set up a fleet
    /// for the following compute types: </para> <para> <b>Managed EC2 fleet</b> </para> <para>
    /// An EC2 fleet is a set of Amazon Elastic Compute Cloud (Amazon EC2) instances. Your
    /// game server build is deployed to each fleet instance. Amazon GameLift Servers manages
    /// the fleet's instances and controls the lifecycle of game server processes, which host
    /// game sessions for players. EC2 fleets can have instances in multiple locations. Each
    /// instance in the fleet is designated a <c>Compute</c>. </para> <para> To create an
    /// EC2 fleet, provide these required parameters: </para> <ul> <li> <para> Either <c>BuildId</c>
    /// or <c>ScriptId</c> </para> </li> <li> <para> <c>ComputeType</c> set to <c>EC2</c>
    /// (the default value) </para> </li> <li> <para> <c>EC2InboundPermissions</c> </para>
    /// </li> <li> <para> <c>EC2InstanceType</c> </para> </li> <li> <para> <c>FleetType</c>
    /// </para> </li> <li> <para> <c>Name</c> </para> </li> <li> <para> <c>RuntimeConfiguration</c>
    /// with at least one <c>ServerProcesses</c> configuration </para> </li> </ul> <para>
    /// If successful, this operation creates a new fleet resource and places it in <c>NEW</c>
    /// status while Amazon GameLift Servers initiates the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-all.html#fleets-creation-workflow">fleet
    /// creation workflow</a>. To debug your fleet, fetch logs, view performance metrics or
    /// other actions on the fleet, create a development fleet with port 22/3389 open. As
    /// a best practice, we recommend opening ports for remote access only when you need them
    /// and closing them when you're finished. </para> <para> When the fleet status is ACTIVE,
    /// you can adjust capacity settings and turn autoscaling on/off for each location. </para>
    /// <note> <para> A managed fleet's runtime environment depends on the Amazon Machine
    /// Image (AMI) version it uses. When a new fleet is created, Amazon GameLift Servers
    /// assigns the latest available AMI version to the fleet, and all compute instances in
    /// that fleet are deployed with that version. To update the AMI version, you must create
    /// a new fleet. As a best practice, we recommend replacing your managed fleets every
    /// 30 days to maintain a secure and up-to-date runtime environment for your hosted game
    /// servers. For guidance, see <a href="https://docs.aws.amazon.com/gameliftservers/latest/developerguide/security-best-practices.html">
    /// Security best practices for Amazon GameLift Servers</a>. </para> </note> <para> <b>Anywhere
    /// fleet</b> </para> <para> An Anywhere fleet represents compute resources that are not
    /// owned or managed by Amazon GameLift Servers. You might create an Anywhere fleet with
    /// your local machine for testing, or use one to host game servers with on-premises hardware
    /// or other game hosting solutions. </para> <para> To create an Anywhere fleet, provide
    /// these required parameters: </para> <ul> <li> <para> <c>ComputeType</c> set to <c>ANYWHERE</c>
    /// </para> </li> <li> <para> <c>Locations</c> specifying a custom location </para> </li>
    /// <li> <para> <c>Name</c> </para> </li> </ul> <para> If successful, this operation creates
    /// a new fleet resource and places it in <c>ACTIVE</c> status. You can register computes
    /// with a fleet in <c>ACTIVE</c> status. </para> <para> <b>Learn more</b> </para> <para>
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up fleets</a> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html#fleets-creating-debug-creation">Debug
    /// fleet creation issues</a> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Multi-location
    /// fleets</a> </para>
    /// </summary>
    public partial class CreateFleetRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property AnywhereConfiguration. 
        /// <para>
        /// Amazon GameLift Servers Anywhere configuration options.
        /// </para>
        /// </summary>
        public AnywhereConfiguration AnywhereConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AnywhereConfiguration property is set.
        /// </summary>
        internal bool IsSetAnywhereConfiguration() => this.AnywhereConfiguration != null;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// The unique identifier for a custom game server build to be deployed to a fleet with
        /// compute type <c>EC2</c>. You can use either the build ID or ARN. The build must be
        /// uploaded to Amazon GameLift Servers and in <c>READY</c> status. This fleet property
        /// can't be changed after the fleet is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string BuildId { get; set; }

        /// <summary>
        /// Checks to see if the BuildId property is set.
        /// </summary>
        internal bool IsSetBuildId() => this.BuildId != null;

        /// <summary>
        /// Gets and sets the property CertificateConfiguration. 
        /// <para>
        /// Prompts Amazon GameLift Servers to generate a TLS/SSL certificate for the fleet. Amazon
        /// GameLift Servers uses the certificates to encrypt traffic between game clients and
        /// the game servers running on Amazon GameLift Servers. By default, the <c>CertificateConfiguration</c>
        /// is <c>DISABLED</c>. You can't change this property after you create the fleet. 
        /// </para>
        ///  
        /// <para>
        /// Certificate Manager (ACM) certificates expire after 13 months. Certificate expiration
        /// can cause fleets to fail, preventing players from connecting to instances in the fleet.
        /// We recommend you replace fleets before 13 months, consider using fleet aliases for
        /// a smooth transition.
        /// </para>
        ///  <note> 
        /// <para>
        /// ACM isn't available in all Amazon Web Services regions. A fleet creation request with
        /// certificate generation enabled in an unsupported Region, fails with a 4xx error. For
        /// more information about the supported Regions, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-regions.html">Supported
        /// Regions</a> in the <i>Certificate Manager User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public CertificateConfiguration CertificateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CertificateConfiguration property is set.
        /// </summary>
        internal bool IsSetCertificateConfiguration() => this.CertificateConfiguration != null;

        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// The type of compute resource used to host your game servers. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EC2</c> – The game server build is deployed to Amazon EC2 instances for cloud
        /// hosting. This is the default setting.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANYWHERE</c> – Game servers and supporting software are deployed to compute resources
        /// that you provide and manage. With this compute type, you can also set the <c>AnywhereConfiguration</c>
        /// parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ComputeType ComputeType { get; set; }

        /// <summary>
        /// Checks to see if the ComputeType property is set.
        /// </summary>
        internal bool IsSetComputeType() => this.ComputeType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EC2InboundPermissions. 
        /// <para>
        /// The IP address ranges and port settings that allow inbound traffic to access game
        /// server processes and other processes on this fleet. Set this parameter for managed
        /// EC2 fleets. You can leave this parameter empty when creating the fleet, but you must
        /// call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateFleetPortSettings">https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateFleetPortSettings</a>
        /// to set it before players can connect to game sessions. As a best practice, we recommend
        /// opening ports for remote access only when you need them and closing them when you're
        /// finished. For Amazon GameLift Servers Realtime fleets, Amazon GameLift Servers automatically
        /// sets TCP and UDP ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<IpPermission> EC2InboundPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;

        /// <summary>
        /// Checks to see if the EC2InboundPermissions property is set.
        /// </summary>
        internal bool IsSetEC2InboundPermissions() => this.EC2InboundPermissions != null && (this.EC2InboundPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EC2InstanceType. 
        /// <para>
        /// The Amazon GameLift Servers-supported Amazon EC2 instance type to use with managed
        /// EC2 fleets. Instance type determines the computing resources that will be used to
        /// host your game servers, including CPU, memory, storage, and networking capacity. See
        /// <a href="http://aws.amazon.com/ec2/instance-types/">Amazon Elastic Compute Cloud Instance
        /// Types</a> for detailed descriptions of Amazon EC2 instance types.
        /// </para>
        /// </summary>
        public EC2InstanceType EC2InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the EC2InstanceType property is set.
        /// </summary>
        internal bool IsSetEC2InstanceType() => this.EC2InstanceType != null;

        /// <summary>
        /// Gets and sets the property FleetType. 
        /// <para>
        /// Indicates whether to use On-Demand or Spot instances for this fleet. By default, this
        /// property is set to <c>ON_DEMAND</c>. Learn more about when to use <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-ec2-instances.html#gamelift-ec2-instances-spot">
        /// On-Demand versus Spot Instances</a>. This fleet property can't be changed after the
        /// fleet is created.
        /// </para>
        /// </summary>
        public FleetType FleetType { get; set; }

        /// <summary>
        /// Checks to see if the FleetType property is set.
        /// </summary>
        internal bool IsSetFleetType() => this.FleetType != null;

        /// <summary>
        /// Gets and sets the property InstanceRoleArn. 
        /// <para>
        /// A unique identifier for an IAM role that manages access to your Amazon Web Services
        /// services. With an instance role ARN set, any application that runs on an instance
        /// in this fleet can assume the role, including install scripts, server processes, and
        /// daemons (background processes). Create a role or look up a role's ARN by using the
        /// <a href="https://console.aws.amazon.com/iam/">IAM dashboard</a> in the Amazon Web
        /// Services Management Console. Learn more about using on-box credentials for your game
        /// servers at <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-resources.html">
        /// Access external resources from a game server</a>. This fleet property can't be changed
        /// after the fleet is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string InstanceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRoleArn property is set.
        /// </summary>
        internal bool IsSetInstanceRoleArn() => this.InstanceRoleArn != null;

        /// <summary>
        /// Gets and sets the property InstanceRoleCredentialsProvider. 
        /// <para>
        /// Prompts Amazon GameLift Servers to generate a shared credentials file for the IAM
        /// role that's defined in <c>InstanceRoleArn</c>. The shared credentials file is stored
        /// on each fleet instance and refreshed as needed. Use shared credentials for applications
        /// that are deployed along with the game server executable, if the game server is integrated
        /// with server SDK version 5.x. For more information about using shared credentials,
        /// see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-resources.html">
        /// Communicate with other Amazon Web Services resources from your fleets</a>.
        /// </para>
        /// </summary>
        public InstanceRoleCredentialsProvider InstanceRoleCredentialsProvider { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRoleCredentialsProvider property is set.
        /// </summary>
        internal bool IsSetInstanceRoleCredentialsProvider() => this.InstanceRoleCredentialsProvider != null;

        /// <summary>
        /// Gets and sets the property Locations. 
        /// <para>
        /// A set of remote locations to deploy additional instances to and manage as a multi-location
        /// fleet. Use this parameter when creating a fleet in Amazon Web Services Regions that
        /// support multiple locations. You can add any Amazon Web Services Region or Local Zone
        /// that's supported by Amazon GameLift Servers. Provide a list of one or more Amazon
        /// Web Services Region codes, such as <c>us-west-2</c>, or Local Zone names. When using
        /// this parameter, Amazon GameLift Servers requires you to include your home location
        /// in the request. For a list of supported Regions and Local Zones, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">
        /// Amazon GameLift Servers service locations</a> for managed hosting.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<LocationConfiguration> Locations { get; set; } = AWSConfigs.InitializeCollections ? new List<LocationConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Locations property is set.
        /// </summary>
        internal bool IsSetLocations() => this.Locations != null && (this.Locations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogPaths. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> To specify where Amazon GameLift Servers
        /// should store log files once a server process shuts down, use the Amazon GameLift Servers
        /// server API <c>ProcessReady()</c> and specify one or more directory paths in <c>logParameters</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-initialize">Initialize
        /// the server process</a> in the <i>Amazon GameLift Servers Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogPaths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogPaths property is set.
        /// </summary>
        internal bool IsSetLogPaths() => this.LogPaths != null && (this.LogPaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricGroups. 
        /// <para>
        /// The name of an Amazon Web Services CloudWatch metric group to add this fleet to. A
        /// metric group is used to aggregate the metrics for multiple fleets. You can specify
        /// an existing metric group name or set a new name to create a new metric group. A fleet
        /// can be included in only one metric group at a time. 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a fleet. Fleet names do not need to be
        /// unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NewGameSessionProtectionPolicy. 
        /// <para>
        /// The status of termination protection for active game sessions on the fleet. By default,
        /// this property is set to <c>NoProtection</c>. You can also set game session protection
        /// for an individual game session by calling <a href="gamelift/latest/apireference/API_UpdateGameSession.html">UpdateGameSession</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NoProtection</b> - Game sessions can be terminated during active gameplay as a
        /// result of a scale-down event. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FullProtection</b> - Game sessions in <c>ACTIVE</c> status cannot be terminated
        /// during a scale-down event.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProtectionPolicy NewGameSessionProtectionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the NewGameSessionProtectionPolicy property is set.
        /// </summary>
        internal bool IsSetNewGameSessionProtectionPolicy() => this.NewGameSessionProtectionPolicy != null;

        /// <summary>
        /// Gets and sets the property PeerVpcAwsAccountId. 
        /// <para>
        /// Used when peering your Amazon GameLift Servers fleet with a VPC, the unique identifier
        /// for the Amazon Web Services account that owns the VPC. You can find your account ID
        /// in the Amazon Web Services Management Console under account settings. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PeerVpcAwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the PeerVpcAwsAccountId property is set.
        /// </summary>
        internal bool IsSetPeerVpcAwsAccountId() => this.PeerVpcAwsAccountId != null;

        /// <summary>
        /// Gets and sets the property PeerVpcId. 
        /// <para>
        /// A unique identifier for a VPC with resources to be accessed by your Amazon GameLift
        /// Servers fleet. The VPC must be in the same Region as your fleet. To look up a VPC
        /// ID, use the <a href="https://console.aws.amazon.com/vpc/">VPC Dashboard</a> in the
        /// Amazon Web Services Management Console. Learn more about VPC peering in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Servers Fleets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PeerVpcId { get; set; }

        /// <summary>
        /// Checks to see if the PeerVpcId property is set.
        /// </summary>
        internal bool IsSetPeerVpcId() => this.PeerVpcId != null;

        /// <summary>
        /// Gets and sets the property PlayerGatewayConfiguration. 
        /// <para>
        /// Configuration settings for player gateway. Use this to specify advanced options for
        /// how player gateway handles connections.
        /// </para>
        /// </summary>
        public PlayerGatewayConfiguration PlayerGatewayConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PlayerGatewayConfiguration property is set.
        /// </summary>
        internal bool IsSetPlayerGatewayConfiguration() => this.PlayerGatewayConfiguration != null;

        /// <summary>
        /// Gets and sets the property PlayerGatewayMode. 
        /// <para>
        /// Configures player gateway for your fleet. Player gateway provides benefits such as
        /// DDoS protection by rate limiting and validating traffic before it reaches game servers,
        /// hiding game server IP addresses from players, and providing updated endpoints when
        /// relay endpoints become unhealthy. Note, player gateway is only available for fleets
        /// using server SDK 5.x or later game server builds.
        /// </para>
        ///  
        /// <para>
        ///  <b>How it works:</b> When enabled, game clients connect to relay endpoints instead
        /// of to your game servers. Player gateway validates player gateway tokens and routes
        /// traffic to the appropriate game server. Your game backend calls <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetPlayerConnectionDetails.html">GetPlayerConnectionDetails</a>
        /// to retrieve relay endpoints and player gateway tokens for your game clients. To learn
        /// more about this topic, see <a href="https://docs.aws.amazon.com/gameliftservers/latest/developerguide/ddos-protection-intro.html">DDoS
        /// protection with Amazon GameLift Servers player gateway</a>.
        /// </para>
        ///  
        /// <para>
        /// Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DISABLED</c> (default) -- Game clients connect to the game server endpoint. Use
        /// this when you do not intend to integrate your game with player gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED</c> -- Player gateway is available in fleet locations where it is supported.
        /// Your game backend can call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetPlayerConnectionDetails.html">GetPlayerConnectionDetails</a>
        /// to obtain a player gateway token and endpoints for game clients.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REQUIRED</c> -- Player gateway is available in fleet locations where it is supported,
        /// and the fleet can only use locations that support this feature. Attempting to add
        /// a remote location to your fleet which does not support player gateway will result
        /// in an <c>InvalidRequestException</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PlayerGatewayMode PlayerGatewayMode { get; set; }

        /// <summary>
        /// Checks to see if the PlayerGatewayMode property is set.
        /// </summary>
        internal bool IsSetPlayerGatewayMode() => this.PlayerGatewayMode != null;

        /// <summary>
        /// Gets and sets the property ResourceCreationLimitPolicy. 
        /// <para>
        /// A policy that limits the number of game sessions that an individual player can create
        /// on instances in this fleet within a specified span of time.
        /// </para>
        /// </summary>
        public ResourceCreationLimitPolicy ResourceCreationLimitPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCreationLimitPolicy property is set.
        /// </summary>
        internal bool IsSetResourceCreationLimitPolicy() => this.ResourceCreationLimitPolicy != null;

        /// <summary>
        /// Gets and sets the property RuntimeConfiguration. 
        /// <para>
        /// Instructions for how to launch and run server processes on the fleet. Set runtime
        /// configuration for managed EC2 fleets. For an Anywhere fleet, set this parameter only
        /// if the fleet is running the Amazon GameLift Servers Agent. The runtime configuration
        /// defines one or more server process configurations. Each server process identifies
        /// a game executable or Realtime script file and the number of processes to run concurrently.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter replaces the parameters <c>ServerLaunchPath</c> and <c>ServerLaunchParameters</c>,
        /// which are still supported for backward compatibility.
        /// </para>
        ///  </note>
        /// </summary>
        public RuntimeConfiguration RuntimeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeConfiguration property is set.
        /// </summary>
        internal bool IsSetRuntimeConfiguration() => this.RuntimeConfiguration != null;

        /// <summary>
        /// Gets and sets the property ScriptId. 
        /// <para>
        /// The unique identifier for a Realtime configuration script to be deployed to a fleet
        /// with compute type <c>EC2</c>. You can use either the script ID or ARN. Scripts must
        /// be uploaded to Amazon GameLift Servers prior to creating the fleet. This fleet property
        /// can't be changed after the fleet is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ScriptId { get; set; }

        /// <summary>
        /// Checks to see if the ScriptId property is set.
        /// </summary>
        internal bool IsSetScriptId() => this.ScriptId != null;

        /// <summary>
        /// Gets and sets the property ServerLaunchParameters. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> Specify server launch parameters using the
        /// <c>RuntimeConfiguration</c> parameter. Requests that use this parameter instead continue
        /// to be valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ServerLaunchParameters { get; set; }

        /// <summary>
        /// Checks to see if the ServerLaunchParameters property is set.
        /// </summary>
        internal bool IsSetServerLaunchParameters() => this.ServerLaunchParameters != null;

        /// <summary>
        /// Gets and sets the property ServerLaunchPath. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> Specify a server launch path using the <c>RuntimeConfiguration</c>
        /// parameter. Requests that use this parameter instead continue to be valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ServerLaunchPath { get; set; }

        /// <summary>
        /// Checks to see if the ServerLaunchPath property is set.
        /// </summary>
        internal bool IsSetServerLaunchPath() => this.ServerLaunchPath != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new fleet resource. Tags are developer-defined key-value
        /// pairs. Tagging Amazon Web Services resources is useful for resource management, access
        /// management and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
