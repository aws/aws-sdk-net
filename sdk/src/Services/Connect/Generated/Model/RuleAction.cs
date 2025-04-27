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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the action to be performed when a rule is triggered.
    /// </summary>
    public partial class RuleAction
    {
        private ActionType _actionType;
        private AssignContactCategoryActionDefinition _assignContactCategoryAction;
        private AssignSlaActionDefinition _assignSlaAction;
        private CreateCaseActionDefinition _createCaseAction;
        private EndAssociatedTasksActionDefinition _endAssociatedTasksAction;
        private EventBridgeActionDefinition _eventBridgeAction;
        private SendNotificationActionDefinition _sendNotificationAction;
        private SubmitAutoEvaluationActionDefinition _submitAutoEvaluationAction;
        private TaskActionDefinition _taskAction;
        private UpdateCaseActionDefinition _updateCaseAction;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of action that creates a rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property AssignContactCategoryAction. 
        /// <para>
        /// Information about the contact category action.
        /// </para>
        ///  
        /// <para>
        /// Supported only for <c>TriggerEventSource</c> values: <c>OnPostCallAnalysisAvailable</c>
        /// | <c>OnRealTimeCallAnalysisAvailable</c> | <c>OnRealTimeChatAnalysisAvailable</c>
        /// | <c>OnPostChatAnalysisAvailable</c> | <c>OnZendeskTicketCreate</c> | <c>OnZendeskTicketStatusUpdate</c>
        /// | <c>OnSalesforceCaseCreate</c> 
        /// </para>
        /// </summary>
        public AssignContactCategoryActionDefinition AssignContactCategoryAction
        {
            get { return this._assignContactCategoryAction; }
            set { this._assignContactCategoryAction = value; }
        }

        // Check to see if AssignContactCategoryAction property is set
        internal bool IsSetAssignContactCategoryAction()
        {
            return this._assignContactCategoryAction != null;
        }

        /// <summary>
        /// Gets and sets the property AssignSlaAction. 
        /// <para>
        /// Information about the assign SLA action.
        /// </para>
        /// </summary>
        public AssignSlaActionDefinition AssignSlaAction
        {
            get { return this._assignSlaAction; }
            set { this._assignSlaAction = value; }
        }

        // Check to see if AssignSlaAction property is set
        internal bool IsSetAssignSlaAction()
        {
            return this._assignSlaAction != null;
        }

        /// <summary>
        /// Gets and sets the property CreateCaseAction. 
        /// <para>
        /// Information about the create case action.
        /// </para>
        ///  
        /// <para>
        /// Supported only for <c>TriggerEventSource</c> values: <c>OnPostCallAnalysisAvailable</c>
        /// | <c>OnPostChatAnalysisAvailable</c>.
        /// </para>
        /// </summary>
        public CreateCaseActionDefinition CreateCaseAction
        {
            get { return this._createCaseAction; }
            set { this._createCaseAction = value; }
        }

        // Check to see if CreateCaseAction property is set
        internal bool IsSetCreateCaseAction()
        {
            return this._createCaseAction != null;
        }

        /// <summary>
        /// Gets and sets the property EndAssociatedTasksAction. 
        /// <para>
        /// Information about the end associated tasks action.
        /// </para>
        ///  
        /// <para>
        /// Supported only for <c>TriggerEventSource</c> values: <c>OnCaseUpdate</c>.
        /// </para>
        /// </summary>
        public EndAssociatedTasksActionDefinition EndAssociatedTasksAction
        {
            get { return this._endAssociatedTasksAction; }
            set { this._endAssociatedTasksAction = value; }
        }

        // Check to see if EndAssociatedTasksAction property is set
        internal bool IsSetEndAssociatedTasksAction()
        {
            return this._endAssociatedTasksAction != null;
        }

        /// <summary>
        /// Gets and sets the property EventBridgeAction. 
        /// <para>
        /// Information about the EventBridge action.
        /// </para>
        ///  
        /// <para>
        /// Supported only for <c>TriggerEventSource</c> values: <c>OnPostCallAnalysisAvailable</c>
        /// | <c>OnRealTimeCallAnalysisAvailable</c> | <c>OnRealTimeChatAnalysisAvailable</c>
        /// | <c>OnPostChatAnalysisAvailable</c> | <c>OnContactEvaluationSubmit</c> | <c>OnMetricDataUpdate</c>
        /// 
        /// </para>
        /// </summary>
        public EventBridgeActionDefinition EventBridgeAction
        {
            get { return this._eventBridgeAction; }
            set { this._eventBridgeAction = value; }
        }

        // Check to see if EventBridgeAction property is set
        internal bool IsSetEventBridgeAction()
        {
            return this._eventBridgeAction != null;
        }

        /// <summary>
        /// Gets and sets the property SendNotificationAction. 
        /// <para>
        /// Information about the send notification action.
        /// </para>
        ///  
        /// <para>
        /// Supported only for <c>TriggerEventSource</c> values: <c>OnPostCallAnalysisAvailable</c>
        /// | <c>OnRealTimeCallAnalysisAvailable</c> | <c>OnRealTimeChatAnalysisAvailable</c>
        /// | <c>OnPostChatAnalysisAvailable</c> | <c>OnContactEvaluationSubmit</c> | <c>OnMetricDataUpdate</c>
        /// 
        /// </para>
        /// </summary>
        public SendNotificationActionDefinition SendNotificationAction
        {
            get { return this._sendNotificationAction; }
            set { this._sendNotificationAction = value; }
        }

        // Check to see if SendNotificationAction property is set
        internal bool IsSetSendNotificationAction()
        {
            return this._sendNotificationAction != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitAutoEvaluationAction. 
        /// <para>
        /// Information about the submit automated evaluation action.
        /// </para>
        /// </summary>
        public SubmitAutoEvaluationActionDefinition SubmitAutoEvaluationAction
        {
            get { return this._submitAutoEvaluationAction; }
            set { this._submitAutoEvaluationAction = value; }
        }

        // Check to see if SubmitAutoEvaluationAction property is set
        internal bool IsSetSubmitAutoEvaluationAction()
        {
            return this._submitAutoEvaluationAction != null;
        }

        /// <summary>
        /// Gets and sets the property TaskAction. 
        /// <para>
        /// Information about the task action. This field is required if <c>TriggerEventSource</c>
        /// is one of the following values: <c>OnZendeskTicketCreate</c> | <c>OnZendeskTicketStatusUpdate</c>
        /// | <c>OnSalesforceCaseCreate</c> 
        /// </para>
        /// </summary>
        public TaskActionDefinition TaskAction
        {
            get { return this._taskAction; }
            set { this._taskAction = value; }
        }

        // Check to see if TaskAction property is set
        internal bool IsSetTaskAction()
        {
            return this._taskAction != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateCaseAction. 
        /// <para>
        /// Information about the update case action.
        /// </para>
        ///  
        /// <para>
        /// Supported only for <c>TriggerEventSource</c> values: <c>OnCaseCreate</c> | <c>OnCaseUpdate</c>.
        /// </para>
        /// </summary>
        public UpdateCaseActionDefinition UpdateCaseAction
        {
            get { return this._updateCaseAction; }
            set { this._updateCaseAction = value; }
        }

        // Check to see if UpdateCaseAction property is set
        internal bool IsSetUpdateCaseAction()
        {
            return this._updateCaseAction != null;
        }

    }
}