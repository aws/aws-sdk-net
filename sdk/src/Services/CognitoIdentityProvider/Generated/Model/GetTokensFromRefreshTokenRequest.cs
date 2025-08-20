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
    /// Container for the parameters to the GetTokensFromRefreshToken operation.
    /// Given a refresh token, issues new ID, access, and optionally refresh tokens for the
    /// user who owns the submitted token. This operation issues a new refresh token and invalidates
    /// the original refresh token after an optional grace period when refresh token rotation
    /// is enabled. If refresh token rotation is disabled, issues new ID and access tokens
    /// only.
    /// </summary>
    public partial class GetTokensFromRefreshTokenRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _clientId;
        private Dictionary<string, string> _clientMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _clientSecret;
        private string _deviceKey;
        private string _refreshToken;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The app client that issued the refresh token to the user who wants to request new
        /// tokens.
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
        /// A map of custom key-value pairs that you can provide as input for certain custom workflows
        /// that this action triggers.
        /// </para>
        ///  
        /// <para>
        /// You create custom workflows by assigning Lambda functions to user pool triggers. When
        /// you use the <c>GetTokensFromRefreshToken</c> API action, Amazon Cognito invokes the
        /// Lambda function the pre token generation trigger.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-working-with-aws-lambda-triggers.html">
        /// Using Lambda triggers</a> in the <i>Amazon Cognito Developer Guide</i>.
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
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The client secret of the requested app client, if the client has a secret.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceKey. 
        /// <para>
        /// When you enable device remembering, Amazon Cognito issues a device key that you can
        /// use for device authentication that bypasses multi-factor authentication (MFA). To
        /// implement <c>GetTokensFromRefreshToken</c> in a user pool with device remembering,
        /// you must capture the device key from the initial authentication request. If your application
        /// doesn't provide the key of a registered device, Amazon Cognito issues a new one. You
        /// must provide the confirmed device key in this request if device remembering is enabled
        /// in your user pool.
        /// </para>
        ///  
        /// <para>
        /// For more information about device remembering, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
        /// with devices</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
        public string DeviceKey
        {
            get { return this._deviceKey; }
            set { this._deviceKey = value; }
        }

        // Check to see if DeviceKey property is set
        internal bool IsSetDeviceKey()
        {
            return this._deviceKey != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// A valid refresh token that can authorize the request for new tokens. When refresh
        /// token rotation is active in the requested app client, this token is invalidated after
        /// the request is complete and after an optional grace period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string RefreshToken
        {
            get { return this._refreshToken; }
            set { this._refreshToken = value; }
        }

        // Check to see if RefreshToken property is set
        internal bool IsSetRefreshToken()
        {
            return this._refreshToken != null;
        }

    }
}