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
    /// game sessions. You configure a fleet to create instances with certain hardware specifications
    /// (see <a href="https://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance Types</a>
    /// for more information), and deploy a specified game build to each instance. A newly
    /// created fleet passes through several states; once it reaches the <code>ACTIVE</code>
    /// state, it can begin hosting game sessions.
    /// 
    ///  
    /// <para>
    /// To create a new fleet, provide a fleet name, an EC2 instance type, and a build ID
    /// of the game build to deploy. You can also configure the new fleet with the following
    /// settings: (1) a runtime configuration describing what server processes to run on each
    /// instance in the fleet (required to create fleet), (2) access permissions for inbound
    /// traffic, (3) fleet-wide game session protection, and (4) the location of default log
    /// files for GameLift to upload and store. 
    /// </para>
    ///  
    /// <para>
    /// If the <code>CreateFleet</code> call is successful, Amazon GameLift performs the following
    /// tasks:
    /// </para>
    ///  <ul> <li>Creates a fleet record and sets the state to <code>NEW</code> (followed
    /// by other states as the fleet is activated).</li> <li>Sets the fleet's capacity to
    /// 1 "desired", which causes GameLift to start one new EC2 instance.</li> <li>Starts
    /// launching server processes on the instance. If the fleet is configured to run multiple
    /// server processes per instance, GameLift staggers each launch by a few seconds.</li>
    /// <li>Begins writing events to the fleet event log, which can be accessed in the GameLift
    /// console.</li> <li>Sets the fleet's status to <code>ACTIVE</code> once one server process
    /// in the fleet is ready to host a game session.</li> </ul> 
    /// <para>
    /// After a fleet is created, use the following actions to change fleet properties and
    /// configuration:
    /// </para>
    ///  <ul> <li> <a>UpdateFleetAttributes</a> -- Update fleet metadata, including name and
    /// description.</li> <li> <a>UpdateFleetCapacity</a> -- Increase or decrease the number
    /// of instances you want the fleet to maintain.</li> <li> <a>UpdateFleetPortSettings</a>
    /// -- Change the IP address and port ranges that allow access to incoming traffic.</li>
    /// <li> <a>UpdateRuntimeConfiguration</a> -- Change how server processes are launched
    /// in the fleet, including launch path, launch parameters, and the number of concurrent
    /// processes.</li> </ul>
    /// </summary>
    public partial class CreateFleetRequest : AmazonGameLiftRequest
    {
        private string _buildId;
        private string _description;
        private List<IpPermission> _ec2InboundPermissions = new List<IpPermission>();
        private EC2InstanceType _ec2InstanceType;
        private List<string> _logPaths = new List<string>();
        private string _name;
        private ProtectionPolicy _newGameSessionProtectionPolicy;
        private RuntimeConfiguration _runtimeConfiguration;
        private string _serverLaunchParameters;
        private string _serverLaunchPath;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// Unique identifier of the build to be deployed on the new fleet. The build must have
        /// been successfully uploaded to GameLift and be in a <code>READY</code> state. This
        /// fleet setting cannot be changed once the fleet is created.
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
        /// memory, storage, and networking capacity. GameLift supports the following EC2 instance
        /// types. See <a href="https://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance
        /// Types</a> for detailed descriptions.
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
        /// Gets and sets the property LogPaths. 
        /// <para>
        /// Location of default log files. When a server process is shut down, Amazon GameLift
        /// captures and stores any log files in this location. These logs are in addition to
        /// game session logs; see more on game session logs in the <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-api-server-code">Amazon
        /// GameLift Developer Guide</a>. If no default log path for a fleet is specified, GameLift
        /// will automatically upload logs stored on each instance at <code>C:\game\logs</code>.
        /// Use the GameLift console to access stored logs. 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Descriptive label associated with a fleet. Fleet names do not need to be unique.
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
        /// protection policy using UpdateFleetAttributes, but this change will only affect sessions
        /// created after the policy change. You can also set protection for individual instances
        /// using <a>UpdateGameSession</a>. <ul><li><b>NoProtection</b> – The game session can
        /// be terminated during a scale-down event.</li> <li><b>FullProtection</b> – If the game
        /// session is in an <code>ACTIVE</code> status, it cannot be terminated during a scale-down
        /// event.</li></ul>
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
        /// Gets and sets the property RuntimeConfiguration. 
        /// <para>
        /// Instructions for launching server processes on each instance in the fleet. The runtime
        /// configuration for a fleet has a collection of server process configurations, one for
        /// each type of server process to run on an instance. A server process configuration
        /// specifies the location of the server executable, launch parameters, and the number
        /// of concurrent processes with that configuration to maintain on each instance. A <code>CreateFleet</code>
        /// request must include a runtime configuration with at least one server process configuration;
        /// otherwise the request will fail with an invalid request exception. (This parameter
        /// replaces the parameters <code>ServerLaunchPath</code> and <code>ServerLaunchParameters</code>;
        /// requests that contain values for these parameters instead of a runtime configuration
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
        /// path and launch parameters instead of a runtime configuration will continue to work.)
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
        /// path and launch parameters instead of a runtime configuration will continue to work.)
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