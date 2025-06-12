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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBudget operation.
    /// Updates a budget that sets spending thresholds for rendering activity.
    /// </summary>
    public partial class UpdateBudgetRequest : AmazonDeadlineRequest
    {
        private List<BudgetActionToAdd> _actionsToAdd = AWSConfigs.InitializeCollections ? new List<BudgetActionToAdd>() : null;
        private List<BudgetActionToRemove> _actionsToRemove = AWSConfigs.InitializeCollections ? new List<BudgetActionToRemove>() : null;
        private float? _approximateDollarLimit;
        private string _budgetId;
        private string _clientToken;
        private string _description;
        private string _displayName;
        private string _farmId;
        private BudgetSchedule _schedule;
        private BudgetStatus _status;

        /// <summary>
        /// Gets and sets the property ActionsToAdd. 
        /// <para>
        /// The budget actions to add. Budget actions specify what happens when the budget runs
        /// out.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<BudgetActionToAdd> ActionsToAdd
        {
            get { return this._actionsToAdd; }
            set { this._actionsToAdd = value; }
        }

        // Check to see if ActionsToAdd property is set
        internal bool IsSetActionsToAdd()
        {
            return this._actionsToAdd != null && (this._actionsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ActionsToRemove. 
        /// <para>
        /// The budget actions to remove from the budget.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<BudgetActionToRemove> ActionsToRemove
        {
            get { return this._actionsToRemove; }
            set { this._actionsToRemove = value; }
        }

        // Check to see if ActionsToRemove property is set
        internal bool IsSetActionsToRemove()
        {
            return this._actionsToRemove != null && (this._actionsToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApproximateDollarLimit. 
        /// <para>
        /// The dollar limit to update on the budget. Based on consumed usage.
        /// </para>
        /// </summary>
        public float? ApproximateDollarLimit
        {
            get { return this._approximateDollarLimit; }
            set { this._approximateDollarLimit = value; }
        }

        // Check to see if ApproximateDollarLimit property is set
        internal bool IsSetApproximateDollarLimit()
        {
            return this._approximateDollarLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BudgetId. 
        /// <para>
        /// The budget ID to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BudgetId
        {
            get { return this._budgetId; }
            set { this._budgetId = value; }
        }

        // Check to see if BudgetId property is set
        internal bool IsSetBudgetId()
        {
            return this._budgetId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The unique token which the server uses to recognize retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the budget to update.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=100)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the budget to update.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the budget to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule to update.
        /// </para>
        /// </summary>
        public BudgetSchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Updates the status of the budget.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c>–The budget is being evaluated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c>–The budget is inactive. This can include Expired, Canceled, or deleted
        /// Deleted statuses.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BudgetStatus Status
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