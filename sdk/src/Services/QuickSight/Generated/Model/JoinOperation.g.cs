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
    /// A transform operation that combines data from two sources based on specified join
    /// conditions.
    /// </summary>
    public partial class JoinOperation
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property LeftOperand. 
        /// <para>
        /// The left operand for the join operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformOperationSource LeftOperand { get; set; }

        /// <summary>
        /// Checks to see if the LeftOperand property is set.
        /// </summary>
        internal bool IsSetLeftOperand() => this.LeftOperand != null;

        /// <summary>
        /// Gets and sets the property LeftOperandProperties. 
        /// <para>
        /// Properties that control how the left operand's columns are handled in the join result.
        /// </para>
        /// </summary>
        public JoinOperandProperties LeftOperandProperties { get; set; }

        /// <summary>
        /// Checks to see if the LeftOperandProperties property is set.
        /// </summary>
        internal bool IsSetLeftOperandProperties() => this.LeftOperandProperties != null;

        /// <summary>
        /// Gets and sets the property OnClause. 
        /// <para>
        /// The join condition that specifies how to match rows between the left and right operands.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 512)]
        public string OnClause { get; set; }

        /// <summary>
        /// Checks to see if the OnClause property is set.
        /// </summary>
        internal bool IsSetOnClause() => this.OnClause != null;

        /// <summary>
        /// Gets and sets the property RightOperand. 
        /// <para>
        /// The right operand for the join operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformOperationSource RightOperand { get; set; }

        /// <summary>
        /// Checks to see if the RightOperand property is set.
        /// </summary>
        internal bool IsSetRightOperand() => this.RightOperand != null;

        /// <summary>
        /// Gets and sets the property RightOperandProperties. 
        /// <para>
        /// Properties that control how the right operand's columns are handled in the join result.
        /// </para>
        /// </summary>
        public JoinOperandProperties RightOperandProperties { get; set; }

        /// <summary>
        /// Checks to see if the RightOperandProperties property is set.
        /// </summary>
        internal bool IsSetRightOperandProperties() => this.RightOperandProperties != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of join to perform, such as <c>INNER</c>, <c>LEFT</c>, <c>RIGHT</c>, or <c>OUTER</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JoinOperationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
