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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBudget operation. Updates a budget that
    /// sets spending thresholds for rendering activity.
    /// </summary>
    public partial class UpdateBudgetRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property ActionsToAdd. The budget actions to add. Budget actions
        /// specify what happens when the budget runs out.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<BudgetActionToAdd> ActionsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<BudgetActionToAdd>() : null;

        /// <summary>
        /// Checks to see if the ActionsToAdd property is set.
        /// </summary>
        internal bool IsSetActionsToAdd() => this.ActionsToAdd != null && (this.ActionsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ActionsToRemove. The budget actions to remove from the
        /// budget.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<BudgetActionToRemove> ActionsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<BudgetActionToRemove>() : null;

        /// <summary>
        /// Checks to see if the ActionsToRemove property is set.
        /// </summary>
        internal bool IsSetActionsToRemove() => this.ActionsToRemove != null && (this.ActionsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApproximateDollarLimit. The dollar limit to update on the
        /// budget. Based on consumed usage.
        /// </summary>
        public float? ApproximateDollarLimit { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateDollarLimit property is set.
        /// </summary>
        internal bool IsSetApproximateDollarLimit() => this.ApproximateDollarLimit.HasValue;

        /// <summary>
        /// Gets and sets the property BudgetId. The budget ID to update.
        /// </summary>
        [AWSProperty(Required = true)]
        public string BudgetId { get; set; }

        /// <summary>
        /// Checks to see if the BudgetId property is set.
        /// </summary>
        internal bool IsSetBudgetId() => this.BudgetId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. The unique token which the server uses to
        /// recognize retries of the same request.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        [AWSProperty(Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the budget to update.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property Schedule. The schedule to update.
        /// </summary>
        public BudgetSchedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

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
        public BudgetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
