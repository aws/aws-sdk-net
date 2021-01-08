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
    /// This is the response object from the CreateSimulationApplication operation.
    /// </summary>
    public partial class CreateSimulationApplicationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private RenderingEngine _renderingEngine;
        private string _revisionId;
        private RobotSoftwareSuite _robotSoftwareSuite;
        private SimulationSoftwareSuite _simulationSoftwareSuite;
        private List<Source> _sources = new List<Source>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the simulation application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the simulation application was last
        /// updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the simulation application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision id of the simulation application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property RobotSoftwareSuite. 
        /// <para>
        /// Information about the robot software suite (ROS distribution).
        /// </para>
        /// </summary>
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
        public List<Source> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of all tags added to the simulation application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the simulation application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}