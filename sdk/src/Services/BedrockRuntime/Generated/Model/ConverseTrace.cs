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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The trace object in a response from <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_Converse.html">Converse</a>.
    /// Currently, you can only trace guardrails.
    /// </summary>
    public partial class ConverseTrace
    {
        private GuardrailTraceAssessment _guardrail;
        private PromptRouterTrace _promptRouter;

        /// <summary>
        /// Gets and sets the property Guardrail. 
        /// <para>
        /// The guardrail trace object. 
        /// </para>
        /// </summary>
        public GuardrailTraceAssessment Guardrail
        {
            get { return this._guardrail; }
            set { this._guardrail = value; }
        }

        // Check to see if Guardrail property is set
        internal bool IsSetGuardrail()
        {
            return this._guardrail != null;
        }

        /// <summary>
        /// Gets and sets the property PromptRouter. 
        /// <para>
        /// The request's prompt router.
        /// </para>
        /// </summary>
        public PromptRouterTrace PromptRouter
        {
            get { return this._promptRouter; }
            set { this._promptRouter = value; }
        }

        // Check to see if PromptRouter property is set
        internal bool IsSetPromptRouter()
        {
            return this._promptRouter != null;
        }

    }
}