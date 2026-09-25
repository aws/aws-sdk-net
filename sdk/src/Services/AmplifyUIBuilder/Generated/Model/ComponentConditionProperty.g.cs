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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Represents a conditional expression to set a component property. Use <c>ComponentConditionProperty</c>
    /// to set a property to different values conditionally, based on the value of another
    /// property.
    /// </summary>
    public partial class ComponentConditionProperty
    {
        /// <summary>
        /// Gets and sets the property Else. 
        /// <para>
        /// The value to assign to the property if the condition is not met.
        /// </para>
        /// </summary>
        public ComponentProperty Else { get; set; }

        /// <summary>
        /// Checks to see if the Else property is set.
        /// </summary>
        internal bool IsSetElse() => this.Else != null;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The name of a field. Specify this when the property is a data model.
        /// </para>
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// Checks to see if the Field property is set.
        /// </summary>
        internal bool IsSetField() => this.Field != null;

        /// <summary>
        /// Gets and sets the property Operand. 
        /// <para>
        /// The value of the property to evaluate.
        /// </para>
        /// </summary>
        public string Operand { get; set; }

        /// <summary>
        /// Checks to see if the Operand property is set.
        /// </summary>
        internal bool IsSetOperand() => this.Operand != null;

        /// <summary>
        /// Gets and sets the property OperandType. 
        /// <para>
        /// The type of the property to evaluate.
        /// </para>
        /// </summary>
        public string OperandType { get; set; }

        /// <summary>
        /// Checks to see if the OperandType property is set.
        /// </summary>
        internal bool IsSetOperandType() => this.OperandType != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to use to perform the evaluation, such as <c>eq</c> to represent equals.
        /// </para>
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// The name of the conditional property.
        /// </para>
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Checks to see if the Property property is set.
        /// </summary>
        internal bool IsSetProperty() => this.Property != null;

        /// <summary>
        /// Gets and sets the property Then. 
        /// <para>
        /// The value to assign to the property if the condition is met.
        /// </para>
        /// </summary>
        public ComponentProperty Then { get; set; }

        /// <summary>
        /// Checks to see if the Then property is set.
        /// </summary>
        internal bool IsSetThen() => this.Then != null;
    }
}
