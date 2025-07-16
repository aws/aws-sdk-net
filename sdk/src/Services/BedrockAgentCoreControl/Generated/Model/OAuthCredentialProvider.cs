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
    /// An OAuth credential provider for gateway authentication. This structure contains the
    /// configuration for authenticating with the target endpoint using OAuth.
    /// </summary>
    public partial class OAuthCredentialProvider
    {
        private Dictionary<string, string> _customParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _providerArn;
        private List<string> _scopes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CustomParameters. 
        /// <para>
        /// The custom parameters for the OAuth credential provider. These parameters provide
        /// additional configuration for the OAuth authentication process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public Dictionary<string, string> CustomParameters
        {
            get { return this._customParameters; }
            set { this._customParameters = value; }
        }

        // Check to see if CustomParameters property is set
        internal bool IsSetCustomParameters()
        {
            return this._customParameters != null && (this._customParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OAuth credential provider. This ARN identifies
        /// the provider in Amazon Web Services.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProviderArn
        {
            get { return this._providerArn; }
            set { this._providerArn = value; }
        }

        // Check to see if ProviderArn property is set
        internal bool IsSetProviderArn()
        {
            return this._providerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth scopes for the credential provider. These scopes define the level of access
        /// requested from the OAuth provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
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