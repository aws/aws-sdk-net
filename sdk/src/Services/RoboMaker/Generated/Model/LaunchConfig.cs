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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about a launch configuration.
    /// </summary>
    public partial class LaunchConfig
    {
        private Dictionary<string, string> _environmentVariables = new Dictionary<string, string>();
        private string _launchFile;
        private string _packageName;
        private PortForwardingConfig _portForwardingConfig;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The environment variables for the application launch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && this._environmentVariables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchFile. 
        /// <para>
        /// The launch file name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string LaunchFile
        {
            get { return this._launchFile; }
            set { this._launchFile = value; }
        }

        // Check to see if LaunchFile property is set
        internal bool IsSetLaunchFile()
        {
            return this._launchFile != null;
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The package name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string PackageName
        {
            get { return this._packageName; }
            set { this._packageName = value; }
        }

        // Check to see if PackageName property is set
        internal bool IsSetPackageName()
        {
            return this._packageName != null;
        }

        /// <summary>
        /// Gets and sets the property PortForwardingConfig. 
        /// <para>
        /// The port forwarding configuration.
        /// </para>
        /// </summary>
        public PortForwardingConfig PortForwardingConfig
        {
            get { return this._portForwardingConfig; }
            set { this._portForwardingConfig = value; }
        }

        // Check to see if PortForwardingConfig property is set
        internal bool IsSetPortForwardingConfig()
        {
            return this._portForwardingConfig != null;
        }

    }
}