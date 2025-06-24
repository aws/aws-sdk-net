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
    /// A set of instructions for launching server processes on fleet computes. Server processes
    /// run either an executable in a custom game build or a Amazon GameLift Servers Realtime
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
        /// instance or compute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? ConcurrentExecutions
        {
            get { return this._concurrentExecutions; }
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
        /// The location of a game build executable or Realtime script. Game builds and Realtime
        /// scripts are installed on instances at the root: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Windows (custom game builds only): <c>C:\game</c>. Example: "<c>C:\game\MyGame\server.exe</c>"
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Linux: <c>/local/game</c>. Examples: "<c>/local/game/MyGame/server.exe</c>" or "<c>/local/game/MyRealtimeScript.js</c>"
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Amazon GameLift Servers doesn't support the use of setup scripts that launch the game
        /// executable. For custom game builds, this parameter must indicate the executable that
        /// calls the server SDK operations <c>initSDK()</c> and <c>ProcessReady()</c>. 
        /// </para>
        ///  </note>
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