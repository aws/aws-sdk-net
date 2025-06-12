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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// This is the response object from the GetWorkflowStep operation.
    /// </summary>
    public partial class GetWorkflowStepResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _description;
        private DateTime? _endTime;
        private DateTime? _lastStartTime;
        private string _name;
        private List<string> _next = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _noOfSrvCompleted;
        private int? _noOfSrvFailed;
        private List<WorkflowStepOutput> _outputs = AWSConfigs.InitializeCollections ? new List<WorkflowStepOutput>() : null;
        private Owner _owner;
        private List<string> _previous = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _scriptOutputLocation;
        private StepStatus _status;
        private string _statusMessage;
        private StepActionType _stepActionType;
        private string _stepGroupId;
        private string _stepId;
        private List<string> _stepTarget = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _totalNoOfSrv;
        private string _workflowId;
        private WorkflowStepAutomationConfiguration _workflowStepAutomationConfiguration;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the step was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the step.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the step ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastStartTime. 
        /// <para>
        /// The time at which the workflow was last started.
        /// </para>
        /// </summary>
        public DateTime? LastStartTime
        {
            get { return this._lastStartTime; }
            set { this._lastStartTime = value; }
        }

        // Check to see if LastStartTime property is set
        internal bool IsSetLastStartTime()
        {
            return this._lastStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the step.
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
        /// Gets and sets the property Next. 
        /// <para>
        /// The next step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Next
        {
            get { return this._next; }
            set { this._next = value; }
        }

        // Check to see if Next property is set
        internal bool IsSetNext()
        {
            return this._next != null && (this._next.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NoOfSrvCompleted. 
        /// <para>
        /// The number of servers that have been migrated.
        /// </para>
        /// </summary>
        public int? NoOfSrvCompleted
        {
            get { return this._noOfSrvCompleted; }
            set { this._noOfSrvCompleted = value; }
        }

        // Check to see if NoOfSrvCompleted property is set
        internal bool IsSetNoOfSrvCompleted()
        {
            return this._noOfSrvCompleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoOfSrvFailed. 
        /// <para>
        /// The number of servers that have failed to migrate.
        /// </para>
        /// </summary>
        public int? NoOfSrvFailed
        {
            get { return this._noOfSrvFailed; }
            set { this._noOfSrvFailed = value; }
        }

        // Check to see if NoOfSrvFailed property is set
        internal bool IsSetNoOfSrvFailed()
        {
            return this._noOfSrvFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The outputs of the step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<WorkflowStepOutput> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the step.
        /// </para>
        /// </summary>
        public Owner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Previous. 
        /// <para>
        /// The previous step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Previous
        {
            get { return this._previous; }
            set { this._previous = value; }
        }

        // Check to see if Previous property is set
        internal bool IsSetPrevious()
        {
            return this._previous != null && (this._previous.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScriptOutputLocation. 
        /// <para>
        /// The output location of the script.
        /// </para>
        /// </summary>
        public string ScriptOutputLocation
        {
            get { return this._scriptOutputLocation; }
            set { this._scriptOutputLocation = value; }
        }

        // Check to see if ScriptOutputLocation property is set
        internal bool IsSetScriptOutputLocation()
        {
            return this._scriptOutputLocation != null;
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message of the migration workflow.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
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
        /// Gets and sets the property StepId. 
        /// <para>
        /// The ID of the step.
        /// </para>
        /// </summary>
        public string StepId
        {
            get { return this._stepId; }
            set { this._stepId = value; }
        }

        // Check to see if StepId property is set
        internal bool IsSetStepId()
        {
            return this._stepId != null;
        }

        /// <summary>
        /// Gets and sets the property StepTarget. 
        /// <para>
        /// The servers on which a step will be run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StepTarget
        {
            get { return this._stepTarget; }
            set { this._stepTarget = value; }
        }

        // Check to see if StepTarget property is set
        internal bool IsSetStepTarget()
        {
            return this._stepTarget != null && (this._stepTarget.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalNoOfSrv. 
        /// <para>
        /// The total number of servers that have been migrated.
        /// </para>
        /// </summary>
        public int? TotalNoOfSrv
        {
            get { return this._totalNoOfSrv; }
            set { this._totalNoOfSrv = value; }
        }

        // Check to see if TotalNoOfSrv property is set
        internal bool IsSetTotalNoOfSrv()
        {
            return this._totalNoOfSrv.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The ID of the migration workflow.
        /// </para>
        /// </summary>
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
        /// The custom script to run tests on source or target environments.
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