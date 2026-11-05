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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// A leaf node condition which can be used to specify a numeric condition.
    /// 
    ///  <note> 
    /// <para>
    /// The currently supported value for <c>FieldName</c> is <c>limit</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class NumberCondition
    {
        /// <summary>
        /// Gets and sets the property ComparisonType. 
        /// <para>
        /// The type of comparison to be made when evaluating the number condition.
        /// </para>
        /// </summary>
        public NumberComparisonType ComparisonType { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonType property is set.
        /// </summary>
        internal bool IsSetComparisonType() => this.ComparisonType != null;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The name of the field in the number condition.
        /// </para>
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Checks to see if the FieldName property is set.
        /// </summary>
        internal bool IsSetFieldName() => this.FieldName != null;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maxValue to be used while evaluating the number condition.
        /// </para>
        /// </summary>
        public int? MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minValue to be used while evaluating the number condition.
        /// </para>
        /// </summary>
        public int? MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue.HasValue;
    }
}
