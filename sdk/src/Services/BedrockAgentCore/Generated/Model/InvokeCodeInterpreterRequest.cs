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
    /// Container for the parameters to the InvokeCodeInterpreter operation.
    /// Executes code within an active code interpreter session in Amazon Bedrock. This operation
    /// processes the provided code, runs it in a secure environment, and returns the execution
    /// results including output, errors, and generated visualizations.
    /// 
    ///  
    /// <para>
    /// To execute code, you must specify the code interpreter identifier, session ID, and
    /// the code to run in the arguments parameter. The operation returns a stream containing
    /// the execution results, which can include text output, error messages, and data visualizations.
    /// </para>
    ///  
    /// <para>
    /// This operation is subject to request rate limiting based on your account's service
    /// quotas.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>InvokeCodeInterpreter</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class InvokeCodeInterpreterRequest : AmazonBedrockAgentCoreRequest
    {
        private ToolArguments _arguments;
        private string _codeInterpreterIdentifier;
        private ToolName _name;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// The arguments for the code interpreter. This includes the code to execute and any
        /// additional parameters such as the programming language, whether to clear the execution
        /// context, and other execution options. The structure of this parameter depends on the
        /// specific code interpreter being used.
        /// </para>
        /// </summary>
        public ToolArguments Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null;
        }

        /// <summary>
        /// Gets and sets the property CodeInterpreterIdentifier. 
        /// <para>
        /// The unique identifier of the code interpreter associated with the session. This must
        /// match the identifier used when creating the session with <c>StartCodeInterpreterSession</c>.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the code interpreter to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ToolName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the code interpreter session to use. This must be an active
        /// session created with <c>StartCodeInterpreterSession</c>. If the session has expired
        /// or been stopped, the request will fail.
        /// </para>
        /// </summary>
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