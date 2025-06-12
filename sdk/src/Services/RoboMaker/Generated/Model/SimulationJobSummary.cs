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
    /// Summary information for a simulation job.
    /// </summary>
    public partial class SimulationJobSummary
    {
        private string _arn;
        private ComputeType _computeType;
        private List<string> _dataSourceNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private List<string> _robotApplicationNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _simulationApplicationNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SimulationJobStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the simulation job.
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
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// The compute type for the simulation job summary.
        /// </para>
        /// </summary>
        public ComputeType ComputeType
        {
            get { return this._computeType; }
            set { this._computeType = value; }
        }

        // Check to see if ComputeType property is set
        internal bool IsSetComputeType()
        {
            return this._computeType != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceNames. 
        /// <para>
        /// The names of the data sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DataSourceNames
        {
            get { return this._dataSourceNames; }
            set { this._dataSourceNames = value; }
        }

        // Check to see if DataSourceNames property is set
        internal bool IsSetDataSourceNames()
        {
            return this._dataSourceNames != null && (this._dataSourceNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the simulation job was last updated.
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
        /// The name of the simulation job.
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
        /// Gets and sets the property RobotApplicationNames. 
        /// <para>
        /// A list of simulation job robot application names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RobotApplicationNames
        {
            get { return this._robotApplicationNames; }
            set { this._robotApplicationNames = value; }
        }

        // Check to see if RobotApplicationNames property is set
        internal bool IsSetRobotApplicationNames()
        {
            return this._robotApplicationNames != null && (this._robotApplicationNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SimulationApplicationNames. 
        /// <para>
        /// A list of simulation job simulation application names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SimulationApplicationNames
        {
            get { return this._simulationApplicationNames; }
            set { this._simulationApplicationNames = value; }
        }

        // Check to see if SimulationApplicationNames property is set
        internal bool IsSetSimulationApplicationNames()
        {
            return this._simulationApplicationNames != null && (this._simulationApplicationNames.Count > 0 || !AWSConfigs.InitializeCollections); 
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