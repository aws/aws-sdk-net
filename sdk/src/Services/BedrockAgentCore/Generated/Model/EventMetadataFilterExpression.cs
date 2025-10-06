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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Filter expression for retrieving events based on metadata associated with an event.
    /// </summary>
    public partial class EventMetadataFilterExpression
    {
        private LeftExpression _left;
        private OperatorType _operator;
        private RightExpression _right;

        /// <summary>
        /// Gets and sets the property Left. 
        /// <para>
        /// Left operand of the event metadata filter expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LeftExpression Left
        {
            get { return this._left; }
            set { this._left = value; }
        }

        // Check to see if Left property is set
        internal bool IsSetLeft()
        {
            return this._left != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Operator applied to the event metadata filter expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperatorType Operator
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
        /// Gets and sets the property Right. 
        /// <para>
        /// Right operand of the event metadata filter expression.
        /// </para>
        /// </summary>
        public RightExpression Right
        {
            get { return this._right; }
            set { this._right = value; }
        }

        // Check to see if Right property is set
        internal bool IsSetRight()
        {
            return this._right != null;
        }

    }
}