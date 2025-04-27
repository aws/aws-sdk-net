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
    /// Container for the parameters to the UpdateBudget operation.
    /// Updates a budget. You can change every part of a budget except for the <c>budgetName</c>
    /// and the <c>calculatedSpend</c>. When you modify a budget, the <c>calculatedSpend</c>
    /// drops to zero until Amazon Web Services has new usage data to use for forecasting.
    /// 
    ///  <important> 
    /// <para>
    /// Only one of <c>BudgetLimit</c> or <c>PlannedBudgetLimits</c> can be present in the
    /// syntax at one time. Use the syntax that matches your case. The Request Syntax section
    /// shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>, see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_UpdateBudget.html#API_UpdateBudget_Examples">Examples</a>
    /// section.
    /// </para>
    ///  
    /// <para>
    /// Similarly, only one set of filter and metric selections can be present in the syntax
    /// at one time. Either <c>FilterExpression</c> and <c>Metrics</c> or <c>CostFilters</c>
    /// and <c>CostTypes</c>, not both or a different combination. We recommend using <c>FilterExpression</c>
    /// and <c>Metrics</c> as they provide more flexible and powerful filtering capabilities.
    /// The Request Syntax section shows the <c>FilterExpression</c>/<c>Metrics</c> syntax.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateBudgetRequest : AmazonBudgetsRequest
    {
        private string _accountId;
        private Budget _newBudget;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>accountId</c> that is associated with the budget that you want to update.
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
        /// Gets and sets the property NewBudget. 
        /// <para>
        /// The budget that you want to update your budget to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Budget NewBudget
        {
            get { return this._newBudget; }
            set { this._newBudget = value; }
        }

        // Check to see if NewBudget property is set
        internal bool IsSetNewBudget()
        {
            return this._newBudget != null;
        }

    }
}