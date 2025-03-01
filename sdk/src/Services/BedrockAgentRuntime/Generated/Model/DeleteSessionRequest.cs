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
    /// Container for the parameters to the DeleteSession operation.
    /// Deletes a session that you ended. You can't delete a session with an <c>ACTIVE</c>
    /// status. To delete an active session, you must first end it with the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_EndSession.html">EndSession</a>
    /// API operation. For more information about sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
    /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
    /// </summary>
    public partial class DeleteSessionRequest : AmazonBedrockAgentRuntimeRequest
    {
        private string _sessionIdentifier;

        /// <summary>
        /// Gets and sets the property SessionIdentifier. 
        /// <para>
        /// The unique identifier for the session to be deleted. You can specify either the session's
        /// <c>sessionId</c> or its Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionIdentifier
        {
            get { return this._sessionIdentifier; }
            set { this._sessionIdentifier = value; }
        }

        // Check to see if SessionIdentifier property is set
        internal bool IsSetSessionIdentifier()
        {
            return this._sessionIdentifier != null;
        }

    }
}