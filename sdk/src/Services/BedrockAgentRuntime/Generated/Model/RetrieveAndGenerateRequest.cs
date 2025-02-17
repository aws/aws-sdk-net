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
    /// Container for the parameters to the RetrieveAndGenerate operation.
    /// Queries a knowledge base and generates responses based on the retrieved results and
    /// using the specified foundation model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
    /// profile</a>. The response only cites sources that are relevant to the query.
    /// </summary>
    public partial class RetrieveAndGenerateRequest : AmazonBedrockAgentRuntimeRequest
    {
        private RetrieveAndGenerateInput _input;
        private RetrieveAndGenerateConfiguration _retrieveAndGenerateConfiguration;
        private RetrieveAndGenerateSessionConfiguration _sessionConfiguration;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Contains the query to be made to the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public RetrieveAndGenerateInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property RetrieveAndGenerateConfiguration. 
        /// <para>
        /// Contains configurations for the knowledge base query and retrieval process. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-test-config.html">Query
        /// configurations</a>.
        /// </para>
        /// </summary>
        public RetrieveAndGenerateConfiguration RetrieveAndGenerateConfiguration
        {
            get { return this._retrieveAndGenerateConfiguration; }
            set { this._retrieveAndGenerateConfiguration = value; }
        }

        // Check to see if RetrieveAndGenerateConfiguration property is set
        internal bool IsSetRetrieveAndGenerateConfiguration()
        {
            return this._retrieveAndGenerateConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SessionConfiguration. 
        /// <para>
        /// Contains details about the session with the knowledge base.
        /// </para>
        /// </summary>
        public RetrieveAndGenerateSessionConfiguration SessionConfiguration
        {
            get { return this._sessionConfiguration; }
            set { this._sessionConfiguration = value; }
        }

        // Check to see if SessionConfiguration property is set
        internal bool IsSetSessionConfiguration()
        {
            return this._sessionConfiguration != null;
        }

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
        [AWSProperty(Min=2, Max=100)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}