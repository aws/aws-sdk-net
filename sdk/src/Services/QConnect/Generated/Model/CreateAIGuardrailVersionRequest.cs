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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAIGuardrailVersion operation.
    /// Creates an Amazon Q in Connect AI Guardrail version.
    /// </summary>
    public partial class CreateAIGuardrailVersionRequest : AmazonQConnectRequest
    {
        private string _aiGuardrailId;
        private string _assistantId;
        private string _clientToken;
        private DateTime? _modifiedTime;

        /// <summary>
        /// Gets and sets the property AiGuardrailId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect AI Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AiGuardrailId
        {
            get { return this._aiGuardrailId; }
            set { this._aiGuardrailId = value; }
        }

        // Check to see if AiGuardrailId property is set
        internal bool IsSetAiGuardrailId()
        {
            return this._aiGuardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant. Can be either the ID or the ARN.
        /// URLs cannot contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantId
        {
            get { return this._assistantId; }
            set { this._assistantId = value; }
        }

        // Check to see if AssistantId property is set
        internal bool IsSetAssistantId()
        {
            return this._assistantId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="http://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>..
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property ModifiedTime. 
        /// <para>
        /// The time the AI Guardrail was last modified.
        /// </para>
        /// </summary>
        public DateTime ModifiedTime
        {
            get { return this._modifiedTime.GetValueOrDefault(); }
            set { this._modifiedTime = value; }
        }

        // Check to see if ModifiedTime property is set
        internal bool IsSetModifiedTime()
        {
            return this._modifiedTime.HasValue; 
        }

    }
}