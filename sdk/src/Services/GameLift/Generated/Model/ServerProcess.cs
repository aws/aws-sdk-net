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
    /// A set of instructions for launching server processes on each instance in a fleet.
    /// Server processes run either an executable in a custom game build or a Realtime Servers
    /// script. Server process configurations are part of a fleet's runtime configuration.
    /// </summary>
    public partial class ServerProcess
    {
        private int? _concurrentExecutions;
        private string _launchPath;
        private string _parameters;

        /// <summary>
        /// Gets and sets the property ConcurrentExecutions. 
        /// <para>
        /// The number of server processes using this configuration that run concurrently on each
        /// instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int ConcurrentExecutions
        {
            get { return this._concurrentExecutions.GetValueOrDefault(); }
            set { this._concurrentExecutions = value; }
        }

        // Check to see if ConcurrentExecutions property is set
        internal bool IsSetConcurrentExecutions()
        {
            return this._concurrentExecutions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchPath. 
        /// <para>
        /// The location of a game build executable or the Realtime script file that contains
        /// the <code>Init()</code> function. Game builds and Realtime scripts are installed on
        /// instances at the root: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Windows (custom game builds only): <code>C:\game</code>. Example: "<code>C:\game\MyGame\server.exe</code>"
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Linux: <code>/local/game</code>. Examples: "<code>/local/game/MyGame/server.exe</code>"
        /// or "<code>/local/game/MyRealtimeScript.js</code>"
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string LaunchPath
        {
            get { return this._launchPath; }
            set { this._launchPath = value; }
        }

        // Check to see if LaunchPath property is set
        internal bool IsSetLaunchPath()
        {
            return this._launchPath != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// An optional list of parameters to pass to the server executable or Realtime script
        /// on launch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

    }
}