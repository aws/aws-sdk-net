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
    /// The parameters that define or describe the historical data that your auto-adjusting
    /// budget is based on.
    /// </summary>
    public partial class HistoricalOptions
    {
        private int? _budgetAdjustmentPeriod;
        private int? _lookBackAvailablePeriods;

        /// <summary>
        /// Gets and sets the property BudgetAdjustmentPeriod. 
        /// <para>
        /// The number of budget periods included in the moving-average calculation that determines
        /// your auto-adjusted budget amount. The maximum value depends on the <c>TimeUnit</c>
        /// granularity of the budget:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <c>DAILY</c> granularity, the maximum value is <c>60</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>MONTHLY</c> granularity, the maximum value is <c>12</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>QUARTERLY</c> granularity, the maximum value is <c>4</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>ANNUALLY</c> granularity, the maximum value is <c>1</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public int? BudgetAdjustmentPeriod
        {
            get { return this._budgetAdjustmentPeriod; }
            set { this._budgetAdjustmentPeriod = value; }
        }

        // Check to see if BudgetAdjustmentPeriod property is set
        internal bool IsSetBudgetAdjustmentPeriod()
        {
            return this._budgetAdjustmentPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LookBackAvailablePeriods. 
        /// <para>
        /// The integer that describes how many budget periods in your <c>BudgetAdjustmentPeriod</c>
        /// are included in the calculation of your current <c>BudgetLimit</c>. If the first budget
        /// period in your <c>BudgetAdjustmentPeriod</c> has no cost data, then that budget period
        /// isn’t included in the average that determines your budget limit. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you set <c>BudgetAdjustmentPeriod</c> as <c>4</c> quarters, but your
        /// account had no cost data in the first quarter, then only the last three quarters are
        /// included in the calculation. In this scenario, <c>LookBackAvailablePeriods</c> returns
        /// <c>3</c>. 
        /// </para>
        ///  
        /// <para>
        /// You can’t set your own <c>LookBackAvailablePeriods</c>. The value is automatically
        /// calculated from the <c>BudgetAdjustmentPeriod</c> and your historical cost data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public int? LookBackAvailablePeriods
        {
            get { return this._lookBackAvailablePeriods; }
            set { this._lookBackAvailablePeriods = value; }
        }

        // Check to see if LookBackAvailablePeriods property is set
        internal bool IsSetLookBackAvailablePeriods()
        {
            return this._lookBackAvailablePeriods.HasValue; 
        }

    }
}