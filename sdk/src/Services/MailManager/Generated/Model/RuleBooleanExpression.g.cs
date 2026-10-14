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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// A boolean expression to be used in a rule condition.
    /// </summary>
    public partial class RuleBooleanExpression
    {
        /// <summary>
        /// Gets and sets the property Evaluate. 
        /// <para>
        /// The operand on which to perform a boolean condition operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleBooleanToEvaluate Evaluate { get; set; }

        /// <summary>
        /// Checks to see if the Evaluate property is set.
        /// </summary>
        internal bool IsSetEvaluate() => this.Evaluate != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The matching operator for a boolean condition expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleBooleanOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;
    }
}
