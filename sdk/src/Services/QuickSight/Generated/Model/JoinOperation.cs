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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// A transform operation that combines data from two sources based on specified join
    /// conditions.
    /// </summary>
    public partial class JoinOperation
    {
        private string _alias;
        private TransformOperationSource _leftOperand;
        private JoinOperandProperties _leftOperandProperties;
        private string _onClause;
        private TransformOperationSource _rightOperand;
        private JoinOperandProperties _rightOperandProperties;
        private JoinOperationType _type;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property LeftOperand. 
        /// <para>
        /// The left operand for the join operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformOperationSource LeftOperand
        {
            get { return this._leftOperand; }
            set { this._leftOperand = value; }
        }

        // Check to see if LeftOperand property is set
        internal bool IsSetLeftOperand()
        {
            return this._leftOperand != null;
        }

        /// <summary>
        /// Gets and sets the property LeftOperandProperties. 
        /// <para>
        /// Properties that control how the left operand's columns are handled in the join result.
        /// </para>
        /// </summary>
        public JoinOperandProperties LeftOperandProperties
        {
            get { return this._leftOperandProperties; }
            set { this._leftOperandProperties = value; }
        }

        // Check to see if LeftOperandProperties property is set
        internal bool IsSetLeftOperandProperties()
        {
            return this._leftOperandProperties != null;
        }

        /// <summary>
        /// Gets and sets the property OnClause. 
        /// <para>
        /// The join condition that specifies how to match rows between the left and right operands.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=512)]
        public string OnClause
        {
            get { return this._onClause; }
            set { this._onClause = value; }
        }

        // Check to see if OnClause property is set
        internal bool IsSetOnClause()
        {
            return this._onClause != null;
        }

        /// <summary>
        /// Gets and sets the property RightOperand. 
        /// <para>
        /// The right operand for the join operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformOperationSource RightOperand
        {
            get { return this._rightOperand; }
            set { this._rightOperand = value; }
        }

        // Check to see if RightOperand property is set
        internal bool IsSetRightOperand()
        {
            return this._rightOperand != null;
        }

        /// <summary>
        /// Gets and sets the property RightOperandProperties. 
        /// <para>
        /// Properties that control how the right operand's columns are handled in the join result.
        /// </para>
        /// </summary>
        public JoinOperandProperties RightOperandProperties
        {
            get { return this._rightOperandProperties; }
            set { this._rightOperandProperties = value; }
        }

        // Check to see if RightOperandProperties property is set
        internal bool IsSetRightOperandProperties()
        {
            return this._rightOperandProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of join to perform, such as <c>INNER</c>, <c>LEFT</c>, <c>RIGHT</c>, or <c>OUTER</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JoinOperationType Type
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