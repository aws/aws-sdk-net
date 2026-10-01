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
    /// Container for the parameters to the RetrieveAndGenerate operation. Queries a knowledge
    /// base and generates responses based on the retrieved results and using the specified
    /// foundation model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
    /// profile</a>. The response only cites sources that are relevant to the query. <note>
    /// <para> This API cannot be used with managed knowledge bases. Use <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_AgenticRetrieveStream.html">AgenticRetrieveStream</a>
    /// or <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Retrieve.html">Retrieve</a>
    /// with managed knowledge bases. </para> </note>
    /// </summary>
    public partial class RetrieveAndGenerateRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Contains the query to be made to the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RetrieveAndGenerateInput Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property RetrieveAndGenerateConfiguration. 
        /// <para>
        /// Contains configurations for the knowledge base query and retrieval process. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-test-config.html">Query
        /// configurations</a>.
        /// </para>
        /// </summary>
        public RetrieveAndGenerateConfiguration RetrieveAndGenerateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RetrieveAndGenerateConfiguration property is set.
        /// </summary>
        internal bool IsSetRetrieveAndGenerateConfiguration() => this.RetrieveAndGenerateConfiguration != null;

        /// <summary>
        /// Gets and sets the property SessionConfiguration. 
        /// <para>
        /// Contains details about the session with the knowledge base.
        /// </para>
        /// </summary>
        public RetrieveAndGenerateSessionConfiguration SessionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SessionConfiguration property is set.
        /// </summary>
        internal bool IsSetSessionConfiguration() => this.SessionConfiguration != null;

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
        [AWSProperty(Min = 2, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property UserContext. 
        /// <para>
        /// Contains information about the user making the request. This is used for access control
        /// filtering to ensure that retrieval results only include documents the user is authorized
        /// to access.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public UserContext UserContext { get; set; }

        /// <summary>
        /// Checks to see if the UserContext property is set.
        /// </summary>
        internal bool IsSetUserContext() => this.UserContext != null;
    }
}
