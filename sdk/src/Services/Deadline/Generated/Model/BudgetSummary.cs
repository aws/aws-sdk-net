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
    /// The budget summary.
    /// </summary>
    public partial class BudgetSummary
    {
        private float? _approximateDollarLimit;
        private string _budgetId;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _displayName;
        private BudgetStatus _status;
        private DateTime? _updatedAt;
        private string _updatedBy;
        private ConsumedUsages _usages;
        private UsageTrackingResource _usageTrackingResource;

        /// <summary>
        /// Gets and sets the property ApproximateDollarLimit. 
        /// <para>
        /// The approximate dollar limit of the budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The budget ID.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user or system that created this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

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
        /// The display name of the budget summary to update.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the resource was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user or system that updated this resource.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Usages. 
        /// <para>
        /// The consumed usage for the budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConsumedUsages Usages
        {
            get { return this._usages; }
            set { this._usages = value; }
        }

        // Check to see if Usages property is set
        internal bool IsSetUsages()
        {
            return this._usages != null;
        }

        /// <summary>
        /// Gets and sets the property UsageTrackingResource. 
        /// <para>
        /// The resource used to track expenditure in the budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UsageTrackingResource UsageTrackingResource
        {
            get { return this._usageTrackingResource; }
            set { this._usageTrackingResource = value; }
        }

        // Check to see if UsageTrackingResource property is set
        internal bool IsSetUsageTrackingResource()
        {
            return this._usageTrackingResource != null;
        }

    }
}