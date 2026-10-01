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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Boolean condition for a rule. In the Amazon Connect admin website, case rules are
    /// known as <i>case field conditions</i>. For more information about case field conditions,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
    /// case field conditions to a case template</a>.
    /// </summary>
    public partial class BooleanCondition
    {
        /// <summary>
        /// Gets and sets the property AndAll. 
        /// <para>
        /// Combines multiple conditions with AND operator. All conditions must be true for the
        /// compound condition to be true.
        /// </para>
        /// </summary>
        public CompoundCondition AndAll { get; set; }

        /// <summary>
        /// Checks to see if the AndAll property is set.
        /// </summary>
        internal bool IsSetAndAll() => this.AndAll != null;

        /// <summary>
        /// Gets and sets the property EqualTo. 
        /// <para>
        /// Tests that operandOne is equal to operandTwo.
        /// </para>
        /// </summary>
        public BooleanOperands EqualTo { get; set; }

        /// <summary>
        /// Checks to see if the EqualTo property is set.
        /// </summary>
        internal bool IsSetEqualTo() => this.EqualTo != null;

        /// <summary>
        /// Gets and sets the property NotEqualTo. 
        /// <para>
        /// Tests that operandOne is not equal to operandTwo.
        /// </para>
        /// </summary>
        public BooleanOperands NotEqualTo { get; set; }

        /// <summary>
        /// Checks to see if the NotEqualTo property is set.
        /// </summary>
        internal bool IsSetNotEqualTo() => this.NotEqualTo != null;

        /// <summary>
        /// Gets and sets the property OrAll. 
        /// <para>
        /// Combines multiple conditions with OR operator. At least one condition must be true
        /// for the compound condition to be true.
        /// </para>
        /// </summary>
        public CompoundCondition OrAll { get; set; }

        /// <summary>
        /// Checks to see if the OrAll property is set.
        /// </summary>
        internal bool IsSetOrAll() => this.OrAll != null;
    }
}
