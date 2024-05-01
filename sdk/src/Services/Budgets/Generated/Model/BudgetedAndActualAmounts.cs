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
    /// The amount of cost or usage that you created the budget for, compared to your actual
    /// costs or usage.
    /// </summary>
    public partial class BudgetedAndActualAmounts
    {
        private Spend _actualAmount;
        private Spend _budgetedAmount;
        private TimePeriod _timePeriod;

        /// <summary>
        /// Gets and sets the property ActualAmount. 
        /// <para>
        /// Your actual costs or usage for a budget period.
        /// </para>
        /// </summary>
        public Spend ActualAmount
        {
            get { return this._actualAmount; }
            set { this._actualAmount = value; }
        }

        // Check to see if ActualAmount property is set
        internal bool IsSetActualAmount()
        {
            return this._actualAmount != null;
        }

        /// <summary>
        /// Gets and sets the property BudgetedAmount. 
        /// <para>
        /// The amount of cost or usage that you created the budget for.
        /// </para>
        /// </summary>
        public Spend BudgetedAmount
        {
            get { return this._budgetedAmount; }
            set { this._budgetedAmount = value; }
        }

        // Check to see if BudgetedAmount property is set
        internal bool IsSetBudgetedAmount()
        {
            return this._budgetedAmount != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period that's covered by this budget comparison.
        /// </para>
        /// </summary>
        public TimePeriod TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}