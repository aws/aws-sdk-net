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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// A reference to a child function within a <c>SEQUENTIAL_EXECUTOR</c> function.
    /// </summary>
    public partial class FunctionRef
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// An optional alternate name for the function within the executor. If omitted, MediaTailor
        /// uses the function identifier.
        /// </para>
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property FunctionId. 
        /// <para>
        /// The identifier of the child function to execute in this step.
        /// </para>
        /// </summary>
        public string FunctionId { get; set; }

        /// <summary>
        /// Checks to see if the FunctionId property is set.
        /// </summary>
        internal bool IsSetFunctionId() => this.FunctionId != null;

        /// <summary>
        /// Gets and sets the property RunCondition. 
        /// <para>
        /// An optional expression that evaluates to a boolean. MediaTailor evaluates this expression
        /// immediately before running the step, using the accumulated state at that point in
        /// the sequence. If the expression evaluates to <c>false</c>, MediaTailor skips the step
        /// and moves to the next one. If omitted, the step always runs.
        /// </para>
        /// </summary>
        public string RunCondition { get; set; }

        /// <summary>
        /// Checks to see if the RunCondition property is set.
        /// </summary>
        internal bool IsSetRunCondition() => this.RunCondition != null;
    }
}
