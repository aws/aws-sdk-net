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

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Application configuration information for a robot.
    /// </summary>
    public partial class RobotApplicationConfig
    {
        private string _application;
        private string _applicationVersion;
        private LaunchConfig _launchConfig;
        private List<Tool> _tools = new List<Tool>();
        private List<UploadConfiguration> _uploadConfigurations = new List<UploadConfiguration>();
        private bool? _useDefaultTools;
        private bool? _useDefaultUploadConfigurations;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The application information for the robot application.
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
        /// The version of the robot application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The launch configuration for the robot application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LaunchConfig LaunchConfig
        {
            get { return this._launchConfig; }
            set { this._launchConfig = value; }
        }

        // Check to see if LaunchConfig property is set
        internal bool IsSetLaunchConfig()
        {
            return this._launchConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tools. 
        /// <para>
        /// Information about tools configured for the robot application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<Tool> Tools
        {
            get { return this._tools; }
            set { this._tools = value; }
        }

        // Check to see if Tools property is set
        internal bool IsSetTools()
        {
            return this._tools != null && this._tools.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UploadConfigurations. 
        /// <para>
        /// The upload configurations for the robot application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<UploadConfiguration> UploadConfigurations
        {
            get { return this._uploadConfigurations; }
            set { this._uploadConfigurations = value; }
        }

        // Check to see if UploadConfigurations property is set
        internal bool IsSetUploadConfigurations()
        {
            return this._uploadConfigurations != null && this._uploadConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UseDefaultTools. 
        /// <para>
        /// A Boolean indicating whether to use default robot application tools. The default tools
        /// are rviz, rqt, terminal and rosbag record. The default is <code>False</code>. 
        /// </para>
        /// </summary>
        public bool UseDefaultTools
        {
            get { return this._useDefaultTools.GetValueOrDefault(); }
            set { this._useDefaultTools = value; }
        }

        // Check to see if UseDefaultTools property is set
        internal bool IsSetUseDefaultTools()
        {
            return this._useDefaultTools.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseDefaultUploadConfigurations. 
        /// <para>
        /// A Boolean indicating whether to use default upload configurations. By default, <code>.ros</code>
        /// and <code>.gazebo</code> files are uploaded when the application terminates and all
        /// ROS topics will be recorded.
        /// </para>
        ///  
        /// <para>
        /// If you set this value, you must specify an <code>outputLocation</code>. 
        /// </para>
        /// </summary>
        public bool UseDefaultUploadConfigurations
        {
            get { return this._useDefaultUploadConfigurations.GetValueOrDefault(); }
            set { this._useDefaultUploadConfigurations = value; }
        }

        // Check to see if UseDefaultUploadConfigurations property is set
        internal bool IsSetUseDefaultUploadConfigurations()
        {
            return this._useDefaultUploadConfigurations.HasValue; 
        }

    }
}