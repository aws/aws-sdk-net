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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about a deployment application configuration.
    /// </summary>
    public partial class DeploymentApplicationConfig
    {
        private string _application;
        private string _applicationVersion;
        private DeploymentLaunchConfig _launchConfig;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the robot application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1224)]
        public string Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersion. 
        /// <para>
        /// The version of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ApplicationVersion
        {
            get { return this._applicationVersion; }
            set { this._applicationVersion = value; }
        }

        // Check to see if ApplicationVersion property is set
        internal bool IsSetApplicationVersion()
        {
            return this._applicationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchConfig. 
        /// <para>
        /// The launch configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentLaunchConfig LaunchConfig
        {
            get { return this._launchConfig; }
            set { this._launchConfig = value; }
        }

        // Check to see if LaunchConfig property is set
        internal bool IsSetLaunchConfig()
        {
            return this._launchConfig != null;
        }

    }
}