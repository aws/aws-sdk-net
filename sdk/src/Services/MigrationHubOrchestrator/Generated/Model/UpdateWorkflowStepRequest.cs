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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkflowStep operation.
    /// Update a step in a migration workflow.
    /// </summary>
    public partial class UpdateWorkflowStepRequest : AmazonMigrationHubOrchestratorRequest
    {
        private string _description;
        private string _id;
        private string _name;
        private List<string> _next = new List<string>();
        private List<WorkflowStepOutput> _outputs = new List<WorkflowStepOutput>();
        private List<string> _previous = new List<string>();
        private StepStatus _status;
        private StepActionType _stepActionType;
        private string _stepGroupId;
        private List<string> _stepTarget = new List<string>();
        private string _workflowId;
        private WorkflowStepAutomationConfiguration _workflowStepAutomationConfiguration;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Next. 
        /// <para>
        /// The next step.
        /// </para>
        /// </summary>
        public List<string> Next
        {
            get { return this._next; }
            set { this._next = value; }
        }

        // Check to see if Next property is set
        internal bool IsSetNext()
        {
            return this._next != null && this._next.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The outputs of a step.
        /// </para>
        /// </summary>
        public List<WorkflowStepOutput> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Previous. 
        /// <para>
        /// The previous step.
        /// </para>
        /// </summary>
        public List<string> Previous
        {
            get { return this._previous; }
            set { this._previous = value; }
        }

        // Check to see if Previous property is set
        internal bool IsSetPrevious()
        {
            return this._previous != null && this._previous.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the step.
        /// </para>
        /// </summary>
        public StepStatus Status
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
        /// Gets and sets the property StepActionType. 
        /// <para>
        /// The action type of the step. You must run and update the status of a manual step for
        /// the workflow to continue after the completion of the step.
        /// </para>
        /// </summary>
        public StepActionType StepActionType
        {
            get { return this._stepActionType; }
            set { this._stepActionType = value; }
        }

        // Check to see if StepActionType property is set
        internal bool IsSetStepActionType()
        {
            return this._stepActionType != null;
        }

        /// <summary>
        /// Gets and sets the property StepGroupId. 
        /// <para>
        /// The ID of the step group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string StepGroupId
        {
            get { return this._stepGroupId; }
            set { this._stepGroupId = value; }
        }

        // Check to see if StepGroupId property is set
        internal bool IsSetStepGroupId()
        {
            return this._stepGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property StepTarget. 
        /// <para>
        /// The servers on which a step will be run.
        /// </para>
        /// </summary>
        public List<string> StepTarget
        {
            get { return this._stepTarget; }
            set { this._stepTarget = value; }
        }

        // Check to see if StepTarget property is set
        internal bool IsSetStepTarget()
        {
            return this._stepTarget != null && this._stepTarget.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The ID of the migration workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string WorkflowId
        {
            get { return this._workflowId; }
            set { this._workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this._workflowId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowStepAutomationConfiguration. 
        /// <para>
        /// The custom script to run tests on the source and target environments.
        /// </para>
        /// </summary>
        public WorkflowStepAutomationConfiguration WorkflowStepAutomationConfiguration
        {
            get { return this._workflowStepAutomationConfiguration; }
            set { this._workflowStepAutomationConfiguration = value; }
        }

        // Check to see if WorkflowStepAutomationConfiguration property is set
        internal bool IsSetWorkflowStepAutomationConfiguration()
        {
            return this._workflowStepAutomationConfiguration != null;
        }

    }
}