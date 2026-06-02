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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
        private string _functionId;
        private string _runCondition;

        /// <summary>
        /// Gets and sets the property FunctionId. 
        /// <para>
        /// The identifier of the child function to execute in this step.
        /// </para>
        /// </summary>
        public string FunctionId
        {
            get { return this._functionId; }
            set { this._functionId = value; }
        }

        // Check to see if FunctionId property is set
        internal bool IsSetFunctionId()
        {
            return this._functionId != null;
        }

        /// <summary>
        /// Gets and sets the property RunCondition. 
        /// <para>
        /// An optional expression that evaluates to a boolean. MediaTailor evaluates this expression
        /// immediately before running the step, using the accumulated state at that point in
        /// the sequence. If the expression evaluates to <c>false</c>, MediaTailor skips the step
        /// and moves to the next one. If omitted, the step always runs.
        /// </para>
        /// </summary>
        public string RunCondition
        {
            get { return this._runCondition; }
            set { this._runCondition = value; }
        }

        // Check to see if RunCondition property is set
        internal bool IsSetRunCondition()
        {
            return this._runCondition != null;
        }

    }
}