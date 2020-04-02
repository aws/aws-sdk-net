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
    /// A collection of server process configurations that describe what processes to run
    /// on each instance in a fleet. Server processes run either a custom game build executable
    /// or a Realtime Servers script. Each instance in the fleet starts the specified server
    /// processes and continues to start new processes as existing processes end. Each instance
    /// regularly checks for an updated runtime configuration. 
    /// 
    ///  
    /// <para>
    /// The runtime configuration enables the instances in a fleet to run multiple processes
    /// simultaneously. Learn more about <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-multiprocess.html">
    /// Running Multiple Processes on a Fleet </a>.
    /// </para>
    ///  
    /// <para>
    /// A Amazon GameLift instance is limited to 50 processes running simultaneously. To calculate
    /// the total number of processes in a runtime configuration, add the values of the <code>ConcurrentExecutions</code>
    /// parameter for each <a>ServerProcess</a> object.
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
    public partial class RuntimeConfiguration
    {
        private int? _gameSessionActivationTimeoutSeconds;
        private int? _maxConcurrentGameSessionActivations;
        private List<ServerProcess> _serverProcesses = new List<ServerProcess>();

        /// <summary>
        /// Gets and sets the property GameSessionActivationTimeoutSeconds. 
        /// <para>
        /// The maximum amount of time (in seconds) that a game session can remain in status <code>ACTIVATING</code>.
        /// If the game session is not active before the timeout, activation is terminated and
        /// the game session status is changed to <code>TERMINATED</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600)]
        public int GameSessionActivationTimeoutSeconds
        {
            get { return this._gameSessionActivationTimeoutSeconds.GetValueOrDefault(); }
            set { this._gameSessionActivationTimeoutSeconds = value; }
        }

        // Check to see if GameSessionActivationTimeoutSeconds property is set
        internal bool IsSetGameSessionActivationTimeoutSeconds()
        {
            return this._gameSessionActivationTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentGameSessionActivations. 
        /// <para>
        /// The maximum number of game sessions with status <code>ACTIVATING</code> to allow on
        /// an instance simultaneously. This setting limits the amount of instance resources that
        /// can be used for new game activations at any one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int MaxConcurrentGameSessionActivations
        {
            get { return this._maxConcurrentGameSessionActivations.GetValueOrDefault(); }
            set { this._maxConcurrentGameSessionActivations = value; }
        }

        // Check to see if MaxConcurrentGameSessionActivations property is set
        internal bool IsSetMaxConcurrentGameSessionActivations()
        {
            return this._maxConcurrentGameSessionActivations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerProcesses. 
        /// <para>
        /// A collection of server process configurations that describe which server processes
        /// to run on each instance in a fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<ServerProcess> ServerProcesses
        {
            get { return this._serverProcesses; }
            set { this._serverProcesses = value; }
        }

        // Check to see if ServerProcesses property is set
        internal bool IsSetServerProcesses()
        {
            return this._serverProcesses != null && this._serverProcesses.Count > 0; 
        }

    }
}