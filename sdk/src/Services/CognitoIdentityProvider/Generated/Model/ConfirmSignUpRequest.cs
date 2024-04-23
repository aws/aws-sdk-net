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
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the ConfirmSignUp operation.
    /// This public API operation provides a code that Amazon Cognito sent to your user when
    /// they signed up in your user pool via the <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SignUp.html">SignUp</a>
    /// API operation. After your user enters their code, they confirm ownership of the email
    /// address or phone number that they provided, and their user account becomes active.
    /// Depending on your user pool configuration, your users will receive their confirmation
    /// code in an email or SMS message.
    /// 
    ///  
    /// <para>
    /// Local users who signed up in your user pool are the only type of user who can confirm
    /// sign-up with a code. Users who federate through an external identity provider (IdP)
    /// have already been confirmed by their IdP. Administrator-created users, users created
    /// with the <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminCreateUser.html">AdminCreateUser</a>
    /// API operation, confirm their accounts when they respond to their invitation email
    /// message and choose a password. They do not receive a confirmation code. Instead, they
    /// receive a temporary password.
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
    public partial class ConfirmSignUpRequest : AmazonCognitoIdentityProviderRequest
    {
        private AnalyticsMetadataType _analyticsMetadata;
        private string _clientId;
        private Dictionary<string, string> _clientMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _confirmationCode;
        private bool? _forceAliasCreation;
        private string _secretHash;
        private UserContextDataType _userContextData;
        private string _username;

        /// <summary>
        /// Gets and sets the property AnalyticsMetadata. 
        /// <para>
        /// The Amazon Pinpoint analytics metadata for collecting metrics for <c>ConfirmSignUp</c>
        /// calls.
        /// </para>
        /// </summary>
        public AnalyticsMetadataType AnalyticsMetadata
        {
            get { return this._analyticsMetadata; }
            set { this._analyticsMetadata = value; }
        }

        // Check to see if AnalyticsMetadata property is set
        internal bool IsSetAnalyticsMetadata()
        {
            return this._analyticsMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client associated with the user pool.
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
        /// that this action triggers.
        /// </para>
        ///  
        /// <para>
        /// You create custom workflows by assigning Lambda functions to user pool triggers. When
        /// you use the ConfirmSignUp API action, Amazon Cognito invokes the function that is
        /// assigned to the <i>post confirmation</i> trigger. When Amazon Cognito invokes this
        /// function, it passes a JSON payload, which the function receives as input. This payload
        /// contains a <c>clientMetadata</c> attribute, which provides the data that you assigned
        /// to the ClientMetadata parameter in your ConfirmSignUp request. In your function code
        /// in Lambda, you can process the <c>clientMetadata</c> value to enhance your workflow
        /// for your specific needs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-working-with-aws-lambda-triggers.html">
        /// Customizing user pool Workflows with Lambda Triggers</a> in the <i>Amazon Cognito
        /// Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you use the ClientMetadata parameter, remember that Amazon Cognito won't do the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Store the ClientMetadata value. This data is available only to Lambda triggers that
        /// are assigned to a user pool to support custom workflows. If your user pool configuration
        /// doesn't include triggers, the ClientMetadata parameter serves no purpose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Validate the ClientMetadata value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Encrypt the ClientMetadata value. Don't use Amazon Cognito to provide sensitive information.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Gets and sets the property ConfirmationCode. 
        /// <para>
        /// The confirmation code sent by a user's request to confirm registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ConfirmationCode
        {
            get { return this._confirmationCode; }
            set { this._confirmationCode = value; }
        }

        // Check to see if ConfirmationCode property is set
        internal bool IsSetConfirmationCode()
        {
            return this._confirmationCode != null;
        }

        /// <summary>
        /// Gets and sets the property ForceAliasCreation. 
        /// <para>
        /// Boolean to be specified to force user confirmation irrespective of existing alias.
        /// By default set to <c>False</c>. If this parameter is set to <c>True</c> and the phone
        /// number/email used for sign up confirmation already exists as an alias with a different
        /// user, the API call will migrate the alias from the previous user to the newly created
        /// user being confirmed. If set to <c>False</c>, the API will throw an <b>AliasExistsException</b>
        /// error.
        /// </para>
        /// </summary>
        public bool ForceAliasCreation
        {
            get { return this._forceAliasCreation.GetValueOrDefault(); }
            set { this._forceAliasCreation = value; }
        }

        // Check to see if ForceAliasCreation property is set
        internal bool IsSetForceAliasCreation()
        {
            return this._forceAliasCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretHash. 
        /// <para>
        /// A keyed-hash message authentication code (HMAC) calculated using the secret key of
        /// a user pool client and username plus the client ID in the message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string SecretHash
        {
            get { return this._secretHash; }
            set { this._secretHash = value; }
        }

        // Check to see if SecretHash property is set
        internal bool IsSetSecretHash()
        {
            return this._secretHash != null;
        }

        /// <summary>
        /// Gets and sets the property UserContextData. 
        /// <para>
        /// Contextual data about your user session, such as the device fingerprint, IP address,
        /// or location. Amazon Cognito advanced security evaluates the risk of an authentication
        /// event based on the context that your app generates and passes to Amazon Cognito when
        /// it makes API requests.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public UserContextDataType UserContextData
        {
            get { return this._userContextData; }
            set { this._userContextData = value; }
        }

        // Check to see if UserContextData property is set
        internal bool IsSetUserContextData()
        {
            return this._userContextData != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the user that you want to query or modify. The value of this parameter
        /// is typically your user's username, but it can be any of their alias attributes. If
        /// <c>username</c> isn't an alias attribute in your user pool, this value must be the
        /// <c>sub</c> of a local user or the username of a user from a third-party IdP.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new NullSigner();
        }
    }
}