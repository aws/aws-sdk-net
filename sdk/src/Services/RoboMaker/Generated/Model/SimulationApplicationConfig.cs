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
    /// Information about a simulation application configuration.
    /// </summary>
    public partial class SimulationApplicationConfig
    {
        private string _application;
        private string _applicationVersion;
        private LaunchConfig _launchConfig;
        private List<Tool> _tools = AWSConfigs.InitializeCollections ? new List<Tool>() : null;
        private List<UploadConfiguration> _uploadConfigurations = AWSConfigs.InitializeCollections ? new List<UploadConfiguration>() : null;
        private bool? _useDefaultTools;
        private bool? _useDefaultUploadConfigurations;
        private List<WorldConfig> _worldConfigs = AWSConfigs.InitializeCollections ? new List<WorldConfig>() : null;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The application information for the simulation application.
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
        /// The version of the simulation application.
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
        /// The launch configuration for the simulation application.
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
        /// Information about tools configured for the simulation application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tools != null && (this._tools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UploadConfigurations. 
        /// <para>
        /// Information about upload configurations for the simulation application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._uploadConfigurations != null && (this._uploadConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UseDefaultTools. 
        /// <para>
        /// A Boolean indicating whether to use default simulation application tools. The default
        /// tools are rviz, rqt, terminal and rosbag record. The default is <c>False</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used.
        /// </para>
        ///  </important>
        /// </summary>
        [Obsolete("AWS RoboMaker is ending support for ROS software suite. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/software-support-policy.html.")]
        public bool? UseDefaultTools
        {
            get { return this._useDefaultTools; }
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
        /// A Boolean indicating whether to use default upload configurations. By default, <c>.ros</c>
        /// and <c>.gazebo</c> files are uploaded when the application terminates and all ROS
        /// topics will be recorded.
        /// </para>
        ///  
        /// <para>
        /// If you set this value, you must specify an <c>outputLocation</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used.
        /// </para>
        ///  </important>
        /// </summary>
        [Obsolete("AWS RoboMaker is ending support for ROS software suite. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/software-support-policy.html.")]
        public bool? UseDefaultUploadConfigurations
        {
            get { return this._useDefaultUploadConfigurations; }
            set { this._useDefaultUploadConfigurations = value; }
        }

        // Check to see if UseDefaultUploadConfigurations property is set
        internal bool IsSetUseDefaultUploadConfigurations()
        {
            return this._useDefaultUploadConfigurations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorldConfigs. 
        /// <para>
        /// A list of world configurations.
        /// </para>
        ///  <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<WorldConfig> WorldConfigs
        {
            get { return this._worldConfigs; }
            set { this._worldConfigs = value; }
        }

        // Check to see if WorldConfigs property is set
        internal bool IsSetWorldConfigs()
        {
            return this._worldConfigs != null && (this._worldConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}