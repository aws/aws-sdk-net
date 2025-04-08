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
    /// Configurations for streaming.
    /// </summary>
    public partial class StreamingConfigurations
    {
        private int? _applyGuardrailInterval;
        private bool? _streamFinalResponse;

        /// <summary>
        /// Gets and sets the property ApplyGuardrailInterval. 
        /// <para>
        ///  The guardrail interval to apply as response is generated. By default, the guardrail
        /// interval is set to 50 characters. If a larger interval is specified, the response
        /// will be generated in larger chunks with fewer <c>ApplyGuardrail</c> calls. The following
        /// examples show the response generated for <i>Hello, I am an agent</i> input string.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example response in chunks: Interval set to 3 characters</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>'Hel', 'lo, ','I am', ' an', ' Age', 'nt'</c> 
        /// </para>
        ///  
        /// <para>
        /// Each chunk has at least 3 characters except for the last chunk
        /// </para>
        ///  
        /// <para>
        ///  <b>Example response in chunks: Interval set to 20 or more characters</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>Hello, I am an Agent</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? ApplyGuardrailInterval
        {
            get { return this._applyGuardrailInterval; }
            set { this._applyGuardrailInterval = value; }
        }

        // Check to see if ApplyGuardrailInterval property is set
        internal bool IsSetApplyGuardrailInterval()
        {
            return this._applyGuardrailInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamFinalResponse. 
        /// <para>
        ///  Specifies whether to enable streaming for the final response. This is set to <c>false</c>
        /// by default. 
        /// </para>
        /// </summary>
        public bool? StreamFinalResponse
        {
            get { return this._streamFinalResponse; }
            set { this._streamFinalResponse = value; }
        }

        // Check to see if StreamFinalResponse property is set
        internal bool IsSetStreamFinalResponse()
        {
            return this._streamFinalResponse.HasValue; 
        }

    }
}