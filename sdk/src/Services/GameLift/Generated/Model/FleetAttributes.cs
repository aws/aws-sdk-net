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
    /// General properties describing a fleet.
    /// </summary>
    public partial class FleetAttributes
    {
        private string _buildId;
        private DateTime? _creationTime;
        private string _description;
        private string _fleetId;
        private List<string> _logPaths = new List<string>();
        private string _name;
        private ProtectionPolicy _newGameSessionProtectionPolicy;
        private OperatingSystem _operatingSystem;
        private string _serverLaunchParameters;
        private string _serverLaunchPath;
        private FleetStatus _status;
        private DateTime? _terminationTime;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// Unique identifier for a build.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (ex: "1469498468.057".
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
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet.
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
        /// Type of game session protection to set for all new instances started in the fleet.
        /// </para>
        ///  <ul><li><b>NoProtection</b> – The game session can be terminated during a scale-down
        /// event.</li> <li><b>FullProtection</b> – If the game session is in an <code>ACTIVE</code>
        /// status, it cannot be terminated during a scale-down event.</li></ul>
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
        /// Operating system of the fleet's computing resources. A fleet's operating system depends
        /// on the OS specified for the build that is deployed on this fleet.
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
        /// Gets and sets the property ServerLaunchParameters. 
        /// <para>
        /// Game server launch parameters specified for fleets created prior to 2016-08-04 (or
        /// AWS SDK v. 0.12.16). Server launch parameters for fleets created after this date are
        /// specified in the fleet's <code><a>RuntimeConfiguration</a></code>.
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
        /// Path to a game server executable in the fleet's build, specified for fleets created
        /// prior to 2016-08-04 (or AWS SDK v. 0.12.16). Server launch paths for fleets created
        /// after this date are specified in the fleet's <code><a>RuntimeConfiguration</a></code>.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the fleet.
        /// </para>
        ///  
        /// <para>
        /// Possible fleet statuses include the following:
        /// </para>
        ///  <ul><li><b>NEW</b> – A new fleet has been defined and desired instances is set to
        /// 1. </li><li><b>DOWNLOADING/VALIDATING/BUILDING/ACTIVATING</b> – GameLift is setting
        /// up the new fleet, creating new instances with the game build and starting server processes.</li><li><b>ACTIVE</b>
        /// – Hosts can now accept game sessions.</li><li><b>ERROR</b> – An error occurred when
        /// downloading, validating, building, or activating the fleet.</li><li><b>DELETING</b>
        /// – Hosts are responding to a delete fleet request.</li><li><b>TERMINATED</b> – The
        /// fleet no longer exists.</li></ul>
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
        /// Gets and sets the property TerminationTime. 
        /// <para>
        /// Time stamp indicating when this data object was terminated. Format is a number expressed
        /// in Unix time as milliseconds (ex: "1469498468.057".
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