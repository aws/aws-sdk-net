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
    /// Creates a new fleet to host game servers. A fleet consists of a set of Amazon Elastic
    /// Compute Cloud (Amazon EC2) instances of a certain type, which defines the CPU, memory,
    /// storage, and networking capacity of each host in the fleet. See <a href="https://aws.amazon.com/ec2/instance-types/">Amazon
    /// EC2 Instance Types</a> for more information. Each instance in the fleet hosts a game
    /// server created from the specified game build. Once a fleet is in an ACTIVE state,
    /// it can begin hosting game sessions.
    /// 
    ///  
    /// <para>
    /// To create a new fleet, provide a name and the EC2 instance type for the new fleet,
    /// and specify the build and server launch path. Builds must be in a READY state before
    /// they can be used to build fleets. When configuring the new fleet, you can optionally
    /// (1) provide a set of launch parameters to be passed to a game server when activated;
    /// (2) limit incoming traffic to a specified range of IP addresses and port numbers;
    /// and (3) configure Amazon GameLift to store game session logs by specifying the path
    /// to the logs stored in your game server files. If the call is successful, Amazon GameLift
    /// performs the following tasks:
    /// </para>
    ///  <ul> <li>Creates a fleet record and sets the state to NEW.</li> <li>Sets the fleet's
    /// capacity to 1 "desired" and 1 "active" EC2 instance count.</li> <li>Creates an EC2
    /// instance and begins the process of initializing the fleet and activating a game server
    /// on the instance.</li> <li>Begins writing events to the fleet event log, which can
    /// be accessed in the GameLift console.</li> </ul> 
    /// <para>
    /// Once a fleet is created, use the following actions to change certain fleet properties
    /// (server launch parameters and log paths cannot be changed):
    /// </para>
    ///  <ul> <li> <a>UpdateFleetAttributes</a> -- Update fleet metadata, including name and
    /// description.</li> <li> <a>UpdateFleetCapacity</a> -- Increase or decrease the number
    /// of instances you want the fleet to maintain.</li> <li> <a>UpdateFleetPortSettings</a>
    /// -- Change the IP addresses and ports that allow access to incoming traffic.</li> </ul>
    /// </summary>
    public partial class CreateFleetRequest : AmazonGameLiftRequest
    {
        private string _buildId;
        private string _description;
        private List<IpPermission> _ec2InboundPermissions = new List<IpPermission>();
        private EC2InstanceType _ec2InstanceType;
        private List<string> _logPaths = new List<string>();
        private string _name;
        private string _serverLaunchParameters;
        private string _serverLaunchPath;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// Unique identifier for the build you want the new fleet to use.
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
        /// Human-readable description of the fleet.
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
        /// Access limits for incoming traffic. Setting these values limits game server access
        /// to incoming traffic using specified IP ranges and port numbers. Some ports in a range
        /// may be restricted. You can provide one or more sets of permissions for the fleet.
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
        /// Type of EC2 instances used in the fleet. EC2 instance types define the CPU, memory,
        /// storage, and networking capacity of the fleetaposs hosts. Amazon GameLift supports
        /// the EC2 instance types listed below. See <a href="https://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a> for detailed descriptions of each.
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
        /// Path to game-session log files generated by your game server. Once a game session
        /// has been terminated, Amazon GameLift captures and stores the logs on Amazon S3. Use
        /// the GameLift console to access the stored logs.
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
        /// Descriptive label associated with this fleet. Fleet names do not need to be unique.
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
        /// Gets and sets the property ServerLaunchParameters. 
        /// <para>
        /// Parameters required to launch your game server. These parameters should be expressed
        /// as a string of command-line parameters. Example: "+sv_port 33435 +start_lobby".
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
        /// Path to the launch executable for the game server. A game server is built into a <code>C:\game</code>
        /// drive. This value must be expressed as <code>C:\game\[launchpath]</code>. Example:
        /// If, when built, your game server files are in a folder called "MyGame", your log path
        /// should be <code>C:\game\MyGame\server.exe</code>.
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