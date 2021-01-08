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
    /// Represents the output of the <code>CreateBudget</code> operation. The content consists
    /// of the detailed metadata and data file information, and the current status of the
    /// <code>budget</code> object.
    /// 
    ///  
    /// <para>
    /// This is the ARN pattern for a budget: 
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:aws:budgets::AccountId:budget/budgetName</code> 
    /// </para>
    /// </summary>
    public partial class Budget
    {
        private Spend _budgetLimit;
        private string _budgetName;
        private BudgetType _budgetType;
        private CalculatedSpend _calculatedSpend;
        private Dictionary<string, List<string>> _costFilters = new Dictionary<string, List<string>>();
        private CostTypes _costTypes;
        private DateTime? _lastUpdatedTime;
        private Dictionary<string, Spend> _plannedBudgetLimits = new Dictionary<string, Spend>();
        private TimePeriod _timePeriod;
        private TimeUnit _timeUnit;

        /// <summary>
        /// Gets and sets the property BudgetLimit. 
        /// <para>
        /// The total amount of cost, usage, RI utilization, RI coverage, Savings Plans utilization,
        /// or Savings Plans coverage that you want to track with your budget.
        /// </para>
        ///  
        /// <para>
        ///  <code>BudgetLimit</code> is required for cost or usage budgets, but optional for
        /// RI or Savings Plans utilization or coverage budgets. RI and Savings Plans utilization
        /// or coverage budgets default to <code>100</code>, which is the only valid value for
        /// RI or Savings Plans utilization or coverage budgets. You can't use <code>BudgetLimit</code>
        /// with <code>PlannedBudgetLimits</code> for <code>CreateBudget</code> and <code>UpdateBudget</code>
        /// actions. 
        /// </para>
        /// </summary>
        public Spend BudgetLimit
        {
            get { return this._budgetLimit; }
            set { this._budgetLimit = value; }
        }

        // Check to see if BudgetLimit property is set
        internal bool IsSetBudgetLimit()
        {
            return this._budgetLimit != null;
        }

        /// <summary>
        /// Gets and sets the property BudgetName. 
        /// <para>
        /// The name of a budget. The name must be unique within an account. The <code>:</code>
        /// and <code>\</code> characters aren't allowed in <code>BudgetName</code>.
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
        /// Gets and sets the property BudgetType. 
        /// <para>
        /// Whether this budget tracks costs, usage, RI utilization, RI coverage, Savings Plans
        /// utilization, or Savings Plans coverage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BudgetType BudgetType
        {
            get { return this._budgetType; }
            set { this._budgetType = value; }
        }

        // Check to see if BudgetType property is set
        internal bool IsSetBudgetType()
        {
            return this._budgetType != null;
        }

        /// <summary>
        /// Gets and sets the property CalculatedSpend. 
        /// <para>
        /// The actual and forecasted cost or usage that the budget tracks.
        /// </para>
        /// </summary>
        public CalculatedSpend CalculatedSpend
        {
            get { return this._calculatedSpend; }
            set { this._calculatedSpend = value; }
        }

        // Check to see if CalculatedSpend property is set
        internal bool IsSetCalculatedSpend()
        {
            return this._calculatedSpend != null;
        }

        /// <summary>
        /// Gets and sets the property CostFilters. 
        /// <para>
        /// The cost filters, such as service or tag, that are applied to a budget.
        /// </para>
        ///  
        /// <para>
        /// AWS Budgets supports the following services as a filter for RI budgets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Elastic Compute Cloud - Compute
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Redshift
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Relational Database Service
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ElastiCache
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Elasticsearch Service
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, List<string>> CostFilters
        {
            get { return this._costFilters; }
            set { this._costFilters = value; }
        }

        // Check to see if CostFilters property is set
        internal bool IsSetCostFilters()
        {
            return this._costFilters != null && this._costFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CostTypes. 
        /// <para>
        /// The types of costs that are included in this <code>COST</code> budget.
        /// </para>
        ///  
        /// <para>
        ///  <code>USAGE</code>, <code>RI_UTILIZATION</code>, <code>RI_COVERAGE</code>, <code>SAVINGS_PLANS_UTILIZATION</code>,
        /// and <code>SAVINGS_PLANS_COVERAGE</code> budgets do not have <code>CostTypes</code>.
        /// </para>
        /// </summary>
        public CostTypes CostTypes
        {
            get { return this._costTypes; }
            set { this._costTypes = value; }
        }

        // Check to see if CostTypes property is set
        internal bool IsSetCostTypes()
        {
            return this._costTypes != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that you updated this budget.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlannedBudgetLimits. 
        /// <para>
        /// A map containing multiple <code>BudgetLimit</code>, including current or future limits.
        /// </para>
        ///  
        /// <para>
        ///  <code>PlannedBudgetLimits</code> is available for cost or usage budget and supports
        /// monthly and quarterly <code>TimeUnit</code>. 
        /// </para>
        ///  
        /// <para>
        /// For monthly budgets, provide 12 months of <code>PlannedBudgetLimits</code> values.
        /// This must start from the current month and include the next 11 months. The <code>key</code>
        /// is the start of the month, <code>UTC</code> in epoch seconds. 
        /// </para>
        ///  
        /// <para>
        /// For quarterly budgets, provide 4 quarters of <code>PlannedBudgetLimits</code> value
        /// entries in standard calendar quarter increments. This must start from the current
        /// quarter and include the next 3 quarters. The <code>key</code> is the start of the
        /// quarter, <code>UTC</code> in epoch seconds. 
        /// </para>
        ///  
        /// <para>
        /// If the planned budget expires before 12 months for monthly or 4 quarters for quarterly,
        /// provide the <code>PlannedBudgetLimits</code> values only for the remaining periods.
        /// </para>
        ///  
        /// <para>
        /// If the budget begins at a date in the future, provide <code>PlannedBudgetLimits</code>
        /// values from the start date of the budget. 
        /// </para>
        ///  
        /// <para>
        /// After all of the <code>BudgetLimit</code> values in <code>PlannedBudgetLimits</code>
        /// are used, the budget continues to use the last limit as the <code>BudgetLimit</code>.
        /// At that point, the planned budget provides the same experience as a fixed budget.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>DescribeBudget</code> and <code>DescribeBudgets</code> response along with
        /// <code>PlannedBudgetLimits</code> will also contain <code>BudgetLimit</code> representing
        /// the current month or quarter limit present in <code>PlannedBudgetLimits</code>. This
        /// only applies to budgets created with <code>PlannedBudgetLimits</code>. Budgets created
        /// without <code>PlannedBudgetLimits</code> will only contain <code>BudgetLimit</code>,
        /// and no <code>PlannedBudgetLimits</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, Spend> PlannedBudgetLimits
        {
            get { return this._plannedBudgetLimits; }
            set { this._plannedBudgetLimits = value; }
        }

        // Check to see if PlannedBudgetLimits property is set
        internal bool IsSetPlannedBudgetLimits()
        {
            return this._plannedBudgetLimits != null && this._plannedBudgetLimits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The period of time that is covered by a budget. The period has a start date and an
        /// end date. The start date must come before the end date. The end date must come before
        /// <code>06/15/87 00:00 UTC</code>. 
        /// </para>
        ///  
        /// <para>
        /// If you create your budget and don't specify a start date, AWS defaults to the start
        /// of your chosen time period (DAILY, MONTHLY, QUARTERLY, or ANNUALLY). For example,
        /// if you created your budget on January 24, 2018, chose <code>DAILY</code>, and didn't
        /// set a start date, AWS set your start date to <code>01/24/18 00:00 UTC</code>. If you
        /// chose <code>MONTHLY</code>, AWS set your start date to <code>01/01/18 00:00 UTC</code>.
        /// If you didn't specify an end date, AWS set your end date to <code>06/15/87 00:00 UTC</code>.
        /// The defaults are the same for the AWS Billing and Cost Management console and the
        /// API. 
        /// </para>
        ///  
        /// <para>
        /// You can change either date with the <code>UpdateBudget</code> operation.
        /// </para>
        ///  
        /// <para>
        /// After the end date, AWS deletes the budget and all associated notifications and subscribers.
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

        /// <summary>
        /// Gets and sets the property TimeUnit. 
        /// <para>
        /// The length of time until a budget resets the actual and forecasted spend.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeUnit TimeUnit
        {
            get { return this._timeUnit; }
            set { this._timeUnit = value; }
        }

        // Check to see if TimeUnit property is set
        internal bool IsSetTimeUnit()
        {
            return this._timeUnit != null;
        }

    }
}