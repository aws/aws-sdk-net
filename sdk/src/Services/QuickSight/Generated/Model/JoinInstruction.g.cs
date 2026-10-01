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
    /// The instructions associated with a join.
    /// </summary>
    public partial class JoinInstruction
    {
        /// <summary>
        /// Gets and sets the property LeftJoinKeyProperties. 
        /// <para>
        /// Join key properties of the left operand.
        /// </para>
        /// </summary>
        public JoinKeyProperties LeftJoinKeyProperties { get; set; }

        /// <summary>
        /// Checks to see if the LeftJoinKeyProperties property is set.
        /// </summary>
        internal bool IsSetLeftJoinKeyProperties() => this.LeftJoinKeyProperties != null;

        /// <summary>
        /// Gets and sets the property LeftOperand. 
        /// <para>
        /// The operand on the left side of a join.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string LeftOperand { get; set; }

        /// <summary>
        /// Checks to see if the LeftOperand property is set.
        /// </summary>
        internal bool IsSetLeftOperand() => this.LeftOperand != null;

        /// <summary>
        /// Gets and sets the property OnClause. 
        /// <para>
        /// The join instructions provided in the <c>ON</c> clause of a join.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string OnClause { get; set; }

        /// <summary>
        /// Checks to see if the OnClause property is set.
        /// </summary>
        internal bool IsSetOnClause() => this.OnClause != null;

        /// <summary>
        /// Gets and sets the property RightJoinKeyProperties. 
        /// <para>
        /// Join key properties of the right operand.
        /// </para>
        /// </summary>
        public JoinKeyProperties RightJoinKeyProperties { get; set; }

        /// <summary>
        /// Checks to see if the RightJoinKeyProperties property is set.
        /// </summary>
        internal bool IsSetRightJoinKeyProperties() => this.RightJoinKeyProperties != null;

        /// <summary>
        /// Gets and sets the property RightOperand. 
        /// <para>
        /// The operand on the right side of a join.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RightOperand { get; set; }

        /// <summary>
        /// Checks to see if the RightOperand property is set.
        /// </summary>
        internal bool IsSetRightOperand() => this.RightOperand != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of join that it is.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JoinType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
