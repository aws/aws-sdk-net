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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Stage statistics such as input and output rows and bytes, execution time and stage
    /// state. This information also includes substages and the query stage plan.
    /// </summary>
    public partial class QueryStage
    {
        private long? _executionTime;
        private long? _inputBytes;
        private long? _inputRows;
        private long? _outputBytes;
        private long? _outputRows;
        private QueryStagePlanNode _queryStagePlan;
        private long? _stageId;
        private string _state;
        private List<QueryStage> _subStages = AWSConfigs.InitializeCollections ? new List<QueryStage>() : null;

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// Time taken to execute this stage.
        /// </para>
        /// </summary>
        public long? ExecutionTime
        {
            get { return this._executionTime; }
            set { this._executionTime = value; }
        }

        // Check to see if ExecutionTime property is set
        internal bool IsSetExecutionTime()
        {
            return this._executionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputBytes. 
        /// <para>
        /// The number of bytes input into the stage for execution.
        /// </para>
        /// </summary>
        public long? InputBytes
        {
            get { return this._inputBytes; }
            set { this._inputBytes = value; }
        }

        // Check to see if InputBytes property is set
        internal bool IsSetInputBytes()
        {
            return this._inputBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputRows. 
        /// <para>
        /// The number of rows input into the stage for execution.
        /// </para>
        /// </summary>
        public long? InputRows
        {
            get { return this._inputRows; }
            set { this._inputRows = value; }
        }

        // Check to see if InputRows property is set
        internal bool IsSetInputRows()
        {
            return this._inputRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputBytes. 
        /// <para>
        /// The number of bytes output from the stage after execution.
        /// </para>
        /// </summary>
        public long? OutputBytes
        {
            get { return this._outputBytes; }
            set { this._outputBytes = value; }
        }

        // Check to see if OutputBytes property is set
        internal bool IsSetOutputBytes()
        {
            return this._outputBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputRows. 
        /// <para>
        /// The number of rows output from the stage after execution.
        /// </para>
        /// </summary>
        public long? OutputRows
        {
            get { return this._outputRows; }
            set { this._outputRows = value; }
        }

        // Check to see if OutputRows property is set
        internal bool IsSetOutputRows()
        {
            return this._outputRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryStagePlan. 
        /// <para>
        /// Stage plan information such as name, identifier, sub plans, and source stages.
        /// </para>
        /// </summary>
        public QueryStagePlanNode QueryStagePlan
        {
            get { return this._queryStagePlan; }
            set { this._queryStagePlan = value; }
        }

        // Check to see if QueryStagePlan property is set
        internal bool IsSetQueryStagePlan()
        {
            return this._queryStagePlan != null;
        }

        /// <summary>
        /// Gets and sets the property StageId. 
        /// <para>
        /// The identifier for a stage.
        /// </para>
        /// </summary>
        public long? StageId
        {
            get { return this._stageId; }
            set { this._stageId = value; }
        }

        // Check to see if StageId property is set
        internal bool IsSetStageId()
        {
            return this._stageId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the stage after query execution.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SubStages. 
        /// <para>
        /// List of sub query stages that form this stage execution plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QueryStage> SubStages
        {
            get { return this._subStages; }
            set { this._subStages = value; }
        }

        // Check to see if SubStages property is set
        internal bool IsSetSubStages()
        {
            return this._subStages != null && (this._subStages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}