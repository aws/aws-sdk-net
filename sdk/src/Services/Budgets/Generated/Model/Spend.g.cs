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
    /// The amount of cost or usage that's measured for a budget.
    /// 
    ///  
    /// <para>
    ///  <i>Cost example:</i> A <c>Spend</c> for <c>3 USD</c> of costs has the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An <c>Amount</c> of <c>3</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>Unit</c> of <c>USD</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Usage example:</i> A <c>Spend</c> for <c>3 GB</c> of S3 usage has the following
    /// parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An <c>Amount</c> of <c>3</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>Unit</c> of <c>GB</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Spend
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The cost or usage amount that's associated with a budget forecast, actual spend, or
        /// budget threshold.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2147483647)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount.HasValue;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement that's used for the budget forecast, actual spend, or budget
        /// threshold.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2147483647)]
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
