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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFleet operation.
    /// Creates a fleet of Amazon Elastic Compute Cloud (Amazon Elastic Compute Cloud) instances
    /// to host your custom game server or Realtime Servers. Use this operation to configure
    /// the computing resources for your fleet and provide instructions for running game servers
    /// on each instance.
    /// 
    ///  
    /// <para>
    /// Most GameLift fleets can deploy instances to multiple locations, including the home
    /// Region (where the fleet is created) and an optional set of remote locations. Fleets
    /// that are created in the following Amazon Web Services Regions support multiple locations:
    /// us-east-1 (N. Virginia), us-west-2 (Oregon), eu-central-1 (Frankfurt), eu-west-1 (Ireland),
    /// ap-southeast-2 (Sydney), ap-northeast-1 (Tokyo), and ap-northeast-2 (Seoul). Fleets
    /// that are created in other GameLift Regions can deploy instances in the fleet's home
    /// Region only. All fleet instances use the same configuration regardless of location;
    /// however, you can adjust capacity settings and turn auto-scaling on/off for each location.
    /// </para>
    ///  
    /// <para>
    /// To create a fleet, choose the hardware for your instances, specify a game server build
    /// or Realtime script to deploy, and provide a runtime configuration to direct GameLift
    /// how to start and run game servers on each instance in the fleet. Set permissions for
    /// inbound traffic to your game servers, and enable optional features as needed. When
    /// creating a multi-location fleet, provide a list of additional remote locations.
    /// </para>
    ///  
    /// <para>
    /// If you need to debug your fleet, fetch logs, view performance metrics or other actions
    /// on the fleet, create the development fleet with port 22/3389 open. As a best practice,
    /// we recommend opening ports for remote access only when you need them and closing them
    /// when you're finished. 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation creates a new Fleet resource and places it in <code>NEW</code>
    /// status, which prompts GameLift to initiate the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creation-workflow.html">fleet
    /// creation workflow</a>.
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
        private List<IpPermission> _ec2InboundPermissions = new List<IpPermission>();
        private EC2InstanceType _ec2InstanceType;
        private FleetType _fleetType;
        private string _instanceRoleArn;
        private List<LocationConfiguration> _locations = new List<LocationConfiguration>();
        private List<string> _logPaths = new List<string>();
        private List<string> _metricGroups = new List<string>();
        private string _name;
        private ProtectionPolicy _newGameSessionProtectionPolicy;
        private string _peerVpcAwsAccountId;
        private string _peerVpcId;
        private ResourceCreationLimitPolicy _resourceCreationLimitPolicy;
        private RuntimeConfiguration _runtimeConfiguration;
        private string _scriptId;
        private string _serverLaunchParameters;
        private string _serverLaunchPath;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AnywhereConfiguration. 
        /// <para>
        /// GameLift Anywhere configuration options.
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
        /// The unique identifier for a custom game server build to be deployed on fleet instances.
        /// You can use either the build ID or ARN. The build must be uploaded to GameLift and
        /// in <code>READY</code> status. This fleet property cannot be changed later.
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
        /// Prompts GameLift to generate a TLS/SSL certificate for the fleet. GameLift uses the
        /// certificates to encrypt traffic between game clients and the game servers running
        /// on GameLift. By default, the <code>CertificateConfiguration</code> is <code>DISABLED</code>.
        /// You can't change this property after you create the fleet. 
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
        /// The type of compute resource used to host your game servers. You can use your own
        /// compute resources with GameLift Anywhere or use Amazon EC2 instances with managed
        /// GameLift.
        /// </para>
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
        /// The allowed IP address ranges and port settings that allow inbound traffic to access
        /// game sessions on this fleet. If the fleet is hosting a custom game build, this property
        /// must be set before players can connect to game sessions. For Realtime Servers fleets,
        /// GameLift automatically sets TCP and UDP ranges. 
        /// </para>
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
            return this._ec2InboundPermissions != null && this._ec2InboundPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EC2InstanceType. 
        /// <para>
        /// The GameLift-supported Amazon EC2 instance type to use for all fleet instances. Instance
        /// type determines the computing resources that will be used to host your game servers,
        /// including CPU, memory, storage, and networking capacity. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// Elastic Compute Cloud Instance Types</a> for detailed descriptions of Amazon EC2 instance
        /// types.
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
        /// property is set to <code>ON_DEMAND</code>. Learn more about when to use <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-ec2-instances.html#gamelift-ec2-instances-spot">
        /// On-Demand versus Spot Instances</a>. This property cannot be changed after the fleet
        /// is created.
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
        /// Access external resources from a game server</a>. This property cannot be changed
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
        /// Gets and sets the property Locations. 
        /// <para>
        /// A set of remote locations to deploy additional instances to and manage as part of
        /// the fleet. This parameter can only be used when creating fleets in Amazon Web Services
        /// Regions that support multiple locations. You can add any GameLift-supported Amazon
        /// Web Services Region as a remote location, in the form of an Amazon Web Services Region
        /// code such as <code>us-west-2</code>. To create a fleet with instances in the home
        /// Region only, omit this parameter. 
        /// </para>
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
            return this._locations != null && this._locations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LogPaths. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> To specify where GameLift should store log
        /// files once a server process shuts down, use the GameLift server API <code>ProcessReady()</code>
        /// and specify one or more directory paths in <code>logParameters</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-initialize">Initialize
        /// the server process</a> in the <i>GameLift Developer Guide</i>. 
        /// </para>
        /// </summary>
        public List<string> LogPaths
        {
            get { return this._logPaths; }
            set { this._logPaths = value; }
        }

        // Check to see if LogPaths property is set
        internal bool IsSetLogPaths()
        {
            return this._logPaths != null && this._logPaths.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricGroups. 
        /// <para>
        /// The name of an Amazon Web Services CloudWatch metric group to add this fleet to. A
        /// metric group is used to aggregate the metrics for multiple fleets. You can specify
        /// an existing metric group name or set a new name to create a new metric group. A fleet
        /// can be included in only one metric group at a time. 
        /// </para>
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
            return this._metricGroups != null && this._metricGroups.Count > 0; 
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
        /// this property is set to <code>NoProtection</code>. You can also set game session protection
        /// for an individual game session by calling <a href="gamelift/latest/apireference/API_UpdateGameSession.html">UpdateGameSession</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NoProtection</b> - Game sessions can be terminated during active gameplay as a
        /// result of a scale-down event. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FullProtection</b> - Game sessions in <code>ACTIVE</code> status cannot be terminated
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
        /// Used when peering your GameLift fleet with a VPC, the unique identifier for the Amazon
        /// Web Services account that owns the VPC. You can find your account ID in the Amazon
        /// Web Services Management Console under account settings. 
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
        /// A unique identifier for a VPC with resources to be accessed by your GameLift fleet.
        /// The VPC must be in the same Region as your fleet. To look up a VPC ID, use the <a
        /// href="https://console.aws.amazon.com/vpc/">VPC Dashboard</a> in the Amazon Web Services
        /// Management Console. Learn more about VPC peering in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with GameLift Fleets</a>.
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
        /// Instructions for how to launch and maintain server processes on instances in the fleet.
        /// The runtime configuration defines one or more server process configurations, each
        /// identifying a build executable or Realtime script file and the number of processes
        /// of that type to run concurrently. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>RuntimeConfiguration</code> parameter is required unless the fleet is being
        /// configured using the older parameters <code>ServerLaunchPath</code> and <code>ServerLaunchParameters</code>,
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
        /// The unique identifier for a Realtime configuration script to be deployed on fleet
        /// instances. You can use either the script ID or ARN. Scripts must be uploaded to GameLift
        /// prior to creating the fleet. This fleet property cannot be changed later.
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
        /// <code>RuntimeConfiguration</code> parameter. Requests that use this parameter instead
        /// continue to be valid.
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
        ///  <b>This parameter is no longer used.</b> Specify a server launch path using the <code>RuntimeConfiguration</code>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}