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
    /// Container for the parameters to the UpdateAssistantAIAgent operation.
    /// Updates the AI Agent that is set for use by default on an Amazon Q in Connect Assistant.
    /// </summary>
    public partial class UpdateAssistantAIAgentRequest : AmazonQConnectRequest
    {
        private AIAgentType _aiAgentType;
        private string _assistantId;
        private AIAgentConfigurationData _configuration;

        /// <summary>
        /// Gets and sets the property AiAgentType. 
        /// <para>
        /// The type of the AI Agent being updated for use by default on the Amazon Q in Connect
        /// Assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIAgentType AiAgentType
        {
            get { return this._aiAgentType; }
            set { this._aiAgentType = value; }
        }

        // Check to see if AiAgentType property is set
        internal bool IsSetAiAgentType()
        {
            return this._aiAgentType != null;
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
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the AI Agent being updated for use by default on the Amazon Q
        /// in Connect Assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIAgentConfigurationData Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

    }
}