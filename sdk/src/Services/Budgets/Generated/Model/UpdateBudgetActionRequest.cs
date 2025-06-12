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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
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
namespace Amazon.Budgets.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBudgetAction operation.
    /// Updates a budget action.
    /// </summary>
    public partial class UpdateBudgetActionRequest : AmazonBudgetsRequest
    {
        private string _accountId;
        private string _actionId;
        private ActionThreshold _actionThreshold;
        private ApprovalModel _approvalModel;
        private string _budgetName;
        private Definition _definition;
        private string _executionRoleArn;
        private NotificationType _notificationType;
        private List<Subscriber> _subscribers = AWSConfigs.InitializeCollections ? new List<Subscriber>() : null;

        /// <summary>
        /// Gets and sets the property AccountId.
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        ///  A system-generated universally unique identifier (UUID) for the action. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ActionId
        {
            get { return this._actionId; }
            set { this._actionId = value; }
        }

        // Check to see if ActionId property is set
        internal bool IsSetActionId()
        {
            return this._actionId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionThreshold.
        /// </summary>
        public ActionThreshold ActionThreshold
        {
            get { return this._actionThreshold; }
            set { this._actionThreshold = value; }
        }

        // Check to see if ActionThreshold property is set
        internal bool IsSetActionThreshold()
        {
            return this._actionThreshold != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalModel. 
        /// <para>
        ///  This specifies if the action needs manual or automatic approval. 
        /// </para>
        /// </summary>
        public ApprovalModel ApprovalModel
        {
            get { return this._approvalModel; }
            set { this._approvalModel = value; }
        }

        // Check to see if ApprovalModel property is set
        internal bool IsSetApprovalModel()
        {
            return this._approvalModel != null;
        }

        /// <summary>
        /// Gets and sets the property BudgetName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string BudgetName
        {
            get { return this._budgetName; }
            set { this._budgetName = value; }
        }

        // Check to see if BudgetName property is set
        internal bool IsSetBudgetName()
        {
            return this._budgetName != null;
        }

        /// <summary>
        /// Gets and sets the property Definition.
        /// </summary>
        public Definition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        ///  The role passed for action execution and reversion. Roles and actions must be in
        /// the same account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=618)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationType.
        /// </summary>
        public NotificationType NotificationType
        {
            get { return this._notificationType; }
            set { this._notificationType = value; }
        }

        // Check to see if NotificationType property is set
        internal bool IsSetNotificationType()
        {
            return this._notificationType != null;
        }

        /// <summary>
        /// Gets and sets the property Subscribers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=11)]
        public List<Subscriber> Subscribers
        {
            get { return this._subscribers; }
            set { this._subscribers = value; }
        }

        // Check to see if Subscribers property is set
        internal bool IsSetSubscribers()
        {
            return this._subscribers != null && (this._subscribers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}