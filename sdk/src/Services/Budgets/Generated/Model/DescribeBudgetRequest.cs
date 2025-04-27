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
    /// Container for the parameters to the DescribeBudget operation.
    /// Describes a budget.
    /// 
    ///  <important> 
    /// <para>
    /// The Request Syntax section shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>,
    /// see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_DescribeBudget.html#API_DescribeBudget_Examples">Examples</a>
    /// section.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DescribeBudgetRequest : AmazonBudgetsRequest
    {
        private string _accountId;
        private string _budgetName;
        private bool? _showFilterExpression;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>accountId</c> that is associated with the budget that you want a description
        /// of.
        /// </para>
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
        /// Gets and sets the property BudgetName. 
        /// <para>
        /// The name of the budget that you want a description of.
        /// </para>
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
        /// Gets and sets the property ShowFilterExpression. 
        /// <para>
        /// Specifies whether the response includes the filter expression associated with the
        /// budget. By showing the filter expression, you can see detailed filtering logic applied
        /// to the budget, such as Amazon Web Services services or tags that are being tracked.
        /// </para>
        /// </summary>
        public bool? ShowFilterExpression
        {
            get { return this._showFilterExpression; }
            set { this._showFilterExpression = value; }
        }

        // Check to see if ShowFilterExpression property is set
        internal bool IsSetShowFilterExpression()
        {
            return this._showFilterExpression.HasValue; 
        }

    }
}