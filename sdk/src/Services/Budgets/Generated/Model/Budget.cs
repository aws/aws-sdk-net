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
    /// Represents the output of the <c>CreateBudget</c> operation. The content consists of
    /// the detailed metadata and data file information, and the current status of the <c>budget</c>
    /// object.
    /// 
    ///  
    /// <para>
    /// This is the Amazon Resource Name (ARN) pattern for a budget: 
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:aws:budgets::AccountId:budget/budgetName</c> 
    /// </para>
    /// </summary>
    public partial class Budget
    {
        private AutoAdjustData _autoAdjustData;
        private string _billingViewArn;
        private Spend _budgetLimit;
        private string _budgetName;
        private BudgetType _budgetType;
        private CalculatedSpend _calculatedSpend;
        private Dictionary<string, List<string>> _costFilters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private CostTypes _costTypes;
        private Expression _filterExpression;
        private HealthStatus _healthStatus;
        private DateTime? _lastUpdatedTime;
        private List<string> _metrics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, Spend> _plannedBudgetLimits = AWSConfigs.InitializeCollections ? new Dictionary<string, Spend>() : null;
        private TimePeriod _timePeriod;
        private TimeUnit _timeUnit;

        /// <summary>
        /// Gets and sets the property AutoAdjustData. 
        /// <para>
        /// The parameters that determine the budget amount for an auto-adjusting budget.
        /// </para>
        /// </summary>
        public AutoAdjustData AutoAdjustData
        {
            get { return this._autoAdjustData; }
            set { this._autoAdjustData = value; }
        }

        // Check to see if AutoAdjustData property is set
        internal bool IsSetAutoAdjustData()
        {
            return this._autoAdjustData != null;
        }

        /// <summary>
        /// Gets and sets the property BillingViewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies a specific billing view. The
        /// ARN is used to specify which particular billing view you want to interact with or
        /// retrieve information from when making API calls related to Amazon Web Services Billing
        /// and Cost Management features. The BillingViewArn can be retrieved by calling the ListBillingViews
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string BillingViewArn
        {
            get { return this._billingViewArn; }
            set { this._billingViewArn = value; }
        }

        // Check to see if BillingViewArn property is set
        internal bool IsSetBillingViewArn()
        {
            return this._billingViewArn != null;
        }

        /// <summary>
        /// Gets and sets the property BudgetLimit. 
        /// <para>
        /// The total amount of cost, usage, RI utilization, RI coverage, Savings Plans utilization,
        /// or Savings Plans coverage that you want to track with your budget.
        /// </para>
        ///  
        /// <para>
        ///  <c>BudgetLimit</c> is required for cost or usage budgets, but optional for RI or
        /// Savings Plans utilization or coverage budgets. RI and Savings Plans utilization or
        /// coverage budgets default to <c>100</c>. This is the only valid value for RI or Savings
        /// Plans utilization or coverage budgets. You can't use <c>BudgetLimit</c> with <c>PlannedBudgetLimits</c>
        /// for <c>CreateBudget</c> and <c>UpdateBudget</c> actions. 
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
        /// The name of a budget. The name must be unique within an account. The <c>:</c> and
        /// <c>\</c> characters, and the "/action/" substring, aren't allowed in <c>BudgetName</c>.
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
        /// Specifies whether this budget tracks costs, usage, RI utilization, RI coverage, Savings
        /// Plans utilization, or Savings Plans coverage.
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
        /// The cost filters, such as <c>Region</c>, <c>Service</c>, <c>LinkedAccount</c>, <c>Tag</c>,
        /// or <c>CostCategory</c>, that are applied to a budget.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Budgets supports the following services as a <c>Service</c> filter
        /// for RI budgets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon EC2
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
        /// Amazon OpenSearch Service
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("CostFilters lack support for newer dimensions and filtering options. Please consider using the new 'FilterExpression' field.")]
        public Dictionary<string, List<string>> CostFilters
        {
            get { return this._costFilters; }
            set { this._costFilters = value; }
        }

        // Check to see if CostFilters property is set
        internal bool IsSetCostFilters()
        {
            return this._costFilters != null && (this._costFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CostTypes. 
        /// <para>
        /// The types of costs that are included in this <c>COST</c> budget.
        /// </para>
        ///  
        /// <para>
        ///  <c>USAGE</c>, <c>RI_UTILIZATION</c>, <c>RI_COVERAGE</c>, <c>SAVINGS_PLANS_UTILIZATION</c>,
        /// and <c>SAVINGS_PLANS_COVERAGE</c> budgets do not have <c>CostTypes</c>.
        /// </para>
        /// </summary>
        [Obsolete("CostTypes lack support for newer record type dimensions and filtering options. Please consider using the new 'Metrics' field.")]
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
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// The filtering dimensions for the budget and their corresponding values.
        /// </para>
        /// </summary>
        public Expression FilterExpression
        {
            get { return this._filterExpression; }
            set { this._filterExpression = value; }
        }

        // Check to see if FilterExpression property is set
        internal bool IsSetFilterExpression()
        {
            return this._filterExpression != null;
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The current operational state of a Billing View derived resource.
        /// </para>
        /// </summary>
        public HealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that you updated this budget.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The definition for how the budget data is aggregated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlannedBudgetLimits. 
        /// <para>
        /// A map containing multiple <c>BudgetLimit</c>, including current or future limits.
        /// </para>
        ///  
        /// <para>
        ///  <c>PlannedBudgetLimits</c> is available for cost or usage budget and supports both
        /// monthly and quarterly <c>TimeUnit</c>. 
        /// </para>
        ///  
        /// <para>
        /// For monthly budgets, provide 12 months of <c>PlannedBudgetLimits</c> values. This
        /// must start from the current month and include the next 11 months. The <c>key</c> is
        /// the start of the month, <c>UTC</c> in epoch seconds. 
        /// </para>
        ///  
        /// <para>
        /// For quarterly budgets, provide four quarters of <c>PlannedBudgetLimits</c> value entries
        /// in standard calendar quarter increments. This must start from the current quarter
        /// and include the next three quarters. The <c>key</c> is the start of the quarter, <c>UTC</c>
        /// in epoch seconds. 
        /// </para>
        ///  
        /// <para>
        /// If the planned budget expires before 12 months for monthly or four quarters for quarterly,
        /// provide the <c>PlannedBudgetLimits</c> values only for the remaining periods.
        /// </para>
        ///  
        /// <para>
        /// If the budget begins at a date in the future, provide <c>PlannedBudgetLimits</c> values
        /// from the start date of the budget. 
        /// </para>
        ///  
        /// <para>
        /// After all of the <c>BudgetLimit</c> values in <c>PlannedBudgetLimits</c> are used,
        /// the budget continues to use the last limit as the <c>BudgetLimit</c>. At that point,
        /// the planned budget provides the same experience as a fixed budget. 
        /// </para>
        ///  
        /// <para>
        ///  <c>DescribeBudget</c> and <c>DescribeBudgets</c> response along with <c>PlannedBudgetLimits</c>
        /// also contain <c>BudgetLimit</c> representing the current month or quarter limit present
        /// in <c>PlannedBudgetLimits</c>. This only applies to budgets that are created with
        /// <c>PlannedBudgetLimits</c>. Budgets that are created without <c>PlannedBudgetLimits</c>
        /// only contain <c>BudgetLimit</c>. They don't contain <c>PlannedBudgetLimits</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Spend> PlannedBudgetLimits
        {
            get { return this._plannedBudgetLimits; }
            set { this._plannedBudgetLimits = value; }
        }

        // Check to see if PlannedBudgetLimits property is set
        internal bool IsSetPlannedBudgetLimits()
        {
            return this._plannedBudgetLimits != null && (this._plannedBudgetLimits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The period of time that's covered by a budget. You set the start date and end date.
        /// The start date must come before the end date. The end date must come before <c>06/15/87
        /// 00:00 UTC</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you create your budget and don't specify a start date, Amazon Web Services defaults
        /// to the start of your chosen time period (DAILY, MONTHLY, QUARTERLY, ANNUALLY, or CUSTOM).
        /// For example, if you created your budget on January 24, 2018, chose <c>DAILY</c>, and
        /// didn't set a start date, Amazon Web Services set your start date to <c>01/24/18 00:00
        /// UTC</c>. If you chose <c>MONTHLY</c>, Amazon Web Services set your start date to <c>01/01/18
        /// 00:00 UTC</c>. If you didn't specify an end date, Amazon Web Services set your end
        /// date to <c>06/15/87 00:00 UTC</c>. The defaults are the same for the Billing and Cost
        /// Management console and the API. 
        /// </para>
        ///  
        /// <para>
        /// You can change either date with the <c>UpdateBudget</c> operation.
        /// </para>
        ///  
        /// <para>
        /// After the end date, Amazon Web Services deletes the budget and all the associated
        /// notifications and subscribers.
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