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
    /// A set of instructions for launching server processes on each instance in a fleet.
    /// Each instruction set identifies the location of the server executable, optional launch
    /// parameters, and the number of server processes with this configuration to maintain
    /// concurrently on the instance. Server process configurations make up a fleet's <code><a>RuntimeConfiguration</a></code>.
    /// </summary>
    public partial class ServerProcess
    {
        private int? _concurrentExecutions;
        private string _launchPath;
        private string _parameters;

        /// <summary>
        /// Gets and sets the property ConcurrentExecutions. 
        /// <para>
        /// Number of server processes using this configuration to run concurrently on an instance.
        /// 
        /// </para>
        /// </summary>
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
        /// Location in the game build of the server executable. All game builds are installed
        /// on instances at the root <code>C:\game\...</code>, so an executable file located at
        /// <code>MyGame\latest\server.exe</code> has a launch path of "<code>C:\game\MyGame\latest\server.exe</code>".
        /// 
        /// </para>
        /// </summary>
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
        /// Optional list of parameters to pass to the server executable on launch.
        /// </para>
        /// </summary>
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