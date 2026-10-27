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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains information about the Amazon Bedrock model used to interpret the prompt used
    /// in descriptive bot building.
    /// </summary>
    public partial class BedrockModelSpecification
    {
        /// <summary>
        /// Gets and sets the property CustomPrompt. 
        /// <para>
        /// The custom prompt used in the Bedrock model specification details.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4000)]
        public string CustomPrompt { get; set; }

        /// <summary>
        /// Checks to see if the CustomPrompt property is set.
        /// </summary>
        internal bool IsSetCustomPrompt() => this.CustomPrompt != null;

        /// <summary>
        /// Gets and sets the property Guardrail. 
        /// <para>
        /// The guardrail configuration in the Bedrock model specification details.
        /// </para>
        /// </summary>
        public BedrockGuardrailConfiguration Guardrail { get; set; }

        /// <summary>
        /// Checks to see if the Guardrail property is set.
        /// </summary>
        internal bool IsSetGuardrail() => this.Guardrail != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The ARN of the foundation model used in descriptive bot building.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property TraceStatus. 
        /// <para>
        /// The Bedrock trace status in the Bedrock model specification details.
        /// </para>
        /// </summary>
        public BedrockTraceStatus TraceStatus { get; set; }

        /// <summary>
        /// Checks to see if the TraceStatus property is set.
        /// </summary>
        internal bool IsSetTraceStatus() => this.TraceStatus != null;
    }
}
