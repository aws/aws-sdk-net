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
    /// Container for the parameters to the StartCodeInterpreterSession operation.
    /// Creates and initializes a code interpreter session in Amazon Bedrock. The session
    /// enables agents to execute code as part of their response generation, supporting programming
    /// languages such as Python for data analysis, visualization, and computation tasks.
    /// 
    ///  
    /// <para>
    /// To create a session, you must specify a code interpreter identifier and a name. The
    /// session remains active until it times out or you explicitly stop it using the <c>StopCodeInterpreterSession</c>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>StartCodeInterpreterSession</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_InvokeCodeInterpreter.html">InvokeCodeInterpreter</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_StopCodeInterpreterSession.html">StopCodeInterpreterSession</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartCodeInterpreterSessionRequest : AmazonBedrockAgentCoreRequest
    {
        private string _clientToken;
        private string _codeInterpreterIdentifier;
        private string _name;
        private int? _sessionTimeoutSeconds;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. This parameter helps prevent the creation of
        /// duplicate sessions if there are temporary network issues.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CodeInterpreterIdentifier. 
        /// <para>
        /// The unique identifier of the code interpreter to use for this session. This identifier
        /// specifies which code interpreter environment to initialize for the session.
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
        /// The name of the code interpreter session. This name helps you identify and manage
        /// the session. The name does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
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
        /// Gets and sets the property SessionTimeoutSeconds. 
        /// <para>
        /// The time in seconds after which the session automatically terminates if there is no
        /// activity. The default value is 3600 seconds (1 hour). The minimum allowed value is
        /// 60 seconds, and the maximum allowed value is 28800 seconds (8 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=28800)]
        public int? SessionTimeoutSeconds
        {
            get { return this._sessionTimeoutSeconds; }
            set { this._sessionTimeoutSeconds = value; }
        }

        // Check to see if SessionTimeoutSeconds property is set
        internal bool IsSetSessionTimeoutSeconds()
        {
            return this._sessionTimeoutSeconds.HasValue; 
        }

    }
}