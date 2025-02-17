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
    /// Container for the parameters to the DeleteAIGuardrailVersion operation.
    /// Delete and Amazon Q in Connect AI Guardrail version.
    /// </summary>
    public partial class DeleteAIGuardrailVersionRequest : AmazonQConnectRequest
    {
        private string _aiGuardrailId;
        private string _assistantId;
        private long? _versionNumber;

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
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the AI Guardrail version to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}