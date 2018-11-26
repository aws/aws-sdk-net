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
    /// Summary information for a simulation job.
    /// </summary>
    public partial class SimulationJobSummary
    {
        private string _arn;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private List<string> _robotApplicationNames = new List<string>();
        private List<string> _simulationApplicationNames = new List<string>();
        private SimulationJobStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the simulation job.
        /// </para>
        /// </summary>
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
        /// The time, in milliseconds since the epoch, when the simulation job was last updated.
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
        /// The name of the simulation job.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RobotApplicationNames. 
        /// <para>
        /// A list of simulation job robot application names.
        /// </para>
        /// </summary>
        public List<string> RobotApplicationNames
        {
            get { return this._robotApplicationNames; }
            set { this._robotApplicationNames = value; }
        }

        // Check to see if RobotApplicationNames property is set
        internal bool IsSetRobotApplicationNames()
        {
            return this._robotApplicationNames != null && this._robotApplicationNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SimulationApplicationNames. 
        /// <para>
        /// A list of simulation job simulation application names.
        /// </para>
        /// </summary>
        public List<string> SimulationApplicationNames
        {
            get { return this._simulationApplicationNames; }
            set { this._simulationApplicationNames = value; }
        }

        // Check to see if SimulationApplicationNames property is set
        internal bool IsSetSimulationApplicationNames()
        {
            return this._simulationApplicationNames != null && this._simulationApplicationNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the simulation job.
        /// </para>
        /// </summary>
        public SimulationJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}