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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of action that creates a rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionType ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

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
        public AssignContactCategoryActionDefinition AssignContactCategoryAction { get; set; }

        /// <summary>
        /// Checks to see if the AssignContactCategoryAction property is set.
        /// </summary>
        internal bool IsSetAssignContactCategoryAction() => this.AssignContactCategoryAction != null;

        /// <summary>
        /// Gets and sets the property AssignSlaAction. 
        /// <para>
        /// Information about the assign SLA action.
        /// </para>
        /// </summary>
        public AssignSlaActionDefinition AssignSlaAction { get; set; }

        /// <summary>
        /// Checks to see if the AssignSlaAction property is set.
        /// </summary>
        internal bool IsSetAssignSlaAction() => this.AssignSlaAction != null;

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
        public CreateCaseActionDefinition CreateCaseAction { get; set; }

        /// <summary>
        /// Checks to see if the CreateCaseAction property is set.
        /// </summary>
        internal bool IsSetCreateCaseAction() => this.CreateCaseAction != null;

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
        public EndAssociatedTasksActionDefinition EndAssociatedTasksAction { get; set; }

        /// <summary>
        /// Checks to see if the EndAssociatedTasksAction property is set.
        /// </summary>
        internal bool IsSetEndAssociatedTasksAction() => this.EndAssociatedTasksAction != null;

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
        public EventBridgeActionDefinition EventBridgeAction { get; set; }

        /// <summary>
        /// Checks to see if the EventBridgeAction property is set.
        /// </summary>
        internal bool IsSetEventBridgeAction() => this.EventBridgeAction != null;

        /// <summary>
        /// Gets and sets the property ExtractInformationAction. 
        /// <para>
        /// Information about the extract information action.
        /// </para>
        /// </summary>
        public ExtractInformationActionDefinition ExtractInformationAction { get; set; }

        /// <summary>
        /// Checks to see if the ExtractInformationAction property is set.
        /// </summary>
        internal bool IsSetExtractInformationAction() => this.ExtractInformationAction != null;

        /// <summary>
        /// Gets and sets the property SendInAppNotificationAction. 
        /// <para>
        /// Information about the send in-app notification action.
        /// </para>
        ///  
        /// <para>
        /// Supported only for <c>TriggerEventSource</c> values: <c>OnPostCallAnalysisAvailable</c>
        /// | <c>OnRealTimeCallAnalysisAvailable</c> | <c>OnRealTimeChatAnalysisAvailable</c>
        /// | <c>OnPostChatAnalysisAvailable</c> | <c>OnAfterCallWorkAvailable</c> | <c>OnAfterChatWorkAvailable</c>
        /// | <c>OnEmailAnalysisAvailable</c> | <c>OnContactEvaluationSubmit</c> | <c>OnCaseCreate</c>
        /// | <c>OnCaseUpdate</c> | <c>OnSlaBreach</c> | <c>OnSchedulePublish</c> | <c>OnScheduleUpdate</c>
        /// | <c>OnScheduleTimeOffRequestActivity</c> 
        /// </para>
        /// </summary>
        public SendInAppNotificationActionDefinition SendInAppNotificationAction { get; set; }

        /// <summary>
        /// Checks to see if the SendInAppNotificationAction property is set.
        /// </summary>
        internal bool IsSetSendInAppNotificationAction() => this.SendInAppNotificationAction != null;

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
        public SendNotificationActionDefinition SendNotificationAction { get; set; }

        /// <summary>
        /// Checks to see if the SendNotificationAction property is set.
        /// </summary>
        internal bool IsSetSendNotificationAction() => this.SendNotificationAction != null;

        /// <summary>
        /// Gets and sets the property SubmitAutoEvaluationAction. 
        /// <para>
        /// Information about the submit automated evaluation action.
        /// </para>
        /// </summary>
        public SubmitAutoEvaluationActionDefinition SubmitAutoEvaluationAction { get; set; }

        /// <summary>
        /// Checks to see if the SubmitAutoEvaluationAction property is set.
        /// </summary>
        internal bool IsSetSubmitAutoEvaluationAction() => this.SubmitAutoEvaluationAction != null;

        /// <summary>
        /// Gets and sets the property TaskAction. 
        /// <para>
        /// Information about the task action. This field is required if <c>TriggerEventSource</c>
        /// is one of the following values: <c>OnZendeskTicketCreate</c> | <c>OnZendeskTicketStatusUpdate</c>
        /// | <c>OnSalesforceCaseCreate</c> 
        /// </para>
        /// </summary>
        public TaskActionDefinition TaskAction { get; set; }

        /// <summary>
        /// Checks to see if the TaskAction property is set.
        /// </summary>
        internal bool IsSetTaskAction() => this.TaskAction != null;

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
        public UpdateCaseActionDefinition UpdateCaseAction { get; set; }

        /// <summary>
        /// Checks to see if the UpdateCaseAction property is set.
        /// </summary>
        internal bool IsSetUpdateCaseAction() => this.UpdateCaseAction != null;
    }
}
