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
    /// A set of instructions that define the set of server processes to run on computes in
    /// a fleet. Server processes run either an executable in a custom game build or a Amazon
    /// GameLift Servers Realtime script. Amazon GameLift Servers launches the processes,
    /// manages their life cycle, and replaces them as needed. Computes check regularly for
    /// an updated runtime configuration. 
    /// 
    ///  
    /// <para>
    /// An Amazon GameLift Servers instance is limited to 50 processes running concurrently.
    /// To calculate the total number of processes defined in a runtime configuration, add
    /// the values of the <c>ConcurrentExecutions</c> parameter for each server process. Learn
    /// more about <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-multiprocess.html">
    /// Running Multiple Processes on a Fleet</a>.
    /// </para>
    /// </summary>
    public partial class RuntimeConfiguration
    {
        private int? _gameSessionActivationTimeoutSeconds;
        private int? _maxConcurrentGameSessionActivations;
        private List<ServerProcess> _serverProcesses = AWSConfigs.InitializeCollections ? new List<ServerProcess>() : null;

        /// <summary>
        /// Gets and sets the property GameSessionActivationTimeoutSeconds. 
        /// <para>
        /// The maximum amount of time (in seconds) allowed to launch a new game session and have
        /// it report ready to host players. During this time, the game session is in status <c>ACTIVATING</c>.
        /// If the game session does not become active before the timeout, it is ended and the
        /// game session status is changed to <c>TERMINATED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600)]
        public int? GameSessionActivationTimeoutSeconds
        {
            get { return this._gameSessionActivationTimeoutSeconds; }
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
        /// The number of game sessions in status <c>ACTIVATING</c> to allow on an instance or
        /// compute. This setting limits the instance resources that can be used for new game
        /// activations at any one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? MaxConcurrentGameSessionActivations
        {
            get { return this._maxConcurrentGameSessionActivations; }
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
        /// to run on fleet computes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._serverProcesses != null && (this._serverProcesses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}