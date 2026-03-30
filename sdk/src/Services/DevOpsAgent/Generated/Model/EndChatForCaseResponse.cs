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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Response structure for end chat operation
    /// </summary>
    public partial class EndChatForCaseResponse : AmazonWebServiceResponse
    {
        private string _errorMessage;
        private string _executionId;
        private bool? _isDisconnected;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message if the disconnect failed
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The execution ID that was ended
        /// </para>
        /// </summary>
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property IsDisconnected. 
        /// <para>
        /// Whether the chat session was successfully ended
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsDisconnected
        {
            get { return this._isDisconnected; }
            set { this._isDisconnected = value; }
        }

        // Check to see if IsDisconnected property is set
        internal bool IsSetIsDisconnected()
        {
            return this._isDisconnected.HasValue; 
        }

    }
}