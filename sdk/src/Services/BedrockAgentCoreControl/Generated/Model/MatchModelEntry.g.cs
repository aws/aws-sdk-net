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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A model ID or pattern to match against the requested model, and the operator to use
    /// for the comparison.
    /// </summary>
    public partial class MatchModelEntry
    {
        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to use when comparing the requested model to the value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>StringEquals</c> – Requires an exact match.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StringLike</c> – Supports wildcard patterns using <c>*</c> and <c>?</c>. This
        /// is the default.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MatchOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The model ID or pattern to match. With the <c>StringLike</c> operator, you can use
        /// <c>*</c> and <c>?</c> as wildcards, for example <c>anthropic.claude-*</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
