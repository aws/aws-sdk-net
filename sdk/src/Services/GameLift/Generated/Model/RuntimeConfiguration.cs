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
    /// A collection of server process configurations that describe the set of processes to
    /// run on each instance in a fleet. Server processes run either an executable in a custom
    /// game build or a Realtime Servers script. GameLift launches the configured processes,
    /// manages their life cycle, and replaces them as needed. Each instance checks regularly
    /// for an updated runtime configuration. 
    /// 
    ///  
    /// <para>
    /// A GameLift instance is limited to 50 processes running concurrently. To calculate
    /// the total number of processes in a runtime configuration, add the values of the <code>ConcurrentExecutions</code>
    /// parameter for each server process. Learn more about <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-multiprocess.html">
    /// Running Multiple Processes on a Fleet</a>.
    /// </para>
    /// </summary>
    public partial class RuntimeConfiguration
    {
        private int? _gameSessionActivationTimeoutSeconds;
        private int? _maxConcurrentGameSessionActivations;
        private List<ServerProcess> _serverProcesses = new List<ServerProcess>();

        /// <summary>
        /// Gets and sets the property GameSessionActivationTimeoutSeconds. 
        /// <para>
        /// The maximum amount of time (in seconds) allowed to launch a new game session and have
        /// it report ready to host players. During this time, the game session is in status <code>ACTIVATING</code>.
        /// If the game session does not become active before the timeout, it is ended and the
        /// game session status is changed to <code>TERMINATED</code>.
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
        /// The number of game sessions in status <code>ACTIVATING</code> to allow on an instance.
        /// This setting limits the instance resources that can be used for new game activations
        /// at any one time.
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
        /// A collection of server process configurations that identify what server processes
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