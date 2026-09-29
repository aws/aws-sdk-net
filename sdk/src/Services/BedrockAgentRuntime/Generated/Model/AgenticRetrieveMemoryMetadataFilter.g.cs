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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// A metadata filter expression, in the form accepted by the AgentCore Memory RetrieveMemoryRecords
    /// operation. The expression has a left operand that names the metadata key, an operator,
    /// and a right operand. For the EXISTS and NOT_EXISTS operators, omit the right operand.
    /// </summary>
    public partial class AgenticRetrieveMemoryMetadataFilter
    {
        /// <summary>
        /// Gets and sets the property Left. 
        /// <para>
        /// The metadata key that the expression evaluates.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgenticRetrieveMemoryMetadataFilterLeft Left { get; set; }

        /// <summary>
        /// Checks to see if the Left property is set.
        /// </summary>
        internal bool IsSetLeft() => this.Left != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The relationship that the metadata key and value must have for a memory record to
        /// match.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgenticRetrieveMemoryMetadataFilterOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Right. 
        /// <para>
        /// The value that the expression compares the metadata key against. Supply this value
        /// for every operator except EXISTS and NOT_EXISTS.
        /// </para>
        /// </summary>
        public AgenticRetrieveMemoryMetadataFilterRight Right { get; set; }

        /// <summary>
        /// Checks to see if the Right property is set.
        /// </summary>
        internal bool IsSetRight() => this.Right != null;
    }
}
