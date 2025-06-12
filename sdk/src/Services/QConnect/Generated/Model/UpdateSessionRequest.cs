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
    /// Container for the parameters to the UpdateSession operation.
    /// Updates a session. A session is a contextual container used for generating recommendations.
    /// Amazon Connect updates the existing Amazon Q in Connect session for each contact on
    /// which Amazon Q in Connect is enabled.
    /// </summary>
    public partial class UpdateSessionRequest : AmazonQConnectRequest
    {
        private Dictionary<string, AIAgentConfigurationData> _aiAgentConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, AIAgentConfigurationData>() : null;
        private string _assistantId;
        private string _description;
        private string _sessionId;
        private TagFilter _tagFilter;

        /// <summary>
        /// Gets and sets the property AiAgentConfiguration. 
        /// <para>
        /// The configuration of the AI Agents (mapped by AI Agent Type to AI Agent version) that
        /// should be used by Amazon Q in Connect for this Session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AIAgentConfigurationData> AiAgentConfiguration
        {
            get { return this._aiAgentConfiguration; }
            set { this._aiAgentConfiguration = value; }
        }

        // Check to see if AiAgentConfiguration property is set
        internal bool IsSetAiAgentConfiguration()
        {
            return this._aiAgentConfiguration != null && (this._aiAgentConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session. Can be either the ID or the ARN. URLs cannot contain
        /// the ARN.
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

        /// <summary>
        /// Gets and sets the property TagFilter. 
        /// <para>
        /// An object that can be used to specify Tag conditions.
        /// </para>
        /// </summary>
        public TagFilter TagFilter
        {
            get { return this._tagFilter; }
            set { this._tagFilter = value; }
        }

        // Check to see if TagFilter property is set
        internal bool IsSetTagFilter()
        {
            return this._tagFilter != null;
        }

    }
}