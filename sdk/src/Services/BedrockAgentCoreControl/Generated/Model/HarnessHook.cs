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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
    /// A lifecycle hook configuration. Specify one hook type.
    /// </summary>
    public partial class HarnessHook
    {
        private HarnessAfterInvocationHook _afterInvocation;
        private HarnessAfterToolCallHook _afterToolCall;
        private HarnessBeforeInvocationHook _beforeInvocation;
        private HarnessBeforeToolCallHook _beforeToolCall;

        /// <summary>
        /// Gets and sets the property AfterInvocation. 
        /// <para>
        /// A hook that runs after an invocation completes.
        /// </para>
        /// </summary>
        public HarnessAfterInvocationHook AfterInvocation
        {
            get { return this._afterInvocation; }
            set { this._afterInvocation = value; }
        }

        // Check to see if AfterInvocation property is set
        internal bool IsSetAfterInvocation()
        {
            return this._afterInvocation != null;
        }

        /// <summary>
        /// Gets and sets the property AfterToolCall. 
        /// <para>
        /// A hook that runs after a tool call completes.
        /// </para>
        /// </summary>
        public HarnessAfterToolCallHook AfterToolCall
        {
            get { return this._afterToolCall; }
            set { this._afterToolCall = value; }
        }

        // Check to see if AfterToolCall property is set
        internal bool IsSetAfterToolCall()
        {
            return this._afterToolCall != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeInvocation. 
        /// <para>
        /// A hook that runs before an invocation begins.
        /// </para>
        /// </summary>
        public HarnessBeforeInvocationHook BeforeInvocation
        {
            get { return this._beforeInvocation; }
            set { this._beforeInvocation = value; }
        }

        // Check to see if BeforeInvocation property is set
        internal bool IsSetBeforeInvocation()
        {
            return this._beforeInvocation != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeToolCall. 
        /// <para>
        /// A hook that runs before the agent calls a tool.
        /// </para>
        /// </summary>
        public HarnessBeforeToolCallHook BeforeToolCall
        {
            get { return this._beforeToolCall; }
            set { this._beforeToolCall = value; }
        }

        // Check to see if BeforeToolCall property is set
        internal bool IsSetBeforeToolCall()
        {
            return this._beforeToolCall != null;
        }

    }
}