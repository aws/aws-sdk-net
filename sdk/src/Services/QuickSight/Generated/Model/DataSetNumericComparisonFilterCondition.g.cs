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
    /// A filter condition that compares numeric values using operators like <c>EQUALS</c>,
    /// <c>GREATER_THAN</c>, or <c>LESS_THAN</c>.
    /// </summary>
    public partial class DataSetNumericComparisonFilterCondition
    {
        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The comparison operator to use, such as <c>EQUALS</c>, <c>GREATER_THAN</c>, <c>LESS_THAN</c>,
        /// or their variants.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSetNumericComparisonFilterOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The numeric value to compare against.
        /// </para>
        /// </summary>
        public DataSetNumericFilterValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
