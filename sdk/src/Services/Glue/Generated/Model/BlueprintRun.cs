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
    /// The details of a blueprint run.
    /// </summary>
    public partial class BlueprintRun
    {
        private string _blueprintName;
        private DateTime? _completedOn;
        private string _errorMessage;
        private string _parameters;
        private string _roleArn;
        private string _rollbackErrorMessage;
        private string _runId;
        private DateTime? _startedOn;
        private BlueprintRunState _state;
        private string _workflowName;

        /// <summary>
        /// Gets and sets the property BlueprintName. 
        /// <para>
        /// The name of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BlueprintName
        {
            get { return this._blueprintName; }
            set { this._blueprintName = value; }
        }

        // Check to see if BlueprintName property is set
        internal bool IsSetBlueprintName()
        {
            return this._blueprintName != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time that the blueprint run completed.
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
        /// Indicates any errors that are seen while running the blueprint.
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The blueprint parameters as a string. You will have to provide a value for each key
        /// that is required from the parameter spec that is defined in the <c>Blueprint$ParameterSpec</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role ARN. This role will be assumed by the Glue service and will be used to create
        /// the workflow and other entities of a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackErrorMessage. 
        /// <para>
        /// If there are any errors while creating the entities of a workflow, we try to roll
        /// back the created entities until that point and delete them. This attribute indicates
        /// the errors seen while trying to delete the entities that are created.
        /// </para>
        /// </summary>
        public string RollbackErrorMessage
        {
            get { return this._rollbackErrorMessage; }
            set { this._rollbackErrorMessage = value; }
        }

        // Check to see if RollbackErrorMessage property is set
        internal bool IsSetRollbackErrorMessage()
        {
            return this._rollbackErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The run ID for this blueprint run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time that the blueprint run started.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the blueprint run. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Running — The blueprint run is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Succeeded — The blueprint run completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed — The blueprint run failed and rollback is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rolling Back — The blueprint run failed and rollback is in progress.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BlueprintRunState State
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
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of a workflow that is created as a result of a successful blueprint run.
        /// If a blueprint run has an error, there will not be a workflow created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string WorkflowName
        {
            get { return this._workflowName; }
            set { this._workflowName = value; }
        }

        // Check to see if WorkflowName property is set
        internal bool IsSetWorkflowName()
        {
            return this._workflowName != null;
        }

    }
}