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
        ///  The guardrail interval to apply as response is generated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int ApplyGuardrailInterval
        {
            get { return this._applyGuardrailInterval.GetValueOrDefault(); }
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
        public bool StreamFinalResponse
        {
            get { return this._streamFinalResponse.GetValueOrDefault(); }
            set { this._streamFinalResponse = value; }
        }

        // Check to see if StreamFinalResponse property is set
        internal bool IsSetStreamFinalResponse()
        {
            return this._streamFinalResponse.HasValue; 
        }

    }
}