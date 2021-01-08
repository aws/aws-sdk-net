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
    /// Container for the parameters to the UpdateSimulationApplication operation.
    /// Updates a simulation application.
    /// </summary>
    public partial class UpdateSimulationApplicationRequest : AmazonRoboMakerRequest
    {
        private string _application;
        private string _currentRevisionId;
        private RenderingEngine _renderingEngine;
        private RobotSoftwareSuite _robotSoftwareSuite;
        private SimulationSoftwareSuite _simulationSoftwareSuite;
        private List<SourceConfig> _sources = new List<SourceConfig>();

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
        /// Gets and sets the property CurrentRevisionId. 
        /// <para>
        /// The revision id for the robot application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string CurrentRevisionId
        {
            get { return this._currentRevisionId; }
            set { this._currentRevisionId = value; }
        }

        // Check to see if CurrentRevisionId property is set
        internal bool IsSetCurrentRevisionId()
        {
            return this._currentRevisionId != null;
        }

        /// <summary>
        /// Gets and sets the property RenderingEngine. 
        /// <para>
        /// The rendering engine for the simulation application.
        /// </para>
        /// </summary>
        public RenderingEngine RenderingEngine
        {
            get { return this._renderingEngine; }
            set { this._renderingEngine = value; }
        }

        // Check to see if RenderingEngine property is set
        internal bool IsSetRenderingEngine()
        {
            return this._renderingEngine != null;
        }

        /// <summary>
        /// Gets and sets the property RobotSoftwareSuite. 
        /// <para>
        /// Information about the robot software suite (ROS distribution).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RobotSoftwareSuite RobotSoftwareSuite
        {
            get { return this._robotSoftwareSuite; }
            set { this._robotSoftwareSuite = value; }
        }

        // Check to see if RobotSoftwareSuite property is set
        internal bool IsSetRobotSoftwareSuite()
        {
            return this._robotSoftwareSuite != null;
        }

        /// <summary>
        /// Gets and sets the property SimulationSoftwareSuite. 
        /// <para>
        /// The simulation software suite used by the simulation application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SimulationSoftwareSuite SimulationSoftwareSuite
        {
            get { return this._simulationSoftwareSuite; }
            set { this._simulationSoftwareSuite = value; }
        }

        // Check to see if SimulationSoftwareSuite property is set
        internal bool IsSetSimulationSoftwareSuite()
        {
            return this._simulationSoftwareSuite != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The sources of the simulation application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SourceConfig> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

    }
}