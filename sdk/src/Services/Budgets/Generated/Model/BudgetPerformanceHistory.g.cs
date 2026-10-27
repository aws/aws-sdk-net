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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        [AWSProperty(Min = 20, Max = 2048)]
        public string BillingViewArn { get; set; }

        /// <summary>
        /// Checks to see if the BillingViewArn property is set.
        /// </summary>
        internal bool IsSetBillingViewArn() => this.BillingViewArn != null;

        /// <summary>
        /// Gets and sets the property BudgetName.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string BudgetName { get; set; }

        /// <summary>
        /// Checks to see if the BudgetName property is set.
        /// </summary>
        internal bool IsSetBudgetName() => this.BudgetName != null;

        /// <summary>
        /// Gets and sets the property BudgetType.
        /// </summary>
        public BudgetType BudgetType { get; set; }

        /// <summary>
        /// Checks to see if the BudgetType property is set.
        /// </summary>
        internal bool IsSetBudgetType() => this.BudgetType != null;

        /// <summary>
        /// Gets and sets the property BudgetedAndActualAmountsList. 
        /// <para>
        /// A list of amounts of cost or usage that you created budgets for, which are compared
        /// to your actual costs or usage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BudgetedAndActualAmounts> BudgetedAndActualAmountsList { get; set; } = AWSConfigs.InitializeCollections ? new List<BudgetedAndActualAmounts>() : null;

        /// <summary>
        /// Checks to see if the BudgetedAndActualAmountsList property is set.
        /// </summary>
        internal bool IsSetBudgetedAndActualAmountsList() => this.BudgetedAndActualAmountsList != null && (this.BudgetedAndActualAmountsList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CostFilters. 
        /// <para>
        /// The history of the cost filters for a budget during the specified time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> CostFilters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the CostFilters property is set.
        /// </summary>
        internal bool IsSetCostFilters() => this.CostFilters != null && (this.CostFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CostTypes. 
        /// <para>
        /// The history of the cost types for a budget during the specified time period.
        /// </para>
        /// </summary>
        public CostTypes CostTypes { get; set; }

        /// <summary>
        /// Checks to see if the CostTypes property is set.
        /// </summary>
        internal bool IsSetCostTypes() => this.CostTypes != null;

        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// The filtering dimensions for the budget and their corresponding values.
        /// </para>
        /// </summary>
        public Expression FilterExpression { get; set; }

        /// <summary>
        /// Checks to see if the FilterExpression property is set.
        /// </summary>
        internal bool IsSetFilterExpression() => this.FilterExpression != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The definition for how the budget data is aggregated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeUnit.
        /// </summary>
        public TimeUnit TimeUnit { get; set; }

        /// <summary>
        /// Checks to see if the TimeUnit property is set.
        /// </summary>
        internal bool IsSetTimeUnit() => this.TimeUnit != null;
    }
}
