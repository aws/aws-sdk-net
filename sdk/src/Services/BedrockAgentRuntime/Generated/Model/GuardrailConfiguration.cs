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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
    /// The configuration details for the guardrail.
    /// </summary>
    public partial class GuardrailConfiguration
    {
        private string _guardrailId;
        private string _guardrailVersion;

        /// <summary>
        /// Gets and sets the property GuardrailId. 
        /// <para>
        /// The unique identifier for the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string GuardrailId
        {
            get { return this._guardrailId; }
            set { this._guardrailId = value; }
        }

        // Check to see if GuardrailId property is set
        internal bool IsSetGuardrailId()
        {
            return this._guardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// The version of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string GuardrailVersion
        {
            get { return this._guardrailVersion; }
            set { this._guardrailVersion = value; }
        }

        // Check to see if GuardrailVersion property is set
        internal bool IsSetGuardrailVersion()
        {
            return this._guardrailVersion != null;
        }

    }
}