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
    /// This is the response object from the DescribeBudgetPerformanceHistory operation.
    /// </summary>
    public partial class DescribeBudgetPerformanceHistoryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BudgetPerformanceHistory. 
        /// <para>
        /// The history of how often the budget has gone into an <c>ALARM</c> state.
        /// </para>
        ///  
        /// <para>
        /// For <c>DAILY</c> budgets, the history saves the state of the budget for the last 60
        /// days. For <c>MONTHLY</c> budgets, the history saves the state of the budget for the
        /// current month plus the last 12 months. For <c>QUARTERLY</c> budgets, the history saves
        /// the state of the budget for the last four quarters.
        /// </para>
        /// </summary>
        public BudgetPerformanceHistory BudgetPerformanceHistory { get; set; }

        /// <summary>
        /// Checks to see if the BudgetPerformanceHistory property is set.
        /// </summary>
        internal bool IsSetBudgetPerformanceHistory() => this.BudgetPerformanceHistory != null;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
