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
    /// AWS Budget model
    /// </summary>
    public partial class Budget
    {
        private Spend _budgetLimit;
        private string _budgetName;
        private BudgetType _budgetType;
        private CalculatedSpend _calculatedSpend;
        private Dictionary<string, List<string>> _costFilters = new Dictionary<string, List<string>>();
        private CostTypes _costTypes;
        private TimePeriod _timePeriod;
        private TimeUnit _timeUnit;

        /// <summary>
        /// Gets and sets the property BudgetLimit.
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
        /// Gets and sets the property CalculatedSpend.
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
        /// Gets and sets the property TimePeriod.
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