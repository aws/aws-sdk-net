/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFleet operation.
    /// Creates a new fleet to run your game servers. A fleet is a set of Amazon Elastic Compute
    /// Cloud (Amazon EC2) instances, each of which can run multiple server processes to host
    /// game sessions. You set up a fleet to use instances with certain hardware specifications
    /// (see <a href="http://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance Types</a>
    /// for more information), and deploy your game build to run on each instance. 
    /// 
    ///  
    /// <para>
    /// To create a new fleet, you must specify the following: (1) a fleet name, (2) the build
    /// ID of a successfully uploaded game build, (3) an EC2 instance type, and (4) a run-time
    /// configuration, which describes the server processes to run on each instance in the
    /// fleet. If you don't specify a fleet type (on-demand or spot), the new fleet uses on-demand
    /// instances by default.
    /// </para>
    ///  
    /// <para>
    /// You can also configure the new fleet with the following settings:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Fleet description
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Access permissions for inbound traffic
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Fleet-wide game session protection
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Resource usage limits
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// VPC peering connection (see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
    /// Peering with Amazon GameLift Fleets</a>)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you use Amazon CloudWatch for metrics, you can add the new fleet to a metric group.
    /// By adding multiple fleets to a metric group, you can view aggregated metrics for all
    /// the fleets in the group. 
    /// </para>
    ///  
    /// <para>
    /// If the <code>CreateFleet</code> call is successful, Amazon GameLift performs the following
    /// tasks. You can track the process of a fleet by checking the fleet status or by monitoring
    /// fleet creation events:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a fleet record. Status: <code>NEW</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Begins writing events to the fleet event log, which can be accessed in the Amazon
    /// GameLift console.
    /// </para>
    ///  
    /// <para>
    /// Sets the fleet's target capacity to 1 (desired instances), which triggers Amazon GameLift
    /// to start one new EC2 instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Downloads the game build to the new instance and installs it. Statuses: <code>DOWNLOADING</code>,
    /// <code>VALIDATING</code>, <code>BUILDING</code>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Starts launching server processes on the instance. If the fleet is configured to run
    /// multiple server processes per instance, Amazon GameLift staggers each launch by a
    /// few seconds. Status: <code>ACTIVATING</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Sets the fleet's status to <code>ACTIVE</code> as soon as one server process is ready
    /// to host a game session.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Fleet-related operations include:
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
    /// Describe fleets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetPortSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetUtilization</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeRuntimeConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEC2InstanceLimits</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetEvents</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Update fleets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>UpdateFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetPortSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRuntimeConfiguration</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Manage fleet actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>StartFleetActions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopFleetActions</a> 
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class CreateFleetRequest : AmazonGameLiftRequest
    {
        private string _buildId;
        private string _description;
        private List<IpPermission> _ec2InboundPermissions = new List<IpPermission>();
        private EC2InstanceType _ec2InstanceType;
        private FleetType _fleetType;
        private List<string> _logPaths = new List<string>();
        private List<string> _metricGroups = new List<string>();
        private string _name;
        private ProtectionPolicy _newGameSessionProtectionPolicy;
        private string _peerVpcAwsAccountId;
        private string _peerVpcId;
        private ResourceCreationLimitPolicy _resourceCreationLimitPolicy;
        private RuntimeConfiguration _runtimeConfiguration;
        private string _serverLaunchParameters;
        private string _serverLaunchPath;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// Unique identifier for a build to be deployed on the new fleet. The build must have
        /// been successfully uploaded to Amazon GameLift and be in a <code>READY</code> status.
        /// This fleet setting cannot be changed once the fleet is created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Human-readable description of a fleet.
        /// </para>
        /// </summary>
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
        /// Range of IP addresses and port settings that permit inbound traffic to access server
        /// processes running on the fleet. If no inbound permissions are set, including both
        /// IP address range and port range, the server processes in the fleet cannot accept connections.
        /// You can specify one or more sets of permissions for a fleet.
        /// </para>
        /// </summary>
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
        /// Name of an EC2 instance type that is supported in Amazon GameLift. A fleet instance
        /// type determines the computing resources of each instance in the fleet, including CPU,
        /// memory, storage, and networking capacity. Amazon GameLift supports the following EC2
        /// instance types. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon EC2
        /// Instance Types</a> for detailed descriptions.
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
        /// Indicates whether to use on-demand instances or spot instances for this fleet. If
        /// empty, the default is ON_DEMAND. Both categories of instances use identical hardware
        /// and configurations, based on the instance type selected for this fleet. You can acquire
        /// on-demand instances at any time for a fixed price and keep them as long as you need
        /// them. Spot instances have lower prices, but spot pricing is variable, and while in
        /// use they can be interrupted (with a two-minute notification). Learn more about Amazon
        /// GameLift spot instances with at <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-ec2-instances.html">
        /// Choose Computing Resources</a>. 
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
        /// Gets and sets the property LogPaths. 
        /// <para>
        /// This parameter is no longer used. Instead, to specify where Amazon GameLift should
        /// store log files once a server process shuts down, use the Amazon GameLift server API
        /// <code>ProcessReady()</code> and specify one or more directory paths in <code>logParameters</code>.
        /// See more information in the <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api-ref.html#gamelift-sdk-server-api-ref-dataypes-process">Server
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
        /// Name of a metric group to add this fleet to. A metric group tracks metrics across
        /// all fleets in the group. Use an existing metric group name to add this fleet to the
        /// group, or use a new name to create a new metric group. A fleet can only be included
        /// in one metric group at a time.
        /// </para>
        /// </summary>
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
        /// Descriptive label that is associated with a fleet. Fleet names do not need to be unique.
        /// </para>
        /// </summary>
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
        /// Game session protection policy to apply to all instances in this fleet. If this parameter
        /// is not set, instances in this fleet default to no protection. You can change a fleet's
        /// protection policy using <a>UpdateFleetAttributes</a>, but this change will only affect
        /// sessions created after the policy change. You can also set protection for individual
        /// instances using <a>UpdateGameSession</a>.
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
        /// Gets and sets the property PeerVpcAwsAccountId. 
        /// <para>
        /// Unique identifier for the AWS account with the VPC that you want to peer your Amazon
        /// GameLift fleet with. You can find your Account ID in the AWS Management Console under
        /// account settings.
        /// </para>
        /// </summary>
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
        /// Unique identifier for a VPC with resources to be accessed by your Amazon GameLift
        /// fleet. The VPC must be in the same region where your fleet is deployed. To get VPC
        /// information, including IDs, use the Virtual Private Cloud service tools, including
        /// the VPC Dashboard in the AWS Management Console.
        /// </para>
        /// </summary>
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
        /// Policy that limits the number of game sessions an individual player can create over
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
        /// Instructions for launching server processes on each instance in the fleet. The run-time
        /// configuration for a fleet has a collection of server process configurations, one for
        /// each type of server process to run on an instance. A server process configuration
        /// specifies the location of the server executable, launch parameters, and the number
        /// of concurrent processes with that configuration to maintain on each instance. A CreateFleet
        /// request must include a run-time configuration with at least one server process configuration;
        /// otherwise the request fails with an invalid request exception. (This parameter replaces
        /// the parameters <code>ServerLaunchPath</code> and <code>ServerLaunchParameters</code>;
        /// requests that contain values for these parameters instead of a run-time configuration
        /// will continue to work.) 
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
        /// Gets and sets the property ServerLaunchParameters. 
        /// <para>
        /// This parameter is no longer used. Instead, specify server launch parameters in the
        /// <code>RuntimeConfiguration</code> parameter. (Requests that specify a server launch
        /// path and launch parameters instead of a run-time configuration will continue to work.)
        /// </para>
        /// </summary>
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
        /// <code>RuntimeConfiguration</code> parameter. (Requests that specify a server launch
        /// path and launch parameters instead of a run-time configuration will continue to work.)
        /// </para>
        /// </summary>
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

    }
}