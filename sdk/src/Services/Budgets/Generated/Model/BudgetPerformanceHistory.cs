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
    /// A history of the state of a budget at the end of the budget's specified time period.
    /// </summary>
    public partial class BudgetPerformanceHistory
    {
        private string _billingViewArn;
        private List<BudgetedAndActualAmounts> _budgetedAndActualAmountsList = AWSConfigs.InitializeCollections ? new List<BudgetedAndActualAmounts>() : null;
        private string _budgetName;
        private BudgetType _budgetType;
        private Dictionary<string, List<string>> _costFilters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private CostTypes _costTypes;
        private TimeUnit _timeUnit;

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
        /// Gets and sets the property BudgetedAndActualAmountsList. 
        /// <para>
        /// A list of amounts of cost or usage that you created budgets for, which are compared
        /// to your actual costs or usage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BudgetedAndActualAmounts> BudgetedAndActualAmountsList
        {
            get { return this._budgetedAndActualAmountsList; }
            set { this._budgetedAndActualAmountsList = value; }
        }

        // Check to see if BudgetedAndActualAmountsList property is set
        internal bool IsSetBudgetedAndActualAmountsList()
        {
            return this._budgetedAndActualAmountsList != null && (this._budgetedAndActualAmountsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BudgetName.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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