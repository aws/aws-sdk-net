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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the action to be performed when a rule is triggered.
    /// </summary>
    public partial class RuleAction
    {
        private ActionType _actionType;
        private AssignContactCategoryActionDefinition _assignContactCategoryAction;
        private EventBridgeActionDefinition _eventBridgeAction;
        private SendNotificationActionDefinition _sendNotificationAction;
        private TaskActionDefinition _taskAction;

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
        /// Gets and sets the property EventBridgeAction. 
        /// <para>
        /// Information about the EventBridge action.
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
        /// Gets and sets the property TaskAction. 
        /// <para>
        /// Information about the task action. This field is required if <code>TriggerEventSource</code>
        /// is one of the following values: <code>OnZendeskTicketCreate</code> | <code>OnZendeskTicketStatusUpdate</code>
        /// | <code>OnSalesforceCaseCreate</code> 
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

    }
}