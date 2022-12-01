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
    /// Describes a GameLift fleet of game hosting resources.
    /// 
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    /// </summary>
    public partial class FleetAttributes
    {
        private AnywhereConfiguration _anywhereConfiguration;
        private string _buildArn;
        private string _buildId;
        private CertificateConfiguration _certificateConfiguration;
        private ComputeType _computeType;
        private DateTime? _creationTime;
        private string _description;
        private string _fleetArn;
        private string _fleetId;
        private FleetType _fleetType;
        private string _instanceRoleArn;
        private EC2InstanceType _instanceType;
        private List<string> _logPaths = new List<string>();
        private List<string> _metricGroups = new List<string>();
        private string _name;
        private ProtectionPolicy _newGameSessionProtectionPolicy;
        private OperatingSystem _operatingSystem;
        private ResourceCreationLimitPolicy _resourceCreationLimitPolicy;
        private string _scriptArn;
        private string _scriptId;
        private string _serverLaunchParameters;
        private string _serverLaunchPath;
        private FleetStatus _status;
        private List<string> _stoppedActions = new List<string>();
        private DateTime? _terminationTime;

        /// <summary>
        /// Gets and sets the property AnywhereConfiguration.
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
        /// Gets and sets the property BuildArn. 
        /// <para>
        ///  The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// associated with the GameLift build resource that is deployed on instances in this
        /// fleet. In a GameLift build ARN, the resource ID matches the <code>BuildId</code> value.
        /// </para>
        /// </summary>
        public string BuildArn
        {
            get { return this._buildArn; }
            set { this._buildArn = value; }
        }

        // Check to see if BuildArn property is set
        internal bool IsSetBuildArn()
        {
            return this._buildArn != null;
        }

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// A unique identifier for the build resource that is deployed on instances in this fleet.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the fleet.
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
        /// that is assigned to a GameLift fleet resource and uniquely identifies it. ARNs are
        /// unique across all Regions. Format is <code>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</code>.
        /// In a GameLift fleet ARN, the resource ID matches the <code>FleetId</code> value.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the fleet.
        /// </para>
        /// </summary>
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
        /// Access external resources from a game server</a>.
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type that determines the computing resources of each instance
        /// in the fleet. Instance type defines the CPU, memory, storage, and networking capacity.
        /// See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon Elastic Compute Cloud
        /// Instance Types</a> for detailed descriptions.
        /// </para>
        /// </summary>
        public EC2InstanceType InstanceType
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
        /// Gets and sets the property LogPaths. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> Game session log paths are now defined using
        /// the GameLift server API <code>ProcessReady()</code> <code>logParameters</code>. See
        /// more information in the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api-ref.html#gamelift-sdk-server-api-ref-dataypes-process">Server
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
        /// Name of a metric group that metrics for this fleet are added to. In Amazon CloudWatch,
        /// you can view aggregated metrics for fleets that are in a metric group. A fleet can
        /// be included in only one metric group at a time.
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
        [AWSProperty(Min=1, Max=1024)]
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
        /// The type of game session protection to set on all new instances that are started in
        /// the fleet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NoProtection</b> -- The game session can be terminated during a scale-down event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FullProtection</b> -- If the game session is in an <code>ACTIVE</code> status,
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
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system of the fleet's computing resources. A fleet's operating system
        /// is determined by the OS of the build or script that is deployed on this fleet.
        /// </para>
        /// </summary>
        public OperatingSystem OperatingSystem
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
        /// Gets and sets the property ResourceCreationLimitPolicy.
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
        /// Gets and sets the property ScriptArn. 
        /// <para>
        ///  The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// associated with the GameLift script resource that is deployed on instances in this
        /// fleet. In a GameLift script ARN, the resource ID matches the <code>ScriptId</code>
        /// value.
        /// </para>
        /// </summary>
        public string ScriptArn
        {
            get { return this._scriptArn; }
            set { this._scriptArn = value; }
        }

        // Check to see if ScriptArn property is set
        internal bool IsSetScriptArn()
        {
            return this._scriptArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptId. 
        /// <para>
        /// A unique identifier for the Realtime script resource that is deployed on instances
        /// in this fleet.
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
        ///  <b>This parameter is no longer used.</b> Server launch parameters are now defined
        /// using the fleet's runtime configuration . Requests that use this parameter instead
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
        ///  <b>This parameter is no longer used.</b> Server launch paths are now defined using
        /// the fleet's <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/RuntimeConfiguration.html">RuntimeConfiguration</a>
        /// . Requests that use this parameter instead continue to be valid.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the fleet. Possible fleet statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NEW</b> -- A new fleet has been defined and desired instances is set to 1. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DOWNLOADING/VALIDATING/BUILDING/ACTIVATING</b> -- GameLift is setting up the new
        /// fleet, creating new instances with the game build or Realtime script and starting
        /// server processes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE</b> -- Hosts can now accept game sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ERROR</b> -- An error occurred when downloading, validating, building, or activating
        /// the fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETING</b> -- Hosts are responding to a delete fleet request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TERMINATED</b> -- The fleet no longer exists.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FleetStatus Status
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
        /// Gets and sets the property StoppedActions. 
        /// <para>
        /// A list of fleet activity that has been suspended using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StopFleetActions.html">StopFleetActions</a>
        /// . This includes fleet auto-scaling.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> StoppedActions
        {
            get { return this._stoppedActions; }
            set { this._stoppedActions = value; }
        }

        // Check to see if StoppedActions property is set
        internal bool IsSetStoppedActions()
        {
            return this._stoppedActions != null && this._stoppedActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TerminationTime. 
        /// <para>
        /// A time stamp indicating when this data object was terminated. Format is a number expressed
        /// in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// </para>
        /// </summary>
        public DateTime TerminationTime
        {
            get { return this._terminationTime.GetValueOrDefault(); }
            set { this._terminationTime = value; }
        }

        // Check to see if TerminationTime property is set
        internal bool IsSetTerminationTime()
        {
            return this._terminationTime.HasValue; 
        }

    }
}