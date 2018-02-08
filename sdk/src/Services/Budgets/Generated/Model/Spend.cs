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
    /// The amount of cost or usage being measured for a budget.
    /// 
    ///  
    /// <para>
    /// For example, a <code>Spend</code> for <code>3 GB</code> of S3 usage would have the
    /// following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An <code>Amount</code> of <code>3</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>unit</code> of <code>GB</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Spend
    {
        private decimal? _amount;
        private string _unit;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The cost or usage amount associated with a budget forecast, actual spend, or budget
        /// threshold.
        /// </para>
        /// </summary>
        public decimal Amount
        {
            get { return this._amount.GetValueOrDefault(); }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement used for the budget forecast, actual spend, or budget threshold,
        /// such as dollars or GB.
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}