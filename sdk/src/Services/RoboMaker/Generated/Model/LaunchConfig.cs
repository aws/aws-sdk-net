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
    /// Information about a launch configuration.
    /// </summary>
    public partial class LaunchConfig
    {
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _launchFile;
        private string _packageName;
        private PortForwardingConfig _portForwardingConfig;
        private bool? _streamui;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// If you've specified <c>General</c> as the value for your <c>RobotSoftwareSuite</c>,
        /// you can use this field to specify a list of commands for your container image.
        /// </para>
        ///  
        /// <para>
        /// If you've specified <c>SimulationRuntime</c> as the value for your <c>SimulationSoftwareSuite</c>,
        /// you can use this field to specify a list of commands for your container image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && (this._command.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The environment variables for the application launch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LaunchFile. 
        /// <para>
        /// The launch file name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        [AWSProperty(Min=1, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property StreamUI. 
        /// <para>
        /// Boolean indicating whether a streaming session will be configured for the application.
        /// If <c>True</c>, AWS RoboMaker will configure a connection so you can interact with
        /// your application as it is running in the simulation. You must configure and launch
        /// the component. It must have a graphical user interface. 
        /// </para>
        /// </summary>
        public bool? StreamUI
        {
            get { return this._streamui; }
            set { this._streamui = value; }
        }

        // Check to see if StreamUI property is set
        internal bool IsSetStreamUI()
        {
            return this._streamui.HasValue; 
        }

    }
}