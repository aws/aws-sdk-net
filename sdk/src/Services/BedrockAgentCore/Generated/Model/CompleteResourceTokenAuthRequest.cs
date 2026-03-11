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
    /// Container for the parameters to the CompleteResourceTokenAuth operation.
    /// Confirms the user authentication session for obtaining OAuth2.0 tokens for a resource.
    /// </summary>
    public partial class CompleteResourceTokenAuthRequest : AmazonBedrockAgentCoreRequest
    {
        private string _sessionUri;
        private UserIdentifier _userIdentifier;

        /// <summary>
        /// Gets and sets the property SessionUri. 
        /// <para>
        /// Unique identifier for the user's authentication session for retrieving OAuth2 tokens.
        /// This ID tracks the authorization flow state across multiple requests and responses
        /// during the OAuth2 authentication process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string SessionUri
        {
            get { return this._sessionUri; }
            set { this._sessionUri = value; }
        }

        // Check to see if SessionUri property is set
        internal bool IsSetSessionUri()
        {
            return this._sessionUri != null;
        }

        /// <summary>
        /// Gets and sets the property UserIdentifier. 
        /// <para>
        /// The OAuth2.0 token or user ID that was used to generate the workload access token
        /// used for initiating the user authorization flow to retrieve OAuth2.0 tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserIdentifier UserIdentifier
        {
            get { return this._userIdentifier; }
            set { this._userIdentifier = value; }
        }

        // Check to see if UserIdentifier property is set
        internal bool IsSetUserIdentifier()
        {
            return this._userIdentifier != null;
        }

    }
}