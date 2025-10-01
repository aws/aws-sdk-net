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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Detailed information about an access budget including time bounds, budget allocation,
    /// and configuration settings.
    /// </summary>
    public partial class AccessBudgetDetails
    {
        private AutoRefreshMode _autoRefresh;
        private int? _budget;
        private AccessBudgetType _budgetType;
        private DateTime? _endTime;
        private int? _remainingBudget;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AutoRefresh. 
        /// <para>
        /// Indicates whether the budget automatically refreshes for each time period specified
        /// in <c>budgetType</c>. Valid values are:
        /// </para>
        ///  
        /// <para>
        ///  <c>ENABLED</c> - The budget refreshes automatically at the start of each period.
        /// </para>
        ///  
        /// <para>
        ///  <c>DISABLED</c> - The budget must be refreshed manually.
        /// </para>
        ///  
        /// <para>
        ///  <c>NULL</c> - The value is null when <c>budgetType</c> is set to <c>LIFETIME</c>.
        /// </para>
        /// </summary>
        public AutoRefreshMode AutoRefresh
        {
            get { return this._autoRefresh; }
            set { this._autoRefresh = value; }
        }

        // Check to see if AutoRefresh property is set
        internal bool IsSetAutoRefresh()
        {
            return this._autoRefresh != null;
        }

        /// <summary>
        /// Gets and sets the property Budget. 
        /// <para>
        /// The total budget allocation amount for this access budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000000)]
        public int Budget
        {
            get { return this._budget.GetValueOrDefault(); }
            set { this._budget = value; }
        }

        // Check to see if Budget property is set
        internal bool IsSetBudget()
        {
            return this._budget.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BudgetType. 
        /// <para>
        /// Specifies the time period for limiting table usage in queries and jobs. For calendar-based
        /// periods, the budget can renew if auto refresh is enabled. For lifetime budgets, the
        /// limit applies to the total usage throughout the collaboration. Valid values are:
        /// </para>
        ///  
        /// <para>
        ///  <c>CALENDAR_DAY</c> - Limit table usage per day.
        /// </para>
        ///  
        /// <para>
        ///  <c>CALENDAR_WEEK</c> - Limit table usage per week.
        /// </para>
        ///  
        /// <para>
        ///  <c>CALENDAR_MONTH</c> - Limit table usage per month.
        /// </para>
        ///  
        /// <para>
        ///  <c>LIFETIME</c> - Limit total table usage for the collaboration duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessBudgetType BudgetType
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time for the access budget period.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemainingBudget. 
        /// <para>
        /// The remaining budget amount available for use within this access budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int RemainingBudget
        {
            get { return this._remainingBudget.GetValueOrDefault(); }
            set { this._remainingBudget = value; }
        }

        // Check to see if RemainingBudget property is set
        internal bool IsSetRemainingBudget()
        {
            return this._remainingBudget.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time for the access budget period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}