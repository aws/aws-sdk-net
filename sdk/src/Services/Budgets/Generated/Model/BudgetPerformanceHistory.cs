/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// A history of the state of a budget at the end of the budget's specified time period.
    /// </summary>
    public partial class BudgetPerformanceHistory
    {
        private List<BudgetedAndActualAmounts> _budgetedAndActualAmountsList = new List<BudgetedAndActualAmounts>();
        private string _budgetName;
        private BudgetType _budgetType;
        private Dictionary<string, List<string>> _costFilters = new Dictionary<string, List<string>>();
        private CostTypes _costTypes;
        private TimeUnit _timeUnit;

        /// <summary>
        /// Gets and sets the property BudgetedAndActualAmountsList. 
        /// <para>
        /// A list of amounts of cost or usage that you created budgets for, compared to your
        /// actual costs or usage.
        /// </para>
        /// </summary>
        public List<BudgetedAndActualAmounts> BudgetedAndActualAmountsList
        {
            get { return this._budgetedAndActualAmountsList; }
            set { this._budgetedAndActualAmountsList = value; }
        }

        // Check to see if BudgetedAndActualAmountsList property is set
        internal bool IsSetBudgetedAndActualAmountsList()
        {
            return this._budgetedAndActualAmountsList != null && this._budgetedAndActualAmountsList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BudgetName.
        /// </summary>
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
        /// </summary>
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
        /// Gets and sets the property CostFilters. 
        /// <para>
        /// The history of the cost filters for a budget during the specified time period.
        /// </para>
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
        /// The history of the cost types for a budget during the specified time period.
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
        /// Gets and sets the property TimeUnit.
        /// </summary>
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