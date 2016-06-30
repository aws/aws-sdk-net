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
    /// Collection of server process configurations that describe what processes should be
    /// run on each instance in a fleet. An instance can launch and maintain multiple server
    /// processes based on the runtime configuration; it regularly checks for an updated runtime
    /// configuration and starts new server processes to match the latest version.
    /// 
    ///  
    /// <para>
    /// The key purpose of a a runtime configuration with multiple server process configurations
    /// is to be able to run more than one kind of game server in a single fleet. You can
    /// include configurations for more than one server executable in order to run two or
    /// more different programs to run on the same instance. This option might be useful,
    /// for example, to run more than one version of your game server on the same fleet. Another
    /// option is to specify configurations for the same server executable but with different
    /// launch parameters.
    /// </para>
    ///  
    /// <para>
    /// A GameLift instance is limited to 50 processes running simultaneously. To calculate
    /// the total number of processes specified in a runtime configuration, add the values
    /// of the <code>ConcurrentExecutions</code> parameter for each <code><a>ServerProcess</a></code>
    /// object in the runtime configuration.
    /// </para>
    /// </summary>
    public partial class RuntimeConfiguration
    {
        private List<ServerProcess> _serverProcesses = new List<ServerProcess>();

        /// <summary>
        /// Gets and sets the property ServerProcesses. 
        /// <para>
        /// Collection of server process configurations describing what server processes to run
        /// on each instance in a fleet 
        /// </para>
        /// </summary>
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