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
    /// Individual budget parameter configuration that defines specific budget allocation
    /// settings for access budgets.
    /// </summary>
    public partial class BudgetParameter
    {
        private AutoRefreshMode _autoRefresh;
        private int? _budget;
        private AccessBudgetType _type;

        /// <summary>
        /// Gets and sets the property AutoRefresh. 
        /// <para>
        /// Whether this individual budget parameter automatically refreshes when the budget period
        /// resets.
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
        /// The budget allocation amount for this specific parameter.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of budget parameter being configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessBudgetType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}