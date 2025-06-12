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
    /// Container for the parameters to the UpdateSession operation.
    /// Updates the metadata or encryption settings of a session. For more information about
    /// sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
    /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
    /// </summary>
    public partial class UpdateSessionRequest : AmazonBedrockAgentRuntimeRequest
    {
        private string _sessionIdentifier;
        private Dictionary<string, string> _sessionMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property SessionIdentifier. 
        /// <para>
        /// The unique identifier of the session to modify. You can specify either the session's
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

        /// <summary>
        /// Gets and sets the property SessionMetadata. 
        /// <para>
        /// A map of key-value pairs containing attributes to be persisted across the session.
        /// For example the user's ID, their language preference, and the type of device they
        /// are using.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> SessionMetadata
        {
            get { return this._sessionMetadata; }
            set { this._sessionMetadata = value; }
        }

        // Check to see if SessionMetadata property is set
        internal bool IsSetSessionMetadata()
        {
            return this._sessionMetadata != null && (this._sessionMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}