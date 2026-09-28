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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// The detailed information for a specific budget period, including time boundaries and
    /// budget amounts.
    /// </summary>
    public partial class AccessBudgetDetails
    {
        /// <summary>
        /// Gets and sets the property AutoRefresh. 
        /// <para>
        /// Specifies whether this budget automatically refreshes when the current period ends.
        /// </para>
        /// </summary>
        public AutoRefreshMode AutoRefresh { get; set; }

        /// <summary>
        /// Checks to see if the AutoRefresh property is set.
        /// </summary>
        internal bool IsSetAutoRefresh() => this.AutoRefresh != null;

        /// <summary>
        /// Gets and sets the property Budget. 
        /// <para>
        /// The total budget amount allocated for this period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? Budget { get; set; }

        /// <summary>
        /// Checks to see if the Budget property is set.
        /// </summary>
        internal bool IsSetBudget() => this.Budget.HasValue;

        /// <summary>
        /// Gets and sets the property BudgetType. 
        /// <para>
        /// The type of budget period. Calendar-based types reset automatically at regular intervals,
        /// while LIFETIME budgets never reset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessBudgetType BudgetType { get; set; }

        /// <summary>
        /// Checks to see if the BudgetType property is set.
        /// </summary>
        internal bool IsSetBudgetType() => this.BudgetType != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of this budget period. If not specified, the budget period continues
        /// indefinitely.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property RemainingBudget. 
        /// <para>
        /// The amount of budget remaining in this period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? RemainingBudget { get; set; }

        /// <summary>
        /// Checks to see if the RemainingBudget property is set.
        /// </summary>
        internal bool IsSetRemainingBudget() => this.RemainingBudget.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of this budget period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
