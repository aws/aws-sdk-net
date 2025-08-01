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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the GetCodeInterpreterSession operation.
    /// Retrieves detailed information about a specific code interpreter session in Amazon
    /// Bedrock. This operation returns the session's configuration, current status, and metadata.
    /// 
    ///  
    /// <para>
    /// To get a code interpreter session, you must specify both the code interpreter identifier
    /// and the session ID. The response includes information about the session's timeout
    /// settings and current status.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>GetCodeInterpreterSession</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_ListCodeInterpreterSessions.html">ListCodeInterpreterSessions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_StopCodeInterpreterSession.html">StopCodeInterpreterSession</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetCodeInterpreterSessionRequest : AmazonBedrockAgentCoreRequest
    {
        private string _codeInterpreterIdentifier;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property CodeInterpreterIdentifier. 
        /// <para>
        /// The unique identifier of the code interpreter associated with the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CodeInterpreterIdentifier
        {
            get { return this._codeInterpreterIdentifier; }
            set { this._codeInterpreterIdentifier = value; }
        }

        // Check to see if CodeInterpreterIdentifier property is set
        internal bool IsSetCodeInterpreterIdentifier()
        {
            return this._codeInterpreterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the code interpreter session to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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