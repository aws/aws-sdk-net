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
    /// Summary information for a simulation application.
    /// </summary>
    public partial class SimulationApplicationSummary
    {
        private string _arn;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private RobotSoftwareSuite _robotSoftwareSuite;
        private SimulationSoftwareSuite _simulationSoftwareSuite;
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
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
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
        /// Gets and sets the property RobotSoftwareSuite. 
        /// <para>
        /// Information about a robot software suite.
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
        /// Information about a simulation software suite.
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