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
    /// The identity provider configuration used to authenticate end users to the consent
    /// portal.
    /// </summary>
    public partial class ConsentPortalIdpConfig
    {
        private string _audience;
        private string _credentialProviderArn;
        private List<string> _scopes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Audience. 
        /// <para>
        /// The audience value that the consent portal includes when requesting tokens from the
        /// identity provider.
        /// </para>
        /// </summary>
        public string Audience
        {
            get { return this._audience; }
            set { this._audience = value; }
        }

        // Check to see if Audience property is set
        internal bool IsSetAudience()
        {
            return this._audience != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OAuth2 credential provider used to authenticate
        /// end users to the consent portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CredentialProviderArn
        {
            get { return this._credentialProviderArn; }
            set { this._credentialProviderArn = value; }
        }

        // Check to see if CredentialProviderArn property is set
        internal bool IsSetCredentialProviderArn()
        {
            return this._credentialProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth2 scopes that the consent portal requests when authenticating end users.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null && (this._scopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}