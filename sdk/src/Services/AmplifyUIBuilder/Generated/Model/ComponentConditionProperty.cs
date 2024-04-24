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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
        private ComponentProperty _else;
        private string _field;
        private string _operand;
        private string _operandType;
        private string _operator;
        private string _property;
        private ComponentProperty _then;

        /// <summary>
        /// Gets and sets the property Else. 
        /// <para>
        /// The value to assign to the property if the condition is not met.
        /// </para>
        /// </summary>
        public ComponentProperty Else
        {
            get { return this._else; }
            set { this._else = value; }
        }

        // Check to see if Else property is set
        internal bool IsSetElse()
        {
            return this._else != null;
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The name of a field. Specify this when the property is a data model.
        /// </para>
        /// </summary>
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Operand. 
        /// <para>
        /// The value of the property to evaluate.
        /// </para>
        /// </summary>
        public string Operand
        {
            get { return this._operand; }
            set { this._operand = value; }
        }

        // Check to see if Operand property is set
        internal bool IsSetOperand()
        {
            return this._operand != null;
        }

        /// <summary>
        /// Gets and sets the property OperandType. 
        /// <para>
        /// The type of the property to evaluate.
        /// </para>
        /// </summary>
        public string OperandType
        {
            get { return this._operandType; }
            set { this._operandType = value; }
        }

        // Check to see if OperandType property is set
        internal bool IsSetOperandType()
        {
            return this._operandType != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to use to perform the evaluation, such as <c>eq</c> to represent equals.
        /// </para>
        /// </summary>
        public string Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// The name of the conditional property.
        /// </para>
        /// </summary>
        public string Property
        {
            get { return this._property; }
            set { this._property = value; }
        }

        // Check to see if Property property is set
        internal bool IsSetProperty()
        {
            return this._property != null;
        }

        /// <summary>
        /// Gets and sets the property Then. 
        /// <para>
        /// The value to assign to the property if the condition is met.
        /// </para>
        /// </summary>
        public ComponentProperty Then
        {
            get { return this._then; }
            set { this._then = value; }
        }

        // Check to see if Then property is set
        internal bool IsSetThen()
        {
            return this._then != null;
        }

    }
}