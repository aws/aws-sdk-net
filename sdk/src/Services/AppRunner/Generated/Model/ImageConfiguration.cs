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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes the configuration that App Runner uses to run an App Runner service using
    /// an image pulled from a source image repository.
    /// </summary>
    public partial class ImageConfiguration
    {
        private string _port;
        private Dictionary<string, string> _runtimeEnvironmentVariables = new Dictionary<string, string>();
        private string _startCommand;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that your application listens to in the container.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>8080</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=51200)]
        public string Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeEnvironmentVariables. 
        /// <para>
        /// Environment variables that are available to your running App Runner service. An array
        /// of key-value pairs. Keys with a prefix of <code>AWSAPPRUNNER</code> are reserved for
        /// system use and aren't valid.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RuntimeEnvironmentVariables
        {
            get { return this._runtimeEnvironmentVariables; }
            set { this._runtimeEnvironmentVariables = value; }
        }

        // Check to see if RuntimeEnvironmentVariables property is set
        internal bool IsSetRuntimeEnvironmentVariables()
        {
            return this._runtimeEnvironmentVariables != null && this._runtimeEnvironmentVariables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartCommand. 
        /// <para>
        /// An optional command that App Runner runs to start the application in the source image.
        /// If specified, this command overrides the Docker image’s default start command.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=51200)]
        public string StartCommand
        {
            get { return this._startCommand; }
            set { this._startCommand = value; }
        }

        // Check to see if StartCommand property is set
        internal bool IsSetStartCommand()
        {
            return this._startCommand != null;
        }

    }
}