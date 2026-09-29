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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A transform operation that filters rows based on a condition.
    /// </summary>
    public partial class FilterOperation
    {
        /// <summary>
        /// Gets and sets the property ConditionExpression. 
        /// <para>
        /// An expression that must evaluate to a Boolean value. Rows for which the expression
        /// evaluates to true are kept in the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string ConditionExpression { get; set; }

        /// <summary>
        /// Checks to see if the ConditionExpression property is set.
        /// </summary>
        internal bool IsSetConditionExpression() => this.ConditionExpression != null;

        /// <summary>
        /// Gets and sets the property DateFilterCondition. 
        /// <para>
        /// A date-based filter condition within a filter operation.
        /// </para>
        /// </summary>
        public DataSetDateFilterCondition DateFilterCondition { get; set; }

        /// <summary>
        /// Checks to see if the DateFilterCondition property is set.
        /// </summary>
        internal bool IsSetDateFilterCondition() => this.DateFilterCondition != null;

        /// <summary>
        /// Gets and sets the property NumericFilterCondition. 
        /// <para>
        /// A numeric-based filter condition within a filter operation.
        /// </para>
        /// </summary>
        public DataSetNumericFilterCondition NumericFilterCondition { get; set; }

        /// <summary>
        /// Checks to see if the NumericFilterCondition property is set.
        /// </summary>
        internal bool IsSetNumericFilterCondition() => this.NumericFilterCondition != null;

        /// <summary>
        /// Gets and sets the property StringFilterCondition. 
        /// <para>
        /// A string-based filter condition within a filter operation.
        /// </para>
        /// </summary>
        public DataSetStringFilterCondition StringFilterCondition { get; set; }

        /// <summary>
        /// Checks to see if the StringFilterCondition property is set.
        /// </summary>
        internal bool IsSetStringFilterCondition() => this.StringFilterCondition != null;
    }
}
