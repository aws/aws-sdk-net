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
    /// Container for the parameters to the CreateFleet operation.
    /// Creates a fleet of compute resources to host your game servers. Use this operation
    /// to set up the following types of fleets based on compute type: 
    /// 
    ///  
    /// <para>
    ///  <b>Managed EC2 fleet</b> 
    /// </para>
    ///  
    /// <para>
    /// An EC2 fleet is a set of Amazon Elastic Compute Cloud (Amazon EC2) instances. Your
    /// game server build is deployed to each fleet instance. Amazon GameLift Servers manages
    /// the fleet's instances and controls the lifecycle of game server processes, which host
    /// game sessions for players. EC2 fleets can have instances in multiple locations. Each
    /// instance in the fleet is designated a <c>Compute</c>.
    /// </para>
    ///  
    /// <para>
    /// To create an EC2 fleet, provide these required parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Either <c>BuildId</c> or <c>ScriptId</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ComputeType</c> set to <c>EC2</c> (the default value)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>EC2InboundPermissions</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>EC2InstanceType</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>FleetType</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Name</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RuntimeConfiguration</c> with at least one <c>ServerProcesses</c> configuration
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, this operation creates a new fleet resource and places it in <c>NEW</c>
    /// status while Amazon GameLift Servers initiates the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-all.html#fleets-creation-workflow">fleet
    /// creation workflow</a>. To debug your fleet, fetch logs, view performance metrics or
    /// other actions on the fleet, create a development fleet with port 22/3389 open. As
    /// a best practice, we recommend opening ports for remote access only when you need them
    /// and closing them when you're finished. 
    /// </para>
    ///  
    /// <para>
    /// When the fleet status is ACTIVE, you can adjust capacity settings and turn autoscaling
    /// on/off for each location.
    /// </para>
    ///  
    /// <para>
    ///  <b>Anywhere fleet</b> 
    /// </para>
    ///  
    /// <para>
    /// An Anywhere fleet represents compute resources that are not owned or managed by Amazon
    /// GameLift Servers. You might create an Anywhere fleet with your local machine for testing,
    /// or use one to host game servers with on-premises hardware or other game hosting solutions.
    /// 
    /// </para>
    ///  
    /// <para>
    /// To create an Anywhere fleet, provide these required parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ComputeType</c> set to <c>ANYWHERE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Locations</c> specifying a custom location
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Name</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, this operation creates a new fleet resource and places it in <c>ACTIVE</c>
    /// status. You can register computes with a fleet in <c>ACTIVE</c> status. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up fleets</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html#fleets-creating-debug-creation">Debug
    /// fleet creation issues</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Multi-location
    /// fleets</a> 
    /// </para>
    /// </summary>
    public partial class CreateFleetRequest : AmazonGameLiftRequest
    {
        private AnywhereConfiguration _anywhereConfiguration;
        private string _buildId;
        private CertificateConfiguration _certificateConfiguration;
        private ComputeType _computeType;
        private string _description;
        private List<IpPermission> _ec2InboundPermissions = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;
        private EC2InstanceType _ec2InstanceType;
        private FleetType _fleetType;
        private string _instanceRoleArn;
        private InstanceRoleCredentialsProvider _instanceRoleCredentialsProvider;
        private List<LocationConfiguration> _locations = AWSConfigs.InitializeCollections ? new List<LocationConfiguration>() : null;
        private List<string> _logPaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _metricGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private ProtectionPolicy _newGameSessionProtectionPolicy;
        private string _peerVpcAwsAccountId;
        private string _peerVpcId;
        private ResourceCreationLimitPolicy _resourceCreationLimitPolicy;
        private RuntimeConfiguration _runtimeConfiguration;
        private string _scriptId;
        private string _serverLaunchParameters;
        private string _serverLaunchPath;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AnywhereConfiguration. 
        /// <para>
        /// Amazon GameLift Servers Anywhere configuration options.
        /// </para>
        /// </summary>
        public AnywhereConfiguration AnywhereConfiguration
        {
            get { return this._anywhereConfiguration; }
            set { this._anywhereConfiguration = value; }
        }

        // Check to see if AnywhereConfiguration property is set
        internal bool IsSetAnywhereConfiguration()
        {
            return this._anywhereConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// The unique identifier for a custom game server build to be deployed to a fleet with
        /// compute type <c>EC2</c>. You can use either the build ID or ARN. The build must be
        /// uploaded to Amazon GameLift Servers and in <c>READY</c> status. This fleet property
        /// can't be changed after the fleet is created.
        /// </para>
        /// </summary>
        public string BuildId
        {
            get { return this._buildId; }
            set { this._buildId = value; }
        }

        // Check to see if BuildId property is set
        internal bool IsSetBuildId()
        {
            return this._buildId != null;
        }

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
        public CertificateConfiguration CertificateConfiguration
        {
            get { return this._certificateConfiguration; }
            set { this._certificateConfiguration = value; }
        }

        // Check to see if CertificateConfiguration property is set
        internal bool IsSetCertificateConfiguration()
        {
            return this._certificateConfiguration != null;
        }

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
        public ComputeType ComputeType
        {
            get { return this._computeType; }
            set { this._computeType = value; }
        }

        // Check to see if ComputeType property is set
        internal bool IsSetComputeType()
        {
            return this._computeType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the fleet.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<IpPermission> EC2InboundPermissions
        {
            get { return this._ec2InboundPermissions; }
            set { this._ec2InboundPermissions = value; }
        }

        // Check to see if EC2InboundPermissions property is set
        internal bool IsSetEC2InboundPermissions()
        {
            return this._ec2InboundPermissions != null && (this._ec2InboundPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public EC2InstanceType EC2InstanceType
        {
            get { return this._ec2InstanceType; }
            set { this._ec2InstanceType = value; }
        }

        // Check to see if EC2InstanceType property is set
        internal bool IsSetEC2InstanceType()
        {
            return this._ec2InstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property FleetType. 
        /// <para>
        /// Indicates whether to use On-Demand or Spot instances for this fleet. By default, this
        /// property is set to <c>ON_DEMAND</c>. Learn more about when to use <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-ec2-instances.html#gamelift-ec2-instances-spot">
        /// On-Demand versus Spot Instances</a>. This fleet property can't be changed after the
        /// fleet is created.
        /// </para>
        /// </summary>
        public FleetType FleetType
        {
            get { return this._fleetType; }
            set { this._fleetType = value; }
        }

        // Check to see if FleetType property is set
        internal bool IsSetFleetType()
        {
            return this._fleetType != null;
        }

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
        [AWSProperty(Min=1)]
        public string InstanceRoleArn
        {
            get { return this._instanceRoleArn; }
            set { this._instanceRoleArn = value; }
        }

        // Check to see if InstanceRoleArn property is set
        internal bool IsSetInstanceRoleArn()
        {
            return this._instanceRoleArn != null;
        }

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
        public InstanceRoleCredentialsProvider InstanceRoleCredentialsProvider
        {
            get { return this._instanceRoleCredentialsProvider; }
            set { this._instanceRoleCredentialsProvider = value; }
        }

        // Check to see if InstanceRoleCredentialsProvider property is set
        internal bool IsSetInstanceRoleCredentialsProvider()
        {
            return this._instanceRoleCredentialsProvider != null;
        }

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
        /// Gets and sets the property LogPaths. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> To specify where Amazon GameLift Servers
        /// should store log files once a server process shuts down, use the Amazon GameLift Servers
        /// server API <c>ProcessReady()</c> and specify one or more directory paths in <c>logParameters</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-initialize">Initialize
        /// the server process</a> in the <i>Amazon GameLift Servers Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogPaths
        {
            get { return this._logPaths; }
            set { this._logPaths = value; }
        }

        // Check to see if LogPaths property is set
        internal bool IsSetLogPaths()
        {
            return this._logPaths != null && (this._logPaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricGroups. 
        /// <para>
        /// The name of an Amazon Web Services CloudWatch metric group to add this fleet to. A
        /// metric group is used to aggregate the metrics for multiple fleets. You can specify
        /// an existing metric group name or set a new name to create a new metric group. A fleet
        /// can be included in only one metric group at a time. 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a fleet. Fleet names do not need to be
        /// unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property PeerVpcAwsAccountId. 
        /// <para>
        /// Used when peering your Amazon GameLift Servers fleet with a VPC, the unique identifier
        /// for the Amazon Web Services account that owns the VPC. You can find your account ID
        /// in the Amazon Web Services Management Console under account settings. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PeerVpcAwsAccountId
        {
            get { return this._peerVpcAwsAccountId; }
            set { this._peerVpcAwsAccountId = value; }
        }

        // Check to see if PeerVpcAwsAccountId property is set
        internal bool IsSetPeerVpcAwsAccountId()
        {
            return this._peerVpcAwsAccountId != null;
        }

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
        [AWSProperty(Min=1, Max=1024)]
        public string PeerVpcId
        {
            get { return this._peerVpcId; }
            set { this._peerVpcId = value; }
        }

        // Check to see if PeerVpcId property is set
        internal bool IsSetPeerVpcId()
        {
            return this._peerVpcId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCreationLimitPolicy. 
        /// <para>
        /// A policy that limits the number of game sessions that an individual player can create
        /// on instances in this fleet within a specified span of time.
        /// </para>
        /// </summary>
        public ResourceCreationLimitPolicy ResourceCreationLimitPolicy
        {
            get { return this._resourceCreationLimitPolicy; }
            set { this._resourceCreationLimitPolicy = value; }
        }

        // Check to see if ResourceCreationLimitPolicy property is set
        internal bool IsSetResourceCreationLimitPolicy()
        {
            return this._resourceCreationLimitPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeConfiguration. 
        /// <para>
        /// Instructions for how to launch and run server processes on the fleet. Set runtime
        /// configuration for managed EC2 fleets. For an Anywhere fleets, set this parameter only
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
        public RuntimeConfiguration RuntimeConfiguration
        {
            get { return this._runtimeConfiguration; }
            set { this._runtimeConfiguration = value; }
        }

        // Check to see if RuntimeConfiguration property is set
        internal bool IsSetRuntimeConfiguration()
        {
            return this._runtimeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptId. 
        /// <para>
        /// The unique identifier for a Realtime configuration script to be deployed to a fleet
        /// with compute type <c>EC2</c>. You can use either the script ID or ARN. Scripts must
        /// be uploaded to Amazon GameLift Servers prior to creating the fleet. This fleet property
        /// can't be changed after the fleet is created.
        /// </para>
        /// </summary>
        public string ScriptId
        {
            get { return this._scriptId; }
            set { this._scriptId = value; }
        }

        // Check to see if ScriptId property is set
        internal bool IsSetScriptId()
        {
            return this._scriptId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerLaunchParameters. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> Specify server launch parameters using the
        /// <c>RuntimeConfiguration</c> parameter. Requests that use this parameter instead continue
        /// to be valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ServerLaunchParameters
        {
            get { return this._serverLaunchParameters; }
            set { this._serverLaunchParameters = value; }
        }

        // Check to see if ServerLaunchParameters property is set
        internal bool IsSetServerLaunchParameters()
        {
            return this._serverLaunchParameters != null;
        }

        /// <summary>
        /// Gets and sets the property ServerLaunchPath. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> Specify a server launch path using the <c>RuntimeConfiguration</c>
        /// parameter. Requests that use this parameter instead continue to be valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ServerLaunchPath
        {
            get { return this._serverLaunchPath; }
            set { this._serverLaunchPath = value; }
        }

        // Check to see if ServerLaunchPath property is set
        internal bool IsSetServerLaunchPath()
        {
            return this._serverLaunchPath != null;
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