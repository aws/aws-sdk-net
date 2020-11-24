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
    /// Creates a new fleet to run your game servers. whether they are custom game builds
    /// or Realtime Servers with game-specific script. A fleet is a set of Amazon Elastic
    /// Compute Cloud (Amazon EC2) instances, each of which can host multiple game sessions.
    /// When creating a fleet, you choose the hardware specifications, set some configuration
    /// options, and specify the game server to deploy on the new fleet. 
    /// 
    ///  
    /// <para>
    /// To create a new fleet, provide the following: (1) a fleet name, (2) an EC2 instance
    /// type and fleet type (spot or on-demand), (3) the build ID for your game build or script
    /// ID if using Realtime Servers, and (4) a runtime configuration, which determines how
    /// game servers will run on each instance in the fleet. 
    /// </para>
    ///  
    /// <para>
    /// If the <code>CreateFleet</code> call is successful, Amazon GameLift performs the following
    /// tasks. You can track the process of a fleet by checking the fleet status or by monitoring
    /// fleet creation events:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a fleet resource. Status: <code>NEW</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Begins writing events to the fleet event log, which can be accessed in the Amazon
    /// GameLift console.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Sets the fleet's target capacity to 1 (desired instances), which triggers Amazon GameLift
    /// to start one new EC2 instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Downloads the game build or Realtime script to the new instance and installs it. Statuses:
    /// <code>DOWNLOADING</code>, <code>VALIDATING</code>, <code>BUILDING</code>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Starts launching server processes on the instance. If the fleet is configured to run
    /// multiple server processes per instance, Amazon GameLift staggers each process launch
    /// by a few seconds. Status: <code>ACTIVATING</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Sets the fleet's status to <code>ACTIVE</code> as soon as one server process is ready
    /// to host a game session.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// Up Fleets</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html#fleets-creating-debug-creation">Debug
    /// Fleet Creation Issues</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListFleets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateFleetRequest : AmazonGameLiftRequest
    {
        private string _buildId;
        private CertificateConfiguration _certificateConfiguration;
        private string _description;
        private List<IpPermission> _ec2InboundPermissions = new List<IpPermission>();
        private EC2InstanceType _ec2InstanceType;
        private FleetType _fleetType;
        private string _instanceRoleArn;
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
        /// Gets and sets the property BuildId. 
        /// <para>
        /// A unique identifier for a build to be deployed on the new fleet. You can use either
        /// the build ID or ARN value. The custom game server build must have been successfully
        /// uploaded to Amazon GameLift and be in a <code>READY</code> status. This fleet setting
        /// cannot be changed once the fleet is created. 
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
        /// Indicates whether to generate a TLS/SSL certificate for the new fleet. TLS certificates
        /// are used for encrypting traffic between game clients and game servers running on GameLift.
        /// If this parameter is not specified, the default value, DISABLED, is used. This fleet
        /// setting cannot be changed once the fleet is created. Learn more at <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-howitworks.html#gamelift-howitworks-security">Securing
        /// Client/Server Communication</a>. 
        /// </para>
        ///  
        /// <para>
        /// Note: This feature requires the AWS Certificate Manager (ACM) service, which is available
        /// in the AWS global partition but not in all other partitions. When working in a partition
        /// that does not support this feature, a request for a new fleet with certificate generation
        /// results fails with a 4xx unsupported Region error.
        /// </para>
        ///  
        /// <para>
        /// Valid values include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>GENERATED</b> - Generate a TLS/SSL certificate for this fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DISABLED</b> - (default) Do not generate a TLS/SSL certificate for this fleet.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of a fleet.
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
        /// Range of IP addresses and port settings that permit inbound traffic to access game
        /// sessions that are running on the fleet. For fleets using a custom game build, this
        /// parameter is required before game sessions running on the fleet can accept connections.
        /// For Realtime Servers fleets, Amazon GameLift automatically sets TCP and UDP ranges
        /// for use by the Realtime servers. You can specify multiple permission settings or add
        /// more by updating the fleet.
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
        /// The name of an EC2 instance type that is supported in Amazon GameLift. A fleet instance
        /// type determines the computing resources of each instance in the fleet, including CPU,
        /// memory, storage, and networking capacity. Amazon GameLift supports the following EC2
        /// instance types. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon EC2
        /// Instance Types</a> for detailed descriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Indicates whether to use On-Demand instances or Spot instances for this fleet. If
        /// empty, the default is <code>ON_DEMAND</code>. Both categories of instances use identical
        /// hardware and configurations based on the instance type selected for this fleet. Learn
        /// more about <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-ec2-instances.html#gamelift-ec2-instances-spot">
        /// On-Demand versus Spot Instances</a>. 
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
        /// A unique identifier for an AWS IAM role that manages access to your AWS services.
        /// Fleets with an instance role ARN allow applications that are running on the fleet's
        /// instances to assume the role. Learn more about using on-box credentials for your game
        /// servers at <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-resources.html">
        /// Access external resources from a game server</a>. To call this operation with instance
        /// role ARN, you must have IAM PassRole permissions. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-iam-policy-examples.html">IAM
        /// policy examples for GameLift</a>. 
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
        /// Gets and sets the property LogPaths. 
        /// <para>
        /// This parameter is no longer used. Instead, to specify where Amazon GameLift should
        /// store log files once a server process shuts down, use the Amazon GameLift server API
        /// <code>ProcessReady()</code> and specify one or more directory paths in <code>logParameters</code>.
        /// See more information in the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api-ref.html#gamelift-sdk-server-api-ref-dataypes-process">Server
        /// API Reference</a>. 
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
        /// The name of an Amazon CloudWatch metric group to add this fleet to. A metric group
        /// aggregates the metrics for all fleets in the group. Specify an existing metric group
        /// name, or provide a new name to create a new metric group. A fleet can only be included
        /// in one metric group at a time. 
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
        /// A game session protection policy to apply to all instances in this fleet. If this
        /// parameter is not set, instances in this fleet default to no protection. You can change
        /// a fleet's protection policy using <a>UpdateFleetAttributes</a>, but this change will
        /// only affect sessions created after the policy change. You can also set protection
        /// for individual instances using <a>UpdateGameSession</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NoProtection</b> - The game session can be terminated during a scale-down event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FullProtection</b> - If the game session is in an <code>ACTIVE</code> status,
        /// it cannot be terminated during a scale-down event.
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
        /// A unique identifier for the AWS account with the VPC that you want to peer your Amazon
        /// GameLift fleet with. You can find your account ID in the AWS Management Console under
        /// account settings. 
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
        /// fleet. The VPC must be in the same Region as your fleet. To look up a VPC ID, use
        /// the <a href="https://console.aws.amazon.com/vpc/">VPC Dashboard</a> in the AWS Management
        /// Console. Learn more about VPC peering in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Fleets</a>. 
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
        /// A policy that limits the number of game sessions an individual player can create over
        /// a span of time for this fleet.
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
        /// Instructions for launching server processes on each instance in the fleet. Server
        /// processes run either a custom game build executable or a Realtime script. The runtime
        /// configuration defines the server executables or launch script file, launch parameters,
        /// and the number of processes to run concurrently on each instance. When creating a
        /// fleet, the runtime configuration must have at least one server process configuration;
        /// otherwise the request fails with an invalid request exception. (This parameter replaces
        /// the parameters <code>ServerLaunchPath</code> and <code>ServerLaunchParameters</code>,
        /// although requests that contain values for these parameters instead of a runtime configuration
        /// will continue to work.) This parameter is required unless the parameters <code>ServerLaunchPath</code>
        /// and <code>ServerLaunchParameters</code> are defined. Runtime configuration replaced
        /// these parameters, but fleets that use them will continue to work. 
        /// </para>
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
        /// A unique identifier for a Realtime script to be deployed on the new fleet. You can
        /// use either the script ID or ARN value. The Realtime script must have been successfully
        /// uploaded to Amazon GameLift. This fleet setting cannot be changed once the fleet is
        /// created.
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
        /// This parameter is no longer used. Instead, specify server launch parameters in the
        /// <code>RuntimeConfiguration</code> parameter. (Requests that specify a server launch
        /// path and launch parameters instead of a runtime configuration will continue to work.)
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
        /// This parameter is no longer used. Instead, specify a server launch path using the
        /// <code>RuntimeConfiguration</code> parameter. Requests that specify a server launch
        /// path and launch parameters instead of a runtime configuration will continue to work.
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
        /// pairs. Tagging AWS resources are useful for resource management, access management
        /// and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging AWS Resources</a> in the <i>AWS General Reference</i>. Once the resource is
        /// created, you can use <a>TagResource</a>, <a>UntagResource</a>, and <a>ListTagsForResource</a>
        /// to add, remove, and view tags. The maximum tag limit may be lower than stated. See
        /// the AWS General Reference for actual tagging limits.
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