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
        /// your auto-adjusted budget amount. The maximum value depends on the <code>TimeUnit</code>
        /// granularity of the budget:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <code>DAILY</code> granularity, the maximum value is <code>60</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>MONTHLY</code> granularity, the maximum value is <code>12</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>QUARTERLY</code> granularity, the maximum value is <code>4</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>ANNUALLY</code> granularity, the maximum value is <code>1</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public int BudgetAdjustmentPeriod
        {
            get { return this._budgetAdjustmentPeriod.GetValueOrDefault(); }
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
        /// The integer that describes how many budget periods in your <code>BudgetAdjustmentPeriod</code>
        /// are included in the calculation of your current <code>BudgetLimit</code>. If the first
        /// budget period in your <code>BudgetAdjustmentPeriod</code> has no cost data, then that
        /// budget period isn’t included in the average that determines your budget limit. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you set <code>BudgetAdjustmentPeriod</code> as <code>4</code> quarters,
        /// but your account had no cost data in the first quarter, then only the last three quarters
        /// are included in the calculation. In this scenario, <code>LookBackAvailablePeriods</code>
        /// returns <code>3</code>. 
        /// </para>
        ///  
        /// <para>
        /// You can’t set your own <code>LookBackAvailablePeriods</code>. The value is automatically
        /// calculated from the <code>BudgetAdjustmentPeriod</code> and your historical cost data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public int LookBackAvailablePeriods
        {
            get { return this._lookBackAvailablePeriods.GetValueOrDefault(); }
            set { this._lookBackAvailablePeriods = value; }
        }

        // Check to see if LookBackAvailablePeriods property is set
        internal bool IsSetLookBackAvailablePeriods()
        {
            return this._lookBackAvailablePeriods.HasValue; 
        }

    }
}