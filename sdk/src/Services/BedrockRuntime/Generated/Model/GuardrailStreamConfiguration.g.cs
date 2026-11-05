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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Configuration information for a guardrail that you use with the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_ConverseStream.html">ConverseStream</a>
    /// action.
    /// </summary>
    public partial class GuardrailStreamConfiguration
    {
        /// <summary>
        /// Gets and sets the property GuardrailIdentifier. 
        /// <para>
        /// The identifier for the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string GuardrailIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailIdentifier property is set.
        /// </summary>
        internal bool IsSetGuardrailIdentifier() => this.GuardrailIdentifier != null;

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// The version of the guardrail.
        /// </para>
        /// </summary>
        public string GuardrailVersion { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailVersion property is set.
        /// </summary>
        internal bool IsSetGuardrailVersion() => this.GuardrailVersion != null;

        /// <summary>
        /// Gets and sets the property StreamProcessingMode. 
        /// <para>
        /// The processing mode. 
        /// </para>
        ///  
        /// <para>
        /// The processing mode. For more information, see <i>Configure streaming response behavior</i>
        /// in the <i>Amazon Bedrock User Guide</i>. 
        /// </para>
        /// </summary>
        public GuardrailStreamProcessingMode StreamProcessingMode { get; set; }

        /// <summary>
        /// Checks to see if the StreamProcessingMode property is set.
        /// </summary>
        internal bool IsSetStreamProcessingMode() => this.StreamProcessingMode != null;

        /// <summary>
        /// Gets and sets the property Trace. 
        /// <para>
        /// The trace behavior for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailTrace Trace { get; set; }

        /// <summary>
        /// Checks to see if the Trace property is set.
        /// </summary>
        internal bool IsSetTrace() => this.Trace != null;
    }
}
