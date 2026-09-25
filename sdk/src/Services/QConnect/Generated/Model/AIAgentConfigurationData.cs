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
    /// A type that specifies the AI Agent ID configuration data when mapping an AI Agents
    /// to be used for an AI Agent type on a session or assistant.
    /// </summary>
    public partial class AIAgentConfigurationData
    {
        private string _aiAgentId;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property AiAgentId. 
        /// <para>
        /// The ID of the AI Agent to be configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AiAgentId
        {
            get { return this._aiAgentId; }
            set { this._aiAgentId = value; }
        }

        // Check to see if AiAgentId property is set
        internal bool IsSetAiAgentId()
        {
            return this._aiAgentId != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the AI Agent configured for this AI Agent type is enabled. When
        /// this value is omitted or set to true, the configured AI Agent runs; when set to false,
        /// the AI Agent ID is retained but no AI Agent runs for the AI Agent type. Setting this
        /// value to false is currently supported only for the <c>ANSWER_RECOMMENDATION</c> AI
        /// Agent type; other requests to set it to false are rejected with a validation error.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}