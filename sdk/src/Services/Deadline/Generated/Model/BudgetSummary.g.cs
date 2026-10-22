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
    /// The budget summary.
    /// </summary>
    public partial class BudgetSummary
    {
        /// <summary>
        /// Gets and sets the property ApproximateDollarLimit. 
        /// <para>
        /// The approximate dollar limit of the budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public float? ApproximateDollarLimit { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateDollarLimit property is set.
        /// </summary>
        internal bool IsSetApproximateDollarLimit() => this.ApproximateDollarLimit.HasValue;

        /// <summary>
        /// Gets and sets the property BudgetId. 
        /// <para>
        /// The budget ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BudgetId { get; set; }

        /// <summary>
        /// Checks to see if the BudgetId property is set.
        /// </summary>
        internal bool IsSetBudgetId() => this.BudgetId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user or system that created this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the budget summary.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [Obsolete("ListBudgets no longer supports description. Use GetBudget if description is needed.")]
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the budget summary to update.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the budget.
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
        [AWSProperty(Required = true)]
        public BudgetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the resource was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user or system that updated this resource.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;

        /// <summary>
        /// Gets and sets the property UsageTrackingResource. 
        /// <para>
        /// The resource used to track expenditure in the budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UsageTrackingResource UsageTrackingResource { get; set; }

        /// <summary>
        /// Checks to see if the UsageTrackingResource property is set.
        /// </summary>
        internal bool IsSetUsageTrackingResource() => this.UsageTrackingResource != null;

        /// <summary>
        /// Gets and sets the property Usages. 
        /// <para>
        /// The consumed usage for the budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConsumedUsages Usages { get; set; }

        /// <summary>
        /// Checks to see if the Usages property is set.
        /// </summary>
        internal bool IsSetUsages() => this.Usages != null;
    }
}
