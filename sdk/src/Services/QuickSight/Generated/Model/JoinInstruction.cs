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
    /// The instructions associated with a join.
    /// </summary>
    public partial class JoinInstruction
    {
        private JoinKeyProperties _leftJoinKeyProperties;
        private string _leftOperand;
        private string _onClause;
        private JoinKeyProperties _rightJoinKeyProperties;
        private string _rightOperand;
        private JoinType _type;

        /// <summary>
        /// Gets and sets the property LeftJoinKeyProperties. 
        /// <para>
        /// Join key properties of the left operand.
        /// </para>
        /// </summary>
        public JoinKeyProperties LeftJoinKeyProperties
        {
            get { return this._leftJoinKeyProperties; }
            set { this._leftJoinKeyProperties = value; }
        }

        // Check to see if LeftJoinKeyProperties property is set
        internal bool IsSetLeftJoinKeyProperties()
        {
            return this._leftJoinKeyProperties != null;
        }

        /// <summary>
        /// Gets and sets the property LeftOperand. 
        /// <para>
        /// The operand on the left side of a join.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string LeftOperand
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
        /// Gets and sets the property OnClause. 
        /// <para>
        /// The join instructions provided in the <c>ON</c> clause of a join.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// Gets and sets the property RightJoinKeyProperties. 
        /// <para>
        /// Join key properties of the right operand.
        /// </para>
        /// </summary>
        public JoinKeyProperties RightJoinKeyProperties
        {
            get { return this._rightJoinKeyProperties; }
            set { this._rightJoinKeyProperties = value; }
        }

        // Check to see if RightJoinKeyProperties property is set
        internal bool IsSetRightJoinKeyProperties()
        {
            return this._rightJoinKeyProperties != null;
        }

        /// <summary>
        /// Gets and sets the property RightOperand. 
        /// <para>
        /// The operand on the right side of a join.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RightOperand
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of join that it is.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JoinType Type
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