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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A workflow run is an execution of a workflow providing all the runtime information.
    /// </summary>
    public partial class WorkflowRun
    {
        private DateTime? _completedOn;
        private string _errorMessage;
        private WorkflowGraph _graph;
        private string _name;
        private string _previousRunId;
        private DateTime? _startedOn;
        private StartingEventBatchCondition _startingEventBatchCondition;
        private WorkflowRunStatistics _statistics;
        private WorkflowRunStatus _status;
        private string _workflowRunId;
        private Dictionary<string, string> _workflowRunProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time when the workflow run completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn
        {
            get { return this._completedOn; }
            set { this._completedOn = value; }
        }

        // Check to see if CompletedOn property is set
        internal bool IsSetCompletedOn()
        {
            return this._completedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// This error message describes any error that may have occurred in starting the workflow
        /// run. Currently the only error message is "Concurrent runs exceeded for workflow: <c>foo</c>."
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Graph. 
        /// <para>
        /// The graph representing all the Glue components that belong to the workflow as nodes
        /// and directed connections between them as edges.
        /// </para>
        /// </summary>
        public WorkflowGraph Graph
        {
            get { return this._graph; }
            set { this._graph = value; }
        }

        // Check to see if Graph property is set
        internal bool IsSetGraph()
        {
            return this._graph != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the workflow that was run.
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
        /// Gets and sets the property PreviousRunId. 
        /// <para>
        /// The ID of the previous workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PreviousRunId
        {
            get { return this._previousRunId; }
            set { this._previousRunId = value; }
        }

        // Check to see if PreviousRunId property is set
        internal bool IsSetPreviousRunId()
        {
            return this._previousRunId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time when the workflow run was started.
        /// </para>
        /// </summary>
        public DateTime? StartedOn
        {
            get { return this._startedOn; }
            set { this._startedOn = value; }
        }

        // Check to see if StartedOn property is set
        internal bool IsSetStartedOn()
        {
            return this._startedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartingEventBatchCondition. 
        /// <para>
        /// The batch condition that started the workflow run.
        /// </para>
        /// </summary>
        public StartingEventBatchCondition StartingEventBatchCondition
        {
            get { return this._startingEventBatchCondition; }
            set { this._startingEventBatchCondition = value; }
        }

        // Check to see if StartingEventBatchCondition property is set
        internal bool IsSetStartingEventBatchCondition()
        {
            return this._startingEventBatchCondition != null;
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistics of the run.
        /// </para>
        /// </summary>
        public WorkflowRunStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the workflow run.
        /// </para>
        /// </summary>
        public WorkflowRunStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowRunId. 
        /// <para>
        /// The ID of this workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string WorkflowRunId
        {
            get { return this._workflowRunId; }
            set { this._workflowRunId = value; }
        }

        // Check to see if WorkflowRunId property is set
        internal bool IsSetWorkflowRunId()
        {
            return this._workflowRunId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowRunProperties. 
        /// <para>
        /// The workflow run properties which were set during the run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> WorkflowRunProperties
        {
            get { return this._workflowRunProperties; }
            set { this._workflowRunProperties = value; }
        }

        // Check to see if WorkflowRunProperties property is set
        internal bool IsSetWorkflowRunProperties()
        {
            return this._workflowRunProperties != null && (this._workflowRunProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}