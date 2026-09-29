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
    /// This is the response object from the RetrieveAndGenerate operation.
    /// </summary>
    public partial class RetrieveAndGenerateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Citations. 
        /// <para>
        /// A list of segments of the generated response that are based on sources in the knowledge
        /// base, alongside information about the sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Citation> Citations { get; set; } = AWSConfigs.InitializeCollections ? new List<Citation>() : null;

        /// <summary>
        /// Checks to see if the Citations property is set.
        /// </summary>
        internal bool IsSetCitations() => this.Citations != null && (this.Citations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GuardrailAction. 
        /// <para>
        /// Specifies if there is a guardrail intervention in the response.
        /// </para>
        /// </summary>
        public GuadrailAction GuardrailAction { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailAction property is set.
        /// </summary>
        internal bool IsSetGuardrailAction() => this.GuardrailAction != null;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// Contains the response generated from querying the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RetrieveAndGenerateOutput Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session. When you first make a <c>RetrieveAndGenerate</c>
        /// request, Amazon Bedrock automatically generates this value. You must reuse this value
        /// for all subsequent requests in the same conversational session. This value allows
        /// Amazon Bedrock to maintain context and knowledge from previous interactions. You can't
        /// explicitly set the <c>sessionId</c> yourself.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
