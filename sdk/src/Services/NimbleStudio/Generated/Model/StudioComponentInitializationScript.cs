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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Initialization scripts for studio components.
    /// </summary>
    public partial class StudioComponentInitializationScript
    {
        private string _launchProfileProtocolVersion;
        private LaunchProfilePlatform _platform;
        private StudioComponentInitializationScriptRunContext _runContext;
        private string _script;

        /// <summary>
        /// Gets and sets the property LaunchProfileProtocolVersion. 
        /// <para>
        /// The version number of the protocol that is used by the launch profile. The only valid
        /// version is "2021-03-31".
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public string LaunchProfileProtocolVersion
        {
            get { return this._launchProfileProtocolVersion; }
            set { this._launchProfileProtocolVersion = value; }
        }

        // Check to see if LaunchProfileProtocolVersion property is set
        internal bool IsSetLaunchProfileProtocolVersion()
        {
            return this._launchProfileProtocolVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the initialization script, either Windows or Linux.
        /// </para>
        /// </summary>
        public LaunchProfilePlatform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property RunContext. 
        /// <para>
        /// The method to use when running the initialization script.
        /// </para>
        /// </summary>
        public StudioComponentInitializationScriptRunContext RunContext
        {
            get { return this._runContext; }
            set { this._runContext = value; }
        }

        // Check to see if RunContext property is set
        internal bool IsSetRunContext()
        {
            return this._runContext != null;
        }

        /// <summary>
        /// Gets and sets the property Script. 
        /// <para>
        /// The initialization script.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=5120)]
        public string Script
        {
            get { return this._script; }
            set { this._script = value; }
        }

        // Check to see if Script property is set
        internal bool IsSetScript()
        {
            return this._script != null;
        }

    }
}