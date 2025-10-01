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
    /// Controls and tracks usage limits for associated configured tables within a collaboration
    /// across queries and job. Supports both period-based budgets that can renew (daily,
    /// weekly, or monthly) and fixed lifetime budgets. Contains the resource ARN, remaining
    /// budget information, and up to two budget configurations (period-based and lifetime).
    /// By default, table usage is unlimited unless a budget is configured.
    /// </summary>
    public partial class AccessBudget
    {
        private int? _aggregateRemainingBudget;
        private List<AccessBudgetDetails> _details = AWSConfigs.InitializeCollections ? new List<AccessBudgetDetails>() : null;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property AggregateRemainingBudget. 
        /// <para>
        /// The total remaining budget across all budget parameters, showing the lower value between
        /// the per-period budget and lifetime budget for this access budget. For individual parameter
        /// budgets, see <c>remainingBudget</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int AggregateRemainingBudget
        {
            get { return this._aggregateRemainingBudget.GetValueOrDefault(); }
            set { this._aggregateRemainingBudget = value; }
        }

        // Check to see if AggregateRemainingBudget property is set
        internal bool IsSetAggregateRemainingBudget()
        {
            return this._aggregateRemainingBudget.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Detailed budget information including time bounds, remaining budget, and refresh settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<AccessBudgetDetails> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && (this._details.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the access budget resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}