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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Stores information for generating Amplify DataStore queries. Use a <code>Predicate</code>
    /// to retrieve a subset of the data in a collection.
    /// </summary>
    public partial class Predicate
    {
        private List<Predicate> _and = new List<Predicate>();
        private string _field;
        private string _operand;
        private string _operandType;
        private string _operator;
        private List<Predicate> _or = new List<Predicate>();

        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// A list of predicates to combine logically.
        /// </para>
        /// </summary>
        public List<Predicate> And
        {
            get { return this._and; }
            set { this._and = value; }
        }

        // Check to see if And property is set
        internal bool IsSetAnd()
        {
            return this._and != null && this._and.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The field to query.
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
        /// The value to use when performing the evaluation.
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
        /// The type of value to use when performing the evaluation.
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
        /// The operator to use to perform the evaluation.
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
        /// Gets and sets the property Or. 
        /// <para>
        /// A list of predicates to combine logically.
        /// </para>
        /// </summary>
        public List<Predicate> Or
        {
            get { return this._or; }
            set { this._or = value; }
        }

        // Check to see if Or property is set
        internal bool IsSetOr()
        {
            return this._or != null && this._or.Count > 0; 
        }

    }
}