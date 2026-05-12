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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for RFC 8693 token exchange.
    /// </summary>
    public partial class TokenExchangeGrantTypeConfigType
    {
        private ActorTokenContentType _actorTokenContent;
        private List<string> _actorTokenScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ActorTokenContent. 
        /// <para>
        /// The content type for the actor token in the token exchange.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActorTokenContentType ActorTokenContent
        {
            get { return this._actorTokenContent; }
            set { this._actorTokenContent = value; }
        }

        // Check to see if ActorTokenContent property is set
        internal bool IsSetActorTokenContent()
        {
            return this._actorTokenContent != null;
        }

        /// <summary>
        /// Gets and sets the property ActorTokenScopes. 
        /// <para>
        /// The scopes for the actor token. Only valid when actorTokenContent is M2M.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ActorTokenScopes
        {
            get { return this._actorTokenScopes; }
            set { this._actorTokenScopes = value; }
        }

        // Check to see if ActorTokenScopes property is set
        internal bool IsSetActorTokenScopes()
        {
            return this._actorTokenScopes != null && (this._actorTokenScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}