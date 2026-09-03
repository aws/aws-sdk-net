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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the GetClientToken operation.
    /// Issues an access token for machine-to-machine (M2M) authorization. Your app client
    /// provides its client ID and secret, and receives an access token that authorizes requests
    /// to your resource servers. <c>GetClientToken</c> provides the same functionality as
    /// the OAuth2 client-credentials grant; both authorize an application rather than a user.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must configure the app client with a client secret and
    /// enable the <c>ALLOW_CLIENT_TOKEN_AUTH</c> authentication flow. The <c>ALLOW_CLIENT_TOKEN_AUTH</c>
    /// flow is mutually exclusive with user authentication flows. It must be the only authentication
    /// flow that you configure for the app client. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-define-resource-servers.html">Scopes,
    /// M2M, and resource servers</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you can't use IAM credentials to authorize
    /// requests, and you can't grant IAM permissions in policies. For more information about
    /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetClientTokenRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _clientId;
        private Dictionary<string, string> _clientMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _scopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _secret;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client that requests the access token. The app client must have
        /// a client secret and the <c>ALLOW_CLIENT_TOKEN_AUTH</c> authentication flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientMetadata. 
        /// <para>
        /// A map of custom key-value pairs that you can provide as input for any custom workflows
        /// that this action triggers. You create custom workflows by assigning Lambda functions
        /// to user pool triggers.
        /// </para>
        ///  
        /// <para>
        /// When Amazon Cognito invokes any of these functions, it passes a JSON payload, which
        /// the function receives as input. This payload contains a <c>clientMetadata</c> attribute
        /// that provides the data that you assigned to the ClientMetadata parameter in your request.
        /// In your function code, you can process the <c>clientMetadata</c> value to enhance
        /// your workflow for your specific needs.
        /// </para>
        ///  
        /// <para>
        /// To review the Lambda trigger types that Amazon Cognito invokes at runtime with API
        /// requests, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-working-with-lambda-triggers.html#lambda-triggers-by-event">
        /// Connecting API actions to Lambda triggers</a> in the <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you use the <c>ClientMetadata</c> parameter, note that Amazon Cognito won't do
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Store the <c>ClientMetadata</c> value. This data is available only to Lambda triggers
        /// that are assigned to a user pool to support custom workflows. If your user pool configuration
        /// doesn't include triggers, the <c>ClientMetadata</c> parameter serves no purpose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Validate the <c>ClientMetadata</c> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Encrypt the <c>ClientMetadata</c> value. Don't send sensitive information in this
        /// parameter.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ClientMetadata
        {
            get { return this._clientMetadata; }
            set { this._clientMetadata = value; }
        }

        // Check to see if ClientMetadata property is set
        internal bool IsSetClientMetadata()
        {
            return this._clientMetadata != null && (this._clientMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The custom scopes to authorize in the access token, in the format <c>resource-server-identifier/scope-name</c>.
        /// Each scope must belong to a resource server in your user pool. If you don't specify
        /// any scopes, Amazon Cognito authorizes the scopes that are configured for the app client.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
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

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// An active secret for the app client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=24, Max=64)]
        public string Secret
        {
            get { return this._secret; }
            set { this._secret = value; }
        }

        // Check to see if Secret property is set
        internal bool IsSetSecret()
        {
            return this._secret != null;
        }

    }
}